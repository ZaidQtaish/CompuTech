Public Class frmUsersInfo
    Dim DS As New Data.DataSet("Users")
    Dim intRowIndex As Integer = 0

    Private Sub frmUserInfoFormView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlCommand As String = "SELECT UserId, UserFName, UserLName, Username, [Password], Active from Users"
        Try
            Using AccessConn As New OleDb.OleDbConnection(PublicParam.connectionString)
                AccessConn.Open()
                Using cmd As New OleDb.OleDbCommand(sqlCommand, AccessConn)
                    Dim da As New OleDbDataAdapter(cmd)
                    da.Fill(DS, "Users")
                    If DS.Tables("Users").Rows.Count = 0 Then
                        MessageBox.Show("No User Data Found !", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtUserId.Text = DS.Tables(0).Rows(0).Item(0).ToString
                        txtUserFName.Text = DS.Tables(0).Rows(0).Item(1).ToString
                        txtUserLName.Text = DS.Tables(0).Rows(0).Item(2).ToString
                        txtUsername.Text = DS.Tables(0).Rows(0).Item(3).ToString
                        txtPassword.Text = DS.Tables(0).Rows(0).Item(4).ToString

                        If DS.Tables(0).Rows(0).Item(5) Then
                            lblInactive.Visible = False
                            lblActive.Visible = True
                        Else
                            lblActive.Visible = False
                            lblInactive.Visible = True
                        End If
                    End If
                End Using
            End Using
            btnNextRecord.Focus()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        Try
            If intRowIndex < DS.Tables(0).Rows.Count - 1 Then
                intRowIndex = intRowIndex + 1

                txtUserId.Text = DS.Tables(0).Rows(intRowIndex).Item(0).ToString
                txtUserFName.Text = DS.Tables(0).Rows(intRowIndex).Item(1).ToString
                txtUserLName.Text = DS.Tables(0).Rows(intRowIndex).Item(2).ToString
                txtUsername.Text = DS.Tables(0).Rows(intRowIndex).Item(3).ToString
                txtPassword.Text = DS.Tables(0).Rows(intRowIndex).Item(4).ToString

                If DS.Tables(0).Rows(intRowIndex).Item(5) Then
                    lblInactive.Visible = False
                    lblActive.Visible = True
                Else
                    lblActive.Visible = False
                    lblInactive.Visible = True
                End If
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub btnPrevRecord_Click(sender As Object, e As EventArgs) Handles btnPrevRecord.Click
        Try
            If intRowIndex > 0 Then
                intRowIndex = intRowIndex - 1

                txtUserId.Text = DS.Tables(0).Rows(intRowIndex).Item(0).ToString
                txtUserFName.Text = DS.Tables(0).Rows(intRowIndex).Item(1).ToString
                txtUserLName.Text = DS.Tables(0).Rows(intRowIndex).Item(2).ToString
                txtUsername.Text = DS.Tables(0).Rows(intRowIndex).Item(3).ToString
                txtPassword.Text = DS.Tables(0).Rows(intRowIndex).Item(4).ToString

                If DS.Tables(0).Rows(intRowIndex).Item(5) Then
                    lblInactive.Visible = False
                    lblActive.Visible = True
                Else
                    lblActive.Visible = False
                    lblInactive.Visible = True
                End If
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub btnFirstRecord_Click(sender As Object, e As EventArgs) Handles btnFirstRecord.Click
        Try
            If DS.Tables("Users").Rows.Count = 0 Then
                MessageBox.Show("No Cusrtomer Data Found !", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                intRowIndex = 0

                txtUserId.Text = DS.Tables(0).Rows(intRowIndex).Item(0).ToString
                txtUserFName.Text = DS.Tables(0).Rows(intRowIndex).Item(1).ToString
                txtUserLName.Text = DS.Tables(0).Rows(intRowIndex).Item(2).ToString
                txtUsername.Text = DS.Tables(0).Rows(intRowIndex).Item(3).ToString
                txtPassword.Text = DS.Tables(0).Rows(intRowIndex).Item(4).ToString

                If DS.Tables(0).Rows(intRowIndex).Item(5) Then
                    lblInactive.Visible = False
                    lblActive.Visible = True
                Else
                    lblActive.Visible = False
                    lblInactive.Visible = True
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub btnLastRecord_Click(sender As Object, e As EventArgs) Handles btnLastRecord.Click
        Try
            intRowIndex = DS.Tables(0).Rows.Count - 1

            txtUserId.Text = DS.Tables(0).Rows(intRowIndex).Item(0).ToString
            txtUserFName.Text = DS.Tables(0).Rows(intRowIndex).Item(1).ToString
            txtUserLName.Text = DS.Tables(0).Rows(intRowIndex).Item(2).ToString
            txtUsername.Text = DS.Tables(0).Rows(intRowIndex).Item(3).ToString
            txtPassword.Text = DS.Tables(0).Rows(intRowIndex).Item(4).ToString

            If DS.Tables(0).Rows(intRowIndex).Item(5) Then
                lblInactive.Visible = False
                lblActive.Visible = True
            Else
                lblActive.Visible = False
                lblInactive.Visible = True
            End If


        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class