Public Class Form1
    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Dim dPrice As Decimal
        Dim dQuantity As Decimal
        Dim dDiscount As Decimal
        Dim dVat As Decimal
        Dim dTotalCost As Decimal

        dPrice = 25
        dQuantity = 10
        dDiscount = 2
        dVat = 0.15
        dTotalCost = (dPrice - dQuantity) * dDiscount

        MsgBox("The total cost without vat for client is " & dTotalCost)
    End Sub
End Class
