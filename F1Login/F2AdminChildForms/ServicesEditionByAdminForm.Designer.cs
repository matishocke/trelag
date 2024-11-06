namespace F1Login.F2AdminChildForms
{
    partial class ServicesEditionByAdminForm
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
            DGV_FavorListEdition = new DataGridView();
            favorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favorBindingSource = new BindingSource(components);
            LBL_Unitprice = new Label();
            LBL_favorname = new Label();
            TXT_ShowFavorName = new TextBox();
            TXT_ShowUnitPrice = new TextBox();
            BTN_UpdateFavor = new Button();
            BTN_DeleteFavor = new Button();
            lbl_ID = new Label();
            LBL_ShowID = new Label();
            BTN_CreateFavor = new Button();
            BTN_Reset = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_FavorListEdition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)favorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DGV_FavorListEdition
            // 
            DGV_FavorListEdition.AutoGenerateColumns = false;
            DGV_FavorListEdition.BackgroundColor = Color.MediumSlateBlue;
            DGV_FavorListEdition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_FavorListEdition.Columns.AddRange(new DataGridViewColumn[] { favorIDDataGridViewTextBoxColumn, favorNameDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn });
            DGV_FavorListEdition.DataSource = favorBindingSource;
            DGV_FavorListEdition.Location = new Point(44, 278);
            DGV_FavorListEdition.MultiSelect = false;
            DGV_FavorListEdition.Name = "DGV_FavorListEdition";
            DGV_FavorListEdition.ReadOnly = true;
            DGV_FavorListEdition.RowHeadersVisible = false;
            DGV_FavorListEdition.RowHeadersWidth = 72;
            DGV_FavorListEdition.RowTemplate.Height = 37;
            DGV_FavorListEdition.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_FavorListEdition.Size = new Size(1078, 343);
            DGV_FavorListEdition.TabIndex = 8;
            DGV_FavorListEdition.SelectionChanged += DGV_FavorListEdition_SelectionChanged;
            // 
            // favorIDDataGridViewTextBoxColumn
            // 
            favorIDDataGridViewTextBoxColumn.DataPropertyName = "FavorID";
            favorIDDataGridViewTextBoxColumn.FillWeight = 52.2908363F;
            favorIDDataGridViewTextBoxColumn.HeaderText = "FavorID";
            favorIDDataGridViewTextBoxColumn.MinimumWidth = 9;
            favorIDDataGridViewTextBoxColumn.Name = "favorIDDataGridViewTextBoxColumn";
            favorIDDataGridViewTextBoxColumn.ReadOnly = true;
            favorIDDataGridViewTextBoxColumn.Width = 175;
            // 
            // favorNameDataGridViewTextBoxColumn
            // 
            favorNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            favorNameDataGridViewTextBoxColumn.DataPropertyName = "FavorName";
            favorNameDataGridViewTextBoxColumn.FillWeight = 213.750443F;
            favorNameDataGridViewTextBoxColumn.HeaderText = "FavorName";
            favorNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            favorNameDataGridViewTextBoxColumn.Name = "favorNameDataGridViewTextBoxColumn";
            favorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.FillWeight = 33.95874F;
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 9;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            unitPriceDataGridViewTextBoxColumn.Width = 114;
            // 
            // favorBindingSource
            // 
            favorBindingSource.DataSource = typeof(Repository.Models.Favor);
            // 
            // LBL_Unitprice
            // 
            LBL_Unitprice.AutoSize = true;
            LBL_Unitprice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Unitprice.ForeColor = SystemColors.ButtonHighlight;
            LBL_Unitprice.Location = new Point(64, 114);
            LBL_Unitprice.Name = "LBL_Unitprice";
            LBL_Unitprice.Size = new Size(133, 32);
            LBL_Unitprice.TabIndex = 19;
            LBL_Unitprice.Text = "Unit Price :";
            // 
            // LBL_favorname
            // 
            LBL_favorname.AutoSize = true;
            LBL_favorname.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_favorname.ForeColor = SystemColors.ButtonHighlight;
            LBL_favorname.Location = new Point(44, 64);
            LBL_favorname.Name = "LBL_favorname";
            LBL_favorname.Size = new Size(153, 32);
            LBL_favorname.TabIndex = 18;
            LBL_favorname.Text = "FavorName :";
            // 
            // TXT_ShowFavorName
            // 
            TXT_ShowFavorName.BackColor = Color.MediumSlateBlue;
            TXT_ShowFavorName.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_ShowFavorName.ForeColor = SystemColors.ButtonHighlight;
            TXT_ShowFavorName.Location = new Point(213, 61);
            TXT_ShowFavorName.Name = "TXT_ShowFavorName";
            TXT_ShowFavorName.Size = new Size(431, 39);
            TXT_ShowFavorName.TabIndex = 20;
            // 
            // TXT_ShowUnitPrice
            // 
            TXT_ShowUnitPrice.BackColor = Color.MediumSlateBlue;
            TXT_ShowUnitPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_ShowUnitPrice.ForeColor = SystemColors.ButtonHighlight;
            TXT_ShowUnitPrice.Location = new Point(213, 114);
            TXT_ShowUnitPrice.Name = "TXT_ShowUnitPrice";
            TXT_ShowUnitPrice.Size = new Size(431, 39);
            TXT_ShowUnitPrice.TabIndex = 21;
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
            BTN_UpdateFavor.Location = new Point(347, 180);
            BTN_UpdateFavor.Name = "BTN_UpdateFavor";
            BTN_UpdateFavor.Padding = new Padding(10, 0, 20, 0);
            BTN_UpdateFavor.Size = new Size(202, 75);
            BTN_UpdateFavor.TabIndex = 24;
            BTN_UpdateFavor.Text = "Update";
            BTN_UpdateFavor.TextAlign = ContentAlignment.MiddleLeft;
            BTN_UpdateFavor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_UpdateFavor.UseVisualStyleBackColor = false;
            BTN_UpdateFavor.Click += BTN_UpdateFavor_Click;
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
            BTN_DeleteFavor.Location = new Point(581, 180);
            BTN_DeleteFavor.Name = "BTN_DeleteFavor";
            BTN_DeleteFavor.Padding = new Padding(10, 0, 20, 0);
            BTN_DeleteFavor.Size = new Size(202, 75);
            BTN_DeleteFavor.TabIndex = 25;
            BTN_DeleteFavor.Text = "  Delete";
            BTN_DeleteFavor.TextAlign = ContentAlignment.MiddleLeft;
            BTN_DeleteFavor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_DeleteFavor.UseVisualStyleBackColor = false;
            BTN_DeleteFavor.Click += BTN_DeleteFavor_Click;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_ID.ForeColor = SystemColors.ButtonHighlight;
            lbl_ID.Location = new Point(145, 11);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(52, 32);
            lbl_ID.TabIndex = 27;
            lbl_ID.Text = "ID :";
            // 
            // LBL_ShowID
            // 
            LBL_ShowID.AutoSize = true;
            LBL_ShowID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_ShowID.ForeColor = SystemColors.ButtonHighlight;
            LBL_ShowID.Location = new Point(213, 11);
            LBL_ShowID.Name = "LBL_ShowID";
            LBL_ShowID.Size = new Size(34, 32);
            LBL_ShowID.TabIndex = 28;
            LBL_ShowID.Text = "__";
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
            BTN_CreateFavor.Location = new Point(108, 180);
            BTN_CreateFavor.Name = "BTN_CreateFavor";
            BTN_CreateFavor.Padding = new Padding(10, 0, 20, 0);
            BTN_CreateFavor.Size = new Size(202, 75);
            BTN_CreateFavor.TabIndex = 29;
            BTN_CreateFavor.Text = "Create";
            BTN_CreateFavor.TextAlign = ContentAlignment.MiddleLeft;
            BTN_CreateFavor.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_CreateFavor.UseVisualStyleBackColor = false;
            BTN_CreateFavor.Click += BTN_CreateFavor_Click;
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
            BTN_Reset.Location = new Point(814, 180);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Padding = new Padding(10, 0, 20, 0);
            BTN_Reset.Size = new Size(202, 75);
            BTN_Reset.TabIndex = 31;
            BTN_Reset.Text = " Reset";
            BTN_Reset.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Reset.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Reset.UseVisualStyleBackColor = false;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 25, 50);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 683);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 53);
            panel1.TabIndex = 32;
            // 
            // ServicesEditionByAdminForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(30, 30, 60);
            ClientSize = new Size(1176, 736);
            Controls.Add(panel1);
            Controls.Add(BTN_Reset);
            Controls.Add(BTN_CreateFavor);
            Controls.Add(LBL_ShowID);
            Controls.Add(lbl_ID);
            Controls.Add(BTN_DeleteFavor);
            Controls.Add(BTN_UpdateFavor);
            Controls.Add(TXT_ShowUnitPrice);
            Controls.Add(TXT_ShowFavorName);
            Controls.Add(LBL_Unitprice);
            Controls.Add(LBL_favorname);
            Controls.Add(DGV_FavorListEdition);
            Name = "ServicesEditionByAdminForm";
            Text = "ServicesEditionByAdminForm";
            Load += ServicesEditionByAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_FavorListEdition).EndInit();
            ((System.ComponentModel.ISupportInitialize)favorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_FavorListEdition;
        private DataGridViewTextBoxColumn favorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn favorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private BindingSource favorBindingSource;
        private Label LBL_Unitprice;
        private Label LBL_favorname;
        private TextBox TXT_ShowFavorName;
        private TextBox TXT_ShowUnitPrice;
        private Button BTN_UpdateFavor;
        private Button BTN_DeleteFavor;
        private Label lbl_ID;
        private Label LBL_ShowID;
        private Button BTN_CreateFavor;
        private Button BTN_Reset;
        private Panel panel1;
    }
}