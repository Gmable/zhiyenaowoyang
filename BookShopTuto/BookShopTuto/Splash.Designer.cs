
namespace BookShopTuto
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(203, 26);
            label1.Name = "label1";
            label1.Size = new Size(151, 30);
            label1.TabIndex = 0;
            label1.Text = "书店管理系统";
            label1.Click += this.label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-1, 286);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(580, 26);
            progressBar1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("隶书", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(13, 249);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "加载中......";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("隶书", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(148, 254);
            label4.Name = "label4";
            label4.Size = new Size(22, 23);
            label4.TabIndex = 5;
            label4.Text = "%";
            label4.Click += this.label4_Click;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(578, 313);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.GrayText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label4;
        private EventHandler label1_Click;
        private EventHandler label4_Click;
    }
}
