Public Class checkout

    Private hargapermalam As Integer
    Private tagihan As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        hargapermalam = Booking.cbooked.GetDatahargaDatabase(Booking.idkamartepilih)


        ngitung()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ngitung()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkout = DateTimePicker1.Value
        Booking.cbooked.checkoutDataKoleksiByIDDatabase(Booking.Idterpilih,
                                        checkout, tagihan
                                                        )

        Booking.cbooked.updatekamar(Booking.idkamartepilih, "Kosong")

    End Sub

    Public Function ngitung()
        Dim checkout = DateTimePicker1.Value

        Dim hari = checkout - Booking.checkinterpilih
        tagihan = hari.Days * hargapermalam
        Labelharga.Text = tagihan

    End Function



End Class