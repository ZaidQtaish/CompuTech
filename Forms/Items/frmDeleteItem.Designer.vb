<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteItem
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
        Label2 = New Label()
        txtItemPrice = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        txtItemType = New TextBox()
        txtItemName = New TextBox()
        btnDeleteItem = New Button()
        GroupBox1 = New GroupBox()
        radSearchByName = New RadioButton()
        radSearchByID = New RadioButton()
        lblSearchName = New Label()
        txtSearchName = New TextBox()
        btnFindItem = New Button()
        lblItemId = New Label()
        txtSearchItemId = New TextBox()
        btnCancelReset = New Button()
        lblTitle = New Label()
        picItem = New PictureBox()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        CType(picItem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(44, 410)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 21)
        Label2.TabIndex = 107
        Label2.Text = "Item Price:"
        ' 
        ' txtItemPrice
        ' 
        txtItemPrice.Enabled = False
        txtItemPrice.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtItemPrice.Location = New Point(173, 410)
        txtItemPrice.Margin = New Padding(3, 2, 3, 2)
        txtItemPrice.Name = "txtItemPrice"
        txtItemPrice.Size = New Size(312, 29)
        txtItemPrice.TabIndex = 104
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(46, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 21)
        Label4.TabIndex = 106
        Label4.Text = "Item Type:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(43, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 21)
        Label3.TabIndex = 105
        Label3.Text = "Item Name:"
        ' 
        ' txtItemType
        ' 
        txtItemType.Enabled = False
        txtItemType.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtItemType.Location = New Point(173, 353)
        txtItemType.Margin = New Padding(3, 2, 3, 2)
        txtItemType.Name = "txtItemType"
        txtItemType.Size = New Size(312, 29)
        txtItemType.TabIndex = 103
        ' 
        ' txtItemName
        ' 
        txtItemName.Enabled = False
        txtItemName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtItemName.Location = New Point(173, 296)
        txtItemName.Margin = New Padding(3, 2, 3, 2)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(312, 29)
        txtItemName.TabIndex = 102
        ' 
        ' btnDeleteItem
        ' 
        btnDeleteItem.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnDeleteItem.FlatStyle = FlatStyle.Flat
        btnDeleteItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnDeleteItem.ForeColor = SystemColors.ActiveCaptionText
        btnDeleteItem.Location = New Point(28, 482)
        btnDeleteItem.Margin = New Padding(3, 2, 3, 2)
        btnDeleteItem.Name = "btnDeleteItem"
        btnDeleteItem.Size = New Size(160, 37)
        btnDeleteItem.TabIndex = 96
        btnDeleteItem.Text = "Delete Item"
        btnDeleteItem.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radSearchByName)
        GroupBox1.Controls.Add(radSearchByID)
        GroupBox1.Controls.Add(lblSearchName)
        GroupBox1.Controls.Add(txtSearchName)
        GroupBox1.Controls.Add(btnFindItem)
        GroupBox1.Controls.Add(lblItemId)
        GroupBox1.Controls.Add(txtSearchItemId)
        GroupBox1.Location = New Point(28, 100)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(565, 157)
        GroupBox1.TabIndex = 101
        GroupBox1.TabStop = False
        ' 
        ' radSearchByName
        ' 
        radSearchByName.AutoSize = True
        radSearchByName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        radSearchByName.ForeColor = SystemColors.ControlLightLight
        radSearchByName.Location = New Point(207, 19)
        radSearchByName.Margin = New Padding(3, 2, 3, 2)
        radSearchByName.Name = "radSearchByName"
        radSearchByName.Size = New Size(160, 24)
        radSearchByName.TabIndex = 50
        radSearchByName.TabStop = True
        radSearchByName.Text = "Search By Name"
        radSearchByName.UseVisualStyleBackColor = True
        ' 
        ' radSearchByID
        ' 
        radSearchByID.AutoSize = True
        radSearchByID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        radSearchByID.ForeColor = SystemColors.ControlLightLight
        radSearchByID.Location = New Point(18, 19)
        radSearchByID.Margin = New Padding(3, 2, 3, 2)
        radSearchByID.Name = "radSearchByID"
        radSearchByID.Size = New Size(133, 24)
        radSearchByID.TabIndex = 49
        radSearchByID.TabStop = True
        radSearchByID.Text = "Search By ID"
        radSearchByID.UseVisualStyleBackColor = True
        ' 
        ' lblSearchName
        ' 
        lblSearchName.AutoSize = True
        lblSearchName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblSearchName.ForeColor = SystemColors.ControlLightLight
        lblSearchName.Location = New Point(15, 106)
        lblSearchName.Name = "lblSearchName"
        lblSearchName.Size = New Size(101, 20)
        lblSearchName.TabIndex = 48
        lblSearchName.Text = "Item Name:"
        ' 
        ' txtSearchName
        ' 
        txtSearchName.BorderStyle = BorderStyle.FixedSingle
        txtSearchName.Enabled = False
        txtSearchName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        txtSearchName.Location = New Point(159, 105)
        txtSearchName.Margin = New Padding(3, 2, 3, 2)
        txtSearchName.Name = "txtSearchName"
        txtSearchName.Size = New Size(224, 26)
        txtSearchName.TabIndex = 2
        ' 
        ' btnFindItem
        ' 
        btnFindItem.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnFindItem.FlatStyle = FlatStyle.Flat
        btnFindItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFindItem.ForeColor = SystemColors.ActiveCaptionText
        btnFindItem.Location = New Point(404, 66)
        btnFindItem.Margin = New Padding(3, 2, 3, 2)
        btnFindItem.Name = "btnFindItem"
        btnFindItem.Size = New Size(138, 52)
        btnFindItem.TabIndex = 3
        btnFindItem.Text = "Find Item"
        btnFindItem.UseVisualStyleBackColor = False
        ' 
        ' lblItemId
        ' 
        lblItemId.AutoSize = True
        lblItemId.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblItemId.ForeColor = SystemColors.ControlLightLight
        lblItemId.Location = New Point(18, 64)
        lblItemId.Name = "lblItemId"
        lblItemId.Size = New Size(74, 20)
        lblItemId.TabIndex = 45
        lblItemId.Text = "Item ID:"
        ' 
        ' txtSearchItemId
        ' 
        txtSearchItemId.BorderStyle = BorderStyle.FixedSingle
        txtSearchItemId.Enabled = False
        txtSearchItemId.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        txtSearchItemId.Location = New Point(159, 63)
        txtSearchItemId.Margin = New Padding(3, 2, 3, 2)
        txtSearchItemId.Name = "txtSearchItemId"
        txtSearchItemId.Size = New Size(224, 26)
        txtSearchItemId.TabIndex = 1
        ' 
        ' btnCancelReset
        ' 
        btnCancelReset.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnCancelReset.FlatStyle = FlatStyle.Flat
        btnCancelReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelReset.ForeColor = SystemColors.ActiveCaptionText
        btnCancelReset.Location = New Point(292, 482)
        btnCancelReset.Margin = New Padding(3, 2, 3, 2)
        btnCancelReset.Name = "btnCancelReset"
        btnCancelReset.Size = New Size(153, 37)
        btnCancelReset.TabIndex = 100
        btnCancelReset.Text = "Cancel and reset"
        btnCancelReset.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(360, 23)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(193, 45)
        lblTitle.TabIndex = 99
        lblTitle.Text = "Delete Item"
        ' 
        ' picItem
        ' 
        picItem.ErrorImage = My.Resources.Resources.item
        picItem.Image = My.Resources.Resources.item
        picItem.InitialImage = My.Resources.Resources.item
        picItem.Location = New Point(657, 123)
        picItem.Margin = New Padding(3, 2, 3, 2)
        picItem.Name = "picItem"
        picItem.Size = New Size(252, 275)
        picItem.SizeMode = PictureBoxSizeMode.Zoom
        picItem.TabIndex = 98
        picItem.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(556, 482)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(155, 37)
        btnExit.TabIndex = 97
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmDeleteItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(936, 542)
        Controls.Add(Label2)
        Controls.Add(txtItemPrice)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtItemType)
        Controls.Add(txtItemName)
        Controls.Add(btnDeleteItem)
        Controls.Add(GroupBox1)
        Controls.Add(btnCancelReset)
        Controls.Add(lblTitle)
        Controls.Add(picItem)
        Controls.Add(btnExit)
        Name = "frmDeleteItem"
        Text = "frmDeleteItem"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picItem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemType As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSearchByName As RadioButton
    Friend WithEvents radSearchByID As RadioButton
    Friend WithEvents lblSearchName As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents btnFindItem As Button
    Friend WithEvents lblItemId As Label
    Friend WithEvents txtSearchItemId As TextBox
    Friend WithEvents btnCancelReset As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents picItem As PictureBox
    Friend WithEvents btnExit As Button
End Class
