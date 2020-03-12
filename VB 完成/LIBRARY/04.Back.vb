Public Class Back
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader
    Dim adapter As SqlClient.SqlDataAdapter

    Dim libraryNumber As String '蔵書番号(バーコード)'
    Dim userNumber As String '利用者番号'

    Dim senderMailAddress As String = "14jy0100@jynet.jec.ac.jp" '送信元アドレス'
    Dim subject As String = "こんにちは、こちらは日本電子専門学校図書館です。" '件名'
    Dim header As String = "こんにちは、こちらは日本電子専門学校図書館です。" & vbCrLf '本文ヘッダー'
    Dim body As String = "" '本文'
    Dim footer As String = vbCrLf + "それではまた。" '本文フッター'

    Dim print As String = "" '出力する予約本の引き当て書の内容'

    Private Sub Back_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtDate.Text = Format(Today, "yyyy/MM/dd")
        txtUserNumber.Text = ""
        txtUserName.Text = ""
        txtUserNameKana.Text = ""
        txtLibraryNumber.Text = ""
        txtTitle.Text = ""
        txtOptionName.Text = ""
        chkOptionBorrow.Checked = False
        chkOptionBorrow.Enabled = False
        txtScheduleReturnDate.Text = ""
        btnBack.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        '検索ボタンクリック'
        'Title,OptionName,ScheduleReturnDate'

        '入力チェック'
        '蔵書番号入力チェック'
        If txtLibraryNumber.Text = "" Then
            MessageBox.Show("蔵書番号が未入力です", "ユーザーエラー")
            Exit Sub
        End If

        If txtLibraryNumber.Text.Contains("'") Or txtLibraryNumber.Text.Contains("""") Or txtLibraryNumber.Text.Contains("　") Or txtLibraryNumber.Text.Contains("-") Then
            MessageBox.Show("蔵書番号に無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If
        If Not txtLibraryNumber.Text.Length = 9 Then
            MessageBox.Show("蔵書番号の桁数が間違っています", "ユーザーエラー")
            Exit Sub
        End If

        Connection.Open()

        'libraryNumberがLibraryに登録されているかの判定'
        command.CommandText = "SELECT Title, OptionName FROM Library,Book,OptionType WHERE Library.BookNumber = Book.BookNumber AND Book.OptionNumber = OptionType.OptionNumber AND LibraryNumber ='" & txtLibraryNumber.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read() = False Then
            MessageBox.Show("蔵書番号が間違っています。", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If
        dr.Close()
        libraryNumber = txtLibraryNumber.Text

        '貸出登録済みかの判断'
        command.CommandText = "SELECT Borrow.UserNumber, UserName, Kana, Title, OptionName, OptionBorrowFlag, ScheduleReturnDate FROM Borrow, LibraryUser, Library, OptionType, Book WHERE Borrow.LibraryNumber ='" & libraryNumber & "'  AND Borrow.LibraryNumber = Library.LibraryNumber AND Book.BookNumber = Library.BookNumber AND Book.OptionNumber = OptionType.OptionNumber AND Borrow.ReturnDate IS NULL AND LibraryUser.UserNumber =(SELECT UserNumber FROM Borrow WHERE LibraryNumber = '" & libraryNumber & "' AND ReturnDate IS NULL GROUP BY UserNumber)"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read() = False Then
            MessageBox.Show("貸出登録されていない蔵書番号です", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If
        '情報をセット'
        libraryNumber = txtLibraryNumber.Text
        userNumber = dr("UserNumber")

        txtTitle.Text = dr("Title")
        txtOptionName.Text = dr("OptionName")
        If dr("OptionBorrowFlag") = 1 Then
            MessageBox.Show("付属品の貸出履歴があります", "メッセージ")
            chkOptionBorrow.Checked = True
        End If
        txtScheduleReturnDate.Text = dr("ScheduleReturnDate")

        txtUserNumber.Text = dr("UserNumber")
        txtUserName.Text = dr("UserName")
        txtUserNameKana.Text = dr("Kana")
        Connection.Close()

        dgvBorrowListUpdate()
        btnBack.Enabled = True
        btnClear.Enabled = True
        txtLibraryNumber.Text = ""

    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '返却ボタンをクリック'
        Connection.Open()


        'Borrowに返却日を挿入'
        command.CommandText = "UPDATE Borrow SET ReturnDate = GETDATE() WHERE ReturnDate IS NULL AND LibraryNumber = '" & libraryNumber & "' AND UserNumber = '" & userNumber & "'"
        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        txtLibraryNumber.Text = ""
        txtTitle.Text = ""
        txtOptionName.Text = ""
        chkOptionBorrow.Checked = False
        txtScheduleReturnDate.Text = ""
        btnBack.Enabled = False

        Connection.Close()
        dgvBorrowListUpdate()
        Connection.Open()


        '予約者がいたらBookingに入荷日を挿入して予約者情報を印刷して予約者に入荷情報を()メールする'
        command.CommandText = "SELECT MIN(BookingNumber) AS 'MinBookingNumber'  FROM Booking WHERE RegisterDate IS NULL AND LibraryNumber = '" & libraryNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If Not dr.Read() Then
            dr.Close()
            Connection.Close()
            libraryNumber = ""
            Exit Sub
        End If
        If IsDBNull(dr("MinBookingNumber")) Then '予約者無し'
            dr.Close()
            '予約者がいないため蔵書を貸出可能状態に変更'
            command.CommandText = "UPDATE Library SET BorrowFlag = 0 WHERE LibraryNumber = '" & libraryNumber & "'"
            Try
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            libraryNumber = ""
            Connection.Close()
            Exit Sub
        Else '予約者ありBookingNumber'
            dr.Close()
            '予約入荷情報書き込み'
            command.CommandText = "UPDATE Booking SET RegisterDate = GETDATE() WHERE BookingNumber = (SELECT MIN(BookingNumber) AS 'MinBookingNumber'  FROM Booking WHERE RegisterDate IS NULL AND LibraryNumber = '" & libraryNumber & "')"
            Try
                command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            '予約者情報を表示、印刷、メール送信する'
            command.CommandText = "SELECT BookingNumber, Booking.UserNumber, UserName, MailAddress, Booking.LibraryNumber, Title FROM Booking, LibraryUser, Library, Book WHERE Booking.UserNumber = LibraryUser.UserNumber AND Booking.LibraryNumber = Library.LibraryNumber AND Library.BookNumber = Book.BookNumber AND BookingNumber = (SELECT MAX(BookingNumber) AS 'MaxBookingNumber'  FROM Booking WHERE RegisterDate IS NOT NULL AND LibraryNumber = '" & libraryNumber & "')"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If Not dr.Read() Then
                Connection.Close()
                libraryNumber = ""
                Exit Sub
            End If
            MessageBox.Show("この蔵書には予約が入っています" & vbCrLf & "利用者番号：" & dr("UserNumber") & vbCrLf & "利用者名：" & dr("UserName"), "システムメッセージ")

            'ここにメールと印刷処理'
            'メール処理'
            subject = "【日本電子専門学校図書館】予約蔵書入荷のお知らせ"
            body = "【日本電子専門学校図書館】予約蔵書入荷のお知らせ" & vbCrLf & "" & vbCrLf & dr("UserName") & "様" & vbCrLf & "日本電子専門学校図書館のご利用ありがとうございます。" & vbCrLf & "以前予約した蔵書 " & dr("Title") & " が入荷しました。" & vbCrLf & "お申し込みは下記の内容で承りました。" & vbCrLf & "予約した本を3日間以内借りに来ない場合自動取り消しになりますのでご注意ください。" & vbCrLf & "" & vbCrLf & "■蔵書番号:" & dr("LibraryNumber") & vbCrLf & "" & vbCrLf & "■蔵書名:" & dr("Title") & vbCrLf & "" & vbCrLf & "■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□" & vbCrLf & "■お問い合わせ先" & vbCrLf & "■日本電子専門学校図書館" & vbCrLf & "■TEL     ：03-xxx-xxx 受付時間：09:00-20:00（土・日・祝日をのぞく）" & vbCrLf & "■E-MAIL：info@jec.ac.jp" & vbCrLf & "■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□" & vbCrLf & "■注意事項" & vbCrLf & "■他のお問い合わせ等は上記の連絡先にお願いします。" & vbCrLf & "■このメールはコンピュータシステムによって自動的に送信しています。" & vbCrLf & "■このため、お問い合わせ等をこのメールに返信いただいても回答できません。"

            'ここにメール送信の処理を書く(userName,title,mailAddress)'
            'SmtpClientオブジェクトを作成する
            Dim sc As New System.Net.Mail.SmtpClient()
            'SMTPサーバーを指定する
            sc.Host = "webserver02"
            'ポート番号を指定する（既定値は25）
            sc.Port = 25
            'メールを送信する
            sc.Send(senderMailAddress, dr("MailAddress"), subject, body)
            sc.Dispose()
            'メール処理完了'

            '引き当て印刷処理'
            print = "利用者番号：" & dr("UserNumber") & vbCrLf & "利用者名：" & dr("UserName") & vbCrLf & "蔵書番号：" & dr("LibraryNumber") & vbCrLf & "書名：" & dr("Title") & vbCrLf & "入荷日付：" & Format(Today, "yyyy/MM/dd") & vbCrLf & "予約番号：" & dr("BookingNumber")
            BookingInfoOutputer.Print()
            '印刷処理完了'
            dr.Close()
        End If

        Connection.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtUserNumber.Text = ""
        txtUserName.Text = ""
        txtUserNameKana.Text = ""
        txtLibraryNumber.Text = ""
        txtTitle.Text = ""
        txtOptionName.Text = ""
        chkOptionBorrow.Checked = False
        chkOptionBorrow.Enabled = False
        txtScheduleReturnDate.Text = ""
        btnBack.Enabled = False
        btnClear.Enabled = False
        dgvBorrowList.DataSource = Nothing
    End Sub

    Private Sub btnRental_Click(sender As System.Object, e As System.EventArgs) Handles btnRental.Click '貸し出しボタンクリック'
        '貸し出し画面に移動する'
        '返却画面を閉じる'
        Borrow.Show()
        Me.Close()
    End Sub

    Private Sub btnTop_Click(sender As System.Object, e As System.EventArgs) Handles btnTopBack.Click 'Topボタンクリック'
        Me.Close()
    End Sub

    Private Sub dgvBorrowListUpdate() '貸し出しリストを更新する'
        Connection.Open()
        Try
            'ここからDataGridViewの表示'
            'userNumberに一致するUserNumberのBorrowデータを表示する'
            command.CommandText = "SELECT ScheduleReturnDate AS '返却予定日', Borrow.LibraryNumber AS '蔵書番号', Title AS '書名', OptionName AS '付録', CASE WHEN OptionBorrowFlag=0 THEN '無し' WHEN OptionBorrowFlag=1 THEN '有り' ELSE 'NULL' END '付録貸出し', CASE WHEN ExtensionFlag=0 THEN '無し' WHEN ExtensionFlag=1 THEN '有り' ELSE 'NULL' END '延長履歴' FROM Borrow,Library,Book,OptionType WHERE ReturnDate IS NULL AND Borrow.LibraryNumber=Library.LibraryNumber AND Library.BookNumber=Book.BookNumber AND Book.OptionNumber = OptionType.OptionNumber AND UserNumber = '" & userNumber & "'"
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
    End Sub

    Private Sub BookingInfoOutputer_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles BookingInfoOutputer.PrintPage
        Dim font As New Font("M S 明治", 12, FontStyle.Bold)
        e.Graphics.DrawString(print, font, Brushes.BlueViolet, 10, 10)
    End Sub

End Class