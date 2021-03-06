USE [WebService]
GO
/****** Object:  Table [dbo].[curso]    Script Date: 10/25/2016 20:03:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[curso](
	[curId] [int] IDENTITY(1,1) NOT NULL,
	[CurNombre] [varchar](50) NULL,
	[CurCred] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[curId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[curso] ON
INSERT [dbo].[curso] ([curId], [CurNombre], [CurCred]) VALUES (1, N'BI', 4)
INSERT [dbo].[curso] ([curId], [CurNombre], [CurCred]) VALUES (2, N'Ingeneria de sofwtare', 4)
INSERT [dbo].[curso] ([curId], [CurNombre], [CurCred]) VALUES (3, N'poo', 4)
INSERT [dbo].[curso] ([curId], [CurNombre], [CurCred]) VALUES (4, N'ingenieria procesos', 4)
INSERT [dbo].[curso] ([curId], [CurNombre], [CurCred]) VALUES (5, N'matematica', 4)
SET IDENTITY_INSERT [dbo].[curso] OFF
/****** Object:  Table [dbo].[alumno]    Script Date: 10/25/2016 20:03:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[alumno](
	[AluId] [int] IDENTITY(1,1) NOT NULL,
	[ALuNom] [varchar](40) NULL,
	[AluApe] [varchar](40) NULL,
	[AluDni] [char](8) NULL,
	[AluEdad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AluId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[alumno] ON
INSERT [dbo].[alumno] ([AluId], [ALuNom], [AluApe], [AluDni], [AluEdad]) VALUES (1, N'juvenal', N'quispe tapia', N'23456789', 24)
INSERT [dbo].[alumno] ([AluId], [ALuNom], [AluApe], [AluDni], [AluEdad]) VALUES (4, N'juvenal', N'quispe tapia', N'34678934', 30)
INSERT [dbo].[alumno] ([AluId], [ALuNom], [AluApe], [AluDni], [AluEdad]) VALUES (6, N'roiser', N'quispe tapia', N'234567  ', 22)
INSERT [dbo].[alumno] ([AluId], [ALuNom], [AluApe], [AluDni], [AluEdad]) VALUES (7, N'cris', N'perez', N'345678  ', 22)
INSERT [dbo].[alumno] ([AluId], [ALuNom], [AluApe], [AluDni], [AluEdad]) VALUES (8, N'juvenal', N'quispe', N'2334567 ', 23)
SET IDENTITY_INSERT [dbo].[alumno] OFF
