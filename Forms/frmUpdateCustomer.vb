Public Class frmUpdateCustomer
    Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radSearchByID.Checked = True
        txtSearchCustomerID.Enabled = True
    End Sub

    Private Sub radSearchByID_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchByID.CheckedChanged
        txtSearchCustomerID.Enabled = True
        txtSearchCustomerID.BackColor = Color.White
        txtSearchLastName.Enabled = False
        txtSearchLastName.Clear()
        txtSearchLastName.BackColor = Color.DarkGray
    End Sub

    Private Sub radSearchByLName_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchByLName.CheckedChanged
        txtSearchLastName.Enabled = True
        txtSearchLastName.BackColor = Color.White
        txtSearchCustomerID.Enabled = False
        txtSearchCustomerID.Clear()
        txtSearchCustomerID.BackColor = Color.DarkGray
    End Sub

    Private Sub btnCancelReset_Click(sender As Object, e As EventArgs) Handles btnCancelReset.Click
        txtSearchCustomerID.Clear()
        txtSearchLastName.Clear()
        txtCustomerFName.Clear()
        txtCustomerFName.Enabled = False
        txtCustomerLName.Clear()
        txtCustomerLName.Enabled = False
        txtCustomerEmail.Clear()
        txtCustomerEmail.Enabled = False
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFindCustomer_Click(sender As Object, e As EventArgs) Handles btnFindCustomer.Click
        Dim DS As New Data.DataSet("Customers")
        Dim sqlCommand As String

        If radSearchByID.Checked Then
            If String.IsNullOrWhiteSpace(txtSearchCustomerID.Text) Then
                MessageBox.Show("Please enter a Customer ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            sqlCommand = "SELECT * FROM Customers WHERE CustomerID = @CustomerID"
        Else
            If String.IsNullOrWhiteSpace(txtSearchLastName.Text) Then
                MessageBox.Show("Please enter a Customer Last Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            sqlCommand = "SELECT * FROM Customers WHERE CustomerLName = @CustomerLName"
        End If

        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    If radSearchByID.Checked Then
                        cmd.Parameters.AddWithValue("@CustomerID", txtSearchCustomerID.Text)
                    Else
                        cmd.Parameters.AddWithValue("@CustomerLName", txtSearchLastName.Text)
                    End If

                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "Customers")

                    If DS.Tables("Customers").Rows.Count > 0 Then
                        Dim row As DataRow = DS.Tables("Customers").Rows(0)
                        txtSearchCustomerID.Text = row("CustomerId").ToString()
                        txtCustomerFName.Text = row("CustomerFName").ToString()
                        txtCustomerFName.Enabled = True
                        txtCustomerLName.Text = row("CustomerLName").ToString()
                        txtCustomerLName.Enabled = True
                        txtCustomerEmail.Text = row("CustomerEmail").ToString()
                        txtCustomerEmail.Enabled = True
                    Else
                        MessageBox.Show("No customer found with the given information.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this Customer?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Return
        End If

        Dim strCustomerId As String = txtSearchCustomerID.Text
        Dim strCustomerFName As String = txtCustomerFName.Text
        Dim strCustomerLName As String = txtCustomerLName.Text
        Dim strEmail As String = txtCustomerEmail.Text

        Dim sqlCommand As String = "UPDATE Customers SET CustomerFName = @CustomerFName, CustomerLName = @CustomerLName, 
                                    CustomerEmail = @CustomerEmail
                                    WHERE CustomerId = @CustomerId"
        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    cmd.Parameters.AddWithValue("@CustomerFName", strCustomerFName)
                    cmd.Parameters.AddWithValue("@CustomerLName", strCustomerLName)
                    cmd.Parameters.AddWithValue("@CustomerEmail", strEmail)
                    cmd.Parameters.AddWithValue("@CustomerId", strCustomerId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        btnCancelReset_Click(sender, e)
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