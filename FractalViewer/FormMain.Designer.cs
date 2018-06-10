namespace FractalViewer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxZoom = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelCalculating = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboFractalType = new System.Windows.Forms.ComboBox();
            this.textBoxW = new System.Windows.Forms.TextBox();
            this.numericRed = new System.Windows.Forms.NumericUpDown();
            this.numericGreen = new System.Windows.Forms.NumericUpDown();
            this.numericBlue = new System.Windows.Forms.NumericUpDown();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 960);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBoxZoom
            // 
            this.pictureBoxZoom.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxZoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxZoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxZoom.Location = new System.Drawing.Point(1370, 519);
            this.pictureBoxZoom.Name = "pictureBoxZoom";
            this.pictureBoxZoom.Size = new System.Drawing.Size(240, 198);
            this.pictureBoxZoom.TabIndex = 7;
            this.pictureBoxZoom.TabStop = false;
            this.pictureBoxZoom.Visible = false;
            this.pictureBoxZoom.Click += new System.EventHandler(this.pictureBoxZoom_Click);
            this.pictureBoxZoom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxZoom_MouseMove);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar.Location = new System.Drawing.Point(3, 185);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(75, 15);
            this.progressBar.TabIndex = 5;
            // 
            // labelCalculating
            // 
            this.labelCalculating.AutoSize = true;
            this.labelCalculating.Location = new System.Drawing.Point(3, 169);
            this.labelCalculating.Name = "labelCalculating";
            this.labelCalculating.Size = new System.Drawing.Size(0, 13);
            this.labelCalculating.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(3, 143);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(3, 114);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 85);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(3, 56);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate!";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.comboFractalType);
            this.flowLayoutPanel1.Controls.Add(this.textBoxW);
            this.flowLayoutPanel1.Controls.Add(this.generateButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.clearButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Controls.Add(this.labelCalculating);
            this.flowLayoutPanel1.Controls.Add(this.progressBar);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1364, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(124, 219);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // comboFractalType
            // 
            this.comboFractalType.FormattingEnabled = true;
            this.comboFractalType.Location = new System.Drawing.Point(3, 3);
            this.comboFractalType.Name = "comboFractalType";
            this.comboFractalType.Size = new System.Drawing.Size(109, 21);
            this.comboFractalType.TabIndex = 7;
            this.comboFractalType.SelectedIndexChanged += new System.EventHandler(this.comboFractalType_SelectedIndexChanged);
            // 
            // textBoxW
            // 
            this.textBoxW.Location = new System.Drawing.Point(3, 30);
            this.textBoxW.Name = "textBoxW";
            this.textBoxW.Size = new System.Drawing.Size(38, 20);
            this.textBoxW.TabIndex = 8;
            this.textBoxW.TextChanged += new System.EventHandler(this.textBoxW_TextChanged);
            // 
            // numericRed
            // 
            this.numericRed.Location = new System.Drawing.Point(1386, 243);
            this.numericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed.Name = "numericRed";
            this.numericRed.Size = new System.Drawing.Size(41, 20);
            this.numericRed.TabIndex = 8;
            this.numericRed.ValueChanged += new System.EventHandler(this.numericRed_ValueChanged);
            // 
            // numericGreen
            // 
            this.numericGreen.Location = new System.Drawing.Point(1386, 269);
            this.numericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen.Name = "numericGreen";
            this.numericGreen.Size = new System.Drawing.Size(41, 20);
            this.numericGreen.TabIndex = 9;
            this.numericGreen.ValueChanged += new System.EventHandler(this.numericGreen_ValueChanged);
            // 
            // numericBlue
            // 
            this.numericBlue.Location = new System.Drawing.Point(1386, 295);
            this.numericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue.Name = "numericBlue";
            this.numericBlue.Size = new System.Drawing.Size(41, 20);
            this.numericBlue.TabIndex = 10;
            this.numericBlue.ValueChanged += new System.EventHandler(this.numericBlue_ValueChanged);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(1370, 250);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(15, 13);
            this.labelRed.TabIndex = 11;
            this.labelRed.Text = "R";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(1371, 275);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(15, 13);
            this.labelGreen.TabIndex = 12;
            this.labelGreen.Text = "G";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(1371, 301);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(14, 13);
            this.labelBlue.TabIndex = 13;
            this.labelBlue.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1370, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Location";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(1400, 386);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(106, 20);
            this.textBoxX1.TabIndex = 18;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(1400, 438);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(106, 20);
            this.textBoxX2.TabIndex = 19;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(1400, 412);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(106, 20);
            this.textBoxY1.TabIndex = 20;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(1400, 464);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(106, 20);
            this.textBoxY2.TabIndex = 21;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(1374, 389);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(20, 13);
            this.labelX1.TabIndex = 22;
            this.labelX1.Text = "X1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(1374, 441);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(20, 13);
            this.labelX2.TabIndex = 23;
            this.labelX2.Text = "X2";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(1374, 415);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(20, 13);
            this.labelY1.TabIndex = 24;
            this.labelY1.Text = "Y1";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(1374, 467);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(20, 13);
            this.labelY2.TabIndex = 25;
            this.labelY2.Text = "Y2";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(1373, 331);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 26;
            this.colorButton.Text = "Colour";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1373, 490);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 975);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.numericBlue);
            this.Controls.Add(this.numericGreen);
            this.Controls.Add(this.numericRed);
            this.Controls.Add(this.pictureBoxZoom);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMain";
            this.Text = "Fractal Viewer by Craig Brennan V2.10";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoom)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label labelCalculating;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBoxZoom;
        private System.Windows.Forms.ComboBox comboFractalType;
        private System.Windows.Forms.TextBox textBoxW;
        private System.Windows.Forms.NumericUpDown numericRed;
        private System.Windows.Forms.NumericUpDown numericGreen;
        private System.Windows.Forms.NumericUpDown numericBlue;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button buttonBack;

    }
}

