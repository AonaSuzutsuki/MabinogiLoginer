<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.BrowserMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BrowserMenuNewWinBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BrowserMenuCopyBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserMenuLinkCopyBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenDefBrowser = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginBT = New System.Windows.Forms.Button()
        Me.AccountList = New System.Windows.Forms.ListBox()
        Me.ListMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListMenuAccountAddBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListMenuAccountEditBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListMenuAccountDelBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GameStartBT = New System.Windows.Forms.Button()
        Me.LogoutBT = New System.Windows.Forms.Button()
        Me.MainBrowser = New MabiAutoLauncher.AxBrowser(Me.components)
        Me.BrowserStatusMenu = New System.Windows.Forms.StatusStrip()
        Me.LoadingStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BrowserTripMenu = New System.Windows.Forms.ToolStrip()
        Me.BrowserBackBT = New System.Windows.Forms.ToolStripButton()
        Me.BrowserForwardBT = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BrowserRefreshBT = New System.Windows.Forms.ToolStripButton()
        Me.BrowserStopBT = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TripMabinogiHomeBT = New System.Windows.Forms.ToolStripButton()
        Me.TripEiyudenHomeBT = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MabiWikiBT = New System.Windows.Forms.ToolStripButton()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.MainMenuFileBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuExitBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuSettingsBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuProfileFixerBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuUpdateBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuHelpBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuVersioninfoBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadinStatusLabelTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.MainMenuNewWindowBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserMenu.SuspendLayout()
        Me.ListMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.BrowserStatusMenu.SuspendLayout()
        Me.BrowserTripMenu.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowserMenu
        '
        Me.BrowserMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserMenuNewWinBT, Me.ToolStripSeparator5, Me.BrowserMenuCopyBT, Me.BrowserMenuLinkCopyBT, Me.ToolStripSeparator4, Me.OpenDefBrowser})
        Me.BrowserMenu.Name = "BrowserMenu"
        Me.BrowserMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BrowserMenu.Size = New System.Drawing.Size(197, 104)
        '
        'BrowserMenuNewWinBT
        '
        Me.BrowserMenuNewWinBT.Name = "BrowserMenuNewWinBT"
        Me.BrowserMenuNewWinBT.Size = New System.Drawing.Size(196, 22)
        Me.BrowserMenuNewWinBT.Text = "新規ウィンドウ"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(193, 6)
        '
        'BrowserMenuCopyBT
        '
        Me.BrowserMenuCopyBT.Name = "BrowserMenuCopyBT"
        Me.BrowserMenuCopyBT.Size = New System.Drawing.Size(196, 22)
        Me.BrowserMenuCopyBT.Text = "コピー"
        '
        'BrowserMenuLinkCopyBT
        '
        Me.BrowserMenuLinkCopyBT.Name = "BrowserMenuLinkCopyBT"
        Me.BrowserMenuLinkCopyBT.Size = New System.Drawing.Size(196, 22)
        Me.BrowserMenuLinkCopyBT.Text = "リンクのコピー"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(193, 6)
        '
        'OpenDefBrowser
        '
        Me.OpenDefBrowser.Name = "OpenDefBrowser"
        Me.OpenDefBrowser.Size = New System.Drawing.Size(196, 22)
        Me.OpenDefBrowser.Text = "規定のブラウザで開く"
        '
        'LoginBT
        '
        Me.LoginBT.Location = New System.Drawing.Point(14, 68)
        Me.LoginBT.Name = "LoginBT"
        Me.LoginBT.Size = New System.Drawing.Size(75, 23)
        Me.LoginBT.TabIndex = 2
        Me.LoginBT.Text = "ログイン"
        Me.LoginBT.UseVisualStyleBackColor = True
        '
        'AccountList
        '
        Me.AccountList.ContextMenuStrip = Me.ListMenu
        Me.AccountList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountList.FormattingEnabled = True
        Me.AccountList.ItemHeight = 12
        Me.AccountList.Location = New System.Drawing.Point(0, 0)
        Me.AccountList.Name = "AccountList"
        Me.AccountList.Size = New System.Drawing.Size(185, 404)
        Me.AccountList.TabIndex = 3
        '
        'ListMenu
        '
        Me.ListMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListMenuAccountAddBT, Me.ListMenuAccountEditBT, Me.ListMenuAccountDelBT})
        Me.ListMenu.Name = "ContextMenuStrip1"
        Me.ListMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ListMenu.ShowCheckMargin = True
        Me.ListMenu.ShowImageMargin = False
        Me.ListMenu.Size = New System.Drawing.Size(173, 70)
        '
        'ListMenuAccountAddBT
        '
        Me.ListMenuAccountAddBT.Name = "ListMenuAccountAddBT"
        Me.ListMenuAccountAddBT.Size = New System.Drawing.Size(172, 22)
        Me.ListMenuAccountAddBT.Text = "アカウントの追加"
        '
        'ListMenuAccountEditBT
        '
        Me.ListMenuAccountEditBT.Name = "ListMenuAccountEditBT"
        Me.ListMenuAccountEditBT.Size = New System.Drawing.Size(172, 22)
        Me.ListMenuAccountEditBT.Text = "アカウントの編集"
        '
        'ListMenuAccountDelBT
        '
        Me.ListMenuAccountDelBT.Name = "ListMenuAccountDelBT"
        Me.ListMenuAccountDelBT.Size = New System.Drawing.Size(172, 22)
        Me.ListMenuAccountDelBT.Text = "アカウントの削除"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 26)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MainBrowser)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BrowserStatusMenu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BrowserTripMenu)
        Me.SplitContainer1.Size = New System.Drawing.Size(861, 511)
        Me.SplitContainer1.SplitterDistance = 185
        Me.SplitContainer1.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.AccountList)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GameStartBT)
        Me.SplitContainer2.Panel2.Controls.Add(Me.LoginBT)
        Me.SplitContainer2.Panel2.Controls.Add(Me.LogoutBT)
        Me.SplitContainer2.Size = New System.Drawing.Size(185, 511)
        Me.SplitContainer2.SplitterDistance = 404
        Me.SplitContainer2.TabIndex = 5
        '
        'GameStartBT
        '
        Me.GameStartBT.Location = New System.Drawing.Point(14, 14)
        Me.GameStartBT.Name = "GameStartBT"
        Me.GameStartBT.Size = New System.Drawing.Size(156, 43)
        Me.GameStartBT.TabIndex = 5
        Me.GameStartBT.Text = "ゲームスタート"
        Me.GameStartBT.UseVisualStyleBackColor = True
        '
        'LogoutBT
        '
        Me.LogoutBT.Location = New System.Drawing.Point(95, 68)
        Me.LogoutBT.Name = "LogoutBT"
        Me.LogoutBT.Size = New System.Drawing.Size(75, 23)
        Me.LogoutBT.TabIndex = 4
        Me.LogoutBT.Text = "ログアウト"
        Me.LogoutBT.UseVisualStyleBackColor = True
        '
        'MainBrowser
        '
        Me.MainBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainBrowser.Location = New System.Drawing.Point(0, 25)
        Me.MainBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MainBrowser.Name = "MainBrowser"
        Me.MainBrowser.Size = New System.Drawing.Size(672, 463)
        Me.MainBrowser.TabIndex = 3
        '
        'BrowserStatusMenu
        '
        Me.BrowserStatusMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadingStatusLabel})
        Me.BrowserStatusMenu.Location = New System.Drawing.Point(0, 488)
        Me.BrowserStatusMenu.Name = "BrowserStatusMenu"
        Me.BrowserStatusMenu.Size = New System.Drawing.Size(672, 23)
        Me.BrowserStatusMenu.TabIndex = 2
        Me.BrowserStatusMenu.Text = "StatusStrip1"
        '
        'LoadingStatusLabel
        '
        Me.LoadingStatusLabel.Name = "LoadingStatusLabel"
        Me.LoadingStatusLabel.Size = New System.Drawing.Size(105, 18)
        Me.LoadingStatusLabel.Text = "{LoadingStatus}"
        '
        'BrowserTripMenu
        '
        Me.BrowserTripMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowserBackBT, Me.BrowserForwardBT, Me.ToolStripSeparator1, Me.BrowserRefreshBT, Me.BrowserStopBT, Me.ToolStripSeparator2, Me.TripMabinogiHomeBT, Me.TripEiyudenHomeBT, Me.ToolStripSeparator3, Me.MabiWikiBT})
        Me.BrowserTripMenu.Location = New System.Drawing.Point(0, 0)
        Me.BrowserTripMenu.Name = "BrowserTripMenu"
        Me.BrowserTripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BrowserTripMenu.Size = New System.Drawing.Size(672, 25)
        Me.BrowserTripMenu.TabIndex = 1
        Me.BrowserTripMenu.Text = "ToolStrip1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TripMabinogiHomeBT
        '
        Me.TripMabinogiHomeBT.Image = Global.MabiAutoLauncher.My.Resources.Resources._48px_MabinogiIcon
        Me.TripMabinogiHomeBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TripMabinogiHomeBT.Name = "TripMabinogiHomeBT"
        Me.TripMabinogiHomeBT.Size = New System.Drawing.Size(100, 22)
        Me.TripMabinogiHomeBT.Text = "マビノギ公式"
        '
        'TripEiyudenHomeBT
        '
        Me.TripEiyudenHomeBT.Image = Global.MabiAutoLauncher.My.Resources.Resources.eiyuden
        Me.TripEiyudenHomeBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TripEiyudenHomeBT.Name = "TripEiyudenHomeBT"
        Me.TripEiyudenHomeBT.Size = New System.Drawing.Size(88, 22)
        Me.TripEiyudenHomeBT.Text = "英雄伝公式"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'MabiWikiBT
        '
        Me.MabiWikiBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MabiWikiBT.Image = CType(resources.GetObject("MabiWikiBT.Image"), System.Drawing.Image)
        Me.MabiWikiBT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MabiWikiBT.Name = "MabiWikiBT"
        Me.MabiWikiBT.Size = New System.Drawing.Size(89, 22)
        Me.MabiWikiBT.Text = "マビノギ Wiki"
        Me.MabiWikiBT.ToolTipText = "マビノギ Wiki(新規ウィンドウで開きます)"
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuFileBT, Me.MainMenuToolBT, Me.MainMenuHelpBT})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu.Size = New System.Drawing.Size(861, 26)
        Me.MainMenu.TabIndex = 5
        Me.MainMenu.Text = "MenuStrip1"
        '
        'MainMenuFileBT
        '
        Me.MainMenuFileBT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuNewWindowBT, Me.ToolStripSeparator6, Me.MainMenuExitBT})
        Me.MainMenuFileBT.Name = "MainMenuFileBT"
        Me.MainMenuFileBT.Size = New System.Drawing.Size(85, 22)
        Me.MainMenuFileBT.Text = "ファイル(&F)"
        '
        'MainMenuExitBT
        '
        Me.MainMenuExitBT.Name = "MainMenuExitBT"
        Me.MainMenuExitBT.Size = New System.Drawing.Size(160, 22)
        Me.MainMenuExitBT.Text = "終了(&X)"
        '
        'MainMenuToolBT
        '
        Me.MainMenuToolBT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuSettingsBT, Me.MainMenuProfileFixerBT, Me.MainMenuUpdateBT})
        Me.MainMenuToolBT.Name = "MainMenuToolBT"
        Me.MainMenuToolBT.Size = New System.Drawing.Size(56, 22)
        Me.MainMenuToolBT.Text = "ツール"
        '
        'MainMenuSettingsBT
        '
        Me.MainMenuSettingsBT.Name = "MainMenuSettingsBT"
        Me.MainMenuSettingsBT.Size = New System.Drawing.Size(152, 22)
        Me.MainMenuSettingsBT.Text = "設定"
        '
        'MainMenuProfileFixerBT
        '
        Me.MainMenuProfileFixerBT.Name = "MainMenuProfileFixerBT"
        Me.MainMenuProfileFixerBT.Size = New System.Drawing.Size(152, 22)
        Me.MainMenuProfileFixerBT.Text = "Profile Fixer"
        '
        'MainMenuUpdateBT
        '
        Me.MainMenuUpdateBT.Name = "MainMenuUpdateBT"
        Me.MainMenuUpdateBT.Size = New System.Drawing.Size(152, 22)
        Me.MainMenuUpdateBT.Text = "アップデート"
        '
        'MainMenuHelpBT
        '
        Me.MainMenuHelpBT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuVersioninfoBT})
        Me.MainMenuHelpBT.Name = "MainMenuHelpBT"
        Me.MainMenuHelpBT.Size = New System.Drawing.Size(75, 22)
        Me.MainMenuHelpBT.Text = "ヘルプ(&H)"
        '
        'MainMenuVersioninfoBT
        '
        Me.MainMenuVersioninfoBT.Name = "MainMenuVersioninfoBT"
        Me.MainMenuVersioninfoBT.Size = New System.Drawing.Size(178, 22)
        Me.MainMenuVersioninfoBT.Text = "バージョン情報(&A)"
        '
        'LoadinStatusLabelTimer
        '
        Me.LoadinStatusLabelTimer.Interval = 2000
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(157, 6)
        '
        'MainMenuNewWindowBT
        '
        Me.MainMenuNewWindowBT.Name = "MainMenuNewWindowBT"
        Me.MainMenuNewWindowBT.Size = New System.Drawing.Size(160, 22)
        Me.MainMenuNewWindowBT.Text = "新規ウィンドウ"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 537)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mabinogi Login"
        Me.BrowserMenu.ResumeLayout(False)
        Me.ListMenu.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.BrowserStatusMenu.ResumeLayout(False)
        Me.BrowserStatusMenu.PerformLayout()
        Me.BrowserTripMenu.ResumeLayout(False)
        Me.BrowserTripMenu.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginBT As System.Windows.Forms.Button
    Friend WithEvents AccountList As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LogoutBT As System.Windows.Forms.Button
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MainMenuFileBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuExitBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuHelpBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuVersioninfoBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListMenuAccountAddBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMenuAccountDelBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMenuAccountEditBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents BrowserTripMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents MainMenuToolBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuSettingsBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuUpdateBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TripMabinogiHomeBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BrowserMenuCopyBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserMenuLinkCopyBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TripEiyudenHomeBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenuProfileFixerBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameStartBT As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MabiWikiBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenDefBrowser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserStatusMenu As System.Windows.Forms.StatusStrip
    Friend WithEvents LoadingStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LoadinStatusLabelTimer As System.Windows.Forms.Timer
    Friend WithEvents BrowserMenuNewWinBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MainBrowser As MabiAutoLauncher.AxBrowser
    Friend WithEvents BrowserBackBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserForwardBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BrowserRefreshBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents BrowserStopBT As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainMenuNewWindowBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
