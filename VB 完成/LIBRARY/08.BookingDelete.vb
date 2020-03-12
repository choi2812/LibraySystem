Public Class BookingDelete

    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader
    Dim adapter As SqlClient.SqlDataAdapter


    Private userNumber As String '利用者番号'
    Private libraryNumber As String '蔵書番号(バーコード)'

    Dim senderMailAddress As String = "14jy0100@jynet.jec.ac.jp" '送信元アドレス'
    Dim subject As String = "こんにちは、こちらは日本電子専門学校図書館です。" '件名'
    Dim header As String = "こんにちは、こちらは日本電子専門学校図書館です。" & vbCrLf '本文ヘッダー'
    Dim body As String = "" '本文'
    Dim footer As String = vbCrLf + "それではまた。" '本文フッター'

    Dim print As String = "" '出力する予約本の引き当て書の内容'

    Private Sub BookingDelete_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvBookingList.DataSource = Nothing
        Dim column As New DataGridViewCheckBoxColumn
        rbUserNumber.Checked = True
        column.Name = "checkbox"
        column.HeaderText = "選択"
        dgvBookingList.Columns.Insert(0, column)

        txtNumber.Text = ""
        btnDelete.Enabled = False

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
        If rbUserNumber.Checked Then '利用者番号で検索'
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

        ElseIf rblibraryNumber.Checked Then '蔵書番号で検索'
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

        txtNumber.Text = ""
        btnDelete.Enabled = True


    End Sub

    Private Sub btnLimitSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnLimitSearch.Click
        SearchByDate()
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Connection.Open()
        '予約削除する'

        Dim rat As DialogResult

        rat = MessageBox.Show("選択した予約デ－タを削除します。" & vbCrLf & "よろしいですか？", "確認", MessageBoxButtons.YesNo)
        If Not rat = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("キャンセルしました。", "確認")
            Connection.Close()
            Exit Sub
        End If

        Dim mailAddress As String = ""
        Dim userName As String = ""
        Dim title As String = ""
        Dim deleteCount As Integer = 0
        Dim dgvUserNumber As String = ""
        Dim dgvLibraryNumber As String = ""
        For i As Integer = dgvBookingList.Rows.Count - 1 To 0 Step -1
            'SmtpClientオブジェクトを作成する
            Dim sc As New System.Net.Mail.SmtpClient()
            'SMTPサーバーを指定する
            sc.Host = "webserver02"
            'ポート番号を指定する（既定値は25）
            sc.Port = 25

            If dgvBookingList.Rows(i).Cells("checkbox").Value Then

                dgvUserNumber = dgvBookingList(2, i).Value()
                dgvLibraryNumber = dgvBookingList(1, i).Value()


                '予約が入荷しているかどうか'
                command.CommandText = "SELECT * FROM Booking WHERE RegisterDate IS NOT NULL AND LibraryNumber = '" & dgvLibraryNumber & "' AND UserNumber = '" & dgvUserNumber & "'"
                Try
                    dr = command.ExecuteReader()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If Not dr.Read Then '入荷していない場合'
                    dr.Close()
                    '予約リストの削除処理'
                    command.CommandText = "DELETE FROM Booking WHERE UserNumber= '" & dgvUserNumber & "' AND LibraryNumber = '" & dgvLibraryNumber & "'"
                    Try
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try


                    '削除メール処理'
                    mailAddress = ""
                    userName = ""
                    title = ""
                    Dim mailTitle As String = ""
                    command.CommandText = "SELECT Title FROM Book,Library WHERE Book.BookNumber = Library.BookNumber AND LibraryNumber='" & dgvLibraryNumber & "'"
                    Try
                        dr = command.ExecuteReader()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read() Then
                        mailTitle = dr("Title")
                    End If
                    dr.Close()
                    '利用者情報セット'
                    command.CommandText = "SELECT UserName, MailAddress FROM LibraryUser WHERE UserNumber='" & dgvUserNumber & "'"
                    Try
                        dr = command.ExecuteReader()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read() Then
                        userName = dr("UserName")
                        mailAddress = dr("MailAddress")
                    End If
                    subject = "【日本電子専門学校図書館】予約取り消しのお知らせ"
                    body = "【日本電子専門学校図書館】予約取り消しのお知らせ" & vbCrLf & vbCrLf & userName & "様" & vbCrLf & vbCrLf & "日本電子専門学校図書館のご利用ありがとうございます。" & vbCrLf & vbCrLf & userName & "様の予約した本を3日間以内借りに来ないので予約取り消しました。" & vbCrLf & "蔵書番号：" & dgvLibraryNumber & vbCrLf & "書名：" & mailTitle & vbCrLf & vbCrLf & "お問い合わせ先" & vbCrLf & "日本電子専門学校図書館" & vbCrLf & "TEL     ：03-xxx-xxx 受付時間：09:00-20:00（土・日・祝日をのぞく）" & vbCrLf & "E-MAIL：info@jec.ac.jp"
                    'メールを送信する
                    If (Not senderMailAddress = "") AndAlso (Not mailAddress = "") Then
                        sc.Send(senderMailAddress, mailAddress, subject, body)
                    End If
                    dr.Close()


                Else '入荷している場合'


                    dr.Close()
                    '予約リストの削除処理'
                    command.CommandText = "DELETE FROM Booking WHERE UserNumber= '" & dgvUserNumber & "' AND LibraryNumber = '" & dgvLibraryNumber & "'"
                    Try
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try


                    '削除メール処理'
                    mailAddress = ""
                    userName = ""
                    title = ""
                    Dim mailTitle As String = ""
                    command.CommandText = "SELECT Title FROM Book,Library WHERE Book.BookNumber = Library.BookNumber AND LibraryNumber='" & dgvLibraryNumber & "'"
                    Try
                        dr = command.ExecuteReader()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read() Then
                        mailTitle = dr("Title")
                    End If
                    dr.Close()
                    '利用者情報セット'
                    command.CommandText = "SELECT UserName, MailAddress FROM LibraryUser WHERE UserNumber='" & dgvUserNumber & "'"
                    Try
                        dr = command.ExecuteReader()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read() Then
                        userName = dr("UserName")
                        mailAddress = dr("MailAddress")
                    End If
                    subject = "【日本電子専門学校図書館】予約取り消しのお知らせ"
                    body = "【日本電子専門学校図書館】予約取り消しのお知らせ" & vbCrLf & vbCrLf & userName & "様" & vbCrLf & vbCrLf & "日本電子専門学校図書館のご利用ありがとうございます。" & vbCrLf & vbCrLf & userName & "様の予約した本を3日間以内借りに来ないので予約取り消しました。" & vbCrLf & "蔵書番号：" & dgvLibraryNumber & vbCrLf & "書名：" & mailTitle & vbCrLf & vbCrLf & "お問い合わせ先" & vbCrLf & "日本電子専門学校図書館" & vbCrLf & "TEL     ：03-xxx-xxx 受付時間：09:00-20:00（土・日・祝日をのぞく）" & vbCrLf & "E-MAIL：info@jec.ac.jp"
                    'メールを送信する
                    If (Not senderMailAddress = "") AndAlso (Not mailAddress = "") Then
                        sc.Send(senderMailAddress, mailAddress, subject, body)
                    End If
                    '削除完了'



                    '予約有無判定'
                    dr.Close()
                    command.CommandText = "SELECT MIN(BookingNumber) AS 'MinBookingNumber' FROM Booking WHERE LibraryNumber = '" & dgvLibraryNumber & "'"
                    Try
                        dr = command.ExecuteReader()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read() And Not IsDBNull(dr("MinBookingNumber")) Then
                        '引き当て処理'
                        Dim bookingNumber As String
                        bookingNumber = dr("MinBookingNumber")
                        dr.Close()
                        command.CommandText = "UPDATE Booking SET RegisterDate = GETDATE() WHERE BookingNumber = '" & bookingNumber & "'"
                        Try
                            command.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            Connection.Close()
                            Exit Sub
                        End Try

                        '引き当てメール処理'
                        mailAddress = ""
                        userName = ""
                        title = ""

                        '利用者情報、書名セット'
                        command.CommandText = "SELECT Booking.UserNumber, UserName, MailAddress, Booking.LibraryNumber,BookingNumber, Title FROM Booking, Library, Book,LibraryUser WHERE  (( Booking.UserNumber = LibraryUser.UserNumber ) AND (Booking.LibraryNumber = Library.LibraryNumber  AND Library.BookNumber = Book.BookNumber)) AND BookingNumber = '" & bookingNumber & "'"
                        Try
                            dr = command.ExecuteReader()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            Connection.Close()
                            Exit Sub
                        End Try
                        If dr.Read() Then
                            'メールを送信する
                            subject = "【日本電子専門学校図書館】予約蔵書入荷のお知らせ"
                            body = "【日本電子専門学校図書館】予約蔵書入荷のお知らせ" & vbCrLf & "" & vbCrLf & dr("UserName") & "様" & vbCrLf & "日本電子専門学校図書館のご利用ありがとうございます。" & vbCrLf & "以前予約した蔵書 " & dr("Title") & " が入荷しました。" & vbCrLf & "お申し込みは下記の内容で承りました。" & vbCrLf & "予約した本を3日間以内借りに来ない場合自動取り消しになりますのでご注意ください。" & vbCrLf & "" & vbCrLf & "■蔵書番号:" & dr("LibraryNumber") & vbCrLf & "" & vbCrLf & "■蔵書名:" & dr("Title") & vbCrLf & "" & vbCrLf & "■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□" & vbCrLf & "■お問い合わせ先" & vbCrLf & "■日本電子専門学校図書館" & vbCrLf & "■TEL     ：03-xxx-xxx 受付時間：09:00-20:00（土・日・祝日をのぞく）" & vbCrLf & "■E-MAIL：info@jec.ac.jp" & vbCrLf & "■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□■□" & vbCrLf & "■注意事項" & vbCrLf & "■他のお問い合わせ等は上記の連絡先にお願いします。" & vbCrLf & "■このメールはコンピュータシステムによって自動的に送信しています。" & vbCrLf & "■このため、お問い合わせ等をこのメールに返信いただいても回答できません。"

                            sc.Send(senderMailAddress, dr("MailAddress"), subject, body)

                            '引き当て印刷処理'
                            print = "利用者番号：" & dr("UserNumber") & vbCrLf & "利用者名：" & dr("UserName") & vbCrLf & "蔵書番号：" & dr("LibraryNumber") & vbCrLf & "書名：" & dr("Title") & vbCrLf & "入荷日付：" & Format(Today, "yyyy/MM/dd") & vbCrLf & "予約番号：" & dr("BookingNumber")
                            BookingInfoOutputer.Print()
                        End If
                        'メール送信完了'
                    End If
                    '次の予約への引き当て処理完了'
                End If
                '入荷していた場合の予約取り消し完了'


                dr.Close()
                command.CommandText = "SELECT * FROM Booking WHERE LibraryNumber = '" & dgvLibraryNumber & "'"
                Try
                    dr = command.ExecuteReader()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                '予約が存在しなければ'
                If Not dr.Read Then
                    dr.Close()
                    command.CommandText = "UPDATE Library SET BorrowFlag = 0 WHERE LibraryNumber = '" & dgvLibraryNumber & "'"
                    Try
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    dr.Close()
                End If
                dr.Close()
            End If
            sc.Dispose()
            deleteCount += 1
        Next i

        Connection.Close()

        If deleteCount = 0 Then
            MessageBox.Show("削除対象を選択してください", "ユーザーエラー")
        End If



        Connection.Close()


        'リスト更新'
        If libraryNumber = "" AndAlso userNumber = "" Then
            SearchByDate()
            Exit Sub
        End If
        If Not userNumber = "" AndAlso libraryNumber = "" Then
            SearchByUserNumber()
            Exit Sub
        End If
        If userNumber = "" AndAlso Not libraryNumber = "" Then
            SearchByLibraryNumber()
            Exit Sub
        End If


    End Sub


    Private Sub btnBorrowList_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrowList.Click
        '貸出リストに移動'
        BorrowList.Show()
        Me.Close()
    End Sub

    Private Sub btnTop_Click(sender As System.Object, e As System.EventArgs) Handles btnTop.Click
        'トップ画面に戻る'
        Me.Close()
    End Sub

    Private Sub SearchByUserNumber()
        '利用者番号で検索表示'

        Connection.Open()
        Try
            'ここからDataGridViewの表示'
            'userNumberに一致するUserNumberのBookingデータを表示する'
            command.CommandText = "SELECT Library.LibraryNumber AS '蔵書番号',LibraryUser.UserNumber AS  '利用者番号', UserName as '利用者名',Title AS '書名',BookingDate as '予約受付日',RegisterDate as '入荷日' From Library,LibraryUser,Book,Booking WHERE Book.BookNumber=Library.BookNumber and Library.LibraryNumber=Booking.LibraryNumber and Booking.UserNumber=LibraryUser.UserNumber and LibraryUser.UserNumber='" & userNumber & "'"
            adapter = New SqlClient.SqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            dgvBookingList.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        Connection.Close()
        libraryNumber = ""
    End Sub

    Private Sub SearchByLibraryNumber()
        '蔵書番号で検索表示'
        Connection.Open()
        Try
            'ここからDataGridViewの表示'
            'libraryNumberに一致するLibraryNumberのBookingデータを表示する'
            '表示内容は「蔵書番号,利用者番号,利用者名,予約日,入荷日」'
            command.CommandText = "SELECT Booking.LibraryNumber AS '蔵書番号', Booking.UserNumber AS '利用者番号', UserName AS '利用者名', BookingDate AS '予約日', RegisterDate AS '入荷日' FROM Booking,LibraryUser WHERE Booking.UserNumber = LibraryUser.UserNumber AND LibraryNumber = '" & libraryNumber & "'"
            adapter = New SqlClient.SqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            dgvBookingList.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        Connection.Close()
        userNumber = ""

    End Sub


    Private Sub SearchByDate()
        '期限越え検索'

        Connection.Open()
        Try
            'ここからDataGridViewの表示'
            '表示内容は「蔵書番号,利用者番号,利用者名,予約日,予約入荷日,予約者数,メールアドレス,電話番号」'
            command.CommandText = "SELECT Booking.LibraryNumber AS '蔵書番号', Booking.UserNumber AS '利用者番号', UserName AS '利用者名', BookingDate AS '予約日', RegisterDate AS '入荷日', MailAddress AS 'メールアドレス', TelephoneNumber AS '電話番号' FROM Booking, LibraryUser WHERE  3 > DATEDIFF(DAY, RegisterDate , BookingDate) AND Booking.UserNumber = LibraryUser.UserNumber AND RegisterDate IS NOT NULL"
            adapter = New SqlClient.SqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            dgvBookingList.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        Connection.Close()

        userNumber = ""
        libraryNumber = ""
        txtNumber.Text = ""





    End Sub

    Private Sub BookingInfoOutputer_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles BookingInfoOutputer.PrintPage
        Dim font As New Font("M S 明治", 12, FontStyle.Bold)
        e.Graphics.DrawString(print, font, Brushes.BlueViolet, 10, 10)
    End Sub
End Class