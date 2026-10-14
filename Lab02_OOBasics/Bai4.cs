using System;

namespace Lab02_OOPBasics
{
    public partial class SinhVien
    {
      
        public int TinhTuoi()
        {
            int tuoi = DateTime.Today.Year - NgaySinh.Year;
            if (NgaySinh.Date > DateTime.Today.AddYears(-tuoi)) tuoi--;
            return tuoi;
        }

        public string XepLoai()
        {
            if (DiemTB >= 9.0) return "Xuất sắc";
            if (DiemTB >= 8.0) return "Giỏi";
            if (DiemTB >= 6.5) return "Khá";
            if (DiemTB >= 5.0) return "Trung bình";
            return "Yếu";
        }
    }
}