<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalle
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
        Me.TBDetalle = New System.Windows.Forms.TextBox()
        Me.LblIDPago = New System.Windows.Forms.Label()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A continuacion complete el detalle del cobro y pulse finalizar"
        '
        'TBDetalle
        '
        Me.TBDetalle.Location = New System.Drawing.Point(30, 78)
        Me.TBDetalle.MaxLength = 255
        Me.TBDetalle.Multiline = True
        Me.TBDetalle.Name = "TBDetalle"
        Me.TBDetalle.Size = New System.Drawing.Size(426, 129)
        Me.TBDetalle.TabIndex = 1
        '
        'LblIDPago
        '
        Me.LblIDPago.AutoSize = True
        Me.LblIDPago.Location = New System.Drawing.Point(27, 22)
        Me.LblIDPago.Name = "LblIDPago"
        Me.LblIDPago.Size = New System.Drawing.Size(39, 13)
        Me.LblIDPago.TabIndex = 2
        Me.LblIDPago.Text = "Label2"
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Location = New System.Drawing.Point(381, 225)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnFinalizar.TabIndex = 3
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'FrmDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnFinalizar)
        Me.Controls.Add(Me.LblIDPago)
        Me.Controls.Add(Me.TBDetalle)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDetalle"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Completar detalle de cobro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBDetalle As System.Windows.Forms.TextBox
    Friend WithEvents LblIDPago As System.Windows.Forms.Label
    Friend WithEvents BtnFinalizar As System.Windows.Forms.Button
End Class
