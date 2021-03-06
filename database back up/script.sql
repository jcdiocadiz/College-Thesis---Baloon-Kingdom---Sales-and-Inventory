USE [master]
GO
/****** Object:  Database [BKDatabase]    Script Date: 09/07/2010 01:52:30 ******/
CREATE DATABASE [BKDatabase] ON  PRIMARY 
( NAME = N'BKDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\BKDatabase.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BKDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\BKDatabase_log.ldf' , SIZE = 1536KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'BKDatabase', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BKDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BKDatabase] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BKDatabase] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BKDatabase] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BKDatabase] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BKDatabase] SET ARITHABORT OFF
GO
ALTER DATABASE [BKDatabase] SET AUTO_CLOSE ON
GO
ALTER DATABASE [BKDatabase] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BKDatabase] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BKDatabase] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BKDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BKDatabase] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BKDatabase] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BKDatabase] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BKDatabase] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BKDatabase] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BKDatabase] SET  DISABLE_BROKER
GO
ALTER DATABASE [BKDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BKDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BKDatabase] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BKDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BKDatabase] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BKDatabase] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BKDatabase] SET  READ_WRITE
GO
ALTER DATABASE [BKDatabase] SET RECOVERY SIMPLE
GO
ALTER DATABASE [BKDatabase] SET  MULTI_USER
GO
ALTER DATABASE [BKDatabase] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BKDatabase] SET DB_CHAINING OFF
GO
USE [BKDatabase]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[Item Number] [int] NOT NULL,
	[Item ID] [int] NULL,
	[COF Number] [int] NULL,
	[Category Name] [varchar](50) NULL,
	[Sub Category] [varchar](50) NULL,
	[Specific Category] [varchar](50) NULL,
	[Item Name] [varchar](50) NULL,
	[Supplier] [varchar](50) NULL,
	[Width] [decimal](18, 2) NULL,
	[Height] [decimal](18, 2) NULL,
	[Size] [varchar](50) NULL,
	[Color] [varchar](50) NULL,
	[Type] [varchar](50) NULL,
	[Unit] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Unit Cost] [decimal](18, 2) NULL,
	[Sub Cost] [decimal](18, 2) NULL,
	[Back Order] [int] NULL,
	[Lost Item] [int] NULL,
	[Returned Item] [int] NULL,
 CONSTRAINT [PK_Item_1] PRIMARY KEY CLUSTERED 
(
	[Item Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Invoice ID] [int] NOT NULL,
	[COF Number] [int] NULL,
	[Date Generate] [datetime] NULL,
	[Time Generate] [datetime] NULL,
	[Order Amount] [decimal](18, 2) NULL,
	[Service Charge] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Invoice ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory Transactions]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventory Transactions](
	[Item ID] [int] NULL,
	[Item Name] [varchar](50) NULL,
	[Type of Transaction] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Date and Time] [datetime] NULL,
	[Transaction done by] [varchar](50) NULL,
	[Reason] [varchar](100) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventory](
	[Item ID] [int] NOT NULL,
	[Category Name] [varchar](50) NULL,
	[Sub Category] [varchar](50) NULL,
	[Specific Category] [varchar](50) NULL,
	[Item Name] [varchar](50) NULL,
	[Item Type] [varchar](50) NULL,
	[Size] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Unit] [varchar](50) NULL,
	[Unit Price] [decimal](18, 2) NULL,
	[Selling Price] [decimal](18, 2) NULL,
	[Quantity in Stock] [decimal](18, 2) NULL,
	[Quantity in Order] [decimal](18, 2) NULL,
	[Status] [varchar](50) NULL,
	[Color] [varchar](50) NULL,
	[Width] [decimal](18, 2) NULL,
	[Height] [decimal](18, 2) NULL,
	[Supplier] [varchar](50) NULL,
	[Lost Item] [int] NULL,
	[Returned Item] [int] NULL,
	[Back Order] [int] NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Item ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Category Name] [varchar](50) NULL,
	[Sub Category] [varchar](50) NULL,
	[Specific Category] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cancel Refund]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cancel Refund](
	[Cancel Refund ID] [int] NULL,
	[COF Number] [int] NULL,
	[Customer ID] [int] NULL,
	[Date Cancelled] [datetime] NULL,
	[Total Amount] [decimal](18, 2) NULL,
	[Refund Amount] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Customer ID] [int] NOT NULL,
	[Last Name] [varchar](50) NULL,
	[Middle Initial] [varchar](50) NULL,
	[First Name] [varchar](50) NULL,
	[Address] [text] NULL,
	[Home Phone] [varchar](50) NULL,
	[Cellphone] [varchar](50) NULL,
	[Email Address] [text] NULL,
	[Status] [varchar](50) NULL,
	[No of Orders] [int] NULL,
	[Cancel Order] [int] NULL,
	[Processed Order] [int] NULL,
	[Pending Order] [int] NULL,
	[Waiting Order] [int] NULL,
 CONSTRAINT [PK_Customer_1] PRIMARY KEY CLUSTERED 
(
	[Customer ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orderline]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orderline](
	[COF Number] [int] NOT NULL,
	[Customer ID] [int] NULL,
	[Lastname] [varchar](50) NULL,
	[First Name] [nchar](10) NULL,
	[Middle Initial] [varchar](3) NULL,
	[Order Date] [datetime] NULL,
	[Event Date] [datetime] NULL,
	[Event Time] [datetime] NULL,
	[Theme] [varchar](50) NULL,
	[Color Motif] [varchar](50) NULL,
	[Venue] [varchar](150) NULL,
	[Balance] [decimal](18, 2) NULL,
	[Order Amount] [decimal](18, 2) NULL,
	[Down payment] [decimal](18, 2) NULL,
	[Full payment] [decimal](18, 2) NULL,
	[Service Charge] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Status] [varchar](50) NULL,
	[Official Receipt] [varchar](50) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Overall Total] [decimal](18, 2) NULL,
	[Refund] [decimal](18, 2) NULL,
	[Vat Amount] [decimal](18, 2) NULL,
	[Vat Percentage] [decimal](18, 2) NULL,
	[Delivery Status] [varchar](50) NULL,
	[Rent Deposit] [decimal](18, 2) NULL,
 CONSTRAINT [PK_orderline] PRIMARY KEY CLUSTERED 
(
	[COF Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Official Receipt]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Official Receipt](
	[OR ID] [int] NOT NULL,
	[Date and Time Generate] [datetime] NULL,
	[OR Number] [varchar](50) NULL,
	[COF Number] [int] NULL,
	[VAT Percentage] [decimal](18, 2) NULL,
	[VAT Amount] [decimal](18, 2) NULL,
	[Order Amount] [decimal](18, 2) NULL,
	[Service Charge] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Recorded by] [varchar](50) NULL,
 CONSTRAINT [PK_Official Receipt] PRIMARY KEY CLUSTERED 
(
	[OR ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[COF Number] [int] NOT NULL,
	[Customer ID] [int] NULL,
	[Total Amount] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[Overall Total] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PO Items]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PO Items](
	[Item ID] [int] NULL,
	[PO Item ID] [int] NOT NULL,
	[POF Number] [int] NULL,
	[Category Name] [varchar](50) NULL,
	[Specific Category] [varchar](50) NULL,
	[Sub-Category] [varchar](50) NULL,
	[Item Name] [varchar](50) NULL,
	[Size] [varchar](50) NULL,
	[Color] [varchar](50) NULL,
	[Height] [decimal](18, 2) NULL,
	[Weight] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[Unit] [varchar](50) NULL,
	[Unit Price] [decimal](18, 2) NULL,
	[Sub Total] [decimal](18, 2) NULL,
	[Quantity Received] [int] NULL,
	[Undersupplied] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Purchase](
	[POF Number] [int] NOT NULL,
	[Date of Purchase] [datetime] NULL,
	[Time of Purchase] [datetime] NULL,
	[Supplier ID] [int] NULL,
	[Supplier Name] [varchar](50) NULL,
	[Address] [varchar](300) NULL,
	[Contact Number] [varchar](50) NULL,
	[Total Quantity] [int] NULL,
	[Total Amount] [decimal](18, 0) NULL,
	[Vat Amount] [decimal](18, 0) NULL,
	[Vat Percentage] [int] NULL,
	[Status] [varchar](50) NULL,
	[Balance] [decimal](18, 0) NULL,
	[Deposit] [decimal](18, 0) NULL,
	[Full Payment] [decimal](18, 0) NULL,
	[Date Received] [datetime] NULL,
	[Time Received] [datetime] NULL,
	[Undersupplied] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[POF Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Receive PO Item]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Receive PO Item](
	[Receive Number] [int] NOT NULL,
	[POF Number] [int] NULL,
	[Item ID] [int] NULL,
	[Date Received] [datetime] NULL,
	[Time Received] [datetime] NULL,
	[Quantity Purchased] [int] NULL,
	[Quantity Received] [int] NULL,
	[Undersupplied] [int] NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Receive PO Item] PRIMARY KEY CLUSTERED 
(
	[Receive Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rented Items]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rented Items](
	[Returned Item ID] [int] NOT NULL,
	[COF Number] [int] NULL,
	[Customer ID] [int] NULL,
	[Date Returned] [datetime] NULL,
	[Time Returned] [datetime] NULL,
	[Quantity Rented] [int] NULL,
	[Quantity Returned] [int] NULL,
	[Lost Item] [int] NULL,
	[Total Amount] [decimal](18, 2) NULL,
	[Payment] [decimal](18, 2) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Rented Items] PRIMARY KEY CLUSTERED 
(
	[Returned Item ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rental Refund]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental Refund](
	[Rental Refund ID] [int] NOT NULL,
	[COF Number] [int] NULL,
	[Date Released] [datetime] NULL,
	[Time Released] [datetime] NULL,
	[Refund Amount] [decimal](18, 2) NULL,
	[Rental Amount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Rental Refund] PRIMARY KEY CLUSTERED 
(
	[Rental Refund ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental Checklist]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rental Checklist](
	[Checklist Number] [int] NOT NULL,
	[COF Number] [int] NULL,
	[Item ID] [int] NULL,
	[Category Name] [varchar](50) NULL,
	[Sub Category] [varchar](50) NULL,
	[Specific Category] [varchar](50) NULL,
	[Item Name] [varchar](50) NULL,
	[Date OUT] [datetime] NULL,
	[Time OUT] [datetime] NULL,
	[Unit] [varchar](50) NULL,
	[Quantity OUT] [int] NULL,
	[Quantity IN] [int] NULL,
	[Date IN] [datetime] NULL,
	[Time IN] [datetime] NULL,
	[Quantity Missing] [int] NULL,
	[Issued By] [varchar](50) NULL,
	[Picked Up By] [varchar](50) NULL,
	[Recorded Issuance By] [varchar](50) NULL,
	[Returned By] [varchar](50) NULL,
	[Recorded Return By] [varchar](50) NULL,
	[ID] [varchar](50) NULL,
	[Deposit Amount] [decimal](18, 2) NULL,
	[Refund Amount] [decimal](18, 2) NULL,
	[Rental Amount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Rental Checklist] PRIMARY KEY CLUSTERED 
(
	[Checklist Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[Supplier ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Contact] [varchar](50) NOT NULL,
	[Email Address] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Supplier ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Security]    Script Date: 09/07/2010 01:52:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Security](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_Security] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SearchPOFnum]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchPOFnum]
(
	@POFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        [POF Number], [Date of Purchase], [Time of Purchase], [Supplier ID], [Supplier Name], Address, [Contact Number], [Total Quantity], [Total Amount], [Vat Amount], 
                         [Vat Percentage], Status, Balance, Deposit, [Full Payment], [Date Received], [Time Received], Undersupplied
FROM            Purchase
WHERE        ([POF Number] LIKE @POFNumber + '%')
GO
/****** Object:  StoredProcedure [dbo].[SearchInventoryRec]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchInventoryRec]
(
	@ItemID int,
	@CategoryName varchar(50),
	@SubCategory varchar(50),
	@ItemName varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Type], [Item Name], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        ([Item ID] = @ItemID) OR
                         ([Category Name] = @CategoryName) OR
                         ([Sub Category] = @SubCategory) OR
                         ([Item Name] = @ItemName)
GO
/****** Object:  StoredProcedure [dbo].[SearchInvByCategoryAndName]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchInvByCategoryAndName]
(
	@CategoryName varchar(50),
	@SubCategory varchar(50),
	@Specific_Category varchar(50),
	@ItemName varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        ([Category Name] LIKE @CategoryName + '%') OR
                         ([Sub Category] LIKE @SubCategory + '%') OR
                         ([Specific Category] LIKE @Specific_Category + '%') OR
                         ([Item Name] LIKE @ItemName + '%')
GO
/****** Object:  StoredProcedure [dbo].[SearchCustByLastOrFirst]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchCustByLastOrFirst]
(
	@LastName varchar(50),
	@FirstName varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [[Cancel Order], 
                         [Processed Order], [Pending Order]
FROM            Customer
WHERE        ([Last Name] = @LastName) OR
                         ([First Name] = @FirstName) AND (Status = 'Active')
GO
/****** Object:  StoredProcedure [dbo].[SearchCustByLastAndFirst]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchCustByLastAndFirst]
(
	@FirstName varchar(50),
	@LastName varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        ([First Name] LIKE @FirstName + '%') AND (Status = 'Active') OR
                         (Status = 'Active') AND ([Last Name] LIKE @LastName + '%')
GO
/****** Object:  StoredProcedure [dbo].[SearchCustByID]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchCustByID]
(
	@CustomerID int
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        ([Customer ID] = @CustomerID) AND (Status = 'Active')
GO
/****** Object:  StoredProcedure [dbo].[SearchByID]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchByID]
(
	@Item_ID int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[SearchByCustID]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchByCustID]
(
	@CustomerID int
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [[Cancel Order], 
                         [Processed Order], [Pending Order]
FROM            Customer
WHERE        ([Customer ID] = @CustomerID) AND (Status = 'Active')
GO
/****** Object:  StoredProcedure [dbo].[SearchByCOF]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchByCOF]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[Salesdate]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Salesdate]
(
	@OrderDate datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] LIKE @OrderDate + '%')
GO
/****** Object:  StoredProcedure [dbo].[Sales]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sales]
(
	@OrderDate datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] = @OrderDate)
GO
/****** Object:  StoredProcedure [dbo].[RentView]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RentView]
AS
	SET NOCOUNT ON;
SELECT [Returned Item ID], [COF Number], [Customer ID], [Date Returned], [Time Returned], [Quantity Rented], [Quantity Returned], [Lost Item], [Total Amount], Payment, Status FROM dbo.[Rented Items]
GO
/****** Object:  StoredProcedure [dbo].[SuppBeginEnd]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuppBeginEnd]
(
	@Begin int,
	@End int
)
AS
	SET NOCOUNT ON;
SELECT        [Supplier ID], Name, Address, Contact, [Email Address], Status
FROM            Supplier
WHERE        ([Supplier ID] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[Supnme]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Supnme]
(
	@Begin varchar(50),
	@End varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Supplier ID], Name, Address, Contact, [Email Address], Status
FROM            Supplier
WHERE        (Name BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[ShowSupWithoutBO]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ShowSupWithoutBO]
(
	@Supplier varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        (Supplier = @Supplier) AND ([Back Order] = 0)
GO
/****** Object:  StoredProcedure [dbo].[ShowPurwithBO]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ShowPurwithBO]
(
	@Supplier varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        (Supplier = @Supplier) AND ([Back Order] > 0)
GO
/****** Object:  StoredProcedure [dbo].[ShowItems]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ShowItems]
(
	@COF_Number int
)
AS
	SET NOCOUNT ON;
SELECT        [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Supplier, Width, Height, Size, Color, Type, Unit, Quantity, 
                         [Unit Cost], [Sub Cost], [Back Order], [Lost Item], [Returned Item]
FROM            Item
WHERE        ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[SelectQuery]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectQuery]
(
	@COFNum int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], Width, Height, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost]
FROM            Item
WHERE        ([COF Number] = @COFNum)
GO
/****** Object:  StoredProcedure [dbo].[SelectCommand]    Script Date: 09/07/2010 01:52:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Item.[COF Number], Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Orderline.[COF Number] AS Expr1, Orderline.Lastname, Orderline.[First Name], 
                         Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, 
                         Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], Orderline.Total, Orderline.Discount, 
                         Orderline.[Overall Total]
FROM            Item INNER JOIN
                         Orderline ON Item.[COF Number] = Orderline.[COF Number]
WHERE        (Item.[COF Number] = @COFNumber) AND (Orderline.[COF Number] = @COFNumber)
GO
/****** Object:  View [dbo].[vwOrdersByCOFNumber]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwOrdersByCOFNumber]
AS
SELECT        dbo.Orderline.[COF Number], dbo.Orderline.[Customer ID], dbo.Orderline.Lastname, dbo.Orderline.[First Name], dbo.Orderline.[Middle Initial], 
                         dbo.Orderline.[Order Date], dbo.Orderline.[Event Date], dbo.Orderline.[Event Time], dbo.Orderline.Theme, dbo.Orderline.[Color Motif], dbo.Orderline.Venue, 
                         dbo.Orderline.Balance, dbo.Orderline.[Order Amount], dbo.Orderline.[Down payment], dbo.Orderline.[Full payment], dbo.Orderline.[Service Charge], 
                         dbo.Orderline.Total, dbo.Orderline.Status, dbo.Orderline.[Official Receipt], dbo.Item.[Item Number], dbo.Item.[Item ID], dbo.Item.[Sub Category], 
                         dbo.Item.[Specific Category], dbo.Item.[Item Name], dbo.Item.Supplier, dbo.Item.Width, dbo.Item.Height, dbo.Item.Size, dbo.Item.Type, dbo.Item.Unit, 
                         dbo.Item.Quantity, dbo.Item.[Unit Cost], dbo.Item.[Sub Cost], dbo.Item.[Back Order], dbo.Item.Color
FROM            dbo.Orderline LEFT OUTER JOIN
                         dbo.Item ON dbo.Orderline.[COF Number] = dbo.Item.[COF Number]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[21] 2[29] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4[30] 2[40] 3) )"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2[66] 3) )"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 5
   End
   Begin DiagramPane = 
      PaneHidden = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Orderline"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 135
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Item"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 135
               Right = 427
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
         Begin ParameterName = "@cofnumber"
            ParameterValue = "2"
         End
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwOrdersByCOFNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwOrdersByCOFNumber'
GO
/****** Object:  StoredProcedure [dbo].[ViewWaitingOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewWaitingOrder]
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        (Status = 'Waiting')
GO
/****** Object:  StoredProcedure [dbo].[ViewRentItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewRentItem]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Supplier, Width, Height, Size, Color, Type, Unit, Quantity, 
                         [Unit Cost], [Sub Cost], [Back Order], [Lost Item], [Returned Item]
FROM            Item
WHERE        ([COF Number] = @COFNumber) AND (Type = 'Rental')
GO
/****** Object:  StoredProcedure [dbo].[viewrentalchklst]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[viewrentalchklst]
AS
	SET NOCOUNT ON;
SELECT [Checklist Number], [COF Number], [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Date OUT], [Time OUT], Unit, [Quantity OUT], [Quantity IN], [Date IN], [Time IN], [Quantity Missing], [Issued By], [Picked Up By], [Recorded Issuance By], [Returned By], [Recorded Return By], ID, [Deposit Amount], [Refund Amount] FROM dbo.[Rental Checklist]
GO
/****** Object:  StoredProcedure [dbo].[ViewRentalChecklist]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewRentalChecklist]
AS
	SET NOCOUNT ON;
SELECT [Checklist Number], [COF Number], [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Date OUT], [Time OUT], Unit, [Quantity OUT], [Quantity IN], [Date IN], [Time IN], [Quantity Missing], [Issued By], [Picked Up By], [Recorded Issuance By], [Returned By], [Recorded Return By], ID, [Deposit Amount], [Refund Amount], [Rental Amount] FROM dbo.[Rental Checklist]
GO
/****** Object:  StoredProcedure [dbo].[ViewRentalChcklist]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewRentalChcklist]
AS
	SET NOCOUNT ON;
SELECT [Checklist Number], [COF Number], [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Date OUT], [Time OUT], Unit, [Quantity OUT], [Quantity IN], [Date IN], [Time IN], [Quantity Missing], [Issued By], [Picked Up By], [Recorded Issuance By], [Returned By], [Recorded Return By], ID, [Deposit Amount], [Refund Amount] FROM dbo.[Rental Checklist]
GO
/****** Object:  StoredProcedure [dbo].[ViewPurItemlessthan10]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewPurItemlessthan10]
(
	@Supplier varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        (Supplier = @Supplier) AND ([Back Order] < 10)
GO
/****** Object:  StoredProcedure [dbo].[ViewProcessedOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewProcessedOrder]
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        (Status = 'Processed')
GO
/****** Object:  StoredProcedure [dbo].[ViewPOItems]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewPOItems]
(
	@POFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [PO Item ID], [POF Number], [Category Name], [Specific Category], [Sub-Category], [Item Name], Size, Color, Height, Weight, Quantity, Unit, [Unit Price], 
                         [Sub Total], [Quantity Received], Undersupplied
FROM            [PO Items]
WHERE        ([POF Number] = @POFNumber)
GO
/****** Object:  StoredProcedure [dbo].[ViewPendingOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewPendingOrder]
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        (Status = 'Pending')
GO
/****** Object:  StoredProcedure [dbo].[ViewOrderline]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewOrderline]
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
GO
/****** Object:  StoredProcedure [dbo].[ViewOrderByCofNumber]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewOrderByCofNumber]
(
	@cofnumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.[Customer ID], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], 
                         Orderline.[Event Time], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], 
                         Orderline.[Full payment], Orderline.[Service Charge], Orderline.Total, Orderline.Status, Orderline.[Official Receipt], Orderline.Discount, Orderline.[Overall Total], 
                         Orderline.Refund, Orderline.[Vat Amount], Orderline.[Vat Percentage], Orderline.[Delivery Status], Orderline.[Rent Deposit]
FROM            Orderline LEFT OUTER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number]
WHERE        (Orderline.[COF Number] = @cofnumber)
GO
/****** Object:  StoredProcedure [dbo].[ViewLostQty]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewLostQty]
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        ([Item Type] = 'Rental')
GO
/****** Object:  StoredProcedure [dbo].[VIEWlost]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VIEWlost]
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Item Name], [Item Type], Quantity, [Lost Item]
FROM            Inventory
WHERE        ([Item Type] = 'Rental')
GO
/****** Object:  StoredProcedure [dbo].[ViewItemsCOFNum]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewItemsCOFNum]
(
	@COF_Number int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], Width, Height, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost]
FROM            Item
WHERE        ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[ViewItemsCOF]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewItemsCOF]
(
	@COF_number int
)
AS
	SET NOCOUNT ON;
SELECT        [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Width, Height, Color, Type, Unit, Quantity, [Unit Cost], 
                         [Sub Cost]
FROM            Item
WHERE        ([COF Number] = @COF_number)
GO
/****** Object:  StoredProcedure [dbo].[ViewItems]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewItems]
AS
	SET NOCOUNT ON;
SELECT [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Width, Height, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost] FROM dbo.Item
GO
/****** Object:  StoredProcedure [dbo].[ViewInactiveCust]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewInactiveCust]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [[Cancel Order], 
                         [Processed Order], [Pending Order]
FROM            Customer
WHERE        (Status = 'Inactive')
GO
/****** Object:  StoredProcedure [dbo].[ViewCustomers]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewCustomers]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        (Status = 'Active')
GO
/****** Object:  StoredProcedure [dbo].[ViewCustomer]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewCustomer]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address]
FROM            Customer
GO
/****** Object:  StoredProcedure [dbo].[ViewCustItems]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewCustItems]
(
	@COF_Num int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], Width, Height, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost]
FROM            Item
WHERE        ([COF Number] = @COF_Num)
GO
/****** Object:  StoredProcedure [dbo].[ViewCust]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewCust]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
GO
/****** Object:  StoredProcedure [dbo].[ViewCartItems]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewCartItems]
(
	@COF_Num int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Width, Height, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost]
FROM            Item
WHERE        ([COF Number] = @COF_Num)
GO
/****** Object:  StoredProcedure [dbo].[ViewCartCOFNum]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewCartCOFNum]
(
	@COF_Number int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], Width, Height, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost]
FROM            Item
WHERE        ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[ViewCartCOF1]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewCartCOF1]
(
	@COF_Number int
)
AS
	SET NOCOUNT ON;
SELECT        [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Supplier, Width, Height, Size, Color, Type, Unit, Quantity, 
                         [Unit Cost], [Sub Cost], [Back Order], [Lost Item], [Returned Item]
FROM            Item
WHERE        ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[ViewCancelledOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewCancelledOrder]
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        (Status = 'Cancelled')
GO
/****** Object:  StoredProcedure [dbo].[ViewBelow100]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewBelow100]
(
	@Supplier varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        (Supplier = @Supplier) AND ([Back Order] > 0) AND ([Quantity in Stock] < 100)
GO
/****** Object:  StoredProcedure [dbo].[ViewAllSupplier]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewAllSupplier]
AS
	SET NOCOUNT ON;
SELECT        [Supplier ID], Name, Address, Contact, [Email Address], Status
FROM            Supplier
WHERE        (Status = 'Active')
GO
/****** Object:  StoredProcedure [dbo].[ViewAllCustRec]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewAllCustRec]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        (Status = 'Active')
GO
/****** Object:  StoredProcedure [dbo].[ViewAllCust]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewAllCust]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address]
FROM            Customer
GO
/****** Object:  StoredProcedure [dbo].[ViewAll]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewAll]
AS
	SET NOCOUNT ON;
SELECT        [OR ID], [Date Generate], [Time Generate], [OR Number], [COF Number], [VAT Percentage], [VAT Amount], [Order Amount], [Service Charge], Total
FROM            [Official Receipt]
GO
/****** Object:  StoredProcedure [dbo].[View_InactiveCust]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[View_InactiveCust]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        (Status = 'Inactive')
GO
/****** Object:  StoredProcedure [dbo].[View InactiveCust]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[View InactiveCust]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        (Status = 'Inactive')
GO
/****** Object:  StoredProcedure [dbo].[View]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[View]
AS
	SET NOCOUNT ON;
SELECT [Rental Refund ID], [COF Number], [Date Released], [Time Released], [Refund Amount], [Rental Amount] FROM dbo.[Rental Refund]
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplierAccount]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSupplierAccount]
(
	@Supplier_ID int,
	@Name varchar(50),
	@Address varchar(50),
	@Contact varchar(50),
	@Email_Address varchar(50),
	@Original_Supplier_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Supplier
SET                [Supplier ID] = @Supplier_ID, Name = @Name, Address = @Address, Contact = @Contact, [Email Address] = @Email_Address
WHERE        ([Supplier ID] = @Original_Supplier_ID);
	  
SELECT [Supplier ID], Name, Address, Contact, [Email Address], Status FROM Supplier WHERE ([Supplier ID] = @Supplier_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateRentItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateRentItem]
(
	@Lost_Item int,
	@Returned_Item int,
	@COFNumber int,
	@ItemID int,
	@Item_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Item
SET                [Lost Item] = @Lost_Item, [Returned Item] = @Returned_Item
WHERE        ([COF Number] = @COFNumber) AND ([Item ID] = @ItemID);
	 
SELECT [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Supplier, Width, Height, Size, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost], [Back Order], [Lost Item], [Returned Item] FROM Item WHERE ([Item Number] = @Item_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuery]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateQuery]
(
	@TotalQty int,
	@Total_Amount decimal(18, 0),
	@Vat_Amount decimal(18, 0),
	@Vat_Percentage int,
	@Status varchar(50),
	@Balance decimal(18, 0),
	@Deposit decimal(18, 0),
	@Full_Payment decimal(18, 0),
	@Original_POF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Purchase
SET                [Total Quantity] = @TotalQty, [Total Amount] = @Total_Amount, [Vat Amount] = @Vat_Amount, [Vat Percentage] = @Vat_Percentage, Status = @Status, 
                         Balance = @Balance, Deposit = @Deposit, [Full Payment] = @Full_Payment
WHERE        ([POF Number] = @Original_POF_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdatePOStatus]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePOStatus]
(
	@Status varchar(50),
	@Original_POF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Purchase
SET                Status = @Status
WHERE        ([POF Number] = @Original_POF_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdatePayment]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePayment]
(
	@COF_Number int,
	@Balance decimal(18, 2),
	@Order_Amount decimal(18, 2),
	@Down_payment decimal(18, 2),
	@Full_payment decimal(18, 2),
	@Service_Charge decimal(18, 2),
	@Total decimal(18, 2),
	@Status varchar(50),
	@Original_COF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Orderline
SET                [COF Number] = @COF_Number, Balance = @Balance, [Order Amount] = @Order_Amount, [Down payment] = @Down_payment, [Full payment] = @Full_payment, 
                         [Service Charge] = @Service_Charge, Total = @Total, Status = @Status
WHERE        ([COF Number] = @Original_COF_Number);
	 
SELECT [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], [Rent Deposit] FROM Orderline WHERE ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdatePay]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePay]
(
	@Full_payment decimal(18, 2),
	@Total decimal(18, 2),
	@Status varchar(50),
	@DownPayment decimal(18, 2),
	@Balance decimal(18, 2),
	@Original_COF_Number int,
	@COF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Orderline
SET                [Full payment] = @Full_payment, Total = @Total, Status = @Status, [Down payment] = @DownPayment, Balance = @Balance
WHERE        ([COF Number] = @Original_COF_Number);
	 
SELECT [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], [Rent Deposit] FROM Orderline WHERE ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassword]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePassword]
(
	@Password varchar(50),
	@Original_Username varchar(50),
	@Username varchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE       Security
SET                Password = @Password
WHERE        (Username = @Original_Username);
	 
SELECT Username, Password FROM Security WHERE (Username = @Username)
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateOrder]
(
	@Status varchar(50),
	@Original_COF_Number int,
	@COF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Orderline
SET                Status = @Status
WHERE        ([COF Number] = @Original_COF_Number);
	 
SELECT [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], [Rent Deposit] FROM Orderline WHERE ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdateItemQty]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateItemQty]
(
	@Quantity int,
	@Unit_Cost decimal(18, 2),
	@Sub_Cost decimal(18, 2),
	@Original_Item_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Item
SET                Quantity = @Quantity, [Unit Cost] = @Unit_Cost, [Sub Cost] = @Sub_Cost
WHERE        ([Item Number] = @Original_Item_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdateItemBackOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateItemBackOrder]
(
	@Back_Order int,
	@Original_Item_Number int,
	@Item_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Item
SET                [Back Order] = @Back_Order
WHERE        ([Item Number] = @Original_Item_Number);
	 
SELECT [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Supplier, Width, Height, Size, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost], [Back Order], [Lost Item], [Returned Item] FROM Item WHERE ([Item Number] = @Item_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvRentItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInvRentItem]
(
	@Lost_Item int,
	@Returned_Item int,
	@ItemID int,
	@COFNumber int,
	@Item_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Item
SET                [Lost Item] = @Lost_Item, [Returned Item] = @Returned_Item
WHERE        ([Item ID] = @ItemID) AND ([COF Number] = @COFNumber);
	 
SELECT [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Supplier, Width, Height, Size, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost], [Back Order], [Lost Item], [Returned Item] FROM Item WHERE ([Item Number] = @Item_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvRec]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInvRec]
(
	@Category_Name varchar(50),
	@Sub_Category varchar(50),
	@Specific_Category varchar(50),
	@Item_Type varchar(50),
	@Item_Name varchar(50),
	@Size varchar(50),
	@Unit varchar(50),
	@Unit_Price decimal(18, 2),
	@Amount decimal(18, 2),
	@Color varchar(50),
	@Width decimal(18, 2),
	@Height decimal(18, 2),
	@Supplier varchar(50),
	@Original_Item_ID int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Inventory] SET [Category Name] = @Category_Name, [Sub Category] = @Sub_Category, [Specific Category] = @Specific_Category, [Item Type] = @Item_Type, [Item Name] = @Item_Name, [Size] = @Size, [Unit] = @Unit, [Unit Price] = @Unit_Price, [Amount] = @Amount, [Color] = @Color, [Width] = @Width, [Height] = @Height, [Supplier] = @Supplier  WHERE (([Item ID] = @Original_Item_ID));
	
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Type], [Item Name], Size, Quantity, Unit, [Unit Price], Amount, [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvQuantity]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInvQuantity]
(
	@Quantity int,
	@Quantity_in_Stock decimal(18, 2),
	@Back_Order int,
	@Original_Item_ID int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Inventory
SET                Quantity = @Quantity, [Quantity in Stock] = @Quantity_in_Stock, [Back Order] = @Back_Order
WHERE        ([Item ID] = @Original_Item_ID);
	 
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvLostandRet]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInvLostandRet]
(
	@Quantity int,
	@Quantity_in_Stock decimal(18, 2),
	@Lost_Item int,
	@Returned_Item int,
	@Original_Item_ID int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Inventory
SET                Quantity = @Quantity, [Quantity in Stock] = @Quantity_in_Stock, [Lost Item] = @Lost_Item, [Returned Item] = @Returned_Item
WHERE        ([Item ID] = @Original_Item_ID);
	 
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvItem1]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInvItem1]
(
	@Quantity int,
	@Quantity_in_Stock decimal(18, 2),
	@Quantity_in_Order decimal(18, 2),
	@Original_Item_ID int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Inventory
SET                Quantity = @Quantity, [Quantity in Stock] = @Quantity_in_Stock, [Quantity in Order] = @Quantity_in_Order
WHERE        ([Item ID] = @Original_Item_ID);
	 
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInvItem]
(
	@Quantity_in_Stock decimal(18, 2),
	@Quantity_in_Order decimal(18, 2),
	@Original_Item_ID int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Inventory
SET                [Quantity in Stock] = @Quantity_in_Stock, [Quantity in Order] = @Quantity_in_Order
WHERE        ([Item ID] = @Original_Item_ID);
	 
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateInventoryRecord]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInventoryRecord]
(
	@Category_Name varchar(50),
	@Sub_Category varchar(50),
	@Specific_Category varchar(50),
	@Item_Name varchar(50),
	@Item_Type varchar(50),
	@Size varchar(50),
	@Unit varchar(50),
	@Color varchar(50),
	@Width decimal(18, 2),
	@Height decimal(18, 2),
	@Supplier varchar(50),
	@Original_Item_ID int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Inventory] SET [Category Name] = @Category_Name, [Sub Category] = @Sub_Category, [Specific Category] = @Specific_Category, [Item Name] = @Item_Name, [Item Type] = @Item_Type, [Size] = @Size, [Unit] = @Unit, [Color] = @Color, [Width] = @Width, [Height] = @Height, [Supplier] = @Supplier WHERE (([Item ID] = @Original_Item_ID));
	
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvCat]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInvCat]
(
	@Category_Name varchar(50),
	@Sub_Category varchar(50),
	@Specific_Category varchar(50),
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Inventory
SET                [Category Name] = @Category_Name, [Sub Category] = @Sub_Category, [Specific Category] = @Specific_Category
WHERE        ([Category Name] = @Category_Name) AND ([Sub Category] = @Sub_Category) AND ([Specific Category] = @Specific_Category);
	 
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateDuplicateItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDuplicateItem]
(
	@Quantity int,
	@Quantity_in_Stock int,
	@Status varchar(50),
	@Original_Item_ID int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Inventory] SET [Quantity] = @Quantity, [Quantity in Stock] = @Quantity_in_Stock, [Status] = @Status WHERE (([Item ID] = @Original_Item_ID));
	
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Type], [Item Name], Size, Quantity, Unit, [Unit Price],[Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustOrder]
(
	@No_of_Orders int,
	@CancelOrder int,
	@Processed_Order int,
	@Pending_Order int,
	@Waiting_Order int,
	@Original_Customer_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Customer
SET                [No of Orders] = @No_of_Orders, [Cancel Order] = @CancelOrder, [Processed Order] = @Processed_Order, [Pending Order] = @Pending_Order, 
                         [Waiting Order] = @Waiting_Order
WHERE        ([Customer ID] = @Original_Customer_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerAcct]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomerAcct]
(
	@Last_Name varchar(50),
	@Middle_Initial varchar(50),
	@First_Name varchar(50),
	@Address text,
	@Home_Phone varchar(50),
	@Cellphone varchar(50),
	@Email_Address text,
	@Original_Customer_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Customer
SET                [Last Name] = @Last_Name, [Middle Initial] = @Middle_Initial, [First Name] = @First_Name, Address = @Address, [Home Phone] = @Home_Phone, 
                         Cellphone = @Cellphone, [Email Address] = @Email_Address
WHERE        ([Customer ID] = @Original_Customer_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateCOFByCustomer]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCOFByCustomer]
(
	@Lastname varchar(50),
	@First_Name nchar(10),
	@Middle_Initial varchar(3),
	@Customer_ID int,
	@COF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Orderline
SET                Lastname = @Lastname, [First Name] = @First_Name, [Middle Initial] = @Middle_Initial
WHERE        ([Customer ID] = @Customer_ID);
	 
SELECT [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt] FROM Orderline WHERE ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[UpdateCartItems]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCartItems]
(
	@Category_Name varchar(50),
	@Sub_Category varchar(50),
	@Specific_Category varchar(50),
	@Item_Name varchar(50),
	@Supplier varchar(50),
	@Width decimal(18, 2),
	@Height decimal(18, 2),
	@Size varchar(50),
	@Color varchar(50),
	@Type varchar(50),
	@Unit varchar(50),
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Item
SET                [Category Name] = @Category_Name, [Sub Category] = @Sub_Category, [Specific Category] = @Specific_Category, [Item Name] = @Item_Name, 
                         Supplier = @Supplier, Width = @Width, Height = @Height, Size = @Size, Color = @Color, Type = @Type, Unit = @Unit
WHERE        ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[UpdateBackOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBackOrder]
(
	@Back_Order int,
	@Original_Item_ID int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Inventory
SET                [Back Order] = @Back_Order
WHERE        ([Item ID] = @Original_Item_ID);
	 
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[tryone]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tryone]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Item.[COF Number], Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Orderline.[COF Number] AS Expr1, Orderline.Lastname, Orderline.[First Name], 
                         Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.[Event Time], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, 
                         Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], Orderline.Total, Orderline.Discount, 
                         Orderline.[Overall Total]
FROM            Item INNER JOIN
                         Orderline ON Item.[COF Number] = Orderline.[COF Number]
WHERE        (Item.[COF Number] = @COFNumber) AND (Orderline.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[tryMonths]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tryMonths]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[tryMonth]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tryMonth]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] = @Begin) AND ([Order Date] = @End)
GO
/****** Object:  StoredProcedure [dbo].[trylastagain]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[trylastagain]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Item.[COF Number], Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Orderline.[COF Number] AS Expr1, Orderline.Lastname, Orderline.[First Name], 
                         Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.[Event Time], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, 
                         Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], Orderline.Total, Orderline.Discount, 
                         Orderline.[Overall Total]
FROM            Item INNER JOIN
                         Orderline ON Item.[COF Number] = Orderline.[COF Number]
WHERE        (Item.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[TryDate]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TryDate]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] >= @Begin) AND ([Order Date] <= @End)
GO
/****** Object:  StoredProcedure [dbo].[Refund]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Refund]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        [Rental Refund ID], [COF Number], [Date Released], [Time Released], [Refund Amount], [Rental Amount]
FROM            [Rental Refund]
WHERE        ([COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[RcvViewAll]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RcvViewAll]
AS
	SET NOCOUNT ON;
SELECT        [Receive Number], [POF Number], [Item ID], [Date Received], [Time Received], [Quantity Purchased], [Quantity Received], Undersupplied, Status
FROM            [Receive PO Item]
GO
/****** Object:  StoredProcedure [dbo].[RcvNum]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RcvNum]
(
	@ReceiveNumber int
)
AS
	SET NOCOUNT ON;
SELECT        [Receive Number], [POF Number], [Item ID], [Date Received], [Time Received], [Quantity Purchased], [Quantity Received], Undersupplied, Status
FROM            [Receive PO Item]
WHERE        ([Receive Number] = @ReceiveNumber) AND ([Receive Number] = @ReceiveNumber)
GO
/****** Object:  StoredProcedure [dbo].[RcvNo]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RcvNo]
(
	@Begin int,
	@End int
)
AS
	SET NOCOUNT ON;
SELECT        [Receive Number], [POF Number], [Item ID], [Date Received], [Time Received], [Quantity Purchased], [Quantity Received], Undersupplied, Status
FROM            [Receive PO Item]
WHERE        ([Receive Number] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[RcvDate]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RcvDate]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [Receive Number], [POF Number], [Item ID], [Date Received], [Time Received], [Quantity Purchased], [Quantity Received], Undersupplied, Status
FROM            [Receive PO Item]
WHERE        ([Date Received] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[ProcessPO]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProcessPO]
(
	@TotalQty int,
	@Total_Amount decimal(18, 0),
	@Vat_Amount decimal(18, 0),
	@Vat_Percentage int,
	@Status varchar(50),
	@Balance decimal(18, 0),
	@Deposit decimal(18, 0),
	@Full_Payment decimal(18, 0),
	@Undersupplied decimal(18, 2),
	@Original_POF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Purchase
SET                [Total Quantity] = @TotalQty, [Total Amount] = @Total_Amount, [Vat Amount] = @Vat_Amount, [Vat Percentage] = @Vat_Percentage, Status = @Status, 
                         Balance = @Balance, Deposit = @Deposit, [Full Payment] = @Full_Payment, Undersupplied = @Undersupplied
WHERE        ([POF Number] = @Original_POF_Number)
GO
/****** Object:  StoredProcedure [dbo].[ProcessOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProcessOrder]
(
	@Order_Amount decimal(18, 2),
	@Down_payment decimal(18, 2),
	@Full_payment decimal(18, 2),
	@Service_Charge decimal(18, 2),
	@Total decimal(18, 2),
	@Status varchar(50),
	@Official_Receipt varchar(50),
	@Balance decimal(18, 2),
	@Original_COF_Number int,
	@COF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Orderline
SET                [Order Amount] = @Order_Amount, [Down payment] = @Down_payment, [Full payment] = @Full_payment, [Service Charge] = @Service_Charge, Total = @Total, 
                         Status = @Status, [Official Receipt] = @Official_Receipt, Balance = @Balance
WHERE        ([COF Number] = @Original_COF_Number);
	 
SELECT [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], [Rent Deposit] FROM Orderline WHERE ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[POFBeginEnd]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[POFBeginEnd]
(
	@Begin int,
	@End int
)
AS
	SET NOCOUNT ON;
SELECT        [POF Number], [Date of Purchase], [Time of Purchase], [Supplier ID], [Supplier Name], Address, [Contact Number], [Total Quantity], [Total Amount], [Vat Amount], 
                         [Vat Percentage], Status, Balance, Deposit, [Full Payment], [Date Received], [Time Received], Undersupplied
FROM            Purchase
WHERE        ([POF Number] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[PODatebeginend]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PODatebeginend]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [POF Number], [Date of Purchase], [Time of Purchase], [Supplier ID], [Supplier Name], Address, [Contact Number], [Total Quantity], [Total Amount], [Vat Amount], 
                         [Vat Percentage], Status, Balance, Deposit, [Full Payment], [Date Received], [Time Received], Undersupplied
FROM            Purchase
WHERE        ([Date of Purchase] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[POBeginEndDate]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[POBeginEndDate]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [POF Number], [Date of Purchase], [Time of Purchase], [Supplier ID], [Supplier Name], Address, [Contact Number], [Total Quantity], [Total Amount], [Vat Amount], 
                         [Vat Percentage], Status, Balance, Deposit, [Full Payment], [Date Received], [Time Received], Undersupplied
FROM            Purchase
WHERE        ([Date of Purchase] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[PlacingOrder]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PlacingOrder]
(
	@Balance decimal(18, 2),
	@Order_Amount decimal(18, 2),
	@Down_payment decimal(18, 2),
	@Full_payment decimal(18, 2),
	@Service_Charge decimal(18, 2),
	@Total decimal(18, 2),
	@Status varchar(50),
	@Official_Receipt varchar(50),
	@Discount decimal(18, 2),
	@Overall_Total decimal(18, 2),
	@Vat_Amount decimal(18, 2),
	@Vat_Percentage decimal(18, 2),
	@Original_COF_Number int,
	@COF_Number int
)
AS
	SET NOCOUNT OFF;
UPDATE       Orderline
SET                Balance = @Balance, [Order Amount] = @Order_Amount, [Down payment] = @Down_payment, [Full payment] = @Full_payment, [Service Charge] = @Service_Charge,
                          Total = @Total, Status = @Status, [Official Receipt] = @Official_Receipt, Discount = @Discount, [Overall Total] = @Overall_Total, [Vat Amount] = @Vat_Amount, 
                         [Vat Percentage] = @Vat_Percentage
WHERE        ([COF Number] = @Original_COF_Number);
	 
SELECT [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], [Rent Deposit] FROM Orderline WHERE ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[Peste]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Peste]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Item.[COF Number], Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Orderline.[COF Number] AS Expr1, Orderline.Lastname, Orderline.[First Name], 
                         Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, 
                         Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], Orderline.Total, Orderline.Discount, 
                         Orderline.[Overall Total]
FROM            Item INNER JOIN
                         Orderline ON Item.[COF Number] = Orderline.[COF Number]
WHERE        (Item.[COF Number] = @COFNumber) AND (Orderline.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[orselect]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[orselect]
(
	@Begin int,
	@End int
)
AS
	SET NOCOUNT ON;
SELECT        [OR ID], [Date and Time Generate], [OR Number], [COF Number], [VAT Percentage], [VAT Amount], [Order Amount], [Service Charge], Total, [Recorded by]
FROM            [Official Receipt]
WHERE        ([OR ID] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[ORnum]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ORnum]
(
	@OR_ID int
)
AS
	SET NOCOUNT ON;
SELECT        [OR ID], [Date and Time Generate], [OR Number], [COF Number], [VAT Percentage], [VAT Amount], [Order Amount], [Service Charge], Total, [Recorded by]
FROM            [Official Receipt]
WHERE        ([OR ID] = @OR_ID)
GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplierAcct]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSupplierAcct]
(
	@Original_Supplier_ID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Supplier] WHERE (([Supplier ID] = @Original_Supplier_ID) )
GO
/****** Object:  StoredProcedure [dbo].[DeletePO]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePO]
(
	@Original_POF_Number int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Purchase
WHERE        ([POF Number] = @Original_POF_Number)
GO
/****** Object:  StoredProcedure [dbo].[DeleteInvItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteInvItem]
(
	@Original_Item_ID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Inventory] WHERE (([Item ID] = @Original_Item_ID))
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOF]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCOF]
(
	@Original_COF_Number int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Orderline
WHERE        ([COF Number] = @Original_COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[DeleteCartItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCartItem]
(
	@COF_Number int,
	@Item_ID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM Item
WHERE        ([COF Number] = @COF_Number) AND ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[DelCust]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DelCust]
(
	@Original_Customer_ID int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Customer] WHERE (([Customer ID] = @Original_Customer_ID))
GO
/****** Object:  StoredProcedure [dbo].[DeactivateSupplier]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeactivateSupplier]
(
	@Status varchar(50),
	@Original_Supplier_ID int,
	@Supplier_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Supplier
SET                Status = @Status
WHERE        ([Supplier ID] = @Original_Supplier_ID);
	  
SELECT [Supplier ID], Name, Address, Contact, [Email Address], Status FROM Supplier WHERE ([Supplier ID] = @Supplier_ID)
GO
/****** Object:  StoredProcedure [dbo].[DeactivateCust]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeactivateCust]
(
	@Status varchar(50),
	@Original_Customer_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Customer
SET                Status = @Status
WHERE        ([Customer ID] = @Original_Customer_ID)
GO
/****** Object:  StoredProcedure [dbo].[DateSale]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DateSale]
(
	@OrderDate datetime
)
AS
	SET NOCOUNT ON;
SELECT        COUNT(*) AS Expr1, DATEPART(month, [Order Date]) AS Expr2
FROM            Orderline
WHERE        ([Order Date] LIKE @OrderDate + '%')
GROUP BY [Order Date]
GO
/****** Object:  StoredProcedure [dbo].[DailySales]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DailySales]
(
	@OrderDate datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] = @OrderDate)
GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSelectCommand]
(
	@POFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Purchase.[POF Number], Purchase.[Date of Purchase], Purchase.[Supplier Name], Purchase.Address, Purchase.[Contact Number], Purchase.[Total Amount], 
                         Purchase.[Vat Amount], Purchase.Balance, Purchase.Deposit, Purchase.[Full Payment], [PO Items].[POF Number] AS Expr1, [PO Items].[Item Name], 
                         [PO Items].Quantity, [PO Items].[Unit Price], [PO Items].[Sub Total]
FROM            Purchase INNER JOIN
                         [PO Items] ON Purchase.[POF Number] = [PO Items].[POF Number]
WHERE        (Purchase.[POF Number] = @POFNumber) AND ([PO Items].[POF Number] = @POFNumber)
GO
/****** Object:  StoredProcedure [dbo].[MonthlySales]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MonthlySales]
(
	@OrderDate datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] = @OrderDate)
GO
/****** Object:  StoredProcedure [dbo].[Monthly Sales]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Monthly Sales]
(
	@OrderDate datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] BETWEEN @OrderDate AND @OrderDate)
GO
/****** Object:  StoredProcedure [dbo].[Monthly]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Monthly]
(
	@OrderDate datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] LIKE @OrderDate + '%')
GO
/****** Object:  StoredProcedure [dbo].[MaySales]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MaySales]
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] BETWEEN '05-01-2010 12:00:00' AND '05-31-2010 23:59:59')
GO
/****** Object:  StoredProcedure [dbo].[lostqty]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[lostqty]
(
	@LostItem int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        ([Item Type] = 'Rental') AND ([Lost Item] = @LostItem)
GO
/****** Object:  StoredProcedure [dbo].[LostCOF]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LostCOF]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        [Returned Item ID], [COF Number], [Customer ID], [Date Returned], [Time Returned], [Quantity Rented], [Quantity Returned], [Lost Item], [Total Amount], Payment, 
                         Status
FROM            [Rented Items]
WHERE        ([COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[Lastnm]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Lastnm]
(
	@LastName varchar(50),
	@FirstName varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        ([Last Name] BETWEEN @LastName AND @FirstName)
GO
/****** Object:  StoredProcedure [dbo].[Lastname]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Lastname]
(
	@LastName varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        ([Last Name] LIKE @LastName + '%') AND ([Last Name] LIKE @LastName + '%')
GO
/****** Object:  StoredProcedure [dbo].[Lastlast]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Lastlast]
(
	@LastName varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        ([Last Name] BETWEEN @LastName AND @LastName)
GO
/****** Object:  StoredProcedure [dbo].[KSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], 
                         Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Order Amount], 
                         Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], Orderline.Total, Orderline.Discount, Orderline.[Overall Total], 
                         Orderline.[Vat Amount]
FROM            Item INNER JOIN
                         Orderline ON Item.[COF Number] = Orderline.[COF Number]
WHERE        (Item.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[jNewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[jNewSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.[Event Time], 
                         Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], 
                         Orderline.[Service Charge], Orderline.Total, Orderline.Discount, Orderline.[Overall Total], Orderline.[Vat Amount], Item.[COF Number] AS Expr1, Item.[Item Name], 
                         Item.Unit, Item.Quantity, Item.[Unit Cost], Item.[Sub Cost]
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number]
WHERE        (Orderline.[COF Number] = @COFNumber) AND (Item.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[Itemid]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Itemid]
(
	@ItemID int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        ([Item Type] = 'Rental') AND ([Item ID] = @ItemID)
GO
/****** Object:  StoredProcedure [dbo].[OrderItems]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderItems]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Item.[COF Number], Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Orderline.[COF Number] AS Expr1, Orderline.Lastname, Orderline.[First Name], 
                         Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.[Event Time], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, 
                         Orderline.Balance, Orderline.[Full payment], Orderline.[Down payment], Orderline.[Order Amount], Orderline.[Service Charge], Orderline.Total, Orderline.Discount, 
                         Orderline.[Overall Total], Orderline.[Vat Amount]
FROM            Item INNER JOIN
                         Orderline ON Item.[COF Number] = Orderline.[COF Number]
WHERE        (Item.[COF Number] = @COFNumber) AND (Orderline.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[OrderItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrderItem]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Item.[COF Number], Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Orderline.[COF Number] AS Expr1, Orderline.Lastname, Orderline.[First Name], 
                         Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.[Event Time], Orderline.Theme, Orderline.[Color Motif], Orderline.Venue, 
                         Orderline.Balance, Orderline.[Full payment], Orderline.[Down payment], Orderline.[Order Amount], Orderline.[Service Charge], Orderline.Total, Orderline.Discount, 
                         Orderline.[Overall Total], Orderline.[Vat Amount]
FROM            Item INNER JOIN
                         Orderline ON Item.[COF Number] = Orderline.[COF Number]
WHERE        (Item.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[OrDateBeginEnd]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrDateBeginEnd]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[Orby]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Orby]
(
	@ORNumber varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [OR ID], [Date and Time Generate], [OR Number], [COF Number], [VAT Percentage], [VAT Amount], [Order Amount], [Service Charge], Total, [Recorded by]
FROM            [Official Receipt]
WHERE        ([OR Number] LIKE @ORNumber + '%')
GO
/****** Object:  StoredProcedure [dbo].[OrBeginEnd]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OrBeginEnd]
(
	@Begin int,
	@End int
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([COF Number] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[CustIDBeginEnd]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustIDBeginEnd]
(
	@Begin int,
	@End int
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        ([Customer ID] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[CustBeginEnd]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustBeginEnd]
(
	@Begin varchar(50),
	@End varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        ([Last Name] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[COFRented]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[COFRented]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        [Checklist Number], [COF Number], [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Date OUT], [Time OUT], Unit, [Quantity OUT], 
                         [Quantity IN], [Date IN], [Time IN], [Quantity Missing], [Issued By], [Picked Up By], [Recorded Issuance By], [Returned By], [Recorded Return By], ID, [Deposit Amount],
                          [Refund Amount], [Rental Amount]
FROM            [Rental Checklist]
WHERE        ([COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[cNewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[cNewSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, 
                         Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], 
                         Orderline.Total, Orderline.Discount, Orderline.[Overall Total], Item.[COF Number] AS Expr1, Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost]
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number]
WHERE        (Item.[COF Number] = @COFNumber) AND (Orderline.[COF Number] = @COFNumber) AND (Orderline.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[bNewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[bNewSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, 
                         Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], 
                         Orderline.Total, Item.[COF Number] AS Expr1, Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost]
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number]
WHERE        (Orderline.[COF Number] = @COFNumber) AND (Item.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[ASelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ASelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, 
                         Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], 
                         Orderline.Total, Orderline.Discount, Orderline.[Overall Total], Orderline.[Vat Amount], Item.[COF Number] AS Expr1, Item.[Item Name], Item.Quantity, Item.[Unit Cost], 
                         Item.[Sub Cost]
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number]
WHERE        (Orderline.[COF Number] = @COFNumber) AND (Item.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[aNewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[aNewSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, 
                         Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], 
                         Orderline.Total, Orderline.Discount, Orderline.[Overall Total], Item.[COF Number] AS Expr1, Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost]
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number]
WHERE        (Orderline.[COF Number] = @COFNumber) AND (Item.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[AddSupplier]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddSupplier]
(
	@Supplier_ID int,
	@Name varchar(50),
	@Address varchar(50),
	@Contact varchar(50),
	@Email_Address varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Supplier] ([Supplier ID], [Name], [Address], [Contact], [Email Address]) VALUES (@Supplier_ID, @Name, @Address, @Contact, @Email_Address);
	
SELECT [Supplier ID], Name, Address, Contact, [Email Address] FROM Supplier WHERE ([Supplier ID] = @Supplier_ID)
GO
/****** Object:  StoredProcedure [dbo].[AddRentalRefund]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddRentalRefund]
(
	@Rental_Refund_ID int,
	@COF_Number int,
	@Date_Released datetime,
	@Time_Released datetime,
	@Refund_Amount decimal(18, 2),
	@Rental_Amount decimal(18, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Rental Refund]
                         ([Rental Refund ID], [COF Number], [Date Released], [Time Released], [Refund Amount], [Rental Amount])
VALUES        (@Rental_Refund_ID,@COF_Number,@Date_Released,@Time_Released,@Refund_Amount,@Rental_Amount)
GO
/****** Object:  StoredProcedure [dbo].[AddPOItems]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPOItems]
(
	@Item_ID int,
	@POF_Number int,
	@Category_Name varchar(50),
	@Specific_Category varchar(50),
	@p1 varchar(50),
	@Item_Name varchar(50),
	@Size varchar(50),
	@Color varchar(50),
	@Height decimal(18, 2),
	@Weight decimal(18, 2),
	@Quantity int,
	@Unit_Price decimal(18, 2),
	@Sub_Total decimal(18, 2),
	@Unit varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PO Items]
                         ([Item ID], [POF Number], [Category Name], [Specific Category], [Sub-Category], [Item Name], Size, Color, Height, Weight, Quantity, [Unit Price], [Sub Total], Unit)
VALUES        (@Item_ID,@POF_Number,@Category_Name,@Specific_Category,@p1,@Item_Name,@Size,@Color,@Height,@Weight,@Quantity,@Unit_Price,@Sub_Total,@Unit)
GO
/****** Object:  StoredProcedure [dbo].[AddPOItem]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPOItem]
(
	@Item_ID int,
	@PO_Item_ID int,
	@POF_Number int,
	@Category_Name varchar(50),
	@Specific_Category varchar(50),
	@p1 varchar(50),
	@Item_Name varchar(50),
	@Size varchar(50),
	@Color varchar(50),
	@Height decimal(18, 2),
	@Weight decimal(18, 2),
	@Quantity int,
	@Unit varchar(50),
	@Unit_Price decimal(18, 2),
	@Sub_Total decimal(18, 2),
	@Undersupplied int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PO Items]
                         ([Item ID], [PO Item ID], [POF Number], [Category Name], [Specific Category], [Sub-Category], [Item Name], Size, Color, Height, Weight, Quantity, Unit, [Unit Price], 
                         [Sub Total], Undersupplied)
VALUES        (@Item_ID,@PO_Item_ID,@POF_Number,@Category_Name,@Specific_Category,@p1,@Item_Name,@Size,@Color,@Height,@Weight,@Quantity,@Unit,@Unit_Price,@Sub_Total,@Undersupplied)
GO
/****** Object:  StoredProcedure [dbo].[AddPOF]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPOF]
(
	@POF_Number int,
	@Date_of_Purchase datetime,
	@Time_of_Purchase datetime,
	@Supplier_ID int,
	@Supplier_Name varchar(50),
	@Address varchar(300),
	@Contact_Number varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO Purchase
                         ([POF Number], [Date of Purchase], [Time of Purchase], [Supplier ID], [Supplier Name], Address, [Contact Number])
VALUES        (@POF_Number,@Date_of_Purchase,@Time_of_Purchase,@Supplier_ID,@Supplier_Name,@Address,@Contact_Number)
GO
/****** Object:  StoredProcedure [dbo].[AddOfficialReceipt]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOfficialReceipt]
(
	@OR_ID int,
	@Date_and_Time_Generate datetime,
	@OR_Number varchar(50),
	@COF_Number int,
	@VAT_Percentage decimal(18, 2),
	@VAT_Amount decimal(18, 2),
	@Order_Amount decimal(18, 2),
	@Service_Charge decimal(18, 2),
	@Total decimal(18, 2),
	@Recorded_by varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Official Receipt]
                         ([OR ID], [Date and Time Generate], [OR Number], [COF Number], [VAT Percentage], [VAT Amount], [Order Amount], [Service Charge], Total, [Recorded by])
VALUES        (@OR_ID,@Date_and_Time_Generate,@OR_Number,@COF_Number,@VAT_Percentage,@VAT_Amount,@Order_Amount,@Service_Charge,@Total,@Recorded_by);
	 
SELECT [OR ID], [Date and Time Generate], [OR Number], [COF Number], [VAT Percentage], [VAT Amount], [Order Amount], [Service Charge], Total, [Recorded by] FROM [Official Receipt] WHERE ([OR ID] = @OR_ID)
GO
/****** Object:  StoredProcedure [dbo].[AddNewSupplier]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewSupplier]
(
	@Supplier_ID int,
	@Name varchar(50),
	@Address varchar(50),
	@Contact varchar(50),
	@Email_Address varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO Supplier
                         ([Supplier ID], Name, Address, Contact, [Email Address])
VALUES        (@Supplier_ID,@Name,@Address,@Contact,@Email_Address);
	 
SELECT [Supplier ID], Name, Address, Contact, [Email Address], Status FROM Supplier WHERE ([Supplier ID] = @Supplier_ID)
GO
/****** Object:  StoredProcedure [dbo].[AddNewRent]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewRent]
(
	@Returned_Item_ID int,
	@COF_Number int,
	@Customer_ID int,
	@Date_Returned datetime,
	@Time_Returned datetime,
	@Quantity_Rented int,
	@Quantity_Returned int,
	@Lost_Item int,
	@Total_Amount decimal(18, 2),
	@Payment decimal(18, 2),
	@Status varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Rented Items]
                         ([Returned Item ID], [COF Number], [Customer ID], [Date Returned], [Time Returned], [Quantity Rented], [Quantity Returned], [Lost Item], [Total Amount], Payment, 
                         Status)
VALUES        (@Returned_Item_ID,@COF_Number,@Customer_ID,@Date_Returned,@Time_Returned,@Quantity_Rented,@Quantity_Returned,@Lost_Item,@Total_Amount,@Payment,@Status);
	 
SELECT [Returned Item ID], [COF Number], [Customer ID], [Date Returned], [Time Returned], [Quantity Rented], [Quantity Returned], [Lost Item], [Total Amount], Payment, Status FROM [Rented Items] WHERE ([Returned Item ID] = @Returned_Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[AddnewInvTrans]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddnewInvTrans]
(
	@Item_ID int,
	@Item_Name varchar(50),
	@Type_of_Transaction varchar(50),
	@Quantity int,
	@Date_and_Time datetime,
	@Transaction_done_by varchar(50),
	@Reason varchar(100)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Inventory Transactions]
                         ([Item ID], [Item Name], [Type of Transaction], Quantity, [Date and Time], [Transaction done by], Reason)
VALUES        (@Item_ID,@Item_Name,@Type_of_Transaction,@Quantity,@Date_and_Time,@Transaction_done_by,@Reason)
GO
/****** Object:  StoredProcedure [dbo].[AddNewInventory]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewInventory]
(
	@Item_ID int,
	@Category_Name varchar(50),
	@Sub_Category varchar(50),
	@Specific_Category varchar(50),
	@Item_Name varchar(50),
	@Item_Type varchar(50),
	@Size varchar(50),
	@Quantity int,
	@Unit varchar(50),
	@Unit_Price decimal(18, 2),
	@Selling_Price decimal(18, 2),
	@Quantity_in_Stock int,
	@Status varchar(50),
	@Color varchar(50),
	@Width decimal(18, 2),
	@Height decimal(18, 2),
	@Supplier varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO Inventory
                         ([Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], Status, 
                         Color, Width, Height, Supplier)
VALUES        (@Item_ID,@Category_Name,@Sub_Category,@Specific_Category,@Item_Name,@Item_Type,@Size,@Quantity,@Unit,@Unit_Price,@Selling_Price,@Quantity_in_Stock,@Status,@Color,@Width,@Height,@Supplier);
	 
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item],[Back Order] FROM Inventory WHERE ([Item ID] = @Item_ID)
GO
/****** Object:  StoredProcedure [dbo].[AddNewCustomer]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddNewCustomer]
(
	@Customer_ID int,
	@Last_Name varchar(50),
	@Middle_Initial varchar(50),
	@First_Name varchar(50),
	@Address text,
	@Home_Phone varchar(50),
	@Cellphone varchar(50),
	@Email_Address text
)
AS
	SET NOCOUNT OFF;
INSERT INTO Customer
                         ([Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address])
VALUES        (@Customer_ID,@Last_Name,@Middle_Initial,@First_Name,@Address,@Home_Phone,@Cellphone,@Email_Address)
GO
/****** Object:  StoredProcedure [dbo].[AddItemtoCart]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddItemtoCart]
(
	@Item_Number int,
	@Item_ID int,
	@COF_Number int,
	@Category_Name varchar(50),
	@Sub_Category varchar(50),
	@Specific_Category varchar(50),
	@Item_Name varchar(50),
	@Supplier varchar(50),
	@Width decimal(18, 2),
	@Height decimal(18, 2),
	@Size varchar(50),
	@Color varchar(50),
	@Type varchar(50),
	@Unit varchar(50),
	@Quantity int,
	@Unit_Cost decimal(18, 2),
	@Sub_Cost decimal(18, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO Item
                         ([Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Supplier, Width, Height, Size, Color, Type, Unit, Quantity, 
                         [Unit Cost], [Sub Cost])
VALUES        (@Item_Number,@Item_ID,@COF_Number,@Category_Name,@Sub_Category,@Specific_Category,@Item_Name,@Supplier,@Width,@Height,@Size,@Color,@Type,@Unit,@Quantity,@Unit_Cost,@Sub_Cost);
	 
SELECT [Item Number], [Item ID], [COF Number], [Category Name], [Sub Category], [Specific Category], [Item Name], Supplier, Width, Height, Size, Color, Type, Unit, Quantity, [Unit Cost], [Sub Cost], [Back Order], [Lost Item], [Returned Item] FROM Item WHERE ([Item Number] = @Item_Number)
GO
/****** Object:  StoredProcedure [dbo].[AddInvoice]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddInvoice]
(
	@Invoice_ID int,
	@COF_Number int,
	@Date_Generate datetime,
	@Time_Generate datetime,
	@Order_Amount decimal(18, 2),
	@Service_Charge decimal(18, 2),
	@Total decimal(18, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO Invoice
                         ([Invoice ID], [COF Number], [Date Generate], [Time Generate], [Order Amount], [Service Charge], Total)
VALUES        (@Invoice_ID,@COF_Number,@Date_Generate,@Time_Generate,@Order_Amount,@Service_Charge,@Total);
	 
SELECT [Invoice ID], [COF Number], [Date Generate], [Time Generate], [Order Amount], [Service Charge], Total FROM Invoice WHERE ([Invoice ID] = @Invoice_ID)
GO
/****** Object:  StoredProcedure [dbo].[AddChecklist]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddChecklist]
(
	@Checklist_Number int,
	@COF_Number int,
	@Item_ID int,
	@Category_Name varchar(50),
	@Sub_Category varchar(50),
	@Specific_Category varchar(50),
	@Item_Name varchar(50),
	@Date_OUT datetime,
	@Time_OUT datetime,
	@Unit varchar(50),
	@Quantity_OUT int,
	@Issued_By varchar(50),
	@Picked_Up_By varchar(50),
	@Recorded_Issuance_By varchar(50),
	@ID varchar(50),
	@Deposit_Amount decimal(18, 2)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Rental Checklist]
                         ([Checklist Number], [COF Number], [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Date OUT], [Time OUT], Unit, [Quantity OUT], 
                         [Issued By], [Picked Up By], [Recorded Issuance By], ID, [Deposit Amount])
VALUES        (@Checklist_Number,@COF_Number,@Item_ID,@Category_Name,@Sub_Category,@Specific_Category,@Item_Name,@Date_OUT,@Time_OUT,@Unit,@Quantity_OUT,@Issued_By,@Picked_Up_By,@Recorded_Issuance_By,@ID,@Deposit_Amount)
GO
/****** Object:  StoredProcedure [dbo].[AddCategory]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCategory]
(
	@Category_ID int,
	@Name text
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Category] ([Category ID], [Name]) VALUES (@Category_ID, @Name);
	
SELECT [Category ID], Name FROM Category WHERE ([Category ID] = @Category_ID)
GO
/****** Object:  StoredProcedure [dbo].[ActivateCustomer]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActivateCustomer]
(
	@Original_Customer_ID int
)
AS
	SET NOCOUNT OFF;
UPDATE       Customer
SET                Status = 'Active'
WHERE        ([Customer ID] = @Original_Customer_ID)
GO
/****** Object:  StoredProcedure [dbo].[AccountRecv]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AccountRecv]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] BETWEEN @Begin AND @End + 1)
GO
/****** Object:  StoredProcedure [dbo].[Account]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Account]
(
	@Begin datetime,
	@End datetime
)
AS
	SET NOCOUNT ON;
SELECT        [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], 
                         [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], 
                         [Rent Deposit]
FROM            Orderline
WHERE        ([Order Date] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[InvBeginEnd]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InvBeginEnd]
(
	@Begin int,
	@End int
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        ([Item ID] BETWEEN @Begin AND @End)
GO
/****** Object:  StoredProcedure [dbo].[InsertOrderRec]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOrderRec]
(
	@COF_Number int,
	@Customer_ID int,
	@Lastname varchar(50),
	@First_Name nchar(10),
	@Middle_Initial varchar(3),
	@Order_Date datetime,
	@Event_Date datetime,
	@Event_Time datetime,
	@Theme varchar(50),
	@Color_Motif varchar(50),
	@Venue varchar(150)
)
AS
	SET NOCOUNT OFF;
INSERT INTO Orderline
                         ([COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue)
VALUES        (@COF_Number,@Customer_ID,@Lastname,@First_Name,@Middle_Initial,@Order_Date,@Event_Date,@Event_Time,@Theme,@Color_Motif,@Venue);
	 
SELECT [COF Number], [Customer ID], Lastname, [First Name], [Middle Initial], [Order Date], [Event Date], [Event Time], Theme, [Color Motif], Venue, Balance, [Order Amount], [Down payment], [Full payment], [Service Charge], Total, Status, [Official Receipt], Discount, [Overall Total], Refund, [Vat Amount], [Vat Percentage], [Delivery Status], [Rent Deposit] FROM Orderline WHERE ([COF Number] = @COF_Number)
GO
/****** Object:  StoredProcedure [dbo].[iNewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[iNewSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, 
                         Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Down payment], Orderline.Discount, Orderline.[Overall Total], Item.[COF Number] AS Expr1, 
                         Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], Invoice.[COF Number] AS Expr2, Invoice.[Order Amount], Invoice.[Service Charge], 
                         Invoice.Total
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number] INNER JOIN
                         Invoice ON Orderline.[COF Number] = Invoice.[COF Number]
WHERE        (Orderline.[COF Number] = @COFNumber) AND (Item.[COF Number] = @COFNumber) AND (Invoice.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[hNewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[hNewSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, 
                         Orderline.[Color Motif], Orderline.Venue, Orderline.Balance, Orderline.[Order Amount], Orderline.[Down payment], Orderline.[Full payment], Orderline.[Service Charge], 
                         Orderline.Total, Orderline.Discount, Orderline.[Overall Total], Item.[COF Number] AS Expr1, Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost]
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number]
WHERE        (Orderline.[COF Number] = @COFNumber) AND (Item.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[gNewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[gNewSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, 
                         Orderline.[Color Motif], Orderline.Venue, Item.[COF Number] AS Expr1, Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], 
                         [Official Receipt].[COF Number] AS Expr2, [Official Receipt].[Order Amount], [Official Receipt].[VAT Amount], [Official Receipt].[Service Charge], 
                         [Official Receipt].Total
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number] INNER JOIN
                         [Official Receipt] ON Orderline.[COF Number] = [Official Receipt].[COF Number]
WHERE        (Orderline.[COF Number] = @COFNumber) AND (Item.[COF Number] = @COFNumber) AND ([Official Receipt].[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[GetSupplierByName]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSupplierByName]
(
	@Name varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Supplier ID], Name, Address, Contact, [Email Address], Status
FROM            Supplier
WHERE        (Name LIKE @Name + '%')
GO
/****** Object:  StoredProcedure [dbo].[GetSupplierByID]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSupplierByID]
(
	@SupplierID int
)
AS
	SET NOCOUNT ON;
SELECT        [Supplier ID], Name, Address, Contact, [Email Address], Status
FROM            Supplier
WHERE        ([Supplier ID] LIKE @SupplierID)
GO
/****** Object:  StoredProcedure [dbo].[GetPORec]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPORec]
AS
	SET NOCOUNT ON;
SELECT [POF Number], [Date of Purchase], [Time of Purchase], [Supplier ID], [Supplier Name], Address, [Contact Number], [Total Quantity], [Total Amount], [Vat Amount], [Vat Percentage], Status, Balance, Deposit, [Full Payment], [Date Received], [Time Received], Undersupplied FROM dbo.Purchase
GO
/****** Object:  StoredProcedure [dbo].[GetAllInventoryRec]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllInventoryRec]
AS
	SET NOCOUNT ON;
SELECT [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order] FROM dbo.Inventory
GO
/****** Object:  StoredProcedure [dbo].[GetAllCustomerRecords]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCustomerRecords]
AS
	SET NOCOUNT ON;
SELECT        [Customer ID], [Last Name], [Middle Initial], [First Name], Address, [Home Phone], Cellphone, [Email Address], Status, [No of Orders], [Cancel Order], 
                         [Processed Order], [Pending Order], [Waiting Order]
FROM            Customer
WHERE        (Status = 'Active')
GO
/****** Object:  StoredProcedure [dbo].[fNewSelectCommand]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[fNewSelectCommand]
(
	@COFNumber int
)
AS
	SET NOCOUNT ON;
SELECT        Orderline.[COF Number], Orderline.Lastname, Orderline.[First Name], Orderline.[Middle Initial], Orderline.[Order Date], Orderline.[Event Date], Orderline.Theme, 
                         Orderline.[Color Motif], Orderline.Venue, Item.[COF Number] AS Expr1, Item.[Item Name], Item.Quantity, Item.[Unit Cost], Item.[Sub Cost], 
                         Invoice.[COF Number] AS Expr2, Invoice.[Order Amount], Invoice.[Service Charge], Invoice.Total
FROM            Orderline INNER JOIN
                         Item ON Orderline.[COF Number] = Item.[COF Number] INNER JOIN
                         Invoice ON Orderline.[COF Number] = Invoice.[COF Number]
WHERE        (Orderline.[COF Number] = @COFNumber) AND (Item.[COF Number] = @COFNumber) AND (Invoice.[COF Number] = @COFNumber)
GO
/****** Object:  StoredProcedure [dbo].[DisplayTobePurchasedItems]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DisplayTobePurchasedItems]
(
	@Supplier varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item], [Back Order]
FROM            Inventory
WHERE        (Supplier = @Supplier) AND ([Back Order] > 0)
GO
/****** Object:  StoredProcedure [dbo].[DisplayInvRec]    Script Date: 09/07/2010 01:53:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DisplayInvRec]
AS
	SET NOCOUNT ON;
SELECT        [Item ID], [Category Name], [Sub Category], [Specific Category], [Item Name], [Item Type], Size, Quantity, Unit, [Unit Price], [Selling Price], [Quantity in Stock], 
                         [Quantity in Order], Status, Color, Width, Height, Supplier, [Lost Item], [Returned Item]
FROM            Inventory
GO
/****** Object:  Default [DF_Item_Item Number]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Item Number]  DEFAULT ((0)) FOR [Item Number]
GO
/****** Object:  Default [DF_Item_Width]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Width]  DEFAULT ((0)) FOR [Width]
GO
/****** Object:  Default [DF_Item_Height]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Height]  DEFAULT ((0)) FOR [Height]
GO
/****** Object:  Default [DF_Item_Quantity]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
/****** Object:  Default [DF_Item_Unit Cost]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Unit Cost]  DEFAULT ((0)) FOR [Unit Cost]
GO
/****** Object:  Default [DF_Item_Sub Cost]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Sub Cost]  DEFAULT ((0)) FOR [Sub Cost]
GO
/****** Object:  Default [DF_Item_Back Order]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Back Order]  DEFAULT ((0)) FOR [Back Order]
GO
/****** Object:  Default [DF_Item_Lost Item]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Lost Item]  DEFAULT ((0)) FOR [Lost Item]
GO
/****** Object:  Default [DF_Item_Returned Item]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Item] ADD  CONSTRAINT [DF_Item_Returned Item]  DEFAULT ((0)) FOR [Returned Item]
GO
/****** Object:  Default [DF_Invoice_Invoice ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_Invoice ID]  DEFAULT ((1)) FOR [Invoice ID]
GO
/****** Object:  Default [DF_Inventory_Item ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Item ID]  DEFAULT ((1)) FOR [Item ID]
GO
/****** Object:  Default [DF_Inventory_Quantity]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Quantity]  DEFAULT ((0)) FOR [Quantity]
GO
/****** Object:  Default [DF_Inventory_Quantity in Stock]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Quantity in Stock]  DEFAULT ((0)) FOR [Quantity in Stock]
GO
/****** Object:  Default [DF_Inventory_Quantity in Order]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Quantity in Order]  DEFAULT ((0)) FOR [Quantity in Order]
GO
/****** Object:  Default [DF_Inventory_Color]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Color]  DEFAULT ('none') FOR [Color]
GO
/****** Object:  Default [DF_Inventory_Width]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Width]  DEFAULT ((0)) FOR [Width]
GO
/****** Object:  Default [DF_Inventory_Height]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Height]  DEFAULT ((0)) FOR [Height]
GO
/****** Object:  Default [DF_Inventory_Lost Item]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Lost Item]  DEFAULT ((0)) FOR [Lost Item]
GO
/****** Object:  Default [DF_Inventory_Returned Item]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Returned Item]  DEFAULT ((0)) FOR [Returned Item]
GO
/****** Object:  Default [DF_Inventory_Back Order]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Inventory] ADD  CONSTRAINT [DF_Inventory_Back Order]  DEFAULT ((0)) FOR [Back Order]
GO
/****** Object:  Default [DF_Cancel Refund_Cancel Refund ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Cancel Refund] ADD  CONSTRAINT [DF_Cancel Refund_Cancel Refund ID]  DEFAULT ((1)) FOR [Cancel Refund ID]
GO
/****** Object:  Default [DF_Customer_Customer ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_Customer ID]  DEFAULT ((1)) FOR [Customer ID]
GO
/****** Object:  Default [DF_Customer_Status]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_Status]  DEFAULT ('Active') FOR [Status]
GO
/****** Object:  Default [DF_Customer_No of Orders]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_No of Orders]  DEFAULT ((0)) FOR [No of Orders]
GO
/****** Object:  Default [DF_Customer_[Cancel Order]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_[Cancel Order]  DEFAULT ((0)) FOR [Cancel Order]
GO
/****** Object:  Default [DF_Customer_Processed Order]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_Processed Order]  DEFAULT ((0)) FOR [Processed Order]
GO
/****** Object:  Default [DF_Customer_Pending Order]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_Pending Order]  DEFAULT ((0)) FOR [Pending Order]
GO
/****** Object:  Default [DF_Customer_Waiting Order]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_Waiting Order]  DEFAULT ((0)) FOR [Waiting Order]
GO
/****** Object:  Default [DF_orderline_COF_No]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_COF_No]  DEFAULT ((1)) FOR [COF Number]
GO
/****** Object:  Default [DF_orderline_balance]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_balance]  DEFAULT ((0.00)) FOR [Balance]
GO
/****** Object:  Default [DF_orderline_order_amt]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_order_amt]  DEFAULT ((0.00)) FOR [Order Amount]
GO
/****** Object:  Default [DF_orderline_downpayment]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_downpayment]  DEFAULT ((0.00)) FOR [Down payment]
GO
/****** Object:  Default [DF_orderline_fullpayment]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_fullpayment]  DEFAULT ((0.00)) FOR [Full payment]
GO
/****** Object:  Default [DF_orderline_service_charge]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_service_charge]  DEFAULT ((0.00)) FOR [Service Charge]
GO
/****** Object:  Default [DF_orderline_total]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_total]  DEFAULT ((0.00)) FOR [Total]
GO
/****** Object:  Default [DF_orderline_status]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_status]  DEFAULT ('Pending') FOR [Status]
GO
/****** Object:  Default [DF_orderline_OfficialReceipt]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_orderline_OfficialReceipt]  DEFAULT ('No') FOR [Official Receipt]
GO
/****** Object:  Default [DF_Orderline_Refund]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Orderline] ADD  CONSTRAINT [DF_Orderline_Refund]  DEFAULT ((0)) FOR [Refund]
GO
/****** Object:  Default [DF_Official Receipt_OR ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Official Receipt] ADD  CONSTRAINT [DF_Official Receipt_OR ID]  DEFAULT ((0)) FOR [OR ID]
GO
/****** Object:  Default [DF_PO Items_Item ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[PO Items] ADD  CONSTRAINT [DF_PO Items_Item ID]  DEFAULT ((1)) FOR [PO Item ID]
GO
/****** Object:  Default [DF_PO Items_Quantity Received]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[PO Items] ADD  CONSTRAINT [DF_PO Items_Quantity Received]  DEFAULT ((0)) FOR [Quantity Received]
GO
/****** Object:  Default [DF_PO Items_Undersupplied]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[PO Items] ADD  CONSTRAINT [DF_PO Items_Undersupplied]  DEFAULT ((0)) FOR [Undersupplied]
GO
/****** Object:  Default [DF_Purchase_POF Number]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_POF Number]  DEFAULT ((1)) FOR [POF Number]
GO
/****** Object:  Default [DF_Purchase_Status]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_Status]  DEFAULT ('Waiting') FOR [Status]
GO
/****** Object:  Default [DF_Purchase_Undersupplied]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_Undersupplied]  DEFAULT ((0)) FOR [Undersupplied]
GO
/****** Object:  Default [DF_Rented Items_Returned Item ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Rented Items] ADD  CONSTRAINT [DF_Rented Items_Returned Item ID]  DEFAULT ((1)) FOR [Returned Item ID]
GO
/****** Object:  Default [DF_Rental Refund_Rental Refund ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Rental Refund] ADD  CONSTRAINT [DF_Rental Refund_Rental Refund ID]  DEFAULT ((0)) FOR [Rental Refund ID]
GO
/****** Object:  Default [DF_Rental Checklist_Checklist Number]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Rental Checklist] ADD  CONSTRAINT [DF_Rental Checklist_Checklist Number]  DEFAULT ((0)) FOR [Checklist Number]
GO
/****** Object:  Default [DF_Rental Checklist_ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Rental Checklist] ADD  CONSTRAINT [DF_Rental Checklist_ID]  DEFAULT ('No') FOR [ID]
GO
/****** Object:  Default [DF_Supplier_Supplier ID]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_Supplier ID]  DEFAULT ((1)) FOR [Supplier ID]
GO
/****** Object:  Default [DF_Supplier_Status]    Script Date: 09/07/2010 01:52:33 ******/
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [DF_Supplier_Status]  DEFAULT ('Active') FOR [Status]
GO
