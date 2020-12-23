Imports System.Data.SqlClient

Public Class lapReturPengembalian
    Public Sub loadSub() Handles MyBase.Load
        caridata(True, "", "", cariTextBox.Text, Today, Today)

    End Sub

    Sub caridata(isFromLoad As Boolean, tbl_name As String, berdasarkan As String, cari As String, dari As Date, sampai As Date)
        dataDataGridView.Rows.Clear()

        Try
            bukaKoneksi()

            If isFromLoad Then
                syntaxSQL = "select * from tbl_retur_beli b, tbl_retur_beli_detail bd where b.no_retur_Pembelian = bd.no_retur_Pembelian"

            Else
                syntaxSQL = "select *  from tbl_retur_beli b, tbl_retur_beli_detail bd where b.no_retur_Pembelian = bd.no_retur_Pembelian and " & tbl_name & "." & berdasarkan & " like '%" & cari & "%'"


            End If

            Console.WriteLine(syntaxSQL)
            comSQL = New SqlCommand(syntaxSQL, conn)
            dr = comSQL.ExecuteReader
            Do While dr.Read
                If isFromLoad Then
                    dataDataGridView.Rows.Add(dr.Item("no_retur_Pembelian"), dr.Item("tanggal_retur_Pembelian"), dr.Item("no_Pembelian"), dr.Item("id_user"), dr.Item("id_pemasok"), dr.Item("nama_pemasok"), dr.Item("id_barang"), dr.Item("jumlah"), dr.Item("total_harga_barang"))
                Else
                    Dim sekarang As DateTime = dr(1)
                    If Date.Compare(sekarang, dari) <= 0 And Date.Compare(sekarang, sampai) >= 0 Then
                        dataDataGridView.Rows.Add(dr.Item("no_retur_Pembelian"), dr.Item("tanggal_retur_Pembelian"), dr.Item("no_Pembelian"), dr.Item("id_user"), dr.Item("id_pemasok"), dr.Item("nama_pemasok"), dr.Item("id_barang"), dr.Item("jumlah"), dr.Item("total_harga_barang"))

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
        Dim berdasarkan As String = "no_retur_Pembelian"
        Dim tblName As String = "b"
        Select Case dasarComboBox.Text
            Case "No Retur Pembelian"
                berdasarkan = "no_retur_Pembelian"
                tblName = "b"
            Case "No Pembelian"
                berdasarkan = "no_Pembelian"
                tblName = "b"

            Case "ID User"
                berdasarkan = "id_user"
                tblName = "b"

            Case "ID Pemasok"
                berdasarkan = "id_pemasok"
                tblName = "b"

            Case "ID Barang"
                berdasarkan = "id_barang"
                tblName = "bd"


        End Select


        caridata(False, tblName, berdasarkan, cariTextBox.Text, DateTimePicker1.Text, DateTimePicker2.Text)
    End Sub
End Class