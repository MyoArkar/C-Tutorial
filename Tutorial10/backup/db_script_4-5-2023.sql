USE [user_management_system_db]
GO
/****** Object:  Table [dbo].[m_user]    Script Date: 4/5/2023 4:43:52 PM ******/
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
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (5, N'မြမြ', N'mya006', 2, N'အင်းစိန်')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (6, N'user6', N'user6', 1, N'addfad')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (7, N'user7', N'user7', 2, N'adfadfad')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (8, N'fdfdf', N'dfsdf', 2, N'sdfsdf')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (9, N'dfsdfs', N'dsfsdf', 2, N'sdfsf')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (10, N'dfsdfs', N'sfsd', 2, N'sdfsdfs')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (11, N'sdfsdf', N'dfsdfsdf', 2, N'sdfsfds')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (12, N'fdfsdfs', N'sdfsfs', 2, N'sdfsdfsfsf')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (13, N'user13', N'112121', 2, N'dafdfdfs')
GO
