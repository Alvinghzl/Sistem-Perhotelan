<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hapustamu
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
        Me.LblHapus = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblHapus
        '
        Me.LblHapus.AutoSize = True
        Me.LblHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapus.Location = New System.Drawing.Point(168, 142)
        Me.LblHapus.Name = "LblHapus"
        Me.LblHapus.Size = New System.Drawing.Size(158, 52)
        Me.LblHapus.TabIndex = 5
        Me.LblHapus.Text = "Label2"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(177, 263)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(149, 48)
        Me.BtnHapus.TabIndex = 4
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah yakin menghapus tamu dari list?"
        '
        'hapustamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 423)
        Me.Controls.Add(Me.LblHapus)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "hapustamu"
        Me.Text = "hapustamu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHapus As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Label1 As Label
End Class
