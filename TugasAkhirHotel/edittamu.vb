Public Class edittamu

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        TextBoxNIK.Text = formtamu.tamu.GSNik
        TextBoxNama.Text = formtamu.tamu.GSNama
        RichTextBoxAlamat.Text = formtamu.tamu.GSAlamat
        ComboBoxGender.SelectedItem() = formtamu.tamu.GSJenisKelamin

    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click


        formtamu.tamu.GSNik = TextBoxNIK.Text
        formtamu.tamu.GSNama = TextBoxNama.Text
        formtamu.tamu.GSAlamat = RichTextBoxAlamat.Text
        formtamu.tamu.GSJenisKelamin = ComboBoxGender.SelectedItem()

        formtamu.tamu.UpdateDataKoleksiByIDDatabase(formtamu.idterpilih,
                                          formtamu.tamu.GSNik,
                                         formtamu.tamu.GSNama,
                                         formtamu.tamu.GSAlamat,
                                         formtamu.tamu.GSJenisKelamin
                                         )
        Dim edit = New formtamu()
        edit.Show()

        Me.Close()
    End Sub
End Class