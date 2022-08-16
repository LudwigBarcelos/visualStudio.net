USE [ejercicio]
GO

/****** Object:  Table [dbo].[trabajador]    Script Date: 11/02/2022 07:21:04 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[trabajador](
	[id_trabajador] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[apellido_pat] [varchar](45) NOT NULL,
	[apellido_mat] [varchar](45) NOT NULL,
	[direccion] [varchar](45) NOT NULL,
	[telefono] [varchar](45) NOT NULL,
	[num_empleado] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_puesto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_trabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

