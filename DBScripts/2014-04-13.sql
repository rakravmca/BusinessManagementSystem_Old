USE [BusinessManagementSystem]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/13/2014 10:44:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[EmailAddress] [nvarchar](100) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

GO
INSERT [dbo].[User] ([Id], [FirstName], [MiddleName], [LastName], [BirthDate], [EmailAddress], [Gender], [Username], [Password]) VALUES (1, N'Rakesh', N'Kumar', N'Nayak', CAST(0x00007C0700000000 AS DateTime), N'rakravmca@gmail.com', N'M', N'rak', N'rak')
GO
INSERT [dbo].[User] ([Id], [FirstName], [MiddleName], [LastName], [BirthDate], [EmailAddress], [Gender], [Username], [Password]) VALUES (2, N'Test', NULL, N'Test', CAST(0x00007C0700000000 AS DateTime), N'aasd@asdasd.com', N'F', N'test', N'test')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO
