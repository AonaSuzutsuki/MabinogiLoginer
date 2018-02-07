Public Class VerInfoMain

    Private Sub VerInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TitleLabel.Text = "Mabinogi Loginer"
        NameLabel.Text = "rvv[JP]"
        VersionLabel.Text = My.Application.Info.Version.ToString
    End Sub

    Private mousePoint As Point
    Private Sub MainForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown, TitleLabel.MouseDown
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            mousePoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub MainForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove, TitleLabel.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            Me.Left += e.X - mousePoint.X
            Me.Top += e.Y - mousePoint.Y
        End If
    End Sub

    Private Sub OKBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBT.Click
        Close()
    End Sub

    Private Sub NameLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NameLabel.LinkClicked
        NewWindow("http://kimamaningen.futene.net")
    End Sub

    Private Sub NewWindow(Optional ByVal url As String = Nothing, Optional ByVal e As WebBrowserNewWindow2EventArgs = Nothing)
        Dim NW As New NewWindow

        If Not (url = Nothing) Then
            Dim u As New Uri(url)
            NW.MainBrowser.Url = u
        End If

        NW.Show()

        Try
            e.ppDisp = NW.MainBrowser.Application
            NW.MainBrowser.RegisterAsBrowser = True
        Catch

        End Try
    End Sub
End Class