<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMdiMainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        UsersMenu = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        UsersInfoToolStripMenuItem = New ToolStripMenuItem()
        AddNewUserToolStripMenuItem = New ToolStripMenuItem()
        UpdateUserInfoToolStripMenuItem = New ToolStripMenuItem()
        CustomersMenu = New ToolStripMenuItem()
        CustomerInfoToolStripMenuItem = New ToolStripMenuItem()
        AddNewCustomerToolStripMenuItem = New ToolStripMenuItem()
        UpdateCustomerToolStripMenuItem = New ToolStripMenuItem()
        DeleteCustomerToolStripMenuItem = New ToolStripMenuItem()
        CustomerDGVToolStripMenuItem = New ToolStripMenuItem()
        ItemsMenu = New ToolStripMenuItem()
        ShowItemsToolStripMenuItem = New ToolStripMenuItem()
        AddNewItemToolStripMenuItem = New ToolStripMenuItem()
        UpdateItemInfoToolStripMenuItem = New ToolStripMenuItem()
        DeleteItemToolStripMenuItem = New ToolStripMenuItem()
        OrdersMenu = New ToolStripMenuItem()
        NewOrderToolStripMenuItem = New ToolStripMenuItem()
        OrdersInfoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip = New MenuStrip()
        SystemMenu = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ConnectToAccessMenuItem = New ToolStripMenuItem()
        MenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' UsersMenu
        ' 
        UsersMenu.DropDownItems.AddRange(New ToolStripItem() {ToolStripSeparator3, UsersInfoToolStripMenuItem, AddNewUserToolStripMenuItem, UpdateUserInfoToolStripMenuItem})
        UsersMenu.ForeColor = SystemColors.ControlLightLight
        UsersMenu.ImageTransparentColor = SystemColors.ActiveBorder
        UsersMenu.Name = "UsersMenu"
        UsersMenu.Size = New Size(62, 25)
        UsersMenu.Text = "Users"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(182, 6)
        ' 
        ' UsersInfoToolStripMenuItem
        ' 
        UsersInfoToolStripMenuItem.Name = "UsersInfoToolStripMenuItem"
        UsersInfoToolStripMenuItem.Size = New Size(185, 26)
        UsersInfoToolStripMenuItem.Text = "Users Info"
        ' 
        ' AddNewUserToolStripMenuItem
        ' 
        AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem"
        AddNewUserToolStripMenuItem.Size = New Size(185, 26)
        AddNewUserToolStripMenuItem.Text = "Add New User"
        ' 
        ' UpdateUserInfoToolStripMenuItem
        ' 
        UpdateUserInfoToolStripMenuItem.Name = "UpdateUserInfoToolStripMenuItem"
        UpdateUserInfoToolStripMenuItem.Size = New Size(185, 26)
        UpdateUserInfoToolStripMenuItem.Text = "Update Users"
        ' 
        ' CustomersMenu
        ' 
        CustomersMenu.DropDownItems.AddRange(New ToolStripItem() {CustomerInfoToolStripMenuItem, AddNewCustomerToolStripMenuItem, UpdateCustomerToolStripMenuItem, DeleteCustomerToolStripMenuItem, CustomerDGVToolStripMenuItem})
        CustomersMenu.ForeColor = SystemColors.ControlLightLight
        CustomersMenu.Name = "CustomersMenu"
        CustomersMenu.Size = New Size(100, 25)
        CustomersMenu.Text = "Customers"
        ' 
        ' CustomerInfoToolStripMenuItem
        ' 
        CustomerInfoToolStripMenuItem.Name = "CustomerInfoToolStripMenuItem"
        CustomerInfoToolStripMenuItem.Size = New Size(237, 26)
        CustomerInfoToolStripMenuItem.Text = "Customer Info (Form)"
        ' 
        ' AddNewCustomerToolStripMenuItem
        ' 
        AddNewCustomerToolStripMenuItem.Name = "AddNewCustomerToolStripMenuItem"
        AddNewCustomerToolStripMenuItem.Size = New Size(237, 26)
        AddNewCustomerToolStripMenuItem.Text = "Add New Customer"
        ' 
        ' UpdateCustomerToolStripMenuItem
        ' 
        UpdateCustomerToolStripMenuItem.Name = "UpdateCustomerToolStripMenuItem"
        UpdateCustomerToolStripMenuItem.Size = New Size(237, 26)
        UpdateCustomerToolStripMenuItem.Text = "Update Customer"
        ' 
        ' DeleteCustomerToolStripMenuItem
        ' 
        DeleteCustomerToolStripMenuItem.Name = "DeleteCustomerToolStripMenuItem"
        DeleteCustomerToolStripMenuItem.Size = New Size(237, 26)
        DeleteCustomerToolStripMenuItem.Text = "Delete Customer"
        ' 
        ' CustomerDGVToolStripMenuItem
        ' 
        CustomerDGVToolStripMenuItem.Name = "CustomerDGVToolStripMenuItem"
        CustomerDGVToolStripMenuItem.Size = New Size(237, 26)
        CustomerDGVToolStripMenuItem.Text = "Customer DGV"
        ' 
        ' ItemsMenu
        ' 
        ItemsMenu.DropDownItems.AddRange(New ToolStripItem() {ShowItemsToolStripMenuItem, AddNewItemToolStripMenuItem, UpdateItemInfoToolStripMenuItem, DeleteItemToolStripMenuItem})
        ItemsMenu.ForeColor = SystemColors.ControlLightLight
        ItemsMenu.Name = "ItemsMenu"
        ItemsMenu.Size = New Size(63, 25)
        ItemsMenu.Text = "Items"
        ' 
        ' ShowItemsToolStripMenuItem
        ' 
        ShowItemsToolStripMenuItem.Name = "ShowItemsToolStripMenuItem"
        ShowItemsToolStripMenuItem.Size = New Size(206, 26)
        ShowItemsToolStripMenuItem.Text = "Show Items"
        ' 
        ' AddNewItemToolStripMenuItem
        ' 
        AddNewItemToolStripMenuItem.Name = "AddNewItemToolStripMenuItem"
        AddNewItemToolStripMenuItem.Size = New Size(206, 26)
        AddNewItemToolStripMenuItem.Text = "Add New Item"
        ' 
        ' UpdateItemInfoToolStripMenuItem
        ' 
        UpdateItemInfoToolStripMenuItem.Name = "UpdateItemInfoToolStripMenuItem"
        UpdateItemInfoToolStripMenuItem.Size = New Size(206, 26)
        UpdateItemInfoToolStripMenuItem.Text = "Update Item Info"
        ' 
        ' DeleteItemToolStripMenuItem
        ' 
        DeleteItemToolStripMenuItem.Name = "DeleteItemToolStripMenuItem"
        DeleteItemToolStripMenuItem.Size = New Size(206, 26)
        DeleteItemToolStripMenuItem.Text = "Delete Item"
        ' 
        ' OrdersMenu
        ' 
        OrdersMenu.DropDownItems.AddRange(New ToolStripItem() {NewOrderToolStripMenuItem, OrdersInfoToolStripMenuItem})
        OrdersMenu.ForeColor = SystemColors.ControlLightLight
        OrdersMenu.Name = "OrdersMenu"
        OrdersMenu.Size = New Size(72, 25)
        OrdersMenu.Text = "Orders"
        ' 
        ' NewOrderToolStripMenuItem
        ' 
        NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem"
        NewOrderToolStripMenuItem.Size = New Size(180, 26)
        NewOrderToolStripMenuItem.Text = "New Order"
        ' 
        ' OrdersInfoToolStripMenuItem
        ' 
        OrdersInfoToolStripMenuItem.Name = "OrdersInfoToolStripMenuItem"
        OrdersInfoToolStripMenuItem.Size = New Size(180, 26)
        OrdersInfoToolStripMenuItem.Text = "Orders Info"
        ' 
        ' MenuStrip
        ' 
        MenuStrip.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        MenuStrip.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        MenuStrip.Items.AddRange(New ToolStripItem() {UsersMenu, CustomersMenu, ItemsMenu, OrdersMenu, SystemMenu})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(7, 2, 0, 2)
        MenuStrip.Size = New Size(1214, 29)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' SystemMenu
        ' 
        SystemMenu.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem, ConnectToAccessMenuItem})
        SystemMenu.ForeColor = SystemColors.ControlLightLight
        SystemMenu.Name = "SystemMenu"
        SystemMenu.Size = New Size(75, 25)
        SystemMenu.Text = "System"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(286, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' ConnectToAccessMenuItem
        ' 
        ConnectToAccessMenuItem.Name = "ConnectToAccessMenuItem"
        ConnectToAccessMenuItem.Size = New Size(286, 26)
        ConnectToAccessMenuItem.Text = "Connect to Access Database"
        ' 
        ' frmMdiMainScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1214, 667)
        Controls.Add(MenuStrip)
        FormBorderStyle = FormBorderStyle.FixedSingle
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmMdiMainScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MDIParent"
        WindowState = FormWindowState.Maximized
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents UsersMenu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CustomersMenu As ToolStripMenuItem
    Friend WithEvents ItemsMenu As ToolStripMenuItem
    Friend WithEvents OrdersMenu As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents SystemMenu As ToolStripMenuItem
    Friend WithEvents UsersInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateUserInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateItemInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdersInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectToAccessMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerDGVToolStripMenuItem As ToolStripMenuItem

End Class
