Public Class Booking

    Public Shared cbooked As New Booked
    Public Shared Idterpilih As Nullable(Of Integer)
    Public Shared checkinterpilih As Date
    Public Shared idkamartepilih As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub

    Private Sub TambahKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKamarToolStripMenuItem.Click
        Dim tambahjenis = New tambah_jeniskamar()
        tambahjenis.Show()

    End Sub

    Private Sub JenisKamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisKamarToolStripMenuItem.Click
        Dim tojeniskamar = New jeniskamar()
        tojeniskamar.Show()

    End Sub

    Private Sub TambahTamuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahTamuToolStripMenuItem.Click
        Dim atamu = New tambah_tamu()
        atamu.Show()

    End Sub

    Private Sub TambahKamarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TambahKamarToolStripMenuItem1.Click
        Dim kamar = New TambahKamar()
        kamar.Show()

    End Sub

    Private Sub CheckInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInToolStripMenuItem.Click
        Dim checkin = New CheckIn()
        checkin.Show()

    End Sub

    Private Sub CheckOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutToolStripMenuItem.Click
        Dim checkout = New checkout()
        checkout.Show()

    End Sub

    Private Sub TamuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamuToolStripMenuItem.Click
        Dim tampiltamu = New formtamu()

        tampiltamu.Show()
    End Sub

    Private Sub KamarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KamarToolStripMenuItem.Click
        Dim tampilkamar = New FormKamar()

        tampilkamar.Show()
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridView1.DataSource = cbooked.GetDataKoleksiDatabase()
    End Sub

    Private Sub Booking_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    Private Sub ButtonChckOut_Click(sender As Object, e As EventArgs) Handles ButtonChckOut.Click
        Dim chkout = New checkout()
        chkout.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        Idterpilih = selectedRow.Cells(0).Value
        checkinterpilih = selectedRow.Cells(3).Value
        idkamartepilih = selectedRow.Cells(2).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim logout = New signout()
        logout.Show()
        Me.Close()
    End Sub
End Class