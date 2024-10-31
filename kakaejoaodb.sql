drop database dbCrud;
create database dbCrud;
use dbCrud;

create table Professor(
	IdProfessor int primary key auto_increment,
    Nome varchar(200) not null,
    CPF int not null,
    RG int not null,
    Telefone bigint not null,
    Data_nasc date not null
);
create table Aluno(
	IdAluno int primary key auto_increment,
     Nome varchar(200) not null,
     Email varchar(150) not null,
     Telefone bigint not null,
     Serie varchar(20) not null,
     Turma varchar(20) not null,
     Data_nasc date not null
);


select * from Aluno;
select * from Professor;