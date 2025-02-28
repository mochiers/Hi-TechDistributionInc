USE [master]
GO
/****** Object:  Database [HiTechDB]    Script Date: 1/12/2022 11:27:47 PM ******/
CREATE DATABASE [HiTechDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HiTechDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVEREXPRESS\MSSQL\DATA\HiTechDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HiTechDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVEREXPRESS\MSSQL\DATA\HiTechDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HiTechDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HiTechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HiTechDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HiTechDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HiTechDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HiTechDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HiTechDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HiTechDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HiTechDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HiTechDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HiTechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HiTechDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HiTechDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HiTechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HiTechDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HiTechDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HiTechDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HiTechDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HiTechDB] SET  MULTI_USER 
GO
ALTER DATABASE [HiTechDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HiTechDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HiTechDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HiTechDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HiTechDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HiTechDB] SET QUERY_STORE = OFF
GO
USE [HiTechDB]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuthorsBooks]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuthorsBooks](
	[AuthorID] [int] NOT NULL,
	[ISBN] [nvarchar](25) NOT NULL,
	[YearPublished] [int] NOT NULL,
	[Edition] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AuthorsBooks] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [nvarchar](25) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[UnitPrice] [nvarchar](50) NOT NULL,
	[YearPublished] [int] NOT NULL,
	[QOH] [nvarchar](50) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[PublisherID] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1111111,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[StreetAddress] [nvarchar](75) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](25) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[FaxNumber] [nvarchar](50) NOT NULL,
	[CreditLimit] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[JobID] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobPositions]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobPositions](
	[JobID] [int] NOT NULL,
	[JobTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_JobPositions] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ISBN] [nvarchar](25) NOT NULL,
	[QuantityOrdered] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[OrderDate] [nvarchar](50) NOT NULL,
	[OrderType] [nvarchar](50) NOT NULL,
	[RequiredDate] [date] NOT NULL,
	[ShippingDate] [date] NOT NULL,
	[StatusID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Payment] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherID] [int] NOT NULL,
	[PublisherName] [nvarchar](50) NOT NULL,
	[WebAddress] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusID] [int] NOT NULL,
	[State] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersAccount]    Script Date: 1/12/2022 11:27:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersAccount](
	[UserID] [int] NOT NULL,
	[Password] [nvarchar](75) NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_UsersAccount] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [CategoryID], [PublisherID]) VALUES (N'978-3-16-148410-0', N'Python Algorithms', N'49.99', 2019, N'20', 4, 1)
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Object Orientated Programming')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Database')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Data Structures')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Algorithms')
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [StreetAddress], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit], [Email]) VALUES (1111113, N'Lasalle', N'Saint-Catherine Street', N'Montreal', N'H9K 1S3', N'(514) 111-1111', N'+1 (514) 111-1111', N'10000000', N'lasalle@lasalle.com')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [PhoneNumber], [Email], [JobID], [StatusID]) VALUES (11111, N'Henry', N'Brown', N'(514) 111-1111', N'henrybrown@gmail.com', 11, 1)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [PhoneNumber], [Email], [JobID], [StatusID]) VALUES (11112, N'Thomas', N'Moore', N'(514) 222-2222', N'thomasmoore@hotmail.com', 12, 1)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [PhoneNumber], [Email], [JobID], [StatusID]) VALUES (11113, N'Peter', N'Wang', N'(514) 333-3333', N'peterwang@yahoo.com', 13, 1)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [PhoneNumber], [Email], [JobID], [StatusID]) VALUES (11114, N'Jennifer', N'Bouchard', N'(514) 234-5654', N'jbouchard@gmail.com', 14, 1)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [PhoneNumber], [Email], [JobID], [StatusID]) VALUES (11115, N'Mary', N'Brown', N'(514) 546-6823', N'marybrown@yahoo.com', 15, 1)

GO
INSERT [dbo].[JobPositions] ([JobID], [JobTitle]) VALUES (11, N'MIS Manager')
INSERT [dbo].[JobPositions] ([JobID], [JobTitle]) VALUES (12, N'Sales Manager')
INSERT [dbo].[JobPositions] ([JobID], [JobTitle]) VALUES (13, N'Inventory Controller')
INSERT [dbo].[JobPositions] ([JobID], [JobTitle]) VALUES (14, N'Order Clerk')

GO
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [WebAddress]) VALUES (1, N'Premier Press', N'https://www.premierpress.com/')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [WebAddress]) VALUES (2, N'Wrox', N'https://www.wiley.com/en-ca')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [WebAddress]) VALUES (3, N'Murach', N'https://www.murach.com/')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName], [WebAddress]) VALUES (4, N'Pearson', N'https://www.pearson.com/us/higher-education.html')
GO
INSERT [dbo].[Status] ([StatusID], [State]) VALUES (1, N'Active')
INSERT [dbo].[Status] ([StatusID], [State]) VALUES (2, N'Inactive')
GO
INSERT [dbo].[UsersAccount] ([UserID], [Password], [EmployeeID]) VALUES (1111, N'Henrypassword', 11111)
INSERT [dbo].[UsersAccount] ([UserID], [Password], [EmployeeID]) VALUES (1112, N'Thomaspassword', 11112)
GO
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorsBooks_Authors] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[AuthorsBooks] CHECK CONSTRAINT [FK_AuthorsBooks_Authors]
GO
ALTER TABLE [dbo].[AuthorsBooks]  WITH CHECK ADD  CONSTRAINT [FK_AuthorsBooks_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[AuthorsBooks] CHECK CONSTRAINT [FK_AuthorsBooks_Books]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Categories]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publishers] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publishers] ([PublisherID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publishers]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_JobPositions] FOREIGN KEY([JobID])
REFERENCES [dbo].[JobPositions] ([JobID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_JobPositions]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Status1] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([StatusID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Status1]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Books] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Books]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([StatusID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Status]
GO
ALTER TABLE [dbo].[UsersAccount]  WITH CHECK ADD  CONSTRAINT [FK_UsersAccount_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[UsersAccount] CHECK CONSTRAINT [FK_UsersAccount_Employees]
GO
USE [master]
GO
ALTER DATABASE [HiTechDB] SET  READ_WRITE 
GO
