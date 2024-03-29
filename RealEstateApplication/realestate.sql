USE [master]
GO
/****** Object:  Database [RealEstateOrganizationDb]    Script Date: 1/12/2024 5:26:39 PM ******/
CREATE DATABASE [RealEstateOrganizationDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RealEstateOrganizationDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RealEstateOrganizationDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RealEstateOrganizationDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RealEstateOrganizationDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RealEstateOrganizationDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RealEstateOrganizationDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RealEstateOrganizationDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET RECOVERY FULL 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET  MULTI_USER 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RealEstateOrganizationDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RealEstateOrganizationDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RealEstateOrganizationDb', N'ON'
GO
ALTER DATABASE [RealEstateOrganizationDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [RealEstateOrganizationDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RealEstateOrganizationDb]
GO
/****** Object:  Table [dbo].[LeaseAgreements]    Script Date: 1/12/2024 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LeaseAgreements](
	[LeaseID] [int] NOT NULL,
	[PropertyID] [int] NULL,
	[TenantID] [int] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[RentAmount] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[LeaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Properties]    Script Date: 1/12/2024 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Properties](
	[PropertyID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [varchar](255) NULL,
	[Size] [int] NULL,
	[TypeID] [int] NULL,
	[Rent] [decimal](10, 2) NULL,
 CONSTRAINT [PK__Properti__70C9A7558D1B7841] PRIMARY KEY CLUSTERED 
(
	[PropertyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyTypes]    Script Date: 1/12/2024 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyTypes](
	[TypeID] [int] NOT NULL,
	[Name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tenants]    Script Date: 1/12/2024 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tenants](
	[TenantID] [int] NOT NULL,
	[Name] [varchar](255) NULL,
	[ContactInfo] [varchar](255) NULL,
	[TenantTypeID] [int] NULL,
	[PropertyID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenantID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TenantTypes]    Script Date: 1/12/2024 5:26:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TenantTypes](
	[TenantTypeID] [int] NOT NULL,
	[Name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenantTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (1, 1, 1, CAST(N'2024-01-01' AS Date), CAST(N'2024-12-31' AS Date), CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (2, 2, 2, CAST(N'2024-01-01' AS Date), CAST(N'2024-12-31' AS Date), CAST(8500.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (3, 4, 3, CAST(N'2024-03-01' AS Date), CAST(N'2025-02-28' AS Date), CAST(12000.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (4, 5, 4, CAST(N'2024-04-01' AS Date), CAST(N'2025-03-31' AS Date), CAST(7000.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (5, 6, 5, CAST(N'2024-05-01' AS Date), CAST(N'2025-04-30' AS Date), CAST(9500.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (6, 7, 6, CAST(N'2024-06-01' AS Date), CAST(N'2025-05-31' AS Date), CAST(8000.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (7, 8, 7, CAST(N'2024-07-01' AS Date), CAST(N'2025-06-30' AS Date), CAST(10500.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (8, 9, 8, CAST(N'2024-08-01' AS Date), CAST(N'2025-07-31' AS Date), CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (9, 10, 9, CAST(N'2024-09-01' AS Date), CAST(N'2025-08-31' AS Date), CAST(7500.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (10, 11, 10, CAST(N'2024-10-01' AS Date), CAST(N'2025-09-30' AS Date), CAST(11000.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (11, 12, 11, CAST(N'2024-11-01' AS Date), CAST(N'2025-10-31' AS Date), CAST(8500.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (12, 13, 12, CAST(N'2024-12-01' AS Date), CAST(N'2025-11-30' AS Date), CAST(9000.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (13, 14, 13, CAST(N'2025-01-01' AS Date), CAST(N'2025-12-31' AS Date), CAST(9500.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (14, 15, 14, CAST(N'2025-02-01' AS Date), CAST(N'2026-01-31' AS Date), CAST(7800.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (15, 16, 15, CAST(N'2025-03-01' AS Date), CAST(N'2026-02-28' AS Date), CAST(11500.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (16, 17, 16, CAST(N'2025-04-01' AS Date), CAST(N'2026-03-31' AS Date), CAST(10500.00 AS Decimal(10, 2)))
INSERT [dbo].[LeaseAgreements] ([LeaseID], [PropertyID], [TenantID], [StartDate], [EndDate], [RentAmount]) VALUES (17, 18, 17, CAST(N'2025-05-01' AS Date), CAST(N'2026-04-30' AS Date), CAST(12000.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Properties] ON 

INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (1, N'123 Main St, London', 2000, 1, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (2, N'456 Market Rd, Manchester', 1500, 2, CAST(8500.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (3, N'789 Warehouse Ln, Birmingham', 5000, 3, CAST(12000.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (4, N'10 Downing Street, London', 2500, 1, CAST(12000.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (5, N'25 Oak Street, Birmingham', 1500, 2, CAST(7000.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (6, N'42 Maple Avenue, Manchester', 3000, 3, CAST(9500.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (7, N'78 Elm Road, Liverpool', 1800, 2, CAST(8000.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (8, N'55 Pine Lane, Leeds', 2200, 1, CAST(10500.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (9, N'101 Cherry Blvd, Bristol', 2000, 5, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (10, N'202 Birch Street, Sheffield', 1600, 4, CAST(7500.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (11, N'303 Cedar Place, Leicester', 2800, 3, CAST(11000.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (12, N'404 Spruce Path, Coventry', 1900, 1, CAST(8500.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (13, N'505 Walnut Avenue, Nottingham', 2300, 2, CAST(9000.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (14, N'606 Magnolia Street, Norwich', 2100, 5, CAST(9500.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (15, N'707 Poplar Road, Swansea', 1700, 4, CAST(7800.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (16, N'808 Fir Lane, Cardiff', 2600, 1, CAST(11500.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (17, N'909 Ash Blvd, Edinburgh', 2400, 3, CAST(10500.00 AS Decimal(10, 2)))
INSERT [dbo].[Properties] ([PropertyID], [Address], [Size], [TypeID], [Rent]) VALUES (18, N'1010 Yew Street, Glasgow', 2500, 2, CAST(12000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Properties] OFF
GO
INSERT [dbo].[PropertyTypes] ([TypeID], [Name]) VALUES (1, N'Office')
INSERT [dbo].[PropertyTypes] ([TypeID], [Name]) VALUES (2, N'Retail')
INSERT [dbo].[PropertyTypes] ([TypeID], [Name]) VALUES (3, N'Warehouse')
INSERT [dbo].[PropertyTypes] ([TypeID], [Name]) VALUES (4, N'Industrial')
INSERT [dbo].[PropertyTypes] ([TypeID], [Name]) VALUES (5, N'Mixed-Use')
GO
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (1, N'John Smith', N'john.smith@example.com', 2, 1)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (2, N'Emily Johnson', N'emily.johnson@example.com', 3, 2)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (3, N'Cafe Good Eats', N'info@cafegoodeats.com', 3, 4)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (4, N'Tech Innovations Ltd', N'contact@techinnovate.com', 2, 5)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (5, N'Bloom and Grow Florists', N'sales@bloomgrow.com', 1, 6)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (6, N'Healthy Smiles Dental', N'appointments@healthysmiles.com', 4, 7)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (7, N'Quick Fitness Gym', N'memberservices@quickfit.com', 3, 8)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (8, N'Bright Minds Tutoring', N'support@brightminds.com', 1, 9)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (9, N'City Electronics', N'service@cityelectronics.com', 1, 10)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (10, N'Urban Fashion Boutique', N'info@urbanfashion.com', 1, 11)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (11, N'The Art Space Gallery', N'contact@theartspace.com', 1, 12)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (12, N'Prestige Law Advisors', N'info@prestigelaw.com', 2, 13)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (13, N'Global Software Solutions', N'contact@globalsw.com', 2, 14)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (14, N'Sunshine Daycare Center', N'info@sunshinedaycare.com', 1, 15)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (15, N'Rapid Courier Services', N'support@rapidcourier.com', 1, 16)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (16, N'Green Earth Landscaping', N'contact@greenearth.com', 1, 17)
INSERT [dbo].[Tenants] ([TenantID], [Name], [ContactInfo], [TenantTypeID], [PropertyID]) VALUES (17, N'Blue Sky Architects', N'design@blueskyarch.com', 2, 18)
GO
INSERT [dbo].[TenantTypes] ([TenantTypeID], [Name]) VALUES (1, N'Retail Store')
INSERT [dbo].[TenantTypes] ([TenantTypeID], [Name]) VALUES (2, N'IT Company')
INSERT [dbo].[TenantTypes] ([TenantTypeID], [Name]) VALUES (3, N'Restaurant')
INSERT [dbo].[TenantTypes] ([TenantTypeID], [Name]) VALUES (4, N'Medical Center')
GO
ALTER TABLE [dbo].[LeaseAgreements]  WITH CHECK ADD  CONSTRAINT [FK__LeaseAgre__Prope__4222D4EF] FOREIGN KEY([PropertyID])
REFERENCES [dbo].[Properties] ([PropertyID])
GO
ALTER TABLE [dbo].[LeaseAgreements] CHECK CONSTRAINT [FK__LeaseAgre__Prope__4222D4EF]
GO
ALTER TABLE [dbo].[LeaseAgreements]  WITH CHECK ADD FOREIGN KEY([TenantID])
REFERENCES [dbo].[Tenants] ([TenantID])
GO
ALTER TABLE [dbo].[Properties]  WITH CHECK ADD  CONSTRAINT [FK__Propertie__TypeI__3B75D760] FOREIGN KEY([TypeID])
REFERENCES [dbo].[PropertyTypes] ([TypeID])
GO
ALTER TABLE [dbo].[Properties] CHECK CONSTRAINT [FK__Propertie__TypeI__3B75D760]
GO
ALTER TABLE [dbo].[Tenants]  WITH CHECK ADD  CONSTRAINT [FK__Tenants__Propert__3F466844] FOREIGN KEY([PropertyID])
REFERENCES [dbo].[Properties] ([PropertyID])
GO
ALTER TABLE [dbo].[Tenants] CHECK CONSTRAINT [FK__Tenants__Propert__3F466844]
GO
ALTER TABLE [dbo].[Tenants]  WITH CHECK ADD FOREIGN KEY([TenantTypeID])
REFERENCES [dbo].[TenantTypes] ([TenantTypeID])
GO
USE [master]
GO
ALTER DATABASE [RealEstateOrganizationDb] SET  READ_WRITE 
GO
