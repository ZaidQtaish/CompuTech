<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerInfo
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
        PictureBox1 = New PictureBox()
        lblUserId = New Label()
        txtCustomerId = New TextBox()
        btnFirstRecord = New Button()
        btnLastRecord = New Button()
        btnPrevRecord = New Button()
        btnNextRecord = New Button()
        lblTitle = New Label()
        lblLastName = New Label()
        lblFirstName = New Label()
        lblEmail = New Label()
        txtCustomerLName = New TextBox()
        txtCustomerFName = New TextBox()
        txtEmail = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources.user
        PictureBox1.Image = My.Resources.Resources.user1
        PictureBox1.InitialImage = My.Resources.Resources.user
        PictureBox1.Location = New Point(12, 11)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 104)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 64
        PictureBox1.TabStop = False
        ' 
        ' lblUserId
        ' 
        lblUserId.AutoSize = True
        lblUserId.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblUserId.ForeColor = SystemColors.ControlLightLight
        lblUserId.Location = New Point(102, 147)
        lblUserId.Name = "lblUserId"
        lblUserId.Size = New Size(69, 21)
        lblUserId.TabIndex = 61
        lblUserId.Text = "User ID:"
        ' 
        ' txtCustomerId
        ' 
        txtCustomerId.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerId.ForeColor = SystemColors.ActiveCaptionText
        txtCustomerId.Location = New Point(204, 147)
        txtCustomerId.Margin = New Padding(3, 2, 3, 2)
        txtCustomerId.Name = "txtCustomerId"
        txtCustomerId.ReadOnly = True
        txtCustomerId.Size = New Size(312, 29)
        txtCustomerId.TabIndex = 60
        ' 
        ' btnFirstRecord
        ' 
        btnFirstRecord.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnFirstRecord.CausesValidation = False
        btnFirstRecord.FlatStyle = FlatStyle.Flat
        btnFirstRecord.Font = New Font("Microsoft JhengHei", 15.75F, FontStyle.Bold)
        btnFirstRecord.Location = New Point(62, 400)
        btnFirstRecord.Margin = New Padding(3, 2, 3, 2)
        btnFirstRecord.Name = "btnFirstRecord"
        btnFirstRecord.Size = New Size(115, 35)
        btnFirstRecord.TabIndex = 59
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
        btnLastRecord.Location = New Point(480, 400)
        btnLastRecord.Margin = New Padding(3, 2, 3, 2)
        btnLastRecord.Name = "btnLastRecord"
        btnLastRecord.Size = New Size(115, 35)
        btnLastRecord.TabIndex = 58
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
        btnPrevRecord.Location = New Point(204, 400)
        btnPrevRecord.Margin = New Padding(3, 2, 3, 2)
        btnPrevRecord.Name = "btnPrevRecord"
        btnPrevRecord.Size = New Size(115, 35)
        btnPrevRecord.TabIndex = 57
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
        btnNextRecord.Location = New Point(340, 400)
        btnNextRecord.Margin = New Padding(3, 2, 3, 2)
        btnNextRecord.Name = "btnNextRecord"
        btnNextRecord.Size = New Size(115, 35)
        btnNextRecord.TabIndex = 56
        btnNextRecord.Text = ">"
        btnNextRecord.TextAlign = ContentAlignment.TopCenter
        btnNextRecord.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(222, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(234, 45)
        lblTitle.TabIndex = 55
        lblTitle.Text = "Customer Info"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblLastName.ForeColor = SystemColors.ControlLightLight
        lblLastName.Location = New Point(94, 270)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(94, 21)
        lblLastName.TabIndex = 54
        lblLastName.Text = "Last Name:"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFirstName.ForeColor = SystemColors.ControlLightLight
        lblFirstName.Location = New Point(94, 208)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(96, 21)
        lblFirstName.TabIndex = 53
        lblFirstName.Text = "First Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblEmail.ForeColor = SystemColors.ControlLightLight
        lblEmail.Location = New Point(114, 334)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(57, 21)
        lblEmail.TabIndex = 51
        lblEmail.Text = "Email:"
        ' 
        ' txtCustomerLName
        ' 
        txtCustomerLName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerLName.ForeColor = SystemColors.ActiveCaptionText
        txtCustomerLName.Location = New Point(204, 270)
        txtCustomerLName.Margin = New Padding(3, 2, 3, 2)
        txtCustomerLName.Name = "txtCustomerLName"
        txtCustomerLName.ReadOnly = True
        txtCustomerLName.Size = New Size(312, 29)
        txtCustomerLName.TabIndex = 50
        ' 
        ' txtCustomerFName
        ' 
        txtCustomerFName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerFName.ForeColor = SystemColors.ActiveCaptionText
        txtCustomerFName.Location = New Point(204, 208)
        txtCustomerFName.Margin = New Padding(3, 2, 3, 2)
        txtCustomerFName.Name = "txtCustomerFName"
        txtCustomerFName.ReadOnly = True
        txtCustomerFName.Size = New Size(312, 29)
        txtCustomerFName.TabIndex = 49
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtEmail.ForeColor = SystemColors.ActiveCaptionText
        txtEmail.Location = New Point(204, 334)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(312, 29)
        txtEmail.TabIndex = 47
        ' 
        ' frmCustomerInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(662, 461)
        Controls.Add(PictureBox1)
        Controls.Add(lblUserId)
        Controls.Add(txtCustomerId)
        Controls.Add(btnFirstRecord)
        Controls.Add(btnLastRecord)
        Controls.Add(btnPrevRecord)
        Controls.Add(btnNextRecord)
        Controls.Add(lblTitle)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(lblEmail)
        Controls.Add(txtCustomerLName)
        Controls.Add(txtCustomerFName)
        Controls.Add(txtEmail)
        Name = "frmCustomerInfo"
        Text = "frmCustomerInfo"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblUserId As Label
    Friend WithEvents txtCustomerId As TextBox
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents btnLastRecord As Button
    Friend WithEvents btnPrevRecord As Button
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtCustomerLName As TextBox
    Friend WithEvents txtCustomerFName As TextBox
    Friend WithEvents txtEmail As TextBox
End Class
