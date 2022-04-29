insert into Bairro (nome) (select bairro from fnViaCep('05842070'))
insert into CIDADE(nome) (select localidade from fnViaCep('05842070'))
insert into Logradouro(nome) (select Logradouro from fnViaCep('05842070'))
insert into estado(nome) (select uf from fnViaCep('05842070'))




select * from fnViaCep('05842070')
select * from Bairro

delete bairro where ID = 1002
