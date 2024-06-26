<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderInfo
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitle = New Label()
        btnExit = New Button()
        dgvOrders = New DataGridView()
        CustomerId = New DataGridViewTextBoxColumn()
        CustomerFName = New DataGridViewTextBoxColumn()
        CustomerLName = New DataGridViewTextBoxColumn()
        CustomerEmail = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 30F, FontStyle.Bold)
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(199, 37)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(237, 54)
        lblTitle.TabIndex = 58
        lblTitle.Text = "Orders Info"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(456, 626)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(155, 37)
        btnExit.TabIndex = 70
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' dgvOrders
        ' 
        dgvOrders.AllowDrop = True
        dgvOrders.AllowUserToResizeColumns = False
        dgvOrders.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(60))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle1.Padding = New Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(53), CByte(53), CByte(70))
        dgvOrders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvOrders.BackgroundColor = Color.FromArgb(CByte(33), CByte(33), CByte(60))
        dgvOrders.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.MenuText
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.Window
        DataGridViewCellStyle2.Padding = New Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrders.Columns.AddRange(New DataGridViewColumn() {CustomerId, CustomerFName, CustomerLName, CustomerEmail, Quantity})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(60))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New Padding(2)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(53), CByte(63), CByte(70))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvOrders.DefaultCellStyle = DataGridViewCellStyle3
        dgvOrders.GridColor = Color.White
        dgvOrders.Location = New Point(38, 151)
        dgvOrders.Margin = New Padding(3, 2, 3, 2)
        dgvOrders.Name = "dgvOrders"
        dgvOrders.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New Padding(2)
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.Control
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvOrders.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvOrders.RowHeadersWidth = 51
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle5.Padding = New Padding(2)
        dgvOrders.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvOrders.RowTemplate.Height = 29
        dgvOrders.ScrollBars = ScrollBars.None
        dgvOrders.Size = New Size(549, 438)
        dgvOrders.TabIndex = 71
        ' 
        ' CustomerId
        ' 
        CustomerId.HeaderText = "Order ID"
        CustomerId.Name = "CustomerId"
        CustomerId.ReadOnly = True
        ' 
        ' CustomerFName
        ' 
        CustomerFName.HeaderText = "User ID"
        CustomerFName.Name = "CustomerFName"
        CustomerFName.ReadOnly = True
        ' 
        ' CustomerLName
        ' 
        CustomerLName.HeaderText = "Customer ID"
        CustomerLName.Name = "CustomerLName"
        CustomerLName.ReadOnly = True
        ' 
        ' CustomerEmail
        ' 
        CustomerEmail.HeaderText = "Item ID"
        CustomerEmail.Name = "CustomerEmail"
        CustomerEmail.ReadOnly = True
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        Quantity.ReadOnly = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources.cart1
        PictureBox1.Image = My.Resources.Resources.cart1
        PictureBox1.InitialImage = My.Resources.Resources.cart1
        PictureBox1.Location = New Point(12, 11)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 72
        PictureBox1.TabStop = False
        ' 
        ' frmOrderInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(623, 686)
        Controls.Add(PictureBox1)
        Controls.Add(dgvOrders)
        Controls.Add(btnExit)
        Controls.Add(lblTitle)
        Name = "frmOrderInfo"
        Text = "frmOrderInfo"
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents CustomerId As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerLName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmail As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
