CREATE TABLE TaiKhoan (
    MaTaiKhoan INT PRIMARY KEY IDENTITY,
    TenDangNhap NVARCHAR(50) UNIQUE,
    MatKhau NVARCHAR(100),
    VaiTro NVARCHAR(20) -- Admin / NhanVien
);
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY IDENTITY,
    TenNhanVien NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
    ChucVu NVARCHAR(50),
    LuongCoBan FLOAT
);
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY,
    TenKhachHang NVARCHAR(100),
    SoDienThoai NVARCHAR(15),
    DiemTichLuy INT DEFAULT 0
);
CREATE TABLE Phong (
    MaPhong INT PRIMARY KEY IDENTITY,
    TenPhong NVARCHAR(50),
    TrangThai NVARCHAR(20) -- Trong / DangSuDung / BaoTri
);
CREATE TABLE DichVu (
    MaDichVu INT PRIMARY KEY IDENTITY,
    TenDichVu NVARCHAR(100),
    Gia FLOAT
);
CREATE TABLE LichDat (
    MaLich INT PRIMARY KEY IDENTITY,
    MaKhachHang INT,
    MaNhanVien INT,
    MaPhong INT,
    MaDichVu INT,
    ThoiGian DATETIME,
    TrangThai NVARCHAR(20), -- Cho / DaLam / Huy

    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu)
);
CREATE TABLE DanhMuc (
    MaDanhMuc INT PRIMARY KEY IDENTITY,
    TenDanhMuc NVARCHAR(100)
);
CREATE TABLE SanPham (
    MaSanPham INT PRIMARY KEY IDENTITY,
    TenSanPham NVARCHAR(100),
    MaDanhMuc INT,
    GiaNhap FLOAT,
    GiaBan FLOAT,

    FOREIGN KEY (MaDanhMuc) REFERENCES DanhMuc(MaDanhMuc)
);
CREATE TABLE NhaCungCap (
    MaNCC INT PRIMARY KEY IDENTITY,
    TenNCC NVARCHAR(100),
    SoDienThoai NVARCHAR(15)
);
CREATE TABLE NhapHang (
    MaNhap INT PRIMARY KEY IDENTITY,
    MaNCC INT,
    NgayNhap DATETIME,

    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);
CREATE TABLE ChiTietNhap (
    MaNhap INT,
    MaSanPham INT,
    SoLuong INT,
    GiaNhap FLOAT,

    PRIMARY KEY (MaNhap, MaSanPham),
    FOREIGN KEY (MaNhap) REFERENCES NhapHang(MaNhap),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
CREATE TABLE TonKho (
    MaSanPham INT PRIMARY KEY,
    SoLuong INT,

    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY IDENTITY,
    MaKhachHang INT,
    MaNhanVien INT,
    NgayLap DATETIME,
    TongTien FLOAT,

    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
CREATE TABLE ChiTietHoaDon (
    MaHoaDon INT,
    MaSanPham INT,
    SoLuong INT,
    Gia FLOAT,

    PRIMARY KEY (MaHoaDon, MaSanPham),
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);
CREATE TABLE TraHang (
    MaTraHang INT PRIMARY KEY IDENTITY,
    MaHoaDon INT,
    NgayTra DATETIME,

    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon)
);
CREATE TABLE ChiTietTraHang (
    MaTraHang INT,
    MaSanPham INT,
    SoLuong INT,

    PRIMARY KEY (MaTraHang, MaSanPham)
);
CREATE TABLE TraNCC (
    MaTraNCC INT PRIMARY KEY IDENTITY,
    MaNhap INT,
    NgayTra DATETIME,

    FOREIGN KEY (MaNhap) REFERENCES NhapHang(MaNhap)
);
CREATE TABLE ChiTietTraNCC (
    MaTraNCC INT,
    MaSanPham INT,
    SoLuong INT,

    PRIMARY KEY (MaTraNCC, MaSanPham)
);
CREATE TABLE SoQuy (
    MaGiaoDich INT PRIMARY KEY IDENTITY,
    Loai NVARCHAR(20), -- Thu / Chi
    SoTien FLOAT,
    MoTa NVARCHAR(255),
    Ngay DATETIME
);
CREATE TABLE ChamCong (
    MaChamCong INT PRIMARY KEY IDENTITY,
    MaNhanVien INT,
    Ngay DATE,
    GioVao TIME,
    GioRa TIME,

    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
CREATE TABLE BangLuong (
    MaLuong INT PRIMARY KEY IDENTITY,
    MaNhanVien INT,
    Thang INT,
    Nam INT,
    Luong FLOAT,

    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);
select* from SoQuy

--xoá bảng thừa
DROP TABLE ChiTietTraHang;
DROP TABLE TraHang;

DROP TABLE ChiTietTraNCC;
DROP TABLE TraNCC;

ALTER TABLE SoQuy
ADD LoaiLienKet NVARCHAR(50),
    MaLienKet INT;

ALTER TABLE TaiKhoan
ADD MaNhanVien INT;

ALTER TABLE TaiKhoan
ADD FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien);

ALTER TABLE SoQuy
ADD CONSTRAINT CHK_Loai
CHECK (Loai IN (N'Thu', N'Chi'));

ALTER TABLE Phong
ADD CONSTRAINT CHK_TrangThaiPhong
CHECK (TrangThai IN (N'Trong', N'DangSuDung', N'BaoTri'))

-----

CREATE TABLE UuDaiKhachHang (
    MaUuDai INT PRIMARY KEY IDENTITY,
    DiemToiThieu INT,
    TenMuc NVARCHAR(50),
    PhanTramGiam FLOAT
);


INSERT INTO UuDaiKhachHang
VALUES
(500, N'VIP', 15);

delete from UuDaiKhachHang
SELECT * FROM UuDaiKhachHang
select * from SanPhamUuDai
CREATE TABLE SanPhamUuDai (
    MaSanPham INT,
    MaUuDai INT,

    PRIMARY KEY (MaSanPham, MaUuDai),

    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham),
    FOREIGN KEY (MaUuDai) REFERENCES UuDaiKhachHang(MaUuDai)
);

INSERT INTO SanPhamUuDai (MaSanPham, MaUuDai)
VALUES
(1, 1),
(2, 1),
(3, 1);
DBCC CHECKIDENT ('UuDaiKhachHang', RESEED, 0)


delete from SanPhamUuDai
-----
CREATE TRIGGER trg_KiemTraTonKho
ON ChiTietHoaDon
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN TonKho t ON i.MaSanPham = t.MaSanPham
        WHERE i.SoLuong > t.SoLuong
    )
    BEGIN
        RAISERROR (N'Không đủ tồn kho để bán!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END
GO
-----

--thu tuc dang nhap
CREATE PROCEDURE sp_DangNhap
    @TenDangNhap NVARCHAR(50),
    @MatKhau NVARCHAR(50)
AS
BEGIN
    DECLARE @VaiTro NVARCHAR(20)

    SELECT @VaiTro = VaiTro
    FROM TaiKhoan
    WHERE TenDangNhap = @TenDangNhap
      AND MatKhau = @MatKhau

    -- Nếu không tồn tại → trả NULL
    SELECT @VaiTro AS VaiTro
END

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro)
VALUES 
(N'admin', N'123', N'Admin'),
(N'nv01', N'123', N'NhanVien');
ALTER TABLE LichDat
ADD ThoiGianKetThuc DATETIME;
select * from TaiKhoan

--xoá dl bảng
-- BẢNG PHỤ (xóa trước)
DELETE FROM ChiTietTraNCC;
DELETE FROM ChiTietTraHang;
DELETE FROM ChiTietHoaDon;
DELETE FROM ChiTietNhap;

-- BẢNG LIÊN QUAN
DELETE FROM TraNCC;
DELETE FROM TraHang;
DELETE FROM HoaDon;
DELETE FROM NhapHang;
DELETE FROM LichDat;

-- BẢNG PHỤ KHÁC
DELETE FROM TonKho;
DELETE FROM SoQuy;
DELETE FROM ChamCong;
DELETE FROM BangLuong;

-- BẢNG CHÍNH
DELETE FROM SanPham;
DELETE FROM DanhMuc;
DELETE FROM NhaCungCap;
DELETE FROM KhachHang;
DELETE FROM TaiKhoan;
DELETE FROM NhanVien;
DELETE FROM Phong;
DELETE FROM DichVu;
--DỮ LIỆU DEMO
------------------ NHÂN VIÊN ------------------
INSERT INTO NhanVien (TenNhanVien, SoDienThoai, ChucVu, LuongCoBan)
VALUES 
(N'Nguyễn Văn Huy', '0912345678', N'Quản lý', 12000000),
(N'Trần Thị Lan', '0987654321', N'Kỹ thuật viên', 8000000),
(N'Lê Minh Tuấn', '0978123456', N'Lễ tân', 6500000),
(N'Phạm Ngọc Anh', '0966666666', N'Kỹ thuật viên', 7500000);

------------------ TÀI KHOẢN ------------------
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, VaiTro, MaNhanVien)
VALUES 
(N'admin', N'123', N'Admin', 1),
(N'nv01', N'123', N'NhanVien', 2),
(N'nv02', N'123', N'NhanVien', 3),
(N'nv03', N'123', N'NhanVien', 4);

------------------ KHÁCH HÀNG ------------------
INSERT INTO KhachHang (TenKhachHang, SoDienThoai, DiemTichLuy)
VALUES
(N'Nguyễn Thu Hà', '0901111111', 200),
(N'Trần Quỳnh Mai', '0902222222', 150),
(N'Phạm Đức Long', '0903333333', 50),
(N'Hoàng Minh Khang', '0904444444', 0);

------------------ PHÒNG ------------------
INSERT INTO Phong (TenPhong, TrangThai)
VALUES
(N'Phòng VIP 1', N'Trong'),
(N'Phòng VIP 2', N'Trong'),
(N'Phòng Thường 1', N'DangSuDung'),
(N'Phòng Thường 2', N'BaoTri');

------------------ DỊCH VỤ ------------------
INSERT INTO DichVu (TenDichVu, Gia)
VALUES
(N'Massage body đá nóng', 600000),
(N'Chăm sóc da chuyên sâu', 800000),
(N'Gội đầu dưỡng sinh', 250000),
(N'Tắm trắng body', 1200000);

------------------ DANH MỤC ------------------
INSERT INTO DanhMuc (TenDanhMuc)
VALUES
(N'Mỹ phẩm chăm sóc da'),
(N'Thiết bị spa'),
(N'Thực phẩm chức năng'),
(N'Gói trị liệu da mặt'),
(N'Gói trị liệu body'),
(N'Massage & thư giãn'),
(N'Chăm sóc tóc');

------------------ NHÀ CUNG CẤP ------------------
INSERT INTO NhaCungCap (TenNCC, SoDienThoai)
VALUES
(N'Công ty TNHH L’Oréal Việt Nam', '02838211111'),
(N'Công ty TNHH Shiseido Việt Nam', '02839300000'),
(N'Công ty TNHH Unilever Việt Nam', '02838224444'),
(N'Công ty Thiết bị Spa Minh Tâm', '0901234567');

------------------ SẢN PHẨM ------------------
INSERT INTO SanPham (TenSanPham, MaDanhMuc, GiaNhap, GiaBan)
VALUES
(N'Sữa rửa mặt La Roche-Posay', 1, 180000, 250000),
(N'Toner Hada Labo', 1, 150000, 220000),
(N'Máy xông hơi mặt', 2, 700000, 950000),
(N'Máy massage nâng cơ', 2, 1500000, 2000000),
(N'Viên uống Collagen DHC', 3, 250000, 350000),
(N'Gói trị mụn chuyên sâu', 4, 200000, 500000),
(N'Gói dưỡng trắng da', 4, 300000, 700000),
(N'Gói giảm béo bụng', 5, 800000, 1500000),
(N'Massage đá nóng', 6, 300000, 600000),
(N'Gội đầu dưỡng sinh', 7, 100000, 250000);

------------------ NHẬP HÀNG ------------------
INSERT INTO NhapHang (MaNCC, NgayNhap)
VALUES
(1, DATEADD(DAY, -5, GETDATE())),
(2, DATEADD(DAY, -3, GETDATE())),
(3, DATEADD(DAY, -2, GETDATE())),
(4, GETDATE());

------------------ CHI TIẾT NHẬP ------------------
INSERT INTO ChiTietNhap (MaNhap, MaSanPham, SoLuong, GiaNhap)
VALUES
(1, 1, 30, 180000),
(1, 2, 20, 150000),
(2, 3, 10, 700000),
(2, 4, 5, 1500000),
(3, 5, 40, 250000),
(4, 6, 15, 200000),
(4, 7, 10, 300000);

------------------ TỒN KHO ------------------
INSERT INTO TonKho (MaSanPham, SoLuong)
VALUES
(1, 30),(2, 20),(3, 10),(4, 5),(5, 40),
(6, 15),(7, 10),(8, 5),(9, 8),(10, 20);

DELETE FROM ChiTietHoaDon;
DELETE FROM HoaDon;
DELETE FROM LichDat;

DBCC CHECKIDENT ('HoaDon', RESEED, 0);
DBCC CHECKIDENT ('LichDat', RESEED, 0);
------------------ HÓA ĐƠN ------------------
INSERT INTO HoaDon (MaKhachHang, MaNhanVien, NgayLap, TongTien)
VALUES
(1, 2, '2026-04-22 10:00:00', 850000),
(2, 2, '2026-04-22 11:00:00', 1200000),
(3, 3, '2026-04-22 12:00:00', 600000);
------------------ CHI TIẾT HÓA ĐƠN ------------------
INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, SoLuong, Gia)
VALUES
(1, 6, 1, 500000),
(1, 1, 1, 350000),

(2, 8, 1, 1200000),

(3, 9, 1, 600000);
-------------------LỊCH ĐẶT------------------------
INSERT INTO LichDat 
(MaKhachHang, MaNhanVien, MaPhong, MaDichVu, ThoiGian, ThoiGianKetThuc, TrangThai)
VALUES
-- KHÁCH 1: 9h - 10h
(1, 2, 1, 1, '2026-04-22 09:00:00', '2026-04-22 10:00:00', N'DaLam'),

-- KHÁCH 2: 10h - 11h
(2, 2, 1, 2, '2026-04-22 10:00:00', '2026-04-22 11:00:00', N'DaLam'),

-- KHÁCH 3: 11h - 12h
(3, 3, 2, 3, '2026-04-22 11:00:00', '2026-04-22 12:00:00', N'DaLam'),

-- KHÁCH 1: quay lại 14h - 15h
(1, 4, 2, 1, '2026-04-22 14:00:00', '2026-04-22 15:00:00', N'Cho'),

-- KHÁCH 2: đang làm 15h - 16h
(2, 3, 1, 2, '2026-04-22 15:00:00', '2026-04-22 16:00:00', N'DangLam'),

-- NGÀY MAI
(3, 2, 2, 3, '2026-04-23 09:00:00', '2026-04-23 10:00:00', N'Cho');
select * from LichDat
select * from HoaDon
select * from SoQuy
------------------ SỔ QUỸ ------------------
/*INSERT INTO SoQuy (Loai, SoTien, MoTa, Ngay, LoaiLienKet, MaLienKet)
SELECT 
    N'Chi',
    SUM(CT.SoLuong * CT.GiaNhap),
    N'Nhập hàng #' + CAST(NH.MaNhap AS NVARCHAR),
    NH.NgayNhap,
    N'NhapHang',
    NH.MaNhap
FROM NhapHang NH
JOIN ChiTietNhap CT ON NH.MaNhap = CT.MaNhap
GROUP BY NH.MaNhap, NH.NgayNhap;

INSERT INTO SoQuy (Loai, SoTien, MoTa, Ngay, LoaiLienKet, MaLienKet)
SELECT 
    N'Thu',
    TongTien,
    N'Hóa đơn #' + CAST(MaHoaDon AS NVARCHAR),
    NgayLap,
    N'HoaDon',
    MaHoaDon
FROM HoaDon;*/

--triger tự tạo sổ quỹ khi bán hàng và nhập hàng
CREATE TRIGGER trg_HoaDon_ThemSoQuy
ON HoaDon
AFTER INSERT
AS
BEGIN
    INSERT INTO SoQuy (Loai, SoTien, MoTa, Ngay, LoaiLienKet, MaLienKet)
    SELECT 
        N'Thu',
        TongTien,
        N'Hóa đơn #' + CAST(MaHoaDon AS NVARCHAR),
        NgayLap,
        N'HoaDon',
        MaHoaDon
    FROM inserted
END
--
CREATE TRIGGER trg_NhapHang_ThemSoQuy
ON NhapHang
AFTER INSERT
AS
BEGIN
    INSERT INTO SoQuy (Loai, SoTien, MoTa, Ngay, LoaiLienKet, MaLienKet)
    SELECT 
        N'Chi',
        SUM(CT.SoLuong * CT.GiaNhap),
        N'Nhập hàng #' + CAST(i.MaNhap AS NVARCHAR),
        i.NgayNhap,
        N'NhapHang',
        i.MaNhap
    FROM inserted i
    JOIN ChiTietNhap CT ON i.MaNhap = CT.MaNhap
    GROUP BY i.MaNhap, i.NgayNhap
END

------------------ CHẤM CÔNG ------------------
INSERT INTO ChamCong (MaNhanVien, Ngay, GioVao, GioRa)
VALUES
(1, GETDATE(), '08:00', '17:00'),
(2, GETDATE(), '09:00', '18:00');

------------------ BẢNG LƯƠNG ------------------
INSERT INTO BangLuong (MaNhanVien, Thang, Nam, Luong)
VALUES
(1, 4, 2026, 12000000),
(2, 4, 2026, 8000000);

--CÁC THỦ TỤC CHỨC NĂNG TỔNG QUAN
--DOANH THU TRONG NGÀY
CREATE PROCEDURE sp_DoanhThuHomNay
AS
BEGIN
    DECLARE @Ngay DATE = CAST(GETDATE() AS DATE)

    SELECT ISNULL(SUM(TongTien), 0) AS DoanhThu
    FROM HoaDon
    WHERE NgayLap >= @Ngay
      AND NgayLap < DATEADD(DAY, 1, @Ngay)
END

exec sp_DoanhThuHomNay
--SỐ LƯỢNG KHÁCH HÀNG TRONG NGÀY
ALTER PROCEDURE sp_SoKhachTrongNgay
AS
BEGIN
    DECLARE @Ngay DATE = CAST(GETDATE() AS DATE)

    SELECT COUNT(DISTINCT MaKhachHang) AS SoLuongKhach
    FROM (
        -- Khách sắp tới + đang làm
        SELECT MaKhachHang
        FROM LichDat
        WHERE ThoiGian >= @Ngay
          AND ThoiGian < DATEADD(DAY, 1, @Ngay)
          AND TrangThai IN (N'Cho', N'DangLam')

        UNION

        -- Khách đã làm (có hóa đơn)
        SELECT MaKhachHang
        FROM HoaDon
        WHERE NgayLap >= @Ngay
          AND NgayLap < DATEADD(DAY, 1, @Ngay)
    ) AS T
END
exec sp_SoKhachTrongNgay
drop PROCEDURE sp_SoKhachTrongNgay
--KHÁCH ĐANG PHỤC VỤ
ALTER PROCEDURE sp_KhachDangPhucVu
AS
BEGIN
    DECLARE @Ngay DATE = CAST(GETDATE() AS DATE)

    SELECT COUNT(DISTINCT MaKhachHang) AS SoLuong
    FROM LichDat
    WHERE TrangThai = N'DangLam'
      AND ThoiGian >= @Ngay
      AND ThoiGian < DATEADD(DAY, 1, @Ngay)
END

EXEC sp_KhachDangPhucVu;

--KHÁCH SẮP ĐẾN
CREATE PROCEDURE sp_KhachSapDen
AS
BEGIN
    DECLARE @Ngay DATE = CAST(GETDATE() AS DATE)

    SELECT COUNT(DISTINCT MaKhachHang) AS SoLuong
    FROM LichDat
    WHERE TrangThai = N'Cho'
      AND ThoiGian >= @Ngay
      AND ThoiGian < DATEADD(DAY, 1, @Ngay)
END

EXEC sp_KhachSapDen;
--DOANH THU 7 NGÀY 
CREATE PROCEDURE sp_DoanhThu7Ngay
AS
BEGIN
    SELECT ISNULL(SUM(TongTien), 0) AS DoanhThu7Ngay
    FROM HoaDon
    WHERE NgayLap >= DATEADD(DAY, -7, GETDATE())
END

EXEC sp_DoanhThu7Ngay
--DOANH THU 30 NGÀY
CREATE PROCEDURE sp_DoanhThu30Ngay
AS
BEGIN
    SELECT ISNULL(SUM(TongTien), 0) AS DoanhThu30Ngay
    FROM HoaDon
    WHERE NgayLap >= DATEADD(DAY, -30, GETDATE())
END
--SO KHÁCH TRONG 7 NGÀY 
CREATE PROCEDURE sp_SoKhach7Ngay
AS
BEGIN
    SELECT COUNT(DISTINCT MaKhachHang) AS SoKhach7Ngay
    FROM HoaDon
    WHERE NgayLap >= DATEADD(DAY, -7, GETDATE())
END

exec sp_SoKhach7Ngay
--SỐ KHÁCH TRONG 30 NGÀY
CREATE PROCEDURE sp_SoKhach30Ngay
AS
BEGIN
    SELECT COUNT(DISTINCT MaKhachHang) AS SoKhach30Ngay
    FROM HoaDon
    WHERE NgayLap >= DATEADD(DAY, -30, GETDATE())
END

--CÁC THỦ TỤC CHỨC NĂNG QUẢN LÝ HÀNG HOÁ
---
CREATE TRIGGER trg_TinhGiamGiaHoaDon
ON ChiTietHoaDon
AFTER INSERT
AS
BEGIN
    DECLARE @MaHoaDon INT
    DECLARE @MaKhachHang INT
    DECLARE @Diem INT
    DECLARE @PhanTramGiam FLOAT

    SELECT TOP 1 @MaHoaDon = MaHoaDon
    FROM inserted

    SELECT @MaKhachHang = MaKhachHang
    FROM HoaDon
    WHERE MaHoaDon = @MaHoaDon

    SELECT @Diem = DiemTichLuy
    FROM KhachHang
    WHERE MaKhachHang = @MaKhachHang

    SELECT TOP 1 @PhanTramGiam = PhanTramGiam
    FROM UuDaiKhachHang
    WHERE DiemToiThieu <= @Diem
    ORDER BY DiemToiThieu DESC

    UPDATE hd
    SET TongTien =
    (
        SELECT SUM(
            CASE
                WHEN spud.MaSanPham IS NOT NULL
                THEN cthd.SoLuong * cthd.Gia * (1 - @PhanTramGiam / 100)
                ELSE cthd.SoLuong * cthd.Gia
            END
        )
        FROM ChiTietHoaDon cthd
        LEFT JOIN SanPhamUuDai spud
            ON cthd.MaSanPham = spud.MaSanPham
        WHERE cthd.MaHoaDon = @MaHoaDon
    )
    FROM HoaDon hd
    WHERE hd.MaHoaDon = @MaHoaDon
END



--triger cập nhật tồn
CREATE TRIGGER trg_CapNhatTonKho_KhiNhap
ON ChiTietNhap
AFTER INSERT
AS
BEGIN
    -- Nếu sản phẩm đã có trong tồn kho → cộng thêm
    UPDATE TK
    SET TK.SoLuong = TK.SoLuong + I.SoLuong
    FROM TonKho TK
    JOIN inserted I ON TK.MaSanPham = I.MaSanPham;

    -- Nếu sản phẩm chưa có trong tồn kho → thêm mới
    INSERT INTO TonKho (MaSanPham, SoLuong)
    SELECT I.MaSanPham, I.SoLuong
    FROM inserted I
    WHERE NOT EXISTS (
        SELECT 1 FROM TonKho TK WHERE TK.MaSanPham = I.MaSanPham
    );
END
CREATE TRIGGER trg_CapNhatTonKho_KhiBan
ON ChiTietHoaDon
AFTER INSERT
AS
BEGIN
    UPDATE TK
    SET TK.SoLuong = TK.SoLuong - I.SoLuong
    FROM TonKho TK
    JOIN inserted I ON TK.MaSanPham = I.MaSanPham;
END
-----------------------------------------------------------
CREATE PROC sp_LayPhanTramGiam
    @MaKH INT,
    @MaSP INT
AS
BEGIN
    SELECT TOP 1 ud.PhanTramGiam
    FROM KhachHang kh
    JOIN UuDaiKhachHang ud
        ON kh.DiemTichLuy >= ud.DiemToiThieu
    JOIN SanPhamUuDai spud
        ON ud.MaUuDai = spud.MaUuDai
    WHERE kh.MaKhachHang = @MaKH
    AND spud.MaSanPham = @MaSP
    ORDER BY ud.DiemToiThieu DESC
END
exec sp_LayPhanTramGiam 1,1
--CÒN TỒN
ALTER PROCEDURE sp_ConTonHang
AS
BEGIN
    SELECT SP.MaSanPham, SP.TenSanPham, SP.GiaBan, TK.SoLuong
    FROM SanPham SP
    JOIN TonKho TK ON SP.MaSanPham = TK.MaSanPham
    WHERE TK.SoLuong > 0
END
exec sp_ConTonHang
--HẾT HÀNG
ALTER PROCEDURE sp_DaHetHang
AS
BEGIN
    SELECT SP.MaSanPham, SP.TenSanPham, SP.GiaBan, TK.SoLuong
    FROM SanPham SP
    JOIN TonKho TK ON SP.MaSanPham = TK.MaSanPham
    WHERE TK.SoLuong <= 0
END

exec sp_DaHetHang
--THÊM HÀNG
CREATE PROCEDURE sp_ThemSanPham
    @TenSanPham NVARCHAR(100),
    @MaDanhMuc INT,
    @GiaNhap FLOAT,
    @GiaBan FLOAT
AS
BEGIN
    INSERT INTO SanPham (TenSanPham, MaDanhMuc, GiaNhap, GiaBan)
    VALUES (@TenSanPham, @MaDanhMuc, @GiaNhap, @GiaBan)

    DECLARE @MaSanPhamMoi INT = SCOPE_IDENTITY()

    INSERT INTO TonKho (MaSanPham, SoLuong)
    VALUES (@MaSanPhamMoi, 0)
END
--XOÁ HÀNG
CREATE PROCEDURE sp_XoaSanPham
    @MaSanPham INT
AS
BEGIN
    DELETE FROM TonKho
    WHERE MaSanPham = @MaSanPham

    DELETE FROM SanPham
    WHERE MaSanPham = @MaSanPham
END
--TÌM KIẾM HÀNG THEO TÊN
CREATE PROCEDURE sp_TimKiemSanPham
    @Ten NVARCHAR(100)
AS
BEGIN
    SELECT 
        SP.MaSanPham,
        SP.TenSanPham,
        SP.GiaBan,
        TK.SoLuong
    FROM SanPham SP
    LEFT JOIN TonKho TK ON SP.MaSanPham = TK.MaSanPham
    WHERE SP.TenSanPham LIKE N'%' + @Ten + N'%'
END
select* from SanPham
--thu tuc tat ca sp
ALTER PROCEDURE sp_TatCaSanPham
AS
BEGIN
    SELECT 
        MaSanPham,
        TenSanPham,
        MaDanhMuc,
        GiaNhap,
        GiaBan
    FROM SanPham
END
select* from Phong
--CÁC THỦ TỤC CHỨC NĂNG QUẢN LÝ PHÒNG
--Lấy tất cả phòng
CREATE PROCEDURE sp_TatCaPhong
AS
BEGIN
    SELECT MaPhong, TenPhong, TrangThai
    FROM Phong
END
--Phòng đang hoạt động
alter PROCEDURE sp_PhongDangHoatDong
AS
BEGIN
    SELECT MaPhong, TenPhong, TrangThai
    FROM Phong
    WHERE TrangThai = N'DangSuDung'
END
--Phòng trống
CREATE PROCEDURE sp_PhongTrong
AS
BEGIN
    SELECT MaPhong, TenPhong, TrangThai
    FROM Phong
    WHERE TrangThai = N'Trong'
END
--Thêm Phòng
CREATE PROCEDURE sp_ThemPhong
    @TenPhong NVARCHAR(100),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO Phong(TenPhong, TrangThai)
    VALUES (@TenPhong, @TrangThai)
END
--xOÁ phòng
CREATE PROCEDURE sp_XoaPhong
    @MaPhong INT
AS
BEGIN
    DELETE FROM Phong
    WHERE MaPhong = @MaPhong
END
--sửa phòng
CREATE PROCEDURE sp_SuaPhong
    @MaPhong INT,
    @TenPhong NVARCHAR(100),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    UPDATE Phong
    SET TenPhong = @TenPhong,
        TrangThai = @TrangThai
    WHERE MaPhong = @MaPhong
END
--CÁC THỦ TỤC CHỨC NĂNG QUẢN LÝ GIAO DỊCH
--TẠO VIEW CHUNG
CREATE VIEW vw_GiaoDich
AS

-- HÓA ĐƠN
SELECT 
    hd.MaHoaDon AS MaGiaoDich,
    hd.NgayLap AS Ngay,
    N'Hóa đơn' AS LoaiGiaoDich,
    CAST(hd.MaKhachHang AS NVARCHAR(50)) AS DoiTuong,
    hd.TongTien
FROM HoaDon hd

UNION ALL

-- NHẬP HÀNG
SELECT 
    nh.MaNhap AS MaGiaoDich,
    nh.NgayNhap AS Ngay,
    N'Nhập hàng' AS LoaiGiaoDich,
    CAST(nh.MaNCC AS NVARCHAR(50)) AS DoiTuong,
    ISNULL(ct.TotalTien,0) AS TongTien
FROM NhapHang nh
LEFT JOIN
(
    SELECT MaNhap, SUM(SoLuong * GiaNhap) AS TotalTien
    FROM ChiTietNhap
    GROUP BY MaNhap
) ct ON nh.MaNhap = ct.MaNhap

DROP VIEW vw_GiaoDich; 
--HHHHHHH
ALTER PROC sp_ThemChiTietHoaDon
    @MaHoaDon INT,
    @MaSanPham INT,
    @SoLuong INT
AS
BEGIN
    INSERT INTO ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong, Gia)
    SELECT
        @MaHoaDon,
        MaSanPham,
        @SoLuong,
        GiaBan
    FROM SanPham
    WHERE MaSanPham = @MaSanPham
END
-----hhhhhh
ALTER PROC sp_LayPhanTramGiam
    @MaKH INT,
    @MaSP INT
AS
BEGIN
    SELECT TOP 1 ud.PhanTramGiam
    FROM KhachHang kh
    JOIN UuDaiKhachHang ud
        ON kh.DiemTichLuy >= ud.DiemToiThieu
    JOIN SanPhamUuDai spud
        ON ud.MaUuDai = spud.MaUuDai
    WHERE kh.MaKhachHang = @MaKH
    AND spud.MaSanPham = @MaSP
    ORDER BY ud.DiemToiThieu DESC
END

--lấy tất cả
alter PROCEDURE sp_GiaoDich_GetAll
AS
BEGIN
    SELECT * FROM vw_GiaoDich ORDER BY Ngay DESC
END
-- lọc theo loại
alter PROCEDURE sp_GiaoDich_ByType
    @Loai NVARCHAR(50)
AS
BEGIN
    SELECT * FROM vw_GiaoDich
    WHERE LoaiGiaoDich = @Loai
END
-- lọc theo ngày
alter PROCEDURE sp_GiaoDich_ByDate
    @FromDate DATETIME,
    @ToDate DATETIME
AS
BEGIN
    SELECT * FROM vw_GiaoDich
    WHERE Ngay BETWEEN @FromDate AND @ToDate
END

--CÁC THỦ TỤC CHỨC NĂNG QUẢN LÝ KHÁCH HÀNG
--THÊM KHÁCH HÀNG
CREATE PROC sp_ThemKhachHang
@TenKhachHang NVARCHAR(100),
@SoDienThoai NVARCHAR(15),
@DiemTichLuy INT
AS
BEGIN
    INSERT INTO KhachHang(TenKhachHang, SoDienThoai, DiemTichLuy)
    VALUES (@TenKhachHang, @SoDienThoai, @DiemTichLuy)
END

--xoá khách hàng
CREATE PROC sp_XoaKhachHang
@MaKhachHang INT
AS
BEGIN
    DELETE FROM KhachHang
    WHERE MaKhachHang = @MaKhachHang
END
--sửa khách hàng
CREATE PROC sp_SuaKhachHang
@MaKhachHang INT,
@TenKhachHang NVARCHAR(100),
@SoDienThoai NVARCHAR(15),
@DiemTichLuy INT
AS
BEGIN
    UPDATE KhachHang
    SET TenKhachHang = @TenKhachHang,
        SoDienThoai = @SoDienThoai,
        DiemTichLuy = @DiemTichLuy
    WHERE MaKhachHang = @MaKhachHang
END
--tìm kiếm khách hàng
CREATE PROC sp_TimKiemKhachHang
@TuKhoa NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM KhachHang
    WHERE TenKhachHang LIKE '%' + @TuKhoa + '%'
       OR SoDienThoai LIKE '%' + @TuKhoa + '%'
END

--phân loại
CREATE PROC sp_DanhSachVIP
AS
BEGIN
    SELECT *
    FROM KhachHang
    WHERE DiemTichLuy >= 100
END

CREATE PROC sp_DanhSachThuong
AS
BEGIN
    SELECT *
    FROM KhachHang
    WHERE DiemTichLuy < 100
END

--triger tự cộng điểm 
CREATE TRIGGER trg_CongDiemKhachHang
ON HoaDon
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE KhachHang
    SET DiemTichLuy = DiemTichLuy + 50
    FROM KhachHang kh
    INNER JOIN inserted i 
        ON kh.MaKhachHang = i.MaKhachHang
END


alter VIEW vw_KhachHang_VIP
AS
SELECT 
    MaKhachHang,
    TenKhachHang,
    SoDienThoai,
    DiemTichLuy,
    CASE 
        WHEN DiemTichLuy >= 500 THEN N'VIP'
        ELSE N'Thường'
    END AS LoaiKhachHang
FROM KhachHang

--các thủ tục chức năng quản lý nhân viên
--thêm
CREATE PROC sp_ThemNhanVien
@TenNhanVien NVARCHAR(100),
@SoDienThoai NVARCHAR(15),
@ChucVu NVARCHAR(50),
@LuongCoBan FLOAT
AS
BEGIN
    INSERT INTO NhanVien(TenNhanVien, SoDienThoai, ChucVu, LuongCoBan)
    VALUES (@TenNhanVien, @SoDienThoai, @ChucVu, @LuongCoBan)
END
--sửa
CREATE PROC sp_SuaNhanVien
@MaNhanVien INT,
@TenNhanVien NVARCHAR(100),
@SoDienThoai NVARCHAR(15),
@ChucVu NVARCHAR(50),
@LuongCoBan FLOAT
AS
BEGIN
    UPDATE NhanVien
    SET TenNhanVien = @TenNhanVien,
        SoDienThoai = @SoDienThoai,
        ChucVu = @ChucVu,
        LuongCoBan = @LuongCoBan
    WHERE MaNhanVien = @MaNhanVien
END
--xoá
CREATE PROC sp_XoaNhanVien
@MaNhanVien INT
AS
BEGIN
    DELETE FROM NhanVien
    WHERE MaNhanVien = @MaNhanVien
END
--tìm kiếm
CREATE PROC sp_TimKiemNhanVien
@TuKhoa NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM NhanVien
    WHERE TenNhanVien LIKE '%' + @TuKhoa + '%'
       OR SoDienThoai LIKE '%' + @TuKhoa + '%'
       OR ChucVu LIKE '%' + @TuKhoa + '%'
END
--lọc
CREATE PROC sp_NhanVienSPA
AS
BEGIN
    SELECT *
    FROM NhanVien
    WHERE ChucVu = N'Kỹ thuật viên'
END

CREATE PROC sp_NhanVienLeTan
AS
BEGIN
    SELECT *
    FROM NhanVien
    WHERE ChucVu = N'Lễ tân'
END
--các thủ tục chức năng của sổ quỹ
CREATE PROC sp_ThemSoQuy
@Loai NVARCHAR(20),
@SoTien FLOAT,
@MoTa NVARCHAR(255),
@Ngay DATETIME
AS
BEGIN
    INSERT INTO SoQuy(Loai, SoTien, MoTa, Ngay)
    VALUES (@Loai, @SoTien, @MoTa, @Ngay)
END
--lay du liệu
CREATE PROC sp_LaySoQuy
AS
BEGIN
    SELECT * FROM SoQuy ORDER BY Ngay DESC
END

--lọc theo loại
CREATE PROC sp_LocTheoLoai
@Loai NVARCHAR(20)
AS
BEGIN
    SELECT * FROM SoQuy
    WHERE Loai = @Loai
    ORDER BY Ngay DESC
END

--7 ngày gần
CREATE PROC sp_Lay7Ngay
AS
BEGIN
    SELECT * FROM SoQuy
    WHERE Ngay >= DATEADD(DAY, -7, GETDATE())
    ORDER BY Ngay DESC
END
--loc ket hợp
CREATE PROC sp_LocLoaiVa7Ngay
@Loai NVARCHAR(20)
AS
BEGIN
    SELECT * FROM SoQuy
    WHERE Loai = @Loai
    AND Ngay >= DATEADD(DAY, -7, GETDATE())
    ORDER BY Ngay DESC
END
--tìm kiếm 
CREATE PROC sp_TimKiemSoQuy
@MoTa NVARCHAR(255)
AS
BEGIN
    SELECT * FROM SoQuy
    WHERE MoTa LIKE '%' + @MoTa + '%'
    ORDER BY Ngay DESC
END
--tổng thu
CREATE PROC sp_TongThu
AS
BEGIN
    SELECT ISNULL(SUM(SoTien),0) AS TongThu
    FROM SoQuy
    WHERE Loai = N'Thu'
END
--tổng chi
CREATE PROC sp_TongChi
AS
BEGIN
    SELECT ISNULL(SUM(SoTien),0) AS TongChi
    FROM SoQuy
    WHERE Loai = N'Chi'
END
-- các thủ tục chức năng báo cáo
--doanh thu
CREATE PROC sp_BaoCao_DoanhThu
@SoNgay INT
AS
BEGIN
    SELECT 
        CAST(NgayLap AS DATE) AS Ngay,
        SUM(TongTien) AS DoanhThu
    FROM HoaDon
    WHERE NgayLap >= DATEADD(DAY, -@SoNgay, GETDATE())
    GROUP BY CAST(NgayLap AS DATE)
    ORDER BY Ngay DESC
END
--tồn kho
CREATE PROC sp_BaoCao_TonKho
AS
BEGIN
    SELECT 
        sp.TenSanPham,
        tk.SoLuong
    FROM TonKho tk
    JOIN SanPham sp ON tk.MaSanPham = sp.MaSanPham
END
-- doanh thu chi tiét
ALTER PROC sp_BaoCao_DoanhThu_ChiTiet
@SoNgay INT
AS
BEGIN
    ;WITH HD AS
    (
        SELECT 
            MaHoaDon,
            TongTien
        FROM HoaDon
        WHERE CAST(NgayLap AS DATE) >= CAST(DATEADD(DAY, -@SoNgay, GETDATE()) AS DATE)
    )

    -- dòng tổng (đưa lên đầu)
    SELECT 
        NULL AS MaHoaDon,
        NULL AS TongTien,
        SUM(TongTien) AS TongDoanhThu
    FROM HD

    UNION ALL

    -- dữ liệu hóa đơn
    SELECT 
        MaHoaDon,
        TongTien,
        CAST(NULL AS FLOAT) AS TongDoanhThu
    FROM HD
END
select * from HoaDon
--các thủ tục chức năng lịch làm việc
CREATE PROC sp_LichLamViec_Tuan
@StartDate DATE
AS
BEGIN
    SELECT 
        ld.ThoiGian,
        kh.TenKhachHang,
        ld.MaNhanVien
    FROM LichDat ld
    JOIN KhachHang kh ON ld.MaKhachHang = kh.MaKhachHang
    WHERE CAST(ld.ThoiGian AS DATE)
          BETWEEN @StartDate AND DATEADD(DAY, 6, @StartDate)
END
--
drop proc sp_ThemLichDat
CREATE PROC sp_ThemLichDat
@MaKhachHang INT,
@MaNhanVien INT,
@MaPhong INT,
@MaDichVu INT,
@ThoiGian DATETIME,
@TrangThai NVARCHAR(20)
AS
BEGIN
    INSERT INTO LichDat
    VALUES(@MaKhachHang,@MaNhanVien,@MaPhong,@MaDichVu,@ThoiGian,@TrangThai)
END
--
CREATE PROC sp_KiemTraTrungLich
@ThoiGian DATETIME
AS
BEGIN
    SELECT COUNT(*) 
    FROM LichDat
    WHERE ThoiGian = @ThoiGian
END
--
CREATE PROC sp_ThemKhachHang_nv
@TenKhachHang NVARCHAR(100),
@SoDienThoai NVARCHAR(15),
@DiemTichLuy INT
AS
BEGIN
    INSERT INTO KhachHang(TenKhachHang, SoDienThoai, DiemTichLuy)
    VALUES(@TenKhachHang, @SoDienThoai, @DiemTichLuy)
END

--
CREATE PROC sp_ThemLichDat_nv
@MaKhachHang INT,
@MaNhanVien INT,
@MaPhong INT,
@MaDichVu INT,
@ThoiGian DATETIME
AS
BEGIN
    INSERT INTO LichDat
    (
        MaKhachHang,
        MaNhanVien,
        MaPhong,
        MaDichVu,
        ThoiGian,
        TrangThai
    )
    VALUES
    (
        @MaKhachHang,
        @MaNhanVien,
        @MaPhong,
        @MaDichVu,
        @ThoiGian,
        N'Cho'
    )
END
select*from KhachHang

select*from LichDat