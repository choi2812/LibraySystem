Imports System.Net.Mail
Public Class UserPasswordReset
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Private Sub Customerpasswordreset_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Connection.Open()
        btnReset.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click


        If txtNumber.Text = "" Then
            MessageBox.Show("利用者番号が未入力です", "ユーザーエラー")
            Exit Sub
        End If
        If txtNumber.Text.Contains("'") Or txtNumber.Text.Contains("""") Or txtNumber.Text.Contains("　") Or txtNumber.Text.Contains("-") Then
            MessageBox.Show("利用者番号に無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If
        If Not txtNumber.Text.Length = 8 Then
            MessageBox.Show("利用者番号の桁数が間違っています", "ユーザーエラー")
            Exit Sub
        End If

        command.CommandText = "SELECT * FROM LibraryUser WHERE UserNumber =" & "'" & txtNumber.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dr.Close()
            Exit Sub
        End Try
        If dr.Read() = False Then
            MessageBox.Show("利用者番号が間違っています。", "ユーザーエラー")
            dr.Close()
            Exit Sub
        End If
        If IsDBNull(dr("MailAddress")) Or dr("MailAddress") = "" Then
            MessageBox.Show("未だメールアドレスを登録していません。", "ユーザーエラー")
            dr.Close()
            Exit Sub
        End If
        txtNumber.Text = ""
        txtUserNumber.Text = dr("UserNumber")
        txtUserName.Text = dr("UserName")
        dr.Close()

        btnReset.Enabled = True

    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click

        command.CommandText = "UPDATE LibraryUser SET UserPassWord=MailAddress where UserNumber ='" + txtUserNumber.Text + "'"
        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        MessageBox.Show("パスワードを初期化しました。", "システムメッセージ")

        command.CommandText = ("SELECT MailAddress FROM LibraryUser where UserNumber = '" & txtUserNumber.Text & "'")
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dr.Close()
        End Try
        If dr.Read = True Then

            Dim senderMail As String = "14jy0100@jynet.jec.ac.jp"
            '宛先

            Dim recipientMail As String = dr("MailAddress")


            Dim subject As String = "【日本電子専門学校図書館】パスワード初期化のお知らせ"
            '本文
            Dim body As String = "【日本電子専門学校図書館】パスワード初期化のお知らせ" + vbCrLf + vbCrLf + txtUserName.Text + "様" + vbCrLf + vbCrLf + "日本電子専門学校図書館のご利用ありがとうございます。" + vbCrLf + vbCrLf + "パスワード初期化しました" + vbCrLf + vbCrLf + "パスワード：自分のメールアドレスと同じ。" + vbCrLf + vbCrLf + "お問い合わせ先" + vbCrLf + vbCrLf + "日本電子専門学校図書館()" + vbCrLf + vbCrLf + "TEL     ：03-xxx-xxx 受付時間：09:00-20:00（土・日・祝日をのぞく）" + vbCrLf + vbCrLf + "E-MAIL : info@(jec.ac.jp)"
            'SmtpClientオブジェクトを作成する
            Dim sc As New System.Net.Mail.SmtpClient()
            'SMTPサーバーを指定する
            sc.Host = "webserver02"
            'ポート番号を指定する（既定値は25）
            sc.Port = 25
            'メールを送信する
            sc.Send(senderMail, recipientMail, subject, body)
            MessageBox.Show("登録メールアドレスにメールを送りました")
            '後始末
            sc.Dispose()
        End If

        Me.Close()
        Connection.Close()

    End Sub

    Private Sub txtNumber_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumber.TextChanged

    End Sub
End Class