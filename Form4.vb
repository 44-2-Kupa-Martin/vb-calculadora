Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ma00, Ma01, Ma02, Ma10, Ma11, Ma12, Ma20, Ma21, Ma22, Mb00, Mb01, Mb02, Mb10, Mb11, Mb12, Mb20, Mb21, Mb22 As Integer

        Ma00 = Ma1.Text
        Ma01 = Ma2.Text
        Ma02 = Ma3.Text
        Ma10 = Ma4.Text
        Ma11 = Ma5.Text
        Ma12 = Ma6.Text
        Ma20 = Ma7.Text
        Ma21 = Ma8.Text
        Ma22 = Ma9.Text

        Mb00 = Mb1.Text
        Mb01 = Mb2.Text
        Mb02 = Mb3.Text
        Mb10 = Mb4.Text
        Mb11 = Mb5.Text
        Mb12 = Mb6.Text
        Mb20 = Mb7.Text
        Mb21 = Mb8.Text
        Mb22 = Mb9.Text

        R1.Text = Ma00 + Mb00
        R2.Text = Ma01 + Mb01
        R3.Text = Ma02 + Mb02
        R4.Text = Ma10 + Mb10
        R5.Text = Ma11 + Mb11
        R6.Text = Ma12 + Mb12
        R7.Text = Ma20 + Mb20
        R8.Text = Ma21 + Mb21
        R9.Text = Ma22 + Mb22





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
End Class