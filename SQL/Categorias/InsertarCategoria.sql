create proc InsertarCategoria
@Categoria varchar(15)
as
Insert into Categoria(Categoria) values(@Categoria)
go
