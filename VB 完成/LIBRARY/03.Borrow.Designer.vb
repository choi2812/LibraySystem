<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrow
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtOptionName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtBackDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLibraryNumber = New System.Windows.Forms.TextBox()
        Me.txtUserNameKana = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserNumberSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSet2 = New LIBRARY.DataSet2()
        Me.RENTALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RENTALTableAdapter = New LIBRARY.DataSet2TableAdapters.RENTALTableAdapter()
        Me.TableAdapterManager = New LIBRARY.DataSet2TableAdapters.TableAdapterManager()
        Me.btnUserSearch = New System.Windows.Forms.Button()
        Me.chkOptionBorrow = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUserNumber = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLibrarySearch = New System.Windows.Forms.Button()
        Me.btnTop = New System.Windows.Forms.Button()
        Me.dgvBorrowList = New System.Windows.Forms.DataGridView()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RENTALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvBorrowList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOptionName
        '
        Me.txtOptionName.Location = New System.Drawing.Point(427, 49)
        Me.txtOptionName.Name = "txtOptionName"
        Me.txtOptionName.ReadOnly = True
        Me.txtOptionName.Size = New System.Drawing.Size(73, 19)
        Me.txtOptionName.TabIndex = 77
        Me.txtOptionName.Text = "無し"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(442, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "付録"
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(222, 49)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.ReadOnly = True
        Me.txtBookName.Size = New System.Drawing.Size(199, 19)
        Me.txtBookName.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "書名"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(556, 16)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "返却"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtBackDate
        '
        Me.txtBackDate.Location = New System.Drawing.Point(439, 18)
        Me.txtBackDate.Name = "txtBackDate"
        Me.txtBackDate.ReadOnly = True
        Me.txtBackDate.Size = New System.Drawing.Size(100, 19)
        Me.txtBackDate.TabIndex = 70
        Me.txtBackDate.Text = "2016/4/21"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "返却予定日"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(256, 18)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 19)
        Me.txtDate.TabIndex = 68
        Me.txtDate.Text = "2016/4/07"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "日付"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "蔵書番号検索"
        '
        'txtLibraryNumber
        '
        Me.txtLibraryNumber.Location = New System.Drawing.Point(21, 49)
        Me.txtLibraryNumber.Name = "txtLibraryNumber"
        Me.txtLibraryNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtLibraryNumber.TabIndex = 3
        '
        'txtUserNameKana
        '
        Me.txtUserNameKana.Location = New System.Drawing.Point(456, 47)
        Me.txtUserNameKana.Name = "txtUserNameKana"
        Me.txtUserNameKana.ReadOnly = True
        Me.txtUserNameKana.Size = New System.Drawing.Size(100, 19)
        Me.txtUserNameKana.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 12)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "名前かな"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "名前"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(335, 47)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(100, 19)
        Me.txtUserName.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HGPｺﾞｼｯｸE", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 48)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "貸出入力"
        '
        'txtUserNumberSearch
        '
        Me.txtUserNumberSearch.Location = New System.Drawing.Point(16, 45)
        Me.txtUserNumberSearch.Name = "txtUserNumberSearch"
        Me.txtUserNumberSearch.Size = New System.Drawing.Size(105, 19)
        Me.txtUserNumberSearch.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "利用者番号入力"
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RENTALBindingSource
        '
        Me.RENTALBindingSource.DataMember = "RENTAL"
        Me.RENTALBindingSource.DataSource = Me.DataSet2
        '
        'RENTALTableAdapter
        '
        Me.RENTALTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RENTALTableAdapter = Me.RENTALTableAdapter
        Me.TableAdapterManager.UpdateOrder = LIBRARY.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnUserSearch
        '
        Me.btnUserSearch.Location = New System.Drawing.Point(134, 43)
        Me.btnUserSearch.Name = "btnUserSearch"
        Me.btnUserSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnUserSearch.TabIndex = 2
        Me.btnUserSearch.Text = "利用者検索"
        Me.btnUserSearch.UseVisualStyleBackColor = True
        '
        'chkOptionBorrow
        '
        Me.chkOptionBorrow.AutoSize = True
        Me.chkOptionBorrow.Location = New System.Drawing.Point(523, 49)
        Me.chkOptionBorrow.Name = "chkOptionBorrow"
        Me.chkOptionBorrow.Size = New System.Drawing.Size(68, 16)
        Me.chkOptionBorrow.TabIndex = 5
        Me.chkOptionBorrow.Text = "貸出有り"
        Me.chkOptionBorrow.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(523, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 12)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "付属品貸出有無"
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(667, 180)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(87, 74)
        Me.btnBorrow.TabIndex = 6
        Me.btnBorrow.Text = "貸出"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(667, 91)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "オールクリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUserNumber)
        Me.GroupBox1.Controls.Add(Me.btnUserSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtUserNumberSearch)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtUserNameKana)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 85)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "貸出対象者"
        '
        'txtUserNumber
        '
        Me.txtUserNumber.Location = New System.Drawing.Point(222, 47)
        Me.txtUserNumber.Name = "txtUserNumber"
        Me.txtUserNumber.ReadOnly = True
        Me.txtUserNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtUserNumber.TabIndex = 82
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(241, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "利用者番号"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLibrarySearch)
        Me.GroupBox2.Controls.Add(Me.txtLibraryNumber)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtBookName)
        Me.GroupBox2.Controls.Add(Me.chkOptionBorrow)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtOptionName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 100)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "貸出内容決定"
        '
        'btnLibrarySearch
        '
        Me.btnLibrarySearch.Location = New System.Drawing.Point(134, 47)
        Me.btnLibrarySearch.Name = "btnLibrarySearch"
        Me.btnLibrarySearch.Size = New System.Drawing.Size(75, 23)
        Me.btnLibrarySearch.TabIndex = 4
        Me.btnLibrarySearch.Text = "蔵書検索"
        Me.btnLibrarySearch.UseVisualStyleBackColor = True
        '
        'btnTop
        '
        Me.btnTop.Location = New System.Drawing.Point(667, 16)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(75, 23)
        Me.btnTop.TabIndex = 9
        Me.btnTop.Text = "トップ"
        Me.btnTop.UseVisualStyleBackColor = True
        '
        'dgvBorrowList
        '
        Me.dgvBorrowList.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBorrowList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBorrowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBorrowList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBorrowList.Location = New System.Drawing.Point(17, 267)
        Me.dgvBorrowList.Name = "dgvBorrowList"
        Me.dgvBorrowList.ReadOnly = True
        Me.dgvBorrowList.RowTemplate.Height = 21
        Me.dgvBorrowList.Size = New System.Drawing.Size(748, 229)
        Me.dgvBorrowList.TabIndex = 88
        '
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 587)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.dgvBorrowList)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtBackDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Borrow"
        Me.Text = "貸出"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RENTALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvBorrowList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOptionName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBookName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtBackDate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLibraryNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtUserNameKana As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserNumberSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet2 As LIBRARY.DataSet2
    Friend WithEvents RENTALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RENTALTableAdapter As LIBRARY.DataSet2TableAdapters.RENTALTableAdapter
    Friend WithEvents TableAdapterManager As LIBRARY.DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents btnUserSearch As System.Windows.Forms.Button
    Friend WithEvents chkOptionBorrow As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnTop As System.Windows.Forms.Button
    Friend WithEvents dgvBorrowList As System.Windows.Forms.DataGridView
    Friend WithEvents txtUserNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnLibrarySearch As System.Windows.Forms.Button
End Class
