Public Class Top
  
    Private Sub btnSelectUserFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectUserFile.Click
        '利用者番号登録'
        SelectUserFile.Show()
    End Sub

    Private Sub btnUserRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnUserRegist.Click
        '利用者情報登録/変更'
        UserRegist.Show()
    End Sub

    Private Sub btnBorrow_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrow.Click
        '貸出'
        Borrow.Show()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '返却'
        Back.Show()
    End Sub

    Private Sub btnBookAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnBookAdd.Click
        '蔵書追加'
        BookAdd.Show()
    End Sub

    Private Sub btnBookDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnBookDelete.Click
        '除籍'
        BookDelete.Show()
    End Sub

    Private Sub btnBorrowList_Click(sender As System.Object, e As System.EventArgs) Handles btnBorrowList.Click
        '貸出リスト'
        BorrowList.Show()
    End Sub

    Private Sub btnBookingDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnBookingDelete.Click
        '予約確認と削除'
        BookingDelete.show()
    End Sub

    Private Sub btnUserPasswordReset_Click(sender As System.Object, e As System.EventArgs) Handles btnUserPasswordReset.Click
        '利用者パスワードを初期化する'
        UserPasswordReset.Show()
    End Sub

   

    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    '    PrintDocument1.Print()
    'End Sub

    'Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim i As New Font("M S 明治", 64, FontStyle.Bold)
    '    e.Graphics.DrawString("sTRING", i, Brushes.BlueViolet, 10, 10)
    'End Sub

    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '    PrintPreviewDialog1.ShowDialog()
    'End Sub

    Private Sub Top_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class