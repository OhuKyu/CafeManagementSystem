namespace CafeShopManageSystem
{
    partial class CashierMainForm
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
            panel1 = new Panel();
            label1 = new Label();
            close = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btn_logout = new Button();
            customer_btn = new Button();
            order_btn = new Button();
            addProducts_btn = new Button();
            dashboard_btn = new Button();
            username = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            adminDashboard1 = new CafeShopManagementSystem.AdminDashboard();
            adminAddProducts1 = new AdminAddProducts();
            cashierOrderForm1 = new CashierOrderForm();
            cashierCustomersForm1 = new CashierCustomersForm();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1324, 45);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(211, 15);
            label1.TabIndex = 13;
            label1.Text = "Cafe Shop Management System";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(1306, 0);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 12;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(7, 9, 22);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btn_logout);
            panel2.Controls.Add(customer_btn);
            panel2.Controls.Add(order_btn);
            panel2.Controls.Add(addProducts_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(username);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 505);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_Cafe_100px_6;
            pictureBox1.Location = new Point(45, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(7, 9, 22);
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Location = new Point(12, 458);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(196, 35);
            btn_logout.TabIndex = 19;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // customer_btn
            // 
            customer_btn.BackColor = Color.FromArgb(7, 9, 22);
            customer_btn.FlatStyle = FlatStyle.Flat;
            customer_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_btn.ForeColor = Color.White;
            customer_btn.Location = new Point(12, 339);
            customer_btn.Name = "customer_btn";
            customer_btn.Size = new Size(196, 35);
            customer_btn.TabIndex = 18;
            customer_btn.Text = "Customers";
            customer_btn.UseVisualStyleBackColor = false;
            customer_btn.Click += customer_btn_Click;
            // 
            // order_btn
            // 
            order_btn.BackColor = Color.FromArgb(7, 9, 22);
            order_btn.FlatStyle = FlatStyle.Flat;
            order_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_btn.ForeColor = Color.White;
            order_btn.Location = new Point(12, 298);
            order_btn.Name = "order_btn";
            order_btn.Size = new Size(196, 35);
            order_btn.TabIndex = 17;
            order_btn.Text = "Order";
            order_btn.UseVisualStyleBackColor = false;
            order_btn.Click += order_btn_Click;
            // 
            // addProducts_btn
            // 
            addProducts_btn.BackColor = Color.FromArgb(7, 9, 22);
            addProducts_btn.FlatStyle = FlatStyle.Flat;
            addProducts_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProducts_btn.ForeColor = Color.White;
            addProducts_btn.Location = new Point(12, 257);
            addProducts_btn.Name = "addProducts_btn";
            addProducts_btn.Size = new Size(196, 35);
            addProducts_btn.TabIndex = 16;
            addProducts_btn.Text = "Add Products";
            addProducts_btn.UseVisualStyleBackColor = false;
            addProducts_btn.Click += addProducts_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.FromArgb(7, 9, 22);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(12, 216);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(196, 35);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.White;
            username.Location = new Point(96, 155);
            username.Name = "username";
            username.Size = new Size(58, 15);
            username.TabIndex = 15;
            username.Text = "Cashier";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 14;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 126);
            label2.Name = "label2";
            label2.Size = new Size(135, 18);
            label2.TabIndex = 14;
            label2.Text = "Cashier's Portal";
            // 
            // panel3
            // 
            panel3.Controls.Add(adminDashboard1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierOrderForm1);
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(223, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 505);
            panel3.TabIndex = 3;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1101, 505);
            adminDashboard1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1101, 505);
            adminAddProducts1.TabIndex = 2;
            // 
            // cashierOrderForm1
            // 
            cashierOrderForm1.Location = new Point(0, 0);
            cashierOrderForm1.Name = "cashierOrderForm1";
            cashierOrderForm1.Size = new Size(1101, 505);
            cashierOrderForm1.TabIndex = 1;
            // 
            // cashierCustomersForm1
            // 
            cashierCustomersForm1.Location = new Point(0, 0);
            cashierCustomersForm1.Name = "cashierCustomersForm1";
            cashierCustomersForm1.Size = new Size(1101, 505);
            cashierCustomersForm1.TabIndex = 0;
            // 
            // CashierMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 550);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashierMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label close;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btn_logout;
        private Button customer_btn;
        private Button order_btn;
        private Button addProducts_btn;
        private Button dashboard_btn;
        private Label username;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private CafeShopManagementSystem.AdminDashboard adminDashboard1;
        private AdminAddProducts adminAddProducts1;
        private CashierOrderForm cashierOrderForm1;
        private CashierCustomersForm cashierCustomersForm1;
    }
}