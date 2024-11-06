namespace F1Login.F3UserChildForms
{
    partial class CartForm
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
            LBL_TotalPriceBeforDiscount = new Label();
            LBL_ShowTotalPriceBeforeDicsount = new Label();
            BTN_Bestil = new Button();
            BTN_Delete = new Button();
            DGV_Cart = new DataGridView();
            groupBox1 = new GroupBox();
            checkBox_Pets = new CheckBox();
            checkBox_Supply = new CheckBox();
            checkBox_Alarm = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            LBL_TotalPriceAfterDiscount = new Label();
            LBL_ShowTotalPriceAfterDiscount = new Label();
            LBL_ShowProcent = new Label();
            LBL_Procent = new Label();
            LBL_SYMBOL = new Label();
            label3 = new Label();
            BTN_GoBack = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV_Cart).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LBL_TotalPriceBeforDiscount
            // 
            LBL_TotalPriceBeforDiscount.AutoSize = true;
            LBL_TotalPriceBeforDiscount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_TotalPriceBeforDiscount.ForeColor = SystemColors.ButtonHighlight;
            LBL_TotalPriceBeforDiscount.Location = new Point(27, 1010);
            LBL_TotalPriceBeforDiscount.Name = "LBL_TotalPriceBeforDiscount";
            LBL_TotalPriceBeforDiscount.Size = new Size(336, 36);
            LBL_TotalPriceBeforDiscount.TabIndex = 15;
            LBL_TotalPriceBeforDiscount.Text = "Total Price Before Discount:";
            // 
            // LBL_ShowTotalPriceBeforeDicsount
            // 
            LBL_ShowTotalPriceBeforeDicsount.AutoSize = true;
            LBL_ShowTotalPriceBeforeDicsount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_ShowTotalPriceBeforeDicsount.ForeColor = SystemColors.ButtonHighlight;
            LBL_ShowTotalPriceBeforeDicsount.Location = new Point(411, 1010);
            LBL_ShowTotalPriceBeforeDicsount.Name = "LBL_ShowTotalPriceBeforeDicsount";
            LBL_ShowTotalPriceBeforeDicsount.Size = new Size(155, 36);
            LBL_ShowTotalPriceBeforeDicsount.TabIndex = 16;
            LBL_ShowTotalPriceBeforeDicsount.Text = "Price Before";
            // 
            // BTN_Bestil
            // 
            BTN_Bestil.BackColor = Color.Green;
            BTN_Bestil.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Bestil.ForeColor = SystemColors.ButtonHighlight;
            BTN_Bestil.Image = Properties.Resources._121;
            BTN_Bestil.Location = new Point(886, 1010);
            BTN_Bestil.Name = "BTN_Bestil";
            BTN_Bestil.Size = new Size(258, 93);
            BTN_Bestil.TabIndex = 17;
            BTN_Bestil.Text = "  Order it";
            BTN_Bestil.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Bestil.UseVisualStyleBackColor = false;
            BTN_Bestil.Click += BTN_Bestil_Click;
            // 
            // BTN_Delete
            // 
            BTN_Delete.BackColor = Color.Maroon;
            BTN_Delete.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_Delete.ForeColor = SystemColors.ButtonHighlight;
            BTN_Delete.Image = Properties.Resources.deletedss1;
            BTN_Delete.Location = new Point(886, 403);
            BTN_Delete.Name = "BTN_Delete";
            BTN_Delete.Size = new Size(258, 93);
            BTN_Delete.TabIndex = 18;
            BTN_Delete.Text = " Delete";
            BTN_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_Delete.UseVisualStyleBackColor = false;
            BTN_Delete.Click += BTN_Delete_Click;
            // 
            // DGV_Cart
            // 
            DGV_Cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Cart.BackgroundColor = Color.MediumSlateBlue;
            DGV_Cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Cart.Location = new Point(27, 42);
            DGV_Cart.Name = "DGV_Cart";
            DGV_Cart.ReadOnly = true;
            DGV_Cart.RowHeadersVisible = false;
            DGV_Cart.RowHeadersWidth = 72;
            DGV_Cart.RowTemplate.Height = 37;
            DGV_Cart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Cart.Size = new Size(1117, 345);
            DGV_Cart.TabIndex = 19;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_Pets);
            groupBox1.Controls.Add(checkBox_Supply);
            groupBox1.Controls.Add(checkBox_Alarm);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(27, 550);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 423);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Discount possible!";
            // 
            // checkBox_Pets
            // 
            checkBox_Pets.AutoSize = true;
            checkBox_Pets.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox_Pets.Location = new Point(33, 163);
            checkBox_Pets.Name = "checkBox_Pets";
            checkBox_Pets.Size = new Size(497, 36);
            checkBox_Pets.TabIndex = 26;
            checkBox_Pets.Text = "Check  if there are NO PETS at your home.";
            checkBox_Pets.UseVisualStyleBackColor = true;
            checkBox_Pets.CheckedChanged += checkBox_Pets_CheckedChanged;
            // 
            // checkBox_Supply
            // 
            checkBox_Supply.AutoSize = true;
            checkBox_Supply.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox_Supply.Location = new Point(33, 111);
            checkBox_Supply.Name = "checkBox_Supply";
            checkBox_Supply.Size = new Size(567, 36);
            checkBox_Supply.TabIndex = 25;
            checkBox_Supply.Text = "Check if you possess your own cleaning supplies.";
            checkBox_Supply.UseVisualStyleBackColor = true;
            checkBox_Supply.CheckedChanged += checkBox_Supply_CheckedChanged;
            // 
            // checkBox_Alarm
            // 
            checkBox_Alarm.AutoSize = true;
            checkBox_Alarm.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox_Alarm.Location = new Point(33, 57);
            checkBox_Alarm.Name = "checkBox_Alarm";
            checkBox_Alarm.Size = new Size(575, 36);
            checkBox_Alarm.TabIndex = 24;
            checkBox_Alarm.Text = "Check if you have an alarm system in your home.";
            checkBox_Alarm.UseVisualStyleBackColor = true;
            checkBox_Alarm.CheckedChanged += checkBox_Alarm_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(178, 282);
            label2.Name = "label2";
            label2.Size = new Size(593, 108);
            label2.TabIndex = 22;
            label2.Text = "Failure to respond to these items will be assumed \r\nas a negative, resulting in the forfeiture of your \r\ndiscount on the price.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(22, 282);
            label1.Name = "label1";
            label1.Size = new Size(150, 36);
            label1.TabIndex = 21;
            label1.Text = "Attention!!!";
            // 
            // LBL_TotalPriceAfterDiscount
            // 
            LBL_TotalPriceAfterDiscount.AutoSize = true;
            LBL_TotalPriceAfterDiscount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_TotalPriceAfterDiscount.ForeColor = SystemColors.ButtonHighlight;
            LBL_TotalPriceAfterDiscount.Location = new Point(44, 1107);
            LBL_TotalPriceAfterDiscount.Name = "LBL_TotalPriceAfterDiscount";
            LBL_TotalPriceAfterDiscount.Size = new Size(319, 36);
            LBL_TotalPriceAfterDiscount.TabIndex = 21;
            LBL_TotalPriceAfterDiscount.Text = "Total Price After Discount:";
            // 
            // LBL_ShowTotalPriceAfterDiscount
            // 
            LBL_ShowTotalPriceAfterDiscount.AutoSize = true;
            LBL_ShowTotalPriceAfterDiscount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_ShowTotalPriceAfterDiscount.ForeColor = SystemColors.ButtonHighlight;
            LBL_ShowTotalPriceAfterDiscount.Location = new Point(411, 1107);
            LBL_ShowTotalPriceAfterDiscount.Name = "LBL_ShowTotalPriceAfterDiscount";
            LBL_ShowTotalPriceAfterDiscount.Size = new Size(138, 36);
            LBL_ShowTotalPriceAfterDiscount.TabIndex = 22;
            LBL_ShowTotalPriceAfterDiscount.Text = "Price After";
            // 
            // LBL_ShowProcent
            // 
            LBL_ShowProcent.AutoSize = true;
            LBL_ShowProcent.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_ShowProcent.ForeColor = SystemColors.ButtonHighlight;
            LBL_ShowProcent.Location = new Point(434, 1060);
            LBL_ShowProcent.Name = "LBL_ShowProcent";
            LBL_ShowProcent.Size = new Size(30, 36);
            LBL_ShowProcent.TabIndex = 24;
            LBL_ShowProcent.Text = "0";
            // 
            // LBL_Procent
            // 
            LBL_Procent.AutoSize = true;
            LBL_Procent.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_Procent.ForeColor = SystemColors.ButtonHighlight;
            LBL_Procent.Location = new Point(115, 1060);
            LBL_Procent.Name = "LBL_Procent";
            LBL_Procent.Size = new Size(248, 36);
            LBL_Procent.TabIndex = 23;
            LBL_Procent.Text = "Discount in Procent:";
            // 
            // LBL_SYMBOL
            // 
            LBL_SYMBOL.AutoSize = true;
            LBL_SYMBOL.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LBL_SYMBOL.ForeColor = SystemColors.ButtonHighlight;
            LBL_SYMBOL.Location = new Point(487, 1060);
            LBL_SYMBOL.Name = "LBL_SYMBOL";
            LBL_SYMBOL.Size = new Size(37, 36);
            LBL_SYMBOL.TabIndex = 25;
            LBL_SYMBOL.Text = "%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(416, 1060);
            label3.Name = "label3";
            label3.Size = new Size(25, 36);
            label3.TabIndex = 26;
            label3.Text = "-";
            // 
            // BTN_GoBack
            // 
            BTN_GoBack.BackColor = Color.Black;
            BTN_GoBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            BTN_GoBack.ForeColor = SystemColors.ButtonHighlight;
            BTN_GoBack.Image = Properties.Resources.logoutsss2;
            BTN_GoBack.Location = new Point(886, 1226);
            BTN_GoBack.Name = "BTN_GoBack";
            BTN_GoBack.Size = new Size(258, 93);
            BTN_GoBack.TabIndex = 27;
            BTN_GoBack.Text = "Go Back";
            BTN_GoBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTN_GoBack.UseVisualStyleBackColor = false;
            BTN_GoBack.Click += BTN_GoBack_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 1362);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 42);
            panel1.TabIndex = 28;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 60);
            ClientSize = new Size(1176, 1404);
            Controls.Add(panel1);
            Controls.Add(BTN_GoBack);
            Controls.Add(label3);
            Controls.Add(LBL_SYMBOL);
            Controls.Add(LBL_ShowProcent);
            Controls.Add(LBL_Procent);
            Controls.Add(LBL_ShowTotalPriceAfterDiscount);
            Controls.Add(LBL_TotalPriceAfterDiscount);
            Controls.Add(groupBox1);
            Controls.Add(DGV_Cart);
            Controls.Add(BTN_Delete);
            Controls.Add(BTN_Bestil);
            Controls.Add(LBL_ShowTotalPriceBeforeDicsount);
            Controls.Add(LBL_TotalPriceBeforDiscount);
            Name = "CartForm";
            Text = "CartForm";
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_Cart).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LBL_TotalPriceBeforDiscount;
        private Label LBL_ShowTotalPriceBeforeDicsount;
        private Button BTN_Bestil;
        private Button BTN_Delete;
        private DataGridView DGV_Cart;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private CheckBox checkBox_Pets;
        private CheckBox checkBox_Supply;
        private CheckBox checkBox_Alarm;
        private Label LBL_TotalPriceAfterDiscount;
        private Label LBL_ShowTotalPriceAfterDiscount;
        private Label LBL_ShowProcent;
        private Label LBL_Procent;
        private Label LBL_SYMBOL;
        private Label label3;
        private Button BTN_GoBack;
        private Panel panel1;
    }
}