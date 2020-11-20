CREATE DATABASE BDNomina

USE BDNomina

IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Empleado' AND type ='U')
BEGIN 
	ALTER TABLE Empleado DROP CONSTRAINT FK_Empleado_Puesto 
	ALTER TABLE Empleado DROP CONSTRAINT FK_Empleado_Empresa
END	
--Empresa_Puesto--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'EmprPue' AND type ='U')
BEGIN 
	DROP TABLE EmprPue
END
--Empresa_Departamento--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'EmprDep' AND type ='U')
BEGIN 
	DROP TABLE EmprDep
END
--Puesto--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Puesto' AND type ='U')
BEGIN 
	DROP TABLE Puesto
END
--Departamento--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Departamento' AND type ='U')
BEGIN 
	DROP TABLE Departamento
END
--Empresa--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Empresa' AND type ='U')
BEGIN 
	DROP TABLE Empresa
END
--Empleado--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Empleado' AND type ='U')
BEGIN 
	DROP TABLE Empleado
END										 
--Nomina--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Nomina' AND type ='U')
BEGIN 
	DROP TABLE Nomina
END
--Domicilio--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Domicilio' AND type ='U')
BEGIN 
	DROP TABLE Domicilio
END
--Deducciones--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Deducciones' AND type ='U')
BEGIN 
	DROP TABLE Deducciones
END
--Incidencias--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Incidencias' AND type ='U')
BEGIN 
	DROP TABLE Incidencias
END
--Percepciones--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Percepciones' AND type ='U')
BEGIN 
	DROP TABLE Percepciones
END
--Frecuencia de pago--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'Frecuencia' AND type ='U')
BEGIN 
	DROP TABLE Frecuencia
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

--Domicilio--
CREATE TABLE Domicilio (
	IdDomicilio		int,
	Calle			varchar(20),
	Numero			int,
	Colonia			varchar(20),
	Municipio		varchar(20),
	Estado			varchar(20),
	CP				char(5),
	CONSTRAINT PK_Domicilio PRIMARY KEY(IdDomicilio)
)

--Nomina--
CREATE TABLE Nomina (
	IdNomina		int,
	SueldoBruto		decimal(11,2),
	SueldoNeto		decimal(11,2),
	UltimaFecha		date,
	IdPercepcion	int,
	IdIncidencias 	int,
	IdDeducciones 	int
	CONSTRAINT PK_Nomina PRIMARY KEY(IdNomina),
	CONSTRAINT FK_Nomina_Percepciones FOREIGN KEY (IdPercepcion) REFERENCES Percepciones(IdPercepcion),
	CONSTRAINT FK_Nomina_Incidencias FOREIGN KEY (IdIncidencias) REFERENCES Incidencias(IdIncidencias),
	CONSTRAINT FK_Nomina_Deducciones FOREIGN KEY (IdDeducciones) REFERENCES Deducciones(IdDeduccion)
)

--Empleado--
CREATE TABLE Empleado (
	NoEmpleado		int,
	Nombres			varchar(30),
	Contraseña		varchar(10),
	NSS				char(11),
	RFC				char(13),
	Banco			varchar(20),
	NoCuenta		char(24),
	Email			varchar(30),
	Telefonos		varchar(20),
	ApellidoM		varchar(20),
	ApellidoP		varchar(20),
	CURP			char(18),
	IdEmpresa		int,
	IdDomicilio		int,
	IdPuesto		int,
	IdNomina		int,
	CONSTRAINT PK_Empleado PRIMARY KEY(NoEmpleado),
	CONSTRAINT FK_Empleado_Domicilio FOREIGN KEY (IdDomicilio) REFERENCES Domicilio(IdDomicilio),
	CONSTRAINT FK_Empleado_Nomina FOREIGN KEY (IdNomina) REFERENCES Nomina(IdNomina)
)

--Empresa--
CREATE TABLE Empresa (
	IdEmpresa		int,
	Nombre			varchar(30),
	RSocial			varchar(30),
	DomFiscal		varchar(30),
	RegPatronal		varchar(20),
	RFC				char(13),
	FechaIniOp		date,
	Email			varchar(30),
	Telefono		varchar(20),
	IdGerente		int,
	IdFrecuencia	int,
	CONSTRAINT PK_Empresa PRIMARY KEY(IdEmpresa),
	CONSTRAINT FK_Empresa_Gerente FOREIGN KEY (IdGerente) REFERENCES Empleado(NoEmpleado),
	CONSTRAINT FK_Empresa_Frecuencia FOREIGN KEY (IdFrecuencia) REFERENCES Frecuencia(IdFrecuencia)
)

--Departamento--
CREATE TABLE Departamento (
	IdDepartamento		int,
	Nombre				varchar(30),
	SueldoBase			decimal(11,2),
	IdGerente			int,
	CONSTRAINT PK_Departamento PRIMARY KEY(IdDepartamento),
	CONSTRAINT FK_Departamento_Gerente FOREIGN KEY (IdGerente) REFERENCES Empleado(NoEmpleado)
)

--Puesto--
CREATE TABLE Puesto (
	IdPuesto		int,
	Nombre			varchar(30),
	NivSalarial		tinyint,
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

ALTER TABLE Empleado ADD CONSTRAINT FK_Empleado_Puesto FOREIGN KEY (IdPuesto) REFERENCES Puesto(IdPuesto)
ALTER TABLE Empleado ADD CONSTRAINT FK_Empleado_Empresa FOREIGN KEY (IdEmpresa) REFERENCES Empresa(IdEmpresa)
