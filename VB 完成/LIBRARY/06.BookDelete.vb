Public Class BookDelete

    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Dim libraryNumber As String = "" '蔵書番号保管場所'

    Private Sub BookDelete_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtSearch.Text = ""
        txtTitle.Text = ""
        txtPublishedYear.Text = ""
        txtPrice.Text = ""
        txtOptionName.Text = ""
        txtOptionSpecification.Text = ""
        cbxReason.Enabled = False
        btnDelete.Enabled = False
        libraryNumber = ""
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

        '蔵書番号入力チェック'
        If txtSearch.Text = "" Then
            MessageBox.Show("蔵書番号が未入力です", "ユーザーエラー")
            Exit Sub
        End If

        If txtSearch.Text.Contains("'") Or txtSearch.Text.Contains("""") Or txtSearch.Text.Contains("　") Or txtSearch.Text.Contains("-") Then
            MessageBox.Show("蔵書番号に無効な文字が入力されています、「-」「'」「""」「空白」を入力することはできません", "ユーザーエラー")
            Exit Sub
        End If
        If Not txtSearch.Text.Length = 9 Then
            MessageBox.Show("蔵書番号の桁数が間違っています", "ユーザーエラー")
            Exit Sub
        End If

        Connection.Open()

        command.CommandText = "SELECT Title, PublishedYear, Price, OptionName, OptionSpecification from Library as L, Book as B, OptionType as OT where(L.BookNumber = B.BookNumber) and OT.OptionNumber=B.OptionNumber and LibraryNumber=" & "'" & txtSearch.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If Not dr.Read() Then
            MessageBox.Show("蔵書番号が間違っています", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If

        libraryNumber = txtSearch.Text

        txtTitle.Text = dr("Title")
        txtPublishedYear.Text = dr("PublishedYear")
        txtPrice.Text = dr("Price")
        txtOptionName.Text = dr("OptionName")
        If (IsDBNull(dr("OptionSpecification"))) Then
            txtOptionSpecification.Text = "なし"
        Else
            txtOptionSpecification.Text = dr("OptionSpecification")
        End If
        txtSearch.Text = ""

        '入力欄と除籍ボタンを有効化'
        cbxReason.Enabled = True
        btnDelete.Enabled = True

        Connection.Close()

    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Connection.Open()

        '貸出が入っているか'
        command.CommandText = "SELECT * FROM Borrow AS B WHERE B.ReturnDate IS NULL AND B.LibraryNumber = '" & libraryNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read() Then
            MessageBox.Show("返却されていない蔵書です。", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If
        dr.Close()

        '予約が入っているか'
        command.CommandText = "SELECT * FROM Booking AS B WHERE B.LibraryNumber = '" & libraryNumber & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        If dr.Read() Then
            MessageBox.Show("予約が入っている蔵書です。", "ユーザーエラー")
            Connection.Close()
            Exit Sub
        End If
        dr.Close()

        '余裕があればここに「除籍テーブルに除籍履歴を書き込む処理」を書く'
        ''
        ''
        ''
        ''
        ''
        ''
        ''
        '除籍処理'
        command.CommandText = "DELETE FROM Borrow WHERE LibraryNumber= '" & libraryNumber & "'"
        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try


        command.CommandText = "DELETE FROM Library WHERE LibraryNumber= '" & libraryNumber & "'"
        Try
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try

        '除籍成功'
        MessageBox.Show("除籍成功", "メッセージ")
        Connection.Close()


        '画面初期化'
        txtSearch.Text = ""
        txtTitle.Text = ""
        txtPublishedYear.Text = ""
        txtPrice.Text = ""
        txtOptionName.Text = ""
        txtOptionSpecification.Text = ""
        cbxReason.Enabled = False
        btnDelete.Enabled = False
        libraryNumber = ""

    End Sub
End Class