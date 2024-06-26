Public Class frmUpdateUser
    Private Sub frmDeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radSearchByID.Checked = True
        txtSearchUserID.Enabled = True
    End Sub

    Private Sub radSearchByID_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchByID.CheckedChanged
        txtSearchUserID.Enabled = True
        txtSearchUserID.BackColor = Color.White
        txtSearchUsername.Enabled = False
        txtSearchUsername.Clear()
        txtSearchUsername.BackColor = Color.DarkGray
    End Sub

    Private Sub radSearchByUsername_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchByUsername.CheckedChanged
        txtSearchUsername.Enabled = True
        txtSearchUsername.BackColor = Color.White
        txtSearchUserID.Enabled = False
        txtSearchUserID.Clear()
        txtSearchUserID.BackColor = Color.DarkGray
    End Sub

    Private Sub btnCancelReset_Click(sender As Object, e As EventArgs) Handles btnCancelReset.Click
        txtSearchUserID.Clear()
        txtSearchUsername.Clear()
        txtUserFName.Clear()
        txtUserLName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUserFName.Enabled = False
        txtUserLName.Enabled = False
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        GroupBox.Visible = False
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click
        Dim DS As New Data.DataSet("Users")
        Dim sqlCommand As String

        If radSearchByID.Checked Then
            If String.IsNullOrWhiteSpace(txtSearchUserID.Text) Then
                MessageBox.Show("Please enter a user ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            sqlCommand = "SELECT * FROM Users WHERE UserID = @UserID"
        Else
            If String.IsNullOrWhiteSpace(txtSearchUsername.Text) Then
                MessageBox.Show("Please enter a username.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            sqlCommand = "SELECT * FROM Users WHERE Username = @Username"
        End If

        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    If radSearchByID.Checked Then
                        cmd.Parameters.AddWithValue("@UserID", txtSearchUserID.Text)
                    Else
                        cmd.Parameters.AddWithValue("@Username", txtSearchUsername.Text)
                    End If

                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "Users")

                    If DS.Tables("Users").Rows.Count > 0 Then
                        Dim row As DataRow = DS.Tables("Users").Rows(0)
                        txtSearchUserID.Text = row("UserId").ToString()
                        txtUserFName.Text = row("UserFName").ToString()
                        txtUserFName.Enabled = True
                        txtUserLName.Text = row("UserLName").ToString()
                        txtUserLName.Enabled = True
                        txtUsername.Text = row("Username").ToString()
                        txtUsername.Enabled = True
                        txtPassword.Text = row("Password").ToString()
                        txtPassword.Enabled = True
                        GroupBox.Visible = True
                        If row("Active") Then
                            radActiveUser.Checked = True
                        Else
                            radInactiveUser.Checked = True
                        End If

                    Else
                        MessageBox.Show("No user found with the given information.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If GroupBox.Visible = False Then
            MessageBox.Show("Please find a user to update.", "No user Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this user?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Return
        End If

        Dim strUserId As String = txtSearchUserID.Text
        Dim strUserFName As String = txtUserFName.Text
        Dim strUserLName As String = txtUserLName.Text
        Dim strUsername As String = txtUsername.Text
        Dim strPassword As String = txtPassword.Text
        Dim boolActive As Boolean = radActiveUser.Checked

        Dim sqlCommand As String = "UPDATE Users SET UserFName = @UserFName, UserLName = @UserLName, 
                                    Username = @Username, [Password] = @Password, active = @Active 
                                    WHERE UserId = @UserId"
        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    cmd.Parameters.AddWithValue("@UserFName", strUserFName)
                    cmd.Parameters.AddWithValue("@UserLName", strUserLName)
                    cmd.Parameters.AddWithValue("@Username", strUsername)
                    cmd.Parameters.AddWithValue("@Password", strPassword)
                    cmd.Parameters.AddWithValue("@Active", boolActive)
                    cmd.Parameters.AddWithValue("@UserId", strUserId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearchUserID.Clear()
                        txtSearchUsername.Clear()
                        txtUserFName.Clear()
                        txtUserFName.Enabled = False
                        txtUserLName.Clear()
                        txtUserLName.Enabled = False
                        txtUsername.Clear()
                        txtUsername.Enabled = False
                        txtPassword.Clear()
                        txtPassword.Enabled = False
                        GroupBox.Visible = False
                    Else
                        MessageBox.Show("No changes made.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class