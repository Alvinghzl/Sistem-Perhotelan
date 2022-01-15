Public Class hapustamu


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapus.Text = formtamu.namaterpilih
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click


        If formtamu.idterpilih.HasValue Then
            formtamu.tamu.DeleteDataKoleksiByIDDatabase(formtamu.idterpilih)
        End If



        Me.Close()
    End Sub
End Class