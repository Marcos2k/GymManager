USE [master]
GO
/****** Object:  Database [Gimnasio]    Script Date: 29/11/2014 22:19:25 ******/
CREATE DATABASE [Gimnasio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gimnasio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Gimnasio.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Gimnasio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Gimnasio_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Gimnasio] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gimnasio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gimnasio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gimnasio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gimnasio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gimnasio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gimnasio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gimnasio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gimnasio] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Gimnasio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gimnasio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gimnasio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gimnasio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gimnasio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gimnasio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gimnasio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gimnasio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gimnasio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gimnasio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gimnasio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gimnasio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gimnasio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gimnasio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gimnasio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gimnasio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gimnasio] SET RECOVERY FULL 
GO
ALTER DATABASE [Gimnasio] SET  MULTI_USER 
GO
ALTER DATABASE [Gimnasio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gimnasio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gimnasio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gimnasio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Gimnasio', N'ON'
GO
USE [Gimnasio]
GO
/****** Object:  StoredProcedure [dbo].[AgregarUsuario]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[AgregarUsuario]
@Usuario varchar(20),
@Contraseña varchar(16),
@Acceso int
As
INSERT INTO Usuarios(Usuario,Contraseña,Acceso) values(@Usuario,@Contraseña,@Acceso)

GO
/****** Object:  StoredProcedure [dbo].[BuscarIdUsuario]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarIdUsuario]
@Usuario varchar(20),
@Contraseña varchar(16)
as
Select ID_Usuario from Usuarios Where Usuario=@Usuario And Contraseña=@Contraseña

GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuario]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarUsuario]
@Nombre varchar(20)
as
Select Usuario from Usuarios Where Usuario=@Nombre

GO
/****** Object:  StoredProcedure [dbo].[ComprobarClave]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ComprobarClave]
@Contraseña varchar(20)
as
Select Contraseña from Usuarios Where Usuario=@Contraseña

GO
/****** Object:  StoredProcedure [dbo].[GenerarComprobante]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GenerarComprobante]
@ID_Pago int
AS
SELECT        dbo.Pagos.ID_Pago,dbo.Socios.Nombre, dbo.Socios.Apellido, dbo.Pagos.Fecha, dbo.Pagos.Monto, dbo.Detalle_Pago.Concepto
FROM            dbo.Detalle_Pago INNER JOIN
                         dbo.Pagos ON dbo.Detalle_Pago.ID_Pago = dbo.Pagos.ID_Pago INNER JOIN
                         dbo.Socios ON dbo.Pagos.ID_Socio = dbo.Socios.ID 
						 WHERE dbo.Pagos.ID_Pago = @ID_Pago

GO
/****** Object:  StoredProcedure [dbo].[GuardarDetalle]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GuardarDetalle]
@ID_Pago int,
@Concepto varchar(255)
as
INSERT INTO Detalle_Pago(ID_Pago,Concepto) VALUES(@ID_Pago,@Concepto)

GO
/****** Object:  StoredProcedure [dbo].[InsertarCategoria]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarCategoria]
@Categoria varchar(15)
as
Insert into Categoria(Categoria) values(@Categoria)

GO
/****** Object:  StoredProcedure [dbo].[ModificarSocio]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarSocio]
@ID int,
@Nombre varchar(20),
@Apellido varchar(15),
@Direccion varchar(100),
@Dni varchar(12),
@Edad int,
@Telefono varchar(12),
@Observaciones varchar(255),
@Categoria int,
@Estado int
as
Update Socios set Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion,Dni=@Dni,Edad=@Edad,
Telefono=@Telefono,Observaciones=@Observaciones,Categoria=@Categoria,Estado=@Estado 
Where ID=@ID

GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuarios]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarUsuarios]
@Contraseña varchar(16),
@Acceso int,
@ID int
As
Update Usuarios set Contraseña=@Contraseña, Acceso=@Acceso Where ID_Usuario=@ID

GO
/****** Object:  StoredProcedure [dbo].[MostrarCategorias]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[MostrarCategorias]
as
Select Categoria From Categoria

GO
/****** Object:  StoredProcedure [dbo].[MostrarPagoPorFechas]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarPagoPorFechas]
@Desde date,
@Hasta date
as
SELECT        dbo.Pagos.ID_Pago,dbo.Socios.Nombre, dbo.Socios.Apellido, dbo.Pagos.Fecha, dbo.Pagos.Monto, dbo.Detalle_Pago.Concepto
FROM            dbo.Detalle_Pago INNER JOIN
                         dbo.Pagos ON dbo.Detalle_Pago.ID_Pago = dbo.Pagos.ID_Pago INNER JOIN
                         dbo.Socios ON dbo.Pagos.ID_Socio = dbo.Socios.ID
						 WHERE Pagos.Fecha BETWEEN @Desde And @Hasta

GO
/****** Object:  StoredProcedure [dbo].[MostrarPagos]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarPagos]
As
SELECT        dbo.Pagos.ID_Pago,dbo.Socios.Nombre, dbo.Socios.Apellido, dbo.Pagos.Fecha, dbo.Pagos.Monto, dbo.Detalle_Pago.Concepto
FROM            dbo.Detalle_Pago INNER JOIN
                         dbo.Pagos ON dbo.Detalle_Pago.ID_Pago = dbo.Pagos.ID_Pago INNER JOIN
                         dbo.Socios ON dbo.Pagos.ID_Socio = dbo.Socios.ID
						 order by ID_Pago desc

GO
/****** Object:  StoredProcedure [dbo].[MostrarSocios]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarSocios]
as
SELECT        dbo.Socios.ID, dbo.Socios.Nombre, dbo.Socios.Apellido, dbo.Socios.Direccion, dbo.Socios.Dni, dbo.Socios.Edad, dbo.Socios.Telefono, dbo.Socios.Observaciones, 
                         dbo.Categoria.Categoria, dbo.Estado.Estado
FROM            dbo.Categoria INNER JOIN
                         dbo.Socios ON dbo.Categoria.ID_Categoria = dbo.Socios.Categoria INNER JOIN
                         dbo.Estado ON dbo.Socios.Estado = dbo.Estado.ID_Estado

GO
/****** Object:  StoredProcedure [dbo].[ObtenerCategorias]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ObtenerCategorias]
as
Select *from Categoria

GO
/****** Object:  StoredProcedure [dbo].[ObtenerEstados]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ObtenerEstados]
as
Select *from Estado

GO
/****** Object:  StoredProcedure [dbo].[ObtenerPagoPorSocio]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ObtenerPagoPorSocio]
@ID_Socio int
as
SELECT        dbo.Socios.ID As Socio,dbo.Pagos.ID_Pago,dbo.Socios.Nombre, dbo.Socios.Apellido, dbo.Pagos.Fecha, dbo.Pagos.Monto, dbo.Detalle_Pago.Concepto
FROM            dbo.Detalle_Pago INNER JOIN
                         dbo.Pagos ON dbo.Detalle_Pago.ID_Pago = dbo.Pagos.ID_Pago INNER JOIN
                         dbo.Socios ON dbo.Pagos.ID_Socio = dbo.Socios.ID 
						 Where dbo.Socios.ID = @ID_Socio
						 order by ID_Pago desc

GO
/****** Object:  StoredProcedure [dbo].[ObtenerUltimoPago]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ObtenerUltimoPago]
as
Select *from Pagos order by ID_Pago desc

GO
/****** Object:  StoredProcedure [dbo].[RegistrarPago]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[RegistrarPago]
@ID_Socio int,
@Fecha date,
@Monto decimal(7,2)
As 
INSERT INTO Pagos(ID_Socio,Fecha,Monto) VALUES(@ID_Socio,@Fecha,@Monto)

GO
/****** Object:  StoredProcedure [dbo].[RegistrarSocio]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RegistrarSocio]
@Nombre varchar(20),
@Apellido varchar(15),
@Direccion varchar(100),
@Dni varchar(12),
@Edad int,
@Telefono varchar(12),
@Observaciones varchar(255),
@Categoria int,
@Estado int
As
Insert into Socios(Nombre,Apellido,Direccion,Dni,Edad,Telefono,Observaciones,Categoria,Estado)
Values(@Nombre,@Apellido,@Direccion,@Dni,@Edad,@Telefono,@Observaciones,@Categoria,@Estado)

GO
/****** Object:  StoredProcedure [dbo].[Validar_usuarios]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Validar_usuarios]
@Usuario varchar(50),
@Contraseña varchar(50),
@Acceso varchar(2)
as
Select *from Usuarios
Where Usuario = @Usuario and Contraseña = @Contraseña and Acceso=@Acceso

GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_Pago]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle_Pago](
	[ID_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[ID_Pago] [int] NOT NULL,
	[Concepto] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Detalle_Pago] PRIMARY KEY CLUSTERED 
(
	[ID_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estado](
	[ID_Estado] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[ID_Estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[ID_Pago] [int] IDENTITY(1,1) NOT NULL,
	[ID_Socio] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Monto] [decimal](7, 2) NOT NULL,
 CONSTRAINT [PK_Pagos] PRIMARY KEY CLUSTERED 
(
	[ID_Pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Socios]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Socios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](15) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Dni] [varchar](12) NOT NULL,
	[Edad] [int] NOT NULL,
	[Telefono] [varchar](16) NOT NULL,
	[Observaciones] [varchar](255) NOT NULL,
	[Categoria] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Socios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 29/11/2014 22:19:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](20) NOT NULL,
	[Contraseña] [varchar](16) NOT NULL,
	[Acceso] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Detalle_Pago]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Pago_Pagos] FOREIGN KEY([ID_Pago])
REFERENCES [dbo].[Pagos] ([ID_Pago])
GO
ALTER TABLE [dbo].[Detalle_Pago] CHECK CONSTRAINT [FK_Detalle_Pago_Pagos]
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_Socios] FOREIGN KEY([ID_Socio])
REFERENCES [dbo].[Socios] ([ID])
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_Socios]
GO
ALTER TABLE [dbo].[Socios]  WITH CHECK ADD  CONSTRAINT [FK_Socios_Categoria] FOREIGN KEY([Categoria])
REFERENCES [dbo].[Categoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Socios] CHECK CONSTRAINT [FK_Socios_Categoria]
GO
ALTER TABLE [dbo].[Socios]  WITH CHECK ADD  CONSTRAINT [FK_Socios_Estado] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([ID_Estado])
GO
ALTER TABLE [dbo].[Socios] CHECK CONSTRAINT [FK_Socios_Estado]
GO
USE [master]
GO
ALTER DATABASE [Gimnasio] SET  READ_WRITE 
GO
