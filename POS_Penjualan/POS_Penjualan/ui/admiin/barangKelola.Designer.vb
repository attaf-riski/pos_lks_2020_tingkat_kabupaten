<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barangKelola
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kelolaButton = New System.Windows.Forms.Button()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.hargaJualTb = New System.Windows.Forms.TextBox()
        Me.hargaJualCountLabel = New System.Windows.Forms.Label()
        Me.hargaBeliTextBox = New System.Windows.Forms.TextBox()
        Me.hargaCountLabel = New System.Windows.Forms.Label()
        Me.jumlahTextBox = New System.Windows.Forms.TextBox()
        Me.jumlahCountLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.katergoriTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.f = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.namaTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.namaCountLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.idCountLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.bersihButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.simpanButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.contentPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.kelolaButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1186, 93)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(150, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "KELOLA BARANG"
        '
        'kelolaButton
        '
        Me.kelolaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.kelolaButton.FlatAppearance.BorderSize = 0
        Me.kelolaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.kelolaButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.kelolaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kelolaButton.Location = New System.Drawing.Point(20, 15)
        Me.kelolaButton.Name = "kelolaButton"
        Me.kelolaButton.Size = New System.Drawing.Size(106, 45)
        Me.kelolaButton.TabIndex = 5
        Me.kelolaButton.Text = "Kembali"
        Me.kelolaButton.UseVisualStyleBackColor = False
        '
        'contentPanel
        '
        Me.contentPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.contentPanel.Controls.Add(Me.hargaJualTb)
        Me.contentPanel.Controls.Add(Me.hargaJualCountLabel)
        Me.contentPanel.Controls.Add(Me.hargaBeliTextBox)
        Me.contentPanel.Controls.Add(Me.hargaCountLabel)
        Me.contentPanel.Controls.Add(Me.jumlahTextBox)
        Me.contentPanel.Controls.Add(Me.jumlahCountLabel)
        Me.contentPanel.Controls.Add(Me.Label3)
        Me.contentPanel.Controls.Add(Me.katergoriTextBox)
        Me.contentPanel.Controls.Add(Me.Label11)
        Me.contentPanel.Controls.Add(Me.f)
        Me.contentPanel.Controls.Add(Me.Label9)
        Me.contentPanel.Controls.Add(Me.namaTextBox)
        Me.contentPanel.Controls.Add(Me.Label7)
        Me.contentPanel.Controls.Add(Me.namaCountLabel)
        Me.contentPanel.Controls.Add(Me.Label6)
        Me.contentPanel.Controls.Add(Me.idTextBox)
        Me.contentPanel.Controls.Add(Me.idCountLabel)
        Me.contentPanel.Controls.Add(Me.Label4)
        Me.contentPanel.Controls.Add(Me.Label2)
        Me.contentPanel.Controls.Add(Me.Panel2)
        Me.contentPanel.Location = New System.Drawing.Point(49, 98)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(711, 515)
        Me.contentPanel.TabIndex = 2
        '
        'hargaJualTb
        '
        Me.hargaJualTb.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.hargaJualTb.Location = New System.Drawing.Point(148, 380)
        Me.hargaJualTb.MaxLength = 50
        Me.hargaJualTb.Name = "hargaJualTb"
        Me.hargaJualTb.Size = New System.Drawing.Size(388, 24)
        Me.hargaJualTb.TabIndex = 8
        '
        'hargaJualCountLabel
        '
        Me.hargaJualCountLabel.AutoSize = True
        Me.hargaJualCountLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.hargaJualCountLabel.Location = New System.Drawing.Point(503, 407)
        Me.hargaJualCountLabel.Name = "hargaJualCountLabel"
        Me.hargaJualCountLabel.Size = New System.Drawing.Size(33, 13)
        Me.hargaJualCountLabel.TabIndex = 6
        Me.hargaJualCountLabel.Text = "0/50"
        '
        'hargaBeliTextBox
        '
        Me.hargaBeliTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.hargaBeliTextBox.Location = New System.Drawing.Point(148, 321)
        Me.hargaBeliTextBox.MaxLength = 50
        Me.hargaBeliTextBox.Name = "hargaBeliTextBox"
        Me.hargaBeliTextBox.Size = New System.Drawing.Size(388, 24)
        Me.hargaBeliTextBox.TabIndex = 8
        '
        'hargaCountLabel
        '
        Me.hargaCountLabel.AutoSize = True
        Me.hargaCountLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.hargaCountLabel.Location = New System.Drawing.Point(503, 348)
        Me.hargaCountLabel.Name = "hargaCountLabel"
        Me.hargaCountLabel.Size = New System.Drawing.Size(33, 13)
        Me.hargaCountLabel.TabIndex = 6
        Me.hargaCountLabel.Text = "0/50"
        '
        'jumlahTextBox
        '
        Me.jumlahTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.jumlahTextBox.Location = New System.Drawing.Point(148, 260)
        Me.jumlahTextBox.MaxLength = 50
        Me.jumlahTextBox.Name = "jumlahTextBox"
        Me.jumlahTextBox.Size = New System.Drawing.Size(388, 24)
        Me.jumlahTextBox.TabIndex = 8
        '
        'jumlahCountLabel
        '
        Me.jumlahCountLabel.AutoSize = True
        Me.jumlahCountLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.jumlahCountLabel.Location = New System.Drawing.Point(503, 287)
        Me.jumlahCountLabel.Name = "jumlahCountLabel"
        Me.jumlahCountLabel.Size = New System.Drawing.Size(33, 13)
        Me.jumlahCountLabel.TabIndex = 6
        Me.jumlahCountLabel.Text = "0/50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(145, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Harga Jual"
        '
        'katergoriTextBox
        '
        Me.katergoriTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.katergoriTextBox.Location = New System.Drawing.Point(148, 195)
        Me.katergoriTextBox.MaxLength = 50
        Me.katergoriTextBox.Name = "katergoriTextBox"
        Me.katergoriTextBox.Size = New System.Drawing.Size(388, 24)
        Me.katergoriTextBox.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(145, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 19)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Harga Beli"
        '
        'f
        '
        Me.f.AutoSize = True
        Me.f.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.f.Location = New System.Drawing.Point(503, 222)
        Me.f.Name = "f"
        Me.f.Size = New System.Drawing.Size(33, 13)
        Me.f.TabIndex = 6
        Me.f.Text = "0/50"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(145, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Jumlah"
        '
        'namaTextBox
        '
        Me.namaTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.namaTextBox.Location = New System.Drawing.Point(148, 123)
        Me.namaTextBox.MaxLength = 50
        Me.namaTextBox.Name = "namaTextBox"
        Me.namaTextBox.Size = New System.Drawing.Size(388, 24)
        Me.namaTextBox.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(145, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Kategori"
        '
        'namaCountLabel
        '
        Me.namaCountLabel.AutoSize = True
        Me.namaCountLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.namaCountLabel.Location = New System.Drawing.Point(503, 150)
        Me.namaCountLabel.Name = "namaCountLabel"
        Me.namaCountLabel.Size = New System.Drawing.Size(33, 13)
        Me.namaCountLabel.TabIndex = 6
        Me.namaCountLabel.Text = "0/50"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(145, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nama Barang"
        '
        'idTextBox
        '
        Me.idTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idTextBox.Location = New System.Drawing.Point(148, 57)
        Me.idTextBox.MaxLength = 10
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(388, 24)
        Me.idTextBox.TabIndex = 5
        '
        'idCountLabel
        '
        Me.idCountLabel.AutoSize = True
        Me.idCountLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.idCountLabel.Location = New System.Drawing.Point(503, 84)
        Me.idCountLabel.Name = "idCountLabel"
        Me.idCountLabel.Size = New System.Drawing.Size(33, 13)
        Me.idCountLabel.TabIndex = 3
        Me.idCountLabel.Text = "0/10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(145, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ID barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(105, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Input Data"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.hapusButton)
        Me.Panel2.Controls.Add(Me.bersihButton)
        Me.Panel2.Controls.Add(Me.editButton)
        Me.Panel2.Controls.Add(Me.simpanButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 440)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(711, 75)
        Me.Panel2.TabIndex = 0
        '
        'hapusButton
        '
        Me.hapusButton.BackColor = System.Drawing.Color.Red
        Me.hapusButton.FlatAppearance.BorderSize = 0
        Me.hapusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapusButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.hapusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.hapusButton.Location = New System.Drawing.Point(554, 15)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(106, 47)
        Me.hapusButton.TabIndex = 1
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
        Me.bersihButton.Location = New System.Drawing.Point(378, 15)
        Me.bersihButton.Name = "bersihButton"
        Me.bersihButton.Size = New System.Drawing.Size(106, 47)
        Me.bersihButton.TabIndex = 1
        Me.bersihButton.Text = "Bersih"
        Me.bersihButton.UseVisualStyleBackColor = False
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.editButton.FlatAppearance.BorderSize = 0
        Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.editButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.editButton.Location = New System.Drawing.Point(215, 15)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(106, 47)
        Me.editButton.TabIndex = 1
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = False
        '
        'simpanButton
        '
        Me.simpanButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.simpanButton.FlatAppearance.BorderSize = 0
        Me.simpanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.simpanButton.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.simpanButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.simpanButton.Location = New System.Drawing.Point(47, 15)
        Me.simpanButton.Name = "simpanButton"
        Me.simpanButton.Size = New System.Drawing.Size(106, 47)
        Me.simpanButton.TabIndex = 1
        Me.simpanButton.Text = "Simpan"
        Me.simpanButton.UseVisualStyleBackColor = False
        '
        'barangKelola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1196, 645)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "barangKelola"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "barangKelola"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.contentPanel.ResumeLayout(False)
        Me.contentPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents kelolaButton As Button
    Friend WithEvents contentPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents hapusButton As Button
    Friend WithEvents bersihButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents simpanButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents idCountLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents hargaBeliTextBox As TextBox
    Friend WithEvents hargaCountLabel As Label
    Friend WithEvents jumlahTextBox As TextBox
    Friend WithEvents jumlahCountLabel As Label
    Friend WithEvents katergoriTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents f As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents namaTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents namaCountLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents hargaJualTb As TextBox
    Friend WithEvents hargaJualCountLabel As Label
    Friend WithEvents Label3 As Label
End Class
