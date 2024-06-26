Imports System.Data.OleDb

Public Class frmAddNewUser
    Private Sub btnCancelReset_Click(sender As Object, e As EventArgs) Handles btnCancelReset.Click
        txtConfirmPassword.Clear()
        txtUsername.Clear()
        txtUserFName.Clear()
        txtUserLName.Clear()
        txtPassword.Clear()
        radActiveUser.Checked = False
        txtUsername.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click
        ' Check if all required fields are filled
        If String.IsNullOrWhiteSpace(txtUserFName.Text) OrElse
       String.IsNullOrWhiteSpace(txtUserLName.Text) OrElse
       String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
       String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
       String.IsNullOrWhiteSpace(txtConfirmPassword.Text) OrElse
       (Not radActiveUser.Checked AndAlso Not radInactiveUser.Checked) Then
            MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if password matches confirm password
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password and confirm password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert user into database
        Dim strFirstName As String = txtUserFName.Text
        Dim strLastName As String = txtUserLName.Text
        Dim strUsername As String = txtUsername.Text
        Dim strPassword As String = txtPassword.Text
        Dim boolActive As Boolean = radActiveUser.Checked

        Dim sqlCommand As String = "INSERT INTO Users(UserFName, UserLName, Username, [Password], active) 
                                    VALUES(@FirstName, @LastName, @Username, @Password, @Active)"

        Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
            Try
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    cmd.Parameters.AddWithValue("@FirstName", strFirstName)
                    cmd.Parameters.AddWithValue("@LastName", strLastName)
                    cmd.Parameters.AddWithValue("@Username", strUsername)
                    cmd.Parameters.AddWithValue("@Password", strPassword)
                    cmd.Parameters.AddWithValue("@Active", boolActive)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("New user added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class