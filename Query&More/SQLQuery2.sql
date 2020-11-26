--PROCEDURE EMPLEADO--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Empleado' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_Empleado;
go

CREATE PROCEDURE sp_Empleado
(
@Opc				CHAR(1),
@Id				INT = null,
@User			VARCHAR(20) = null,
@Nombre			VARCHAR(20) = null,
@Contraseña		VARCHAR(10),
@NSS				CHAR(11),
@RFC				CHAR(13),
@Banco			VARCHAR(20),
@NoCuenta		CHAR(24),
@Email			VARCHAR(20),
@Telefonos		VARCHAR(20),
@ApM				VARCHAR(20),
@ApP				VARCHAR(20),
@CURP			CHAR(20),
@IdEmpresa		INT,	
@IdPuesto		INT,	
@IdNomina		INT,
@IdDepto			INT,

@Calle			VARCHAR(20),
@Numero			INT,
@Colonia			VARCHAR(20),
@Municipio		VARCHAR(20),
@Estado			VARCHAR(20),
@CP				CHAR(5),
@Gerente			Bit		
)
AS
BEGIN 
if @Opc = 'I'
BEGIN
INSERT INTO Empleado(Username,Nombres ,Contraseña, NSS, RFC, Banco, NoCuenta, Email, Telefonos, ApellidoM, ApellidoP, CURP, IdEmpresa, IdPuesto, IdNomina, IdDepto, Calle, Numero, Colonia, Municipio, Estado, CP, Gerente)
VALUES (@User,@Nombre, @Contraseña, @NSS, @RFC, @Banco, @NoCuenta, @Email, @Telefonos, @ApM, @ApP, @CURP, @IdEmpresa, @IdPuesto, @IdNomina, @IdDepto, @Calle, @Numero, @Colonia, @Municipio, @Estado, @CP, @Gerente)
END

IF @Opc = 'D'
BEGIN
DELETE 
FROM Empleado
WHERE NoEmpleado = @Id
END

END

--Empresa--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Empresa' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_Empresa;
go

CREATE PROCEDURE sp_Empresa
(
@Opc				CHAR(1),
@Id				INT = null,
@Nombre			VARCHAR(20) = null,
@RSocial			VARCHAR(30),
@DFiscal			VARCHAR(30),
@RPatronal		VARCHAR(20),
@RFC				CHAR(13),
@FecIniOp		date,
@Email			VARCHAR(20),
@Telefono		VARCHAR(20),
@IdGerente		BIGINT,	
@IdFrecuencia	INT
)
AS
BEGIN 
if @Opc = 'I'
BEGIN
INSERT INTO Empresa(Nombre,RSocial ,DomFiscal, RegPatronal, RFC, FechaIniOp, Email, Telefono, IdGerente, IdFrecuencia)
VALUES (@Nombre,@RSocial, @DFiscal, @RPatronal, @RFC, @FecIniOp, @Email, @Telefono, @IdGerente, @IdFrecuencia)
END

IF @Opc = 'D'
BEGIN
DELETE 
FROM Empresa
WHERE IdEmpresa = @Id
END

END

--Departamento--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Departamento' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_Departamento;
go

CREATE PROCEDURE sp_Departamento
(
@Opc				CHAR(1),
@Id				INT = null,
@Nombre			VARCHAR(20) = null,
@SueldoBase		DECIMAL(11, 2),
@IdGerente		BIGINT
)
AS
BEGIN 
if @Opc = 'I'
BEGIN
INSERT INTO Departamento(Nombre,SueldoBase ,IdGerente)
VALUES (@Nombre,@SueldoBase, @IdGerente)
END

IF @Opc = 'D'
BEGIN
DELETE 
FROM Departamento
WHERE IdDepartamento = @Id
END

END

--Nomina--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Nomina' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_Nomina;
go

CREATE PROCEDURE sp_Nomina
(
@Opc				CHAR(1),
@Id				INT = null,
@SueldoB			DECIMAL(5, 2),
@SueldoN			DECIMAL(5,2),
@UltimaFec		DATE,
@IdPercepcion	INT,
@IdIncidencias	INT,
@IdDeducciones	INT
)
AS
BEGIN 
if @Opc = 'I'
BEGIN
INSERT INTO Nomina(SueldoBruto,SueldoNeto,UltimaFecha,IdPercepcion, IdIncidencias, IdDeducciones)
VALUES (@SueldoB,@SueldoN, @UltimaFec,@IdPercepcion, @IdIncidencias, @IdDeducciones)
END

IF @Opc = 'D'
BEGIN
DELETE 
FROM Nomina
WHERE IdNomina = @Id
END

END

--Puesto--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Puesto' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_Puesto;
go

CREATE PROCEDURE sp_Puesto
(
@Opc				CHAR(1),
@Id				INT = null,
@Nombre			VARCHAR(20) = null,
@NivSalarial		DECIMAL(5,2),
@NoEmpleados		INT,
@IdDepartamento	INT
)
AS
BEGIN 
if @Opc = 'I'
BEGIN
INSERT INTO Puesto(Nombre,NivSalarial ,NoEmpleados, IdDepartamento)
VALUES (@Nombre,@NivSalarial, @NoEmpleados, @IdDepartamento)
END

IF @Opc = 'D'
BEGIN
DELETE 
FROM Puesto
WHERE IdPuesto = @Id
END

END

