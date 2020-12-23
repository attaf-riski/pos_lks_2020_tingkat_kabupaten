Imports System.Data.SqlClient

Public Class barangKelola
    Public Sub loadSub() Handles MyBase.Load
        contentPanel.Height = (Me.Height - Panel1.Height - 10)
        contentPanel.Left = (Me.Width - contentPanel.Width) / 2

        kembaliKeAwal()

    End Sub

    Private Sub kelolaButton_Click(sender As Object, e As EventArgs) Handles kelolaButton.Click
        With barang
            .TopLevel = False
            .loadSub()
            menuTemplate.fillPanel.Controls.Add(barang)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub jumlahTextBox_TextChanged(sender As Object, e As EventArgs) Handles jumlahTextBox.TextChanged
        jumlahCountLabel.Text = jumlahTextBox.Text.ToString.Length & "/50"

    End Sub

    Private Sub hargaTextBox_TextChanged(sender As Object, e As EventArgs) Handles hargaBeliTextBox.TextChanged
        hargaCountLabel.Text = hargaBeliTextBox.Text.ToString.Length & "/50"

    End Sub

    Private Sub hargaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlahTextBox.KeyPress, hargaBeliTextBox.KeyPress, hargaJualTb.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub katergoriTextBox_TextChanged(sender As Object, e As EventArgs) Handles katergoriTextBox.TextChanged
        f.Text = katergoriTextBox.Text.ToString.Length & "/50"

    End Sub

    Private Sub namaTextBox_TextChanged(sender As Object, e As EventArgs) Handles namaTextBox.TextChanged
        namaCountLabel.Text = namaTextBox.Text.ToString.Length & "/50"

    End Sub


    Sub kembaliKeAwal()

        idTextBox.Clear()

    End Sub

    Sub bersih()
        namaTextBox.Clear()
        katergoriTextBox.Clear()
        jumlahTextBox.Clear()
        hargaBeliTextBox.Clear()
        hargaJualTb.Clear()

    End Sub


    Private Sub idTextBox_TextChanged(sender As Object, e As EventArgs) Handles idTextBox.TextChanged
        idCountLabel.Text = idTextBox.Text.ToString.Length & "/10"
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                namaTextBox.Text = dr(1)
                katergoriTextBox.Text = dr(2)
                jumlahTextBox.Text = dr(3)
                hargaBeliTextBox.Text = dr(4)
                hargaJualTb.Text = dr(5)
            Else
                bersih()

            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try





    End Sub

    Private Sub bersihButton_Click(sender As Object, e As EventArgs) Handles bersihButton.Click
        kembaliKeAwal()

    End Sub

    Private Sub simpanButton_Click(sender As Object, e As EventArgs) Handles simpanButton.Click
        If idTextBox.Text = "" Or namaTextBox.Text = "" Or katergoriTextBox.Text = "" Or jumlahTextBox.Text = "" Or hargaBeliTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                'peringatan
                MessageBox.Show("Mohon maaf, ID sudah digunakan. Gunakan ID lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                dr.Close()
                syntaxSQL = "INSERT INTO tbl_barang VALUES('" & idTextBox.Text & "','" & namaTextBox.Text & "','" & katergoriTextBox.Text & "'," & jumlahTextBox.Text & "," & hargaBeliTextBox.Text & "," & hargaJualTb.Text & ")"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()

                MessageBox.Show("Barang berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadSub()

            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try


    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        If idTextBox.Text = "" Or namaTextBox.Text = "" Or katergoriTextBox.Text = "" Or jumlahTextBox.Text = "" Or hargaBeliTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()
                syntaxSQL = "UPDATE tbl_barang SET  nama_barang = '" & namaTextBox.Text & "', kategori = '" & katergoriTextBox.Text & "',jumlah = " & jumlahTextBox.Text & ", harga_beli = " & hargaBeliTextBox.Text & ", harga_jual = " & hargaJualTb.Text & " WHERE id_barang = '" & idTextBox.Text & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()

                MessageBox.Show("Barang berhasil diedit!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadSub()
            Else
                'peringatan
                'peringatan
                MessageBox.Show("Mohon maaf, Barang belum disimpan. Simpan dahulu barang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try


    End Sub

    Private Sub hapusButton_Click(sender As Object, e As EventArgs) Handles hapusButton.Click
        If idTextBox.Text = "" Or namaTextBox.Text = "" Or katergoriTextBox.Text = "" Or jumlahTextBox.Text = "" Or hargaBeliTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()
                syntaxSQL = "Delete tbl_barang WHERE id_barang = '" & idTextBox.Text & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()

                MessageBox.Show("Barang berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadSub()
            Else
                'peringatan
                'peringatan
                MessageBox.Show("Mohon maaf, Barang belum disimpan. Simpan dahulu barang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try


    End Sub

    Private Sub hargaJualTb_TextChanged(sender As Object, e As EventArgs) Handles hargaJualTb.TextChanged
        hargaJualCountLabel.Text = hargaJualTb.Text.ToString.Length & "/50"

    End Sub

    Private Sub contentPanel_Paint(sender As Object, e As PaintEventArgs) Handles contentPanel.Paint

    End Sub
End Class