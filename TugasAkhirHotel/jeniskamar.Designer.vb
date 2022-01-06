<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jeniskamar
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
        Me.DataGridJenisKamar = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridJenisKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridJenisKamar
        '
        Me.DataGridJenisKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJenisKamar.Location = New System.Drawing.Point(50, 103)
        Me.DataGridJenisKamar.Name = "DataGridJenisKamar"
        Me.DataGridJenisKamar.RowHeadersWidth = 62
        Me.DataGridJenisKamar.RowTemplate.Height = 28
        Me.DataGridJenisKamar.Size = New System.Drawing.Size(516, 200)
        Me.DataGridJenisKamar.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(312, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 42)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'jeniskamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 395)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridJenisKamar)
        Me.Name = "jeniskamar"
        Me.Text = "jeniskamar"
        CType(Me.DataGridJenisKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridJenisKamar As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
