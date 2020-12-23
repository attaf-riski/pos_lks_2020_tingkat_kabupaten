<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class retur_pembelian
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
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.idBarangComboBox = New System.Windows.Forms.ComboBox()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.bersihButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.kembalikanTextBox = New System.Windows.Forms.TextBox()
        Me.dibayarTextBox = New System.Windows.Forms.TextBox()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.jumlahBarangDikembalikanTextBox = New System.Windows.Forms.TextBox()
        Me.jumlahDibeliTextBox = New System.Windows.Forms.TextBox()
        Me.namaBarangTextBox = New System.Windows.Forms.TextBox()
        Me.namaPemasokTextBox = New System.Windows.Forms.TextBox()
        Me.namaTextBox = New System.Windows.Forms.TextBox()
        Me.tanggalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.daftarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.akanDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.idPemasokTB = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.idUserTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.noPembelianTextBox = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.contentPanel.SuspendLayout()
        CType(Me.daftarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.akanDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1225, 67)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "RETUR PEMBELIAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.contentPanel.Controls.Add(Me.idBarangComboBox)
        Me.contentPanel.Controls.Add(Me.hapusButton)
        Me.contentPanel.Controls.Add(Me.bersihButton)
        Me.contentPanel.Controls.Add(Me.simpanButton)
        Me.contentPanel.Controls.Add(Me.tambahButton)
        Me.contentPanel.Controls.Add(Me.kembalikanTextBox)
        Me.contentPanel.Controls.Add(Me.dibayarTextBox)
        Me.contentPanel.Controls.Add(Me.totalTextBox)
        Me.contentPanel.Controls.Add(Me.jumlahBarangDikembalikanTextBox)
        Me.contentPanel.Controls.Add(Me.jumlahDibeliTextBox)
        Me.contentPanel.Controls.Add(Me.namaBarangTextBox)
        Me.contentPanel.Controls.Add(Me.namaPemasokTextBox)
        Me.contentPanel.Controls.Add(Me.namaTextBox)
        Me.contentPanel.Controls.Add(Me.tanggalDateTimePicker)
        Me.contentPanel.Controls.Add(Me.daftarDataGridView)
        Me.contentPanel.Controls.Add(Me.akanDGV)
        Me.contentPanel.Controls.Add(Me.Label3)
        Me.contentPanel.Controls.Add(Me.Label8)
        Me.contentPanel.Controls.Add(Me.Label18)
        Me.contentPanel.Controls.Add(Me.idPemasokTB)
        Me.contentPanel.Controls.Add(Me.Label17)
        Me.contentPanel.Controls.Add(Me.Label7)
        Me.contentPanel.Controls.Add(Me.Label15)
        Me.contentPanel.Controls.Add(Me.Label6)
        Me.contentPanel.Controls.Add(Me.Label21)
        Me.contentPanel.Controls.Add(Me.Label14)
        Me.contentPanel.Controls.Add(Me.Label13)
        Me.contentPanel.Controls.Add(Me.Label11)
        Me.contentPanel.Controls.Add(Me.idUserTextBox)
        Me.contentPanel.Controls.Add(Me.Label5)
        Me.contentPanel.Controls.Add(Me.noPembelianTextBox)
        Me.contentPanel.Controls.Add(Me.Label20)
        Me.contentPanel.Controls.Add(Me.idTextBox)
        Me.contentPanel.Controls.Add(Me.Label16)
        Me.contentPanel.Controls.Add(Me.Label12)
        Me.contentPanel.Controls.Add(Me.Label19)
        Me.contentPanel.Controls.Add(Me.Label10)
        Me.contentPanel.Controls.Add(Me.Label4)
        Me.contentPanel.Controls.Add(Me.Label9)
        Me.contentPanel.Controls.Add(Me.Label2)
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(5, 72)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1225, 641)
        Me.contentPanel.TabIndex = 7
        '
        'idBarangComboBox
        '
        Me.idBarangComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idBarangComboBox.FormattingEnabled = True
        Me.idBarangComboBox.Items.AddRange(New Object() {"ID Barang", "Nama Barang", "Kategori"})
        Me.idBarangComboBox.Location = New System.Drawing.Point(951, 119)
        Me.idBarangComboBox.Name = "idBarangComboBox"
        Me.idBarangComboBox.Size = New System.Drawing.Size(203, 24)
        Me.idBarangComboBox.TabIndex = 15
        '
        'hapusButton
        '
        Me.hapusButton.BackColor = System.Drawing.Color.Red
        Me.hapusButton.FlatAppearance.BorderSize = 0
        Me.hapusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapusButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.hapusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.hapusButton.Location = New System.Drawing.Point(1070, 537)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(84, 47)
        Me.hapusButton.TabIndex = 13
        Me.hapusButton.Text = "Hapus"
        Me.hapusButton.UseVisualStyleBackColor = False
        '
        'bersihButton
        '
        Me.bersihButton.BackColor = System.Drawing.Color.OrangeRed
        Me.bersihButton.FlatAppearance.BorderSize = 0
        Me.bersihButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bersihButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.bersihButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bersihButton.Location = New System.Drawing.Point(1070, 298)
        Me.bersihButton.Name = "bersihButton"
        Me.bersihButton.Size = New System.Drawing.Size(84, 38)
        Me.bersihButton.TabIndex = 13
        Me.bersihButton.Text = "Hapus"
        Me.bersihButton.UseVisualStyleBackColor = False
        '
        'simpanButton
        '
        Me.simpanButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.simpanButton.FlatAppearance.BorderSize = 0
        Me.simpanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.simpanButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.simpanButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.simpanButton.Location = New System.Drawing.Point(951, 538)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(84, 47)
        Me.simpanButton.TabIndex = 14
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = False
        '
        'tambahButton
        '
        Me.tambahButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.tambahButton.FlatAppearance.BorderSize = 0
        Me.tambahButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tambahButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.tambahButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tambahButton.Location = New System.Drawing.Point(951, 298)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(97, 38)
        Me.tambahButton.TabIndex = 14
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.UseVisualStyleBackColor = False
        '
        'kembalikanTextBox
        '
        Me.kembalikanTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.kembalikanTextBox.Location = New System.Drawing.Point(951, 494)
        Me.kembalikanTextBox.MaxLength = 50
        Me.kembalikanTextBox.Name = "kembalikanTextBox"
        Me.kembalikanTextBox.ReadOnly = True
        Me.kembalikanTextBox.Size = New System.Drawing.Size(203, 24)
        Me.kembalikanTextBox.TabIndex = 12
        '
        'dibayarTextBox
        '
        Me.dibayarTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.dibayarTextBox.Location = New System.Drawing.Point(951, 445)
        Me.dibayarTextBox.MaxLength = 50
        Me.dibayarTextBox.Name = "dibayarTextBox"
        Me.dibayarTextBox.Size = New System.Drawing.Size(203, 24)
        Me.dibayarTextBox.TabIndex = 12
        '
        'totalTextBox
        '
        Me.totalTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.totalTextBox.Location = New System.Drawing.Point(951, 398)
        Me.totalTextBox.MaxLength = 50
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(203, 24)
        Me.totalTextBox.TabIndex = 12
        '
        'jumlahBarangDikembalikanTextBox
        '
        Me.jumlahBarangDikembalikanTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.jumlahBarangDikembalikanTextBox.Location = New System.Drawing.Point(951, 268)
        Me.jumlahBarangDikembalikanTextBox.MaxLength = 50
        Me.jumlahBarangDikembalikanTextBox.Name = "jumlahBarangDikembalikanTextBox"
        Me.jumlahBarangDikembalikanTextBox.Size = New System.Drawing.Size(203, 24)
        Me.jumlahBarangDikembalikanTextBox.TabIndex = 12
        '
        'jumlahDibeliTextBox
        '
        Me.jumlahDibeliTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.jumlahDibeliTextBox.Location = New System.Drawing.Point(951, 219)
        Me.jumlahDibeliTextBox.MaxLength = 50
        Me.jumlahDibeliTextBox.Name = "jumlahDibeliTextBox"
        Me.jumlahDibeliTextBox.ReadOnly = True
        Me.jumlahDibeliTextBox.Size = New System.Drawing.Size(203, 24)
        Me.jumlahDibeliTextBox.TabIndex = 12
        '
        'namaBarangTextBox
        '
        Me.namaBarangTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.namaBarangTextBox.Location = New System.Drawing.Point(951, 169)
        Me.namaBarangTextBox.MaxLength = 50
        Me.namaBarangTextBox.Name = "namaBarangTextBox"
        Me.namaBarangTextBox.ReadOnly = True
        Me.namaBarangTextBox.Size = New System.Drawing.Size(203, 24)
        Me.namaBarangTextBox.TabIndex = 12
        '
        'namaPemasokTextBox
        '
        Me.namaPemasokTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.namaPemasokTextBox.Location = New System.Drawing.Point(644, 119)
        Me.namaPemasokTextBox.MaxLength = 50
        Me.namaPemasokTextBox.Name = "namaPemasokTextBox"
        Me.namaPemasokTextBox.Size = New System.Drawing.Size(269, 24)
        Me.namaPemasokTextBox.TabIndex = 12
        '
        'namaTextBox
        '
        Me.namaTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.namaTextBox.Location = New System.Drawing.Point(357, 116)
        Me.namaTextBox.MaxLength = 50
        Me.namaTextBox.Name = "namaTextBox"
        Me.namaTextBox.ReadOnly = True
        Me.namaTextBox.Size = New System.Drawing.Size(242, 24)
        Me.namaTextBox.TabIndex = 12
        '
        'tanggalDateTimePicker
        '
        Me.tanggalDateTimePicker.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.tanggalDateTimePicker.Location = New System.Drawing.Point(50, 116)
        Me.tanggalDateTimePicker.Name = "tanggalDateTimePicker"
        Me.tanggalDateTimePicker.Size = New System.Drawing.Size(254, 24)
        Me.tanggalDateTimePicker.TabIndex = 11
        '
        'daftarDataGridView
        '
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.Lavender
        Me.daftarDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle41
        Me.daftarDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Verdana", 10.0!)
        DataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.daftarDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle42
        Me.daftarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.daftarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.daftarDataGridView.Location = New System.Drawing.Point(47, 378)
        Me.daftarDataGridView.Name = "daftarDataGridView"
        Me.daftarDataGridView.ReadOnly = True
        Me.daftarDataGridView.RowHeadersVisible = False
        Me.daftarDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.daftarDataGridView.RowTemplate.ReadOnly = True
        Me.daftarDataGridView.Size = New System.Drawing.Size(863, 206)
        Me.daftarDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID Barang"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 300
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Kategori"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 300
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Harga Barang"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 300
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Jumlah Beli"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 300
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Total Harga"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 300
        '
        'akanDGV
        '
        DataGridViewCellStyle43.BackColor = System.Drawing.Color.Lavender
        Me.akanDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle43
        Me.akanDGV.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Verdana", 10.0!)
        DataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.akanDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle44
        Me.akanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.akanDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.Column6, Me.Column7})
        Me.akanDGV.Location = New System.Drawing.Point(50, 169)
        Me.akanDGV.Name = "akanDGV"
        Me.akanDGV.ReadOnly = True
        Me.akanDGV.RowHeadersVisible = False
        Me.akanDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.akanDGV.RowTemplate.ReadOnly = True
        Me.akanDGV.Size = New System.Drawing.Size(863, 167)
        Me.akanDGV.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Barang"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 300
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kategori"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Harga Barang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'Column6
        '
        Me.Column6.HeaderText = "Jumlah Beli"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 300
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total Harga"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 300
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(47, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tanggal Retur Pembelian"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(641, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nama Pemasok"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(948, 474)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 17)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Kembalian"
        '
        'idPemasokTB
        '
        Me.idPemasokTB.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idPemasokTB.Location = New System.Drawing.Point(644, 64)
        Me.idPemasokTB.MaxLength = 10
        Me.idPemasokTB.Name = "idPemasokTB"
        Me.idPemasokTB.Size = New System.Drawing.Size(269, 24)
        Me.idPemasokTB.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(948, 425)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Dibayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(641, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ID Pemasok"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(948, 378)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 17)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Total Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(354, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nama user"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(939, 248)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(231, 17)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Jumlah Barang Dikembalikan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(948, 199)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Jumlah Barang Dibeli"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(948, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 17)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Nama Barang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(948, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "ID Barang"
        '
        'idUserTextBox
        '
        Me.idUserTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idUserTextBox.Location = New System.Drawing.Point(357, 61)
        Me.idUserTextBox.MaxLength = 10
        Me.idUserTextBox.Name = "idUserTextBox"
        Me.idUserTextBox.ReadOnly = True
        Me.idUserTextBox.Size = New System.Drawing.Size(242, 24)
        Me.idUserTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(354, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID User"
        '
        'noPembelianTextBox
        '
        Me.noPembelianTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.noPembelianTextBox.Location = New System.Drawing.Point(951, 64)
        Me.noPembelianTextBox.MaxLength = 10
        Me.noPembelianTextBox.Name = "noPembelianTextBox"
        Me.noPembelianTextBox.Size = New System.Drawing.Size(203, 24)
        Me.noPembelianTextBox.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(1799, 338)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 18)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Pembayaran"
        '
        'idTextBox
        '
        Me.idTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idTextBox.Location = New System.Drawing.Point(50, 60)
        Me.idTextBox.MaxLength = 10
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.ReadOnly = True
        Me.idTextBox.Size = New System.Drawing.Size(254, 24)
        Me.idTextBox.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(916, 360)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 18)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Pengembalian Dana"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(928, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 18)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Input Barang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(948, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 17)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "No Pembelian"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(7, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Akan Dikembalikan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(47, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No Retur Pembelian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(4, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Daftar Barang Dibeli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Input Data"
        '
        'retur_pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1235, 718)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "retur_pembelian"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "retur_pembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.contentPanel.ResumeLayout(False)
        Me.contentPanel.PerformLayout()
        CType(Me.daftarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.akanDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents contentPanel As Panel
    Friend WithEvents idBarangComboBox As ComboBox
    Friend WithEvents hapusButton As Button
    Friend WithEvents bersihButton As Button
    Friend WithEvents simpanButton As Button
    Friend WithEvents tambahButton As Button
    Friend WithEvents kembalikanTextBox As TextBox
    Friend WithEvents dibayarTextBox As TextBox
    Friend WithEvents totalTextBox As TextBox
    Friend WithEvents jumlahBarangDikembalikanTextBox As TextBox
    Friend WithEvents jumlahDibeliTextBox As TextBox
    Friend WithEvents namaBarangTextBox As TextBox
    Friend WithEvents namaPemasokTextBox As TextBox
    Friend WithEvents namaTextBox As TextBox
    Friend WithEvents tanggalDateTimePicker As DateTimePicker
    Friend WithEvents daftarDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents akanDGV As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents idPemasokTB As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents idUserTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents noPembelianTextBox As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
End Class
