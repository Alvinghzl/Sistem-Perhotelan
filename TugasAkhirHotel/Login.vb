Public Class Login

    Public Shared Users As User

    Public Shared Id As String
    Public Shared Pw As String

    Public Shared reg As Daftar
    Public Shared boking As Booking

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Users = New User()
        reg = New Daftar()
        User.AkunReg.Add({"1", Users.EncryptData("1")})

        boking = New Booking
        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Id = TextBoxUser.Text
        Pw = TextBoxPassword.Text

        Dim data_user As List(Of String) = Users.CekAuthDatabase(Id, Pw)

        If data_user.Count > 0 Then
            Users.Uname = data_user(1)
            Booking.Show()
            Me.Hide()
        Else
            MessageBox.Show("Password Salah Silahkan Periksa Kembali")
        End If

    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBoxUser.Text = 1
        TextBoxPassword.Text = 1

    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Daftar.Show()
    End Sub
End Class