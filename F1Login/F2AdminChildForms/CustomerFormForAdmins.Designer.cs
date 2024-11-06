namespace F1Login.F2AdminChildForms
{
    partial class CustomerFormForAdmins
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
            panel1 = new Panel();
            customerBindingSource = new BindingSource(components);
            BTN_Reset = new Button();
            BTN_CreateFavor = new Button();
            LBL_ShowID = new Label();
            lbl_ID = new Label();
            BTN_DeleteFavor = new Button();
            BTN_UpdateFavor = new Button();
            LBL_Unitprice = new Label();
            LBL_FirstName = new Label();
            TXT_UserName = new TextBox();
            LBL_Password = new Label();
            LBL_userName = new Label();
            TXT_Email = new TextBox();
            TXT_Phonenumber = new TextBox();
            label1 = new Label();
            LBL_PhoneNumber = new Label();
            TXT_Address = new TextBox();
            label2 = new Label();
            TXT_FirstName = new TextBox();
            TXT_Password = new TextBox();
            TXT_LastName = new TextBox();
            DGV_Customers = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            BTN_Find = new Button();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Customers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 25, 50);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1038);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 98);
            panel1.TabIndex = 0;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Repository.Models.Customer);
            // 
            // BTN_Reset
            // 
            BTN_Reset.BackColor = Color.SlateBlue;
            BTN_Reset.FlatAppearance.BorderSize = 0;
            BTN_Reset.FlatStyle = FlatStyle.Flat;
            BTN_Reset.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Reset.ForeColor = SystemColors.ButtonHighlight;
            BTN_Reset.Image = Properties.Resources.resetteewdt;
            BTN_Reset.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Reset.Location = new Point(844, 413);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Padding = new Padding(10, 0, 20, 0);
            BTN_Reset.Size = new Size(202, 195);
            BTN_Reset.TabIndex = 41;
            BTN_Reset.Text = " Reset";
            BTN_Reset.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Reset.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Reset.UseVisualStyleBackColor = false;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // BTN_CreateFavor
            // 
            BTN_CreateFavor.BackColor = Color.OliveDrab;
            BTN_CreateFavor.FlatAppearance.BorderSize = 0;
            BTN_CreateFavor.FlatStyle = FlatStyle.Flat;
            BTN_CreateFavor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_CreateFavor.ForeColor = SystemColors.ButtonHighlight;
            BTN_CreateFavor.Image = Properties.Resources.plusaad1;
            BTN_CreateFavor.ImageAlign = ContentAlignment.TopLeft;
            BTN_CreateFavor.Location = new Point(115, 413);
            BTN_CreateFavor.Name = "BTN_CreateFavor";
            BTN_CreateFavor.Padding = new Padding(10, 0, 20, 0);
            BTN_CreateFavor.Size = new Size(202, 75);
            BTN_CreateFavor.TabIndex = 40;
            BTN_CreateFavor.Text = "Create";
            BTN_CreateFavor.TextAlign = ContentAlignment.MiddleLeft;
            BTN_CreateFavor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_CreateFavor.UseVisualStyleBackColor = false;
            BTN_CreateFavor.Click += BTN_CreateFavor_Click;
            // 
            // LBL_ShowID
            // 
            LBL_ShowID.AutoSize = true;
            LBL_ShowID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_ShowID.ForeColor = SystemColors.ButtonHighlight;
            LBL_ShowID.Location = new Point(243, 630);
            LBL_ShowID.Name = "LBL_ShowID";
            LBL_ShowID.Size = new Size(34, 32);
            LBL_ShowID.TabIndex = 39;
            LBL_ShowID.Text = "__";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_ID.ForeColor = SystemColors.ButtonHighlight;
            lbl_ID.Location = new Point(73, 630);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(154, 32);
            lbl_ID.TabIndex = 38;
            lbl_ID.Text = "CustomerID :";
            // 
            // BTN_DeleteFavor
            // 
            BTN_DeleteFavor.BackColor = Color.DarkRed;
            BTN_DeleteFavor.FlatAppearance.BorderSize = 0;
            BTN_DeleteFavor.FlatStyle = FlatStyle.Flat;
            BTN_DeleteFavor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_DeleteFavor.ForeColor = SystemColors.ButtonHighlight;
            BTN_DeleteFavor.Image = Properties.Resources.deletedss;
            BTN_DeleteFavor.ImageAlign = ContentAlignment.TopLeft;
            BTN_DeleteFavor.Location = new Point(598, 413);
            BTN_DeleteFavor.Name = "BTN_DeleteFavor";
            BTN_DeleteFavor.Padding = new Padding(10, 0, 20, 0);
            BTN_DeleteFavor.Size = new Size(202, 75);
            BTN_DeleteFavor.TabIndex = 37;
            BTN_DeleteFavor.Text = "  Delete";
            BTN_DeleteFavor.TextAlign = ContentAlignment.MiddleLeft;
            BTN_DeleteFavor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_DeleteFavor.UseVisualStyleBackColor = false;
            BTN_DeleteFavor.Click += BTN_DeleteFavor_Click;
            // 
            // BTN_UpdateFavor
            // 
            BTN_UpdateFavor.BackColor = Color.DarkSlateGray;
            BTN_UpdateFavor.FlatAppearance.BorderSize = 0;
            BTN_UpdateFavor.FlatStyle = FlatStyle.Flat;
            BTN_UpdateFavor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_UpdateFavor.ForeColor = SystemColors.ButtonHighlight;
            BTN_UpdateFavor.Image = Properties.Resources.updateeewdw;
            BTN_UpdateFavor.ImageAlign = ContentAlignment.TopLeft;
            BTN_UpdateFavor.Location = new Point(353, 413);
            BTN_UpdateFavor.Name = "BTN_UpdateFavor";
            BTN_UpdateFavor.Padding = new Padding(10, 0, 20, 0);
            BTN_UpdateFavor.Size = new Size(202, 75);
            BTN_UpdateFavor.TabIndex = 36;
            BTN_UpdateFavor.Text = "Update";
            BTN_UpdateFavor.TextAlign = ContentAlignment.MiddleLeft;
            BTN_UpdateFavor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_UpdateFavor.UseVisualStyleBackColor = false;
            BTN_UpdateFavor.Click += BTN_UpdateFavor_Click;
            // 
            // LBL_Unitprice
            // 
            LBL_Unitprice.AutoSize = true;
            LBL_Unitprice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Unitprice.ForeColor = SystemColors.ButtonHighlight;
            LBL_Unitprice.Location = new Point(574, 749);
            LBL_Unitprice.Name = "LBL_Unitprice";
            LBL_Unitprice.Size = new Size(144, 32);
            LBL_Unitprice.TabIndex = 33;
            LBL_Unitprice.Text = "Last Name :";
            // 
            // LBL_FirstName
            // 
            LBL_FirstName.AutoSize = true;
            LBL_FirstName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_FirstName.ForeColor = SystemColors.ButtonHighlight;
            LBL_FirstName.Location = new Point(81, 749);
            LBL_FirstName.Name = "LBL_FirstName";
            LBL_FirstName.Size = new Size(146, 32);
            LBL_FirstName.TabIndex = 32;
            LBL_FirstName.Text = "First Name :";
            // 
            // TXT_UserName
            // 
            TXT_UserName.BackColor = Color.MediumSlateBlue;
            TXT_UserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_UserName.ForeColor = SystemColors.ButtonHighlight;
            TXT_UserName.Location = new Point(233, 569);
            TXT_UserName.Name = "TXT_UserName";
            TXT_UserName.Size = new Size(322, 39);
            TXT_UserName.TabIndex = 44;
            // 
            // LBL_Password
            // 
            LBL_Password.AutoSize = true;
            LBL_Password.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Password.ForeColor = SystemColors.ButtonHighlight;
            LBL_Password.Location = new Point(589, 688);
            LBL_Password.Name = "LBL_Password";
            LBL_Password.Size = new Size(129, 32);
            LBL_Password.TabIndex = 43;
            LBL_Password.Text = "Password :";
            // 
            // LBL_userName
            // 
            LBL_userName.AutoSize = true;
            LBL_userName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_userName.ForeColor = SystemColors.ButtonHighlight;
            LBL_userName.Location = new Point(81, 573);
            LBL_userName.Name = "LBL_userName";
            LBL_userName.Size = new Size(141, 32);
            LBL_userName.TabIndex = 42;
            LBL_userName.Text = "UserName :";
            // 
            // TXT_Email
            // 
            TXT_Email.BackColor = Color.MediumSlateBlue;
            TXT_Email.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_Email.ForeColor = SystemColors.ButtonHighlight;
            TXT_Email.Location = new Point(233, 807);
            TXT_Email.Name = "TXT_Email";
            TXT_Email.Size = new Size(813, 39);
            TXT_Email.TabIndex = 49;
            // 
            // TXT_Phonenumber
            // 
            TXT_Phonenumber.BackColor = Color.MediumSlateBlue;
            TXT_Phonenumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_Phonenumber.ForeColor = SystemColors.ButtonHighlight;
            TXT_Phonenumber.Location = new Point(233, 687);
            TXT_Phonenumber.Name = "TXT_Phonenumber";
            TXT_Phonenumber.Size = new Size(322, 39);
            TXT_Phonenumber.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(134, 810);
            label1.Name = "label1";
            label1.Size = new Size(88, 32);
            label1.TabIndex = 47;
            label1.Text = "Email :";
            // 
            // LBL_PhoneNumber
            // 
            LBL_PhoneNumber.AutoSize = true;
            LBL_PhoneNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_PhoneNumber.ForeColor = SystemColors.ButtonHighlight;
            LBL_PhoneNumber.Location = new Point(39, 691);
            LBL_PhoneNumber.Name = "LBL_PhoneNumber";
            LBL_PhoneNumber.Size = new Size(183, 32);
            LBL_PhoneNumber.TabIndex = 46;
            LBL_PhoneNumber.Text = "PhoneNumber :";
            // 
            // TXT_Address
            // 
            TXT_Address.BackColor = Color.MediumSlateBlue;
            TXT_Address.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_Address.ForeColor = SystemColors.ButtonHighlight;
            TXT_Address.Location = new Point(233, 868);
            TXT_Address.Multiline = true;
            TXT_Address.Name = "TXT_Address";
            TXT_Address.Size = new Size(813, 87);
            TXT_Address.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(115, 871);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 50;
            label2.Text = "Address :";
            // 
            // TXT_FirstName
            // 
            TXT_FirstName.BackColor = Color.MediumSlateBlue;
            TXT_FirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_FirstName.ForeColor = SystemColors.ButtonHighlight;
            TXT_FirstName.Location = new Point(233, 746);
            TXT_FirstName.Name = "TXT_FirstName";
            TXT_FirstName.Size = new Size(322, 39);
            TXT_FirstName.TabIndex = 52;
            // 
            // TXT_Password
            // 
            TXT_Password.BackColor = Color.MediumSlateBlue;
            TXT_Password.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_Password.ForeColor = SystemColors.ButtonHighlight;
            TXT_Password.Location = new Point(724, 684);
            TXT_Password.Name = "TXT_Password";
            TXT_Password.Size = new Size(322, 39);
            TXT_Password.TabIndex = 53;
            // 
            // TXT_LastName
            // 
            TXT_LastName.BackColor = Color.MediumSlateBlue;
            TXT_LastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_LastName.ForeColor = SystemColors.ButtonHighlight;
            TXT_LastName.Location = new Point(724, 746);
            TXT_LastName.Name = "TXT_LastName";
            TXT_LastName.Size = new Size(322, 39);
            TXT_LastName.TabIndex = 54;
            // 
            // DGV_Customers
            // 
            DGV_Customers.AutoGenerateColumns = false;
            DGV_Customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Customers.BackgroundColor = Color.MediumSlateBlue;
            DGV_Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Customers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            DGV_Customers.DataSource = customerBindingSource;
            DGV_Customers.Location = new Point(27, 26);
            DGV_Customers.MultiSelect = false;
            DGV_Customers.Name = "DGV_Customers";
            DGV_Customers.ReadOnly = true;
            DGV_Customers.RowHeadersVisible = false;
            DGV_Customers.RowHeadersWidth = 72;
            DGV_Customers.RowTemplate.Height = 37;
            DGV_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Customers.Size = new Size(1121, 343);
            DGV_Customers.TabIndex = 55;
            DGV_Customers.SelectionChanged += DGV_Customers_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            dataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            dataGridViewTextBoxColumn1.MinimumWidth = 9;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Firstname";
            dataGridViewTextBoxColumn2.HeaderText = "Firstname";
            dataGridViewTextBoxColumn2.MinimumWidth = 9;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Lastname";
            dataGridViewTextBoxColumn3.HeaderText = "Lastname";
            dataGridViewTextBoxColumn3.MinimumWidth = 9;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Username";
            dataGridViewTextBoxColumn4.HeaderText = "Username";
            dataGridViewTextBoxColumn4.MinimumWidth = 9;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Password";
            dataGridViewTextBoxColumn5.HeaderText = "Password";
            dataGridViewTextBoxColumn5.MinimumWidth = 9;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            dataGridViewTextBoxColumn6.HeaderText = "Email";
            dataGridViewTextBoxColumn6.MinimumWidth = 9;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "PhoneNumber";
            dataGridViewTextBoxColumn7.HeaderText = "PhoneNumber";
            dataGridViewTextBoxColumn7.MinimumWidth = 9;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            dataGridViewTextBoxColumn8.HeaderText = "Address";
            dataGridViewTextBoxColumn8.MinimumWidth = 9;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // BTN_Find
            // 
            BTN_Find.BackColor = Color.DarkOrange;
            BTN_Find.FlatAppearance.BorderSize = 0;
            BTN_Find.FlatStyle = FlatStyle.Flat;
            BTN_Find.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Find.ForeColor = SystemColors.ButtonHighlight;
            BTN_Find.Image = Properties.Resources.gettt1;
            BTN_Find.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Find.Location = new Point(598, 533);
            BTN_Find.Name = "BTN_Find";
            BTN_Find.Padding = new Padding(10, 0, 20, 0);
            BTN_Find.Size = new Size(202, 75);
            BTN_Find.TabIndex = 63;
            BTN_Find.Text = " Find";
            BTN_Find.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Find.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Find.UseVisualStyleBackColor = false;
            BTN_Find.Click += BTN_Find_Click;
            // 
            // CustomerFormForAdmins
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(30, 30, 60);
            ClientSize = new Size(1176, 1136);
            Controls.Add(BTN_Find);
            Controls.Add(DGV_Customers);
            Controls.Add(TXT_LastName);
            Controls.Add(TXT_Password);
            Controls.Add(TXT_FirstName);
            Controls.Add(TXT_Address);
            Controls.Add(label2);
            Controls.Add(TXT_Email);
            Controls.Add(TXT_Phonenumber);
            Controls.Add(label1);
            Controls.Add(LBL_PhoneNumber);
            Controls.Add(TXT_UserName);
            Controls.Add(LBL_Password);
            Controls.Add(LBL_userName);
            Controls.Add(BTN_Reset);
            Controls.Add(BTN_CreateFavor);
            Controls.Add(LBL_ShowID);
            Controls.Add(lbl_ID);
            Controls.Add(BTN_DeleteFavor);
            Controls.Add(BTN_UpdateFavor);
            Controls.Add(LBL_Unitprice);
            Controls.Add(LBL_FirstName);
            Controls.Add(panel1);
            Name = "CustomerFormForAdmins";
            Text = "CustomerFormForAdmins";
            Load += CustomerFormForAdmins_Load;
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Customers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private Button BTN_Reset;
        private Button BTN_CreateFavor;
        private Label LBL_ShowID;
        private Label lbl_ID;
        private Button BTN_DeleteFavor;
        private Button BTN_UpdateFavor;
        private Label LBL_Unitprice;
        private Label LBL_FirstName;
        private TextBox textBox1;
        private TextBox TXT_UserName;
        private Label LBL_Password;
        private Label LBL_userName;
        private TextBox TXT_Email;
        private TextBox TXT_Phonenumber;
        private Label label1;
        private Label LBL_PhoneNumber;
        private TextBox TXT_Address;
        private Label label2;
        private TextBox TXT_FirstName;
        private TextBox TXT_Password;
        private TextBox TXT_LastName;
        private DataGridView DGV_Customers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Button BTN_Find;
    }
}