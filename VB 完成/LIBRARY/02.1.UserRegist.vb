Public Class UserRegist
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Private Sub Register_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNumber.Enabled = False
        txtName.Enabled = False
        txtKana.Enabled = False
        txtMailAddress.Enabled = False
        txtTelephoneNumber.Enabled = False
        btnReview.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        txtNumber.Text = ""
        txtName.Text = ""
        txtKana.Text = ""
        txtMailAddress.Text = ""
        txtTelephoneNumber.Text = ""
        '入力チェック'
        If txtUserNumberSearch.Text = "" Then
            MessageBox.Show("利用者番号が未入力です", "ユーザーエラー")
            Exit Sub
        End If
        If txtUserNumberSearch.Text.Contains("'") Or txtUserNumberSearch.Text.Contains("""") Or txtUserNumberSearch.Text.Contains("　") Or txtUserNumberSearch.Text.Contains("-") Then
            MessageBox.Show("利用者番号に無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If
        If Not txtUserNumberSearch.Text.Length = 8 Then
            MessageBox.Show("利用者番号の桁数が間違っています", "ユーザーエラー")
            Exit Sub
        End If


        'DB接続'
        Connection.Open()

        '利用者情報問い合わせ'
        command.CommandText = "SELECT UserNumber, UserName, Kana, MailAddress, TelephoneNumber FROM LibraryUser WHERE UserNumber =" & "'" & txtUserNumberSearch.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read() Then
            txtNumber.Text = dr("UserNumber")
            txtName.Text = dr("UserName")
            txtKana.Text = dr("Kana")
            If IsDBNull(dr("MailAddress")) Then
                txtMailAddress.Text = ""
            Else
                txtMailAddress.Text = dr("MailAddress")
            End If
            If IsDBNull(dr("TelephoneNumber")) Then
                txtTelephoneNumber.Text = ""
            Else
                txtTelephoneNumber.Text = dr("TelephoneNumber")
            End If

            '入力欄有効化'
            txtNumber.Enabled = True
            txtName.Enabled = True
            txtKana.Enabled = True
            txtMailAddress.Enabled = True
            txtTelephoneNumber.Enabled = True
            btnReview.Enabled = True

        Else
            MessageBox.Show("入力された番号は有効ではありません「" & txtUserNumberSearch.Text & "」", "ユーザーエラー")
        End If

        txtUserNumberSearch.Text = "" '利用者番号入力欄初期化'

        Connection.Close() 'DB切断'
    End Sub

    Private Sub btnReview_Click(sender As System.Object, e As System.EventArgs) Handles btnReview.Click


        '入力チェック'
        If txtNumber.Text = "" Then
            MessageBox.Show("利用者番号が未入力です", "ユーザーエラー")
            Exit Sub
        End If
        If Len(txtName.Text) = 0 Then
            MessageBox.Show("利用者名が未入力です", "ユーザーエラー")
            Exit Sub
        End If
        If txtName.Text.Contains("'") Or txtName.Text.Contains("""") Or txtName.Text.Contains("-") Then
            MessageBox.Show("利用者名に無効な文字が入力されています、「-」「'」「""」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If

        If Len(txtKana.Text) = 0 Then
            MessageBox.Show("利用者名よみがなが未入力です", "ユーザーエラー")
            Exit Sub
        End If
        If txtKana.Text.Contains("'") Or txtKana.Text.Contains("""") Or txtKana.Text.Contains("-") Then
            MessageBox.Show("利用者名よみがなに無効な文字が入力されています、「-」「'」「""」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If


        If (Len(txtMailAddress.Text) <= 3 Or txtMailAddress.Text.Contains(" ")) AndAlso Not txtMailAddress.Text.Contains("@") Then
            MessageBox.Show("メールアドレスが未入力です", "ユーザーエラー")
            Exit Sub
        End If
        If txtMailAddress.Text.Contains("'") Or txtMailAddress.Text.Contains("""") Or txtMailAddress.Text.Contains("　") Or txtMailAddress.Text.Contains("-") Then
            MessageBox.Show("メールアドレスに無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If

        If Len(txtTelephoneNumber.Text) = 0 Then
            MessageBox.Show("電話番号が未入力です。", "ユーザーエラー")
            Exit Sub
        End If
        If Not IsNumeric(txtTelephoneNumber.Text) Then
            MessageBox.Show("電話番号に数字以外が入力されています", "ユーザーエラー")
            Exit Sub
        End If
        If Len(txtTelephoneNumber.Text) < 8 Then
            MessageBox.Show("電話番号の入力桁数が間違っています", "ユーザーエラー")
            Exit Sub
        End If
        If txtTelephoneNumber.Text.Contains("'") Or txtTelephoneNumber.Text.Contains("""") Or txtTelephoneNumber.Text.Contains("　") Or txtTelephoneNumber.Text.Contains("-") Then
            MessageBox.Show("電話番号に無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If


        UserInfoReview.Show()

        '「UserInfoReview」に利用者のデータを渡す'
        UserInfoReview.txtNumber.Text = txtNumber.Text
        UserInfoReview.txtName.Text = txtName.Text
        UserInfoReview.txtKana.Text = txtKana.Text
        UserInfoReview.txtMailAddress.Text = txtMailAddress.Text
        UserInfoReview.txtTelephoneNumber.Text = txtTelephoneNumber.Text

    End Sub

End Class