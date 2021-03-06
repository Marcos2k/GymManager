USE [Gimnasio]
GO
/****** Object:  StoredProcedure [dbo].[MostrarSocios]    Script Date: 02/02/2015 13:28:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[MostrarSocios]
as
SELECT        dbo.Socios.ID, dbo.Socios.Nombre, dbo.Socios.Apellido, dbo.Socios.Direccion, dbo.Socios.Dni, dbo.Socios.Edad, dbo.Socios.Telefono, dbo.Socios.Observaciones, 
                         dbo.Categoria.Categoria, dbo.Estado.Estado, dbo.Socios.Vencimiento
FROM            dbo.Categoria INNER JOIN
                         dbo.Socios ON dbo.Categoria.ID_Categoria = dbo.Socios.Categoria INNER JOIN
                         dbo.Estado ON dbo.Socios.Estado = dbo.Estado.ID_Estado
						 order by ID desc
						 go
