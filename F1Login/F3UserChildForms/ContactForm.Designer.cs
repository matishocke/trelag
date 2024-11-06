namespace F1Login.F3UserChildForms
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            pictureBox_twitter = new PictureBox();
            pictureBox_Instagram = new PictureBox();
            LBL_Phonenumber = new Label();
            pictureBox_Facebook = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_twitter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Instagram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Facebook).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_twitter
            // 
            pictureBox_twitter.Image = Properties.Resources.twitter;
            pictureBox_twitter.Location = new Point(880, 0);
            pictureBox_twitter.Name = "pictureBox_twitter";
            pictureBox_twitter.Size = new Size(90, 90);
            pictureBox_twitter.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_twitter.TabIndex = 0;
            pictureBox_twitter.TabStop = false;
            pictureBox_twitter.Click += pictureBox_twitter_Click;
            // 
            // pictureBox_Instagram
            // 
            pictureBox_Instagram.Image = Properties.Resources.instagram;
            pictureBox_Instagram.Location = new Point(976, 0);
            pictureBox_Instagram.Name = "pictureBox_Instagram";
            pictureBox_Instagram.Size = new Size(80, 90);
            pictureBox_Instagram.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Instagram.TabIndex = 1;
            pictureBox_Instagram.TabStop = false;
            pictureBox_Instagram.Click += pictureBox_Instagram_Click;
            // 
            // LBL_Phonenumber
            // 
            LBL_Phonenumber.AutoSize = true;
            LBL_Phonenumber.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Phonenumber.ForeColor = SystemColors.ButtonHighlight;
            LBL_Phonenumber.Location = new Point(12, 22);
            LBL_Phonenumber.Name = "LBL_Phonenumber";
            LBL_Phonenumber.Size = new Size(529, 348);
            LBL_Phonenumber.TabIndex = 6;
            LBL_Phonenumber.Text = resources.GetString("LBL_Phonenumber.Text");
            // 
            // pictureBox_Facebook
            // 
            pictureBox_Facebook.Image = Properties.Resources.facebook;
            pictureBox_Facebook.Location = new Point(1062, 0);
            pictureBox_Facebook.Name = "pictureBox_Facebook";
            pictureBox_Facebook.Size = new Size(90, 90);
            pictureBox_Facebook.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Facebook.TabIndex = 7;
            pictureBox_Facebook.TabStop = false;
            pictureBox_Facebook.Click += pictureBox_Facebook_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox_Facebook);
            panel1.Controls.Add(pictureBox_Instagram);
            panel1.Controls.Add(pictureBox_twitter);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 387);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 149);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1176, 47);
            panel2.TabIndex = 9;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 60);
            ClientSize = new Size(1176, 536);
            Controls.Add(panel1);
            Controls.Add(LBL_Phonenumber);
            Name = "ContactForm";
            Text = "ContactForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox_twitter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Instagram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Facebook).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_twitter;
        private PictureBox pictureBox_Instagram;
        private Label LBL_Phonenumber;
        private PictureBox pictureBox_Facebook;
        private Panel panel1;
        private Panel panel2;
    }
}