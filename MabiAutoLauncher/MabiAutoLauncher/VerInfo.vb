Public Class VerInfo

    Private Sub VerInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TitleLabel.Text = "Mabinogi Loginer"
        NameLabel.Text = "rvv[JP]"
        VersionLabel.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub OKBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBT.Click
        Close()
    End Sub

    Private Sub NameLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NameLabel.LinkClicked
        VersionInfoBrowser.url = "http://kimamaningen.futene.net"
        VersionInfoBrowser.Show()
    End Sub
End Class