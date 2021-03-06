USE [Gimnasio]
GO
/****** Object:  StoredProcedure [dbo].[RegistrarSocio]    Script Date: 02/02/2015 13:40:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[RegistrarSocio]
@Nombre varchar(20),
@Apellido varchar(15),
@Direccion varchar(100),
@Dni varchar(12),
@Edad int,
@Telefono varchar(12),
@Observaciones varchar(255),
@Categoria int,
@Estado int,
@Vencimiento int
As
Insert into Socios(Nombre,Apellido,Direccion,Dni,Edad,Telefono,Observaciones,Categoria,Estado,Vencimiento)
Values(@Nombre,@Apellido,@Direccion,@Dni,@Edad,@Telefono,@Observaciones,@Categoria,@Estado,@Vencimiento)