<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.AutoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CancelBT = New System.Windows.Forms.Button()
        Me.OkayBT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PCOTPHelp = New System.Windows.Forms.LinkLabel()
        Me.PCOTPFilePathBox = New System.Windows.Forms.TextBox()
        Me.FileViewBT = New System.Windows.Forms.Button()
        Me.OTPLaunchBox = New System.Windows.Forms.CheckBox()
        Me.OTPLaunchHelp = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'AutoCheckBox
        '
        Me.AutoCheckBox.AutoSize = True
        Me.AutoCheckBox.Location = New System.Drawing.Point(35, 24)
        Me.AutoCheckBox.Name = "AutoCheckBox"
        Me.AutoCheckBox.Size = New System.Drawing.Size(172, 16)
        Me.AutoCheckBox.TabIndex = 0
        Me.AutoCheckBox.Text = "起動時にアップデートチェックする"
        Me.AutoCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "アップデート"
        '
        'CancelBT
        '
        Me.CancelBT.Location = New System.Drawing.Point(197, 227)
        Me.CancelBT.Name = "CancelBT"
        Me.CancelBT.Size = New System.Drawing.Size(75, 23)
        Me.CancelBT.TabIndex = 2
        Me.CancelBT.Text = "キャンセル"
        Me.CancelBT.UseVisualStyleBackColor = True
        '
        'OkayBT
        '
        Me.OkayBT.Location = New System.Drawing.Point(116, 227)
        Me.OkayBT.Name = "OkayBT"
        Me.OkayBT.Size = New System.Drawing.Size(75, 23)
        Me.OkayBT.TabIndex = 3
        Me.OkayBT.Text = "OK"
        Me.OkayBT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PC型トークンパス"
        '
        'PCOTPHelp
        '
        Me.PCOTPHelp.AutoSize = True
        Me.PCOTPHelp.Location = New System.Drawing.Point(113, 78)
        Me.PCOTPHelp.Name = "PCOTPHelp"
        Me.PCOTPHelp.Size = New System.Drawing.Size(17, 12)
        Me.PCOTPHelp.TabIndex = 5
        Me.PCOTPHelp.TabStop = True
        Me.PCOTPHelp.Text = "？"
        '
        'PCOTPFilePathBox
        '
        Me.PCOTPFilePathBox.Location = New System.Drawing.Point(35, 93)
        Me.PCOTPFilePathBox.Name = "PCOTPFilePathBox"
        Me.PCOTPFilePathBox.Size = New System.Drawing.Size(201, 19)
        Me.PCOTPFilePathBox.TabIndex = 6
        '
        'FileViewBT
        '
        Me.FileViewBT.Location = New System.Drawing.Point(242, 91)
        Me.FileViewBT.Name = "FileViewBT"
        Me.FileViewBT.Size = New System.Drawing.Size(30, 23)
        Me.FileViewBT.TabIndex = 7
        Me.FileViewBT.Text = "..."
        Me.FileViewBT.UseVisualStyleBackColor = True
        '
        'OTPLaunchBox
        '
        Me.OTPLaunchBox.AutoSize = True
        Me.OTPLaunchBox.Location = New System.Drawing.Point(35, 118)
        Me.OTPLaunchBox.Name = "OTPLaunchBox"
        Me.OTPLaunchBox.Size = New System.Drawing.Size(124, 16)
        Me.OTPLaunchBox.TabIndex = 8
        Me.OTPLaunchBox.Text = "ログイン時に実行する"
        Me.OTPLaunchBox.UseVisualStyleBackColor = True
        '
        'OTPLaunchHelp
        '
        Me.OTPLaunchHelp.AutoSize = True
        Me.OTPLaunchHelp.Location = New System.Drawing.Point(162, 119)
        Me.OTPLaunchHelp.Name = "OTPLaunchHelp"
        Me.OTPLaunchHelp.Size = New System.Drawing.Size(17, 12)
        Me.OTPLaunchHelp.TabIndex = 9
        Me.OTPLaunchHelp.TabStop = True
        Me.OTPLaunchHelp.Text = "？"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.OTPLaunchHelp)
        Me.Controls.Add(Me.OTPLaunchBox)
        Me.Controls.Add(Me.FileViewBT)
        Me.Controls.Add(Me.PCOTPFilePathBox)
        Me.Controls.Add(Me.PCOTPHelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OkayBT)
        Me.Controls.Add(Me.CancelBT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AutoCheckBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AutoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CancelBT As System.Windows.Forms.Button
    Friend WithEvents OkayBT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PCOTPHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents PCOTPFilePathBox As System.Windows.Forms.TextBox
    Friend WithEvents FileViewBT As System.Windows.Forms.Button
    Friend WithEvents OTPLaunchBox As System.Windows.Forms.CheckBox
    Friend WithEvents OTPLaunchHelp As System.Windows.Forms.LinkLabel
End Class
