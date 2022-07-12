Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MySQLConnectionString = "server=sql11.freemysqlhosting.net;port=3306; user id=sql11505076; password=F8ncyjlzqP; database=sql11505076; Character Set=utf8;" ' ประกาศ connection string
    Dim MyConnection As New MySqlConnection
    Dim SQLDmd As New MySqlCommand
    Dim datareader As MySqlDataReader
    Sub ExecuteQuery(query As String)
        MyConnection = New MySqlConnection(MySQLConnectionString)
        SQLDmd = New MySqlCommand(query, MyConnection)
        MyConnection.Open()
        SQLDmd.ExecuteNonQuery()
        MyConnection.Close()
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        MyConnection = New MySqlConnection(MySQLConnectionString)
        Dim sql As String = "SELECT * FROM users WHERE username='" & TextBox1.Text & "'"
        SQLDmd = New MySqlCommand(sql, MyConnection)
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please enter Username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                MyConnection.Open()
                Dim rdr As MySqlDataReader = SQLDmd.ExecuteReader
                rdr.Read()
                If rdr(1).ToString = TextBox1.Text Then
                    If rdr(2).ToString = TextBox2.Text Then
                        My.Settings.username = TextBox1.Text
                        MessageBox.Show("Login Complete!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MyConnection.Close()

                        Form2.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Incorrect Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Login Failed, Username not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        updat("UPDATE users SET state = 'Online' WHERE username='" & TextBox1.Text & "'")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Hide()
    End Sub
End Class
