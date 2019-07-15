<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormViewStockData
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.menu_back = New System.Windows.Forms.MenuItem
        Me.Menu_StockTake = New System.Windows.Forms.MenuItem
        Me.Menu_ExportData = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.menu_back)
        Me.MenuItem1.MenuItems.Add(Me.Menu_StockTake)
        Me.MenuItem1.MenuItems.Add(Me.Menu_ExportData)
        Me.MenuItem1.Text = "File"
        '
        'menu_back
        '
        Me.menu_back.Text = "Back"
        '
        'Menu_StockTake
        '
        Me.Menu_StockTake.Text = "Stock Take"
        '
        'Menu_ExportData
        '
        Me.Menu_ExportData.Text = "Export Data"
        '
        'FormViewStockData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(238, 295)
        Me.Menu = Me.mainMenu1
        Me.Name = "FormViewStockData"
        Me.Text = "viewstockdata"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menu_back As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_StockTake As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_ExportData As System.Windows.Forms.MenuItem
End Class
