Imports System.Net
Imports System.IO
Imports System.Text

Public Class MainForm

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim iniclass As New INI

        If Not (game = "") Then
            iniclass.WriteInt("Main", "Game", game, My.Application.Info.DirectoryPath & "\settings.ini")
        End If

        Select Case Me.WindowState
            Case FormWindowState.Normal
                iniclass.WriteInt("Main", "Width", Me.Width, My.Application.Info.DirectoryPath & "\settings.ini")
                iniclass.WriteInt("Main", "Height", Me.Height, My.Application.Info.DirectoryPath & "\settings.ini")
            Case FormWindowState.Minimized

            Case FormWindowState.Maximized

        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iniclass As New INI

        Dim iniWidth As Integer
        Dim iniHeight As Integer
        iniWidth = iniclass.GetInt("Main", "Width", Me.Width, My.Application.Info.DirectoryPath & "\settings.ini")
        iniHeight = iniclass.GetInt("Main", "Height", Me.Height, My.Application.Info.DirectoryPath & "\settings.ini")
        Me.Size = New Size(iniWidth, iniHeight)
        Dim ScreenWidth As Integer
        Dim ScreenHeight As Integer
        ScreenWidth = SystemInformation.WorkingArea.Width
        ScreenHeight = SystemInformation.WorkingArea.Height
        Me.Location = New Point((ScreenWidth - Me.Width) / 2, _
       (ScreenHeight - Me.Height) / 2)

        LoadingStatusLabel.Text = ""

        Try
            If (System.IO.Directory.Exists(My.Application.Info.DirectoryPath & "\account")) Then
                'Dim base64class As New Base64
                'Dim basepass As String = base64class.Encoding("pending", "")
                'Dim idstr As String = base64class.Encoding("ID", basepass)
                'Dim pwstr As String = base64class.Encoding("PW", basepass)

                Dim stPrompt As String = String.Empty
                'Dim encshowname As String
                Dim decshowname As String
                For Each stFilePath As String In System.IO.Directory.GetFiles(My.Application.Info.DirectoryPath & "\account", "*")
                    'encshowname = iniclass.GetStr("Data", "NAME", Nothing, stFilePath)
                    decshowname = System.IO.Path.GetFileNameWithoutExtension(stFilePath) 'base64class.Decoding(encshowname, basepass)
                    AccountList.Items.Add(decshowname)
                Next stFilePath
            End If
        Catch exFormatEx As System.FormatException
            MessageBox.Show("データの読み込みに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("不明なエラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MainBrowser.ScriptErrorsSuppressed = True
        LoginBT.Enabled = False
        LogoutBT.Enabled = False
        GameStartBT.Enabled = False

        Dim gamestr As String = iniclass.GetStr("Main", "Game", Nothing, My.Application.Info.DirectoryPath & "\settings.ini")
        If (gamestr = "mabinogi") Then
            MainBrowser.Navigate("http://mabinogi.nexon.co.jp/")
        ElseIf (gamestr = "eiyuden") Then
            MainBrowser.Navigate("http://heroes.nexon.co.jp/")
        Else
            MainBrowser.Navigate("http://mabinogi.nexon.co.jp/")
        End If

        Dim UpdateNum As Integer = iniclass.GetInt("Main", "AutoUpdate", 1, My.Application.Info.DirectoryPath & "\settings.ini")
        If (UpdateNum = 1) Then
            CheckStart()
        End If
    End Sub

    'Web Multi Thread
    Dim webt As New System.Threading.Thread( _
            New System.Threading.ThreadStart( _
            AddressOf websubt))
    Private Sub websubt()
        MainBrowser.Navigate("http://mabinogi.nexon.co.jp/")
        t.Abort()
    End Sub

    '起動アップデートチェック
    Dim t As New System.Threading.Thread( _
            New System.Threading.ThreadStart( _
            AddressOf UpdateCheckback))
    Public AutoInt As Integer

    Private Sub CheckStart()
        Try
            t.IsBackground = True
            t.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateCheckback()
        UpdateCheckNoAlert()
        t.Abort()
    End Sub

    Private Sub UpdateCheckNoAlert()
        Dim version As String
        Try
            Using wc As New System.Net.WebClient()
                wc.DownloadFile("http://kimamaningen.futene.net/HTML/Downloads/TGSUpdate/MabiLoginer/version.txt", "version.txt")
            End Using
        Catch ex As Exception

        End Try

        Try
            Using sr As New System.IO.StreamReader("version.txt")
                version = sr.ReadToEnd()
            End Using
            If (My.Application.Info.Version.ToString & "b" = version) Then
                Me.Invoke(New MethodInvoker(Sub()
                                                AutoInt = 0
                                            End Sub))
                System.IO.File.Delete("version.txt")
            Else
                MsgBox("アップデートがあります。", vbInformation, "お知らせ")
                Me.Invoke(New MethodInvoker(Sub()
                                                AutoInt = 1
                                            End Sub))
                System.IO.File.Delete("version.txt")
            End If
        Catch

        End Try
    End Sub


    Private Function StringSearchMethod(ByVal txt As String, _
                                       ByVal mototxt As String, _
                                       ByVal int As Integer) As String
        Dim SearchMethodData As New System.Text.RegularExpressions.Regex(txt, _
            System.Text.RegularExpressions.RegexOptions.IgnoreCase Or _
            System.Text.RegularExpressions.RegexOptions.Singleline)

        Dim SearchMethodData2 As System.Text.RegularExpressions.MatchCollection = _
            SearchMethodData.Matches(mototxt)

        For Each SearchMethod As System.Text.RegularExpressions.Match In SearchMethodData2
            Return SearchMethod.Groups(int).Value
        Next

        Return ""
    End Function

    Private Sub GameStartBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameStartBT.Click
        If (game = "mabinogi") Then
            MainBrowser.Document.InvokeScript("LaunchGame")
        ElseIf (game = "eiyuden") Then
            MainBrowser.Document.InvokeScript("LaunchGame")
        Else

        End If
    End Sub

    Dim game As String
    Private Sub LoginBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBT.Click
        Try
            If (game = "mabinogi") Then
                GenPW()
                MabinogiLogin()
            ElseIf (game = "eiyuden") Then
                GenPW()
                EiyudenLogin()
            End If
        Catch exNullRef As System.NullReferenceException
            MessageBox.Show("ログインフォームが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("不明なエラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim PWD As String
    Private Sub GenPW()
        PWD = PasswordClass.ReturnPassword()
    End Sub

    Private Sub MabinogiLogin()
        Dim id As String = StringSearchMethod("tabindex=""1"" id=""login(.*?)""", MainBrowser.DocumentText, 1)
        Dim pw As String = StringSearchMethod("tabindex=""2"" id=""login(.*?)""", MainBrowser.DocumentText, 1)

        Dim base64class As New Base64
        Dim iniclass As New INI

        Dim basepass As String = base64class.Encoding(PWD, "")
        Dim getfilename As String = AccountList.SelectedItem
        Dim encfilename As String = getfilename 'base64class.Encoding(getfilename, basepass)

        Dim enciddata As String = iniclass.GetStr("Data", "ID", Nothing, My.Application.Info.DirectoryPath & "\account\" & encfilename)
        Dim encpwdata As String = iniclass.GetStr("Data", "PW", Nothing, My.Application.Info.DirectoryPath & "\account\" & encfilename)

        MainBrowser.Document.All.Item("login" + id).InnerText = base64class.Decoding(enciddata, basepass)
        MainBrowser.Document.All.Item("login" + pw).InnerText = base64class.Decoding(encpwdata, basepass)

        System.Threading.Thread.Sleep(1000)

        MainBrowser.Document.InvokeScript("checkFrmLogin")

        Dim otppath As String = iniclass.GetStr("Main", "PCOTPPATH", Nothing, My.Application.Info.DirectoryPath & "\settings.ini")
        Dim otpradio As Integer = iniclass.GetInt("Data", "OTP", 0, My.Application.Info.DirectoryPath & "\account\" & encfilename)
        Dim otplaunch As Integer = iniclass.GetInt("Main", "PCOTPLAUNCH", 0, My.Application.Info.DirectoryPath & "\settings.ini")
        If (otplaunch = 1) Then
            If (otpradio = 1) Then
                Try
                    System.Diagnostics.Process.Start(otppath)
                Catch Win32Ex As System.ComponentModel.Win32Exception
                    MessageBox.Show("トークンファイルの起動ができません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("不明なエラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

        LogoutBT.Enabled = True
    End Sub

    Private Sub EiyudenLogin()
        Dim base64class As New Base64
        Dim iniclass As New INI

        Dim basepass As String = base64class.Encoding(PWD, "")
        Dim getfilename As String = AccountList.SelectedItem
        Dim encfilename As String = getfilename 'base64class.Encoding(getfilename, basepass)

        Dim enciddata As String = iniclass.GetStr("Data", "ID", Nothing, My.Application.Info.DirectoryPath & "\account\" & encfilename)
        Dim encpwdata As String = iniclass.GetStr("Data", "PW", Nothing, My.Application.Info.DirectoryPath & "\account\" & encfilename)

        MainBrowser.Document.All.Item("loginid").InnerText = base64class.Decoding(enciddata, basepass)
        MainBrowser.Document.All.Item("password").InnerText = base64class.Decoding(encpwdata, basepass)

        System.Threading.Thread.Sleep(1000)

        MainBrowser.Document.InvokeScript("DoLogin")

        Dim otppath As String = iniclass.GetStr("Main", "PCOTPPATH", Nothing, My.Application.Info.DirectoryPath & "\settings.ini")
        Dim otpradio As Integer = iniclass.GetInt("Data", "OTP", 0, My.Application.Info.DirectoryPath & "\account\" & encfilename)
        Dim otplaunch As Integer = iniclass.GetInt("Main", "PCOTPLAUNCH", 0, My.Application.Info.DirectoryPath & "\settings.ini")
        If (otplaunch = 1) Then
            If (otpradio = 1) Then
                Try
                    System.Diagnostics.Process.Start(otppath)
                Catch Win32Ex As System.ComponentModel.Win32Exception
                    MessageBox.Show("トークンファイルの起動ができません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("不明なエラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

        LogoutBT.Enabled = True
    End Sub


    Private Sub LogoutBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutBT.Click
        If (game = "mabinogi") Then
            MainBrowser.Navigate("http://mabinogi.nexon.co.jp/6th/include/module/_logout.asp")
        ElseIf (game = "eiyuden") Then
            MainBrowser.Navigate("http://heroes.nexon.co.jp/login/logout.aspx")
        End If
    End Sub

    Private Sub AccountList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountList.SelectedIndexChanged
        If (MainBrowser.Url.ToString.IndexOf("mabinogi.nexon.co.jp") > 0) Then
            If (StringSearchMethod("tabindex=""1"" id=""login(.*?)""", MainBrowser.DocumentText, 1) = vbNullString) Then
                LoginBT.Enabled = False
                LogoutBT.Enabled = True
            Else
                If (AccountList.SelectedIndex > -1) Then
                    LoginBT.Enabled = True
                Else
                    LoginBT.Enabled = False
                End If
                LogoutBT.Enabled = False
            End If
        ElseIf (MainBrowser.Url.ToString.IndexOf("heroes.nexon.co.jp") > 0) Then
            If (MainBrowser.DocumentText.IndexOf("class=""login-box""") < 0) Then
                LoginBT.Enabled = False
                LogoutBT.Enabled = True
            Else
                If (AccountList.SelectedIndex > -1) Then
                    LoginBT.Enabled = True
                Else
                    LoginBT.Enabled = False
                End If
                LogoutBT.Enabled = False
            End If
        Else
            LoginBT.Enabled = False
            LogoutBT.Enabled = False
        End If
    End Sub

    Private Sub MainBrowser_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles MainBrowser.Navigating
        LoadingStatusLabel.ForeColor = Color.Red
        LoadingStatusLabel.Text = "読み込み中"
    End Sub

    Private Sub MainBrowser_NewWindow2(ByVal sender As Object, ByVal e As WebBrowserNewWindow2EventArgs) Handles MainBrowser.NewWindow2
        NewWindow(Nothing, e)
        Dim NW As New NewWindow
        NW.Focus()
    End Sub

    Private Sub NewWindow(Optional ByVal url As String = Nothing, Optional ByVal e As WebBrowserNewWindow2EventArgs = Nothing)
        Dim NW As New NewWindow
        'Dim AxBrowser1 As New AxBrowser

        If Not (url = Nothing) Then
            Dim u As New Uri(url)
            NW.MainBrowser.Url = u
        End If

        'NW.Controls.Add(AxBrowser1)
        NW.Show()

        '新しいウィンドウが開くのを抑制
        Try
            e.ppDisp = NW.MainBrowser.Application
            NW.MainBrowser.RegisterAsBrowser = True
        Catch

        End Try
    End Sub

    Private Sub MainBrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles MainBrowser.DocumentCompleted
        'sender: navigateしたurl
        'e: フレームのurl
        'たくさん読み込まれれるため最後に呼ばれるナビゲートURLと一致するかを調べる
        If Not (sender.url.ToString = e.Url.ToString) Then
            Exit Sub
        End If

        LoadingStatusLabel.ForeColor = Color.Blue
        LoadingStatusLabel.Text = "読み込み完了"
        LoadinStatusLabelTimer.Start()

        If (sender.url.ToString.IndexOf("mabinogi.nexon.co.jp") > 0) Then
            game = "mabinogi"
            If (StringSearchMethod("tabindex=""1"" id=""login(.*?)""", MainBrowser.DocumentText, 1) = vbNullString) Then
                LoginBT.Enabled = False
                LogoutBT.Enabled = True
                GameStartBT.Enabled = True
            Else
                If (AccountList.SelectedIndex > -1) Then
                    LoginBT.Enabled = True
                Else
                    LoginBT.Enabled = False
                End If
                LogoutBT.Enabled = False
                GameStartBT.Enabled = False
            End If
        ElseIf (sender.url.ToString.IndexOf("heroes.nexon.co.jp") > 0) Then
            game = "eiyuden"
            If (MainBrowser.DocumentText.IndexOf("class=""login-box""") < 0) Then
                LoginBT.Enabled = False
                LogoutBT.Enabled = True
                GameStartBT.Enabled = True
            Else
                If (AccountList.SelectedIndex > -1) Then
                    LoginBT.Enabled = True
                Else
                    LoginBT.Enabled = False
                End If
                LogoutBT.Enabled = False
                GameStartBT.Enabled = False
            End If
        Else
            game = Nothing
            LoginBT.Enabled = False
            LogoutBT.Enabled = False
            GameStartBT.Enabled = False
        End If

        Try
            Dim iniclass As New INI
            If (e.Url.ToString() = "http://mabinogi.nexon.co.jp/6th/security/mabinogiLoginPass.asp") Then
            ElseIf (e.Url.ToString() = "http://heroes.nexon.co.jp/login/login_pass.aspx") Then
            Else
                Dim otppath As String = iniclass.GetStr("Main", "PCOTPPATH", Nothing, My.Application.Info.DirectoryPath & "\settings.ini")
                otppath = System.IO.Path.GetFileName(otppath)
                otppath = System.IO.Path.GetFileNameWithoutExtension(otppath)
                Dim ps As System.Diagnostics.Process() = System.Diagnostics.Process.GetProcessesByName(otppath)

                For Each p As System.Diagnostics.Process In ps
                    p.Kill()
                Next
            End If
        Catch

        End Try

        If (MainBrowser.CanGoBack = True) Then
            BrowserBackBT.Enabled = True
        Else
            BrowserBackBT.Enabled = False
        End If

        If (MainBrowser.CanGoForward = True) Then
            BrowserForwardBT.Enabled = True
        Else
            BrowserForwardBT.Enabled = False
        End If
    End Sub

    Private Sub LoadinStatusLabelTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadinStatusLabelTimer.Tick
        LoadingStatusLabel.ForeColor = Color.Black
        LoadingStatusLabel.Text = ""
        LoadinStatusLabelTimer.Stop()
    End Sub


    'BrowserTripMenu
    Private Sub BrowserBackBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserBackBT.Click
        MainBrowser.GoBack()
    End Sub

    Private Sub BrowserForwardBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserForwardBT.Click
        MainBrowser.GoForward()
    End Sub

    Private Sub BrowserRefreshBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserRefreshBT.Click
        MainBrowser.Refresh()
    End Sub

    Private Sub BrowserStopBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserStopBT.Click
        MainBrowser.Stop()
    End Sub

    Private Sub TripMabinogiHomeBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TripMabinogiHomeBT.Click
        MainBrowser.Navigate("http://mabinogi.nexon.co.jp/")
    End Sub

    Private Sub TripEiyudenHomeBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TripEiyudenHomeBT.Click
        MainBrowser.Navigate("http://heroes.nexon.co.jp/")
    End Sub

    Private Sub MabiWikiBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MabiWikiBT.Click
        NewWindow("http://mabinogi.wikiwiki.jp/index.php")
    End Sub

    'BrowserMenu
    Dim linktxt As String
    Private Sub BrowserMenu_Opening(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserMenu.Opening
        linktxt = MainBrowser.StatusText
        If (linktxt.IndexOf("http://") > -1) Then
            BrowserMenuLinkCopyBT.Enabled = True
        ElseIf (linktxt.IndexOf("https://") > -1) Then
            BrowserMenuLinkCopyBT.Enabled = True
        Else
            BrowserMenuLinkCopyBT.Enabled = False
        End If
    End Sub

    Private Sub BrowserMenuNewWinBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserMenuNewWinBT.Click
        'MainBrowser.StatusText
        Dim viBrowser As New VersionInfoBrowser
        viBrowser.MainBrowser.Url = MainBrowser.Url
        viBrowser.Show()
    End Sub

    Private Sub BrowserMenuCopyBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserMenuCopyBT.Click
        MainBrowser.Document.ExecCommand("Copy", False, "")
    End Sub

    Private Sub BrowserMenuLinkCopyBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserMenuLinkCopyBT.Click
        Clipboard.SetText(linktxt)
    End Sub

    Private Sub OpenDefBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDefBrowser.Click
        Process.Start(MainBrowser.Url.ToString())
    End Sub


    'MainMenu
    Private Sub MainMenuNewWindowBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuNewWindowBT.Click
        Dim NW As New NewWindow
        NW.Show()
    End Sub

    Private Sub MainMenuExitBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuExitBT.Click
        Application.Exit()
    End Sub

    Private Sub MainMenuSettingsBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuSettingsBT.Click
        Dim settingclass As New Settings
        settingclass.ShowDialog()
        settingclass.Dispose()
    End Sub

    Private Sub MainMenuUpdateBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuUpdateBT.Click
        Updater.Show()
    End Sub

    Private Sub MainMenuVersioninfoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuVersioninfoBT.Click
        VerInfoMain.Show()
    End Sub

    Private Sub MainMenuProfileFixerBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuProfileFixerBT.Click
        Dim proffixclass As New ProfFixer
        proffixclass.ShowDialog()
        proffixclass.Dispose()
    End Sub



    'ListMenu
    Private Sub ListMenuAccountAddBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListMenuAccountAddBT.Click
        Dim EditAc As New EditAccount
        EditAccount.EditMode = 0
        EditAc.ShowDialog()
        EditAc.Close()
    End Sub

    Private Sub ListMenuAccountEditBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListMenuAccountEditBT.Click
        Dim EditAc As New EditAccount
        EditAccount.EditMode = 1
        EditAccount.shownamestr = AccountList.SelectedItem
        EditAccount.accountselect = AccountList.SelectedIndex
        EditAc.ShowDialog()
        EditAc.Close()
    End Sub

    Private Sub ListMenuAccountDelBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListMenuAccountDelBT.Click
        Dim base64class As New Base64
        'Dim basepass As String = base64class.Encoding("pending", "")

        Dim getfilename As String = AccountList.SelectedItem
        Dim encfilename As String = getfilename 'base64class.Encoding(getfilename, basepass)
        System.IO.File.Delete(My.Application.Info.DirectoryPath & "\account\" & encfilename)
        AccountList.Items.Remove(AccountList.SelectedItem)
    End Sub

    Private Sub ListMenu_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ListMenu.Opening
        If (AccountList.SelectedIndex > -1) Then
            ListMenuAccountEditBT.Enabled = True
            ListMenuAccountDelBT.Enabled = True
        Else
            ListMenuAccountEditBT.Enabled = False
            ListMenuAccountDelBT.Enabled = False
        End If
    End Sub
End Class
