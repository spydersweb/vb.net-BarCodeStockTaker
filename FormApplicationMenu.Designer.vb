<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormApplicationMenu
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button_stockTake = New System.Windows.Forms.Button
        Me.button_viewdata = New System.Windows.Forms.Button
        Me.button_clearStockTake = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.Menu_File = New System.Windows.Forms.MenuItem
        Me.Menu_StockTake = New System.Windows.Forms.MenuItem
        Me.Menu_ViewData = New System.Windows.Forms.MenuItem
        Me.Menu_ClearData = New System.Windows.Forms.MenuItem
        Me.Menu_ExportData = New System.Windows.Forms.MenuItem
        Me.button_exportData = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'button_stockTake
        '
        Me.button_stockTake.Location = New System.Drawing.Point(9, 65)
        Me.button_stockTake.Name = "button_stockTake"
        Me.button_stockTake.Size = New System.Drawing.Size(221, 29)
        Me.button_stockTake.TabIndex = 0
        Me.button_stockTake.Text = "Perform a Stock Take"
        '
        'button_viewdata
        '
        Me.button_viewdata.Location = New System.Drawing.Point(9, 113)
        Me.button_viewdata.Name = "button_viewdata"
        Me.button_viewdata.Size = New System.Drawing.Size(221, 29)
        Me.button_viewdata.TabIndex = 1
        Me.button_viewdata.Text = "View Stock Data"
        '
        'button_clearStockTake
        '
        Me.button_clearStockTake.Location = New System.Drawing.Point(9, 156)
        Me.button_clearStockTake.Name = "button_clearStockTake"
        Me.button_clearStockTake.Size = New System.Drawing.Size(221, 29)
        Me.button_clearStockTake.TabIndex = 2
        Me.button_clearStockTake.Text = "Clear Stock Take"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.Menu_File)
        '
        'Menu_File
        '
        Me.Menu_File.MenuItems.Add(Me.Menu_StockTake)
        Me.Menu_File.MenuItems.Add(Me.Menu_ViewData)
        Me.Menu_File.MenuItems.Add(Me.Menu_ClearData)
        Me.Menu_File.MenuItems.Add(Me.Menu_ExportData)
        Me.Menu_File.Text = "File"
        '
        'Menu_StockTake
        '
        Me.Menu_StockTake.Text = "Stock Take"
        '
        'Menu_ViewData
        '
        Me.Menu_ViewData.Text = "View Data"
        '
        'Menu_ClearData
        '
        Me.Menu_ClearData.Text = "Clear Data"
        '
        'Menu_ExportData
        '
        Me.Menu_ExportData.Text = "Export Data"
        '
        'button_exportData
        '
        Me.button_exportData.Location = New System.Drawing.Point(9, 202)
        Me.button_exportData.Name = "button_exportData"
        Me.button_exportData.Size = New System.Drawing.Size(221, 29)
        Me.button_exportData.TabIndex = 3
        Me.button_exportData.Text = "Export Data to SD"
        '
        'FormApplicationMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(638, 455)
        Me.Controls.Add(Me.button_exportData)
        Me.Controls.Add(Me.button_clearStockTake)
        Me.Controls.Add(Me.button_viewdata)
        Me.Controls.Add(Me.button_stockTake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "FormApplicationMenu"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_stockTake As System.Windows.Forms.Button
    Friend WithEvents button_viewdata As System.Windows.Forms.Button
    Friend WithEvents button_clearStockTake As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Menu_File As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_StockTake As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_ViewData As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_ClearData As System.Windows.Forms.MenuItem
    Friend WithEvents button_exportData As System.Windows.Forms.Button
    Friend WithEvents Menu_ExportData As System.Windows.Forms.MenuItem

End Class
