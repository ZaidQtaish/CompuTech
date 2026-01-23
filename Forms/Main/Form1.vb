Public Class Form1
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPass.Clear()
        txtUser.Clear()
        txtUser.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strUser = txtUser.Text
        Dim strPass = txtPass.Text

        ' Check user in Database
        Dim DS As New Data.DataSet("LoginUsers")
        Dim sqlCommand As String = "select UserId, Username from Users where username = @Username and password = @Password and active = true"

        Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
            Try
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    cmd.Parameters.AddWithValue("@Username", strUser)
                    cmd.Parameters.AddWithValue("@Password", strPass)

                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "LoginUsers")

                    If DS.Tables("LoginUsers").Rows.Count > 0 Then
                        PublicParam.userId = DS.Tables("LoginUsers").Rows(0).Item("UserId")
                        PublicParam.username = DS.Tables("LoginUsers").Rows(0).Item("Username")

                        Dim objMdi As New frmMdiMainScreen
                        objMdi.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Wrong Username or Password")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        If chkRmbr.Checked = True Then
            My.Settings.username = txtUser.Text
            My.Settings.password = txtPass.Text
            My.Settings.rememberMe = True
        Else
            My.Settings.username = ""
            My.Settings.password = ""
            My.Settings.rememberMe = False
        End If
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.rememberMe Then
            txtUser.Text = My.Settings.username
            txtPass.Text = My.Settings.password
            chkRmbr.Checked = True
        End If
    End Sub
End Class
