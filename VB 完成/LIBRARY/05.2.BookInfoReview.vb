Public Class BookInfoReview
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Dim GNumber As Integer = -1
    Dim OptionNumber As Integer = -1
    Dim ANumber As Integer = -1
    Dim PNumber As Integer = -1

    Private Sub BookInfoReview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub BtnAdd_Click(sender As System.Object, e As System.EventArgs) Handles BtnAdd.Click
        '登録ボタンクリック'

        Connection.Open()

        If txtISBN.Text = "" Then 'ISBNが無い蔵書の場合'
            'GNumber取得'
            command.CommandText = "SELECT GNumber FROM Genre WHERE GName ='" & txtGenre.Text & "'"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If dr.Read Then
                GNumber = dr("GNumber")
            End If
            dr.Close()


            'OptionNumber取得'
            command.CommandText = "SELECT OptionNumber FROM OptionType WHERE OptionName ='" & txtOptionName.Text & "'"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If dr.Read Then
                OptionNumber = dr("OptionNumber")
            End If
            dr.Close()


            'ANumber取得'
            command.CommandText = "SELECT ANumber FROM Author WHERE AName='" & txtAuthorName.Text & "' AND ANameKana = '" & txtAuthorNameKana.Text & "'"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If dr.Read Then
                ANumber = dr("ANumber")
            End If
            dr.Close()


            'PNumber取得'
            command.CommandText = "SELECT PNumber FROM Publishcompany WHERE PName='" & txtPublisher.Text & "' AND PNameKana='" & txtPublisherKana.Text & "'"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If dr.Read Then
                PNumber = dr("PNumber")
            End If
            dr.Close()

            'MessageBox.Show("ONumber" & OptionNumber & vbCrLf & "ANumber" & ANumber & vbCrLf & "GNumber" & GNumber & vbCrLf & "PNumber" & PNumber)'
            '登録済みでなかった場合、それぞれの要素をDBに新規追加してそのPKを変数に代入する'
            If OptionNumber = -1 Then
                command.CommandText = "INSERT INTO OptionType(OptionName) VALUES('" & txtOptionName.Text & "')"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                dr.Close()

                command.CommandText = "SELECT MAX(OptionNumber) AS 'MaxOptionNumber' FROM OptionType"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read Then
                    OptionNumber = dr("MaxOptionNumber")
                End If
                dr.Close()
            End If
            If ANumber = -1 Then
                command.CommandText = "INSERT INTO Author(AName,ANameKana,ANameInitial) VALUES('" & txtAuthorName.Text & "','" & txtAuthorNameKana.Text & "','" & txtCapital.Text & "')"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                dr.Close()

                command.CommandText = "SELECT MAX(ANumber) AS 'MaxANumber' FROM Author"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read Then
                    ANumber = dr("MaxANumber")
                End If
                dr.Close()
            End If
            If PNumber = -1 Then
                command.CommandText = "INSERT INTO Publishcompany(PName,PNameKana) VALUES('" & txtPublisher.Text & "','" & txtPublisherKana.Text & "')"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                dr.Close()

                command.CommandText = "SELECT MAX(PNumber) AS 'MaxPNumber' FROM Publishcompany"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read Then
                    PNumber = dr("MaxPNumber")
                End If
                dr.Close()
            End If
            If GNumber = -1 Then
                command.CommandText = "INSERT INTO Genre(GName) VALUES('" & txtGenre.Text & "')"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                dr.Close()

                command.CommandText = "SELECT MAX(GNumber) AS 'MaxGNumber' FROM Genre"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read Then
                    GNumber = dr("GNumber")
                End If
                dr.Close()
            End If
            dr.Close()

            'MessageBox.Show("ONumber" & OptionNumber & vbCrLf & "ANumber" & ANumber & vbCrLf & "GNumber" & GNumber & vbCrLf & "PNumber" & PNumber)

            'Bookに書籍情報を追加'
            Dim sql As String = ""
            sql = "INSERT INTO Book(Title,TitleKana,SubTitle,SubTitleKana,ANumber,PNumber,GNumber,BookShelfNumber,PublishedYear,OptionNumber,Price,Etc,OptionSpecification) VALUES("
            sql = sql & "'" & txtTitle.Text & "','" & txtTitleKana.Text & "','" & txtSubtitle.Text & "','" & txtSubtitleKana.Text & "',"
            sql = sql & Val(ANumber) & ","
            sql = sql & Val(PNumber) & ","
            sql = sql & Val(GNumber) & ","
            sql = sql & "'" & txtShelf.Text & "',"
            sql = sql & "'" & txtPublishYear.Text & "',"
            sql = sql & Val(OptionNumber) & ","
            sql = sql & "'" & txtPrice.Text & "',"
            sql = sql & "'" & txtEtc.Text & "',"
            sql = sql & "'" & txtOptionSpecification.Text & "')"

            command.CommandText = sql
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            dr.Close()

        Else 'ISBNがある蔵書の場合'

            '新規か追加かの判定'
            command.CommandText = "SELECT ISBN FROM Book WHERE ISBN ='" & txtISBN.Text & "' AND NOT ISBN = ''"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            If Not dr.Read Then '新規登録、Bookに書籍情報を挿入する'
                dr.Close()

                'GNumber取得'
                command.CommandText = "SELECT GNumber FROM Genre WHERE GName ='" & txtGenre.Text & "'"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read Then
                    GNumber = dr("GNumber")
                End If
                dr.Close()


                'OptionNumber取得'
                command.CommandText = "SELECT OptionNumber FROM OptionType WHERE OptionName ='" & txtOptionName.Text & "'"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read Then
                    OptionNumber = dr("OptionNumber")
                End If
                dr.Close()


                'ANumber取得'
                command.CommandText = "SELECT ANumber FROM Author WHERE AName='" & txtAuthorName.Text & "' AND ANameKana = '" & txtAuthorNameKana.Text & "'"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read Then
                    ANumber = dr("ANumber")
                End If
                dr.Close()


                'PNumber取得'
                command.CommandText = "SELECT PNumber FROM Publishcompany WHERE PName='" & txtPublisher.Text & "' AND PNameKana='" & txtPublisherKana.Text & "'"
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                If dr.Read Then
                    PNumber = dr("PNumber")
                End If
                dr.Close()

                'MessageBox.Show("ONumber" & OptionNumber & vbCrLf & "ANumber" & ANumber & vbCrLf & "GNumber" & GNumber & vbCrLf & "PNumber" & PNumber)'


                '登録済みでなかった場合、それぞれの要素をDBに新規追加してそのPKを変数に代入する'
                If OptionNumber = -1 Then
                    command.CommandText = "INSERT INTO OptionType(OptionName) VALUES('" & txtOptionName.Text & "')"
                    Try
                        dr = command.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    dr.Close()

                    command.CommandText = "SELECT MAX(OptionNumber) AS 'MaxOptionNumber' FROM OptionType"
                    Try
                        dr = command.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read Then
                        OptionNumber = dr("MaxOptionNumber")
                    End If
                    dr.Close()
                End If
                If ANumber = -1 Then
                    command.CommandText = "INSERT INTO Author(AName,ANameKana,ANameInitial) VALUES('" & txtAuthorName.Text & "','" & txtAuthorNameKana.Text & "', '" & txtCapital.Text & "')"
                    Try
                        dr = command.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    dr.Close()

                    command.CommandText = "SELECT MAX(ANumber) AS 'MaxANumber' FROM Author"
                    Try
                        dr = command.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read Then
                        ANumber = dr("MaxANumber")
                    End If
                    dr.Close()
                End If
                If PNumber = -1 Then
                    command.CommandText = "INSERT INTO Publishcompany(PName,PNameKana) VALUES('" & txtPublisher.Text & "','" & txtPublisherKana.Text & "')"
                    Try
                        dr = command.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    dr.Close()

                    command.CommandText = "SELECT MAX(PNumber) AS 'MaxPNumber' FROM Publishcompany"
                    Try
                        dr = command.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read Then
                        PNumber = dr("MaxPNumber")
                    End If
                    dr.Close()
                End If
                If GNumber = -1 Then
                    command.CommandText = "INSERT INTO Genre(GName) VALUES('" & txtGenre.Text & "')"
                    Try
                        dr = command.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    dr.Close()

                    command.CommandText = "SELECT MAX(GNumber) AS 'MaxGNumber' FROM Genre"
                    Try
                        dr = command.ExecuteReader
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Connection.Close()
                        Exit Sub
                    End Try
                    If dr.Read Then
                        GNumber = dr("GNumber")
                    End If
                    dr.Close()
                End If
                dr.Close()

                'MessageBox.Show("ONumber" & OptionNumber & vbCrLf & "ANumber" & ANumber & vbCrLf & "GNumber" & GNumber & vbCrLf & "PNumber" & PNumber)

                'Bookに書籍情報を追加'
                Dim sql As String = ""
                sql = "INSERT INTO Book(Title,TitleKana,SubTitle,SubTitleKana,ANumber,PNumber,GNumber,BookShelfNumber,PublishedYear,OptionNumber,Price,Etc,ISBN,OptionSpecification) VALUES("
                sql = sql & "'" & txtTitle.Text & "','" & txtTitleKana.Text & "','" & txtSubtitle.Text & "','" & txtSubtitleKana.Text & "',"
                sql = sql & Val(ANumber) & ","
                sql = sql & Val(PNumber) & ","
                sql = sql & Val(GNumber) & ","
                sql = sql & "'" & txtShelf.Text & "',"
                sql = sql & "'" & txtPublishYear.Text & "',"
                sql = sql & Val(OptionNumber) & ","
                sql = sql & "'" & txtPrice.Text & "',"
                sql = sql & "'" & txtEtc.Text & "',"
                sql = sql & "'" & txtISBN.Text & "',"
                sql = sql & "'" & txtOptionSpecification.Text & "')"

                command.CommandText = sql
                Try
                    dr = command.ExecuteReader
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Connection.Close()
                    Exit Sub
                End Try
                dr.Close()


            End If
            dr.Close()
        End If

        If txtISBN.Text = "" Then 'ISBNが無い蔵書の追加'
            command.CommandText = "INSERT INTO Library(LibraryNumber, BookNumber, BorrowFlag, AddLibraryDate) VALUES('" & txtLibraryNumber.Text & "',(SELECT MAX(BookNumber) FROM Book),0,GETDATE())"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            dr.Close()
        Else 'ISBNがある蔵書の追加'
            command.CommandText = "INSERT INTO Library(LibraryNumber, BookNumber, BorrowFlag, AddLibraryDate) VALUES('" & txtLibraryNumber.Text & "',(SELECT BookNumber FROM Book WHERE ISBN = '" & txtISBN.Text & "'),0,GETDATE())"
            Try
                dr = command.ExecuteReader
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Connection.Close()
                Exit Sub
            End Try
            dr.Close()
        End If
        dr.Close()
        Connection.Close()

        MessageBox.Show("蔵書の追加が完了しました", "システムメッセージ")

        Me.Close()
        BookAdd.Close()
    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class