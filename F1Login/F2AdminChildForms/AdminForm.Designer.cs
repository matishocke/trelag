namespace F1Login.F2AdminChildForms
{
    partial class AdminForm
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
            DGV_Admins = new DataGridView();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adminIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adminBindingSource = new BindingSource(components);
            BTN_FindAdmin = new Button();
            TXT_LastNameAdmin = new TextBox();
            TXT_PasswordAdmin = new TextBox();
            TXT_FirstNameAdmin = new TextBox();
            TXT_AddressAdmin = new TextBox();
            LBL_AddressAdmin = new Label();
            TXT_EmailAdmin = new TextBox();
            TXT_PhonenumberAdmin = new TextBox();
            LBL_EmailAdmin = new Label();
            LBL_PhoneNumberAdmin = new Label();
            TXT_UserNameAdmin = new TextBox();
            LBL_PasswordAdmin = new Label();
            LBL_userNameAdmin = new Label();
            BTN_ResetAdmin = new Button();
            BTN_CreateAdmin = new Button();
            LBL_ShowIDAdmin = new Label();
            lbl_IDAdmin = new Label();
            BTN_DeleteAdmin = new Button();
            BTN_UpdateAdmin = new Button();
            LBL_LastNameAdmin = new Label();
            LBL_FirstNameAdmin = new Label();
            TXT_Salary = new TextBox();
            LBL_Salary = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_Admins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DGV_Admins
            // 
            DGV_Admins.AutoGenerateColumns = false;
            DGV_Admins.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Admins.BackgroundColor = Color.MediumSlateBlue;
            DGV_Admins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Admins.Columns.AddRange(new DataGridViewColumn[] { userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, userTypeDataGridViewTextBoxColumn, adminIDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn });
            DGV_Admins.DataSource = adminBindingSource;
            DGV_Admins.Location = new Point(27, 28);
            DGV_Admins.MultiSelect = false;
            DGV_Admins.Name = "DGV_Admins";
            DGV_Admins.ReadOnly = true;
            DGV_Admins.RowHeadersVisible = false;
            DGV_Admins.RowHeadersWidth = 72;
            DGV_Admins.RowTemplate.Height = 37;
            DGV_Admins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Admins.Size = new Size(1121, 343);
            DGV_Admins.TabIndex = 56;
            DGV_Admins.SelectionChanged += DGV_Admins_SelectionChanged;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 9;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            userTypeDataGridViewTextBoxColumn.MinimumWidth = 9;
            userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            adminIDDataGridViewTextBoxColumn.DataPropertyName = "AdminID";
            adminIDDataGridViewTextBoxColumn.HeaderText = "AdminID";
            adminIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            adminIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 9;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 9;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 9;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            salaryDataGridViewTextBoxColumn.MinimumWidth = 9;
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminBindingSource
            // 
            adminBindingSource.DataSource = typeof(Repository.Models.Admin);
            // 
            // BTN_FindAdmin
            // 
            BTN_FindAdmin.BackColor = Color.DarkOrange;
            BTN_FindAdmin.FlatAppearance.BorderSize = 0;
            BTN_FindAdmin.FlatStyle = FlatStyle.Flat;
            BTN_FindAdmin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_FindAdmin.ForeColor = SystemColors.ButtonHighlight;
            BTN_FindAdmin.Image = Properties.Resources.gettt1;
            BTN_FindAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_FindAdmin.Location = new Point(616, 535);
            BTN_FindAdmin.Name = "BTN_FindAdmin";
            BTN_FindAdmin.Padding = new Padding(10, 0, 20, 0);
            BTN_FindAdmin.Size = new Size(202, 75);
            BTN_FindAdmin.TabIndex = 84;
            BTN_FindAdmin.Text = " Find";
            BTN_FindAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BTN_FindAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_FindAdmin.UseVisualStyleBackColor = false;
            BTN_FindAdmin.Click += BTN_FindAdmin_Click;
            // 
            // TXT_LastNameAdmin
            // 
            TXT_LastNameAdmin.BackColor = Color.MediumSlateBlue;
            TXT_LastNameAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_LastNameAdmin.ForeColor = SystemColors.ButtonHighlight;
            TXT_LastNameAdmin.Location = new Point(742, 776);
            TXT_LastNameAdmin.Name = "TXT_LastNameAdmin";
            TXT_LastNameAdmin.Size = new Size(322, 39);
            TXT_LastNameAdmin.TabIndex = 83;
            // 
            // TXT_PasswordAdmin
            // 
            TXT_PasswordAdmin.BackColor = Color.MediumSlateBlue;
            TXT_PasswordAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_PasswordAdmin.ForeColor = SystemColors.ButtonHighlight;
            TXT_PasswordAdmin.Location = new Point(742, 714);
            TXT_PasswordAdmin.Name = "TXT_PasswordAdmin";
            TXT_PasswordAdmin.Size = new Size(322, 39);
            TXT_PasswordAdmin.TabIndex = 82;
            // 
            // TXT_FirstNameAdmin
            // 
            TXT_FirstNameAdmin.BackColor = Color.MediumSlateBlue;
            TXT_FirstNameAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_FirstNameAdmin.ForeColor = SystemColors.ButtonHighlight;
            TXT_FirstNameAdmin.Location = new Point(251, 776);
            TXT_FirstNameAdmin.Name = "TXT_FirstNameAdmin";
            TXT_FirstNameAdmin.Size = new Size(322, 39);
            TXT_FirstNameAdmin.TabIndex = 81;
            // 
            // TXT_AddressAdmin
            // 
            TXT_AddressAdmin.BackColor = Color.MediumSlateBlue;
            TXT_AddressAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_AddressAdmin.ForeColor = SystemColors.ButtonHighlight;
            TXT_AddressAdmin.Location = new Point(251, 898);
            TXT_AddressAdmin.Multiline = true;
            TXT_AddressAdmin.Name = "TXT_AddressAdmin";
            TXT_AddressAdmin.Size = new Size(813, 87);
            TXT_AddressAdmin.TabIndex = 80;
            // 
            // LBL_AddressAdmin
            // 
            LBL_AddressAdmin.AutoSize = true;
            LBL_AddressAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_AddressAdmin.ForeColor = SystemColors.ButtonHighlight;
            LBL_AddressAdmin.Location = new Point(133, 901);
            LBL_AddressAdmin.Name = "LBL_AddressAdmin";
            LBL_AddressAdmin.Size = new Size(112, 32);
            LBL_AddressAdmin.TabIndex = 79;
            LBL_AddressAdmin.Text = "Address :";
            // 
            // TXT_EmailAdmin
            // 
            TXT_EmailAdmin.BackColor = Color.MediumSlateBlue;
            TXT_EmailAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_EmailAdmin.ForeColor = SystemColors.ButtonHighlight;
            TXT_EmailAdmin.Location = new Point(251, 837);
            TXT_EmailAdmin.Name = "TXT_EmailAdmin";
            TXT_EmailAdmin.Size = new Size(813, 39);
            TXT_EmailAdmin.TabIndex = 78;
            // 
            // TXT_PhonenumberAdmin
            // 
            TXT_PhonenumberAdmin.BackColor = Color.MediumSlateBlue;
            TXT_PhonenumberAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_PhonenumberAdmin.ForeColor = SystemColors.ButtonHighlight;
            TXT_PhonenumberAdmin.Location = new Point(251, 717);
            TXT_PhonenumberAdmin.Name = "TXT_PhonenumberAdmin";
            TXT_PhonenumberAdmin.Size = new Size(322, 39);
            TXT_PhonenumberAdmin.TabIndex = 77;
            // 
            // LBL_EmailAdmin
            // 
            LBL_EmailAdmin.AutoSize = true;
            LBL_EmailAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_EmailAdmin.ForeColor = SystemColors.ButtonHighlight;
            LBL_EmailAdmin.Location = new Point(152, 840);
            LBL_EmailAdmin.Name = "LBL_EmailAdmin";
            LBL_EmailAdmin.Size = new Size(88, 32);
            LBL_EmailAdmin.TabIndex = 76;
            LBL_EmailAdmin.Text = "Email :";
            // 
            // LBL_PhoneNumberAdmin
            // 
            LBL_PhoneNumberAdmin.AutoSize = true;
            LBL_PhoneNumberAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_PhoneNumberAdmin.ForeColor = SystemColors.ButtonHighlight;
            LBL_PhoneNumberAdmin.Location = new Point(57, 721);
            LBL_PhoneNumberAdmin.Name = "LBL_PhoneNumberAdmin";
            LBL_PhoneNumberAdmin.Size = new Size(183, 32);
            LBL_PhoneNumberAdmin.TabIndex = 75;
            LBL_PhoneNumberAdmin.Text = "PhoneNumber :";
            // 
            // TXT_UserNameAdmin
            // 
            TXT_UserNameAdmin.BackColor = Color.MediumSlateBlue;
            TXT_UserNameAdmin.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_UserNameAdmin.ForeColor = SystemColors.ButtonHighlight;
            TXT_UserNameAdmin.Location = new Point(251, 571);
            TXT_UserNameAdmin.Name = "TXT_UserNameAdmin";
            TXT_UserNameAdmin.Size = new Size(322, 39);
            TXT_UserNameAdmin.TabIndex = 74;
            // 
            // LBL_PasswordAdmin
            // 
            LBL_PasswordAdmin.AutoSize = true;
            LBL_PasswordAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_PasswordAdmin.ForeColor = SystemColors.ButtonHighlight;
            LBL_PasswordAdmin.Location = new Point(607, 718);
            LBL_PasswordAdmin.Name = "LBL_PasswordAdmin";
            LBL_PasswordAdmin.Size = new Size(129, 32);
            LBL_PasswordAdmin.TabIndex = 73;
            LBL_PasswordAdmin.Text = "Password :";
            // 
            // LBL_userNameAdmin
            // 
            LBL_userNameAdmin.AutoSize = true;
            LBL_userNameAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_userNameAdmin.ForeColor = SystemColors.ButtonHighlight;
            LBL_userNameAdmin.Location = new Point(99, 575);
            LBL_userNameAdmin.Name = "LBL_userNameAdmin";
            LBL_userNameAdmin.Size = new Size(141, 32);
            LBL_userNameAdmin.TabIndex = 72;
            LBL_userNameAdmin.Text = "UserName :";
            // 
            // BTN_ResetAdmin
            // 
            BTN_ResetAdmin.BackColor = Color.SlateBlue;
            BTN_ResetAdmin.FlatAppearance.BorderSize = 0;
            BTN_ResetAdmin.FlatStyle = FlatStyle.Flat;
            BTN_ResetAdmin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_ResetAdmin.ForeColor = SystemColors.ButtonHighlight;
            BTN_ResetAdmin.Image = Properties.Resources.resetteewdt;
            BTN_ResetAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_ResetAdmin.Location = new Point(862, 415);
            BTN_ResetAdmin.Name = "BTN_ResetAdmin";
            BTN_ResetAdmin.Padding = new Padding(10, 0, 20, 0);
            BTN_ResetAdmin.Size = new Size(202, 195);
            BTN_ResetAdmin.TabIndex = 71;
            BTN_ResetAdmin.Text = " Reset";
            BTN_ResetAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BTN_ResetAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_ResetAdmin.UseVisualStyleBackColor = false;
            BTN_ResetAdmin.Click += BTN_ResetAdmin_Click;
            // 
            // BTN_CreateAdmin
            // 
            BTN_CreateAdmin.BackColor = Color.OliveDrab;
            BTN_CreateAdmin.FlatAppearance.BorderSize = 0;
            BTN_CreateAdmin.FlatStyle = FlatStyle.Flat;
            BTN_CreateAdmin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_CreateAdmin.ForeColor = SystemColors.ButtonHighlight;
            BTN_CreateAdmin.Image = Properties.Resources.plusaad1;
            BTN_CreateAdmin.ImageAlign = ContentAlignment.TopLeft;
            BTN_CreateAdmin.Location = new Point(133, 415);
            BTN_CreateAdmin.Name = "BTN_CreateAdmin";
            BTN_CreateAdmin.Padding = new Padding(10, 0, 20, 0);
            BTN_CreateAdmin.Size = new Size(202, 75);
            BTN_CreateAdmin.TabIndex = 70;
            BTN_CreateAdmin.Text = "Create";
            BTN_CreateAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BTN_CreateAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_CreateAdmin.UseVisualStyleBackColor = false;
            BTN_CreateAdmin.Click += BTN_CreateAdmin_Click;
            // 
            // LBL_ShowIDAdmin
            // 
            LBL_ShowIDAdmin.AutoSize = true;
            LBL_ShowIDAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_ShowIDAdmin.ForeColor = SystemColors.ButtonHighlight;
            LBL_ShowIDAdmin.Location = new Point(261, 660);
            LBL_ShowIDAdmin.Name = "LBL_ShowIDAdmin";
            LBL_ShowIDAdmin.Size = new Size(34, 32);
            LBL_ShowIDAdmin.TabIndex = 69;
            LBL_ShowIDAdmin.Text = "__";
            // 
            // lbl_IDAdmin
            // 
            lbl_IDAdmin.AutoSize = true;
            lbl_IDAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_IDAdmin.ForeColor = SystemColors.ButtonHighlight;
            lbl_IDAdmin.Location = new Point(116, 660);
            lbl_IDAdmin.Name = "lbl_IDAdmin";
            lbl_IDAdmin.Size = new Size(124, 32);
            lbl_IDAdmin.TabIndex = 68;
            lbl_IDAdmin.Text = "AdminID :";
            // 
            // BTN_DeleteAdmin
            // 
            BTN_DeleteAdmin.BackColor = Color.DarkRed;
            BTN_DeleteAdmin.FlatAppearance.BorderSize = 0;
            BTN_DeleteAdmin.FlatStyle = FlatStyle.Flat;
            BTN_DeleteAdmin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_DeleteAdmin.ForeColor = SystemColors.ButtonHighlight;
            BTN_DeleteAdmin.Image = Properties.Resources.deletedss;
            BTN_DeleteAdmin.ImageAlign = ContentAlignment.TopLeft;
            BTN_DeleteAdmin.Location = new Point(616, 415);
            BTN_DeleteAdmin.Name = "BTN_DeleteAdmin";
            BTN_DeleteAdmin.Padding = new Padding(10, 0, 20, 0);
            BTN_DeleteAdmin.Size = new Size(202, 75);
            BTN_DeleteAdmin.TabIndex = 67;
            BTN_DeleteAdmin.Text = "  Delete";
            BTN_DeleteAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BTN_DeleteAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_DeleteAdmin.UseVisualStyleBackColor = false;
            BTN_DeleteAdmin.Click += BTN_DeleteAdmin_Click;
            // 
            // BTN_UpdateAdmin
            // 
            BTN_UpdateAdmin.BackColor = Color.DarkSlateGray;
            BTN_UpdateAdmin.FlatAppearance.BorderSize = 0;
            BTN_UpdateAdmin.FlatStyle = FlatStyle.Flat;
            BTN_UpdateAdmin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_UpdateAdmin.ForeColor = SystemColors.ButtonHighlight;
            BTN_UpdateAdmin.Image = Properties.Resources.updateeewdw;
            BTN_UpdateAdmin.ImageAlign = ContentAlignment.TopLeft;
            BTN_UpdateAdmin.Location = new Point(371, 415);
            BTN_UpdateAdmin.Name = "BTN_UpdateAdmin";
            BTN_UpdateAdmin.Padding = new Padding(10, 0, 20, 0);
            BTN_UpdateAdmin.Size = new Size(202, 75);
            BTN_UpdateAdmin.TabIndex = 66;
            BTN_UpdateAdmin.Text = "Update";
            BTN_UpdateAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BTN_UpdateAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_UpdateAdmin.UseVisualStyleBackColor = false;
            BTN_UpdateAdmin.Click += BTN_UpdateAdmin_Click;
            // 
            // LBL_LastNameAdmin
            // 
            LBL_LastNameAdmin.AutoSize = true;
            LBL_LastNameAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_LastNameAdmin.ForeColor = SystemColors.ButtonHighlight;
            LBL_LastNameAdmin.Location = new Point(592, 779);
            LBL_LastNameAdmin.Name = "LBL_LastNameAdmin";
            LBL_LastNameAdmin.Size = new Size(144, 32);
            LBL_LastNameAdmin.TabIndex = 65;
            LBL_LastNameAdmin.Text = "Last Name :";
            // 
            // LBL_FirstNameAdmin
            // 
            LBL_FirstNameAdmin.AutoSize = true;
            LBL_FirstNameAdmin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_FirstNameAdmin.ForeColor = SystemColors.ButtonHighlight;
            LBL_FirstNameAdmin.Location = new Point(99, 779);
            LBL_FirstNameAdmin.Name = "LBL_FirstNameAdmin";
            LBL_FirstNameAdmin.Size = new Size(146, 32);
            LBL_FirstNameAdmin.TabIndex = 64;
            LBL_FirstNameAdmin.Text = "First Name :";
            // 
            // TXT_Salary
            // 
            TXT_Salary.BackColor = Color.MediumSlateBlue;
            TXT_Salary.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_Salary.ForeColor = SystemColors.ButtonHighlight;
            TXT_Salary.Location = new Point(742, 653);
            TXT_Salary.Name = "TXT_Salary";
            TXT_Salary.Size = new Size(322, 39);
            TXT_Salary.TabIndex = 86;
            // 
            // LBL_Salary
            // 
            LBL_Salary.AutoSize = true;
            LBL_Salary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Salary.ForeColor = SystemColors.ButtonHighlight;
            LBL_Salary.Location = new Point(641, 656);
            LBL_Salary.Name = "LBL_Salary";
            LBL_Salary.Size = new Size(95, 32);
            LBL_Salary.TabIndex = 85;
            LBL_Salary.Text = "Salary :";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1036);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 100);
            panel1.TabIndex = 87;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(40, 0, 64);
            ClientSize = new Size(1176, 1136);
            Controls.Add(panel1);
            Controls.Add(TXT_Salary);
            Controls.Add(LBL_Salary);
            Controls.Add(BTN_FindAdmin);
            Controls.Add(TXT_LastNameAdmin);
            Controls.Add(TXT_PasswordAdmin);
            Controls.Add(TXT_FirstNameAdmin);
            Controls.Add(TXT_AddressAdmin);
            Controls.Add(LBL_AddressAdmin);
            Controls.Add(TXT_EmailAdmin);
            Controls.Add(TXT_PhonenumberAdmin);
            Controls.Add(LBL_EmailAdmin);
            Controls.Add(LBL_PhoneNumberAdmin);
            Controls.Add(TXT_UserNameAdmin);
            Controls.Add(LBL_PasswordAdmin);
            Controls.Add(LBL_userNameAdmin);
            Controls.Add(BTN_ResetAdmin);
            Controls.Add(BTN_CreateAdmin);
            Controls.Add(LBL_ShowIDAdmin);
            Controls.Add(lbl_IDAdmin);
            Controls.Add(BTN_DeleteAdmin);
            Controls.Add(BTN_UpdateAdmin);
            Controls.Add(LBL_LastNameAdmin);
            Controls.Add(LBL_FirstNameAdmin);
            Controls.Add(DGV_Admins);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Admins).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_Admins;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private BindingSource adminBindingSource;
        private Button BTN_FindAdmin;
        private TextBox TXT_LastNameAdmin;
        private TextBox TXT_PasswordAdmin;
        private TextBox TXT_FirstNameAdmin;
        private TextBox TXT_AddressAdmin;
        private Label LBL_AddressAdmin;
        private TextBox TXT_EmailAdmin;
        private TextBox TXT_PhonenumberAdmin;
        private Label LBL_EmailAdmin;
        private Label LBL_PhoneNumberAdmin;
        private TextBox TXT_UserNameAdmin;
        private Label LBL_PasswordAdmin;
        private Label LBL_userNameAdmin;
        private Button BTN_ResetAdmin;
        private Button BTN_CreateAdmin;
        private Label LBL_ShowIDAdmin;
        private Label lbl_IDAdmin;
        private Button BTN_DeleteAdmin;
        private Button BTN_UpdateAdmin;
        private Label LBL_LastNameAdmin;
        private Label LBL_FirstNameAdmin;
        private TextBox TXT_Salary;
        private Label LBL_Salary;
        private Panel panel1;
    }
}