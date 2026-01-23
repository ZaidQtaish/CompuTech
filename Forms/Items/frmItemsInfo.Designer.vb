<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemsInfo
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
        lblItemId = New Label()
        txtItemId = New TextBox()
        btnFirstRecord = New Button()
        btnLastRecord = New Button()
        btnPrevRecord = New Button()
        btnNextRecord = New Button()
        lblTitle = New Label()
        lblType = New Label()
        lblItemName = New Label()
        lblPrice = New Label()
        txtItemType = New TextBox()
        txtItemName = New TextBox()
        txtItemPrice = New TextBox()
        picLogo = New PictureBox()
        picItem = New PictureBox()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picItem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblItemId
        ' 
        lblItemId.AutoSize = True
        lblItemId.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblItemId.ForeColor = SystemColors.ControlLightLight
        lblItemId.Location = New Point(105, 146)
        lblItemId.Name = "lblItemId"
        lblItemId.Size = New Size(70, 21)
        lblItemId.TabIndex = 74
        lblItemId.Text = "Item ID:"
        ' 
        ' txtItemId
        ' 
        txtItemId.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtItemId.ForeColor = SystemColors.ActiveCaptionText
        txtItemId.Location = New Point(207, 146)
        txtItemId.Margin = New Padding(3, 2, 3, 2)
        txtItemId.Name = "txtItemId"
        txtItemId.ReadOnly = True
        txtItemId.Size = New Size(312, 29)
        txtItemId.TabIndex = 73
        ' 
        ' btnFirstRecord
        ' 
        btnFirstRecord.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnFirstRecord.CausesValidation = False
        btnFirstRecord.FlatStyle = FlatStyle.Flat
        btnFirstRecord.Font = New Font("Microsoft JhengHei", 15.75F, FontStyle.Bold)
        btnFirstRecord.Location = New Point(65, 399)
        btnFirstRecord.Margin = New Padding(3, 2, 3, 2)
        btnFirstRecord.Name = "btnFirstRecord"
        btnFirstRecord.Size = New Size(115, 35)
        btnFirstRecord.TabIndex = 72
        btnFirstRecord.Text = "<<"
        btnFirstRecord.TextAlign = ContentAlignment.TopCenter
        btnFirstRecord.UseVisualStyleBackColor = False
        ' 
        ' btnLastRecord
        ' 
        btnLastRecord.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnLastRecord.CausesValidation = False
        btnLastRecord.FlatStyle = FlatStyle.Flat
        btnLastRecord.Font = New Font("Microsoft JhengHei", 15.75F, FontStyle.Bold)
        btnLastRecord.Location = New Point(483, 399)
        btnLastRecord.Margin = New Padding(3, 2, 3, 2)
        btnLastRecord.Name = "btnLastRecord"
        btnLastRecord.Size = New Size(115, 35)
        btnLastRecord.TabIndex = 71
        btnLastRecord.Text = ">>"
        btnLastRecord.TextAlign = ContentAlignment.TopCenter
        btnLastRecord.UseVisualStyleBackColor = False
        ' 
        ' btnPrevRecord
        ' 
        btnPrevRecord.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnPrevRecord.CausesValidation = False
        btnPrevRecord.FlatStyle = FlatStyle.Flat
        btnPrevRecord.Font = New Font("Microsoft JhengHei", 15.75F, FontStyle.Bold)
        btnPrevRecord.Location = New Point(207, 399)
        btnPrevRecord.Margin = New Padding(3, 2, 3, 2)
        btnPrevRecord.Name = "btnPrevRecord"
        btnPrevRecord.Size = New Size(115, 35)
        btnPrevRecord.TabIndex = 70
        btnPrevRecord.Text = "<"
        btnPrevRecord.TextAlign = ContentAlignment.TopCenter
        btnPrevRecord.UseVisualStyleBackColor = False
        ' 
        ' btnNextRecord
        ' 
        btnNextRecord.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnNextRecord.CausesValidation = False
        btnNextRecord.FlatStyle = FlatStyle.Flat
        btnNextRecord.Font = New Font("Microsoft JhengHei", 15.75F, FontStyle.Bold)
        btnNextRecord.Location = New Point(343, 399)
        btnNextRecord.Margin = New Padding(3, 2, 3, 2)
        btnNextRecord.Name = "btnNextRecord"
        btnNextRecord.Size = New Size(115, 35)
        btnNextRecord.TabIndex = 69
        btnNextRecord.Text = ">"
        btnNextRecord.TextAlign = ContentAlignment.TopCenter
        btnNextRecord.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(253, 28)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(172, 45)
        lblTitle.TabIndex = 68
        lblTitle.Text = "Items Info"
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblType.ForeColor = SystemColors.ControlLightLight
        lblType.Location = New Point(117, 269)
        lblType.Name = "lblType"
        lblType.Size = New Size(50, 21)
        lblType.TabIndex = 67
        lblType.Text = "Type:"
        ' 
        ' lblItemName
        ' 
        lblItemName.AutoSize = True
        lblItemName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblItemName.ForeColor = SystemColors.ControlLightLight
        lblItemName.Location = New Point(92, 207)
        lblItemName.Name = "lblItemName"
        lblItemName.Size = New Size(99, 21)
        lblItemName.TabIndex = 66
        lblItemName.Text = "Item Name:"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPrice.ForeColor = SystemColors.ControlLightLight
        lblPrice.Location = New Point(117, 333)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(52, 21)
        lblPrice.TabIndex = 65
        lblPrice.Text = "Price:"
        ' 
        ' txtItemType
        ' 
        txtItemType.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtItemType.ForeColor = SystemColors.ActiveCaptionText
        txtItemType.Location = New Point(207, 269)
        txtItemType.Margin = New Padding(3, 2, 3, 2)
        txtItemType.Name = "txtItemType"
        txtItemType.ReadOnly = True
        txtItemType.Size = New Size(312, 29)
        txtItemType.TabIndex = 64
        ' 
        ' txtItemName
        ' 
        txtItemName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtItemName.ForeColor = SystemColors.ActiveCaptionText
        txtItemName.Location = New Point(207, 207)
        txtItemName.Margin = New Padding(3, 2, 3, 2)
        txtItemName.Name = "txtItemName"
        txtItemName.ReadOnly = True
        txtItemName.Size = New Size(312, 29)
        txtItemName.TabIndex = 63
        ' 
        ' txtItemPrice
        ' 
        txtItemPrice.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtItemPrice.ForeColor = SystemColors.ActiveCaptionText
        txtItemPrice.Location = New Point(207, 333)
        txtItemPrice.Margin = New Padding(3, 2, 3, 2)
        txtItemPrice.Name = "txtItemPrice"
        txtItemPrice.ReadOnly = True
        txtItemPrice.Size = New Size(312, 29)
        txtItemPrice.TabIndex = 62
        ' 
        ' picLogo
        ' 
        picLogo.ErrorImage = My.Resources.Resources.item
        picLogo.Image = My.Resources.Resources.item
        picLogo.InitialImage = My.Resources.Resources.item
        picLogo.Location = New Point(12, 11)
        picLogo.Margin = New Padding(3, 2, 3, 2)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(102, 104)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 75
        picLogo.TabStop = False
        ' 
        ' picItem
        ' 
        picItem.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        picItem.ErrorImage = My.Resources.Resources.pc1
        picItem.Image = My.Resources.Resources.pc1
        picItem.InitialImage = My.Resources.Resources.pc1
        picItem.Location = New Point(669, 50)
        picItem.Margin = New Padding(3, 2, 3, 2)
        picItem.Name = "picItem"
        picItem.Size = New Size(437, 364)
        picItem.SizeMode = PictureBoxSizeMode.Zoom
        picItem.TabIndex = 76
        picItem.TabStop = False
        ' 
        ' frmItemsInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(1140, 461)
        Controls.Add(picItem)
        Controls.Add(picLogo)
        Controls.Add(lblItemId)
        Controls.Add(txtItemId)
        Controls.Add(btnFirstRecord)
        Controls.Add(btnLastRecord)
        Controls.Add(btnPrevRecord)
        Controls.Add(btnNextRecord)
        Controls.Add(lblTitle)
        Controls.Add(lblType)
        Controls.Add(lblItemName)
        Controls.Add(lblPrice)
        Controls.Add(txtItemType)
        Controls.Add(txtItemName)
        Controls.Add(txtItemPrice)
        Name = "frmItemsInfo"
        Text = "frmItemsInfo"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(picItem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblItemId As Label
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents btnLastRecord As Button
    Friend WithEvents btnPrevRecord As Button
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtItemType As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picItem As PictureBox
End Class
