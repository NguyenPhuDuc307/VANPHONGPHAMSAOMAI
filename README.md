# HỆ THỐNG QUẢN LÝ VĂN PHÒNG PHẨM SAO MAI

## Giới thiệu

Hệ thống quản lý văn phòng phẩm Sao Mai là phần mềm quản lý bán hàng và kho hàng cho cửa hàng văn phòng phẩm. Phần mềm được xây dựng bằng C# với kiến trúc 3 lớp (3-tier architecture), sử dụng Windows Forms và DevExpress cho giao diện người dùng.

## Tính năng chính

### 1. Quản lý danh mục
- **Quản lý loại mặt hàng**: Thêm, sửa, xóa các loại văn phòng phẩm (Bảng, Bìa, Bút, Giấy, Keo, Máy tính, Phấn, Thước...)
- **Quản lý mặt hàng**: Quản lý thông tin chi tiết sản phẩm (mã, tên, giá bán, đơn vị tính, mô tả)
- **Quản lý khách hàng**: Lưu trữ thông tin khách hàng (tên, giới tính, số điện thoại)
- **Quản lý nhà cung cấp**: Quản lý thông tin nhà cung cấp (tên, địa chỉ, số điện thoại, email)
- **Quản lý nhân viên**: Quản lý thông tin nhân viên và phân quyền

### 2. Nghiệp vụ bán hàng
- **Bán hàng**: Tạo hóa đơn bán hàng cho khách hàng
- **Đặt hàng**: Tạo đơn đặt hàng từ nhà cung cấp
- **In hóa đơn**: Xuất hóa đơn và đơn đặt hàng dạng Crystal Reports

### 3. Thống kê và báo cáo
- **Thống kê doanh thu**: Biểu đồ doanh thu theo ngày (7 ngày gần nhất)
- **Thống kê bán hàng**: Top 5 mặt hàng bán chạy nhất trong ngày
- **Thống kê khách hàng**: Top 5 khách hàng mua nhiều nhất trong tháng
- **Thống kê mặt hàng**: Số lượng mặt hàng theo từng loại

### 4. Quản lý người dùng
- **Đăng nhập/Đăng ký**: Xác thực người dùng
- **Phân quyền**: Quản lý (Manager) và Nhân viên (Staff)
- **Đổi mật khẩu**: Cho phép người dùng thay đổi mật khẩu
- **Quên mật khẩu**: Khôi phục mật khẩu qua thông tin xác thực

## Kiến trúc hệ thống

### Kiến trúc 3 lớp (3-Tier Architecture)

```
┌─────────────────────────────────────┐
│   Presentation Layer (UI)           │
│   - Windows Forms                   │
│   - DevExpress Controls             │
│   - Crystal Reports                 │
└─────────────────────────────────────┘
              ↓
┌─────────────────────────────────────┐
│   Business Logic Layer              │
│   - KHACHHANG.cs                    │
│   - MATHANG.cs                      │
│   - HOADON.cs                       │
│   - DONDATHANG.cs                   │
│   - NHANVIEN.cs                     │
│   - NHACUNGCAP.cs                   │
│   - THONGKE.cs                      │
└─────────────────────────────────────┘
              ↓
┌─────────────────────────────────────┐
│   Data Access Layer                 │
│   - Entity Framework                │
│   - Database Context                │
│   - Entities                        │
└─────────────────────────────────────┘
              ↓
┌─────────────────────────────────────┐
│   Database (SQL Server)             │
│   - VANPHONGPHAM                    │
└─────────────────────────────────────┘
```

### Cấu trúc thư mục

```
VANPHONGPHAM/
├── DataLayer/              # Lớp truy cập dữ liệu
│   ├── Entities.cs         # Entity Framework Context
│   ├── connect.cs          # Quản lý kết nối
│   ├── Encryptor.cs        # Mã hóa dữ liệu
│   └── [Entity Models]     # Các model tương ứng với bảng
├── BusinessLayer/          # Lớp nghiệp vụ
│   ├── KHACHHANG.cs
│   ├── MATHANG.cs
│   ├── HOADON.cs
│   ├── DONDATHANG.cs
│   ├── NHANVIEN.cs
│   ├── NHACUNGCAP.cs
│   └── THONGKE.cs
├── VANPHONGPHAM/          # Lớp giao diện
│   ├── frmMain.cs         # Form chính
│   ├── frmDangNhap.cs     # Form đăng nhập
│   ├── frmBanHang.cs      # Form bán hàng
│   ├── frmDatHang.cs      # Form đặt hàng
│   └── [Other Forms]      # Các form khác
├── Reports/               # Crystal Reports
│   ├── ReportBH.rpt       # Báo cáo bán hàng
│   ├── ReportDDH.rpt      # Báo cáo đơn đặt hàng
│   ├── ReportHD.rpt       # Báo cáo hóa đơn
│   └── [Other Reports]
├── Documents/             # Tài liệu hướng dẫn
└── scriptVPPv11.sql      # Script tạo database
```

## Cơ sở dữ liệu

### Sơ đồ quan hệ chính

- **NHAN_VIEN**: Thông tin nhân viên và tài khoản
- **KHACH_HANG**: Thông tin khách hàng
- **NHA_CUNG_CAP**: Thông tin nhà cung cấp
- **LOAI_MAT_HANG**: Danh mục loại mặt hàng
- **MAT_HANG**: Thông tin chi tiết mặt hàng
- **HOA_DON**: Hóa đơn bán hàng
- **HOADON_MATHANG**: Chi tiết hóa đơn
- **DON_DAT_HANG**: Đơn đặt hàng từ nhà cung cấp
- **DONDATHANG_MATHANG**: Chi tiết đơn đặt hàng

### Stored Procedures & Functions

- `BANHANG`: Lấy dữ liệu bán hàng theo khoảng thời gian
- `DONDATHANG`: Lấy dữ liệu đơn đặt hàng theo khoảng thời gian
- `HOADON`: Lấy dữ liệu hóa đơn theo ngày
- `FNTHONGKEDOANHTHU`: Thống kê doanh thu 7 ngày gần nhất
- `FNBANHANGByTIMEGROUPMH`: Top 5 mặt hàng bán chạy
- `FNKHACHHANGGROUP`: Top 6 khách hàng mua nhiều nhất

## Yêu cầu hệ thống

### Phần mềm
- Windows 7 trở lên
- .NET Framework 4.5 hoặc cao hơn
- SQL Server 2012 trở lên
- Visual Studio 2019 hoặc cao hơn (để phát triển)

### Thư viện
- Entity Framework 6.x
- DevExpress WinForms
- Crystal Reports for .NET

## Cài đặt

### 1. Cài đặt Database

```sql
-- Chạy file scriptVPPv11.sql trong SQL Server Management Studio
-- File này sẽ tạo database VANPHONGPHAM và dữ liệu mẫu
```

### 2. Cấu hình kết nối

Khi chạy lần đầu, phần mềm sẽ yêu cầu cấu hình kết nối database:
- Server name: Tên SQL Server instance
- Database: VANPHONGPHAM
- Username: Tên đăng nhập SQL Server
- Password: Mật khẩu

Thông tin kết nối sẽ được mã hóa và lưu trong file `connectdb.dba`.

### 3. Đăng nhập

Tài khoản mặc định:
- **Username**: admin
- **Password**: admin12345

Các tài khoản khác:
- nguyentu / nguyentu
- camthuy / camthuy
- thanhthao / thanhthao
- duchau / duchau
- vandat / vandat00

## Hướng dẫn sử dụng

### Đăng nhập
1. Khởi động ứng dụng
2. Nhập tên đăng nhập và mật khẩu
3. Nhấn "Đăng nhập"

### Bán hàng
1. Từ màn hình chính, chọn "Bán hàng"
2. Chọn khách hàng (hoặc tạo mới)
3. Thêm mặt hàng vào giỏ
4. Nhập số lượng
5. Xác nhận và in hóa đơn

### Đặt hàng
1. Từ màn hình chính, chọn "Đặt hàng"
2. Chọn nhà cung cấp
3. Thêm mặt hàng cần đặt
4. Nhập số lượng và đơn giá
5. Xác nhận đơn đặt hàng

### Xem thống kê
- Dashboard trên màn hình chính hiển thị:
  - Biểu đồ doanh thu 7 ngày
  - Top 5 mặt hàng bán chạy
  - Top 5 khách hàng VIP

## Phân quyền

### Quản lý (Manager)
- Toàn quyền truy cập tất cả chức năng
- Quản lý nhân viên
- Phân quyền người dùng
- Đặt hàng từ nhà cung cấp
- Xem tất cả báo cáo

### Nhân viên (Staff)
- Bán hàng
- Quản lý khách hàng
- Quản lý mặt hàng
- Xem thống kê cơ bản

## Tính năng bảo mật

- Mã hóa mật khẩu kết nối database
- Xác thực người dùng
- Phân quyền theo vai trò
- Vô hiệu hóa tài khoản thay vì xóa

## Đội ngũ phát triển

**Nhóm 1:**
- Nguyễn Phú Đức
- Nguyễn Tứ
- Lê Cẩm Thúy
- Trần Thanh Thảo

## Hỗ trợ

Để được hỗ trợ, vui lòng liên hệ:
- **Điện thoại**: 0964732241
- **Email**: vanphongpham1911@gmail.com

## Phiên bản

**Van Phong Pham Sao Mai v1.0**

## License

Copyright © 2022 Nhóm 1. All rights reserved.
