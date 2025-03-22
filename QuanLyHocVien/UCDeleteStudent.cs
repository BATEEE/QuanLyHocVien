using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocVien
{
    public partial class UCDeleteStudent : UserControl
    {
        private fQuanLyHocVien fMain_72_Thang;
        public UCDeleteStudent(fQuanLyHocVien fMain_72_Thang)
        {
            InitializeComponent();
            this.fMain_72_Thang = fMain_72_Thang;
        }

        private void UCDeleteStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSoTimKiem_72_Thang = txtMaSoFind.Text.Trim();

            if (string.IsNullOrEmpty(maSoTimKiem_72_Thang))
            {
                MessageBox.Show("Vui lòng nhập Mã số học viên cần tìm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student studentToRemove_72_Thang = fMain_72_Thang.students.FirstOrDefault(s => s.Maso_72_Thang == maSoTimKiem_72_Thang);

            if (studentToRemove_72_Thang == null)
            {
                MessageBox.Show("Không tìm thấy học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xoá học viên {studentToRemove_72_Thang.HoTen_72_Thang} không?",
                                          "Xác nhận xoá",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                fMain_72_Thang.students.Remove(studentToRemove_72_Thang); // Xoá học viên khỏi danh sách
                txtMaSoFind.Clear();
                MessageBox.Show("Xoá học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
