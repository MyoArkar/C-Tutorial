USE [user_management_system_db]
GO
/****** Object:  Table [dbo].[m_user]    Script Date: 4/4/2023 4:00:52 PM ******/
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
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (1, N'mak', N'mak001', 1, N'ygn')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (2, N'jhon', N'jhon002', 2, N'nwy')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (3, N'အောင်အောင်', N'aung003', 1, N'တာမွေ')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (4, N'ကိုကို', N'ko004', 1, N'အင်းစိန်')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (5, N'မြမြ', N'mya005', 2, N'အင်းစိန်')
GO
