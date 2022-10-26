USE [Reecetados]
GO
/****** Object:  Table [dbo].[Ingredientes]    Script Date: 26/10/2022 08:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredientes](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](max) NULL,
	[CantNecesaria] [int] NOT NULL,
	[Calorias] [varchar](max) NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_Ingredientes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecetasCreadas]    Script Date: 26/10/2022 08:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecetasCreadas](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Ingredientes] [varchar](max) NULL,
	[FechaCreacion] [datetime] NULL,
	[Likes] [int] NULL,
	[Imagen] [varchar](max) NULL,
	[NombreCreador] [varchar](max) NULL,
	[idIngredientes] [int] NULL,
 CONSTRAINT [PK_Recetas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vinos]    Script Date: 26/10/2022 08:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vinos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Porcentajedealcohol] [nchar](10) NULL,
	[PaisDeCreacion] [varchar](max) NULL,
	[FechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_Vinos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[RecetasCreadas]  WITH CHECK ADD  CONSTRAINT [FK_RecetasCreadas_Ingredientes] FOREIGN KEY([idIngredientes])
REFERENCES [dbo].[Ingredientes] ([ID])
GO
ALTER TABLE [dbo].[RecetasCreadas] CHECK CONSTRAINT [FK_RecetasCreadas_Ingredientes]
GO
