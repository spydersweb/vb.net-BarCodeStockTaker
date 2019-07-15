Imports System
Imports System.Windows.Forms
Imports System.IO


Public Class FormStockTake

    Private nonNumberEntered As Boolean = False

    Public barcode_count As New TextBox
    Public stock_count As New TextBox

    Private Sub stockTake_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inv_app.Init(Me)
        barcode.Focus()
        barcode.TextAlign = HorizontalAlignment.Center

        With barcode_count
            .Location = New Point(156, 150)
            .Size = New Size(79, 64)
            .Font = New Font("Tahoma", 36, FontStyle.Bold)
            .TextAlign = HorizontalAlignment.Right
            .Text = "0"
            .Visible = True
            .Show()
            .BackColor = Me.BackColor
            .Enabled = False
        End With

        With stock_count
            .Location = New Point(20, 150)
            .Size = New Size(79, 64)
            .Font = New Font("Tahoma", 36, FontStyle.Bold)
            .TextAlign = HorizontalAlignment.Right
            .Text = Inventory.GetInventoryTotalItems
            .Visible = True
            .Show()
            .BackColor = Me.BackColor
            .Enabled = False
        End With
        Me.Controls.Add(barcode_count)
        Me.Controls.Add(stock_count)

    End Sub

    Private Sub barcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles barcode.KeyDown
        If e.KeyCode = 236 Then
            barcode.Text = ""
        End If

        If e.KeyCode = Keys.Escape Then
            ' Remove the last item scanned here
            Inventory.RemoveLastItemAdded()
            barcode_count.Text = Inventory.GetInventoryItemCount(barcode.Text)
            stock_count.Text = Inventory.GetInventoryTotalItems
            barcode.Text = ""
        End If
    End Sub

    Private Sub barcode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles barcode.KeyUp
        ' The last key to be pressed is the 13 Keys.Enter
        If e.KeyCode = Keys.Enter Then
            'MsgBox("Enter Captured")
            ' Perform the stock addition here
            Inventory.AddInventoryItem(barcode.Text)
            barcode_count.Text = Inventory.GetInventoryItemCount(barcode.Text)
            stock_count.Text = Inventory.GetInventoryTotalItems
        End If
    End Sub

    ' Menu Item Back
    Private Sub Menu_Back_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu_Back.Click
        Me.Close()
        FormApplicationMenu.Show()
    End Sub

    ' Menu Item Export Data
    Private Sub Menu_ExportData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu_ExportData.Click
        Inventory.ExportData()
    End Sub

    ' Menu Item View Data
    Private Sub Menu_ViewData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Menu_ViewData.Click
        Dim FormViewStockData As FormViewStockData = New FormViewStockData
        FormViewStockData.Show()
        Me.Close()
        FormViewStockData = Nothing
    End Sub
End Class