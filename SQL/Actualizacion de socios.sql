--Actualizamos los registros de los dni que no comiencen con 2,3,4. Antes que nada verificamos los registros haciendo SELECT
Select  *from Socios where not left(Dni,1) = '3' and not left(Dni,1) = '2' and not  left(Dni,1) = '4'

Update socios set Dni='Sin dni' where not left(Dni,1) = '3' and not left(Dni,1) = '2' and not  left(Dni,1) = '4'

Update socios set Telefono = 'Sin telefono' --Modificamos todos los registros por eso no especifico WHERE

Update Socios set Direccion = 'Sin domicilio'

/**Realizado por Marcos 4/12/2014 , realicé backup por las dudas