Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Jenis_kamar

    Private IdKamar As Integer
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

    Public ReadOnly Property getjenisItem() As List(Of String)
        Get
            Return jenisItem
        End Get
    End Property

    Public Property GSIdKamar() As String
        Get
            Return IdKamar
        End Get
        Set(ByVal value As String)
            IdKamar = value
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

    Public Function AddKoleksiDataTable(IDRoom As Integer,
                                        JenisRoom As String,
                                        HargaRoom As Integer
                                        )

        DataTable.Add({IDRoom,
                      JenisRoom,
                      HargaRoom
                      })

    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return DataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        ' Convert to string.
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        ' Convert to List.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database

        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_kamar AS 'ID Kamar',
                                  jenis_kamar as 'Jenis Kamar',
                                  harga_permalam AS 'Harga Permalam'
                                  FROM jeniskamar"

        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AdddataKoleksiDatabase(jeniskamar As String,
                                           hargakamar As Integer,
                                           jenisitem As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database


        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "INSERT INTO jeniskamar (jenis_kamar,
                        harga_permalam, jenisitem) VALUE(
            '" & jeniskamar & "',
            '" & hargakamar & "',
            '" & jenisitem & "')"

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()

        'Perpustakaan. sqlDt. Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()



    End Function


End Class
