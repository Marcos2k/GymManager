USE [Gimnasio]
GO
/****** Object:  StoredProcedure [dbo].[IncrementarCantidadCuota]    Script Date: 17/02/2015 1:05:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[IncrementarCantidadCuota]
as
IF Exists(Select MesProximo from Socios WHERE MesProximo = DATEPART(MM,GETDATE()))
Update Socios set Cuotas = Cuotas+1 Where Vencimiento = DATEPART(DD,GETDATE()) and MesProximo = DATEPART(MM,GETDATE());
Update Socios set MesProximo = MesProximo + 1 Where MesProximo = DATEPART(MM,GETDATE()) And Vencimiento = DATEPART(DD,GETDATE())
go