namespace F1Login.F3UserChildForms
{
    partial class ServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesForm));
            BTN_GoToCart = new Button();
            BTN_AddToCart = new Button();
            LBL_Price = new Label();
            LBL_favorname = new Label();
            label6 = new Label();
            label5 = new Label();
            TXT_inputQuantity = new TextBox();
            LBL_Quantity = new Label();
            LBL_ShowFavorPrice = new Label();
            LBL_ShowFavorName = new Label();
            DGV_FavorList = new DataGridView();
            favorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favorBindingSource = new BindingSource(components);
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_FavorList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)favorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BTN_GoToCart
            // 
            BTN_GoToCart.BackColor = Color.Green;
            BTN_GoToCart.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_GoToCart.ForeColor = SystemColors.ButtonHighlight;
            BTN_GoToCart.Image = Properties.Resources.ttt;
            BTN_GoToCart.Location = new Point(445, 847);
            BTN_GoToCart.Name = "BTN_GoToCart";
            BTN_GoToCart.Size = new Size(268, 90);
            BTN_GoToCart.TabIndex = 18;
            BTN_GoToCart.Text = " Go to cart";
            BTN_GoToCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_GoToCart.UseVisualStyleBackColor = false;
            BTN_GoToCart.Click += BTN_GoToCart_Click;
            // 
            // BTN_AddToCart
            // 
            BTN_AddToCart.BackColor = Color.DarkViolet;
            BTN_AddToCart.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_AddToCart.ForeColor = SystemColors.ButtonHighlight;
            BTN_AddToCart.Image = Properties.Resources.add_cart;
            BTN_AddToCart.Location = new Point(445, 716);
            BTN_AddToCart.Name = "BTN_AddToCart";
            BTN_AddToCart.Size = new Size(269, 90);
            BTN_AddToCart.TabIndex = 16;
            BTN_AddToCart.Text = " Add to cart";
            BTN_AddToCart.TextAlign = ContentAlignment.MiddleLeft;
            BTN_AddToCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_AddToCart.UseVisualStyleBackColor = false;
            BTN_AddToCart.Click += BTN_AddToCart_Click;
            // 
            // LBL_Price
            // 
            LBL_Price.AutoSize = true;
            LBL_Price.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Price.ForeColor = SystemColors.ButtonHighlight;
            LBL_Price.Location = new Point(39, 464);
            LBL_Price.Name = "LBL_Price";
            LBL_Price.Size = new Size(142, 36);
            LBL_Price.TabIndex = 15;
            LBL_Price.Text = "Unit Price :";
            // 
            // LBL_favorname
            // 
            LBL_favorname.AutoSize = true;
            LBL_favorname.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_favorname.ForeColor = SystemColors.ButtonHighlight;
            LBL_favorname.Location = new Point(38, 406);
            LBL_favorname.Name = "LBL_favorname";
            LBL_favorname.Size = new Size(164, 36);
            LBL_favorname.TabIndex = 14;
            LBL_favorname.Text = "FavorName :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(41, 575);
            label6.Name = "label6";
            label6.Size = new Size(134, 30);
            label6.TabIndex = 13;
            label6.Text = "\"Hello there!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(44, 575);
            label5.Name = "label5";
            label5.Size = new Size(1073, 90);
            label5.TabIndex = 12;
            label5.Text = resources.GetString("label5.Text");
            // 
            // TXT_inputQuantity
            // 
            TXT_inputQuantity.BackColor = Color.MediumSlateBlue;
            TXT_inputQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_inputQuantity.ForeColor = SystemColors.ButtonHighlight;
            TXT_inputQuantity.Location = new Point(214, 514);
            TXT_inputQuantity.Name = "TXT_inputQuantity";
            TXT_inputQuantity.Size = new Size(105, 42);
            TXT_inputQuantity.TabIndex = 11;
            // 
            // LBL_Quantity
            // 
            LBL_Quantity.AutoSize = true;
            LBL_Quantity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Quantity.ForeColor = SystemColors.ButtonHighlight;
            LBL_Quantity.Location = new Point(42, 518);
            LBL_Quantity.Name = "LBL_Quantity";
            LBL_Quantity.Size = new Size(131, 36);
            LBL_Quantity.TabIndex = 10;
            LBL_Quantity.Text = "Quantity :";
            // 
            // LBL_ShowFavorPrice
            // 
            LBL_ShowFavorPrice.AutoSize = true;
            LBL_ShowFavorPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_ShowFavorPrice.ForeColor = SystemColors.ButtonHighlight;
            LBL_ShowFavorPrice.Location = new Point(209, 463);
            LBL_ShowFavorPrice.Name = "LBL_ShowFavorPrice";
            LBL_ShowFavorPrice.Size = new Size(336, 36);
            LBL_ShowFavorPrice.TabIndex = 9;
            LBL_ShowFavorPrice.Text = "Click on list to show Price ...";
            // 
            // LBL_ShowFavorName
            // 
            LBL_ShowFavorName.AutoSize = true;
            LBL_ShowFavorName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_ShowFavorName.ForeColor = SystemColors.ButtonHighlight;
            LBL_ShowFavorName.Location = new Point(208, 405);
            LBL_ShowFavorName.Name = "LBL_ShowFavorName";
            LBL_ShowFavorName.Size = new Size(409, 36);
            LBL_ShowFavorName.TabIndex = 8;
            LBL_ShowFavorName.Text = "Click on list to show Favorname ...";
            // 
            // DGV_FavorList
            // 
            DGV_FavorList.AutoGenerateColumns = false;
            DGV_FavorList.BackgroundColor = Color.MediumSlateBlue;
            DGV_FavorList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_FavorList.Columns.AddRange(new DataGridViewColumn[] { favorIDDataGridViewTextBoxColumn, favorNameDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn });
            DGV_FavorList.DataSource = favorBindingSource;
            DGV_FavorList.Location = new Point(38, 32);
            DGV_FavorList.MultiSelect = false;
            DGV_FavorList.Name = "DGV_FavorList";
            DGV_FavorList.ReadOnly = true;
            DGV_FavorList.RowHeadersVisible = false;
            DGV_FavorList.RowHeadersWidth = 72;
            DGV_FavorList.RowTemplate.Height = 37;
            DGV_FavorList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_FavorList.Size = new Size(1078, 354);
            DGV_FavorList.TabIndex = 7;
            DGV_FavorList.SelectionChanged += DGV_FavorList_SelectionChanged;
            DGV_FavorList.DoubleClick += DGV_FavorList_DoubleClick;
            // 
            // favorIDDataGridViewTextBoxColumn
            // 
            favorIDDataGridViewTextBoxColumn.DataPropertyName = "FavorID";
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
            favorNameDataGridViewTextBoxColumn.HeaderText = "FavorName";
            favorNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            favorNameDataGridViewTextBoxColumn.Name = "favorNameDataGridViewTextBoxColumn";
            favorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.MinimumWidth = 9;
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            unitPriceDataGridViewTextBoxColumn.Width = 175;
            // 
            // favorBindingSource
            // 
            favorBindingSource.DataSource = typeof(Repository.Models.Favor);
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1189);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 47);
            panel1.TabIndex = 19;
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(30, 30, 60);
            ClientSize = new Size(1180, 1236);
            Controls.Add(panel1);
            Controls.Add(BTN_GoToCart);
            Controls.Add(BTN_AddToCart);
            Controls.Add(DGV_FavorList);
            Controls.Add(LBL_Price);
            Controls.Add(LBL_ShowFavorName);
            Controls.Add(LBL_favorname);
            Controls.Add(LBL_ShowFavorPrice);
            Controls.Add(label6);
            Controls.Add(LBL_Quantity);
            Controls.Add(label5);
            Controls.Add(TXT_inputQuantity);
            Name = "ServicesForm";
            Text = "ServicesForm";
            Load += ServicesForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_FavorList).EndInit();
            ((System.ComponentModel.ISupportInitialize)favorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private DataGridView DGV_FavorList;
        private DataGridViewTextBoxColumn favorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn favorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private BindingSource favorBindingSource;
        private Label label6;
        private Label label5;
        private TextBox TXT_inputQuantity;
        private Label LBL_Quantity;
        private Label LBL_ShowFavorPrice;
        private Label LBL_ShowFavorName;
        private Label LBL_Price;
        private Label LBL_favorname;
        private Button BTN_AddToCart;
        private Button BTN_GoToCart;
        private Panel panel1;
    }
}