<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewCustomer
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
        lblTitle = New Label()
        PictureBox1 = New PictureBox()
        lblLastName = New Label()
        lblFirstName = New Label()
        txtLName = New TextBox()
        txtFName = New TextBox()
        btnExit = New Button()
        btnCancelReset = New Button()
        btnAddNewCustomer = New Button()
        lblCustomerEmail = New Label()
        txtCustomerEmail = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(215, 34)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(313, 45)
        lblTitle.TabIndex = 46
        lblTitle.Text = "Add New Customer"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources.add_user
        PictureBox1.Image = My.Resources.Resources.add_user
        PictureBox1.InitialImage = My.Resources.Resources.add_user
        PictureBox1.Location = New Point(461, 115)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 236)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 45
        PictureBox1.TabStop = False
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblLastName.ForeColor = SystemColors.ControlLightLight
        lblLastName.Location = New Point(47, 210)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(94, 21)
        lblLastName.TabIndex = 43
        lblLastName.Text = "Last Name:"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFirstName.ForeColor = SystemColors.ControlLightLight
        lblFirstName.Location = New Point(47, 132)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(96, 21)
        lblFirstName.TabIndex = 42
        lblFirstName.Text = "First Name:"
        ' 
        ' txtLName
        ' 
        txtLName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtLName.ForeColor = SystemColors.ActiveCaptionText
        txtLName.Location = New Point(47, 233)
        txtLName.Margin = New Padding(3, 2, 3, 2)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(312, 29)
        txtLName.TabIndex = 35
        ' 
        ' txtFName
        ' 
        txtFName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtFName.ForeColor = SystemColors.ActiveCaptionText
        txtFName.Location = New Point(47, 154)
        txtFName.Margin = New Padding(3, 2, 3, 2)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(312, 29)
        txtFName.TabIndex = 34
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(495, 392)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(155, 37)
        btnExit.TabIndex = 41
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnCancelReset
        ' 
        btnCancelReset.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnCancelReset.FlatStyle = FlatStyle.Flat
        btnCancelReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelReset.ForeColor = SystemColors.ActiveCaptionText
        btnCancelReset.Location = New Point(280, 392)
        btnCancelReset.Margin = New Padding(3, 2, 3, 2)
        btnCancelReset.Name = "btnCancelReset"
        btnCancelReset.Size = New Size(153, 37)
        btnCancelReset.TabIndex = 39
        btnCancelReset.Text = "Cancel and reset"
        btnCancelReset.UseVisualStyleBackColor = False
        ' 
        ' btnAddNewCustomer
        ' 
        btnAddNewCustomer.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnAddNewCustomer.FlatStyle = FlatStyle.Flat
        btnAddNewCustomer.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAddNewCustomer.ForeColor = SystemColors.ActiveCaptionText
        btnAddNewCustomer.Location = New Point(47, 392)
        btnAddNewCustomer.Margin = New Padding(3, 2, 3, 2)
        btnAddNewCustomer.Name = "btnAddNewCustomer"
        btnAddNewCustomer.Size = New Size(177, 37)
        btnAddNewCustomer.TabIndex = 37
        btnAddNewCustomer.Text = "Add New Customer"
        btnAddNewCustomer.UseVisualStyleBackColor = False
        ' 
        ' lblCustomerEmail
        ' 
        lblCustomerEmail.AutoSize = True
        lblCustomerEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCustomerEmail.ForeColor = SystemColors.ControlLightLight
        lblCustomerEmail.Location = New Point(47, 285)
        lblCustomerEmail.Name = "lblCustomerEmail"
        lblCustomerEmail.Size = New Size(130, 21)
        lblCustomerEmail.TabIndex = 48
        lblCustomerEmail.Text = "Customer Email"
        ' 
        ' txtCustomerEmail
        ' 
        txtCustomerEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerEmail.ForeColor = SystemColors.ActiveCaptionText
        txtCustomerEmail.Location = New Point(47, 308)
        txtCustomerEmail.Margin = New Padding(3, 2, 3, 2)
        txtCustomerEmail.Name = "txtCustomerEmail"
        txtCustomerEmail.Size = New Size(312, 29)
        txtCustomerEmail.TabIndex = 47
        ' 
        ' frmAddNewCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(743, 465)
        Controls.Add(lblCustomerEmail)
        Controls.Add(txtCustomerEmail)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtLName)
        Controls.Add(txtFName)
        Controls.Add(btnExit)
        Controls.Add(btnCancelReset)
        Controls.Add(btnAddNewCustomer)
        Name = "frmAddNewCustomer"
        Text = "frmAddNewCustomer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents radInactiveUser As RadioButton
    Friend WithEvents radActiveUser As RadioButton
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancelReset As Button
    Friend WithEvents btnAddNewCustomer As Button
    Friend WithEvents lblCustomerEmail As Label
    Friend WithEvents txtCustomerEmail As TextBox
End Class
