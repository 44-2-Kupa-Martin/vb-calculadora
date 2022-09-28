Public Class Form8

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rel1.Value = num1.Value + num4.Value
        rel2.Value = num2.Value + num5.Value
        rel3.Value = num3.Value + num6.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rel1.Value = num1.Value - num4.Value
        rel2.Value = num2.Value - num5.Value
        rel3.Value = num3.Value - num6.Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        rel1.Value = num1.Value * num4.Value
        rel2.Value = num2.Value * num5.Value
        rel3.Value = num3.Value * num6.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rel1.Value = num1.Value * esc1.Value
        rel2.Value = num2.Value * esc1.Value
        rel3.Value = num3.Value * esc1.Value
    End Sub

End Class