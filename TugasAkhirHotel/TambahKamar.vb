Public Class TambahKamar

    Public Shared JnsKmr As Jenis_kamar
    'Public Shared IdKamar As Integer
    'Public Shared JenisKamar As String
    'Public Shared NamaKamar As String

    Public Shared idterpilih As Nullable(Of Integer)
    Public Shared namaterpilih As String


    Public Sub New()

        JnsKmr = New Jenis_kamar()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ReloadDataTableDatabase()

    End Sub


    Private Sub TambahKamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        ReloadDataTableDatabase()

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = JnsKmr.GetDataKoleksiDatabase()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        idterpilih = selectedRow.Cells(0).Value
        namaterpilih = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        FormKamar.kmr.gsIDjenisKamar = idterpilih
        FormKamar.kmr.gsNamaKamar = TextBoxNamaKamar.Text
        FormKamar.kmr.gsStatus = "Kosong"


        FormKamar.kmr.AdddataKoleksiDatabase(FormKamar.kmr.gsIDjenisKamar,
                                             FormKamar.kmr.gsNamaKamar,
                                             FormKamar.kmr.gsStatus
                                             )
        Me.Close()
    End Sub

    Private Sub ButtonPilih_Click(sender As Object, e As EventArgs) Handles ButtonPilih.Click

        TextBoxJenisKamar.Text = namaterpilih

    End Sub
End Class