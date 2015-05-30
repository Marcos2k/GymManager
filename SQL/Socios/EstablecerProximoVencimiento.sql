/*Script realizado por Marcos Gonzalez 17/02/2015*/
Alter table Socios
Add constraint EstablecerProximoVencimiento
/*Establece el proximo vencimiento por Default*/
Default Datepart(MM,GETDATE()) + 1 FOR MesProximo
go