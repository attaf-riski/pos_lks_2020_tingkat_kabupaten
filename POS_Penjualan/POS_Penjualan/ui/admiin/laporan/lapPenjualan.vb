Imports System.Data.SqlClient

Public Class lapPenjualan
    Public Sub loadSub() Handles MyBase.Load
        caridata(True, "", "", cariTextBox.Text, Today, Today)

    End Sub

    Sub caridata(isFromLoad As Boolean, tbl_name As String, berdasarkan As String, cari As String, dari As Date, sampai As Date)
        dataDataGridView.Rows.Clear()

        Try
            bukaKoneksi()

            If isFromLoad Then
                syntaxSQL = "select * from tbl_jual b, tbl_jual_detail bd where b.no_penjualan = bd.no_penjualan"

            Else
                syntaxSQL = "select *  from tbl_jual b, tbl_jual_detail bd where b.no_penjualan = bd.no_penjualan and " & tbl_name & "." & berdasarkan & " like '%" & cari & "%'"


            End If

            Console.WriteLine(syntaxSQL)
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                If isFromLoad Then
                    dataDataGridView.Rows.Add(dr.Item("no_penjualan"), dr.Item("tanggal_penjualan"), dr.Item("id_user"), dr.Item("id_konsumen"), dr.Item("nama_konsumen"), dr.Item("id_barang"), dr.Item("harga_barang"), dr.Item("jumlah"), dr.Item("total_harga_barang"))
                Else
                    Dim sekarang As DateTime = dr(1)
                    If Date.Compare(sekarang, dari) <= 0 And Date.Compare(sekarang, sampai) >= 0 Then
                        dataDataGridView.Rows.Add(dr.Item("no_penjualan"), dr.Item("tanggal_penjualan"), dr.Item("id_user"), dr.Item("id_konsumen"), dr.Item("nama_konsumen"), dr.Item("id_barang"), dr.Item("harga_barang"), dr.Item("jumlah"), dr.Item("total_harga_barang"))

                    End If
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

    Private Sub cariTextBox_TextChanged(sender As Object, e As EventArgs) Handles cariTextBox.TextChanged
        Dim berdasarkan As String = "no_penjualan"
        Dim tblName As String = "b"
        Select Case dasarComboBox.Text
            Case "No pembelian"
                berdasarkan = "no_penjualan"
            Case "ID User"
                berdasarkan = "id_user"

            Case "ID Konsumen"
                berdasarkan = "id_konsumen"

            Case "ID Barang"
                berdasarkan = "id_barang"


        End Select


        caridata(False, tblName, berdasarkan, cariTextBox.Text, DateTimePicker1.Text, DateTimePicker2.Text)
    End Sub
End Class