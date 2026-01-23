<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteCustomer
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
        btnExit = New Button()
        btnCancelReset = New Button()
        btnDeleteCustomer = New Button()
        GroupBox1 = New GroupBox()
        radSearchByLName = New RadioButton()
        radSearchByID = New RadioButton()
        lblSearchLName = New Label()
        txtSearchLastName = New TextBox()
        btnFindCustomer = New Button()
        lblCustID = New Label()
        txtSearchCusrtomerID = New TextBox()
        Label2 = New Label()
        txtCustomerEmail = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        txtCustomerLName = New TextBox()
        txtCustomerFName = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(325, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(269, 45)
        lblTitle.TabIndex = 57
        lblTitle.Text = "Delete Customer"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources.delete_user
        PictureBox1.Image = My.Resources.Resources.delete_user
        PictureBox1.InitialImage = My.Resources.Resources.delete_user
        PictureBox1.Location = New Point(689, 89)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 236)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 56
        PictureBox1.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(580, 493)
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
        btnCancelReset.Location = New Point(325, 493)
        btnCancelReset.Margin = New Padding(3, 2, 3, 2)
        btnCancelReset.Name = "btnCancelReset"
        btnCancelReset.Size = New Size(153, 37)
        btnCancelReset.TabIndex = 52
        btnCancelReset.Text = "Cancel and reset"
        btnCancelReset.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCustomer
        ' 
        btnDeleteCustomer.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnDeleteCustomer.FlatStyle = FlatStyle.Flat
        btnDeleteCustomer.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnDeleteCustomer.ForeColor = SystemColors.ActiveCaptionText
        btnDeleteCustomer.Location = New Point(51, 493)
        btnDeleteCustomer.Margin = New Padding(3, 2, 3, 2)
        btnDeleteCustomer.Name = "btnDeleteCustomer"
        btnDeleteCustomer.Size = New Size(177, 37)
        btnDeleteCustomer.TabIndex = 51
        btnDeleteCustomer.Text = "Delete Customer"
        btnDeleteCustomer.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radSearchByLName)
        GroupBox1.Controls.Add(radSearchByID)
        GroupBox1.Controls.Add(lblSearchLName)
        GroupBox1.Controls.Add(txtSearchLastName)
        GroupBox1.Controls.Add(btnFindCustomer)
        GroupBox1.Controls.Add(lblCustID)
        GroupBox1.Controls.Add(txtSearchCusrtomerID)
        GroupBox1.Location = New Point(51, 111)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(603, 157)
        GroupBox1.TabIndex = 58
        GroupBox1.TabStop = False
        ' 
        ' radSearchByLName
        ' 
        radSearchByLName.AutoSize = True
        radSearchByLName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        radSearchByLName.ForeColor = SystemColors.ControlLightLight
        radSearchByLName.Location = New Point(216, 20)
        radSearchByLName.Margin = New Padding(3, 2, 3, 2)
        radSearchByLName.Name = "radSearchByLName"
        radSearchByLName.Size = New Size(200, 24)
        radSearchByLName.TabIndex = 50
        radSearchByLName.TabStop = True
        radSearchByLName.Text = "Search By Last Name"
        radSearchByLName.UseVisualStyleBackColor = True
        ' 
        ' radSearchByID
        ' 
        radSearchByID.AutoSize = True
        radSearchByID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        radSearchByID.ForeColor = SystemColors.ControlLightLight
        radSearchByID.Location = New Point(27, 20)
        radSearchByID.Margin = New Padding(3, 2, 3, 2)
        radSearchByID.Name = "radSearchByID"
        radSearchByID.Size = New Size(133, 24)
        radSearchByID.TabIndex = 49
        radSearchByID.TabStop = True
        radSearchByID.Text = "Search By ID"
        radSearchByID.UseVisualStyleBackColor = True
        ' 
        ' lblSearchLName
        ' 
        lblSearchLName.AutoSize = True
        lblSearchLName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblSearchLName.ForeColor = SystemColors.ControlLightLight
        lblSearchLName.Location = New Point(6, 108)
        lblSearchLName.Name = "lblSearchLName"
        lblSearchLName.Size = New Size(182, 20)
        lblSearchLName.TabIndex = 48
        lblSearchLName.Text = "Customer Last Name:"
        ' 
        ' txtSearchLastName
        ' 
        txtSearchLastName.BorderStyle = BorderStyle.FixedSingle
        txtSearchLastName.Enabled = False
        txtSearchLastName.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        txtSearchLastName.Location = New Point(203, 105)
        txtSearchLastName.Margin = New Padding(3, 2, 3, 2)
        txtSearchLastName.Name = "txtSearchLastName"
        txtSearchLastName.Size = New Size(224, 26)
        txtSearchLastName.TabIndex = 2
        ' 
        ' btnFindCustomer
        ' 
        btnFindCustomer.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnFindCustomer.FlatStyle = FlatStyle.Flat
        btnFindCustomer.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFindCustomer.ForeColor = SystemColors.ActiveCaptionText
        btnFindCustomer.Location = New Point(448, 66)
        btnFindCustomer.Margin = New Padding(3, 2, 3, 2)
        btnFindCustomer.Name = "btnFindCustomer"
        btnFindCustomer.Size = New Size(138, 52)
        btnFindCustomer.TabIndex = 3
        btnFindCustomer.Text = "Find Customer"
        btnFindCustomer.UseVisualStyleBackColor = False
        ' 
        ' lblCustID
        ' 
        lblCustID.AutoSize = True
        lblCustID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        lblCustID.ForeColor = SystemColors.ControlLightLight
        lblCustID.Location = New Point(30, 66)
        lblCustID.Name = "lblCustID"
        lblCustID.Size = New Size(115, 20)
        lblCustID.TabIndex = 45
        lblCustID.Text = "Customer ID:"
        ' 
        ' txtSearchCusrtomerID
        ' 
        txtSearchCusrtomerID.BorderStyle = BorderStyle.FixedSingle
        txtSearchCusrtomerID.Enabled = False
        txtSearchCusrtomerID.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        txtSearchCusrtomerID.Location = New Point(203, 63)
        txtSearchCusrtomerID.Margin = New Padding(3, 2, 3, 2)
        txtSearchCusrtomerID.Name = "txtSearchCusrtomerID"
        txtSearchCusrtomerID.Size = New Size(224, 26)
        txtSearchCusrtomerID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(66, 417)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 21)
        Label2.TabIndex = 65
        Label2.Text = "Customer Email:"
        ' 
        ' txtCustomerEmail
        ' 
        txtCustomerEmail.Enabled = False
        txtCustomerEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerEmail.Location = New Point(211, 414)
        txtCustomerEmail.Margin = New Padding(3, 2, 3, 2)
        txtCustomerEmail.Name = "txtCustomerEmail"
        txtCustomerEmail.Size = New Size(312, 29)
        txtCustomerEmail.TabIndex = 61
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(81, 361)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 21)
        Label4.TabIndex = 63
        Label4.Text = "Last Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(81, 304)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 21)
        Label3.TabIndex = 62
        Label3.Text = "First Name:"
        ' 
        ' txtCustomerLName
        ' 
        txtCustomerLName.Enabled = False
        txtCustomerLName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerLName.Location = New Point(211, 358)
        txtCustomerLName.Margin = New Padding(3, 2, 3, 2)
        txtCustomerLName.Name = "txtCustomerLName"
        txtCustomerLName.Size = New Size(312, 29)
        txtCustomerLName.TabIndex = 60
        ' 
        ' txtCustomerFName
        ' 
        txtCustomerFName.Enabled = False
        txtCustomerFName.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        txtCustomerFName.Location = New Point(211, 301)
        txtCustomerFName.Margin = New Padding(3, 2, 3, 2)
        txtCustomerFName.Name = "txtCustomerFName"
        txtCustomerFName.Size = New Size(312, 29)
        txtCustomerFName.TabIndex = 59
        ' 
        ' frmDeleteCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(936, 551)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(txtCustomerEmail)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtCustomerLName)
        Controls.Add(txtCustomerFName)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        Controls.Add(btnExit)
        Controls.Add(btnCancelReset)
        Controls.Add(btnDeleteCustomer)
        Name = "frmDeleteCustomer"
        Text = "frmDeleteCustomer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancelReset As Button
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSearchByLName As RadioButton
    Friend WithEvents radSearchByID As RadioButton
    Friend WithEvents lblSearchLName As Label
    Friend WithEvents txtSearchLastName As TextBox
    Friend WithEvents btnFindCustomer As Button
    Friend WithEvents lblCustID As Label
    Friend WithEvents txtSearchCusrtomerID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomerLName As TextBox
    Friend WithEvents txtCustomerFName As TextBox
End Class
