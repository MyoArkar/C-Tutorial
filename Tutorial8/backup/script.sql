USE [master]
GO
/****** Object:  Database [user_management_system_db]    Script Date: 4/3/2023 4:03:23 PM ******/
CREATE DATABASE [user_management_system_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'user_management_system_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\user_management_system_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'user_management_system_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\user_management_system_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [user_management_system_db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [user_management_system_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [user_management_system_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [user_management_system_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [user_management_system_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [user_management_system_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [user_management_system_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [user_management_system_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [user_management_system_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [user_management_system_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [user_management_system_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [user_management_system_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [user_management_system_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [user_management_system_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [user_management_system_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [user_management_system_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [user_management_system_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [user_management_system_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [user_management_system_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [user_management_system_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [user_management_system_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [user_management_system_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [user_management_system_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [user_management_system_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [user_management_system_db] SET RECOVERY FULL 
GO
ALTER DATABASE [user_management_system_db] SET  MULTI_USER 
GO
ALTER DATABASE [user_management_system_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [user_management_system_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [user_management_system_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [user_management_system_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [user_management_system_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [user_management_system_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'user_management_system_db', N'ON'
GO
ALTER DATABASE [user_management_system_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [user_management_system_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [user_management_system_db]
GO
/****** Object:  Table [dbo].[m_user]    Script Date: 4/3/2023 4:03:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_user](
	[user_id] [int] NULL,
	[user_name] [nvarchar](100) NULL,
	[password] [nvarchar](100) NULL,
	[gender] [smallint] NULL,
	[address] [nvarchar](255) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [user_management_system_db] SET  READ_WRITE 
GO
