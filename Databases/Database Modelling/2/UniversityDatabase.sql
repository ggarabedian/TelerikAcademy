USE [master]
GO
/****** Object:  Database [University]    Script Date: 10/9/2015 2:06:42 PM ******/
CREATE DATABASE [University]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'University', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\University.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'University_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\University_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [University] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [University].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [University] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [University] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [University] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [University] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [University] SET ARITHABORT OFF 
GO
ALTER DATABASE [University] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [University] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [University] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [University] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [University] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [University] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [University] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [University] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [University] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [University] SET  DISABLE_BROKER 
GO
ALTER DATABASE [University] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [University] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [University] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [University] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [University] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [University] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [University] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [University] SET RECOVERY FULL 
GO
ALTER DATABASE [University] SET  MULTI_USER 
GO
ALTER DATABASE [University] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [University] SET DB_CHAINING OFF 
GO
ALTER DATABASE [University] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [University] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [University] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'University', N'ON'
GO
USE [University]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
	[professorId] [int] NOT NULL,
	[departamentId] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departaments]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departaments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
	[facultyId] [int] NOT NULL,
 CONSTRAINT [PK_Departaments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculties]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculties](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Faculties] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorCourses]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorCourses](
	[professorId] [int] NOT NULL,
	[courseId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Professors]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Professors](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
	[departamentId] [int] NOT NULL,
 CONSTRAINT [PK_Professors] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProfessorTitles]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfessorTitles](
	[professorId] [int] NOT NULL,
	[titleId] [int] NOT NULL,
 CONSTRAINT [PK_ProfessorTitles] PRIMARY KEY CLUSTERED 
(
	[professorId] ASC,
	[titleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentCourses]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentCourses](
	[studentId] [int] NOT NULL,
	[courseId] [int] NOT NULL,
 CONSTRAINT [PK_StudentCourses] PRIMARY KEY CLUSTERED 
(
	[studentId] ASC,
	[courseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
	[facultyId] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Titles]    Script Date: 10/9/2015 2:06:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Titles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Titles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departaments] FOREIGN KEY([departamentId])
REFERENCES [dbo].[Departaments] ([id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departaments]
GO
ALTER TABLE [dbo].[Departaments]  WITH CHECK ADD  CONSTRAINT [FK_Departaments_Faculties] FOREIGN KEY([facultyId])
REFERENCES [dbo].[Faculties] ([id])
GO
ALTER TABLE [dbo].[Departaments] CHECK CONSTRAINT [FK_Departaments_Faculties]
GO
ALTER TABLE [dbo].[ProfessorCourses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorCourses_Courses] FOREIGN KEY([courseId])
REFERENCES [dbo].[Courses] ([id])
GO
ALTER TABLE [dbo].[ProfessorCourses] CHECK CONSTRAINT [FK_ProfessorCourses_Courses]
GO
ALTER TABLE [dbo].[ProfessorCourses]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorCourses_Professors] FOREIGN KEY([professorId])
REFERENCES [dbo].[Professors] ([id])
GO
ALTER TABLE [dbo].[ProfessorCourses] CHECK CONSTRAINT [FK_ProfessorCourses_Professors]
GO
ALTER TABLE [dbo].[Professors]  WITH CHECK ADD  CONSTRAINT [FK_Professors_Departaments] FOREIGN KEY([departamentId])
REFERENCES [dbo].[Departaments] ([id])
GO
ALTER TABLE [dbo].[Professors] CHECK CONSTRAINT [FK_Professors_Departaments]
GO
ALTER TABLE [dbo].[ProfessorTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorTitles_Professors] FOREIGN KEY([professorId])
REFERENCES [dbo].[Professors] ([id])
GO
ALTER TABLE [dbo].[ProfessorTitles] CHECK CONSTRAINT [FK_ProfessorTitles_Professors]
GO
ALTER TABLE [dbo].[ProfessorTitles]  WITH CHECK ADD  CONSTRAINT [FK_ProfessorTitles_Titles] FOREIGN KEY([titleId])
REFERENCES [dbo].[Titles] ([id])
GO
ALTER TABLE [dbo].[ProfessorTitles] CHECK CONSTRAINT [FK_ProfessorTitles_Titles]
GO
ALTER TABLE [dbo].[StudentCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourses_Courses] FOREIGN KEY([courseId])
REFERENCES [dbo].[Courses] ([id])
GO
ALTER TABLE [dbo].[StudentCourses] CHECK CONSTRAINT [FK_StudentCourses_Courses]
GO
ALTER TABLE [dbo].[StudentCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourses_Students] FOREIGN KEY([studentId])
REFERENCES [dbo].[Students] ([id])
GO
ALTER TABLE [dbo].[StudentCourses] CHECK CONSTRAINT [FK_StudentCourses_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Faculties] FOREIGN KEY([facultyId])
REFERENCES [dbo].[Faculties] ([id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Faculties]
GO
USE [master]
GO
ALTER DATABASE [University] SET  READ_WRITE 
GO
