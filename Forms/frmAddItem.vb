Public Class frmAddItem
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancelReset_Click(sender As Object, e As EventArgs) Handles btnCancelReset.Click
        txtName.Clear()
        txtType.Clear()
        txtPrice.Clear()
        picItem.Image = picItem.ErrorImage
        txtName.Focus()
    End Sub

    Private Sub btnAddNewItem_Click(sender As Object, e As EventArgs) Handles btnAddNewItem.Click
        ' Check if all required fields are filled
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
       String.IsNullOrWhiteSpace(txtType.Text) OrElse
       String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert customer into database
        Dim strName As String = txtName.Text
        Dim strType As String = txtType.Text
        Dim strPrice As String = txtPrice.Text
        Dim strImage As String = picItem.ImageLocation

        Dim sqlCommand As String = "INSERT INTO Items(Name, Type, Price, ImagePath) 
                                    VALUES(@Name, @Type, @Price, @Image)"

        Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
            Try
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    cmd.Parameters.AddWithValue("@Name", strName)
                    cmd.Parameters.AddWithValue("@Type", strType)
                    cmd.Parameters.AddWithValue("@Price", strPrice)
                    cmd.Parameters.AddWithValue("@Image", strImage)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("New Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        openImage.ShowDialog()
        Dim image As String = openImage.FileName
        picItem.ImageLocation = image
    End Sub
End Class