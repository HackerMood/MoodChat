Imports System.ComponentModel

Public Class chat
    Private Sub chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        TextBox2.Hide()
        chating.Hide()
        loaddata("SELECT sender,mesg FROM message WHERE receiver = '" & Form1.TextBox1.Text & "'", listmessage)
        updat("UPDATE users SET state = 'Online' WHERE username='" & Form1.TextBox1.Text & "'")

    End Sub

    Private Sub click(sender As Object, e As DataGridViewCellEventArgs) Handles listmessage.CellClick
        Try

            Dim selectedrowindex As DataGridViewRow
            selectedrowindex = listmessage.Rows(e.RowIndex)
            Dim msg As String = selectedrowindex.Cells(0).Value
            TextBox4.Text = msg
            select1(msg)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error select")
        End Try


    End Sub
    Public Sub sendmessage(ByVal username As String, ByVal msgs As String)
        listmessage.Hide()
        chating.Show()
        chatinfo(username)
        messagebox.Text = msgs
        TextBox1.Text = username
        reloadertime.Start()

    End Sub

    Private Sub sendbtn_Click(sender As Object, e As EventArgs) Handles sendbtn.Click
        If Not (messagesend.Text = Nothing) Then
            Dim tj = vbCrLf & "[ " + Form1.TextBox1.Text + " ] : " + messagesend.Text
            TextBox2.Text = messagebox.Text + tj

            updating("UPDATE message SET mesg = '" & TextBox2.Text & "' WHERE sender='" & Form1.TextBox1.Text & "' AND receiver ='" & TextBox1.Text & "'", "message sent")
            updating2("UPDATE message SET mesg = '" & TextBox2.Text & "' WHERE sender='" & TextBox1.Text & "' AND receiver ='" & Form1.TextBox1.Text & "'")
        End If

        messagesend.Text = Nothing
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Close()
        Form2.Show()
    End Sub

    Public Function infochat(ByVal users As String, ByVal eml As String, ByVal state As String)
        tusername.Text = users
        temail.Text = eml
        tstate.Text = state
    End Function

    Private Sub reloadertime_Tick(sender As Object, e As EventArgs) Handles reloadertime.Tick
        reloaderlbl()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        friendreq.Show()
    End Sub

    Private Sub chat_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Close()
    End Sub
End Class