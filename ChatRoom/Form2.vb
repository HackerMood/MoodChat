Imports System.ComponentModel

Public Class Form2
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        friendreq.Show()
    End Sub

    Private Sub IconPictureBox2_Click(sender As Object, e As EventArgs) Handles IconPictureBox2.Click

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Hide()
        chat.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        TextBox2.Hide()
        f1()
        Try
            loaddata("SELECT username,email,state FROM friend WHERE req ='" & Form1.TextBox1.Text & "'AND targ = 'Accept' ", listfriend)
        Catch ex As Exception

        End Try
    End Sub




    Private Sub send(sender As Object, e As DataGridViewCellEventArgs) Handles listfriend.CellClick
        Try
            Dim selectedrowindex As DataGridViewRow
            selectedrowindex = listfriend.Rows(e.RowIndex)
            Dim msg As String = selectedrowindex.Cells(0).Value
            'TextBox4.Text = msgs
            chatinfo2(msg)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error select")
        End Try
        Me.Hide()
        sendermessage.Show()
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Close()
    End Sub
End Class