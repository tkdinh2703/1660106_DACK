USE [master]
GO
/****** Object:  Database [QLBH-DACK]    Script Date: 12/11/2019 7:54:23 PM ******/
CREATE DATABASE [QLBH-DACK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLBH-DACK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QLBH-DACK.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLBH-DACK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\QLBH-DACK_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLBH-DACK] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLBH-DACK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLBH-DACK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLBH-DACK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLBH-DACK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLBH-DACK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLBH-DACK] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLBH-DACK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLBH-DACK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLBH-DACK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLBH-DACK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLBH-DACK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLBH-DACK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLBH-DACK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLBH-DACK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLBH-DACK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLBH-DACK] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLBH-DACK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLBH-DACK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLBH-DACK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLBH-DACK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLBH-DACK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLBH-DACK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLBH-DACK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLBH-DACK] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLBH-DACK] SET  MULTI_USER 
GO
ALTER DATABASE [QLBH-DACK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLBH-DACK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLBH-DACK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLBH-DACK] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLBH-DACK] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLBH-DACK] SET QUERY_STORE = OFF
GO
USE [QLBH-DACK]
GO
/****** Object:  Table [dbo].[Chitietphieunhaphang]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietphieunhaphang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Maphieunhaphang] [int] NULL,
	[Masp] [int] NULL,
	[Soluong] [int] NULL,
	[Dongia] [bigint] NULL,
	[Thanhtien] [bigint] NULL,
 CONSTRAINT [PK_Chitietphieunhaphang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chitietphieuxuathang]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietphieuxuathang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Maphieuxuathang] [int] NULL,
	[Masp] [int] NULL,
	[SoLuong] [int] NULL,
	[Dongiahientai] [bigint] NULL,
	[Thanhtien] [bigint] NULL,
 CONSTRAINT [PK_Chitietphieuxuathang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DSKhachhang]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSKhachhang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Ngaysinh] [nvarchar](50) NULL,
	[Diachi] [nvarchar](200) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Nganhang] [nchar](50) NULL,
	[Sotk] [bigint] NULL,
	[Sodienthoai] [int] NULL,
 CONSTRAINT [PK_DSKhachhang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khohang]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khohang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tenkhohang] [nvarchar](80) NULL,
	[Diachikho] [nvarchar](300) NULL,
 CONSTRAINT [PK_Khohang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loaihang]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaihang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenLHang] [nvarchar](500) NULL,
 CONSTRAINT [PK_Loaihang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manhinh]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manhinh](
	[IdMh] [int] IDENTITY(1,1) NOT NULL,
	[frmTen] [nvarchar](50) NULL,
	[frmNoidung] [nvarchar](50) NULL,
 CONSTRAINT [PK_Manhinh] PRIMARY KEY CLUSTERED 
(
	[IdMh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhacungcap]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhacungcap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[DienThoai] [bigint] NULL,
	[Website] [varchar](200) NULL,
 CONSTRAINT [PK_Nhacungcap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhansu]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhansu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[NgayThamgia] [nvarchar](50) NULL,
	[Diachi] [nvarchar](200) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Nganhang] [nchar](50) NULL,
	[Sotk] [bigint] NULL,
	[Sodienthoai] [int] NULL,
	[IdQuyen] [int] NULL,
 CONSTRAINT [PK_Nhansus_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phanquyen]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phanquyen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QuyenId] [int] NULL,
	[ManhinhId] [int] NULL,
	[Truycap] [bit] NULL,
	[Them] [bit] NULL,
	[Xoa] [bit] NULL,
	[Sua] [bit] NULL,
	[Inan] [bit] NULL,
	[Nhap] [bit] NULL,
	[Xuat] [bit] NULL,
 CONSTRAINT [PK_Phanquyen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieunhaphang]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieunhaphang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Maphieuthu] [nvarchar](100) NULL,
	[MaNcc] [int] NULL,
	[MaNvnhap] [int] NULL,
	[MaKhonhap] [int] NULL,
	[Ngaynhap] [varchar](50) NULL,
 CONSTRAINT [PK_Phieunhaphang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieuxuathang]    Script Date: 12/11/2019 7:54:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieuxuathang](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Madonhang] [nvarchar](100) NULL,
	[Makh] [int] NULL,
	[Makho] [int] NULL,
	[Manv] [int] NULL,
	[Ngaylap] [nvarchar](50) NULL,
 CONSTRAINT [PK_Phieuxuathang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 12/11/2019 7:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](20) NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sanphams]    Script Date: 12/11/2019 7:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sanphams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[LoaiHang] [nvarchar](50) NULL,
	[NgaySanXuat] [varchar](50) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[HinhAnh] [nvarchar](500) NULL,
	[NhaCungCap] [nvarchar](50) NULL,
	[GiaMua] [bigint] NULL,
	[GiaBan] [bigint] NULL,
	[VAT] [bigint] NULL,
	[Khohang] [nvarchar](100) NULL,
	[Thuonghieu] [nvarchar](100) NULL,
 CONSTRAINT [PK_Sanpham] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuonghieu]    Script Date: 12/11/2019 7:54:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuonghieu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenNSX] [nvarchar](50) NULL,
	[Quocgia] [nvarchar](50) NULL,
	[Website] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nhasanxuat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DSKhachhang] ON 

INSERT [dbo].[DSKhachhang] ([Id], [Ten], [Email], [Ngaysinh], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai]) VALUES (1, N'phuong', N'phuong@gmail.com', N'12/4/2019', N'194 phan chu trinh', N'Nam', N'ACB                                               ', 13326566596, 123456789)
INSERT [dbo].[DSKhachhang] ([Id], [Ten], [Email], [Ngaysinh], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai]) VALUES (2, N'trung', N'phuong@gmail.com', N'12/4/2019', N'194 phan chu trinh', N'Nam', N'ACB                                               ', 13326566596, 123456789)
INSERT [dbo].[DSKhachhang] ([Id], [Ten], [Email], [Ngaysinh], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai]) VALUES (4, N'trung', N'phuong@gmail.com', N'12/4/2019', N'194 phan chu trinh', N'Nam', N'ACB                                               ', 13326566596, 123456789)
INSERT [dbo].[DSKhachhang] ([Id], [Ten], [Email], [Ngaysinh], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai]) VALUES (5, N'trung', N'phuong@gmail.com', N'12/4/2019', N'194 phan chu trinh', N'Nam', N'ACB                                               ', 13326566596, 123456789)
SET IDENTITY_INSERT [dbo].[DSKhachhang] OFF
SET IDENTITY_INSERT [dbo].[Khohang] ON 

INSERT [dbo].[Khohang] ([Id], [Tenkhohang], [Diachikho]) VALUES (1, N'nguyen van cu', N'227 nguyen van cu')
INSERT [dbo].[Khohang] ([Id], [Tenkhohang], [Diachikho]) VALUES (2, N'nguyen chi thanh', NULL)
INSERT [dbo].[Khohang] ([Id], [Tenkhohang], [Diachikho]) VALUES (3, N'le hồng phong', N'111 lê hồng phong quận 5')
INSERT [dbo].[Khohang] ([Id], [Tenkhohang], [Diachikho]) VALUES (4, N'phan chu trinh', N'86 hoang thai')
SET IDENTITY_INSERT [dbo].[Khohang] OFF
SET IDENTITY_INSERT [dbo].[Loaihang] ON 

INSERT [dbo].[Loaihang] ([Id], [TenLHang]) VALUES (1, N'Điện Thoại')
INSERT [dbo].[Loaihang] ([Id], [TenLHang]) VALUES (2, N'Laptop')
INSERT [dbo].[Loaihang] ([Id], [TenLHang]) VALUES (3, N'Ipad')
INSERT [dbo].[Loaihang] ([Id], [TenLHang]) VALUES (4, N'Đồng hồ')
SET IDENTITY_INSERT [dbo].[Loaihang] OFF
SET IDENTITY_INSERT [dbo].[Manhinh] ON 

INSERT [dbo].[Manhinh] ([IdMh], [frmTen], [frmNoidung]) VALUES (1, N'frmQlnguoidung', N'Quản lý người dùng')
INSERT [dbo].[Manhinh] ([IdMh], [frmTen], [frmNoidung]) VALUES (2, N'frmQlnhanvien', N'Quản lý nhân viên')
INSERT [dbo].[Manhinh] ([IdMh], [frmTen], [frmNoidung]) VALUES (3, N'frmQlsanpham', N'Quản lý sản phẩm')
INSERT [dbo].[Manhinh] ([IdMh], [frmTen], [frmNoidung]) VALUES (4, N'FrmQlnhacungcap', N'Quản lý nhà cung cấp/phân phối')
INSERT [dbo].[Manhinh] ([IdMh], [frmTen], [frmNoidung]) VALUES (5, N'frmQlnhasanxuat', N'Quản lý nhà sản xuất')
INSERT [dbo].[Manhinh] ([IdMh], [frmTen], [frmNoidung]) VALUES (6, N'frmQlkhohang', N'Quản lý kho hàng')
SET IDENTITY_INSERT [dbo].[Manhinh] OFF
SET IDENTITY_INSERT [dbo].[Nhacungcap] ON 

INSERT [dbo].[Nhacungcap] ([Id], [TenNCC], [DiaChi], [DienThoai], [Website]) VALUES (1, N'Phong vũ 2', N'148 CMT8 Q6', 202336788, N'phongvu.comn')
INSERT [dbo].[Nhacungcap] ([Id], [TenNCC], [DiaChi], [DienThoai], [Website]) VALUES (2, N'Thành Nhân', N'01 Hồ xuân hương', 569782144, N'thanhnhan.com')
INSERT [dbo].[Nhacungcap] ([Id], [TenNCC], [DiaChi], [DienThoai], [Website]) VALUES (3, N'Fpt', N'227 nguyễn chí thanh', 45687568, N'fpt.com')
SET IDENTITY_INSERT [dbo].[Nhacungcap] OFF
SET IDENTITY_INSERT [dbo].[Nhansu] ON 

INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (1, N'trongbang', N'1234', N'Bằng', N'bang@gmail.com', N'11/28/2019', N'194 Đỗ ngọc thạnh 1', N'Nam       ', N'Nam                                               ', 1, 0, 1)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (2, N'binh', N'123', N'Bằng', N'bang@gmail.com', N'11/28/2019', N'194 Đỗ ngọc thạnh', N'Nam       ', N'                                                  ', 1, 0, 1)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (3, N'Trandinh1', N'aaaaa', N'Trần kiên định', N'dinh@gmail.com', N'11/28/2019', N'194 Đỗ ngọc thạnh zzzz', N'Nam       ', N'                                                  ', 1, 0, 1)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (4, N'Trandinh2', N'24545', N'2', N'dinh@gmail.com', N'11/28/2019', N'194 Đỗ ngọc thạnh', N'Nam       ', N'Nam                                               ', 1, 0, 1)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (5, N'Trandinh3', N'123', N'Định', N'dinh@gmail.com', N'11/28/2019', N'194 Đỗ ngọc thạnha', N'Nam       ', N'Nam                                               ', 1, 0, 1)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (6, N'Trandinh4', N'123', N'Định', N'dinh@gmail.com', N'11/28/2019', N'194 Đỗ ngọc thạnh', N'Nam       ', N'nam                                               ', 1, 0, 1)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (7, N'fasdf', N'aaaa', N'asdffd', N'Nsgsgegr', N'11/5/2019', N'fdsgfd', N'Nam       ', N'                                                  ', 1, 0, 1)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (8, N'leduyen', N'11111111', N'sadf', N'Nafs@gmail.com', N'11/20/2019', N'safdsaf', N'Nữ        ', N'Nữ                                                ', 1, 0, 2)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (9, N'hjfsadhh', N'dsafsdf', N'sdfaasd', N'Nsdfsadf', N'11/7/2019', N'asdffsda', N'Nữ        ', N'Nữ                                                ', 1, 5464564, 2)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (10, N'trang', N'88888888', N'Trang', N'Nafs@gmail.com', N'11/20/2019', N'safdsaf', N'Nữ', N'                                                  ', 1, 0, 2)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (11, N'tkdinh', N'272898dt', N'dinh', N'N', N'', N'zzzzzz', N'Nữ        ', N'Nam                                               ', 1, 0, 2)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (12, N'tkdinh', N'272898', N'', N'N', N'', N'', N'Nữ        ', N'                                                  ', 1, 0, 2)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (13, N'hanh', N'444', N'hanhh', N'N', N'', N'', N'Nữ        ', N'Nam                                               ', 1, 0, 3)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (14, N'dinhit', N'1', N'sfd', N'sdafsd@gmail.com', N'', N'asdf', N'Nữ        ', N'Nam                                               ', 1, 0, 3)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (15, N'cong', N'1', N'', N'dsafsdf@gmailcom', N'', N'', N'Nữ        ', N'                                                  ', 1, 0, 3)
INSERT [dbo].[Nhansu] ([Id], [TenDangNhap], [MatKhau], [Ten], [Email], [NgayThamgia], [Diachi], [Gioitinh], [Nganhang], [Sotk], [Sodienthoai], [IdQuyen]) VALUES (17, N'trang2', N'1', N'', N'', N'', N'', N'Nam', N'                                                  ', 0, 0, 2)
SET IDENTITY_INSERT [dbo].[Nhansu] OFF
SET IDENTITY_INSERT [dbo].[Phanquyen] ON 

INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (6, 1, 1, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (7, 1, 2, 1, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (8, 1, 3, 1, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (9, 1, 4, 1, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (10, 1, 5, 1, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (11, 1, 6, 1, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (12, 2, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (13, 2, 2, 1, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (14, 2, 3, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (15, 2, 4, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (16, 2, 5, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (17, 2, 6, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (18, 3, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (19, 3, 2, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (20, 3, 3, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (21, 3, 4, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (22, 3, 5, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (23, 3, 6, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Phanquyen] ([Id], [QuyenId], [ManhinhId], [Truycap], [Them], [Xoa], [Sua], [Inan], [Nhap], [Xuat]) VALUES (24, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Phanquyen] OFF
SET IDENTITY_INSERT [dbo].[Phieuxuathang] ON 

INSERT [dbo].[Phieuxuathang] ([Id], [Madonhang], [Makh], [Makho], [Manv], [Ngaylap]) VALUES (10, N'BHPC041501', 4, 3, 15, N'12/6/2019 11:52:40 AM')
INSERT [dbo].[Phieuxuathang] ([Id], [Madonhang], [Makh], [Makho], [Manv], [Ngaylap]) VALUES (11, N'BHPC041502', 4, 3, 15, N'12/6/2019 11:52:40 AM')
INSERT [dbo].[Phieuxuathang] ([Id], [Madonhang], [Makh], [Makho], [Manv], [Ngaylap]) VALUES (12, N'BHPT021001', 2, 3, 10, N'12/10/2019 7:52:03 AM')
SET IDENTITY_INSERT [dbo].[Phieuxuathang] OFF
SET IDENTITY_INSERT [dbo].[Quyen] ON 

INSERT [dbo].[Quyen] ([Id], [TenQuyen]) VALUES (1, N'Người dùng')
INSERT [dbo].[Quyen] ([Id], [TenQuyen]) VALUES (2, N'Quản lý')
INSERT [dbo].[Quyen] ([Id], [TenQuyen]) VALUES (3, N'Admin')
SET IDENTITY_INSERT [dbo].[Quyen] OFF
SET IDENTITY_INSERT [dbo].[Sanphams] ON 

INSERT [dbo].[Sanphams] ([Id], [TenHang], [LoaiHang], [NgaySanXuat], [XuatXu], [SoLuong], [HinhAnh], [NhaCungCap], [GiaMua], [GiaBan], [VAT], [Khohang], [Thuonghieu]) VALUES (1, N'samsung s7', N'Điện Thoại', N'12/25/2019', N'han quoc', 1980, N'F:\imgUDQL\Udungql\Actions-user-group-new-icon.png', N'Phong vũ 2', 100000, 100000000, 5, N'nguyen chi thanh', N'Amazon')
INSERT [dbo].[Sanphams] ([Id], [TenHang], [LoaiHang], [NgaySanXuat], [XuatXu], [SoLuong], [HinhAnh], [NhaCungCap], [GiaMua], [GiaBan], [VAT], [Khohang], [Thuonghieu]) VALUES (2, N'fsdfsdfdssdfd', N'Laptop', N'12/18/2019', N'bbfffd', 980, N'F:\imgUDQL\Udungql\xiaomi-redmi-note-8-32gb-white-18thangbh-400x460.png', N'Phong vũ 2', 2000, 200000, 10, N'le hồng phong', N'Amazon')
SET IDENTITY_INSERT [dbo].[Sanphams] OFF
SET IDENTITY_INSERT [dbo].[Thuonghieu] ON 

INSERT [dbo].[Thuonghieu] ([Id], [TenNSX], [Quocgia], [Website]) VALUES (1, N'Apple', N'Mỹ', N'apple.com')
INSERT [dbo].[Thuonghieu] ([Id], [TenNSX], [Quocgia], [Website]) VALUES (2, N'SamSung', N'Hàn Quốc', NULL)
INSERT [dbo].[Thuonghieu] ([Id], [TenNSX], [Quocgia], [Website]) VALUES (3, N'Huawei', N'Trung Quốc', NULL)
INSERT [dbo].[Thuonghieu] ([Id], [TenNSX], [Quocgia], [Website]) VALUES (4, N'Amazon', N'Anh', NULL)
INSERT [dbo].[Thuonghieu] ([Id], [TenNSX], [Quocgia], [Website]) VALUES (5, N'Philips', N'Nhật', NULL)
INSERT [dbo].[Thuonghieu] ([Id], [TenNSX], [Quocgia], [Website]) VALUES (6, N'google', N'Úc', N'google.com')
SET IDENTITY_INSERT [dbo].[Thuonghieu] OFF
USE [master]
GO
ALTER DATABASE [QLBH-DACK] SET  READ_WRITE 
GO
