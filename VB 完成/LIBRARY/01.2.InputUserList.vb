Imports System.Text


Public Class InputUserList

    Private ofd As OpenFileDialog

    Private Sub InputUserList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '「SelectUserFile」から渡された「利用者リスト」の中身のデータを表示する'
        Dim parser As FileIO.TextFieldParser = New FileIO.TextFieldParser(ofd.FileName, Encoding.GetEncoding("UTF-8"))
        parser.SetDelimiters(",")

        dgvUserList.Rows.Clear()
        While (Not parser.EndOfData)
            Dim row As String() = parser.ReadFields()
            dgvUserList.Rows.Add(row)
        End While

    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        '「SelectUserFile」に戻る'
        Me.Close()
    End Sub

    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click

        '今年度の利用者リストをString型の配列に変換'
        Dim parser As FileIO.TextFieldParser = New FileIO.TextFieldParser(ofd.FileName, Encoding.GetEncoding("UTF-8"))
        parser.SetDelimiters(",")

        '利用者リストを作成する(userDataList As New List(Of String()))'
        Dim userDataList As New List(Of String())
        While Not parser.EndOfData
            Dim userData As String() = parser.ReadFields()
            userDataList.Add(userData)
        End While
        '利用者リスト作成完了'


        '利用者リストから利用者番号の羅列を作る('a','b','c','d')'
        Dim sql As String = ""
        For Each userData As String() In userDataList
            sql = sql & "'" & userData(0) & "',"
        Next
        sql = sql.TrimEnd(CType(",", Char))
        'ここまでテスト済み'
        'ここまでテスト済み'
        'ここまでテスト済み'
        'ここまでテスト済み'
        'ここまでテスト済み'
        'ここまでテスト済み'


        'データベースコネクションを作成'
        Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
        Dim command As SqlClient.SqlCommand = Connection.CreateCommand
        Dim dr As SqlClient.SqlDataReader
        Connection.Open() 'DB接続'



        'LibraryUserに存在しない利用者番号のリストを作る'


        '在校生でなおかつLibrayUserに登録のある利用者番号のリストを作る(userNumberListRegisted As List(Of String))'
        '別名：データ変更しちゃいけないリスト'
        Dim userNumberListRegisted As New List(Of String)
        command.CommandText = "SELECT UserNumber,UserName,Kana FROM LibraryUser WHERE UserNumber IN(" & sql & ")"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        While dr.Read
            userNumberListRegisted.Add(dr("UserNumber"))
        End While
        dr.Close()
        '在校生でなおかつLibrayUserに登録のある利用者番号のリスト作成完了'





        '今年度の利用者リストに一致しない利用者番号のデータをBookingから削除する'
        command.CommandText = "DELETE FROM Booking WHERE UserNumber NOT IN(" & sql & ")"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        dr.Close()
        '利用者リストに存在しない利用者番号のデータをBorrowから削除する'
        command.CommandText = "DELETE FROM Borrow WHERE UserNumber NOT IN(" & sql & ")"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        dr.Close()
        '利用者リストに存在しない利用者番号のデータをLibraryUserから削除する'
        command.CommandText = "DELETE FROM LibraryUser WHERE UserNumber NOT IN(" & sql & ")"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        dr.Close()

        '在校生でなおかつLibrayUserに登録の無い利用者番号を挿入する'
        sql = ""
        For Each userNumber As String In userNumberListRegisted
            sql = sql & "'" & userNumber & "',"
        Next
        sql = sql.TrimEnd(CType(",", Char))


        '今年度の利用者リストから未登録の利用者情報を抽出して登録する'
        'userDataList'
        Dim userDataListUnRegisted As New List(Of String())
        For Each userData As String() In userDataList
            If Not userNumberListRegisted.Contains(userData(0)) Then
                userDataListUnRegisted.Add(userData)
            End If
        Next

        dr.Close()
        For Each userData As String() In userDataListUnRegisted
            command.CommandText = "INSERT INTO LibraryUser(UserNumber,UserName,Kana) VALUES('" & userData(0) & "','" & userData(1) & "','" & userData(2) & "')"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            dr.Close()
        Next
        



        '蔵書の貸し出しフラグを更新する'
        dr.Close()
        command.CommandText = "UPDATE Library SET BorrowFlag = 0 WHERE LibraryNumber NOT IN(SELECT LibraryNumber FROM Borrow) AND LibraryNumber NOT IN(SELECT LibraryNumber FROM Borrow)"
        Try
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Connection.Close()
            Exit Sub
        End Try
        dr.Close()
        Connection.Close() 'DB切断'

        '利用者リストの登録完了'
        MessageBox.Show("利用者リストの更新が完了しました", "システムメッセージ")
        Me.Close()
        SelectUserFile.Close()


    End Sub

    Public Sub setFile(ofd As OpenFileDialog)
        Me.ofd = ofd
    End Sub

End Class