Imports System.Data.SqlClient

Public Class login
    Public Sub loadSub() Handles MyBase.Load
        passPanel.Height = 0

        idTextBox.Clear()
        passTextBox.Clear()

        idTextBox.Focus()

    End Sub





    Private Sub passTextBox_TextChanged(sender As Object, e As EventArgs) Handles passTextBox.TextChanged
        passCountLabel.Text = passTextBox.Text.ToString.Length & "/10"
    End Sub

    Private Sub idTextBox_TextChanged(sender As Object, e As EventArgs) Handles idTextBox.TextChanged
        idCountLabel.Text = idTextBox.Text.ToString.Length & "/10"
    End Sub




    Private Sub Buttologinn_Click(sender As Object, e As EventArgs) Handles Buttologinn.Click
        If idTextBox.Text = "" Then
            MessageBox.Show("Mohon maaf mohon isi kolom id", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        If Strings.Right(idTextBox.Text, 2) = "01" Or Strings.Right(idTextBox.Text, 2) = "02" Then

            Select Case Strings.Right(idTextBox.Text, 2)
                Case "01"
                    levelStr = adminStr
                Case "02"
                    levelStr = petugasStr
            End Select





            'masuk
            Try
                bukaKoneksi()

                syntaxSQL = "SELECT * FROM tbl_user WHERE id_user  = '" & idTextBox.Text & "'"
                comSQL = New SqlCommand(syntaxSQL, conn)
                dr = comSQL.ExecuteReader
                dr.Read()

                If dr.HasRows Then
                    If passPanel.Height <= 0 Then
                        MessageBox.Show("Anda memiliki hak khusus, masukan password", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Timer1.Enabled = True
                        passTextBox.Focus()
                        Exit Sub
                    End If

                    dr.Close()
                    syntaxSQL = "SELECT * FROM tbl_user WHERE id_user  = '" & idTextBox.Text & "' and password = '" & passTextBox.Text & "'"
                    comSQL = New SqlCommand(syntaxSQL, conn)
                    dr = comSQL.ExecuteReader
                    dr.Read()

                    If dr.HasRows Then
                        nameStr = dr(2)
                        idStr = dr(0)
                        Me.Hide()
                        dr.Close()
                        tutupKoneksi()

                        With menuTemplate
                            .loadSub()
                            .Show()
                        End With

                    Else
                        MessageBox.Show("Mohon Maaf, Password Salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        passTextBox.Clear()
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Mohon Maaf, ID tidak terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    idTextBox.Clear()
                    Exit Sub
                End If

            Catch ex As Exception

                MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Console.WriteLine(ex.ToString)
            Finally
                tutupKoneksi()
                dr.Close()

            End Try
        Else
            'keluar  
            MessageBox.Show("Mohon Maaf, ID tidak terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            idTextBox.Clear()
            passPanel.Height = 0
            Exit Sub
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        passPanel.Height += 10
        If passPanel.Height >= 69 Then
            Timer1.Enabled = False
        End If
    End Sub
End Class