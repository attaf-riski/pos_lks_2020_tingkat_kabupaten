Imports System.Data.SqlClient


Public Class pemasok
    Public Sub loadSub() Handles MyBase.Load
        caridata(True, "", cariTextBox.Text, Today, Today)

    End Sub

    Sub caridata(isFromLoad As Boolean, berdasarkan As String, cari As String, dari As Date, sampai As Date)
        dataDataGridView.Rows.Clear()

        Try
            bukaKoneksi()

            If isFromLoad Then
                syntaxSQL = "select * from tbl_pemasok"

            Else
                syntaxSQL = "select * from tbl_pemasok where " & berdasarkan & " like '%" & cari & "%'"

            End If
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                dataDataGridView.Rows.Add(dr(0), dr(1), dr(2), dr(3))
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
        Dim berdasarkan As String = "id_pemasok"

        Select Case dasarComboBox.Text
            Case "ID pemasok"
                berdasarkan = "id_pemasok"
            Case "Nama pemasok"
                berdasarkan = "nama_pemasok"



        End Select


        caridata(False, berdasarkan, cariTextBox.Text, Today, Today)
    End Sub

    Private Sub kelolaButton_Click(sender As Object, e As EventArgs) Handles kelolaButton.Click
        With pemasokKelola
            .TopLevel = False
            .loadSub()
            menuTemplate.fillPanel.Controls.Add(pemasokKelola)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class