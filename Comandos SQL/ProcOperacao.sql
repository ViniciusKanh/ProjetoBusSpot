

use BusSpot
go
Create Procedure Proc_Mostrar_Operacao 
as
select* from Operacao order by Data_Operacao
go

use BusSpot
go
Create Procedure Proc_Inserir_Operacao 
@Data_OP Date,
@ID_ONIBUS int,
@ID_LINHA int

as
insert Operacao(Data_Operacao,ID_ONIBUS,ID_LINHA) values (@Data_OP,@ID_ONIBUS,@ID_LINHA)
go

use BusSpot
go
Create Procedure Proc_Alterar_Operacao 
@ID int,
@Data_OP Date,
@ID_ONIBUS int,
@ID_LINHA int
as
Update Operacao set Data_Operacao = @Data_OP, ID_ONIBUS = @ID_ONIBUS, ID_LINHA = @ID_LINHA where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_Operacao 
@textobuscar  varchar(2)
as
select * from Operacao where Data_Operacao like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_Operacao 
@ID int
as
Delete from Operacao where ID = @ID
go

