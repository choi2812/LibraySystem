Imports System.Net.Mail

Public Class BorrowList
    Private Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Private command As SqlClient.SqlCommand = Connection.CreateCommand
    Private dr As SqlClient.SqlDataReader
    Private adapter As SqlClient.SqlDataAdapter

    Private userNumber As String '利用者番号'
    Private libraryNumber As String '蔵書番号(バーコード)'

    Dim senderMailAddress As String = "14jy0100@jynet.jec.ac.jp" '送信元アドレス'
    Dim subject As String = "こんにちは、こちらは日本電子専門学校図書館です。" '件名'
    Dim header As String = "こんにちは、こちらは日本電子専門学校図書館です。" & vbCrLf '本文ヘッダー'
    Dim body As String = "" '本文'
    Dim footer As String = vbCrLf + "それではまた。" '本文フッター'


    Dim column As New DataGridViewCheckBoxColumn 'リストのチェックボックス'

    Private Sub BorrowList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvBorrowList.DataSource = Nothing
        Dim column As New DataGridViewCheckBoxColumn 'リストのチェックボックス'
        column.Name = "select"
        column.HeaderText = "選択"
        dgvBorrowList.Columns.Insert(0, column)

        btnClear.Enabled = False
        btnBack.Enabled = False
    End Sub

    Private Sub btnBookingList_Click(sender As System.Object, e As System.EventArgs) Handles btnBookingList.Click
        '予約リストに遷移する'
        BookingDelete.Show()
        Me.Close()
    End Sub

    Private Sub btnTop_Click(sender As System.Object, e As System.EventArgs) Handles btnTop.Click
        'Top画面に遷移する'
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        '検索条件入力欄と貸し出しリストを初期化する'
        txtNumber.Text = ""
        userNumber = ""
        libraryNumber = ""
        btnClear.Enabled = False
        btnBack.Enabled = False
        dgvBorrowList.DataSource = Nothing
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        '番号入力チェック'
        If txtNumber.Text = "" Then
            MessageBox.Show("番号が未入力です", "ユーザーエラー")
            Exit Sub
        End If

        If txtNumber.Text.Contains("'") Or txtNumber.Text.Contains("""") Or txtNumber.Text.Contains("　") Or txtNumber.Text.Contains("-") Then
            MessageBox.Show("番号に無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If
        If txtNumber.Text.Length < 8 Or txtNumber.Text.Length > 9 Then
            MessageBox.Show("番号の桁数が間違っています", "ユーザーエラー")
            Exit Sub
        End If


        '検索条件に合わせて関数を呼び出す'
        Connection.Open()
        If rbUserNumber.Checked Then


            command.CommandText = "SELECT UserNumber FROM LibraryUser WHERE UserNumber = '" & txtNumber.Text & "'"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If Not dr.Read() Then '利用者番号がDBに登録されていない場合'
                MessageBox.Show("利用者番号が間違っています。", "エラーメッセ－ジ")
                Connection.Close()
                Exit Sub
            End If
            userNumber = txtNumber.Text
            Connection.Close()
            SearchByUserNumber()

        ElseIf rbLibrarynumber.Checked Then


            command.CommandText = "SELECT LibraryNumber FROM Library WHERE LibraryNumber = '" & txtNumber.Text & "'"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If Not dr.Read() Then '蔵書番号がDBに登録されていない場合'
                MessageBox.Show("蔵書番号が間違っています。", "エラーメッセ－ジ")
                Connection.Close()
                Exit Sub
            End If
            libraryNumber = txtNumber.Text
            Connection.Close()
            SearchByLibraryNumber()
        End If
        btnClear.Enabled = True
        btnBack.Enabled = True
        txtNumber.Text = ""
    End Sub

    Private Sub btnTimeOver_Click(sender As System.Object, e As System.EventArgs) Handles btnTimeOver.Click

        '期限越えを検索表示する'
        SearchByDate()
        btnClear.Enabled = True
        btnBack.Enabled = True

    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click

        Connection.Open()

        'ここで催促メール処理'

        Dim sc As New System.Net.Mail.SmtpClient()
        'SMTPサーバーを指定する
        sc.Host = "webserver02"
        'ポート番号を指定する（既定値は25）
        sc.Port = 25
        Dim count As Integer = 0
        For i As Integer = dgvBorrowList.Rows.Count - 1 To 0 Step -1

            If dgvBorrowList.Rows(i).Cells("select").Value Then

                command.CommandText = "SELECT UserName,MailAddress FROM LibraryUser WHERE UserNumber = '" & dgvBorrowList(1, i).Value() & "'"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read() Then
                    If Not IsDBNull(dr("MailAddress")) AndAlso Not dr("MailAddress") = "" Then
                        Dim recipientMailAddress As String = dr("MailAddress")
                        subject = "【日本電子専門学校図書館】貸出期間越えのお知らせ"
                        'メールを送信する
                        Dim body As String = "【日本電子専門学校図書館】貸出期間越えのお知らせ" + vbCrLf + dr("UserName") + vbCrLf + "様" + vbCrLf + vbCrLf + "日本電子専門学校図書館のご利用ありがとうございます。" + vbCrLf + vbCrLf + "日本電子図書から借りた本が貸出期間（７日）を超えているので早めに本を持って窓口までお越しください。" + vbCrLf + vbCrLf + "お問い合わせ先" + vbCrLf + vbCrLf + "日本電子専門学校図書館()" + vbCrLf + vbCrLf + "TEL     ：03-xxx-xxx 受付時間：09:00-20:00（土・日・祝日をのぞく）" + vbCrLf + vbCrLf + "E-MAIL : info@(jec.ac.jp)"
                        sc.Send(senderMailAddress, recipientMailAddress, subject, body)
                    End If
                End If
                dr.Close()
                count += 1
            End If
        Next i
        If count = 0 Then
            MessageBox.Show("返却催促する貸出を選択してください", "ユーザーエラー")
        Else
            MessageBox.Show("返却催促が完了しました", "システムメッセージ")
        End If

        sc.Dispose()
        Connection.Close()

    End Sub

    Private Sub SearchByUserNumber() '利用者番号で検索表示'
        Connection.Open()
        Try
            'ここからDataGridViewの表示'
            'userNumberに一致するUserNumberのBorrowデータを表示する'
            command.CommandText = "SELECT Borrow.UserNumber AS '利用者番号', UserName AS '利用者名', ScheduleReturnDate AS '返却予定日', CASE WHEN ScheduleReturnDate <= Getdate() THEN '期間超過' WHEN GETDATE() <= ScheduleReturnDate THEN '期間内' ELSE '不明' END '貸出期間', Borrow.LibraryNumber AS '蔵書番号', Title AS '書名', OptionName AS '付録', CASE WHEN OptionBorrowFlag=0 THEN '無し' WHEN OptionBorrowFlag=1 THEN '有り' ELSE 'NULL' END '付録貸出し', 	CASE WHEN ExtensionFlag=0 THEN '無し' WHEN ExtensionFlag=1 THEN '有り' ELSE 'NULL' END '延長履歴' FROM Borrow, Library, Book,	OptionType, LibraryUser WHERE ReturnDate IS NULL AND Borrow.UserNumber = LibraryUser.UserNumber AND Borrow.LibraryNumber=Library.LibraryNumber AND Library.BookNumber=Book.BookNumber AND Book.OptionNumber = OptionType.OptionNumber AND Borrow.UserNumber = '" & userNumber & "'"
            adapter = New SqlClient.SqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            dgvBorrowList.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        Connection.Close()
        libraryNumber = ""
    End Sub

    Private Sub SearchByLibraryNumber() '蔵書番号で検索表示'
        Connection.Open()
        Try
            'ここからDataGridViewの表示'
            'libraryNumberに一致するLibraryNumberのBorrowデータを表示する'
            '表示内容は「利用者番号,利用者名,貸出日,返却予定日,延長履歴,予約者数,付録,付録貸出」'
            command.CommandText = "SELECT Borrow.UserNumber AS '利用者番号', UserName AS '利用者名', Library.LibraryNumber AS '蔵書番号',Title AS '書名', BorrowDate AS '貸出日', ScheduleReturnDate AS '返却予定日', CASE WHEN ScheduleReturnDate <= Getdate() THEN '期間超過' WHEN Getdate() <= ScheduleReturnDate THEN '期間内' ELSE '不明' END '貸出期間', CASE WHEN ExtensionFlag=0 THEN '無し' WHEN ExtensionFlag=1 THEN '有り' ELSE '不明' END '延長履歴', OptionName AS '付録', CASE WHEN OptionBorrowFlag = 0 THEN '無し' WHEN OptionBorrowFlag = 1 THEN '有り' ELSE '不明' END '付録貸出' FROM Library,LibraryUser,Book,OptionType,Borrow WHERE ReturnDate IS NULL  AND  Borrow.UserNumber = LibraryUser.UserNumber  AND OptionType.OptionNumber = Book.OptionNumber  AND  Library.BookNumber = Book.BookNumber  AND Borrow.LibraryNumber = Library.LibraryNumber AND Library.LibraryNumber = '" & libraryNumber & "'"
            adapter = New SqlClient.SqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            dgvBorrowList.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        Connection.Close()
        userNumber = ""
    End Sub

    Private Sub SearchByDate() '期限越えで検索表示'
        Connection.Open()
        Try
            'ここからDataGridViewの表示'
            'userNumberに一致するUserNumberのBorrowデータを表示する'
            '表示内容は「返却予定日,貸出日,書名,蔵書番号,利用者名,利用者番号,付録,付録貸出」'
            command.CommandText = "SELECT Borrow.UserNumber AS '利用者番号', UserName AS '利用者名', ScheduleReturnDate AS '返却予定日', BorrowDate AS '貸出日', Title AS '書名', Borrow.LibraryNumber AS '蔵書番号', OptionName AS '付録', CASE WHEN OptionBorrowFlag = 0 THEN '無し' WHEN OptionBorrowFlag = 1 THEN '有り' ELSE '不明' End '付録貸出' FROM Borrow, LibraryUser, Library, Book, OptionType WHERE Borrow.UserNumber = LibraryUser.UserNumber  AND Borrow.LibraryNumber = Library.LibraryNumber AND Library.BookNumber = Book.BookNumber AND Book.OptionNumber = OptionType.OptionNumber AND ScheduleReturnDate <GETDATE() ORDER BY ScheduleReturnDate"
            adapter = New SqlClient.SqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            dgvBorrowList.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try

        Connection.Close()
        libraryNumber = ""
        userNumber = ""
    End Sub
End Class






















