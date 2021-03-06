﻿Imports System.Data.SqlClient


Public Class pemasokKelola
    Public Sub loadSub() Handles MyBase.Load
        contentPanel.Height = (Me.Height - Panel1.Height - 10)
        contentPanel.Left = (Me.Width - contentPanel.Width) / 2


        kembaliKeAwal()

    End Sub

    Private Sub kelolaButton_Click(sender As Object, e As EventArgs) Handles kelolaButton.Click
        With pemasok
            .TopLevel = False
            .loadSub()
            menuTemplate.fillPanel.Controls.Add(pemasok)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub noTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub noTextBox_TextChanged(sender As Object, e As EventArgs) Handles noTextBox.TextChanged
        noCountLabel.Text = noTextBox.Text.ToString.Length & "/50"
    End Sub

    Private Sub namaTextBox_TextChanged(sender As Object, e As EventArgs) Handles namaTextBox.TextChanged
        namaCountLabel.Text = namaTextBox.Text.ToString.Length & "/50"

    End Sub

    Private Sub alamatTextBox_TextChanged(sender As Object, e As EventArgs) Handles alamatTextBox.TextChanged
        f.Text = alamatTextBox.Text.ToString.Length & "/50"

    End Sub
    Sub kembaliKeAwal()

        idTextBox.Clear()

    End Sub

    Sub bersih()
        namaTextBox.Clear()
        alamatTextBox.Clear()
        noTextBox.Clear()

    End Sub
    Private Sub idTextBox_TextChanged(sender As Object, e As EventArgs) Handles idTextBox.TextChanged
        idCountLabel.Text = idTextBox.Text.ToString.Length & "/10"

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_pemasok WHERE id_pemasok = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                namaTextBox.Text = dr(1)
                alamatTextBox.Text = dr(2)
                noTextBox.Text = dr(3)
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

    Private Sub simpanButton_Click(sender As Object, e As EventArgs) Handles simpanButton.Click
        If idTextBox.Text = "" Or namaTextBox.Text = "" Or alamatTextBox.Text = "" Or noTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_pemasok WHERE id_pemasok = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                'peringatan
                MessageBox.Show("Mohon maaf, ID sudah digunakan. Gunakan ID lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                dr.Close()
                syntaxSQL = "INSERT INTO tbl_pemasok VALUES('" & idTextBox.Text & "','" & namaTextBox.Text & "','" & alamatTextBox.Text & "','" & noTextBox.Text & "')"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()

                MessageBox.Show("pemasok berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If idTextBox.Text = "" Or namaTextBox.Text = "" Or alamatTextBox.Text = "" Or noTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_pemasok WHERE id_pemasok = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()
                syntaxSQL = "UPDATE tbl_pemasok SET  nama_pemasok = '" & namaTextBox.Text & "', alamat = '" & alamatTextBox.Text & "',no_ponsel = '" & noTextBox.Text & "' WHERE id_pemasok = '" & idTextBox.Text & "'"


                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()

                MessageBox.Show("pemasok berhasil diedit!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadSub()
            Else
                'peringatan
                'peringatan
                MessageBox.Show("Mohon maaf, pemasok belum disimpan. Simpan dahulu pemasok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub bersihButton_Click(sender As Object, e As EventArgs) Handles bersihButton.Click
        kembaliKeAwal()

    End Sub

    Private Sub hapusButton_Click(sender As Object, e As EventArgs) Handles hapusButton.Click
        If idTextBox.Text = "" Or namaTextBox.Text = "" Or alamatTextBox.Text = "" Or noTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_pemasok WHERE id_pemasok = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()
                syntaxSQL = "Delete tbl_pemasok WHERE id_pemasok = '" & idTextBox.Text & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()

                MessageBox.Show("pemasok berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadSub()
            Else
                'peringatan
                'peringatan
                MessageBox.Show("Mohon maaf, pemasok belum disimpan. Simpan dahulu pemasok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
End Class