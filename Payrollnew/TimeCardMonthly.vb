Imports System.Data.SqlClient

Public Class TimeCardMonthly
    Private Sub TimeCardMonthly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAll()
    End Sub
    Sub FillAll()
        fillUnitcode()
        FillComapnyCode()
        fillDepartment()
        fillDesignation()
        fillGrademas()
        fillSectionmas()
        fillFormXIGroup()
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
    Sub fillFormXIGroup()

        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Grpname) From F11Grp  Order By Grpname", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbFromXI.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbFromXI.Items.Add(drow(0).ToString())
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


    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT Empmas.Eno,Empmas.Name,Desigmas.Designame,P01,P02,P03,P04,P05,P06,P07,P08,P09,P10,P11,P12,P13,P14,P15,P16,P17,P18,P19,P20,P21,P22,P23,P24,P25,P26,P27,P28,P29," &
                                 "P30,P31,P32,P33,P34,P35,P36,P37,P38,P39,P40,P41,P42,P43,P44,P45,P46,P47,P48,P49,P50,P51,P52,P53,P54,P55,P56,P57,P58,P59,P60,P61,P62,OT01,OT02,OT03,OT04,OT05,OT06,OT07,OT08, " &
                                 "OT09,OT10,OT11,OT12,OT13,OT14,OT15,OT16,OT17,OT18,OT19,OT20,OT21,OT22,OT23,OT24,OT25,OT26,OT27,OT28,OT29,OT30,OT31,Attn01,Attn02,Attn03,Attn04,Attn05,Attn06,Attn07,Attn08,Attn09, " &
                                 "Attn10,Attn11,Attn12,Attn13,Attn14,Attn15,Attn16,Attn17,Attn18,Attn19,Attn20,Attn21,Attn22,Attn23,Attn24,Attn25,Attn26,Attn27,Attn28,Attn29,Attn30,Attn31,Totshift,Totot From Mtime INNER JOIN Empmas ON Mtime.Eno=Empmas.Eno " &
                                         "INNER JOIN Deptmas ON Deptmas.DeptID = Empmas.DeptID INNER JOIN Desigmas ON Desigmas.DesigID = Empmas.DesigID " &
                                         "INNER JOIN Grademas ON Grademas.GradeID = Empmas.GradeID INNER JOIN Vehmas ON Vehmas.VehID = Empmas.VehID  " &
                                        "WHERE  Empmas.Compcode='" & CmbcompanyCode.SelectedItem & "' And Empmas.Unitcode='" & CmbUnitnCode.SelectedItem & "' And " &
                                        "Empmas.Empcatg='" & Cmbcategory.SelectedItem & "'And Mtime.Smonth='" & CDate(DateTimePicker1.Value).ToString("yyyyMMM") & "'", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dgw.Rows.Clear()
            While (rdr.Read() = True)
                Dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12), rdr(13), rdr(14), rdr(15), rdr(16), rdr(17), rdr(18), rdr(19), rdr(20), rdr(21), rdr(22),
                            rdr(23), rdr(24), rdr(25), rdr(26), rdr(27), rdr(28), rdr(29), rdr(30), rdr(31), rdr(32), rdr(33), rdr(34), rdr(35), rdr(36), rdr(37), rdr(38), rdr(39), rdr(40), rdr(41), rdr(42), rdr(43), rdr(44), rdr(45), rdr(46),
                             rdr(47), rdr(48), rdr(49), rdr(50), rdr(51), rdr(52), rdr(53), rdr(54), rdr(55), rdr(56), rdr(57), rdr(58), rdr(59), rdr(60), rdr(61), rdr(62), rdr(63), rdr(64), rdr(65), rdr(66), rdr(67), rdr(68),
                              rdr(69), rdr(70), rdr(71), rdr(72), rdr(73), rdr(74), rdr(75), rdr(76), rdr(77), rdr(78), rdr(79), rdr(80), rdr(81), rdr(82), rdr(83), rdr(84), rdr(85), rdr(86), rdr(87), rdr(88), rdr(89), rdr(90),
                              rdr(91), rdr(92), rdr(93), rdr(94), rdr(95), rdr(96), rdr(97), rdr(98), rdr(99), rdr(100), rdr(101), rdr(102), rdr(103), rdr(104), rdr(105), rdr(106), rdr(107), rdr(108), rdr(109), rdr(110), rdr(111), rdr(112),
                              rdr(113), rdr(114), rdr(115), rdr(116), rdr(117), rdr(118), rdr(119), rdr(120), rdr(121), rdr(122), rdr(123), rdr(124), rdr(125), rdr(126), rdr(127), rdr(128))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        ExportExcel(Dgw)
    End Sub
End Class