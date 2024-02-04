USE [master]
GO
/****** Object:  Database [LCPCollectionDB]    Script Date: 04/02/2024 12:36:15 ******/
CREATE DATABASE [LCPCollectionDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LCPCollectionDB', FILENAME = N'C:\Users\luisc\LCPCollectionDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LCPCollectionDB_log', FILENAME = N'C:\Users\luisc\LCPCollectionDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LCPCollectionDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LCPCollectionDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LCPCollectionDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [LCPCollectionDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LCPCollectionDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LCPCollectionDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LCPCollectionDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LCPCollectionDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [LCPCollectionDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LCPCollectionDB] SET  MULTI_USER 
GO
ALTER DATABASE [LCPCollectionDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LCPCollectionDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LCPCollectionDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LCPCollectionDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LCPCollectionDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LCPCollectionDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LCPCollectionDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [LCPCollectionDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LCPCollectionDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 04/02/2024 12:36:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Animes]    Script Date: 04/02/2024 12:36:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CoverUrl] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Companies] [nvarchar](max) NULL,
	[Publishers] [nvarchar](max) NULL,
	[Platforms] [nvarchar](max) NULL,
	[ReleaseDate] [datetime2](7) NULL,
	[TrailerUrl] [nvarchar](max) NULL,
	[Genre] [nvarchar](max) NULL,
	[Rating] [float] NULL,
 CONSTRAINT [PK_Animes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 04/02/2024 12:36:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CoverUrl] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Companies] [nvarchar](max) NULL,
	[Publishers] [nvarchar](max) NULL,
	[Platforms] [nvarchar](max) NULL,
	[ReleaseDate] [datetime2](7) NULL,
	[TrailerUrl] [nvarchar](max) NULL,
	[Genre] [nvarchar](max) NULL,
	[Rating] [float] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FilesData]    Script Date: 04/02/2024 12:36:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FilesData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GId] [uniqueidentifier] NOT NULL,
	[ImageBytes] [varbinary](max) NULL,
	[FileName] [nvarchar](max) NOT NULL,
	[FileType] [nvarchar](max) NOT NULL,
	[FileFullPath] [nvarchar](max) NULL,
	[FileSize] [bigint] NOT NULL,
 CONSTRAINT [PK_FilesData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 04/02/2024 12:36:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CoverUrl] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Companies] [nvarchar](max) NULL,
	[Publishers] [nvarchar](max) NULL,
	[Platforms] [nvarchar](max) NULL,
	[ReleaseDate] [datetime2](7) NULL,
	[TrailerUrl] [nvarchar](max) NULL,
	[Genre] [nvarchar](max) NULL,
	[Rating] [float] NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 04/02/2024 12:36:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CoverUrl] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Companies] [nvarchar](max) NULL,
	[Publishers] [nvarchar](max) NULL,
	[Platforms] [nvarchar](max) NULL,
	[ReleaseDate] [datetime2](7) NULL,
	[TrailerUrl] [nvarchar](max) NULL,
	[Genre] [nvarchar](max) NULL,
	[Rating] [float] NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TVSeries]    Script Date: 04/02/2024 12:36:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TVSeries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CoverUrl] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Companies] [nvarchar](max) NULL,
	[Publishers] [nvarchar](max) NULL,
	[Platforms] [nvarchar](max) NULL,
	[ReleaseDate] [datetime2](7) NULL,
	[TrailerUrl] [nvarchar](max) NULL,
	[Genre] [nvarchar](max) NULL,
	[Rating] [float] NULL,
 CONSTRAINT [PK_TVSeries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [LCPCollectionDB] SET  READ_WRITE 
GO
