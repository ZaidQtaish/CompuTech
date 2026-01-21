Public Class frmCustomerDGV
    Dim intDgvRowIndex As Integer = 0
    Private Sub frmCustomerDGV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DS As New Data.DataSet("Customers")

        Dim sqlCommand As String = "SELECT CustomerID, CustomerFName, CustomerLName, CustomerEmail FROM Customers"
        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "Customers")
                    If DS.Tables("Customers").Rows.Count = 0 Then
                        MessageBox.Show("No Customer Data Found !", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        For i As Integer = 0 To DS.Tables("Customers").Rows.Count - 1
                            dgvCustomers.Rows.Add()
                            dgvCustomers.Rows(i).Cells(0).Value = DS.Tables(0).Rows(i).Item(0).ToString
                            dgvCustomers.Rows(i).Cells(1).Value = DS.Tables(0).Rows(i).Item(1).ToString
                            dgvCustomers.Rows(i).Cells(2).Value = DS.Tables(0).Rows(i).Item(2).ToString
                            dgvCustomers.Rows(i).Cells(3).Value = DS.Tables(0).Rows(i).Item(3).ToString
                            intDgvRowIndex = intDgvRowIndex + 1
                        Next
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub dgvCustomers_Click(sender As Object, e As EventArgs) Handles dgvCustomers.Click
        txtCustomerID.Text = dgvCustomers.CurrentRow.Cells(0).Value
        txtCustomerFName.Text = dgvCustomers.CurrentRow.Cells(1).Value
        txtCustomerLName.Text = dgvCustomers.CurrentRow.Cells(2).Value
        txtCustomerEmail.Text = dgvCustomers.CurrentRow.Cells(3).Value

        frmNewOrder.selectedCustomerId = txtCustomerID.Text
        frmNewOrder.txtCustomerName.Text = txtCustomerFName.Text + " " + txtCustomerLName.Text
    End Sub

    Private Sub btnClearDGV_Click(sender As Object, e As EventArgs) Handles btnClearDGV.Click
        dgvCustomers.Rows.Clear()
        intDgvRowIndex = 0
    End Sub

    Private Sub btnLoadDataDGV_Click(sender As Object, e As EventArgs) Handles btnLoadDataDGV.Click
        btnClearDGV_Click(sender, e)
        frmCustomerDGV_Load(sender, e)
    End Sub

    Private Sub btnAddDataDGV_Click(sender As Object, e As EventArgs) Handles btnAddDataDGV.Click
        If String.IsNullOrWhiteSpace(txtCustomerID.Text) OrElse
       String.IsNullOrWhiteSpace(txtCustomerFName.Text) OrElse
       String.IsNullOrWhiteSpace(txtCustomerLName.Text) OrElse
       String.IsNullOrWhiteSpace(txtCustomerEmail.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Insert customer into database
            Dim strFirstName As String = txtCustomerFName.Text
            Dim strLastName As String = txtCustomerLName.Text
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
                    MsgBox(Err.Description)
                End Try
            End Using
            btnLoadDataDGV_Click(sender, e)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub btnRemoveRow_Click(sender As Object, e As EventArgs) Handles btnRemoveRow.Click
        If String.IsNullOrWhiteSpace(txtCustomerID.Text) Then
            MessageBox.Show("Please select a customer to remove.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            Dim strId As String = txtCustomerID.Text
            Dim sqlCommand As String = "DELETE FROM Customers WHERE CustomerId = @CustomerId"

            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                Try
                    AccessConn.Open()
                    Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                        cmd.Parameters.AddWithValue("@CustomerId", strId)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MsgBox(Err.Description)
                End Try
            End Using
            btnLoadDataDGV_Click(sender, e)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class