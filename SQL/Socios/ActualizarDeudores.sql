/*El Estado '2' representa "Debe"
ante cualquier duda, consultar la tabla Estado haciendo una consulta tipo Select
*/
Create proc ActualizarDeudores
as
Update Socios Set Estado=2 where Vencimiento = DATEPART(DD,GETDATE())
go
