Public Class tambah_jeniskamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click


        jeniskamar.JnsKmr.GSJenisKamar = TxtBoxJenisKamar.Text
        jeniskamar.JnsKmr.GSHarga = Integer.Parse(TxtBoxHargaKamar.Text)


        jeniskamar.JnsKmr.AdddataKoleksiDatabase(jeniskamar.JnsKmr.GSJenisKamar,
                                                 jeniskamar.JnsKmr.GSHarga
                                                 )

        Dim tambahjenis = New jeniskamar
        tambahjenis.Show()
        Me.Close()
    End Sub
End Class