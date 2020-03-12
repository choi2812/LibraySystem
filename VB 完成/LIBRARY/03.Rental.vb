Public Class Rental
    Dim Connection As New SqlClient.SqlConnection(My.Settings.DB_ConnectionString)
    Dim command As SqlClient.SqlCommand = Connection.CreateCommand
    Dim dr As SqlClient.SqlDataReader

    Private Sub RENTALBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.RENTALBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet2)

    End Sub

    Private Sub Rental_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'DataSet2.RENTAL' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Connection.Open()
        MessageBox.Show("番号が間違っています")
        MessageBox.Show("対象者が間違っています")
        Show()


    End Sub

    Private Sub txtToday_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtToday.TextChanged
        txtToday.Text = Format(Now, "D")
    End Sub


    Private Sub BtnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        command.CommandText = "SELECT * FROM LibraryUser WHERE UserNumber =" & "'" & txtNumber.Text & "'"

        Try
            dr = command.ExecuteReader
        Catch ex As InvalidOperationException
            dr.Close()
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        subDataDisq()
        command.CommandText = "SELECT * FROM Borrow WHERE UserNumber =" & "'" & txtNumber.Text & "'"
        Try
            dr = command.ExecuteReader
        Catch ex As InvalidOperationException
            dr.Close()
            dr = command.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub subDataDisq()
        If dr.Read() = False Then
            MessageBox.Show("利用者番号が間違っています。", "メッセ－ジ")
            dr.Close()
            Exit Sub
        End If
        txtNumber.Text = dr("UserNumber")
        txtName.Text = dr("UserName")
        txtKana.Text = dr("Kana")
        txtLibrarynumber.Text = dr("LibraryNumber")


    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtNumber.Text = ""
        txtName.Text = ""
        txtKana.Text = ""

    End Sub

    Private Sub txtBack_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBack.TextChanged
        Dim d As Date

        d = Now

       
        txtBack.Text = DateSerial(Year(d), Month(d) + 2, 0)
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Dim b As Back
        Back.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class