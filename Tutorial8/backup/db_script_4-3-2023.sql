USE [user_management_system_db]
GO
/****** Object:  Table [dbo].[m_user]    Script Date: 4/3/2023 4:18:23 PM ******/
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
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (7891, N'mak', N'akak7891', 2, N'ygn')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (78912, N'akak', N'jkjk7892', 1, N'mdy')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (1234, N'hak', N'hkhk1234', 1, N'mdy')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (2647, N'jfk', N'jfk2647', 2, N'Npd')
INSERT [dbo].[m_user] ([user_id], [user_name], [password], [gender], [address]) VALUES (2356, N'lklk', N'lklk2356', 1, N'fjaljfldjflsd')
GO
