﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.RosyBrown
        Me.Button1.Location = New System.Drawing.Point(157, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sumar matrices"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Button2.ForeColor = System.Drawing.Color.RosyBrown
        Me.Button2.Location = New System.Drawing.Point(322, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Multiplicar Matrices"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.RosyBrown
        Me.Button3.Location = New System.Drawing.Point(157, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Multiplicar Matriz Por escalar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Button4.ForeColor = System.Drawing.Color.RosyBrown
        Me.Button4.Location = New System.Drawing.Point(322, 165)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 45)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Diagonalizar Matriz (En mantenimiento)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.RosyBrown
        Me.Label1.Location = New System.Drawing.Point(206, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "¿Que desea Realizar?"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(641, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form3"
        Me.Text = "---"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
