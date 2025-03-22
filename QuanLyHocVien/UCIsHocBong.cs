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
    public partial class UCIsHocBong : UserControl
    {
        public UCIsHocBong(List<Student> hocBongStudents)
        {
            InitializeComponent();
            // Cấu hình DataGridView
            dataIsHocBongSinhVien.AutoGenerateColumns = false;
            dataIsHocBongSinhVien.Columns.Clear();

            dataIsHocBongSinhVien.Columns.Add("STT", "STT");
            dataIsHocBongSinhVien.Columns.Add("Maso", "Mã số");
            dataIsHocBongSinhVien.Columns.Add("HoTen", "Họ tên");
            dataIsHocBongSinhVien.Columns.Add("DiemTrungBinh", "Điểm Trung Bình");
            dataIsHocBongSinhVien.Columns.Add("HocBong", "Học Bổng");

            // Thêm dữ liệu vào DataGridView
            int stt = 1; // Bắt đầu từ 1
            foreach (var student in hocBongStudents)
            {
                dataIsHocBongSinhVien.Rows.Add(stt++, student.Maso_72_Thang, student.HoTen_72_Thang, student.TinhDiemTrungBinh_72_Thang(), student.IsHocBong_72_Thang() ? "Có" : "Không");
            }
        }
    }
}
