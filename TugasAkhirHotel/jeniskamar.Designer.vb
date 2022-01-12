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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridJenisKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridJenisKamar
        '
        Me.DataGridJenisKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJenisKamar.Location = New System.Drawing.Point(28, 128)
        Me.DataGridJenisKamar.Name = "DataGridJenisKamar"
        Me.DataGridJenisKamar.RowHeadersWidth = 62
        Me.DataGridJenisKamar.RowTemplate.Height = 28
        Me.DataGridJenisKamar.Size = New System.Drawing.Size(567, 200)
        Me.DataGridJenisKamar.TabIndex = 0
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(625, 254)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(124, 42)
        Me.BtnHapus.TabIndex = 1
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(625, 128)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(124, 42)
        Me.BtnTambah.TabIndex = 2
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(625, 192)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(124, 42)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("DM Sans", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(698, 52)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sistem Reservasi Hotel GrandHyatt"
        '
        'jeniskamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.BackgroundImage = Global.TugasAkhirHotel.My.Resources.Resources.desktop_pc_1920x1080_thumbnail_00019
        Me.ClientSize = New System.Drawing.Size(813, 451)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.DataGridJenisKamar)
        Me.Name = "jeniskamar"
        Me.Text = "jeniskamar"
        CType(Me.DataGridJenisKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridJenisKamar As DataGridView
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Label1 As Label
End Class
