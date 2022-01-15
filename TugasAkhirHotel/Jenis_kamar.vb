Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Jenis_kamar

    Private Id_jens_Kamar As Integer
    Private JenisKamar As String
    Private Harga As Integer
    Private Jenis As New List(Of String)
    Private DataTable As New ArrayList()
    Private jenisItem As New List(Of String)


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"


    Public Function AddJenisKamar(value As String)
        Jenis.Add(value)
        Return ""
    End Function

    Public Function resetItem()
        jenisItem.Clear()
    End Function

    Public ReadOnly Property getjenisItem() As List(Of String)
        Get
            Return jenisItem
        End Get
    End Property

    Public Property GSId_jenisKamar() As String
        Get
            Return Id_jens_Kamar
        End Get
        Set(ByVal value As String)
            Id_jens_Kamar = value
        End Set
    End Property

    Public Property GSJenisKamar() As String
        Get
            Return JenisKamar
        End Get
        Set(ByVal value As String)
            JenisKamar = value
        End Set
    End Property

    Public Property GSHarga() As String
        Get
            Return Harga
        End Get
        Set(ByVal value As String)
            Harga = value
        End Set
    End Property

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return DataTable
        End Get
    End Property

    'Public Function ConvertKoleksiToString(vals As List(Of String))
    '    Dim builder As StringBuilder = New StringBuilder()
    '    For Each val As String In vals
    '        builder.Append(val).Append("|")
    '    Next

    '    ' Convert to string.
    '    Dim res = builder.ToString()
    '    Return res
    'End Function

    'Public Function ConvertStringToKoleksi(value As String)
    '    Dim arr() As String = value.Split("|")

    '    ' Convert to List.
    '    Dim vals As List(Of String) = arr.ToList()
    '    Return vals
    'End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_kamar AS 'ID Jenis Kamar',
                                  jenis_kamar as 'Jenis Kamar',
                                  harga_permalam AS 'Harga Permalam'
                                  FROM jeniskamar"

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
        sqlCommand.CommandText = "SELECT id_jenis_kamar,
                                  jenis_kamar, 
                                  harga_permalam
                                  FROM jeniskamar 
                                  WHERE id_jenis_kamar='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function


    Public Function AdddataKoleksiDatabase(jeniskamar As String,
                                           hargakamar As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "INSERT INTO jeniskamar (jenis_kamar,
                        harga_permalam) VALUE(
            '" & jeniskamar & "',
            '" & hargakamar & "')"

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        sqlRead.Close()

    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  jeniskamar As String,
                                                  hargakamar As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE jeniskamar SET " &
                       "jenis_kamar='" & jeniskamar & "', " &
                       "harga_permalam='" & hargakamar & "' " &
                       "WHERE id_jenis_kamar=" & ID

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)

        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()
        sqlRead.Close()

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "DELETE FROM jeniskamar WHERE id_jenis_kamar = '" & ID & "'"

        Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()

    End Function

End Class
