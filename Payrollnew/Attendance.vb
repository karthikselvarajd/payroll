
Imports System.Data.SqlClient

Public Class Attendance

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        ProgressBar1.Visible = False
        FillAll()
    End Sub
    Sub FillAll()
        fillShiftcode()
        fillUnitcode()
        FillComapnyCode()
        fillDepartment()
        fillDesignation()
        fillGrademas()
        fillSectionmas()
        FilVehicleSub()
    End Sub
    Sub FilVehicleSub()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Vehname) From Vehmas  Order By Vehname", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbVehicle.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbVehicle.Items.Add(drow(0).ToString())
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
    Sub fillShiftcode()

        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Shiftcode) From Shiftmas  Order By Shiftcode", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbShiftCode.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbShiftCode.Items.Add(drow(0).ToString())
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



    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles ListView1.DrawItem
        e.DrawBackground()
        e.DrawDefault = True
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        Using sf = New StringFormat()
            sf.Alignment = StringAlignment.Center
        End Using
        e.Graphics.DrawLine(Pens.Black, e.Bounds.X, e.Bounds.Y, e.Bounds.Left, e.Bounds.Right)
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
        Using sf = New StringFormat()
            sf.Alignment = StringAlignment.Center

            Using headerFont = New System.Drawing.Font("Segoe UI", 8, FontStyle.Bold)
                e.Graphics.FillRectangle(Brushes.Indigo, e.Bounds)
                e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.White, e.Bounds, sf)
            End Using
        End Using
        e.Graphics.DrawLine(Pens.Silver, e.Bounds.X, e.Bounds.Y, e.Bounds.Left, e.Bounds.Right)
        e.DrawDefault = False
    End Sub

    Private Sub ListView1_MouseUp(sender As Object, e As MouseEventArgs) Handles ListView1.MouseUp
        Dim clickedItem As ListViewItem = ListView1.GetItemAt(5, e.Y)
        If (clickedItem IsNot Nothing) Then
            clickedItem.Selected = True
            clickedItem.Focused = True
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Using cmd As New SqlCommand()
                Strsql = "SELECT Empmas.Eno,Empmas.Name,Empmas.Cardno,Sectionmas.Secname,Deptmas.Deptname,Desigmas.Designame,Grademas.Gradename As [Grade]," &
                                                                     "Empmas.Sex As [Gender],Tempdata.Sin,Tempdata.La,Tempdata.Status From Tempdata INNER JOIN Empmas ON Tempdata.Eno=Empmas.Eno " &
                                                "INNER JOIN Deptmas ON Deptmas.DeptID = Empmas.DeptID INNER JOIN Desigmas ON Desigmas.DesigID = Empmas.DesigID " &
                                                "INNER JOIN Sectionmas ON Sectionmas.SecID = Empmas.SecID " &
                                                "INNER JOIN Grademas ON Grademas.GradeID = Empmas.GradeID INNER JOIN Vehmas ON Vehmas.VehID = Empmas.VehID " &
                                               "WHERE Empmas.Empcatg='" & Cmbcategory.Text & "'And Empmas.Shiftcode ='" & CmbShiftCode.SelectedItem & "' And Empmas.Compcode='" & CmbcompanyCode.SelectedItem & "' And Empmas.Unitcode='" & CmbUnitnCode.SelectedItem & "'And Shiftdt='" & CDate(DateTimePicker1.Value).ToString("yyyyMMdd") & "'"
                Dim strsql1 As String = "Select Count(Empmas.Eno), count(Case When status ='P' then 1 end) as absent_count,count(case when status ='AB' then 1 end) as present_count, " &
                                "count(case when Empmas.Sex ='Male' then 1  end) as Male_count,count(case when Empmas.Sex ='Male'and Status ='P'then 1  end) as MalPr_count,  " &
                                "count(case when Empmas.Sex ='Male'and Status ='AB'then 1 end) as MalAb_count,count(case when Empmas.Sex ='Female' then 1 end) as Female_count, " &
                                "count(case when Empmas.Sex ='Female'and Status ='P'then 1 end) as FeMalPr_count, count(case when Empmas.Sex ='Female'and Status ='AB'then 1 end) as FemAb_count " &
                                " From Tempdata INNER JOIN Empmas ON Tempdata.Eno = Empmas.Eno INNER JOIN Deptmas ON Deptmas.DeptID = Empmas.DeptID INNER JOIN Desigmas ON Desigmas.DesigID = Empmas.DesigID " &
                             " INNER JOIN Sectionmas ON Sectionmas.SecID = Empmas.SecID INNER JOIN Grademas ON Grademas.GradeID = Empmas.GradeID INNER JOIN Vehmas ON Vehmas.VehID = Empmas.VehID WHERE Empmas.Empcatg='" & Cmbcategory.Text & "'and Empmas.Shiftcode='" & CmbShiftCode.Text & "'" &
                             "And Empmas.Unitcode='" & CmbUnitnCode.Text & "'And Shiftdt ='" & CDate(DateTimePicker1.Value).ToString("yyyyMMdd") & "'" &
                             "And Empmas.Lstatus= '" & IsDBNull("NULL") & "'"

                If Not String.IsNullOrEmpty(CmbDesign.SelectedItem) Then
                    Strsql += " And Desigmas.Designame Like '" + CmbDesign.SelectedItem + "'"
                    strsql1 += " and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbDepart.SelectedItem) Then
                    Strsql += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'"
                    strsql1 += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) Then
                    Strsql += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'"
                    strsql1 += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbGrade.SelectedItem) Then
                    Strsql += " and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'"
                    strsql1 += " and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) And Not String.IsNullOrEmpty(CmbGrade.SelectedItem) Then
                    Strsql += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'"
                    strsql1 += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
                    Strsql += " and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                    strsql1 += " and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
                    Strsql += " and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                    strsql1 += " and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) And Not String.IsNullOrEmpty(CmbGrade.SelectedItem) And Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
                    Strsql += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                    strsql1 += " and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "'and Desigmas.Designame LIke '" + CmbDesign.SelectedItem + "'and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbGrade.SelectedItem) And Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
                    Strsql += "and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                    strsql1 += "and Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "'and Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbVehicle.SelectedItem) Then
                    Strsql += "and Vehmas.Vehname LIke '" + CmbVehicle.SelectedItem + "'"
                    strsql1 += "and Vehmas.Vehname LIke '" + CmbVehicle.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(CmbVehicle.SelectedItem) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) And Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbGrade.SelectedItem) And Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
                    Strsql += "and Vehmas.Vehname LIke '" + CmbVehicle.SelectedItem + "'And Desigmas.Designame Like '" + CmbDesign.SelectedItem + "' and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "' And " &
                        "Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "' And Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                    strsql1 += "and Vehmas.Vehname LIke '" + CmbVehicle.SelectedItem + "'And Desigmas.Designame Like '" + CmbDesign.SelectedItem + "' And Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "' And " &
                        "Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "' And Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(TxtEmpno.Text) And Not String.IsNullOrEmpty(TxtEmpName.Text) And Not String.IsNullOrEmpty(TxtCardno.Text) And Not String.IsNullOrEmpty(CmbVehicle.SelectedItem) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) And Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbGrade.SelectedItem) And Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
                    Strsql += " and Empmas.Eno Like'" + TxtEmpno.Text + "'and  Empmas.Name Like '" + TxtEmpName.Text + "'and Empmas.Cardno Like '" + TxtCardno.Text + "' And Vehmas.Vehname Like '" + CmbVehicle.SelectedItem + "'And Desigmas.Designame Like '" + CmbDesign.SelectedItem + "' and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "' And " &
                        "Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "' And Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                    strsql1 += " and Empmas.Eno Like'" + TxtEmpno.Text + "'and  Empmas.Name Like '" + TxtEmpName.Text + "'and Empmas.Cardno Like '" + TxtCardno.Text + "' And Vehmas.Vehname Like '" + CmbVehicle.SelectedItem + "'And Desigmas.Designame Like '" + CmbDesign.SelectedItem + "' and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "' And " &
                        "Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "' And Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
                End If
                If Not String.IsNullOrEmpty(TxtEmpno.Text) Then
                    Strsql += "and Empmas.Eno Like'" + TxtEmpno.Text + "'"
                    strsql1 += "and Empmas.Eno Like'" + TxtEmpno.Text + "'"
                End If
                If Not String.IsNullOrEmpty(TxtEmpName.Text) Then
                    Strsql += "and Empmas.Name Like'" + TxtEmpName.Text + "'"
                    strsql1 += "and Empmas.Name Like'" + TxtEmpName.Text + "'"
                End If
                If Not String.IsNullOrEmpty(TxtCardno.Text) Then
                    Strsql += "and Empmas.Cardno Like'" + TxtCardno.Text + "'"
                    strsql1 += "and Empmas.Cardno Like'" + TxtCardno.Text + "'"
                End If
                Dim dt As DataTable = New DataTable()
                con = New SqlConnection(cs)
                con.Open()
                adp = New SqlDataAdapter(Strsql, con)
                adp.Fill(dt)
                cmd.CommandText = strsql1
                cmd.Connection = con
                Using sda As New SqlDataAdapter(cmd)
                    Dim dt1 As New DataTable()
                    sda.Fill(dt1)
                    ListView1.Items.Clear()
                    For Each row As DataRow In dt.Rows
                        Dim item As ListViewItem = New ListViewItem(row(0).ToString())
                        item.SubItems.Add(row(1).ToString())
                        item.SubItems.Add(row(2).ToString())
                        item.SubItems.Add(row(3).ToString())
                        item.SubItems.Add(row(4).ToString())
                        item.SubItems.Add(row(5).ToString())
                        item.SubItems.Add(row(6).ToString())
                        item.SubItems.Add(row(7).ToString())
                        item.SubItems.Add(row(8).ToString())
                        item.SubItems.Add(row(9).ToString())
                        item.SubItems.Add(row(10).ToString())
                        ListView1.Items.Add(item)
                    Next
                    For Each row1 As DataRow In dt1.Rows
                        TotalstrengthTxt.Text = row1(0).ToString()
                        PresentTotalTxt.Text = row1(1).ToString()
                        AbsentTotal.Text = row1(2).ToString()
                        MaleTotalTxt.Text = row1(3).ToString()
                        MalePresentTxt.Text = row1(4).ToString()
                        MaleAbsentTxt.Text = row1(5).ToString()
                        FemaleTotalTxt.Text = row1(6).ToString()
                        FemalePresentTxt.Text = row1(7).ToString()
                        FemaleAbsentTxt.Text = row1(8).ToString()
                    Next
                End Using
            End Using
            ProgressBar1.Visible = False
        End If
    End Sub
End Class