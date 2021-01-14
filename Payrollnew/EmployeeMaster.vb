Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System
Imports System.Globalization

Public Class EmployeeMaster
    Dim Currentvalue As Date = Nothing
    Private Sub EmployeeMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillAll()

    End Sub
    Sub FillAll()
        fillF11Grp()
        fillUnitcode()
        FillComapnyCode()
        fillDepartment()
        fillDesignation()
        fillGrademas()
        fillSectionmas()
        FilBooldGroup()
    End Sub
    Sub FilBooldGroup()
        Try
            Dim CN As New SqlConnection(cs)
            CN.Open()
            adp = New SqlDataAdapter()
            adp.SelectCommand = New SqlCommand("SELECT  RTRIM(Bgname) From Bgmas  Order By Bgname", CN)
            ds = New DataSet("ds")
            adp.Fill(ds)
            Dim dtable As DataTable = ds.Tables(0)
            CmbBloodGroup.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbBloodGroup.Items.Add(drow(0).ToString())
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
            CmbGradeE.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbGrade.Items.Add(drow(0).ToString())
                CmbGradeE.Items.Add(drow(0).ToString())
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
            CmbDepartE.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbDepart.Items.Add(drow(0).ToString())
                CmbDepartE.Items.Add(drow(0).ToString())
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
            CmbDesignE.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbDesign.Items.Add(drow(0).ToString())
                CmbDesignE.Items.Add(drow(0).ToString())
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
            CmbcompanyCodeE.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbcompanyCode.Items.Add(drow(0).ToString())
                CmbcompanyCodeE.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
            CmbSectionE.Items.Clear()
            For Each drow As DataRow In dtable.Rows
                CmbSection.Items.Add(drow(0).ToString())
                CmbSectionE.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        con = New SqlConnection(cs)
        con.Open()
        Strsql = "SELECT Empmas.Eno,Empmas.Cardno,Empmas.Name,Fname,Sectionmas.Secname,Deptmas.Deptname,Desigmas.Designame,Grademas.Gradename As [Grade] From Empmas " &
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
        If Not String.IsNullOrEmpty(TxtEmpno.Text) And Not String.IsNullOrEmpty(TxtEmpName.Text) And Not String.IsNullOrEmpty(TxtCardno.Text) And Not String.IsNullOrEmpty(CmbDesign.SelectedItem) And Not String.IsNullOrEmpty(CmbDepart.SelectedItem) And Not String.IsNullOrEmpty(CmbGrade.SelectedItem) And Not String.IsNullOrEmpty(CmbSection.SelectedItem) Then
            Strsql += " and Empmas.Eno Like'" + TxtEmpno.Text + "'and  Empmas.Name Like '" + TxtEmpName.Text + "'and Empmas.Cardno Like '" + TxtCardno.Text + "' And Desigmas.Designame Like '" + CmbDesign.SelectedItem + "' and Deptmas.Deptname LIke '" + CmbDepart.SelectedItem + "' And " &
                    "Grademas.Gradename LIke '" + CmbGrade.SelectedItem + "' And Sectionmas.Secname LIke '" + CmbSection.SelectedItem + "'"
        End If
        If Not String.IsNullOrEmpty(TxtEmpno.Text) Then
            Strsql += "and Empmas.Eno Like'" + TxtEmpno.Text + "'"
        End If
        If Not String.IsNullOrEmpty(TxtEmpName.Text) Then
            Strsql += "and Empmas.Name Like'" + TxtEmpName.Text + "'"
        End If
        If Not String.IsNullOrEmpty(TxtCardno.Text) Then
            Strsql += "and Empmas.Cardno Like'" + TxtCardno.Text + "'"
        End If
        cmd = New SqlCommand(Strsql)
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        Dgw.Rows.Clear()
        While (rdr.Read() = True)
            Dgw.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7))
        End While
        rdr.Close()
        cmd.Dispose()
        con.Close()
    End Sub


    Private Sub Dgw_MouseClick(sender As Object, e As MouseEventArgs) Handles Dgw.MouseClick
        con = New SqlConnection(cs)
        con.Open()
        If Dgw.RowCount > 0 Then
            TabControl1.SelectedTab = TabPage1
            Strsql = "SELECT Empmas.Eno,Empmas.Cardno,Empmas.Name,FHFlag,Fname,Sex,Dob,Bgmas.Bgname,Mstatus,Educmas.Educname,Education,Mail," &
        "Compcode,Unitcode,Deptmas.Deptname,Desigmas.Designame,Sectionmas.Secname,Grademas.Gradename,Doj,Dop,Doc,D480,Confdelay , " &
        "Salbasis,Paymodemas.Paymode,PFno,Uanno,Empcatg,Esino,Dispmas.Dispname, Woff,Bankcode,Bankacno,Branchname,Branchcode,IFScode , " &
            "Isdisabled,Punchstatus,Photo,Claimstatus,Pservice,Vpf,Ismigrant,CAddr1,CAddr2,CAddr3,CAddr4,CAddr5,CPincode,CTel ," &
            " PAddr1,PAddr2,PAddr3,PAddr4,PAddr5,PPincode,PTel, " &
            "Country,Eweight,Eheight,Passportno,Passportexpdt,Ereligion,Aadhaarno,Emerno1,Emerno2,IDmark1,IDmark2,Visano,Visaexpdt,Ecaste , " &
            "Ecastecatg,Panno " &
            " From Empmas INNER JOIN Deptmas On Deptmas.DeptID = Empmas.DeptID INNER JOIN Educmas On Educmas.EducID = Empmas.EducID " &
            "INNER JOIN Paymodemas On Paymodemas.PayID = Empmas.PayID  INNER JOIN Desigmas On Desigmas.DesigID = Empmas.DesigID  " &
           "INNER JOIN Bgmas On Bgmas.BgID = Empmas.BgID INNER JOIN Dispmas On Dispmas.DispID = Empmas.DispID " &
           "INNER JOIN Sectionmas On Sectionmas.SecID = Empmas.SecID " &
           "INNER JOIN Grademas On Grademas.GradeID = Empmas.GradeID INNER JOIN Vehmas On Vehmas.VehID = Empmas.VehID " &
           "WHERE Eno='" & Dgw.SelectedRows(0).Cells(0).Value & "' And Empmas.Lstatus = '" & IsDBNull("NULL") & "'"
            cmd = New SqlCommand(Strsql)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            While (rdr.Read() = True)
                TxtEmpNoE.Text = rdr(0).ToString
                TxtCardnoE.Text = rdr(1).ToString
                TxtEmpNameE.Text = rdr(2).ToString
                CmbFH_Flag.Text = rdr(3).ToString
                TxtFatherHusband.Text = rdr(4).ToString
                CmbGender.Text = rdr(5).ToString
                DtDateofBirth.Text = rdr(6).ToString
                CmbBloodGroup.Text = rdr(7).ToString
                CmbMaritalStatus.Text = rdr(8).ToString
                CmbEducationLevel.Text = rdr(9).ToString
                TxtEducationDesc.Text = rdr(10).ToString
                TxtEmaiL_ID.Text = rdr(11).ToString
                CmbcompanyCodeE.Text = rdr(12).ToString
                CmbUnitCodeE.Text = rdr(13).ToString
                CmbDepartE.Text = rdr(14).ToString
                CmbDesignE.Text = rdr(15).ToString
                CmbSectionE.Text = rdr(16).ToString
                CmbGradeE.Text = rdr(17).ToString
                DtDateofJoin.Text = rdr(18).ToString
                DtComplProb.Text = rdr(19).ToString
                DtDateofConfirm.Text = rdr(20).ToString
                DtCompl480.Text = rdr(21).ToString
                TxtReasonDealy.Text = rdr(22).ToString
                CmbSalCalc.Text = rdr(23).ToString
                CmbPaymentMode.Text = rdr(24).ToString
                TxtPFno.Text = rdr(25).ToString
                TxtUANno.Text = rdr(26).ToString
                CmbCategoryE.Text = rdr(27).ToString
                TxtESIno.Text = rdr(28).ToString
                CmbEsiDipensary.Text = rdr(29).ToString
                ' DtWeeklyOff.Value = DateTime.ParseExact(rdr(30).ToString()).ToString()
                CmbBankCode.Text = rdr(31).ToString
                TxtAccountno.Text = rdr(32).ToString
                TxtBranchname.Text = rdr(33).ToString
                TxtBranchCode.Text = rdr(34).ToString
                TxtIFSCcode.Text = rdr(35).ToString
                CmbPunchStatus.Text = rdr(37).ToString
                TxtImagePath.Text = rdr(38).ToString
                TxtF19_F10C.Text = rdr(39).ToString
                TxtPrev_Service.Text = rdr(40).ToString
                TxtValuntoryPF.Text = Val(rdr(41).ToString)
                txtCadd1.Text = rdr(43).ToString
                txtCadd2.Text = rdr(44).ToString
                txtCadd3.Text = rdr(45).ToString
                txtCadd4.Text = rdr(46).ToString
                txtCadd5.Text = rdr(47).ToString
                txtCpincode.Text = rdr(48).ToString
                txtCmobile.Text = rdr(49).ToString
                txtPadd1.Text = rdr(50).ToString
                txtPadd2.Text = rdr(51).ToString
                txtPadd3.Text = rdr(52).ToString
                txtPadd4.Text = rdr(53).ToString
                txtPadd5.Text = rdr(54).ToString
                txtPpincode.Text = rdr(55).ToString
                txtPmobile.Text = rdr(56).ToString
                TxtCountry.Text = rdr(57).ToString
                TxtWeight.Text = rdr(58).ToString
                TxtHeight.Text = rdr(59).ToString
                TxtPassport.Text = rdr(60).ToString
                DtPassportExp.Text = rdr(61).ToString
                TxtReligion.Text = rdr(62).ToString
                TxtAaadhaarno.Text = rdr(63).ToString
                TxtEmer1.Text = rdr(64).ToString
                TxtEmer2.Text = rdr(65).ToString
                TxtIDMark1.Text = rdr(66).ToString
                TxtIDMark2.Text = rdr(67).ToString
                TxtVisano.Text = rdr(68).ToString
                DtVisaExp.Text = rdr(69).ToString
                TxtCaste.Text = rdr(70).ToString
                TxtCommunity.Text = rdr(71).ToString
                TxtPanCard.Text = rdr(72).ToString
                If rdr(36) = True Then
                    ChkDisabled.Checked = True
                Else
                    ChkDisabled.Checked = False
                End If
                If rdr(42) = True Then
                    ChkMigrantEmp.Checked = True
                Else
                    ChkMigrantEmp.Checked = False
                End If
            End While
            rdr.Close()
            cmd.Dispose()
            con.Close()
            Dim data As New SqlDataAdapter("SELECT Empphoto  FROM Empphotos WHERE Eno ='" & Dgw.SelectedRows(0).Cells(0).Value & "'", con)
            Dim dTable As New DataTable
            data.Fill(dTable)
            PictureBox1.Image = Nothing
            If dTable.Rows.Count > 0 Then
                Dim myMS As New IO.MemoryStream
                If Not IsDBNull(dTable.Rows(0).Item("Empphoto")) Then
                    bytImage = dTable.Rows(0).Item("Empphoto")
                    For Each ar As Byte In bytImage
                        myMS.WriteByte(ar)
                    Next
                    PictureBox1.Image = System.Drawing.Image.FromStream(myMS)
                End If
            End If
        End If

    End Sub




    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics
        Dim sText As String

        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF

        Dim ctlTab As TabControl

        ctlTab = CType(sender, TabControl)

        g = e.Graphics

        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)

        iX = e.Bounds.Left + 6
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    Private Sub DtDateofBirth_ValueChanged(sender As Object, e As EventArgs) Handles DtDateofBirth.ValueChanged
        Dim Diffyear As Integer
        Dim DiffMonth As Integer
        Dim DiffDay As Integer
        Dim cuYear As Integer = DateTime.Now.Year
        Dim cuMonth As Integer = DateTime.Now.Month
        Dim cuDay As Integer = DateTime.Now.Day
        Dim Age As String
        Diffyear = cuYear - DtDateofBirth.Value.Year
        DiffMonth = cuMonth - DtDateofBirth.Value.Month
        DiffDay = cuDay - DtDateofBirth.Value.Day
        If (DiffMonth) < 0 Then
            Diffyear -= 1
        End If
        If (DiffDay) < 0 Then
            DiffMonth -= 1
            If (cuMonth - 1) < 8 Then
                If ((cuMonth - 1) Mod 2) = 0 Then
                    If (cuMonth - 1) = 2 Then

                        If cuYear Mod 4 = 0 Then
                            DiffDay = 29 + DiffDay
                        Else
                            DiffDay = 28 + DiffDay
                        End If
                    Else
                        DiffDay = 30 + DiffDay
                    End If
                Else
                    DiffDay = 31 + DiffDay
                End If
            Else
                If ((cuMonth - 1) Mod 2) = 0 Then
                    DiffDay = 31 + DiffDay
                Else
                    DiffDay = 30 + DiffDay
                End If
            End If
        End If
        If (DiffMonth) < 0 Then
            DiffMonth = DiffMonth + 12
        End If
        If Diffyear < 0 Then
            Diffyear = Diffyear * (-1)
        End If
        If (DiffDay) < 0 Then
            DiffDay = DiffDay * (-1)
        End If
        Age = Diffyear.ToString().PadLeft(2, "0"c) & " Y " & DiffMonth.ToString().PadLeft(2, "0"c) & " M " & DiffDay.ToString().PadLeft(2, "0"c) & " D"
        Label13.Text = Age
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPEG;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPEG;*.JPG;*.GIF;*.PNG"
        If dialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(dialog.FileName)
            TxtImagePath.Text = System.IO.Path.GetFileName(dialog.FileName)
        End If
    End Sub

    Private Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click

        If MsgBox("Do You Want to Apply the Same as Permanent Address ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            txtPadd1.Text = txtCadd1.Text
            txtPadd2.Text = txtCadd2.Text
            txtPadd3.Text = txtCadd3.Text
            txtPadd4.Text = txtCadd4.Text
            txtPadd5.Text = txtCadd5.Text
            txtPpincode.Text = txtCpincode.Text
            txtPmobile.Text = txtCmobile.Text
            TabControl1.SelectedTab = TabPage4
            TxtRemarks.Focus()
        Else
            TabControl1.SelectedTab = TabPage4
            TxtRemarks.Focus()
        End If
    End Sub

    Private Sub TxtEmpNoE_TextChanged(sender As Object, e As EventArgs) Handles TxtEmpNoE.TextChanged

    End Sub

    Private Sub TxtEmpNoE_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtEmpNoE.MouseMove

    End Sub

    Private Sub TxtEmpNoE_Move(sender As Object, e As EventArgs) Handles TxtEmpNoE.Move

    End Sub

    Private Sub TxtEmpNoE_MouseEnter(sender As Object, e As EventArgs) Handles TxtEmpNoE.MouseEnter

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        PictureBox1.Image = Nothing
        TxtImagePath.Clear()
    End Sub


End Class