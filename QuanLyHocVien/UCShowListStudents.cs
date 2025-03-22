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
    public partial class UCShowListStudents : UserControl
    {
        public UCShowListStudents(List<Student> students)
        {
            InitializeComponent();
            flpStudents.Controls.Clear();

            foreach (var student in students)
            {
                Label lblStudent = new Label();
                lblStudent.Text = $"🔹 {student.Maso_72_Thang} - {student.HoTen_72_Thang} - {student.TinhDiemTrungBinh_72_Thang():0.00}";
                lblStudent.Font = new Font("Arial", 14, FontStyle.Bold);
                lblStudent.AutoSize = true;
                lblStudent.Padding = new Padding(10);

                flpStudents.Controls.Add(lblStudent);
            }
        }

        private void UCShowListStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
