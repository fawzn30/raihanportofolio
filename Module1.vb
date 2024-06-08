
Imports System.Data.SqlClient 'namespace = ruang kerja database 

Module Module1
    Public conn As SqlConnection 'var untuk koneksi

    Public da As SqlDataAdapter 'var untuk tampilkan data ke dgv
    Public ds As DataSet 'var untuk tampilkan data ke dgv

    Public cmd As SqlCommand 'var untuk tampilkan data/ ke dalam listbox
    Public dr As SqlDataReader 'var untuk tampilkan data/ ke dalam listbox


    Public Sub Koneksi()
        conn = New SqlConnection("data source=FAWWAZ\SQLEXPRESS;initial catalog=DBTI3P;integrated security=true")
        conn.Open()

    End Sub
End Module
