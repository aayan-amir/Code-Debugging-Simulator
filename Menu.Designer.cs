namespace Code_Debugging
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewScores;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewScores = new DataGridView();
            label2 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewScores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewScores
            // 
            dataGridViewScores.AllowUserToAddRows = false;
            dataGridViewScores.AllowUserToDeleteRows = false;
            dataGridViewScores.AllowUserToResizeRows = false;
            dataGridViewScores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewScores.BackgroundColor = Color.DarkGreen;
            dataGridViewScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewScores.GridColor = SystemColors.ActiveBorder;
            dataGridViewScores.Location = new Point(100, 277);
            dataGridViewScores.Name = "dataGridViewScores";
            dataGridViewScores.ReadOnly = true;
            dataGridViewScores.RowHeadersVisible = false;
            dataGridViewScores.RowHeadersWidth = 51;
            dataGridViewScores.Size = new Size(332, 318);
            dataGridViewScores.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("OCR A Extended", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(100, 86);
            label2.Name = "label2";
            label2.Size = new Size(1211, 83);
            label2.TabIndex = 19;
            label2.Text = "CODE DEBUGGING SIMULATOR";
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
            nightControlBox1.TabIndex = 18;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 0F;
            cyberButton1.BackgroundPen = false;
            cyberButton1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorBackground_1 = Color.Black;
            cyberButton1.ColorBackground_2 = Color.Lime;
            cyberButton1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorLighting = Color.MediumOrchid;
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(255, 255, 128);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = true;
            cyberButton1.LinearGradient_Background = true;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(505, 503);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 20;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 40;
            cyberButton1.Size = new Size(371, 92);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 20;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "MCQs!";
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
            cyberButton2.Background_WidthPen = 0F;
            cyberButton2.BackgroundPen = false;
            cyberButton2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorBackground_1 = Color.Black;
            cyberButton2.ColorBackground_2 = Color.Lime;
            cyberButton2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton2.ColorLighting = Color.MediumOrchid;
            cyberButton2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(255, 255, 128);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton2.Lighting = true;
            cyberButton2.LinearGradient_Background = true;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(505, 277);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 20;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 40;
            cyberButton2.Size = new Size(371, 90);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 21;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "Fix The Code!";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            cyberButton2.Click += cyberButton2_Click_2;
            // 
            // cyberButton3
            // 
            cyberButton3.Alpha = 20;
            cyberButton3.BackColor = Color.Transparent;
            cyberButton3.Background = true;
            cyberButton3.Background_WidthPen = 0F;
            cyberButton3.BackgroundPen = false;
            cyberButton3.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberButton3.ColorBackground_1 = Color.Lime;
            cyberButton3.ColorBackground_2 = Color.Black;
            cyberButton3.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberButton3.ColorLighting = Color.MediumOrchid;
            cyberButton3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton3.Effect_1 = true;
            cyberButton3.Effect_1_ColorBackground = Color.FromArgb(255, 255, 128);
            cyberButton3.Effect_1_Transparency = 25;
            cyberButton3.Effect_2 = true;
            cyberButton3.Effect_2_ColorBackground = Color.White;
            cyberButton3.Effect_2_Transparency = 20;
            cyberButton3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton3.Lighting = true;
            cyberButton3.LinearGradient_Background = true;
            cyberButton3.LinearGradientPen = false;
            cyberButton3.Location = new Point(505, 382);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 20;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 40;
            cyberButton3.Size = new Size(371, 104);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 22;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "Fill In The Blanks!";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            cyberButton3.Click += cyberButton3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.ErrorImage = Properties.Resources.aa1;
            pictureBox1.Image = Properties.Resources.aaaaaaa;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(-37, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1405, 792);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 786);
            Controls.Add(dataGridViewScores);
            Controls.Add(cyberButton3);
            Controls.Add(cyberButton2);
            Controls.Add(cyberButton1);
            Controls.Add(label2);
            Controls.Add(nightControlBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Code Debugger";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewScores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();



        }

        #endregion
        private Label label2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private PictureBox pictureBox1;
    }
}
