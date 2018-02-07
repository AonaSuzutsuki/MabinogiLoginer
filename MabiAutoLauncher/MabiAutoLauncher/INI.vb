﻿Imports System.Runtime.InteropServices

Public Class INI
    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)> _
    Public Shared Function GetPrivateProfileString( _
ByVal lpAppName As String, _
ByVal lpKeyName As String, ByVal lpDefault As String, _
ByVal lpReturnedString As String, ByVal nSize As Integer, _
ByVal lpFileName As String) As Integer
    End Function

    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)> _
    Public Shared Function GetPrivateProfileInt( _
ByVal lpAppName As String, _
ByVal lpKeyName As String, ByVal nDefault As Integer, _
ByVal lpFileName As String) As Integer
    End Function

    <DllImport("KERNEL32.DLL")> _
    Public Shared Function WritePrivateProfileString( _
ByVal lpAppName As String, _
ByVal lpKeyName As String, _
ByVal lpString As String, _
ByVal lpFileName As String) As Integer
    End Function

    Public address As String
    Public port As Integer
    Public str As String
    Dim IniBuffer As String = Space(255)

    'Public Function GetString(ByVal ClassName As String, ByVal PropertyName As String, ByVal FileName As String)
    '    GetPrivateProfileString(ClassName, PropertyName, "", IniBuffer, Len(IniBuffer), _
    '                            FileName)
    '    address = Microsoft.VisualBasic.Left(IniBuffer, InStr(IniBuffer, Chr(0)) - 1)

    '    Return address
    'End Function

    Public Function GetInt(ByVal ClassName As String, ByVal PropertyName As String, ByVal NoNum As Integer, ByVal FileName As String)
        port = GetPrivateProfileInt(ClassName, PropertyName, NoNum, FileName)

        Return port
    End Function

    Public Function GetStr(ByVal ClassName As String, ByVal PropertyName As String, ByVal NoStr As String, ByVal FileName As String)
        GetPrivateProfileString(ClassName, PropertyName, NoStr, IniBuffer, Len(IniBuffer), _
                                FileName)
        str = Microsoft.VisualBasic.Left(IniBuffer, InStr(IniBuffer, Chr(0)) - 1)

        Return str
    End Function

    Public Sub WriteStr(ByVal ClassName As String, ByVal PropertyName As String, ByVal Text As String, ByVal FileName As String)
        WritePrivateProfileString(ClassName, PropertyName, Text, FileName)
    End Sub

    Public Sub WriteInt(ByVal ClassName As String, ByVal PropertyName As String, ByVal Text As String, ByVal FileName As String)
        WritePrivateProfileString(ClassName, PropertyName, Text, FileName)
    End Sub
End Class
