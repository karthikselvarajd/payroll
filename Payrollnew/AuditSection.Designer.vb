<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AuditSection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClearALL = New System.Windows.Forms.Button()
        Me.BtnInvert = New System.Windows.Forms.Button()
        Me.BtnSelectALL = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.CmbcompanyCode = New System.Windows.Forms.ComboBox()
        Me.CmbUnitnCode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.Cmbcategory = New System.Windows.Forms.ComboBox()
        Me.CmbSection = New System.Windows.Forms.ComboBox()
        Me.CmbGrade = New System.Windows.Forms.ComboBox()
        Me.CmbDesign = New System.Windows.Forms.ComboBox()
        Me.CmbDepart = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnClear)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnClearALL)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnInvert)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.BtnSelectALL)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(269, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 599)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(294, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 21)
        Me.Label2.TabIndex = 212
        Me.Label2.Text = "Audit Selection List"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(7, 45)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.OwnerDraw = True
        Me.ListView1.Size = New System.Drawing.Size(754, 462)
        Me.ListView1.TabIndex = 213
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Emp No"
        Me.ColumnHeader1.Width = 57
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Emp Name"
        Me.ColumnHeader2.Width = 112
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Card No"
        Me.ColumnHeader3.Width = 67
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Section"
        Me.ColumnHeader4.Width = 67
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Department"
        Me.ColumnHeader5.Width = 97
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Designation"
        Me.ColumnHeader6.Width = 92
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Garde"
        Me.ColumnHeader7.Width = 51
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Audit Status"
        Me.ColumnHeader8.Width = 86
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.Transparent
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Black
        Me.BtnClear.Location = New System.Drawing.Point(684, 551)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(77, 23)
        Me.BtnClear.TabIndex = 303
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Location = New System.Drawing.Point(597, 551)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(77, 23)
        Me.BtnSave.TabIndex = 302
        Me.BtnSave.Text = "SAVE"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnClearALL
        '
        Me.BtnClearALL.BackColor = System.Drawing.Color.Transparent
        Me.BtnClearALL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnClearALL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearALL.ForeColor = System.Drawing.Color.Black
        Me.BtnClearALL.Location = New System.Drawing.Point(175, 551)
        Me.BtnClearALL.Name = "BtnClearALL"
        Me.BtnClearALL.Size = New System.Drawing.Size(77, 23)
        Me.BtnClearALL.TabIndex = 301
        Me.BtnClearALL.Text = "Clear  ALL"
        Me.BtnClearALL.UseVisualStyleBackColor = False
        '
        'BtnInvert
        '
        Me.BtnInvert.BackColor = System.Drawing.Color.Transparent
        Me.BtnInvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnInvert.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvert.ForeColor = System.Drawing.Color.Black
        Me.BtnInvert.Location = New System.Drawing.Point(91, 551)
        Me.BtnInvert.Name = "BtnInvert"
        Me.BtnInvert.Size = New System.Drawing.Size(77, 23)
        Me.BtnInvert.TabIndex = 300
        Me.BtnInvert.Text = "Invert"
        Me.BtnInvert.UseVisualStyleBackColor = False
        '
        'BtnSelectALL
        '
        Me.BtnSelectALL.BackColor = System.Drawing.Color.Transparent
        Me.BtnSelectALL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectALL.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectALL.ForeColor = System.Drawing.Color.Black
        Me.BtnSelectALL.Location = New System.Drawing.Point(7, 551)
        Me.BtnSelectALL.Name = "BtnSelectALL"
        Me.BtnSelectALL.Size = New System.Drawing.Size(77, 23)
        Me.BtnSelectALL.TabIndex = 299
        Me.BtnSelectALL.Text = "Select ALL"
        Me.BtnSelectALL.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(421, 521)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 17)
        Me.RadioButton2.TabIndex = 298
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "&No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(375, 521)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(40, 17)
        Me.RadioButton1.TabIndex = 297
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "&Yes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(303, 519)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 296
        Me.Label5.Text = "Status"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.White
        Me.BtnSearch.Location = New System.Drawing.Point(186, 273)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(77, 23)
        Me.BtnSearch.TabIndex = 307
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'CmbcompanyCode
        '
        Me.CmbcompanyCode.FormattingEnabled = True
        Me.CmbcompanyCode.Location = New System.Drawing.Point(106, 72)
        Me.CmbcompanyCode.Name = "CmbcompanyCode"
        Me.CmbcompanyCode.Size = New System.Drawing.Size(157, 21)
        Me.CmbcompanyCode.TabIndex = 306
        '
        'CmbUnitnCode
        '
        Me.CmbUnitnCode.FormattingEnabled = True
        Me.CmbUnitnCode.Location = New System.Drawing.Point(106, 45)
        Me.CmbUnitnCode.Name = "CmbUnitnCode"
        Me.CmbUnitnCode.Size = New System.Drawing.Size(157, 21)
        Me.CmbUnitnCode.TabIndex = 305
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 21)
        Me.Label4.TabIndex = 304
        Me.Label4.Text = "Company Code"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 303
        Me.Label3.Text = "Unit Code"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(106, 207)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox7.TabIndex = 302
        '
        'Cmbcategory
        '
        Me.Cmbcategory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbcategory.FormattingEnabled = True
        Me.Cmbcategory.Items.AddRange(New Object() {"Worker", "Staff"})
        Me.Cmbcategory.Location = New System.Drawing.Point(106, 234)
        Me.Cmbcategory.Name = "Cmbcategory"
        Me.Cmbcategory.Size = New System.Drawing.Size(157, 21)
        Me.Cmbcategory.TabIndex = 301
        Me.Cmbcategory.Text = "Worker"
        '
        'CmbSection
        '
        Me.CmbSection.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSection.FormattingEnabled = True
        Me.CmbSection.Location = New System.Drawing.Point(106, 180)
        Me.CmbSection.Name = "CmbSection"
        Me.CmbSection.Size = New System.Drawing.Size(157, 21)
        Me.CmbSection.TabIndex = 300
        '
        'CmbGrade
        '
        Me.CmbGrade.DropDownHeight = 80
        Me.CmbGrade.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbGrade.FormattingEnabled = True
        Me.CmbGrade.IntegralHeight = False
        Me.CmbGrade.Location = New System.Drawing.Point(107, 153)
        Me.CmbGrade.Name = "CmbGrade"
        Me.CmbGrade.Size = New System.Drawing.Size(157, 21)
        Me.CmbGrade.TabIndex = 299
        '
        'CmbDesign
        '
        Me.CmbDesign.DropDownHeight = 80
        Me.CmbDesign.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDesign.FormattingEnabled = True
        Me.CmbDesign.IntegralHeight = False
        Me.CmbDesign.Location = New System.Drawing.Point(106, 126)
        Me.CmbDesign.Name = "CmbDesign"
        Me.CmbDesign.Size = New System.Drawing.Size(157, 21)
        Me.CmbDesign.TabIndex = 298
        '
        'CmbDepart
        '
        Me.CmbDepart.DropDownHeight = 80
        Me.CmbDepart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDepart.FormattingEnabled = True
        Me.CmbDepart.IntegralHeight = False
        Me.CmbDepart.Location = New System.Drawing.Point(107, 99)
        Me.CmbDepart.Name = "CmbDepart"
        Me.CmbDepart.Size = New System.Drawing.Size(157, 21)
        Me.CmbDepart.TabIndex = 297
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(12, 209)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 15)
        Me.Label20.TabIndex = 296
        Me.Label20.Text = "Form XI Grp"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(12, 236)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 15)
        Me.Label19.TabIndex = 295
        Me.Label19.Text = "Category"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(12, 182)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 15)
        Me.Label18.TabIndex = 294
        Me.Label18.Text = "Section"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(12, 155)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 15)
        Me.Label17.TabIndex = 293
        Me.Label17.Text = "Grade"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(12, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 15)
        Me.Label16.TabIndex = 292
        Me.Label16.Text = "Designation"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(12, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 15)
        Me.Label15.TabIndex = 291
        Me.Label15.Text = "Department"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 308
        Me.Label1.Text = "Search Option"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(733, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 21)
        Me.Button1.TabIndex = 304
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AuditSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1039, 599)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.CmbcompanyCode)
        Me.Controls.Add(Me.CmbUnitnCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.Cmbcategory)
        Me.Controls.Add(Me.CmbSection)
        Me.Controls.Add(Me.CmbGrade)
        Me.Controls.Add(Me.CmbDesign)
        Me.Controls.Add(Me.CmbDepart)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AuditSection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuditSection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnClear As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents BtnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnClearALL As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnInvert As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents BtnSelectALL As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents BtnSearch As Button
    Friend WithEvents CmbcompanyCode As ComboBox
    Friend WithEvents CmbUnitnCode As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Cmbcategory As ComboBox
    Friend WithEvents CmbSection As ComboBox
    Friend WithEvents CmbGrade As ComboBox
    Friend WithEvents CmbDesign As ComboBox
    Friend WithEvents CmbDepart As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
