USE [QUANLIKARAOKE]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonBan]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonBan](
	[IDHoaDon] [bigint] NOT NULL,
	[IDMatHang] [int] NOT NULL,
	[SL] [int] NULL,
	[DonGiaBan] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDonNhap]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDonNhap](
	[IDHoaDon] [bigint] NOT NULL,
	[IDMatHang] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC,
	[IDMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDVT] [nvarchar](30) NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBanHang]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanHang](
	[IDHoaDon] [bigint] IDENTITY(1,1) NOT NULL,
	[IDPhong] [int] NULL,
	[ThoiGianBDau] [datetime] NULL,
	[ThoiGianKThuc] [datetime] NULL,
	[DonGiaPhong] [int] NULL,
	[NguoiBan] [varchar](30) NULL,
	[NgayTao] [datetime] NULL,
	[Nguoitao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_HoaDonBanHang] PRIMARY KEY CLUSTERED 
(
	[IDHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[NhanVienNhap] [varchar](30) NOT NULL,
	[IDNhaCC] [int] NULL,
	[NgayNhap] [datetime] NOT NULL,
	[DaNhap] [tinyint] NULL,
	[TienThanhToan] [int] NULL,
	[NgayTao] [datetime] NOT NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lapdat]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lapdat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPhong] [int] NULL,
	[IDThietBi] [int] NULL,
	[SLLapdat] [int] NULL,
	[NgayLapdat] [datetime] NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_Lapdat] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NOT NULL,
	[DonGia] [int] NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [nchar](10) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThietBi]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThietBi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiTB] [nvarchar](50) NULL,
	[Mota] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiThietBi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenMatHang] [nvarchar](50) NOT NULL,
	[DVT] [int] NULL,
	[DonGiaBan] [int] NOT NULL,
	[Tile] [int] NULL,
	[IdCha] [int] NULL,
	[Nguoitao] [varchar](30) NULL,
	[Ngaytao] [datetime] NULL,
	[NguoiCapNhat] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
 CONSTRAINT [PK_MatHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](50) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[Email] [varchar](150) NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[HoVaTen] [nvarchar](50) NULL,
	[DienThoai] [varchar](10) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[ChucVu] [varchar](20) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhaptb]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhaptb](
	[IDHD] [bigint] NOT NULL,
	[IDThietbi] [nchar](10) NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [int] NULL,
 CONSTRAINT [PK_Nhaptb] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[IDLoaiPhong] [int] NULL,
	[SucChua] [int] NULL,
	[TrangThai] [tinyint] NULL,
	[NgayTao] [datetime] NULL,
	[NguoiTao] [varchar](30) NULL,
	[NgayCapNhat] [datetime] NULL,
	[NguoiCapNhat] [varchar](50) NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDLoaiTB] [int] NULL,
	[TenThietBi] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[Mausac] [nvarchar](50) NULL,
	[Kichthuoc] [varchar](50) NULL,
 CONSTRAINT [PK_ThietBi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhLuong]    Script Date: 4/22/2023 4:18:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhLuong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDusername] [varchar](30) NOT NULL,
	[Ngaybatdau] [datetime] NULL,
	[LuongCB] [int] NULL,
	[Dathanhtoan] [tinyint] NULL,
	[songaynghi] [int] NULL,
 CONSTRAINT [PK_TinhLuong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGiaBan]) VALUES (13, 1, 1, 20000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGiaBan]) VALUES (13, 2, 10, 15000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGiaBan]) VALUES (13, 4, 20, 25000)
INSERT [dbo].[ChiTietHoaDonBan] ([IDHoaDon], [IDMatHang], [SL], [DonGiaBan]) VALUES (15, 5, 10, 15000)
GO
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (1, 1, 10, 200000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (1, 2, 20, 25000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (1, 4, 200, 25000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (2, 1, 100, 15000)
INSERT [dbo].[ChiTietHoaDonNhap] ([IDHoaDon], [IDMatHang], [SoLuong], [DonGiaNhap]) VALUES (2, 5, 20, 15000)
GO
SET IDENTITY_INSERT [dbo].[DonViTinh] ON 

INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'Cái', CAST(N'2023-04-10T22:54:39.873' AS DateTime), N'admin', CAST(N'2023-04-11T08:52:38.310' AS DateTime), N'admin')
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (3, N'lon', CAST(N'2023-04-13T08:55:22.147' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (4, N'thùng', CAST(N'2023-04-13T08:55:31.187' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[DonViTinh] ([ID], [TenDVT], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (5, N'đĩa', CAST(N'2023-04-13T08:55:36.613' AS DateTime), N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[DonViTinh] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonBanHang] ON 

INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [Nguoitao], [NgayCapNhat], [NguoiCapNhat]) VALUES (13, 8, CAST(N'2022-04-12T14:04:00.000' AS DateTime), CAST(N'2023-04-17T20:34:00.000' AS DateTime), 100000, N'admin', NULL, N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [Nguoitao], [NgayCapNhat], [NguoiCapNhat]) VALUES (14, 8, CAST(N'2023-04-09T21:26:00.000' AS DateTime), CAST(N'2023-04-09T21:26:00.000' AS DateTime), 100000, N'admin', NULL, N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [Nguoitao], [NgayCapNhat], [NguoiCapNhat]) VALUES (15, 11, CAST(N'2023-04-13T21:27:00.000' AS DateTime), CAST(N'2023-04-17T22:09:00.000' AS DateTime), 100000, N'admin', NULL, N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [Nguoitao], [NgayCapNhat], [NguoiCapNhat]) VALUES (16, 8, CAST(N'2023-04-16T18:16:00.000' AS DateTime), CAST(N'2023-04-16T18:16:00.000' AS DateTime), 100000, N'admin', NULL, N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [Nguoitao], [NgayCapNhat], [NguoiCapNhat]) VALUES (17, 8, CAST(N'2023-04-17T10:13:00.000' AS DateTime), CAST(N'2023-04-17T10:13:00.000' AS DateTime), 100000, N'admin', NULL, N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [Nguoitao], [NgayCapNhat], [NguoiCapNhat]) VALUES (18, 8, CAST(N'2023-04-17T11:03:00.000' AS DateTime), CAST(N'2023-04-17T11:03:00.000' AS DateTime), 100000, N'admin', NULL, N'admin', NULL, NULL)
INSERT [dbo].[HoaDonBanHang] ([IDHoaDon], [IDPhong], [ThoiGianBDau], [ThoiGianKThuc], [DonGiaPhong], [NguoiBan], [NgayTao], [Nguoitao], [NgayCapNhat], [NguoiCapNhat]) VALUES (19, 11, CAST(N'2023-04-17T22:08:00.000' AS DateTime), CAST(N'2023-04-17T22:08:00.000' AS DateTime), 100000, N'admin', NULL, N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[HoaDonBanHang] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDonNhap] ON 

INSERT [dbo].[HoaDonNhap] ([ID], [NhanVienNhap], [IDNhaCC], [NgayNhap], [DaNhap], [TienThanhToan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'sa', 2, CAST(N'2023-05-11T00:00:00.000' AS DateTime), 1, 1000000, CAST(N'2023-04-11T16:35:19.290' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[HoaDonNhap] ([ID], [NhanVienNhap], [IDNhaCC], [NgayNhap], [DaNhap], [TienThanhToan], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (2, N'sas', 4, CAST(N'2023-06-17T00:00:00.000' AS DateTime), 1, 30000, CAST(N'2023-04-17T15:07:17.623' AS DateTime), N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[HoaDonNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiPhong] ON 

INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'Phòng thường', 100000, CAST(N'2023-04-11T13:09:29.097' AS DateTime), N'admin     ', NULL, NULL)
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (3, N'Phòng ViP', 400000, CAST(N'2023-04-11T14:27:52.833' AS DateTime), N'admin     ', CAST(N'2023-04-13T14:28:29.263' AS DateTime), N'admin')
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (4, N'Phòng đặc biệt', 500000, CAST(N'2023-04-13T14:28:16.780' AS DateTime), N'admin     ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[LoaiPhong] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiThietBi] ON 

INSERT [dbo].[LoaiThietBi] ([ID], [TenLoaiTB], [Mota]) VALUES (1, N'Loa', NULL)
INSERT [dbo].[LoaiThietBi] ([ID], [TenLoaiTB], [Mota]) VALUES (2, N'Micro', NULL)
INSERT [dbo].[LoaiThietBi] ([ID], [TenLoaiTB], [Mota]) VALUES (3, N'Máy karaoke', NULL)
INSERT [dbo].[LoaiThietBi] ([ID], [TenLoaiTB], [Mota]) VALUES (4, N'Amplifier', NULL)
INSERT [dbo].[LoaiThietBi] ([ID], [TenLoaiTB], [Mota]) VALUES (5, N'Đèn karaoke', NULL)
INSERT [dbo].[LoaiThietBi] ([ID], [TenLoaiTB], [Mota]) VALUES (6, N'Ghế karaoke', NULL)
INSERT [dbo].[LoaiThietBi] ([ID], [TenLoaiTB], [Mota]) VALUES (7, N'TV', NULL)
SET IDENTITY_INSERT [dbo].[LoaiThietBi] OFF
GO
SET IDENTITY_INSERT [dbo].[MatHang] ON 

INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [Tile], [IdCha], [Nguoitao], [Ngaytao], [NguoiCapNhat], [NgayCapNhat]) VALUES (1, N'Kem', 1, 20000, NULL, NULL, N'admin', CAST(N'2023-04-11T09:29:44.207' AS DateTime), N'admin', CAST(N'2023-04-11T09:46:27.937' AS DateTime))
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [Tile], [IdCha], [Nguoitao], [Ngaytao], [NguoiCapNhat], [NgayCapNhat]) VALUES (2, N'bia333', 3, 15000, NULL, NULL, N'admin', CAST(N'2023-04-13T08:59:35.617' AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [Tile], [IdCha], [Nguoitao], [Ngaytao], [NguoiCapNhat], [NgayCapNhat]) VALUES (3, N'Bia sài gòn', 3, 20000, NULL, NULL, N'admin', CAST(N'2023-04-13T08:59:54.113' AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [Tile], [IdCha], [Nguoitao], [Ngaytao], [NguoiCapNhat], [NgayCapNhat]) VALUES (4, N'xoài xanh', 5, 25000, NULL, NULL, N'admin', CAST(N'2023-04-13T09:00:09.590' AS DateTime), NULL, NULL)
INSERT [dbo].[MatHang] ([ID], [TenMatHang], [DVT], [DonGiaBan], [Tile], [IdCha], [Nguoitao], [Ngaytao], [NguoiCapNhat], [NgayCapNhat]) VALUES (5, N'Coca', 3, 15000, NULL, NULL, N'admin', CAST(N'2023-04-17T21:58:26.667' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[MatHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([ID], [TenNCC], [DienThoai], [DiaChi], [Email], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (1, N'Rau củ Hà AN', N'0123456781', N'Hưng Yên', N'hy@gmail.com', CAST(N'2023-04-11T14:45:59.787' AS DateTime), NULL, CAST(N'2023-04-13T21:29:13.517' AS DateTime), N'admin')
INSERT [dbo].[NhaCungCap] ([ID], [TenNCC], [DienThoai], [DiaChi], [Email], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (2, N'NCC1', N'01234567890', N'Hưng Yên', N'a@gmail.com', CAST(N'2023-04-11T14:54:41.770' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[NhaCungCap] ([ID], [TenNCC], [DienThoai], [DiaChi], [Email], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (4, N'Bia Hà Nội', N'0123456789', N'Hưng Yên', N'hy@gmail.com', CAST(N'2023-04-13T21:28:45.653' AS DateTime), N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
GO
INSERT [dbo].[NhanVien] ([Username], [Password], [HoVaTen], [DienThoai], [DiaChi], [ChucVu]) VALUES (N'sa', N'1234', N'Nguyễn Văn A', N'0123456789', N'Hưng Yên', N'nhanvien')
INSERT [dbo].[NhanVien] ([Username], [Password], [HoVaTen], [DienThoai], [DiaChi], [ChucVu]) VALUES (N'sa1', N'1234', N'Nguyễn Văn AC', N'0123456789', N'Hưng Yên', N'admin')
INSERT [dbo].[NhanVien] ([Username], [Password], [HoVaTen], [DienThoai], [DiaChi], [ChucVu]) VALUES (N'sa12', N'1234', N'Nguyễn Văn Ba', N'0123456789', N'Hưng Yên', N'nhanvien')
INSERT [dbo].[NhanVien] ([Username], [Password], [HoVaTen], [DienThoai], [DiaChi], [ChucVu]) VALUES (N'sas', N'1234', N'Nguyễn Văn B', N'0123456789', N'Hưng Yên', N'nhanvien')
GO
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SucChua], [TrangThai], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (7, N'kr101', 3, 5, NULL, CAST(N'2023-04-13T09:13:11.717' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SucChua], [TrangThai], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (8, N'kr201', 1, 5, 0, CAST(N'2023-04-13T09:14:32.073' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SucChua], [TrangThai], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (9, N'kr102', 3, 10, NULL, CAST(N'2023-04-13T09:14:52.020' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SucChua], [TrangThai], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (10, N'kr103', 3, 10, 0, CAST(N'2023-04-13T09:15:02.053' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SucChua], [TrangThai], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (11, N'kr202', 1, 8, 0, CAST(N'2023-04-13T09:15:10.917' AS DateTime), N'admin', NULL, NULL)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [SucChua], [TrangThai], [NgayTao], [NguoiTao], [NgayCapNhat], [NguoiCapNhat]) VALUES (12, N'kr203', 1, 10, NULL, CAST(N'2023-04-13T09:15:23.497' AS DateTime), N'admin', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Phong] OFF
GO
SET IDENTITY_INSERT [dbo].[TinhLuong] ON 

INSERT [dbo].[TinhLuong] ([ID], [IDusername], [Ngaybatdau], [LuongCB], [Dathanhtoan], [songaynghi]) VALUES (1, N'sa12', CAST(N'2023-04-11T14:19:00.000' AS DateTime), 150000, 1, 1)
SET IDENTITY_INSERT [dbo].[TinhLuong] OFF
GO
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[DonViTinh] ADD  CONSTRAINT [DF_DonViTinh_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NgayNhap]  DEFAULT (getdate()) FOR [NgayNhap]
GO
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[HoaDonNhap] ADD  CONSTRAINT [DF_HoaDonNhap_NguoiCapNhat]  DEFAULT (getdate()) FOR [NguoiCapNhat]
GO
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [DF_MatHang_Nguoitao]  DEFAULT ('admin') FOR [Nguoitao]
GO
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [DF_MatHang_Ngaytao]  DEFAULT (getdate()) FOR [Ngaytao]
GO
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [DF_MatHang_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
ALTER TABLE [dbo].[MatHang] ADD  CONSTRAINT [DF_MatHang_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  CONSTRAINT [DF_NhaCungCap_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_TrangThai]  DEFAULT ((1)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_NguoiTao]  DEFAULT ('admin') FOR [NguoiTao]
GO
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[Phong] ADD  CONSTRAINT [DF_Phong_NguoiCapNhat]  DEFAULT ('admin') FOR [NguoiCapNhat]
GO
ALTER TABLE [dbo].[TinhLuong] ADD  CONSTRAINT [DF_TinhLuong_Ngaybatdau]  DEFAULT (getdate()) FOR [Ngaybatdau]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBan_HoaDonBanHang] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDonBanHang] ([IDHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan] CHECK CONSTRAINT [FK_ChiTietHoaDonBan_HoaDonBanHang]
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonBan_MatHang] FOREIGN KEY([IDMatHang])
REFERENCES [dbo].[MatHang] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDonBan] CHECK CONSTRAINT [FK_ChiTietHoaDonBan_MatHang]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDonNhap] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_HoaDonNhap]
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDonNhap_MatHang] FOREIGN KEY([IDMatHang])
REFERENCES [dbo].[MatHang] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDonNhap] CHECK CONSTRAINT [FK_ChiTietHoaDonNhap_MatHang]
GO
ALTER TABLE [dbo].[HoaDonBanHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanHang_Phong] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[Phong] ([ID])
GO
ALTER TABLE [dbo].[HoaDonBanHang] CHECK CONSTRAINT [FK_HoaDonBanHang_Phong]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhaCungCap] FOREIGN KEY([IDNhaCC])
REFERENCES [dbo].[NhaCungCap] ([ID])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[Lapdat]  WITH CHECK ADD  CONSTRAINT [FK_Lapdat_Phong] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[Phong] ([ID])
GO
ALTER TABLE [dbo].[Lapdat] CHECK CONSTRAINT [FK_Lapdat_Phong]
GO
ALTER TABLE [dbo].[Lapdat]  WITH CHECK ADD  CONSTRAINT [FK_Lapdat_ThietBi] FOREIGN KEY([IDThietBi])
REFERENCES [dbo].[ThietBi] ([ID])
GO
ALTER TABLE [dbo].[Lapdat] CHECK CONSTRAINT [FK_Lapdat_ThietBi]
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_DonViTinh] FOREIGN KEY([DVT])
REFERENCES [dbo].[DonViTinh] ([ID])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_DonViTinh]
GO
ALTER TABLE [dbo].[Nhaptb]  WITH CHECK ADD  CONSTRAINT [FK_Nhaptb_HoaDonNhap] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HoaDonNhap] ([ID])
GO
ALTER TABLE [dbo].[Nhaptb] CHECK CONSTRAINT [FK_Nhaptb_HoaDonNhap]
GO
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_LoaiPhong] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([ID])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_LoaiPhong]
GO
ALTER TABLE [dbo].[ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_LoaiThietBi] FOREIGN KEY([IDLoaiTB])
REFERENCES [dbo].[LoaiThietBi] ([ID])
GO
ALTER TABLE [dbo].[ThietBi] CHECK CONSTRAINT [FK_ThietBi_LoaiThietBi]
GO
ALTER TABLE [dbo].[TinhLuong]  WITH CHECK ADD  CONSTRAINT [FK_TinhLuong_NhanVien] FOREIGN KEY([IDusername])
REFERENCES [dbo].[NhanVien] ([Username])
GO
ALTER TABLE [dbo].[TinhLuong] CHECK CONSTRAINT [FK_TinhLuong_NhanVien]
GO
