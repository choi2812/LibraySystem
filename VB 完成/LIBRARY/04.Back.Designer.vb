<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Back
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
        Me.txtOptionName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtScheduleReturnDate = New System.Windows.Forms.TextBox()
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
        Me.txtUserNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnTop = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.DataSet1 = New LIBRARY.DataSet1()
        Me.TAKEOUTLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAKEOUTLISTTableAdapter = New LIBRARY.DataSet1TableAdapters.TAKEOUTLISTTableAdapter()
        Me.TableAdapterManager = New LIBRARY.DataSet1TableAdapters.TableAdapterManager()
        Me.dgvBorrowList = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chkOptionBorrow = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnTopBack = New System.Windows.Forms.Button()
        Me.btnRental = New System.Windows.Forms.Button()
        Me.BookingInfoOutputer = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAKEOUTLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBorrowList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOptionName
        '
        Me.txtOptionName.Location = New System.Drawing.Point(317, 50)
        Me.txtOptionName.Name = "txtOptionName"
        Me.txtOptionName.ReadOnly = True
        Me.txtOptionName.Size = New System.Drawing.Size(75, 19)
        Me.txtOptionName.TabIndex = 55
        Me.txtOptionName.Text = "CD"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(339, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "付録"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(112, 50)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(199, 19)
        Me.txtTitle.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(186, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "書名"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(409, 477)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "取り消し"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtScheduleReturnDate
        '
        Me.txtScheduleReturnDate.Location = New System.Drawing.Point(467, 50)
        Me.txtScheduleReturnDate.Name = "txtScheduleReturnDate"
        Me.txtScheduleReturnDate.ReadOnly = True
        Me.txtScheduleReturnDate.Size = New System.Drawing.Size(100, 19)
        Me.txtScheduleReturnDate.TabIndex = 48
        Me.txtScheduleReturnDate.Text = "2016/01/20"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(483, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "返却予定日"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(212, 24)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 19)
        Me.txtDate.TabIndex = 46
        Me.txtDate.Text = "2016/01/20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "日付"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "蔵書番号"
        '
        'txtLibraryNumber
        '
        Me.txtLibraryNumber.Location = New System.Drawing.Point(6, 50)
        Me.txtLibraryNumber.Name = "txtLibraryNumber"
        Me.txtLibraryNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtLibraryNumber.TabIndex = 0
        '
        'txtUserNameKana
        '
        Me.txtUserNameKana.Location = New System.Drawing.Point(246, 47)
        Me.txtUserNameKana.Name = "txtUserNameKana"
        Me.txtUserNameKana.ReadOnly = True
        Me.txtUserNameKana.Size = New System.Drawing.Size(100, 19)
        Me.txtUserNameKana.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 12)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "名前かな"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(151, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "名前"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(125, 47)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(100, 19)
        Me.txtUserName.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HGPｺﾞｼｯｸE", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 48)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "返却"
        '
        'txtUserNumber
        '
        Me.txtUserNumber.Location = New System.Drawing.Point(9, 47)
        Me.txtUserNumber.Name = "txtUserNumber"
        Me.txtUserNumber.ReadOnly = True
        Me.txtUserNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtUserNumber.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "利用者番号"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.Location = New System.Drawing.Point(924, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 59)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "貸出"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnTop
        '
        Me.BtnTop.Location = New System.Drawing.Point(490, 477)
        Me.BtnTop.Name = "BtnTop"
        Me.BtnTop.Size = New System.Drawing.Size(75, 23)
        Me.BtnTop.TabIndex = 56
        Me.BtnTop.Text = "トップ"
        Me.BtnTop.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(409, 121)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "オールクリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAKEOUTLISTBindingSource
        '
        Me.TAKEOUTLISTBindingSource.DataMember = "TAKEOUTLIST"
        Me.TAKEOUTLISTBindingSource.DataSource = Me.DataSet1
        '
        'TAKEOUTLISTTableAdapter
        '
        Me.TAKEOUTLISTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TAKEOUTLISTTableAdapter = Me.TAKEOUTLISTTableAdapter
        Me.TableAdapterManager.UpdateOrder = LIBRARY.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgvBorrowList
        '
        Me.dgvBorrowList.AllowUserToAddRows = False
        Me.dgvBorrowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowList.Location = New System.Drawing.Point(12, 266)
        Me.dgvBorrowList.Name = "dgvBorrowList"
        Me.dgvBorrowList.RowTemplate.Height = 21
        Me.dgvBorrowList.Size = New System.Drawing.Size(748, 313)
        Me.dgvBorrowList.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(395, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "付録返却有"
        '
        'chkOptionBorrow
        '
        Me.chkOptionBorrow.AutoSize = True
        Me.chkOptionBorrow.Location = New System.Drawing.Point(425, 53)
        Me.chkOptionBorrow.Name = "chkOptionBorrow"
        Me.chkOptionBorrow.Size = New System.Drawing.Size(15, 14)
        Me.chkOptionBorrow.TabIndex = 61
        Me.chkOptionBorrow.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(667, 46)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "返却"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUserNumber)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtUserNameKana)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 80)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "返却者"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtLibraryNumber)
        Me.GroupBox2.Controls.Add(Me.btnBack)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chkOptionBorrow)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtScheduleReturnDate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtOptionName)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(748, 84)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "返却対象"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(579, 46)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnTopBack
        '
        Me.btnTopBack.Location = New System.Drawing.Point(685, 22)
        Me.btnTopBack.Name = "btnTopBack"
        Me.btnTopBack.Size = New System.Drawing.Size(75, 23)
        Me.btnTopBack.TabIndex = 5
        Me.btnTopBack.Text = "トップ"
        Me.btnTopBack.UseVisualStyleBackColor = True
        '
        'btnRental
        '
        Me.btnRental.Location = New System.Drawing.Point(591, 22)
        Me.btnRental.Name = "btnRental"
        Me.btnRental.Size = New System.Drawing.Size(75, 23)
        Me.btnRental.TabIndex = 4
        Me.btnRental.Text = "貸し出し"
        Me.btnRental.UseVisualStyleBackColor = True
        '
        'BookingInfoOutputer
        '
        '
        'Back
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 591)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRental)
        Me.Controls.Add(Me.btnTopBack)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBorrowList)
        Me.Controls.Add(Me.BtnTop)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Back"
        Me.Text = "返却"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAKEOUTLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBorrowList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOptionName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtScheduleReturnDate As System.Windows.Forms.TextBox
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
    Friend WithEvents txtUserNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnTop As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As LIBRARY.DataSet1
    Friend WithEvents TAKEOUTLISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TAKEOUTLISTTableAdapter As LIBRARY.DataSet1TableAdapters.TAKEOUTLISTTableAdapter
    Friend WithEvents TableAdapterManager As LIBRARY.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents dgvBorrowList As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkOptionBorrow As System.Windows.Forms.CheckBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTopBack As System.Windows.Forms.Button
    Friend WithEvents btnRental As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents BookingInfoOutputer As System.Drawing.Printing.PrintDocument
End Class
