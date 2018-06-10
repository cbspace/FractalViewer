using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace FractalViewer
{
    class FractalGen
    {
        private int NO_OF_THREADS;

        public PictureBox PB;
        public Bitmap DrawArea;

        private WPart[] WpArray;

        public fractalConfig FC;

        public bool Calculating;

        // Constructor
        public FractalGen(byte threads, PictureBox PB, fractalConfig FC)
        {
            NO_OF_THREADS = threads;
            this.PB = PB;
            DrawArea = new Bitmap(FC.width, FC.height);
            PB.Image = DrawArea;
            this.FC = FC;
        }
        
        // Create the threads
        public void Generate()
        {
            // Create array of WParts
            WpArray = new WPart[NO_OF_THREADS];

            // Create array of ManualResetEvents
            ManualResetEvent[] doneEvents = new ManualResetEvent[NO_OF_THREADS]; 

            double x_step = (FC.fractalArea.x2 - FC.fractalArea.x1) / NO_OF_THREADS;

            for (int i = 0; i < NO_OF_THREADS; i++)
            {
                doneEvents[i] = new ManualResetEvent(false);

                FractalArea fa_temp = new FractalArea
                {
                    x1 = FC.fractalArea.x1 + x_step * i,
                    x2 = FC.fractalArea.x1 + x_step * i + x_step,

                    y1 = FC.fractalArea.y1,
                    y2 = FC.fractalArea.y2
                };

                WPart WP = new WPart(FC.width /NO_OF_THREADS, FC.height, FC.fractalType, FC.w_max, fa_temp, FC.dx, FC.dy, doneEvents[i]);
                WpArray[i] = WP;
                ThreadPool.QueueUserWorkItem(WP.ThreadPoolCallback,i);
            }

            Calculating = true;

            // Wait for all threads in pool to complete
            foreach (var e in doneEvents)
                e.WaitOne();

            Calculating = false;
            Application.DoEvents();

            Draw();
            PB.Image = DrawArea;
        }

        //Colorise and display the fractal
        public void Draw()
        {
            int wi;

            for (int i = 0; i < NO_OF_THREADS; i++)
            {
          
                WPart WP = WpArray[i];

                for (int Xcount = 0; Xcount < WP.width; Xcount++)
                {
                    for (int Ycount = 0; Ycount < WP.height; Ycount++)
                    {
                        // Draw pixel
                        wi = WP.w_data[Xcount, Ycount];

                        if (wi < FC.w_max)
                        {
                            const byte alpha = 255;
                            byte red = Convert.ToByte(FC.R * wi / FC.w_max);
                            byte green = Convert.ToByte(FC.G * wi / FC.w_max);
                            byte blue = Convert.ToByte(FC.B * wi / FC.w_max);
                            byte[] color = { alpha, red, green, blue };
                            if (BitConverter.IsLittleEndian)
                                Array.Reverse(color);
                            DrawArea.SetPixel(Xcount + WP.width*i, Ycount, Color.FromArgb(BitConverter.ToInt32(color, 0)));
                        }
                        else
                        {
                            DrawArea.SetPixel(Xcount + WP.width*i, Ycount, Color.Black);
                        }
                    }
                }

            }
        }

        public void Clear()
        {
            // Clear image area and set to black
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            g.Clear(Color.Black);
            g.Dispose();

            // Draw image to picturebox
            PB.Image = DrawArea;
        }

    }

    // W Part Class
    public class WPart
    {
        public int[,] w_data;
        public int type;
        public int width;
        public int height;
        public int w_max;
        private FractalArea fa;
        public double dx, dy;
        public ManualResetEvent doneEvent;

        public WPart(int width, int height, int type, int w_max, FractalArea fa, double dx, double dy, ManualResetEvent de)
        {
            this.width = width;
            this.height = height;
            this.type = type;
            this.w_max = w_max;
            this.fa = fa;
            this.dx = dx;
            this.dy = dy;
            w_data = new int[width, height];
            doneEvent = de;
        }

        // Assign work to the threads
        public void ThreadPoolCallback(Object threadContext)
        {
            Calculate();
            doneEvent.Set();
        }

        // Calculate a portion of the w_map and store in array
        public void Calculate()
        {
            int w;
            double cr, ci, zr, zi, zr2, zi2, zrt;

            if (type == 0 || type == 1)
            {
                // Loop through each pixel 
                for (int Xcount = 0; Xcount < width; Xcount++)
                {
                    for (int Ycount = 0; Ycount < height; Ycount++)
                    {
                        cr = fa.x1 + dx * Xcount;
                        ci = fa.y1 + dy * Ycount;

                        w = 0;
                        zr = 0;
                        zi = 0;
                        zr2 = 0;
                        zi2 = 0;

                        // Fractal calculation loop
                        while (((zr2 + zi2) < 4) && (w < w_max))
                        {
                            zrt = zr2 - zi2 + cr;
                            zi = (type == 0)? 2 * zr * zi + ci : 2 * Math.Abs(zr * zi) + ci;
                            zr = zrt;
                            zr2 = Math.Pow(zr, 2);
                            zi2 = Math.Pow(zi, 2);
                            w++;
                        }

                        // Store w
                        if (w < w_max)
                        {
                            w_data[Xcount, Ycount] = (w < w_max)? w:w_max;
                        }
                    }
                }

            }
        }  
    }

    // A fractal area
    public class FractalArea
    {
        public double x1, x2, y1, y2;

        public FractalArea() { }

        public FractalArea(double x1, double x2, double y1, double y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

    }

    // Stores fractal config
    // Type
    // W_Max
    // Location (current FractalArea)
    // Colours
    public class fractalConfig
    {
        public int width = 1350, height = 960;
        public int fractalType;
        public int w_max = 500;
        public FractalArea fractalArea;
        public double dx, dy;
        public byte R = 0, G = 255, B = 0;

        public fractalConfig()
        {

        }

        public void changeFractal(int fractalType)
        {
            this.fractalType = fractalType;
            setDefaultArea();
            setDxDy();
        }

        public void setDxDy()
        {
            dx = (fractalArea.x2 - fractalArea.x1) / width;
            dy = (fractalArea.y2 - fractalArea.y1) / height;
        }

        public void setDefaultArea()
        {
            fractalArea = Fractals.getDefaultArea(fractalType);
        }
    }

    // Store fractal details
    // Names
    // Default X an Y view range
    public static class Fractals
    {
        // Fractal names and default values
        public static IDictionary<int, string> fractal_types = new Dictionary<int, string>()
        {
            { 0,"Mandelbrot Fractal" },
            { 1,"Burning Ship Fractal" },
        };

        // Return the fractal name
        public static string getFractalNamebyID(int fracID)
        {
            return fractal_types[fracID];
        }

        // Return the default fractal area
        public static FractalArea getDefaultArea(int fracId)
        {
            switch (fracId)
            {
                case 0:
                    return new FractalArea(-2.0, 1.0, 1.0, -1.0);
                case 1:
                    return new FractalArea(1.0, -2.0, -2.0, 1.0);
                default:
                    return new FractalArea(0.0, 0.0, 0.0, 0.0);
            }
        }

    }
}


// Backlog
//
// Implement Burning ship fractal
// Make the colour change function work
// Change from Double to Decimal
