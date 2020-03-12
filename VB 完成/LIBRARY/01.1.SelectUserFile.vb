Public Class SelectUserFile
    Dim ofd As New OpenFileDialog

    Private Sub SelectUserFile_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnFileOpen.Enabled = False
        ofd.FileName = ""
        ofd.InitialDirectory = "c:\"
        ofd.Filter = "CSVファイル(*.csv)|*.csv"
        ofd.Title = "今年度の利用者リストを選択してください"
        ofd.RestoreDirectory = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnFileSelect.Click
        'エクスプローラを開いてファイルを選択させる'
        If ofd.ShowDialog() = DialogResult.OK Then
            txtFileName.Text = ofd.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnFileOpen.Click
        '選択したファイルを「InputUserList」に渡す'
        InputUserList.setFile(Me.ofd)
        InputUserList.Show()
    End Sub

    Private Sub txtFileName_TextChanged(sender As Object, e As EventArgs) Handles txtFileName.TextChanged
        If txtFileName.Text.Contains(".csv") Or txtFileName.Text.Contains(".CSV") Then
            btnFileOpen.Enabled = True
        Else
            btnFileOpen.Enabled = False
        End If
    End Sub
End Class