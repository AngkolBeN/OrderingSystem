
Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim total As Decimal = 0

        ' Calculate size price
        If chkSmall.Checked Then total += 75
        If chkMedium.Checked Then total += 150
        If chkLarge.Checked Then total += 200

        ' Calculate toppings price
        If chkCreamy.Checked Then total += 5
        If chkChunky.Checked Then total += 10
        If chkUnsalted.Checked Then total += 5

        ' Multiply by quantity
        Dim quantity As Integer = CInt(numQuantity.Value)
        total *= quantity

        ' Get amount given
        Dim amountGiven As Decimal
        If Decimal.TryParse(txtAmountGiven.Text, amountGiven) Then
            Dim change As Decimal = amountGiven - total
            ' Create transaction string
            Dim transaction As String = $"`Total: ₱{total:F2}, Amount Given: ₱{amountGiven:F2}, Change: ₱{change:F2}"
            listTransactions.Items.Add(transaction)
        Else
            MessageBox.Show("Please enter a valid amount given.")
        End If

    End Sub

End Class
