Imports System.Data.SqlClient

Public Class EmpAddInfo
    Private Sub EmpAddInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAll()
    End Sub
    Sub FillAll()

        fillUnitcode()
        FillComapnyCode()
        fillDepartment()
        fillDesignation()
        fillGrademas()
        fillSectionmas()
        fillF11Grp()
    End Sub
    Sub fillF11Grp()

        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Grpname) From F11Grp  Order By Grpname", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbFormXI.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbFormXI.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillGrademas()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Gradename) From Grademas  Order By Gradename", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbGrade.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbGrade.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub fillUnitcode()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Unitcode) From Unitmas  Order By Unitcode", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbUnitnCode.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbUnitnCode.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub fillDepartment()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Deptname) From Deptmas  Order By Deptname", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbDepart.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbDepart.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub fillDesignation()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Designame) From Desigmas  Order By Designame", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbDesign.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbDesign.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub FillComapnyCode()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM( Compcode) From Compmas  Order By Compcode", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbcompanyCode.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbcompanyCode.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub fillSectionmas()

        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Secname) From Sectionmas  Order By Secname", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbSection.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbSection.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        con = New SqlConnection(cs)
        con.Open()
        Strsql = "SELECT Empmas.Eno,Empmas.Name From Empmas " &
                 "INNER JOIN Deptmas ON Deptmas.DeptID = Empmas.DeptID INNER JOIN Desigmas ON Desigmas.DesigID = Empmas.DesigID " &
                 "INNER JOIN Sectionmas ON Sectionmas.SecID = Empmas.SecID " &
                 "INNER JOIN Grademas ON Grademas.GradeID = Empmas.GradeID INNER JOIN Vehmas ON Vehmas.VehID = Empmas.VehID " &
                 "WHERE Empmas.Empcatg='" & Cmbcategory.Text & "' And Empmas.Compcode='" & CmbcompanyCode.SelectedItem & "' And Empmas.Unitcode='" & CmbUnitnCode.SelectedItem & "'And Empmas.Lstatus= '" & IsDBNull("NULL") & "'"

        If Not String.IsNullOrEmpty(CmbDesign.SelectedItem) Then
            Strsql += " And Desigmas.Designame Like '" + CmbDesign.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(CmbDepart.SelectedItem) Then
            Strsql += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) Then
            Strsql += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(CmbGrade.SelectedItem) Then
            Strsql += " and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) And Not String.IsNullOrEmpty(CmbGrade.SelectedItem) Then
            Strsql += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
            Strsql += " and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
            Strsql += " and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) And Not String.IsNullOrEmpty(CmbGrade.SelectedItem) And Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
            Strsql += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(CmbGrade.SelectedItem) And Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
            Strsql += "and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(TxtEmpno.Text) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) And Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbGrade.SelectedItem) And Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
            Strsql += " and Empmas.Eno Like'" + TxtEmpno.Text + "' And Desigmas.Designame Like '" + CmbDesign.SelectedItem + "' and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "' And " &
                    "Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "' And Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(TxtEmpno.Text) Then
            Strsql += "and Empmas.Eno Like'" + TxtEmpno.Text + "'"
        End If

        cmd = New SqlCommand(Strsql)
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        Dgw.Rows.Clear()
        While (rdr.Read() = True)
            Dgw.Rows.Add(rdr(0), rdr(1))
        End While
        rdr.Close()
        cmd.Dispose()
        con.Close()
    End Sub
End Class