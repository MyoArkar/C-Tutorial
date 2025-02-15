USE [student_list]
GO
/****** Object:  Table [dbo].[students]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[student_name] [nvarchar](50) NULL,
	[date_of_birth] [date] NULL,
	[uni_id] [int] NULL,
 CONSTRAINT [PK_students] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[universities]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[universities](
	[uni_id] [int] IDENTITY(1,1) NOT NULL,
	[uni_name] [nvarchar](50) NULL,
	[city_id] [int] NULL,
 CONSTRAINT [PK_universities] PRIMARY KEY CLUSTERED 
(
	[uni_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AvgStudentAgeByUni]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AvgStudentAgeByUni] AS
SELECT uni_name, AVG(DATEDIFF(YEAR, date_of_birth, GETDATE())) AS AvgAge
FROM students
INNER JOIN universities ON students.student_id = universities.uni_id
GROUP BY uni_name;

GO
/****** Object:  View [dbo].[UnversityByStudent]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[UnversityByStudent] AS
SELECT uni_name, COUNT(*) AS NumStudents
FROM universities
INNER JOIN students ON students.uni_id=  universities.uni_id
GROUP BY uni_name;
GO
/****** Object:  Table [dbo].[cities]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cities](
	[city_id] [int] IDENTITY(1,1) NOT NULL,
	[city_name] [nvarchar](50) NULL,
	[s_d_id] [int] NULL,
 CONSTRAINT [PK_cities] PRIMARY KEY CLUSTERED 
(
	[city_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[NumOfUni_IN_City]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NumOfUni_IN_City] AS
SELECT city_name, COUNT(*) AS NumUni
FROM cities
INNER JOIN universities ON universities.city_id=  cities.city_id
GROUP BY city_name;
GO
/****** Object:  Table [dbo].[states_divisions]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[states_divisions](
	[s_d_id] [int] IDENTITY(1,1) NOT NULL,
	[s_d_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_states_divisions] PRIMARY KEY CLUSTERED 
(
	[s_d_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[NumOfCity_IN_S_D]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[NumOfCity_IN_S_D] AS
SELECT s_d_name, COUNT(*) AS NumCity
FROM states_divisions
INNER JOIN cities ON cities.s_d_id=  states_divisions.s_d_id
GROUP BY s_d_name;
GO
ALTER TABLE [dbo].[cities]  WITH CHECK ADD  CONSTRAINT [FK_cities_states_divisions] FOREIGN KEY([s_d_id])
REFERENCES [dbo].[states_divisions] ([s_d_id])
GO
ALTER TABLE [dbo].[cities] CHECK CONSTRAINT [FK_cities_states_divisions]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_universities] FOREIGN KEY([uni_id])
REFERENCES [dbo].[universities] ([uni_id])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_universities]
GO
ALTER TABLE [dbo].[universities]  WITH CHECK ADD  CONSTRAINT [FK_universities_cities] FOREIGN KEY([city_id])
REFERENCES [dbo].[cities] ([city_id])
GO
ALTER TABLE [dbo].[universities] CHECK CONSTRAINT [FK_universities_cities]
GO
/****** Object:  StoredProcedure [dbo].[AddCity]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddCity] 
	
	@city_name nvarchar(50),
	@s_d_id int
AS
BEGIN
	INSERT INTO cities(city_name,s_d_id)
	Values (@city_name,@s_d_id)
END
GO
/****** Object:  StoredProcedure [dbo].[AddS_D]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddS_D] 
	@s_d_name nvarchar(50)
AS
BEGIN
	INSERT INTO states_divisions(s_d_name)
	Values (@s_d_name)
END
GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddStudent]
	@student_name nvarchar(50),
	@date_of_birth date,
	@uni_id int
AS
BEGIN
	INSERT INTO students(student_name,date_of_birth,uni_id)
	Values (@student_name,@date_of_birth,@uni_id)
END
GO
/****** Object:  StoredProcedure [dbo].[AddUniversity]    Script Date: 4/23/2023 10:10:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddUniversity]
 
 @uni_name nvarchar(50),
 @city_id int
AS
BEGIN
    INSERT INTO universities(uni_name,city_id)
    VALUES (@uni_name,@city_id);
END;
GO
