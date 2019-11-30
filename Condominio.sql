create database Condominio 
use Condominio

create table edificio(
	idEdificio int primary key identity ,
	nombreEdificio varchar(50) not null,
	descripcionEdificio varchar(300) null,

)

create table departamento(
	idDepartamento int primary key identity ,
	idEdificio int FOREIGN KEY REFERENCES edificio(idEdificio),
	numeroDepartamento int not null,
	descripcionEdificio varchar(300) null,
	numeroResidentes int not null

)


create table usuario(
	idUsuario int primary key identity ,
	nombreUsuario varchar(50) not null,
	apellidoUsuario varchar(50) not null,
	ciUsuario numeric(10,0) not null,
	mailUusuario varchar(50) not null,
	claveUsuario varchar(50)  null,
	tipoUsuario varchar (50) null
)

create table cuota(
	idCuota int primary key identity,
	idDepartamento int FOREIGN KEY REFERENCES departamento(idDepartamento),
	descripcionCuota varchar(150) not null,
	ValorCuota numeric(3,2) not null,
	fechaLimiteCuota date not null
)

create table pago(
	idPago int primary key identity,
	idEdificio int FOREIGN KEY REFERENCES edificio(idEdificio),
	valorPago numeric(3,2) not null
)


create table visita(
	idVisita int primary key identity ,
	idDepartamento int FOREIGN KEY REFERENCES departamento(idDepartamento),
	nombreVisita varchar(50) not null,
	apellidoVisita varchar(50) not null,
	ciVisita numeric(10,0) not null,
	fechaVisita datetime not null
)

create table queja(
	idQueja int primary key identity,
	idEdificio int FOREIGN KEY REFERENCES edificio(idEdificio),
	descripcionQueja varchar(300) not null,
	fechaQueja date not null
)