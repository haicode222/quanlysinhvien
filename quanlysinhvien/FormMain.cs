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
            tbxMaSV.ReadOnly = isLocked;
            hoTenTextBox.ReadOnly = isLocked;
            cmbMaLop.Enabled = !isLocked;

            // Thay đổi màu nền để người dùng dễ nhận biết (tùy chọn)
            tbxMaSV.BackColor = isLocked ? Color.LightGray : Color.White;
            hoTenTextBox.BackColor = isLocked ? Color.LightGray : Color.White;
            cmbMaLop.BackColor = isLocked ? Color.LightGray : Color.White;
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
            
            this.lopQLTableAdapter.Fill(this.dbQLSVDataSet.LopQL);
            
            this.sinhVienTableAdapter.Fill(this.dbQLSVDataSet.SinhVien);

            LockControls(true); // Khóa các TextBox khi mới load form

        }

        private void maSVLabel_Click(object sender, EventArgs e)
        {

        }


        private void sinhVienDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LockControls(true); 
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmbMaLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp học từ danh sách!", "Thông báo");
                cmbMaLop.Focus();
                return;
            }

            try
            {
              
                this.Validate();
                this.sinhVienBindingSource.EndEdit();

                
                int result = this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);

                if (result > 0)
                {
                    
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
                
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
           
            this.sinhVienBindingSource.AddNew(); 
                LockControls(false); 

            if (cmbMaLop.Items.Count > 0)
                cmbMaLop.SelectedIndex = 0;

            tbxMaSV.Focus(); 
        }

        private void sinhVienBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (sinhVienBindingSource.Current != null)
            {
                
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        
                        sinhVienBindingSource.RemoveCurrent();

                       
                        this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);

                       
                        this.sinhVienTableAdapter.Fill(this.dbQLSVDataSet.SinhVien);

                        MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
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
                
                LockControls(false);

               
                // Vì Mã SV là khóa chính (Primary Key), không nên cho phép sửa 
              
                tbxMaSV.ReadOnly = true;
                tbxMaSV.BackColor = Color.LightGray;

                // 4. Đưa con trỏ vào ô Họ tên để người dùng bắt đầu sửa
                hoTenTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách để sửa!");
            }
        }

        private void sinhVienDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lopQLDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LockControlsLop(bool isLocked)
        {
            tbxMalop.ReadOnly = isLocked;
            tbxTenlop.ReadOnly = isLocked;

            tbxMalop.Enabled = true;
            tbxTenlop.Enabled = true;

            lopQLDataGridView.Enabled = isLocked;

            // Màu nền để người dùng biết ô nào đang bị khóa
            Color backColor = isLocked ? Color.LightGray : Color.White;
            tbxMalop.BackColor = backColor;
            tbxTenlop.BackColor = backColor;
        }


        private void btn_addCl_Click(object sender, EventArgs e)
        {
            this.lopQLBindingSource.CancelEdit();

            this.lopQLBindingSource.AddNew();

            // 2. Mở khóa để nhập liệu
            LockControlsLop(false);

            //tbxMalop.Clear();
            //tbxTenlop.Clear();

            tbxMalop.ReadOnly = false;
            // 3. Đưa con trỏ vào ô Mã lớp
            tbxMalop.Focus();
        }

        private void btn_editCl_Click(object sender, EventArgs e)
        {
            if (lopQLBindingSource.Current != null)
            {
                LockControlsLop(false);

                // KHÔNG cho sửa Mã lớp (Khóa chính)
                tbxMalop.ReadOnly = true;
                tbxMalop.BackColor = Color.LightGray;

                tbxTenlop.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp để sửa!");
            }
        }

        private void btn_delCl_Click(object sender, EventArgs e)
        {
            if (lopQLBindingSource.Current != null)
            {
                DialogResult dr = MessageBox.Show("Xóa lớp này sẽ mất dữ liệu liên quan. Bạn có chắc không?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        lopQLBindingSource.RemoveCurrent();
                        this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);
                        MessageBox.Show("Đã xóa lớp thành công!");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Không thể xóa lớp này vì đang có sinh viên thuộc lớp này!");

                        this.lopQLTableAdapter.Fill(this.dbQLSVDataSet.LopQL);
                    }
                }
            }
        }

        private void btn_saveCl_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lopQLBindingSource.EndEdit();

            // 2. Kiểm tra xem bộ nhớ (DataSet) có thấy thay đổi không
            if (this.dbQLSVDataSet.HasChanges())
            {
                try
                {
                    // 3. Dùng đích danh TableAdapter của Lớp để lưu (Thay vì Manager)
                    // Lệnh này sẽ trả về số dòng được lưu thành công
                    int ketQua = this.lopQLTableAdapter.Update(this.dbQLSVDataSet.LopQL);

                    if (ketQua > 0)
                    {
                        MessageBox.Show($"Ngon rồi! Đã lưu thành công {ketQua} lớp học.");
                        this.lopQLTableAdapter.Fill(this.dbQLSVDataSet.LopQL);
                        LockControlsLop(true);
                    }
                    else
                    {
                        MessageBox.Show("Máy báo đã chạy lệnh lưu nhưng 0 dòng được ghi vào DB. Lạ nhỉ!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thực thi SQL (Có thể trùng mã hoặc lỗi DB): " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("DataSet bảo: 'Tôi chả thấy ông giáo thay đổi chữ nào cả!'. Hãy kiểm tra lại DataBindings.");
            }
        }

        private void btn_create_Click_1(object sender, EventArgs e)
        {
            this.sinhVienBindingSource.AddNew();
            LockControls(false);

            if (cmbMaLop.Items.Count > 0)
                cmbMaLop.SelectedIndex = 0;

            tbxMaSV.Focus();
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            if (sinhVienBindingSource.Current != null)
            {

                LockControls(false);


                // Vì Mã SV là khóa chính (Primary Key), không nên cho phép sửa 

                tbxMaSV.ReadOnly = true;
                tbxMaSV.BackColor = Color.LightGray;

                // 4. Đưa con trỏ vào ô Họ tên để người dùng bắt đầu sửa
                hoTenTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ danh sách để sửa!");
            }
        }

        private void btn_del_Click_1(object sender, EventArgs e)
        {
            if (sinhVienBindingSource.Current != null)
            {

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    try
                    {

                        sinhVienBindingSource.RemoveCurrent();


                        this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);


                        this.sinhVienTableAdapter.Fill(this.dbQLSVDataSet.SinhVien);

                        MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            if (cmbMaLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp học từ danh sách!", "Thông báo");
                cmbMaLop.Focus();
                return;
            }

            try
            {

                this.Validate();
                this.sinhVienBindingSource.EndEdit();


                int result = this.tableAdapterManager.UpdateAll(this.dbQLSVDataSet);

                if (result > 0)
                {

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

                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbx_TimMaLop_TextChanged(object sender, EventArgs e)
        {
            string filterValue = tbx_TimMaLop.Text.Trim();

            if (string.IsNullOrEmpty(filterValue))
            {
                // Nếu ô tìm kiếm trống, hiển thị lại toàn bộ danh sách
                this.sinhVienBindingSource.RemoveFilter();
            }
            else
            {
                // Sử dụng cú pháp LIKE để tìm kiếm gần đúng
                // Cú pháp: "[TênCột] LIKE '%giá_trị%'"
                this.sinhVienBindingSource.Filter = string.Format("MaLop LIKE '%{0}%'", filterValue);
            }

        }
    }
}
