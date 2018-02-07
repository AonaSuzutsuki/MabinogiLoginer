Public Class Settings

    Dim iniclass As New INI
    Dim autocheck As Integer
    Dim otplaunch As Integer
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        autocheck = iniclass.GetInt("Main", "AutoUpdate", 1, My.Application.Info.DirectoryPath & "\settings.ini")
        If (autocheck = 0) Then
            AutoCheckBox.Checked = False
        Else
            AutoCheckBox.Checked = True
        End If

        otplaunch = iniclass.GetInt("Main", "PCOTPLAUNCH", 0, My.Application.Info.DirectoryPath & "\settings.ini")
        If (otplaunch = 0) Then
            OTPLaunchBox.Checked = False
        Else
            OTPLaunchBox.Checked = True
        End If

        Dim otppath As String
        otppath = iniclass.GetStr("Main", "PCOTPPATH", Nothing, My.Application.Info.DirectoryPath & "\settings.ini")
        PCOTPFilePathBox.Text = otppath
    End Sub

    Private Sub FileViewBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileViewBT.Click
        Dim ofd As New OpenFileDialog()

        ofd.FileName = ""
        ofd.InitialDirectory = "C:\"
        ofd.Filter = _
            "実行ファイル(*.exe)|*.exe"
        ofd.FilterIndex = 1
        ofd.Title = "実行ファイルを選択してください"
        ofd.RestoreDirectory = True
        ofd.CheckFileExists = True
        ofd.CheckPathExists = True

        If ofd.ShowDialog() = DialogResult.OK Then
            PCOTPFilePathBox.Text = ofd.FileName
        End If
    End Sub


    Private Sub OkayBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkayBT.Click
        savemethod()
    End Sub

    Private Sub savemethod()
        iniclass.WriteInt("Main", "AutoUpdate", AutoCheckBox.CheckState, My.Application.Info.DirectoryPath & "\settings.ini")
        iniclass.WriteStr("Main", "PCOTPPATH", PCOTPFilePathBox.Text, My.Application.Info.DirectoryPath & "\settings.ini")
        iniclass.WriteStr("Main", "PCOTPLAUNCH", OTPLaunchBox.CheckState, My.Application.Info.DirectoryPath & "\settings.ini")
        Close()
    End Sub

    Private Sub CancelBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBT.Click
        Close()
    End Sub


    'Help
    Private Sub PCOTPHelp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PCOTPHelp.LinkClicked
        MessageBox.Show("...よりPC型トークンの実行ファイルを選択してください。", "ヘルプ", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub

    Private Sub OTPLaunchHelp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles OTPLaunchHelp.LinkClicked
        MessageBox.Show("PC型トークンアカウントでログインする際にトークン生成ソフトを起動するかどうかです。", "ヘルプ", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub
End Class