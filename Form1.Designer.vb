<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraCientificaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraVectorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraDeMatricesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SumarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicarPorEscalarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModoToolStripMenuItem
        '
        Me.ModoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraCientificaToolStripMenuItem, Me.CalculadoraVectorialToolStripMenuItem, Me.CalculadoraDeMatricesToolStripMenuItem})
        Me.ModoToolStripMenuItem.Name = "ModoToolStripMenuItem"
        Me.ModoToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ModoToolStripMenuItem.Text = "Modo"
        '
        'CalculadoraCientificaToolStripMenuItem
        '
        Me.CalculadoraCientificaToolStripMenuItem.Name = "CalculadoraCientificaToolStripMenuItem"
        Me.CalculadoraCientificaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CalculadoraCientificaToolStripMenuItem.Text = "Calculadora Cientifica"
        '
        'CalculadoraVectorialToolStripMenuItem
        '
        Me.CalculadoraVectorialToolStripMenuItem.Name = "CalculadoraVectorialToolStripMenuItem"
        Me.CalculadoraVectorialToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CalculadoraVectorialToolStripMenuItem.Text = "Calculadora vectorial"
        '
        'CalculadoraDeMatricesToolStripMenuItem
        '
        Me.CalculadoraDeMatricesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumarToolStripMenuItem, Me.MultiplicarToolStripMenuItem, Me.MultiplicarPorEscalarToolStripMenuItem})
        Me.CalculadoraDeMatricesToolStripMenuItem.Name = "CalculadoraDeMatricesToolStripMenuItem"
        Me.CalculadoraDeMatricesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CalculadoraDeMatricesToolStripMenuItem.Text = "Calculadora de Matrices"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 364)
        Me.Panel1.TabIndex = 1
        '
        'SumarToolStripMenuItem
        '
        Me.SumarToolStripMenuItem.Name = "SumarToolStripMenuItem"
        Me.SumarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SumarToolStripMenuItem.Text = "Sumar"
        '
        'MultiplicarToolStripMenuItem
        '
        Me.MultiplicarToolStripMenuItem.Name = "MultiplicarToolStripMenuItem"
        Me.MultiplicarToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MultiplicarToolStripMenuItem.Text = "Multiplicar Matrices"
        '
        'MultiplicarPorEscalarToolStripMenuItem
        '
        Me.MultiplicarPorEscalarToolStripMenuItem.Name = "MultiplicarPorEscalarToolStripMenuItem"
        Me.MultiplicarPorEscalarToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MultiplicarPorEscalarToolStripMenuItem.Text = "Multiplicar por Escalar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 390)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ModoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraCientificaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraVectorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculadoraDeMatricesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SumarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplicarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplicarPorEscalarToolStripMenuItem As ToolStripMenuItem
End Class
