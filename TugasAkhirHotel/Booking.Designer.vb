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
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tamu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_kamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_tamu, Me.id_kamar, Me.check_in, Me.check_out, Me.total_bayar, Me.status})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 94)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1060, 243)
        Me.DataGridView1.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.Width = 150
        '
        'id_tamu
        '
        Me.id_tamu.HeaderText = "ID Tamu"
        Me.id_tamu.MinimumWidth = 8
        Me.id_tamu.Name = "id_tamu"
        Me.id_tamu.Width = 150
        '
        'id_kamar
        '
        Me.id_kamar.HeaderText = "ID Kamar"
        Me.id_kamar.MinimumWidth = 8
        Me.id_kamar.Name = "id_kamar"
        Me.id_kamar.Width = 150
        '
        'check_in
        '
        Me.check_in.HeaderText = "Check In"
        Me.check_in.MinimumWidth = 8
        Me.check_in.Name = "check_in"
        Me.check_in.Width = 150
        '
        'check_out
        '
        Me.check_out.HeaderText = "Check Out"
        Me.check_out.MinimumWidth = 8
        Me.check_out.Name = "check_out"
        Me.check_out.Width = 150
        '
        'total_bayar
        '
        Me.total_bayar.HeaderText = "Total Bayar"
        Me.total_bayar.MinimumWidth = 8
        Me.total_bayar.Name = "total_bayar"
        Me.total_bayar.Width = 150
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 8
        Me.status.Name = "status"
        Me.status.Width = 150
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookigToolStripMenuItem, Me.TamuToolStripMenuItem, Me.KamarToolStripMenuItem, Me.JenisKamarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1096, 33)
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
        Me.TambahTamuToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
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
        Me.TambahKamarToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.TambahKamarToolStripMenuItem.Text = "Tambah Kamar"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 450)
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
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents id_tamu As DataGridViewTextBoxColumn
    Friend WithEvents id_kamar As DataGridViewTextBoxColumn
    Friend WithEvents check_in As DataGridViewTextBoxColumn
    Friend WithEvents check_out As DataGridViewTextBoxColumn
    Friend WithEvents total_bayar As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
