namespace Code_Debugging
{
    partial class Form2
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
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            btnSubmit = new ReaLTaiizor.Controls.CyberButton();
            btnNext = new ReaLTaiizor.Controls.CyberButton();
            lblCode = new ReaLTaiizor.Controls.NightLabel();
            txtAnswer = new ReaLTaiizor.Controls.CrownTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("OCR A Extended", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(237, 47);
            label1.Name = "label1";
            label1.Size = new Size(966, 83);
            label1.TabIndex = 17;
            label1.Text = "Fill In The Blanks!";
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
            nightControlBox1.Location = new Point(1225, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 19;
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
            cyberButton3.ColorLighting = Color.FromArgb(29, 200, 238);
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
            cyberButton3.Location = new Point(45, 66);
            cyberButton3.Margin = new Padding(3, 4, 3, 4);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(160, 47);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 20;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "Back To Menu";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            cyberButton3.Click += cyberButton3_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Alpha = 20;
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.Background = true;
            btnSubmit.Background_WidthPen = 7F;
            btnSubmit.BackgroundPen = true;
            btnSubmit.ColorBackground = Color.Black;
            btnSubmit.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnSubmit.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnSubmit.ColorBackground_Pen = Color.Lime;
            btnSubmit.ColorLighting = Color.Lime;
            btnSubmit.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSubmit.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSubmit.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSubmit.Effect_1 = true;
            btnSubmit.Effect_1_ColorBackground = Color.FromArgb(0, 192, 0);
            btnSubmit.Effect_1_Transparency = 25;
            btnSubmit.Effect_2 = true;
            btnSubmit.Effect_2_ColorBackground = Color.White;
            btnSubmit.Effect_2_Transparency = 20;
            btnSubmit.Font = new Font("Arial", 11F);
            btnSubmit.ForeColor = Color.Lime;
            btnSubmit.Lighting = false;
            btnSubmit.LinearGradient_Background = false;
            btnSubmit.LinearGradientPen = false;
            btnSubmit.Location = new Point(945, 652);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.PenWidth = 15;
            btnSubmit.Rounding = true;
            btnSubmit.RoundingInt = 70;
            btnSubmit.Size = new Size(189, 84);
            btnSubmit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmit.TabIndex = 24;
            btnSubmit.Tag = "Cyber";
            btnSubmit.TextButton = "Submit";
            btnSubmit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSubmit.Timer_Effect_1 = 5;
            btnSubmit.Timer_RGB = 300;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnNext
            // 
            btnNext.Alpha = 20;
            btnNext.BackColor = Color.Transparent;
            btnNext.Background = true;
            btnNext.Background_WidthPen = 7F;
            btnNext.BackgroundPen = true;
            btnNext.ColorBackground = Color.Black;
            btnNext.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnNext.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnNext.ColorBackground_Pen = Color.Lime;
            btnNext.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNext.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNext.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNext.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNext.Effect_1 = true;
            btnNext.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNext.Effect_1_Transparency = 25;
            btnNext.Effect_2 = true;
            btnNext.Effect_2_ColorBackground = Color.White;
            btnNext.Effect_2_Transparency = 20;
            btnNext.Font = new Font("Arial", 11F);
            btnNext.ForeColor = Color.Lime;
            btnNext.Lighting = false;
            btnNext.LinearGradient_Background = false;
            btnNext.LinearGradientPen = false;
            btnNext.Location = new Point(182, 652);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.PenWidth = 15;
            btnNext.Rounding = true;
            btnNext.RoundingInt = 70;
            btnNext.Size = new Size(189, 84);
            btnNext.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNext.TabIndex = 23;
            btnNext.Tag = "Cyber";
            btnNext.TextButton = "Start";
            btnNext.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNext.Timer_Effect_1 = 5;
            btnNext.Timer_RGB = 300;
            btnNext.Click += btnNext_Click_1;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.BackColor = Color.Black;
            lblCode.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCode.ForeColor = Color.Lime;
            lblCode.Location = new Point(385, 215);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(564, 57);
            lblCode.TabIndex = 25;
            lblCode.Text = "Click \"Start\" To... Start";
            lblCode.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = Color.Black;
            txtAnswer.BorderStyle = BorderStyle.FixedSingle;
            txtAnswer.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAnswer.ForeColor = Color.White;
            txtAnswer.Location = new Point(536, 652);
            txtAnswer.Margin = new Padding(3, 4, 3, 4);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(244, 48);
            txtAnswer.TabIndex = 26;
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.aa1;
            pictureBox1.Image = Properties.Resources.aaaaaaa;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-22, -7);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1394, 175);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1366, 786);
            Controls.Add(txtAnswer);
            Controls.Add(lblCode);
            Controls.Add(btnSubmit);
            Controls.Add(btnNext);
            Controls.Add(cyberButton3);
            Controls.Add(nightControlBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Option_2";
            TransparencyKey = Color.Fuchsia;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private ReaLTaiizor.Controls.CyberButton btnSubmit;
        private ReaLTaiizor.Controls.CyberButton btnNext;
        private ReaLTaiizor.Controls.NightLabel lblCode;
        private ReaLTaiizor.Controls.CrownTextBox txtAnswer;
        private PictureBox pictureBox1;
    }
}