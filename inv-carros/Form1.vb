Public Class Form1
    Public Structure infocarro
        Public make As String
        Public model As String
        Public purchaseprice As Decimal
        Public purchasedate As Date
    End Structure

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim micarro As infocarro
        micarro.make = "jeep"
        micarro.model = "cherokee"
        micarro.purchaseprice = 27999
        micarro.purchasedate = #6/23/2000#
        TextBox1.Text = micarro.make
        TextBox2.Text = micarro.model
        TextBox3.Text = micarro.purchaseprice
        TextBox4.Text = micarro.purchasedate
    End Sub
End Class
