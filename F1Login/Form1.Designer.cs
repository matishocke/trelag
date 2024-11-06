namespace F1Login
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxUserOrAdmin = new ComboBox();
            Login_BTN = new Button();
            label_Password = new Label();
            label_username = new Label();
            Password_TXT = new TextBox();
            Username_TXT = new TextBox();
            BTN_HelpFunction = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBoxUserOrAdmin);
            groupBox1.Controls.Add(Login_BTN);
            groupBox1.Controls.Add(label_Password);
            groupBox1.Controls.Add(label_username);
            groupBox1.Controls.Add(Password_TXT);
            groupBox1.Controls.Add(Username_TXT);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(27, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 590);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Get Started";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(265, 330);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(181, 34);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(150, 519);
            label3.Name = "label3";
            label3.Size = new Size(200, 36);
            label3.TabIndex = 11;
            label3.Text = "Create Account";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(127, 489);
            label2.Name = "label2";
            label2.Size = new Size(247, 30);
            label2.TabIndex = 10;
            label2.Text = "Dont Have An Account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 70);
            label1.Name = "label1";
            label1.Size = new Size(227, 36);
            label1.TabIndex = 9;
            label1.Text = "Select User Type :";
            // 
            // comboBoxUserOrAdmin
            // 
            comboBoxUserOrAdmin.FormattingEnabled = true;
            comboBoxUserOrAdmin.Items.AddRange(new object[] { "admin", "user" });
            comboBoxUserOrAdmin.Location = new Point(274, 72);
            comboBoxUserOrAdmin.Name = "comboBoxUserOrAdmin";
            comboBoxUserOrAdmin.Size = new Size(215, 38);
            comboBoxUserOrAdmin.TabIndex = 8;
            // 
            // Login_BTN
            // 
            Login_BTN.BackColor = Color.Black;
            Login_BTN.ForeColor = SystemColors.ButtonHighlight;
            Login_BTN.Image = Properties.Resources.ln;
            Login_BTN.ImageAlign = ContentAlignment.MiddleRight;
            Login_BTN.Location = new Point(69, 387);
            Login_BTN.Name = "Login_BTN";
            Login_BTN.Size = new Size(377, 87);
            Login_BTN.TabIndex = 7;
            Login_BTN.Text = "LOGIN";
            Login_BTN.TextImageRelation = TextImageRelation.ImageBeforeText;
            Login_BTN.UseVisualStyleBackColor = false;
            Login_BTN.Click += Login_BTN_Click;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_Password.Location = new Point(69, 250);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(136, 36);
            label_Password.TabIndex = 6;
            label_Password.Text = "Password ";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_username.Location = new Point(69, 164);
            label_username.Name = "label_username";
            label_username.Size = new Size(144, 36);
            label_username.TabIndex = 5;
            label_username.Text = "Username ";
            // 
            // Password_TXT
            // 
            Password_TXT.Location = new Point(69, 289);
            Password_TXT.Name = "Password_TXT";
            Password_TXT.Size = new Size(377, 35);
            Password_TXT.TabIndex = 4;
            Password_TXT.UseSystemPasswordChar = true;
            // 
            // Username_TXT
            // 
            Username_TXT.Location = new Point(69, 203);
            Username_TXT.Name = "Username_TXT";
            Username_TXT.Size = new Size(377, 35);
            Username_TXT.TabIndex = 3;
            // 
            // BTN_HelpFunction
            // 
            BTN_HelpFunction.BackColor = Color.DarkSlateBlue;
            BTN_HelpFunction.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_HelpFunction.ForeColor = SystemColors.ButtonHighlight;
            BTN_HelpFunction.Image = Properties.Resources.hjelpefunktion;
            BTN_HelpFunction.Location = new Point(423, 620);
            BTN_HelpFunction.Name = "BTN_HelpFunction";
            BTN_HelpFunction.Size = new Size(123, 51);
            BTN_HelpFunction.TabIndex = 5;
            BTN_HelpFunction.Text = "Help";
            BTN_HelpFunction.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_HelpFunction.UseVisualStyleBackColor = false;
            BTN_HelpFunction.Click += BTN_HelpFunction_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 60);
            ClientSize = new Size(572, 696);
            Controls.Add(BTN_HelpFunction);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBoxUserOrAdmin;
        private Button Login_BTN;
        private Label label_Password;
        private Label label_username;
        private TextBox Password_TXT;
        private TextBox Username_TXT;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
        private Button BTN_HelpFunction;
    }
}