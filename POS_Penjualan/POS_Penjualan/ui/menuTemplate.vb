Public Class menuTemplate


    Public Sub loadWelcome() Handles MyBase.Load
        With welcome
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(welcome)
            .BringToFront()
            .Show()
        End With

    End Sub


    Public Sub loadSub() Handles MyBase.Load
        setPrevil()



    End Sub

    Public Sub offAll()
        barangButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        konsumenButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        pemasokButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        userButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        penjualanButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        pembelianButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        returnJualButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        returBelianButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        lapJualButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        lapBeliButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        lapReturJualButton.BackColor = Color.FromArgb(255, 23, 106, 183)
        lapReturBeliButton.BackColor = Color.FromArgb(255, 23, 106, 183)

        barangButton.ForeColor = Color.White
        konsumenButton.ForeColor = Color.White
        pemasokButton.ForeColor = Color.White
        userButton.ForeColor = Color.White
        penjualanButton.ForeColor = Color.White
        pembelianButton.ForeColor = Color.White
        returnJualButton.ForeColor = Color.White
        returBelianButton.ForeColor = Color.White
        lapJualButton.ForeColor = Color.White
        lapBeliButton.ForeColor = Color.White
        lapReturJualButton.ForeColor = Color.White
        lapReturBeliButton.ForeColor = Color.White

    End Sub

    Sub setPrevil()
        statusLabel.Text = levelStr
        namaLabel.Text = nameStr





        masterPanel.Visible = False
        laporanPanel.Visible = False
        transaksiPanel.Visible = False


        Select Case levelStr
            Case adminStr
                transaksiPanel.Visible = True

                laporanPanel.Visible = True

            Case petugasStr
                masterPanel.Visible = True

            Case Else
                masterPanel.Visible = True
                laporanPanel.Visible = True
                transaksiPanel.Visible = True

        End Select

        If statusLabel.Text = "" Then
            statusLabel.Text = adminStr
            namaLabel.Text = "admin"
            idStr = "111101"
        End If

    End Sub


    Sub onAll(sender As Object)
        Dim button As Button = DirectCast(sender, Button)
        button.BackColor = Color.FromArgb(255, 185, 209, 234)
        button.ForeColor = Color.Black
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tanggalLabel.Text = Date.Now.ToLongDateString & "    " & Date.Now.ToShortTimeString
    End Sub

    Private Sub userButton_Click(sender As Object, e As EventArgs) Handles userButton.Click
        offAll()
        onAll(sender)


        With user
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(user)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub konsumenButton_Click(sender As Object, e As EventArgs) Handles konsumenButton.Click
        offAll()
        onAll(sender)

        With koonsumen
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(koonsumen)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub pemasokButton_Click(sender As Object, e As EventArgs) Handles pemasokButton.Click
        offAll()
        onAll(sender)

        With pemasok
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(pemasok)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub barangButton_Click(sender As Object, e As EventArgs) Handles barangButton.Click
        offAll()
        onAll(sender)

        With barang
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(barang)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub penjualanButton_Click(sender As Object, e As EventArgs) Handles penjualanButton.Click
        offAll()
        onAll(sender)

        With penjualan
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(penjualan)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub pembelianButton_Click(sender As Object, e As EventArgs) Handles pembelianButton.Click
        offAll()
        onAll(sender)

        With pembelian
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(pembelian)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub returnJualButton_Click(sender As Object, e As EventArgs) Handles returnJualButton.Click
        offAll()
        onAll(sender)

        With retur_penjualan
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(retur_penjualan)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub returBelianButton_Click(sender As Object, e As EventArgs) Handles returBelianButton.Click
        offAll()
        onAll(sender)

        With retur_pembelian
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(retur_pembelian)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub lapJualButton_Click(sender As Object, e As EventArgs) Handles lapJualButton.Click
        offAll()
        onAll(sender)

        With lapPenjualan
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(lapPenjualan)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub lapBeliButton_Click(sender As Object, e As EventArgs) Handles lapBeliButton.Click
        offAll()
        onAll(sender)

        With lapPembelian
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(lapPembelian)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub lapReturJualButton_Click(sender As Object, e As EventArgs) Handles lapReturJualButton.Click
        offAll()
        onAll(sender)

        With lapReturPenjualan
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(lapReturPenjualan)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub lapReturBeliButton_Click(sender As Object, e As EventArgs) Handles lapReturBeliButton.Click
        offAll()
        onAll(sender)

        With lapReturPengembalian
            .TopLevel = False
            .loadSub()
            Me.fillPanel.Controls.Add(lapReturPengembalian)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click

        If MessageBox.Show("Apakah anda yakin akan logout", "Yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Hide()
            Me.loadWelcome()
            Me.loadSub()

            With login
                .loadSub()
                .Show()
            End With
        End If




    End Sub


End Class