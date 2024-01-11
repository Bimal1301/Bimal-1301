<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class course
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
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        DateTimePicker1 = New DateTimePicker()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
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
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(273, 314)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.Size = New Size(1013, 395)
        DataGridView1.TabIndex = 27
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1074, 760)
        Button4.Name = "Button4"
        Button4.Size = New Size(212, 111)
        Button4.TabIndex = 26
        Button4.Text = "Dashboard"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(746, 760)
        Button3.Name = "Button3"
        Button3.Size = New Size(221, 111)
        Button3.TabIndex = 25
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(445, 760)
        Button2.Name = "Button2"
        Button2.Size = New Size(226, 111)
        Button2.TabIndex = 24
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(112, 760)
        Button1.Name = "Button1"
        Button1.Size = New Size(232, 111)
        Button1.TabIndex = 23
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(924, 231)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(297, 39)
        DateTimePicker1.TabIndex = 22
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Theory", "Practical", "Full"})
        ComboBox2.Location = New Point(924, 175)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(297, 40)
        ComboBox2.TabIndex = 21
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Advanced", "Basic", "Premium"})
        ComboBox1.Location = New Point(246, 227)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(297, 40)
        ComboBox1.TabIndex = 20
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(246, 171)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(121, 39)
        TextBox1.TabIndex = 19
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(708, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(195, 32)
        Label5.TabIndex = 18
        Label5.Text = "Course Add Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(725, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 32)
        Label4.TabIndex = 17
        Label4.Text = "Course Module"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(68, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 32)
        Label3.TabIndex = 16
        Label3.Text = "Course Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(68, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 32)
        Label2.TabIndex = 15
        Label2.Text = "Course ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Bisque
        Label1.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(630, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 72)
        Label1.TabIndex = 14
        Label1.Text = "Course"
        ' 
        ' course
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(1454, 952)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "course"
        Text = "course"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
