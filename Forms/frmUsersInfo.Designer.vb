<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersInfo
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
        lblLastName = New Label()
        lblFirstName = New Label()
        lblPassword = New Label()
        lblUserName = New Label()
        txtUserLName = New TextBox()
        txtUserFName = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblTitle = New Label()
        btnFirstRecord = New Button()
        btnLastRecord = New Button()
        btnPrevRecord = New Button()
        btnNextRecord = New Button()
        lblUserId = New Label()
        txtUserId = New TextBox()
        lblActive = New Label()
        lblInactive = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblLastName.ForeColor = SystemColors.ControlLightLight
        lblLastName.Location = New Point(94, 253)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(94, 21)
        lblLastName.TabIndex = 35
        lblLastName.Text = "Last Name:"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFirstName.ForeColor = SystemColors.ControlLightLight
        lblFirstName.Location = New Point(94, 191)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(96, 21)
        lblFirstName.TabIndex = 34
        lblFirstName.Text = "First Name:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPassword.ForeColor = SystemColors.ControlLightLight
        lblPassword.Location = New Point(102, 380)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 21)
        lblPassword.TabIndex = 33
        lblPassword.Text = "Password:"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblUserName.ForeColor = SystemColors.ControlLightLight
        lblUserName.Location = New Point(97, 317)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(91, 21)
        lblUserName.TabIndex = 32
        lblUserName.Text = "Username:"
        ' 
        ' txtUserLName
        ' 
        txtUserLName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUserLName.ForeColor = SystemColors.ActiveCaptionText
        txtUserLName.Location = New Point(204, 253)
        txtUserLName.Margin = New Padding(3, 2, 3, 2)
        txtUserLName.Name = "txtUserLName"
        txtUserLName.ReadOnly = True
        txtUserLName.Size = New Size(312, 29)
        txtUserLName.TabIndex = 31
        ' 
        ' txtUserFName
        ' 
        txtUserFName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUserFName.ForeColor = SystemColors.ActiveCaptionText
        txtUserFName.Location = New Point(204, 191)
        txtUserFName.Margin = New Padding(3, 2, 3, 2)
        txtUserFName.Name = "txtUserFName"
        txtUserFName.ReadOnly = True
        txtUserFName.Size = New Size(312, 29)
        txtUserFName.TabIndex = 30
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPassword.ForeColor = SystemColors.ActiveCaptionText
        txtPassword.Location = New Point(204, 380)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.ReadOnly = True
        txtPassword.Size = New Size(312, 29)
        txtPassword.TabIndex = 29
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUsername.ForeColor = SystemColors.ActiveCaptionText
        txtUsername.Location = New Point(204, 317)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(312, 29)
        txtUsername.TabIndex = 28
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(253, 26)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(171, 45)
        lblTitle.TabIndex = 36
        lblTitle.Text = "Users Info"
        ' 
        ' btnFirstRecord
        ' 
        btnFirstRecord.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnFirstRecord.CausesValidation = False
        btnFirstRecord.FlatStyle = FlatStyle.Flat
        btnFirstRecord.Font = New Font("Microsoft JhengHei", 15.75F, FontStyle.Bold)
        btnFirstRecord.Location = New Point(63, 519)
        btnFirstRecord.Margin = New Padding(3, 2, 3, 2)
        btnFirstRecord.Name = "btnFirstRecord"
        btnFirstRecord.Size = New Size(115, 35)
        btnFirstRecord.TabIndex = 40
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
        btnLastRecord.Location = New Point(481, 519)
        btnLastRecord.Margin = New Padding(3, 2, 3, 2)
        btnLastRecord.Name = "btnLastRecord"
        btnLastRecord.Size = New Size(115, 35)
        btnLastRecord.TabIndex = 39
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
        btnPrevRecord.Location = New Point(205, 519)
        btnPrevRecord.Margin = New Padding(3, 2, 3, 2)
        btnPrevRecord.Name = "btnPrevRecord"
        btnPrevRecord.Size = New Size(115, 35)
        btnPrevRecord.TabIndex = 38
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
        btnNextRecord.Location = New Point(341, 519)
        btnNextRecord.Margin = New Padding(3, 2, 3, 2)
        btnNextRecord.Name = "btnNextRecord"
        btnNextRecord.Size = New Size(115, 35)
        btnNextRecord.TabIndex = 37
        btnNextRecord.Text = ">"
        btnNextRecord.TextAlign = ContentAlignment.TopCenter
        btnNextRecord.UseVisualStyleBackColor = False
        ' 
        ' lblUserId
        ' 
        lblUserId.AutoSize = True
        lblUserId.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblUserId.ForeColor = SystemColors.ControlLightLight
        lblUserId.Location = New Point(102, 130)
        lblUserId.Name = "lblUserId"
        lblUserId.Size = New Size(69, 21)
        lblUserId.TabIndex = 42
        lblUserId.Text = "User ID:"
        ' 
        ' txtUserId
        ' 
        txtUserId.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUserId.ForeColor = SystemColors.ActiveCaptionText
        txtUserId.Location = New Point(204, 130)
        txtUserId.Margin = New Padding(3, 2, 3, 2)
        txtUserId.Name = "txtUserId"
        txtUserId.ReadOnly = True
        txtUserId.Size = New Size(312, 29)
        txtUserId.TabIndex = 41
        ' 
        ' lblActive
        ' 
        lblActive.AutoSize = True
        lblActive.BackColor = Color.FromArgb(CByte(65), CByte(176), CByte(110))
        lblActive.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblActive.ForeColor = SystemColors.ActiveCaptionText
        lblActive.Location = New Point(203, 441)
        lblActive.Name = "lblActive"
        lblActive.Size = New Size(98, 37)
        lblActive.TabIndex = 43
        lblActive.Text = "Active"
        lblActive.Visible = False
        ' 
        ' lblInactive
        ' 
        lblInactive.AutoSize = True
        lblInactive.BackColor = Color.FromArgb(CByte(182), CByte(8), CByte(8))
        lblInactive.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInactive.ForeColor = SystemColors.ActiveCaptionText
        lblInactive.Location = New Point(203, 441)
        lblInactive.Name = "lblInactive"
        lblInactive.Size = New Size(119, 37)
        lblInactive.TabIndex = 44
        lblInactive.Text = "Inactive"
        lblInactive.Visible = False
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
        PictureBox1.TabIndex = 46
        PictureBox1.TabStop = False
        ' 
        ' frmUsersInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(662, 586)
        Controls.Add(PictureBox1)
        Controls.Add(lblInactive)
        Controls.Add(lblActive)
        Controls.Add(lblUserId)
        Controls.Add(txtUserId)
        Controls.Add(btnFirstRecord)
        Controls.Add(btnLastRecord)
        Controls.Add(btnPrevRecord)
        Controls.Add(btnNextRecord)
        Controls.Add(lblTitle)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(lblPassword)
        Controls.Add(lblUserName)
        Controls.Add(txtUserLName)
        Controls.Add(txtUserFName)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "frmUsersInfo"
        Text = "frmUsersInfo"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUserLName As TextBox
    Friend WithEvents txtUserFName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnFirstRecord As Button
    Friend WithEvents btnLastRecord As Button
    Friend WithEvents btnPrevRecord As Button
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents lblUserId As Label
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents lblActive As Label
    Friend WithEvents lblInactive As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
