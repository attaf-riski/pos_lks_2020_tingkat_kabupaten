Imports System.Data.SqlClient

Public Class pembelian
    Public Sub loadSub() Handles MyBase.Load
        'id otomatis
        idOtomatis()

        'set user

        If idStr = "" Then
            TextBoidx.Text = "111201"
            namaTextBox.Text = "ataf"
        Else
            TextBoidx.Text = idStr
            namaTextBox.Text = nameStr
        End If



        'load data
        loadData()

        'bersij
        bersih()
    End Sub

    Sub loadData()
        dataDataGridView.Rows.Clear()

        Try
            bukaKoneksi()
            syntaxSQL = "select * from tbl_barang"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                If dr(3) <> 0 Then
                    dataDataGridView.Rows.Add(dr(0), dr(1), dr(2), dr(3), FormatCurrency(dr(4)))
                End If
            Loop

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub



    Sub idOtomatis()
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_beli ORDER BY no_pembelian DESC"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                If Strings.Mid(dr(0), 3, 6) = Format(Today, "yyMMdd") Then
                    idTextBox.Text = "PB" & Format(Strings.Right(dr(0), 8) + 1, "00")
                Else
                    idTextBox.Text = "PB" & Format(Today, "yyMMdd") & "01"
                End If
            Else
                idTextBox.Text = "PB" & Format(Today, "yyMMdd") & "01"
            End If

        Catch ex As Exception
            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub



    Sub bersih()
        iPemasokTextBox.Clear()
        nmaPemasokTextBox.Clear()
        idBarangTextBox.Clear()
        namaBarangTextBox.Clear()
        jumlahTextBox.Text = "0"
        totalTextBox.Text = "0"
        dibayarTextBox.Text = "0"
        kembalianTextBox.Text = "0"
        akaaDataGridView.Rows.Clear()

    End Sub

    Private Sub idBarangTextBox_TextChanged(sender As Object, e As EventArgs) Handles idBarangTextBox.TextChanged
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & idBarangTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                namaBarangTextBox.Text = dr(1)

            Else
                namaBarangTextBox.Text = ""
            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub jumlahTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlahTextBox.KeyPress, dibayarTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Sub hitungTotalBiaya()
        Dim bufferTotal As Integer = 0

        For baris As Integer = 0 To akaaDataGridView.RowCount - 2
            bufferTotal += akaaDataGridView.Rows(baris).Cells(5).Value
        Next

        totalTextBox.Text = bufferTotal.ToString

    End Sub



    Private Sub tambahButton_Click(sender As Object, e As EventArgs) Handles tambahButton.Click
        If idBarangTextBox.Text = "" Or jumlahTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom id barang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If namaBarangTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf, id barang tidak terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If Val(jumlahTextBox.Text) <= 0 Then
            MessageBox.Show("Mohon maaf, jumlah harus lebih dari 0", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & idBarangTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                Dim bufferTotal As Integer = dr(4) * Val(jumlahTextBox.Text)
                akaaDataGridView.Rows.Add(idBarangTextBox.Text, dr(1), dr(2), dr(4), jumlahTextBox.Text, bufferTotal)
            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try



        'cek duplijkat
        For barisAtas As Integer = 0 To akaaDataGridView.RowCount - 2
            For barisBawah As Integer = 1 + barisAtas To akaaDataGridView.RowCount - 2
                If akaaDataGridView.Rows(barisAtas).Cells(0).Value = akaaDataGridView.Rows(barisBawah).Cells(0).Value Then
                    MessageBox.Show("Barang sudah masuk ke tabel pemesanan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    akaaDataGridView.Rows.RemoveAt(barisBawah)
                End If
            Next
        Next





        hitungTotalBiaya()

        idBarangTextBox.Clear()
        jumlahTextBox.Text = "0"
    End Sub

    Private Sub bersihButton_Click(sender As Object, e As EventArgs) Handles bersihButton.Click
        If idBarangTextBox.Text = "" Or jumlahTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom id barang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        For baris As Integer = 0 To akaaDataGridView.RowCount - 2
            If akaaDataGridView.Rows(baris).Cells(0).Value = idTextBox.Text Then
                akaaDataGridView.Rows.RemoveAt(baris)
            End If
        Next

        hitungTotalBiaya()

    End Sub

    Private Sub dibayarTextBox_TextChanged(sender As Object, e As EventArgs) Handles dibayarTextBox.TextChanged
        kembalianTextBox.Text = Val(dibayarTextBox.Text) - Val(totalTextBox.Text)

    End Sub

    Private Sub hapusButton_Click(sender As Object, e As EventArgs) Handles hapusButton.Click
        loadSub()

    End Sub

    Private Sub simpanButton_Click(sender As Object, e As EventArgs) Handles simpanButton.Click
        If iPemasokTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom id pemasok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If akaaDataGridView.RowCount = 1 Then
            MessageBox.Show("Mohon maaf, tidak ada transaksi yang akan disimpan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Val(dibayarTextBox.Text) < Val(totalTextBox.Text) Then
            MessageBox.Show("Mohon maaf, pembayaran kurang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Try
            bukaKoneksi()
            syntaxSQL = "INSERT INTO tbl_beli VALUES('" & idTextBox.Text & "','" & tanggalDateTimePicker.Text & "', '" & TextBoidx.Text & "','" & iPemasokTextBox.Text &
                "','" & nmaPemasokTextBox.Text & "'," & totalTextBox.Text & "," & dibayarTextBox.Text & "," & kembalianTextBox.Text & ")"
            Console.WriteLine(syntaxSQL)
            comSQL = New SqlCommand(syntaxSQL, conn)
            comSQL.ExecuteNonQuery()




            For baris As Integer = 0 To akaaDataGridView.RowCount - 2
                syntaxSQL = "INSERT INTO tbl_beli_detail VALUES('" & idTextBox.Text & "','" & akaaDataGridView.Rows(baris).Cells(0).Value & "'," & akaaDataGridView.Rows(baris).Cells(3).Value & "," & akaaDataGridView.Rows(baris).Cells(4).Value & "," & akaaDataGridView.Rows(baris).Cells(5).Value & ")"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()


                syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & akaaDataGridView.Rows(baris).Cells(0).Value & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                dr = comSQL.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    syntaxSQL = "UPDATE tbl_barang SET jumlah = " & dr(3) + akaaDataGridView.Rows(baris).Cells(4).Value & "WHERE id_barang = '" & akaaDataGridView.Rows(baris).Cells(0).Value & "'"
                    dr.Close()
                    comSQL = New SqlCommand(syntaxSQL, conn)
                    comSQL.ExecuteNonQuery()

                End If






            Next



            MessageBox.Show("pembelian berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadSub()




        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub iPemasokTextBox_TextChanged(sender As Object, e As EventArgs) Handles iPemasokTextBox.TextChanged
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_pemasok WHERE id_pemasok = '" & iPemasokTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                nmaPemasokTextBox.Text = dr(1)
            Else
                nmaPemasokTextBox.Clear()

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