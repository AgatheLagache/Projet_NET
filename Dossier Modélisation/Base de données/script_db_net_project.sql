USE [master]
GO
/****** Object:  Database [net_project_db]    Script Date: 10/12/2018 15:15:35 ******/
CREATE DATABASE [net_project_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'net_project_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\net_project_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'net_project_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\net_project_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [net_project_db] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [net_project_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [net_project_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [net_project_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [net_project_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [net_project_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [net_project_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [net_project_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [net_project_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [net_project_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [net_project_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [net_project_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [net_project_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [net_project_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [net_project_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [net_project_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [net_project_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [net_project_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [net_project_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [net_project_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [net_project_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [net_project_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [net_project_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [net_project_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [net_project_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [net_project_db] SET  MULTI_USER 
GO
ALTER DATABASE [net_project_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [net_project_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [net_project_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [net_project_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [net_project_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [net_project_db] SET QUERY_STORE = OFF
GO
USE [net_project_db]
GO
/****** Object:  User [lucas]    Script Date: 10/12/2018 15:15:35 ******/
CREATE USER [lucas] FOR LOGIN [lucas] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [kevin]    Script Date: 10/12/2018 15:15:35 ******/
CREATE USER [kevin] FOR LOGIN [kevin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [agathe]    Script Date: 10/12/2018 15:15:35 ******/
CREATE USER [agathe] FOR LOGIN [agathe] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Acteur]    Script Date: 10/12/2018 15:15:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acteur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Action]    Script Date: 10/12/2018 15:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Action](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[description] [varchar](255) NULL,
	[id_Acteur] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Composer]    Script Date: 10/12/2018 15:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Composer](
	[ordre] [int] NOT NULL,
	[id_Action] [int] NOT NULL,
	[id_Scenario] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scenario]    Script Date: 10/12/2018 15:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scenario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Index [prk_constraint_Acteur]    Script Date: 10/12/2018 15:15:36 ******/
ALTER TABLE [dbo].[Acteur] ADD  CONSTRAINT [prk_constraint_Acteur] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [prk_constraint_Action]    Script Date: 10/12/2018 15:15:36 ******/
ALTER TABLE [dbo].[Action] ADD  CONSTRAINT [prk_constraint_Action] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [prk_constraint_Composer]    Script Date: 10/12/2018 15:15:36 ******/
ALTER TABLE [dbo].[Composer] ADD  CONSTRAINT [prk_constraint_Composer] PRIMARY KEY NONCLUSTERED 
(
	[id_Action] ASC,
	[id_Scenario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [prk_constraint_Scenario]    Script Date: 10/12/2018 15:15:36 ******/
ALTER TABLE [dbo].[Scenario] ADD  CONSTRAINT [prk_constraint_Scenario] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Action]  WITH CHECK ADD  CONSTRAINT [FK_Action_id_Acteur] FOREIGN KEY([id_Acteur])
REFERENCES [dbo].[Acteur] ([id])
GO
ALTER TABLE [dbo].[Action] CHECK CONSTRAINT [FK_Action_id_Acteur]
GO
ALTER TABLE [dbo].[Composer]  WITH CHECK ADD  CONSTRAINT [FK_Composer_id_Action] FOREIGN KEY([id_Action])
REFERENCES [dbo].[Action] ([id])
GO
ALTER TABLE [dbo].[Composer] CHECK CONSTRAINT [FK_Composer_id_Action]
GO
ALTER TABLE [dbo].[Composer]  WITH CHECK ADD  CONSTRAINT [FK_Composer_id_Scenario] FOREIGN KEY([id_Scenario])
REFERENCES [dbo].[Scenario] ([id])
GO
ALTER TABLE [dbo].[Composer] CHECK CONSTRAINT [FK_Composer_id_Scenario]
GO
USE [master]
GO
ALTER DATABASE [net_project_db] SET  READ_WRITE 
GO
