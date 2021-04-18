<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rnombre = New System.Windows.Forms.TextBox()
        Me.Rpeso = New System.Windows.Forms.TextBox()
        Me.Raltura = New System.Windows.Forms.TextBox()
        Me.Rapellido = New System.Windows.Forms.TextBox()
        Me.Resultados = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altura (metros)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Peso"
        '
        'Rnombre
        '
        Me.Rnombre.Location = New System.Drawing.Point(160, 56)
        Me.Rnombre.Name = "Rnombre"
        Me.Rnombre.Size = New System.Drawing.Size(165, 20)
        Me.Rnombre.TabIndex = 4
        '
        'Rpeso
        '
        Me.Rpeso.Location = New System.Drawing.Point(160, 172)
        Me.Rpeso.Name = "Rpeso"
        Me.Rpeso.Size = New System.Drawing.Size(100, 20)
        Me.Rpeso.TabIndex = 5
        '
        'Raltura
        '
        Me.Raltura.Location = New System.Drawing.Point(160, 134)
        Me.Raltura.Name = "Raltura"
        Me.Raltura.Size = New System.Drawing.Size(100, 20)
        Me.Raltura.TabIndex = 6
        '
        'Rapellido
        '
        Me.Rapellido.Location = New System.Drawing.Point(160, 95)
        Me.Rapellido.Name = "Rapellido"
        Me.Rapellido.Size = New System.Drawing.Size(165, 20)
        Me.Rapellido.TabIndex = 7
        '
        'Resultados
        '
        Me.Resultados.FormattingEnabled = True
        Me.Resultados.Location = New System.Drawing.Point(507, 56)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Size = New System.Drawing.Size(244, 212)
        Me.Resultados.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Calculo IMC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Resultados)
        Me.Controls.Add(Me.Rapellido)
        Me.Controls.Add(Me.Raltura)
        Me.Controls.Add(Me.Rpeso)
        Me.Controls.Add(Me.Rnombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Calculo de IMC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Rnombre As TextBox
    Friend WithEvents Rpeso As TextBox
    Friend WithEvents Raltura As TextBox
    Friend WithEvents Rapellido As TextBox
    Friend WithEvents Resultados As ListBox
    Friend WithEvents Button1 As Button
End Class
