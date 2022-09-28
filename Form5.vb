Public Class Form5


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        R00.Text = Val(A00.Text * B00.Text) + Val(A01.Text * B10.Text) + Val(A02.Text * B20.Text)
        R01.Text = Val(A00.Text * B01.Text) + Val(A01.Text * B11.Text) + Val(A02.Text * B21.Text)
        R02.Text = Val(A00.Text * B02.Text) + Val(A01.Text * B12.Text) + Val(A02.Text * B22.Text)
        R10.Text = Val(A10.Text * B00.Text) + Val(A11.Text * B10.Text) + Val(A12.Text * B20.Text)
        R11.Text = Val(A10.Text * B01.Text) + Val(A11.Text * B11.Text) + Val(A12.Text * B21.Text)
        R12.Text = Val(A10.Text * B02.Text) + Val(A11.Text * B12.Text) + Val(A12.Text * B22.Text)
        R20.Text = Val(A20.Text * B00.Text) + Val(A21.Text * B10.Text) + Val(A22.Text * B20.Text)
        R21.Text = Val(A20.Text * B01.Text) + Val(A21.Text * B11.Text) + Val(A22.Text * B21.Text)
        R22.Text = Val(A20.Text * B02.Text) + Val(A21.Text * B12.Text) + Val(A22.Text * B22.Text)






    End Sub
End Class