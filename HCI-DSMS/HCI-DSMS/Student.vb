Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Student
    Dim table As New DataTable
    Dim index As New Integer

    Private Sub Studentdashboard_load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Reg Id", GetType(Integer))
        table.Columns.Add("Full Name", GetType(String))
        table.Columns.Add("Address", GetType(String))
        table.Columns.Add("Phone No", GetType(Int64))
        table.Columns.Add("Email", GetType(String))
        table.Columns.Add("Gender", GetType(String))
        table.Columns.Add("DOB", GetType(Date))
        table.Columns.Add("Course Type", GetType(String))
        table.Columns.Add("Duration", GetType(String))
        table.Columns.Add("Course Fee", GetType(String))
        table.Columns.Add("Instructor", GetType(String))
        table.Columns.Add("Course Start Date", GetType(Date))


        DataGridView1.DataSource = table

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
        Dashboard.Show()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        table.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, ComboBox1.SelectedItem, DateTimePicker1.Value.ToString("dd/MM/yyyy"), ComboBox2.SelectedItem, ComboBox3.SelectedItem, ComboBox4.SelectedItem, ComboBox5.SelectedItem, DateTimePicker3.Value.ToString("dd/MM/yyyy"))





    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.SelectedItem = ""
        ComboBox2.SelectedItem = ""
        ComboBox3.SelectedItem = ""
        ComboBox4.SelectedItem = ""
        ComboBox5.SelectedItem = ""


    End Sub
End Class