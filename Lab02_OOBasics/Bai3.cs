using System;

namespace Lab02_OOPBasics
{
    public partial class SinhVien
    {
        
        public void SetHoTen(string hoTen)
        {
            if (string.IsNullOrWhiteSpace(hoTen))
                throw new ArgumentException("Họ tên không được rỗng.");
            HoTen = hoTen.Trim();
        }
        
        public void SetDiemTB(double diemTB)
        {
            if (diemTB < 0 || diemTB > 10)
                throw new ArgumentOutOfRangeException(nameof(diemTB), "Điểm TB phải nằm trong khoảng [0, 10].");
            DiemTB = diemTB;
        }
    }
}