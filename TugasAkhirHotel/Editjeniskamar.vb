Public Class Editjeniskamar

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TxtBoxJenisKamar.Text = jeniskamar.JnsKmr.GSJenisKamar
        TxtBoxHargaKamar.Text = jeniskamar.JnsKmr.GSHarga

        jeniskamar.JnsKmr.resetitem()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        jeniskamar.JnsKmr.GSJenisKamar = TxtBoxJenisKamar.Text
        jeniskamar.JnsKmr.GSHarga = Integer.Parse(TxtBoxHargaKamar.Text)


        Dim converted = jeniskamar.JnsKmr.ConvertKoleksiToString(jeniskamar.JnsKmr.getjenisItem)

        jeniskamar.JnsKmr.UpdateDataKoleksiByIDDatabase(jeniskamar.idterpilih,
                                                        jeniskamar.JnsKmr.GSJenisKamar,
                                                        jeniskamar.JnsKmr.GSHarga,
                                                        converted
                                                        )
        Dim edit = New jeniskamar()
        edit.Show()

        Me.Close
    End Sub
End Class