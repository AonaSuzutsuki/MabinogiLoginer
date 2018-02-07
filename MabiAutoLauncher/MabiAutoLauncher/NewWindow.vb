Public Class NewWindow

    Private Sub NewWindow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim iniclass As New INI

        Select Case Me.WindowState
            Case FormWindowState.Normal
                iniclass.WriteInt("Browser", "Width", Me.Width, My.Application.Info.DirectoryPath & "\settings.ini")
                iniclass.WriteInt("Browser", "Height", Me.Height, My.Application.Info.DirectoryPath & "\settings.ini")
            Case FormWindowState.Minimized

            Case FormWindowState.Maximized

        End Select
    End Sub

    Private Sub NewWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim iniclass As New INI

        MainBrowser.ScriptErrorsSuppressed = True

        Dim iniWidth As Integer
        Dim iniHeight As Integer
        iniWidth = iniclass.GetInt("Browser", "Width", Me.Width, My.Application.Info.DirectoryPath & "\settings.ini")
        iniHeight = iniclass.GetInt("Browser", "Height", Me.Height, My.Application.Info.DirectoryPath & "\settings.ini")
        Me.Size = New Size(iniWidth, iniHeight)
        Dim ScreenWidth As Integer
        Dim ScreenHeight As Integer
        ScreenWidth = SystemInformation.WorkingArea.Width
        ScreenHeight = SystemInformation.WorkingArea.Height
        Me.Location = New Point((ScreenWidth - Me.Width) / 2, _
       (ScreenHeight - Me.Height) / 2)
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

    Private Sub BrowserMenuOpenBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserMenuOpenBT.Click
        MainBrowser.Navigate(UrlTextBox.Text)
    End Sub


    'Browser
    Private Sub MainBrowser_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles MainBrowser.DocumentCompleted
        Me.Text = MainBrowser.DocumentTitle
        UrlTextBox.Text = MainBrowser.Url.ToString()
    End Sub

    Private Sub MainBrowser_NewWindow2(ByVal sender As Object, ByVal e As WebBrowserNewWindow2EventArgs) Handles MainBrowser.NewWindow2
        NewWindow(Nothing, e)
    End Sub

    Private Sub NewWindow(Optional ByVal url As String = Nothing, Optional ByVal e As WebBrowserNewWindow2EventArgs = Nothing)
        Dim NW As New NewWindow

        If Not (url = Nothing) Then
            Dim u As New Uri(url)
            NW.MainBrowser.Url = u
        End If

        NW.Show()

        '新しいウィンドウが開くのを抑制
        Try
            e.ppDisp = NW.MainBrowser.Application
            NW.MainBrowser.RegisterAsBrowser = True
        Catch

        End Try
    End Sub


    'URLBox
    Private Sub UrlTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UrlTextBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            MainBrowser.Navigate(UrlTextBox.Text)
        End If
    End Sub


    'Menu
    Private Sub MenuFileCloseBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCloseBT.Click
        Close()
    End Sub

    Private Sub MenuVerInfoBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuVerInfoBT.Click
        BrowserVerInfo.Show()
    End Sub
End Class