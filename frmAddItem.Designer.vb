<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddItem
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
        lblCustomerEmail = New Label()
        txtPrice = New TextBox()
        lblTitle = New Label()
        picItem = New PictureBox()
        lblType = New Label()
        lblName = New Label()
        txtType = New TextBox()
        txtName = New TextBox()
        btnExit = New Button()
        btnCancelReset = New Button()
        btnAddNewItem = New Button()
        btnUpload = New Button()
        openImage = New OpenFileDialog()
        CType(picItem, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCustomerEmail
        ' 
        lblCustomerEmail.AutoSize = True
        lblCustomerEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCustomerEmail.ForeColor = SystemColors.ControlLightLight
        lblCustomerEmail.Location = New Point(53, 286)
        lblCustomerEmail.Name = "lblCustomerEmail"
        lblCustomerEmail.Size = New Size(52, 21)
        lblCustomerEmail.TabIndex = 59
        lblCustomerEmail.Text = "Price:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPrice.ForeColor = SystemColors.ActiveCaptionText
        txtPrice.Location = New Point(53, 309)
        txtPrice.Margin = New Padding(3, 2, 3, 2)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(312, 29)
        txtPrice.TabIndex = 58
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(256, 32)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(237, 45)
        lblTitle.TabIndex = 57
        lblTitle.Text = "Add New Item"
        ' 
        ' picItem
        ' 
        picItem.ErrorImage = My.Resources.Resources.item
        picItem.Image = My.Resources.Resources.item
        picItem.InitialImage = My.Resources.Resources.item
        picItem.Location = New Point(467, 116)
        picItem.Margin = New Padding(3, 2, 3, 2)
        picItem.Name = "picItem"
        picItem.Size = New Size(222, 236)
        picItem.SizeMode = PictureBoxSizeMode.Zoom
        picItem.TabIndex = 56
        picItem.TabStop = False
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblType.ForeColor = SystemColors.ControlLightLight
        lblType.Location = New Point(53, 211)
        lblType.Name = "lblType"
        lblType.Size = New Size(50, 21)
        lblType.TabIndex = 55
        lblType.Text = "Type:"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblName.ForeColor = SystemColors.ControlLightLight
        lblName.Location = New Point(53, 133)
        lblName.Name = "lblName"
        lblName.Size = New Size(99, 21)
        lblName.TabIndex = 54
        lblName.Text = "Item Name:"
        ' 
        ' txtType
        ' 
        txtType.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtType.ForeColor = SystemColors.ActiveCaptionText
        txtType.Location = New Point(53, 234)
        txtType.Margin = New Padding(3, 2, 3, 2)
        txtType.Name = "txtType"
        txtType.Size = New Size(312, 29)
        txtType.TabIndex = 50
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtName.ForeColor = SystemColors.ActiveCaptionText
        txtName.Location = New Point(53, 155)
        txtName.Margin = New Padding(3, 2, 3, 2)
        txtName.Name = "txtName"
        txtName.Size = New Size(312, 29)
        txtName.TabIndex = 49
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(506, 458)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(155, 37)
        btnExit.TabIndex = 53
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnCancelReset
        ' 
        btnCancelReset.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnCancelReset.FlatStyle = FlatStyle.Flat
        btnCancelReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelReset.ForeColor = SystemColors.ActiveCaptionText
        btnCancelReset.Location = New Point(291, 458)
        btnCancelReset.Margin = New Padding(3, 2, 3, 2)
        btnCancelReset.Name = "btnCancelReset"
        btnCancelReset.Size = New Size(153, 37)
        btnCancelReset.TabIndex = 52
        btnCancelReset.Text = "Cancel and reset"
        btnCancelReset.UseVisualStyleBackColor = False
        ' 
        ' btnAddNewItem
        ' 
        btnAddNewItem.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnAddNewItem.FlatStyle = FlatStyle.Flat
        btnAddNewItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAddNewItem.ForeColor = SystemColors.ActiveCaptionText
        btnAddNewItem.Location = New Point(71, 458)
        btnAddNewItem.Margin = New Padding(3, 2, 3, 2)
        btnAddNewItem.Name = "btnAddNewItem"
        btnAddNewItem.Size = New Size(151, 37)
        btnAddNewItem.TabIndex = 51
        btnAddNewItem.Text = "Add New Item"
        btnAddNewItem.UseVisualStyleBackColor = False
        ' 
        ' btnUpload
        ' 
        btnUpload.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnUpload.FlatStyle = FlatStyle.Flat
        btnUpload.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnUpload.ForeColor = SystemColors.ActiveCaptionText
        btnUpload.Location = New Point(58, 368)
        btnUpload.Margin = New Padding(3, 2, 3, 2)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(177, 37)
        btnUpload.TabIndex = 60
        btnUpload.Text = "Upload Item Image"
        btnUpload.UseVisualStyleBackColor = False
        ' 
        ' openImage
        ' 
        openImage.FileName = "OpenFileDialog1"
        ' 
        ' frmAddItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(743, 525)
        Controls.Add(btnUpload)
        Controls.Add(lblCustomerEmail)
        Controls.Add(txtPrice)
        Controls.Add(lblTitle)
        Controls.Add(picItem)
        Controls.Add(lblType)
        Controls.Add(lblName)
        Controls.Add(txtType)
        Controls.Add(txtName)
        Controls.Add(btnExit)
        Controls.Add(btnCancelReset)
        Controls.Add(btnAddNewItem)
        Name = "frmAddItem"
        Text = "frmAddItem"
        CType(picItem, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCustomerEmail As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents picItem As PictureBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancelReset As Button
    Friend WithEvents btnAddNewItem As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents openImage As OpenFileDialog
End Class
