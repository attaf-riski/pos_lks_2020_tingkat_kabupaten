<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.idCountLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.passPanel = New System.Windows.Forms.Panel()
        Me.passTextBox = New System.Windows.Forms.TextBox()
        Me.passCountLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Buttologinn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.passPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 121)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS_Penjualan.My.Resources.Resources.human
        Me.PictureBox1.Location = New System.Drawing.Point(31, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(115, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LOGIN"
        '
        'idTextBox
        '
        Me.idTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.idTextBox.Location = New System.Drawing.Point(29, 205)
        Me.idTextBox.MaxLength = 10
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(248, 24)
        Me.idTextBox.TabIndex = 5
        '
        'idCountLabel
        '
        Me.idCountLabel.AutoSize = True
        Me.idCountLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.idCountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.idCountLabel.Location = New System.Drawing.Point(244, 232)
        Me.idCountLabel.Name = "idCountLabel"
        Me.idCountLabel.Size = New System.Drawing.Size(33, 13)
        Me.idCountLabel.TabIndex = 3
        Me.idCountLabel.Text = "0/10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(26, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.passPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.Buttologinn)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(25, 260)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(255, 119)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'passPanel
        '
        Me.passPanel.BackColor = System.Drawing.Color.Transparent
        Me.passPanel.Controls.Add(Me.passTextBox)
        Me.passPanel.Controls.Add(Me.passCountLabel)
        Me.passPanel.Controls.Add(Me.Label5)
        Me.passPanel.Location = New System.Drawing.Point(3, 3)
        Me.passPanel.Name = "passPanel"
        Me.passPanel.Size = New System.Drawing.Size(265, 69)
        Me.passPanel.TabIndex = 0
        '
        'passTextBox
        '
        Me.passTextBox.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.passTextBox.Location = New System.Drawing.Point(3, 25)
        Me.passTextBox.MaxLength = 10
        Me.passTextBox.Name = "passTextBox"
        Me.passTextBox.Size = New System.Drawing.Size(248, 24)
        Me.passTextBox.TabIndex = 9
        Me.passTextBox.UseSystemPasswordChar = True
        '
        'passCountLabel
        '
        Me.passCountLabel.AutoSize = True
        Me.passCountLabel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.passCountLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.passCountLabel.Location = New System.Drawing.Point(218, 52)
        Me.passCountLabel.Name = "passCountLabel"
        Me.passCountLabel.Size = New System.Drawing.Size(33, 13)
        Me.passCountLabel.TabIndex = 7
        Me.passCountLabel.Text = "0/10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(0, -2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password"
        '
        'Buttologinn
        '
        Me.Buttologinn.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Buttologinn.FlatAppearance.BorderSize = 0
        Me.Buttologinn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttologinn.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Buttologinn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttologinn.Location = New System.Drawing.Point(3, 78)
        Me.Buttologinn.Name = "Buttologinn"
        Me.Buttologinn.Size = New System.Drawing.Size(252, 41)
        Me.Buttologinn.TabIndex = 1
        Me.Buttologinn.Text = "Login"
        Me.Buttologinn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BackgroundImage = Global.POS_Penjualan.My.Resources.Resources.gl1
        Me.ClientSize = New System.Drawing.Size(292, 409)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.idTextBox)
        Me.Controls.Add(Me.idCountLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOKO MAKMUR - Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.passPanel.ResumeLayout(False)
        Me.passPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents idCountLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents passPanel As Panel
    Friend WithEvents Buttologinn As Button
    Friend WithEvents passTextBox As TextBox
    Friend WithEvents passCountLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
