﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TextBoxNamaKamar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxJenisKamar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'TextBoxNamaKamar
        '
        Me.TextBoxNamaKamar.Location = New System.Drawing.Point(25, 138)
        Me.TextBoxNamaKamar.Name = "TextBoxNamaKamar"
        Me.TextBoxNamaKamar.Size = New System.Drawing.Size(271, 26)
        Me.TextBoxNamaKamar.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama Kamar"
        '
        'TextBoxJenisKamar
        '
        Me.TextBoxJenisKamar.Location = New System.Drawing.Point(25, 53)
        Me.TextBoxJenisKamar.Name = "TextBoxJenisKamar"
        Me.TextBoxJenisKamar.Size = New System.Drawing.Size(271, 26)
        Me.TextBoxJenisKamar.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Jenis Kamar"
        '
        'Editkamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 450)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.TextBoxNamaKamar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxJenisKamar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Editkamar"
        Me.Text = "Editkamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEdit As Button
    Friend WithEvents TextBoxNamaKamar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxJenisKamar As TextBox
    Friend WithEvents Label1 As Label
End Class
