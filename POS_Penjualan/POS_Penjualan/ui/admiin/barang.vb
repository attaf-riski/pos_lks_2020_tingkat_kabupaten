Imports System.Data.SqlClient

Public Class barang
    Public Sub loadSub() Handles MyBase.Load
        caridata(True, "", cariTextBox.Text, Today, Today)

    End Sub

    Sub caridata(isFromLoad As Boolean, berdasarkan As String, cari As String, dari As Date, sampai As Date)
        dataDataGridView.Rows.Clear()

        Try
            bukaKoneksi()

            If isFromLoad Then
                syntaxSQL = "select * from tbl_barang"

            Else
                syntaxSQL = "select * from tbl_barang where " & berdasarkan & " like '%" & cari & "%'"

            End If

            Console.WriteLine(syntaxSQL)
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                dataDataGridView.Rows.Add(dr(0), dr(1), dr(2), dr(3), FormatCurrency(dr(4)), FormatCurrency(dr(5)))
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
        Dim berdasarkan As String = "id_barang"

        Select Case dasarComboBox.Text
            Case "ID Barang"
                berdasarkan = "id_barang"
            Case "Nama Barang"
                berdasarkan = "nama_barang"

            Case "Kategori"
                berdasarkan = "kategori"

        End Select


        caridata(False, berdasarkan, cariTextBox.Text, Today, Today)
    End Sub

    Private Sub kelolaButton_Click(sender As Object, e As EventArgs) Handles kelolaButton.Click
        With barangKelola
            .TopLevel = False
            .loadSub()
            menuTemplate.fillPanel.Controls.Add(barangKelola)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class