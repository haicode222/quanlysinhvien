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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void LockControls(bool isLocked)
        {
            maSVTextBox.ReadOnly = isLocked;
            hoTenTextBox.ReadOnly = isLocked;
            lopTextBox.ReadOnly = isLocked;

            // Thay đổi màu nền để người dùng dễ nhận biết (tùy chọn)
            maSVTextBox.BackColor = isLocked ? Color.LightGray : Color.White;
            hoTenTextBox.BackColor = isLocked ? Color.LightGray : Color.White;
            lopTextBox.BackColor = isLocked ? Color.LightGray : Color.White;
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);

        }

        private void sinhVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);

        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbQLSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.dbQLSVDataSet.SinhVien);

            LockControls(true); // Khóa các TextBox khi mới load form

        }

        private void maSVLabel_Click(object sender, EventArgs e)
        {

        }


        private void sinhVienDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LockControls(true); // Khóa các TextBox khi người dùng chọn một dòng trong DataGridView
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Ép các ô nhập liệu hoàn tất việc đẩy dữ liệu vào bộ nhớ tạm (DataSet)
                this.Validate();

                // 2. Kết thúc quá trình chỉnh sửa trên BindingSource
                this.sinhVienBindingSource.EndEdit();

                // 3. Sử dụng TableAdapterManager để đẩy tất cả thay đổi xuống Database
                // Lưu ý: Nếu tên DataSet của bạn khác, hãy sửa 'quanLySVDataSet' cho đúng
                int result = this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);

                if (result > 0)
                {
                    // 4. Tải lại dữ liệu từ Database lên giao diện để đồng bộ hoàn toàn
                    this.sinhVienTableAdapter.Fill(this.dbQLSVDataSet.SinhVien);
                    LockControls(true); // Khóa lại các TextBox sau khi lưu

                    MessageBox.Show("Đã lưu " + result + " thay đổi thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào để lưu.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có (ví dụ: trùng mã sinh viên, dữ liệu quá dài...)
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
           
            this.sinhVienBindingSource.AddNew(); // Thêm một dòng mới vào BindingSource
                LockControls(false); // Mở khóa các TextBox để người dùng nhập liệu
            maSVTextBox.Focus(); 
        }

        private void sinhVienBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (sinhVienBindingSource.Current != null)
            {
                // 2. Hiện thông báo xác nhận để tránh xóa nhầm
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        // 3. Xóa dòng hiện tại khỏi bộ nhớ tạm (BindingSource)
                        sinhVienBindingSource.RemoveCurrent();

                        // 4. Lưu thay đổi này xuống Database thực tế
                        this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);

                        // 5. Tải lại danh sách để giao diện luôn khớp với Database
                        this.sinhVienTableAdapter.Fill(this.dbQLSVDataSet.SinhVien);

                        MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Sau khi xóa xong thì khóa các ô lại cho sạch sẽ
                        LockControls(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên trong danh sách để xóa!", "Thông báo");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (sinhVienBindingSource.Current != null)
            {
                // 2. Mở khóa các ô nhập liệu bằng hàm bạn đã viết
                LockControls(false);

                // 3. QUAN TRỌNG: Khóa riêng ô Mã Sinh Viên
                // Vì Mã SV là khóa chính (Primary Key), không nên cho phép sửa 
                // để tránh lỗi logic và lỗi Database.
                maSVTextBox.ReadOnly = true;
                maSVTextBox.BackColor = Color.LightGray;

                // 4. Đưa con trỏ vào ô Họ tên để người dùng bắt đầu sửa
                hoTenTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách để sửa!");
            }
        }
    }
}
