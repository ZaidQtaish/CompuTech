Public Class frmOrderInfo
    Private Sub frmOrderInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DS As New Data.DataSet("Orders")

        Dim sqlCommand As String = "SELECT Orders.OrderId, Orders.UserId, Orders.CustomerId, Order_Items.OrderId, Order_Items.ItemId, Order_Items.Quantity
                                    FROM Orders
                                    INNER JOIN Order_Items ON Orders.OrderId = Order_Items.OrderId"
        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "Orders")
                    If DS.Tables("Orders").Rows.Count = 0 Then
                        MessageBox.Show("No Order Data Found !", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        For i As Integer = 0 To DS.Tables("Orders").Rows.Count - 1
                            dgvOrders.Rows.Add()
                            dgvOrders.Rows(i).Cells(0).Value = DS.Tables(0).Rows(i).Item(0).ToString
                            dgvOrders.Rows(i).Cells(1).Value = DS.Tables(0).Rows(i).Item(1).ToString
                            dgvOrders.Rows(i).Cells(2).Value = DS.Tables(0).Rows(i).Item(2).ToString
                            dgvOrders.Rows(i).Cells(3).Value = DS.Tables(0).Rows(i).Item(4).ToString
                            dgvOrders.Rows(i).Cells(4).Value = DS.Tables(0).Rows(i).Item(5).ToString
                        Next
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class