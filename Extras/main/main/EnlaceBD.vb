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

End Class
