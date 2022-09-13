Imports System.Text.RegularExpressions
Public Class Form2
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text + "+"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text + "-"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text + "*"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text + "/"
    End Sub

    Private Function parseSum(ByVal input As String) As Decimal
        Dim result() As String = Regex.Split(input, "(\+|-)")
        Dim sumStack As New List(Of String)
        Dim finalSum As Decimal = 0
        Dim subtrahendStack As New List(Of String)
        Dim finalSubtrahend As Decimal = 0
        '2 is a sum, 1 is a substraction, 0 is number
        Dim flag As Integer = 2
        For Each Str As String In result
            Select Case flag
                Case 2
                    sumStack.Add(Str)
                Case 1
                    subtrahendStack.Add(Str)
            End Select
            If Str = "-" Then
                flag = 1
            ElseIf Str = "+" Then
                flag = 2
            Else
                flag = 0
            End If
        Next
        For Each Str As String In sumStack
            finalSum = finalSum + parseProduct(Str)
        Next
        For Each Str As String In subtrahendStack
            finalSubtrahend = finalSubtrahend + parseProduct(Str)
        Next
        Return finalSum - finalSubtrahend
    End Function

    Private Function parseProduct(ByVal input As String) As Decimal
        Dim result() As String = Regex.Split(input, "(\*|/)")
        Dim productStack As New List(Of Decimal)
        Dim finalProduct As Decimal = 1
        Dim quotentStack As New List(Of Decimal)
        Dim finalQuotent As Decimal = 1
        '2 is a product, 1 is a division, 0 is a number
        Dim flag As Integer = 2
        For Each Str As String In result
            Select Case flag
                Case 2
                    productStack.Add(Str)
                Case 1
                    quotentStack.Add(Str)
            End Select
            If Str = "/" Then
                flag = 1
            ElseIf Str = "*" Then
                flag = 2
            Else
                flag = 0
            End If
        Next


        For Each Num As Decimal In productStack
            finalProduct = finalProduct * Num
        Next
        For Each Num As Decimal In quotentStack
            finalQuotent = finalQuotent * Num
        Next
        Return finalProduct / finalQuotent
    End Function

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = CStr(parseSum(TextBox1.Text))
    End Sub
End Class