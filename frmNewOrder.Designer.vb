<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOrder
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
        picPc1 = New PictureBox()
        picPc2 = New PictureBox()
        picPc3 = New PictureBox()
        lblPc1 = New Label()
        lblPc2 = New Label()
        lblPc3 = New Label()
        lblPrice1 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        btnSelect1 = New Button()
        btnSelect2 = New Button()
        btnSelect3 = New Button()
        lblQuantity = New Label()
        numQuantity = New NumericUpDown()
        lblExtras = New Label()
        chkMouse = New CheckBox()
        chkKeyboard = New CheckBox()
        lblMousePrice = New Label()
        lblKeyboardPrice = New Label()
        lblTotal = New Label()
        txtTotal = New TextBox()
        btnExit = New Button()
        btnCancelReset = New Button()
        btnPrintInvoice = New Button()
        lblRamTitle = New Label()
        lblGpuTitle = New Label()
        lblCoolerTitle = New Label()
        lblCpuTitle = New Label()
        lblCpu = New Label()
        lblGpu = New Label()
        lblRam = New Label()
        lblCooler = New Label()
        GroupBox1 = New GroupBox()
        boxSpecs = New GroupBox()
        btnSelectCustomer = New Button()
        txtCustomerName = New TextBox()
        CType(picPc1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPc2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picPc3, ComponentModel.ISupportInitialize).BeginInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        boxSpecs.SuspendLayout()
        SuspendLayout()
        ' 
        ' picPc1
        ' 
        picPc1.Image = My.Resources.Resources.pc1
        picPc1.Location = New Point(53, 106)
        picPc1.Name = "picPc1"
        picPc1.Size = New Size(272, 272)
        picPc1.SizeMode = PictureBoxSizeMode.Zoom
        picPc1.TabIndex = 0
        picPc1.TabStop = False
        ' 
        ' picPc2
        ' 
        picPc2.Image = My.Resources.Resources.pc2
        picPc2.Location = New Point(477, 106)
        picPc2.Name = "picPc2"
        picPc2.Size = New Size(272, 272)
        picPc2.SizeMode = PictureBoxSizeMode.Zoom
        picPc2.TabIndex = 1
        picPc2.TabStop = False
        ' 
        ' picPc3
        ' 
        picPc3.Image = My.Resources.Resources.pc3
        picPc3.Location = New Point(897, 106)
        picPc3.Name = "picPc3"
        picPc3.Size = New Size(272, 272)
        picPc3.SizeMode = PictureBoxSizeMode.Zoom
        picPc3.TabIndex = 2
        picPc3.TabStop = False
        ' 
        ' lblPc1
        ' 
        lblPc1.AutoSize = True
        lblPc1.Font = New Font("Segoe UI Symbol", 26F, FontStyle.Bold)
        lblPc1.ForeColor = SystemColors.ControlLightLight
        lblPc1.Location = New Point(85, 381)
        lblPc1.Name = "lblPc1"
        lblPc1.Size = New Size(206, 47)
        lblPc1.TabIndex = 56
        lblPc1.Text = "Player: One"
        ' 
        ' lblPc2
        ' 
        lblPc2.AutoSize = True
        lblPc2.Font = New Font("Segoe UI Symbol", 26F, FontStyle.Bold)
        lblPc2.ForeColor = SystemColors.ControlLightLight
        lblPc2.Location = New Point(511, 381)
        lblPc2.Name = "lblPc2"
        lblPc2.Size = New Size(206, 47)
        lblPc2.TabIndex = 57
        lblPc2.Text = "Player: Two"
        ' 
        ' lblPc3
        ' 
        lblPc3.AutoSize = True
        lblPc3.Font = New Font("Segoe UI Symbol", 26F, FontStyle.Bold)
        lblPc3.ForeColor = SystemColors.ControlLightLight
        lblPc3.Location = New Point(917, 381)
        lblPc3.Name = "lblPc3"
        lblPc3.Size = New Size(230, 47)
        lblPc3.TabIndex = 58
        lblPc3.Text = "Player: Three"
        ' 
        ' lblPrice1
        ' 
        lblPrice1.AutoSize = True
        lblPrice1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice1.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblPrice1.Location = New Point(116, 437)
        lblPrice1.Name = "lblPrice1"
        lblPrice1.Size = New Size(127, 22)
        lblPrice1.TabIndex = 59
        lblPrice1.Text = "$499.99 JOD"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        Label1.Location = New Point(551, 437)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 22)
        Label1.TabIndex = 60
        Label1.Text = "$999.99 JOD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        Label2.Location = New Point(965, 437)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 22)
        Label2.TabIndex = 61
        Label2.Text = "$1499.99 JOD"
        ' 
        ' btnSelect1
        ' 
        btnSelect1.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnSelect1.FlatStyle = FlatStyle.Flat
        btnSelect1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelect1.ForeColor = SystemColors.ActiveCaptionText
        btnSelect1.Location = New Point(104, 474)
        btnSelect1.Margin = New Padding(3, 2, 3, 2)
        btnSelect1.Name = "btnSelect1"
        btnSelect1.Size = New Size(149, 37)
        btnSelect1.TabIndex = 62
        btnSelect1.Text = "Select"
        btnSelect1.UseVisualStyleBackColor = False
        ' 
        ' btnSelect2
        ' 
        btnSelect2.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnSelect2.FlatStyle = FlatStyle.Flat
        btnSelect2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelect2.ForeColor = SystemColors.ActiveCaptionText
        btnSelect2.Location = New Point(539, 474)
        btnSelect2.Margin = New Padding(3, 2, 3, 2)
        btnSelect2.Name = "btnSelect2"
        btnSelect2.Size = New Size(149, 37)
        btnSelect2.TabIndex = 63
        btnSelect2.Text = "Select"
        btnSelect2.UseVisualStyleBackColor = False
        ' 
        ' btnSelect3
        ' 
        btnSelect3.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnSelect3.FlatStyle = FlatStyle.Flat
        btnSelect3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelect3.ForeColor = SystemColors.ActiveCaptionText
        btnSelect3.Location = New Point(960, 475)
        btnSelect3.Margin = New Padding(3, 2, 3, 2)
        btnSelect3.Name = "btnSelect3"
        btnSelect3.Size = New Size(149, 37)
        btnSelect3.TabIndex = 64
        btnSelect3.Text = "Select"
        btnSelect3.UseVisualStyleBackColor = False
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQuantity.ForeColor = Color.White
        lblQuantity.Location = New Point(502, 608)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(93, 22)
        lblQuantity.TabIndex = 73
        lblQuantity.Text = "Quantity:"
        lblQuantity.Visible = False
        ' 
        ' numQuantity
        ' 
        numQuantity.Font = New Font("Arial Rounded MT Bold", 12.25F)
        numQuantity.Location = New Point(612, 609)
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(67, 26)
        numQuantity.TabIndex = 75
        numQuantity.Visible = False
        ' 
        ' lblExtras
        ' 
        lblExtras.AutoSize = True
        lblExtras.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblExtras.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblExtras.Location = New Point(502, 660)
        lblExtras.Name = "lblExtras"
        lblExtras.Size = New Size(226, 22)
        lblExtras.TabIndex = 76
        lblExtras.Text = "[ Featured Peripherals ]"
        lblExtras.Visible = False
        ' 
        ' chkMouse
        ' 
        chkMouse.AutoSize = True
        chkMouse.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMouse.ForeColor = SystemColors.ControlLightLight
        chkMouse.Location = New Point(502, 699)
        chkMouse.Name = "chkMouse"
        chkMouse.Size = New Size(299, 22)
        chkMouse.TabIndex = 77
        chkMouse.Text = "Asus ROG Strix Impact III Wireless"
        chkMouse.UseVisualStyleBackColor = True
        chkMouse.Visible = False
        ' 
        ' chkKeyboard
        ' 
        chkKeyboard.AutoSize = True
        chkKeyboard.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkKeyboard.ForeColor = SystemColors.ControlLightLight
        chkKeyboard.Location = New Point(502, 761)
        chkKeyboard.Name = "chkKeyboard"
        chkKeyboard.Size = New Size(314, 22)
        chkKeyboard.TabIndex = 78
        chkKeyboard.Text = "Asus ROG Strix Scope II 96 Wireless"
        chkKeyboard.UseVisualStyleBackColor = True
        chkKeyboard.Visible = False
        ' 
        ' lblMousePrice
        ' 
        lblMousePrice.AutoSize = True
        lblMousePrice.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMousePrice.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblMousePrice.Location = New Point(519, 724)
        lblMousePrice.Name = "lblMousePrice"
        lblMousePrice.Size = New Size(94, 17)
        lblMousePrice.TabIndex = 79
        lblMousePrice.Text = "$69.99 JOD"
        lblMousePrice.Visible = False
        ' 
        ' lblKeyboardPrice
        ' 
        lblKeyboardPrice.AutoSize = True
        lblKeyboardPrice.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblKeyboardPrice.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblKeyboardPrice.Location = New Point(519, 786)
        lblKeyboardPrice.Name = "lblKeyboardPrice"
        lblKeyboardPrice.Size = New Size(103, 17)
        lblKeyboardPrice.TabIndex = 80
        lblKeyboardPrice.Text = "$179.99 JOD"
        lblKeyboardPrice.Visible = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblTotal.Location = New Point(989, 788)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(62, 22)
        lblTotal.TabIndex = 81
        lblTotal.Text = "Total:"
        ' 
        ' txtTotal
        ' 
        txtTotal.Font = New Font("Arial Rounded MT Bold", 12.25F)
        txtTotal.Location = New Point(1057, 788)
        txtTotal.Margin = New Padding(5)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(127, 26)
        txtTotal.TabIndex = 82
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(1031, 724)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(153, 37)
        btnExit.TabIndex = 85
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnCancelReset
        ' 
        btnCancelReset.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnCancelReset.FlatStyle = FlatStyle.Flat
        btnCancelReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelReset.ForeColor = SystemColors.ActiveCaptionText
        btnCancelReset.Location = New Point(1031, 671)
        btnCancelReset.Margin = New Padding(3, 2, 3, 2)
        btnCancelReset.Name = "btnCancelReset"
        btnCancelReset.Size = New Size(153, 37)
        btnCancelReset.TabIndex = 84
        btnCancelReset.Text = "Cancel and reset"
        btnCancelReset.UseVisualStyleBackColor = False
        ' 
        ' btnPrintInvoice
        ' 
        btnPrintInvoice.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnPrintInvoice.FlatStyle = FlatStyle.Flat
        btnPrintInvoice.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnPrintInvoice.ForeColor = SystemColors.ActiveCaptionText
        btnPrintInvoice.Location = New Point(1031, 619)
        btnPrintInvoice.Margin = New Padding(3, 2, 3, 2)
        btnPrintInvoice.Name = "btnPrintInvoice"
        btnPrintInvoice.Size = New Size(153, 37)
        btnPrintInvoice.TabIndex = 83
        btnPrintInvoice.Text = "Print Invoice"
        btnPrintInvoice.UseVisualStyleBackColor = False
        btnPrintInvoice.Visible = False
        ' 
        ' lblRamTitle
        ' 
        lblRamTitle.AutoSize = True
        lblRamTitle.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRamTitle.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblRamTitle.ImageAlign = ContentAlignment.MiddleRight
        lblRamTitle.Location = New Point(17, 131)
        lblRamTitle.Name = "lblRamTitle"
        lblRamTitle.Size = New Size(60, 22)
        lblRamTitle.TabIndex = 67
        lblRamTitle.Text = "RAM:"
        ' 
        ' lblGpuTitle
        ' 
        lblGpuTitle.AutoSize = True
        lblGpuTitle.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGpuTitle.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblGpuTitle.ImageAlign = ContentAlignment.MiddleRight
        lblGpuTitle.Location = New Point(17, 88)
        lblGpuTitle.Name = "lblGpuTitle"
        lblGpuTitle.Size = New Size(58, 22)
        lblGpuTitle.TabIndex = 66
        lblGpuTitle.Text = "GPU:"
        ' 
        ' lblCoolerTitle
        ' 
        lblCoolerTitle.AutoSize = True
        lblCoolerTitle.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCoolerTitle.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblCoolerTitle.ImageAlign = ContentAlignment.MiddleRight
        lblCoolerTitle.Location = New Point(17, 171)
        lblCoolerTitle.Name = "lblCoolerTitle"
        lblCoolerTitle.Size = New Size(76, 22)
        lblCoolerTitle.TabIndex = 68
        lblCoolerTitle.Text = "Cooler:"
        ' 
        ' lblCpuTitle
        ' 
        lblCpuTitle.AutoSize = True
        lblCpuTitle.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCpuTitle.ForeColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        lblCpuTitle.Location = New Point(17, 47)
        lblCpuTitle.Name = "lblCpuTitle"
        lblCpuTitle.Size = New Size(62, 22)
        lblCpuTitle.TabIndex = 65
        lblCpuTitle.Text = "CPU: "
        ' 
        ' lblCpu
        ' 
        lblCpu.AutoSize = True
        lblCpu.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCpu.ForeColor = Color.White
        lblCpu.Location = New Point(85, 47)
        lblCpu.Name = "lblCpu"
        lblCpu.Size = New Size(192, 22)
        lblCpu.TabIndex = 69
        lblCpu.Text = "Intel Core i5-12400F"
        ' 
        ' lblGpu
        ' 
        lblGpu.AutoSize = True
        lblGpu.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGpu.ForeColor = Color.White
        lblGpu.Location = New Point(85, 88)
        lblGpu.Name = "lblGpu"
        lblGpu.Size = New Size(300, 22)
        lblGpu.TabIndex = 70
        lblGpu.Text = "AMD Radeon™ RX 6650 XT 8GB"
        ' 
        ' lblRam
        ' 
        lblRam.AutoSize = True
        lblRam.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRam.ForeColor = Color.White
        lblRam.Location = New Point(85, 131)
        lblRam.Name = "lblRam"
        lblRam.Size = New Size(331, 22)
        lblRam.TabIndex = 71
        lblRam.Text = "Teamgroup Delta 16GB DDR5 5600"
        ' 
        ' lblCooler
        ' 
        lblCooler.AutoSize = True
        lblCooler.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCooler.ForeColor = Color.White
        lblCooler.Location = New Point(99, 171)
        lblCooler.Name = "lblCooler"
        lblCooler.Size = New Size(323, 22)
        lblCooler.TabIndex = 72
        lblCooler.Text = "Deepcool AK400 Digital Air Cooler"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(449, -16)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(375, 262)
        GroupBox1.TabIndex = 86
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' boxSpecs
        ' 
        boxSpecs.Controls.Add(GroupBox1)
        boxSpecs.Controls.Add(lblCooler)
        boxSpecs.Controls.Add(lblRam)
        boxSpecs.Controls.Add(lblGpu)
        boxSpecs.Controls.Add(lblCpu)
        boxSpecs.Controls.Add(lblCpuTitle)
        boxSpecs.Controls.Add(lblCoolerTitle)
        boxSpecs.Controls.Add(lblGpuTitle)
        boxSpecs.Controls.Add(lblRamTitle)
        boxSpecs.Font = New Font("Arial Rounded MT Bold", 14.25F)
        boxSpecs.ForeColor = SystemColors.ControlLightLight
        boxSpecs.Location = New Point(31, 599)
        boxSpecs.Name = "boxSpecs"
        boxSpecs.Size = New Size(443, 215)
        boxSpecs.TabIndex = 69
        boxSpecs.TabStop = False
        boxSpecs.Text = "Specs"
        boxSpecs.Visible = False
        ' 
        ' btnSelectCustomer
        ' 
        btnSelectCustomer.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnSelectCustomer.FlatStyle = FlatStyle.Flat
        btnSelectCustomer.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelectCustomer.ForeColor = SystemColors.ActiveCaptionText
        btnSelectCustomer.Location = New Point(53, 27)
        btnSelectCustomer.Margin = New Padding(3, 2, 3, 2)
        btnSelectCustomer.Name = "btnSelectCustomer"
        btnSelectCustomer.Size = New Size(200, 37)
        btnSelectCustomer.TabIndex = 86
        btnSelectCustomer.Text = "Select Customer"
        btnSelectCustomer.UseVisualStyleBackColor = False
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Font = New Font("Arial Rounded MT Bold", 12.25F)
        txtCustomerName.Location = New Point(275, 35)
        txtCustomerName.Margin = New Padding(5)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.ReadOnly = True
        txtCustomerName.Size = New Size(178, 26)
        txtCustomerName.TabIndex = 87
        ' 
        ' frmNewOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(1220, 834)
        Controls.Add(txtCustomerName)
        Controls.Add(btnSelectCustomer)
        Controls.Add(btnExit)
        Controls.Add(btnCancelReset)
        Controls.Add(btnPrintInvoice)
        Controls.Add(txtTotal)
        Controls.Add(lblTotal)
        Controls.Add(lblKeyboardPrice)
        Controls.Add(lblMousePrice)
        Controls.Add(chkKeyboard)
        Controls.Add(chkMouse)
        Controls.Add(lblExtras)
        Controls.Add(numQuantity)
        Controls.Add(lblQuantity)
        Controls.Add(boxSpecs)
        Controls.Add(btnSelect3)
        Controls.Add(btnSelect2)
        Controls.Add(btnSelect1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblPrice1)
        Controls.Add(lblPc3)
        Controls.Add(lblPc2)
        Controls.Add(lblPc1)
        Controls.Add(picPc3)
        Controls.Add(picPc2)
        Controls.Add(picPc1)
        Name = "frmNewOrder"
        Text = "frmNewOrder"
        CType(picPc1, ComponentModel.ISupportInitialize).EndInit()
        CType(picPc2, ComponentModel.ISupportInitialize).EndInit()
        CType(picPc3, ComponentModel.ISupportInitialize).EndInit()
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        boxSpecs.ResumeLayout(False)
        boxSpecs.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPc1 As PictureBox
    Friend WithEvents picPc2 As PictureBox
    Friend WithEvents picPc3 As PictureBox
    Friend WithEvents lblPc1 As Label
    Friend WithEvents lblPc2 As Label
    Friend WithEvents lblPc3 As Label
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSelect1 As Button
    Friend WithEvents btnSelect2 As Button
    Friend WithEvents btnSelect3 As Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents lblExtras As Label
    Friend WithEvents chkMouse As CheckBox
    Friend WithEvents chkKeyboard As CheckBox
    Friend WithEvents lblMousePrice As Label
    Friend WithEvents lblKeyboardPrice As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancelReset As Button
    Friend WithEvents btnPrintInvoice As Button
    Friend WithEvents lblRamTitle As Label
    Friend WithEvents lblGpuTitle As Label
    Friend WithEvents lblCoolerTitle As Label
    Friend WithEvents lblCpuTitle As Label
    Friend WithEvents lblCpu As Label
    Friend WithEvents lblGpu As Label
    Friend WithEvents lblRam As Label
    Friend WithEvents lblCooler As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents boxSpecs As GroupBox
    Friend WithEvents btnSelectCustomer As Button
    Friend WithEvents txtCustomerName As TextBox
End Class
