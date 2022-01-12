Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class User
    Private Shared UnameID As String
    Private Shared Pw As String

    Private TripleDes As New TripleDESCryptoServiceProvider
    Public Shared AkunReg As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "hotel"

    Public Property Uname() As String
        Get
            Return UnameID
        End Get
        Set(ByVal value As String)
            UnameID = value
        End Set
    End Property
    Public Property PassW() As String
        Get
            Return Pw
        End Get
        Set(ByVal value As String)
            Pw = value
        End Set
    End Property

    Public Function EncryptData(ByVal plaintext As String) As String
        ' Plaintext Srting > byte array
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        'Create the Stream
        Dim ms As New System.IO.MemoryStream

        ' Create encoder
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' encrypted stream > printable string
        Return Convert.ToBase64String(ms.ToArray)
    End Function
    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function CekAuth(username As String, ByVal plainPassword As String) As Boolean
        ' Static akun
        For Each Un In AkunReg
            If String.Compare(username, Un(0)) = 0 Then
                If String.Compare(EncryptData(plainPassword), Un(1)) = 0 Then
                    Return True
                Else Return False
                End If
            End If
        Next
        Return False
    End Function

    Public Function regis(user, pw)
        AkunReg.Add({user, EncryptData(pw)})

    End Function


    Public Function AddUsersDatabase(Username_regist As String, password_regist As String)

        Dim today = Date.Now()

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO users(username, password, registered_at) VALUE('" &
                        Username_regist & "', '" &
                        EncryptMD5(password_regist) & "', '" &
                        today.ToString("yyyy/MM/dd") & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

    End Function

    Public Function CekAuthDatabase(username_login As String, password_login As String) As List(Of String)

        Dim result As New List(Of String)

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username + ";" + "password = " + password + ";" + "database = " + database
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim quertAuth = "SELECT id_user, username FROM users WHERE username ='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"
            sqlCommand.CommandText = quertAuth
            Debug.WriteLine(quertAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result


    End Function

End Class
