<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rental
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
        Me.txtAppendix = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBookname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtBack = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtToday = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLibrarynumber = New System.Windows.Forms.TextBox()
        Me.txtKana = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSet2 = New LIBRARY.DataSet2()
        Me.RENTALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RENTALTableAdapter = New LIBRARY.DataSet2TableAdapters.RENTALTableAdapter()
        Me.TableAdapterManager = New LIBRARY.DataSet2TableAdapters.TableAdapterManager()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.chk = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RENTALDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RENTALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RENTALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAppendix
        '
        Me.txtAppendix.Location = New System.Drawing.Point(344, 49)
        Me.txtAppendix.Name = "txtAppendix"
        Me.txtAppendix.ReadOnly = True
        Me.txtAppendix.Size = New System.Drawing.Size(73, 19)
        Me.txtAppendix.TabIndex = 77
        Me.txtAppendix.Text = "無し"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(357, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "付録"
        '
        'txtBookname
        '
        Me.txtBookname.Location = New System.Drawing.Point(137, 49)
        Me.txtBookname.Name = "txtBookname"
        Me.txtBookname.ReadOnly = True
        Me.txtBookname.Size = New System.Drawing.Size(199, 19)
        Me.txtBookname.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 24)
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
        Me.btnBack.TabIndex = 72
        Me.btnBack.Text = "返却"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtBack
        '
        Me.txtBack.Location = New System.Drawing.Point(439, 18)
        Me.txtBack.Name = "txtBack"
        Me.txtBack.ReadOnly = True
        Me.txtBack.Size = New System.Drawing.Size(100, 19)
        Me.txtBack.TabIndex = 70
        Me.txtBack.Text = "2016/4/21"
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
        'txtToday
        '
        Me.txtToday.Location = New System.Drawing.Point(256, 18)
        Me.txtToday.Name = "txtToday"
        Me.txtToday.ReadOnly = True
        Me.txtToday.Size = New System.Drawing.Size(100, 19)
        Me.txtToday.TabIndex = 68
        Me.txtToday.Text = "2016/4/07"
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
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "蔵書番号"
        '
        'txtLibrarynumber
        '
        Me.txtLibrarynumber.Location = New System.Drawing.Point(21, 49)
        Me.txtLibrarynumber.Name = "txtLibrarynumber"
        Me.txtLibrarynumber.Size = New System.Drawing.Size(100, 19)
        Me.txtLibrarynumber.TabIndex = 65
        '
        'txtKana
        '
        Me.txtKana.Location = New System.Drawing.Point(253, 45)
        Me.txtKana.Name = "txtKana"
        Me.txtKana.ReadOnly = True
        Me.txtKana.Size = New System.Drawing.Size(100, 19)
        Me.txtKana.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(282, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 12)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "名前かな"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "名前"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(132, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 61
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
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(16, 45)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 19)
        Me.txtNumber.TabIndex = 59
        Me.txtNumber.Text = "13fd0113"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "利用者番号"
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
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(387, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 80
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'chk
        '
        Me.chk.AutoSize = True
        Me.chk.Location = New System.Drawing.Point(438, 49)
        Me.chk.Name = "chk"
        Me.chk.Size = New System.Drawing.Size(68, 16)
        Me.chk.TabIndex = 81
        Me.chk.Text = "貸出有り"
        Me.chk.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(438, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 12)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "付属品貸出有無"
        '
        'btnRent
        '
        Me.btnRent.Location = New System.Drawing.Point(573, 194)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(130, 51)
        Me.btnRent.TabIndex = 83
        Me.btnRent.Text = "貸出"
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(492, 40)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 23)
        Me.btnClear.TabIndex = 84
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtKana)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 85)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "貸出対象者"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLibrarynumber)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtBookname)
        Me.GroupBox2.Controls.Add(Me.chk)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAppendix)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 100)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "貸出内容決定"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(667, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 87
        Me.Button3.Text = "トップ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "付録貸出"
        Me.DataGridViewTextBoxColumn7.HeaderText = "付録貸出"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "付録"
        Me.DataGridViewTextBoxColumn9.HeaderText = "付録"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "書名"
        Me.DataGridViewTextBoxColumn5.HeaderText = "書名"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "蔵書番号"
        Me.DataGridViewTextBoxColumn6.HeaderText = "蔵書番号"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "返却予定日"
        Me.DataGridViewTextBoxColumn10.HeaderText = "返却予定日"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'RENTALDataGridView
        '
        Me.RENTALDataGridView.AutoGenerateColumns = False
        Me.RENTALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RENTALDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn7})
        Me.RENTALDataGridView.DataSource = Me.RENTALBindingSource
        Me.RENTALDataGridView.Location = New System.Drawing.Point(12, 281)
        Me.RENTALDataGridView.Name = "RENTALDataGridView"
        Me.RENTALDataGridView.RowTemplate.Height = 21
        Me.RENTALDataGridView.Size = New System.Drawing.Size(536, 215)
        Me.RENTALDataGridView.TabIndex = 79
        '
        'Rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 587)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRent)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RENTALDataGridView)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtBack)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtToday)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rental"
        Me.Text = "Rental"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RENTALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RENTALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAppendix As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBookname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtBack As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtToday As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLibrarynumber As System.Windows.Forms.TextBox
    Friend WithEvents txtKana As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataSet2 As LIBRARY.DataSet2
    Friend WithEvents RENTALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RENTALTableAdapter As LIBRARY.DataSet2TableAdapters.RENTALTableAdapter
    Friend WithEvents TableAdapterManager As LIBRARY.DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents chk As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnRent As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RENTALDataGridView As System.Windows.Forms.DataGridView
End Class
