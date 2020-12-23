Imports System.Data.SqlClient

Public Class userKelola
    Public Sub loadSub() Handles MyBase.Load
        contentPanel.Height = (Me.Height - Panel1.Height - 10)
        contentPanel.Left = (Me.Width - contentPanel.Width) / 2

        loadSub()


    End Sub

    Private Sub kelolaButton_Click(sender As Object, e As EventArgs) Handles kelolaButton.Click
        With user
            .TopLevel = False
            .loadSub()
            menuTemplate.fillPanel.Controls.Add(user)
            .BringToFront()
            .Show()
        End With
    End Sub


    Sub kembaliKeAwal()

        idTextBox.Clear()

    End Sub

    Sub bersih()
        namaTextBox.Clear()
        passTextBox.Clear()
        alamatTextBox.Clear()
        noTextBox.Clear()
        statusComboBox.Text = ""
        statusComboBox.Enabled = True

    End Sub

    Private Sub idTextBox_TextChanged(sender As Object, e As EventArgs) Handles idTextBox.TextChanged
        idCountLabel.Text = idTextBox.Text.ToString.Length & "/10"

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_user WHERE id_user = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                passTextBox.Text = dr(1)
                namaTextBox.Text = dr(2)
                alamatTextBox.Text = dr(3)
                noTextBox.Text = dr(4)

                Select Case Strings.Right(dr(0), 2)
                    Case "01"
                        statusComboBox.Text = adminStr
                        statusComboBox.Enabled = False
                    Case "02"
                        statusComboBox.Text = petugasStr
                        statusComboBox.Enabled = True
                End Select


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

    Private Sub noTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noTextBox.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub bersihButton_Click(sender As Object, e As EventArgs) Handles bersihButton.Click
        kembaliKeAwal()

    End Sub

    Private Sub noTextBox_TextChanged(sender As Object, e As EventArgs) Handles noTextBox.TextChanged

        noCountLabel.Text = noTextBox.Text.ToString.Length & "/50"
    End Sub

    Private Sub passTextBox_TextChanged(sender As Object, e As EventArgs) Handles passTextBox.TextChanged
        passCountLabel.Text = passTextBox.Text.ToString.Length & "/10"

    End Sub

    Private Sub namaTextBox_TextChanged(sender As Object, e As EventArgs) Handles namaTextBox.TextChanged
        namaCountLabel.Text = namaTextBox.Text.ToString.Length & "/50"

    End Sub

    Private Sub alamatTextBox_TextChanged(sender As Object, e As EventArgs) Handles alamatTextBox.TextChanged
        f.Text = alamatTextBox.Text.ToString.Length & "/50"

    End Sub

    Private Sub simpanButton_Click(sender As Object, e As EventArgs) Handles simpanButton.Click
        If idTextBox.Text = "" Or passTextBox.Text = "" Or namaTextBox.Text = "" Or noTextBox.Text = "" Or statusComboBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If statusComboBox.Text = adminStr Then
            MessageBox.Show("Mohon maaf, admin hanya diperbolehkan 1", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If statusComboBox.Text <> petugasStr Then
            MessageBox.Show("Mohon maaf, status tidak terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_user WHERE id_user = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                'peringatan
                MessageBox.Show("Mohon maaf, ID sudah digunakan. Gunakan ID lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                dr.Close()
                Dim idCutom As String = idTextBox.Text + "02"
                syntaxSQL = "SELECT * FROM tbl_user WHERE id_user = '" & idCutom & "'"

                comSQL = New SqlCommand(syntaxSQL, conn)
                dr = comSQL.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    'peringatan
                    MessageBox.Show("Mohon maaf, ID sudah digunakan. Gunakan ID lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                Else
                    dr.Close()
                    syntaxSQL = "INSERT INTO tbl_user VALUES('" & idCutom & "','" & passTextBox.Text & "','" & namaTextBox.Text & "','" & alamatTextBox.Text & "','" & noTextBox.Text & "')"
                    comSQL = New SqlCommand(syntaxSQL, conn)
                    comSQL.ExecuteNonQuery()

                    MessageBox.Show("user berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadSub()
                End If




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
        If idTextBox.Text = "" Or passTextBox.Text = "" Or namaTextBox.Text = "" Or noTextBox.Text = "" Or statusComboBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If statusComboBox.Text <> petugasStr Then
            MessageBox.Show("Mohon maaf, status tidak terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_user WHERE id_user = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()
                syntaxSQL = "UPDATE tbl_user SET  nama_user = '" & namaTextBox.Text & "', password = '" & passTextBox.Text & "',alamat = '" & alamatTextBox.Text & "', no_ponsel = '" & noTextBox.Text & "' WHERE id_user = '" & idTextBox.Text & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()

                MessageBox.Show("user berhasil diedit!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadSub()
            Else
                'peringatan
                'peringatan
                MessageBox.Show("Mohon maaf, user belum disimpan. Simpan dahulu user.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        'admin tidak boleh dihapus
        If idTextBox.Text = "" Or passTextBox.Text = "" Or namaTextBox.Text = "" Or noTextBox.Text = "" Or statusComboBox.Text = "" Then
            MessageBox.Show("Mohon maaf, mohon  isi semua kolom", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If statusComboBox.Text = adminStr Then
            MessageBox.Show("Mohon maaf, admin tidak boleh dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If statusComboBox.Text <> petugasStr Then
            MessageBox.Show("Mohon maaf, status tidak terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            bukaKoneksi()
            syntaxSQL = "SELECT * FROM tbl_user WHERE id_user = '" & idTextBox.Text & "'"
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                dr.Close()
                syntaxSQL = "Delete tbl_user WHERE id_user = '" & idTextBox.Text & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                comSQL.ExecuteNonQuery()

                MessageBox.Show("user berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadSub()
            Else
                'peringatan
                'peringatan
                MessageBox.Show("Mohon maaf, user belum disimpan. Simpan dahulu user.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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