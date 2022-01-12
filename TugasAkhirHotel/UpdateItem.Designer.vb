<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateItem
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtBoxHargaKamar = New System.Windows.Forms.TextBox()
        Me.TxtBoxJenisKamar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(392, 188)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(120, 40)
        Me.BtnTambah.TabIndex = 11
        Me.BtnTambah.Text = "Update"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtBoxHargaKamar
        '
        Me.TxtBoxHargaKamar.Location = New System.Drawing.Point(210, 135)
        Me.TxtBoxHargaKamar.Name = "TxtBoxHargaKamar"
        Me.TxtBoxHargaKamar.Size = New System.Drawing.Size(302, 26)
        Me.TxtBoxHargaKamar.TabIndex = 10
        '
        'TxtBoxJenisKamar
        '
        Me.TxtBoxJenisKamar.Location = New System.Drawing.Point(210, 90)
        Me.TxtBoxJenisKamar.Name = "TxtBoxJenisKamar"
        Me.TxtBoxJenisKamar.Size = New System.Drawing.Size(302, 26)
        Me.TxtBoxJenisKamar.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Harga Permalam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Jenis Kamar"
        '
        'UpdateItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 300)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtBoxHargaKamar)
        Me.Controls.Add(Me.TxtBoxJenisKamar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateItem"
        Me.Text = "UpdateItem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxtBoxHargaKamar As TextBox
    Friend WithEvents TxtBoxJenisKamar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
