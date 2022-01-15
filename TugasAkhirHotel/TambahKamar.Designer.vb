<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKamar
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxJenisKamar = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaKamar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.ButtonPilih = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(549, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(507, 455)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jenis Kamar"
        '
        'TextBoxJenisKamar
        '
        Me.TextBoxJenisKamar.Enabled = False
        Me.TextBoxJenisKamar.Location = New System.Drawing.Point(31, 86)
        Me.TextBoxJenisKamar.Name = "TextBoxJenisKamar"
        Me.TextBoxJenisKamar.Size = New System.Drawing.Size(271, 26)
        Me.TextBoxJenisKamar.TabIndex = 2
        '
        'TextBoxNamaKamar
        '
        Me.TextBoxNamaKamar.Location = New System.Drawing.Point(31, 171)
        Me.TextBoxNamaKamar.Name = "TextBoxNamaKamar"
        Me.TextBoxNamaKamar.Size = New System.Drawing.Size(271, 26)
        Me.TextBoxNamaKamar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Kamar"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(31, 423)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(125, 39)
        Me.BtnTambah.TabIndex = 5
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'ButtonPilih
        '
        Me.ButtonPilih.Location = New System.Drawing.Point(322, 85)
        Me.ButtonPilih.Name = "ButtonPilih"
        Me.ButtonPilih.Size = New System.Drawing.Size(78, 32)
        Me.ButtonPilih.TabIndex = 6
        Me.ButtonPilih.Text = "Pilih"
        Me.ButtonPilih.UseVisualStyleBackColor = True
        '
        'TambahKamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 496)
        Me.Controls.Add(Me.ButtonPilih)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TextBoxNamaKamar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxJenisKamar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TambahKamar"
        Me.Text = "TambahKamar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxJenisKamar As TextBox
    Friend WithEvents TextBoxNamaKamar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents ButtonPilih As Button
End Class
