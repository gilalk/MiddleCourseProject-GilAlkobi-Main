USE [master]
GO
/****** Object:  Database [SchoolManagement]    Script Date: 28/02/2022 17:49:56 ******/
CREATE DATABASE [SchoolManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SchoolManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SchoolManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SchoolManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SchoolManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SchoolManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolManagement] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SchoolManagement] SET QUERY_STORE = OFF
GO
USE [SchoolManagement]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 28/02/2022 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK__Accounts__3214EC077097F5F8] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 28/02/2022 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [nvarchar](50) NULL,
	[crewMemberId] [int] NULL,
	[ClassCode] [int] NULL,
	[ClassName] [nvarchar](20) NULL,
 CONSTRAINT [PK__Class__CB1927C0FA645A65] PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CrewMembers]    Script Date: 28/02/2022 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CrewMembers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Role] [nvarchar](50) NULL,
	[Subject] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[Adress] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK__CrewMemb__3214EC072D1C5067] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HomeWork]    Script Date: 28/02/2022 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HomeWork](
	[HW_Id] [int] NOT NULL,
	[StudentId] [int] NULL,
	[SignDate] [datetime] NULL,
	[HWContent] [varbinary](max) NULL,
	[ClassId] [int] NULL,
	[Grade] [int] NULL,
 CONSTRAINT [PK_HomeWork] PRIMARY KEY CLUSTERED 
(
	[HW_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parent]    Script Date: 28/02/2022 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parent](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [nvarchar](10) NULL,
	[DateOfBirth] [date] NULL,
	[Age] [int] NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[WorkAddress] [nvarchar](50) NULL,
	[AccountId] [int] NULL,
 CONSTRAINT [PK__Parent__3214EC073AB408F6] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 28/02/2022 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [nvarchar](10) NULL,
	[DateOfBirth] [date] NULL,
	[Age] [int] NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[EmergacyContactName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Class]    Script Date: 28/02/2022 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Class](
	[ClassId] [int] NOT NULL,
	[StudentId] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Student_Class] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_parent]    Script Date: 28/02/2022 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_parent](
	[ParentId] [int] NOT NULL,
	[StudentId] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (1, N'yehudan', N'y1234')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (3, N'yoela', N'yo1234')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (4, N'talah', N't1234')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (5, N'yafaev', N'yafa123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (6, N'yoramef', N'ef1234')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (7, N'avichi', N'avi123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (8, N'oritik', N'tik123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (9, N'daniels', N'shl123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (10, N'organ', N'gan123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (12, N'orsha', N'os123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (26, N'MoranVizel', N'MoranVizel123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (27, N'GiladAvni', N'GiladAvni123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (28, N'DaliahYehu', N'DaliahYehu123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (29, N'GilAlkobi', N'GilAlkobi123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (30, N'OraBora', N'OraBora123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (31, N'YaelShoshana', N'YaelShoshana123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (32, N'MaorDeri', N'MaorDeri123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (33, N'AviaSimhi', N'avi123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (34, N'GuyNadel', N'GuyNadel123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (35, N'davidavior', N'davidavior123')
INSERT [dbo].[Accounts] ([Id], [UserName], [Password]) VALUES (36, N'ayalalavi', N'ayalalavi123')
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (1, N'Mathematics', 5, NULL, NULL)
INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (2, N'English', 4, NULL, NULL)
INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (3, N'Bible', 3, 1247, N'')
INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (4, N'History', 6, 1239, N'')
INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (5, N'Mathematics', 7, 1398, N'')
INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (6, N'Mathematics', 8, 1399, N'')
INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (7, N'physics', 10, 1192, N'')
INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (8, N'English', 4, 1277, N'')
INSERT [dbo].[Class] ([ClassId], [SubjectName], [crewMemberId], [ClassCode], [ClassName]) VALUES (9, N'physics', 11, 1198, N'')
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
SET IDENTITY_INSERT [dbo].[CrewMembers] ON 

INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (1, N'Yehuda', N'Dan', N'male', NULL, N'manager', N'', NULL, N'Rakefet 23', N'Modi''in', N'yehudanmanage@gmail.com', N'', 1)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (3, N'Yoel', N'Avitbol', N'male', NULL, N'teacher', N'physics', NULL, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (4, N'Tal', N'Aharon', N'male', NULL, N'teacher', N'English', NULL, NULL, NULL, NULL, NULL, 4)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (5, N'Yafa', N'Eviatar', N'female', NULL, N'teacher', N'Mathematics', NULL, N'', N'', NULL, N'', 5)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (6, N'Yoram', N'Efrati', N'male', NULL, N'teacher', N'History', NULL, NULL, NULL, NULL, NULL, 6)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (7, N'Gil', N'Alkobi', N'male', 31, N'teacher', N'Mathematics', CAST(N'1991-02-26' AS Date), N'Sheera 3', N'Beit Horon', N'gil@gmail.com', N'0509879972', 29)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (8, N'Ora', N'Bora', N'female', 0, N'teacher', N'Mathematics', CAST(N'2022-01-24' AS Date), N'Yehuda 41', N'Tveria', N'Ora.bora@gmail.com', N'0505998764', 30)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (9, N'Yael', N'Shoshana', N'female', 34, N'deputy director', N'', CAST(N'1988-06-01' AS Date), N'Beirav 54', N'Zefat', N'yashosh@gmail.com', N'0522398764', 31)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (10, N'Maor', N'Deri', N'male', 24, N'teacher', N'physics', CAST(N'1998-10-14' AS Date), N'Bonei Hair 2', N'Yavne', N'maor.deri@gmail.com', N'0509876554', 32)
INSERT [dbo].[CrewMembers] ([Id], [FirstName], [LastName], [Gender], [Age], [Role], [Subject], [DateOfBirth], [Adress], [City], [Email], [PhoneNumber], [AccountId]) VALUES (11, N'Avia', N'Simhi', N'female', 23, N'teacher', N'physics', CAST(N'1999-02-23' AS Date), N'Yehuda Hamaccabi 24', N'Beit Horon', N'aviasi@gmail.com', N'0538776549', 33)
SET IDENTITY_INSERT [dbo].[CrewMembers] OFF
GO
SET IDENTITY_INSERT [dbo].[Parent] ON 

INSERT [dbo].[Parent] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [Email], [PhoneNumber], [WorkAddress], [AccountId]) VALUES (1, N'Avia', N'Alkobi', N'female', NULL, NULL, NULL, N'Beit Horon', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [Email], [PhoneNumber], [WorkAddress], [AccountId]) VALUES (2, N'Moshe', N'Shlaim', N'male', NULL, NULL, NULL, N'Yavne', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [Email], [PhoneNumber], [WorkAddress], [AccountId]) VALUES (3, N'Nava', N'Shlaim', N'female', NULL, NULL, NULL, N'Yavne', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [Email], [PhoneNumber], [WorkAddress], [AccountId]) VALUES (4, N'Gil', N'Alkobi', N'male', NULL, NULL, NULL, N'Beit Horon', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [Email], [PhoneNumber], [WorkAddress], [AccountId]) VALUES (5, N'Tirza', N'Ganon', N'female', NULL, NULL, NULL, N'Rishon Lezion', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [Email], [PhoneNumber], [WorkAddress], [AccountId]) VALUES (6, N'Yossi', N'Tikozki', N'male', NULL, NULL, NULL, N'Ramat Gan', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [Email], [PhoneNumber], [WorkAddress], [AccountId]) VALUES (7, N'Sara', N'Dahan', N'female', NULL, NULL, NULL, N'Zefat', NULL, NULL, NULL, NULL)
INSERT [dbo].[Parent] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [Email], [PhoneNumber], [WorkAddress], [AccountId]) VALUES (8, N'Eli', N'Dahan', N'male', NULL, NULL, NULL, N'Zefat', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Parent] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (1, N'Avichai', N'Dahan', N'male', NULL, NULL, N'Maccabi 601', N'Zefat', N'0544888765', N'', N'', 7)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (2, N'Ori', N'Tikozki', N'male', NULL, NULL, NULL, N'Ramat-Gan', NULL, NULL, NULL, 8)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (3, N'Daniel', N'Shlaim', N'male', NULL, NULL, N'Hamechonai 2', N'Yavne', N'0505763344', N'danishl@gmail.com', N'0544677899', 9)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (4, N'Or', N'Ganon', N'male', NULL, NULL, NULL, N'Rishon Lezion', NULL, NULL, NULL, 10)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (6, N'Or', N'Shani', N'male', NULL, NULL, NULL, N'Netanya', NULL, NULL, NULL, 12)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (9, N'Moran', N'Vizel', N'female', CAST(N'2000-11-23' AS Date), 22, N'Shani 54', N'Beit Shemesh', N'0548744775', N'morivi@gmail.com', N'0505666777', 26)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (10, N'Gilad', N'Avni', N'male', CAST(N'2001-03-14' AS Date), 21, N'Hameyasdim 1', N'Jerusalem', N'', N'gilav@gmail.com', N'', 27)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (11, N'Daliah', N'Yehu', N'male', CAST(N'2005-06-17' AS Date), 17, N'Shvo 24', N'Modi''in', N'', N'dayehu@gmail.com', N'', 28)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (12, N'Guy', N'Nadel', N'male', CAST(N'2008-02-05' AS Date), 14, N'yeela 5', N'Beer Sheva', N'0544897654', N'guyna@yahoo.com', N'0534897897', 34)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (13, N'David', N'Avior', N'male', CAST(N'2004-06-08' AS Date), 18, N'', N'', N'0509889971', N'davav@gmail.com', N'0533789654', 35)
INSERT [dbo].[Student] ([Id], [FirstName], [LastName], [Gender], [DateOfBirth], [Age], [Address], [City], [EmergacyContactName], [Email], [PhoneNumber], [AccountId]) VALUES (14, N'Ayala', N'Lavi', N'female', CAST(N'2005-02-01' AS Date), 17, N'', N'', N'0544987989', N'ayalav@walla.com', N'0523435456', 36)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Student_Class] ON 

INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (1, 1, 1)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (1, 2, 2)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (2, 1, 4)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (2, 6, 7)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (3, 12, 9)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (3, 1, 10)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (3, 10, 11)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (3, 3, 12)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (3, 14, 13)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (3, 2, 14)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (6, 1, 15)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (6, 13, 16)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (4, 2, 17)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (7, 12, 18)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (7, 10, 19)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (7, 4, 20)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (5, 11, 21)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (5, 3, 22)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (9, 2, 23)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (9, 4, 24)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (2, 13, 25)
INSERT [dbo].[Student_Class] ([ClassId], [StudentId], [Id]) VALUES (8, 9, 26)
SET IDENTITY_INSERT [dbo].[Student_Class] OFF
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_CrewMembers] FOREIGN KEY([crewMemberId])
REFERENCES [dbo].[CrewMembers] ([Id])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_CrewMembers]
GO
ALTER TABLE [dbo].[CrewMembers]  WITH CHECK ADD  CONSTRAINT [FK_CrewMembers_Accounts] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[CrewMembers] CHECK CONSTRAINT [FK_CrewMembers_Accounts]
GO
ALTER TABLE [dbo].[HomeWork]  WITH CHECK ADD  CONSTRAINT [FK_HomeWork_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[HomeWork] CHECK CONSTRAINT [FK_HomeWork_Student]
GO
ALTER TABLE [dbo].[Parent]  WITH CHECK ADD  CONSTRAINT [FK_Parent_Accounts] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[Parent] CHECK CONSTRAINT [FK_Parent_Accounts]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Accounts] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Accounts]
GO
ALTER TABLE [dbo].[Student_Class]  WITH CHECK ADD  CONSTRAINT [FK_Student_Class_Class] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[Student_Class] CHECK CONSTRAINT [FK_Student_Class_Class]
GO
ALTER TABLE [dbo].[Student_Class]  WITH CHECK ADD  CONSTRAINT [FK_Student_Class_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Student_Class] CHECK CONSTRAINT [FK_Student_Class_Student]
GO
ALTER TABLE [dbo].[Student_parent]  WITH CHECK ADD  CONSTRAINT [FK_FamilyConnection_Parent] FOREIGN KEY([ParentId])
REFERENCES [dbo].[Parent] ([Id])
GO
ALTER TABLE [dbo].[Student_parent] CHECK CONSTRAINT [FK_FamilyConnection_Parent]
GO
ALTER TABLE [dbo].[Student_parent]  WITH CHECK ADD  CONSTRAINT [FK_FamilyConnection_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Student_parent] CHECK CONSTRAINT [FK_FamilyConnection_Student]
GO
USE [master]
GO
ALTER DATABASE [SchoolManagement] SET  READ_WRITE 
GO
