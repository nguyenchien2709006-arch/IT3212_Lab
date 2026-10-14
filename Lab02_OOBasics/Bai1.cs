using System;

namespace Lab02_OOPBasics
{
    public partial class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public double DiemTB { get; set; }

        public void HienThi()
        {
            Console.WriteLine($"{MaSV} - {HoTen} - {NgaySinh:dd/MM/yyyy} - {DiemTB:N2}");
        }
    }
}