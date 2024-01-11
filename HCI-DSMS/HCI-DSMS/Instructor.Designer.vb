<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructor
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
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
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
        DataGridView1.BackgroundColor = Color.LightBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(114, 570)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.Size = New Size(1510, 419)
        DataGridView1.TabIndex = 37
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(1441, 493)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 46)
        Button5.TabIndex = 36
        Button5.Text = "Exit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1114, 493)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 46)
        Button4.TabIndex = 35
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(832, 493)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 46)
        Button3.TabIndex = 34
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(502, 493)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 46)
        Button2.TabIndex = 33
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Location = New Point(246, 493)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 32
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Male", "Female", "Other"})
        ComboBox2.Location = New Point(1042, 293)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(242, 40)
        ComboBox2.TabIndex = 31
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Part-Time" & vbTab, "Full-Time"})
        ComboBox1.Location = New Point(1042, 224)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(242, 40)
        ComboBox1.TabIndex = 30
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(1042, 151)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(312, 39)
        TextBox4.TabIndex = 29
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(246, 293)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(429, 77)
        TextBox3.TabIndex = 28
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(246, 224)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(429, 39)
        TextBox2.TabIndex = 27
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(246, 151)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(122, 39)
        TextBox1.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(890, 293)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 32)
        Label7.TabIndex = 25
        Label7.Text = "Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(820, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(162, 32)
        Label6.TabIndex = 24
        Label6.Text = "Contract Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(842, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 32)
        Label5.TabIndex = 23
        Label5.Text = "Contact No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(91, 284)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 32)
        Label4.TabIndex = 22
        Label4.Text = "Address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(66, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 32)
        Label3.TabIndex = 21
        Label3.Text = "Full Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(47, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 32)
        Label2.TabIndex = 20
        Label2.Text = "Instructor Id"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 22.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuText
        Label1.Location = New Point(698, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(306, 78)
        Label1.TabIndex = 19
        Label1.Text = "Instructor"
        ' 
        ' Instructor
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        ClientSize = New Size(1789, 1085)
        Controls.Add(DataGridView1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Instructor"
        Text = "Instructor"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
