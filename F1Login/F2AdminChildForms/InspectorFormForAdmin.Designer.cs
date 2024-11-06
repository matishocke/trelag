namespace F1Login.F2AdminChildForms
{
    partial class InspectorFormForAdmin
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
            DGV_AllRequests = new DataGridView();
            TXT_RequestIDIns = new TextBox();
            LBL_RequestIDIns = new Label();
            TXT_customerIDIns = new TextBox();
            LBL_CustomerIDIns = new Label();
            procentIns = new Label();
            TXT_DiscountIns = new TextBox();
            LBL_DiscountIns = new Label();
            TXT_HasPetsIns = new TextBox();
            LBL_HasPetsIns = new Label();
            TXT_HasCleaningSupplyIns = new TextBox();
            LBL_HasCleaningSupplyIns = new Label();
            TXT_HasAlarmIns = new TextBox();
            LBL_HasAlarmIns = new Label();
            TXT_DateCreatedIns = new TextBox();
            LBL_dateCreatedIns = new Label();
            BTN_FindByCustomerID = new Button();
            BTN_FindByRequestID = new Button();
            BTN_Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_AllRequests).BeginInit();
            SuspendLayout();
            // 
            // DGV_AllRequests
            // 
            DGV_AllRequests.AllowUserToAddRows = false;
            DGV_AllRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_AllRequests.BackgroundColor = Color.DarkSlateBlue;
            DGV_AllRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_AllRequests.Location = new Point(28, 35);
            DGV_AllRequests.MultiSelect = false;
            DGV_AllRequests.Name = "DGV_AllRequests";
            DGV_AllRequests.ReadOnly = true;
            DGV_AllRequests.RowHeadersVisible = false;
            DGV_AllRequests.RowHeadersWidth = 72;
            DGV_AllRequests.RowTemplate.Height = 37;
            DGV_AllRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_AllRequests.Size = new Size(1119, 343);
            DGV_AllRequests.TabIndex = 59;
            DGV_AllRequests.SelectionChanged += DGV_AllRequests_SelectionChanged;
            DGV_AllRequests.DoubleClick += DGV_AllRequests_DoubleClick;
            // 
            // TXT_RequestIDIns
            // 
            TXT_RequestIDIns.BackColor = Color.MediumSlateBlue;
            TXT_RequestIDIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_RequestIDIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_RequestIDIns.Location = new Point(254, 429);
            TXT_RequestIDIns.Name = "TXT_RequestIDIns";
            TXT_RequestIDIns.Size = new Size(144, 39);
            TXT_RequestIDIns.TabIndex = 83;
            // 
            // LBL_RequestIDIns
            // 
            LBL_RequestIDIns.AutoSize = true;
            LBL_RequestIDIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_RequestIDIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_RequestIDIns.Location = new Point(111, 432);
            LBL_RequestIDIns.Name = "LBL_RequestIDIns";
            LBL_RequestIDIns.Size = new Size(137, 32);
            LBL_RequestIDIns.TabIndex = 82;
            LBL_RequestIDIns.Text = "RequestID :";
            // 
            // TXT_customerIDIns
            // 
            TXT_customerIDIns.BackColor = Color.MediumSlateBlue;
            TXT_customerIDIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_customerIDIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_customerIDIns.Location = new Point(254, 525);
            TXT_customerIDIns.Name = "TXT_customerIDIns";
            TXT_customerIDIns.Size = new Size(144, 39);
            TXT_customerIDIns.TabIndex = 81;
            // 
            // LBL_CustomerIDIns
            // 
            LBL_CustomerIDIns.AutoSize = true;
            LBL_CustomerIDIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_CustomerIDIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_CustomerIDIns.Location = new Point(94, 528);
            LBL_CustomerIDIns.Name = "LBL_CustomerIDIns";
            LBL_CustomerIDIns.Size = new Size(154, 32);
            LBL_CustomerIDIns.TabIndex = 80;
            LBL_CustomerIDIns.Text = "CustomerID :";
            // 
            // procentIns
            // 
            procentIns.AutoSize = true;
            procentIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            procentIns.ForeColor = SystemColors.ButtonHighlight;
            procentIns.Location = new Point(1020, 742);
            procentIns.Name = "procentIns";
            procentIns.Size = new Size(34, 32);
            procentIns.TabIndex = 105;
            procentIns.Text = "%";
            // 
            // TXT_DiscountIns
            // 
            TXT_DiscountIns.BackColor = Color.MediumSlateBlue;
            TXT_DiscountIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_DiscountIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_DiscountIns.Location = new Point(802, 739);
            TXT_DiscountIns.Name = "TXT_DiscountIns";
            TXT_DiscountIns.Size = new Size(212, 39);
            TXT_DiscountIns.TabIndex = 104;
            // 
            // LBL_DiscountIns
            // 
            LBL_DiscountIns.AutoSize = true;
            LBL_DiscountIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_DiscountIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_DiscountIns.Location = new Point(674, 742);
            LBL_DiscountIns.Name = "LBL_DiscountIns";
            LBL_DiscountIns.Size = new Size(122, 32);
            LBL_DiscountIns.TabIndex = 103;
            LBL_DiscountIns.Text = "Discount :";
            // 
            // TXT_HasPetsIns
            // 
            TXT_HasPetsIns.BackColor = Color.MediumSlateBlue;
            TXT_HasPetsIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_HasPetsIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_HasPetsIns.Location = new Point(254, 742);
            TXT_HasPetsIns.Name = "TXT_HasPetsIns";
            TXT_HasPetsIns.Size = new Size(252, 39);
            TXT_HasPetsIns.TabIndex = 102;
            // 
            // LBL_HasPetsIns
            // 
            LBL_HasPetsIns.AutoSize = true;
            LBL_HasPetsIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_HasPetsIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_HasPetsIns.Location = new Point(135, 745);
            LBL_HasPetsIns.Name = "LBL_HasPetsIns";
            LBL_HasPetsIns.Size = new Size(113, 32);
            LBL_HasPetsIns.TabIndex = 101;
            LBL_HasPetsIns.Text = "HasPets :";
            // 
            // TXT_HasCleaningSupplyIns
            // 
            TXT_HasCleaningSupplyIns.BackColor = Color.MediumSlateBlue;
            TXT_HasCleaningSupplyIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_HasCleaningSupplyIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_HasCleaningSupplyIns.Location = new Point(802, 678);
            TXT_HasCleaningSupplyIns.Name = "TXT_HasCleaningSupplyIns";
            TXT_HasCleaningSupplyIns.Size = new Size(252, 39);
            TXT_HasCleaningSupplyIns.TabIndex = 100;
            // 
            // LBL_HasCleaningSupplyIns
            // 
            LBL_HasCleaningSupplyIns.AutoSize = true;
            LBL_HasCleaningSupplyIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_HasCleaningSupplyIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_HasCleaningSupplyIns.Location = new Point(557, 681);
            LBL_HasCleaningSupplyIns.Name = "LBL_HasCleaningSupplyIns";
            LBL_HasCleaningSupplyIns.Size = new Size(239, 32);
            LBL_HasCleaningSupplyIns.TabIndex = 99;
            LBL_HasCleaningSupplyIns.Text = "HasCleaningSupply :";
            // 
            // TXT_HasAlarmIns
            // 
            TXT_HasAlarmIns.BackColor = Color.MediumSlateBlue;
            TXT_HasAlarmIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_HasAlarmIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_HasAlarmIns.Location = new Point(254, 678);
            TXT_HasAlarmIns.Name = "TXT_HasAlarmIns";
            TXT_HasAlarmIns.Size = new Size(252, 39);
            TXT_HasAlarmIns.TabIndex = 98;
            // 
            // LBL_HasAlarmIns
            // 
            LBL_HasAlarmIns.AutoSize = true;
            LBL_HasAlarmIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_HasAlarmIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_HasAlarmIns.Location = new Point(112, 681);
            LBL_HasAlarmIns.Name = "LBL_HasAlarmIns";
            LBL_HasAlarmIns.Size = new Size(136, 32);
            LBL_HasAlarmIns.TabIndex = 97;
            LBL_HasAlarmIns.Text = "HasAlarm :";
            // 
            // TXT_DateCreatedIns
            // 
            TXT_DateCreatedIns.BackColor = Color.MediumSlateBlue;
            TXT_DateCreatedIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_DateCreatedIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_DateCreatedIns.Location = new Point(254, 612);
            TXT_DateCreatedIns.Name = "TXT_DateCreatedIns";
            TXT_DateCreatedIns.Size = new Size(800, 39);
            TXT_DateCreatedIns.TabIndex = 96;
            // 
            // LBL_dateCreatedIns
            // 
            LBL_dateCreatedIns.AutoSize = true;
            LBL_dateCreatedIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_dateCreatedIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_dateCreatedIns.Location = new Point(78, 615);
            LBL_dateCreatedIns.Name = "LBL_dateCreatedIns";
            LBL_dateCreatedIns.Size = new Size(170, 32);
            LBL_dateCreatedIns.TabIndex = 95;
            LBL_dateCreatedIns.Text = "Date Created :";
            // 
            // BTN_FindByCustomerID
            // 
            BTN_FindByCustomerID.BackColor = Color.DarkOrange;
            BTN_FindByCustomerID.FlatAppearance.BorderSize = 0;
            BTN_FindByCustomerID.FlatStyle = FlatStyle.Flat;
            BTN_FindByCustomerID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_FindByCustomerID.ForeColor = SystemColors.ButtonHighlight;
            BTN_FindByCustomerID.Image = Properties.Resources.gettt1;
            BTN_FindByCustomerID.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_FindByCustomerID.Location = new Point(436, 505);
            BTN_FindByCustomerID.Name = "BTN_FindByCustomerID";
            BTN_FindByCustomerID.Padding = new Padding(10, 0, 20, 0);
            BTN_FindByCustomerID.Size = new Size(355, 75);
            BTN_FindByCustomerID.TabIndex = 111;
            BTN_FindByCustomerID.Text = "Find By CustomerID";
            BTN_FindByCustomerID.TextAlign = ContentAlignment.MiddleLeft;
            BTN_FindByCustomerID.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_FindByCustomerID.UseVisualStyleBackColor = false;
            BTN_FindByCustomerID.Click += BTN_FindByCustomerID_Click;
            // 
            // BTN_FindByRequestID
            // 
            BTN_FindByRequestID.BackColor = Color.DarkOrange;
            BTN_FindByRequestID.FlatAppearance.BorderSize = 0;
            BTN_FindByRequestID.FlatStyle = FlatStyle.Flat;
            BTN_FindByRequestID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_FindByRequestID.ForeColor = SystemColors.ButtonHighlight;
            BTN_FindByRequestID.Image = Properties.Resources.gettt1;
            BTN_FindByRequestID.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_FindByRequestID.Location = new Point(436, 409);
            BTN_FindByRequestID.Name = "BTN_FindByRequestID";
            BTN_FindByRequestID.Padding = new Padding(10, 0, 20, 0);
            BTN_FindByRequestID.Size = new Size(355, 75);
            BTN_FindByRequestID.TabIndex = 110;
            BTN_FindByRequestID.Text = "Find By RequestID";
            BTN_FindByRequestID.TextAlign = ContentAlignment.MiddleLeft;
            BTN_FindByRequestID.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_FindByRequestID.UseVisualStyleBackColor = false;
            BTN_FindByRequestID.Click += BTN_FindByRequestID_Click;
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
            BTN_Reset.Location = new Point(827, 409);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Padding = new Padding(10, 0, 20, 0);
            BTN_Reset.Size = new Size(227, 171);
            BTN_Reset.TabIndex = 109;
            BTN_Reset.Text = " Reset";
            BTN_Reset.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Reset.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Reset.UseVisualStyleBackColor = false;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // InspectorFormForAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(10, 40, 70);
            ClientSize = new Size(1176, 1236);
            Controls.Add(BTN_FindByCustomerID);
            Controls.Add(BTN_FindByRequestID);
            Controls.Add(BTN_Reset);
            Controls.Add(procentIns);
            Controls.Add(TXT_DiscountIns);
            Controls.Add(LBL_DiscountIns);
            Controls.Add(TXT_HasPetsIns);
            Controls.Add(LBL_HasPetsIns);
            Controls.Add(TXT_HasCleaningSupplyIns);
            Controls.Add(LBL_HasCleaningSupplyIns);
            Controls.Add(TXT_HasAlarmIns);
            Controls.Add(LBL_HasAlarmIns);
            Controls.Add(TXT_DateCreatedIns);
            Controls.Add(LBL_dateCreatedIns);
            Controls.Add(TXT_RequestIDIns);
            Controls.Add(LBL_RequestIDIns);
            Controls.Add(TXT_customerIDIns);
            Controls.Add(LBL_CustomerIDIns);
            Controls.Add(DGV_AllRequests);
            Name = "InspectorFormForAdmin";
            Text = "InspectorFormForAdmin";
            Load += InspectorFormForAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_AllRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_AllRequests;
        private TextBox TXT_RequestIDIns;
        private Label LBL_RequestIDIns;
        private TextBox TXT_customerIDIns;
        private Label LBL_CustomerIDIns;
        private Label procentIns;
        private TextBox TXT_DiscountIns;
        private Label LBL_DiscountIns;
        private TextBox TXT_HasPetsIns;
        private Label LBL_HasPetsIns;
        private TextBox TXT_HasCleaningSupplyIns;
        private Label LBL_HasCleaningSupplyIns;
        private TextBox TXT_HasAlarmIns;
        private Label LBL_HasAlarmIns;
        private TextBox TXT_DateCreatedIns;
        private Label LBL_dateCreatedIns;
        private Button BTN_FindByCustomerID;
        private Button BTN_FindByRequestID;
        private Button BTN_Reset;
    }
}