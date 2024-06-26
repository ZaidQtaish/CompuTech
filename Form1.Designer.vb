<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtUser = New TextBox()
        txtPass = New TextBox()
        lblUser = New Label()
        lblPass = New Label()
        picLogo = New PictureBox()
        lblLogin = New Label()
        btnExit = New Button()
        btnReset = New Button()
        btnLogin = New Button()
        chkRmbr = New CheckBox()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUser
        ' 
        txtUser.BorderStyle = BorderStyle.FixedSingle
        txtUser.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUser.Location = New Point(67, 157)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(346, 33)
        txtUser.TabIndex = 1
        ' 
        ' txtPass
        ' 
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPass.ForeColor = SystemColors.WindowText
        txtPass.Location = New Point(67, 241)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(346, 33)
        txtPass.TabIndex = 2
        txtPass.UseSystemPasswordChar = True
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = SystemColors.Window
        lblUser.Location = New Point(67, 129)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(106, 25)
        lblUser.TabIndex = 3
        lblUser.Text = "Username:"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPass.ForeColor = SystemColors.Window
        lblPass.Location = New Point(67, 213)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(102, 25)
        lblPass.TabIndex = 4
        lblPass.Text = "Password:"
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(446, -29)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(431, 536)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 5
        picLogo.TabStop = False
        ' 
        ' lblLogin
        ' 
        lblLogin.AutoSize = True
        lblLogin.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLogin.ForeColor = SystemColors.Window
        lblLogin.Location = New Point(189, 33)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(120, 50)
        lblLogin.TabIndex = 6
        lblLogin.Text = "Login"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = Color.Black
        btnExit.Location = New Point(256, 397)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(144, 29)
        btnExit.TabIndex = 9
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnReset.ForeColor = Color.Black
        btnReset.Location = New Point(79, 397)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(144, 29)
        btnReset.TabIndex = 8
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnLogin.ForeColor = Color.Black
        btnLogin.Location = New Point(79, 339)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(321, 39)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' chkRmbr
        ' 
        chkRmbr.AutoSize = True
        chkRmbr.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkRmbr.ForeColor = SystemColors.Window
        chkRmbr.Location = New Point(67, 290)
        chkRmbr.Name = "chkRmbr"
        chkRmbr.Size = New Size(140, 25)
        chkRmbr.TabIndex = 10
        chkRmbr.Text = "Remember Me"
        chkRmbr.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(864, 451)
        Controls.Add(chkRmbr)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnLogin)
        Controls.Add(lblLogin)
        Controls.Add(picLogo)
        Controls.Add(lblPass)
        Controls.Add(lblUser)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents chkRmbr As CheckBox

End Class
