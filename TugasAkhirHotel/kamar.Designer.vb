<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kamar
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
        Me.DataGridKamar = New System.Windows.Forms.DataGridView()
        Me.tambah = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        CType(Me.DataGridKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridKamar
        '
        Me.DataGridKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKamar.Location = New System.Drawing.Point(59, 82)
        Me.DataGridKamar.Name = "DataGridKamar"
        Me.DataGridKamar.RowHeadersWidth = 62
        Me.DataGridKamar.RowTemplate.Height = 28
        Me.DataGridKamar.Size = New System.Drawing.Size(516, 200)
        Me.DataGridKamar.TabIndex = 1
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(59, 304)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(134, 64)
        Me.tambah.TabIndex = 2
        Me.tambah.Text = "Tambah"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(223, 304)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(134, 64)
        Me.hapus.TabIndex = 3
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 428)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.DataGridKamar)
        Me.Name = "kamar"
        Me.Text = "kamar"
        CType(Me.DataGridKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridKamar As DataGridView
    Friend WithEvents tambah As Button
    Friend WithEvents hapus As Button
End Class
