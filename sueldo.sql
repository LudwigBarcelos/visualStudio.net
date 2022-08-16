USE [ejercicio]
GO

/****** Object:  Table [dbo].[sueldo]    Script Date: 17/02/2022 04:27:45 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sueldo](
	[id_sueldo] [int] IDENTITY(1,1) NOT NULL,
	[id_trabajador] [int] NOT NULL,
	[id_puesto] [int] NOT NULL,
	[sueldo] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sueldo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[sueldo]  WITH CHECK ADD FOREIGN KEY([id_trabajador])
REFERENCES [dbo].[trabajador] ([id_trabajador])
GO

