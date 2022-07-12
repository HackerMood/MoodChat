Imports MySql.Data.MySqlClient
Module db
    Public Function strconnection() As MySqlConnection
        '''Return New MySqlConnection("server=localhost;user id =root;password=;database=chatroom")
        '''
        Return New MySqlConnection("server=sql11.freemysqlhosting.net;port=3306; user id=sql11505076; password=F8ncyjlzqP; database=sql11505076; Character Set=utf8")
    End Function

    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub loaddata(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub
    Public Sub select1(ByVal senders As String)
        chat.TextBox3.Text = senders
        Dim username, val As String

        Dim sk As New MySqlCommand("SELECT * FROM message WHERE sender = '" & chat.TextBox3.Text & "'", strcon)
        strcon.Open()
        sk.ExecuteNonQuery()

        Using sdr As MySqlDataReader = sk.ExecuteReader()

            sdr.Read()
            username = sdr("sender").ToString()
            val = sdr("mesg").ToString()
        End Using
        strcon.Close()

        chat.sendmessage(username, val)
    End Sub
    Public Sub sendmessage(ByVal senders As String)
        chat.TextBox3.Text = senders
        Dim username, val As String

        Dim sk As New MySqlCommand("SELECT * FROM message WHERE sender = '" & chat.TextBox3.Text & "'", strcon)
        strcon.Open()
        sk.ExecuteNonQuery()

        Using sdr As MySqlDataReader = sk.ExecuteReader()

            sdr.Read()
            username = sdr("sender").ToString()
            val = sdr("mesg").ToString()
        End Using
        strcon.Close()

        chat.sendmessage(username, val)
    End Sub
    Public Sub chatinfo(ByVal tuser As String)
        chat.TextBox3.Text = tuser
        Dim users, mail, ste As String

        Dim sk As New MySqlCommand("SELECT * FROM users WHERE username = '" & chat.TextBox3.Text & "'", strcon)
        strcon.Open()
        sk.ExecuteNonQuery()
        Using sdr As MySqlDataReader = sk.ExecuteReader()
            sdr.Read()

            users = sdr("username").ToString()
            mail = sdr("email").ToString()
            ste = sdr("state").ToString()
        End Using
        strcon.Close()
        chat.infochat(users, mail, ste)
    End Sub

    Public Sub chatinfo2(ByVal tuser As String)
        Dim users, mail, ste As String
        strcon.Close()
        Dim sk As New MySqlCommand("SELECT * FROM users WHERE username = '" & tuser & "'", strcon)
        strcon.Open()
        sk.ExecuteNonQuery()
        Using sdr As MySqlDataReader = sk.ExecuteReader()
            sdr.Read()

            users = sdr("username").ToString()
            mail = sdr("email").ToString()
            ste = sdr("state").ToString()
        End Using
        strcon.Close()
        Form2.eml.Text = mail
        Form2.us.Text = users
        Form2.ste.Text = ste
    End Sub
    Public Sub creat(ByVal sql As String, ByVal msgs As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Error")
                Else
                    MessageBox.Show(msgs)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub datainject(ByVal sql As String, ByVal msgs As String)
        Try

            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Error")
                Else
                    MessageBox.Show(msgs)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub
    Public Sub dtinject(ByVal sql As String, ByVal msgs As String)
        Try

            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Error")
                Else
                    MessageBox.Show(msgs)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()

        End Try
    End Sub
    Public Sub datainject1(ByVal sql As String, ByVal msgs As String)
        Try

            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Error")
                Else
                    MessageBox.Show(msgs)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub
    Public Sub updat(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Dim gf As String = ""
                Else
                    Dim gf As String = ""
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub updat2(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    datainject("INSERT INTO friend (username, email, req , state , targ) VALUES('" & Form1.TextBox1.Text & "', '" & Form2.TextBox1.Text & "','" & friendreq.TextBox2.Text & "','Online','Pending')", "Request sent")
                    datainject1("INSERT INTO friend (username, email, req , state , targ) VALUES('" & friendreq.TextBox2.Text & "', '" & Form2.TextBox1.Text & "','" & Form1.TextBox1.Text & "','Online','Pending')", "Request sent")
                Else
                    Dim gf As String = ""
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub updat3(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    datainject("INSERT INTO friend (username, email, req , state , targ) VALUES('" & friendreq.TextBox2.Text & "', '" & Form2.TextBox1.Text & "','" & Form1.TextBox1.Text & "','Online','Pending')", "Request sent")
                Else
                    Dim gf As String = ""
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub updating(ByVal sql As String, ByVal msgs As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Try
                        dtinject("INSERT INTO message(mesg, sender, receiver) VALUES('" & chat.TextBox2.Text & "', '" & Form1.TextBox1.Text & "','" & chat.TextBox1.Text & "')", "message sent")
                    Catch ex As Exception

                    End Try
                Else
                    MessageBox.Show(msgs)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub updating2(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Try
                        dtinject("INSERT INTO message(mesg, sender, receiver) VALUES('" & chat.TextBox2.Text & "', '" & chat.TextBox1.Text & "','" & Form1.TextBox1.Text & "')", "message sent")
                    Catch ex As Exception

                    End Try
                Else
                    Dim glp As String = ""
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub ating(ByVal sql As String, ByVal msgs As String)
        Try
            strcon.Close()
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Try
                        dtinject("INSERT INTO message(mesg, sender, receiver) VALUES('" & sendermessage.TextBox2.Text & "', '" & Form1.TextBox1.Text & "','" & sendermessage.tusername.Text & "')", "message sent")
                    Catch ex As Exception

                    End Try
                Else
                    MessageBox.Show(msgs)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub ating2(ByVal sql As String)
        Try
            strcon.Close()

            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Try
                        dtinject("INSERT INTO message(mesg, sender, receiver) VALUES('" & sendermessage.TextBox2.Text & "', '" & sendermessage.tusername.Text & "','" & Form1.TextBox1.Text & "')", "message sent")
                    Catch ex As Exception

                    End Try
                Else
                    Dim glp As String = ""
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    Try
                        MessageBox.Show("Error")
                    Catch ex As Exception

                    End Try

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Function reloaderlbl()
        Dim actumessage, etat As String

        Dim sk As New MySqlCommand("SELECT mesg FROM message WHERE sender = '" & chat.TextBox3.Text & "'", strcon)
        Dim sl As New MySqlCommand("SELECT state FROM users WHERE username = '" & chat.TextBox4.Text & "'", strcon)
        strcon.Close()
        strcon.Open()
        sk.ExecuteNonQuery()
        sl.ExecuteNonQuery()


        Using sdr As MySqlDataReader = sk.ExecuteReader()

            sdr.Read()
            actumessage = sdr("mesg").ToString()
        End Using

        Using sdf As MySqlDataReader = sl.ExecuteReader()

            sdf.Read()
            etat = sdf("state").ToString()
        End Using
        strcon.Close()
        chat.messagebox.Text = actumessage
        chat.tstate.Text = etat
    End Function
    Public Function reloaderlbl2()
        Dim actumessage, etat As String

        Try
            Dim sk As New MySqlCommand("SELECT mesg FROM message WHERE sender = '" & Form2.us.Text & "' AND receiver='" & Form1.TextBox1.Text & "'", strcon)
            Dim sl As New MySqlCommand("SELECT state FROM users WHERE username = '" & Form2.us.Text & "'", strcon)
            strcon.Close()
            strcon.Open()
            sk.ExecuteNonQuery()
            sl.ExecuteNonQuery()


            Using sdr As MySqlDataReader = sk.ExecuteReader()

                sdr.Read()
                actumessage = sdr("mesg").ToString()
            End Using

            Using sdf As MySqlDataReader = sl.ExecuteReader()

                sdf.Read()
                etat = sdf("state").ToString()
            End Using
            strcon.Close()
            sendermessage.TextBox1.Text = actumessage
            sendermessage.tstate.Text = etat
        Catch ex As Exception
            Dim ja As String = ""
        End Try
    End Function
    Public Function f1()
        Dim sk As New MySqlCommand("SELECT * FROM users WHERE username = '" & Form1.TextBox1.Text & "'", strcon)
        Dim f As String
        strcon.Open()
        sk.ExecuteNonQuery()
        Using sdr As MySqlDataReader = sk.ExecuteReader()

            sdr.Read()
            f = sdr("email").ToString()
        End Using
        strcon.Close()
        Form2.TextBox2.Text = f

    End Function
End Module
