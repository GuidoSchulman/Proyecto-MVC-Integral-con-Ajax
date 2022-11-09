USE [Recetados]
GO
/****** Object:  Table [dbo].[Ingredientes]    Script Date: 9/11/2022 12:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredientes](
	[ID_Ingredientes] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[CantNecesaria] [int] NOT NULL,
	[Calorias] [float] NULL,
	[Imagen] [image] NULL,
 CONSTRAINT [PK_Ingredientes] PRIMARY KEY CLUSTERED 
(
	[ID_Ingredientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IngredientesXRecetasCreadas]    Script Date: 9/11/2022 12:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredientesXRecetasCreadas](
	[ID_Ingredientes] [int] NOT NULL,
	[ID_Recetas] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecetasCreadas]    Script Date: 9/11/2022 12:03:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecetasCreadas](
	[ID_Recetas] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Ingredientes] [varchar](max) NULL,
	[FechaCreacion] [datetime] NULL,
	[Likes] [int] NULL,
	[Imagen] [image] NULL,
	[NombreCreador] [varchar](max) NULL,
 CONSTRAINT [PK_Recetas] PRIMARY KEY CLUSTERED 
(
	[ID_Recetas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vinos]    Script Date: 9/11/2022 12:03:23 ******/
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
SET IDENTITY_INSERT [dbo].[Ingredientes] ON 

INSERT [dbo].[Ingredientes] ([ID_Ingredientes], [Nombre], [CantNecesaria], [Calorias], [Imagen]) VALUES (1, N'Pan', 2, 30, NULL)
INSERT [dbo].[Ingredientes] ([ID_Ingredientes], [Nombre], [CantNecesaria], [Calorias], [Imagen]) VALUES (2, N'Azucar', 50, 500, NULL)
INSERT [dbo].[Ingredientes] ([ID_Ingredientes], [Nombre], [CantNecesaria], [Calorias], [Imagen]) VALUES (3, N'Salchicha', 3, 300, NULL)
SET IDENTITY_INSERT [dbo].[Ingredientes] OFF
GO
INSERT [dbo].[IngredientesXRecetasCreadas] ([ID_Ingredientes], [ID_Recetas]) VALUES (1, 1)
INSERT [dbo].[IngredientesXRecetasCreadas] ([ID_Ingredientes], [ID_Recetas]) VALUES (2, 1)
GO
SET IDENTITY_INSERT [dbo].[RecetasCreadas] ON 

INSERT [dbo].[RecetasCreadas] ([ID_Recetas], [Nombre], [Ingredientes], [FechaCreacion], [Likes], [Imagen], [NombreCreador]) VALUES (1, N'Pan Dulce', N'Pan; Azucar', CAST(N'2005-05-16T00:00:00.000' AS DateTime), 5, NULL, N'Guido123')
INSERT [dbo].[RecetasCreadas] ([ID_Recetas], [Nombre], [Ingredientes], [FechaCreacion], [Likes], [Imagen], [NombreCreador]) VALUES (2, N'Omelette', N'Huevo, Sal', CAST(N'2001-06-20T00:00:00.000' AS DateTime), 10, NULL, N'Shirly1220')
INSERT [dbo].[RecetasCreadas] ([ID_Recetas], [Nombre], [Ingredientes], [FechaCreacion], [Likes], [Imagen], [NombreCreador]) VALUES (3, N'Flan', N'Huevo, DulceDeLeche', CAST(N'2022-06-22T00:00:00.000' AS DateTime), 6, NULL, N'Martin654')
SET IDENTITY_INSERT [dbo].[RecetasCreadas] OFF
GO
ALTER TABLE [dbo].[IngredientesXRecetasCreadas]  WITH CHECK ADD  CONSTRAINT [FK_IngredientesXRecetasCreadas_Ingredientes] FOREIGN KEY([ID_Ingredientes])
REFERENCES [dbo].[Ingredientes] ([ID_Ingredientes])
GO
ALTER TABLE [dbo].[IngredientesXRecetasCreadas] CHECK CONSTRAINT [FK_IngredientesXRecetasCreadas_Ingredientes]
GO
ALTER TABLE [dbo].[IngredientesXRecetasCreadas]  WITH CHECK ADD  CONSTRAINT [FK_IngredientesXRecetasCreadas_RecetasCreadas] FOREIGN KEY([ID_Recetas])
REFERENCES [dbo].[RecetasCreadas] ([ID_Recetas])
GO
ALTER TABLE [dbo].[IngredientesXRecetasCreadas] CHECK CONSTRAINT [FK_IngredientesXRecetasCreadas_RecetasCreadas]
GO
