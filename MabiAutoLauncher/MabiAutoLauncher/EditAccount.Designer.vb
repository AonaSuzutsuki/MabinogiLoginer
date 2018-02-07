<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAccount
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowNameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.CancelBT = New System.Windows.Forms.Button()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OTPNothingRadio = New System.Windows.Forms.RadioButton()
        Me.OTPPCRadio = New System.Windows.Forms.RadioButton()
        Me.OTPOtherRadio = New System.Windows.Forms.RadioButton()
        Me.ShowNameToolTrip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShowNameHelpBT = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "表示名"
        '
        'ShowNameBox
        '
        Me.ShowNameBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ShowNameBox.Location = New System.Drawing.Point(33, 24)
        Me.ShowNameBox.Name = "ShowNameBox"
        Me.ShowNameBox.Size = New System.Drawing.Size(239, 19)
        Me.ShowNameBox.TabIndex = 1
        Me.ShowNameToolTrip.SetToolTip(Me.ShowNameBox, "1～31のASCII文字・Unicode文字・引用符("""")・不等号(<と>)・パイプ(|)・null(\0)・コロン(:)・アスタリスク(*)・クエスチョンマー" & _
                "ク(?)・スラッシュ(/)・バックスラッシュ(\)は使用できません。")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "アカウント名・ID"
        '
        'IDBox
        '
        Me.IDBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.IDBox.Location = New System.Drawing.Point(33, 77)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(239, 19)
        Me.IDBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "パスワード"
        '
        'PasswordBox
        '
        Me.PasswordBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.PasswordBox.Location = New System.Drawing.Point(33, 114)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(239, 19)
        Me.PasswordBox.TabIndex = 5
        '
        'CancelBT
        '
        Me.CancelBT.Location = New System.Drawing.Point(197, 258)
        Me.CancelBT.Name = "CancelBT"
        Me.CancelBT.Size = New System.Drawing.Size(75, 23)
        Me.CancelBT.TabIndex = 6
        Me.CancelBT.Text = "キャンセル"
        Me.CancelBT.UseVisualStyleBackColor = True
        '
        'SaveBT
        '
        Me.SaveBT.Location = New System.Drawing.Point(116, 258)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(75, 23)
        Me.SaveBT.TabIndex = 7
        Me.SaveBT.Text = "保存"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ワンタイムパスワード方式"
        '
        'OTPNothingRadio
        '
        Me.OTPNothingRadio.AutoSize = True
        Me.OTPNothingRadio.Checked = True
        Me.OTPNothingRadio.Location = New System.Drawing.Point(33, 165)
        Me.OTPNothingRadio.Name = "OTPNothingRadio"
        Me.OTPNothingRadio.Size = New System.Drawing.Size(95, 16)
        Me.OTPNothingRadio.TabIndex = 9
        Me.OTPNothingRadio.TabStop = True
        Me.OTPNothingRadio.Text = "利用していない"
        Me.OTPNothingRadio.UseVisualStyleBackColor = True
        '
        'OTPPCRadio
        '
        Me.OTPPCRadio.AutoSize = True
        Me.OTPPCRadio.Location = New System.Drawing.Point(33, 187)
        Me.OTPPCRadio.Name = "OTPPCRadio"
        Me.OTPPCRadio.Size = New System.Drawing.Size(85, 16)
        Me.OTPPCRadio.TabIndex = 10
        Me.OTPPCRadio.TabStop = True
        Me.OTPPCRadio.Text = "PC型トークン"
        Me.OTPPCRadio.UseVisualStyleBackColor = True
        '
        'OTPOtherRadio
        '
        Me.OTPOtherRadio.AutoSize = True
        Me.OTPOtherRadio.Location = New System.Drawing.Point(33, 209)
        Me.OTPOtherRadio.Name = "OTPOtherRadio"
        Me.OTPOtherRadio.Size = New System.Drawing.Size(67, 16)
        Me.OTPOtherRadio.TabIndex = 11
        Me.OTPOtherRadio.TabStop = True
        Me.OTPOtherRadio.Text = "それ以外"
        Me.OTPOtherRadio.UseVisualStyleBackColor = True
        '
        'ShowNameHelpBT
        '
        Me.ShowNameHelpBT.AutoSize = True
        Me.ShowNameHelpBT.Location = New System.Drawing.Point(59, 9)
        Me.ShowNameHelpBT.Name = "ShowNameHelpBT"
        Me.ShowNameHelpBT.Size = New System.Drawing.Size(19, 12)
        Me.ShowNameHelpBT.TabIndex = 12
        Me.ShowNameHelpBT.TabStop = True
        Me.ShowNameHelpBT.Text = " * "
        '
        'EditAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 293)
        Me.Controls.Add(Me.ShowNameHelpBT)
        Me.Controls.Add(Me.OTPOtherRadio)
        Me.Controls.Add(Me.OTPPCRadio)
        Me.Controls.Add(Me.OTPNothingRadio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SaveBT)
        Me.Controls.Add(Me.CancelBT)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShowNameBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditAccount"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "アカウント"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShowNameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IDBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PasswordBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelBT As System.Windows.Forms.Button
    Friend WithEvents SaveBT As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OTPNothingRadio As System.Windows.Forms.RadioButton
    Friend WithEvents OTPPCRadio As System.Windows.Forms.RadioButton
    Friend WithEvents OTPOtherRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ShowNameToolTrip As System.Windows.Forms.ToolTip
    Friend WithEvents ShowNameHelpBT As System.Windows.Forms.LinkLabel
End Class
