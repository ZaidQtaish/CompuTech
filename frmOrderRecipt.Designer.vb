<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderRecipt
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
        rtbRecipt = New RichTextBox()
        btnExit = New Button()
        btnConfirm = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = SystemColors.ControlLightLight
        lblTitle.Location = New Point(215, 32)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(226, 45)
        lblTitle.TabIndex = 69
        lblTitle.Text = "Order Receipt"
        ' 
        ' rtbRecipt
        ' 
        rtbRecipt.BackColor = SystemColors.ControlLightLight
        rtbRecipt.Font = New Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rtbRecipt.Location = New Point(51, 140)
        rtbRecipt.Name = "rtbRecipt"
        rtbRecipt.Size = New Size(554, 435)
        rtbRecipt.TabIndex = 70
        rtbRecipt.Text = ""
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExit.ForeColor = SystemColors.ActiveCaptionText
        btnExit.Location = New Point(493, 622)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(153, 37)
        btnExit.TabIndex = 86
        btnExit.Text = "Cancel and Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.FromArgb(CByte(87), CByte(169), CByte(191))
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnConfirm.ForeColor = SystemColors.ActiveCaptionText
        btnConfirm.Location = New Point(12, 622)
        btnConfirm.Margin = New Padding(3, 2, 3, 2)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(153, 37)
        btnConfirm.TabIndex = 87
        btnConfirm.Text = "Confirm Order"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' frmOrderRecipt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(658, 670)
        Controls.Add(btnConfirm)
        Controls.Add(btnExit)
        Controls.Add(rtbRecipt)
        Controls.Add(lblTitle)
        Name = "frmOrderRecipt"
        Text = "frmOrderRecipt"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents rtbRecipt As RichTextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnConfirm As Button
End Class
