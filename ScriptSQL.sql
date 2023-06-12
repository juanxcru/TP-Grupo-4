CREATE DATABASE Supermercado;
GO

USE [Supermercado]
GO
/****** Object:  UserDefinedTableType [dbo].[ItemsTabla]    Script Date: 12/06/2023 17:33:16 ******/
CREATE TYPE [dbo].[ItemsTabla] AS TABLE(
	[id_articulo] [int] NULL,
	[cantidad] [decimal](9, 2) NULL,
	[subtotal] [decimal](9, 2) NULL
)
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[id_articulo] [int] IDENTITY(1,1) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[id_marca] [int] NOT NULL,
	[descripcion] [varchar](30) NOT NULL,
	[precio] [decimal](9, 4) NOT NULL,
	[stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[detalle] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[mail] [varchar](30) NULL,
	[dni] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[dni_empleado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_venta]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_venta](
	[id_item_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NOT NULL,
	[id_articulo] [int] NOT NULL,
	[cantidad] [decimal](18, 0) NOT NULL,
	[sub_total] [decimal](9, 4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_item_venta] ASC,
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[nombre_marca] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[nombre_usuario] [varchar](20) NULL,
	[password] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 12/06/2023 17:33:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha_hora] [smalldatetime] NOT NULL,
	[monto_total] [decimal](9, 4) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Articulo] ON 

INSERT [dbo].[Articulo] ([id_articulo], [id_categoria], [id_marca], [descripcion], [precio], [stock]) VALUES (2, 1, 1, N'Spaguetti', CAST(160.0000 AS Decimal(9, 4)), 61)
INSERT [dbo].[Articulo] ([id_articulo], [id_categoria], [id_marca], [descripcion], [precio], [stock]) VALUES (3, 33, 42, N'Cafe torrado', CAST(500.0000 AS Decimal(9, 4)), 10)
SET IDENTITY_INSERT [dbo].[Articulo] OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (1, N'VERDULERIA')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (2, N'CARNICERIA')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (3, N'BAZAR')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (4, N'GALLETITAS')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (5, N'LACTEOS')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (6, N'Harinas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (7, N'Fideos')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (8, N'Limpieza')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (9, N'Higiene')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (10, N'Lactios')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (11, N'Fiambres')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (12, N'Bebidas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (13, N'Legumbres')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (14, N'Enlatados')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (15, N'Galletitas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (16, N'Arroz')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (17, N'Te')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (18, N'Cafe')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (19, N'Polentas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (20, N'Dentrificos')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (21, N'Harinas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (22, N'Fideos')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (23, N'Limpieza')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (24, N'Higiene')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (25, N'Lactios')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (26, N'Fiambres')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (27, N'Bebidas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (28, N'Legumbres')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (29, N'Enlatados')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (30, N'Galletitas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (31, N'Arroz')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (32, N'Te')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (33, N'Cafe')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (34, N'Polentas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (35, N'Dentrificos')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (36, N'Harinas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (37, N'Fideos')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (38, N'Limpieza')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (39, N'Higiene')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (40, N'Lactios')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (41, N'Fiambres')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (42, N'Bebidas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (43, N'Legumbres')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (44, N'Enlatados')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (45, N'Galletitas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (46, N'Arroz')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (47, N'Te')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (48, N'Cafe')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (49, N'Polentas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (50, N'Dentrificos')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (51, N'Harinas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (52, N'Fideos')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (53, N'Limpieza')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (54, N'Higiene')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (55, N'Lactios')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (56, N'Fiambres')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (57, N'Bebidas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (58, N'Legumbres')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (59, N'Enlatados')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (60, N'Galletitas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (61, N'Arroz')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (62, N'Te')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (63, N'Cafe')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (64, N'Polentas')
INSERT [dbo].[Categoria] ([id_categoria], [detalle]) VALUES (65, N'Dentrificos')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [mail], [dni]) VALUES (1, N'MARCOS', N'ACUÑA', N'marcos.94@gmail.com', 27154897)
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [mail], [dni]) VALUES (2, N'generico', N'generico', N'gen', 0)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (1, N'NICOLAS', N'UZAL', 38095591)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (2, N'MARCELO', N'YAGGI', 36158223)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (3, N'MARTIN', N'SANTO', 45125886)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (31, N'CAMILA', N'SANTO', 42076819)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (32, N'JUAN CRUZ', N'DINARDI', 38256963)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (33, N'ALEJO', N'CALVO', 38256963)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (34, N'GABRIEL', N'SOTELO', 35697842)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (36, N'MAJO', N'ALFANO', 22666720)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (37, N'LEANDRO', N'AGUILAR', 41258963)
INSERT [dbo].[Empleado] ([id_empleado], [nombre], [apellido], [dni_empleado]) VALUES (38, N'CRISTIAN', N'SANTO', 22846625)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (1, N'SIN MARCA')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (2, N'LASERENISIMA')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (3, N'Pureza')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (4, N'Molino')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (5, N'Marolio')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (6, N'Matarazzo')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (7, N'Cif')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (8, N'Magistral')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (9, N'Higienol')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (10, N'Colgate')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (11, N'Serenisima')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (12, N'Milkout')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (13, N'Coca Cola')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (14, N'Fanta')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (15, N'Arcor')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (16, N'La Campanola')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (17, N'Noel')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (18, N'Oreo')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (19, N'2 Hermanos')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (20, N'La Virginia')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (21, N'Arlistan')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (22, N'La Morenita')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (23, N'Presto Pronta')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (24, N'Pureza')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (25, N'Molino')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (26, N'Marolio')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (27, N'Matarazzo')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (28, N'Cif')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (29, N'Magistral')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (30, N'Higienol')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (31, N'Colgate')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (32, N'Serenisima')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (33, N'Milkout')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (34, N'Coca Cola')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (35, N'Fanta')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (36, N'Arcor')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (37, N'La Campanola')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (38, N'Noel')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (39, N'Oreo')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (40, N'2 Hermanos')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (41, N'La Virginia')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (42, N'Arlistan')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (43, N'La Morenita')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (44, N'Presto Pronta')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (45, N'Pureza')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (46, N'Molino')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (47, N'Marolio')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (48, N'Matarazzo')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (49, N'Cif')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (50, N'Magistral')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (51, N'Higienol')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (52, N'Colgate')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (53, N'Serenisima')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (54, N'Milkout')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (55, N'Coca Cola')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (56, N'Fanta')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (57, N'Arcor')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (58, N'La Campanola')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (59, N'Noel')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (60, N'Oreo')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (61, N'2 Hermanos')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (62, N'La Virginia')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (63, N'Arlistan')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (64, N'La Morenita')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (65, N'Presto Pronta')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (66, N'Pureza')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (67, N'Molino')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (68, N'Marolio')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (69, N'Matarazzo')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (70, N'Cif')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (71, N'Magistral')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (72, N'Higienol')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (73, N'Colgate')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (74, N'Serenisima')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (75, N'Milkout')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (76, N'Coca Cola')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (77, N'Fanta')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (78, N'Arcor')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (79, N'La Campanola')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (80, N'Noel')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (81, N'Oreo')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (82, N'2 Hermanos')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (83, N'La Virginia')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (84, N'Arlistan')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (85, N'La Morenita')
INSERT [dbo].[Marca] ([id_marca], [nombre_marca]) VALUES (86, N'Presto Pronta')
SET IDENTITY_INSERT [dbo].[Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[Perfil] ON 

INSERT [dbo].[Perfil] ([id_perfil], [descripcion]) VALUES (1, N'ADMINISTRADOR')
INSERT [dbo].[Perfil] ([id_perfil], [descripcion]) VALUES (2, N'GERENTE')
INSERT [dbo].[Perfil] ([id_perfil], [descripcion]) VALUES (3, N'VENDEDOR')
INSERT [dbo].[Perfil] ([id_perfil], [descripcion]) VALUES (4, N'STOCK')
SET IDENTITY_INSERT [dbo].[Perfil] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (1, 1, 1, N'admin', N'admin')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (2, 2, 2, N'manager', N'manager')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (3, 3, 3, N'vendor', N'vendor')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (20, 31, 4, N'stock', N'b7lIqjRv9IcywVIHjLqy')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (21, 32, 1, N'juan', N'M4PjKvZTuxJmwBJKSwb6')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (22, 33, 2, N'alejo', N'eND0rrVcsheyLv4MQYx7')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (23, 34, 4, N'gabriel', N'Jao1ao4TNiQQMBub2XWc')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (27, 36, 3, N'majo', N'12345')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (28, 37, 4, N'stock2', N'stock')
INSERT [dbo].[Usuario] ([id_usuario], [id_empleado], [id_perfil], [nombre_usuario], [password]) VALUES (30, 38, 1, N'cszanto', N'1234')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Item_venta] ADD  DEFAULT ((0)) FOR [sub_total]
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT ((0)) FOR [monto_total]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD FOREIGN KEY([id_marca])
REFERENCES [dbo].[Marca] ([id_marca])
GO
ALTER TABLE [dbo].[Item_venta]  WITH CHECK ADD FOREIGN KEY([id_articulo])
REFERENCES [dbo].[Articulo] ([id_articulo])
GO
ALTER TABLE [dbo].[Item_venta]  WITH CHECK ADD  CONSTRAINT [fk_Item_venta_Venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[Venta] ([id_venta])
GO
ALTER TABLE [dbo].[Item_venta] CHECK CONSTRAINT [fk_Item_venta_Venta]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfil] ([id_perfil])
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_clientes_dni]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_buscar_clientes_dni]

@dni int
	
AS
BEGIN
	select 
		Cliente.id_cliente,
		Cliente.dni,
		Cliente.nombre,
		Cliente.apellido,
		Cliente.mail
	from 
		Cliente
	where
		Cliente.dni like @dni
	
END	
GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarArticuloACargar]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Buscar articulos a cargar
create procedure [dbo].[sp_BuscarArticuloACargar]
	@pDescripcion varchar (30)
as
Select art.id_articulo as 'Id', art.descripcion as 'Descripcion', Cat.detalle as 'Categoria', Mar.nombre_marca as 'Marca', art.stock as 'Stock' 
from dbo.Articulo Art
inner join dbo.Categoria Cat On art.id_categoria= Cat.id_categoria
inner join dbo.Marca Mar On art.id_marca= Mar.id_marca
where descripcion like '%'+ @pDescripcion+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarCategorias]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Cargar Categoria
create procedure [dbo].[sp_cargarCategorias]
as 
Select id_categoria,detalle from dbo.Categoria
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarMarca]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Cargar Marca
create procedure [dbo].[sp_cargarMarca]
as 
Select id_marca,nombre_marca from dbo.Marca
GO
/****** Object:  StoredProcedure [dbo].[sp_cargarStock]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Cargar Stock
create procedure [dbo].[sp_cargarStock]
	@pIdProducto int,
	@pCantidad int
as
update dbo.Articulo
set Stock = (Stock+@pCantidad)
where id_articulo=@pIdProducto
GO
/****** Object:  StoredProcedure [dbo].[sp_CrearArticulo]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Crear Articulo
create procedure [dbo].[sp_CrearArticulo](	
	@pCategoria int,
	@pMarca int,
	@pDescripcion varchar (30),
	@pPrecio float,
	@pStock int
)
as 
insert into dbo.Articulo(id_categoria,id_marca,descripcion,precio,stock)
values (@pCategoria,@pMarca,@pDescripcion,@pPrecio,	@pStock)
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_usuario]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Eliminar Usuario
CREATE PROCEDURE [dbo].[sp_eliminar_usuario]
    @idEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Eliminar el usuario basado en el id_empleado
    DELETE FROM Usuario
    WHERE id_empleado = @idEmpleado;

    -- Eliminar el empleado basado en el id_empleado
    DELETE FROM Empleado
    WHERE id_empleado = @idEmpleado;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_existe_dni]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_existe_dni]
    @dni INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @existe BIT;

    IF EXISTS (SELECT 1 FROM Cliente WHERE Cliente.dni = @dni)
        SET @existe = 1;
    ELSE
        SET @existe = 0;

    SELECT @existe;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_cliente]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_guardar_cliente]
(    @dni INT,
	@nombre varchar(20),
	@apellido varchar(20),
	@email varchar(30)
)
AS
BEGIN
    

	INSERT INTO Cliente ( dni , apellido , nombre, mail)
	Values (
		
		@dni,
		@apellido,
		@nombre,
		@email
	);


	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_guardar_venta_e_items]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_guardar_venta_e_items]
	@id_cli int,
	@id_emp int,
	@fechahora smalldatetime,
	@monto decimal(9,2),
    @items AS ItemsTabla READONLY
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ventaID INT;

    -- Insertar la venta en la tabla "venta"
   

	INSERT Into Venta ( id_cliente, id_empleado, fecha_hora, monto_total)
		Values
		(
			@id_cli,
			@id_emp,
			@fechahora,
			@monto
		
		);


    -- Obtener el ID de la venta insertada
    SET @ventaID = SCOPE_IDENTITY();

    -- Insertar los items en la tabla "items" relacionados con la venta
    INSERT INTO Item_Venta (id_venta, cantidad, sub_total, id_articulo)
	SELECT @ventaID, cantidad, subtotal, id_articulo
    FROM @items;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_usuario]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Insertar Usuario
CREATE PROCEDURE [dbo].[sp_insertar_usuario]
    @nombre VARCHAR(20),
    @apellido VARCHAR(20),
    @dni INT,
    @nombreUsuario VARCHAR(20),
    @idPerfil INT,
	@password VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar en la tabla "Empleado" y obtener el ID del empleado
	DECLARE @idEmpleado INT;
	INSERT INTO Empleado (nombre, apellido, dni_empleado)
	VALUES (@nombre, @apellido, @dni);
	SET @idEmpleado = SCOPE_IDENTITY();

	-- Insertar en la tabla "Usuario" utilizando el ID del empleado y el ID del perfil
	INSERT INTO Usuario (id_empleado, id_perfil, nombre_usuario, password)
	VALUES (@idEmpleado, @idPerfil, @nombreUsuario, @password);

END
GO
/****** Object:  StoredProcedure [dbo].[sp_listarArticulos]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Listar Articulos
create procedure [dbo].[sp_listarArticulos]
as 
Select a.descripcion as 'Descripcion', c.detalle as 'Categoria',  m.nombre_marca as 'Marca', a.precio as 'Precio'
from dbo.Articulo a
inner join dbo.Categoria c on c.id_categoria = a.id_categoria
inner join dbo.Marca m on m.id_marca = a.id_marca
GO
/****** Object:  StoredProcedure [dbo].[sp_listarArticulosAManipular]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Crear listado de articulos a manipular
create procedure [dbo].[sp_listarArticulosAManipular]
	@pDescripcion varchar (30)
as 
Select a.id_articulo as 'Articulo', a.descripcion as 'Descripcion', c.detalle as 'Categoria',  m.nombre_marca as 'Marca', a.precio as 'Precio'
from dbo.Articulo a
inner join dbo.Categoria c on c.id_categoria = a.id_categoria
inner join dbo.Marca m on m.id_marca = a.id_marca
where a.descripcion like '%'+ @pDescripcion+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_usuario]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_modificar_usuario]
    @idEmpleado INT,
    @nombre VARCHAR(20),
    @apellido VARCHAR(20),
    @dni INT,
    @nombreUsuario VARCHAR(20),
    @idPerfil INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar los datos del empleado
    UPDATE Empleado
    SET nombre = @nombre,
        apellido = @apellido,
        dni_empleado = @dni
    WHERE id_empleado = @idEmpleado;

    -- Actualizar los datos del usuario
    UPDATE Usuario
    SET nombre_usuario = @nombreUsuario,
        id_perfil = @idPerfil
    WHERE id_empleado = @idEmpleado;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_modificarArticulo]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Modificar Articulo
create procedure [dbo].[sp_modificarArticulo](
	@pIdArticulo int,
	@pCategoria int,
	@pMarca int,
	@pDescripcion varchar (30),
	@pPrecio float
)
as
update dbo.Articulo
set descripcion= @pDescripcion,id_categoria= @pCategoria,id_marca= @pMarca, Precio=@pPrecio
where id_articulo=@pIdArticulo
GO
/****** Object:  StoredProcedure [dbo].[sp_ProductosAlerta]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Crear Alerta
create procedure [dbo].[sp_ProductosAlerta]
as 
Select art.descripcion as 'Descripcion', Cat.detalle as 'Categoria', Mar.nombre_marca as 'Marca', art.Stock
from dbo.Articulo Art
inner join dbo.Categoria Cat On art.id_categoria= Cat.id_categoria
inner join dbo.Marca Mar On art.id_marca= Mar.id_marca
where Stock<50
GO
/****** Object:  StoredProcedure [dbo].[sp_validar_articulo]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Validar articulos
CREATE PROCEDURE [dbo].[sp_validar_articulo]

	@id int,
	@cantidad int
AS
BEGIN
	select 
		Articulo.id_articulo, 
		Articulo.descripcion, 
		Articulo.precio,
		Articulo.stock,
		m.nombre_marca,
		c.detalle
	from 
		Articulo articulo
		inner join Marca m on m.id_marca = articulo.id_marca
		inner join Categoria c on c.id_categoria = articulo.id_categoria
	where
		Articulo.id_articulo = @id
		AND stock >= @cantidad
END
GO
/****** Object:  StoredProcedure [dbo].[sp_validar_usuario]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_validar_usuario]

	@username nvarchar(50),
	@password nvarchar(50)

AS
BEGIN
	select 
		Usuario.id_usuario, 
		Usuario.nombre_usuario, 
		Usuario.id_perfil, 
		p.Descripcion,
		Usuario.id_empleado
	from 
		Usuario usuario
		inner join Perfil p on p.id_perfil = Usuario.id_perfil
	where
		upper(nombre_usuario) = upper(@username)
		AND password = @password

END
GO
/****** Object:  StoredProcedure [dbo].[sp_ver_usuarios]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Ver Usuarios
CREATE PROCEDURE [dbo].[sp_ver_usuarios]
AS
BEGIN
     SELECT
        E.id_empleado,
        E.nombre,
        E.apellido,
        E.dni_empleado,
		U.id_usuario,
        U.nombre_usuario,
		U.password,
        P.id_perfil,
        P.descripcion
    FROM
        [Supermercado].[dbo].[Empleado] AS E
        INNER JOIN [Supermercado].[dbo].[Usuario] AS U ON E.id_empleado = U.id_empleado
        INNER JOIN [Supermercado].[dbo].[Perfil] AS P ON U.id_perfil = P.id_perfil;
END
GO
/****** Object:  StoredProcedure [dbo].[ver_ventas]    Script Date: 12/06/2023 17:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ver_ventas]
AS
BEGIN
	SELECT
		*
	FROM 
		Venta
END
GO


USE [Supermercado]
GO

/****** Object:  StoredProcedure [dbo].[sp_select_perfil]    Script Date: 12/06/2023 18:16:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_perfil]
as BEGIN
SELECT 
*
FROM [Supermercado].[dbo].[Perfil]
END
GO