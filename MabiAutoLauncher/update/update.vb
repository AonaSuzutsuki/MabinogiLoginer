﻿Imports ICSharpCode.SharpZipLib

Public Class update

    Dim num As String

    Private Sub update_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If (num = 1) Then
                Process.Start("MabinogiLoginer.exe")
            End If
        Catch
            Environment.Exit(0)
        End Try
    End Sub

    Private Sub update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmddata As String = vbNullString
        For Each cmd As String In My.Application.CommandLineArgs
            cmddata = cmd
        Next
        If (cmddata = "agree") Then

        Else
            MessageBox.Show("直接起動できません。", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Environment.Exit(0)
        End If

        System.Threading.Thread.Sleep(2000)

        Try
            Using wc As New System.Net.WebClient()
                wc.DownloadFile("http://kimamaningen.futene.net/HTML/Downloads/TGSUpdate/MabiLoginer/MabinogiLoginer.zip", "MabinogiLoginer.zip")
            End Using

            unzip()
            System.IO.File.Delete("MabinogiLoginer.zip")

            MsgBox("アップデートが完了しました。", vbInformation, "完了")
            num = 1
            Close()
        Catch ex As Exception
            MsgBox("ファイルが見つかりません。", vbCritical, "エラー")
            MsgBox("バージョン確認ができません。", vbCritical, "エラー")
            num = 1
            Close()
        End Try
    End Sub

    Private Sub unzip()
        '展開するZIP書庫のパス 
        Dim zipFileName As String = My.Application.Info.DirectoryPath & "\MabinogiLoginer.zip"
        '展開したファイルを保存するフォルダ（存在しないと作成される） 
        Dim targetDirectory As String = My.Application.Info.DirectoryPath & ""
        '展開するファイルのフィルタ 
        Dim fileFilter As String = ""

        'FastZipオブジェクトの作成 
        Dim fastZip As New ICSharpCode.SharpZipLib.Zip.FastZip()
        '属性を復元するか。デフォルトはfalse 
        fastZip.RestoreAttributesOnExtract = True
        'ファイル日時を復元するか。デフォルトはfalse 
        fastZip.RestoreDateTimeOnExtract = True
        '空のフォルダも作成するか。デフォルトはfalse 
        fastZip.CreateEmptyDirectories = True

        'パスワードが設定されているとき 
        'パスワードが設定されている書庫をパスワードを指定せずに展開しようとすると、 
        '　例外ZipExceptionがスローされる 
        'fastZip.Password = "password"

        'ZIP書庫を展開する 
        fastZip.ExtractZip(zipFileName, targetDirectory, fileFilter)
    End Sub
End Class
