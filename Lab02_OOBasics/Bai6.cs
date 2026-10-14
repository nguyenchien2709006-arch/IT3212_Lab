using System;
using System.Collections.Generic;

namespace Lab02_OOPBasics
{
    public class SanPham
    {
        private string _tenSP;
        private double _donGia;
        private int _soLuong;

        public string MaSP { get; set; }

        public string TenSP
        {
            get => _tenSP;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên sản phẩm không được rỗng.");
                _tenSP = value.Trim();
            }
        }

        public double DonGia
        {
            get => _donGia;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Đơn giá phải >= 0.");
                _donGia = value;
            }
        }

        public int SoLuong
        {
            get => _soLuong;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Số lượng phải >= 0.");
                _soLuong = value;
            }
        }

        public SanPham() { }

        public SanPham(string maSP, string tenSP, double donGia, int soLuong)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public double TinhThanhTien() => DonGia * SoLuong;

        public void HienThi()
        {
            Console.WriteLine($"{MaSP,-10} | {TenSP,-20} | {DonGia,12:N0} VNĐ | {SoLuong,-8} | {TinhThanhTien(),15:N0} VNĐ");
        }
    }

    public class Bai06_QuanLySanPham
    {
        public static void ThucHanh()
        {
            Console.WriteLine("=== BÀI 6: TỰ NHẬP VÀ QUẢN LÝ DANH SÁCH SẢN PHẨM ===");

            List<SanPham> dsSanPham = new List<SanPham>();

            try
            {
 
                int n;
                while (true)
                {
                    Console.Write("Nhập số lượng sản phẩm muốn thêm: ");
                    if (int.TryParse(Console.ReadLine(), out n) && n > 0) break;
                    Console.WriteLine("  -> Số lượng phải là số nguyên dương (> 0)! Vui lòng nhập lại.");
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Nhập sản phẩm thứ {i + 1} ---");

                    Console.Write("Mã SP: ");
                    string ma = Console.ReadLine();

                    Console.Write("Tên SP: ");
                    string ten = Console.ReadLine();

                    double gia;
                    while (true)
                    {
                        Console.Write("Đơn giá: ");
                        if (double.TryParse(Console.ReadLine(), out gia) && gia >= 0) break;
                        Console.WriteLine("  -> Đơn giá phải là số không âm (>= 0)!");
                    }

                    int sl;
                    while (true)
                    {
                        Console.Write("Số lượng: ");
                        if (int.TryParse(Console.ReadLine(), out sl) && sl >= 0) break;
                        Console.WriteLine("  -> Số lượng phải là số nguyên không âm (>= 0)!");
                    }

                    dsSanPham.Add(new SanPham(ma, ten, gia, sl));
                }

                Console.WriteLine("\n==========================================================================");
                Console.WriteLine("                        DANH SÁCH SẢN PHẨM ĐÃ NHẬP                         ");
                Console.WriteLine("==========================================================================");
                Console.WriteLine($"{"Mã SP",-10} | {"Tên Sản Phẩm",-20} | {"Đơn giá",-16} | {"Số lượng",-8} | {"Thành tiền",-19}");
                Console.WriteLine("--------------------------------------------------------------------------");

                double tongTienTatCa = 0;
                foreach (SanPham sp in dsSanPham)
                {
                    sp.HienThi();
                    tongTienTatCa += sp.TinhThanhTien();
                }

                Console.WriteLine("==========================================================================");
                Console.WriteLine($"-> TỔNG CỘNG TIỀN TẤT CẢ SẢN PHẨM: {tongTienTatCa,20:N0} VNĐ");
                Console.WriteLine("==========================================================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi dữ liệu: " + ex.Message);
            }
        }
    }
}