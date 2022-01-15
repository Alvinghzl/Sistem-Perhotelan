Public Class HapusKamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapus.Text = FormKamar.idterpilih
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If FormKamar.idterpilih.HasValue Then
            FormKamar.kmr.DeleteDataKoleksiByIDDatabase(FormKamar.idterpilih)
        End If

        Me.Close()
    End Sub
End Class