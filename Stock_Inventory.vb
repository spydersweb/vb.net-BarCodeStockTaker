Imports System
Imports System.Data
Imports System.Windows.Forms.DataGrid

Public Class Stock_Inventory

    Private _dg As DataGrid
    Private _stockTake As New Dictionary(Of String, Product)
    Private _lastItemScanned As String
    Private _dt As New DataTable


    Public Property LastItem()
        Get
            Return _lastItemScanned
        End Get
        Set(ByVal value)
            _lastItemScanned = value
        End Set
    End Property

    Public ReadOnly Property Stock() As Dictionary(Of String, Product)
        Get
            Return _stockTake
        End Get
    End Property

    Sub New()
        _dt.Columns.Add("Stock Code", GetType(String))
        _dt.Columns.Add("Quantity", GetType(Integer))
    End Sub

    Public Sub AddInventoryItem(ByVal stockCode As String)
        Me._lastItemScanned = stockCode
        If _stockTake.ContainsKey(stockCode) Then
            ' If the stock code has already been added then just update the quantity
            _stockTake(stockCode).Count = _stockTake(stockCode).Count + 1
        Else
            ' create the product
            _stockTake.Add(stockCode, New Product(stockCode, 1))
        End If
    End Sub

    Public Function GetInventoryItemCount(ByVal stockCode As String)
        Dim returnValue As Integer = 0
        If _stockTake.ContainsKey(stockCode) Then
            returnValue = _stockTake(stockCode).Count
        End If
        Return returnValue

    End Function

    Public Function GetInventoryTotalItems()
        Return _stockTake.Count
    End Function

    Public Sub ClearInventory()
        Dim msg As Integer = MsgBox("Clear Stock Data?", MsgBoxStyle.OkCancel, inv_app.propAppTitle)
        If msg = DialogResult.OK Then
            _stockTake.Clear()
        End If
    End Sub

    Private Sub _fillDataTable()
        _dt.Clear()
        For Each pair As KeyValuePair(Of String, Product) In _stockTake
            _dt.Rows.Add(pair.Key, pair.Value.Count)
        Next
    End Sub

    Public Function ReturnList()
        Dim list As New List(Of KeyValuePair(Of String, Integer))
        For Each pair As KeyValuePair(Of String, Product) In _stockTake
            list.Add(New KeyValuePair(Of String, Integer)(pair.Key, pair.Value.Count))
        Next
        Return list

    End Function

    Public Sub RemoveLastItemAdded()
        If Not Me.LastItem Is Nothing Then
            Dim msg As Integer = MsgBox("Remove Last Item?", MsgBoxStyle.OkCancel, inv_app.propAppTitle)
            If msg = DialogResult.OK Then
                Dim currentItemCount As Integer = _stockTake(Me._lastItemScanned).Count - 1
                If currentItemCount > 1 Then
                    _stockTake(Me._lastItemScanned).Count = currentItemCount
                Else
                    _stockTake.Remove(Me.LastItem)
                End If
                Me.LastItem = Nothing
            End If
        End If
    End Sub

    Public Function ReturnInventoryAsDataGrid(ByRef f As Form) As DataGrid

        Try
            _dg = New DataGrid
            _dg.Size = New Size(f.Width - 5, 220)
            _dg.Location = New Point(f.Left, 35)
            _dg.RowHeadersVisible = True

            _fillDataTable()

            Dim dgStyle As New DataGridTableStyle
            Dim dgStockCode As New DataGridTextBoxColumn()
            With dgStockCode
                .HeaderText = _dt.Columns(0).ColumnName
                .MappingName = _dt.Columns(0).ColumnName
                .Width = (_dg.Width * 60 / 100) - 10
            End With

            Dim dgStockQty As New DataGridTextBoxColumn()
            With dgStockQty
                .HeaderText = _dt.Columns(1).ColumnName
                .MappingName = _dt.Columns(1).ColumnName
                .Width = (_dg.Width * 35 / 100) - 10
            End With

            With dgStyle.GridColumnStyles
                .Add(dgStockCode)
                .Add(dgStockQty)
            End With

            _dg.TableStyles.Clear()
            _dg.TableStyles.Add(dgStyle)
            _dg.DataSource = _dt
            Return _dg
        Catch ex As Exception
            Throw ex
        End Try
        
    End Function

    Public Sub ExportData()
        If Inventory.GetInventoryTotalItems > 0 Then
            Try
                Dim msg As Integer = MsgBox("Clear Stock Data on Export?", MsgBoxStyle.YesNo, inv_app.propAppTitle)
                Dim csvFile As String = inv_app.propDirectoryLocation & "\stocktake.csv"
                Dim outFile As StreamWriter = New StreamWriter(csvFile, False)
                With outFile
                    .WriteLine("Stock Code,Quantity")
                    For Each pair As KeyValuePair(Of String, Product) In Inventory.Stock
                        .WriteLine(pair.Key & "," & pair.Value.Count)
                    Next
                    .Flush()
                    .Close()
                End With
                If msg = DialogResult.Yes Then
                    Inventory.ClearInventory()
                End If
                MsgBox("Data Export Complete")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Nothing to Export!", MsgBoxStyle.Critical, inv_app.propAppTitle)
        End If
    End Sub


    Public Sub dataGridClick_dataGridClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(e)
    End Sub

   
End Class
