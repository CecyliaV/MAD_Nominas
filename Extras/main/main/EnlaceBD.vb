Imports System.Data
Imports System.Data.SqlClient
Public Class EnlaceBD
    Private aux As String
    Private conexion As SqlConnection
    'Private conexionNomina As SqlConnection
    Private tabla As DataTable = New DataTable
    Private adaptador As SqlDataAdapter = New SqlDataAdapter
    Private comandosql As SqlCommand = New SqlCommand
    Public _lector As SqlDataReader




    Private Sub conectar()
        'Dim DBConnection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("SQL").ConnectionString)        
        conexion = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("desarrollo").ConnectionString)
    End Sub

    Private Sub desconectar()
        conexion.Close()
    End Sub

    Public ReadOnly Property obtenertabla() As DataTable
        Get
            Return tabla
        End Get
    End Property

    Public Function ValidaUser(ByVal User As String, ByVal Pass As String) As Boolean
        Dim query As String
        Dim data As New DataTable
        Dim fnd As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_CheckPassword", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro1.Value = User
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Pass", SqlDbType.VarChar, 20)
            parametro2.Value = Pass

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            If (data.Rows.Count = 1) Then
                fnd = True
            Else
                fnd = False
            End If

        Catch ex As SqlException
            fnd = False
        Finally
            desconectar()
        End Try

        Return fnd
    End Function

    Public Function ValidaAdmin(ByVal User As String, ByVal Pass As String) As Boolean
        Dim query As String
        Dim data As New DataTable
        Dim fnd As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_CheckAdmin", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro1.Value = User
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Pass", SqlDbType.VarChar, 20)
            parametro2.Value = Pass

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            If (data.Rows.Count = 1) Then
                fnd = True
            Else
                fnd = False
            End If

        Catch ex As SqlException
            fnd = False
        Finally
            desconectar()
        End Try

        Return fnd
    End Function

    Public Sub LoadGerente(ByVal list As ComboBox)
        Dim query As String
        Dim data As New DataTable
        Dim fnd As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_GetNameGer", conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            conexion.Open()

            _lector = comandosql.ExecuteReader()

            While (_lector.Read())
                list.Items.Add(_lector("Nombres"))
            End While

        Catch ex As SqlException
            _lector.Close()
        Finally
            desconectar()
        End Try


    End Sub

    Public Function ValidaSuperUser(ByVal Id As Integer) As Boolean
        Dim query As String
        Dim data As New DataTable
        Dim fnd As Boolean = True
        Try
            conectar()
            comandosql = New SqlCommand("sp_CheckSuperUser", conexion)
            comandosql.CommandType = CommandType.StoredProcedure


            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Id", SqlDbType.BigInt, 20)
            parametro1.Value = Id

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            If (data.Rows.Count = 1) Then
                fnd = True
            Else
                fnd = False
            End If

        Catch ex As SqlException
            fnd = False
        Finally
            desconectar()
        End Try

        Return fnd
    End Function

    Public Function GetId(ByVal nombre As String, ByVal pass As String) As Integer
        Dim data As New DataTable
        Dim IdGerente As Integer

        conectar()
        comandosql = New SqlCommand("sp_GetIdAny", conexion)
        comandosql.CommandType = CommandType.StoredProcedure


        Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
        parametro1.Value = nombre

        Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Pass", SqlDbType.VarChar, 20)
        parametro2.Value = pass

        adaptador.SelectCommand = comandosql
        adaptador.Fill(data)

        If data.Rows IsNot Nothing AndAlso data.Rows.Count > 0 Then
            IdGerente = data.Rows(0).Item("id")
        End If

        Return IdGerente
    End Function
    Public Function Get_GerenteInfo(ByVal Id As Integer) As DataTable
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_GetGerenteInfo"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@id", SqlDbType.BigInt, 20)
            parametro1.Value = Id

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)


        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data

    End Function
    Public Function AddEmpresaInfo(ByVal opc As String, ByVal Nombre As String, ByVal RS As String, ByVal Dom As String, ByVal RP As String, ByVal RFC As String,
                            ByVal fec As Date, ByVal email As String, ByVal tel As String, ByVal IdFrec As Integer, ByVal IdGerente As Integer
        ) As Boolean
        Dim fnd As Boolean = False
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_Empresa"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure


            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 1)
            parametro1.Value = "I"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            If (Nombre = Nothing) Then
                parametro2.Value = DBNull.Value
            Else
                parametro2.Value = Nombre
            End If
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@RSocial", SqlDbType.VarChar, 20)
            parametro3.Value = RS
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@DFiscal", SqlDbType.VarChar, 20)
            parametro4.Value = Dom
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@RPatronal", SqlDbType.VarChar, 20)
            parametro5.Value = RP
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@RFC", SqlDbType.Char, 20)
            parametro6.Value = RFC
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@FecIniOp", SqlDbType.Date, 20)
            parametro7.Value = fec
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 20)
            parametro8.Value = email
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Telefono", SqlDbType.VarChar, 20)
            parametro9.Value = tel
            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@IdGerente", SqlDbType.BigInt, 20)
            If (IdGerente = Nothing) Then
                parametro10.Value = DBNull.Value
            Else
                parametro10.Value = IdGerente
            End If
            Dim parametro11 As SqlParameter = comandosql.Parameters.Add("@IdFrecuencia", SqlDbType.Int, 20)
            parametro11.Value = DBNull.Value
            If (IdFrec = Nothing) Then
                parametro11.Value = DBNull.Value
            Else
                parametro11.Value = IdFrec
            End If

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            fnd = True

        Catch ex As SqlException
            fnd = False

        Finally
            desconectar()
        End Try
        Return fnd

    End Function

    Public Function GetIdFrecandGer(ByVal nombre As String) As Integer
        Dim data As New DataTable
        Dim IdGerente As Integer

        conectar()
        comandosql = New SqlCommand("sp_GetIdGerente", conexion)
        comandosql.CommandType = CommandType.StoredProcedure


        Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
        parametro1.Value = nombre


        adaptador.SelectCommand = comandosql
        adaptador.Fill(data)

        If data.Rows IsNot Nothing AndAlso data.Rows.Count > 0 Then
            IdGerente = data.Rows(0).Item("id")
        End If

        Return IdGerente
    End Function
    Public Function GetEmpresaNom(ByVal nombre As String, ByVal contra As String) As DataTable
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_GetEmpresaGer"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure

            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro1.Value = nombre

            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Pass", SqlDbType.VarChar, 20)
            parametro2.Value = contra

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)


        Catch ex As SqlException

        Finally
            desconectar()
        End Try
        Return data

    End Function

    Public Function GetIdEmpresa(ByVal nombre As String, ByVal contra As String) As Integer
        Dim data As New DataTable
        Dim IdGerente As Integer

        conectar()
        comandosql = New SqlCommand("sp_GetEmpresaId", conexion)
        comandosql.CommandType = CommandType.StoredProcedure


        Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
        parametro1.Value = nombre

        Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Pass", SqlDbType.VarChar, 20)
        parametro2.Value = contra


        adaptador.SelectCommand = comandosql
        adaptador.Fill(data)

        If data.Rows IsNot Nothing AndAlso data.Rows.Count > 0 Then
            IdGerente = data.Rows(0).Item("IdEmpresa")
        End If

        Return IdGerente
    End Function

    Public Function AddEmpleadoInfo(ByVal opc As String, ByVal Nombre As String, ByVal User As String, ByVal Contra As String, ByVal NSS As String, ByVal RFC As String,
                          ByVal Banco As String, ByVal NoCuenta As String, ByVal email As String, ByVal Telefono As String, ByVal ApM As String, ByVal ApP As String,
                                    ByVal CURP As String, ByVal IdEmpresa As Integer, ByVal IdPuesto As Integer, ByVal IdNomina As Integer, ByVal IdDepto As Integer,
                                    ByVal Calle As String, ByVal Num As Integer, ByVal Col As String, ByVal Mun As String, ByVal estado As String, ByVal CP As String,
                                    ByVal Gerente As Boolean, ByVal FecNac As Date) As Boolean
        Dim fnd As Boolean = False
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_Empleado"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure


            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 1)
            parametro1.Value = "I"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            parametro2.Value = Nombre
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@User", SqlDbType.VarChar, 20)
            parametro3.Value = User
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 20)
            parametro4.Value = Contra
            Dim parametro5 As SqlParameter = comandosql.Parameters.Add("@NSS", SqlDbType.Char, 11)
            parametro5.Value = NSS
            Dim parametro6 As SqlParameter = comandosql.Parameters.Add("@RFC", SqlDbType.Char, 13)
            parametro6.Value = RFC
            Dim parametro7 As SqlParameter = comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 20)
            parametro7.Value = Banco
            Dim parametro8 As SqlParameter = comandosql.Parameters.Add("@NoCuenta", SqlDbType.Char, 20)
            parametro8.Value = NoCuenta
            Dim parametro9 As SqlParameter = comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 20)
            parametro9.Value = email
            Dim parametro10 As SqlParameter = comandosql.Parameters.Add("@Telefonos", SqlDbType.VarChar, 20)
            parametro10.Value = Telefono
            Dim parametro11 As SqlParameter = comandosql.Parameters.Add("@ApM", SqlDbType.VarChar, 20)
            parametro11.Value = ApM
            Dim parametro12 As SqlParameter = comandosql.Parameters.Add("@ApP", SqlDbType.VarChar, 20)
            parametro12.Value = ApP
            Dim parametro13 As SqlParameter = comandosql.Parameters.Add("@CURP", SqlDbType.Char, 20)
            parametro13.Value = CURP


            Dim parametro14 As SqlParameter = comandosql.Parameters.Add("@IdEmpresa", SqlDbType.Int, 1)
            If (IdEmpresa = Nothing) Then
                parametro14.Value = DBNull.Value
            Else
                parametro14.Value = IdEmpresa
            End If

            Dim parametro15 As SqlParameter = comandosql.Parameters.Add("@IdPuesto", SqlDbType.Int, 1)
            parametro15.Value = DBNull.Value
            If (IdPuesto = Nothing) Then
                parametro15.Value = DBNull.Value
            Else
                parametro15.Value = IdPuesto
            End If

            Dim parametro16 As SqlParameter = comandosql.Parameters.Add("@IdNomina", SqlDbType.Int, 1)
            parametro16.Value = DBNull.Value
            If (IdNomina = Nothing) Then
                parametro16.Value = DBNull.Value
            Else
                parametro16.Value = IdNomina
            End If

            Dim parametro17 As SqlParameter = comandosql.Parameters.Add("@IdDepto", SqlDbType.Int, 1)
            parametro17.Value = DBNull.Value
            If (IdDepto = Nothing) Then
                parametro17.Value = DBNull.Value
            Else
                parametro17.Value = IdDepto
            End If

            Dim parametro18 As SqlParameter = comandosql.Parameters.Add("@Calle", SqlDbType.VarChar, 20)
            parametro18.Value = Calle
            Dim parametro19 As SqlParameter = comandosql.Parameters.Add("@Numero", SqlDbType.Int, 1)
            parametro19.Value = Num
            Dim parametro20 As SqlParameter = comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar, 20)
            parametro20.Value = Col
            Dim parametro21 As SqlParameter = comandosql.Parameters.Add("@Municipio", SqlDbType.VarChar, 20)
            parametro21.Value = Mun
            Dim parametro22 As SqlParameter = comandosql.Parameters.Add("@Estado", SqlDbType.VarChar, 20)
            parametro22.Value = estado
            Dim parametro23 As SqlParameter = comandosql.Parameters.Add("@CP", SqlDbType.VarChar, 20)
            parametro23.Value = CP
            Dim parametro24 As SqlParameter = comandosql.Parameters.Add("@Gerente", SqlDbType.Int, 1)
            parametro24.Value = Gerente
            Dim parametro25 As SqlParameter = comandosql.Parameters.Add("@fecNac", SqlDbType.Date, 20)
            parametro25.Value = FecNac

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            fnd = True

        Catch ex As SqlException
            fnd = False

        Finally
            desconectar()
        End Try
        Return fnd

    End Function

    Public Function AddDepartamento(ByVal opc As String, ByVal Nombre As String,
                                    ByVal SueldoBase As Decimal, ByVal IdGerente As Integer) As Boolean
        Dim fnd As Boolean = False
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_Departamento"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure


            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 1)
            parametro1.Value = "I"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            If (Nombre = Nothing) Then
                parametro2.Value = DBNull.Value
            Else
                parametro2.Value = Nombre
            End If
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@SueldoBase", SqlDbType.Decimal, 13)
            parametro3.Value = SueldoBase
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@IdGerente", SqlDbType.BigInt, 20)
            If (IdGerente = Nothing) Then
                parametro4.Value = DBNull.Value
            Else
                parametro4.Value = IdGerente
            End If


            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            fnd = True

        Catch ex As SqlException
            fnd = False

        Finally
            desconectar()
        End Try
        Return fnd

    End Function

    Public Function AddPuesto(ByVal opc As String, ByVal Nombre As String,
                                ByVal NivSalarial As Decimal) As Boolean
        Dim fnd As Boolean = False
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_Puesto"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure


            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 1)
            parametro1.Value = "I"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            If (Nombre = Nothing) Then
                parametro2.Value = DBNull.Value
            Else
                parametro2.Value = Nombre
            End If
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@NivSalarial", SqlDbType.Decimal, 13)
            parametro3.Value = NivSalarial

            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            fnd = True

        Catch ex As SqlException
            fnd = False

        Finally
            desconectar()
        End Try
        Return fnd

    End Function

    Public Function AddPercep(ByVal opc As String, ByVal Nombre As String,
                            ByVal Valor As Decimal, ByVal Porcentaje As Byte) As Boolean
        Dim fnd As Boolean = False
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_Percep"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure


            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 1)
            parametro1.Value = "I"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            If (Nombre = Nothing) Then
                parametro2.Value = DBNull.Value
            Else
                parametro2.Value = Nombre
            End If
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Valor", SqlDbType.Decimal, 13)
            If (Valor = Nothing) Then
                parametro3.Value = DBNull.Value
            Else
                parametro3.Value = Valor
            End If
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Porcentaje", SqlDbType.TinyInt, 3)

            If (Porcentaje = Nothing) Then
                parametro4.Value = DBNull.Value
            Else
                parametro4.Value = Porcentaje
            End If
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            fnd = True

        Catch ex As SqlException
            fnd = False

        Finally
            desconectar()
        End Try
        Return fnd

    End Function

    Public Function AddDedu(ByVal opc As String, ByVal Nombre As String,
                        ByVal Valor As Decimal, ByVal Porcentaje As Byte) As Boolean
        Dim fnd As Boolean = False
        Dim Qry As String
        Dim data As New DataTable

        Try

            conectar()

            Qry = "sp_Dedu"
            comandosql = New SqlCommand(Qry, conexion)
            comandosql.CommandType = CommandType.StoredProcedure


            Dim parametro1 As SqlParameter = comandosql.Parameters.Add("@Opc", SqlDbType.VarChar, 1)
            parametro1.Value = "I"
            Dim parametro2 As SqlParameter = comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 20)
            If (Nombre = Nothing) Then
                parametro2.Value = DBNull.Value
            Else
                parametro2.Value = Nombre
            End If
            Dim parametro3 As SqlParameter = comandosql.Parameters.Add("@Valor", SqlDbType.Decimal, 13)
            If (Valor = Nothing) Then
                parametro3.Value = DBNull.Value
            Else
                parametro3.Value = Valor
            End If
            Dim parametro4 As SqlParameter = comandosql.Parameters.Add("@Porcentaje", SqlDbType.TinyInt, 3)

            If (Porcentaje = Nothing) Then
                parametro4.Value = DBNull.Value
            Else
                parametro4.Value = Porcentaje
            End If
            adaptador.SelectCommand = comandosql
            adaptador.Fill(data)

            fnd = True

        Catch ex As SqlException
            fnd = False

        Finally
            desconectar()
        End Try
        Return fnd

    End Function

End Class
