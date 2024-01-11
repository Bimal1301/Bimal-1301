Imports System.Data.DataTable
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class course
    Dim course As New DataTable
    Dim index As New Integer

    Private Sub course_load(sender As Object, e As EventArgs) Handles MyBase.Load

        course.Columns.Add("Course ID", GetType(Int32))
        course.Columns.Add("Course Type", GetType(String))
        course.Columns.Add("Course Module", GetType(String))
        course.Columns.Add("Course Add Date", GetType(Date))



        DataGridView1.DataSource = course

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        course.Rows.Add(TextBox1.Text, ComboBox1.SelectedItem, ComboBox2.SelectedItem, DateTimePicker1.Value.ToString("dd/MM/yyyy"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        ComboBox1.SelectedItem = ""
        ComboBox2.SelectedItem = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.Rows.RemoveAt(index)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Dashboard.Show()

    End Sub
End Class