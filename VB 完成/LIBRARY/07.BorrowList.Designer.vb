<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowList
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTimeOver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbLibrarynumber = New System.Windows.Forms.RadioButton()
        Me.rbUserNumber = New System.Windows.Forms.RadioButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet1 = New LIBRARY.DataSet1()
        Me.TAKEOUTLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAKEOUTLISTTableAdapter = New LIBRARY.DataSet1TableAdapters.TAKEOUTLISTTableAdapter()
        Me.TableAdapterManager = New LIBRARY.DataSet1TableAdapters.TableAdapterManager()
        Me.dgvBorrowList = New System.Windows.Forms.DataGridView()
        Me.btnBookingList = New System.Windows.Forms.Button()
        Me.btnTop = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAKEOUTLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBorrowList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTimeOver)
        Me.GroupBox2.Location = New System.Drawing.Point(349, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 61)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "期間検索"
        '
        'btnTimeOver
        '
        Me.btnTimeOver.Location = New System.Drawing.Point(19, 23)
        Me.btnTimeOver.Name = "btnTimeOver"
        Me.btnTimeOver.Size = New System.Drawing.Size(94, 22)
        Me.btnTimeOver.TabIndex = 4
        Me.btnTimeOver.Text = "期間超えを検索"
        Me.btnTimeOver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbLibrarynumber)
        Me.GroupBox1.Controls.Add(Me.rbUserNumber)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 61)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "個人検索"
        '
        'rbLibrarynumber
        '
        Me.rbLibrarynumber.AutoSize = True
        Me.rbLibrarynumber.Location = New System.Drawing.Point(8, 39)
        Me.rbLibrarynumber.Name = "rbLibrarynumber"
        Me.rbLibrarynumber.Size = New System.Drawing.Size(71, 16)
        Me.rbLibrarynumber.TabIndex = 1
        Me.rbLibrarynumber.Text = "蔵書番号"
        Me.rbLibrarynumber.UseVisualStyleBackColor = True
        '
        'rbUserNumber
        '
        Me.rbUserNumber.AutoSize = True
        Me.rbUserNumber.Checked = True
        Me.rbUserNumber.Location = New System.Drawing.Point(8, 17)
        Me.rbUserNumber.Name = "rbUserNumber"
        Me.rbUserNumber.Size = New System.Drawing.Size(83, 16)
        Me.rbUserNumber.TabIndex = 0
        Me.rbUserNumber.TabStop = True
        Me.rbUserNumber.Text = "利用者番号"
        Me.rbUserNumber.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(212, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(97, 26)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtNumber.TabIndex = 2
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(498, 82)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(131, 49)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "返却催促"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(667, 108)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "オールクリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "貸出リスト"
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
        Me.dgvBorrowList.Location = New System.Drawing.Point(4, 165)
        Me.dgvBorrowList.Name = "dgvBorrowList"
        Me.dgvBorrowList.RowTemplate.Height = 21
        Me.dgvBorrowList.Size = New System.Drawing.Size(821, 350)
        Me.dgvBorrowList.TabIndex = 33
        '
        'btnBookingList
        '
        Me.btnBookingList.Location = New System.Drawing.Point(568, 12)
        Me.btnBookingList.Name = "btnBookingList"
        Me.btnBookingList.Size = New System.Drawing.Size(75, 23)
        Me.btnBookingList.TabIndex = 7
        Me.btnBookingList.Text = "予約リスト"
        Me.btnBookingList.UseVisualStyleBackColor = True
        '
        'btnTop
        '
        Me.btnTop.Location = New System.Drawing.Point(667, 12)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(75, 23)
        Me.btnTop.TabIndex = 8
        Me.btnTop.Text = "トップ"
        Me.btnTop.UseVisualStyleBackColor = True
        '
        'BorrowList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 515)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.btnBookingList)
        Me.Controls.Add(Me.dgvBorrowList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BorrowList"
        Me.Text = "貸出リスト"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAKEOUTLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBorrowList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTimeOver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As LIBRARY.DataSet1
    Friend WithEvents TAKEOUTLISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TAKEOUTLISTTableAdapter As LIBRARY.DataSet1TableAdapters.TAKEOUTLISTTableAdapter
    Friend WithEvents TableAdapterManager As LIBRARY.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents dgvBorrowList As System.Windows.Forms.DataGridView
    Friend WithEvents rbLibrarynumber As System.Windows.Forms.RadioButton
    Friend WithEvents rbUserNumber As System.Windows.Forms.RadioButton
    Friend WithEvents btnBookingList As System.Windows.Forms.Button
    Friend WithEvents btnTop As System.Windows.Forms.Button
End Class
