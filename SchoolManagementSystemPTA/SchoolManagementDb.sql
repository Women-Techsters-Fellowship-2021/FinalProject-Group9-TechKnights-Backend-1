USE [SchoolManagementSystemPTA]
GO
/****** Object:  Table [dbo].[AddressData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressData](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[PhysicalCountry] [nvarchar](50) NULL,
	[PhysicalProvince] [nvarchar](50) NULL,
	[PhysicalRegion] [nvarchar](50) NULL,
	[PhysicalCity] [nvarchar](50) NULL,
	[PhysicalAddress] [nvarchar](max) NULL,
	[PhysicalAddressLine2] [nvarchar](50) NULL,
	[PhysicalAddressLine3] [nvarchar](50) NULL,
	[PhysicalOther] [nvarchar](50) NULL,
	[PhysicalPostalCode] [nvarchar](50) NULL,
	[IsPostalSameAsPhysical] [bit] NULL,
	[PostalCountry] [nvarchar](50) NULL,
	[PostalProvince] [nvarchar](50) NULL,
	[PostalRegion] [nvarchar](50) NULL,
	[PostalCity] [nvarchar](50) NULL,
	[PostalAddress] [nvarchar](max) NULL,
	[PostalOther] [nvarchar](50) NULL,
	[PostalPostalCode] [nvarchar](50) NULL,
	[PostalAddressLine2] [nvarchar](50) NULL,
	[PostalAddressLine3] [nvarchar](50) NULL,
 CONSTRAINT [PK_AddressData] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GradeData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GradeData](
	[GradeId] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [nvarchar](50) NOT NULL,
	[GradePoint] [nvarchar](50) NOT NULL,
	[TotalFees] [numeric](18, 0) NOT NULL,
	[GradeDescrption] [nvarchar](max) NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_GradeData] PRIMARY KEY CLUSTERED 
(
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ModuleData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuleData](
	[ModuleId] [int] IDENTITY(1,1) NOT NULL,
	[GradeId] [int] NULL,
	[Module] [nvarchar](50) NULL,
	[PassPoint] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_ModuleData] PRIMARY KEY CLUSTERED 
(
	[ModuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ParentAddressData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParentAddressData](
	[ParentAddressId] [int] IDENTITY(1,1) NOT NULL,
	[ParentId] [int] NOT NULL,
	[AddressId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ParentData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParentData](
	[ParentId] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Midname] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Title] [nchar](10) NOT NULL,
	[Gender] [nchar](10) NOT NULL,
	[MaritalStatus] [nvarchar](20) NOT NULL,
	[IsSouthAfrican] [bit] NULL,
	[DateOfBirth] [date] NULL,
	[IdOrPassport] [nvarchar](50) NOT NULL,
	[HomeLanguage] [nvarchar](50) NULL,
	[PersonalEmailAddress] [nvarchar](100) NULL,
	[WorkTelNumber] [nvarchar](20) NULL,
	[HomeTelNumber] [nvarchar](20) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[CelPhoneNumber] [nvarchar](20) NULL,
	[CommunicationMethod] [nvarchar](20) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Token] [uniqueidentifier] NULL,
	[DateCreated] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](128) NOT NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nchar](10) NULL,
 CONSTRAINT [PK_ParentData] PRIMARY KEY CLUSTERED 
(
	[ParentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentAddressData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAddressData](
	[StudentAddressId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_StudentAddressData] PRIMARY KEY CLUSTERED 
(
	[StudentAddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentData](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentNumber] [nvarchar](50) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Midname] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[IsDisable] [nvarchar](20) NULL,
	[IsSouthAfrican] [bit] NULL,
	[DateOfBirth] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[IdOrPassport] [nvarchar](50) NOT NULL,
	[HomeLanguage] [nvarchar](50) NULL,
	[CountryOfBirth] [nvarchar](50) NULL,
	[PersonalEmailAddress] [nvarchar](100) NULL,
	[WorkTelNumber] [nvarchar](20) NULL,
	[HomeTelNumber] [nvarchar](20) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[CelPhoneNumber] [nvarchar](20) NULL,
	[DateCreated] [datetime] NULL,
	[CreatedBy] [nvarchar](128) NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nchar](10) NULL,
	[PreferedLanguage] [nvarchar](50) NULL,
	[CommunicationMethod] [nvarchar](20) NULL,
	[StudentPhoto] [nvarchar](max) NULL,
	[ApplicationStatus] [nvarchar](50) NULL,
	[Token] [uniqueidentifier] NULL,
 CONSTRAINT [PK_StudentData] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TeacherAddressData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherAddressData](
	[TeacherAddressId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_TeacherAddressData] PRIMARY KEY CLUSTERED 
(
	[TeacherAddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TeacherData]    Script Date: 2021/08/30 07:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherData](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Midname] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Title] [nchar](10) NOT NULL,
	[Gender] [nchar](10) NOT NULL,
	[MaritalStatus] [nvarchar](20) NOT NULL,
	[IsSouthAfrican] [bit] NULL,
	[DateOfBirth] [date] NULL,
	[IdOrPassport] [nvarchar](50) NOT NULL,
	[HomeLanguage] [nvarchar](50) NULL,
	[PersonalEmailAddress] [nvarchar](100) NULL,
	[WorkTelNumber] [nvarchar](20) NULL,
	[HomeTelNumber] [nvarchar](20) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[CelPhoneNumber] [nvarchar](20) NULL,
	[CommunicationMethod] [nvarchar](20) NOT NULL,
	[Token] [uniqueidentifier] NULL,
	[IsActive] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](128) NOT NULL,
	[DateModified] [datetime] NULL,
	[ModifiedBy] [nchar](10) NULL,
 CONSTRAINT [PK_TeacherData] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[GradeData] ADD  CONSTRAINT [DF_GradeData_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[ModuleData] ADD  CONSTRAINT [DF_ModuleData_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
