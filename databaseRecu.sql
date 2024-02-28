create database examenRecu
use examenRecu

create table cliente(
codCli int identity(1,1) not null primary key,
nombre varchar(25) not null,
genero char(1) not null
);

create table libros(
idLib int identity(1,1) not null primary key,
Titulo varchar(25) not null,
tipo char(1) not null,
codCli int,
foreign key (codCli) references cliente(codCli)
);