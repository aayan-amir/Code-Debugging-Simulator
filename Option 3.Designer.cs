namespace Code_Debugging
{
    partial class Form5
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
            btnBack = new ReaLTaiizor.Controls.CyberButton();
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox1 = new PictureBox();
            radioA = new RadioButton();
            radioB = new RadioButton();
            radioC = new RadioButton();
            radioD = new RadioButton();
            btnSubmit = new ReaLTaiizor.Controls.CyberButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblQuestion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Alpha = 20;
            btnBack.BackColor = Color.Transparent;
            btnBack.Background = true;
            btnBack.Background_WidthPen = 7F;
            btnBack.BackgroundPen = true;
            btnBack.ColorBackground = Color.Black;
            btnBack.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnBack.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnBack.ColorBackground_Pen = Color.Lime;
            btnBack.ColorLighting = Color.FromArgb(29, 200, 238);
            btnBack.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnBack.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnBack.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnBack.Effect_1 = true;
            btnBack.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnBack.Effect_1_Transparency = 25;
            btnBack.Effect_2 = true;
            btnBack.Effect_2_ColorBackground = Color.White;
            btnBack.Effect_2_Transparency = 20;
            btnBack.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Lime;
            btnBack.Lighting = false;
            btnBack.LinearGradient_Background = false;
            btnBack.LinearGradientPen = false;
            btnBack.Location = new Point(46, 37);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.PenWidth = 15;
            btnBack.Rounding = true;
            btnBack.RoundingInt = 70;
            btnBack.Size = new Size(167, 50);
            btnBack.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnBack.TabIndex = 21;
            btnBack.Tag = "Cyber";
            btnBack.TextButton = "Back To Menu";
            btnBack.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnBack.Timer_Effect_1 = 5;
            btnBack.Timer_RGB = 300;
            btnBack.Click += btnBack_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("OCR A Extended", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(471, 13);
            label1.Name = "label1";
            label1.Size = new Size(410, 104);
            label1.TabIndex = 20;
            label1.Text = "MCQ's!";
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
            nightControlBox1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = Properties.Resources.aa1;
            pictureBox1.Image = Properties.Resources.aaaaaaa;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-55, -4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1422, 139);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // radioA
            // 
            radioA.AutoSize = true;
            radioA.BackColor = SystemColors.ActiveCaptionText;
            radioA.Font = new Font("OCR A Extended", 22.2F, FontStyle.Bold);
            radioA.ForeColor = Color.Lime;
            radioA.Location = new Point(196, 399);
            radioA.Margin = new Padding(3, 4, 3, 4);
            radioA.Name = "radioA";
            radioA.Size = new Size(17, 16);
            radioA.TabIndex = 23;
            radioA.TabStop = true;
            radioA.UseVisualStyleBackColor = false;
            // 
            // radioB
            // 
            radioB.AutoSize = true;
            radioB.BackColor = SystemColors.ActiveCaptionText;
            radioB.Font = new Font("OCR A Extended", 22.2F, FontStyle.Bold);
            radioB.ForeColor = Color.Lime;
            radioB.Location = new Point(196, 481);
            radioB.Margin = new Padding(3, 4, 3, 4);
            radioB.Name = "radioB";
            radioB.Size = new Size(17, 16);
            radioB.TabIndex = 24;
            radioB.TabStop = true;
            radioB.UseVisualStyleBackColor = false;
            // 
            // radioC
            // 
            radioC.AutoSize = true;
            radioC.BackColor = SystemColors.ActiveCaptionText;
            radioC.Font = new Font("OCR A Extended", 22.2F, FontStyle.Bold);
            radioC.ForeColor = Color.Lime;
            radioC.Location = new Point(196, 562);
            radioC.Margin = new Padding(3, 4, 3, 4);
            radioC.Name = "radioC";
            radioC.Size = new Size(17, 16);
            radioC.TabIndex = 25;
            radioC.TabStop = true;
            radioC.UseVisualStyleBackColor = false;
            // 
            // radioD
            // 
            radioD.AutoSize = true;
            radioD.BackColor = SystemColors.ActiveCaptionText;
            radioD.Font = new Font("OCR A Extended", 22.2F, FontStyle.Bold);
            radioD.ForeColor = Color.Lime;
            radioD.Location = new Point(196, 642);
            radioD.Margin = new Padding(3, 4, 3, 4);
            radioD.Name = "radioD";
            radioD.Size = new Size(17, 16);
            radioD.TabIndex = 26;
            radioD.TabStop = true;
            radioD.UseVisualStyleBackColor = false;
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
            btnSubmit.ColorLighting = Color.Black;
            btnSubmit.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnSubmit.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnSubmit.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSubmit.Effect_1 = true;
            btnSubmit.Effect_1_ColorBackground = Color.Black;
            btnSubmit.Effect_1_Transparency = 25;
            btnSubmit.Effect_2 = true;
            btnSubmit.Effect_2_ColorBackground = Color.White;
            btnSubmit.Effect_2_Transparency = 20;
            btnSubmit.Font = new Font("Arial", 11F);
            btnSubmit.ForeColor = Color.Lime;
            btnSubmit.Lighting = false;
            btnSubmit.LinearGradient_Background = false;
            btnSubmit.LinearGradientPen = false;
            btnSubmit.Location = new Point(574, 673);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.PenWidth = 15;
            btnSubmit.Rounding = true;
            btnSubmit.RoundingInt = 70;
            btnSubmit.Size = new Size(189, 84);
            btnSubmit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmit.TabIndex = 27;
            btnSubmit.Tag = "Cyber";
            btnSubmit.TextButton = "Submit";
            btnSubmit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSubmit.Timer_Effect_1 = 5;
            btnSubmit.Timer_RGB = 300;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("OCR A Extended", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(159, 403);
            label2.Name = "label2";
            label2.Size = new Size(31, 30);
            label2.TabIndex = 28;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("OCR A Extended", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(159, 485);
            label3.Name = "label3";
            label3.Size = new Size(31, 30);
            label3.TabIndex = 29;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("OCR A Extended", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(159, 646);
            label4.Name = "label4";
            label4.Size = new Size(31, 30);
            label4.TabIndex = 30;
            label4.Text = "D";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("OCR A Extended", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(159, 565);
            label5.Name = "label5";
            label5.Size = new Size(31, 30);
            label5.TabIndex = 31;
            label5.Text = "C";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.Black;
            lblQuestion.Font = new Font("OCR A Extended", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.Lime;
            lblQuestion.Location = new Point(213, 214);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 39);
            lblQuestion.TabIndex = 32;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1366, 786);
            Controls.Add(lblQuestion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(radioD);
            Controls.Add(radioC);
            Controls.Add(radioB);
            Controls.Add(radioA);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(nightControlBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton btnBack;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox pictureBox1;
        private RadioButton radioA;
        private RadioButton radioB;
        private RadioButton radioC;
        private RadioButton radioD;
        private ReaLTaiizor.Controls.CyberButton btnSubmit;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblQuestion;
    }
}