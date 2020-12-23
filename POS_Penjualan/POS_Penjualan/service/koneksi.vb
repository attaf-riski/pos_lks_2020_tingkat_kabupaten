Imports System.Data.SqlClient


Module sharedPreference
    Public str As String = "Data Source=DESKTOP-AA588B3;Initial Catalog=pos_database;Integrated Security=True"
    Public syntaxSQL As String = ""
    Public comSQL As SqlClient.SqlCommand
    Public conn As New SqlConnection
    Public dr As SqlDataReader


    Public Sub bukaKoneksi()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = str
                conn.Open()
                Console.WriteLine("Terbuka Koneksi")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Public Sub tutupKoneksi()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
                Console.WriteLine("Tertutup Koneksi")
            End If
        Catch ex As Exception
            MessageBox.Show("Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
End Module
