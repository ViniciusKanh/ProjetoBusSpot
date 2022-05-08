use BusSpot
go
Create Procedure Proc_Mostrar_Ponto 
as
select* from Ponto order by Tipo
go

use BusSpot
go
Create Procedure Proc_Inserir_Ponto 
@Tipo varchar(50),
@ID_PARADA int
as
insert Ponto(Tipo,ID_PARADA) values (@Tipo,@ID_PARADA)
go

use BusSpot
go
Create Procedure Proc_Alterar_Ponto 
@ID int,
@Tipo varchar(50),
@ID_PARADA int
as
Update Ponto set Tipo = @Tipo, ID_PARADA = @ID_PARADA where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_Ponto
@textobuscar  varchar(2)
as
select * from Ponto where Tipo like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_Ponto
@ID int
as
Delete from Ponto where ID = @ID
go

