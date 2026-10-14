========================================================================
             BÁO CÁO BÀI THỰC HÀNH LAB 02: LỚP VÀ ĐỐI TƯỢNG 
               HỌC PHẦN: LẬP TRÌNH .NET (IT3212) 
========================================================================

1. THÔNG TIN SINH VIÊN
   - Họ và tên: Nguyễn Thiện Chiến
   - Mã sinh viên: 24000474
   - Lớp: Lập trình .NET-1-1-26(N03)
   - Học phần: Lập trình .NET (IT3212)
   - Bộ môn: Công nghệ Phần mềm - Khoa CNTT

2. TIẾN ĐỘ VÀ PHẦN ĐÃ HOÀN THÀNH
   Chương trình đã hoàn thành từ Bài 1 đến Bài 6 trong tài liệu Lab 02:
   [x] Bài 1: Khai báo lớp SinhVien (MaSV, HoTen, NgaySinh, DiemTB, HienThi).
   [x] Bài 2: Constructor không tham số và Constructor đầy đủ tham số cho SinhVien.
   [x] Bài 3: Đóng gói (Encapsulation), kiểm tra dữ liệu HoTen rỗng và DiemTB [0, 10].
   [x] Bài 4: Cài đặt phương thức nghiệp vụ TinhTuoi() và XepLoai() cho SinhVien.
   [x] Bài 5: Quản lý danh sách List<SinhVien>, tự nhập danh sách từ bàn phím, in danh sách dạng bảng và tìm kiếm theo mã.
   [x] Bài 6: Lớp SanPham (MaSP, TenSP, DonGia, SoLuong), tự nhập nhiều sản phẩm từ bàn phím, tính thành tiền và tính tổng tiền tất cả sản phẩm.

3. DỮ LIỆU THỬ NHIỆM VÀ KẾT QUẢ TỪNG BÀI (TEST DATA & OUTPUT)
--- BÀI 1: KHAI BÁO LỚP SINH VIÊN CƠ BẢN ---
* Input:
  - Mã SV: SV01
  - Họ tên: Nguyễn Thiện Chiến
  - Ngày sinh: 27/09/2006
  - Điểm TB: 8
* Output:
  SV01 - Nguyễn Thiện Chiến - 27/09/2006 - 8

--- BÀI 2: CONSTRUCTOR VÀ NẠP CHỒNG CONSTRUCTOR ---
* Input:
  - Test 1 (Default Constructor): (Không nhập)
  - Test 2 (Parameterized Constructor): SV02, Nguyễn Văn A, 02/09/2006, 7
* Output:
  1. Sinh viên mặc định: Chưa có - Chưa có - 14/10/2026 - 0.00
  2. Sinh viên có tham số: SV02 - Nguyễn Văn A - 02/09/2006 - 7

--- BÀI 3: ĐÓNG GÓI VÀ KIỂM TRA DỮ LIỆU (VALIDATION) ---
* Input lỗi:
  - Họ tên rỗng: ""
  - Điểm TB ngoài [0, 10]: 12
* Input hợp lệ:
  - Họ tên: Dương Ngọc Quỳnh | Ngày sinh: 20/11/2004 | Điểm TB: 9
* Output:
  1. Thử nghiệm gán Họ tên rỗng:
     [Bắt lỗi thành công]: Họ tên không được rỗng.
  2. Thử nghiệm gán Điểm TB = 12:
     [Bắt lỗi thành công]: Điểm TB phải nằm trong khoảng [0, 10].
  3. Nhập dữ liệu hợp lệ:
     SV03 - Dương Ngọc Quỳnh - 20/11/2004 - 9

--- BÀI 4: TÍNH TUỔI VÀ XẾP LOẠI HỌC LỰC ---
* Input:
  - Mã SV: SV04 | Họ tên: Phạm Văn Bách | Ngày sinh: 20/11/2005 | Điểm TB: 5
* Output:
  === THÔNG TIN BÀI 1 ===
  SV04 - Phạm Văn Bách - 20/11/2005 - 8.20
  === NGHIỆP VỤ BÀI 4 ===
  -> Tuổi: 20 tuổi
  -> Xếp loại học lực: Trung Bình 

--- BÀI 5: QUẢN LÝ DANH SÁCH LIST<SINHVIEN> & TÌM KIẾM ---
* Input:
  - Số lượng SV: 2
  - SV1: SV01 | Nguyễn Thiện Chiến  | 27/09/2006 | 8
  - SV2: SV02 | Nguyễn Văn A        | 02/09/2005 | 7
  - Mã cần tìm: SV01
* Output:
  ==========================================================================
                         DANH SÁCH SINH VIÊN ĐÃ NHẬP                        
  ==========================================================================
  Mã SV      | Họ và Tên            | Ngày sinh    | Tuổi   | ĐTB    | Xếp loại  
  --------------------------------------------------------------------------
  SV01       | Nguyễn Thiện Chiến   | 12/05/2006   | 20     | 8     | Giỏi      
  SV02       | Nguyễn Văn A         | 03/09/2005   | 21     | 7     | Khá       
  ==========================================================================
  --- KẾT QUẢ TÌM KIẾM ---
  Tìm thấy: SV01 - Nguyễn Thiện Chiến  - ĐTB: 8 - Loại: Giỏi

--- BÀI 6: LỚP SANPHAM & QUẢN LÝ NHIỀU SẢN PHẨM ---
* Input:
  - Số lượng SP: 2
  - SP1: SP01 | Sữa   | Đơn giá: 15000 | Số lượng: 2
  - SP2: SP02 | Bánh  | Đơn giá: 35000 | Số lượng: 5
* Output:
  ========================================================================
                          DANH SÁCH SẢN PHẨM ĐÃ NHẬP                         
  ========================================================================
  Mã SP      | Tên Sản Phẩm         | Đơn giá          | Số lượng | Thành tiền         
  ------------------------------------------------------------------------
  SP01       | Sữa          |    15,000 VNĐ | 2        |     30,000 VNĐ
  SP02       | Bánh         |    35,000 VNĐ | 5        |     175,000VNĐ
  ========================================================================
  -> TỔNG CỘNG TIỀN TẤT CẢ SẢN PHẨM:           205,000 VNĐ
  ========================================================================

========================================================================