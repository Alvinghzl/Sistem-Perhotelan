Imports MySql.Data.MySqlClient

Public Class Classtamu

    Private idtamu As Integer
    Private Nik As Integer
    Private namatamu As String
    Private alamat As String
    Private jeniskelamin As String


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"

    Public Property GSidtamu() As String
        Get
            Return idtamu
        End Get
        Set(ByVal value As String)
            idtamu = value
        End Set
    End Property

    Public Property GSNik() As String
        Get
            Return Nik
        End Get
        Set(ByVal value As String)
            Nik = value
        End Set
    End Property

    Public Property GSNama() As String
        Get
            Return namatamu
        End Get
        Set(ByVal value As String)
            namatamu = value
        End Set
    End Property

    Public Property GSAlamat() As String
        Get
            Return alamat
        End Get
        Set(ByVal value As String)
            alamat = value
        End Set
    End Property

    Public Property GSJenisKelamin() As String
        Get
            Return jeniskelamin
        End Get
        Set(ByVal value As String)
            jeniskelamin = value
        End Set
    End Property

    Public Function AdddataKoleksiDatabase(NIK As Integer,
                                          Nama As String,
                                          Alamat As String,
                                          JenisKelamin As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "INSERT INTO tamu (nik,
                        nama_tamu, alamat, jenis_kelamin) VALUE(
            '" & NIK & "',
            '" & Nama & "',
            '" & Alamat & "',
            '" & JenisKelamin & "')"

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
        sqlCommand.CommandText = "SELECT id_tamu AS 'ID Tamu',
                                  nik AS 'NIK',
                                  nama_tamu as 'Nama Tamu',
                                  alamat AS 'Alamat',
                                  jenis_kelamin AS 'Jenis Kelamin'
                                  FROM tamu"

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
        sqlCommand.CommandText = "SELECT id_tamu,
                                  nik,
                                  nama_tamu, 
                                  alamat,
                                  jenis_kelamin 
                                  FROM tamu 
                                  WHERE id_tamu='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                 NIK As Integer,
                                                 Nama As String,
                                                 Alamat As String,
                                                 JenisKelamin As String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database

        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE tamu SET " &
                       "nik='" & NIK & "', " &
                       "nama_tamu='" & Nama & "', " &
                       "alamat='" & Alamat & "', " &
                       "jenis_kelamin='" & JenisKelamin & "' " &
                       "WHERE id_tamu=" & ID

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)

        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()
        sqlRead.Close()

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "DELETE FROM tamu WHERE id_tamu = '" & ID & "'"

        Debug.WriteLine(sqlQuery)

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        sqlRead.Close()

    End Function

End Class
