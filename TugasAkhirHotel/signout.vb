Public Class signout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim logout = New Login()
        logout.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tidak = New Booking()
        tidak.Show()
        Me.Close()
    End Sub
End Class