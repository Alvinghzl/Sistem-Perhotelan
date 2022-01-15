Public Class FormKamar

    Public Shared kmr As Classkamar
    'Public Shared IdKamar As Integer
    'Public Shared JenisKamar As String
    'Public Shared NamaKamar As String

    Public Shared idterpilih As Nullable(Of Integer)
    Public Shared namaterpilih As String


    Public Sub New()

        kmr = New Classkamar()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = kmr.GetDataKoleksiDatabase()
    End Sub



    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim tambah = New TambahKamar()
        tambah.Show()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim selecteditem As List(Of String) = kmr.GetDataKoleksiByIDDatabase(idterpilih)

        kmr.gsIDjenisKamar = selecteditem(1)
        kmr.gsNamaKamar = selecteditem(2)


        Dim edit = New Editkamar()
        edit.Show()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        ReloadDataTableDatabase()

        Dim hapus = New HapusKamar()
        hapus.Show()
    End Sub

    Private Sub FormKamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        idterpilih = selectedRow.Cells(0).Value
        namaterpilih = selectedRow.Cells(1).Value
    End Sub
End Class