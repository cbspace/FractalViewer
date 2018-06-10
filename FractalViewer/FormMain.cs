using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace FractalViewer
{
    public partial class FormMain : Form
    {
        // FractalGen object
        FractalGen FG;

        // FractalConfig object
        fractalConfig FC;

        // Initialize form
        public FormMain()
        {
            // Initialize
            InitializeComponent();

            // Create FractalConfig
            FC = new fractalConfig();
        }

        // Form Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Initialise Combo Box
            foreach (KeyValuePair<int, string> item in Fractals.fractal_types)
            {
                comboFractalType.Items.Add(item.Value);
            }

            // Set the combo box to the default value
            comboFractalType.SelectedIndex = 1;

            // Initialise W Text Box
            textBoxW.Text = FC.w_max.ToString();

            // Set parent so that transparency works correctly
            pictureBoxZoom.Parent = pictureBox1;

            // Initialise default fractal colours
            numericRed.Value = FC.R;
            numericGreen.Value = FC.G;
            numericBlue.Value = FC.B;

            // Create FractalGen
            FG = new FractalGen(25, pictureBox1, FC);

            // Clear the display area
            FG.Clear();
        }

        // Close Form
        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Generate Button Click
        private void generateButton_Click(object sender, EventArgs e)
        {
            // Initialise progress bar
            progressBar.Maximum = FC.width;

            // Display Calculating Text
            labelCalculating.Text = "Calculating...";

            // Generate the fractal
            FG.Generate();

            // Hide Calculating Text
            labelCalculating.Text="";

            // Reset progress bar
            progressBar.Value = 0;
        }

        // Click on Zoom Image
        private void pictureBoxZoom_Click(object sender, EventArgs e)
        {
            // Initialise progress bar
            progressBar.Maximum = FC.width;

            // Display Calculating Text
            labelCalculating.Text = "Calculating...";

            // Change the fractalArea
            FC.fractalArea = new FractalArea
            {
                x1 = FC.fractalArea.x1 + FC.dx * (pictureBoxZoom.Location.X - pictureBox1.Location.X),
                x2 = FC.fractalArea.x1 + FC.dx * (pictureBoxZoom.Location.X - pictureBox1.Location.X) + FC.dx * pictureBoxZoom.Width,

                y1 = FC.fractalArea.y1 + FC.dy * (pictureBoxZoom.Location.Y - pictureBox1.Location.Y),
                y2 = FC.fractalArea.y1 + FC.dy * (pictureBoxZoom.Location.Y - pictureBox1.Location.Y) + FC.dy * pictureBoxZoom.Height
            };
            FC.setDxDy();

            // Generate the fractal
            FG.Generate();

            // Hide Calculating Text
            labelCalculating.Text = "";

            // Reset progress bar
            progressBar.Value = 0;
        }

        // Clear the image
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset the fractalArea
            FC.fractalArea = Fractals.getDefaultArea(FC.fractalType);
            FC.setDxDy();

            // Clear the display area
            FG.Clear();
        }

        // Save the image
        private void saveButton_Click(object sender, EventArgs e)
        {
            ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID 
            // for the Quality parameter category.
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object. 
            // An EncoderParameters object has an array of EncoderParameter 
            // objects. In this case, there is only one 
            // EncoderParameter object in the array.
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 100L);
            myEncoderParameters.Param[0] = myEncoderParameter;
            FG.DrawArea.Save("C:\\Users\\Craig\\Pictures\\Fractal.jpg", jgpEncoder, myEncoderParameters);
        }

        // Get the encoder
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        // Move the box
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxZoom.Left = e.X - pictureBoxZoom.Width / 2;
            pictureBoxZoom.Top = e.Y - pictureBoxZoom.Height / 2;
        }

        // Update W max value
        private void textBoxW_TextChanged(object sender, EventArgs e)
        {
            FC.w_max = Convert.ToInt32(textBoxW.Text);
        }

        // Hid zoom box when mouse is not on image
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxZoom.Visible = false;
        }

        // Show zoom box when mouse enters image
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxZoom.Visible = true;
        }

        // Move the zoom box
        private void pictureBoxZoom_MouseMove(object sender, MouseEventArgs e)
        {
            if (!FG.Calculating)
            {
                pictureBoxZoom.Left += (e.X - pictureBoxZoom.Width / 2);
                pictureBoxZoom.Top += (e.Y - pictureBoxZoom.Height / 2); 
            }                 
        }

        // Color Button clock
        private void colorButton_Click(object sender, EventArgs e)
        {
            // Display the color dialogue
            DialogResult result = colorDialog1.ShowDialog();

            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                numericRed.Value = colorDialog1.Color.R;
                numericGreen.Value = colorDialog1.Color.G;
                numericBlue.Value = colorDialog1.Color.B;
            }
        }

        // Change the fractal type and re-calculate fractalArea
        private void comboFractalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FC.changeFractal(comboFractalType.SelectedIndex);
        }

        // Draw the previous view
        private void buttonBack_Click(object sender, EventArgs e)
        {

        }

        // Update Red Value
        private void numericRed_ValueChanged(object sender, EventArgs e)
        {
            FC.R = Convert.ToByte(numericRed.Value);
        }

        // Update Green Value
        private void numericGreen_ValueChanged(object sender, EventArgs e)
        {
            FC.G = Convert.ToByte(numericGreen.Value);
        }

        // Update Blue Value
        private void numericBlue_ValueChanged(object sender, EventArgs e)
        {
            FC.B = Convert.ToByte(numericBlue.Value);
        }
    }
}
