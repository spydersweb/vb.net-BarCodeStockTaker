Imports System
Imports System.IO
Imports System.Text

Public Class FormApplicationMenu

    Public formStockTake As FormStockTake
    Public formViewData As FormViewStockData

    Private Sub FormApplicationMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inv_app.Init(Me)
    End Sub

    ' Stock Take Button
    Private Sub button_stockTake_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_stockTake.Click
        formStockTake = New FormStockTake
        formStockTake.Show()
        Me.Hide()
        formStockTake = Nothing
    End Sub

    ' View Data Button
    Private Sub button_viewdata_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_viewdata.Click
        formViewData = New FormViewStockData
        formViewData.Show()
        Me.Hide()
        formViewData = Nothing
    End Sub

    ' Clear Data Button
    Private Sub button_clearStockTake_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_clearStockTake.Click
        Inventory.ClearInventory()
    End Sub

    ' Export Data Button
    Private Sub button_exportData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_exportData.Click
        Inventory.ExportData()
    End Sub

    ' Menu Item Stock Take
    Private Sub Menu_StockTake_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu_StockTake.Click
        formStockTake = New FormStockTake
        formStockTake.Show()
        Me.Hide()
        formStockTake = Nothing
    End Sub

    ' Menu Item View Data
    Private Sub Menu_ViewData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu_ViewData.Click
        formViewData = New FormViewStockData
        formViewData.Show()
        Me.Hide()
        formViewData = Nothing
    End Sub

    ' Menu Item Clear Data
    Private Sub Menu_ClearData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu_ClearData.Click
        Inventory.ClearInventory()
    End Sub

    ' Menu Item Export Data
    Private Sub Menu_ExportData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_ExportData.Click
        Inventory.ExportData()
    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Me.KeyDown, AddressOf Me.buttonpress
        AddHandler Me.button_stockTake.KeyDown, AddressOf Me.buttonpress
        AddHandler Me.button_viewdata.KeyDown, AddressOf Me.buttonpress
        AddHandler Me.button_clearStockTake.KeyDown, AddressOf Me.buttonpress
        AddHandler Me.button_exportData.KeyDown, AddressOf Me.buttonpress

    End Sub



    Private Sub buttonpress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 236 Then
            formStockTake = New FormStockTake
            formStockTake.Show()
            Me.Hide()
            formStockTake = Nothing
        End If
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub

End Class
