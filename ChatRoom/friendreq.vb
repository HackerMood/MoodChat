Imports System.ComponentModel

Public Class friendreq
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If Not (TextBox1.Text = Nothing) Then
            loaddata("SELECT username,email,state FROM users WHERE username = '" & TextBox1.Text & "'", Friendsend)
        Else
            MessageBox.Show("Enter username !!!")
        End If
    End Sub

    Private Sub friendreq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxreques.Hide()
        TextBox2.Hide()
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        boxreques.Show()
        ListPending.Hide()
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        TextBox1.Text = Nothing
        boxreques.Hide()
    End Sub

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        ListPending.Show()
        boxreques.Show()

        loaddata("SELECT username,email,state FROM friend WHERE req = '" & Form1.TextBox1.Text & "'AND targ = 'Pending'", pendinglist)

    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        boxreques.Hide()
        ListPending.Hide()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Close()
        chat.Show()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click

    End Sub

    Private Sub clicker(sender As Object, e As DataGridViewCellEventArgs) Handles pendinglist.CellClick
        Try

            Dim selectedrowindex As DataGridViewRow
            selectedrowindex = pendinglist.Rows(e.RowIndex)
            Dim msg As String = selectedrowindex.Cells(0).Value
            Dim result As DialogResult = MessageBox.Show("Do you want to accept", "Request", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                loaddata("SELECT username,email,state FROM friend WHERE req = '" & Form1.TextBox1.Text & "'", pendinglist)
            ElseIf result = DialogResult.No Then

                updat("UPDATE friend SET targ  = 'Refuse' WHERE username='" & msg & "' AND req = '" & Form1.TextBox1.Text & "'")
                updat("UPDATE friend SET targ  = 'Refuse' WHERE username='" & Form1.TextBox1.Text & "' AND req = '" & msg & "'")
                loaddata("SELECT username,email,state FROM friend WHERE req = '" & Form1.TextBox1.Text & "'", pendinglist)
            ElseIf result = DialogResult.Yes Then
                updat("UPDATE friend SET targ  = 'Accept' WHERE username='" & msg & "' AND req = '" & Form1.TextBox1.Text & "'")
                updat("UPDATE friend SET targ  = 'Accept' WHERE username='" & Form1.TextBox1.Text & "' AND req = '" & msg & "'")
                loaddata("SELECT username,email,state FROM friend WHERE req = '" & Form1.TextBox1.Text & "'", pendinglist)
            End If
            'select1(msg)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error select")
        End Try
    End Sub

    Private Sub reqsend(sender As Object, e As DataGridViewCellEventArgs) Handles Friendsend.CellClick
        Try

            Dim selectedrowindex As DataGridViewRow
            selectedrowindex = Friendsend.Rows(e.RowIndex)
            Dim msg As String = selectedrowindex.Cells(0).Value
            TextBox2.Text = msg
            Dim result As DialogResult = MessageBox.Show("Do you want to send Friend Request", "Request", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                'loaddata("SELECT username,email,state FROM friend WHERE req = '" & Form1.TextBox1.Text & "'", pendinglist)
                Dim ad As String = ""
            ElseIf result = DialogResult.No Then
                Dim ads As String = ""

            ElseIf result = DialogResult.Yes Then
                updat2("UPDATE friend SET targ  = 'Pending' WHERE username='" & msg & "' AND req = '" & Form1.TextBox1.Text & "'")
                'updat3("UPDATE friend SET targ  = 'Pending' WHERE username='" & Form1.TextBox1.Text & "' AND req = '" & msg & "'")
                loaddata("SELECT username,email,state FROM friend WHERE req = '" & Form1.TextBox1.Text & "'", pendinglist)
            End If
            'select1(msg)
        Catch ex As Exception
            Windows.Forms.MessageBox.Show("error select")
        End Try
    End Sub

    Private Sub friendreq_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Close()
    End Sub
End Class