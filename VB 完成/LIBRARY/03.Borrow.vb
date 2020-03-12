Public Class Borrow
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader
    Dim adapter As SqlClient.SqlDataAdapter

    Private userNumber As String '利用者番号'
    Private libraryNumber As String '蔵書番号(バーコード)'
    Private todayDate As Date = Today '今日の日付'
    Private scheduleReturnDate As Date = DateAdd("d", 7, Today) '返却予定日'

    Private Sub Borrow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load '初期動作'
        txtDate.Text = Format(Today, "yyyy/MM/dd")
        txtBackDate.Text = Format(scheduleReturnDate, "yyyy/MM/dd")
        userNumber = ""
        libraryNumber = ""
        txtUserNumberSearch.Text = ""
        txtUserNumber.Text = ""
        txtLibraryNumber.Text = ""
        txtUserName.Text = ""
        txtUserNameKana.Text = ""
        txtOptionName.Text = ""
        chkOptionBorrow.Checked = False
        chkOptionBorrow.Enabled = False

        btnClear.Enabled = False
        btnBorrow.Enabled = False

        '貸し出しリストの初期化を書く'
        dgvBorrowList.DataSource = Nothing
    End Sub

    Private Sub BtnUserSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnUserSearch.Click
        '検索ボタンクリック

        '入力チェック'
        
        If txtUserNumberSearch.Text.Contains("'") Or txtUserNumberSearch.Text.Contains("""") Or txtUserNumberSearch.Text.Contains("　") Or txtUserNumberSearch.Text.Contains("-") Then
            MessageBox.Show("利用者番号に無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If
        If Not txtUserNumberSearch.Text.Length = 8 Then
            MessageBox.Show("利用者番号の桁数が間違っています", "ユーザーエラー")
            Exit Sub
        End If


        Connection.Open()
        '番号自体の登録がなければ「利用者番号が間違っています」とエラーメッセージをを表示する'
        '番号自体の登録はあるが連絡先の登録がされていない場合は「先に利用者登録を行ってください」とエラーメッセージを表示する'
        command.CommandText = "SELECT UserName, Kana, TelephoneNumber, MailAddress FROM LibraryUser WHERE UserNumber= '" & txtUserNumberSearch.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If Not dr.Read() Then '利用者番号がDBに登録されていない場合'
            MessageBox.Show("利用者番号に一致しません", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        Else
            If IsDBNull(dr("TelephoneNumber")) Or IsDBNull(dr("MailAddress")) Then '利用者の連絡先情報が登録されていない場合'
                MessageBox.Show("先に連絡先情報の登録を行ってください", "システムメッセ－ジ")
                Connection.Close()
                Exit Sub
            End If
        End If

        btnClear.Enabled = True

        '利用者情報セット'
        userNumber = txtUserNumberSearch.Text
        txtUserNumber.Text = txtUserNumberSearch.Text
        txtUserNumberSearch.Text = ""
        txtUserName.Text = dr("UserName")
        txtUserNameKana.Text = dr("Kana")
        dr.Close()

        '予約入荷データがあったら予約入荷情報を表示する'
        command.CommandText = "SELECT Title, Booking.LibraryNumber FROM Booking, Library, Book WHERE Booking.LibraryNumber IN(Library.LibraryNumber) AND Library.BookNumber = Book.BookNumber AND RegisterDate IS NOT NULL AND Booking.UserNumber='" & userNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read() Then '入荷済みの予約が存在する場合'
            Dim BookingData As String = ""
            Do
                BookingData = BookingData & "書名：" & dr("Title") & " 蔵書番号：" & dr("LibraryNumber") & vbCrLf
            Loop While dr.Read()
            MessageBox.Show("予約した本が入荷しています" & vbCrLf & BookingData, "システムメッセ－ジ")
        End If
        dr.Close()

        Connection.Close()
        dgvBorrowListUpdate()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        '利用者情報と書籍情報と貸し出しリストを初期化する'
        userNumber = ""
        libraryNumber = ""
        txtUserNumberSearch.Text = ""
        txtUserNumber.Text = ""
        txtLibraryNumber.Text = ""
        txtUserName.Text = ""
        txtUserNameKana.Text = ""
        txtOptionName.Text = ""
        chkOptionBorrow.Checked = False
        chkOptionBorrow.Enabled = False

        btnClear.Enabled = False
        btnBorrow.Enabled = False

        '貸し出しリストの初期化を書く'
        dgvBorrowList.DataSource = Nothing
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Back.Show()
        Me.Close()
        Connection.Close()
    End Sub

    Private Sub btnTop_Click(sender As System.Object, e As System.EventArgs) Handles btnTop.Click
        Me.Close()
    End Sub

    Private Sub btnLibrarySearch_Click(sender As System.Object, e As System.EventArgs) Handles btnLibrarySearch.Click
        '蔵書番号検索ボタンが押されたとき'

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

        Dim tmpTitle As String
        Dim tmpOptionName As String
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
        tmpTitle = dr("Title")
        tmpOptionName = dr("OptionName")
        dr.Close()

        btnClear.Enabled = True
        btnBorrow.Enabled = True

        '蔵書情報をセット'
        libraryNumber = txtLibraryNumber.Text
        txtBookName.Text = tmpTitle
        txtOptionName.Text = tmpOptionName

        If txtOptionName.Text = "無し" Then
            chkOptionBorrow.Enabled = False
        Else
            chkOptionBorrow.Enabled = True
            MessageBox.Show("付属品があります", "システムメッセージ")
        End If

        txtLibraryNumber.Text = ""

        Connection.Close()
    End Sub

    Private Sub btnRental_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrow.Click '貸し出しボタンクリック'
        Connection.Open()
        '蔵書番号は「libraryNumber」利用者番号は「userNumber」を使う'

        If userNumber = "" Then
            MessageBox.Show("利用者番号を検索して、貸出対象者を確定してください", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If
        If libraryNumber = "" Then
            MessageBox.Show("蔵書番号を検索して、貸し出す蔵書を確定してください", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If


        'Borrowに返却されていない、同じlibraryNumberが存在するかの判定'
        command.CommandText = "SELECT LibraryNumber FROM Borrow WHERE ReturnDate IS NULL AND LibraryNumber = '" & libraryNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read Then
            MessageBox.Show("すでに貸し出し登録されている蔵書番号です", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If
        dr.Close()

        

        '予約が入っている本かの判定'
        command.CommandText = "SELECT * FROM Booking WHERE LibraryNumber = '" & libraryNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read Then '予約が入っている場合'

            '予約者本人かどうかの判定'
            dr.Close()
            command.CommandText = "SELECT * FROM Booking WHERE UserNumber = '" & userNumber & "' AND LibraryNumber = '" & libraryNumber & "'"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If Not dr.Read Then '予約者本人でなかった場合'
                MessageBox.Show("予約者本人ではありません", "ユーザーエラー")
                Connection.Close()
                Exit Sub
            End If

        End If
        dr.Close()

        '四冊以上貸し出し登録されているかどうかの判定'
        command.CommandText = "SELECT * FROM Borrow WHERE ReturnDate IS NULL AND UserNumber = '" & userNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        Dim borrowCount As Integer = 0
        While dr.Read
            borrowCount += 1
        End While
        If 4 <= borrowCount Then
            MessageBox.Show("貸出可能数を超えています", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If
        dr.Close()



        '通常貸し出し、Borrowテーブルに貸し出しデータを挿入する'
        Dim optionBorrowFlag As Integer = 0
        If chkOptionBorrow.Checked Then '付属品貸出しのチェックが入っていたら付属品貸し出しフラグを1に変更する'
            optionBorrowFlag = 1
        End If
        command.CommandText = "INSERT INTO Borrow(UserNumber,LibraryNumber,BorrowDate,ScheduleReturnDate,OptionBorrowFlag) VALUES('" & userNumber & "','" & libraryNumber & "','" & Format(Today, "yyyy-MM-dd") & "','" & Format(scheduleReturnDate, "yyyy-MM-dd") & "'," & optionBorrowFlag & ")"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        dr.Close()

        'LibraryテーブルのBorrowFlagを0から1に変える'
        command.CommandText = "UPDATE Library SET BorrowFlag = 1 WHERE LibraryNumber ='" & libraryNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        dr.Close()

        '予約テーブルから該当する予約データを削除する'
        command.CommandText = "DELETE FROM Booking WHERE LibraryNumber = '" & libraryNumber & "' AND UserNumber='" & userNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        dr.Close()

        txtBookName.Text = ""
        txtOptionName.Text = ""
        txtLibraryNumber.Text = ""
        libraryNumber = ""
        chkOptionBorrow.Checked = False
        chkOptionBorrow.Enabled = False

        btnBorrow.Enabled = False

        Connection.Close()
        dgvBorrowListUpdate()
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

End Class