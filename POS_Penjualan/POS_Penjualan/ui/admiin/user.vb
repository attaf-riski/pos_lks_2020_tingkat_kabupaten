Imports System.Data.SqlClient


Public Class user
    Public Sub loadSub() Handles MyBase.Load
        caridata(True, "", cariTextBox.Text, Today, Today)

    End Sub

    Sub caridata(isFromLoad As Boolean, berdasarkan As String, cari As String, dari As Date, sampai As Date)
        dataDataGridView.Rows.Clear()

        Try
            bukaKoneksi()

            If isFromLoad Then
                syntaxSQL = "select * from tbl_user"

            Else
                syntaxSQL = "select * from tbl_user where " & berdasarkan & " like '%" & cari & "%'"

            End If
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                Dim sebagai As String
                Select Case Strings.Right(dr(0), 2)
                    Case "01"
                        sebagai = adminStr
                    Case "02"
                        sebagai = petugasStr
                End Select

                dataDataGridView.Rows.Add(dr(0), dr(2), dr(3), dr(4), sebagai)
            Loop

        Catch ex As Exception

            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        Finally
            tutupKoneksi()
            dr.Close()

        End Try
    End Sub

    Private Sub cariTextBox_TextChanged(sender As Object, e As EventArgs) Handles cariTextBox.TextChanged
        Dim berdasarkan As String = "id_user"

        Select Case dasarComboBox.Text
            Case "ID user"
                berdasarkan = "id_user"
            Case "Nama user"
                berdasarkan = "nama_user"



        End Select


        caridata(False, berdasarkan, cariTextBox.Text, Today, Today)
    End Sub

    Private Sub kelolaButton_Click(sender As Object, e As EventArgs) Handles kelolaButton.Click
        With userKelola
            .TopLevel = False
            .loadSub()
            menuTemplate.fillPanel.Controls.Add(userKelola)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class