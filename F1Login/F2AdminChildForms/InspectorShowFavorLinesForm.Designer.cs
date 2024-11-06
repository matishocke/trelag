namespace F1Login.F2AdminChildForms
{
    partial class InspectorShowFavorLinesForm
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
            DGV_AllFavorLines = new DataGridView();
            TXT_FavorLineIDIns = new TextBox();
            LBL_FavorLineIDIns = new Label();
            TXT_FavorQuantityIns = new TextBox();
            LBL_FavorQuantityIns = new Label();
            BTN_Denied = new Button();
            BTN_Approved = new Button();
            TXT_FavorComment = new TextBox();
            LBL_FavorComment = new Label();
            label2 = new Label();
            BTN_Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_AllFavorLines).BeginInit();
            SuspendLayout();
            // 
            // DGV_AllFavorLines
            // 
            DGV_AllFavorLines.AllowUserToAddRows = false;
            DGV_AllFavorLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_AllFavorLines.BackgroundColor = Color.DarkSlateBlue;
            DGV_AllFavorLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_AllFavorLines.Location = new Point(27, 27);
            DGV_AllFavorLines.MultiSelect = false;
            DGV_AllFavorLines.Name = "DGV_AllFavorLines";
            DGV_AllFavorLines.ReadOnly = true;
            DGV_AllFavorLines.RowHeadersVisible = false;
            DGV_AllFavorLines.RowHeadersWidth = 72;
            DGV_AllFavorLines.RowTemplate.Height = 37;
            DGV_AllFavorLines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_AllFavorLines.Size = new Size(1119, 343);
            DGV_AllFavorLines.TabIndex = 61;
            DGV_AllFavorLines.SelectionChanged += DGV_AllFavorLines_SelectionChanged;
            // 
            // TXT_FavorLineIDIns
            // 
            TXT_FavorLineIDIns.BackColor = Color.MediumSlateBlue;
            TXT_FavorLineIDIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_FavorLineIDIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_FavorLineIDIns.Location = new Point(757, 414);
            TXT_FavorLineIDIns.Name = "TXT_FavorLineIDIns";
            TXT_FavorLineIDIns.ReadOnly = true;
            TXT_FavorLineIDIns.Size = new Size(355, 39);
            TXT_FavorLineIDIns.TabIndex = 98;
            // 
            // LBL_FavorLineIDIns
            // 
            LBL_FavorLineIDIns.AutoSize = true;
            LBL_FavorLineIDIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_FavorLineIDIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_FavorLineIDIns.Location = new Point(594, 417);
            LBL_FavorLineIDIns.Name = "LBL_FavorLineIDIns";
            LBL_FavorLineIDIns.Size = new Size(157, 32);
            LBL_FavorLineIDIns.TabIndex = 97;
            LBL_FavorLineIDIns.Text = "FavorLineID :";
            // 
            // TXT_FavorQuantityIns
            // 
            TXT_FavorQuantityIns.BackColor = Color.MediumSlateBlue;
            TXT_FavorQuantityIns.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_FavorQuantityIns.ForeColor = SystemColors.ButtonHighlight;
            TXT_FavorQuantityIns.Location = new Point(236, 414);
            TXT_FavorQuantityIns.Name = "TXT_FavorQuantityIns";
            TXT_FavorQuantityIns.ReadOnly = true;
            TXT_FavorQuantityIns.Size = new Size(277, 39);
            TXT_FavorQuantityIns.TabIndex = 96;
            // 
            // LBL_FavorQuantityIns
            // 
            LBL_FavorQuantityIns.AutoSize = true;
            LBL_FavorQuantityIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_FavorQuantityIns.ForeColor = SystemColors.ButtonHighlight;
            LBL_FavorQuantityIns.Location = new Point(48, 417);
            LBL_FavorQuantityIns.Name = "LBL_FavorQuantityIns";
            LBL_FavorQuantityIns.Size = new Size(182, 32);
            LBL_FavorQuantityIns.TabIndex = 95;
            LBL_FavorQuantityIns.Text = "FavorQuantity :";
            // 
            // BTN_Denied
            // 
            BTN_Denied.BackColor = Color.Red;
            BTN_Denied.FlatAppearance.BorderSize = 0;
            BTN_Denied.FlatStyle = FlatStyle.Flat;
            BTN_Denied.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Denied.ForeColor = SystemColors.ButtonHighlight;
            BTN_Denied.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Denied.Location = new Point(196, 494);
            BTN_Denied.Name = "BTN_Denied";
            BTN_Denied.Padding = new Padding(10, 0, 20, 0);
            BTN_Denied.Size = new Size(262, 75);
            BTN_Denied.TabIndex = 100;
            BTN_Denied.Text = "Denied";
            BTN_Denied.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Denied.UseVisualStyleBackColor = false;
            BTN_Denied.Click += BTN_Denied_Click;
            // 
            // BTN_Approved
            // 
            BTN_Approved.BackColor = Color.Green;
            BTN_Approved.FlatAppearance.BorderSize = 0;
            BTN_Approved.FlatStyle = FlatStyle.Flat;
            BTN_Approved.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Approved.ForeColor = SystemColors.ButtonHighlight;
            BTN_Approved.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Approved.Location = new Point(490, 494);
            BTN_Approved.Name = "BTN_Approved";
            BTN_Approved.Padding = new Padding(10, 0, 20, 0);
            BTN_Approved.Size = new Size(262, 75);
            BTN_Approved.TabIndex = 101;
            BTN_Approved.Text = "Approved";
            BTN_Approved.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Approved.UseVisualStyleBackColor = false;
            BTN_Approved.Click += BTN_Approved_Click;
            // 
            // TXT_FavorComment
            // 
            TXT_FavorComment.BackColor = Color.MediumSlateBlue;
            TXT_FavorComment.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TXT_FavorComment.ForeColor = SystemColors.ButtonHighlight;
            TXT_FavorComment.Location = new Point(196, 621);
            TXT_FavorComment.Multiline = true;
            TXT_FavorComment.Name = "TXT_FavorComment";
            TXT_FavorComment.Size = new Size(916, 141);
            TXT_FavorComment.TabIndex = 103;
            // 
            // LBL_FavorComment
            // 
            LBL_FavorComment.AutoSize = true;
            LBL_FavorComment.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_FavorComment.ForeColor = SystemColors.ButtonHighlight;
            LBL_FavorComment.Location = new Point(48, 621);
            LBL_FavorComment.Name = "LBL_FavorComment";
            LBL_FavorComment.Size = new Size(131, 32);
            LBL_FavorComment.TabIndex = 102;
            LBL_FavorComment.Text = "Comment :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(51, 667);
            label2.Name = "label2";
            label2.Size = new Size(128, 69);
            label2.TabIndex = 104;
            label2.Text = "Please provide \r\na concise \r\ncomment.\r\n";
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
            BTN_Reset.Location = new Point(924, 477);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Padding = new Padding(10, 0, 20, 0);
            BTN_Reset.Size = new Size(188, 108);
            BTN_Reset.TabIndex = 110;
            BTN_Reset.Text = " Reset";
            BTN_Reset.TextAlign = ContentAlignment.MiddleLeft;
            BTN_Reset.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Reset.UseVisualStyleBackColor = false;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // InspectorShowFavorLinesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(10, 40, 70);
            ClientSize = new Size(1176, 836);
            Controls.Add(BTN_Reset);
            Controls.Add(label2);
            Controls.Add(TXT_FavorComment);
            Controls.Add(LBL_FavorComment);
            Controls.Add(BTN_Approved);
            Controls.Add(BTN_Denied);
            Controls.Add(TXT_FavorLineIDIns);
            Controls.Add(LBL_FavorLineIDIns);
            Controls.Add(TXT_FavorQuantityIns);
            Controls.Add(LBL_FavorQuantityIns);
            Controls.Add(DGV_AllFavorLines);
            Name = "InspectorShowFavorLinesForm";
            Text = "InspectorShowFavorLinesForm";
            Load += InspectorShowFavorLinesForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_AllFavorLines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_AllFavorLines;
        private TextBox TXT_FavorLineIDIns;
        private Label LBL_FavorLineIDIns;
        private TextBox TXT_FavorQuantityIns;
        private Label LBL_FavorQuantityIns;
        private Button BTN_Denied;
        private Button BTN_Approved;
        private TextBox TXT_FavorComment;
        private Label LBL_FavorComment;
        private Label label2;
        private Button BTN_Reset;
    }
}