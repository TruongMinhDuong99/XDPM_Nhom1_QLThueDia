USE [master]
GO
/****** Object:  Database [DB_BangDia]    Script Date: 12/1/2020 2:27:53 PM ******/
CREATE DATABASE [DB_BangDia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_BangDia', FILENAME = N'F:\C#\DB_BangDia.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_BangDia_log', FILENAME = N'F:\C#\DB_BangDia_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_BangDia] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_BangDia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_BangDia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_BangDia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_BangDia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_BangDia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_BangDia] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_BangDia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_BangDia] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DB_BangDia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_BangDia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_BangDia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_BangDia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_BangDia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_BangDia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_BangDia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_BangDia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_BangDia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_BangDia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_BangDia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_BangDia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_BangDia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_BangDia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_BangDia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_BangDia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_BangDia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_BangDia] SET  MULTI_USER 
GO
ALTER DATABASE [DB_BangDia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_BangDia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_BangDia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_BangDia] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DB_BangDia]
GO
/****** Object:  Table [dbo].[Dias]    Script Date: 12/1/2020 2:27:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dias](
	[MaDia] [nvarchar](50) NOT NULL,
	[TenDia] [nvarchar](50) NOT NULL,
	[TrangThaiDia] [nvarchar](50) NOT NULL,
	[MaTieuDe] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Dias] PRIMARY KEY CLUSTERED 
(
	[MaDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHangs]    Script Date: 12/1/2020 2:27:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHangs](
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](250) NULL,
	[SDT] [nvarchar](20) NULL,
 CONSTRAINT [PK_KhachHangs] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiDias]    Script Date: 12/1/2020 2:27:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDias](
	[MaLoaiDia] [nvarchar](50) NOT NULL,
	[TenLoaiDia] [nvarchar](50) NOT NULL,
	[ThoiGianThue] [int] NOT NULL,
	[GiaThue] [float] NOT NULL,
	[GiaPhat] [float] NOT NULL,
 CONSTRAINT [PK_LoaiDias] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuDats]    Script Date: 12/1/2020 2:27:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDats](
	[MaDat] [nvarchar](50) NOT NULL,
	[NgayDat] [datetime] NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[MaKhachHang] [nvarchar](50) NOT NULL,
	[MaTieuDe] [nvarchar](50) NOT NULL,
	[MaDia] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuDats] PRIMARY KEY CLUSTERED 
(
	[MaDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuThues]    Script Date: 12/1/2020 2:27:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThues](
	[MaThue] [nvarchar](50) NOT NULL,
	[GiaThue] [float] NOT NULL,
	[TrangThaiThue] [nvarchar](50) NOT NULL,
	[NgayMuon] [datetime] NOT NULL,
	[NgayHenTra] [datetime] NOT NULL,
	[NgayTra] [datetime] NULL,
	[PhiTraMuon] [float] NULL,
	[TrangThaiPhi] [nvarchar](50) NULL,
	[MaDia] [nvarchar](50) NOT NULL,
	[MaKhachHang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuThues] PRIMARY KEY CLUSTERED 
(
	[MaThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoans]    Script Date: 12/1/2020 2:27:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoans](
	[TenDN] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TieuDes]    Script Date: 12/1/2020 2:27:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TieuDes](
	[MaTieuDe] [nvarchar](50) NOT NULL,
	[TenTieuDe] [nvarchar](50) NOT NULL,
	[NhaSanXuat] [nvarchar](50) NULL,
	[MaLoaiDia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TieuDes] PRIMARY KEY CLUSTERED 
(
	[MaTieuDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0001', N'Resident Evil-copy-1', N'Sẵn sàng', N'TD0001')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0002', N'Resident Evil-copy-2', N'Sẵn sàng', N'TD0001')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0003', N'Resident Evil-copy-3', N'Sẵn sàng', N'TD0001')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0004', N'Resident Evil-copy-4', N'Sẵn sàng', N'TD0001')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0005', N'Resident Evil 2-copy-1', N'Sẵn sàng', N'TD0002')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0006', N'Resident Evil 2-copy2', N'Sẵn sàng', N'TD0002')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0007', N'Resident Evil 2-copy-3', N'Sẵn sàng', N'TD0002')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0008', N'Resident Evil 2-copy-4', N'Sẵn sàng', N'TD0002')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0009', N'Resident Evil 3: Nemesis-copy-1', N'Sẵn sàng', N'TD0003')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0010', N'Resident Evil 3: Nemesis-copy-2', N'Sẵn sàng', N'TD0003')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0011', N'Resident Evil 3: Nemesis-copy-3', N'Sẵn sàng', N'TD0003')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0012', N'Resident Evil 3: Nemesis-copy-4', N'Sẵn sàng', N'TD0003')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0013', N'Resident Evil - Code : Veronica-copy-1', N'Sẵn sàng', N'TD0004')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0014', N'Resident Evil - Code : Veronica-copy-2', N'Sẵn sàng', N'TD0004')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0015', N'Resident Evil - Code : Veronica-copy-3', N'Sẵn sàng', N'TD0004')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0016', N'Resident Evil - Code : Veronica-copy-4', N'Sẵn sàng', N'TD0004')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0017', N'Pokemon Black & White-copy-1', N'Sẵn sàng', N'TD0005')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0018', N'Pokemon Black & White-copy-2', N'Sẵn sàng', N'TD0005')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0019', N'Pokemon Black & White-copy-3', N'Sẵn sàng', N'TD0005')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0020', N'Pokemon Black & White-copy-4', N'Sẵn sàng', N'TD0005')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0021', N'Pokemon Black 2 & White2-copy-1', N'Sẵn sàng', N'TD0006')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0022', N'Pokemon Black 2 & White2-copy-2', N'Sẵn sàng', N'TD0006')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0023', N'Pokemon Black 2 & White2-copy-3', N'Sẵn sàng', N'TD0006')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0024', N'Pokemon Black 2 & White2-copy-4', N'Sẵn sàng', N'TD0006')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0025', N'Pokemon X Y-copy-1', N'Sẵn sàng', N'TD0007')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0026', N'Pokemon X Y-copy-2', N'Sẵn sàng', N'TD0007')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0027', N'Pokemon X Y-copy-3', N'Sẵn sàng', N'TD0007')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0028', N'Pokemon X Y-copy-4', N'Sẵn sàng', N'TD0007')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0029', N'Pokemon Omega Ruby & Alpha Saphire-copy-1', N'Sẵn sàng', N'TD0008')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0030', N'Pokemon Omega Ruby & Alpha Saphire-copy-2', N'Sẵn sàng', N'TD0008')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0031', N'Pokemon Omega Ruby & Alpha Saphire-copy-3', N'Sẵn sàng', N'TD0008')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0032', N'Pokemon Omega Ruby & Alpha Saphire-copy-4', N'Sẵn sàng', N'TD0008')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0033', N'Pokemon Sun & Moon-copy-1', N'Sẵn sàng', N'TD0009')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0034', N'Pokemon Sun & Moon-copy-2', N'Sẵn sàng', N'TD0009')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0035', N'Pokemon Sun & Moon-copy-3', N'Sẵn sàng', N'TD0009')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0036', N'Pokemon Sun & Moon-copy-4', N'Sẵn sàng', N'TD0009')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0037', N'Pokemon Ultra Sun & Moon-copy-1', N'Sẵn sàng', N'TD0010')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0038', N'Pokemon Ultra Sun & Moon-copy-2', N'Sẵn sàng', N'TD0010')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0039', N'Pokemon Ultra Sun & Moon-copy-3', N'Sẵn sàng', N'TD0010')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0040', N'Pokemon Ultra Sun & Moon-copy-4', N'Sẵn sàng', N'TD0010')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0041', N'Pokemon Sword & Shield-copy-1', N'Sẵn sàng', N'TD0011')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0042', N'Pokemon Sword & Shield-copy-2', N'Sẵn sàng', N'TD0011')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0043', N'Pokemon Sword & Shield-copy-3', N'Sẵn sàng', N'TD0011')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0044', N'Pokemon Sword & Shield-copy-4', N'Sẵn sàng', N'TD0011')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0045', N'Final Fantasy XIII-copy-1', N'Sẵn sàng', N'TD0012')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0046', N'Final Fantasy XIII-copy-2', N'Sẵn sàng', N'TD0012')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0047', N'Final Fantasy XIII-copy-3', N'Sẵn sàng', N'TD0012')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0048', N'Final Fantasy XIII-copy-4', N'Sẵn sàng', N'TD0012')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0049', N'Final Fantasy XV-copy-1', N'Sẵn sàng', N'TD0013')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0050', N'Final Fantasy XV-copy-2', N'Sẵn sàng', N'TD0013')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0051', N'Final Fantasy XV-copy-3', N'Sẵn sàng', N'TD0013')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0052', N'Final Fantasy XV-copy-4', N'Sẵn sàng', N'TD0013')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0053', N'Final Fantasy VII Remake-copy-1', N'Sẵn sàng', N'TD0014')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0054', N'Final Fantasy VII Remake-copy-2', N'Sẵn sàng', N'TD0014')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0055', N'Final Fantasy VII Remake-copy-3', N'Sẵn sàng', N'TD0014')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0056', N'Final Fantasy VII Remake-copy-4', N'Sẵn sàng', N'TD0014')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0057', N'Metal Gear Solid: Social Ops-copy-1', N'Sẵn sàng', N'TD0015')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0058', N'Metal Gear Solid: Social Ops-copy-2', N'Sẵn sàng', N'TD0015')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0059', N'Metal Gear Solid: Social Ops-copy-3', N'Sẵn sàng', N'TD0015')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0060', N'Metal Gear Solid: Social Ops-copy-4', N'Sẵn sàng', N'TD0015')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0061', N'Metal Gear Rising: Revengeance-copy-1', N'Sẵn sàng', N'TD0016')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0062', N'Metal Gear Rising: Revengeance-copy-2', N'Sẵn sàng', N'TD0016')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0063', N'Metal Gear Rising: Revengeance-copy-3', N'Sẵn sàng', N'TD0016')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0064', N'Metal Gear Rising: Revengeance-copy-4', N'Sẵn sàng', N'TD0016')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0065', N'Metal Gear Solid V: Ground  Zeroes-copy-1', N'Sẵn sàng', N'TD0017')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0066', N'Metal Gear Solid V: Ground  Zeroes-copy-2', N'Sẵn sàng', N'TD0017')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0067', N'Metal Gear Solid V: Ground  Zeroes-copy-3', N'Sẵn sàng', N'TD0017')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0068', N'Metal Gear Solid V: Ground  Zeroes-copy-4', N'Sẵn sàng', N'TD0017')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0069', N'Metal Gear Solid V: The Phantom Pain-copy-1', N'Sẵn sàng', N'TD0018')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0070', N'Metal Gear Solid V: The Phantom Pain-copy-2', N'Sẵn sàng', N'TD0018')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0071', N'Metal Gear Solid V: The Phantom Pain-copy-3', N'Sẵn sàng', N'TD0018')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0072', N'Metal Gear Solid V: The Phantom Pain-copy-4', N'Sẵn sàng', N'TD0018')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0073', N'Death Stranding-copy-1', N'Sẵn sàng', N'TD0019')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0074', N'Death Stranding-copy-2', N'Sẵn sàng', N'TD0019')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0075', N'Death Stranding-copy-3', N'Sẵn sàng', N'TD0019')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0076', N'Death Stranding-copy-4', N'Sẵn sàng', N'TD0019')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0077', N'Silent Hill-copy-1', N'Sẵn sàng', N'TD0020')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0078', N'Silent Hill-copy-2', N'Sẵn sàng', N'TD0020')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0079', N'Silent Hill-copy-3', N'Sẵn sàng', N'TD0020')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0080', N'Silent Hill-copy-4', N'Sẵn sàng', N'TD0020')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0081', N'The Evil Within-copy-1', N'Sẵn sàng', N'TD0021')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0082', N'The Evil Within-copy-2', N'Sẵn sàng', N'TD0021')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0083', N'The Evil Within-copy-3', N'Sẵn sàng', N'TD0021')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0084', N'The Evil Within-copy-4', N'Sẵn sàng', N'TD0021')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0085', N'Outlast-copy-1', N'Sẵn sàng', N'TD0022')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0086', N'Outlast-copy-2', N'Sẵn sàng', N'TD0022')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0087', N'Outlast-copy-3', N'Sẵn sàng', N'TD0022')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0088', N'Outlast-copy-4', N'Sẵn sàng', N'TD0022')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0089', N'Outlast 2-copy-1', N'Sẵn sàng', N'TD0023')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0090', N'Outlast 2-copy-2', N'Sẵn sàng', N'TD0023')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0091', N'Outlast 2-copy-3', N'Sẵn sàng', N'TD0023')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0092', N'Outlast 2-copy-4', N'Sẵn sàng', N'TD0023')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0093', N'Until Dawn-copy-1', N'Sẵn sàng', N'TD0024')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0094', N'Until Dawn-copy-2', N'Sẵn sàng', N'TD0024')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0095', N'Until Dawn-copy-3', N'Sẵn sàng', N'TD0024')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0096', N'Until Dawn-copy-4', N'Sẵn sàng', N'TD0024')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0097', N'The Dark Pictures: Man of Medan-copy-1', N'Sẵn sàng', N'TD0025')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0098', N'The Dark Pictures: Man of Medan-copy-2', N'Sẵn sàng', N'TD0025')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0099', N'The Dark Pictures: Man of Medan-copy-3', N'Sẵn sàng', N'TD0025')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0100', N'The Dark Pictures: Man of Medan-copy-4', N'Sẵn sàng', N'TD0025')
GO
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0101', N'Blair Witch-copy-1', N'Sẵn sàng', N'TD0026')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0102', N'Blair Witch-copy-2', N'Sẵn sàng', N'TD0026')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0103', N'Blair Witch-copy-3', N'Sẵn sàng', N'TD0026')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0104', N'Blair Witch-copy-4', N'Sẵn sàng', N'TD0026')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0105', N'Be yond two souls-copy-1', N'Sẵn sàng', N'TD0027')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0106', N'Be yond two souls-copy-2', N'Sẵn sàng', N'TD0027')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0107', N'Be yond two souls-copy-3', N'Sẵn sàng', N'TD0027')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0108', N'Be yond two souls-copy-4', N'Sẵn sàng', N'TD0027')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0109', N'The last of us-copy-1', N'Sẵn sàng', N'TD0028')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0110', N'The last of us-copy-2', N'Sẵn sàng', N'TD0028')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0111', N'The last of us-copy-3', N'Sẵn sàng', N'TD0028')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0112', N'The last of us-copy-4', N'Sẵn sàng', N'TD0028')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0113', N'The last of us part 2-copy-1', N'Sẵn sàng', N'TD0029')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0114', N'The last of us part 2-copy-2', N'Sẵn sàng', N'TD0029')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0115', N'The last of us part 2-copy-3', N'Sẵn sàng', N'TD0029')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0116', N'The last of us part 2-copy-4', N'Sẵn sàng', N'TD0029')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0117', N'Detroit: Become Human-copy-1', N'Sẵn sàng', N'TD0030')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0118', N'Detroit: Become Human-copy-2', N'Sẵn sàng', N'TD0030')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0119', N'Detroit: Become Human-copy-3', N'Sẵn sàng', N'TD0030')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0120', N'Detroit: Become Human-copy-4', N'Sẵn sàng', N'TD0030')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0121', N'Orange Is The New Black SS1-copy-1', N'Sẵn sàng', N'TD0031')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0122', N'Orange Is The New Black SS1-copy-2', N'Sẵn sàng', N'TD0031')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0123', N'Orange Is The New Black SS1-copy-3', N'Sẵn sàng', N'TD0031')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0124', N'Orange Is The New Black SS1-copy-4', N'Sẵn sàng', N'TD0031')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0125', N'Orange Is The New Black SS2-copy-1', N'Sẵn sàng', N'TD0032')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0126', N'Orange Is The New Black SS2-copy-2', N'Sẵn sàng', N'TD0032')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0127', N'Orange Is The New Black SS2-copy-3', N'Sẵn sàng', N'TD0032')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0128', N'Orange Is The New Black SS2-copy-4', N'Sẵn sàng', N'TD0032')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0129', N'Orange Is The New Black SS3-copy-1', N'Sẵn sàng', N'TD0033')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0130', N'Orange Is The New Black SS3-copy-2', N'Sẵn sàng', N'TD0033')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0131', N'Orange Is The New Black SS3-copy-3', N'Sẵn sàng', N'TD0033')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0132', N'Orange Is The New Black SS3-copy-4', N'Sẵn sàng', N'TD0033')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0133', N'Orange Is The New Black SS4-copy-1', N'Sẵn sàng', N'TD0034')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0134', N'Orange Is The New Black SS4-copy-2', N'Sẵn sàng', N'TD0034')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0135', N'Orange Is The New Black SS4-copy-3', N'Sẵn sàng', N'TD0034')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0136', N'Orange Is The New Black SS4-copy-4', N'Sẵn sàng', N'TD0034')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0137', N'Money Heist SS1-copy-1', N'Sẵn sàng', N'TD0035')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0138', N'Money Heist SS1-copy-2', N'Sẵn sàng', N'TD0035')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0139', N'Money Heist SS1-copy-3', N'Sẵn sàng', N'TD0035')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0140', N'Money Heist SS1-copy-4', N'Sẵn sàng', N'TD0035')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0141', N'Money Heist SS2-copy-1', N'Sẵn sàng', N'TD0036')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0142', N'Money Heist SS2-copy-2', N'Sẵn sàng', N'TD0036')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0143', N'Money Heist SS2-copy-3', N'Sẵn sàng', N'TD0036')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0144', N'Money Heist SS2-copy-4', N'Sẵn sàng', N'TD0036')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0145', N'Money Heist SS3-copy-1', N'Sẵn sàng', N'TD0037')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0146', N'Money Heist SS3-copy-2', N'Sẵn sàng', N'TD0037')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0147', N'Money Heist SS3-copy-3', N'Sẵn sàng', N'TD0037')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0148', N'Money Heist SS3-copy-4', N'Sẵn sàng', N'TD0037')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0149', N'Money Heist SS4-copy-1', N'Sẵn sàng', N'TD0038')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0150', N'Money Heist SS4-copy-2', N'Sẵn sàng', N'TD0038')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0151', N'Money Heist SS4-copy-3', N'Sẵn sàng', N'TD0038')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0152', N'Money Heist SS4-copy-4', N'Sẵn sàng', N'TD0038')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0153', N'Kingdom SS1-copy-1', N'Sẵn sàng', N'TD0039')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0154', N'Kingdom SS1-copy-2', N'Sẵn sàng', N'TD0039')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0155', N'Kingdom SS1-copy-3', N'Sẵn sàng', N'TD0039')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0156', N'Kingdom SS1-copy-4', N'Sẵn sàng', N'TD0039')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0157', N'Kingdom SS2-copy-1', N'Sẵn sàng', N'TD0040')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0158', N'Kingdom SS2-copy-2', N'Sẵn sàng', N'TD0040')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0159', N'Kingdom SS2-copy-3', N'Sẵn sàng', N'TD0040')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0160', N'Kingdom SS2-copy-4', N'Sẵn sàng', N'TD0040')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0161', N'The Witcher SS1-copy-1', N'Sẵn sàng', N'TD0041')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0162', N'The Witcher SS1-copy-2', N'Sẵn sàng', N'TD0041')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0163', N'The Witcher SS1-copy-3', N'Sẵn sàng', N'TD0041')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0164', N'The Witcher SS1-copy-4', N'Sẵn sàng', N'TD0041')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0165', N'Sherlock SS1-copy-1', N'Sẵn sàng', N'TD0042')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0166', N'Sherlock SS1-copy-2', N'Sẵn sàng', N'TD0042')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0167', N'Sherlock SS1-copy-3', N'Sẵn sàng', N'TD0042')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0168', N'Sherlock SS1-copy-4', N'Sẵn sàng', N'TD0042')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0169', N'Sherlock SS2-copy-1', N'Sẵn sàng', N'TD0043')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0170', N'Sherlock SS2-copy-2', N'Sẵn sàng', N'TD0043')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0171', N'Sherlock SS2-copy-3', N'Sẵn sàng', N'TD0043')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0172', N'Sherlock SS2-copy-4', N'Sẵn sàng', N'TD0043')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0173', N'Sherlock SS3-copy-1', N'Sẵn sàng', N'TD0044')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0174', N'Sherlock SS3-copy-2', N'Sẵn sàng', N'TD0044')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0175', N'Sherlock SS3-copy-3', N'Sẵn sàng', N'TD0044')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0176', N'Sherlock SS3-copy-4', N'Sẵn sàng', N'TD0044')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0177', N'Stranger Things SS1-copy-1', N'Sẵn sàng', N'TD0045')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0178', N'Stranger Things SS1-copy-2', N'Sẵn sàng', N'TD0045')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0179', N'Stranger Things SS1-copy-3', N'Sẵn sàng', N'TD0045')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0180', N'Stranger Things SS1-copy-4', N'Sẵn sàng', N'TD0045')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0181', N'Stranger Things SS2-copy-1', N'Sẵn sàng', N'TD0046')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0182', N'Stranger Things SS2-copy-2', N'Sẵn sàng', N'TD0046')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0183', N'Stranger Things SS2-copy-3', N'Sẵn sàng', N'TD0046')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0184', N'Stranger Things SS2-copy-4', N'Sẵn sàng', N'TD0046')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0185', N'Stranger Things SS3-copy-1', N'Sẵn sàng', N'TD0047')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0186', N'Stranger Things SS3-copy-2', N'Sẵn sàng', N'TD0047')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0187', N'Stranger Things SS3-copy-3', N'Sẵn sàng', N'TD0047')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0188', N'Stranger Things SS3-copy-4', N'Sẵn sàng', N'TD0047')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0189', N'Stranger Things SS4-copy-1', N'Sẵn sàng', N'TD0048')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0190', N'Stranger Things SS4-copy-2', N'Sẵn sàng', N'TD0048')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0191', N'Stranger Things SS4-copy-3', N'Sẵn sàng', N'TD0048')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0192', N'Stranger Things SS4-copy-4', N'Sẵn sàng', N'TD0048')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0193', N'Prison Break SS1-copy-1', N'Sẵn sàng', N'TD0049')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0194', N'Prison Break SS1-copy-2', N'Sẵn sàng', N'TD0049')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0195', N'Prison Break SS1-copy-3', N'Sẵn sàng', N'TD0049')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0196', N'Prison Break SS1-copy-4', N'Sẵn sàng', N'TD0049')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0197', N'Prison Break SS2-copy-1', N'Sẵn sàng', N'TD0050')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0198', N'Prison Break SS2-copy-2', N'Sẵn sàng', N'TD0050')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0199', N'Prison Break SS2-copy-3', N'Sẵn sàng', N'TD0050')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0200', N'Prison Break SS2-copy-4', N'Sẵn sàng', N'TD0050')
GO
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0201', N'Prison Break SS3-copy-1', N'Sẵn sàng', N'TD0051')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0202', N'Prison Break SS3-copy-2', N'Sẵn sàng', N'TD0051')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0203', N'Prison Break SS3-copy-3', N'Sẵn sàng', N'TD0051')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0204', N'Prison Break SS3-copy-4', N'Sẵn sàng', N'TD0051')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0205', N'Prison Break SS4-copy-1', N'Sẵn sàng', N'TD0052')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0206', N'Prison Break SS4-copy-2', N'Sẵn sàng', N'TD0052')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0207', N'Prison Break SS4-copy-3', N'Sẵn sàng', N'TD0052')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0208', N'Prison Break SS4-copy-4', N'Sẵn sàng', N'TD0052')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0209', N'Prison Break SS5-copy-1', N'Sẵn sàng', N'TD0053')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0210', N'Prison Break SS5-copy-2', N'Sẵn sàng', N'TD0053')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0211', N'Prison Break SS5-copy-3', N'Sẵn sàng', N'TD0053')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0212', N'Prison Break SS5-copy-4', N'Sẵn sàng', N'TD0053')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0213', N'Sex Education SS1-copy-1', N'Sẵn sàng', N'TD0054')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0214', N'Sex Education SS1-copy-2', N'Sẵn sàng', N'TD0054')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0215', N'Sex Education SS1-copy-3', N'Sẵn sàng', N'TD0054')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0216', N'Sex Education SS1-copy-4', N'Sẵn sàng', N'TD0054')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0217', N'Sex Education SS2-copy-1', N'Sẵn sàng', N'TD0055')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0218', N'Sex Education SS2-copy-2', N'Sẵn sàng', N'TD0055')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0219', N'Sex Education SS2-copy-3', N'Sẵn sàng', N'TD0055')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0220', N'Sex Education SS2-copy-4', N'Sẵn sàng', N'TD0055')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0221', N'Game of Thrones SS1-copy-1', N'Sẵn sàng', N'TD0056')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0222', N'Game of Thrones SS1-copy-2', N'Sẵn sàng', N'TD0056')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0223', N'Game of Thrones SS1-copy-3', N'Sẵn sàng', N'TD0056')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0224', N'Game of Thrones SS1-copy-4', N'Sẵn sàng', N'TD0056')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0225', N'Game of Thrones SS2-copy-1', N'Sẵn sàng', N'TD0057')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0226', N'Game of Thrones SS2-copy-2', N'Sẵn sàng', N'TD0057')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0227', N'Game of Thrones SS2-copy-3', N'Sẵn sàng', N'TD0057')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0228', N'Game of Thrones SS2-copy-4', N'Sẵn sàng', N'TD0057')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0229', N'Game of Thrones SS3-copy-1', N'Sẵn sàng', N'TD0058')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0230', N'Game of Thrones SS3-copy-2', N'Sẵn sàng', N'TD0058')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0231', N'Game of Thrones SS3-copy-3', N'Sẵn sàng', N'TD0058')
INSERT [dbo].[Dias] ([MaDia], [TenDia], [TrangThaiDia], [MaTieuDe]) VALUES (N'D0232', N'Game of Thrones SS3-copy-4', N'Sẵn sàng', N'TD0058')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0001', N'Nguyễn Hoàng Nghĩa', N'Gò Vấp, TP.HCM', N'0812346578')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0002', N'Đoàn Kim Định', N'Tân Bình, TP.HCM', N'0394817274')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0003', N'Châu Nhật Đăng', N'Quận 8, TP.HCM', N'0837162647')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0004', N'Hồ Ngọc Hưng', N'Gò Vấp, TP.HCM', N'0837461726')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0005', N'Trương Tính Trung', N'Bình Thạnh, TP.HCM', N'0914726350')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0007', N'Dương Văn Thiện Hải', N'Gò Vấp, TP.HCM', N'0384872726')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0009', N'Nguyễn Văn Vương', N'Tân Phú, TP.HCM', N'0347871762')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0010', N'Hoàng Quốc Cường', N'Quận 12, TP.HCM', N'0389685987')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0011', N'Tống Thanh Lâm', N'Quận 2, TP.HCM', N'0123748880')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0012', N'Lê Thị Ly', N'Phú Nhuận, TP.HCM', N'0223844521')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0013', N'Trần Minh Tuấn', N'Quận 2, TP.HCM', N'0123747281')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0015', N'Nguyễn Nhật Khánh', N'Quận 6, TP.HCM', N'0848271633')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0016', N'Trần Ngọc Minh', N'Tân Bình, TP.HCM', N'0389184770')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0017', N'Nguyễn Thành Tài', N'Thủ Đức, TP.HCM', N'0922574452')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0018', N'Nguyễn Thanh Liêm', N'Thủ Đức, TP.HCm', N'0381847576')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0019', N'Trần Minh Trúc', N'Gò Vấp, TP.HCM', N'0127635665')
INSERT [dbo].[KhachHangs] ([MaKhachHang], [HoTen], [DiaChi], [SDT]) VALUES (N'KH0020', N'Nguyễn Cao Trí', N'Thủ Đức, TP.HCM', N'0928374871')
INSERT [dbo].[LoaiDias] ([MaLoaiDia], [TenLoaiDia], [ThoiGianThue], [GiaThue], [GiaPhat]) VALUES (N'LD0001', N'Đĩa Game', 20, 50000, 10000)
INSERT [dbo].[LoaiDias] ([MaLoaiDia], [TenLoaiDia], [ThoiGianThue], [GiaThue], [GiaPhat]) VALUES (N'LD0002', N'Đĩa Phim', 15, 40000, 8000)
INSERT [dbo].[TaiKhoans] ([TenDN], [MatKhau]) VALUES (N'Binh', N'1')
INSERT [dbo].[TaiKhoans] ([TenDN], [MatKhau]) VALUES (N'Duong', N'1')
INSERT [dbo].[TaiKhoans] ([TenDN], [MatKhau]) VALUES (N'Loi', N'1')
INSERT [dbo].[TaiKhoans] ([TenDN], [MatKhau]) VALUES (N'Nguyen', N'1')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0001', N'Resident Evil', N'Capcom', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0002', N'Resident Evil 2', N'Capcom', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0003', N'Resident Evil 3: Nemesis', N'Capcom', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0004', N'Resident Evil - Code : Veronica', N'Capcom', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0005', N'Pokemon Black & White', N'Nintendo', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0006', N'Pokemon Black 2 & White2', N'Nintendo', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0007', N'Pokemon X Y', N'Nintendo', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0008', N'Pokemon Omega Ruby & Alpha Saphire', N'Nintendo', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0009', N'Pokemon Sun & Moon', N'Nintendo', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0010', N'Pokemon Ultra Sun & Moon', N'Nintendo', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0011', N'Pokemon Sword & Shield', N'Nintendo', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0012', N'Final Fantasy XIII', N'Square Enix', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0013', N'Final Fantasy XV', N'Square Enix', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0014', N'Final Fantasy VII Remake', N'Squre Enix', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0015', N'Metal Gear Solid: Social Ops', N'Konami', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0016', N'Metal Gear Rising: Revengeance', N'Konami', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0017', N'Metal Gear Solid V: Ground  Zeroes', N'Konami', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0018', N'Metal Gear Solid V: The Phantom Pain', N'Konami', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0019', N'Death Stranding', N'Kojima Productions', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0020', N'Silent Hill', N'Team Silent', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0021', N'The Evil Within', N'Tango Gameworks', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0022', N'Outlast', N'Red Barrels', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0023', N'Outlast 2', N'Red Barrels', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0024', N'Until Dawn', N'Supermassive Games', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0025', N'The Dark Pictures: Man of Medan', N'Supermassive Games', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0026', N'Blair Witch', N'Bloober Team', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0027', N'Be yond two souls', N'Quantic Dream', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0028', N'The last of us', N'Naughty Dog', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0029', N'The last of us part 2', N'Naughty Dog', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0030', N'Detroit: Become Human', N'Quantic Dream', N'LD0001')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0031', N'Orange Is The New Black SS1', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0032', N'Orange Is The New Black SS2', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0033', N'Orange Is The New Black SS3', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0034', N'Orange Is The New Black SS4', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0035', N'Money Heist SS1', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0036', N'Money Heist SS2', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0037', N'Money Heist SS3', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0038', N'Money Heist SS4', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0039', N'Kingdom SS1', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0040', N'Kingdom SS2', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0041', N'The Witcher SS1', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0042', N'Sherlock SS1', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0043', N'Sherlock SS2', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0044', N'Sherlock SS3', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0045', N'Stranger Things SS1', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0046', N'Stranger Things SS2', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0047', N'Stranger Things SS3', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0048', N'Stranger Things SS4', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0049', N'Prison Break SS1', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0050', N'Prison Break SS2', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0051', N'Prison Break SS3', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0052', N'Prison Break SS4', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0053', N'Prison Break SS5', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0054', N'Sex Education SS1', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0055', N'Sex Education SS2', N'Netflix', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0056', N'Game of Thrones SS1', N'HBO', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0057', N'Game of Thrones SS2', N'HBO', N'LD0002')
INSERT [dbo].[TieuDes] ([MaTieuDe], [TenTieuDe], [NhaSanXuat], [MaLoaiDia]) VALUES (N'TD0058', N'Game of Thrones SS3', N'HBO', N'LD0002')
ALTER TABLE [dbo].[Dias]  WITH CHECK ADD  CONSTRAINT [FK_Dias_TieuDes] FOREIGN KEY([MaTieuDe])
REFERENCES [dbo].[TieuDes] ([MaTieuDe])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Dias] CHECK CONSTRAINT [FK_Dias_TieuDes]
GO
ALTER TABLE [dbo].[PhieuDats]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDats_KhachHangs] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHangs] ([MaKhachHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuDats] CHECK CONSTRAINT [FK_PhieuDats_KhachHangs]
GO
ALTER TABLE [dbo].[PhieuDats]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDats_TieuDes] FOREIGN KEY([MaTieuDe])
REFERENCES [dbo].[TieuDes] ([MaTieuDe])
GO
ALTER TABLE [dbo].[PhieuDats] CHECK CONSTRAINT [FK_PhieuDats_TieuDes]
GO
ALTER TABLE [dbo].[PhieuThues]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThues_Dias] FOREIGN KEY([MaDia])
REFERENCES [dbo].[Dias] ([MaDia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuThues] CHECK CONSTRAINT [FK_PhieuThues_Dias]
GO
ALTER TABLE [dbo].[PhieuThues]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThues_KhachHangs] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHangs] ([MaKhachHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PhieuThues] CHECK CONSTRAINT [FK_PhieuThues_KhachHangs]
GO
ALTER TABLE [dbo].[TieuDes]  WITH CHECK ADD  CONSTRAINT [FK_TieuDes_LoaiDias] FOREIGN KEY([MaLoaiDia])
REFERENCES [dbo].[LoaiDias] ([MaLoaiDia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TieuDes] CHECK CONSTRAINT [FK_TieuDes_LoaiDias]
GO
USE [master]
GO
ALTER DATABASE [DB_BangDia] SET  READ_WRITE 
GO
