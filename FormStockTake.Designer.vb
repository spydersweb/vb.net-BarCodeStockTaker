<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FormStockTake
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
        Me.Menu_Back = New System.Windows.Forms.MenuItem
        Me.barcode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Menu_ViewData = New System.Windows.Forms.MenuItem
        Me.Menu_ExportData = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.Menu_ViewData)
        Me.MenuItem1.MenuItems.Add(Me.Menu_ExportData)
        Me.MenuItem1.MenuItems.Add(Me.Menu_Back)
        Me.MenuItem1.Text = "File"
        '
        'Menu_Back
        '
        Me.Menu_Back.Text = "Back"
        '
        'barcode
        '
        Me.barcode.BackColor = System.Drawing.SystemColors.Menu
        Me.barcode.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular)
        Me.barcode.Location = New System.Drawing.Point(3, 54)
        Me.barcode.Name = "barcode"
        Me.barcode.Size = New System.Drawing.Size(232, 35)
        Me.barcode.TabIndex = 1
        Me.barcode.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "Stock Code"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(138, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.Text = "Stock Qty"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.Text = "Items Counted"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Menu_ViewData
        '
        Me.Menu_ViewData.Text = "View Data"
        '
        'Menu_ExportData
        '
        Me.Menu_ExportData.Text = "Export Data"
        '
        'FormStockTake
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(238, 295)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.barcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "FormStockTake"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_Back As System.Windows.Forms.MenuItem
    Friend WithEvents barcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Menu_ViewData As System.Windows.Forms.MenuItem
    Friend WithEvents Menu_ExportData As System.Windows.Forms.MenuItem
End Class
