Imports System
Imports System.IO
Imports System.Reflection


Public Class App

    Private appBorderStyle As Windows.Forms.BorderStyle
    Private appTitle As String
    Private appLocation As Point
    Private appSize As Size
    Private appTopMost As Boolean
    Private appStartForm As Form
    Private appVersion As String
    Private appDirectoryLocation As String

    Public Sub New()
        appDirectoryLocation = GetCurrentDirectory()
    End Sub

    Public ReadOnly Property propDirectoryLocation()
        Get
            Return appDirectoryLocation
        End Get
    End Property

    Public Property propAppBorderStyle() As Windows.Forms.BorderStyle
        Get
            Return appBorderStyle
        End Get
        Set(ByVal value As Windows.Forms.BorderStyle)
            appBorderStyle = value
        End Set
    End Property

    Public Property propAppTitle() As String
        Get
            Return appTitle
        End Get
        Set(ByVal value As String)
            appTitle = value
        End Set
    End Property


    Sub New(ByRef startForm As Form)
        Me.appBorderStyle = BorderStyle.None
        Me.appLocation = New Point(0, 0)
        Me.appVersion = "1.1"
        Me.appSize = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
        Me.appStartForm = startForm
        Me.appTitle = "Stock Taker v" & Me.appVersion
        Me.appTopMost = True

    End Sub

    Public Sub run()
        Application.Run(Me.appStartForm)
    End Sub

    Public Function AppVersionLabel() As Label
        Dim appLabel As New Label
        With appLabel
            .Location = New Point(122, 275)
            .Size = New Size(111, 19)
            .Text = Me.appTitle & " v" & Me.appVersion
        End With
        Return appLabel
    End Function

    Public Sub Init(ByRef f As Form)
        f.Text = Me.appTitle
        f.FormBorderStyle = Me.appBorderStyle
        f.Location = Me.appLocation
        f.Size = Me.appSize
        f.TopMost = Me.appTopMost
        f.Controls.Add(Me.AppVersionLabel())
    End Sub

    Private Function GetCurrentDirectory()
        Return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase)
    End Function

End Class
