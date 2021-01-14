Imports System.IO
Imports System.Data.OleDb
Imports System.Data.SqlClient
Module ModCS
    Dim st As String
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Payrollnew.mdb")
    Dim Con As New SqlConnection
    Public Function ReadCS() As String
        intconnection()
        ' intconnection1()
        Con.ConnectionString = "Data Source='" & datasource & "';Initial Catalog='" & Catalog1 & "';User ID='" & userid & "';Password='" & password1 & "'"
        st = "Data Source='" & datasource & "';Initial Catalog='" & Catalog1 & "';User ID='" & userid & "';Password='" & password1 & "'"
        Return st
    End Function
    Public ReadOnly cs As String = ReadCS()
    Public Sub intconnection()
        Dim dTable As New DataTable()
        adap1 = New OleDbDataAdapter("select * From Dbconnection", conn)
        adap1.Fill(dTable)
        If dTable.Rows.Count <> 0 Then
            datasource = dTable.Rows(0)("DBSource").ToString()
            Catalog1 = dTable.Rows(0)("DBName").ToString()
            userid = dTable.Rows(0)("DBUser").ToString()
            password1 = dTable.Rows(0)("DBPassword").ToString()
        End If
        conn.Close()
    End Sub

End Module
