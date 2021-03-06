USE [Gimnasio]
GO
/****** Object:  StoredProcedure [dbo].[ModificarSocio]    Script Date: 02/02/2015 13:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ModificarSocio]
@ID int,
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
as
Update Socios set Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion,Dni=@Dni,Edad=@Edad,
Telefono=@Telefono,Observaciones=@Observaciones,Categoria=@Categoria,Estado=@Estado,Vencimiento=@Vencimiento
Where ID=@ID
