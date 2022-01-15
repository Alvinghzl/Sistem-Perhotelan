<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edittamu
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
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBoxAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNIK = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(407, 370)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(124, 42)
        Me.BtnEdit.TabIndex = 17
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"Laki Laki", "Perempuan"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(247, 291)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(280, 28)
        Me.ComboBoxGender.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Jenis Kelamin"
        '
        'RichTextBoxAlamat
        '
        Me.RichTextBoxAlamat.Location = New System.Drawing.Point(247, 147)
        Me.RichTextBoxAlamat.Name = "RichTextBoxAlamat"
        Me.RichTextBoxAlamat.Size = New System.Drawing.Size(283, 123)
        Me.RichTextBoxAlamat.TabIndex = 14
        Me.RichTextBoxAlamat.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Alamat"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(248, 88)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(283, 26)
        Me.TextBoxNama.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama Lengkap"
        '
        'TextBoxNIK
        '
        Me.TextBoxNIK.Location = New System.Drawing.Point(248, 36)
        Me.TextBoxNIK.Name = "TextBoxNIK"
        Me.TextBoxNIK.Size = New System.Drawing.Size(283, 26)
        Me.TextBoxNIK.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NIK / Number Pasport"
        '
        'edittamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 450)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBoxAlamat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNIK)
        Me.Controls.Add(Me.Label1)
        Me.Name = "edittamu"
        Me.Text = "edittamu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEdit As Button
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBoxAlamat As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNIK As TextBox
    Friend WithEvents Label1 As Label
End Class
