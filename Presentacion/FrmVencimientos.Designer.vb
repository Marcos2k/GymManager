<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVencimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVencimientos))
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.BtnGenerarInforme = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        Me.NupDias = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OptVencimientopordia = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OptTodoslosdeudores = New System.Windows.Forms.RadioButton()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(672, 15)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(0, 13)
        Me.LblFecha.TabIndex = 1
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(55, 228)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(930, 313)
        Me.Grilla.TabIndex = 17
        '
        'BtnGenerarInforme
        '
        Me.BtnGenerarInforme.Location = New System.Drawing.Point(588, 187)
        Me.BtnGenerarInforme.Name = "BtnGenerarInforme"
        Me.BtnGenerarInforme.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerarInforme.TabIndex = 21
        Me.BtnGenerarInforme.Text = "Imprimir"
        Me.BtnGenerarInforme.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(669, 187)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 20
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(507, 187)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 19
        Me.BtnLimpiar.Text = "Limpiar grilla"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(426, 187)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 18
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'LblInexistente
        '
        Me.LblInexistente.AutoSize = True
        Me.LblInexistente.Location = New System.Drawing.Point(476, 372)
        Me.LblInexistente.Name = "LblInexistente"
        Me.LblInexistente.Size = New System.Drawing.Size(93, 13)
        Me.LblInexistente.TabIndex = 29
        Me.LblInexistente.TabStop = True
        Me.LblInexistente.Text = "Datos inexistentes"
        '
        'NupDias
        '
        Me.NupDias.Location = New System.Drawing.Point(203, 27)
        Me.NupDias.Name = "NupDias"
        Me.NupDias.Size = New System.Drawing.Size(38, 20)
        Me.NupDias.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(247, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "de cada mes"
        '
        'OptVencimientopordia
        '
        Me.OptVencimientopordia.AutoSize = True
        Me.OptVencimientopordia.Location = New System.Drawing.Point(6, 27)
        Me.OptVencimientopordia.Name = "OptVencimientopordia"
        Me.OptVencimientopordia.Size = New System.Drawing.Size(191, 17)
        Me.OptVencimientopordia.TabIndex = 37
        Me.OptVencimientopordia.TabStop = True
        Me.OptVencimientopordia.Text = "Consultar los vencen todos los dias"
        Me.OptVencimientopordia.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptTodoslosdeudores)
        Me.GroupBox1.Controls.Add(Me.OptVencimientopordia)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.NupDias)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 159)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una tarea a realizar"
        '
        'OptTodoslosdeudores
        '
        Me.OptTodoslosdeudores.AutoSize = True
        Me.OptTodoslosdeudores.Location = New System.Drawing.Point(6, 50)
        Me.OptTodoslosdeudores.Name = "OptTodoslosdeudores"
        Me.OptTodoslosdeudores.Size = New System.Drawing.Size(244, 17)
        Me.OptTodoslosdeudores.TabIndex = 38
        Me.OptTodoslosdeudores.TabStop = True
        Me.OptTodoslosdeudores.Text = "Mostrar todos los deudores hasta el dia de hoy"
        Me.OptTodoslosdeudores.UseVisualStyleBackColor = True
        '
        'FrmVencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblInexistente)
        Me.Controls.Add(Me.BtnGenerarInforme)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.LblFecha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVencimientos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de vencimientos al dia de la fecha"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents BtnGenerarInforme As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents NupDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents OptVencimientopordia As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OptTodoslosdeudores As System.Windows.Forms.RadioButton
End Class
