USE [Gimnasio]
GO
/****** Object:  StoredProcedure [dbo].[IncrementarCantidadCuota]    Script Date: 26/03/2015 22:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[IncrementarCantidadCuota]
As
IF Exists(Select MesProximo from Socios WHERE MesProximo = DATEPART(MM,GETDATE()))
Update Socios set Cuotas = Cuotas +1 Where Vencimiento <= DATEPART(DD,GETDATE()) and MesProximo = DATEPART(MM,GETDATE());
Update Socios set MesProximo = MesProximo + 1 Where MesProximo = DATEPART(MM,GETDATE()) And Vencimiento <= DATEPART(DD,GETDATE())
Update Socios set MesProximo = 1 Where MesProximo = 13 /*Cuando se pase de Diciembre a Enero vuelve a colocar el numero 1*/
go