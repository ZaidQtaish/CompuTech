Public Class frmAddNewCustomer
    Private Sub btnCancelReset_Click(sender As Object, e As EventArgs) Handles btnCancelReset.Click
        txtCustomerEmail.Clear()
        txtFName.Clear()
        txtLName.Clear()
        txtFName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        ' Check if all required fields are filled
        If String.IsNullOrWhiteSpace(txtFName.Text) OrElse
       String.IsNullOrWhiteSpace(txtLName.Text) OrElse
       String.IsNullOrWhiteSpace(txtCustomerEmail.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert customer into database
        Dim strFirstName As String = txtFName.Text
        Dim strLastName As String = txtLName.Text
        Dim strEmail As String = txtCustomerEmail.Text

        Dim sqlCommand As String = "INSERT INTO Customers(CustomerFName, CustomerLName, CustomerEmail) 
                                    VALUES(@FirstName, @LastName, @Email)"

        Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
            Try
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    cmd.Parameters.AddWithValue("@FirstName", strFirstName)
                    cmd.Parameters.AddWithValue("@LastName", strLastName)
                    cmd.Parameters.AddWithValue("@Email", strEmail)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("New Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class