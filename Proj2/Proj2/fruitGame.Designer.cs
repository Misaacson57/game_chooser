namespace Proj2
{
    partial class fruitGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fruitGame));
            spinButton = new Button();
            flipButton = new Button();
            stopFruit1 = new Button();
            stopFruit2 = new Button();
            stopFruit3 = new Button();
            cher1 = new PictureBox();
            cher2 = new PictureBox();
            cher3 = new PictureBox();
            ban1 = new PictureBox();
            ban2 = new PictureBox();
            ban3 = new PictureBox();
            ora1 = new PictureBox();
            ora2 = new PictureBox();
            ora3 = new PictureBox();
            wMelon1 = new PictureBox();
            wMelon2 = new PictureBox();
            wMelon3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)cher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cher2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cher3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ban1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ban2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ban3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ora1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ora2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ora3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wMelon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wMelon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wMelon3).BeginInit();
            SuspendLayout();
            // 
            // spinButton
            // 
            spinButton.BackColor = Color.Fuchsia;
            spinButton.Location = new Point(618, 204);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(138, 66);
            spinButton.TabIndex = 0;
            spinButton.Text = "Spin";
            spinButton.UseVisualStyleBackColor = false;
            spinButton.Click += spinButton_Click;
            // 
            // flipButton
            // 
            flipButton.BackColor = Color.Fuchsia;
            flipButton.Location = new Point(618, 307);
            flipButton.Name = "flipButton";
            flipButton.Size = new Size(138, 66);
            flipButton.TabIndex = 1;
            flipButton.Text = "Flip twice per second";
            flipButton.UseVisualStyleBackColor = false;
            flipButton.Click += flipButton_Click;
            // 
            // stopFruit1
            // 
            stopFruit1.BackColor = Color.Fuchsia;
            stopFruit1.Location = new Point(60, 318);
            stopFruit1.Name = "stopFruit1";
            stopFruit1.Size = new Size(39, 44);
            stopFruit1.TabIndex = 2;
            stopFruit1.Text = "X";
            stopFruit1.UseVisualStyleBackColor = false;
            stopFruit1.Click += stopFruit1_Click;
            // 
            // stopFruit2
            // 
            stopFruit2.BackColor = Color.Fuchsia;
            stopFruit2.Location = new Point(266, 318);
            stopFruit2.Name = "stopFruit2";
            stopFruit2.Size = new Size(39, 44);
            stopFruit2.TabIndex = 3;
            stopFruit2.Text = "X";
            stopFruit2.UseVisualStyleBackColor = false;
            stopFruit2.Click += stopFruit2_Click;
            // 
            // stopFruit3
            // 
            stopFruit3.BackColor = Color.Fuchsia;
            stopFruit3.Location = new Point(482, 318);
            stopFruit3.Name = "stopFruit3";
            stopFruit3.Size = new Size(39, 44);
            stopFruit3.TabIndex = 4;
            stopFruit3.Text = "X";
            stopFruit3.UseVisualStyleBackColor = false;
            stopFruit3.Click += stopFruit3_Click;
            // 
            // cher1
            // 
            cher1.Image = Properties.Resources.Screenshot_2024_02_29_190005;
            cher1.Location = new Point(12, 129);
            cher1.Name = "cher1";
            cher1.Size = new Size(140, 172);
            cher1.SizeMode = PictureBoxSizeMode.StretchImage;
            cher1.TabIndex = 5;
            cher1.TabStop = false;
            // 
            // cher2
            // 
            cher2.Image = Properties.Resources.Screenshot_2024_02_29_190005;
            cher2.Location = new Point(220, 129);
            cher2.Name = "cher2";
            cher2.Size = new Size(140, 172);
            cher2.SizeMode = PictureBoxSizeMode.StretchImage;
            cher2.TabIndex = 6;
            cher2.TabStop = false;
            // 
            // cher3
            // 
            cher3.Image = Properties.Resources.Screenshot_2024_02_29_190005;
            cher3.Location = new Point(433, 129);
            cher3.Name = "cher3";
            cher3.Size = new Size(140, 172);
            cher3.SizeMode = PictureBoxSizeMode.StretchImage;
            cher3.TabIndex = 7;
            cher3.TabStop = false;
            // 
            // ban1
            // 
            ban1.Image = (Image)resources.GetObject("ban1.Image");
            ban1.Location = new Point(12, 129);
            ban1.Name = "ban1";
            ban1.Size = new Size(140, 172);
            ban1.SizeMode = PictureBoxSizeMode.StretchImage;
            ban1.TabIndex = 8;
            ban1.TabStop = false;
            // 
            // ban2
            // 
            ban2.Image = (Image)resources.GetObject("ban2.Image");
            ban2.Location = new Point(220, 129);
            ban2.Name = "ban2";
            ban2.Size = new Size(140, 172);
            ban2.SizeMode = PictureBoxSizeMode.StretchImage;
            ban2.TabIndex = 9;
            ban2.TabStop = false;
            // 
            // ban3
            // 
            ban3.Image = (Image)resources.GetObject("ban3.Image");
            ban3.Location = new Point(433, 129);
            ban3.Name = "ban3";
            ban3.Size = new Size(140, 172);
            ban3.SizeMode = PictureBoxSizeMode.StretchImage;
            ban3.TabIndex = 10;
            ban3.TabStop = false;
            // 
            // ora1
            // 
            ora1.Image = (Image)resources.GetObject("ora1.Image");
            ora1.Location = new Point(12, 129);
            ora1.Name = "ora1";
            ora1.Size = new Size(140, 172);
            ora1.SizeMode = PictureBoxSizeMode.StretchImage;
            ora1.TabIndex = 11;
            ora1.TabStop = false;
            // 
            // ora2
            // 
            ora2.Image = (Image)resources.GetObject("ora2.Image");
            ora2.Location = new Point(220, 129);
            ora2.Name = "ora2";
            ora2.Size = new Size(140, 172);
            ora2.SizeMode = PictureBoxSizeMode.StretchImage;
            ora2.TabIndex = 12;
            ora2.TabStop = false;
            // 
            // ora3
            // 
            ora3.Image = (Image)resources.GetObject("ora3.Image");
            ora3.Location = new Point(433, 129);
            ora3.Name = "ora3";
            ora3.Size = new Size(140, 172);
            ora3.SizeMode = PictureBoxSizeMode.StretchImage;
            ora3.TabIndex = 13;
            ora3.TabStop = false;
            // 
            // wMelon1
            // 
            wMelon1.Image = (Image)resources.GetObject("wMelon1.Image");
            wMelon1.Location = new Point(12, 129);
            wMelon1.Name = "wMelon1";
            wMelon1.Size = new Size(140, 172);
            wMelon1.SizeMode = PictureBoxSizeMode.StretchImage;
            wMelon1.TabIndex = 14;
            wMelon1.TabStop = false;
            // 
            // wMelon2
            // 
            wMelon2.Image = (Image)resources.GetObject("wMelon2.Image");
            wMelon2.Location = new Point(220, 129);
            wMelon2.Name = "wMelon2";
            wMelon2.Size = new Size(140, 172);
            wMelon2.SizeMode = PictureBoxSizeMode.StretchImage;
            wMelon2.TabIndex = 15;
            wMelon2.TabStop = false;
            // 
            // wMelon3
            // 
            wMelon3.Image = (Image)resources.GetObject("wMelon3.Image");
            wMelon3.Location = new Point(433, 129);
            wMelon3.Name = "wMelon3";
            wMelon3.Size = new Size(140, 172);
            wMelon3.SizeMode = PictureBoxSizeMode.StretchImage;
            wMelon3.TabIndex = 16;
            wMelon3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // fruitGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(wMelon3);
            Controls.Add(wMelon2);
            Controls.Add(wMelon1);
            Controls.Add(ora3);
            Controls.Add(ora2);
            Controls.Add(ora1);
            Controls.Add(ban3);
            Controls.Add(ban2);
            Controls.Add(ban1);
            Controls.Add(cher3);
            Controls.Add(cher2);
            Controls.Add(cher1);
            Controls.Add(stopFruit3);
            Controls.Add(stopFruit2);
            Controls.Add(stopFruit1);
            Controls.Add(flipButton);
            Controls.Add(spinButton);
            Name = "fruitGame";
            Text = "Fruit Matching Game";
            Load += fruitGame_Load;
            DoubleClick += fruitGame_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)cher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cher2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cher3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ban1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ban2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ban3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ora1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ora2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ora3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wMelon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)wMelon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)wMelon3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button spinButton;
        private Button flipButton;
        private Button stopFruit1;
        private Button stopFruit2;
        private Button stopFruit3;
        private PictureBox cher1;
        private PictureBox cher2;
        private PictureBox cher3;
        private PictureBox ban1;
        private PictureBox ban2;
        private PictureBox ban3;
        private PictureBox ora1;
        private PictureBox ora2;
        private PictureBox ora3;
        private PictureBox wMelon1;
        private PictureBox wMelon2;
        private PictureBox wMelon3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}