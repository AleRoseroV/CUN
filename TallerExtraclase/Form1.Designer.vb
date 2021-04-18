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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AplicacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidoDeFutbolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EleccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculoDeIMCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AplicacionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AplicacionesToolStripMenuItem
        '
        Me.AplicacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PartidoDeFutbolToolStripMenuItem, Me.EleccionesToolStripMenuItem, Me.CalculoDeIMCToolStripMenuItem})
        Me.AplicacionesToolStripMenuItem.Name = "AplicacionesToolStripMenuItem"
        Me.AplicacionesToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.AplicacionesToolStripMenuItem.Text = "Aplicaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PartidoDeFutbolToolStripMenuItem
        '
        Me.PartidoDeFutbolToolStripMenuItem.Name = "PartidoDeFutbolToolStripMenuItem"
        Me.PartidoDeFutbolToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PartidoDeFutbolToolStripMenuItem.Text = "Partido de futbol"
        '
        'EleccionesToolStripMenuItem
        '
        Me.EleccionesToolStripMenuItem.Name = "EleccionesToolStripMenuItem"
        Me.EleccionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EleccionesToolStripMenuItem.Text = "Elecciones"
        '
        'CalculoDeIMCToolStripMenuItem
        '
        Me.CalculoDeIMCToolStripMenuItem.Name = "CalculoDeIMCToolStripMenuItem"
        Me.CalculoDeIMCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculoDeIMCToolStripMenuItem.Text = "Calculo de IMC"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AplicacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartidoDeFutbolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EleccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculoDeIMCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
