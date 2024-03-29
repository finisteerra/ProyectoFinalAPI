USE [ProyectoProgramacion]
GO

CREATE TABLE [dbo].[Bitacoras](
	[ConsecutivoError] [bigint] IDENTITY(1,1) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[MensajeError] [varchar](50) NOT NULL,
	[Origen] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoError] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Ceviches](
	[ConsecutivoCeviche] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Precio] [numeric](10, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Ceviche] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoCeviche] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Promociones](
	[ConsecutivoPromocion] [bigint] IDENTITY(1,1) NOT NULL,
	[DescripcionPromocion] [nvarchar](50) NOT NULL,
	[Descuento] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_Promocion] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoPromocion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Proveedores](
	[ConsecutivoProveedor] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Compañia] [nvarchar](100) NOT NULL,
	[Pais] [nvarchar](70) NOT NULL,
 CONSTRAINT [PK_Provedor] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Roles](
	[ConsecutivoRol] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoRol] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Sucursales](
	[ConsecutivoSucursal] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreSucursal] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Usuarios](
	[ConsecutivoUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[CorreoElectronico] [nvarchar](70) NOT NULL,
	[Contrasenna] [nvarchar](10) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Telefono] [int] NOT NULL,
	[ConsecutivoRol] [bigint] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Usuario] UNIQUE NONCLUSTERED 
(
	[CorreoElectronico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Errores](
	[ConsecutivoError] [bigint] IDENTITY(1,1) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[MensajeError] [nvarchar](50) NOT NULL,
	[Origen] [nvarchar](max) NOT NULL,
	[ConsecutivoUsuario] [bigint] NOT NULL,
 CONSTRAINT [PK_Error] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoError] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Facturas](
	[ConsecutivoFactura] [bigint] IDENTITY(1,1) NOT NULL,
	[ConsecutivoUsuario] [bigint] NOT NULL,
	[ConsecutivoPromocion] [bigint] NOT NULL,
	[ConsecutivoSucursal] [bigint] NOT NULL,
	[Total] [numeric](10, 2) NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Usuarios_Ceviches](
	[ConsecutivoUsuario] [bigint] NOT NULL,
	[ConsecutivoCeviche] [bigint] NOT NULL,
 CONSTRAINT [PK_Usuario_Ceviche] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoUsuario] ASC,
	[ConsecutivoCeviche] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Proveedores_Ceviches](
	[ConsecutivoProveedor] [bigint] NOT NULL,
	[ConsecutivoCeviche] [bigint] NOT NULL,
 CONSTRAINT [PK_Provedor_Ceviche] PRIMARY KEY CLUSTERED 
(
	[ConsecutivoProveedor] ASC,
	[ConsecutivoCeviche] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Proveedores_Ceviches]  WITH CHECK ADD FOREIGN KEY([ConsecutivoProveedor])
REFERENCES [dbo].[Proveedores] ([ConsecutivoProveedor])
GO

ALTER TABLE [dbo].[Proveedores_Ceviches]  WITH CHECK ADD FOREIGN KEY([ConsecutivoCeviche])
REFERENCES [dbo].[Ceviches] ([ConsecutivoCeviche])
GO

ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([ConsecutivoRol])
REFERENCES [dbo].[Roles] ([ConsecutivoRol])
GO

ALTER TABLE [dbo].[Usuarios_Ceviches]  WITH CHECK ADD FOREIGN KEY([ConsecutivoUsuario])
REFERENCES [dbo].[Usuarios] ([ConsecutivoUsuario])
GO

ALTER TABLE [dbo].[Usuarios_Ceviches]  WITH CHECK ADD FOREIGN KEY([ConsecutivoCeviche])
REFERENCES [dbo].[Ceviches] ([ConsecutivoCeviche])
GO

ALTER TABLE [dbo].[Errores]  WITH CHECK ADD FOREIGN KEY([ConsecutivoUsuario])
REFERENCES [dbo].[Usuarios] ([ConsecutivoUsuario])
GO

ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD FOREIGN KEY([ConsecutivoUsuario])
REFERENCES [dbo].[Usuarios] ([ConsecutivoUsuario])

ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD FOREIGN KEY([ConsecutivoPromocion])
REFERENCES [dbo].[Promociones] ([ConsecutivoPromocion])

ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD FOREIGN KEY([ConsecutivoSucursal])
REFERENCES [dbo].[Sucursales] ([ConsecutivoSucursal])

INSERT INTO [dbo].[Ceviches]([Descripcion],[Precio],[Cantidad])  VALUES('Ceviche de camaron con piña picada',5500.00,50);
INSERT INTO [dbo].[Ceviches]([Descripcion],[Precio],[Cantidad])  VALUES('Ceviche de mariscos con vinagreta de chile serrano',7000.99,60);
INSERT INTO [dbo].[Ceviches]([Descripcion],[Precio],[Cantidad])  VALUES('Ceviche en tostadas con coco',4000.00,30);
INSERT INTO [dbo].[Ceviches]([Descripcion],[Precio],[Cantidad])  VALUES('Ceviche con champiñones',5000.00,10);

INSERT INTO [dbo].[Proveedores] ([Nombre],[Apellido],[Compañia],[Pais]) VALUES ('Daniel','Martinez','La Gran Bahia','España');
INSERT INTO [dbo].[Proveedores] ([Nombre],[Apellido],[Compañia],[Pais]) VALUES ('Luis','Stone','The Lobster Coast','Estados Unidos');

INSERT INTO [dbo].[Sucursales] ([NombreSucursal]) VALUES ('San Jose');
INSERT INTO [dbo].[Sucursales] ([NombreSucursal]) VALUES ('Heredia');
INSERT INTO [dbo].[Sucursales] ([NombreSucursal]) VALUES ('Cartago');
INSERT INTO [dbo].[Sucursales] ([NombreSucursal]) VALUES ('Alajuela');

INSERT INTO [dbo].[Roles] ([TipoRol]) VALUES('Usuario');
INSERT INTO [dbo].[Roles] ([TipoRol]) VALUES('Administrador');

CREATE PROCEDURE [dbo].[ValidarUsuario]
	@CorreoElectronico	NVARCHAR(70),
	@Contrasenna		NVARCHAR(10)
AS
BEGIN
	
	SELECT ConsecutivoUsuario,
		   CorreoElectronico,
		   Estado
	  FROM dbo.USUARIOS
	  WHERE CorreoElectronico = @CorreoElectronico
		AND Contrasenna		  = @Contrasenna
		AND Estado			  = 1

END
GO

CREATE OR ALTER PROCEDURE [dbo].[RegistrarUsuario] 
	@Nombre	NVARCHAR(50),
	@Apellido NVARCHAR(50),
	@Edad int,
	@Telefono int,
	@CorreoElectronico	NVARCHAR(70),
	@Contrasenna		NVARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.Usuarios (Nombre,Apellido,Edad,CorreoElectronico,Contrasenna,Estado,Telefono,ConsecutivoRol)
     VALUES(@Nombre,@Apellido, @Edad, @CorreoElectronico,@Contrasenna,1,@Telefono,1)
END
GO
