<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingDelete
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet3 = New LIBRARY.DataSet3()
        Me.BOKINGLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOKINGLISTTableAdapter = New LIBRARY.DataSet3TableAdapters.BOKINGLISTTableAdapter()
        Me.TableAdapterManager = New LIBRARY.DataSet3TableAdapters.TableAdapterManager()
        Me.btnLimitSearch = New System.Windows.Forms.Button()
        Me.rblibraryNumber = New System.Windows.Forms.RadioButton()
        Me.rbUserNumber = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBorrowList = New System.Windows.Forms.Button()
        Me.btnTop = New System.Windows.Forms.Button()
        Me.BookingInfoOutputer = New System.Drawing.Printing.PrintDocument()
        Me.dgvBookingList = New System.Windows.Forms.DataGridView()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOKINGLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvBookingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(550, 93)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(134, 51)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "予約削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(225, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(107, 33)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtNumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HGPｺﾞｼｯｸE", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(38, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 48)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "予約削除"
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet3"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOKINGLISTBindingSource
        '
        Me.BOKINGLISTBindingSource.DataMember = "BOKINGLIST"
        Me.BOKINGLISTBindingSource.DataSource = Me.DataSet3
        '
        'BOKINGLISTTableAdapter
        '
        Me.BOKINGLISTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BOKINGLISTTableAdapter = Me.BOKINGLISTTableAdapter
        Me.TableAdapterManager.UpdateOrder = LIBRARY.DataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnLimitSearch
        '
        Me.btnLimitSearch.Location = New System.Drawing.Point(23, 29)
        Me.btnLimitSearch.Name = "btnLimitSearch"
        Me.btnLimitSearch.Size = New System.Drawing.Size(110, 23)
        Me.btnLimitSearch.TabIndex = 4
        Me.btnLimitSearch.Text = "入荷後3日経過"
        Me.btnLimitSearch.UseVisualStyleBackColor = True
        '
        'rblibraryNumber
        '
        Me.rblibraryNumber.AutoSize = True
        Me.rblibraryNumber.Location = New System.Drawing.Point(18, 40)
        Me.rblibraryNumber.Name = "rblibraryNumber"
        Me.rblibraryNumber.Size = New System.Drawing.Size(71, 16)
        Me.rblibraryNumber.TabIndex = 1
        Me.rblibraryNumber.Text = "蔵書番号"
        Me.rblibraryNumber.UseVisualStyleBackColor = True
        '
        'rbUserNumber
        '
        Me.rbUserNumber.AutoSize = True
        Me.rbUserNumber.Checked = True
        Me.rbUserNumber.Location = New System.Drawing.Point(18, 18)
        Me.rbUserNumber.Name = "rbUserNumber"
        Me.rbUserNumber.Size = New System.Drawing.Size(83, 16)
        Me.rbUserNumber.TabIndex = 0
        Me.rbUserNumber.TabStop = True
        Me.rbUserNumber.Text = "利用者番号"
        Me.rbUserNumber.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbUserNumber)
        Me.GroupBox1.Controls.Add(Me.rblibraryNumber)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 70)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "条件検索"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLimitSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 70)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "期間検索"
        '
        'btnBorrowList
        '
        Me.btnBorrowList.Location = New System.Drawing.Point(497, 30)
        Me.btnBorrowList.Name = "btnBorrowList"
        Me.btnBorrowList.Size = New System.Drawing.Size(82, 23)
        Me.btnBorrowList.TabIndex = 6
        Me.btnBorrowList.Text = "貸し出しリスト"
        Me.btnBorrowList.UseVisualStyleBackColor = True
        '
        'btnTop
        '
        Me.btnTop.Location = New System.Drawing.Point(609, 30)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(75, 23)
        Me.btnTop.TabIndex = 7
        Me.btnTop.Text = "トップ"
        Me.btnTop.UseVisualStyleBackColor = True
        '
        'BookingInfoOutputer
        '
        '
        'dgvBookingList
        '
        Me.dgvBookingList.AllowUserToAddRows = False
        Me.dgvBookingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookingList.Location = New System.Drawing.Point(2, 150)
        Me.dgvBookingList.Name = "dgvBookingList"
        Me.dgvBookingList.RowTemplate.Height = 21
        Me.dgvBookingList.Size = New System.Drawing.Size(817, 331)
        Me.dgvBookingList.TabIndex = 92
        '
        'BookingDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 483)
        Me.Controls.Add(Me.dgvBookingList)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.btnBorrowList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BookingDelete"
        Me.Text = "予約削除"
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOKINGLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvBookingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet3 As LIBRARY.DataSet3
    Friend WithEvents BOKINGLISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOKINGLISTTableAdapter As LIBRARY.DataSet3TableAdapters.BOKINGLISTTableAdapter
    Friend WithEvents TableAdapterManager As LIBRARY.DataSet3TableAdapters.TableAdapterManager
    Friend WithEvents btnLimitSearch As System.Windows.Forms.Button
    Friend WithEvents rblibraryNumber As System.Windows.Forms.RadioButton
    Friend WithEvents rbUserNumber As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBorrowList As System.Windows.Forms.Button
    Friend WithEvents btnTop As System.Windows.Forms.Button
    Friend WithEvents BookingInfoOutputer As System.Drawing.Printing.PrintDocument
    Friend WithEvents dgvBookingList As System.Windows.Forms.DataGridView
End Class
