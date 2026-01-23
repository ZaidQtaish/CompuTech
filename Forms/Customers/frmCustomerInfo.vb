Public Class frmCustomerInfo
    Dim DS As New Data.DataSet("Customers")
    Dim intRowIndex As Integer = 0

    Private Sub frmCustomerInfoFormView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlCommand As String = "SELECT CustomerId, CustomerFName, CustomerLName, CustomerEmail from Customers"
        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "Customers")
                    If DS.Tables("Customers").Rows.Count = 0 Then
                        MessageBox.Show("No Customer Data Found!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtCustomerId.Text = DS.Tables(0).Rows(0).Item(0).ToString
                        txtCustomerFName.Text = DS.Tables(0).Rows(0).Item(1).ToString
                        txtCustomerLName.Text = DS.Tables(0).Rows(0).Item(2).ToString
                        txtEmail.Text = DS.Tables(0).Rows(0).Item(3).ToString
                    End If
                End Using
            End Using
            btnNextRecord.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        Try
            If intRowIndex < DS.Tables(0).Rows.Count - 1 Then
                intRowIndex = intRowIndex + 1

                txtCustomerId.Text = DS.Tables(0).Rows(intRowIndex).Item(0).ToString
                txtCustomerFName.Text = DS.Tables(0).Rows(intRowIndex).Item(1).ToString
                txtCustomerLName.Text = DS.Tables(0).Rows(intRowIndex).Item(2).ToString
                txtEmail.Text = DS.Tables(0).Rows(intRowIndex).Item(3).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPrevRecord_Click(sender As Object, e As EventArgs) Handles btnPrevRecord.Click
        Try
            If intRowIndex > 0 Then
                intRowIndex = intRowIndex - 1

                txtCustomerId.Text = DS.Tables(0).Rows(intRowIndex).Item(0).ToString
                txtCustomerFName.Text = DS.Tables(0).Rows(intRowIndex).Item(1).ToString
                txtCustomerLName.Text = DS.Tables(0).Rows(intRowIndex).Item(2).ToString
                txtEmail.Text = DS.Tables(0).Rows(intRowIndex).Item(3).ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFirstRecord_Click(sender As Object, e As EventArgs) Handles btnFirstRecord.Click
        Try
            If DS.Tables("Customers").Rows.Count = 0 Then
                MessageBox.Show("No Customer Data Found!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                intRowIndex = 0

                txtCustomerId.Text = DS.Tables(0).Rows(intRowIndex).Item(0).ToString
                txtCustomerFName.Text = DS.Tables(0).Rows(intRowIndex).Item(1).ToString
                txtCustomerLName.Text = DS.Tables(0).Rows(intRowIndex).Item(2).ToString
                txtEmail.Text = DS.Tables(0).Rows(intRowIndex).Item(3).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLastRecord_Click(sender As Object, e As EventArgs) Handles btnLastRecord.Click
        Try
            intRowIndex = DS.Tables(0).Rows.Count - 1

            txtCustomerId.Text = DS.Tables(0).Rows(intRowIndex).Item(0).ToString
            txtCustomerFName.Text = DS.Tables(0).Rows(intRowIndex).Item(1).ToString
            txtCustomerLName.Text = DS.Tables(0).Rows(intRowIndex).Item(2).ToString
            txtEmail.Text = DS.Tables(0).Rows(intRowIndex).Item(3).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnTable_Click(sender As Object, e As EventArgs)

    End Sub
End Class
