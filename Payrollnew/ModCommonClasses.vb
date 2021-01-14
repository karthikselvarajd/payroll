Imports System.Data.SqlClient
Imports System.Data.OleDb

Module ModCommonClasses
    Public con As SqlConnection
    Public cmd, cmd1 As SqlCommand
    Public rdr As SqlDataReader = Nothing
    Public ds As DataSet
    Public adp As SqlDataAdapter
    Public Strsql As String
    Public dtable As DataTable
    Public TempFileNames2 As String
    Public datasource As String
    Public Catalog1 As String
    Public userid As String
    Public password1 As String
    Public adap1 As OleDb.OleDbDataAdapter
    Public SearchID As String
    Public Amount As String
    Public Selecteditem As String
    Public bytImage(), bytImage1(), bytImage2() As Byte
End Module
