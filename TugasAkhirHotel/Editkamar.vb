Public Class Editkamar

    Public Shared idterpilih As Nullable(Of Integer)
    Private idjeniskamarterpilih As Integer
    Public Shared namaterpilih As String
    Private statusterpilih As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TextBoxKamar.Text = FormKamar.kmr.gsNamaKamar
        TextBoxJenis.Text = FormKamar.namaterpilih

        ReloadDataTableDatabase()
    End Sub


    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = FormKamar.kmr.GetDataKoleksiDatabase()
    End Sub

    Private Sub Editkamar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        idterpilih = selectedRow.Cells(0).Value
        idjeniskamarterpilih = selectedRow.Cells(1).Value
        statusterpilih = selectedRow.Cells(3).Value
        namaterpilih = selectedRow.Cells(2).Value
    End Sub

    Private Sub ButtonPilih_Click(sender As Object, e As EventArgs) Handles ButtonPilih.Click

        TextBoxJenis.Text = namaterpilih

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        FormKamar.kmr.idKamar = idterpilih
        FormKamar.kmr.gsIDjenisKamar = idjeniskamarterpilih
        FormKamar.kmr.gsNamaKamar = TextBoxKamar.Text
        FormKamar.kmr.gsStatus = "Kosong"


        FormKamar.kmr.UpdateDataKoleksiByIDDatabase(FormKamar.kmr.idKamar,
                                            FormKamar.kmr.gsIDjenisKamar,
                                             FormKamar.kmr.gsNamaKamar,
                                             FormKamar.kmr.gsStatus
                                             )


        Me.Close()
    End Sub
End Class