<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputUserList
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
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.userNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(50, 24)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 0
        Me.btnReturn.Text = "戻る"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(422, 24)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(75, 23)
        Me.btnRegist.TabIndex = 1
        Me.btnRegist.Text = "登録する"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'dgvUserList
        '
        Me.dgvUserList.AllowUserToAddRows = False
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userNumber, Me.userName, Me.kana})
        Me.dgvUserList.Location = New System.Drawing.Point(12, 68)
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.RowTemplate.Height = 21
        Me.dgvUserList.Size = New System.Drawing.Size(541, 182)
        Me.dgvUserList.TabIndex = 2
        '
        'userNumber
        '
        Me.userNumber.HeaderText = "利用者番号"
        Me.userNumber.Name = "userNumber"
        Me.userNumber.ReadOnly = True
        '
        'userName
        '
        Me.userName.HeaderText = "利用者名"
        Me.userName.Name = "userName"
        Me.userName.ReadOnly = True
        Me.userName.Width = 160
        '
        'kana
        '
        Me.kana.HeaderText = "利用者名よみがな"
        Me.kana.Name = "kana"
        Me.kana.ReadOnly = True
        Me.kana.Width = 200
        '
        'InputUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 262)
        Me.Controls.Add(Me.dgvUserList)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.btnReturn)
        Me.Name = "InputUserList"
        Me.Text = "利用者番号登録"
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents dgvUserList As System.Windows.Forms.DataGridView
    Friend WithEvents userNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents userName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kana As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
