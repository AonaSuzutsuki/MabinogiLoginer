﻿Imports System.Security.Permissions
Imports System.Runtime.InteropServices

Public Class AxBrowser
    Inherits System.Windows.Forms.WebBrowser

    'NewWindow2イベントの拡張
    Private cookie As AxHost.ConnectionPointCookie
    Private helper As WebBrowser2EventHelper

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    <System.Runtime.InteropServices.DispIdAttribute(200)> _
    Public ReadOnly Property Application() As Object
        Get
            If IsNothing(Me.ActiveXInstance) Then
                Throw New AxHost.InvalidActiveXStateException("Application", AxHost.ActiveXInvokeKind.PropertyGet)
            End If
            Return Me.ActiveXInstance.Application
        End Get
    End Property

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    <System.Runtime.InteropServices.DispIdAttribute(552)> _
    Public Property RegisterAsBrowser() As Boolean
        Get
            If IsNothing(Me.ActiveXInstance) Then
                Throw New AxHost.InvalidActiveXStateException("RegisterAsBrowser", AxHost.ActiveXInvokeKind.PropertyGet)
            End If
            Return Me.ActiveXInstance.RegisterAsBrowser
        End Get
        Set(ByVal value As Boolean)
            If IsNothing(Me.ActiveXInstance) Then
                Throw New AxHost.InvalidActiveXStateException("RegisterAsBrowser", AxHost.ActiveXInvokeKind.PropertySet)
            End If
            Me.ActiveXInstance.RegisterAsBrowser = value
        End Set
    End Property

    <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")> _
    Protected Overrides Sub CreateSink()
        MyBase.CreateSink()
        helper = New WebBrowser2EventHelper(Me)
        cookie = New AxHost.ConnectionPointCookie(Me.ActiveXInstance, helper, GetType(DWebBrowserEvents2))
    End Sub

    <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")> _
    Protected Overrides Sub DetachSink()
        If cookie IsNot Nothing Then
            cookie.Disconnect()
            cookie = Nothing
        End If
        MyBase.DetachSink()
    End Sub

    Public Event NewWindow2 As WebBrowserNewWindow2EventHandler

    Protected Overridable Sub OnNewWindow2(ByVal e As WebBrowserNewWindow2EventArgs)
        RaiseEvent NewWindow2(Me, e)
    End Sub

    Private Class WebBrowser2EventHelper
        Inherits StandardOleMarshalObject
        Implements DWebBrowserEvents2

        Private parent As AxBrowser

        Public Sub New(ByVal parent As AxBrowser)
            Me.parent = parent
        End Sub

        Public Sub NewWindow2(ByRef ppDisp As Object, ByRef cancel As Boolean) Implements DWebBrowserEvents2.NewWindow2
            Dim e As New WebBrowserNewWindow2EventArgs(ppDisp)
            Me.parent.OnNewWindow2(e)
            ppDisp = e.ppDisp
            cancel = e.Cancel
        End Sub

    End Class

End Class

Public Delegate Sub WebBrowserNewWindow2EventHandler(ByVal sender As Object, ByVal e As WebBrowserNewWindow2EventArgs)

Public Class WebBrowserNewWindow2EventArgs
    Inherits System.ComponentModel.CancelEventArgs

    Private ppDispValue As Object

    Public Sub New(ByVal ppDisp As Object)
        Me.ppDispValue = ppDisp
    End Sub

    Public Property ppDisp() As Object
        Get
            Return ppDispValue
        End Get
        Set(ByVal value As Object)
            ppDispValue = value
        End Set
    End Property

End Class

<ComImport(), Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D"), _
InterfaceType(ComInterfaceType.InterfaceIsIDispatch), _
TypeLibType(TypeLibTypeFlags.FHidden)> _
Public Interface DWebBrowserEvents2

    <DispId(DISPID.NEWWINDOW2)> Sub NewWindow2( _
        <InAttribute(), OutAttribute(), MarshalAs(UnmanagedType.IDispatch)> ByRef ppDisp As Object, _
        <InAttribute(), OutAttribute()> ByRef cancel As Boolean)

End Interface

Public Enum DISPID
    NEWWINDOW2 = 251
End Enum
