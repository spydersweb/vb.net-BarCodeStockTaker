Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms

Public Class FormViewStockData

    Private WithEvents dataGridView1 As New Data.DataView()

    Private Sub FormViewStockData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inv_app.Init(Me)
        Me.Controls.Add(Inventory.ReturnInventoryAsDataGrid(Me))
    End Sub

    ' Menu Item Back
    Private Sub menu_back_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_back.Click
        Me.Close()
        FormApplicationMenu.Show()
    End Sub

    Private Sub Menu_ExportData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu_ExportData.Click
        Inventory.ExportData()
    End Sub

    Private Sub Menu_StockTake_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu_StockTake.Click
        Dim FormStockTake As FormStockTake = New FormStockTake
        Me.Close()
        FormStockTake.Show()
        FormStockTake = Nothing

    End Sub
End Class