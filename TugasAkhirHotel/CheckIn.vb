Public Class CheckIn

    Public Shared ctamu As New Classtamu
    Public Shared ckamar As New Classkamar


    Public Shared idtamuterpilih As Nullable(Of Integer)
    Public Shared namatamuterpilih As String

    Public Shared idkamarterpilih As Nullable(Of Integer)
    Public Shared namakamarterpilih As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataKamarDatabase()
        ReloadDataTamuDatabase()



    End Sub

    Private Sub ReloadDataTamuDatabase()
        DataGridViewtamu.DataSource = ctamu.GetDataKoleksiDatabase()
    End Sub

    Private Sub ReloadDataKamarDatabase()
        DataGridViewkamar.DataSource = ckamar.GetDataKoleksiDatabase()
    End Sub

    Private Sub DataGridViewtamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewtamu.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewtamu.Rows(index)

        idtamuterpilih = selectedRow.Cells(0).Value
        namatamuterpilih = selectedRow.Cells(2).Value
    End Sub

    Private Sub DataGridViewkamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewkamar.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridViewkamar.Rows(index)

        idkamarterpilih = selectedRow.Cells(0).Value
        namakamarterpilih = selectedRow.Cells(2).Value
    End Sub

    Private Sub Buttontamu_Click(sender As Object, e As EventArgs) Handles Buttontamu.Click
        TextBoxtamu.Text = namatamuterpilih
    End Sub

    Private Sub Buttonkamar_Click(sender As Object, e As EventArgs) Handles Buttonkamar.Click
        TextBoxKamar.Text = namakamarterpilih
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tanggalchkin = DateTimePicker1.Value

        Booking.cbooked.AddDataKoleksiDatabase(idtamuterpilih, idkamarterpilih, tanggalchkin)
        Booking.cbooked.updatekamar(idkamarterpilih, "Terisi")
        Me.Close()
    End Sub
End Class