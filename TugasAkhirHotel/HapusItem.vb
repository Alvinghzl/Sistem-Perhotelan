Public Class HapusItem

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapus.Text = jeniskamar.namaterpilih
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        jeniskamar.JnsKmr.DeleteDataKoleksiByIDDatabase(jeniskamar.idterpilih)

        Me.Close()
    End Sub
End Class