Public Class UpdateItem

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtBoxJenisKamar.Text = jeniskamar.JnsKmr.GSJenisKamar
        TxtBoxHargaKamar.Text = jeniskamar.JnsKmr.GSHarga

        jeniskamar.JnsKmr.resetItem()

    End Sub


    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        jeniskamar.JnsKmr.GSJenisKamar = TxtBoxJenisKamar.Text
        jeniskamar.JnsKmr.GSHarga = Integer.Parse(TxtBoxHargaKamar.Text)


        Dim converted = jeniskamar.JnsKmr.ConvertKoleksiToString(jeniskamar.JnsKmr.getjenisItem)
        jeniskamar.JnsKmr.AdddataKoleksiDatabase(jeniskamar.JnsKmr.GSJenisKamar,
                                                 jeniskamar.JnsKmr.GSHarga,
                                                 converted
                                                 )
        Dim update = New jeniskamar()
        update.Show()

        Me.Close()
    End Sub
End Class