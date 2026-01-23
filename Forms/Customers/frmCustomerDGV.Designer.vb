<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDGV
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
        dgvCustomers = New DataGridView()
        lblTitle = New Label()
        btnRemoveRow = New Button()
        btnAddDataDGV = New Button()
        btnLoadDataDGV = New Button()
        btnClearDGV = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtCustomerLName = New TextBox()
        txtCustomerFName = New TextBox()
        txtCustomerID = New TextBox()
        lblEmail = New Label()
        txtCustomerEmail = New TextBox()
        btnExit = New Button()
        CustomerEmail = New DataGridViewTextBoxColumn()
        CustomerLName = New DataGridViewTextBoxColumn()
        CustomerFName = New DataGridViewTextBoxColumn()
        CustomerId = New DataGridViewTextBoxColumn()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.AllowDrop = True
        dgvCustomers.AllowUserToResizeColumns = False
        dgvCustomers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(60))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle1.Padding = New Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(53), CByte(53), CByte(70))
        dgvCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvCustomers.BackgroundColor = Color.FromArgb(CByte(33), CByte(33), CByte(60))
        dgvCustomers.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.MenuText
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.Window
        DataGridViewCellStyle2.Padding = New Padding(2)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Columns.AddRange(New DataGridViewColumn() {CustomerId, CustomerFName, CustomerLName, CustomerEmail})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(60))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New Padding(2)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(53), CByte(63), CByte(70))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvCustomers.DefaultCellStyle = DataGridViewCellStyle3
        dgvCustomers.GridColor = Color.White
        dgvCustomers.Location = New Point(42, 125)
        dgvCustomers.Margin = New Padding(3, 2, 3, 2)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New Padding(2)
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.Control
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvCustomers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvCustomers.RowHeadersWidth = 51
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12F)
        DataGridViewCellStyle5.Padding = New Padding(2)
        dgvCustomers.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvCustomers.RowTemplate.Height = 29
        dgvCustomers.ScrollBars = ScrollBars.None
        dgvCustomers.Size = New Size(672, 278)
        dgvCustomers.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 30F, FontStyle.Bold)
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(232, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(301, 54)
        lblTitle.TabIndex = 56
        lblTitle.Text = "Customer DGV"
        ' 
        ' btnRemoveRow
        ' 
        btnRemoveRow.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnRemoveRow.FlatStyle = FlatStyle.Flat
        btnRemoveRow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnRemoveRow.Location = New Point(480, 527)
        btnRemoveRow.Margin = New Padding(3, 2, 3, 2)
        btnRemoveRow.Name = "btnRemoveRow"
        btnRemoveRow.Size = New Size(102, 46)
        btnRemoveRow.TabIndex = 66
        btnRemoveRow.Text = "Remove"
        btnRemoveRow.UseVisualStyleBackColor = False
        ' 
        ' btnAddDataDGV
        ' 
        btnAddDataDGV.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnAddDataDGV.FlatStyle = FlatStyle.Flat
        btnAddDataDGV.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAddDataDGV.Location = New Point(480, 465)
        btnAddDataDGV.Margin = New Padding(3, 2, 3, 2)
        btnAddDataDGV.Name = "btnAddDataDGV"
        btnAddDataDGV.Size = New Size(102, 46)
        btnAddDataDGV.TabIndex = 65
        btnAddDataDGV.Text = "Add Data"
        btnAddDataDGV.UseVisualStyleBackColor = False
        ' 
        ' btnLoadDataDGV
        ' 
        btnLoadDataDGV.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnLoadDataDGV.FlatStyle = FlatStyle.Flat
        btnLoadDataDGV.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnLoadDataDGV.Location = New Point(612, 525)
        btnLoadDataDGV.Margin = New Padding(3, 2, 3, 2)
        btnLoadDataDGV.Name = "btnLoadDataDGV"
        btnLoadDataDGV.Size = New Size(102, 46)
        btnLoadDataDGV.TabIndex = 64
        btnLoadDataDGV.Text = "Load Data "
        btnLoadDataDGV.UseVisualStyleBackColor = False
        ' 
        ' btnClearDGV
        ' 
        btnClearDGV.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnClearDGV.FlatStyle = FlatStyle.Flat
        btnClearDGV.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnClearDGV.Location = New Point(612, 465)
        btnClearDGV.Margin = New Padding(3, 2, 3, 2)
        btnClearDGV.Name = "btnClearDGV"
        btnClearDGV.Size = New Size(102, 43)
        btnClearDGV.TabIndex = 63
        btnClearDGV.Text = "Clear DGV"
        btnClearDGV.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(41, 578)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 21)
        Label3.TabIndex = 62
        Label3.Text = "Last Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(41, 520)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 21)
        Label2.TabIndex = 61
        Label2.Text = "First Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(72, 465)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 21)
        Label1.TabIndex = 60
        Label1.Text = "ID:"
        ' 
        ' txtCustomerLName
        ' 
        txtCustomerLName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerLName.Location = New Point(159, 578)
        txtCustomerLName.Margin = New Padding(3, 2, 3, 2)
        txtCustomerLName.Name = "txtCustomerLName"
        txtCustomerLName.Size = New Size(258, 29)
        txtCustomerLName.TabIndex = 59
        ' 
        ' txtCustomerFName
        ' 
        txtCustomerFName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerFName.Location = New Point(159, 520)
        txtCustomerFName.Margin = New Padding(3, 2, 3, 2)
        txtCustomerFName.Name = "txtCustomerFName"
        txtCustomerFName.Size = New Size(258, 29)
        txtCustomerFName.TabIndex = 58
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerID.Location = New Point(159, 465)
        txtCustomerID.Margin = New Padding(3, 2, 3, 2)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(258, 29)
        txtCustomerID.TabIndex = 57
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblEmail.ForeColor = SystemColors.Control
        lblEmail.Location = New Point(58, 636)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(57, 21)
        lblEmail.TabIndex = 68
        lblEmail.Text = "Email:"
        ' 
        ' txtCustomerEmail
        ' 
        txtCustomerEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerEmail.Location = New Point(159, 636)
        txtCustomerEmail.Margin = New Padding(3, 2, 3, 2)
        txtCustomerEmail.Name = "txtCustomerEmail"
        txtCustomerEmail.Size = New Size(258, 29)
        txtCustomerEmail.TabIndex = 67
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(559, 626)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(155, 37)
        btnExit.TabIndex = 69
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' CustomerEmail
        ' 
        CustomerEmail.HeaderText = "Email"
        CustomerEmail.Name = "CustomerEmail"
        CustomerEmail.ReadOnly = True
        CustomerEmail.Width = 270
        ' 
        ' CustomerLName
        ' 
        CustomerLName.HeaderText = "Last Name"
        CustomerLName.Name = "CustomerLName"
        CustomerLName.ReadOnly = True
        CustomerLName.Width = 150
        ' 
        ' CustomerFName
        ' 
        CustomerFName.HeaderText = "First Name"
        CustomerFName.Name = "CustomerFName"
        CustomerFName.ReadOnly = True
        CustomerFName.Width = 150
        ' 
        ' CustomerId
        ' 
        CustomerId.HeaderText = "ID"
        CustomerId.Name = "CustomerId"
        CustomerId.ReadOnly = True
        CustomerId.Width = 50
        ' 
        ' frmCustomerDGV
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(756, 686)
        Controls.Add(btnExit)
        Controls.Add(lblEmail)
        Controls.Add(txtCustomerEmail)
        Controls.Add(btnRemoveRow)
        Controls.Add(btnAddDataDGV)
        Controls.Add(btnLoadDataDGV)
        Controls.Add(btnClearDGV)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtCustomerLName)
        Controls.Add(txtCustomerFName)
        Controls.Add(txtCustomerID)
        Controls.Add(lblTitle)
        Controls.Add(dgvCustomers)
        Name = "frmCustomerDGV"
        Text = "frmCustomerDGV"
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRemoveRow As Button
    Friend WithEvents btnAddDataDGV As Button
    Friend WithEvents btnLoadDataDGV As Button
    Friend WithEvents btnClearDGV As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerLName As TextBox
    Friend WithEvents txtCustomerFName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents CustomerId As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerLName As DataGridViewTextBoxColumn
    Friend WithEvents CustomerEmail As DataGridViewTextBoxColumn
End Class
