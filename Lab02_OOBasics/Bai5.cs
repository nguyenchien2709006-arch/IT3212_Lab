using System;
using System.Collections.Generic;

namespace Lab02_OOPBasics
{
    public class Bai05_QuanLyDanhSach
    {
        public static void ThucHanh()
        {
            Console.WriteLine("=== BÀI 5: TỰ NHẬP VÀ QUẢN LÝ DANH SÁCH SINH VIÊN ===");

            List<SinhVien> ds = new List<SinhVien>();

            try
            {
                Console.Write("Nhập số lượng sinh viên muốn thêm: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Nhập sinh viên thứ {i + 1} ---");

                    Console.Write("Mã SV: ");
                    string ma = Console.ReadLine();

                    Console.Write("Họ tên: ");
                    string ten = Console.ReadLine();

                    DateTime ns;
                    string[] formats = { "d/M/yyyy", "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy" };
                    while (true)
                    {
                        Console.Write("Ngày sinh (dd/MM/yyyy): ");
                        string inputNS = Console.ReadLine();
                        if (DateTime.TryParseExact(inputNS, formats, null, System.Globalization.DateTimeStyles.None, out ns))
                        {
                            break;
                        }
                        Console.WriteLine("  -> Ngày sinh không hợp lệ! Vui lòng nhập lại (Ví dụ: 02/09/2009).");
                    }

                    double diem;
                    while (true)
                    {
                        Console.Write("Điểm TB (0 - 10): ");
                        if (double.TryParse(Console.ReadLine(), out diem) && diem >= 0 && diem <= 10)
                        {
                            break;
                        }
                        Console.WriteLine("  -> Điểm TB phải là số trong khoảng [0, 10]!");
                    }

                    ds.Add(new SinhVien(ma, ten, ns, diem));
                }

                // =========================================================
                // PHẦN HIỂN THỊ DANH SÁCH SINH VIÊN ĐÃ NHẬP
                // =========================================================
                Console.WriteLine("\n==========================================================================");
                Console.WriteLine("                       DANH SÁCH SINH VIÊN ĐÃ NHẬP                        ");
                Console.WriteLine("==========================================================================");
                Console.WriteLine($"{"Mã SV",-10} | {"Họ và Tên",-20} | {"Ngày sinh",-12} | {"Tuổi",-6} | {"ĐTB",-6} | {"Xếp loại",-10}");
                Console.WriteLine("--------------------------------------------------------------------------");

                if (ds.Count == 0)
                {
                    Console.WriteLine("Chưa có sinh viên nào trong danh sách.");
                }
                else
                {
                    foreach (SinhVien sv in ds)
                    {
                        Console.WriteLine($"{sv.MaSV,-10} | {sv.HoTen,-20} | {sv.NgaySinh:dd/MM/yyyy}   | {sv.TinhTuoi(),-6} | {sv.DiemTB,-6:N2} | {sv.XepLoai(),-10}");
                    }
                }
                Console.WriteLine("==========================================================================");

                if (ds.Count > 0)
                {
                    Console.Write("\nNhập mã SV cần tìm: ");
                    string maTim = Console.ReadLine();

                    SinhVien ketQua = ds.Find(x => x.MaSV.Equals(maTim, StringComparison.OrdinalIgnoreCase));

                    Console.WriteLine("\n--- KẾT QUẢ TÌM KIẾM ---");
                    if (ketQua == null)
                    {
                        Console.WriteLine("Không tìm thấy sinh viên có mã: " + maTim);
                    }
                    else
                    {
                        Console.WriteLine($"Tìm thấy: {ketQua.MaSV} - {ketQua.HoTen} - ĐTB: {ketQua.DiemTB} - Loại: {ketQua.XepLoai()}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi nhập dữ liệu: " + ex.Message);
            }
        }
    }
}