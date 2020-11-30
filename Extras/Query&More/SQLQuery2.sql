--PROCEDURE EMPLEADO--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Empleado' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_Empleado;
go

USE BDNomina
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
@NivSalarial		DECIMAL(5,2)
)
AS
BEGIN 
	if @Opc = 'I'
		BEGIN
			INSERT INTO Puesto(Nombre,NivSalarial)
			VALUES (@Nombre,@NivSalarial)
		END

	IF @Opc = 'D'
		BEGIN
			DELETE 
			FROM Puesto
			WHERE IdPuesto = @Id
		END

END


IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_EscogerEmpresa' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_EscogerEmpresa;
go

CREATE PROCEDURE sp_EscogerEmpresa
(
   @Nom			VARCHAR(20)
)
AS
BEGIN
  select * from Empresa	where Nombre = @Nom

END

--Checar Password--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_CheckAdmin' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_CheckAdmin;
go

CREATE PROCEDURE sp_CheckAdmin
(
   @Nombre			VARCHAR(20),
   @Pass				VARCHAR(20)
)
AS
BEGIN
select * from Empleado where Nombres = @Nombre and Contraseña = @Pass and Gerente = 1 

END

--Checar Gerentes para el CB empresa--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_GetNameGer' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_GetNameGer;
go

CREATE PROCEDURE sp_GetNameGer
AS
BEGIN
select Nombres from Empleado where Gerente = 1

END

--Checar SuperUsuario--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_CheckSuperUser' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_CheckSuperUser;
go

CREATE PROCEDURE sp_CheckSuperUser
(
   @Id				bigint
)
AS
BEGIN
select * from Empleado where NoEmpleado <= 1000 and NoEmpleado = @Id
END

 --GetGerenteMenu--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_GetGerenteMenu' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_GetGerenteMenu;
go

CREATE PROCEDURE sp_GetGerenteMenu
(
   @Id				bigint
)
AS
BEGIN
	select IdNomina, Nombres, IdEmpresa, IdDepto, IdPuesto from Empleado where @Id = NoEmpleado
END


--Conseguir un Id--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_GetIdAny' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_GetIdAny;
go

CREATE PROCEDURE sp_GetIdAny
(
   @Nombre			varchar(20),
   @Pass				varchar(20)
)
AS
BEGIN
	select NoEmpleado 'id' from Empleado where Nombres = @Nombre and Contraseña = @Pass
END


 --Info del Gerente--
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_GetGerenteInfo' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_GetGerenteInfo;
go

CREATE PROCEDURE sp_GetGerenteInfo
(
   @id			bigint
)
AS
BEGIN
	
	select NoEmpleado 'id', Nombres 'Nombre', IdEmpresa 'Empresa', IdDepto 'Departamento', IdPuesto 'Puesto' from Empleado where NoEmpleado = @id
END

-- Percepciones
IF EXISTS(SELECT 1 FROM sysobjects WHERE name = 'sp_Percep' AND type = 'P')	  --Tipo procedure
DROP PROCEDURE sp_Percep;
go

CREATE PROCEDURE sp_Percepc
(
@Opc				CHAR(1),
@Id				INT = null,
@Nombre			VARCHAR(30) = null,
@Valor			DECIMAL(11,2),
@Porcentaje		tinyint
)
AS
BEGIN 
	if @Opc = 'I'
		BEGIN
			INSERT INTO Percepciones(Nombre, Valor, Porcentaje)
			VALUES (@Nombre, @Valor, @Porcentaje)
		END

	IF @Opc = 'D'
		BEGIN
			DELETE 
			FROM Puesto
			WHERE IdPuesto = @Id
		END

END

