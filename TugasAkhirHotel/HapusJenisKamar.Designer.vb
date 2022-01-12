<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJenisKamar
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblDihapus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DM Sans", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda ingin menghapus jenis kamar ini?"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(205, 287)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(153, 39)
        Me.BtnHapus.TabIndex = 1
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblDihapus
        '
        Me.LblDihapus.AutoSize = True
        Me.LblDihapus.Font = New System.Drawing.Font("Bebas Neue", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDihapus.ForeColor = System.Drawing.Color.Red
        Me.LblDihapus.Location = New System.Drawing.Point(169, 174)
        Me.LblDihapus.Name = "LblDihapus"
        Me.LblDihapus.Size = New System.Drawing.Size(232, 62)
        Me.LblDihapus.TabIndex = 2
        Me.LblDihapus.Text = "Jenis Kamar"
        '
        'HapusJenisKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 450)
        Me.Controls.Add(Me.LblDihapus)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusJenisKamar"
        Me.Text = "HapusJenisKamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblDihapus As Label
End Class
