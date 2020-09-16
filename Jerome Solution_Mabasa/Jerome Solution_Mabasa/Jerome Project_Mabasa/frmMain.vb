Public Class frmMain
    'variables
    Private Const dblSALES_TAX = 0.05
    Private Const dblSHIPPING_CHARGE = 6.5
    Dim dblSubtotal As Double
    Dim dblSalesTax As Double
    Dim dblShippingCharge As Double
    Dim dblTotalDue As Double
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'variable
        Dim dblPrice As Double

        ' store input in variable
        Double.TryParse(txtPrice.Text, dblPrice)
        'calculate subtotal and tax
        dblSubtotal = dblSubtotal + dblPrice
        dblSalesTax = dblSALES_TAX * dblSubtotal
        'shipping
        If dblSubtotal >= 100 Then
            dblShippingCharge = 0
        Else
            dblShippingCharge = dblSHIPPING_CHARGE
        End If
        'calculate total due
        dblTotalDue = dblSubtotal + dblSalesTax + dblShippingCharge

        'display
        lblSubtotal.Text = dblSubtotal.ToString("F")
        lblSalesTax.Text = dblSalesTax.ToString("F")
        lblShipping.Text = dblShippingCharge.ToString("F")
        lblTotalDue.Text = dblTotalDue.ToString("c2")
        'focus
        txtPrice.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' allow only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        lblSubtotal.Text = String.Empty
        lblSalesTax.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub
End Class
