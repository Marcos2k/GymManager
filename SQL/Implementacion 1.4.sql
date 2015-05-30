/*Script implementado por Marcos Gonzalez fecha 24/03/2015 */
USE Gimnasio
CREATE TABLE Asistencias(
ID_Asistencia int Identity (1,1) Primary Key,
ID_Socio int,
Fecha date,
Hora varchar(15)
)
go

/*Creamos relaciones entre Asistencias-Socios*/
ALTER TABLE Asistencias
ADD CONSTRAINT FK_Asistencias_Socios
Foreign Key(ID_Socio) References dbo.Socios(ID)
go

Create Proc RegistrarAsistencias
@ID_Socio int,
@Fecha date,
@Hora varchar(15)
as
Insert into Asistencias(ID_Socio,Fecha,Hora) values(@ID_Socio,@Fecha,@Hora)
go

Create proc VerAsistencias
as
Select S.Nombre, S.Apellido,A.Fecha,A.Hora from Socios S INNER JOIN
Asistencias A on S.ID=A.ID_Socio
go

Create proc VerAsistenciaPorSocio
@ID_Socio int
as
Select S.Nombre, S.Apellido,A.Fecha,A.Hora from Socios S INNER JOIN
Asistencias A on S.ID=A.ID_Socio Where A.ID_Socio = @ID_Socio
go

Create proc MostrarAsistenciasPorFecha
@Desde date,
@Hasta date
as
Select S.Nombre, S.Apellido,A.Fecha,A.Hora from Socios S INNER JOIN
Asistencias A on S.ID=A.ID_Socio Where A.Fecha Between @Desde and @Hasta
go