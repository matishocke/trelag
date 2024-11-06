namespace F1Login.F2AdminChildForms
{
    partial class ShowFavorLinesFormForAdmin
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
            favorLineBindingSource = new BindingSource(components);
            favorLineBindingSource1 = new BindingSource(components);
            DGV_FavorLine = new DataGridView();
            favorLineBindingSource3 = new BindingSource(components);
            favorLineBindingSource2 = new BindingSource(components);
            BTN_FindFavorLineID = new Button();
            BTN_Reset = new Button();
            BTN_Delete = new Button();
            BTN_Update = new Button();
            TXT_FavorLineID = new TextBox();
            LBL_FavorLineID = new Label();
            TXT_FavorQuantity = new TextBox();
            LBL_FavorQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)favorLineBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)favorLineBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_FavorLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)favorLineBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)favorLineBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // favorLineBindingSource
            // 
            favorLineBindingSource.DataSource = typeof(Repository.Models.FavorLine);
            // 
            // favorLineBindingSource1
            // 
            favorLineBindingSource1.DataSource = typeof(Repository.Models.FavorLine);
            // 
            // DGV_FavorLine
            // 
            DGV_FavorLine.AllowUserToAddRows = false;
            DGV_FavorLine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_FavorLine.BackgroundColor = Color.MediumSlateBlue;
            DGV_FavorLine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_FavorLine.Location = new Point(28, 34);
            DGV_FavorLine.MultiSelect = false;
            DGV_FavorLine.Name = "DGV_FavorLine";
            DGV_FavorLine.ReadOnly = true;
            DGV_FavorLine.RowHeadersVisible = false;
            DGV_FavorLine.RowHeadersWidth = 72;
            DGV_FavorLine.RowTemplate.Height = 37;
            DGV_FavorLine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_FavorLine.Size = new Size(1119, 307);
            DGV_FavorLine.TabIndex = 59;
            DGV_FavorLine.SelectionChanged += DGV_FavorLine_SelectionChanged;
            // 
            // favorLineBindingSource3
            // 
            favorLineBindingSource3.DataSource = typeof(Repository.Models.FavorLine);
            // 
            // favorLineBindingSource2
            // 
            favorLineBindingSource2.DataSource = typeof(Repository.Models.FavorLine);
            // 
            // BTN_FindFavorLineID
            // 
            BTN_FindFavorLineID.BackColor = Color.DarkOrange;
            BTN_FindFavorLineID.FlatAppearance.BorderSize = 0;
            BTN_FindFavorLineID.FlatStyle = FlatStyle.Flat;
            BTN_FindFavorLineID.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_FindFavorLineID.ForeColor = SystemColors.ButtonHighlight;
            BTN_FindFavorLineID.Image = Properties.Resources.gettt1;
            BTN_FindFavorLineID.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_FindFavorLineID.Location = new Point(792, 388);
            BTN_FindFavorLineID.Name = "BTN_FindFavorLineID";
            BTN_FindFavorLineID.Padding = new Padding(10, 0, 20, 0);
            BTN_FindFavorLineID.Size = new Size(355, 75);
            BTN_FindFavorLineID.TabIndex = 82;
            BTN_FindFavorLineID.Text = "Find By FavorLineID";
            BTN_FindFavorLineID.TextAlign = ContentAlignment.MiddleLeft;
            BTN_FindFavorLineID.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_FindFavorLineID.UseVisualStyleBackColor = false;
            BTN_FindFavorLineID.Click += BTN_FindFavorLineID_Click;
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
            BTN_Reset.Location = new Point(538, 388);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Padding = new Padding(10, 0, 20, 0);
            BTN_Reset.Size = new Size(210, 75);
            BTN_Reset.TabIndex = 81;
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
            BTN_Delete.Location = new Point(283, 388);
            BTN_Delete.Name = "BTN_Delete";
            BTN_Delete.Padding = new Padding(10, 0, 20, 0);
            BTN_Delete.Size = new Size(210, 75);
            BTN_Delete.TabIndex = 80;
            BTN_Delete.Text = "  Delete";
            BTN_Delete.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Delete.UseVisualStyleBackColor = false;
            BTN_Delete.Click += BTN_Delete_Click;
            // 
            // BTN_Update
            // 
            BTN_Update.BackColor = Color.DarkSlateGray;
            BTN_Update.FlatAppearance.BorderSize = 0;
            BTN_Update.FlatStyle = FlatStyle.Flat;
            BTN_Update.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Update.ForeColor = SystemColors.ButtonHighlight;
            BTN_Update.Image = Properties.Resources.updateeewdw;
            BTN_Update.ImageAlign = ContentAlignment.TopLeft;
            BTN_Update.Location = new Point(28, 388);
            BTN_Update.Name = "BTN_Update";
            BTN_Update.Padding = new Padding(10, 0, 20, 0);
            BTN_Update.Size = new Size(210, 75);
            BTN_Update.TabIndex = 79;
            BTN_Update.Text = "Update";
            BTN_Update.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Update.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Update.UseVisualStyleBackColor = false;
            BTN_Update.Click += BTN_Update_Click;
            // 
            // TXT_FavorLineID
            // 
            TXT_FavorLineID.BackColor = Color.MediumSlateBlue;
            TXT_FavorLineID.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_FavorLineID.ForeColor = SystemColors.ButtonHighlight;
            TXT_FavorLineID.Location = new Point(792, 500);
            TXT_FavorLineID.Name = "TXT_FavorLineID";
            TXT_FavorLineID.Size = new Size(355, 39);
            TXT_FavorLineID.TabIndex = 94;
            // 
            // LBL_FavorLineID
            // 
            LBL_FavorLineID.AutoSize = true;
            LBL_FavorLineID.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_FavorLineID.ForeColor = SystemColors.ButtonHighlight;
            LBL_FavorLineID.Location = new Point(629, 503);
            LBL_FavorLineID.Name = "LBL_FavorLineID";
            LBL_FavorLineID.Size = new Size(157, 32);
            LBL_FavorLineID.TabIndex = 93;
            LBL_FavorLineID.Text = "FavorLineID :";
            // 
            // TXT_FavorQuantity
            // 
            TXT_FavorQuantity.BackColor = Color.MediumSlateBlue;
            TXT_FavorQuantity.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_FavorQuantity.ForeColor = SystemColors.ButtonHighlight;
            TXT_FavorQuantity.Location = new Point(216, 500);
            TXT_FavorQuantity.Name = "TXT_FavorQuantity";
            TXT_FavorQuantity.Size = new Size(277, 39);
            TXT_FavorQuantity.TabIndex = 92;
            // 
            // LBL_FavorQuantity
            // 
            LBL_FavorQuantity.AutoSize = true;
            LBL_FavorQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_FavorQuantity.ForeColor = SystemColors.ButtonHighlight;
            LBL_FavorQuantity.Location = new Point(28, 503);
            LBL_FavorQuantity.Name = "LBL_FavorQuantity";
            LBL_FavorQuantity.Size = new Size(182, 32);
            LBL_FavorQuantity.TabIndex = 91;
            LBL_FavorQuantity.Text = "FavorQuantity :";
            // 
            // ShowFavorLinesFormForAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(30, 30, 60);
            ClientSize = new Size(1176, 636);
            Controls.Add(TXT_FavorLineID);
            Controls.Add(LBL_FavorLineID);
            Controls.Add(TXT_FavorQuantity);
            Controls.Add(LBL_FavorQuantity);
            Controls.Add(BTN_FindFavorLineID);
            Controls.Add(BTN_Reset);
            Controls.Add(BTN_Delete);
            Controls.Add(BTN_Update);
            Controls.Add(DGV_FavorLine);
            Name = "ShowFavorLinesFormForAdmin";
            Text = "ShowFavorLinesFormForAdmin";
            Load += ShowFavorLinesFormForAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)favorLineBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)favorLineBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_FavorLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)favorLineBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)favorLineBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource favorLineBindingSource;
        private BindingSource favorLineBindingSource1;
        private DataGridView DGV_FavorLine;
        private BindingSource favorLineBindingSource2;
        private BindingSource favorLineBindingSource3;
        private Button BTN_FindFavorLineID;
        private Button BTN_Reset;
        private Button BTN_Delete;
        private Button BTN_Update;
        private TextBox TXT_FavorLineID;
        private Label LBL_FavorLineID;
        private TextBox TXT_FavorQuantity;
        private Label LBL_FavorQuantity;
    }
}