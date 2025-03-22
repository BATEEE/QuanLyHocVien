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
    public partial class UCAddStudent : UserControl
    {
        private fQuanLyHocVien fMain_72_Thang;
        public UCAddStudent(fQuanLyHocVien f)
        {
            InitializeComponent();
            fMain_72_Thang = f;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSo.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã số và Họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fMain_72_Thang.students.Add(new Student(txtMaSo.Text, txtHoTen.Text, txtQueQuan.Text,txtDiaChi.Text));
            MessageBox.Show("Thêm học viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaSo.Clear();
            txtHoTen.Clear();
            txtQueQuan.Clear();
            txtDiaChi.Clear();
        }
    }
}
