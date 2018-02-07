<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewWindow
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuFileBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCloseBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UrlTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.MainBrowser = New MabiAutoLauncher.AxBrowser(Me.components)
        Me.MenuHelpBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVerInfoBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserBackBT = New System.Windows.Forms.ToolStripButton()
        Me.BrowserForwardBT = New System.Windows.Forms.ToolStripButton()
        Me.BrowserRefreshBT = New System.Windows.Forms.ToolStripButton()
        Me.BrowserStopBT = New System.Windows.Forms.ToolStripButton()
        Me.BrowserMenuOpenBT = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFileBT, Me.MenuHelpBT})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(864, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuFileBT
        '
        Me.MenuFileBT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCloseBT})
        Me.MenuFileBT.Name = "MenuFileBT"
        Me.MenuFileBT.Size = New System.Drawing.Size(85, 22)
        Me.MenuFileBT.Text = "ファイル(&F)"
        '
        'MenuCloseBT
        '
        Me.MenuCloseBT.Name = "MenuCloseBT"
        Me.MenuCloseBT.Size = New System.Drawing.Size(118, 22)
        Me.MenuCloseBT.Text = "終了(&X)"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserBackBT, Me.BrowserForwardBT, Me.ToolStripSeparator1, Me.BrowserRefreshBT, Me.BrowserStopBT, Me.ToolStripSeparator2, Me.UrlTextBox, Me.BrowserMenuOpenBT})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 26)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(864, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'UrlTextBox
        '
        Me.UrlTextBox.Name = "UrlTextBox"
        Me.UrlTextBox.Size = New System.Drawing.Size(350, 25)
        '
        'MainBrowser
        '
        Me.MainBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainBrowser.Location = New System.Drawing.Point(0, 51)
        Me.MainBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MainBrowser.Name = "MainBrowser"
        Me.MainBrowser.Size = New System.Drawing.Size(864, 372)
        Me.MainBrowser.TabIndex = 2
        '
        'MenuHelpBT
        '
        Me.MenuHelpBT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuVerInfoBT})
        Me.MenuHelpBT.Name = "MenuHelpBT"
        Me.MenuHelpBT.Size = New System.Drawing.Size(75, 22)
        Me.MenuHelpBT.Text = "ヘルプ(&H)"
        '
        'MenuVerInfoBT
        '
        Me.MenuVerInfoBT.Name = "MenuVerInfoBT"
        Me.MenuVerInfoBT.Size = New System.Drawing.Size(178, 22)
        Me.MenuVerInfoBT.Text = "バージョン情報(&A)"
        '
        'BrowserBackBT
        '
        Me.BrowserBackBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserBackBT.Image = Global.MabiAutoLauncher.My.Resources.Resources.Back
        Me.BrowserBackBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserBackBT.Name = "BrowserBackBT"
        Me.BrowserBackBT.Size = New System.Drawing.Size(23, 22)
        Me.BrowserBackBT.Text = "戻る"
        '
        'BrowserForwardBT
        '
        Me.BrowserForwardBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserForwardBT.Image = Global.MabiAutoLauncher.My.Resources.Resources.Go
        Me.BrowserForwardBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserForwardBT.Name = "BrowserForwardBT"
        Me.BrowserForwardBT.Size = New System.Drawing.Size(23, 22)
        Me.BrowserForwardBT.Text = "進む"
        '
        'BrowserRefreshBT
        '
        Me.BrowserRefreshBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserRefreshBT.Image = Global.MabiAutoLauncher.My.Resources.Resources.Refresh
        Me.BrowserRefreshBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserRefreshBT.Name = "BrowserRefreshBT"
        Me.BrowserRefreshBT.Size = New System.Drawing.Size(23, 22)
        Me.BrowserRefreshBT.Text = "更新"
        '
        'BrowserStopBT
        '
        Me.BrowserStopBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserStopBT.Image = Global.MabiAutoLauncher.My.Resources.Resources._Stop
        Me.BrowserStopBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserStopBT.Name = "BrowserStopBT"
        Me.BrowserStopBT.Size = New System.Drawing.Size(23, 22)
        Me.BrowserStopBT.Text = "中止"
        '
        'BrowserMenuOpenBT
        '
        Me.BrowserMenuOpenBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrowserMenuOpenBT.Image = Global.MabiAutoLauncher.My.Resources.Resources.Open
        Me.BrowserMenuOpenBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserMenuOpenBT.Name = "BrowserMenuOpenBT"
        Me.BrowserMenuOpenBT.Size = New System.Drawing.Size(23, 22)
        Me.BrowserMenuOpenBT.Text = "ToolStripButton1"
        '
        'NewWindow
        '
        Me.ClientSize = New System.Drawing.Size(864, 423)
        Me.Controls.Add(Me.MainBrowser)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NewWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MainBrowser As MabiAutoLauncher.AxBrowser
    Friend WithEvents MenuFileBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCloseBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserBackBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserForwardBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserRefreshBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserStopBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UrlTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BrowserMenuOpenBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuHelpBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuVerInfoBT As System.Windows.Forms.ToolStripMenuItem
End Class
