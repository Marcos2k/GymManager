Create Proc RegistrarAsistencias
@ID_Socio int,
@Fecha date,
@Hora time
as
Insert into Asistencias(ID_Socio,Fecha,Hora) values(@ID_Socio,@Fecha,@Hora)
go