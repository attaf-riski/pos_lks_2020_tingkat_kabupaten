<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kelolaButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dasarComboBox = New System.Windows.Forms.ComboBox()
        Me.cariTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dataDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dataDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataDataGridView.Location = New System.Drawing.Point(5, 98)
        Me.dataDataGridView.Name = "dataDataGridView"
        Me.dataDataGridView.ReadOnly = True
        Me.dataDataGridView.RowHeadersVisible = False
        Me.dataDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.dataDataGridView.RowTemplate.ReadOnly = True
        Me.dataDataGridView.Size = New System.Drawing.Size(1010, 374)
        Me.dataDataGridView.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID User"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nama User"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "Alamat"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "No Ponsel"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 300
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sebagai"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.kelolaButton)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1010, 93)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(150, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "USER"
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
        Me.kelolaButton.Text = "Kelola"
        Me.kelolaButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dasarComboBox)
        Me.Panel2.Controls.Add(Me.cariTextBox)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(463, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 93)
        Me.Panel2.TabIndex = 7
        '
        'dasarComboBox
        '
        Me.dasarComboBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.dasarComboBox.FormattingEnabled = True
        Me.dasarComboBox.Location = New System.Drawing.Point(140, 55)
        Me.dasarComboBox.Name = "dasarComboBox"
        Me.dasarComboBox.Size = New System.Drawing.Size(388, 24)
        Me.dasarComboBox.TabIndex = 4
        '
        'cariTextBox
        '
        Me.cariTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.cariTextBox.Location = New System.Drawing.Point(140, 12)
        Me.cariTextBox.MaxLength = 50
        Me.cariTextBox.Name = "cariTextBox"
        Me.cariTextBox.Size = New System.Drawing.Size(388, 24)
        Me.cariTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(19, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Berdasarkan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(19, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cari"
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1020, 477)
        Me.Controls.Add(Me.dataDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "user"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dataDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dasarComboBox As ComboBox
    Friend WithEvents cariTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents kelolaButton As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
