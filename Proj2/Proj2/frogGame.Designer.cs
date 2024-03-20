namespace Proj2
{
    partial class frogGame
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            frogButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(53, 22);
            label1.Name = "label1";
            label1.Size = new Size(575, 41);
            label1.TabIndex = 0;
            label1.Text = "Win 1 point if you click and hit the frog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(53, 94);
            label2.Name = "label2";
            label2.Size = new Size(499, 41);
            label2.TabIndex = 1;
            label2.Text = "Lose 2 points if clciked but missed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(53, 174);
            label3.Name = "label3";
            label3.Size = new Size(509, 41);
            label3.TabIndex = 2;
            label3.Text = "Lose 1 point if you don't click at all";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(53, 296);
            label4.Name = "label4";
            label4.Size = new Size(360, 41);
            label4.TabIndex = 3;
            label4.Text = "Click the frog to begin...";
            // 
            // frogButton
            // 
            frogButton.BackgroundImage = Properties.Resources.Screenshot_2024_02_29_175424;
            frogButton.BackgroundImageLayout = ImageLayout.Stretch;
            frogButton.Location = new Point(514, 310);
            frogButton.Name = "frogButton";
            frogButton.Size = new Size(125, 89);
            frogButton.TabIndex = 4;
            frogButton.UseVisualStyleBackColor = true;
            frogButton.Click += frogButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 800;
            timer1.Tick += timer1_Tick;
            // 
            // frogGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(frogButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frogGame";
            Text = "Score = 0";
            Load += frogGame_Load;
            Click += frogGame_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button frogButton;
        private System.Windows.Forms.Timer timer1;
    }
}