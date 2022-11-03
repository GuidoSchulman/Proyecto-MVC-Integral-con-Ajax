USE [Recetados]
GO
/****** Object:  Table [dbo].[Ingredientes]    Script Date: 3/11/2022 15:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredientes](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](max) NULL,
	[CantNecesaria] [int] NOT NULL,
	[Calorias] [float] NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_Ingredientes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecetasCreadas]    Script Date: 3/11/2022 15:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecetasCreadas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Ingredientes] [varchar](max) NULL,
	[FechaCreacion] [datetime] NULL,
	[Likes] [int] NULL,
	[Imagen] [image] NULL,
	[NombreCreador] [varchar](max) NULL,
	[idIngredientes] [int] NOT NULL,
 CONSTRAINT [PK_Recetas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vinos]    Script Date: 3/11/2022 15:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vinos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Porcentajedealcohol] [float] NULL,
	[PaisDeCreacion] [varchar](max) NULL,
	[FechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_Vinos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Ingredientes] ([ID], [Nombre], [CantNecesaria], [Calorias], [Imagen]) VALUES (1, N'Pan', 2, 30, NULL)
GO
SET IDENTITY_INSERT [dbo].[RecetasCreadas] ON 

INSERT [dbo].[RecetasCreadas] ([ID], [Nombre], [Ingredientes], [FechaCreacion], [Likes], [Imagen], [NombreCreador], [idIngredientes]) VALUES (1, N'Pan Dulce', N'Pan; Azucar', CAST(N'2005-05-16T00:00:00.000' AS DateTime), 5, NULL, N'Guido123', 1)
SET IDENTITY_INSERT [dbo].[RecetasCreadas] OFF
GO
ALTER TABLE [dbo].[RecetasCreadas]  WITH CHECK ADD  CONSTRAINT [FK_RecetasCreadas_Ingredientes] FOREIGN KEY([idIngredientes])
REFERENCES [dbo].[Ingredientes] ([ID])
GO
ALTER TABLE [dbo].[RecetasCreadas] CHECK CONSTRAINT [FK_RecetasCreadas_Ingredientes]
GO
