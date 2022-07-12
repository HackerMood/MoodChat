Imports System.ComponentModel

Public Class sendermessage
    Private Sub sendermessage_Load(sender As Object, e As EventArgs)
        updat("UPDATE users SET state = 'Online' WHERE username='" & Form1.TextBox1.Text & "'")
        chatinfo2(Form2.TextBox1.Text)
        reloaderlbl2()
        Timer1.Start()
        tusername.Text = Form2.us.Text
        temail.Text = Form2.eml.Text
        tstate.Text = Form2.ste.Text
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reloaderlbl2()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        friendreq.Show()
    End Sub

    Private Sub sendermessage_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        updat("UPDATE users SET state = 'Online' WHERE username='" & Form1.TextBox1.Text & "'")
        reloaderlbl2()
        Timer1.Start()
        tusername.Text = Form2.us.Text
        temail.Text = Form2.eml.Text
        tstate.Text = Form2.ste.Text
    End Sub

    Private Sub sendbtn_Click(sender As Object, e As EventArgs) Handles sendbtn.Click
        If Not (msend.Text = Nothing) Then
            Dim tj = vbCrLf & "[ " + Form1.TextBox1.Text + " ] : " + msend.Text
            TextBox2.Text = TextBox1.Text + tj

            ating("UPDATE message SET mesg = '" & TextBox2.Text & "' WHERE sender='" & Form1.TextBox1.Text & "' AND receiver ='" & tusername.Text & "'", "message sent")
            ating2("UPDATE message SET mesg = '" & TextBox2.Text & "' WHERE sender='" & tusername.Text & "' AND receiver ='" & Form1.TextBox1.Text & "'")
        End If
        msend.Text = Nothing
    End Sub

    Private Sub sendermessage_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Close()
    End Sub
End Class