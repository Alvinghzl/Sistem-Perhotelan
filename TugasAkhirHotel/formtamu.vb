Public Class formtamu

    Public Shared tamu As New Classtamu
    Public Shared Idtamu As Integer
    Public Shared Nik As Integer
    Public Shared namatamu As String
    Public Shared alamat As String
    Public Shared jenis_kelamin As String

    Public Shared idterpilih As Nullable(Of Integer)
    Public Shared namaterpilih As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
        'tamu = New Classtamu()

    End Sub

    Private Sub tamu_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = tamu.GetDataKoleksiDatabase()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim tambah = New tambah_tamu()
        tambah.Show()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click


        ReloadDataTableDatabase()
        Dim hapus = New hapustamu()
        hapus.Show()
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim selecteditem As List(Of String) = tamu.GetDataKoleksiByIDDatabase(idterpilih)

        tamu.GSNik = selecteditem(1)
        tamu.GSNama = selecteditem(2)
        tamu.GSAlamat = selecteditem(3)
        tamu.GSJenisKelamin = selecteditem(4)


        Dim update = New edittamu()
        update.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        idterpilih = selectedRow.Cells(0).Value
        namaterpilih = selectedRow.Cells(1).Value
    End Sub
End Class