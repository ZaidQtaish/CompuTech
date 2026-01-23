Public Class frmUpdateItem
    Private Sub frmUpdateItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radSearchByID.Checked = True
        txtSearchItemId.Enabled = True
    End Sub
    Private Sub radSearchByID_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchByID.CheckedChanged
        txtSearchItemId.Enabled = True
        txtSearchItemId.BackColor = Color.White
        txtSearchName.Enabled = False
        txtSearchName.Clear()
        txtSearchName.BackColor = Color.DarkGray
    End Sub

    Private Sub radSearchByType_CheckedChanged(sender As Object, e As EventArgs) Handles radSearchByName.CheckedChanged
        txtSearchName.Enabled = True
        txtSearchName.BackColor = Color.White
        txtSearchItemId.Enabled = False
        txtSearchItemId.Clear()
        txtSearchItemId.BackColor = Color.DarkGray
    End Sub

    Private Sub btnCancelReset_Click(sender As Object, e As EventArgs) Handles btnCancelReset.Click
        txtSearchItemId.Clear()
        txtSearchName.Clear()
        txtItemName.Clear()
        txtItemName.Enabled = False
        txtItemType.Clear()
        txtItemType.Enabled = False
        txtItemPrice.Clear()
        txtItemPrice.Enabled = False
        picItem.Image = picItem.ErrorImage
        btnItemImage.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnFindItem_Click(sender As Object, e As EventArgs) Handles btnFindItem.Click
        Dim DS As New Data.DataSet("Items")
        Dim sqlCommand As String

        If radSearchByID.Checked Then
            If String.IsNullOrWhiteSpace(txtSearchItemId.Text) Then
                MessageBox.Show("Please enter an Item ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            sqlCommand = "SELECT * FROM Items WHERE ItemID = @ItemID"
        Else
            If String.IsNullOrWhiteSpace(txtSearchName.Text) Then
                MessageBox.Show("Please enter an Item Type.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            sqlCommand = "SELECT * FROM Items WHERE Name = @ItemName"
        End If

        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    If radSearchByID.Checked Then
                        cmd.Parameters.AddWithValue("@ItemID", txtSearchItemId.Text)
                    Else
                        cmd.Parameters.AddWithValue("@ItemName", txtSearchName.Text)
                    End If

                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "Items")

                    If DS.Tables("Items").Rows.Count > 0 Then
                        Dim row As DataRow = DS.Tables("Items").Rows(0)
                        txtSearchItemId.Text = row("ItemID").ToString()
                        txtItemName.Text = row("Name").ToString()
                        txtItemName.Enabled = True
                        txtItemType.Text = row("Type").ToString()
                        txtItemType.Enabled = True
                        txtItemPrice.Text = row("Price").ToString()
                        txtItemPrice.Enabled = True
                        picItem.ImageLocation = row("ImagePath").ToString()
                        btnItemImage.Visible = True
                    Else
                        MessageBox.Show("No item found with the given information.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this Item?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Return
        End If

        Dim strItemID As String = txtSearchItemId.Text
        Dim strItemName As String = txtItemName.Text
        Dim strItemType As String = txtItemType.Text
        Dim strItemPrice As String = txtItemPrice.Text
        Dim strItemImage As String = picItem.ImageLocation

        Dim sqlCommand As String = "UPDATE Items SET Name = @ItemName, Type = @ItemType, 
                                    Price = @ItemPrice, ImagePath = @ItemImage
                                    WHERE ItemID = @ItemID"
        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    cmd.Parameters.AddWithValue("@ItemName", strItemName)
                    cmd.Parameters.AddWithValue("@ItemType", strItemType)
                    cmd.Parameters.AddWithValue("@ItemPrice", strItemPrice)
                    cmd.Parameters.AddWithValue("@ItemImage", strItemImage)
                    cmd.Parameters.AddWithValue("@ItemID", strItemID)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub btnItemImage_Click(sender As Object, e As EventArgs) Handles btnItemImage.Click
        openImage.ShowDialog()
    End Sub

    Private Sub openImage_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openImage.FileOk
        Dim image As String = openImage.FileName
        picItem.ImageLocation = image
    End Sub
End Class