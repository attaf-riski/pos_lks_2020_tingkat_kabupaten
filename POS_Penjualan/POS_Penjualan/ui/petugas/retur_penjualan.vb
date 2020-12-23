Imports System.Data.SqlClient
Public Class retur_penjualan
    Public Sub loadSub() Handles MyBase.Load
        'id otomatis
        idOtomatis()

        'set user

        If idStr = "" Then
            iduserTextBox.Text = "111201"
            namaTextBox.Text = "ataf"
        Else
            iduserTextBox.Text = idStr
            namaTextBox.Text = nameStr
        End If





        'bersij
        bersih()
    End Sub


    Sub bersih()
        konsumenTextBox.Clear()
        namaKonsumenTextBox.Clear()
        noPenjualanTb.Clear()
        idComboBox.Items.Clear()
        jumlahDijualTextBox.Text = "0"
        jumlahDikembalikanTextBox.Text = "0"
        akanDGV.Rows.Clear()
        dijualDataGridView.Rows.Clear()
        totalTextBox.Text = "0"
        dibayarTextBox.Text = "0"
        kembalianTextBox.Text = "0"
    End Sub


    Sub idOtomatis()
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_retur_jual ORDER BY no_retur_penjualan DESC"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                If Strings.Mid(dr(0), 3, 6) = Format(Today, "yyMMdd") Then
                    idTextBox.Text = "RJ" & Format(Strings.Right(dr(0), 8) + 1, "00")
                Else
                    idTextBox.Text = "RJ" & Format(Today, "yyMMdd") & "01"
                End If
            Else
                idTextBox.Text = "RJ" & Format(Today, "yyMMdd") & "01"
            End If

        Catch ex As Exception
            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub konsumenTextBox_TextChanged(sender As Object, e As EventArgs) Handles konsumenTextBox.TextChanged
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_konsumen WHERE id_konsumen = '" & konsumenTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                namaKonsumenTextBox.Text = dr(1)
            Else
                namaKonsumenTextBox.Clear()

            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub noPenjualanTb_TextChanged(sender As Object, e As EventArgs) Handles noPenjualanTb.TextChanged
        'update dgv barang dijual 
        'update id barang

        dijualDataGridView.Rows.Clear()
        akanDGV.Rows.Clear()
        idComboBox.Items.Clear()


        'isi id barang

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT jd.id_barang FROM tbl_jual j, tbl_jual_detail jd WHERE j.no_penjualan = jd.no_penjualan and j.no_penjualan = '" & noPenjualanTb.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                idComboBox.Items.Add(dr(0))
            Loop

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT jd.id_barang,b.nama_barang,b.kategori,jd.harga_barang,jd.jumlah,jd.total_harga_barang FROM tbl_jual j, tbl_jual_detail jd,tbl_barang b WHERE jd.id_barang = b.id_barang and j.no_penjualan = jd.no_penjualan and j.no_penjualan = '" & noPenjualanTb.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                dijualDataGridView.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
            Loop

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try

    End Sub

    Private Sub idComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idComboBox.SelectedIndexChanged
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT b.nama_barang,jd.jumlah FROM tbl_barang b, tbl_jual_detail jd WHERE b.id_barang = jd.id_barang and jd.no_penjualan = '" & noPenjualanTb.Text & "' and jd.id_barang = '" & idComboBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                namaBarangTextBox.Text = dr(0)
                jumlahDijualTextBox.Text = dr(1)
            Else
                namaBarangTextBox.Clear()
                jumlahDijualTextBox.Text = "0"


            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub jumlahDikembalikanTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlahDikembalikanTextBox.KeyPress, jumlahDijualTextBox.KeyPress, dibayarTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub


    Sub hitungTotalBiaya()
        Dim bufferTotal As Integer = 0

        For baris As Integer = 0 To akanDGV.RowCount - 2
            bufferTotal += akanDGV.Rows(baris).Cells(5).Value
        Next

        totalTextBox.Text = bufferTotal.ToString

    End Sub


    Private Sub tambahButton_Click(sender As Object, e As EventArgs) Handles tambahButton.Click
        'cek kelengkapan
        'cek jumlah

        If noPenjualanTb.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom no penjualan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If idComboBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon pilih id barang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Val(jumlahDikembalikanTextBox.Text) <= 0 Then
            MessageBox.Show("Mohon maaf, barang dikembalikan harus lebih dari 0", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If Val(jumlahDikembalikanTextBox.Text) > Val(jumlahDijualTextBox.Text) Then
            MessageBox.Show("Mohon maaf, barang dikembalikan harus kurang / sama dengan barang dijual", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT b.nama_barang,b.kategori,jd.harga_barang FROM tbl_barang b, tbl_jual_detail jd WHERE b.id_barang = jd.id_barang and jd.no_penjualan = '" & noPenjualanTb.Text & "' and jd.id_barang = '" & idComboBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                Dim kembalikan As Integer = dr(2) * Val(jumlahDikembalikanTextBox.Text)
                akanDGV.Rows.Add(idComboBox.Text, namaBarangTextBox.Text, dr(1), dr(2), jumlahDikembalikanTextBox.Text, kembalikan)
            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try


        For barisAtas As Integer = 0 To akanDGV.RowCount - 2
            For barisBawah As Integer = 1 + barisAtas To akanDGV.RowCount - 2
                If akanDGV.Rows(barisAtas).Cells(0).Value = akanDGV.Rows(barisBawah).Cells(0).Value Then
                    MessageBox.Show("Barang sudah masuk ke tabel dikembalikan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    akanDGV.Rows.RemoveAt(barisBawah)
                End If
            Next
        Next

        namaBarangTextBox.Clear()
        jumlahDijualTextBox.Text = "0"
        jumlahDikembalikanTextBox.Text = "0"


        hitungTotalBiaya()



    End Sub

    Private Sub bersihButton_Click(sender As Object, e As EventArgs) Handles bersihButton.Click
        If noPenjualanTb.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom no penjualan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If idComboBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon pilih id barang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        For baris As Integer = 0 To akanDGV.RowCount - 2
            If akanDGV.Rows(baris).Cells(0).Value = idTextBox.Text Then
                akanDGV.Rows.RemoveAt(baris)
            End If
        Next

        hitungTotalBiaya()
    End Sub

    Private Sub dibayarTextBox_TextChanged(sender As Object, e As EventArgs) Handles dibayarTextBox.TextChanged
        kembalianTextBox.Text = Val(dibayarTextBox.Text) - Val(totalTextBox.Text)

    End Sub

    Private Sub simpanButton_Click(sender As Object, e As EventArgs) Handles simpanButton.Click
        'cek kelengkapan
        '
        If konsumenTextBox.Text = "" Or namaKonsumenTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom id konsumen", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If noPenjualanTb.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi no penjualan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        If akanDGV.RowCount = 1 Then
            MessageBox.Show("Mohon maaf tidak ada barang yang akan dikembalikan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        If Val(dibayarTextBox.Text) < Val(totalTextBox.Text) Then
            MessageBox.Show("Mohon maaf, pembayaran kurang.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_jual WHERE no_penjualan = '" & noPenjualanTb.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then

            Else
                MessageBox.Show("Mohon maaf tidak ada transaksi dengan no penjualan '" & noPenjualanTb.Text & "'", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try

        Try
            bukaKoneksi()
            syntaxSQL = "INSERT INTO tbl_retur_jual VALUES('" & idTextBox.Text & "','" & tanggalDateTimePicker.Text & "', '" & noPenjualanTb.Text & "','" & iduserTextBox.Text &
                "','" & konsumenTextBox.Text & "','" & namaKonsumenTextBox.Text & "'," & totalTextBox.Text & "," & dibayarTextBox.Text & "," & kembalianTextBox.Text & ")"
            Console.WriteLine(syntaxSQL)
            comSQL = New SqlCommand(syntaxSQL, conn)
            comSQL.ExecuteNonQuery()




            For baris As Integer = 0 To akanDGV.RowCount - 2
                syntaxSQL = "INSERT INTO tbl_retur_jual_detail VALUES('" & idTextBox.Text & "','" & akanDGV.Rows(baris).Cells(0).Value & "','" & akanDGV.Rows(baris).Cells(4).Value &
                    "','" & akanDGV.Rows(baris).Cells(5).Value & "')"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()


                syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & akanDGV.Rows(baris).Cells(0).Value & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                dr = comSQL.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    syntaxSQL = "UPDATE tbl_barang SET jumlah = " & dr(3) + akanDGV.Rows(baris).Cells(4).Value & "WHERE id_barang = '" & akanDGV.Rows(baris).Cells(0).Value & "'"
                    dr.Close()
                    comSQL = New SqlCommand(syntaxSQL, conn)
                    comSQL.ExecuteNonQuery()

                End If






            Next



            MessageBox.Show("Retur penjualan berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadSub()




        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try

    End Sub

    Private Sub hapusButton_Click(sender As Object, e As EventArgs) Handles hapusButton.Click
        loadSub()

    End Sub
End Class