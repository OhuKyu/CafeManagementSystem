namespace CafeShopManagementSystem
{
    partial class AdminMainForm
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
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            adminDashboard1 = new AdminDashboard();
            adminAddUsers1 = new CafeShopManageSystem.AdminAddUsers();
            adminAddProducts1 = new CafeShopManageSystem.AdminAddProducts();
            cashierCustomersForm1 = new CafeShopManageSystem.CashierCustomersForm();
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
            panel1.TabIndex = 0;
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
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(223, 505);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CafeShopManageSystem.Properties.Resources.icons8_Cafe_100px_6;
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
            // button3
            // 
            button3.BackColor = Color.FromArgb(7, 9, 22);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 341);
            button3.Name = "button3";
            button3.Size = new Size(196, 35);
            button3.TabIndex = 18;
            button3.Text = "Customers";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(7, 9, 22);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 300);
            button4.Name = "button4";
            button4.Size = new Size(196, 35);
            button4.TabIndex = 17;
            button4.Text = "Add Product";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(7, 9, 22);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 259);
            button2.Name = "button2";
            button2.Size = new Size(196, 35);
            button2.TabIndex = 16;
            button2.Text = "Add Cashier";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(7, 9, 22);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 218);
            button1.Name = "button1";
            button1.Size = new Size(196, 35);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 155);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 15;
            label4.Text = "Admin";
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
            label2.Size = new Size(123, 18);
            label2.TabIndex = 14;
            label2.Text = "Admin's Portal";
            // 
            // panel3
            // 
            panel3.Controls.Add(adminDashboard1);
            panel3.Controls.Add(adminAddUsers1);
            panel3.Controls.Add(adminAddProducts1);
            panel3.Controls.Add(cashierCustomersForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(223, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1101, 505);
            panel3.TabIndex = 2;
            // 
            // adminDashboard1
            // 
            adminDashboard1.Location = new Point(0, 0);
            adminDashboard1.Name = "adminDashboard1";
            adminDashboard1.Size = new Size(1101, 505);
            adminDashboard1.TabIndex = 3;
            // 
            // adminAddUsers1
            // 
            adminAddUsers1.Location = new Point(0, 0);
            adminAddUsers1.Name = "adminAddUsers1";
            adminAddUsers1.Size = new Size(1101, 505);
            adminAddUsers1.TabIndex = 2;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1101, 502);
            adminAddProducts1.TabIndex = 1;
            // 
            // cashierCustomersForm1
            // 
            cashierCustomersForm1.Location = new Point(0, 0);
            cashierCustomersForm1.Name = "cashierCustomersForm1";
            cashierCustomersForm1.Size = new Size(1101, 505);
            cashierCustomersForm1.TabIndex = 0;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 550);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
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
        private Panel panel2;
        private Label label1;
        private Label close;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button btn_logout;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Panel panel3;
        private CafeShopManageSystem.CashierCustomersForm cashierCustomersForm1;
        private AdminDashboard adminDashboard1;
        private CafeShopManageSystem.AdminAddUsers adminAddUsers1;
        private CafeShopManageSystem.AdminAddProducts adminAddProducts1;
    }
}