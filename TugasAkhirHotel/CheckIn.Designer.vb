<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckIn
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewtamu = New System.Windows.Forms.DataGridView()
        Me.DataGridViewkamar = New System.Windows.Forms.DataGridView()
        Me.Buttonkamar = New System.Windows.Forms.Button()
        Me.TextBoxKamar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Buttontamu = New System.Windows.Forms.Button()
        Me.TextBoxtamu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewtamu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewkamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DM Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Check In"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(207, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(283, 26)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal Check In"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(937, 520)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Check In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewtamu
        '
        Me.DataGridViewtamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewtamu.Location = New System.Drawing.Point(29, 219)
        Me.DataGridViewtamu.Name = "DataGridViewtamu"
        Me.DataGridViewtamu.RowHeadersWidth = 62
        Me.DataGridViewtamu.RowTemplate.Height = 28
        Me.DataGridViewtamu.Size = New System.Drawing.Size(510, 263)
        Me.DataGridViewtamu.TabIndex = 11
        '
        'DataGridViewkamar
        '
        Me.DataGridViewkamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewkamar.Location = New System.Drawing.Point(555, 219)
        Me.DataGridViewkamar.Name = "DataGridViewkamar"
        Me.DataGridViewkamar.RowHeadersWidth = 62
        Me.DataGridViewkamar.RowTemplate.Height = 28
        Me.DataGridViewkamar.Size = New System.Drawing.Size(526, 263)
        Me.DataGridViewkamar.TabIndex = 13
        '
        'Buttonkamar
        '
        Me.Buttonkamar.Location = New System.Drawing.Point(846, 160)
        Me.Buttonkamar.Name = "Buttonkamar"
        Me.Buttonkamar.Size = New System.Drawing.Size(78, 32)
        Me.Buttonkamar.TabIndex = 16
        Me.Buttonkamar.Text = "Pilih"
        Me.Buttonkamar.UseVisualStyleBackColor = True
        '
        'TextBoxKamar
        '
        Me.TextBoxKamar.Enabled = False
        Me.TextBoxKamar.Location = New System.Drawing.Point(555, 161)
        Me.TextBoxKamar.Name = "TextBoxKamar"
        Me.TextBoxKamar.Size = New System.Drawing.Size(271, 26)
        Me.TextBoxKamar.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Kamar"
        '
        'Buttontamu
        '
        Me.Buttontamu.Location = New System.Drawing.Point(320, 160)
        Me.Buttontamu.Name = "Buttontamu"
        Me.Buttontamu.Size = New System.Drawing.Size(78, 32)
        Me.Buttontamu.TabIndex = 19
        Me.Buttontamu.Text = "Pilih"
        Me.Buttontamu.UseVisualStyleBackColor = True
        '
        'TextBoxtamu
        '
        Me.TextBoxtamu.Enabled = False
        Me.TextBoxtamu.Location = New System.Drawing.Point(29, 161)
        Me.TextBoxtamu.Name = "TextBoxtamu"
        Me.TextBoxtamu.Size = New System.Drawing.Size(271, 26)
        Me.TextBoxtamu.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tamu"
        '
        'CheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 579)
        Me.Controls.Add(Me.Buttontamu)
        Me.Controls.Add(Me.TextBoxtamu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Buttonkamar)
        Me.Controls.Add(Me.TextBoxKamar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewkamar)
        Me.Controls.Add(Me.DataGridViewtamu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CheckIn"
        Me.Text = "CheckIn"
        CType(Me.DataGridViewtamu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewkamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewtamu As DataGridView
    Friend WithEvents DataGridViewkamar As DataGridView
    Friend WithEvents Buttonkamar As Button
    Friend WithEvents TextBoxKamar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Buttontamu As Button
    Friend WithEvents TextBoxtamu As TextBox
    Friend WithEvents Label4 As Label
End Class
