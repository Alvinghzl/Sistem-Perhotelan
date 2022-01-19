<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BookigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TamuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahTamuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKamarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKamarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonChckOut = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1110, 200)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookigToolStripMenuItem, Me.TamuToolStripMenuItem, Me.KamarToolStripMenuItem, Me.JenisKamarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1171, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BookigToolStripMenuItem
        '
        Me.BookigToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckInToolStripMenuItem, Me.CheckOutToolStripMenuItem})
        Me.BookigToolStripMenuItem.Name = "BookigToolStripMenuItem"
        Me.BookigToolStripMenuItem.Size = New System.Drawing.Size(94, 29)
        Me.BookigToolStripMenuItem.Text = "Booking"
        '
        'CheckInToolStripMenuItem
        '
        Me.CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem"
        Me.CheckInToolStripMenuItem.Size = New System.Drawing.Size(196, 34)
        Me.CheckInToolStripMenuItem.Text = "Check In"
        '
        'CheckOutToolStripMenuItem
        '
        Me.CheckOutToolStripMenuItem.Name = "CheckOutToolStripMenuItem"
        Me.CheckOutToolStripMenuItem.Size = New System.Drawing.Size(196, 34)
        Me.CheckOutToolStripMenuItem.Text = "Check Out"
        '
        'TamuToolStripMenuItem
        '
        Me.TamuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahTamuToolStripMenuItem})
        Me.TamuToolStripMenuItem.Name = "TamuToolStripMenuItem"
        Me.TamuToolStripMenuItem.Size = New System.Drawing.Size(70, 29)
        Me.TamuToolStripMenuItem.Text = "Tamu"
        '
        'TambahTamuToolStripMenuItem
        '
        Me.TambahTamuToolStripMenuItem.Name = "TambahTamuToolStripMenuItem"
        Me.TambahTamuToolStripMenuItem.Size = New System.Drawing.Size(223, 34)
        Me.TambahTamuToolStripMenuItem.Text = "Tambah Tamu"
        '
        'KamarToolStripMenuItem
        '
        Me.KamarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKamarToolStripMenuItem1})
        Me.KamarToolStripMenuItem.Name = "KamarToolStripMenuItem"
        Me.KamarToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.KamarToolStripMenuItem.Text = "Kamar"
        '
        'TambahKamarToolStripMenuItem1
        '
        Me.TambahKamarToolStripMenuItem1.Name = "TambahKamarToolStripMenuItem1"
        Me.TambahKamarToolStripMenuItem1.Size = New System.Drawing.Size(231, 34)
        Me.TambahKamarToolStripMenuItem1.Text = "Tambah Kamar"
        '
        'JenisKamarToolStripMenuItem
        '
        Me.JenisKamarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKamarToolStripMenuItem})
        Me.JenisKamarToolStripMenuItem.Name = "JenisKamarToolStripMenuItem"
        Me.JenisKamarToolStripMenuItem.Size = New System.Drawing.Size(120, 29)
        Me.JenisKamarToolStripMenuItem.Text = "Jenis Kamar"
        '
        'TambahKamarToolStripMenuItem
        '
        Me.TambahKamarToolStripMenuItem.Name = "TambahKamarToolStripMenuItem"
        Me.TambahKamarToolStripMenuItem.Size = New System.Drawing.Size(273, 34)
        Me.TambahKamarToolStripMenuItem.Text = "Tambah Jenis Kamar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sistem Reservasi Hotel Grand Hyatt"
        '
        'ButtonChckOut
        '
        Me.ButtonChckOut.Location = New System.Drawing.Point(1011, 256)
        Me.ButtonChckOut.Name = "ButtonChckOut"
        Me.ButtonChckOut.Size = New System.Drawing.Size(111, 40)
        Me.ButtonChckOut.TabIndex = 3
        Me.ButtonChckOut.Text = "Check Out"
        Me.ButtonChckOut.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Brown
        Me.Button1.Location = New System.Drawing.Point(1025, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TugasAkhirHotel.My.Resources.Resources.desktop_pc_1920x1080_thumbnail_00019
        Me.ClientSize = New System.Drawing.Size(1171, 442)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonChckOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Booking"
        Me.Text = "Booking"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BookigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TamuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahTamuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKamarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents JenisKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKamarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonChckOut As Button
    Friend WithEvents Button1 As Button
    'Friend WithEvents PictureBox1 As PictureBox
End Class
