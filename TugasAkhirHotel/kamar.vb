Public Class kamar

    Public Shared kamarr As kamar
    Public Shared IdKamarr As Integer
    Public Shared idjenisKamar As Integer
    Public Shadows namakamar As String
    Public Shared statuss As String
    Public Property GSIdKamar As Integer
    Public Property GSidjeniskamar As Integer
    Public Property GSnamakamar As String
    Public Property GSstatus As String

    Public Sub New()

        kamarr = New kamar()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()

    End Sub

    Private Sub kamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated


        ReloadDataTableDatabase()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKamar.DataSource = kamarr.GetDataKoleksiDatabase()
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        Dim tambah = New tambah_kamar
        tambah.Show()
    End Sub
End Class