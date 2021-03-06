USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 20/07/2020 11:27:23 ******/
CREATE DATABASE [QuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\QuanLyThuVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\QuanLyThuVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyThuVien', N'ON'
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE = OFF
GO
USE [QuanLyThuVien]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[docgia]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[docgia](
	[madocgia] [nvarchar](8) NOT NULL,
	[tendocgia] [nvarchar](20) NOT NULL,
	[gioitinh] [nvarchar](20) NULL,
	[diachi] [nvarchar](20) NULL,
 CONSTRAINT [pk_docgia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ke]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ke](
	[make] [nvarchar](8) NOT NULL,
	[tenke] [nvarchar](20) NULL,
 CONSTRAINT [pk_ke] PRIMARY KEY CLUSTERED 
(
	[make] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[loaisach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaisach](
	[maloaisach] [nvarchar](20) NOT NULL,
	[tenloaisach] [nvarchar](20) NOT NULL,
 CONSTRAINT [pk_loaisach] PRIMARY KEY CLUSTERED 
(
	[maloaisach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[manhanvien] [nvarchar](8) NOT NULL,
	[taikhoan] [nvarchar](20) NOT NULL,
	[matkhau] [nvarchar](20) NOT NULL,
	[loai] [nvarchar](20) NOT NULL,
	[tennhanvien] [nvarchar](20) NOT NULL,
	[diachi] [nvarchar](20) NULL,
	[sex] [nvarchar](20) NULL,
 CONSTRAINT [pk_nhanvien] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phieumuon]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phieumuon](
	[maphieumuon] [nvarchar](8) NOT NULL,
	[ngaymuon] [date] NOT NULL,
	[hanngaytra] [date] NOT NULL,
	[manhanvien] [nvarchar](8) NOT NULL,
	[masach] [nvarchar](8) NOT NULL,
	[soluong] [int] NULL,
	[madocgia] [nvarchar](8) NOT NULL,
	[trangthai] [nvarchar](20) NOT NULL,
 CONSTRAINT [pk_phieumuon] PRIMARY KEY CLUSTERED 
(
	[maphieumuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sach](
	[masach] [nvarchar](8) NOT NULL,
	[tensach] [nvarchar](20) NULL,
	[maloaisach] [nvarchar](20) NOT NULL,
	[soluong] [int] NULL,
	[make] [nvarchar](8) NOT NULL,
 CONSTRAINT [pk_sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[docgia] ([madocgia], [tendocgia], [gioitinh], [diachi]) VALUES (N'KH111', N'Vo Quoc Tuan', N'nam', N'Duc Linh')
INSERT [dbo].[docgia] ([madocgia], [tendocgia], [gioitinh], [diachi]) VALUES (N'KH112', N'Tien Hoa', N'nam', N'Ham Tan')
INSERT [dbo].[docgia] ([madocgia], [tendocgia], [gioitinh], [diachi]) VALUES (N'KH113', N'Quan AP', N'nam', N'Ha Noi')
INSERT [dbo].[docgia] ([madocgia], [tendocgia], [gioitinh], [diachi]) VALUES (N'KH114', N'Jack', N'nu', N'Long An')
INSERT [dbo].[docgia] ([madocgia], [tendocgia], [gioitinh], [diachi]) VALUES (N'KH115', N'Phan Thanh Hoài', N'Nam', N'Thu Duc')
INSERT [dbo].[docgia] ([madocgia], [tendocgia], [gioitinh], [diachi]) VALUES (N'KH116', N'Trường Trẻ Trâu', N'Nam', N'Thu Duc')
INSERT [dbo].[ke] ([make], [tenke]) VALUES (N'KE001', N'Ke01')
INSERT [dbo].[ke] ([make], [tenke]) VALUES (N'KE002', N'Ke02')
INSERT [dbo].[ke] ([make], [tenke]) VALUES (N'KE003', N'Ke03')
INSERT [dbo].[loaisach] ([maloaisach], [tenloaisach]) VALUES (N'LS001', N'ThamKhao')
INSERT [dbo].[loaisach] ([maloaisach], [tenloaisach]) VALUES (N'LS002', N'Tieu Thuyet')
INSERT [dbo].[loaisach] ([maloaisach], [tenloaisach]) VALUES (N'LS003', N'Sách Nau An')
INSERT [dbo].[loaisach] ([maloaisach], [tenloaisach]) VALUES (N'LS004', N'Truyen')
INSERT [dbo].[loaisach] ([maloaisach], [tenloaisach]) VALUES (N'LS005', N'Thieu Nhi')
INSERT [dbo].[loaisach] ([maloaisach], [tenloaisach]) VALUES (N'LS006', N'SGK')
INSERT [dbo].[nhanvien] ([manhanvien], [taikhoan], [matkhau], [loai], [tennhanvien], [diachi], [sex]) VALUES (N'NV01', N'hoa1234', N'1234', N'1', N'Phan Thanh Hoai', N'Binh Dinh', N'Nam')
INSERT [dbo].[nhanvien] ([manhanvien], [taikhoan], [matkhau], [loai], [tennhanvien], [diachi], [sex]) VALUES (N'NV02', N'hoa1235', N'1234', N'2', N'Le Tien Hoa', N'Ninh Thuan', N'Nu')
INSERT [dbo].[nhanvien] ([manhanvien], [taikhoan], [matkhau], [loai], [tennhanvien], [diachi], [sex]) VALUES (N'NV03', N'hoa1236', N'1234', N'3', N'Nhat Nguyen', N'Khanh Hoa', N'Nam')
INSERT [dbo].[phieumuon] ([maphieumuon], [ngaymuon], [hanngaytra], [manhanvien], [masach], [soluong], [madocgia], [trangthai]) VALUES (N'1', CAST(N'2020-07-17' AS Date), CAST(N'2020-07-18' AS Date), N'NV01', N'1', 1, N'KH111', N'1')
INSERT [dbo].[phieumuon] ([maphieumuon], [ngaymuon], [hanngaytra], [manhanvien], [masach], [soluong], [madocgia], [trangthai]) VALUES (N'2', CAST(N'2020-07-17' AS Date), CAST(N'2020-07-18' AS Date), N'NV03', N'3', 1, N'KH113', N'1')
INSERT [dbo].[phieumuon] ([maphieumuon], [ngaymuon], [hanngaytra], [manhanvien], [masach], [soluong], [madocgia], [trangthai]) VALUES (N'3', CAST(N'2020-07-17' AS Date), CAST(N'2020-07-18' AS Date), N'NV01', N'6', 1, N'KH114', N'1')
INSERT [dbo].[sach] ([masach], [tensach], [maloaisach], [soluong], [make]) VALUES (N'1', N'Toan', N'LS001', 13, N'KE001')
INSERT [dbo].[sach] ([masach], [tensach], [maloaisach], [soluong], [make]) VALUES (N'2', N'Anh', N'LS001', 11, N'KE001')
INSERT [dbo].[sach] ([masach], [tensach], [maloaisach], [soluong], [make]) VALUES (N'3', N'Van', N'LS001', 12, N'KE001')
INSERT [dbo].[sach] ([masach], [tensach], [maloaisach], [soluong], [make]) VALUES (N'4', N'Conan', N'LS004', 12, N'KE002')
INSERT [dbo].[sach] ([masach], [tensach], [maloaisach], [soluong], [make]) VALUES (N'5', N'Bay Vien  Ngoc Rong', N'LS004', 12, N'KE002')
INSERT [dbo].[sach] ([masach], [tensach], [maloaisach], [soluong], [make]) VALUES (N'6', N'Naruto', N'LS004', 11, N'KE002')
INSERT [dbo].[sach] ([masach], [tensach], [maloaisach], [soluong], [make]) VALUES (N'7', N'Chuc Be Ngu Ngon', N'LS005', 12, N'KE001')
ALTER TABLE [dbo].[phieumuon]  WITH CHECK ADD  CONSTRAINT [ck_phieumuon_kh] FOREIGN KEY([madocgia])
REFERENCES [dbo].[docgia] ([madocgia])
GO
ALTER TABLE [dbo].[phieumuon] CHECK CONSTRAINT [ck_phieumuon_kh]
GO
ALTER TABLE [dbo].[phieumuon]  WITH CHECK ADD  CONSTRAINT [ck_phieumuon_nv] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[phieumuon] CHECK CONSTRAINT [ck_phieumuon_nv]
GO
ALTER TABLE [dbo].[phieumuon]  WITH CHECK ADD  CONSTRAINT [ck_phieumuon_s] FOREIGN KEY([masach])
REFERENCES [dbo].[sach] ([masach])
GO
ALTER TABLE [dbo].[phieumuon] CHECK CONSTRAINT [ck_phieumuon_s]
GO
ALTER TABLE [dbo].[phieumuon]  WITH NOCHECK ADD  CONSTRAINT [fk_phieumuon_docgia] FOREIGN KEY([madocgia])
REFERENCES [dbo].[docgia] ([madocgia])
GO
ALTER TABLE [dbo].[phieumuon] CHECK CONSTRAINT [fk_phieumuon_docgia]
GO
ALTER TABLE [dbo].[phieumuon]  WITH NOCHECK ADD  CONSTRAINT [fk_phieumuon_nhanvien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanvien] ([manhanvien])
GO
ALTER TABLE [dbo].[phieumuon] CHECK CONSTRAINT [fk_phieumuon_nhanvien]
GO
ALTER TABLE [dbo].[phieumuon]  WITH NOCHECK ADD  CONSTRAINT [fk_phieumuon_sach] FOREIGN KEY([masach])
REFERENCES [dbo].[sach] ([masach])
GO
ALTER TABLE [dbo].[phieumuon] CHECK CONSTRAINT [fk_phieumuon_sach]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [ck_sach_ke] FOREIGN KEY([make])
REFERENCES [dbo].[ke] ([make])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [ck_sach_ke]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [ck_sach_loaisach] FOREIGN KEY([maloaisach])
REFERENCES [dbo].[loaisach] ([maloaisach])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [ck_sach_loaisach]
GO
ALTER TABLE [dbo].[sach]  WITH NOCHECK ADD  CONSTRAINT [fk_sach_ke] FOREIGN KEY([make])
REFERENCES [dbo].[ke] ([make])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [fk_sach_ke]
GO
ALTER TABLE [dbo].[sach]  WITH NOCHECK ADD  CONSTRAINT [fk_sach_loaisach] FOREIGN KEY([maloaisach])
REFERENCES [dbo].[loaisach] ([maloaisach])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [fk_sach_loaisach]
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[dangnhap] (@tendangnhap nvarchar(20),@matkhau nvarchar(20))
as 
	select * from nhanvien where taikhoan=@tendangnhap and matkhau=@matkhau


GO
/****** Object:  StoredProcedure [dbo].[doimatkhau]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- Đổi mật khẩu

create proc [dbo].[doimatkhau] @mk nvarchar(20),@id nvarchar(8)
as
	begin 
	update nhanvien set matkhau=@mk where manhanvien=@id
	end


GO
/****** Object:  StoredProcedure [dbo].[kiemtradocgia]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--thêm một độc giả
----kiểm tra trước khi thêm
create proc [dbo].[kiemtradocgia](@madocgia nvarchar(8))
as
	select *from docgia where madocgia=@madocgia


GO
/****** Object:  StoredProcedure [dbo].[kiemtrake]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--kiem tra truoc khi them vao
create proc [dbo].[kiemtrake](@make nvarchar(8))
as
	select * from ke where make =@make


GO
/****** Object:  StoredProcedure [dbo].[kiemtraloaisach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--create proc thongtinkeid @idsach nvarchar(8)
--as
--	select * from  ke where make=@idsach
--go

--kiem tra truoc khi them vao
create proc [dbo].[kiemtraloaisach](@maloaisach nvarchar(20))
as
	select * from loaisach where maloaisach =@maloaisach


GO
/****** Object:  StoredProcedure [dbo].[kiemtranv]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--kiem tra truoc khi them vao
create proc [dbo].[kiemtranv](@manhanvien nvarchar(8))
as
	select * from nhanvien where manhanvien=@manhanvien


GO
/****** Object:  StoredProcedure [dbo].[kiemtraphieumuon]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- kiểm tra trước khi lập phiếu mượn
create proc [dbo].[kiemtraphieumuon](@maphieumuon nvarchar(8))
as
	select *from phieumuon where maphieumuon=@maphieumuon


GO
/****** Object:  StoredProcedure [dbo].[kiemtrasach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--kiem tra truoc khi them vao
create proc [dbo].[kiemtrasach](@masach nvarchar(8))
as
	select * from sach where masach =@masach


GO
/****** Object:  StoredProcedure [dbo].[phieumuonmkh]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--lay ma độc giả
create proc  [dbo].[phieumuonmkh]
as
	select madocgia from docgia


GO
/****** Object:  StoredProcedure [dbo].[phieumuonnv]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--lay ma nhan vien
create proc  [dbo].[phieumuonnv]
as
	select manhanvien from nhanvien


GO
/****** Object:  StoredProcedure [dbo].[phieumuons]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--lay ma sach
create proc  [dbo].[phieumuons]
as
	select masach from sach


GO
/****** Object:  StoredProcedure [dbo].[searchnv]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[searchnv] @id nvarchar(8)
as
	select * from nhanvien where manhanvien=@id


GO
/****** Object:  StoredProcedure [dbo].[suadocgia]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--sửa một độc giả

create proc [dbo].[suadocgia](@madocgia nvarchar(8),@tendocgia nvarchar(20),@gioitinh nvarchar(20),@diachi nvarchar(20))
	as
		begin
			update docgia set tendocgia= @tendocgia,
			gioitinh=@gioitinh,diachi=@diachi where madocgia=@madocgia
		end


GO
/****** Object:  StoredProcedure [dbo].[suake]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-- chinh sua ke
create proc [dbo].[suake](@make nvarchar(8),@tenke nvarchar(20))
	as
		begin
			update ke set tenke= @tenke
            where make=@make
		end


GO
/****** Object:  StoredProcedure [dbo].[sualoaisach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-- chinh sua ke
create proc [dbo].[sualoaisach](@maloaisach nvarchar(20),@tenloaisach nvarchar(20))
	as
		begin
			update loaisach set tenloaisach= @tenloaisach
            where maloaisach=@maloaisach
		end


GO
/****** Object:  StoredProcedure [dbo].[suanv]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--sửa nhân viên
create proc [dbo].[suanv] (@manhanvien nvarchar(8),@loai nvarchar(20),@tennv nvarchar(20),@diachi nvarchar(20),@sex nvarchar(20))
as
	begin
		update nhanvien set loai= @loai,
		tennhanvien= @tennv,diachi = @diachi ,sex=@sex where manhanvien =@manhanvien
	end


GO
/****** Object:  StoredProcedure [dbo].[suaphieumuon]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	   

--sửa phiếu xuất
create proc [dbo].[suaphieumuon](@maphieumuon nvarchar(8),@ngaymuon date,@hanngaytra date,@manhanvien nvarchar(8),
	@masach nvarchar(8),@madocgia nvarchar(8),@trangthai   nvarchar(20))
	as
		begin
			IF	1>(SELECT soluong FROM sach WHERE masach=@masach) THROW 50001,'Số lượng hàng trong kho không đủ!',1;
			IF	@maphieumuon = '' THROW 50001, 'Mã phiếu xuất không được để trống!', 1;
			IF	@madocgia = '' THROW 50001, 'Mã khách hàng không được để trống!', 1;
			IF	@manhanvien='' THROW 50001, 'Mã thủ kho không được để trống!', 1;
			IF	@ngaymuon ='' THROW 50001, 'Ngày không được để trống!', 1;
			IF	@hanngaytra ='' THROW 50001, 'Ngày không được để trống!', 1;
			IF	@trangthai ='' THROW 50001, 'Trạng thái không được để trống!', 1;
			update phieumuon set ngaymuon= @ngaymuon,
			hanngaytra=@hanngaytra,manhanvien= @manhanvien,masach= @masach,madocgia= @madocgia,trangthai= @trangthai where maphieumuon=@maphieumuon
		end


GO
/****** Object:  StoredProcedure [dbo].[suasach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-- chinh sua ke
create proc [dbo].[suasach](@masach	   nvarchar(8), 
		@tensach   nvarchar(20) ,    
		@maloaisach	nvarchar(20),
		@soluong     int,
		@make  nvarchar (8))
	as
		begin
			update sach set tensach=@tensach,maloaisach= @maloaisach,soluong=@soluong,make=@make
			where masach=@masach
		end


GO
/****** Object:  StoredProcedure [dbo].[themdocgia]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--kiem tra xong thi them thoi =))))

create proc [dbo].[themdocgia](@madocgia nvarchar(8),@tendocgia nvarchar(20),@gioitinh nvarchar(20),@diachi nvarchar(20))
	as
		begin
			insert into docgia values(@madocgia,@tendocgia,@gioitinh,@diachi)
		end


GO
/****** Object:  StoredProcedure [dbo].[themke]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- thêm vào 
create proc [dbo].[themke](@make nvarchar(8),@tenke nvarchar(20))
as
	insert into ke values(@make,@tenke)


GO
/****** Object:  StoredProcedure [dbo].[themloaisach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- thêm vào 
create proc [dbo].[themloaisach](@maloaisach nvarchar(20),@tenloaisach nvarchar(20))
as
	insert into loaisach values(@maloaisach,@tenloaisach)


GO
/****** Object:  StoredProcedure [dbo].[themnv]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- thêm nhân viên
create proc [dbo].[themnv](@manhanvien nvarchar(8),@taikhoan nvarchar(20),@matkhau nvarchar(20),@loai nvarchar(20),@tennv nvarchar(20),@diachi nvarchar(20),@sex nvarchar(20))
as
	insert into nhanvien values(@manhanvien,@taikhoan,@matkhau,@loai,@tennv,@diachi,@sex)


GO
/****** Object:  StoredProcedure [dbo].[themphieumuon]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themphieumuon](@maphieumuon varchar(8),@ngaymuon date,@hanngaytra date,@manhanvien nvarchar(8),
	@masach nvarchar(8),@madocgia nvarchar(8),@trangthai nvarchar(20))
	as
		begin
			--IF	1>(SELECT soluong FROM sach WHERE masach=@masach) THROW 50001,'Số lượng hàng trong kho không đủ!',1;
			--IF	@maphieumuon = '' THROW 50001, 'Mã phiếu xuất không được để trống!', 1;
			--IF	@madocgia = '' THROW 50001, 'Mã khách hàng không được để trống!', 1;
			--IF	@manhanvien='' THROW 50001, 'Mã thủ kho không được để trống!', 1;
			--IF	@ngaymuon ='' THROW 50001, 'Ngày không được để trống!', 1;
			--IF	@hanngaytra ='' THROW 50001, 'Ngày không được để trống!', 1;
			--IF	@trangthai ='' THROW 50001, 'Trạng thái không được để trống!', 1;
			insert into phieumuon values(@maphieumuon,@ngaymuon,@hanngaytra,@manhanvien,@masach,1,@madocgia,@trangthai)
		end


GO
/****** Object:  StoredProcedure [dbo].[themsach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- thêm vào 
create proc [dbo].[themsach](@masach	   nvarchar(8), 
		@tensach   nvarchar(20) ,    
		@maloaisach	nvarchar(20),
		@soluong     int,
		@make  nvarchar (8))
as
	insert into sach values(@masach,@tensach,@maloaisach,@soluong,@make)


GO
/****** Object:  StoredProcedure [dbo].[thongke]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


	--------- tạo lọc phiếu----------------
	create proc [dbo].[thongke] @dau date,@sau date
as
	begin
		select * from phieumuon where ngaymuon BETWEEN  @dau AND @sau
	end


GO
/****** Object:  StoredProcedure [dbo].[thongtinfulldocgia]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------------------------

-----------------------docgia-----------------------------------------

--lấy full độc giả
create proc  [dbo].[thongtinfulldocgia]
as
	select *from docgia


GO
/****** Object:  StoredProcedure [dbo].[thongtinke]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--exec dbo.themnv 'NV06','Pham Quynh Anh','Tien Giang','Nu','BP01'



-----------------------------------------------------------------
--------------------------KỆ SÁCH--------------------------------
	
--thông tin kệ
create proc [dbo].[thongtinke]
as
	select * from  ke


GO
/****** Object:  StoredProcedure [dbo].[thongtinkeid]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[thongtinkeid] @idsach nvarchar(8)
as
	select * from  ke where make=@idsach


GO
/****** Object:  StoredProcedure [dbo].[thongtinloaisach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



---------------------------LOAISACH-----------------------------------
--chỉnh sửa loại sách

create proc [dbo].[thongtinloaisach]
as
	select * from  loaisach


GO
/****** Object:  StoredProcedure [dbo].[thongtinnv]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


---------------------------------------------------------------------------

-----------------------------NHÂN VIÊN----------------------------------

-- tra cứu thông tin nhân viên
create proc [dbo].[thongtinnv]
as
	select * from  nhanvien


GO
/****** Object:  StoredProcedure [dbo].[thongtinphieumuon]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




---------------------------------Phiếu mượn-----------------------------------
-- lấy thông tin từ phiếu mượn
create proc  [dbo].[thongtinphieumuon]
as
	select *from phieumuon


GO
/****** Object:  StoredProcedure [dbo].[thongtinphieumuonid]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[thongtinphieumuonid] @idsach nvarchar(8)
as
	select * from  phieumuon where maphieumuon=@idsach


GO
/****** Object:  StoredProcedure [dbo].[thongtinsach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--exec dbo.timkiemsach1 N'S0001'
--go

--chỉnh sửa sách

create proc [dbo].[thongtinsach]
as
	select * from  sach


GO
/****** Object:  StoredProcedure [dbo].[thongtinvid]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[thongtinvid] @idmanv nvarchar(20)
as
	select * from  nhanvien where tennhanvien=@idmanv


GO
/****** Object:  StoredProcedure [dbo].[timkiem]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[timkiem](@maloaisach nvarchar(20))
	as 
	 select * from loaisach where tenloaisach like '%' + @maloaisach + '%'

GO
/****** Object:  StoredProcedure [dbo].[timkiemdocgia]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timkiemdocgia](@tendocgia nvarchar(20))
as
	select * from docgia 
	where tendocgia like '%'+ @tendocgia + '%'


GO
/****** Object:  StoredProcedure [dbo].[timkiemphieumuon]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[timkiemphieumuon](@maphieumuon nvarchar(20))
	as 
	 select * from phieumuon where maphieumuon = @maphieumuon 

GO
/****** Object:  StoredProcedure [dbo].[timkiemsach1]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Tìm kiếm theo mã sách
create proc [dbo].[timkiemsach1](@masach nvarchar(8))
as
	select * from sach 
	where masach=@masach


GO
/****** Object:  StoredProcedure [dbo].[timkiemsach2]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[timkiemsach2](@tensach nvarchar(20))
as
	select * from sach 
	where tensach LIKE '%' + @tensach  + '%'

GO
/****** Object:  StoredProcedure [dbo].[xoadocgia]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--xóa 1 độc giả
create proc [dbo].[xoadocgia] @madocgia nvarchar(8)
as
	begin
		delete  from docgia where madocgia=@madocgia
	end


GO
/****** Object:  StoredProcedure [dbo].[xoake]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--xóa kệ
create proc [dbo].[xoake](@make nvarchar(8))
	as 
		begin
			delete from ke where make=@make
		end


GO
/****** Object:  StoredProcedure [dbo].[xoaloaisach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--xóa loại sach
create proc [dbo].[xoaloaisach](@maloaisach nvarchar(20))
	as 
		begin
			delete from loaisach where maloaisach=@maloaisach
		end


GO
/****** Object:  StoredProcedure [dbo].[xoanv]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoanv] @manhanvien nvarchar(8)
as
	begin
		delete  from nhanvien where manhanvien=@manhanvien
	end


GO
/****** Object:  StoredProcedure [dbo].[xoaphieumuon]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--xóa phiếu mượn------
create proc [dbo].[xoaphieumuon] @maphieumuon nvarchar(8)
as
	begin
		delete  from phieumuon where maphieumuon=@maphieumuon
	end


GO
/****** Object:  StoredProcedure [dbo].[xoasach]    Script Date: 20/07/2020 11:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--xóa loại sach
create proc [dbo].[xoasach](@masach nvarchar(8))
	as 
		begin
			delete from sach where masach=@masach
		end


GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
