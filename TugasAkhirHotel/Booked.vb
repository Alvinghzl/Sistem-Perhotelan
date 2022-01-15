Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Booked

    Private idtamu As Integer
    Private idkamar As Integer
    Private tglcheckin As String
    Private tglcheckout As String
    Private bayar As Integer
    Private status As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"

    Public Property GSidTamu() As String
        Get
            Return idtamu
        End Get
        Set(ByVal value As String)
            idtamu = value
        End Set
    End Property

    Public Property GSidkamar() As String
        Get
            Return idkamar
        End Get
        Set(ByVal value As String)
            idkamar = value
        End Set
    End Property

    Public Property GScheckin() As String
        Get
            Return tglcheckin
        End Get
        Set(ByVal value As String)
            tglcheckin = value
        End Set
    End Property

    Public Property gscheckout() As String
        Get
            Return tglcheckout
        End Get
        Set(ByVal value As String)
            tglcheckout = value
        End Set
    End Property
    Public Property GSbayar() As String
        Get
            Return bayar
        End Get
        Set(ByVal value As String)
            bayar = value
        End Set
    End Property

    Public Property GSstatus() As String
        Get
            Return status
        End Get
        Set(ByVal value As String)
            status = value
        End Set
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each Val As String In vals
            builder.Append(Val).Append("|")
        Next
        'Convert ke String
        Dim res = builder.ToString()
        Return res
    End Function

    'Convert String > List
    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")
        'Convert ke List
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function AddDataKoleksiDatabase(id_tamu As Integer,
                                           id_kamar As Integer,
                                           check_in As Date
                                           )
        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        Dim checkin As String = check_in.ToString("yyyy/MM/dd")



        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "INSERT INTO buking(id_tamu, id_kamar, check_in, status) VALUE(
                        '" & id_tamu &
                        "', '" & id_kamar &
                        "', '" & checkin &
                        "', 'Belum Checkout')"

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
        sqlRead = sqlCommand.ExecuteReader

        dbConn.Close()
        'Perpustakaan.sqlDt.Load(sqlRead)
        sqlRead.Close()

    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT 
                                  id_booking AS 'ID Booking',
                                  id_tamu AS 'ID Tamu',
                                  id_kamar AS 'ID Kamar',
                                  check_in AS 'Tanggal Check In',
                                  check_out AS 'Tanggal Check Out',
                                  total_bayar AS 'Total Bayar',
                                  status AS 'Status'
                                  FROM buking"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function checkoutDataKoleksiByIDDatabase(ID As Integer,
                                                  check_out As Date,
                                                  total_bayar As Integer
                                                  )
        Dim checkout As String = check_out.ToString("yyyy/MM/dd")
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlQuery = "UPDATE buking SET " &
                       "check_out='" & checkout & "', " &
                       "total_bayar='" & total_bayar & "', " &
                       "status='Sudah Checkout' " &
                       "WHERE id_booking=" & ID

        sqlCommand = New MySqlCommand(sqlQuery, dbConn)

        sqlRead = sqlCommand.ExecuteReader
        dbConn.Close()
        sqlRead.Close()
    End Function

    Public Function GetDatahargaDatabase(IDKamar As Integer) As Integer
        Dim result As Integer

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT 
                                  harga_permalam
                                  FROM jeniskamar 
                                  where id_jenis_kamar=
                                  (SELECT id_jenis_kamar from kamar where id_kamar= " & IDKamar & ")"
        sqlRead = sqlCommand.ExecuteReader

        If (sqlRead.Read()) Then
            result = sqlRead.GetValue(0)
        End If
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function updatekamar(IDKamar As Integer, status As String) As Integer
        Dim result As Integer

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "UPDATE kamar SET status='" & status & "' where id_kamar= " & IDKamar

        sqlRead = sqlCommand.ExecuteReader

        If (sqlRead.Read()) Then
            result = sqlRead.GetValue(0)
        End If
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

End Class
