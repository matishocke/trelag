namespace F1Login
{
    partial class F2Admin
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
            BTN_Inspector = new Button();
            BTN_Logout = new Button();
            BTN_help = new Button();
            BTN_Order = new Button();
            BTN_ServicesEditionAdmin = new Button();
            BTN_CustomerEditionAdmin = new Button();
            panelLogo = new Panel();
            BTN_picHomeAdmin = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            PIC_Home = new PictureBox();
            LBL_Home = new Label();
            panel1 = new Panel();
            panelShadowAdmin = new Panel();
            panelDesktop = new Panel();
            LBL_DateAdmin = new Label();
            LBL_Clock = new Label();
            pictureBox1 = new PictureBox();
            panelGround = new Panel();
            BTN_Director = new Button();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BTN_picHomeAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PIC_Home).BeginInit();
            panel1.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(25, 25, 50);
            panelMenu.Controls.Add(BTN_Director);
            panelMenu.Controls.Add(BTN_Inspector);
            panelMenu.Controls.Add(BTN_Logout);
            panelMenu.Controls.Add(BTN_help);
            panelMenu.Controls.Add(BTN_Order);
            panelMenu.Controls.Add(BTN_ServicesEditionAdmin);
            panelMenu.Controls.Add(BTN_CustomerEditionAdmin);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 936);
            panelMenu.TabIndex = 8;
            // 
            // BTN_Inspector
            // 
            BTN_Inspector.Dock = DockStyle.Top;
            BTN_Inspector.FlatAppearance.BorderSize = 0;
            BTN_Inspector.FlatStyle = FlatStyle.Flat;
            BTN_Inspector.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Inspector.ForeColor = SystemColors.ButtonHighlight;
            BTN_Inspector.Image = Properties.Resources.inspector110;
            BTN_Inspector.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Inspector.Location = new Point(0, 500);
            BTN_Inspector.Name = "BTN_Inspector";
            BTN_Inspector.Padding = new Padding(10, 0, 20, 0);
            BTN_Inspector.Size = new Size(250, 136);
            BTN_Inspector.TabIndex = 10;
            BTN_Inspector.Text = "       I\r\n    Am\r\nInspector";
            BTN_Inspector.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Inspector.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Inspector.UseVisualStyleBackColor = true;
            BTN_Inspector.Click += BTN_Inspector_Click;
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
            // BTN_Order
            // 
            BTN_Order.Dock = DockStyle.Top;
            BTN_Order.FlatAppearance.BorderSize = 0;
            BTN_Order.FlatStyle = FlatStyle.Flat;
            BTN_Order.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Order.ForeColor = SystemColors.ButtonHighlight;
            BTN_Order.Image = Properties.Resources.ordersssssss;
            BTN_Order.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Order.Location = new Point(0, 340);
            BTN_Order.Name = "BTN_Order";
            BTN_Order.Padding = new Padding(10, 0, 20, 0);
            BTN_Order.Size = new Size(250, 80);
            BTN_Order.TabIndex = 7;
            BTN_Order.Text = "Orders";
            BTN_Order.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Order.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Order.UseVisualStyleBackColor = true;
            BTN_Order.Click += BTN_Order_Click;
            // 
            // BTN_ServicesEditionAdmin
            // 
            BTN_ServicesEditionAdmin.Dock = DockStyle.Top;
            BTN_ServicesEditionAdmin.FlatAppearance.BorderSize = 0;
            BTN_ServicesEditionAdmin.FlatStyle = FlatStyle.Flat;
            BTN_ServicesEditionAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_ServicesEditionAdmin.ForeColor = SystemColors.ButtonHighlight;
            BTN_ServicesEditionAdmin.Image = Properties.Resources.Shopsssss;
            BTN_ServicesEditionAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_ServicesEditionAdmin.Location = new Point(0, 260);
            BTN_ServicesEditionAdmin.Name = "BTN_ServicesEditionAdmin";
            BTN_ServicesEditionAdmin.Padding = new Padding(10, 0, 20, 0);
            BTN_ServicesEditionAdmin.Size = new Size(250, 80);
            BTN_ServicesEditionAdmin.TabIndex = 6;
            BTN_ServicesEditionAdmin.Text = "Services";
            BTN_ServicesEditionAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BTN_ServicesEditionAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_ServicesEditionAdmin.UseVisualStyleBackColor = true;
            BTN_ServicesEditionAdmin.Click += BTN_ServicesEditionAdmin_Click;
            // 
            // BTN_CustomerEditionAdmin
            // 
            BTN_CustomerEditionAdmin.Dock = DockStyle.Top;
            BTN_CustomerEditionAdmin.FlatAppearance.BorderSize = 0;
            BTN_CustomerEditionAdmin.FlatStyle = FlatStyle.Flat;
            BTN_CustomerEditionAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_CustomerEditionAdmin.ForeColor = SystemColors.ButtonHighlight;
            BTN_CustomerEditionAdmin.Image = Properties.Resources.Createsizee1;
            BTN_CustomerEditionAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_CustomerEditionAdmin.Location = new Point(0, 180);
            BTN_CustomerEditionAdmin.Name = "BTN_CustomerEditionAdmin";
            BTN_CustomerEditionAdmin.Padding = new Padding(10, 0, 20, 0);
            BTN_CustomerEditionAdmin.Size = new Size(250, 80);
            BTN_CustomerEditionAdmin.TabIndex = 5;
            BTN_CustomerEditionAdmin.Text = "Customer";
            BTN_CustomerEditionAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BTN_CustomerEditionAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_CustomerEditionAdmin.UseVisualStyleBackColor = true;
            BTN_CustomerEditionAdmin.Click += BTN_Customer_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(25, 25, 50);
            panelLogo.Controls.Add(BTN_picHomeAdmin);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 180);
            panelLogo.TabIndex = 0;
            // 
            // BTN_picHomeAdmin
            // 
            BTN_picHomeAdmin.Dock = DockStyle.Fill;
            BTN_picHomeAdmin.Image = Properties.Resources.logoooo;
            BTN_picHomeAdmin.Location = new Point(0, 0);
            BTN_picHomeAdmin.Name = "BTN_picHomeAdmin";
            BTN_picHomeAdmin.Size = new Size(250, 180);
            BTN_picHomeAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            BTN_picHomeAdmin.TabIndex = 0;
            BTN_picHomeAdmin.TabStop = false;
            BTN_picHomeAdmin.Click += BTN_picHomeAdmin_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // PIC_Home
            // 
            PIC_Home.Image = Properties.Resources.homeuusssss;
            PIC_Home.Location = new Point(25, 12);
            PIC_Home.Name = "PIC_Home";
            PIC_Home.Size = new Size(55, 57);
            PIC_Home.SizeMode = PictureBoxSizeMode.Zoom;
            PIC_Home.TabIndex = 0;
            PIC_Home.TabStop = false;
            // 
            // LBL_Home
            // 
            LBL_Home.AutoSize = true;
            LBL_Home.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Home.ForeColor = SystemColors.ButtonHighlight;
            LBL_Home.Location = new Point(86, 23);
            LBL_Home.Name = "LBL_Home";
            LBL_Home.Size = new Size(71, 30);
            LBL_Home.TabIndex = 1;
            LBL_Home.Text = "Home";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 25, 50);
            panel1.Controls.Add(PIC_Home);
            panel1.Controls.Add(LBL_Home);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 70);
            panel1.TabIndex = 2;
            // 
            // panelShadowAdmin
            // 
            panelShadowAdmin.BackColor = Color.FromArgb(30, 30, 60);
            panelShadowAdmin.Dock = DockStyle.Top;
            panelShadowAdmin.Location = new Point(250, 70);
            panelShadowAdmin.Name = "panelShadowAdmin";
            panelShadowAdmin.Size = new Size(1264, 9);
            panelShadowAdmin.TabIndex = 9;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(25, 25, 50);
            panelDesktop.Controls.Add(LBL_DateAdmin);
            panelDesktop.Controls.Add(LBL_Clock);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 79);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1264, 857);
            panelDesktop.TabIndex = 10;
            // 
            // LBL_DateAdmin
            // 
            LBL_DateAdmin.AutoSize = true;
            LBL_DateAdmin.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_DateAdmin.ForeColor = Color.MediumSlateBlue;
            LBL_DateAdmin.Location = new Point(378, 485);
            LBL_DateAdmin.Name = "LBL_DateAdmin";
            LBL_DateAdmin.Size = new Size(96, 47);
            LBL_DateAdmin.TabIndex = 4;
            LBL_DateAdmin.Text = "Date";
            // 
            // LBL_Clock
            // 
            LBL_Clock.AutoSize = true;
            LBL_Clock.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Clock.ForeColor = Color.MediumSlateBlue;
            LBL_Clock.Location = new Point(468, 415);
            LBL_Clock.Name = "LBL_Clock";
            LBL_Clock.Size = new Size(236, 70);
            LBL_Clock.TabIndex = 3;
            LBL_Clock.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.logoooo;
            pictureBox1.Location = new Point(314, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelGround
            // 
            panelGround.BackColor = Color.FromArgb(30, 30, 60);
            panelGround.Dock = DockStyle.Bottom;
            panelGround.Location = new Point(250, 894);
            panelGround.Name = "panelGround";
            panelGround.Size = new Size(1264, 42);
            panelGround.TabIndex = 11;
            // 
            // BTN_Director
            // 
            BTN_Director.Dock = DockStyle.Top;
            BTN_Director.FlatAppearance.BorderSize = 0;
            BTN_Director.FlatStyle = FlatStyle.Flat;
            BTN_Director.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Director.ForeColor = SystemColors.ButtonHighlight;
            BTN_Director.Image = Properties.Resources.bosssssss;
            BTN_Director.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Director.Location = new Point(0, 636);
            BTN_Director.Name = "BTN_Director";
            BTN_Director.Padding = new Padding(10, 0, 20, 0);
            BTN_Director.Size = new Size(250, 136);
            BTN_Director.TabIndex = 11;
            BTN_Director.Text = " Director";
            BTN_Director.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Director.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Director.UseVisualStyleBackColor = true;
            BTN_Director.Click += BTN_Director_Click;
            // 
            // F2Admin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1514, 936);
            Controls.Add(panelGround);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadowAdmin);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "F2Admin";
            Text = "F2Admin";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BTN_picHomeAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)PIC_Home).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button BTN_help;
        private Button BTN_Order;
        private Button BTN_ServicesEditionAdmin;
        private Button BTN_CustomerEditionAdmin;
        private Panel panelLogo;
        private PictureBox BTN_picHomeAdmin;
        private System.Windows.Forms.Timer timer1;
        private PictureBox PIC_Home;
        private Label LBL_Home;
        private Panel panel1;
        private Button BTN_Logout;
        private Panel panelShadowAdmin;
        private Panel panelDesktop;
        private Label LBL_Clock;
        private PictureBox pictureBox1;
        private Panel panelGround;
        private Label LBL_DateAdmin;
        private Button BTN_Inspector;
        private Button BTN_Director;
    }
}