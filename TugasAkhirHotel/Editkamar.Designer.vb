<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editkamar
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
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.ButtonPilih = New System.Windows.Forms.Button()
        Me.TextBoxKamar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxJenis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(25, 390)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(125, 39)
        Me.BtnEdit.TabIndex = 10
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'ButtonPilih
        '
        Me.ButtonPilih.Location = New System.Drawing.Point(320, 87)
        Me.ButtonPilih.Name = "ButtonPilih"
        Me.ButtonPilih.Size = New System.Drawing.Size(78, 32)
        Me.ButtonPilih.TabIndex = 17
        Me.ButtonPilih.Text = "Pilih"
        Me.ButtonPilih.UseVisualStyleBackColor = True
        '
        'TextBoxKamar
        '
        Me.TextBoxKamar.Location = New System.Drawing.Point(29, 173)
        Me.TextBoxKamar.Name = "TextBoxKamar"
        Me.TextBoxKamar.Size = New System.Drawing.Size(271, 26)
        Me.TextBoxKamar.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nama Kamar"
        '
        'TextBoxJenis
        '
        Me.TextBoxJenis.Enabled = False
        Me.TextBoxJenis.Location = New System.Drawing.Point(29, 88)
        Me.TextBoxJenis.Name = "TextBoxJenis"
        Me.TextBoxJenis.Size = New System.Drawing.Size(271, 26)
        Me.TextBoxJenis.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Jenis Kamar"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(547, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(507, 455)
        Me.DataGridView1.TabIndex = 11
        '
        'Editkamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 583)
        Me.Controls.Add(Me.ButtonPilih)
        Me.Controls.Add(Me.TextBoxKamar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxJenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Name = "Editkamar"
        Me.Text = "Editkamar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEdit As Button
    Friend WithEvents ButtonPilih As Button
    Friend WithEvents TextBoxKamar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxJenis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
