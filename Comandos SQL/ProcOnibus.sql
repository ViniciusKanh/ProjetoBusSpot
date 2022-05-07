

use BusSpot
go
Create Procedure Proc_Mostrar_Onibus 
as
select* from Onibus order by Numero_Onibus
go

use BusSpot
go
Create Procedure Proc_Inserir_Onibus 
@Numero_Onibus varchar(50),
@Placa varchar(50),
@ID_Comodidade int,
@ID_Pagamento int,
@ID_Acessibilidade int,
@ID_Embarque int,
@ID_Empresa int
as
insert Onibus(Numero_Onibus,Placa,ID_COMODIDADE,ID_PAGAMENTO,ID_ACESSIBILIDADE,ID_EMBARQUE,ID_EMPRESA) values (@Numero_Onibus,@Placa,@ID_Comodidade,@ID_Pagamento,@ID_Acessibilidade,@ID_Embarque,@ID_Empresa)
go

use BusSpot
go
Create Procedure Proc_Alterar_Onibus 
@ID int,
@Numero_Onibus varchar(50),
@Placa varchar(50),
@ID_Comodidade int,
@ID_Pagamento int,
@ID_Acessibilidade int,
@ID_Embarque int,
@ID_Empresa int
as
Update Onibus set Numero_Onibus = @Numero_Onibus, Placa = @Placa, ID_COMODIDADE = @ID_Comodidade, ID_PAGAMENTO = @ID_Pagamento,ID_ACESSIBILIDADE=@ID_Acessibilidade,@ID_Embarque=@ID_Embarque,ID_EMPRESA=@ID_Empresa where ID = @ID
go

use BusSpot
go
Create Procedure Proc_Buscar_Onibus 
@textobuscar  varchar(2)
as
select * from Onibus where Numero_Onibus like @textobuscar +'%'
go

use BusSpot
go
Create Procedure Proc_Remover_Onibus
@ID int
as
Delete from Onibus where ID = @ID
go

