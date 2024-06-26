Imports System.Data.OleDb

Public Class frmMdiMainScreen
    Private Sub AddNewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem.Click
        Dim objFrmAddNewUser As New frmAddNewUser
        objFrmAddNewUser.MdiParent = Me
        objFrmAddNewUser.Show()
    End Sub

    Private Sub AddNewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCustomerToolStripMenuItem.Click
        Dim objFrmAddNewCustomer As New frmAddNewCustomer
        objFrmAddNewCustomer.MdiParent = Me
        objFrmAddNewCustomer.Show()
    End Sub

    Private Sub DeleteCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCustomerToolStripMenuItem.Click
        Dim objFrmDeleteCustomer As New frmDeleteCustomer
        objFrmDeleteCustomer.MdiParent = Me
        objFrmDeleteCustomer.Show()
    End Sub

    Private Sub ConnectToAccessMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToAccessMenuItem.Click
        Using connection As New OleDb.OleDbConnection(connectionString)
            Try
                connection.Open()
                MessageBox.Show("Connection to the database was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub UpdateUserInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserInfoToolStripMenuItem.Click
        Dim objFrmUpdateUser As New frmUpdateUser
        objFrmUpdateUser.MdiParent = Me
        objFrmUpdateUser.Show()
    End Sub

    Private Sub UpdateCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomerToolStripMenuItem.Click
        Dim objFrmUpdateCustomer As New frmUpdateCustomer
        objFrmUpdateCustomer.MdiParent = Me
        objFrmUpdateCustomer.Show()
    End Sub

    Private Sub UsersInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersInfoToolStripMenuItem.Click
        Dim objFrmUsersInfo As New frmUsersInfo
        objFrmUsersInfo.MdiParent = Me
        objFrmUsersInfo.Show()
    End Sub

    Private Sub CustomerInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerInfoToolStripMenuItem.Click
        Dim objFrmCustomerInfo As New frmCustomerInfo
        objFrmCustomerInfo.MdiParent = Me
        objFrmCustomerInfo.Show()
    End Sub

    Private Sub CustomerDGVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDGVToolStripMenuItem.Click
        Dim objFrmCustomerDGV As New frmCustomerDGV
        objFrmCustomerDGV.MdiParent = Me
        objFrmCustomerDGV.Show()
    End Sub

    Private Sub NewOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewOrderToolStripMenuItem.Click
        frmNewOrder.MdiParent = Me
        frmNewOrder.Show()
    End Sub

    Private Sub ShowItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowItemsToolStripMenuItem.Click
        Dim objFrmItemsInfo As New frmItemsInfo
        objFrmItemsInfo.MdiParent = Me
        objFrmItemsInfo.Show()
    End Sub

    Private Sub AddNewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewItemToolStripMenuItem.Click
        Dim objfrmAddItem As New frmAddItem
        objfrmAddItem.MdiParent = Me
        objfrmAddItem.Show()
    End Sub

    Private Sub UpdateItemInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateItemInfoToolStripMenuItem.Click
        Dim objfrmUpdateItem As New frmUpdateItem
        objfrmUpdateItem.MdiParent = Me
        objfrmUpdateItem.Show()
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        Dim objfrmDeleteItem As New frmDeleteItem
        objfrmDeleteItem.MdiParent = Me
        objfrmDeleteItem.Show()
    End Sub

    Private Sub OrdersInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersInfoToolStripMenuItem.Click
        Dim objfrmDeleteItem As New frmOrderInfo
        objfrmDeleteItem.MdiParent = Me
        objfrmDeleteItem.Show()
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm In MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub frmMdiMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim C As Control
        For Each C In Me.Controls
            If TypeOf C Is MdiClient Then
                C.BackColor = ColorTranslator.FromHtml("#171732")
                Exit For
            End If
        Next
        C = Nothing
    End Sub
End Class
