using CafeShopManagementSystem;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace CafeShopManageSystem
{
    public partial class AdminAddUsers : UserControl
    {
        static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DP221405\cafe.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection connect = new SqlConnection(conn);
        public AdminAddUsers()
        {
            InitializeComponent();
            displayAddUsersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsersData();
        }

        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();
            dataGridView1.DataSource = listData;
        }

        public bool emptyField()
        {
            return string.IsNullOrEmpty(adminAddUsers_username.Text) ||
                   string.IsNullOrEmpty(adminAddUsers_password.Text) ||
                   string.IsNullOrEmpty(adminAddUsers_role.Text) ||
                   string.IsNullOrEmpty(adminAddUsers_status.Text);
        }

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyField() || adminAddUsers_imageView.Image == null)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();
                string selectUsern = "SELECT * FROM users WHERE username = @usern";

                using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                {
                    checkUsern.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        string usern = char.ToUpper(adminAddUsers_username.Text[0]) + adminAddUsers_username.Text.Substring(1);
                        MessageBox.Show(usern + " đã có người sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string path = SaveImage(adminAddUsers_imageView.ImageLocation, adminAddUsers_username.Text.Trim());

                        string insertData = "INSERT INTO users(username, password, profile_image, role, status, date_reg) " +
                                            "VALUES(@usern, @pass, @image, @role, @status, @date)";
                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayAddUsersData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void adminAddUsers_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    adminAddUsers_imageView.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int id = 0;
        private string existingImagePath = string.Empty;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            adminAddUsers_username.Text = row.Cells[1].Value.ToString();
            adminAddUsers_password.Text = row.Cells[2].Value.ToString();
            adminAddUsers_role.Text = row.Cells[3].Value.ToString();
            adminAddUsers_status.Text = row.Cells[4].Value.ToString();

            existingImagePath = row.Cells[5].Value.ToString();

            try
            {
                if (!string.IsNullOrEmpty(existingImagePath))
                {
                    adminAddUsers_imageView.Image = Image.FromFile(existingImagePath);
                }
                else
                {
                    adminAddUsers_imageView.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có hình ảnh đâu đồ ngốc :3", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn cập nhật Username: " + adminAddUsers_username.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status, profile_image = @imagePath WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", id);

                            string path = adminAddUsers_imageView.ImageLocation != null ?
                                SaveImage(adminAddUsers_imageView.ImageLocation, adminAddUsers_username.Text.Trim()) : existingImagePath;

                            cmd.Parameters.AddWithValue("@imagePath", path);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayAddUsersData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kết nối thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void adminAddUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn muốn xoá username này: " + adminAddUsers_username.Text.Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    connect.Open();

                    string deleteData = "DELETE FROM users WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        displayAddUsersData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void clearFields()
        {
            adminAddUsers_username.Text = "";
            adminAddUsers_password.Text = "";
            adminAddUsers_role.SelectedIndex = -1;
            DisposeImage();
        }

        private void DisposeImage()
        {
            if (adminAddUsers_imageView.Image != null)
            {
                adminAddUsers_imageView.Image.Dispose(); 
                adminAddUsers_imageView.Image = null;
                adminAddUsers_imageView.ImageLocation = null;
            }
        }

        private string SaveImage(string imageLocation, string username)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string directoryPath = Path.Combine(baseDirectory, "User_Directory");
            string filePath = Path.Combine(directoryPath, username + ".png");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (File.Exists(filePath))
            {
                filePath = Path.Combine(directoryPath, Guid.NewGuid().ToString() + ".png");
            }

            File.Copy(imageLocation, filePath, true);
            return filePath;
        }

        private void adminAddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
