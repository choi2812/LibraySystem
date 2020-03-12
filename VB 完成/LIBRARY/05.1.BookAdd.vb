Public Class BookAdd
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Dim isbn As String = "" 'isbnの一時保存場所'
    Private Sub BookAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        isbn = ""

        txtISBNSearch.Text = ""
        txtLibraryNumber.Text = ""
        txtTitle.Text = ""
        txtTitleKana.Text = ""
        txtSubtitle.Text = ""
        txtSubtitleKana.Text = ""
        txtAuthorName.Text = ""
        txtAuthorNameKana.Text = ""
        txtPublisher.Text = ""
        txtPublisherKana.Text = ""
        txtPrice.Text = ""
        txtOptionSpecification.Text = ""
        txtEtc.Text = ""

        Connection.Open()

        'オプションタイプ初期化'
        cbxOptionName.Items.Clear()
        command.CommandText = "SELECT * FROM OptionType ORDER BY OptionNumber"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
        End Try
        While dr.Read
            cbxOptionName.Items.Add(dr("OptionName"))
        End While
        dr.Close()

        'ジャンル初期化'
        cbxGenre.Items.Clear()
        command.CommandText = "SELECT * FROM Genre ORDER BY GNumber"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
        End Try
        While dr.Read
            cbxGenre.Items.Add(dr("GName"))
        End While
        dr.Close()

        Connection.Close()

        '棚番号初期化'
        cbxShelf.Items.Clear()
        Dim i As Integer = 1
        While i < 100
            cbxShelf.Items.Add(String.Format("{0:00}", i))
            i += 1
        End While
        '作者頭文字初期化'
        cbxCapital.Items.Clear()
        cbxCapital.Items.Add("A")
        cbxCapital.Items.Add("B")
        cbxCapital.Items.Add("C")
        cbxCapital.Items.Add("D")
        cbxCapital.Items.Add("E")
        cbxCapital.Items.Add("F")
        cbxCapital.Items.Add("G")
        cbxCapital.Items.Add("H")
        cbxCapital.Items.Add("I")
        cbxCapital.Items.Add("J")
        cbxCapital.Items.Add("K")
        cbxCapital.Items.Add("L")
        cbxCapital.Items.Add("M")
        cbxCapital.Items.Add("N")
        cbxCapital.Items.Add("O")
        cbxCapital.Items.Add("P")
        cbxCapital.Items.Add("Q")
        cbxCapital.Items.Add("R")
        cbxCapital.Items.Add("S")
        cbxCapital.Items.Add("T")
        cbxCapital.Items.Add("U")
        cbxCapital.Items.Add("V")
        cbxCapital.Items.Add("W")
        cbxCapital.Items.Add("X")
        cbxCapital.Items.Add("Y")
        cbxCapital.Items.Add("Z")

        '出版年初期化'
        cbxPublishYear.Items.Clear()
        Dim now As Integer = Val(Format(Today, "yyyy"))
        Dim maxOld As Integer = 30
        i = 0
        While i < maxOld
            cbxPublishYear.Items.Add(now - i)
            i += 1
        End While
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        'ISBN入力チェック'
        If txtISBNSearch.Text = "" Then
            MessageBox.Show("ISBNが入力されていません、ISBNが無い蔵書を登録する場合は検索不要です", "ユーザーエラー")
            Exit Sub
        End If
        If Not IsNumeric(txtISBNSearch.Text) Then
            MessageBox.Show("ISBNに数字以外が入力されています", "ユーザーエラー")
            Exit Sub
        End If
        If txtISBNSearch.Text.Contains("'") Or txtISBNSearch.Text.Contains("""") Or txtISBNSearch.Text.Contains(" ") Or txtISBNSearch.Text.Contains("　") Or txtISBNSearch.Text.Contains("-") Then
            MessageBox.Show("ISBNに無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If
        If Not (txtISBNSearch.Text.Length = 10 Or txtISBNSearch.Text.Length = 13) Then
            MessageBox.Show("ISBNの桁数が間違っています", "ユーザーエラー")
            Exit Sub
        End If

        'ISBN確保'
        isbn = txtISBNSearch.Text
        txtISBN.Text = isbn
        txtISBNSearch.Text = ""
        Connection.Open()

        'ISBNが登録されているか確認'
        command.CommandText = "SELECT ISBN FROM Book WHERE ISBN = '" & isbn & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If Not dr.Read() Then '新規登録の場合'
            dr.Close()

            MessageBox.Show("新規登録になります、蔵書番号と書籍情報を入力して確認ボタンを押してください。", "メッセ－ジ")

            '入力欄を初期化するか確認する'
            Dim ret As DialogResult
            ret = MessageBox.Show("入力欄を初期化しますか？", "確認", MessageBoxButtons.YesNo)
            If ret = Windows.Forms.DialogResult.Yes Then

                txtLibraryNumber.Text = ""
                txtTitle.Text = ""
                txtTitleKana.Text = ""
                txtSubtitle.Text = ""
                txtSubtitleKana.Text = ""
                txtAuthorName.Text = ""
                txtAuthorNameKana.Text = ""
                txtPublisher.Text = ""
                txtPublisherKana.Text = ""
                txtPrice.Text = ""
                txtOptionSpecification.Text = ""
                txtEtc.Text = ""

                'オプションタイプ初期化'
                'オプションタイプ初期化'
                cbxOptionName.Items.Clear()
                command.CommandText = "SELECT * FROM OptionType ORDER BY OptionNumber"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                End Try
                While dr.Read
                    cbxOptionName.Items.Add(dr("OptionName"))
                End While
                dr.Close()

                'ジャンル初期化'
                cbxGenre.Items.Clear()
                command.CommandText = "SELECT * FROM Genre ORDER BY GNumber"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                End Try
                While dr.Read
                    cbxGenre.Items.Add(dr("GName"))
                End While
                dr.Close()

                '棚番号初期化'
                cbxShelf.Items.Clear()
                Dim i As Integer = 1
                While i < 100
                    cbxShelf.Items.Add(String.Format("{0:00}", i))
                    i += 1
                End While
                '作者頭文字初期化'
                cbxCapital.Items.Clear()
                cbxCapital.Items.Add("A")
                cbxCapital.Items.Add("B")
                cbxCapital.Items.Add("C")
                cbxCapital.Items.Add("D")
                cbxCapital.Items.Add("E")
                cbxCapital.Items.Add("F")
                cbxCapital.Items.Add("G")
                cbxCapital.Items.Add("H")
                cbxCapital.Items.Add("I")
                cbxCapital.Items.Add("J")
                cbxCapital.Items.Add("K")
                cbxCapital.Items.Add("L")
                cbxCapital.Items.Add("M")
                cbxCapital.Items.Add("N")
                cbxCapital.Items.Add("O")
                cbxCapital.Items.Add("P")
                cbxCapital.Items.Add("Q")
                cbxCapital.Items.Add("R")
                cbxCapital.Items.Add("S")
                cbxCapital.Items.Add("T")
                cbxCapital.Items.Add("U")
                cbxCapital.Items.Add("V")
                cbxCapital.Items.Add("W")
                cbxCapital.Items.Add("X")
                cbxCapital.Items.Add("Y")
                cbxCapital.Items.Add("Z")

                '出版年初期化'
                cbxPublishYear.Items.Clear()
                Dim now As Integer = Val(Format(Today, "yyyy"))
                Dim maxOld As Integer = 30
                i = 0
                While i < maxOld
                    cbxPublishYear.Items.Add(now - i)
                    i += 1
                End While

            End If


            '入力欄有効化'
            cbxGenre.Enabled = True
            cbxShelf.Enabled = True
            cbxCapital.Enabled = True
            txtTitle.ReadOnly = False
            txtTitleKana.ReadOnly = False
            txtSubtitle.ReadOnly = False
            txtSubtitleKana.ReadOnly = False
            txtAuthorName.ReadOnly = False
            txtAuthorNameKana.ReadOnly = False
            txtPublisher.ReadOnly = False
            txtPublisherKana.ReadOnly = False
            cbxPublishYear.Enabled = True
            txtPrice.ReadOnly = False
            cbxOptionName.Enabled = True
            txtOptionSpecification.ReadOnly = False
            txtEtc.ReadOnly = False

        Else '追加登録の場合'
            dr.Close()

            MessageBox.Show("追加登録になります、追加する蔵書番号を入力して確認ボタンを押してください。", "メッセ－ジ")

            command.CommandText = "SELECT * FROM Genre,Book,Author,Publishcompany,OptionType WHERE OptionType.OptionNumber=Book.OptionNumber and Book.GNumber=Genre.GNumber and Book.ANumber=Author.ANumber And Book.PNumber = Publishcompany.PNumber And ISBN = '" & isbn & "'"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If dr.Read Then
                txtISBN.Text = isbn
                txtLibraryNumber.Text = ""
                cbxGenre.Text = dr("GName")
                cbxGenre.Enabled = False
                cbxShelf.Text = dr("BookShelfNumber")
                cbxShelf.Enabled = False
                cbxCapital.Text = dr("ANameInitial")
                cbxCapital.Enabled = False
                txtTitle.Text = dr("Title")
                txtTitle.ReadOnly = True
                txtTitleKana.Text = dr("TitleKana")
                txtTitleKana.ReadOnly = True
                If IsDBNull(dr("SubTitle")) Then
                    txtSubtitle.Text = ""
                Else
                    txtSubtitle.Text = dr("SubTitle")
                End If
                txtSubtitle.ReadOnly = True
                If IsDBNull(dr("SubTitleKana")) Then
                    txtSubtitleKana.Text = ""
                Else
                    txtSubtitleKana.Text = dr("SubTitleKana")
                End If
                txtSubtitleKana.ReadOnly = True
                txtAuthorName.Text = dr("AName")
                txtAuthorName.ReadOnly = True
                txtAuthorNameKana.Text = dr("ANameKana")
                txtAuthorNameKana.ReadOnly = True
                cbxPublishYear.Text = dr("PublishedYear")
                cbxPublishYear.Enabled = False
                txtPrice.Text = dr("Price")
                txtPrice.ReadOnly = True
                txtPublisher.Text = dr("PName")
                txtPublisher.ReadOnly = True
                txtPublisherKana.Text = dr("PNameKana")
                txtPublisherKana.ReadOnly = True
                If IsDBNull(dr("OptionSpecification")) Then
                    txtOptionSpecification.Text = ""
                Else
                    txtOptionSpecification.Text = dr("OptionSpecification")
                End If
                txtOptionSpecification.ReadOnly = True
                If IsDBNull(dr("Etc")) Then
                    txtEtc.Text = ""
                Else
                    txtEtc.Text = dr("Etc")
                End If
                txtEtc.ReadOnly = True
                cbxOptionName.Text = dr("OptionName")
                cbxOptionName.Enabled = False
            End If
            dr.Close()

            End If

            Connection.Close()
    End Sub

    Private Sub BtnCheck_Click(sender As System.Object, e As System.EventArgs) Handles BtnCheck.Click

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
        If Not IsNumeric(txtLibraryNumber.Text) Then
            MessageBox.Show("蔵書番号に数字以外が入力されています", "ユーザーエラー")
            Exit Sub
        End If

        '分類入力チェック'
        If cbxGenre.Text = "" Then
            MessageBox.Show("分類が選択されていません", "ユーザーエラー")
            Exit Sub
        End If
        '棚番号入力チェック'
        If cbxShelf.Text = "" Then
            MessageBox.Show("棚番号が選択されていません", "ユーザーエラー")
            Exit Sub
        End If
        '著者頭文字入力チェック'
        If cbxCapital.Text = "" Then
            MessageBox.Show("頭文字が選択されていません", "ユーザーエラー")
            Exit Sub
        End If
        '書名入力チェック'
        If txtTitle.Text = "" Then
            MessageBox.Show("書名が入力されていません", "ユーザーエラー")
            Exit Sub
        End If
        If txtTitle.Text.Contains("'") Or txtTitle.Text.Contains("""") Then
            MessageBox.Show("書名に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '書名かな入力チェック'
        If txtTitleKana.Text = "" Then
            MessageBox.Show("書名かなが入力されていません", "ユーザーエラー")
            Exit Sub
        End If
        If txtTitleKana.Text.Contains("'") Or txtTitleKana.Text.Contains("""") Then
            MessageBox.Show("書名に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '副書名入力チェック'
        If txtSubtitle.Text.Contains("'") Or txtSubtitle.Text.Contains("""") Then
            MessageBox.Show("副書名に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '副書名かな入力チェック'
        If txtSubtitleKana.Text.Contains("'") Or txtSubtitleKana.Text.Contains("""") Then
            MessageBox.Show("副書名かなに無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        If (Not txtSubtitle.Text.Length = 0) AndAlso txtSubtitleKana.Text.Length = 0 Then
            MessageBox.Show("副書名が入力されていません", "ユーザーエラー")
            Exit Sub
        End If
        '著者名入力チェック'
        If txtAuthorName.Text = "" Then
            MessageBox.Show("著者名が入力されていません", "ユーザーエラー")
            Exit Sub
        End If
        If txtAuthorName.Text.Contains("'") Or txtAuthorName.Text.Contains("""") Then
            MessageBox.Show("著者名に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '著者かな入力チェック'
        If txtAuthorNameKana.Text = "" Then
            MessageBox.Show("著者かなが入力されていません", "ユーザーエラー")
            Exit Sub
        End If
        If txtAuthorNameKana.Text.Contains("'") Or txtAuthorNameKana.Text.Contains("""") Then
            MessageBox.Show("著者に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '出版社入力チェック'
        If txtPublisher.Text = "" Then
            MessageBox.Show("出版社が入力されていません", "ユーザーエラー")
            Exit Sub
        End If
        If txtPublisher.Text.Contains("'") Or txtPublisher.Text.Contains("""") Then
            MessageBox.Show("出版社に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '出版社かな入力チェック'
        If txtPublisherKana.Text = "" Then
            MessageBox.Show("出版社かなが入力されていません", "ユーザーエラー")
            Exit Sub
        End If
        If txtPublisherKana.Text.Contains("'") Or txtPublisherKana.Text.Contains("""") Then
            MessageBox.Show("出版社に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '発行年入力チェック'
        If cbxPublishYear.Text = "" Then
            MessageBox.Show("発行年が選択されていません", "ユーザーエラー")
            Exit Sub
        End If
        '価格入力チェック'
        If txtPrice.Text = "" Then
            MessageBox.Show("価格が入力されていません", "ユーザーエラー")
            Exit Sub
        End If
        If Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("価格に数字以外が入力されています", "ユーザーエラー")
            Exit Sub
        End If
        '付属品入力チェック'
        If cbxOptionName.Text = "" Then
            MessageBox.Show("付属品が選択されていません", "ユーザーエラー")
            Exit Sub
        End If
        If cbxOptionName.Text.Contains("'") Or cbxOptionName.Text.Contains("""") Then
            MessageBox.Show("付属品に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '付属品明細'
        If txtOptionSpecification.Text.Contains("'") Or txtOptionSpecification.Text.Contains("""") Then
            MessageBox.Show("付属品明細に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If
        '備考'
        If txtEtc.Text.Contains("'") Or txtEtc.Text.Contains("""") Then
            MessageBox.Show("備考に無効な文字が入力されています、「'」「""」を使用することはできません", "ユーザーエラー")
            Exit Sub
        End If


        Connection.Open()
        '蔵書番号が未登録か確認'
        command.CommandText = "SELECT LibraryNumber FROM Library WHERE LibraryNumber = '" & txtLibraryNumber.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read() Then
            MessageBox.Show("既に登録済みの蔵書番号です", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If
        dr.Close()


        'ISBNが未入力の場合、そのまま登録するか確認する'
        If isbn = "" Then
            Dim ret As DialogResult
            ret = MessageBox.Show("ISBNが入力されていません、ISBNの存在しない蔵書を登録しますか？", "確認", MessageBoxButtons.YesNo)
            If Not ret = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("キャンセルしました。", "確認")
                Connection.Close()
                Exit Sub
            End If
        End If
        dr.Close()
        Connection.Close()

        '蔵書番号と書籍情報をBookInfoReviewに渡す'
        BookInfoReview.Show()
        BookInfoReview.txtLibraryNumber.Text = txtLibraryNumber.Text
        BookInfoReview.txtISBN.Text = isbn
        BookInfoReview.txtGenre.Text = cbxGenre.Text
        BookInfoReview.txtShelf.Text = cbxShelf.Text
        BookInfoReview.txtCapital.Text = cbxCapital.Text
        BookInfoReview.txtTitle.Text = txtTitle.Text
        BookInfoReview.txtTitleKana.Text = txtTitleKana.Text
        BookInfoReview.txtSubtitle.Text = txtSubtitle.Text
        BookInfoReview.txtSubtitleKana.Text = txtSubtitleKana.Text
        BookInfoReview.txtAuthorName.Text = txtAuthorName.Text
        BookInfoReview.txtAuthorNameKana.Text = txtAuthorNameKana.Text
        BookInfoReview.txtPublisher.Text = txtPublisher.Text
        BookInfoReview.txtPublisherKana.Text = txtPublisherKana.Text
        BookInfoReview.txtPublishYear.Text = cbxPublishYear.Text
        BookInfoReview.txtPrice.Text = txtPrice.Text
        BookInfoReview.txtOptionName.Text = cbxOptionName.Text
        BookInfoReview.txtOptionSpecification.Text = txtOptionSpecification.Text
        BookInfoReview.txtEtc.Text = txtEtc.Text
        BookInfoReview.txtOptionName.Text = cbxOptionName.Text
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

