Public Class frmDeleteCustomer
    Private Sub frmDeleteCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radSearchByID.Checked = True
        txtSearchCusrtomerID.Enabled = True
    End Sub

    Private Sub radSearchByID_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchByID.CheckedChanged
        txtSearchCusrtomerID.Enabled = True
        txtSearchCusrtomerID.BackColor = Color.White
        txtSearchLastName.Enabled = False
        txtSearchLastName.Clear()
        txtSearchLastName.BackColor = Color.DarkGray
    End Sub

    Private Sub radSearchByLName_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchByLName.CheckedChanged
        txtSearchLastName.Enabled = True
        txtSearchLastName.BackColor = Color.White
        txtSearchCusrtomerID.Enabled = False
        txtSearchCusrtomerID.Clear()
        txtSearchCusrtomerID.BackColor = Color.DarkGray
    End Sub

    Private Sub btnCancelReset_Click(sender As Object, e As EventArgs) Handles btnCancelReset.Click
        txtSearchCusrtomerID.Clear()
        txtSearchLastName.Clear()
        txtCustomerFName.Clear()
        txtCustomerLName.Clear()
        txtCustomerEmail.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFindCustomer_Click(sender As Object, e As EventArgs) Handles btnFindCustomer.Click
        Dim DS As New Data.DataSet("Customers")
        Dim sqlCommand As String

        If radSearchByID.Checked Then
            If String.IsNullOrWhiteSpace(txtSearchCusrtomerID.Text) Then
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
                        cmd.Parameters.AddWithValue("@CustomerID", txtSearchCusrtomerID.Text)
                    Else
                        cmd.Parameters.AddWithValue("@CustomerLName", txtSearchLastName.Text)
                    End If

                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "Customers")

                    If DS.Tables("Customers").Rows.Count > 0 Then
                        Dim row As DataRow = DS.Tables("Customers").Rows(0)
                        txtSearchCusrtomerID.Text = row("CustomerId").ToString()
                        txtCustomerFName.Text = row("CustomerFName").ToString()
                        txtCustomerLName.Text = row("CustomerLName").ToString()
                        txtCustomerEmail.Text = row("CustomerEmail").ToString()
                    Else
                        MessageBox.Show("No customer found with the given information.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If String.IsNullOrWhiteSpace(txtCustomerFName.Text) OrElse String.IsNullOrWhiteSpace(txtCustomerLName.Text) OrElse String.IsNullOrWhiteSpace(txtCustomerEmail.Text) Then
            MessageBox.Show("Please find and select a customer to delete.", "No Customer Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Return
        End If

        Dim sqlCommand As String = "DELETE FROM Customers WHERE CustomerID = @CustomerID"
        Dim customerId As String = txtSearchCusrtomerID.Text

        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    cmd.Parameters.AddWithValue("@CustomerID", customerId)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtSearchCusrtomerID.Clear()
                        txtCustomerFName.Clear()
                        txtCustomerLName.Clear()
                        txtCustomerEmail.Clear()
                        txtSearchLastName.Clear()
                    Else
                        MessageBox.Show("No customer found with the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class