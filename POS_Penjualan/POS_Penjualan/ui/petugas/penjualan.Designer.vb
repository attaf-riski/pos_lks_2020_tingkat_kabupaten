﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class penjualan
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
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.bersihButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.tambahButton = New System.Windows.Forms.Button()
        Me.kembalianTextBox = New System.Windows.Forms.TextBox()
        Me.dibayarTextBox = New System.Windows.Forms.TextBox()
        Me.totalHargaTextBox = New System.Windows.Forms.TextBox()
        Me.jumlahTextBox = New System.Windows.Forms.TextBox()
        Me.namaBarangTextBox = New System.Windows.Forms.TextBox()
        Me.namaKonsumenTextBox = New System.Windows.Forms.TextBox()
        Me.namaUserTextBox = New System.Windows.Forms.TextBox()
        Me.tanggalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.f = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.idLonsumenTextBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.idBarangTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.idUserTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.contentPanel.SuspendLayout()
        CType(Me.f, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 67)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PENJUALAN"
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.contentPanel.Controls.Add(Me.hapusButton)
        Me.contentPanel.Controls.Add(Me.bersihButton)
        Me.contentPanel.Controls.Add(Me.simpanButton)
        Me.contentPanel.Controls.Add(Me.tambahButton)
        Me.contentPanel.Controls.Add(Me.kembalianTextBox)
        Me.contentPanel.Controls.Add(Me.dibayarTextBox)
        Me.contentPanel.Controls.Add(Me.totalHargaTextBox)
        Me.contentPanel.Controls.Add(Me.jumlahTextBox)
        Me.contentPanel.Controls.Add(Me.namaBarangTextBox)
        Me.contentPanel.Controls.Add(Me.namaKonsumenTextBox)
        Me.contentPanel.Controls.Add(Me.namaUserTextBox)
        Me.contentPanel.Controls.Add(Me.tanggalDateTimePicker)
        Me.contentPanel.Controls.Add(Me.f)
        Me.contentPanel.Controls.Add(Me.dataDataGridView)
        Me.contentPanel.Controls.Add(Me.Label3)
        Me.contentPanel.Controls.Add(Me.Label8)
        Me.contentPanel.Controls.Add(Me.Label18)
        Me.contentPanel.Controls.Add(Me.idLonsumenTextBox)
        Me.contentPanel.Controls.Add(Me.Label17)
        Me.contentPanel.Controls.Add(Me.Label7)
        Me.contentPanel.Controls.Add(Me.Label15)
        Me.contentPanel.Controls.Add(Me.Label6)
        Me.contentPanel.Controls.Add(Me.Label14)
        Me.contentPanel.Controls.Add(Me.Label13)
        Me.contentPanel.Controls.Add(Me.idBarangTextBox)
        Me.contentPanel.Controls.Add(Me.Label11)
        Me.contentPanel.Controls.Add(Me.idUserTextBox)
        Me.contentPanel.Controls.Add(Me.Label5)
        Me.contentPanel.Controls.Add(Me.idTextBox)
        Me.contentPanel.Controls.Add(Me.Label16)
        Me.contentPanel.Controls.Add(Me.Label12)
        Me.contentPanel.Controls.Add(Me.Label10)
        Me.contentPanel.Controls.Add(Me.Label4)
        Me.contentPanel.Controls.Add(Me.Label9)
        Me.contentPanel.Controls.Add(Me.Label2)
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(5, 72)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(1175, 601)
        Me.contentPanel.TabIndex = 4
        '
        'hapusButton
        '
        Me.hapusButton.BackColor = System.Drawing.Color.Red
        Me.hapusButton.FlatAppearance.BorderSize = 0
        Me.hapusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapusButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.hapusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.hapusButton.Location = New System.Drawing.Point(1055, 521)
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
        Me.bersihButton.Location = New System.Drawing.Point(1055, 197)
        Me.bersihButton.Name = "bersihButton"
        Me.bersihButton.Size = New System.Drawing.Size(84, 47)
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
        Me.simpanButton.Location = New System.Drawing.Point(936, 522)
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
        Me.tambahButton.Location = New System.Drawing.Point(936, 198)
        Me.tambahButton.Name = "tambahButton"
        Me.tambahButton.Size = New System.Drawing.Size(97, 47)
        Me.tambahButton.TabIndex = 14
        Me.tambahButton.Text = "Tambah"
        Me.tambahButton.UseVisualStyleBackColor = False
        '
        'kembalianTextBox
        '
        Me.kembalianTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.kembalianTextBox.Location = New System.Drawing.Point(936, 440)
        Me.kembalianTextBox.MaxLength = 50
        Me.kembalianTextBox.Name = "kembalianTextBox"
        Me.kembalianTextBox.ReadOnly = True
        Me.kembalianTextBox.Size = New System.Drawing.Size(203, 24)
        Me.kembalianTextBox.TabIndex = 12
        '
        'dibayarTextBox
        '
        Me.dibayarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dibayarTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.dibayarTextBox.Location = New System.Drawing.Point(936, 376)
        Me.dibayarTextBox.MaxLength = 50
        Me.dibayarTextBox.Name = "dibayarTextBox"
        Me.dibayarTextBox.Size = New System.Drawing.Size(203, 24)
        Me.dibayarTextBox.TabIndex = 12
        '
        'totalHargaTextBox
        '
        Me.totalHargaTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.totalHargaTextBox.Location = New System.Drawing.Point(936, 319)
        Me.totalHargaTextBox.MaxLength = 50
        Me.totalHargaTextBox.Name = "totalHargaTextBox"
        Me.totalHargaTextBox.ReadOnly = True
        Me.totalHargaTextBox.Size = New System.Drawing.Size(203, 24)
        Me.totalHargaTextBox.TabIndex = 12
        '
        'jumlahTextBox
        '
        Me.jumlahTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jumlahTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.jumlahTextBox.Location = New System.Drawing.Point(936, 158)
        Me.jumlahTextBox.MaxLength = 50
        Me.jumlahTextBox.Name = "jumlahTextBox"
        Me.jumlahTextBox.Size = New System.Drawing.Size(203, 24)
        Me.jumlahTextBox.TabIndex = 12
        '
        'namaBarangTextBox
        '
        Me.namaBarangTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.namaBarangTextBox.Location = New System.Drawing.Point(936, 108)
        Me.namaBarangTextBox.MaxLength = 50
        Me.namaBarangTextBox.Name = "namaBarangTextBox"
        Me.namaBarangTextBox.ReadOnly = True
        Me.namaBarangTextBox.Size = New System.Drawing.Size(203, 24)
        Me.namaBarangTextBox.TabIndex = 12
        '
        'namaKonsumenTextBox
        '
        Me.namaKonsumenTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.namaKonsumenTextBox.Location = New System.Drawing.Point(647, 115)
        Me.namaKonsumenTextBox.MaxLength = 50
        Me.namaKonsumenTextBox.Name = "namaKonsumenTextBox"
        Me.namaKonsumenTextBox.Size = New System.Drawing.Size(250, 24)
        Me.namaKonsumenTextBox.TabIndex = 12
        '
        'namaUserTextBox
        '
        Me.namaUserTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.namaUserTextBox.Location = New System.Drawing.Point(343, 115)
        Me.namaUserTextBox.MaxLength = 50
        Me.namaUserTextBox.Name = "namaUserTextBox"
        Me.namaUserTextBox.ReadOnly = True
        Me.namaUserTextBox.Size = New System.Drawing.Size(250, 24)
        Me.namaUserTextBox.TabIndex = 12
        '
        'tanggalDateTimePicker
        '
        Me.tanggalDateTimePicker.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.tanggalDateTimePicker.Location = New System.Drawing.Point(50, 116)
        Me.tanggalDateTimePicker.Name = "tanggalDateTimePicker"
        Me.tanggalDateTimePicker.Size = New System.Drawing.Size(250, 24)
        Me.tanggalDateTimePicker.TabIndex = 11
        '
        'f
        '
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.Lavender
        Me.f.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle33
        Me.f.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Verdana", 10.0!)
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.f.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.f.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.f.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.Column6, Me.Column7})
        Me.f.Location = New System.Drawing.Point(50, 169)
        Me.f.Name = "f"
        Me.f.ReadOnly = True
        Me.f.RowHeadersVisible = False
        Me.f.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.f.RowTemplate.ReadOnly = True
        Me.f.Size = New System.Drawing.Size(847, 216)
        Me.f.TabIndex = 10
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
        'dataDataGridView
        '
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.Lavender
        Me.dataDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle35
        Me.dataDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Verdana", 10.0!)
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dataDataGridView.Location = New System.Drawing.Point(50, 429)
        Me.dataDataGridView.Name = "dataDataGridView"
        Me.dataDataGridView.ReadOnly = True
        Me.dataDataGridView.RowHeadersVisible = False
        Me.dataDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.dataDataGridView.RowTemplate.ReadOnly = True
        Me.dataDataGridView.Size = New System.Drawing.Size(847, 140)
        Me.dataDataGridView.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kategori"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Jumlah"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga Barang"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 300
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(47, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tanggal Penjualan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(644, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nama Konsumen"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(933, 420)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 17)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Kembalian"
        '
        'idLonsumenTextBox
        '
        Me.idLonsumenTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idLonsumenTextBox.Location = New System.Drawing.Point(647, 60)
        Me.idLonsumenTextBox.MaxLength = 10
        Me.idLonsumenTextBox.Name = "idLonsumenTextBox"
        Me.idLonsumenTextBox.Size = New System.Drawing.Size(250, 24)
        Me.idLonsumenTextBox.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(933, 356)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Dibayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(644, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ID Konsumen"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(933, 299)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 17)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Total Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(340, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nama user"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(933, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Jumlah Barang"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(933, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 17)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Nama Barang"
        '
        'idBarangTextBox
        '
        Me.idBarangTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idBarangTextBox.Location = New System.Drawing.Point(936, 58)
        Me.idBarangTextBox.MaxLength = 10
        Me.idBarangTextBox.Name = "idBarangTextBox"
        Me.idBarangTextBox.Size = New System.Drawing.Size(203, 24)
        Me.idBarangTextBox.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(933, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "ID Barang"
        '
        'idUserTextBox
        '
        Me.idUserTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idUserTextBox.Location = New System.Drawing.Point(343, 60)
        Me.idUserTextBox.MaxLength = 10
        Me.idUserTextBox.Name = "idUserTextBox"
        Me.idUserTextBox.ReadOnly = True
        Me.idUserTextBox.Size = New System.Drawing.Size(250, 24)
        Me.idUserTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(340, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID User"
        '
        'idTextBox
        '
        Me.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idTextBox.Location = New System.Drawing.Point(50, 60)
        Me.idTextBox.MaxLength = 10
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.ReadOnly = True
        Me.idTextBox.Size = New System.Drawing.Size(250, 24)
        Me.idTextBox.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(913, 272)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 18)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Pembayaran"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(913, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 18)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Input Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(7, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 18)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Akan Dipesan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(47, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "No Penjualan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(7, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Daftar Barang Tersedia"
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
        'penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1185, 678)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "penjualan"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.contentPanel.ResumeLayout(False)
        Me.contentPanel.PerformLayout()
        CType(Me.f, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents contentPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents idLonsumenTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents idUserTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dataDataGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents f As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tanggalDateTimePicker As DateTimePicker
    Friend WithEvents namaUserTextBox As TextBox
    Friend WithEvents namaKonsumenTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents idBarangTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents bersihButton As Button
    Friend WithEvents tambahButton As Button
    Friend WithEvents jumlahTextBox As TextBox
    Friend WithEvents namaBarangTextBox As TextBox
    Friend WithEvents totalHargaTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents hapusButton As Button
    Friend WithEvents simpanButton As Button
    Friend WithEvents kembalianTextBox As TextBox
    Friend WithEvents dibayarTextBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
End Class
