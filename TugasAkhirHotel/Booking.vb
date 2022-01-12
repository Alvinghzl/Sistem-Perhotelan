Public Class Booking
    Private Sub TambahKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKamarToolStripMenuItem.Click
        Dim tambahjenis = New tambah_jeniskamar()
        tambahjenis.Show()
    End Sub

    Private Sub JenisKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisKamarToolStripMenuItem.Click
        Dim tojeniskamar = New jeniskamar()
        tojeniskamar.Show()
    End Sub
End Class