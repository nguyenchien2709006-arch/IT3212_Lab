using System;
using System.Text;

namespace Lab02_OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================ MENU LAB 02 ================");
                Console.WriteLine("1. Bài 1: Khai báo lớp & Nhập SinhVien");
                Console.WriteLine("2. Bài 2: Khởi tạo bằng Constructor");
                Console.WriteLine("3. Bài 3: Đóng gói & Kiểm tra dữ liệu");
                Console.WriteLine("4. Bài 4: Phương thức TinhTuoi & XepLoai");
                Console.WriteLine("5. Bài 5: Quản lý danh sách List<SinhVien>");
                Console.WriteLine("6. Bài 6: Lớp SanPham & Tính thành tiền");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("=============================================");
                Console.Write("Mời bạn chọn (0-6): ");

                string chon = Console.ReadLine();
                Console.WriteLine("\n---------------------------------------------");

                switch (chon)
                {
                    case "1": ChayBai1(); break;
                    case "2": ChayBai2(); break;
                    case "3": ChayBai3(); break;
                    case "4": ChayBai4(); break;
                    case "5": Bai05_QuanLyDanhSach.ThucHanh(); break;
                    case "6": Bai06_QuanLySanPham.ThucHanh(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine("\nẤn phím bất kỳ để quay lại Menu...");
                Console.ReadKey();
            }
        }

        private static void ChayBai1()
        {
            Console.WriteLine("=== BÀI 1: NHẬP VÀ HIỂN THỊ SINH VIÊN ===");
            try
            {
                SinhVien sv = new SinhVien();
                Console.Write("Nhập mã SV: "); sv.MaSV = Console.ReadLine();
                Console.Write("Nhập họ tên: "); sv.HoTen = Console.ReadLine();
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): "); sv.NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Nhập điểm TB: "); sv.DiemTB = double.Parse(Console.ReadLine());

                Console.WriteLine("\n=== KẾT QUẢ IN RA  ===");
                sv.HienThi();
            }
            catch (Exception ex) { Console.WriteLine("Lỗi nhập dữ liệu: " + ex.Message); }
        }

        private static void ChayBai2()
        {
            Console.WriteLine("=== BÀI 2: KHỞI TẠO BẰNG CONSTRUCTOR ===");
            SinhVien svMacDinh = new SinhVien();
            Console.Write("Đối tượng mặc định: "); svMacDinh.HienThi();

            Console.WriteLine("\n--- NHẬP THÔNG TIN MỚI ---");
            try
            {
                Console.Write("Nhập mã SV: "); string ma = Console.ReadLine();
                Console.Write("Nhập họ tên: "); string ten = Console.ReadLine();
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): "); DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Nhập điểm TB: "); double diem = double.Parse(Console.ReadLine());

                SinhVien svMoi = new SinhVien(ma, ten, ngaySinh, diem);
                Console.WriteLine("\n=== KẾT QUẢ IN RA  ===");
                svMoi.HienThi();
            }
            catch (Exception ex) { Console.WriteLine("Lỗi nhập dữ liệu: " + ex.Message); }
        }

        private static void ChayBai3()
        {
            Console.WriteLine("=== BÀI 3: KIỂM TRA ĐÓNG GÓI VÀ BẮT LỖI DỮ LIỆU ===");
            SinhVien sv = new SinhVien();
            sv.MaSV = "SV03";

            Console.WriteLine("1. Thử nghiệm gán Họ tên rỗng:");
            try { sv.SetHoTen(""); } catch (Exception ex) { Console.WriteLine("   [Bắt lỗi thành công]: " + ex.Message); }

            Console.WriteLine("\n2. Thử nghiệm gán Điểm TB = 12:");
            try { sv.SetDiemTB(12); } catch (Exception ex) { Console.WriteLine("   [Bắt lỗi thành công]: " + ex.Message); }

            Console.WriteLine("\n3. Nhập dữ liệu hợp lệ:");
            try
            {
                Console.Write("Nhập họ tên hợp lệ: "); sv.SetHoTen(Console.ReadLine());
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): "); sv.NgaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Nhập điểm TB [0 - 10]: "); sv.SetDiemTB(double.Parse(Console.ReadLine()));

                Console.WriteLine("\n=== KẾT QUẢ ĐÃ KIỂM TRA HỢP LỆ  ===");
                sv.HienThi();
            }
            catch (Exception ex) { Console.WriteLine("   [Lỗi nhập liệu]: " + ex.Message); }
        }

        private static void ChayBai4()
        {
            Console.WriteLine("=== BÀI 4: TÍNH TUỔI VÀ XẾP LOẠI HỌC LỰC ===");
            try
            {
                Console.Write("Nhập mã SV: "); string ma = Console.ReadLine();
                Console.Write("Nhập họ tên: "); string ten = Console.ReadLine();
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): "); DateTime ns = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Nhập điểm TB: "); double diem = double.Parse(Console.ReadLine());

                SinhVien sv = new SinhVien(ma, ten, ns, diem);

                Console.WriteLine("\n=== THÔNG TIN BÀI 1 ===");
                sv.HienThi();

                Console.WriteLine("\n=== NGHIỆP VỤ BÀI 4 ===");
                Console.WriteLine($"-> Tuổi: {sv.TinhTuoi()} tuổi");
                Console.WriteLine($"-> Xếp loại học lực: {sv.XepLoai()}");
            }
            catch (Exception ex) { Console.WriteLine("Lỗi nhập dữ liệu: " + ex.Message); }
        }
    }
}