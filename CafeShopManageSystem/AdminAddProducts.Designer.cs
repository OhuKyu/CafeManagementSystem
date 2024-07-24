namespace CafeShopManageSystem
{
    partial class AdminAddProducts
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            adminAddProducts_clearBtn = new Button();
            adminAddProducts_importBtn = new Button();
            adminAddProducts_deleteBtn = new Button();
            panel3 = new Panel();
            adminAddProducts_imageView = new PictureBox();
            adminAddProducts_updateBtn = new Button();
            adminAddProducts_status = new ComboBox();
            adminAddProducts_addBtn = new Button();
            label4 = new Label();
            adminAddProducts_price = new TextBox();
            label6 = new Label();
            adminAddProducts_stock = new TextBox();
            label7 = new Label();
            adminAddProducts_type = new ComboBox();
            label5 = new Label();
            adminAddProducts_name = new TextBox();
            label3 = new Label();
            adminAddProducts_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminAddProducts_imageView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(14, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 279);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 17);
            label1.TabIndex = 3;
            label1.Text = "Date of Products";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 9, 22);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(18, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(994, 234);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(adminAddProducts_clearBtn);
            panel2.Controls.Add(adminAddProducts_importBtn);
            panel2.Controls.Add(adminAddProducts_deleteBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(adminAddProducts_updateBtn);
            panel2.Controls.Add(adminAddProducts_status);
            panel2.Controls.Add(adminAddProducts_addBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(adminAddProducts_price);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(adminAddProducts_stock);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(adminAddProducts_type);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(adminAddProducts_name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(adminAddProducts_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(14, 309);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 199);
            panel2.TabIndex = 1;
            // 
            // adminAddProducts_clearBtn
            // 
            adminAddProducts_clearBtn.BackColor = Color.FromArgb(7, 9, 22);
            adminAddProducts_clearBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_clearBtn.ForeColor = Color.White;
            adminAddProducts_clearBtn.Location = new Point(612, 150);
            adminAddProducts_clearBtn.Name = "adminAddProducts_clearBtn";
            adminAddProducts_clearBtn.Size = new Size(93, 36);
            adminAddProducts_clearBtn.TabIndex = 19;
            adminAddProducts_clearBtn.Text = "CLEAR";
            adminAddProducts_clearBtn.UseVisualStyleBackColor = false;
            adminAddProducts_clearBtn.Click += adminAddProducts_clearBtn_Click;
            // 
            // adminAddProducts_importBtn
            // 
            adminAddProducts_importBtn.BackColor = Color.FromArgb(7, 9, 22);
            adminAddProducts_importBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_importBtn.ForeColor = Color.White;
            adminAddProducts_importBtn.Location = new Point(911, 143);
            adminAddProducts_importBtn.Name = "adminAddProducts_importBtn";
            adminAddProducts_importBtn.Size = new Size(101, 28);
            adminAddProducts_importBtn.TabIndex = 18;
            adminAddProducts_importBtn.Text = "Import";
            adminAddProducts_importBtn.UseVisualStyleBackColor = false;
            adminAddProducts_importBtn.Click += adminAddProducts_importBtn_Click;
            // 
            // adminAddProducts_deleteBtn
            // 
            adminAddProducts_deleteBtn.BackColor = Color.FromArgb(7, 9, 22);
            adminAddProducts_deleteBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_deleteBtn.ForeColor = Color.White;
            adminAddProducts_deleteBtn.Location = new Point(480, 150);
            adminAddProducts_deleteBtn.Name = "adminAddProducts_deleteBtn";
            adminAddProducts_deleteBtn.Size = new Size(93, 36);
            adminAddProducts_deleteBtn.TabIndex = 18;
            adminAddProducts_deleteBtn.Text = "DELETE";
            adminAddProducts_deleteBtn.UseVisualStyleBackColor = false;
            adminAddProducts_deleteBtn.Click += adminAddProducts_deleteBtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(adminAddProducts_imageView);
            panel3.Location = new Point(908, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(104, 110);
            panel3.TabIndex = 19;
            // 
            // adminAddProducts_imageView
            // 
            adminAddProducts_imageView.Location = new Point(0, 0);
            adminAddProducts_imageView.Name = "adminAddProducts_imageView";
            adminAddProducts_imageView.Size = new Size(104, 110);
            adminAddProducts_imageView.SizeMode = PictureBoxSizeMode.StretchImage;
            adminAddProducts_imageView.TabIndex = 20;
            adminAddProducts_imageView.TabStop = false;
            // 
            // adminAddProducts_updateBtn
            // 
            adminAddProducts_updateBtn.BackColor = Color.FromArgb(7, 9, 22);
            adminAddProducts_updateBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_updateBtn.ForeColor = Color.White;
            adminAddProducts_updateBtn.Location = new Point(326, 150);
            adminAddProducts_updateBtn.Name = "adminAddProducts_updateBtn";
            adminAddProducts_updateBtn.Size = new Size(93, 36);
            adminAddProducts_updateBtn.TabIndex = 17;
            adminAddProducts_updateBtn.Text = "UPDATE";
            adminAddProducts_updateBtn.UseVisualStyleBackColor = false;
            adminAddProducts_updateBtn.Click += adminAddProducts_updateBtn_Click;
            // 
            // adminAddProducts_status
            // 
            adminAddProducts_status.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_status.FormattingEnabled = true;
            adminAddProducts_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            adminAddProducts_status.Location = new Point(539, 108);
            adminAddProducts_status.Name = "adminAddProducts_status";
            adminAddProducts_status.Size = new Size(206, 25);
            adminAddProducts_status.TabIndex = 18;
            // 
            // adminAddProducts_addBtn
            // 
            adminAddProducts_addBtn.BackColor = Color.FromArgb(7, 9, 22);
            adminAddProducts_addBtn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_addBtn.ForeColor = Color.White;
            adminAddProducts_addBtn.Location = new Point(194, 150);
            adminAddProducts_addBtn.Name = "adminAddProducts_addBtn";
            adminAddProducts_addBtn.Size = new Size(93, 36);
            adminAddProducts_addBtn.TabIndex = 16;
            adminAddProducts_addBtn.Text = "ADD";
            adminAddProducts_addBtn.UseVisualStyleBackColor = false;
            adminAddProducts_addBtn.Click += adminAddProducts_addBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(480, 118);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 17;
            label4.Text = "Status:";
            // 
            // adminAddProducts_price
            // 
            adminAddProducts_price.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_price.Location = new Point(539, 67);
            adminAddProducts_price.Name = "adminAddProducts_price";
            adminAddProducts_price.Size = new Size(206, 25);
            adminAddProducts_price.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(466, 77);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 15;
            label6.Text = "Price ($):";
            // 
            // adminAddProducts_stock
            // 
            adminAddProducts_stock.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_stock.Location = new Point(539, 27);
            adminAddProducts_stock.Name = "adminAddProducts_stock";
            adminAddProducts_stock.Size = new Size(206, 25);
            adminAddProducts_stock.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(478, 37);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 13;
            label7.Text = "Stocks:";
            // 
            // adminAddProducts_type
            // 
            adminAddProducts_type.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_type.FormattingEnabled = true;
            adminAddProducts_type.Items.AddRange(new object[] { "Meal", "Drinks" });
            adminAddProducts_type.Location = new Point(151, 108);
            adminAddProducts_type.Name = "adminAddProducts_type";
            adminAddProducts_type.Size = new Size(204, 25);
            adminAddProducts_type.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(103, 118);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Type:";
            // 
            // adminAddProducts_name
            // 
            adminAddProducts_name.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_name.Location = new Point(151, 67);
            adminAddProducts_name.Name = "adminAddProducts_name";
            adminAddProducts_name.Size = new Size(204, 25);
            adminAddProducts_name.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 77);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 6;
            label3.Text = "Product Name:";
            // 
            // adminAddProducts_id
            // 
            adminAddProducts_id.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminAddProducts_id.Location = new Point(151, 27);
            adminAddProducts_id.Name = "adminAddProducts_id";
            adminAddProducts_id.Size = new Size(204, 25);
            adminAddProducts_id.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 37);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 4;
            label2.Text = "Product ID:";
            // 
            // AdminAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddProducts";
            Size = new Size(1074, 520);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminAddProducts_imageView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox adminAddProducts_id;
        private Label label2;
        private TextBox adminAddProducts_name;
        private Label label3;
        private ComboBox adminAddProducts_type;
        private Label label5;
        private Panel panel3;
        private ComboBox adminAddProducts_status;
        private Label label4;
        private TextBox adminAddProducts_price;
        private Label label6;
        private TextBox adminAddProducts_stock;
        private Label label7;
        private Button adminAddProducts_importBtn;
        private PictureBox adminAddProducts_imageView;
        private Button adminAddProducts_clearBtn;
        private Button adminAddProducts_deleteBtn;
        private Button adminAddProducts_updateBtn;
        private Button adminAddProducts_addBtn;
    }
}
