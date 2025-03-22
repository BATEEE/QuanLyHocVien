using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocVien
{
    public class Student
    {
        public string Maso_72_Thang {  get; set; }
        public string HoTen_72_Thang { get; set; }
        public string QueQuan_72_Thang { get; set; }
        public string DiaChi_72_Thang { get; set; }
        public double DiemToan_72_Thang { get; set; }
        public double DiemVan_72_Thang { get; set; }
        public double DiemAnh_72_Thang {  get; set; }


        public Student(string maso, string hoten, string quequan, string diachi)
        {
            Maso_72_Thang = maso;
            HoTen_72_Thang = hoten;
            QueQuan_72_Thang = quequan;
            DiaChi_72_Thang = diachi;
        }

        public Student(string maso, string hoten, string quequan, string diachi, double diemToan, double diemVan, double diemAnh)
        {
            Maso_72_Thang = maso;
            HoTen_72_Thang = hoten;
            QueQuan_72_Thang = quequan;
            DiaChi_72_Thang = diachi;
            DiemToan_72_Thang = diemToan;
            DiemVan_72_Thang = diemVan;
            DiemAnh_72_Thang = diemAnh;
        }

        //72_Thang
        //Tính điểm trung bình
        public double TinhDiemTrungBinh_72_Thang()
        {
            return (this.DiemAnh_72_Thang + this.DiemToan_72_Thang + this.DiemVan_72_Thang) / 3.0;
        }

        //Kiểm tra học bổng
        public bool IsHocBong_72_Thang()
        {
            double dtb_72_Thang = TinhDiemTrungBinh_72_Thang();
            return dtb_72_Thang >= 8.0 && DiemToan_72_Thang >= 5.0 && DiemVan_72_Thang >= 5.0 && DiemAnh_72_Thang >= 5.0;
        }

        //72_Thang
        public override string ToString()
        {
            return $"{Maso_72_Thang} - {HoTen_72_Thang} - Quê quán: {QueQuan_72_Thang} - Điểm TB: {TinhDiemTrungBinh_72_Thang():0.00} - {(IsHocBong_72_Thang() ? "Học bổng" : "Không")}";
        }
    }
}
