namespace CafeShopManageSystem
{
    partial class CashierOrderForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrderForm));
            panel1 = new Panel();
            label1 = new Label();
            cashierOrderForm_menuTable = new DataGridView();
            panel3 = new Panel();
            cashierOrderForm_clearBtn = new Button();
            cashierOrderForm_removeBtn = new Button();
            cashierOrderForm_addBtn = new Button();
            cashierOrderForm_price = new Label();
            label10 = new Label();
            label11 = new Label();
            cashierOrderForm_quantity = new NumericUpDown();
            cashierOrderForm_prodName = new Label();
            label13 = new Label();
            cashierOrderForm_productID = new ComboBox();
            label14 = new Label();
            cashierOrderForm_type = new ComboBox();
            label15 = new Label();
            panel2 = new Panel();
            cashierOrderForm_receiptBtn = new Button();
            cashierOrderForm_payBtn = new Button();
            cashierOrderForm_change = new Label();
            label6 = new Label();
            cashierOrderForm_amount = new TextBox();
            label4 = new Label();
            cashierOrderForm_orderPrice = new Label();
            label3 = new Label();
            cashierOrderForm_orderTable = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_menuTable).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_quantity).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_orderTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cashierOrderForm_menuTable);
            panel1.Location = new Point(32, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 241);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // cashierOrderForm_menuTable
            // 
            cashierOrderForm_menuTable.AllowUserToAddRows = false;
            cashierOrderForm_menuTable.AllowUserToDeleteRows = false;
            cashierOrderForm_menuTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cashierOrderForm_menuTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cashierOrderForm_menuTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 9, 22);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            cashierOrderForm_menuTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            cashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashierOrderForm_menuTable.EnableHeadersVisualStyles = false;
            cashierOrderForm_menuTable.Location = new Point(20, 34);
            cashierOrderForm_menuTable.Name = "cashierOrderForm_menuTable";
            cashierOrderForm_menuTable.ReadOnly = true;
            cashierOrderForm_menuTable.RowHeadersVisible = false;
            cashierOrderForm_menuTable.Size = new Size(685, 191);
            cashierOrderForm_menuTable.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cashierOrderForm_clearBtn);
            panel3.Controls.Add(cashierOrderForm_removeBtn);
            panel3.Controls.Add(cashierOrderForm_addBtn);
            panel3.Controls.Add(cashierOrderForm_price);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cashierOrderForm_quantity);
            panel3.Controls.Add(cashierOrderForm_prodName);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cashierOrderForm_productID);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(cashierOrderForm_type);
            panel3.Controls.Add(label15);
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(32, 281);
            panel3.Name = "panel3";
            panel3.Size = new Size(724, 222);
            panel3.TabIndex = 25;
            // 
            // cashierOrderForm_clearBtn
            // 
            cashierOrderForm_clearBtn.BackColor = Color.FromArgb(7, 9, 22);
            cashierOrderForm_clearBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_clearBtn.ForeColor = Color.White;
            cashierOrderForm_clearBtn.Location = new Point(539, 162);
            cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            cashierOrderForm_clearBtn.Size = new Size(166, 36);
            cashierOrderForm_clearBtn.TabIndex = 24;
            cashierOrderForm_clearBtn.Text = "CLEAR";
            cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_clearBtn.Click += cashierOrderForm_clearBtn_Click;
            // 
            // cashierOrderForm_removeBtn
            // 
            cashierOrderForm_removeBtn.BackColor = Color.FromArgb(7, 9, 22);
            cashierOrderForm_removeBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_removeBtn.ForeColor = Color.White;
            cashierOrderForm_removeBtn.Location = new Point(291, 162);
            cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
            cashierOrderForm_removeBtn.Size = new Size(166, 36);
            cashierOrderForm_removeBtn.TabIndex = 23;
            cashierOrderForm_removeBtn.Text = "REMOVE";
            cashierOrderForm_removeBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_removeBtn.Click += cashierOrderForm_removeBtn_Click;
            // 
            // cashierOrderForm_addBtn
            // 
            cashierOrderForm_addBtn.BackColor = Color.FromArgb(7, 9, 22);
            cashierOrderForm_addBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_addBtn.ForeColor = Color.White;
            cashierOrderForm_addBtn.Location = new Point(20, 162);
            cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
            cashierOrderForm_addBtn.Size = new Size(166, 36);
            cashierOrderForm_addBtn.TabIndex = 22;
            cashierOrderForm_addBtn.Text = "ADD";
            cashierOrderForm_addBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_addBtn.Click += cashierOrderForm_addBtn_Click;
            // 
            // cashierOrderForm_price
            // 
            cashierOrderForm_price.AutoSize = true;
            cashierOrderForm_price.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_price.Location = new Point(120, 107);
            cashierOrderForm_price.Name = "cashierOrderForm_price";
            cashierOrderForm_price.Size = new Size(0, 15);
            cashierOrderForm_price.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(47, 107);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 20;
            label10.Text = "Price ($):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(430, 78);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 19;
            label11.Text = "Quality:";
            // 
            // cashierOrderForm_quantity
            // 
            cashierOrderForm_quantity.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_quantity.Location = new Point(493, 69);
            cashierOrderForm_quantity.Name = "cashierOrderForm_quantity";
            cashierOrderForm_quantity.Size = new Size(154, 29);
            cashierOrderForm_quantity.TabIndex = 18;
            // 
            // cashierOrderForm_prodName
            // 
            cashierOrderForm_prodName.AutoSize = true;
            cashierOrderForm_prodName.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_prodName.Location = new Point(120, 69);
            cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            cashierOrderForm_prodName.Size = new Size(0, 15);
            cashierOrderForm_prodName.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(10, 69);
            label13.Name = "label13";
            label13.Size = new Size(104, 15);
            label13.TabIndex = 16;
            label13.Text = "Product Name:";
            // 
            // cashierOrderForm_productID
            // 
            cashierOrderForm_productID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_productID.FormattingEnabled = true;
            cashierOrderForm_productID.Location = new Point(493, 22);
            cashierOrderForm_productID.Name = "cashierOrderForm_productID";
            cashierOrderForm_productID.Size = new Size(154, 25);
            cashierOrderForm_productID.TabIndex = 15;
            cashierOrderForm_productID.SelectedIndexChanged += cashierOrderForm_productID_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(407, 27);
            label14.Name = "label14";
            label14.Size = new Size(80, 15);
            label14.TabIndex = 14;
            label14.Text = "Product ID:";
            // 
            // cashierOrderForm_type
            // 
            cashierOrderForm_type.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_type.FormattingEnabled = true;
            cashierOrderForm_type.Items.AddRange(new object[] { "Meal", "Drinks" });
            cashierOrderForm_type.Location = new Point(120, 22);
            cashierOrderForm_type.Name = "cashierOrderForm_type";
            cashierOrderForm_type.Size = new Size(154, 25);
            cashierOrderForm_type.TabIndex = 13;
            cashierOrderForm_type.SelectedIndexChanged += cashierOrderForm_type_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(72, 27);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 12;
            label15.Text = "Type:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cashierOrderForm_receiptBtn);
            panel2.Controls.Add(cashierOrderForm_payBtn);
            panel2.Controls.Add(cashierOrderForm_change);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cashierOrderForm_amount);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cashierOrderForm_orderPrice);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cashierOrderForm_orderTable);
            panel2.Location = new Point(771, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(290, 479);
            panel2.TabIndex = 26;
            // 
            // cashierOrderForm_receiptBtn
            // 
            cashierOrderForm_receiptBtn.BackColor = Color.FromArgb(7, 9, 22);
            cashierOrderForm_receiptBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_receiptBtn.ForeColor = Color.White;
            cashierOrderForm_receiptBtn.Location = new Point(13, 438);
            cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            cashierOrderForm_receiptBtn.Size = new Size(264, 36);
            cashierOrderForm_receiptBtn.TabIndex = 29;
            cashierOrderForm_receiptBtn.Text = "RECEIPT";
            cashierOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_receiptBtn.Click += cashierOrderForm_receiptBtn_Click;
            // 
            // cashierOrderForm_payBtn
            // 
            cashierOrderForm_payBtn.BackColor = Color.FromArgb(7, 9, 22);
            cashierOrderForm_payBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_payBtn.ForeColor = Color.White;
            cashierOrderForm_payBtn.Location = new Point(13, 396);
            cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
            cashierOrderForm_payBtn.Size = new Size(264, 36);
            cashierOrderForm_payBtn.TabIndex = 28;
            cashierOrderForm_payBtn.Text = "PAY";
            cashierOrderForm_payBtn.UseVisualStyleBackColor = false;
            cashierOrderForm_payBtn.Click += cashierOrderForm_payBtn_Click;
            // 
            // cashierOrderForm_change
            // 
            cashierOrderForm_change.AutoSize = true;
            cashierOrderForm_change.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_change.Location = new Point(150, 354);
            cashierOrderForm_change.Name = "cashierOrderForm_change";
            cashierOrderForm_change.Size = new Size(15, 15);
            cashierOrderForm_change.TabIndex = 27;
            cashierOrderForm_change.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 354);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 26;
            label6.Text = "Change ($):";
            // 
            // cashierOrderForm_amount
            // 
            cashierOrderForm_amount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_amount.Location = new Point(150, 314);
            cashierOrderForm_amount.Name = "cashierOrderForm_amount";
            cashierOrderForm_amount.Size = new Size(127, 25);
            cashierOrderForm_amount.TabIndex = 25;
            cashierOrderForm_amount.KeyDown += cashierOrderForm_amount_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 319);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 24;
            label4.Text = "Amount ($):";
            // 
            // cashierOrderForm_orderPrice
            // 
            cashierOrderForm_orderPrice.AutoSize = true;
            cashierOrderForm_orderPrice.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashierOrderForm_orderPrice.Location = new Point(165, 279);
            cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
            cashierOrderForm_orderPrice.Size = new Size(15, 15);
            cashierOrderForm_orderPrice.TabIndex = 23;
            cashierOrderForm_orderPrice.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 279);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 22;
            label3.Text = "Price ($):";
            // 
            // cashierOrderForm_orderTable
            // 
            cashierOrderForm_orderTable.AllowUserToAddRows = false;
            cashierOrderForm_orderTable.AllowUserToDeleteRows = false;
            cashierOrderForm_orderTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cashierOrderForm_orderTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            cashierOrderForm_orderTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(7, 9, 22);
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            cashierOrderForm_orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cashierOrderForm_orderTable.EnableHeadersVisualStyles = false;
            cashierOrderForm_orderTable.Location = new Point(13, 14);
            cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
            cashierOrderForm_orderTable.ReadOnly = true;
            cashierOrderForm_orderTable.RowHeadersVisible = false;
            cashierOrderForm_orderTable.Size = new Size(264, 241);
            cashierOrderForm_orderTable.TabIndex = 3;
            cashierOrderForm_orderTable.CellContentClick += cashierOrderForm_orderTable_CellContentClick;
            // 
            // printDocument1
            // 
            printDocument1.BeginPrint += printDocument1_BeginPrint;
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // CashierOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CashierOrderForm";
            Size = new Size(1074, 520);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_menuTable).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_quantity).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cashierOrderForm_orderTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView cashierOrderForm_menuTable;
        private Label label1;
        private Panel panel3;
        private Button cashierOrderForm_clearBtn;
        private Button cashierOrderForm_removeBtn;
        private Button cashierOrderForm_addBtn;
        private Label cashierOrderForm_price;
        private Label label10;
        private Label label11;
        private NumericUpDown cashierOrderForm_quantity;
        private Label cashierOrderForm_prodName;
        private Label label13;
        private ComboBox cashierOrderForm_productID;
        private Label label14;
        private ComboBox cashierOrderForm_type;
        private Label label15;
        private Panel panel2;
        private Label cashierOrderForm_orderPrice;
        private Label label3;
        private DataGridView cashierOrderForm_orderTable;
        private TextBox cashierOrderForm_amount;
        private Label label4;
        private Button cashierOrderForm_receiptBtn;
        private Button cashierOrderForm_payBtn;
        private Label cashierOrderForm_change;
        private Label label6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
