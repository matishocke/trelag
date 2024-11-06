namespace F1Login
{
    partial class F3User
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
            panelMenu = new Panel();
            BTN_Logout = new Button();
            BTN_help = new Button();
            BTN_Contact = new Button();
            BTN_Services = new Button();
            BTN_Customer = new Button();
            panelLogo = new Panel();
            BTN_picHome = new PictureBox();
            panelTitelBar = new Panel();
            LBL_Home = new Label();
            PIC_Home = new PictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            LBL_Date = new Label();
            LBL_Clock = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BTN_picHome).BeginInit();
            panelTitelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_Home).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(25, 25, 50);
            panelMenu.Controls.Add(BTN_Logout);
            panelMenu.Controls.Add(BTN_help);
            panelMenu.Controls.Add(BTN_Contact);
            panelMenu.Controls.Add(BTN_Services);
            panelMenu.Controls.Add(BTN_Customer);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 936);
            panelMenu.TabIndex = 4;
            // 
            // BTN_Logout
            // 
            BTN_Logout.BackColor = Color.Black;
            BTN_Logout.Dock = DockStyle.Bottom;
            BTN_Logout.FlatAppearance.BorderSize = 0;
            BTN_Logout.FlatStyle = FlatStyle.Flat;
            BTN_Logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Logout.ForeColor = SystemColors.ButtonHighlight;
            BTN_Logout.Image = Properties.Resources.logoutsss1;
            BTN_Logout.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Logout.Location = new Point(0, 856);
            BTN_Logout.Name = "BTN_Logout";
            BTN_Logout.Padding = new Padding(10, 0, 20, 0);
            BTN_Logout.Size = new Size(250, 80);
            BTN_Logout.TabIndex = 9;
            BTN_Logout.Text = "Back To Login";
            BTN_Logout.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Logout.UseVisualStyleBackColor = false;
            BTN_Logout.Click += BTN_Logout_Click;
            // 
            // BTN_help
            // 
            BTN_help.Dock = DockStyle.Top;
            BTN_help.FlatAppearance.BorderSize = 0;
            BTN_help.FlatStyle = FlatStyle.Flat;
            BTN_help.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_help.ForeColor = SystemColors.ButtonHighlight;
            BTN_help.Image = Properties.Resources.helpwhitessssss;
            BTN_help.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_help.Location = new Point(0, 420);
            BTN_help.Name = "BTN_help";
            BTN_help.Padding = new Padding(10, 0, 20, 0);
            BTN_help.Size = new Size(250, 80);
            BTN_help.TabIndex = 8;
            BTN_help.Text = "Help";
            BTN_help.TextAlign = ContentAlignment.MiddleLeft;
            BTN_help.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_help.UseVisualStyleBackColor = true;
            BTN_help.Click += BTN_help_Click;
            // 
            // BTN_Contact
            // 
            BTN_Contact.Dock = DockStyle.Top;
            BTN_Contact.FlatAppearance.BorderSize = 0;
            BTN_Contact.FlatStyle = FlatStyle.Flat;
            BTN_Contact.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Contact.ForeColor = SystemColors.ButtonHighlight;
            BTN_Contact.Image = Properties.Resources.kontaktsize;
            BTN_Contact.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Contact.Location = new Point(0, 340);
            BTN_Contact.Name = "BTN_Contact";
            BTN_Contact.Padding = new Padding(10, 0, 20, 0);
            BTN_Contact.Size = new Size(250, 80);
            BTN_Contact.TabIndex = 7;
            BTN_Contact.Text = "Contact";
            BTN_Contact.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Contact.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Contact.UseVisualStyleBackColor = true;
            BTN_Contact.Click += BTN_Contact_Click;
            // 
            // BTN_Services
            // 
            BTN_Services.Dock = DockStyle.Top;
            BTN_Services.FlatAppearance.BorderSize = 0;
            BTN_Services.FlatStyle = FlatStyle.Flat;
            BTN_Services.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Services.ForeColor = SystemColors.ButtonHighlight;
            BTN_Services.Image = Properties.Resources.Shopsssss;
            BTN_Services.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Services.Location = new Point(0, 260);
            BTN_Services.Name = "BTN_Services";
            BTN_Services.Padding = new Padding(10, 0, 20, 0);
            BTN_Services.Size = new Size(250, 80);
            BTN_Services.TabIndex = 6;
            BTN_Services.Text = "Services";
            BTN_Services.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Services.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Services.UseVisualStyleBackColor = true;
            BTN_Services.Click += BTN_Services_Click;
            // 
            // BTN_Customer
            // 
            BTN_Customer.Dock = DockStyle.Top;
            BTN_Customer.FlatAppearance.BorderSize = 0;
            BTN_Customer.FlatStyle = FlatStyle.Flat;
            BTN_Customer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Customer.ForeColor = SystemColors.ButtonHighlight;
            BTN_Customer.Image = Properties.Resources.Createsizee1;
            BTN_Customer.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Customer.Location = new Point(0, 180);
            BTN_Customer.Name = "BTN_Customer";
            BTN_Customer.Padding = new Padding(10, 0, 20, 0);
            BTN_Customer.Size = new Size(250, 80);
            BTN_Customer.TabIndex = 5;
            BTN_Customer.Text = "Cutomer";
            BTN_Customer.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Customer.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Customer.UseVisualStyleBackColor = true;
            BTN_Customer.Click += BTN_Customer_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(25, 25, 50);
            panelLogo.Controls.Add(BTN_picHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 180);
            panelLogo.TabIndex = 0;
            // 
            // BTN_picHome
            // 
            BTN_picHome.Dock = DockStyle.Fill;
            BTN_picHome.Image = Properties.Resources.CleanLogo33333;
            BTN_picHome.Location = new Point(0, 0);
            BTN_picHome.Name = "BTN_picHome";
            BTN_picHome.Size = new Size(250, 180);
            BTN_picHome.SizeMode = PictureBoxSizeMode.Zoom;
            BTN_picHome.TabIndex = 0;
            BTN_picHome.TabStop = false;
            BTN_picHome.Click += BTN_picHome_Click;
            // 
            // panelTitelBar
            // 
            panelTitelBar.BackColor = Color.FromArgb(25, 25, 50);
            panelTitelBar.Controls.Add(LBL_Home);
            panelTitelBar.Controls.Add(PIC_Home);
            panelTitelBar.Dock = DockStyle.Top;
            panelTitelBar.Location = new Point(250, 0);
            panelTitelBar.Name = "panelTitelBar";
            panelTitelBar.Size = new Size(1264, 100);
            panelTitelBar.TabIndex = 5;
            panelTitelBar.MouseDown += panelTitelBar_MouseDown;
            // 
            // LBL_Home
            // 
            LBL_Home.AutoSize = true;
            LBL_Home.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Home.ForeColor = SystemColors.ButtonHighlight;
            LBL_Home.Location = new Point(69, 36);
            LBL_Home.Name = "LBL_Home";
            LBL_Home.Size = new Size(71, 30);
            LBL_Home.TabIndex = 1;
            LBL_Home.Text = "Home";
            // 
            // PIC_Home
            // 
            PIC_Home.Image = Properties.Resources.homeuusssss;
            PIC_Home.Location = new Point(13, 20);
            PIC_Home.Name = "PIC_Home";
            PIC_Home.Size = new Size(55, 57);
            PIC_Home.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_Home.TabIndex = 0;
            PIC_Home.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(25, 25, 50);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(250, 100);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1264, 9);
            panelShadow.TabIndex = 6;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(30, 30, 60);
            panelDesktop.Controls.Add(LBL_Date);
            panelDesktop.Controls.Add(LBL_Clock);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 109);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1264, 827);
            panelDesktop.TabIndex = 7;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // LBL_Date
            // 
            LBL_Date.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LBL_Date.AutoSize = true;
            LBL_Date.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Date.ForeColor = Color.FromArgb(0, 192, 192);
            LBL_Date.Location = new Point(406, 510);
            LBL_Date.Name = "LBL_Date";
            LBL_Date.Size = new Size(96, 47);
            LBL_Date.TabIndex = 2;
            LBL_Date.Text = "Date";
            // 
            // LBL_Clock
            // 
            LBL_Clock.AutoSize = true;
            LBL_Clock.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Clock.ForeColor = Color.FromArgb(0, 192, 192);
            LBL_Clock.Location = new Point(489, 428);
            LBL_Clock.Name = "LBL_Clock";
            LBL_Clock.Size = new Size(236, 70);
            LBL_Clock.TabIndex = 1;
            LBL_Clock.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.CleanLogo_5_1;
            pictureBox1.Location = new Point(348, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 25, 50);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(250, 894);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 42);
            panel1.TabIndex = 2;
            // 
            // F3User
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1514, 936);
            Controls.Add(panel1);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitelBar);
            Controls.Add(panelMenu);
            Name = "F3User";
            Text = "F3User";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BTN_picHome).EndInit();
            panelTitelBar.ResumeLayout(false);
            panelTitelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PIC_Home).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button BTN_Customer;
        private Panel panelLogo;
        private Button BTN_Contact;
        private Button BTN_Services;
        private Button BTN_help;
        private PictureBox BTN_picHome;
        private Panel panelTitelBar;
        private Label LBL_Home;
        private PictureBox PIC_Home;
        private Panel panelShadow;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private Label LBL_Clock;
        private System.Windows.Forms.Timer timer1;
        private Button BTN_Logout;
        private Panel panel1;
        private Label LBL_Date;
    }
}