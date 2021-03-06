USE [master]
GO
/****** Object:  Database [ProjectOne]    Script Date: 04/11/2020 5:56:18 CH ******/
CREATE DATABASE [ProjectOne]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectOne', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ProjectOne.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProjectOne_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\ProjectOne_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProjectOne] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectOne].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectOne] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectOne] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectOne] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectOne] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectOne] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectOne] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProjectOne] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectOne] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectOne] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectOne] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectOne] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectOne] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectOne] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectOne] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectOne] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectOne] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectOne] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectOne] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectOne] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectOne] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectOne] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectOne] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectOne] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjectOne] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectOne] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectOne] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectOne] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectOne] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProjectOne] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ProjectOne]
GO
/****** Object:  Table [dbo].[Account_Staff]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account_Staff](
	[Staff_Id] [varchar](10) NOT NULL,
	[Staff_Account] [nvarchar](50) NULL,
	[Staff_Password] [nvarchar](50) NULL,
	[Staff_Role] [varchar](1) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detail_Inf_Repair]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detail_Inf_Repair](
	[Repair_Id] [varchar](10) NOT NULL,
	[Repair_Reason] [nvarchar](max) NULL,
	[Repair_Note] [nvarchar](max) NULL,
	[Repair_Appointment] [date] NULL,
	[Repair_Money] [varchar](12) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inf_Customers]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inf_Customers](
	[Customer_Id] [varchar](10) NOT NULL,
	[Customer_Name] [nvarchar](50) NULL,
	[Customer_Sex] [varchar](1) NULL,
	[Customer_Birth] [date] NULL,
	[Customer_Email] [nvarchar](50) NULL,
	[Customer_Phone] [varchar](15) NULL,
	[Customer_TimeAdd] [nvarchar](50) NULL,
 CONSTRAINT [PK_Inf_Customers] PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inf_LichSu]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inf_LichSu](
	[Customer_Id] [varchar](10) NOT NULL,
	[Customer_Name] [nvarchar](50) NULL,
	[Customer_Sex] [varchar](1) NULL,
	[Customer_Birth] [date] NULL,
	[Customer_Email] [nvarchar](50) NULL,
	[Customer_Phone] [varchar](15) NULL,
	[Customer_TimeAdd] [nvarchar](50) NULL,
	[Repair_Id] [varchar](10) NULL,
	[Laptop_Name] [nvarchar](50) NULL,
	[Laptop_Status] [nvarchar](50) NULL,
	[Staff_Id] [nvarchar](50) NULL,
	[Repair_Reason] [nvarchar](max) NULL,
	[Repair_Note] [nvarchar](max) NULL,
	[Repair_Appointment] [date] NULL,
	[Repair_Money] [varchar](12) NULL,
	[Repair_Time_End] [date] NULL,
 CONSTRAINT [PK_Inf_LichSu] PRIMARY KEY CLUSTERED 
(
	[Customer_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inf_LK]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inf_LK](
	[LK_Id] [varchar](10) NOT NULL,
	[WareHouse_Id] [varchar](8) NOT NULL,
	[LK_Name] [nvarchar](50) NULL,
	[LK_Number] [varchar](10) NULL,
	[LK_Producer] [nvarchar](50) NULL,
	[LK_Price] [varchar](10) NULL,
	[LK_Time_Add] [nvarchar](50) NULL,
 CONSTRAINT [PK_Inf_LK_1] PRIMARY KEY CLUSTERED 
(
	[LK_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inf_Repair]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inf_Repair](
	[Repair_Id] [varchar](10) NOT NULL,
	[Customer_Id] [varchar](10) NOT NULL,
	[Laptop_Name] [nvarchar](50) NULL,
	[Laptop_Status] [nvarchar](50) NULL,
	[Staff_Id] [nvarchar](50) NULL,
 CONSTRAINT [PK_Inf_Repair] PRIMARY KEY CLUSTERED 
(
	[Repair_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inf_Staff]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inf_Staff](
	[Staff_Id] [varchar](10) NOT NULL,
	[Staff_Name] [nvarchar](50) NULL,
	[Staff_Sex] [varchar](1) NULL,
	[Staff_Birth] [date] NULL,
	[Staff_Address] [nvarchar](100) NULL,
	[Staff_Phone] [varchar](15) NULL,
	[Staff_Deparment] [varchar](1) NULL,
	[Staff_TimeAdd] [nvarchar](50) NULL,
 CONSTRAINT [PK_Inf_Staff] PRIMARY KEY CLUSTERED 
(
	[Staff_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inf_WareHouse]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inf_WareHouse](
	[WareHouse_Id] [varchar](8) NOT NULL,
	[WareHouse_Name] [nvarchar](50) NULL,
	[WareHouse_Address] [nvarchar](50) NULL,
	[WareHouse_Capacity] [numeric](18, 0) NULL,
	[Ware_House_Total] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Inf_WareHouse] PRIMARY KEY CLUSTERED 
(
	[WareHouse_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salary_Staff]    Script Date: 04/11/2020 5:56:18 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Salary_Staff](
	[Staff_Id] [varchar](10) NOT NULL,
	[Staff_Default_Salary] [varchar](10) NULL,
	[Staff_Salary_Per_Hour] [varchar](10) NULL,
	[Staff_OT] [varchar](10) NULL,
	[Staff_Reward] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Account_Staff]  WITH CHECK ADD  CONSTRAINT [FK_Account_Staff_Inf_Staff] FOREIGN KEY([Staff_Id])
REFERENCES [dbo].[Inf_Staff] ([Staff_Id])
GO
ALTER TABLE [dbo].[Account_Staff] CHECK CONSTRAINT [FK_Account_Staff_Inf_Staff]
GO
ALTER TABLE [dbo].[Detail_Inf_Repair]  WITH CHECK ADD  CONSTRAINT [FK_Detail_Inf_Repair_Inf_Repair] FOREIGN KEY([Repair_Id])
REFERENCES [dbo].[Inf_Repair] ([Repair_Id])
GO
ALTER TABLE [dbo].[Detail_Inf_Repair] CHECK CONSTRAINT [FK_Detail_Inf_Repair_Inf_Repair]
GO
ALTER TABLE [dbo].[Inf_LK]  WITH CHECK ADD  CONSTRAINT [FK_Inf_LK_Inf_WareHouse] FOREIGN KEY([WareHouse_Id])
REFERENCES [dbo].[Inf_WareHouse] ([WareHouse_Id])
GO
ALTER TABLE [dbo].[Inf_LK] CHECK CONSTRAINT [FK_Inf_LK_Inf_WareHouse]
GO
ALTER TABLE [dbo].[Inf_Repair]  WITH CHECK ADD  CONSTRAINT [FK_Inf_Repair_Inf_Customers] FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Inf_Customers] ([Customer_Id])
GO
ALTER TABLE [dbo].[Inf_Repair] CHECK CONSTRAINT [FK_Inf_Repair_Inf_Customers]
GO
ALTER TABLE [dbo].[Salary_Staff]  WITH CHECK ADD  CONSTRAINT [FK_Salary_Staff_Inf_Staff1] FOREIGN KEY([Staff_Id])
REFERENCES [dbo].[Inf_Staff] ([Staff_Id])
GO
ALTER TABLE [dbo].[Salary_Staff] CHECK CONSTRAINT [FK_Salary_Staff_Inf_Staff1]
GO
USE [master]
GO
ALTER DATABASE [ProjectOne] SET  READ_WRITE 
GO
