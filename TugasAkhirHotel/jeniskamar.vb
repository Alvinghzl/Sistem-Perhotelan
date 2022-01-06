Public Class jeniskamar

    Public Shared JnsKmr As Jenis_kamar
    Public Shared IdKamar As Integer
    Public Shared JenisKamar As String
    Public Shared Harga As Integer

    Public Sub New()

        JnsKmr = New Jenis_kamar()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()

    End Sub

    Private Sub jeniskamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        ReloadDataTableDatabase()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridJenisKamar.DataSource = JnsKmr.GetDataKoleksiDatabase()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tambah = New tambah_jeniskamar
        tambah.Show()
    End Sub
End Class