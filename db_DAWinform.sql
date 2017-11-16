USE [master]
GO
/****** Object:  Database [QLBH]    Script Date: 11/15/2017 10:08:33 PM ******/
CREATE DATABASE [QLBH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_shop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_shop.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
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
/****** Object:  Table [dbo].[BaoHanh]    Script Date: 11/15/2017 10:08:33 PM ******/
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
	[TrangThai] [int] NULL,
 CONSTRAINT [PK_BaoHanh] PRIMARY KEY CLUSTERED 
(
	[MaBaoHanh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietBaoHanh]    Script Date: 11/15/2017 10:08:33 PM ******/
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
	[TinhTrang] [int] NULL,
	[MoTaLoi] [nvarchar](max) NULL,
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
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuXuat]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/15/2017 10:08:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [varchar](10) NOT NULL,
	[TenSanPham] [nvarchar](max) NULL,
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
/****** Object:  Table [dbo].[Serial]    Script Date: 11/15/2017 10:08:33 PM ******/
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
/****** Object:  Table [dbo].[ThuChi]    Script Date: 11/15/2017 10:08:33 PM ******/
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
INSERT [dbo].[BaoHanh] ([MaBaoHanh], [MaKhachHang], [MaNhanVien], [NgayBaoHanh], [TrangThai]) VALUES (N'BH1', N'KH3', N'NV1', CAST(N'2017-11-15' AS Date), 1)
INSERT [dbo].[BaoHanh] ([MaBaoHanh], [MaKhachHang], [MaNhanVien], [NgayBaoHanh], [TrangThai]) VALUES (N'BH2', N'KH2', N'NV1', CAST(N'2017-11-15' AS Date), 1)
INSERT [dbo].[ChiTietBaoHanh] ([MaBaoHanh], [MaSerial], [NgayHenTra], [TinhTrang], [MoTaLoi], [GhiChu]) VALUES (N'BH1', N'SER1', CAST(N'2017-11-15' AS Date), 0, N'Quạt không chạy', N'')
INSERT [dbo].[ChiTietBaoHanh] ([MaBaoHanh], [MaSerial], [NgayHenTra], [TinhTrang], [MoTaLoi], [GhiChu]) VALUES (N'BH2', N'SER12', CAST(N'2017-11-15' AS Date), 2, N'Không hợp main', N'')
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PN1', N'SP1', 10, 16000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PN2', N'SP1', 2, 16000000)
INSERT [dbo].[ChiTietPhieuNhap] ([MaPhieuNhap], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PN3', N'SP1', 21, 16000000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PX1', N'SP1', 1, 16000000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PX2', N'SP1', 1, 16000000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PX3', N'SP1', 1, 16000000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PX4', N'SP1', 1, 16000000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PX5', N'SP1', 4, 16000000)
INSERT [dbo].[ChiTietPhieuXuat] ([MaPhieuXuat], [MaSanPham], [SoLuong], [Gia]) VALUES (N'PX6', N'SP1', 2, 16000000)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX1', N'ASUS', NULL, 1)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX2', N'INTEL', NULL, 1)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX3', N'GIGABYTE', NULL, 1)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX4', N'AMD', N'', 1)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX5', N'AOC', N'', 1)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX6', N'Razer', N'', 1)
INSERT [dbo].[HangSanXuat] ([MaHangSanXuat], [TenHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'HSX7', N'ZOTAC', N'', 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDT], [DiaChi], [GhiChu], [TrangThai]) VALUES (N'KH1', N'Nguyễn Văn A', NULL, N'0123456', N'Gò Vấp', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDT], [DiaChi], [GhiChu], [TrangThai]) VALUES (N'KH2', N'Nguyễn Văn B', NULL, N'0123457', N'Mũi Né', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDT], [DiaChi], [GhiChu], [TrangThai]) VALUES (N'KH3', N'A. Thắng', NULL, N'0123458', N'Trung Quốc', NULL, 1)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDT], [DiaChi], [GhiChu], [TrangThai]) VALUES (N'KH4', N'Sang Trương', N'', N'01692089106', N'Gò Vấp', N'', 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP1', N'VGA', N'Card màn hình', 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP2', N'CPU', NULL, 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP3', N'Mainboard', NULL, 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP4', N'PSU', N'Nguồn', 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP5', N'Ram', N'', 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP6', N'Case', N'', 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP7', N'HDD', N'Ổ cứng', 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP8', N'SSD', N'', 1)
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham], [GhiChu], [TrangThai]) VALUES (N'LSP9', N'Monitor', N'Màn hình', 1)
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDT], [GhiChu], [TrangThai]) VALUES (N'NCC1', N'Phong Vũ', N'TP.HCM', N'012356879', NULL, 1)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [TenDangNhap], [MatKhau], [HinhDaiDien], [DiaChi], [CMND], [SoDT], [Email], [Quyen], [GhiChu], [TrangThai]) VALUES (N'NV1', N'BOSS', N'admin', N'123456', N'data\images\users\admin.gif', NULL, NULL, NULL, NULL, 1, NULL, 1)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PN1', N'NCC1', CAST(160000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-13' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PN2', N'NCC1', CAST(32000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-14' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNhaCungCap], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PN3', N'NCC1', CAST(336000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-14' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [MaKhachHang], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PX1', N'KH2', CAST(16000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-13' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [MaKhachHang], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PX2', N'KH3', CAST(16000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-13' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [MaKhachHang], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PX3', N'KH2', CAST(16000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-13' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [MaKhachHang], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PX4', N'KH2', CAST(16000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-14' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [MaKhachHang], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PX5', N'KH3', CAST(64000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-14' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[PhieuXuat] ([MaPhieuXuat], [MaKhachHang], [TongTien], [TienNo], [ChietKhau], [Thue], [NgayLap], [NhanVienLap], [GhiChu], [TinhTrang], [TrangThai]) VALUES (N'PX6', N'KH3', CAST(32000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0, 0, CAST(N'2017-11-14' AS Date), N'NV1', N'', 1, 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP1', N'VGA ASUS ROG STRIX Geforce GTX 1070 Ti A8G ( ROG-STRIX-GTX1070TI-A8G-GAMING )', N'data\images\products\asusGTX1070ti.PNG', CAST(15000000 AS Decimal(18, 0)), CAST(16000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'VGA ASUS ROG STRIX Geforce GTX 1070Ti O8G 

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
1 DVI', 36, 23, N'Cái', N'LSP1', N'HSX1', N'', 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP2', N'CPU Intel Core i7-7820X (3.6GHz Upto 4.3Ghz/ 8C16T/ 11MB/ 2066-KabyLakeX)', N'data\images\products\24351_cpu_intel_core_i7_7820x__3_6ghz_upto_4_3ghz_8c16t_11mb_2066_kabylakex__1.png', CAST(16000000 AS Decimal(18, 0)), CAST(17000000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'', 36, 0, N'Cái', N'LSP2', N'HSX2', N'', 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP3', N'Mainboard GIGABYTE B250 GA-Gaming B8', N'data\images\products\24326_mainboard_gigabyte_b250_ga_gaming_b8_4.png', CAST(2500000 AS Decimal(18, 0)), CAST(2999000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'', 36, 0, N'Cái', N'LSP3', N'HSX3', N'', 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP4', N'VGA ASUS ROG-STRIX-RX580-O8G-GAMING', N'data\images\products\24382_vga_asus_rog_strix_rx580_o8g_gaming_1.png', CAST(8250000 AS Decimal(18, 0)), CAST(9250000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'', 37, 0, N'Cái', N'LSP1', N'HSX1', N'', 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP5', N'VGA ASUS STRIX GTX1050TI-DC2O4G-GAMING', N'data\images\products\24304_vga_asus_strix_rog_gtx1050ti_dc2o4g_gaming_1.png', CAST(3500000 AS Decimal(18, 0)), CAST(4490000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'VGA ASUS STRIX GTX1050TI-DC2O4G-GAMING
- 1455 MHz engine clock in OC mode for outstanding 1080p gaming experience.
- DirectCU II with 0dB fan technology lets you enjoy light games in complete silence, and hardcore gaming 30% cooler with 3X-quieter performance!
- Patented Wing-Blade IP5X-Certified Fans for maximum airflow and longer fan lifespan.
- Industry Only Auto-Extreme Technology with Super Alloy Power II delivers premium quality and the best reliability.
- GPU Tweak II with XSplit Gamecaster provides intuitive performance tweaking and real-time streaming.', 36, 0, N'Cái', N'LSP1', N'HSX1', N'', 1)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [Hinh], [GiaMua], [GiaBan], [KhuyenMai], [MoTa], [BaoHanh], [SoLuong], [DonViTinh], [MaLoaiSanPham], [MaHangSanXuat], [GhiChu], [TrangThai]) VALUES (N'SP6', N'Màn hình máy tính AOC G2460VQ6 24 Inch AMD Freesync 75mhz', N'data\images\products\23466_m__n_h__nh_m__y_t__nh_aoc_g2460vq6_24___2.png', CAST(2500000 AS Decimal(18, 0)), CAST(3290000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'AOC Monitor LED,1MS G2460VQ6 Full HD 1080P - LED
* Kích thước: 24"Wide Screen
* Độ phân giải: 1920×1080@75Hz ( FreeSync AMD )
* Độ sáng (Max): 250 cd/m²
* Tỉ lệ tương phản (Max.): 80,000,000:1 (DCR)
* Hiển thị Màu sắc: 16.7M
* Góc nhìn: 170/160 (CR≥10)
* Thời gian đáp ứng: 1 ms;
* Công nghệ: FreeSync, Anti-Blue-Light, Flicker Free
* Kết nối: 15-pin D-Sub, HDMI and DP
* Công suất tiêu thụ: Nhỏ hơn 23W / Chế độ Power saving: Nhỏ hơn 0.5W
* Nguồn điện liền không qua Adaptor không sợ mất cắp ở phòng Game.', 36, 0, N'Cái', N'LSP9', N'HSX5', N'', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER1', N'KQ1DZOQKDCKP', CAST(N'2020-11-13' AS Date), N'SP1', NULL, N'PX1', N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER10', N'TDLBN6KYBMYE', CAST(N'2020-11-13' AS Date), N'SP1', NULL, N'PX2', N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER11', N'ZYND6NTDNAUL', CAST(N'2020-11-14' AS Date), N'SP1', NULL, N'PX5', N'PN2', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER12', N'61BZ5QPXHPOS', CAST(N'2020-11-14' AS Date), N'SP1', NULL, N'PX5', N'PN2', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER13', N'62KMSZ509YAG', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER14', N'D589S21K3D5N', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER15', N'8KPGJ6R2YX6C', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER16', N'XY2A0534XPRC', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER17', N'SCKHR9TNS8T1', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER18', N'HQXB885PQ1E1', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER19', N'B5EIZCV8LKGQ', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER2', N'RTP0ZRM47SEW', CAST(N'2020-11-13' AS Date), N'SP1', NULL, N'PX3', N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER20', N'OULX7B19KH88', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER21', N'VX9J7EXTEW2F', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER22', N'8MGYFE3UETUX', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER23', N'FQ4KFHZE88P4', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER24', N'MTS7FKVY2OJC', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER25', N'ZIYMNK1Z1KBT', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER26', N'6MN8NNXJV051', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER27', N'JBTNVM4KUWYI', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER28', N'DPBUNQU2PF08', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER29', N'33OO3P64O8K7', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER3', N'H72UFQY65KZV', CAST(N'2020-11-14' AS Date), N'SP1', NULL, N'PX4', N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER30', N'XI5VVTWNIRMX', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER31', N'4LTHVWS7C7G4', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER32', N'HA0W3VY8C39M', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER33', N'OEOJ2ZUS6J3T', NULL, N'SP1', NULL, NULL, N'PN3', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER4', N'BMK17UOP031L', CAST(N'2020-11-14' AS Date), N'SP1', NULL, N'PX5', N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER5', N'IP8N7XK8UJVS', CAST(N'2020-11-14' AS Date), N'SP1', NULL, N'PX5', N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER6', N'VEE2FXQ9UFNA', CAST(N'2020-11-14' AS Date), N'SP1', NULL, N'PX6', N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER7', N'2H2OF0MTOVHH', CAST(N'2020-11-14' AS Date), N'SP1', NULL, N'PX6', N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER8', N'F793NZSUNRAZ', NULL, N'SP1', NULL, NULL, N'PN1', 1)
INSERT [dbo].[Serial] ([MaSerial], [SoSerial], [ThoiHanBaoHanh], [MaSanPham], [GhiChu], [MaPhieuXuat], [MaPhieuNhap], [TrangThai]) VALUES (N'SER9', N'MAXPN2OEH746', NULL, N'SP1', NULL, NULL, N'PN1', 1)
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
