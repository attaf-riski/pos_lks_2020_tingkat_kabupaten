Imports System.Data.SqlClient

Public Class retur_pembelian
    Public Sub loadSub() Handles MyBase.Load
        'id otomatis
        idOtomatis()

        'set user

        If idStr = "" Then
            idUserTextBox.Text = "111201"
            namaTextBox.Text = "ataf"
        Else
            idUserTextBox.Text = idStr
            namaTextBox.Text = nameStr
        End If





        'bersij
        bersih()
    End Sub

    Sub bersih()
        idPemasokTB.Clear()
        namaPemasokTextBox.Clear()
        noPembelianTextBox.Clear()
        idBarangComboBox.Items.Clear()
        jumlahDibeliTextBox.Text = "0"
        jumlahBarangDikembalikanTextBox.Text = "0"
        akanDGV.Rows.Clear()
        daftarDataGridView.Rows.Clear()
        totalTextBox.Text = "0"
        dibayarTextBox.Text = "0"
        kembalikanTextBox.Text = "0"
    End Sub


    Sub idOtomatis()
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_retur_beli ORDER BY no_retur_pembelian DESC"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                If Strings.Mid(dr(0), 3, 6) = Format(Today, "yyMMdd") Then
                    idTextBox.Text = "RB" & Format(Strings.Right(dr(0), 8) + 1, "00")
                Else
                    idTextBox.Text = "RB" & Format(Today, "yyMMdd") & "01"
                End If
            Else
                idTextBox.Text = "RB" & Format(Today, "yyMMdd") & "01"
            End If

        Catch ex As Exception
            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub idPemasokTB_TextChanged(sender As Object, e As EventArgs) Handles idPemasokTB.TextChanged
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_pemasok WHERE id_pemasok = '" & idPemasokTB.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                namaPemasokTextBox.Text = dr(1)
            Else
                namaPemasokTextBox.Clear()

            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub nopembelianTextBox_TextChanged(sender As Object, e As EventArgs) Handles noPembelianTextBox.TextChanged
        'update dgv barang dibeli 
        'update id barang

        daftarDataGridView.Rows.Clear()
        akanDGV.Rows.Clear()
        idBarangComboBox.Items.Clear()


        'isi id barang

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT jd.id_barang FROM tbl_beli j, tbl_beli_detail jd WHERE j.no_pembelian = jd.no_pembelian and j.no_pembelian = '" & noPembelianTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                idBarangComboBox.Items.Add(dr(0))
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
            syntaxSQL = "SELECT jd.id_barang,b.nama_barang,b.kategori,jd.harga_barang,jd.jumlah,jd.total_harga_barang FROM tbl_beli j, tbl_beli_detail jd,tbl_barang b WHERE jd.id_barang = b.id_barang and j.no_pembelian = jd.no_pembelian and j.no_pembelian = '" & noPembelianTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                daftarDataGridView.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
            Loop

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try

    End Sub

    Private Sub idBarangComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idBarangComboBox.SelectedIndexChanged
        Try
            bukaKoneksi()
            syntaxSQL = "SELECT b.nama_barang,jd.jumlah FROM tbl_barang b, tbl_beli_detail jd WHERE b.id_barang = jd.id_barang and jd.no_pembelian = '" & noPembelianTextBox.Text & "' and jd.id_barang = '" & idBarangComboBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                namaBarangTextBox.Text = dr(0)
                jumlahDibeliTextBox.Text = dr(1)
            Else
                namaBarangTextBox.Clear()
                jumlahDibeliTextBox.Text = "0"


            End If

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub dibayarTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlahBarangDikembalikanTextBox.KeyPress, dibayarTextBox.KeyPress
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
        If noPembelianTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom no pembelian", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If idBarangComboBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon pilih id barang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Val(jumlahDibeliTextBox.Text) <= 0 Then
            MessageBox.Show("Mohon maaf, barang dikembalikan harus lebih dari 0", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If Val(jumlahBarangDikembalikanTextBox.Text) > Val(jumlahDibeliTextBox.Text) Then
            MessageBox.Show("Mohon maaf, barang dikembalikan harus kurang / sama dengan barang dibeli", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT b.nama_barang,b.kategori,jd.harga_barang FROM tbl_barang b, tbl_beli_detail jd WHERE b.id_barang = jd.id_barang and jd.no_pembelian = '" & noPembelianTextBox.Text & "' and jd.id_barang = '" & idBarangComboBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                Dim kembalikan As Integer = dr(2) * Val(jumlahBarangDikembalikanTextBox.Text)
                akanDGV.Rows.Add(idBarangComboBox.Text, namaBarangTextBox.Text, dr(1), dr(2), jumlahBarangDikembalikanTextBox.Text, kembalikan)
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
        jumlahDibeliTextBox.Text = "0"
        jumlahBarangDikembalikanTextBox.Text = "0"


        hitungTotalBiaya()
    End Sub

    Private Sub bersihButton_Click(sender As Object, e As EventArgs) Handles bersihButton.Click
        If noPembelianTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom no pembelian", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If idBarangComboBox.Text = "" Then
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
        kembalikanTextBox.Text = Val(dibayarTextBox.Text) - Val(totalTextBox.Text)

    End Sub

    Private Sub simpanButton_Click(sender As Object, e As EventArgs) Handles simpanButton.Click
        If idPemasokTB.Text = "" Or namaPemasokTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom id pemasok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If noPembelianTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi no pembelian", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            syntaxSQL = "SELECT * FROM tbl_beli WHERE no_pembelian = '" & noPembelianTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then

            Else
                MessageBox.Show("Mohon maaf tidak ada transaksi dengan no pembelian '" & noPembelianTextBox.Text & "'", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            syntaxSQL = "INSERT INTO tbl_retur_beli VALUES('" & idTextBox.Text & "','" & tanggalDateTimePicker.Text & "', '" & noPembelianTextBox.Text & "','" & idUserTextBox.Text &
                "','" & idPemasokTB.Text & "','" & namaPemasokTextBox.Text & "'," & totalTextBox.Text & "," & dibayarTextBox.Text & "," & kembalikanTextBox.Text & ")"
            Console.WriteLine(syntaxSQL)
            comSQL = New SqlCommand(syntaxSQL, conn)
            comSQL.ExecuteNonQuery()




            For baris As Integer = 0 To akanDGV.RowCount - 2
                syntaxSQL = "INSERT INTO tbl_retur_beli_detail VALUES('" & idTextBox.Text & "','" & akanDGV.Rows(baris).Cells(0).Value & "','" & akanDGV.Rows(baris).Cells(3).Value & "','" & akanDGV.Rows(baris).Cells(4).Value &
                    "','" & akanDGV.Rows(baris).Cells(5).Value & "')"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()


                syntaxSQL = "SELECT * FROM tbl_barang WHERE id_barang = '" & akanDGV.Rows(baris).Cells(0).Value & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                dr = comSQL.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    syntaxSQL = "UPDATE tbl_barang SET jumlah = " & dr(3) - akanDGV.Rows(baris).Cells(4).Value & "WHERE id_barang = '" & akanDGV.Rows(baris).Cells(0).Value & "'"
                    dr.Close()
                    comSQL = New SqlCommand(syntaxSQL, conn)
                    comSQL.ExecuteNonQuery()

                End If






            Next



            MessageBox.Show("Retur pembelian berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
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