Public Class EditAccount
    Public Shared EditMode As Integer
    Public Shared shownamestr As String
    Public Shared accountselect As Integer
    Dim encshowname As String

    Private Sub EditAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not (System.IO.Directory.Exists("account")) Then
                System.IO.Directory.CreateDirectory("account")
            End If

            If (EditMode = 1) Then
                Dim base64class As New Base64
                Dim iniclass As New INI
                Dim basepass As String = base64class.Encoding("pending", "")

                encshowname = shownamestr 'base64class.Encoding(shownamestr, basepass)
                Dim encid As String = iniclass.GetStr("Data", "ID", Nothing, My.Application.Info.DirectoryPath & "\account\" & encshowname)
                Dim encpw As String = iniclass.GetStr("Data", "PW", Nothing, My.Application.Info.DirectoryPath & "\account\" & encshowname)
                Dim iddata As String = base64class.Decoding(encid, basepass)
                Dim pwdata As String = base64class.Decoding(encpw, basepass)
                otpradio = iniclass.GetInt("Data", "OTP", 0, My.Application.Info.DirectoryPath & "\account\" & encshowname)

                ShowNameBox.Text = shownamestr
                IDBox.Text = iddata
                PasswordBox.Text = pwdata

                If (otpradio = 0) Then
                    OTPNothingRadio.Checked = True
                ElseIf (otpradio = 1) Then
                    OTPPCRadio.Checked = True
                ElseIf (otpradio = 2) Then
                    OTPOtherRadio.Checked = True
                End If
            End If
        Catch

        End Try
    End Sub

    Private Sub SaveBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBT.Click
        If (ShowNameBox.Text.Length = 0) Then
            MessageBox.Show("表示名を入力してください。", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (IDBox.Text.Length = 0) Then
            MessageBox.Show("アカウント名・IDを入力してください。", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (PasswordBox.Text.Length = 0) Then
            MessageBox.Show("パスワードを入力してください。", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf (My.Application.Info.DirectoryPath.Length + ShowNameBox.Text.Length > 255) Then
            MessageBox.Show("ファイルパスが長すぎます。表示名を調整してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If (EditMode = 0) Then
                savemethod()
            Else
                If (textchenge = 1) Then
                    resavemethod2()
                Else
                    resavemethod()
                End If
            End If
        End If

    End Sub

    Private Sub resavemethod()
        Try
            If (System.IO.File.Exists(My.Application.Info.DirectoryPath & "\account\" & encshowname)) Then
                Dim base64class As New Base64
                Dim basepass As String = base64class.Encoding("pending", "")

                Dim encshownamesave As String = ShowNameBox.Text 'base64class.Encoding(ShowNameBox.Text, basepass)
                Dim encid As String = base64class.Encoding(IDBox.Text, basepass)
                Dim encpass As String = base64class.Encoding(PasswordBox.Text, basepass)

                Dim otpradio As Integer
                If (OTPNothingRadio.Checked = True) Then
                    otpradio = 0
                ElseIf (OTPPCRadio.Checked = True) Then
                    otpradio = 1
                ElseIf (OTPOtherRadio.Checked = True) Then
                    otpradio = 2
                End If

                If Not (System.IO.File.Exists(My.Application.Info.DirectoryPath & "\account\" & encshownamesave)) Then
                    System.IO.File.Delete(My.Application.Info.DirectoryPath & "\account\" & encshowname)
                    Dim iniclass As New INI
                    'iniclass.WriteStr("Data", "NAME", encshownamesave, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                    iniclass.WriteStr("Data", "ID", encid, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                    iniclass.WriteStr("Data", "PW", encpass, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                    iniclass.WriteStr("Data", "OTP", otpradio, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)

                    MainForm.AccountList.Items.Item(accountselect) = ShowNameBox.Text
                    Close()
                Else
                    MessageBox.Show("既に同じ表示名が使用されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("指定されたファイルが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch

        End Try
    End Sub

    Dim otpradio As Integer
    Private Sub resavemethod2()
        Try
            If (System.IO.File.Exists(My.Application.Info.DirectoryPath & "\account\" & encshowname)) Then
                Dim base64class As New Base64
                Dim basepass As String = base64class.Encoding("pending", "")

                Dim encshownamesave As String = ShowNameBox.Text 'base64class.Encoding(ShowNameBox.Text, basepass)
                Dim encid As String = base64class.Encoding(IDBox.Text, basepass)
                Dim encpass As String = base64class.Encoding(PasswordBox.Text, basepass)

                If (OTPNothingRadio.Checked = True) Then
                    otpradio = 0
                ElseIf (OTPPCRadio.Checked = True) Then
                    otpradio = 1
                ElseIf (OTPOtherRadio.Checked = True) Then
                    otpradio = 2
                End If

                System.IO.File.Delete(My.Application.Info.DirectoryPath & "\account\" & encshowname)
                Dim iniclass As New INI
                'iniclass.WriteStr("Data", "NAME", encshownamesave, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                iniclass.WriteStr("Data", "ID", encid, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                iniclass.WriteStr("Data", "PW", encpass, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                iniclass.WriteStr("Data", "OTP", otpradio, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)

                MainForm.AccountList.Items.Item(accountselect) = ShowNameBox.Text
                Close()

            Else
                MessageBox.Show("指定されたファイルが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch

        End Try
    End Sub

    Private Sub savemethod()
        Try
            Dim base64class As New Base64
            Dim basepass As String = base64class.Encoding("pending", "")

            Dim encshownamesave As String = ShowNameBox.Text 'base64class.Encoding(ShowNameBox.Text, basepass)
            Dim encid As String = base64class.Encoding(IDBox.Text, basepass)
            Dim encpass As String = base64class.Encoding(PasswordBox.Text, basepass)

            Dim otpradio As Integer
            If (OTPNothingRadio.Checked = True) Then
                otpradio = 0
            ElseIf (OTPPCRadio.Checked = True) Then
                otpradio = 1
            ElseIf (OTPOtherRadio.Checked = True) Then
                otpradio = 2
            End If

            If Not (System.IO.File.Exists(My.Application.Info.DirectoryPath & "\account\" & encshownamesave)) Then
                Dim iniclass As New INI
                'iniclass.WriteStr("Data", "NAME", encshownamesave, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                iniclass.WriteStr("Data", "ID", encid, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                iniclass.WriteStr("Data", "PW", encpass, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)
                iniclass.WriteStr("Data", "OTP", otpradio, My.Application.Info.DirectoryPath & "\account\" & encshownamesave)

                MainForm.AccountList.Items.Add(ShowNameBox.Text)
                Close()
            Else
                MessageBox.Show("既に同じ表示名が使用されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch

        End Try
    End Sub

    Private Sub CancelBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBT.Click
        Close()
    End Sub

    Dim textchenge As Integer
    Private Sub ShowNameBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowNameBox.TextChanged
        Dim invalidChars As Char() = System.IO.Path.GetInvalidFileNameChars()
        If (ShowNameBox.Text.IndexOfAny(invalidChars) > 0) Then
            MessageBox.Show("不正な文字列が含まれています。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        textchenge = 1
    End Sub

    Private Sub ShowNameHelpBT_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ShowNameHelpBT.LinkClicked
        MessageBox.Show("1～31のASCII文字・Unicode文字・引用符("")・不等号(<と>)・パイプ(|)・null(\0)・コロン(:)・" & _
                        "アスタリスク(*)・クエスチョンマーク(?)・スラッシュ(/)・バックスラッシュ(\)は使用できません。", _
                        "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class