Public Class tambah_kamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub tmbah_Click(sender As Object, e As EventArgs) Handles tmbah.Click


        kamar.kamarr.GSIdKamar = Integer.Parse(idkamar.Text)
        kamar.kamarr.GSidjeniskamar = Integer.Parse(idjeniskamar.Text)
        kamar.kamarr.GSnamakamar = namakamarr.Text
        kamar.kamarr.GSstatus = status.SelectedItem().ToString()


        Dim tambahkamar = New tambah_kamar
        tambahkamar.Show()
    End Sub
End Class