USE [Gimnasio]
GO
/****** Object:  StoredProcedure [dbo].[MostrarDeudoresAlDia]    Script Date: 03/02/2015 17:14:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[MostrarDeudoresAlDia]
as
SELECT S.ID,Nombre,S.Apellido,S.Direccion,S.Dni,S.Edad,S.Telefono,S.Observaciones,C.Categoria,E.Estado,S.Vencimiento FROM Socios S INNER JOIN Categoria C on S.Categoria=C.ID_Categoria
INNER JOIN Estado E on S.Estado=E.ID_Estado  WHERE S.Vencimiento = DATEPART(DD,GETDATE())
GO

