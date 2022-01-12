<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_kamar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idkamar = New System.Windows.Forms.TextBox()
        Me.idjeniskamar = New System.Windows.Forms.TextBox()
        Me.namakamarr = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.tmbah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Kamar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Jenis Kamar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'idkamar
        '
        Me.idkamar.Location = New System.Drawing.Point(262, 52)
        Me.idkamar.Name = "idkamar"
        Me.idkamar.Size = New System.Drawing.Size(205, 26)
        Me.idkamar.TabIndex = 4
        '
        'idjeniskamar
        '
        Me.idjeniskamar.Location = New System.Drawing.Point(262, 127)
        Me.idjeniskamar.Name = "idjeniskamar"
        Me.idjeniskamar.Size = New System.Drawing.Size(205, 26)
        Me.idjeniskamar.TabIndex = 5
        '
        'namakamarr
        '
        Me.namakamarr.Location = New System.Drawing.Point(262, 199)
        Me.namakamarr.Name = "namakamarr"
        Me.namakamarr.Size = New System.Drawing.Size(205, 26)
        Me.namakamarr.TabIndex = 6
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"Booked", "Available"})
        Me.status.Location = New System.Drawing.Point(262, 268)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(205, 28)
        Me.status.TabIndex = 7
        '
        'tmbah
        '
        Me.tmbah.Location = New System.Drawing.Point(262, 339)
        Me.tmbah.Name = "tmbah"
        Me.tmbah.Size = New System.Drawing.Size(205, 47)
        Me.tmbah.TabIndex = 8
        Me.tmbah.Text = "Tambah"
        Me.tmbah.UseVisualStyleBackColor = True
        '
        'tambah_kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tmbah)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.namakamarr)
        Me.Controls.Add(Me.idjeniskamar)
        Me.Controls.Add(Me.idkamar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tambah_kamar"
        Me.Text = "tambah_kamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents idkamar As TextBox
    Friend WithEvents idjeniskamar As TextBox
    Friend WithEvents namakamarr As TextBox
    Friend WithEvents status As ComboBox
    Friend WithEvents tmbah As Button
End Class
