Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3, num4, num5, num6, num7, num8, num9, Escalar As Integer

        num1 = T1.Text
        num2 = T2.Text
        num3 = T3.Text
        num4 = T4.Text
        num5 = T5.Text
        num6 = T6.Text
        num7 = T7.Text
        num8 = T8.Text
        num9 = T9.Text

        Escalar = Esc.Text

        R1.Text = num1 * Escalar
        R2.Text = num2 * Escalar
        R3.Text = num3 * Escalar
        R4.Text = num4 * Escalar
        R5.Text = num5 * Escalar
        R6.Text = num6 * Escalar
        R7.Text = num7 * Escalar
        R8.Text = num8 * Escalar
        R9.Text = num9 * Escalar



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Clear.Click
        R1.Text = ""
        R2.Text = ""
        R3.Text = ""
        R4.Text = ""
        R5.Text = ""
        R6.Text = ""
        R7.Text = ""
        R8.Text = ""
        R9.Text = ""


    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class