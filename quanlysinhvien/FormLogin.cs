using quanlysinhvien.DbQLSVDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                // 2. Gọi hàm CheckLogin đã tạo ở bước trên
                // Truyền vào username và password từ TextBox
                int? result = (int?)usersTableAdapter.CheckLogin(tbx_Username.Text, tbx_Password.Text);

                // 3. Kiểm tra kết quả
                if (result > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở FormMain
                    FormMain fMain = new FormMain();
                    this.Hide(); // Ẩn form login
                    fMain.ShowDialog(); // Hiện form main
                    this.Close(); // Đóng hẳn khi xong
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
        
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbQLSVDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dbQLSVDataSet.Users);

        }
    }
}
