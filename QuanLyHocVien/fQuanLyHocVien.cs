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
    public partial class fQuanLyHocVien : Form
    {
        //Tạo dữ liệu học viên
        public List<Student> students = new List<Student>
        {
            new Student("SV001", "Nguyễn Văn A", "Hà Nội", "123 Trần Phú", 8.5, 7.0, 9.0),
            new Student("SV002", "Trần Thị B", "TP.HCM", "456 Lê Lợi", 7.0, 8.5, 7.5),
            new Student("SV003", "Lê Văn C", "Đà Nẵng", "789 Nguyễn Huệ", 9.0, 8.0, 8.5),
            new Student("SV004", "Phạm Thị D", "Cần Thơ", "159 Hai Bà Trưng", 6.5, 7.0, 8.0),
            new Student("SV005", "Hoàng Văn E", "Hải Phòng", "753 Lý Thường Kiệt", 8.0, 9.0, 9.5)
        };
        public fQuanLyHocVien()
        {
            InitializeComponent();
        }

        public void fQuanLyHocVien_Load(object sender, EventArgs e)
        {
            //setting
            this.MaximizeBox = false;
            lbUsername.Text = fLogin.username;
            //Hiển thị mặc định là chức năng thêm học sinh
            btnAddStudentFunc.Focus();
            pnContent.Controls.Clear();
            UCAddStudent uc = new UCAddStudent(this);
            pnContent.Controls.Add(uc);
        }

        public void ShowUserConTrol(UserControl uc)
        {
            pnContent.Controls.Clear();
            pnContent.Controls.Add(uc);
        }

        public void btnAddStudentFunc_Click(object sender, EventArgs e)
        {
            ShowUserConTrol(new UCAddStudent(this));
        }

        public void btnUpdateStudentFunc_Click(object sender, EventArgs e)
        {
            ShowUserConTrol(new UCUpdateStudent(this));
        }

        public void btnDeleteStudentFunc_Click(object sender, EventArgs e)
        {
            ShowUserConTrol(new UCDeleteStudent(this));
        }

        public void btnSearchStudentFunc_Click(object sender, EventArgs e)
        {
            ShowUserConTrol(new UCFindStudent(this));
        }

        public void btnIsHocBongFunc_Click(object sender, EventArgs e)
        {
            List<Student> hocBongStudents = students.Where(s => s.IsHocBong_72_Thang()).ToList();

            if (hocBongStudents.Count == 0)
            {
                MessageBox.Show("Không có học viên nào đạt học bổng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị danh sách học viên có học bổng trên DataGridView
            ShowUserConTrol(new UCIsHocBong(hocBongStudents));
        }

        private void btnListHocVien_Click(object sender, EventArgs e)
        {
            ShowUserConTrol(new UCShowListStudents(students));
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
