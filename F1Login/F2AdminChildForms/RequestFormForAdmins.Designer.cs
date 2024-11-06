namespace F1Login.F2AdminChildForms
{
    partial class RequestFormForAdmins
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
            requestBindingSource = new BindingSource(components);
            BTN_FindByReqID = new Button();
            TXT_customerID = new TextBox();
            LBL_CustomerID = new Label();
            BTN_Reset = new Button();
            BTN_Delete = new Button();
            TXT_RequestID = new TextBox();
            LBL_RequestID = new Label();
            BTN_FindByCustomer = new Button();
            TXT_DateCreated = new TextBox();
            LBL_dateCreated = new Label();
            TXT_HasAlarm = new TextBox();
            LBL_HasAlarm = new Label();
            TXT_HasCleaningSupply = new TextBox();
            LBL_HasCleaningSupply = new Label();
            TXT_HasPets = new TextBox();
            LBL_HasPets = new Label();
            TXT_Discount = new TextBox();
            LBL_Discount = new Label();
            BTN_UpdateRequest = new Button();
            panel1 = new Panel();
            label1 = new Label();
            DGV_Requests = new DataGridView();
            requestBindingSource1 = new BindingSource(components);
            requestBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)requestBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Requests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // requestBindingSource
            // 
            requestBindingSource.DataSource = typeof(Repository.Models.Request);
            // 
            // BTN_FindByReqID
            // 
            BTN_FindByReqID.BackColor = Color.DarkOrange;
            BTN_FindByReqID.FlatAppearance.BorderSize = 0;
            BTN_FindByReqID.FlatStyle = FlatStyle.Flat;
            BTN_FindByReqID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_FindByReqID.ForeColor = SystemColors.ButtonHighlight;
            BTN_FindByReqID.Image = Properties.Resources.gettt1;
            BTN_FindByReqID.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_FindByReqID.Location = new Point(461, 536);
            BTN_FindByReqID.Name = "BTN_FindByReqID";
            BTN_FindByReqID.Padding = new Padding(10, 0, 20, 0);
            BTN_FindByReqID.Size = new Size(355, 75);
            BTN_FindByReqID.TabIndex = 77;
            BTN_FindByReqID.Text = "Find By RequestID";
            BTN_FindByReqID.TextAlign = ContentAlignment.MiddleLeft;
            BTN_FindByReqID.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_FindByReqID.UseVisualStyleBackColor = false;
            BTN_FindByReqID.Click += BTN_FindByReqID_Click;
            // 
            // TXT_customerID
            // 
            TXT_customerID.BackColor = Color.MediumSlateBlue;
            TXT_customerID.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_customerID.ForeColor = SystemColors.ButtonHighlight;
            TXT_customerID.Location = new Point(265, 662);
            TXT_customerID.Name = "TXT_customerID";
            TXT_customerID.Size = new Size(144, 39);
            TXT_customerID.TabIndex = 76;
            // 
            // LBL_CustomerID
            // 
            LBL_CustomerID.AutoSize = true;
            LBL_CustomerID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_CustomerID.ForeColor = SystemColors.ButtonHighlight;
            LBL_CustomerID.Location = new Point(105, 665);
            LBL_CustomerID.Name = "LBL_CustomerID";
            LBL_CustomerID.Size = new Size(154, 32);
            LBL_CustomerID.TabIndex = 75;
            LBL_CustomerID.Text = "CustomerID :";
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
            BTN_Reset.Location = new Point(863, 419);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Padding = new Padding(10, 0, 20, 0);
            BTN_Reset.Size = new Size(202, 298);
            BTN_Reset.TabIndex = 74;
            BTN_Reset.Text = " Reset";
            BTN_Reset.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Reset.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Reset.UseVisualStyleBackColor = false;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // BTN_Delete
            // 
            BTN_Delete.BackColor = Color.DarkRed;
            BTN_Delete.FlatAppearance.BorderSize = 0;
            BTN_Delete.FlatStyle = FlatStyle.Flat;
            BTN_Delete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Delete.ForeColor = SystemColors.ButtonHighlight;
            BTN_Delete.Image = Properties.Resources.deletedss;
            BTN_Delete.ImageAlign = ContentAlignment.TopLeft;
            BTN_Delete.Location = new Point(505, 419);
            BTN_Delete.Name = "BTN_Delete";
            BTN_Delete.Padding = new Padding(10, 0, 20, 0);
            BTN_Delete.Size = new Size(311, 75);
            BTN_Delete.TabIndex = 72;
            BTN_Delete.Text = "      Delete";
            BTN_Delete.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Delete.UseVisualStyleBackColor = false;
            BTN_Delete.Click += BTN_Delete_Click;
            // 
            // TXT_RequestID
            // 
            TXT_RequestID.BackColor = Color.MediumSlateBlue;
            TXT_RequestID.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_RequestID.ForeColor = SystemColors.ButtonHighlight;
            TXT_RequestID.Location = new Point(265, 556);
            TXT_RequestID.Name = "TXT_RequestID";
            TXT_RequestID.Size = new Size(144, 39);
            TXT_RequestID.TabIndex = 79;
            // 
            // LBL_RequestID
            // 
            LBL_RequestID.AutoSize = true;
            LBL_RequestID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_RequestID.ForeColor = SystemColors.ButtonHighlight;
            LBL_RequestID.Location = new Point(122, 559);
            LBL_RequestID.Name = "LBL_RequestID";
            LBL_RequestID.Size = new Size(137, 32);
            LBL_RequestID.TabIndex = 78;
            LBL_RequestID.Text = "RequestID :";
            // 
            // BTN_FindByCustomer
            // 
            BTN_FindByCustomer.BackColor = Color.DarkOrange;
            BTN_FindByCustomer.FlatAppearance.BorderSize = 0;
            BTN_FindByCustomer.FlatStyle = FlatStyle.Flat;
            BTN_FindByCustomer.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_FindByCustomer.ForeColor = SystemColors.ButtonHighlight;
            BTN_FindByCustomer.Image = Properties.Resources.gettt1;
            BTN_FindByCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_FindByCustomer.Location = new Point(461, 642);
            BTN_FindByCustomer.Name = "BTN_FindByCustomer";
            BTN_FindByCustomer.Padding = new Padding(10, 0, 20, 0);
            BTN_FindByCustomer.Size = new Size(355, 75);
            BTN_FindByCustomer.TabIndex = 80;
            BTN_FindByCustomer.Text = "Find By CustomerID";
            BTN_FindByCustomer.TextAlign = ContentAlignment.MiddleLeft;
            BTN_FindByCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_FindByCustomer.UseVisualStyleBackColor = false;
            BTN_FindByCustomer.Click += BTN_FindByCustomer_Click;
            // 
            // TXT_DateCreated
            // 
            TXT_DateCreated.BackColor = Color.MediumSlateBlue;
            TXT_DateCreated.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_DateCreated.ForeColor = SystemColors.ButtonHighlight;
            TXT_DateCreated.Location = new Point(265, 756);
            TXT_DateCreated.Name = "TXT_DateCreated";
            TXT_DateCreated.Size = new Size(800, 39);
            TXT_DateCreated.TabIndex = 82;
            // 
            // LBL_dateCreated
            // 
            LBL_dateCreated.AutoSize = true;
            LBL_dateCreated.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_dateCreated.ForeColor = SystemColors.ButtonHighlight;
            LBL_dateCreated.Location = new Point(89, 759);
            LBL_dateCreated.Name = "LBL_dateCreated";
            LBL_dateCreated.Size = new Size(170, 32);
            LBL_dateCreated.TabIndex = 81;
            LBL_dateCreated.Text = "Date Created :";
            // 
            // TXT_HasAlarm
            // 
            TXT_HasAlarm.BackColor = Color.MediumSlateBlue;
            TXT_HasAlarm.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_HasAlarm.ForeColor = SystemColors.ButtonHighlight;
            TXT_HasAlarm.Location = new Point(265, 822);
            TXT_HasAlarm.Name = "TXT_HasAlarm";
            TXT_HasAlarm.Size = new Size(252, 39);
            TXT_HasAlarm.TabIndex = 84;
            // 
            // LBL_HasAlarm
            // 
            LBL_HasAlarm.AutoSize = true;
            LBL_HasAlarm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_HasAlarm.ForeColor = SystemColors.ButtonHighlight;
            LBL_HasAlarm.Location = new Point(123, 825);
            LBL_HasAlarm.Name = "LBL_HasAlarm";
            LBL_HasAlarm.Size = new Size(136, 32);
            LBL_HasAlarm.TabIndex = 83;
            LBL_HasAlarm.Text = "HasAlarm :";
            // 
            // TXT_HasCleaningSupply
            // 
            TXT_HasCleaningSupply.BackColor = Color.MediumSlateBlue;
            TXT_HasCleaningSupply.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_HasCleaningSupply.ForeColor = SystemColors.ButtonHighlight;
            TXT_HasCleaningSupply.Location = new Point(813, 822);
            TXT_HasCleaningSupply.Name = "TXT_HasCleaningSupply";
            TXT_HasCleaningSupply.Size = new Size(252, 39);
            TXT_HasCleaningSupply.TabIndex = 86;
            // 
            // LBL_HasCleaningSupply
            // 
            LBL_HasCleaningSupply.AutoSize = true;
            LBL_HasCleaningSupply.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_HasCleaningSupply.ForeColor = SystemColors.ButtonHighlight;
            LBL_HasCleaningSupply.Location = new Point(568, 825);
            LBL_HasCleaningSupply.Name = "LBL_HasCleaningSupply";
            LBL_HasCleaningSupply.Size = new Size(239, 32);
            LBL_HasCleaningSupply.TabIndex = 85;
            LBL_HasCleaningSupply.Text = "HasCleaningSupply :";
            // 
            // TXT_HasPets
            // 
            TXT_HasPets.BackColor = Color.MediumSlateBlue;
            TXT_HasPets.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_HasPets.ForeColor = SystemColors.ButtonHighlight;
            TXT_HasPets.Location = new Point(265, 886);
            TXT_HasPets.Name = "TXT_HasPets";
            TXT_HasPets.Size = new Size(252, 39);
            TXT_HasPets.TabIndex = 88;
            // 
            // LBL_HasPets
            // 
            LBL_HasPets.AutoSize = true;
            LBL_HasPets.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_HasPets.ForeColor = SystemColors.ButtonHighlight;
            LBL_HasPets.Location = new Point(146, 889);
            LBL_HasPets.Name = "LBL_HasPets";
            LBL_HasPets.Size = new Size(113, 32);
            LBL_HasPets.TabIndex = 87;
            LBL_HasPets.Text = "HasPets :";
            // 
            // TXT_Discount
            // 
            TXT_Discount.BackColor = Color.MediumSlateBlue;
            TXT_Discount.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_Discount.ForeColor = SystemColors.ButtonHighlight;
            TXT_Discount.Location = new Point(813, 883);
            TXT_Discount.Name = "TXT_Discount";
            TXT_Discount.Size = new Size(212, 39);
            TXT_Discount.TabIndex = 90;
            // 
            // LBL_Discount
            // 
            LBL_Discount.AutoSize = true;
            LBL_Discount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Discount.ForeColor = SystemColors.ButtonHighlight;
            LBL_Discount.Location = new Point(694, 886);
            LBL_Discount.Name = "LBL_Discount";
            LBL_Discount.Size = new Size(122, 32);
            LBL_Discount.TabIndex = 89;
            LBL_Discount.Text = "Discount :";
            // 
            // BTN_UpdateRequest
            // 
            BTN_UpdateRequest.BackColor = Color.DarkSlateGray;
            BTN_UpdateRequest.FlatAppearance.BorderSize = 0;
            BTN_UpdateRequest.FlatStyle = FlatStyle.Flat;
            BTN_UpdateRequest.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_UpdateRequest.ForeColor = SystemColors.ButtonHighlight;
            BTN_UpdateRequest.Image = Properties.Resources.updateeewdw;
            BTN_UpdateRequest.ImageAlign = ContentAlignment.TopLeft;
            BTN_UpdateRequest.Location = new Point(105, 419);
            BTN_UpdateRequest.Name = "BTN_UpdateRequest";
            BTN_UpdateRequest.Padding = new Padding(10, 0, 20, 0);
            BTN_UpdateRequest.Size = new Size(311, 75);
            BTN_UpdateRequest.TabIndex = 92;
            BTN_UpdateRequest.Text = "     Update";
            BTN_UpdateRequest.TextAlign = ContentAlignment.MiddleLeft;
            BTN_UpdateRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_UpdateRequest.UseVisualStyleBackColor = false;
            BTN_UpdateRequest.Click += BTN_UpdateRequest_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1171);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 65);
            panel1.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1031, 886);
            label1.Name = "label1";
            label1.Size = new Size(34, 32);
            label1.TabIndex = 94;
            label1.Text = "%";
            // 
            // DGV_Requests
            // 
            DGV_Requests.AllowUserToAddRows = false;
            DGV_Requests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Requests.BackgroundColor = Color.MediumSlateBlue;
            DGV_Requests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Requests.Location = new Point(29, 34);
            DGV_Requests.MultiSelect = false;
            DGV_Requests.Name = "DGV_Requests";
            DGV_Requests.ReadOnly = true;
            DGV_Requests.RowHeadersVisible = false;
            DGV_Requests.RowHeadersWidth = 72;
            DGV_Requests.RowTemplate.Height = 37;
            DGV_Requests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Requests.Size = new Size(1119, 343);
            DGV_Requests.TabIndex = 57;
            DGV_Requests.SelectionChanged += DGV_Requests_SelectionChanged;
            DGV_Requests.DoubleClick += DGV_Requests_DoubleClick;
            // 
            // requestBindingSource1
            // 
            requestBindingSource1.DataSource = typeof(Repository.Models.Request);
            // 
            // requestBindingSource2
            // 
            requestBindingSource2.DataSource = typeof(Repository.Models.Request);
            // 
            // RequestFormForAdmins
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(30, 30, 60);
            ClientSize = new Size(1176, 1236);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(BTN_UpdateRequest);
            Controls.Add(TXT_Discount);
            Controls.Add(LBL_Discount);
            Controls.Add(TXT_HasPets);
            Controls.Add(LBL_HasPets);
            Controls.Add(TXT_HasCleaningSupply);
            Controls.Add(LBL_HasCleaningSupply);
            Controls.Add(TXT_HasAlarm);
            Controls.Add(LBL_HasAlarm);
            Controls.Add(TXT_DateCreated);
            Controls.Add(LBL_dateCreated);
            Controls.Add(BTN_FindByCustomer);
            Controls.Add(TXT_RequestID);
            Controls.Add(LBL_RequestID);
            Controls.Add(BTN_FindByReqID);
            Controls.Add(TXT_customerID);
            Controls.Add(LBL_CustomerID);
            Controls.Add(BTN_Reset);
            Controls.Add(BTN_Delete);
            Controls.Add(DGV_Requests);
            Name = "RequestFormForAdmins";
            Text = "RequestFormForAdmins";
            Load += RequestFormForAdmins_Load;
            ((System.ComponentModel.ISupportInitialize)requestBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Requests).EndInit();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource requestBindingSource;
        private Button BTN_FindByReqID;
        private TextBox TXT_customerID;
        private Label LBL_CustomerID;
        private Button BTN_Reset;
        private Button BTN_Delete;
        private TextBox TXT_RequestID;
        private Label LBL_RequestID;
        private Button BTN_FindByCustomer;
        private TextBox TXT_DateCreated;
        private Label LBL_dateCreated;
        private TextBox TXT_HasAlarm;
        private Label LBL_HasAlarm;
        private TextBox TXT_HasCleaningSupply;
        private Label LBL_HasCleaningSupply;
        private TextBox TXT_HasPets;
        private Label LBL_HasPets;
        private TextBox TXT_Discount;
        private Label LBL_Discount;
        private Button BTN_UpdateRequest;
        private Panel panel1;
        private Label label1;
        private BindingSource requestBindingSource1;
        private DataGridView DGV_Requests;
        private BindingSource requestBindingSource2;
    }
}