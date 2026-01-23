<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateUser
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
        GroupBox = New GroupBox()
        radInactiveUser = New RadioButton()
        radActiveUser = New RadioButton()
        lblLastName = New Label()
        lblFirstName = New Label()
        lblPassword = New Label()
        lblUserName = New Label()
        txtUserLName = New TextBox()
        txtUserFName = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnExit = New Button()
        btnUpdateUser = New Button()
        GroupBox1 = New GroupBox()
        radSearchByUsername = New RadioButton()
        radSearchByID = New RadioButton()
        lblSearchUsername = New Label()
        txtSearchUsername = New TextBox()
        btnFindUser = New Button()
        lblUserId = New Label()
        txtSearchUserID = New TextBox()
        btnCancelReset = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(241, 25)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(205, 45)
        lblTitle.TabIndex = 46
        lblTitle.Text = "Update User"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources.update_user
        PictureBox1.Image = My.Resources.Resources.update_user
        PictureBox1.InitialImage = My.Resources.Resources.update_user
        PictureBox1.Location = New Point(390, 335)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(252, 275)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 45
        PictureBox1.TabStop = False
        ' 
        ' GroupBox
        ' 
        GroupBox.Controls.Add(radInactiveUser)
        GroupBox.Controls.Add(radActiveUser)
        GroupBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBox.ForeColor = SystemColors.ControlLightLight
        GroupBox.Location = New Point(52, 588)
        GroupBox.Margin = New Padding(3, 2, 3, 2)
        GroupBox.Name = "GroupBox"
        GroupBox.Padding = New Padding(3, 2, 3, 2)
        GroupBox.Size = New Size(293, 66)
        GroupBox.TabIndex = 36
        GroupBox.TabStop = False
        GroupBox.Text = "User Status"
        GroupBox.Visible = False
        ' 
        ' radInactiveUser
        ' 
        radInactiveUser.AutoSize = True
        radInactiveUser.Location = New Point(145, 27)
        radInactiveUser.Margin = New Padding(3, 2, 3, 2)
        radInactiveUser.Name = "radInactiveUser"
        radInactiveUser.Size = New Size(127, 25)
        radInactiveUser.TabIndex = 1
        radInactiveUser.TabStop = True
        radInactiveUser.Text = "Inactive User"
        radInactiveUser.UseVisualStyleBackColor = True
        ' 
        ' radActiveUser
        ' 
        radActiveUser.AutoSize = True
        radActiveUser.Location = New Point(6, 25)
        radActiveUser.Margin = New Padding(3, 2, 3, 2)
        radActiveUser.Name = "radActiveUser"
        radActiveUser.Size = New Size(114, 25)
        radActiveUser.TabIndex = 0
        radActiveUser.TabStop = True
        radActiveUser.Text = "Active User"
        radActiveUser.UseVisualStyleBackColor = True
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblLastName.ForeColor = SystemColors.ControlLightLight
        lblLastName.Location = New Point(46, 361)
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
        lblFirstName.Location = New Point(46, 300)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(96, 21)
        lblFirstName.TabIndex = 42
        lblFirstName.Text = "First Name:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPassword.ForeColor = SystemColors.ControlLightLight
        lblPassword.Location = New Point(46, 501)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 21)
        lblPassword.TabIndex = 40
        lblPassword.Text = "Password:"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblUserName.ForeColor = SystemColors.ControlLightLight
        lblUserName.Location = New Point(46, 432)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(91, 21)
        lblUserName.TabIndex = 38
        lblUserName.Text = "Username:"
        ' 
        ' txtUserLName
        ' 
        txtUserLName.Enabled = False
        txtUserLName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUserLName.ForeColor = SystemColors.ActiveCaptionText
        txtUserLName.Location = New Point(46, 384)
        txtUserLName.Margin = New Padding(3, 2, 3, 2)
        txtUserLName.Name = "txtUserLName"
        txtUserLName.Size = New Size(312, 29)
        txtUserLName.TabIndex = 35
        ' 
        ' txtUserFName
        ' 
        txtUserFName.Enabled = False
        txtUserFName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUserFName.ForeColor = SystemColors.ActiveCaptionText
        txtUserFName.Location = New Point(46, 322)
        txtUserFName.Margin = New Padding(3, 2, 3, 2)
        txtUserFName.Name = "txtUserFName"
        txtUserFName.Size = New Size(312, 29)
        txtUserFName.TabIndex = 34
        ' 
        ' txtPassword
        ' 
        txtPassword.Enabled = False
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPassword.ForeColor = SystemColors.ActiveCaptionText
        txtPassword.Location = New Point(46, 524)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(312, 29)
        txtPassword.TabIndex = 32
        ' 
        ' txtUsername
        ' 
        txtUsername.Enabled = False
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUsername.ForeColor = SystemColors.ActiveCaptionText
        txtUsername.Location = New Point(46, 455)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(312, 29)
        txtUsername.TabIndex = 31
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(470, 678)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(155, 37)
        btnExit.TabIndex = 41
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateUser
        ' 
        btnUpdateUser.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnUpdateUser.FlatStyle = FlatStyle.Flat
        btnUpdateUser.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnUpdateUser.ForeColor = SystemColors.ActiveCaptionText
        btnUpdateUser.Location = New Point(46, 678)
        btnUpdateUser.Margin = New Padding(3, 2, 3, 2)
        btnUpdateUser.Name = "btnUpdateUser"
        btnUpdateUser.Size = New Size(177, 37)
        btnUpdateUser.TabIndex = 37
        btnUpdateUser.Text = "Update User"
        btnUpdateUser.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radSearchByUsername)
        GroupBox1.Controls.Add(radSearchByID)
        GroupBox1.Controls.Add(lblSearchUsername)
        GroupBox1.Controls.Add(txtSearchUsername)
        GroupBox1.Controls.Add(btnFindUser)
        GroupBox1.Controls.Add(lblUserId)
        GroupBox1.Controls.Add(txtSearchUserID)
        GroupBox1.Location = New Point(46, 114)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(561, 157)
        GroupBox1.TabIndex = 59
        GroupBox1.TabStop = False
        ' 
        ' radSearchByUsername
        ' 
        radSearchByUsername.AutoSize = True
        radSearchByUsername.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        radSearchByUsername.ForeColor = SystemColors.ControlLightLight
        radSearchByUsername.Location = New Point(216, 19)
        radSearchByUsername.Margin = New Padding(3, 2, 3, 2)
        radSearchByUsername.Name = "radSearchByUsername"
        radSearchByUsername.Size = New Size(196, 24)
        radSearchByUsername.TabIndex = 50
        radSearchByUsername.TabStop = True
        radSearchByUsername.Text = "Search By Username"
        radSearchByUsername.UseVisualStyleBackColor = True
        ' 
        ' radSearchByID
        ' 
        radSearchByID.AutoSize = True
        radSearchByID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        radSearchByID.ForeColor = SystemColors.ControlLightLight
        radSearchByID.Location = New Point(27, 19)
        radSearchByID.Margin = New Padding(3, 2, 3, 2)
        radSearchByID.Name = "radSearchByID"
        radSearchByID.Size = New Size(133, 24)
        radSearchByID.TabIndex = 49
        radSearchByID.TabStop = True
        radSearchByID.Text = "Search By ID"
        radSearchByID.UseVisualStyleBackColor = True
        ' 
        ' lblSearchUsername
        ' 
        lblSearchUsername.AutoSize = True
        lblSearchUsername.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblSearchUsername.ForeColor = SystemColors.ControlLightLight
        lblSearchUsername.Location = New Point(26, 108)
        lblSearchUsername.Name = "lblSearchUsername"
        lblSearchUsername.Size = New Size(96, 20)
        lblSearchUsername.TabIndex = 48
        lblSearchUsername.Text = "Username:"
        ' 
        ' txtSearchUsername
        ' 
        txtSearchUsername.BorderStyle = BorderStyle.FixedSingle
        txtSearchUsername.Enabled = False
        txtSearchUsername.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        txtSearchUsername.Location = New Point(128, 106)
        txtSearchUsername.Margin = New Padding(3, 2, 3, 2)
        txtSearchUsername.Name = "txtSearchUsername"
        txtSearchUsername.Size = New Size(224, 26)
        txtSearchUsername.TabIndex = 2
        ' 
        ' btnFindUser
        ' 
        btnFindUser.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnFindUser.FlatStyle = FlatStyle.Flat
        btnFindUser.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnFindUser.ForeColor = SystemColors.ActiveCaptionText
        btnFindUser.Location = New Point(389, 66)
        btnFindUser.Margin = New Padding(3, 2, 3, 2)
        btnFindUser.Name = "btnFindUser"
        btnFindUser.Size = New Size(138, 52)
        btnFindUser.TabIndex = 3
        btnFindUser.Text = "Find User"
        btnFindUser.UseVisualStyleBackColor = False
        ' 
        ' lblUserId
        ' 
        lblUserId.AutoSize = True
        lblUserId.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblUserId.ForeColor = SystemColors.ControlLightLight
        lblUserId.Location = New Point(27, 66)
        lblUserId.Name = "lblUserId"
        lblUserId.Size = New Size(76, 20)
        lblUserId.TabIndex = 45
        lblUserId.Text = "User ID:"
        ' 
        ' txtSearchUserID
        ' 
        txtSearchUserID.BorderStyle = BorderStyle.FixedSingle
        txtSearchUserID.Enabled = False
        txtSearchUserID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        txtSearchUserID.Location = New Point(128, 64)
        txtSearchUserID.Margin = New Padding(3, 2, 3, 2)
        txtSearchUserID.Name = "txtSearchUserID"
        txtSearchUserID.Size = New Size(224, 26)
        txtSearchUserID.TabIndex = 1
        ' 
        ' btnCancelReset
        ' 
        btnCancelReset.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnCancelReset.FlatStyle = FlatStyle.Flat
        btnCancelReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelReset.ForeColor = SystemColors.ActiveCaptionText
        btnCancelReset.Location = New Point(271, 678)
        btnCancelReset.Margin = New Padding(3, 2, 3, 2)
        btnCancelReset.Name = "btnCancelReset"
        btnCancelReset.Size = New Size(153, 37)
        btnCancelReset.TabIndex = 60
        btnCancelReset.Text = "Cancel and reset"
        btnCancelReset.UseVisualStyleBackColor = False
        ' 
        ' frmUpdateUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(678, 726)
        Controls.Add(btnCancelReset)
        Controls.Add(GroupBox1)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(lblPassword)
        Controls.Add(lblUserName)
        Controls.Add(txtUserLName)
        Controls.Add(txtUserFName)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnExit)
        Controls.Add(btnUpdateUser)
        Name = "frmUpdateUser"
        Text = "frmUpdateUser"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox.ResumeLayout(False)
        GroupBox.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents radInactiveUser As RadioButton
    Friend WithEvents radActiveUser As RadioButton
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUserLName As TextBox
    Friend WithEvents txtUserFName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSearchByUsername As RadioButton
    Friend WithEvents radSearchByID As RadioButton
    Friend WithEvents lblSearchUsername As Label
    Friend WithEvents txtSearchUsername As TextBox
    Friend WithEvents btnFindUser As Button
    Friend WithEvents lblUserId As Label
    Friend WithEvents txtSearchUserID As TextBox
    Friend WithEvents btnCancelReset As Button
End Class
