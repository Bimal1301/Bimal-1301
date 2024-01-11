Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Instructor
    Dim isntructor As New DataTable
    Dim index As New Integer
    Private Sub Instructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isntructor.Columns.Add("Instructor Id", GetType(Integer))
        isntructor.Columns.Add("Full Name", GetType(String))
        isntructor.Columns.Add("Address", GetType(String))
        isntructor.Columns.Add("Contact No", GetType(Int64))
        isntructor.Columns.Add("Contract Type", GetType(String))
        isntructor.Columns.Add("Gender", GetType(String))


        DataGridView1.DataSource = isntructor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isntructor.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, ComboBox1.SelectedItem, ComboBox2.SelectedItem)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dashboard.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.SelectedItem = ""
        ComboBox2.SelectedItem = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim update As DataGridViewRow
        update = DataGridView1.Rows(index)
        update.Cells(0).Value = TextBox1.Text
        update.Cells(1).Value = TextBox2.Text
        update.Cells(2).Value = TextBox3.Text
        update.Cells(3).Value = TextBox4.Text
        update.Cells(4).Value = ComboBox1.SelectedItem
        update.Cells(5).Value = ComboBox2.SelectedItem



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.Rows.RemoveAt(index)


    End Sub
End Class

