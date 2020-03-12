<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookInfoReview
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtShelf = New System.Windows.Forms.TextBox()
        Me.txtCapital = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLibraryNumber = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEtc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSubtitleKana = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubtitle = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTitleKana = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOptionSpecification = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.txtPublisherKana = New System.Windows.Forms.TextBox()
        Me.txtAuthorNameKana = New System.Windows.Forms.TextBox()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.txtPublishYear = New System.Windows.Forms.TextBox()
        Me.txtOptionName = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 19)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "蔵書情報確認画面"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(472, 558)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "確定"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(34, 558)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "戻る"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "著者名"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(280, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 12)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "著者かな"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 445)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 12)
        Me.Label18.TabIndex = 75
        Me.Label18.Text = "付属品"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGenre)
        Me.GroupBox1.Controls.Add(Me.txtShelf)
        Me.GroupBox1.Controls.Add(Me.txtCapital)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 47)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "請求記号"
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(50, 18)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.ReadOnly = True
        Me.txtGenre.Size = New System.Drawing.Size(100, 19)
        Me.txtGenre.TabIndex = 51
        '
        'txtShelf
        '
        Me.txtShelf.Location = New System.Drawing.Point(179, 18)
        Me.txtShelf.Name = "txtShelf"
        Me.txtShelf.ReadOnly = True
        Me.txtShelf.Size = New System.Drawing.Size(63, 19)
        Me.txtShelf.TabIndex = 50
        '
        'txtCapital
        '
        Me.txtCapital.Location = New System.Drawing.Point(411, 19)
        Me.txtCapital.Name = "txtCapital"
        Me.txtCapital.ReadOnly = True
        Me.txtCapital.Size = New System.Drawing.Size(50, 19)
        Me.txtCapital.TabIndex = 49
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(248, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(157, 12)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "作者頭文字(半角英字大文字)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(156, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 12)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "棚"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "分類"
        '
        'txtLibraryNumber
        '
        Me.txtLibraryNumber.Location = New System.Drawing.Point(79, 127)
        Me.txtLibraryNumber.Name = "txtLibraryNumber"
        Me.txtLibraryNumber.ReadOnly = True
        Me.txtLibraryNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtLibraryNumber.TabIndex = 72
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "蔵書番号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 520)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "備考"
        '
        'txtEtc
        '
        Me.txtEtc.Location = New System.Drawing.Point(74, 517)
        Me.txtEtc.Name = "txtEtc"
        Me.txtEtc.ReadOnly = True
        Me.txtEtc.Size = New System.Drawing.Size(473, 19)
        Me.txtEtc.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "価格"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(268, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 12)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "副書名かな"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(268, 337)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 12)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "出版社かな"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 336)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "出版社"
        '
        'txtSubtitleKana
        '
        Me.txtSubtitleKana.Location = New System.Drawing.Point(335, 249)
        Me.txtSubtitleKana.Name = "txtSubtitleKana"
        Me.txtSubtitleKana.ReadOnly = True
        Me.txtSubtitleKana.Size = New System.Drawing.Size(171, 19)
        Me.txtSubtitleKana.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 375)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "発行年"
        '
        'txtSubtitle
        '
        Me.txtSubtitle.Location = New System.Drawing.Point(78, 249)
        Me.txtSubtitle.Name = "txtSubtitle"
        Me.txtSubtitle.ReadOnly = True
        Me.txtSubtitle.Size = New System.Drawing.Size(171, 19)
        Me.txtSubtitle.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 252)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 12)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "副書名"
        '
        'txtTitleKana
        '
        Me.txtTitleKana.Location = New System.Drawing.Point(335, 208)
        Me.txtTitleKana.Name = "txtTitleKana"
        Me.txtTitleKana.ReadOnly = True
        Me.txtTitleKana.Size = New System.Drawing.Size(171, 19)
        Me.txtTitleKana.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(280, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 12)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "書名かな"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(77, 208)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(171, 19)
        Me.txtTitle.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "書名"
        '
        'txtOptionSpecification
        '
        Me.txtOptionSpecification.Location = New System.Drawing.Point(77, 478)
        Me.txtOptionSpecification.Name = "txtOptionSpecification"
        Me.txtOptionSpecification.ReadOnly = True
        Me.txtOptionSpecification.Size = New System.Drawing.Size(470, 19)
        Me.txtOptionSpecification.TabIndex = 54
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(77, 407)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(64, 19)
        Me.txtPrice.TabIndex = 53
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 481)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "付属品明細"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 12)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "ISBN"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(79, 92)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.ReadOnly = True
        Me.txtISBN.Size = New System.Drawing.Size(100, 19)
        Me.txtISBN.TabIndex = 37
        '
        'txtPublisherKana
        '
        Me.txtPublisherKana.Location = New System.Drawing.Point(335, 332)
        Me.txtPublisherKana.Name = "txtPublisherKana"
        Me.txtPublisherKana.ReadOnly = True
        Me.txtPublisherKana.Size = New System.Drawing.Size(100, 19)
        Me.txtPublisherKana.TabIndex = 82
        '
        'txtAuthorNameKana
        '
        Me.txtAuthorNameKana.Location = New System.Drawing.Point(335, 292)
        Me.txtAuthorNameKana.Name = "txtAuthorNameKana"
        Me.txtAuthorNameKana.ReadOnly = True
        Me.txtAuthorNameKana.Size = New System.Drawing.Size(100, 19)
        Me.txtAuthorNameKana.TabIndex = 83
        '
        'txtAuthorName
        '
        Me.txtAuthorName.Location = New System.Drawing.Point(74, 292)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.ReadOnly = True
        Me.txtAuthorName.Size = New System.Drawing.Size(174, 19)
        Me.txtAuthorName.TabIndex = 84
        '
        'txtPublishYear
        '
        Me.txtPublishYear.Location = New System.Drawing.Point(77, 372)
        Me.txtPublishYear.Name = "txtPublishYear"
        Me.txtPublishYear.ReadOnly = True
        Me.txtPublishYear.Size = New System.Drawing.Size(100, 19)
        Me.txtPublishYear.TabIndex = 85
        '
        'txtOptionName
        '
        Me.txtOptionName.Location = New System.Drawing.Point(77, 445)
        Me.txtOptionName.Name = "txtOptionName"
        Me.txtOptionName.ReadOnly = True
        Me.txtOptionName.Size = New System.Drawing.Size(100, 19)
        Me.txtOptionName.TabIndex = 86
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(74, 331)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.ReadOnly = True
        Me.txtPublisher.Size = New System.Drawing.Size(174, 19)
        Me.txtPublisher.TabIndex = 87
        '
        'BookInfoReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 593)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.txtOptionName)
        Me.Controls.Add(Me.txtPublishYear)
        Me.Controls.Add(Me.txtAuthorName)
        Me.Controls.Add(Me.txtAuthorNameKana)
        Me.Controls.Add(Me.txtPublisherKana)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtLibraryNumber)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEtc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSubtitleKana)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSubtitle)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTitleKana)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtOptionSpecification)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BookInfoReview"
        Me.Text = "蔵書追加"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLibraryNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEtc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSubtitleKana As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSubtitle As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTitleKana As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtOptionSpecification As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents txtPublisherKana As System.Windows.Forms.TextBox
    Friend WithEvents txtGenre As System.Windows.Forms.TextBox
    Friend WithEvents txtShelf As System.Windows.Forms.TextBox
    Friend WithEvents txtCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorNameKana As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorName As System.Windows.Forms.TextBox
    Friend WithEvents txtPublishYear As System.Windows.Forms.TextBox
    Friend WithEvents txtOptionName As System.Windows.Forms.TextBox
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
End Class
