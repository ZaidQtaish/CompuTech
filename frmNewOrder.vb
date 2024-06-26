Public Class frmNewOrder
    Public selectedPcId As Integer = 0
    Public selectedPcName As String = ""
    Public basePrice As Decimal
    Public selectedCustomerId As Integer

    Private Sub btnSelect1_Click(sender As Object, e As EventArgs) Handles btnSelect1.Click
        btnCancelReset_Click(sender, e)
        DisplayPcSpecs("Intel Core i5-12400F", "AMD Radeon™ RX 6650 XT 8GB", "Teamgroup Delta 16GB DDR5 5600", "Deepcool AK400 Digital Air Cooler", 499.99, 1)
    End Sub

    Private Sub btnSelect2_Click(sender As Object, e As EventArgs) Handles btnSelect2.Click
        btnCancelReset_Click(sender, e)
        DisplayPcSpecs("Intel Core i5-12600F", "GeForce RTX™ 4060 Ti 8GB", "Teamgroup Delta 16GB DDR5 5600", "Deepcool AK500 Digital Air Cooler", 999.99, 2)
    End Sub

    Private Sub btnSelect3_Click(sender As Object, e As EventArgs) Handles btnSelect3.Click
        btnCancelReset_Click(sender, e)
        DisplayPcSpecs("AMD Ryzen 5 7600X", "AMD Radeon™ RX 7700 XT 12GB", "Teamgroup Delta 32GB DDR5 6000", "Deepcool AK620 Digital Air Cooler", 1499.99, 3)
    End Sub

    Private Sub DisplayPcSpecs(cpu As String, gpu As String, ram As String, cooler As String, price As Decimal, pcSelection As Integer)
        boxSpecs.Visible = True
        lblQuantity.Visible = True
        numQuantity.Visible = True
        lblExtras.Visible = True
        chkMouse.Visible = True
        chkKeyboard.Visible = True
        lblMousePrice.Visible = True
        lblKeyboardPrice.Visible = True
        btnPrintInvoice.Visible = True

        lblCpu.Text = cpu
        lblGpu.Text = gpu
        lblRam.Text = ram
        lblCooler.Text = cooler
        numQuantity.Value = 1
        basePrice = price
        txtTotal.Text = basePrice
        selectedPcId = pcSelection

        If selectedPcId = 1 Then
            selectedPcName = "Player One"
        ElseIf selectedPcId = 2 Then
            selectedPcName = "Player Two"
        ElseIf selectedPcId = 3 Then
            selectedPcName = "Player Three"
        End If
    End Sub

    Private Sub btnCancelReset_Click(sender As Object, e As EventArgs) Handles btnCancelReset.Click
        boxSpecs.Visible = False
        lblQuantity.Visible = False
        numQuantity.Visible = False
        numQuantity.Value = 0
        lblExtras.Visible = False
        chkMouse.Visible = False
        chkMouse.Checked = False
        chkKeyboard.Visible = False
        chkKeyboard.Checked = False
        lblMousePrice.Visible = False
        lblKeyboardPrice.Visible = False
        btnPrintInvoice.Visible = False
        txtTotal.Text = 0
        selectedPcId = 0
        selectedPcName = ""
    End Sub

    Private Sub numQuantity_ValueChanged(sender As Object, e As EventArgs) Handles numQuantity.ValueChanged
        UpdateTotal()
    End Sub

    Private Sub chkMouse_CheckedChanged(sender As Object, e As EventArgs) Handles chkMouse.CheckedChanged
        UpdateTotal()
    End Sub

    Private Sub chkKeyboard_CheckedChanged(sender As Object, e As EventArgs) Handles chkKeyboard.CheckedChanged
        UpdateTotal()
    End Sub

    Private Sub UpdateTotal()
        Dim total As Decimal = basePrice * numQuantity.Value

        If chkMouse.Checked Then
            total += 69.99
        End If

        If chkKeyboard.Checked Then
            total += 179.99
        End If

        txtTotal.Text = total
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click
        Dim objFrmCustomerDGV As New frmCustomerDGV
        objFrmCustomerDGV.Show()
    End Sub

    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs) Handles btnPrintInvoice.Click
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Please select a customer.", "Customer Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If selectedPcId = 0 Or txtTotal.Text = 0 Then
            MessageBox.Show("Please select a PC.", "PC Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim objFrmOrderRecipt As New frmOrderRecipt
        objFrmOrderRecipt.Show()
    End Sub
End Class
