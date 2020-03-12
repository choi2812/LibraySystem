<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookAdd
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtOptionSpecification = New System.Windows.Forms.TextBox()
        Me.BtnCheck = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTitleKana = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSubtitle = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSubtitleKana = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEtc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtISBNSearch = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLibraryNumber = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxCapital = New System.Windows.Forms.ComboBox()
        Me.cbxShelf = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbxGenre = New System.Windows.Forms.ComboBox()
        Me.cbxOptionName = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbxPublishYear = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.txtAuthorNameKana = New System.Windows.Forms.TextBox()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtPublisherKana = New System.Windows.Forms.TextBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(199, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "蔵書情報入力"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 480)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "付属品明細"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(82, 406)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(64, 19)
        Me.txtPrice.TabIndex = 16
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOptionSpecification
        '
        Me.txtOptionSpecification.Location = New System.Drawing.Point(82, 477)
        Me.txtOptionSpecification.Name = "txtOptionSpecification"
        Me.txtOptionSpecification.Size = New System.Drawing.Size(470, 19)
        Me.txtOptionSpecification.TabIndex = 18
        '
        'BtnCheck
        '
        Me.BtnCheck.Location = New System.Drawing.Point(436, 565)
        Me.BtnCheck.Name = "BtnCheck"
        Me.BtnCheck.Size = New System.Drawing.Size(116, 43)
        Me.BtnCheck.TabIndex = 20
        Me.BtnCheck.Text = "確認"
        Me.BtnCheck.UseVisualStyleBackColor = True
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "書名"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(82, 207)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(171, 19)
        Me.txtTitle.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(285, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 12)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "書名かな"
        '
        'txtTitleKana
        '
        Me.txtTitleKana.Location = New System.Drawing.Point(340, 207)
        Me.txtTitleKana.Name = "txtTitleKana"
        Me.txtTitleKana.Size = New System.Drawing.Size(171, 19)
        Me.txtTitleKana.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 12)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "副書名"
        '
        'txtSubtitle
        '
        Me.txtSubtitle.Location = New System.Drawing.Point(82, 248)
        Me.txtSubtitle.Name = "txtSubtitle"
        Me.txtSubtitle.Size = New System.Drawing.Size(171, 19)
        Me.txtSubtitle.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 374)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "発行年"
        '
        'txtSubtitleKana
        '
        Me.txtSubtitleKana.Location = New System.Drawing.Point(340, 248)
        Me.txtSubtitleKana.Name = "txtSubtitleKana"
        Me.txtSubtitleKana.Size = New System.Drawing.Size(171, 19)
        Me.txtSubtitleKana.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 335)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "出版社"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(273, 336)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 12)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "出版社かな"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(273, 251)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 12)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "副書名かな"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "価格"
        '
        'txtEtc
        '
        Me.txtEtc.Location = New System.Drawing.Point(79, 516)
        Me.txtEtc.Name = "txtEtc"
        Me.txtEtc.Size = New System.Drawing.Size(473, 19)
        Me.txtEtc.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 519)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "備考"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 12)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "ISBN"
        '
        'txtISBNSearch
        '
        Me.txtISBNSearch.Location = New System.Drawing.Point(79, 20)
        Me.txtISBNSearch.Name = "txtISBNSearch"
        Me.txtISBNSearch.Size = New System.Drawing.Size(100, 19)
        Me.txtISBNSearch.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "蔵書番号"
        '
        'txtLibraryNumber
        '
        Me.txtLibraryNumber.Location = New System.Drawing.Point(84, 126)
        Me.txtLibraryNumber.Name = "txtLibraryNumber"
        Me.txtLibraryNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtLibraryNumber.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(201, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 12)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "棚"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxCapital)
        Me.GroupBox1.Controls.Add(Me.cbxShelf)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cbxGenre)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 47)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "請求記号"
        '
        'cbxCapital
        '
        Me.cbxCapital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCapital.FormattingEnabled = True
        Me.cbxCapital.Location = New System.Drawing.Point(457, 15)
        Me.cbxCapital.Name = "cbxCapital"
        Me.cbxCapital.Size = New System.Drawing.Size(46, 20)
        Me.cbxCapital.TabIndex = 5
        '
        'cbxShelf
        '
        Me.cbxShelf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxShelf.FormattingEnabled = True
        Me.cbxShelf.Location = New System.Drawing.Point(224, 16)
        Me.cbxShelf.Name = "cbxShelf"
        Me.cbxShelf.Size = New System.Drawing.Size(63, 20)
        Me.cbxShelf.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(294, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(157, 12)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "作者頭文字(半角英字大文字)"
        '
        'cbxGenre
        '
        Me.cbxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGenre.FormattingEnabled = True
        Me.cbxGenre.Location = New System.Drawing.Point(60, 15)
        Me.cbxGenre.Name = "cbxGenre"
        Me.cbxGenre.Size = New System.Drawing.Size(121, 20)
        Me.cbxGenre.TabIndex = 3
        '
        'cbxOptionName
        '
        Me.cbxOptionName.FormattingEnabled = True
        Me.cbxOptionName.Items.AddRange(New Object() {"CD", "DVD", "ビデオ", "無し"})
        Me.cbxOptionName.Location = New System.Drawing.Point(82, 441)
        Me.cbxOptionName.Name = "cbxOptionName"
        Me.cbxOptionName.Size = New System.Drawing.Size(121, 20)
        Me.cbxOptionName.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(35, 444)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 12)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "付属品"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(199, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbxPublishYear
        '
        Me.cbxPublishYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPublishYear.FormattingEnabled = True
        Me.cbxPublishYear.Location = New System.Drawing.Point(82, 371)
        Me.cbxPublishYear.Name = "cbxPublishYear"
        Me.cbxPublishYear.Size = New System.Drawing.Size(121, 20)
        Me.cbxPublishYear.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtISBNSearch)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 57)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(280, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(190, 12)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "※ISBNがある本は先に検索してください"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(285, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 12)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "著者かな"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "著者名"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 568)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 40)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "トップ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtAuthorName
        '
        Me.txtAuthorName.Location = New System.Drawing.Point(79, 292)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.Size = New System.Drawing.Size(173, 19)
        Me.txtAuthorName.TabIndex = 10
        '
        'txtAuthorNameKana
        '
        Me.txtAuthorNameKana.Location = New System.Drawing.Point(340, 294)
        Me.txtAuthorNameKana.Name = "txtAuthorNameKana"
        Me.txtAuthorNameKana.Size = New System.Drawing.Size(171, 19)
        Me.txtAuthorNameKana.TabIndex = 12
        '
        'txtPublisher
        '
        Me.txtPublisher.Location = New System.Drawing.Point(79, 332)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(173, 19)
        Me.txtPublisher.TabIndex = 13
        '
        'txtPublisherKana
        '
        Me.txtPublisherKana.Location = New System.Drawing.Point(340, 333)
        Me.txtPublisherKana.Name = "txtPublisherKana"
        Me.txtPublisherKana.Size = New System.Drawing.Size(171, 19)
        Me.txtPublisherKana.TabIndex = 14
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(262, 129)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.ReadOnly = True
        Me.txtISBN.Size = New System.Drawing.Size(123, 19)
        Me.txtISBN.TabIndex = 57
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(225, 132)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 12)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "ISBN"
        '
        'BookAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 643)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.txtPublisherKana)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.txtAuthorNameKana)
        Me.Controls.Add(Me.txtAuthorName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbxPublishYear)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbxOptionName)
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
        Me.Controls.Add(Me.BtnCheck)
        Me.Controls.Add(Me.txtOptionSpecification)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BookAdd"
        Me.Text = "蔵書追加"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtOptionSpecification As System.Windows.Forms.TextBox
    Friend WithEvents BtnCheck As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTitleKana As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSubtitle As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSubtitleKana As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEtc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtISBNSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLibraryNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxOptionName As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbxGenre As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPublishYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxCapital As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbxShelf As System.Windows.Forms.ComboBox
    Friend WithEvents txtAuthorName As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorNameKana As System.Windows.Forms.TextBox
    Friend WithEvents txtPublisher As System.Windows.Forms.TextBox
    Friend WithEvents txtPublisherKana As System.Windows.Forms.TextBox
    Friend WithEvents txtISBN As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
