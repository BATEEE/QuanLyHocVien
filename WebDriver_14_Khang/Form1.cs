using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebDriver_14_Khang
{
    public partial class WebDriver_14_Khang: Form
    {
        IWebDriver driver_14_Khang;
        public WebDriver_14_Khang()
        {
            InitializeComponent();
        }

        private void buttonOpenBrowser_14_Khang_Click(object sender, EventArgs e)
        {
            //tắt màn hình đen khi chạy
            ChromeDriverService Chrome_14_Khang = ChromeDriverService.CreateDefaultService();
            Chrome_14_Khang.HideCommandPromptWindow = true;

            //Điều hướng trình duyệt
            driver_14_Khang = new ChromeDriver(Chrome_14_Khang);
            driver_14_Khang.Navigate().GoToUrl("https://giasudatviet.com");

            IWebElement login_phone_14_Khang = driver_14_Khang.FindElement(By.Name("login__phone"));
            login_phone_14_Khang.SendKeys("12345678");

            IWebElement login_14_Khang = driver_14_Khang.FindElement(By.ClassName("btn_s3"));
            login_14_Khang.Click();

            Thread.Sleep(2000);//trì hoãn 2s

            IWebElement close_14_Khang = driver_14_Khang.FindElement(By.CssSelector("button.confirm.btn.btn-lg.btn-primary"));
            close_14_Khang.Click();

            driver_14_Khang.Navigate().GoToUrl("https://giasudatviet.com/dang-ky-tim-gia-su.html");

            Thong_Tin_Dang_Ky_14_Khang();

            driver_14_Khang.Navigate().GoToUrl("https://giasudatviet.com/gia-su-tieu-bieu.html");

            Tim_Kiem_Gia_Su_14_Khang();

            Thong_Tin_Dang_Ky_14_Khang();

            driver_14_Khang.Navigate().GoToUrl("https://giasudatviet.com/dang-ky-lam-gia-su.html");

            Dang_Ky_Lam_Gia_Su_14_Khang();

            driver_14_Khang.Navigate().GoToUrl("https://giasudatviet.com/lop-day-can-gia-su.html");

            Lop_Moi_Can_Gia_Su();

            driver_14_Khang.Quit();
        }

        private void Thong_Tin_Dang_Ky_14_Khang()
        {
            IWebElement name_14_Khang = driver_14_Khang.FindElement(By.Name("fullname"));
            name_14_Khang.SendKeys("Nguyễn Văn A");

            IWebElement address_14_Khang = driver_14_Khang.FindElement(By.Name("address"));
            address_14_Khang.SendKeys("1 địa chỉ nào đó");

            IWebElement phone_14_Khang = driver_14_Khang.FindElement(By.Name("phone"));
            phone_14_Khang.SendKeys("12345678");

            IWebElement yeu_cau_14_Khang = driver_14_Khang.FindElement(By.Name("yeu_cau"));
            yeu_cau_14_Khang.SendKeys("abcd 123 xyz");

            Thread.Sleep(5000);//trì hoãn 5s
        }

        private void Tim_Kiem_Gia_Su_14_Khang() {
            IWebElement tinh_thanh_14_Khang = driver_14_Khang.FindElement(By.Name("tinhthanh"));
            tinh_thanh_14_Khang.SendKeys("Hồ Chí Minh");

            IWebElement quan_huyen_14_Khang = driver_14_Khang.FindElement(By.Name("quanhuyen"));
            quan_huyen_14_Khang.SendKeys("Quận 7");

            IWebElement lop_14_Khang = driver_14_Khang.FindElement(By.Name("lop"));
            lop_14_Khang.SendKeys("Lớp 6");

            IWebElement mon_14_Khang = driver_14_Khang.FindElement(By.Name("mon"));
            mon_14_Khang.SendKeys("Toán ");

            IWebElement trinh_do_14_Khang = driver_14_Khang.FindElement(By.Name("trinhdo"));
            trinh_do_14_Khang.SendKeys("Giáo viên");

            IWebElement gender_14_Khang = driver_14_Khang.FindElement(By.Name("gender"));
            gender_14_Khang.SendKeys("Nữ");

            Thread.Sleep(3000);//trì hoãn 3s

            IWebElement search_14_Khang = driver_14_Khang.FindElement(By.ClassName("btn_s3"));
            search_14_Khang.Click();

            Thread.Sleep(3000);//trì hoãn 3s

            IWebElement chon_gia_su_14_Khang = driver_14_Khang.FindElement(By.ClassName("btn2"));
            chon_gia_su_14_Khang.Click();

            Thread.Sleep(5000);//trì hoãn 5s
        }

        private void Dang_Ky_Lam_Gia_Su_14_Khang()
        {
            IWebElement tinh_thanh_14_Khang = driver_14_Khang.FindElement(By.Name("province_id"));
            tinh_thanh_14_Khang.SendKeys("Hà Nội");

            IWebElement name_14_Khang = driver_14_Khang.FindElement(By.Name("fullname"));
            name_14_Khang.SendKeys("Trần Tuấn Thắng");

            IWebElement ngay_14_Khang = driver_14_Khang.FindElement(By.Name("dob_ngay"));
            ngay_14_Khang.SendKeys("12");

            IWebElement thang_14_Khang = driver_14_Khang.FindElement(By.Name("dob_thang"));
            thang_14_Khang.SendKeys("10");

            IWebElement nam_14_Khang = driver_14_Khang.FindElement(By.Name("dob_nam"));
            nam_14_Khang.SendKeys("1999");

            IWebElement gender_14_Khang = driver_14_Khang.FindElement(By.Name("gender"));
            gender_14_Khang.SendKeys("Nữ");

            IWebElement nguyen_quan_14_Khang = driver_14_Khang.FindElement(By.Name("nguyenquan"));
            nguyen_quan_14_Khang.SendKeys("Bà Rịa - Vũng Tàu");

            IWebElement giong_noi_14_Khang = driver_14_Khang.FindElement(By.Name("giongnoi"));
            giong_noi_14_Khang.SendKeys("Miền Nam");

            IWebElement address_14_Khang = driver_14_Khang.FindElement(By.Name("address"));
            address_14_Khang.SendKeys("1 địa chỉ nào đó");

            IWebElement cmnd_14_Khang = driver_14_Khang.FindElement(By.Name("cmnd"));
            address_14_Khang.SendKeys("0987654321");

            IWebElement email_14_Khang = driver_14_Khang.FindElement(By.Name("email"));
            email_14_Khang.SendKeys("1 địa chỉ nào đó");

            IWebElement facebook_14_Khang = driver_14_Khang.FindElement(By.Name("facebook"));
            facebook_14_Khang.SendKeys("1 đường link nào đó");

            IWebElement phone_14_Khang = driver_14_Khang.FindElement(By.Name("phone"));
            phone_14_Khang.SendKeys("12345678");

            IWebElement password_14_Khang = driver_14_Khang.FindElement(By.Name("password"));
            password_14_Khang.SendKeys("abcd123");

            IWebElement password_confirm_14_Khang = driver_14_Khang.FindElement(By.Name("password_confirm"));
            password_confirm_14_Khang.SendKeys("abcd123");

            string filePath_14_Khang = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures_14_Khang", "diadiemmoimo-7287.jpg");
            IWebElement file_avatar_14_Khang = driver_14_Khang.FindElement(By.Name("file_avatar"));
            file_avatar_14_Khang.SendKeys(filePath_14_Khang);

            filePath_14_Khang = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures_14_Khang", "daihomo-17239056774581331244686.jpg");
            IWebElement file_bangcap_14_Khang = driver_14_Khang.FindElement(By.Name("file_bangcap[]"));
            file_bangcap_14_Khang.SendKeys(filePath_14_Khang);

            filePath_14_Khang = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures_14_Khang", "Logo_DH_Mở_TPHCM.png");
            IWebElement file_cmnd_14_Khang = driver_14_Khang.FindElement(By.Name("file_cmnd[]"));
            file_cmnd_14_Khang.SendKeys(filePath_14_Khang);

            IWebElement truong_dao_tao_14_Khang = driver_14_Khang.FindElement(By.Name("truonghoc"));
            truong_dao_tao_14_Khang.SendKeys("Đại học Bách Khoa");

            IWebElement nganh_hoc_14_Khang = driver_14_Khang.FindElement(By.Name("chuyennganh"));
            nganh_hoc_14_Khang.SendKeys("Sư Phạm Toán học");

            IWebElement nam_nhap_hoc_14_Khang = driver_14_Khang.FindElement(By.Name("nam_nhaphoc"));
            nam_nhap_hoc_14_Khang.SendKeys("2020");

            IWebElement nam_tot_nghiep_14_Khang = driver_14_Khang.FindElement(By.Name("nam_totnghiep"));
            nam_tot_nghiep_14_Khang.SendKeys("2024");

            IWebElement trinh_do_14_Khang = driver_14_Khang.FindElement(By.Name("trinhdo"));
            trinh_do_14_Khang.SendKeys("Sinh Viên Sư Phạm");

            IWebElement uu_diem_14_Khang = driver_14_Khang.FindElement(By.Name("uudiem"));
            uu_diem_14_Khang.SendKeys("ưu điểm của tôi là không có gì đặc biệt trong những người đặc biệt");

            IWebElement mon_day_14_Khang = driver_14_Khang.FindElement(By.Id("md_1"));
            mon_day_14_Khang.Click();

            IWebElement lop_14_Khang_2 = driver_14_Khang.FindElement(By.Id("ld_9"));
            lop_14_Khang_2.Click();

            IWebElement khu_vuc_day_14_Khang = driver_14_Khang.FindElement(By.CssSelector("input[name='khuvuc[]'][value='10108']"));
            khu_vuc_day_14_Khang.Click();

            IWebElement thoi_gian_14_Khang_2 = driver_14_Khang.FindElement(By.Id("tgd_10"));
            thoi_gian_14_Khang_2.Click();

            Thread.Sleep(5000);//trì hoãn 5s
        }

        private void Lop_Moi_Can_Gia_Su() {

            IWebElement ma_lop_14_Khang = driver_14_Khang.FindElement(By.Name("keyword"));
            ma_lop_14_Khang.SendKeys("1");

            IWebElement hinh_thuc_14_Khang = driver_14_Khang.FindElement(By.Name("hinhthuc"));
            hinh_thuc_14_Khang.SendKeys("Hồ Chí Minh");

            IWebElement tinh_thanh_14_Khang = driver_14_Khang.FindElement(By.Name("tinhthanh"));
            tinh_thanh_14_Khang.SendKeys("Hồ Chí Minh");

            IWebElement quan_huyen_14_Khang = driver_14_Khang.FindElement(By.Name("quanhuyen"));
            quan_huyen_14_Khang.SendKeys("Quận 7");

            IWebElement trinh_do_14_Khang = driver_14_Khang.FindElement(By.Name("trinhdo"));
            trinh_do_14_Khang.SendKeys("Giáo viên");

            IWebElement gender_14_Khang = driver_14_Khang.FindElement(By.Name("gioitinh"));
            gender_14_Khang.SendKeys("Nữ gia sư");

            IWebElement cap_hoc_14_Khang = driver_14_Khang.FindElement(By.Name("caphoc"));
            cap_hoc_14_Khang.SendKeys("Gia sư cấp 2");

            IWebElement mon_14_Khang = driver_14_Khang.FindElement(By.Name("monhoc"));
            mon_14_Khang.SendKeys("Toán");

            IWebElement lop_14_Khang = driver_14_Khang.FindElement(By.Name("lophoc"));
            lop_14_Khang.SendKeys("Lớp 6");

            Thread.Sleep(3000);//trì hoãn 3s

            IWebElement search_14_Khang = driver_14_Khang.FindElement(By.ClassName("btn_s2"));
            search_14_Khang.Click();

            Thread.Sleep(5000);//trì hoãn 5s
        }
    }
}

