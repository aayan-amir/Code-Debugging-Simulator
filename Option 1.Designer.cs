namespace Code_Debugging
{
    partial class Form3
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
            label2 = new Label();
            richTextBoxEdit1 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            label1 = new Label();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            textBox1 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(53, 195);
            label2.Name = "label2";
            label2.Size = new Size(508, 64);
            label2.TabIndex = 6;
            label2.Text = "Click The Button Below To \r\nGenerate A Faulty Code";
            // 
            // richTextBoxEdit1
            // 
            richTextBoxEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxEdit1.AutoWordSelection = false;
            richTextBoxEdit1.BackColor = Color.Transparent;
            richTextBoxEdit1.BaseColor = Color.Transparent;
            richTextBoxEdit1.BorderColor = Color.Lime;
            richTextBoxEdit1.EdgeColor = Color.Lime;
            richTextBoxEdit1.Font = new Font("OCR A Extended", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxEdit1.ForeColor = Color.Lime;
            richTextBoxEdit1.Location = new Point(753, 195);
            richTextBoxEdit1.Name = "richTextBoxEdit1";
            richTextBoxEdit1.ReadOnly = false;
            richTextBoxEdit1.Size = new Size(562, 387);
            richTextBoxEdit1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            richTextBoxEdit1.TabIndex = 11;
            richTextBoxEdit1.TextBackColor = Color.Black;
            richTextBoxEdit1.TextBorderStyle = BorderStyle.Fixed3D;
            richTextBoxEdit1.TextFont = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxEdit1.WordWrap = true;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Black;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = SystemColors.WindowFrame;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.White;
            nightControlBox1.DisableMinimizeColor = Color.White;
            nightControlBox1.EnableCloseColor = Color.White;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.White;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.White;
            nightControlBox1.Location = new Point(1245, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 13;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 7F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.Black;
            cyberButton1.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.ColorBackground_Pen = Color.Lime;
            cyberButton1.ColorLighting = Color.Lime;
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(255, 128, 0);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.Lime;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.Lime;
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(186, 643);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(165, 63);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 14;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Generate Code";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += cyberButton1_Click;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 7F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.Black;
            cyberButton2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.ColorBackground_Pen = Color.Lime;
            cyberButton2.ColorLighting = Color.Lime;
            cyberButton2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.Lime;
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.Lime;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Arial", 11F);
            cyberButton2.ForeColor = Color.Lime;
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(946, 643);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(165, 63);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 15;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Submit";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            cyberButton2.Click += cyberButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("OCR A Extended", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(245, 12);
            label1.Name = "label1";
            label1.Size = new Size(837, 104);
            label1.TabIndex = 16;
            label1.Text = "Fix The Code!";
            // 
            // cyberButton3
            // 
            cyberButton3.Alpha = 20;
            cyberButton3.BackColor = Color.Transparent;
            cyberButton3.Background = true;
            cyberButton3.Background_WidthPen = 7F;
            cyberButton3.BackgroundPen = true;
            cyberButton3.ColorBackground = Color.Black;
            cyberButton3.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            cyberButton3.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.ColorBackground_Pen = Color.Lime;
            cyberButton3.ColorLighting = Color.Black;
            cyberButton3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton3.Effect_1 = true;
            cyberButton3.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton3.Effect_1_Transparency = 25;
            cyberButton3.Effect_2 = true;
            cyberButton3.Effect_2_ColorBackground = Color.White;
            cyberButton3.Effect_2_Transparency = 20;
            cyberButton3.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cyberButton3.ForeColor = Color.Lime;
            cyberButton3.Lighting = false;
            cyberButton3.LinearGradient_Background = false;
            cyberButton3.LinearGradientPen = false;
            cyberButton3.Location = new Point(46, 37);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(167, 50);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 17;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "Back To Menu";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            cyberButton3.Click += cyberButton3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(508, 689);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 26);
            textBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(493, 643);
            label3.Name = "label3";
            label3.Size = new Size(299, 32);
            label3.TabIndex = 19;
            label3.Text = "Enter Your Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = Properties.Resources.aa1;
            pictureBox1.Image = Properties.Resources.aaaaaaa;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-127, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1526, 137);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1366, 786);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(cyberButton3);
            Controls.Add(label1);
            Controls.Add(cyberButton2);
            Controls.Add(cyberButton1);
            Controls.Add(nightControlBox1);
            Controls.Add(richTextBoxEdit1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ReaLTaiizor.Controls.RichTextBoxEdit richTextBoxEdit1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private Label label1;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private TextBox textBox1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}