USE [ejercicio]
GO

/****** Object:  Table [dbo].[puesto]    Script Date: 17/02/2022 04:27:36 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[puesto](
	[id_puesto] [int] IDENTITY(1,1) NOT NULL,
	[puesto] [varchar](45) NOT NULL,
	[cargo] [varchar](45) NOT NULL,
	[tareas] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

