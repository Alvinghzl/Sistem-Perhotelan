Public Class jeniskamar

    Public Shared JnsKmr As Jenis_kamar
    Public Shared IdKamar As Integer
    Public Shared JenisKamar As String
    Public Shared Harga As Integer

    Public Shared idterpilih As Nullable(Of Integer)
    Public Shared namaterpilih As String

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah = New tambah_jeniskamar
        tambah.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If idterpilih.HasValue Then
            JnsKmr.DeleteDataKoleksiByIDDatabase(idterpilih)
        End If

        ReloadDataTableDatabase()
        Dim hapus = New HapusItem()
        hapus.Show()
    End Sub

    Private Sub DataGridJenisKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJenisKamar.CellClick

        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridJenisKamar.Rows(index)

        idterpilih = selectedRow.Cells(0).Value
        namaterpilih = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selecteditem As List(Of String) = JnsKmr.GetDataKoleksiByIDDatabase(idterpilih)

        JnsKmr.GSJenisKamar = selecteditem(1)
        JnsKmr.GSHarga = selecteditem(2)

        Dim update = New UpdateItem()
        update.Show()
        Me.Close()
    End Sub
End Class