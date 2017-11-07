USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 11/7/2017 10:03:52 AM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_shop.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_shop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_shop_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLBH] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH] SET RECOVERY FULL 
GO
ALTER DATABASE [QLBH] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLBH] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLBH', N'ON'
GO
USE [QLBH]
GO
/****** Object:  Table [dbo].[BaoHanh]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaoHanh](
	[MaBaoHanh] [varchar](10) NOT NULL,
	[MaKhachHang] [varchar](10) NULL,
	[MaNhanVien] [varchar](10) NULL,
	[NgayBaoHanh] [date] NULL,
	[TongTien] [decimal](18, 0) NULL,
	[LoaiBaoHanh] [int] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_BaoHanh] PRIMARY KEY CLUSTERED 
(
	[MaBaoHanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietBaoHanh]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietBaoHanh](
	[MaBaoHanh] [varchar](10) NOT NULL,
	[MaSerial] [varchar](10) NOT NULL,
	[NgayHenTra] [date] NULL,
	[GiaSuaChua] [decimal](18, 0) NULL,
	[TraHang] [int] NULL,
	[MoTaLoi] [ntext] NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_ChiTietBaoHanh] PRIMARY KEY CLUSTERED 
(
	[MaBaoHanh] ASC,
	[MaSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPhieuNhap] [varchar](10) NOT NULL,
	[MaSanPham] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuat](
	[MaPhieuXuat] [varchar](10) NOT NULL,
	[MaSanPham] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDon_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangSanXuat](
	[MaHangSanXuat] [varchar](10) NOT NULL,
	[TenHangSanXuat] [nvarchar](50) NULL,
	[GhiChu] [ntext] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_HangSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaHangSanXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [varchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[CMND] [varchar](15) NULL,
	[SoDT] [varchar](15) NULL,
	[DiaChi] [ntext] NULL,
	[GhiChu] [ntext] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [varchar](10) NOT NULL,
	[TenLoaiSanPham] [nvarchar](50) NULL,
	[GhiChu] [ntext] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [varchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NULL,
	[DiaChi] [ntext] NULL,
	[SoDT] [varchar](20) NULL,
	[GhiChu] [ntext] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[HinhDaiDien] [text] NULL,
	[DiaChi] [ntext] NULL,
	[CMND] [varchar](15) NULL,
	[SoDT] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[Quyen] [int] NULL,
	[GhiChu] [ntext] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [varchar](10) NOT NULL,
	[MaNhaCungCap] [varchar](10) NULL,
	[TongTien] [decimal](18, 0) NULL,
	[TienNo] [decimal](18, 0) NULL,
	[ChietKhau] [float] NULL,
	[Thue] [float] NULL,
	[NgayLap] [date] NULL,
	[NhanVienLap] [varchar](10) NULL,
	[GhiChu] [ntext] NULL,
	[TinhTrang] [int] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[MaPhieuXuat] [varchar](10) NOT NULL,
	[MaKhachHang] [varchar](10) NULL,
	[TongTien] [decimal](18, 0) NULL,
	[TienNo] [decimal](18, 0) NULL,
	[ChietKhau] [float] NULL,
	[Thue] [float] NULL,
	[NgayLap] [date] NULL,
	[NhanVienLap] [varchar](10) NULL,
	[GhiChu] [ntext] NULL,
	[TinhTrang] [int] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](10) NOT NULL,
	[TenSanPham] [ntext] NULL,
	[Hinh] [text] NULL,
	[GiaMua] [decimal](18, 0) NULL,
	[GiaBan] [decimal](18, 0) NULL,
	[KhuyenMai] [decimal](18, 0) NULL,
	[MoTa] [ntext] NULL,
	[BaoHanh] [int] NULL,
	[SoLuong] [int] NULL,
	[DonViTinh] [nvarchar](15) NULL,
	[MaLoaiSanPham] [varchar](10) NULL,
	[MaHangSanXuat] [varchar](10) NULL,
	[GhiChu] [ntext] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Serial]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Serial](
	[MaSerial] [varchar](10) NOT NULL,
	[SoSerial] [varchar](50) NULL,
	[ThoiHanBaoHanh] [date] NULL,
	[MaSanPham] [varchar](10) NULL,
	[GhiChu] [ntext] NULL,
	[MaPhieuXuat] [varchar](10) NULL,
	[MaPhieuNhap] [varchar](10) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_MaSeri] PRIMARY KEY CLUSTERED 
(
	[MaSerial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThuChi]    Script Date: 11/7/2017 10:03:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThuChi](
	[MaPhieu] [varchar](10) NOT NULL,
	[MaNhanVien] [varchar](10) NOT NULL,
	[NguoiNopNhan] [nvarchar](50) NULL,
	[NoiDung] [ntext] NULL,
	[SoTien] [decimal](18, 0) NULL,
	[GhiChu] [ntext] NULL,
	[LoaiPhieu] [int] NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_ThuChi] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PX1', N'SP1', 2, 16000000)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX1', N'ASUS', NULL, 1)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX2', N'INTEL', NULL, 1)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX3', N'GIGABYTE', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDT], [DiaChi], [GhiChu], [TrangThai]) VALUES (N'KH1', N'Nguyễn Văn A', NULL, N'0123456', N'Gò Vấp', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDT], [DiaChi], [GhiChu], [TrangThai]) VALUES (N'KH2', N'Nguyễn Văn B', NULL, N'0123457', N'Mũi Né', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDT], [DiaChi], [GhiChu], [TrangThai]) VALUES (N'KH3', N'A. Thắng', NULL, N'0123458', N'Trung Quốc', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDT], [DiaChi], [GhiChu], [TrangThai]) VALUES (N'KH4', N'Sang Trương', N'', N'01692089106', N'Gò Vấp', N'', 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP1', N'VGA', NULL, 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP2', N'CPU', NULL, 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP3', N'Mainboard', NULL, 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [HinhDaiDien], [DiaChi], [CMND], [SoDT], [Email], [Quyen], [GhiChu], [TrangThai]) VALUES (N'NV1', N'BOSS', N'admin', N'123456', N'data\images\users\admin.gif', NULL, NULL, NULL, NULL, 1, NULL, 1)
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [MaKhachHang], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PX1', N'KH3', CAST(32000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-04-11' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP1', N'VGA ASUS ROG STRIX Geforce GTX 1070 Ti A8G ( ROG-STRIX-GTX1070TI-A8G-GAMING )', N'data\images\products\asusGTX1070ti.PNG', CAST(15000000 AS Decimal(18, 0)), CAST(16000000 AS Decimal(18, 0)), NULL, N'VGA ASUS ROG STRIX Geforce GTX 1070Ti O8G 

THÔNG SỐ SẢN PHẨM NVIDIA GTX 1070 Ti 
Nhân card đồ họa ( Core ) GP104 
Công nghệ vi xử lý ( Process Node ) 16nm 
Số bán dẫn ( Transistor ) 7.2 Triệu 
Nhân CUDA ( CUDA Core)	2432 CUDA 
Xung mặc định ( Base Clock )	1607 Mhz 
Mức Xung OC ( Boost Clock ) 1683 Mhz 
Năng lực tính toán ( FP32 Compute ) 8.1 TFLOPs 
Bộ nhớ trong ( Vram ) 8 GB GDDR5 
Tốc độ bộ nhớ ( Memory Speed )	8 Gbps 
Băng thông bộ nhớ ( Memory Bandwitdth ) 256 GB/s 
Băng thông giao tiếp ( Bus Interface ) 256 Bit 
Cấp nguồn ( Power Connector )	Đầu 8Pin 
Mức điêu tiêu thụ ( TDP )	180W 
Cổng xuất hình ( Display Outputs )	3 cổng DisplayPort 1.4 
1 HDMI 2.0b 
1 DVI', 36, 3, N'Cái', N'LSP1', N'HSX1', N'', 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP2', N'CPU Intel Core i7-7820X (3.6GHz Upto 4.3Ghz/ 8C16T/ 11MB/ 2066-KabyLakeX)', N'data\images\products\24351_cpu_intel_core_i7_7820x__3_6ghz_upto_4_3ghz_8c16t_11mb_2066_kabylakex__1.png', CAST(16000000 AS Decimal(18, 0)), CAST(17000000 AS Decimal(18, 0)), NULL, NULL, 36, 3, N'Cái', N'LSP2', N'HSX2', NULL, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP3', N'Mainboard GIGABYTE B250 GA-Gaming B8
', N'data\images\products\24326_mainboard_gigabyte_b250_ga_gaming_b8_4.png', CAST(2500000 AS Decimal(18, 0)), CAST(2999000 AS Decimal(18, 0)), NULL, NULL, 36, 2, N'Cái', N'LSP3', N'HSX3', NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER1', N'1LIO50ZC29KV', CAST(N'2020-04-11' AS Date), N'SP1', NULL, N'PX1', NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER10', N'HHBHKAR1572F', NULL, N'SP3', NULL, NULL, NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER2', N'DOE6WP3Y2PHX', CAST(N'2020-04-11' AS Date), N'SP1', NULL, N'PX1', NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER3', N'3K05C0LAZLH3', NULL, N'SP1', NULL, NULL, NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER4', N'7GA6ASL4IG2C', NULL, N'SP1', NULL, NULL, NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER5', N'EC7NS1XL3Y2F', NULL, N'SP1', NULL, NULL, NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER6', N'XFNMIQVVTH1Z', NULL, N'SP2', NULL, NULL, NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER7', N'QIERAYAXO5TH', NULL, N'SP2', NULL, NULL, NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER8', N'EYPBQU83I9P1', NULL, N'SP2', NULL, NULL, NULL, 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER9', N'25H9W8VROBQZ', NULL, N'SP3', NULL, NULL, NULL, 1)
ALTER TABLE [dbo].[BaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_BaoHanh_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[BaoHanh] CHECK CONSTRAINT [FK_BaoHanh_KhachHang]
GO
ALTER TABLE [dbo].[BaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_BaoHanh_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[BaoHanh] CHECK CONSTRAINT [FK_BaoHanh_NhanVien]
GO
ALTER TABLE [dbo].[ChiTietBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBaoHanh_BaoHanh] FOREIGN KEY([MaBaoHanh])
REFERENCES [dbo].[BaoHanh] ([MaBaoHanh])
GO
ALTER TABLE [dbo].[ChiTietBaoHanh] CHECK CONSTRAINT [FK_ChiTietBaoHanh_BaoHanh]
GO
ALTER TABLE [dbo].[ChiTietBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBaoHanh_Serial] FOREIGN KEY([MaSerial])
REFERENCES [dbo].[Serial] ([MaSerial])
GO
ALTER TABLE [dbo].[ChiTietBaoHanh] CHECK CONSTRAINT [FK_ChiTietBaoHanh_Serial]
GO
ALTER TABLE [dbo].[ChiTietBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBaoHanh_Serial1] FOREIGN KEY([MaSerial])
REFERENCES [dbo].[Serial] ([MaSerial])
GO
ALTER TABLE [dbo].[ChiTietBaoHanh] CHECK CONSTRAINT [FK_ChiTietBaoHanh_Serial1]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PhieuXuat] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuat] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([NhanVienLap])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[PhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([NhanVienLap])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuXuat] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_HangSanXuat] FOREIGN KEY([MaHangSanXuat])
REFERENCES [dbo].[HangSanXuat] ([MaHangSanXuat])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_HangSanXuat]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[Serial]  WITH CHECK ADD  CONSTRAINT [FK_Serial_PhieuNhap] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[Serial] CHECK CONSTRAINT [FK_Serial_PhieuNhap]
GO
ALTER TABLE [dbo].[Serial]  WITH CHECK ADD  CONSTRAINT [FK_Serial_PhieuXuat] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PhieuXuat] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[Serial] CHECK CONSTRAINT [FK_Serial_PhieuXuat]
GO
ALTER TABLE [dbo].[Serial]  WITH CHECK ADD  CONSTRAINT [FK_SoSeri_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[Serial] CHECK CONSTRAINT [FK_SoSeri_SanPham]
GO
ALTER TABLE [dbo].[ThuChi]  WITH CHECK ADD  CONSTRAINT [FK_ThuChi_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ThuChi] CHECK CONSTRAINT [FK_ThuChi_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLBH] SET  READ_WRITE 
GO
