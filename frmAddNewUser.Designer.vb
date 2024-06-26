<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewUser
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
        lblConfirmPass = New Label()
        txtConfirmPassword = New TextBox()
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
        Button3 = New Button()
        btnCancelReset = New Button()
        btnAddNewUser = New Button()
        lblTitle = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources.add_user
        PictureBox1.Image = My.Resources.Resources.add_user
        PictureBox1.InitialImage = My.Resources.Resources.add_user
        PictureBox1.Location = New Point(502, 136)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 236)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' lblConfirmPass
        ' 
        lblConfirmPass.AutoSize = True
        lblConfirmPass.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblConfirmPass.ForeColor = SystemColors.ControlLightLight
        lblConfirmPass.Location = New Point(50, 409)
        lblConfirmPass.Name = "lblConfirmPass"
        lblConfirmPass.Size = New Size(152, 21)
        lblConfirmPass.TabIndex = 28
        lblConfirmPass.Text = "Confirm Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtConfirmPassword.ForeColor = SystemColors.ActiveCaptionText
        txtConfirmPassword.Location = New Point(50, 432)
        txtConfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(312, 29)
        txtConfirmPassword.TabIndex = 17
        ' 
        ' GroupBox
        ' 
        GroupBox.Controls.Add(radInactiveUser)
        GroupBox.Controls.Add(radActiveUser)
        GroupBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBox.ForeColor = SystemColors.ControlLightLight
        GroupBox.Location = New Point(438, 409)
        GroupBox.Margin = New Padding(3, 2, 3, 2)
        GroupBox.Name = "GroupBox"
        GroupBox.Padding = New Padding(3, 2, 3, 2)
        GroupBox.Size = New Size(327, 66)
        GroupBox.TabIndex = 20
        GroupBox.TabStop = False
        GroupBox.Text = "User Status"
        ' 
        ' radInactiveUser
        ' 
        radInactiveUser.AutoSize = True
        radInactiveUser.Location = New Point(145, 28)
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
        radActiveUser.Location = New Point(6, 26)
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
        lblLastName.Location = New Point(50, 197)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(94, 21)
        lblLastName.TabIndex = 27
        lblLastName.Text = "Last Name:"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFirstName.ForeColor = SystemColors.ControlLightLight
        lblFirstName.Location = New Point(50, 136)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(96, 21)
        lblFirstName.TabIndex = 26
        lblFirstName.Text = "First Name:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPassword.ForeColor = SystemColors.ControlLightLight
        lblPassword.Location = New Point(50, 337)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(86, 21)
        lblPassword.TabIndex = 24
        lblPassword.Text = "Password:"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblUserName.ForeColor = SystemColors.ControlLightLight
        lblUserName.Location = New Point(50, 268)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(91, 21)
        lblUserName.TabIndex = 22
        lblUserName.Text = "Username:"
        ' 
        ' txtUserLName
        ' 
        txtUserLName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUserLName.ForeColor = SystemColors.ActiveCaptionText
        txtUserLName.Location = New Point(50, 220)
        txtUserLName.Margin = New Padding(3, 2, 3, 2)
        txtUserLName.Name = "txtUserLName"
        txtUserLName.Size = New Size(312, 29)
        txtUserLName.TabIndex = 19
        ' 
        ' txtUserFName
        ' 
        txtUserFName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUserFName.ForeColor = SystemColors.ActiveCaptionText
        txtUserFName.Location = New Point(50, 158)
        txtUserFName.Margin = New Padding(3, 2, 3, 2)
        txtUserFName.Name = "txtUserFName"
        txtUserFName.Size = New Size(312, 29)
        txtUserFName.TabIndex = 18
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtPassword.ForeColor = SystemColors.ActiveCaptionText
        txtPassword.Location = New Point(50, 360)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(312, 29)
        txtPassword.TabIndex = 16
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtUsername.ForeColor = SystemColors.ActiveCaptionText
        txtUsername.Location = New Point(50, 291)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(312, 29)
        txtUsername.TabIndex = 15
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Location = New Point(492, 508)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(155, 37)
        Button3.TabIndex = 25
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnCancelReset
        ' 
        btnCancelReset.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnCancelReset.FlatStyle = FlatStyle.Flat
        btnCancelReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelReset.ForeColor = SystemColors.ActiveCaptionText
        btnCancelReset.Location = New Point(283, 508)
        btnCancelReset.Margin = New Padding(3, 2, 3, 2)
        btnCancelReset.Name = "btnCancelReset"
        btnCancelReset.Size = New Size(153, 37)
        btnCancelReset.TabIndex = 23
        btnCancelReset.Text = "Cancel and reset"
        btnCancelReset.UseVisualStyleBackColor = False
        ' 
        ' btnAddNewUser
        ' 
        btnAddNewUser.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnAddNewUser.FlatStyle = FlatStyle.Flat
        btnAddNewUser.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnAddNewUser.ForeColor = SystemColors.ActiveCaptionText
        btnAddNewUser.Location = New Point(50, 508)
        btnAddNewUser.Margin = New Padding(3, 2, 3, 2)
        btnAddNewUser.Name = "btnAddNewUser"
        btnAddNewUser.Size = New Size(177, 37)
        btnAddNewUser.TabIndex = 21
        btnAddNewUser.Text = "Add New User"
        btnAddNewUser.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(283, 34)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(236, 45)
        lblTitle.TabIndex = 30
        lblTitle.Text = "Add New User"
        ' 
        ' frmAddNewUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(808, 571)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Controls.Add(lblConfirmPass)
        Controls.Add(txtConfirmPassword)
        Controls.Add(GroupBox)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(lblPassword)
        Controls.Add(lblUserName)
        Controls.Add(txtUserLName)
        Controls.Add(txtUserFName)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Button3)
        Controls.Add(btnCancelReset)
        Controls.Add(btnAddNewUser)
        Name = "frmAddNewUser"
        Text = "frmAddNewUser"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox.ResumeLayout(False)
        GroupBox.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
    Friend WithEvents txtUserLName As TextBox
    Friend WithEvents txtUserFName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents btnCancelReset As Button
    Friend WithEvents btnAddNewUser As Button
    Friend WithEvents lblTitle As Label
End Class
