<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(277, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(715, 59)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to Pass It Driving School"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Vivaldi", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(419, 625)
        Label2.Name = "Label2"
        Label2.Size = New Size(373, 76)
        Label2.TabIndex = 0
        Label2.Text = "Drive for safety"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(151, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 121)
        Button1.TabIndex = 1
        Button1.Text = "Student"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(419, 274)
        Button2.Name = "Button2"
        Button2.Size = New Size(203, 121)
        Button2.TabIndex = 2
        Button2.Text = "Instructor"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(689, 274)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 121)
        Button3.TabIndex = 3
        Button3.Text = "Course"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(941, 274)
        Button4.Name = "Button4"
        Button4.Size = New Size(235, 121)
        Button4.TabIndex = 4
        Button4.Text = "About Us"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(1055, 625)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 46)
        Button5.TabIndex = 5
        Button5.Text = "Logout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1320, 725)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Dashboard"
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
