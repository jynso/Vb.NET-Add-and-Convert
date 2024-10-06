Imports System.DirectoryServices

Public Class Form1
    Dim firstnumber As Double
    Dim secondnumber As Double




    Private Sub btnsum_Click(sender As Object, e As EventArgs) Handles btnsum.Click
        firstnumber = CDbl(txtfirstnum.Text)
        secondnumber = CDbl(txtsecondnum.Text)

        Dim sum As Double = firstnumber + secondnumber

        txtsum.Text = $"The sum of the two is {sum}"

    End Sub

    Private Sub btnpercent_Click(sender As Object, e As EventArgs) Handles btnpercent.Click
        firstnumber = CDbl(txtfirstnum.Text)
        secondnumber = CDbl(txtsecondnum.Text)
        Dim thirtypercent As Decimal = CDec(0.3)

        Dim sum As Double = firstnumber + secondnumber
        Dim percent As Decimal = sum * thirtypercent


        txtpercent.Text = $"The 30% of the {sum} is {percent}%"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtpercent.Text = ""
        txtsum.Text = ""
        txtfirstnum.Text = ""
        txtsecondnum.Text = ""

    End Sub
End Class
