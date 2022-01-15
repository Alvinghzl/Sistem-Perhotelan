Public Class tambah_tamu

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click



        formtamu.tamu.GSNik = TextBoxNIK.Text
        formtamu.tamu.GSNama = TextBoxNama.Text
        formtamu.tamu.GSAlamat = RichTextBoxAlamat.Text
        formtamu.tamu.GSJenisKelamin = ComboBoxGender.SelectedItem()

        formtamu.tamu.AdddataKoleksiDatabase(formtamu.tamu.GSNik,
                                         formtamu.tamu.GSNama,
                                         formtamu.tamu.GSAlamat,
                                         formtamu.tamu.GSJenisKelamin
                                         )

        Dim tambah = New formtamu
        tambah.Show()
        Me.Close()
    End Sub
End Class