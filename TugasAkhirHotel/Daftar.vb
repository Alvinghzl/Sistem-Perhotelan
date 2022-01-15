Public Class Daftar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Dim user As String = TextBoxUser.Text
        Dim pw As String = TextBoxPassword.Text
        Dim email As String = TextBoxEmail.Text

        If user.Length > 0 And pw.Length > 0 Then
            Login.Users.AddUsersDatabase(user, pw, email)
            MessageBox.Show("Register Berhasil")
            Me.Close()
        Else
            MessageBox.Show("Masukan Data")
        End If

    End Sub
End Class