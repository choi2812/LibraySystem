Public Class UserInfoReview
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click

        Connection.Open()


        command.CommandText = "SELECT MailAddress FROM LibraryUser WHERE UserNumber = '" & txtNumber.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read Then
            If IsDBNull(dr("MailAddress")) Then
                dr.Close()
                command.CommandText = "UPDATE LibraryUser SET UserName='" & txtName.Text & "',Kana='" & txtKana.Text & "',MailAddress='" & txtMailAddress.Text & "',TelephoneNumber='" & txtTelephoneNumber.Text & "',UserPassWord='" & txtMailAddress.Text & "' where UserNumber ='" & txtNumber.Text & "'"
                Try
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
            Else
                dr.Close()
                command.CommandText = "UPDATE LibraryUser SET UserName='" & txtName.Text & "',Kana='" & txtKana.Text & "',MailAddress='" & txtMailAddress.Text & "',TelephoneNumber='" & txtTelephoneNumber.Text & "' where UserNumber ='" & txtNumber.Text & "'"
                Try
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
            End If
        End If
        dr.Close()



        command.CommandText = ("SELECT UserName, MailAddress FROM LibraryUser where UserNumber = '" & txtNumber.Text & "'")
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
        End Try
        If dr.Read() Then
            If Not IsDBNull(dr("MailAddress")) AndAlso Not dr("MailAddress") = "" Then
                Dim senderMail As String = "14jy0100@jynet.jec.ac.jp"
                '宛先
                Dim recipientMail As String = dr("MailAddress")
                Dim subject As String = "【日本電子専門学校図書館】メール登録のお知らせ"
                '本文
                Dim body As String = "【日本電子専門学校図書館】メール登録のお知らせ" + vbCrLf + vbCrLf + txtName.Text + "様" + vbCrLf + vbCrLf + "日本電子専門学校図書館のご利用ありがとうございます。" + vbCrLf + vbCrLf + dr("UserName") + "様のメールアドレス " + dr("MailAddress") + " で登録完了しました。" + vbCrLf + vbCrLf + "お問い合わせ先" + vbCrLf + vbCrLf + "日本電子専門学校図書館()" + vbCrLf + vbCrLf + "TEL     ：03-xxx-xxx 受付時間：09:00-20:00（土・日・祝日をのぞく）" + vbCrLf + vbCrLf + "E-MAIL : info@(jec.ac.jp)"
                'SmtpClientオブジェクトを作成する
                Dim sc As New System.Net.Mail.SmtpClient()
                'SMTPサーバーを指定する
                sc.Host = "webserver02"
                'ポート番号を指定する（既定値は25）
                sc.Port = 25
                'メールを送信する
                Try
                    sc.Send(senderMail, recipientMail, subject, body)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
                MessageBox.Show("登録メールアドレスにメールを送りました")
                '後始末
                sc.Dispose()
            End If
        End If


        '登録完了'
        MessageBox.Show("登録/変更が完了しました")

        Connection.Close()
        Me.Close()
        UserRegist.Close()

    End Sub

    Private Sub UserInfoReview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class