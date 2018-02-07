<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfFixer
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
        Me.FileList = New System.Windows.Forms.ListBox()
        Me.AddFileBT = New System.Windows.Forms.Button()
        Me.FixFileList = New System.Windows.Forms.ListBox()
        Me.DeleteFileBT = New System.Windows.Forms.Button()
        Me.CancelBT = New System.Windows.Forms.Button()
        Me.FixBT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "修復しないファイル"
        '
        'FileList
        '
        Me.FileList.FormattingEnabled = True
        Me.FileList.ItemHeight = 12
        Me.FileList.Location = New System.Drawing.Point(14, 24)
        Me.FileList.Name = "FileList"
        Me.FileList.ScrollAlwaysVisible = True
        Me.FileList.Size = New System.Drawing.Size(193, 220)
        Me.FileList.TabIndex = 1
        '
        'AddFileBT
        '
        Me.AddFileBT.Location = New System.Drawing.Point(213, 73)
        Me.AddFileBT.Name = "AddFileBT"
        Me.AddFileBT.Size = New System.Drawing.Size(75, 23)
        Me.AddFileBT.TabIndex = 2
        Me.AddFileBT.Text = "→"
        Me.AddFileBT.UseVisualStyleBackColor = True
        '
        'FixFileList
        '
        Me.FixFileList.FormattingEnabled = True
        Me.FixFileList.ItemHeight = 12
        Me.FixFileList.Location = New System.Drawing.Point(294, 24)
        Me.FixFileList.Name = "FixFileList"
        Me.FixFileList.ScrollAlwaysVisible = True
        Me.FixFileList.Size = New System.Drawing.Size(193, 220)
        Me.FixFileList.TabIndex = 3
        '
        'DeleteFileBT
        '
        Me.DeleteFileBT.Location = New System.Drawing.Point(213, 102)
        Me.DeleteFileBT.Name = "DeleteFileBT"
        Me.DeleteFileBT.Size = New System.Drawing.Size(75, 23)
        Me.DeleteFileBT.TabIndex = 4
        Me.DeleteFileBT.Text = "←"
        Me.DeleteFileBT.UseVisualStyleBackColor = True
        '
        'CancelBT
        '
        Me.CancelBT.Location = New System.Drawing.Point(412, 273)
        Me.CancelBT.Name = "CancelBT"
        Me.CancelBT.Size = New System.Drawing.Size(75, 23)
        Me.CancelBT.TabIndex = 5
        Me.CancelBT.Text = "キャンセル"
        Me.CancelBT.UseVisualStyleBackColor = True
        '
        'FixBT
        '
        Me.FixBT.Location = New System.Drawing.Point(331, 273)
        Me.FixBT.Name = "FixBT"
        Me.FixBT.Size = New System.Drawing.Size(75, 23)
        Me.FixBT.TabIndex = 6
        Me.FixBT.Text = "開始"
        Me.FixBT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "修復するファイル"
        '
        'ProfFixer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 308)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FixBT)
        Me.Controls.Add(Me.CancelBT)
        Me.Controls.Add(Me.DeleteFileBT)
        Me.Controls.Add(Me.FixFileList)
        Me.Controls.Add(Me.AddFileBT)
        Me.Controls.Add(Me.FileList)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ProfFixer"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Fixer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FileList As System.Windows.Forms.ListBox
    Friend WithEvents AddFileBT As System.Windows.Forms.Button
    Friend WithEvents FixFileList As System.Windows.Forms.ListBox
    Friend WithEvents DeleteFileBT As System.Windows.Forms.Button
    Friend WithEvents CancelBT As System.Windows.Forms.Button
    Friend WithEvents FixBT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
