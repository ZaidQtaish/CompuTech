Public Class frmOrderRecipt
    Private Sub frmOrderRecipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim employeeUsername As String = PublicParam.username
        Dim customerName As String = frmNewOrder.txtCustomerName.Text

        rtbRecipt.AppendText("CompuTech" & vbCrLf & $"------------------------------------" & vbCrLf)
        rtbRecipt.AppendText($"Employee Username: {employeeUsername}" & vbCrLf)
        rtbRecipt.AppendText($"Customer Name: {customerName}" & vbCrLf & $"------------------------------------" & vbCrLf & vbCrLf)
        rtbRecipt.AppendText("[ Purchases ]" & vbCrLf & vbCrLf)
        rtbRecipt.AppendText($"PC: {frmNewOrder.selectedPcName} (${frmNewOrder.basePrice} JOD) x{frmNewOrder.numQuantity.Value}" & vbCrLf & vbCrLf)
        rtbRecipt.AppendText("[ Extras ]" & vbCrLf & vbCrLf)

        If frmNewOrder.chkKeyboard.Checked Then
            rtbRecipt.AppendText($"{frmNewOrder.chkKeyboard.Text} ({frmNewOrder.lblKeyboardPrice.Text})" & vbCrLf)
        End If
        If frmNewOrder.chkMouse.Checked Then
            rtbRecipt.AppendText($"{frmNewOrder.chkMouse.Text} ({frmNewOrder.lblMousePrice.Text})" & vbCrLf)
        End If
        rtbRecipt.AppendText(vbCrLf & vbCrLf & vbCrLf & vbCrLf & $"Subtotal: ${frmNewOrder.txtTotal.Text} JOD" & vbCrLf)
        rtbRecipt.AppendText($"Total: {Val(frmNewOrder.txtTotal.Text) * 1.1}")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim intUserId As Integer = PublicParam.userId
        Dim intCustomerId As Integer = frmNewOrder.selectedCustomerId
        Dim intPcId As Integer = frmNewOrder.selectedPcId
        Dim intQuantity As Integer = frmNewOrder.numQuantity.Value

        Dim sqlOrderCommand As String = "INSERT INTO Orders (UserId, CustomerId) 
                                    VALUES(@UserId, @CustomerId)"
        Dim sqlOrderItemsCommand As String = "INSERT INTO Order_Items (OrderId, ItemId, Quantity) 
                                    VALUES(@OrderId,@ItemId, @Quantity)"

        Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
            Try
                AccessConn.Open()
                Dim orderCmd As New OleDb.OleDbCommand(sqlOrderCommand, AccessConn)
                orderCmd.Parameters.AddWithValue("@UserId", intUserId)
                orderCmd.Parameters.AddWithValue("@CustomerId", intCustomerId)
                orderCmd.ExecuteNonQuery()
                orderCmd.CommandText = "SELECT @@IDENTITY"
                Dim newOrderId As Integer = orderCmd.ExecuteScalar()

                Dim orderItemsCmd As New OleDb.OleDbCommand(sqlOrderItemsCommand, AccessConn)
                orderItemsCmd.Parameters.AddWithValue("@OrderId", newOrderId)
                orderItemsCmd.Parameters.AddWithValue("@ItemId", intPcId)
                orderItemsCmd.Parameters.AddWithValue("@Quantity", intQuantity)
                orderItemsCmd.ExecuteNonQuery()
                MessageBox.Show("Order confirmed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
