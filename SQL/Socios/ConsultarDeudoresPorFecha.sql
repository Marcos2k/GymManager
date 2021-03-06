USE [Gimnasio]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarDeudoresPorFecha]    Script Date: 17/02/2015 14:56:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ConsultarDeudoresPorFecha]
@Vencimiento int
as
SELECT  S.ID,Nombre,S.Apellido,S.Direccion,S.Dni,S.Edad,S.Telefono,S.Observaciones,C.Categoria,E.Estado,S.Vencimiento, S.Cuotas as [Cuotas a pagar] FROM Socios S INNER JOIN Categoria C on S.Categoria=C.ID_Categoria
INNER JOIN Estado E on S.Estado=E.ID_Estado WHERE S.Vencimiento = @Vencimiento
go
