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
    public partial class UCUpdateStudent : UserControl
    {
        private fQuanLyHocVien fMain_72_Thang;
        public UCUpdateStudent(fQuanLyHocVien f)
        {
            InitializeComponent();
            fMain_72_Thang = f;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maSoTimKiem_72_Thang = txtMaSoFind.Text.Trim();

            if (string.IsNullOrEmpty(maSoTimKiem_72_Thang))
            {
                MessageBox.Show("Vui lòng nhập Mã số học viên cần tìm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student student = fMain_72_Thang.students.FirstOrDefault(s => s.Maso_72_Thang == maSoTimKiem_72_Thang);
            if (student != null)
            {
                pnUpdate.Visible = true;
                btnTim.Enabled = false;
                txtMaSoFind.Enabled = false;
                // Hiển thị thông tin lên giao diện
                txtMaSo.Text = student.Maso_72_Thang;
                txtHoTen.Text = student.HoTen_72_Thang;
                txtQueQuan.Text = student.QueQuan_72_Thang;
                txtDiaChi.Text = student.DiaChi_72_Thang;
                txtToan.Text = student.DiemToan_72_Thang.ToString();
                txtVan.Text = student.DiemVan_72_Thang.ToString();
                txtAnh.Text = student.DiemAnh_72_Thang.ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            pnUpdate.Visible = false;
            btnTim.Enabled = true;
            txtMaSoFind.Enabled = true;
            txtMaSoFind.Clear();
        }

        private void UCUpdateStudent_Load(object sender, EventArgs e)
        {
            pnUpdate.Visible = false;
        }

        private void btnUpdateStudent_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSo.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã số và Họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtToan.Text, out double diemToan_72_Thang) ||
                !double.TryParse(txtVan.Text, out double diemVan_72_Thang) ||
                !double.TryParse(txtAnh.Text, out double diemAnh_72_Thang) ||
                diemToan_72_Thang < 0 || diemToan_72_Thang > 10 ||
                diemVan_72_Thang < 0 || diemVan_72_Thang > 10 ||
                diemAnh_72_Thang < 0 || diemAnh_72_Thang > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin học viên
            string maSoTimKiem_72_Thang = txtMaSoFind.Text.Trim();
            Student student_72_Thang = fMain_72_Thang.students.FirstOrDefault(s => s.Maso_72_Thang == maSoTimKiem_72_Thang);
            student_72_Thang.Maso_72_Thang = txtMaSo.Text;
            student_72_Thang.HoTen_72_Thang = txtHoTen.Text;
            student_72_Thang.QueQuan_72_Thang = txtQueQuan.Text;
            student_72_Thang.DiaChi_72_Thang = txtDiaChi.Text;
            student_72_Thang.DiemToan_72_Thang = Convert.ToDouble(txtToan.Text);
            student_72_Thang.DiemVan_72_Thang = Convert.ToDouble(txtVan.Text);
            student_72_Thang.DiemAnh_72_Thang = Convert.ToDouble(txtAnh.Text);

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnUpdate.Visible = false;
            btnTim.Enabled = true;
            txtMaSoFind.Enabled = true;
            txtMaSoFind.Clear();
        }

        private void pnFind_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
