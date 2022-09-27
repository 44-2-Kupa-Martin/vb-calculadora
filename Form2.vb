Imports System.Text.RegularExpressions
Public Class Form2
    Dim flushNext As Boolean = False
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "0"
        Label1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "1"
        Label1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "2"
        Label1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "3"
        Label1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "4"
        Label1.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "5"
        Label1.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "6"
        Label1.Focus()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "7"
        Label1.Focus()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "8"
        Label1.Focus()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "9"
        Label1.Focus()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = ""
        Label1.Focus()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "+"
        Label1.Focus()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "-"
        Label1.Focus()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "*"
        Label1.Focus()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "/"
        Label1.Focus()
    End Sub

    Private Function test(ByVal input As String) As Double
        Dim myVar As MatchCollection = Regex.Matches(input, "\(([^()]+)\)")
        While myVar.Count <> 0
            For Each match As Match In myVar
                Dim res As Double = parseSum(Regex.Replace(match.ToString(), "\(|\)", ""))
                If res < 0 Then
                    input = input.Replace(match.ToString(), "#" + (-1 * res).ToString())
                Else
                    input = input.Replace(match.ToString(), res.ToString())
                End If
            Next
            myVar = Regex.Matches(input, "\(([^()]+)\)")
        End While
        Return parseSum(input)
    End Function

    Private Function parseSum(ByVal input As String) As Double
        Dim result() As String = Regex.Split(input, "(\+|-)")
        Dim sumStack As New List(Of String)
        Dim finalSum As Double = 0
        Dim subtrahendStack As New List(Of String)
        Dim finalSubtrahend As Double = 0
        '2 is a sum, 1 is a substraction, 0 is number
        Dim flag As Integer = 2
        For Each Str As String In result
            If Str = String.Empty Then
                Continue For
            ElseIf Str = "-" Then
                flag = 1
                Continue For
            ElseIf Str = "+" Then
                flag = 2
                Continue For
            End If
            Select Case flag
                Case 2
                    sumStack.Add(Str)
                    flag = 0
                Case 1
                    subtrahendStack.Add(Str)
                    flag = 0
            End Select
        Next
        For Each Str As String In sumStack
            finalSum = finalSum + parseProduct(Str)
        Next
        For Each Str As String In subtrahendStack
            finalSubtrahend = finalSubtrahend + parseProduct(Str)
        Next
        Return finalSum - finalSubtrahend
    End Function

    Private Function parsePowers(ByVal input As String) As Double
        If input.StartsWith("sqrt") Then
            Dim sqrtBase As Double
            If input.Replace("sqrt", "").StartsWith("#") Then
                sqrtBase = -1 * CDbl(input.Replace("sqrt#", ""))
            Else
                sqrtBase = input.Replace("sqrt", "")
            End If
            Return sqrtBase ^ (1 / 2)
        End If
        Dim result() As String = Regex.Split(input, "(\^)")
        Dim base As Double
        If result(0).StartsWith("#") Then
            base = result(0).Replace("#", "")
            base = -1 * base
        Else
            base = result(0)
        End If
        For i = 1 To result.Length - 1 Step 1
            If result(i) = "^" Then Continue For
            Dim num As Double
            If result(i).StartsWith("#") Then
                num = result(i).Replace("#", "")
                num = -1 * num
            Else
                num = result(i)
            End If
            base = base ^ num
        Next
        Return base
    End Function

    Private Function parseProduct(ByVal input As String) As Double
        Dim result() As String = Regex.Split(input, "(\*|\/)")
        Dim productStack As New List(Of String)
        Dim finalProduct As Double = 1
        Dim quotentStack As New List(Of String)
        Dim finalQuotent As Double = 1
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


        For Each Str As String In productStack
            finalProduct = finalProduct * parsePowers(Str)
        Next
        For Each Str As String In quotentStack
            finalQuotent = finalQuotent * parsePowers(Str)
        Next
        Return finalProduct / finalQuotent
    End Function

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If TextBox1.Text = "" Then
            Return
        End If
        If flushNext Then
            flushNext = False
            TextBox1.Text = ""
            Return
        End If
        Dim result As Double
        Try
            result = test(TextBox1.Text)
        Catch ex As Exception
            flushNext = True
            TextBox1.Text = "Syntax err"
            Return
        End Try
        If Double.IsInfinity(result) Then
            flushNext = True
            TextBox1.Text = "Err div. by Zero"
            Return
        ElseIf Double.IsNaN(result) Then
            flushNext = True
            TextBox1.Text = "Not a real number"
            Return
        End If
        TextBox1.Text = CStr(result)
    End Sub


    Private Sub Form2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "0"
                Button10.PerformClick()
            Case "1"
                Button1.PerformClick()
            Case "2"
                Button2.PerformClick()
            Case "3"
                Button3.PerformClick()
            Case "4"
                Button4.PerformClick()
            Case "5"
                Button5.PerformClick()
            Case "6"
                Button6.PerformClick()
            Case "7"
                Button7.PerformClick()
            Case "8"
                Button8.PerformClick()
            Case "9"
                Button9.PerformClick()
            Case "+"
                Button13.PerformClick()
            Case "-"
                Button14.PerformClick()
            Case "*"
                Button15.PerformClick()
            Case "/"
                Button16.PerformClick()
            Case "^"
                Button17.PerformClick()
            Case "("
                Button19.PerformClick()
            Case ")"
                Button20.PerformClick()
            Case ","
                Button21.PerformClick()
        End Select
    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Button12.PerformClick()
            Case Keys.Back
                Button22.PerformClick()
            Case Keys.Delete
                Button11.PerformClick()
        End Select
    End Sub

    Private Sub Form2_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Label1.Focus()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "^"
        Label1.Focus()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "sqrt("
        Label1.Focus()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + "("
        Label1.Focus()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + ")"
        Label1.Focus()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If flushNext Then
            Return
        End If
        TextBox1.Text = TextBox1.Text + ","
        Label1.Focus()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox1.Text.Length And Not flushNext <> 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
        End If
        Label1.Focus()
    End Sub
End Class