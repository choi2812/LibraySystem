<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Top
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
        Me.btnUserPasswordReset = New System.Windows.Forms.Button()
        Me.btnBookingDelete = New System.Windows.Forms.Button()
        Me.btnUserRegist = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBookDelete = New System.Windows.Forms.Button()
        Me.btnBookAdd = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBorrowList = New System.Windows.Forms.Button()
        Me.btnSelectUserFile = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUserPasswordReset
        '
        Me.btnUserPasswordReset.Location = New System.Drawing.Point(348, 18)
        Me.btnUserPasswordReset.Name = "btnUserPasswordReset"
        Me.btnUserPasswordReset.Size = New System.Drawing.Size(115, 67)
        Me.btnUserPasswordReset.TabIndex = 7
        Me.btnUserPasswordReset.Text = "利用者パスワードを初期化する"
        Me.btnUserPasswordReset.UseVisualStyleBackColor = True
        '
        'btnBookingDelete
        '
        Me.btnBookingDelete.Location = New System.Drawing.Point(272, 104)
        Me.btnBookingDelete.Name = "btnBookingDelete"
        Me.btnBookingDelete.Size = New System.Drawing.Size(191, 82)
        Me.btnBookingDelete.TabIndex = 4
        Me.btnBookingDelete.Text = "予約確認と削除"
        Me.btnBookingDelete.UseVisualStyleBackColor = True
        '
        'btnUserRegist
        '
        Me.btnUserRegist.Location = New System.Drawing.Point(170, 18)
        Me.btnUserRegist.Name = "btnUserRegist"
        Me.btnUserRegist.Size = New System.Drawing.Size(146, 67)
        Me.btnUserRegist.TabIndex = 6
        Me.btnUserRegist.Text = "利用者情報登録/変更"
        Me.btnUserRegist.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(272, 17)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(191, 81)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "返却"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBookDelete
        '
        Me.btnBookDelete.Location = New System.Drawing.Point(193, 18)
        Me.btnBookDelete.Name = "btnBookDelete"
        Me.btnBookDelete.Size = New System.Drawing.Size(121, 67)
        Me.btnBookDelete.TabIndex = 9
        Me.btnBookDelete.Text = "除籍"
        Me.btnBookDelete.UseVisualStyleBackColor = True
        '
        'btnBookAdd
        '
        Me.btnBookAdd.Location = New System.Drawing.Point(21, 18)
        Me.btnBookAdd.Name = "btnBookAdd"
        Me.btnBookAdd.Size = New System.Drawing.Size(115, 67)
        Me.btnBookAdd.TabIndex = 8
        Me.btnBookAdd.Text = "蔵書追加"
        Me.btnBookAdd.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(20, 17)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(191, 80)
        Me.btnBorrow.TabIndex = 1
        Me.btnBorrow.Text = "貸出"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HGPｺﾞｼｯｸE", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(82, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 48)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "図書館内システム"
        '
        'btnBorrowList
        '
        Me.btnBorrowList.Location = New System.Drawing.Point(20, 104)
        Me.btnBorrowList.Name = "btnBorrowList"
        Me.btnBorrowList.Size = New System.Drawing.Size(191, 82)
        Me.btnBorrowList.TabIndex = 3
        Me.btnBorrowList.Text = "貸出リスト"
        Me.btnBorrowList.UseVisualStyleBackColor = True
        '
        'btnSelectUserFile
        '
        Me.btnSelectUserFile.Location = New System.Drawing.Point(20, 18)
        Me.btnSelectUserFile.Name = "btnSelectUserFile"
        Me.btnSelectUserFile.Size = New System.Drawing.Size(115, 67)
        Me.btnSelectUserFile.TabIndex = 5
        Me.btnSelectUserFile.Text = "利用者番号登録"
        Me.btnSelectUserFile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBookAdd)
        Me.GroupBox1.Controls.Add(Me.btnBookDelete)
        Me.GroupBox1.Location = New System.Drawing.Point(108, 388)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 100)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "蔵書管理"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUserPasswordReset)
        Me.GroupBox2.Controls.Add(Me.btnUserRegist)
        Me.GroupBox2.Controls.Add(Me.btnSelectUserFile)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 100)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "利用者番号管理"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBorrow)
        Me.GroupBox3.Controls.Add(Me.btnBack)
        Me.GroupBox3.Controls.Add(Me.btnBookingDelete)
        Me.GroupBox3.Controls.Add(Me.btnBorrowList)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 202)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "貸出/返却/予約"
        '
        'Top
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 516)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Top"
        Me.Text = "図書館内システム"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUserPasswordReset As System.Windows.Forms.Button
    Friend WithEvents btnBookingDelete As System.Windows.Forms.Button
    Friend WithEvents btnUserRegist As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBookDelete As System.Windows.Forms.Button
    Friend WithEvents btnBookAdd As System.Windows.Forms.Button
    Friend WithEvents btnBorrow As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBorrowList As System.Windows.Forms.Button
    Friend WithEvents btnSelectUserFile As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
