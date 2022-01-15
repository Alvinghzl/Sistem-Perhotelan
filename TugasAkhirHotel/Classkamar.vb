Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Classkamar

    Private id_kamar As Integer
    Private id_jenis_kamar As Integer
    Private nama_kamar As String
    Private status As String


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"


    Public Property idKamar() As String
        Get
            Return id_kamar
        End Get
        Set(ByVal value As String)
            id_kamar = value
        End Set
    End Property

    Public Property gsIDjenisKamar() As String
        Get
            Return id_jenis_kamar
        End Get
        Set(ByVal value As String)
            id_jenis_kamar = value
        End Set
    End Property

    Public Property gsNamaKamar() As String
        Get
            Return nama_kamar
        End Get
        Set(ByVal value As String)
            nama_kamar = value
        End Set
    End Property

    Public Property gsStatus() As String
        Get
            Return status
        End Get
        Set(ByVal value As String)
            status = value
        End Set
    End Property

    Public Function AdddataKoleksiDatabase(idjeniskamar As String,
                                          namakamar As String,
                                          status As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "INSERT INTO kamar (id_jenis_kamar,
                        nama_kamar, status) VALUE(
            '" & idjeniskamar & "',
            '" & namakamar & "',
            '" & status & "')"

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        sqlRead.Close()

    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_kamar AS 'ID Kamar',
                                  id_jenis_kamar AS 'ID Jenis Kamar',
                                  nama_kamar as 'Nama Kamar',
                                  status AS 'Status'
                                  FROM kamar"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_kamar,
                                  id_jenis_kamar,
                                  nama_kamar, 
                                  status 
                                  FROM kamar 
                                  WHERE id_kamar='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                 idjeniskamar As Integer,
                                                 namakamar As String,
                                                 status As String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE kamar SET " &
                       "id_jenis_kamar='" & idjeniskamar & "', " &
                       "nama_kamar='" & namakamar & "', " &
                       "status='" & status & "' " &
                       "WHERE id_kamar=" & ID

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)

        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()
        sqlRead.Close()

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "DELETE FROM kamar WHERE id_kamar = '" & ID & "'"

        Debug.WriteLine(sqlQuery)

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        sqlRead.Close()

    End Function


End Class
