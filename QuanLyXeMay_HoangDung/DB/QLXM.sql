USE [QLXM]
GO
/****** Object:  StoredProcedure [dbo].[timKiemLichSuBanHang]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO	
CREATE PROCEDURE [dbo].[timKiemLichSuBanHang]
@fromDate DATE,
@toDate DATE
AS
BEGIN
  SELECT dbo.PhieuXuat.MaPX, dbo.KhachHang.TenKH, dbo.Xe.TenXe, dbo.Xe.MauSac,
		dbo.ChiTietPhieuXuat.SoKhung, dbo.ChiTietPhieuXuat.SoMay, dbo.ChiTietPhieuXuat.DonGia,
		dbo.PhieuXuat.NgayXuat

	FROM dbo.ChiTietPhieuXuat
	INNER JOIN dbo.Xe ON dbo.ChiTietPhieuXuat.MaXe = dbo.Xe.MaXe
	INNER JOIN dbo.PhieuXuat ON dbo.ChiTietPhieuXuat.MaPX = dbo.PhieuXuat.MaPX
	INNER JOIN dbo.KhachHang ON dbo.PhieuXuat.MaKH = dbo.KhachHang.MaKH
	
	WHERE PhieuXuat.NgayXuat >= @fromDate AND PhieuXuat.NgayXuat <=@toDate;
END
GO
/****** Object:  StoredProcedure [dbo].[timKiemLichSuNhapHang]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[timKiemLichSuNhapHang]
@fromDate DATE,
@toDate DATE
AS
BEGIN
  SELECT dbo.PhieuNhap.MaPN, dbo.Xe.TenXe, dbo.ChiTietPhieuNhap.SoLuong,
		dbo.ChiTietPhieuNhap.DonGia, dbo.ChiTietPhieuNhap.ThanhTien,
		dbo.PhieuNhap.NgayNhap, dbo.NhaCungCap.TenNCC

	FROM dbo.PhieuNhap
	INNER JOIN dbo.ChiTietPhieuNhap ON dbo.ChiTietPhieuNhap.MaPN = dbo.PhieuNhap.MaPN
	INNER JOIN dbo.Xe ON dbo.ChiTietPhieuNhap.MaXe = dbo.Xe.MaXe
	INNER JOIN dbo.NhaCungCap ON dbo.PhieuNhap.MaNCC = dbo.NhaCungCap.MaNCC
	
	WHERE PhieuNhap.NgayNhap >= @fromDate AND PhieuNhap.NgayNhap <= @toDate;

END
GO
/****** Object:  StoredProcedure [dbo].[timkiemTonKho]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[timkiemTonKho]
@hangXe nvarchar(64) = NULL,
@loaiXe nvarchar(64) = NULL,
@phanKhoi nvarchar(32) = NULL,
@tenXe nvarchar(256) = NULL
AS
BEGIN
  SELECT *
	FROM Xe
	WHERE (HangXe = @hangXe OR @hangXe IS NULL)
	AND (LoaiXe = @loaiXe OR @loaiXe IS NULL)
	AND (PhanKhoi = @phanKhoi OR @phanKhoi IS NULL)
	AND (TenXe LIKE CONCAT('%',@tenXe,'%') OR @tenXe IS NULL)
	AND SoLuong > 0;
END
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaCTPN] [int] IDENTITY(1,1) NOT NULL,
	[MaPN] [nvarchar](50) NULL,
	[MaXe] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaCTPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[MaCTPX] [int] IDENTITY(1,1) NOT NULL,
	[MaPX] [nvarchar](50) NULL,
	[MaXe] [nvarchar](50) NULL,
	[SoKhung] [nvarchar](50) NULL,
	[SoMay] [nvarchar](50) NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaCTPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietXe]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietXe](
	[MaCT] [int] IDENTITY(1,1) NOT NULL,
	[MaXe] [nvarchar](50) NULL,
	[SoKhung] [nvarchar](50) NULL,
	[SoMay] [nvarchar](50) NULL,
	[Active] [bit] NULL,
	[MaPN] [nvarchar](50) NULL,
	[MaPX] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietXe] PRIMARY KEY CLUSTERED 
(
	[MaCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[TenDayDu] [nvarchar](50) NULL,
	[Quyen] [int] NULL,
 CONSTRAINT [PK_DangNhap] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangXe]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangXe](
	[MaHang] [nvarchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangXe] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MauXe]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MauXe](
	[MaMau] [nvarchar](50) NOT NULL,
	[TenMau] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[Email] [nvarchar](150) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DienThoai] [nvarchar](12) NULL,
	[Email] [nvarchar](250) NULL,
	[DiaChi] [nvarchar](350) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaNCC] [nvarchar](50) NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPX] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NULL,
	[MaKH] [int] NULL,
	[NgayXuat] [date] NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Xe]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [nvarchar](50) NOT NULL,
	[TenXe] [nvarchar](50) NULL,
	[MauSac] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[PhanKhoi] [int] NULL,
	[LoaiXe] [nvarchar](50) NULL,
	[AnhXe] [nvarchar](50) NULL,
	[HangXe] [nvarchar](50) NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[viewLichSuNhap]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewLichSuNhap] AS 
SELECT
dbo.PhieuNhap.MaPN,
dbo.Xe.TenXe,
dbo.ChiTietPhieuNhap.SoLuong,
dbo.ChiTietPhieuNhap.DonGia,
dbo.ChiTietPhieuNhap.ThanhTien,
dbo.PhieuNhap.NgayNhap,
dbo.NhaCungCap.TenNCC

FROM
dbo.PhieuNhap
INNER JOIN dbo.ChiTietPhieuNhap ON dbo.ChiTietPhieuNhap.MaPN = dbo.PhieuNhap.MaPN
INNER JOIN dbo.Xe ON dbo.ChiTietPhieuNhap.MaXe = dbo.Xe.MaXe
INNER JOIN dbo.NhaCungCap ON dbo.PhieuNhap.MaNCC = dbo.NhaCungCap.MaNCC

GO
/****** Object:  View [dbo].[viewLichSuXuat]    Script Date: 09/08/2018 4:03:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewLichSuXuat] AS 
SELECT
dbo.PhieuXuat.MaPX,
dbo.KhachHang.TenKH,
dbo.Xe.TenXe,
dbo.Xe.MauSac,
dbo.ChiTietPhieuXuat.SoKhung,
dbo.ChiTietPhieuXuat.SoMay,
dbo.ChiTietPhieuXuat.DonGia,
dbo.PhieuXuat.NgayXuat

FROM
dbo.ChiTietPhieuXuat
INNER JOIN dbo.Xe ON dbo.ChiTietPhieuXuat.MaXe = dbo.Xe.MaXe
INNER JOIN dbo.PhieuXuat ON dbo.ChiTietPhieuXuat.MaPX = dbo.PhieuXuat.MaPX
INNER JOIN dbo.KhachHang ON dbo.PhieuXuat.MaKH = dbo.KhachHang.MaKH

GO
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhap] ON 

INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1004, N'HDMH0000000001', N'XM0001', 2, 19500000, 39000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1005, N'HDMH0000000001', N'XM0002', 2, 22000000, 44000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1006, N'HDMH0000000001', N'XM0003', 3, 46990000, 140970000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1007, N'HDMH0000000002', N'XM0003', 1, 46990000, 46990000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1008, N'HDMH0000000003', N'XM0001', 1, 19500000, 19500000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1009, N'HDMH0000000004', N'XM0001', 1, 19500000, 19500000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1010, N'HDMH0000000005', N'XM0001', 3, 19500000, 58500000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1011, N'HDMH0000000006', N'XM0003', 4, 46990000, 187960000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1012, N'HDMH0000000007', N'XM0003', 3, 46990000, 140970000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaCTPN], [MaPN], [MaXe], [SoLuong], [DonGia], [ThanhTien]) VALUES (1013, N'HDMH0000000008', N'XM0001', 2, 19500000, 39000000)
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhap] OFF
SET IDENTITY_INSERT [dbo].[ChiTietPhieuXuat] ON 

INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (5, N'HDBH0000000001', N'XM0001', N'7457567657556745675', N'56745656567546456', 46990000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (6, N'HDBH0000000001', N'XM0002', N'4574565675645745', N'4554568565654675', 46990000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (7, N'HDBH0000000002', N'XM0001', N'00000000001', N'10000000001', 19500000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (8, N'HDBH0000000002', N'XM0002', N'00000000002', N'10000000002', 19500000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (9, N'HDBH0000000003', N'XM0001', N'9786564475456345', N'4563647456345674', 19500000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (10, N'HDBH0000000004', N'XM0001', N'9857454353443536', N'546346346345634', 19500000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (11, N'HDBH0000000005', N'XM0001', N'564563563456', N'546435645645', 22000000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (12, N'HDBH0000000006', N'XM0001', N'56767243457', N'23457665745', 22000000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (13, N'HDBH0000000007', N'XM0001', N'3254645567546', N'3457564635343', 46990000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (14, N'HDBH0000000008', N'XM0001', N'67565434231', N'565423213456', 46990000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (15, N'HDBH0000000009', N'XM0001', N'675453443535', N'45346565634634', 19500000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (16, N'HDBH0000000010', N'XM0001', N'43534656346346', N'3463463463434634', 19500000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (17, N'HDBH0000000011', N'XM0001', N'433463463463', N'34346346346343', 19500000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (18, N'HDBH0000000012', N'XM0001', N'67632443445645', N'4563565463456346', 46990000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (19, N'HDBH0000000013', N'XM0001', N'54634563456345', N'63456345634634', 46990000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (20, N'HDBH0000000014', N'XM0001', N'456345645456435', N'643564363463464', 46990000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaCTPX], [MaPX], [MaXe], [SoKhung], [SoMay], [DonGia]) VALUES (21, N'HDBH0000000015', N'XM0001', N'5463456345645645', N'3456354634563444', 46990000)
SET IDENTITY_INSERT [dbo].[ChiTietPhieuXuat] OFF
SET IDENTITY_INSERT [dbo].[ChiTietXe] ON 

INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1011, N'XM0001', N'00000000001', N'10000000001', 0, N'HDMH0000000001', N'HDBH0000000002')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1012, N'XM0001', N'00000000002', N'10000000002', 0, N'HDMH0000000001', N'HDBH0000000002')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1013, N'XM0002', N'564563563456', N'546435645645', 0, N'HDMH0000000001', N'HDBH0000000005')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1014, N'XM0002', N'56767243457', N'23457665745', 0, N'HDMH0000000001', N'HDBH0000000006')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1015, N'XM0003', N'7457567657556745675', N'56745656567546456', 0, N'HDMH0000000001', N'HDBH0000000001')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1016, N'XM0003', N'4574565675645745', N'4554568565654675', 0, N'HDMH0000000001', N'HDBH0000000001')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1017, N'XM0003', N'3254645567546', N'3457564635343', 0, N'HDMH0000000001', N'HDBH0000000007')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1018, N'XM0003', N'67565434231', N'565423213456', 0, N'HDMH0000000002', N'HDBH0000000008')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1019, N'XM0001', N'9786564475456345', N'4563647456345674', 0, N'HDMH0000000003', N'HDBH0000000003')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1020, N'XM0001', N'9857454353443536', N'546346346345634', 0, N'HDMH0000000004', N'HDBH0000000004')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1021, N'XM0001', N'675453443535', N'45346565634634', 0, N'HDMH0000000005', N'HDBH0000000009')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1022, N'XM0001', N'43534656346346', N'3463463463434634', 0, N'HDMH0000000005', N'HDBH0000000010')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1023, N'XM0001', N'433463463463', N'34346346346343', 0, N'HDMH0000000005', N'HDBH0000000011')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1024, N'XM0003', N'67632443445645', N'4563565463456346', 0, N'HDMH0000000006', N'HDBH0000000012')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1025, N'XM0003', N'54634563456345', N'63456345634634', 0, N'HDMH0000000006', N'HDBH0000000013')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1026, N'XM0003', N'456345645456435', N'643564363463464', 0, N'HDMH0000000006', N'HDBH0000000014')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1027, N'XM0003', N'5463456345645645', N'3456354634563444', 0, N'HDMH0000000006', N'HDBH0000000015')
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1028, N'XM0003', N'673546654674546', N'674554754564543', 1, N'HDMH0000000007', NULL)
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1029, N'XM0003', N'544575675676', N'5675675675674', 1, N'HDMH0000000007', NULL)
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1030, N'XM0003', N'65757547568547', N'675675756456645', 1, N'HDMH0000000007', NULL)
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1031, N'XM0001', N'5675434546433', N'4556345353434', 1, N'HDMH0000000008', NULL)
INSERT [dbo].[ChiTietXe] ([MaCT], [MaXe], [SoKhung], [SoMay], [Active], [MaPN], [MaPX]) VALUES (1032, N'XM0001', N'5436655346545', N'6456346345353', 1, N'HDMH0000000008', NULL)
SET IDENTITY_INSERT [dbo].[ChiTietXe] OFF
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [TenDayDu], [Quyen]) VALUES (N'admin', N'admin', N'Quản trị viên', 1)
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [TenDayDu], [Quyen]) VALUES (N'nam', N'nam', N'Nam', 0)
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX001', N'HONDA')
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX002', N'Yamaha')
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX003', N'SYM')
INSERT [dbo].[HangXe] ([MaHang], [TenHang]) VALUES (N'HX004', N'Piaggio')
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DienThoai], [Email], [DiaChi]) VALUES (2, N'Hưng', N'0963243462', N'', N'Thái Bình')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DienThoai], [Email], [DiaChi]) VALUES (3, N'Khuê', N'01682314585', N'', N'')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DienThoai], [Email], [DiaChi]) VALUES (4, N'Thắng', N'01234679246', N'thang@gmail.com', N'Bắc Ninh')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M001', N'Đỏ-Đen')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M002', N'Trắng-Đen')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M003', N'Trắng')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M004', N'Đỏ')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M005', N'Xanh dương')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M006', N'Đỏ-Trắng')
INSERT [dbo].[MauXe] ([MaMau], [TenMau]) VALUES (N'M007', N'Xanh-Bạc')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC001', N'Nhà cung cấp số 1', N'Hà Nội', N'', N'ncc01@gmail.com')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC002', N'Nhà cung cấp số 2', N'Thái Bình', N'', N'ncc02@gmail.com')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [Email], [DiaChi]) VALUES (N'NV0001', N'Hoàng Đức Hưng', N'', N'', N'a@a.com', N'')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [DienThoai], [Email], [DiaChi]) VALUES (N'NV0002', N'Lại Hoàng Khuê', N'', N'', N'', N'')
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDMH0000000001', N'NV0001', N'NCC001', CAST(0x2B3E0B00 AS Date), 223970000)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDMH0000000002', N'NV0001', N'NCC001', CAST(0x2B3E0B00 AS Date), 46990000)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDMH0000000003', N'NV0001', N'NCC001', CAST(0x313E0B00 AS Date), 19500000)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDMH0000000004', N'NV0001', N'NCC001', CAST(0x313E0B00 AS Date), 19500000)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDMH0000000005', N'NV0001', N'NCC001', CAST(0x533E0B00 AS Date), 58500000)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDMH0000000006', N'NV0001', N'NCC001', CAST(0x533E0B00 AS Date), 187960000)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDMH0000000007', N'NV0001', N'NCC001', CAST(0x633E0B00 AS Date), 140970000)
INSERT [dbo].[PhieuNhap] ([MaPN], [MaNV], [MaNCC], [NgayNhap], [TongTien]) VALUES (N'HDMH0000000008', N'NV0001', N'NCC001', CAST(0x633E0B00 AS Date), 39000000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000001', N'NV0001', 2, CAST(0x2B3E0B00 AS Date), 93980000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000002', N'NV0001', 2, CAST(0x313E0B00 AS Date), 39000000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000003', N'NV0001', 3, CAST(0x533E0B00 AS Date), 19500000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000004', N'NV0001', 3, CAST(0x533E0B00 AS Date), 19500000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000005', N'NV0001', 2, CAST(0x533E0B00 AS Date), 22000000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000006', N'NV0001', 2, CAST(0x533E0B00 AS Date), 22000000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000007', N'NV0001', 2, CAST(0x533E0B00 AS Date), 46990000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000008', N'NV0001', 2, CAST(0x533E0B00 AS Date), 46990000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000009', N'NV0001', 2, CAST(0x533E0B00 AS Date), 19500000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000010', N'NV0001', 2, CAST(0x533E0B00 AS Date), 19500000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000011', N'NV0001', 4, CAST(0x533E0B00 AS Date), 19500000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000012', N'NV0001', 2, CAST(0x533E0B00 AS Date), 46990000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000013', N'NV0001', 2, CAST(0x533E0B00 AS Date), 46990000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000014', N'NV0001', 2, CAST(0x533E0B00 AS Date), 46990000)
INSERT [dbo].[PhieuXuat] ([MaPX], [MaNV], [MaKH], [NgayXuat], [TongTien]) VALUES (N'HDBH0000000015', N'NV0001', 2, CAST(0x533E0B00 AS Date), 46990000)
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MauSac], [SoLuong], [DonGia], [PhanKhoi], [LoaiXe], [AnhXe], [HangXe]) VALUES (N'XM0001', N'Wave alpha', N'Trắng', -10, 19500000, 110, N'Xe số (côn tự động)', N'XM0001.jpg', N'HONDA')
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MauSac], [SoLuong], [DonGia], [PhanKhoi], [LoaiXe], [AnhXe], [HangXe]) VALUES (N'XM0002', N'Wave S', N'Trắng', 2, 22000000, 110, N'Xe số (côn tự động)', N'XM0002.jpg', N'HONDA')
INSERT [dbo].[Xe] ([MaXe], [TenXe], [MauSac], [SoLuong], [DonGia], [PhanKhoi], [LoaiXe], [AnhXe], [HangXe]) VALUES (N'XM0003', N'Exciter 150 Mat Blue', N'Xanh-Bạc', 6, 46990000, 150, N'Xe số (côn tay)', N'XM0003.jpg', N'Yamaha')
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_Xe]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat1] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PhieuXuat] ([MaPX])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_PhieuXuat1]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuat_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietPhieuXuat_Xe]
GO
ALTER TABLE [dbo].[ChiTietXe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietXe_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietXe] CHECK CONSTRAINT [FK_ChiTietXe_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietXe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietXe_PhieuXuat] FOREIGN KEY([MaPX])
REFERENCES [dbo].[PhieuXuat] ([MaPX])
GO
ALTER TABLE [dbo].[ChiTietXe] CHECK CONSTRAINT [FK_ChiTietXe_PhieuXuat]
GO
ALTER TABLE [dbo].[ChiTietXe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietXe_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietXe] CHECK CONSTRAINT [FK_ChiTietXe_Xe]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_KhachHang]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
