CREATE DATABASE  QuanLiNhanSu
USE QuanLiNhanSu
GO

CREATE DATABASE [QuanLiNhanSu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiNhanSu', FILENAME = N'D:\BàiTap\NET\qlns\QLNS\QuanLiNhanSu.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiNhanSu_log', FILENAME = N'D:\BàiTap\NET\qlns\QLNS\QuanLiNhanSu_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiNhanSu] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLiNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiNhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiNhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiNhanSu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLiNhanSu]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBaoHiemXH](
	[MaNV] [char](10) NOT NULL,
	[MaSoBH] [nvarchar](15) NOT NULL,
	[NgayCap] [datetime] NULL,
	[NoiCap] [nvarchar](50) NULL,
	[NoiDKKCB] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblBaoHiemXH] PRIMARY KEY CLUSTERED 
(
	[MaSoBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChuyenMon](
	[MaCM] [char](10) NOT NULL,
	[TenCM] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChuyenMon] PRIMARY KEY CLUSTERED 
(
	[TenCM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDonVi](
	[MaDV] [nvarchar](30) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDonVi] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLuong](
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](30) NULL,
	[MaLuong] [nvarchar](30) NULL,
	[MaChuyenMon] [nvarchar](30) NULL,
	[LuongCoBan] [int] NULL,
	[PCChucVu] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[LuongCBMoi] [int] NULL,
	[NgaySua] [datetime] NULL,
	[LyDo] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblLuong] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblThueThuNhapCaNhan](
	[MaThue] [char](10) NOT NULL,
	[MaNV] [nvarchar](30) NOT NULL,
	[CoQuanQuanLyThue] [nvarchar](50) NULL,
	[MaLuong] [nvarchar](30) NULL,
	[SoTien] [int] NULL,
	[NgayDangKi] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblThueThuNhapCaNhan] PRIMARY KEY CLUSTERED 
(
	[MaThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTrinhDo](
	[TenTrinhDo] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTrinhDo] PRIMARY KEY CLUSTERED 
(
	[TenTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTTNhanVien](
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](30) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[CMND] [char](12) NULL,
	[NoiSinh] [nchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [char](12) NULL,
	[TDHV] [nvarchar](50) NULL,
	[MaBHXH] [nvarchar](15) NULL,
	[MaLuong] [char](10) NULL,
	[MaDonVi] [nvarchar](30) NULL,
	[MaThue] [char](10) NULL,
	[ChuyenMon] [nvarchar](50) NULL,
	[Email] [nvarchar](30) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[DanToc] [nvarchar](30) NULL,
	[TonGiao] [nvarchar](30) NULL,
	[QuocTich] [nvarchar](30) NULL,
 CONSTRAINT [PK_tblTTNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[ID] [nchar](10) NOT NULL,
	[Password] [nchar](20) NULL,
	[PhanQuyen] [int] NOT NULL
) ON [PRIMARY]

GO
INSERT [dbo].[tblBaoHiemXH] ([MaNV], [MaSoBH], [NgayCap], [NoiCap], [NoiDKKCB], [GhiChu]) VALUES (N'001', N'BH001', CAST(0x0000A60E00000000 AS DateTime), N'TP HCM', N'BV Tân Phú', N'Không có')
INSERT [dbo].[tblBaoHiemXH] ([MaNV], [MaSoBH], [NgayCap], [NoiCap], [NoiDKKCB], [GhiChu]) VALUES (N'002', N'BH002', CAST(0x0000A60100000000 AS DateTime), N'TP HCM', N'BV Tân Phú', N'Không có')
INSERT [dbo].[tblBaoHiemXH] ([MaNV], [MaSoBH], [NgayCap], [NoiCap], [NoiDKKCB], [GhiChu]) VALUES (N'003', N'BH003', CAST(0x0000A69700000000 AS DateTime), N'TP HCM', N'BV Chợ Rẫy', N'Không có')
INSERT [dbo].[tblBaoHiemXH] ([MaNV], [MaSoBH], [NgayCap], [NoiCap], [NoiDKKCB], [GhiChu]) VALUES (N'004', N'BH004', CAST(0x0000A60A00000000 AS DateTime), N'TP HCM', N'BV Nhi Đồng', N'Không có')
INSERT [dbo].[tblBaoHiemXH] ([MaNV], [MaSoBH], [NgayCap], [NoiCap], [NoiDKKCB], [GhiChu]) VALUES (N'005', N'BH005', CAST(0x0000A58000000000 AS DateTime), N'TP HCM', N'BV Thống Nhất', N'BV Thống Nhất')
INSERT [dbo].[tblBaoHiemXH] ([MaNV], [MaSoBH], [NgayCap], [NoiCap], [NoiDKKCB], [GhiChu]) VALUES (N'006', N'BH006', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblChuyenMon] ([MaCM], [TenCM], [GhiChu]) VALUES (N'CM003', N'Bán Hàng', N'Không')
INSERT [dbo].[tblChuyenMon] ([MaCM], [TenCM], [GhiChu]) VALUES (N'CM001', N'CEO', N'Không')
INSERT [dbo].[tblChuyenMon] ([MaCM], [TenCM], [GhiChu]) VALUES (N'CM004', N'Kế Toán', N'Không')
INSERT [dbo].[tblChuyenMon] ([MaCM], [TenCM], [GhiChu]) VALUES (N'CM002', N'Quản Lý', N'Không')
INSERT [dbo].[tblDonVi] ([MaDV], [TenDV], [GhiChu]) VALUES (N'DV001', N'Văn Phòng', N'Không')
INSERT [dbo].[tblDonVi] ([MaDV], [TenDV], [GhiChu]) VALUES (N'DV002', N'Phòng Tổ chức lao động', N'Không')
INSERT [dbo].[tblDonVi] ([MaDV], [TenDV], [GhiChu]) VALUES (N'DV003', N'Phòng Kế toán - Tài chính', N'Không')
INSERT [dbo].[tblDonVi] ([MaDV], [TenDV], [GhiChu]) VALUES (N'DV004', N'Phòng Vật tư', N'Không')
INSERT [dbo].[tblDonVi] ([MaDV], [TenDV], [GhiChu]) VALUES (N'DV005', N'Phòng Kế hoạch - Tiêu thụ', N'Không')
INSERT [dbo].[tblDonVi] ([MaDV], [TenDV], [GhiChu]) VALUES (N'DV006', N'Phòng Điều hành sản xuất', N'Không')
INSERT [dbo].[tblDonVi] ([MaDV], [TenDV], [GhiChu]) VALUES (N'DV007', N'Phòng Thanh tra BVQS', N'Không')
INSERT [dbo].[tblLuong] ([MaNV], [HoTen], [MaLuong], [MaChuyenMon], [LuongCoBan], [PCChucVu], [NgayNhap], [LuongCBMoi], [NgaySua], [LyDo]) VALUES (N'001', N'Nguyễn Thành Nghiệp', N'L001', N'CM001', 45000000, 5000000, CAST(0x0000A60E00000000 AS DateTime), 0, CAST(0x0000A60E00000000 AS DateTime), N'Không')
INSERT [dbo].[tblLuong] ([MaNV], [HoTen], [MaLuong], [MaChuyenMon], [LuongCoBan], [PCChucVu], [NgayNhap], [LuongCBMoi], [NgaySua], [LyDo]) VALUES (N'002', N'Đào Công Tuấn', N'L002', N'CM001', 10000000, 1000000, CAST(0x0000A60100000000 AS DateTime), 15000000, CAST(0x0000A60200000000 AS DateTime), N'Lên Chức')
INSERT [dbo].[tblLuong] ([MaNV], [HoTen], [MaLuong], [MaChuyenMon], [LuongCoBan], [PCChucVu], [NgayNhap], [LuongCBMoi], [NgaySua], [LyDo]) VALUES (N'003', N'Trần Nguyễn Trọng Tuyển', N'L003', N'CM002', 6000000, 2000000, CAST(0x0000A60100000000 AS DateTime), 12000000, CAST(0x0000A60100000000 AS DateTime), N'Xấu trai')
INSERT [dbo].[tblLuong] ([MaNV], [HoTen], [MaLuong], [MaChuyenMon], [LuongCoBan], [PCChucVu], [NgayNhap], [LuongCBMoi], [NgaySua], [LyDo]) VALUES (N'004', N'Lê Tấn Sỷ', N'L004', N'CM002', 8000000, 1500000, CAST(0x0000A58000000000 AS DateTime), 0, CAST(0x0000A58000000000 AS DateTime), N'Không')
INSERT [dbo].[tblLuong] ([MaNV], [HoTen], [MaLuong], [MaChuyenMon], [LuongCoBan], [PCChucVu], [NgayNhap], [LuongCBMoi], [NgaySua], [LyDo]) VALUES (N'005', N'Nguyễn Thị Phương Uyên', N'L005', N'CM002', 5000000, 500000, CAST(0x0000A60100000000 AS DateTime), 7000000, CAST(0x0000A60100000000 AS DateTime), N'Không')
INSERT [dbo].[tblLuong] ([MaNV], [HoTen], [MaLuong], [MaChuyenMon], [LuongCoBan], [PCChucVu], [NgayNhap], [LuongCBMoi], [NgaySua], [LyDo]) VALUES (N'006', N'Nguyễn Xuân Nhật', N'L006', N'CM002', 50000000, 0, CAST(0x0000A61100000000 AS DateTime), 0, CAST(0x0000A61100000000 AS DateTime), N'Không')
INSERT [dbo].[tblThueThuNhapCaNhan] ([MaThue], [MaNV], [CoQuanQuanLyThue], [MaLuong], [SoTien], [NgayDangKi], [GhiChu]) VALUES (N'T001', N'001', N'Cục Thuế Hà Nội', N'L001', 8000000, CAST(0x0000A60E00000000 AS DateTime), N'Không Có')
INSERT [dbo].[tblThueThuNhapCaNhan] ([MaThue], [MaNV], [CoQuanQuanLyThue], [MaLuong], [SoTien], [NgayDangKi], [GhiChu]) VALUES (N'T002', N'002', N'Cục Thuế TPHCM', N'L002', 750000, CAST(0x0000A6DA00000000 AS DateTime), N'Không Có')
INSERT [dbo].[tblThueThuNhapCaNhan] ([MaThue], [MaNV], [CoQuanQuanLyThue], [MaLuong], [SoTien], [NgayDangKi], [GhiChu]) VALUES (N'T003', N'003', N'Cục Thuế TPHCM', N'L003', 350000, CAST(0x0000A6DA00000000 AS DateTime), N'Không Có')
INSERT [dbo].[tblThueThuNhapCaNhan] ([MaThue], [MaNV], [CoQuanQuanLyThue], [MaLuong], [SoTien], [NgayDangKi], [GhiChu]) VALUES (N'T004', N'004', N'Cục Thuế TPHCM', N'L004', 550000, CAST(0x0000A6DA00000000 AS DateTime), N'Không Có')
INSERT [dbo].[tblThueThuNhapCaNhan] ([MaThue], [MaNV], [CoQuanQuanLyThue], [MaLuong], [SoTien], [NgayDangKi], [GhiChu]) VALUES (N'T005', N'005', N'Cục Thuế TPHCM', N'L005', 250000, CAST(0x0000A6DA00000000 AS DateTime), N'Không Có')
INSERT [dbo].[tblThueThuNhapCaNhan] ([MaThue], [MaNV], [CoQuanQuanLyThue], [MaLuong], [SoTien], [NgayDangKi], [GhiChu]) VALUES (N'T006', N'006', N'Cục Thuế Hà Nội', N'L006', 6475000, CAST(0x0000A60E00000000 AS DateTime), N'Không Có')
INSERT [dbo].[tblTrinhDo] ([TenTrinhDo], [GhiChu]) VALUES (N'CĐ', N'Cao Đẳng')
INSERT [dbo].[tblTrinhDo] ([TenTrinhDo], [GhiChu]) VALUES (N'CH', N'Cao Học')
INSERT [dbo].[tblTrinhDo] ([TenTrinhDo], [GhiChu]) VALUES (N'ĐH', N'Đại Học')
INSERT [dbo].[tblTTNhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CMND], [NoiSinh], [DiaChi], [SDT], [TDHV], [MaBHXH], [MaLuong], [MaDonVi], [MaThue], [ChuyenMon], [Email], [GhiChu], [DanToc], [TonGiao], [QuocTich]) VALUES (N'001', N'Nguyễn Thành Nghiệp', CAST(0x0000A60E00000000 AS DateTime), N'Nam', N'212823303   ', N'Bình Định', N'TP HCM', N'0306172360 ', N'ĐH', N'BH001', N'L001', N'DV003', N'T001', N'CEO', N'nguyennghiep@gmail.com', N'Không Có', N'Kinh', N'Không', N'Việt Nam')
INSERT [dbo].[tblTTNhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CMND], [NoiSinh], [DiaChi], [SDT], [TDHV], [MaBHXH], [MaLuong], [MaDonVi], [MaThue], [ChuyenMon], [Email], [GhiChu], [DanToc], [TonGiao], [QuocTich]) VALUES (N'003', N'ĐÀo Công Tuấn', CAST(0x0000884600000000 AS DateTime), N'Nam', N'215487745   ', N'Bình Định', N'TP HCM', N'0356985471 ', N'CĐ', N'BH003', N'L003', N'DV007', N'T003', N'Quản Lý', N'congtuan@gmail.com', N'Đẹp Trai ', N'Kinh', N'Không', N'Việt Nam')
INSERT [dbo].[tblTTNhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CMND], [NoiSinh], [DiaChi], [SDT], [TDHV], [MaBHXH], [MaLuong], [MaDonVi], [MaThue], [ChuyenMon], [Email], [GhiChu], [DanToc], [TonGiao], [QuocTich]) VALUES (N'004', N'Trần Nguyễn Trọng Tuyển', CAST(0x0000A60100000000 AS DateTime), N'Nam', N'242523652   ', N'Bến Tre ', N'TP HCM', N'0365655214 ', N'ĐH', N'BH004', N'L004', N'DV002', N'', N'Kế Toán', N'trongtuyen@gmail.com', N'Không', N'Kinh', N'Không', N'Việt Nam')
INSERT [dbo].[tblTTNhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CMND], [NoiSinh], [DiaChi], [SDT], [TDHV], [MaBHXH], [MaLuong], [MaDonVi], [MaThue], [ChuyenMon], [Email], [GhiChu], [DanToc], [TonGiao], [QuocTich]) VALUES (N'005', N'Nguyễn Thị Phương Uyên', CAST(0x0000806800000000 AS DateTime), N'Nữ', N'212823367   ', N'Huế ', N'TP.HCM', N'0367899877 ', N'ĐH', N'BH005', N'L005', N'DV001', N'T005', N'Bán Hàng', N'phuonguyen@ittc.com', N'Không', N'Kinh', N'Không', N'Việt Nam')
INSERT [dbo].[tblTTNhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [CMND], [NoiSinh], [DiaChi], [SDT], [TDHV], [MaBHXH], [MaLuong], [MaDonVi], [MaThue], [ChuyenMon], [Email], [GhiChu], [DanToc], [TonGiao], [QuocTich]) VALUES (N'006', N'Nguyễn Xuân Nhật', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'L006', NULL, N'T00', N'Quản Lý', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblUser] ([ID], [Password], [PhanQuyen]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[tblUser] ([ID], [Password], [PhanQuyen]) VALUES (N'admin', N'123', 2)
INSERT [dbo].[tblUser] ([ID], [Password], [PhanQuyen]) VALUES (N'admin', N'123456', 3)
INSERT [dbo].[tblUser] ([ID], [Password], [PhanQuyen]) VALUES (N'nghiep', N'123', 1)
INSERT [dbo].[tblUser] ([ID], [Password], [PhanQuyen]) VALUES (N'nghiep', N'nghiep', 2)
INSERT [dbo].[tblUser] ([ID], [Password], [PhanQuyen]) VALUES (N'tuan', N'tuan', 3)
INSERT [dbo].[tblUser] ([ID], [Password], [PhanQuyen]) VALUES (N'tuan', N'123', 3)

ALTER TABLE [dbo].[tblTTNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblTTNhanVien_tblLuong] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblLuong] ([MaNV])
GO
ALTER TABLE [dbo].[tblTTNhanVien] CHECK CONSTRAINT [FK_tblTTNhanVien_tblLuong]
GO
USE [master]
GO
ALTER DATABASE [QuanLiNhanSu] SET  READ_WRITE 
GO
