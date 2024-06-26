<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplashScreen
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
        components = New ComponentModel.Container()
        picLogo = New PictureBox()
        tmrSplashScreen = New Timer(components)
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picLogo
        ' 
        picLogo.Image = My.Resources.Resources.logo
        picLogo.Location = New Point(137, -57)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(508, 590)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 15
        picLogo.TabStop = False
        ' 
        ' tmrSplashScreen
        ' 
        tmrSplashScreen.Enabled = True
        tmrSplashScreen.Interval = 3000
        ' 
        ' frmSplashScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(23), CByte(23), CByte(50))
        ClientSize = New Size(787, 460)
        Controls.Add(picLogo)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmSplashScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmSplashScreen"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents tmrSplashScreen As Timer
End Class
