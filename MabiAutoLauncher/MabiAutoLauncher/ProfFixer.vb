Option Strict On

Public Class ProfFixer

    Private Sub ProfFixer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If (System.IO.Directory.Exists(My.Application.Info.DirectoryPath & "\account")) Then
                For Each stFilePath As String In System.IO.Directory.GetFiles(My.Application.Info.DirectoryPath & "\account", "*")
                    FileList.Items.Add(System.IO.Path.GetFileNameWithoutExtension(stFilePath))
                Next stFilePath
            End If
        Catch ex As Exception
        End Try

        GenPW()

        AddFileBT.Enabled = False
        DeleteFileBT.Enabled = False
    End Sub

    Private Sub AddFileBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFileBT.Click
        FixFileList.Items.Add(FileList.SelectedItem.ToString())
        FileList.Items.RemoveAt(FileList.SelectedIndex)
    End Sub

    Private Sub DeleteFileBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFileBT.Click
        FileList.Items.Add(FixFileList.SelectedItem.ToString())
        FixFileList.Items.RemoveAt(FixFileList.SelectedIndex)
    End Sub

    Dim PWD As String
    Private Sub GenPW()
        PWD = PasswordClass.ReturnPassword()
    End Sub

    Private Sub FixBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FixBT.Click
        Dim firstresult As DialogResult = MessageBox.Show("プロファイルの修復を開始します。よろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Dim base64class As New Base64
        Dim iniclass As New INI
        Dim basepass As String = base64class.Encoding(PWD, "")

        If (firstresult = DialogResult.Yes) Then
            For filenum = 0 To FixFileList.Items.Count - 1
                Try
                    Dim beffilename As String = My.Application.Info.DirectoryPath & "\account\" & CStr(FixFileList.Items.Item(filenum))
                    Dim decfilename As String = base64class.Decoding(CStr(FixFileList.Items.Item(filenum)), basepass)
                    Dim filename As String = My.Application.Info.DirectoryPath & "\account\" & decfilename
                    If (System.IO.File.Exists(filename)) Then
                        Dim result As DialogResult = MessageBox.Show("同一ファイルが存在します。上書きしますか？", _
                                                                     "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If (result = DialogResult.Yes) Then
                            System.IO.File.Delete(filename)
                            System.IO.File.Move(beffilename, filename)
                        End If
                    Else
                        System.IO.File.Move(beffilename, filename)
                    End If
                Catch ex As System.Exception
                    MessageBox.Show("データ複合時にエラーが発生しました。", _
                                                                     "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

            MainForm.AccountList.Items.Clear()
            For Each stFilePath As String In System.IO.Directory.GetFiles(My.Application.Info.DirectoryPath & "\account", "*")
                MainForm.AccountList.Items.Add(System.IO.Path.GetFileNameWithoutExtension(stFilePath))
            Next stFilePath
            Close()
        End If
    End Sub

    Private Sub CancelBT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBT.Click
        Close()
    End Sub

    Private Sub FileList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileList.SelectedIndexChanged
        If (CInt(FileList.SelectedIndex) > -1) Then
            AddFileBT.Enabled = True
        Else
            AddFileBT.Enabled = False
        End If
    End Sub

    Private Sub FixFileList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FixFileList.SelectedIndexChanged
        If (CInt(FixFileList.SelectedIndex) > -1) Then
            DeleteFileBT.Enabled = True
        Else
            DeleteFileBT.Enabled = False
        End If
    End Sub
End Class