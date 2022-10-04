Public Class Form1
    Private Sub changePanel1Contents(ByVal aForm As Form)
        aForm.TopLevel = False
        aForm.WindowState = FormWindowState.Maximized
        aForm.FormBorderStyle = FormBorderStyle.None
        Panel1.Controls.Clear()
        Panel1.Controls.Add(aForm)
        aForm.Show()
    End Sub

    Private Sub CalculadoraCientificaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraCientificaToolStripMenuItem.Click
        changePanel1Contents(Form2)
    End Sub

    Private Sub SumarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumarToolStripMenuItem.Click
        changePanel1Contents(Form4)
    End Sub

    Private Sub MultiplicarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplicarToolStripMenuItem.Click
        changePanel1Contents(Form5)
    End Sub

    Private Sub CalculadoraVectorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraVectorialToolStripMenuItem.Click
        changePanel1Contents(Form8)
    End Sub

    Private Sub MultiplicarPorEscalarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplicarPorEscalarToolStripMenuItem.Click
        changePanel1Contents(Form6)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changePanel1Contents(Form2)
    End Sub
End Class