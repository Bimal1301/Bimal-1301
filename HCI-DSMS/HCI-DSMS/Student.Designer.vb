<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Label13 = New Label()
        btnexit = New Button()
        btnclear = New Button()
        btnsave = New Button()
        DateTimePicker3 = New DateTimePicker()
        ComboBox5 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.InactiveBorder
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(65, 616)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.Size = New Size(1672, 436)
        DataGridView1.TabIndex = 57
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.DeepPink
        Label13.Location = New Point(590, -16)
        Label13.Name = "Label13"
        Label13.Size = New Size(482, 65)
        Label13.TabIndex = 56
        Label13.Text = "Student Dashboard"
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnexit.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit.Location = New Point(1476, 317)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(185, 84)
        btnexit.TabIndex = 53
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = SystemColors.AppWorkspace
        btnclear.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(1476, 176)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(185, 84)
        btnclear.TabIndex = 52
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = SystemColors.ActiveCaption
        btnsave.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsave.Location = New Point(1476, 62)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(185, 84)
        btnsave.TabIndex = 51
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Location = New Point(1030, 463)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(301, 39)
        DateTimePicker3.TabIndex = 54
        DateTimePicker3.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Items.AddRange(New Object() {"Ram", "Sangita", "Sujan", "Srijana", "Hariom"})
        ComboBox5.Location = New Point(1057, 395)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(242, 40)
        ComboBox5.TabIndex = 50
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Items.AddRange(New Object() {"Rs. 2500", "Rs. 3400", "Rs. 5000", "Rs. 6500", "Rs. 12500"})
        ComboBox4.Location = New Point(1057, 302)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(242, 40)
        ComboBox4.TabIndex = 49
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"1 Week", "15 Days", "1 Month", "3 Months", "6 Months", "1 Year"})
        ComboBox3.Location = New Point(1057, 231)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(242, 40)
        ComboBox3.TabIndex = 48
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Basic", "Advanced", "Premium", "Full"})
        ComboBox2.Location = New Point(1057, 148)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(242, 40)
        ComboBox2.TabIndex = 47
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(1057, 60)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(303, 39)
        DateTimePicker1.TabIndex = 46
        DateTimePicker1.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        ComboBox1.Location = New Point(224, 472)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 40)
        ComboBox1.TabIndex = 45
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(224, 403)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(360, 39)
        TextBox5.TabIndex = 44
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(224, 344)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(360, 39)
        TextBox4.TabIndex = 43
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(224, 206)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(360, 115)
        TextBox3.TabIndex = 42
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(224, 134)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(360, 39)
        TextBox2.TabIndex = 41
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(224, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(120, 39)
        TextBox1.TabIndex = 40
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(759, 467)
        Label12.Name = "Label12"
        Label12.Size = New Size(200, 32)
        Label12.TabIndex = 55
        Label12.Text = "Course Start Date"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(844, 403)
        Label11.Name = "Label11"
        Label11.Size = New Size(115, 32)
        Label11.TabIndex = 39
        Label11.Text = "Instructor"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(826, 305)
        Label10.Name = "Label10"
        Label10.Size = New Size(133, 32)
        Label10.TabIndex = 38
        Label10.Text = "Course Fee"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(852, 228)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 32)
        Label9.TabIndex = 37
        Label9.Text = "Duration"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(813, 156)
        Label8.Name = "Label8"
        Label8.Size = New Size(146, 32)
        Label8.TabIndex = 36
        Label8.Text = "Course Type"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(809, 65)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 32)
        Label7.TabIndex = 35
        Label7.Text = "Date of Birth"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(74, 475)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 32)
        Label6.TabIndex = 34
        Label6.Text = "Gender"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(74, 403)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 32)
        Label5.TabIndex = 33
        Label5.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 344)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 32)
        Label4.TabIndex = 32
        Label4.Text = "Phone No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 32)
        Label3.TabIndex = 31
        Label3.Text = "Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 32)
        Label2.TabIndex = 30
        Label2.Text = "Full Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 32)
        Label1.TabIndex = 29
        Label1.Text = "Reg No."
        ' 
        ' Student
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1774, 1075)
        Controls.Add(DataGridView1)
        Controls.Add(Label13)
        Controls.Add(btnexit)
        Controls.Add(btnclear)
        Controls.Add(btnsave)
        Controls.Add(DateTimePicker3)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Student"
        Text = "Student"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
