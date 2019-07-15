
Module Module1
    Public Inventory As New Stock_Inventory
    Public DataGrid1 As New DataGrid
    Public DT As New DataTable
    Public inv_app As New App(New FormApplicationMenu)

    Sub Main()
        Try
            inv_app.run()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
