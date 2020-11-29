DROP DATABASE BDNomina;
CREATE DATABASE BDNomina

USE BDNomina
go

IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Empleado' AND type ='U')
BEGIN 
	DROP TABLE Empleado;
END	
--Empresa_Puesto--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'EmprPue' AND type ='U')
BEGIN 
	DROP TABLE EmprPue;
END
--Empresa_Departamento--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'EmprDep' AND type ='U')
BEGIN 
	DROP TABLE EmprDep;
END
--Puesto--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Puesto' AND type ='U')
BEGIN 
	DROP TABLE Puesto;
END
--Departamento--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Departamento' AND type ='U')
BEGIN 
	DROP TABLE Departamento;
END
--Empresa--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Empresa' AND type ='U')
BEGIN 
	DROP TABLE Empresa;
END
--Empleado--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Empleado' AND type ='U')
BEGIN 
	DROP TABLE Empleado;
END										 
--Nomina--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Nomina' AND type ='U')
BEGIN 
	DROP TABLE Nomina;
END
--Deducciones--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Deducciones' AND type ='U')
BEGIN 
	DROP TABLE Deducciones;
END
--Incidencias--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Incidencias' AND type ='U')
BEGIN 
	DROP TABLE Incidencias;
END
--Percepciones--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Percepciones' AND type ='U')
BEGIN 
	DROP TABLE Percepciones;
END
--Frecuencia de pago--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Frecuencia' AND type ='U')
BEGIN 
	DROP TABLE Frecuencia;
END

--CREACION DE TABLAS-----------------------------------------------------

--Frecuencia de pago--
CREATE TABLE Frecuencia (
	IdFrecuencia		int,
	Nombre				varchar(30),
	CONSTRAINT PK_Frecuencia PRIMARY KEY(IdFrecuencia),
)

--Percepciones--
CREATE TABLE Percepciones (
	IdPercepcion		int,
	Nombre				varchar(30),
	Valor				decimal(11,2), 
	Porcentaje			tinyint,
	CONSTRAINT PK_Percepciones PRIMARY KEY(IdPercepcion)
)

--Incidencias--
CREATE TABLE Incidencias (
	IdIncidencias		int,
	Nombre				varchar(30),
	Valor				decimal(11,2), 
	Porcentaje			tinyint,
	CONSTRAINT PK_Incidencias PRIMARY KEY(IdIncidencias)
)

--Deducciones--
CREATE TABLE Deducciones (
	IdDeduccion			int,
	Nombre				varchar(30),
	Valor				decimal(11,2), 
	Porcentaje			tinyint,
	CONSTRAINT PK_Deduccion PRIMARY KEY(IdDeduccion)
)

--Nomina--
CREATE TABLE Nomina (
	IdNomina			bigint not null identity (1500, 1),
	SueldoBruto		decimal(11,2),
	SueldoNeto		decimal(11,2),
	UltimaFecha		date,
	IdPercepcion		int,
	IdIncidencias 	int,
	IdDeducciones 	int

	CONSTRAINT PK_Nomina PRIMARY KEY(IdNomina),
	CONSTRAINT FK_Nomina_Percepciones FOREIGN KEY (IdPercepcion) REFERENCES Percepciones(IdPercepcion),
	CONSTRAINT FK_Nomina_Incidencias FOREIGN KEY (IdIncidencias) REFERENCES Incidencias(IdIncidencias),
	CONSTRAINT FK_Nomina_Deducciones FOREIGN KEY (IdDeducciones) REFERENCES Deducciones(IdDeduccion)
)

--Empleado--
CREATE TABLE Empleado (
	NoEmpleado		bigint not null identity(1000, 10),
	Username			varchar(25) not null,
	Nombres			varchar(30) not null,
	Contraseña		varchar(10) not null,
	NSS				char(11) not null,
	RFC				char(13) not null,
	Banco			varchar(20) not null,
	NoCuenta			char(24) not null,
	Email			varchar(30) not null,
	Telefonos		varchar(20) not null,
	ApellidoM		varchar(20) not null,
	ApellidoP		varchar(20) not null,
	CURP				char(18) not null,
	IdEmpresa		int null,
	IdDepto			int null,
	IdPuesto			int null,
	IdNomina			bigint null,

	Gerente			bit,
	Calle			varchar(20),
	Numero			int,
	Colonia			varchar(20),
	Municipio		varchar(20),
	Estado			varchar(20),
	CP				char(5),
	CONSTRAINT PK_Empleado PRIMARY KEY(NoEmpleado)
)

--Empresa--
CREATE TABLE Empresa (
	IdEmpresa		int not null identity (1, 1),
	Nombre			varchar(30) not null,
	RSocial			varchar(30) not null,
	DomFiscal		varchar(30) not null,
	RegPatronal		varchar(20) not null,
	RFC				char(13) not null,
	FechaIniOp		date,
	Email			varchar(30) not null,
	Telefono			varchar(20) not null,
	IdGerente		bigint null,
	IdFrecuencia		int null,
	CONSTRAINT PK_Empresa PRIMARY KEY(IdEmpresa),
)

--Departamento--
CREATE TABLE Departamento (
	IdDepartamento		int not null identity(100, 1),
	Nombre				varchar(30),
	SueldoBase			decimal(11,2),
	IdGerente			bigint,
	CONSTRAINT PK_Departamento PRIMARY KEY(IdDepartamento),
	CONSTRAINT FK_Departamento_Gerente FOREIGN KEY (IdGerente) REFERENCES Empleado(NoEmpleado)
)

--Puesto--
CREATE TABLE Puesto (
	IdPuesto			int not null	 identity(500, 1),
	Nombre			varchar(30),
	NivSalarial		decimal(5,2),
	NoEmpleados		int,
	IdDepartamento	int,
	CONSTRAINT PK_Puesto PRIMARY KEY(IdPuesto),
	CONSTRAINT FK_Puesto_Departamento FOREIGN KEY (IdDepartamento) REFERENCES Departamento(IdDepartamento)
)

--Empresa_Departamento--
CREATE TABLE EmprDep (
	IdEmprDep		int,
	IdEmpresa		int,
	IdDepartamento	int,
	CONSTRAINT PK_EmprDep PRIMARY KEY(IdEmprDep),
	CONSTRAINT FK_EmprDep_Empresa FOREIGN KEY (IdEmpresa) REFERENCES Empresa(IdEmpresa),
	CONSTRAINT FK_EmprDep_Departamento FOREIGN KEY (IdDepartamento) REFERENCES Departamento(IdDepartamento)
)

--Empresa_Puesto--
CREATE TABLE EmprPue (
	IdEmprPue		int,
	IdEmpresa		int,
	IdDepartamento	int,
	CONSTRAINT PK_EmprPue PRIMARY KEY(IdEmprPue),
	CONSTRAINT FK_EmprPue_Empresa FOREIGN KEY (IdEmpresa) REFERENCES Empresa(IdEmpresa),
	CONSTRAINT FK_EmprPue_Departamento FOREIGN KEY (IdDepartamento) REFERENCES Departamento(IdDepartamento)
)

--ALTERS----------------------------------------------

ALTER TABLE Empleado ADD CONSTRAINT FK_Empleado_Empresa FOREIGN KEY (IdEmpresa) REFERENCES Empresa(IdEmpresa)
ALTER TABLE Empleado ADD CONSTRAINT FK_Empleado_Departamento FOREIGN KEY (IdDepto) REFERENCES Departamento(IdDepartamento)
ALTER TABLE Empleado ADD CONSTRAINT FK_Empleado_Puesto FOREIGN KEY (IdPuesto) REFERENCES Puesto(IdPuesto)
ALTER TABLE Empleado ADD CONSTRAINT FK_Empleado_Nomina FOREIGN KEY (IdNomina) REFERENCES Nomina(IdNomina)	

ALTER TABLE Empleado DROP CONSTRAINT FK_Empleado_Empresa;
ALTER TABLE Empleado DROP CONSTRAINT FK_Empleado_Departamento;
ALTER TABLE Empleado DROP CONSTRAINT FK_Empleado_Puesto;
ALTER TABLE Empleado DROP CONSTRAINT FK_Empleado_Nomina;


ALTER TABLE Empresa ADD CONSTRAINT FK_Empresa_Gerente FOREIGN KEY (IdGerente) REFERENCES Empleado(NoEmpleado)
ALTER TABLE Empresa ADD CONSTRAINT FK_Empresa_Frecuencia FOREIGN KEY (IdFrecuencia) REFERENCES Frecuencia(IdFrecuencia)

ALTER TABLE Empresa DROP CONSTRAINT FK_Empresa_Gerente;
ALTER TABLE Empresa DROP CONSTRAINT FK_Empresa_Frecuencia;

ALTER TABLE EmprDep DROP CONSTRAINT FK_EmprDep_Empresa;
ALTER TABLE EmprPue DROP CONSTRAINT FK_EmprPue_Empresa;

ALTER TABLE Departamento DROP CONSTRAINT FK_Departamento_Gerente;

ALTER TABLE Puesto DROP CONSTRAINT FK_Puesto_Departamento;
ALTER TABLE Puesto ADD CONSTRAINT FK_Puesto_Departamento FOREIGN KEY (IdDepartamento) REFERENCES Departamento(IdDepartamento);
 
ALTER TABLE EmprDep DROP CONSTRAINT FK_EmprDep_Departamento;
ALTER TABLE EmprPue DROP CONSTRAINT FK_EmprPue_Departamento;


--SU--
exec sp_Empleado 'I'	, null, 'SU', 'Admin', 'contra123', '00000000000', '0000000000000', 'Banco', '123456789', 'admin@gmail.com', '8181818181', 'Super', 'Usuario' , '00000000000000000', null, null, null, null, ' - ', 0, ' - ',' - ',' - ', ' - ', 1

exec sp_Empleado 'I'	, null, 'pingu', 'emiliano', 'contra123', '727956089', '72795608040', 'Banorte', '123456789', 'smt@gmail.com', '8111198227', 'Leal', 'Dmz' , 'LEDE980118HNLLMM01', null, null, null, null, 'Parras', 231, 'Mitras','Mty','Nuevo Leon', '64460', 1
exec sp_Empleado 'I'	, null, 'cecy', 'cecy', 'contra123', '727956089', '72795608040', 'Banorte', '123456789', 'smt@gmail.com', '8111198227', 'villareal', 'Franco' , 'CECY980118HNLLMM01', null, null, null, null, 'smt', 231, 'Vista hermosa','Mty','Nuevo Leon', '64460', 0  
exec sp_Empleado 'D', 1010, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null 

exec sp_Empresa 'I', null, 'amazon', 'money', 'smwhere', 'smt', '72795608040', '20200118', 'amazon@gmail.com', '11111111111', null, null  
exec sp_Empresa 'D', 100, null, null, null, null, null, null, null, null, null, null

exec sp_Departamento 'I', null, 'Cocina', '1000.00', 1000
exec sp_Departamento 'D', 11, null, null, null

exec sp_Puesto 'I', null, 'Chef', 0.5, 1, 10
exec sp_Puesto 'D', 101, null, null, null, null 

exec sp_Nomina 'I', null, 100.00, 950.00, '20200519', 0, 0, 0
exec sp_Nomina 'D', 101, null, null, null, null


exec sp_CheckSuperUser 1000

exec sp_GetIdAny 'admin', 'contra123'

exec sp_GetGerenteInfo 1000

select * from Empleado
select * from Empresa 
select * from Departamento
select * from Puesto
select * from Nomina
 
																																	  	