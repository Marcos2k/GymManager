<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModuloInformes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModuloInformes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.OptTodosSocios = New System.Windows.Forms.RadioButton()
        Me.OptSociosespecifico = New System.Windows.Forms.RadioButton()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OptMontos = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.BtnGenerarInforme = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido/a al modulo de informes, aqui podras hacer consultas y/o informes pers" & _
    "onalizados"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(426, 187)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 1
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'OptTodosSocios
        '
        Me.OptTodosSocios.AutoSize = True
        Me.OptTodosSocios.Location = New System.Drawing.Point(6, 27)
        Me.OptTodosSocios.Name = "OptTodosSocios"
        Me.OptTodosSocios.Size = New System.Drawing.Size(128, 17)
        Me.OptTodosSocios.TabIndex = 2
        Me.OptTodosSocios.TabStop = True
        Me.OptTodosSocios.Text = "Listar todos los socios"
        Me.OptTodosSocios.UseVisualStyleBackColor = True
        '
        'OptSociosespecifico
        '
        Me.OptSociosespecifico.AutoSize = True
        Me.OptSociosespecifico.Location = New System.Drawing.Point(6, 50)
        Me.OptSociosespecifico.Name = "OptSociosespecifico"
        Me.OptSociosespecifico.Size = New System.Drawing.Size(308, 17)
        Me.OptSociosespecifico.TabIndex = 3
        Me.OptSociosespecifico.TabStop = True
        Me.OptSociosespecifico.Text = "Mostrar movimientos de pago acerca de un socio especifico"
        Me.OptSociosespecifico.UseVisualStyleBackColor = True
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(95, 75)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(189, 20)
        Me.TBNombre.TabIndex = 4
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(290, 73)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(45, 23)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "..."
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID"
        '
        'OptMontos
        '
        Me.OptMontos.AutoSize = True
        Me.OptMontos.Location = New System.Drawing.Point(6, 101)
        Me.OptMontos.Name = "OptMontos"
        Me.OptMontos.Size = New System.Drawing.Size(193, 17)
        Me.OptMontos.TabIndex = 8
        Me.OptMontos.TabStop = True
        Me.OptMontos.Text = "Mostrar y calcular montos por fecha"
        Me.OptMontos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Desde"
        '
        'DTFechaDesde
        '
        Me.DTFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaDesde.Location = New System.Drawing.Point(71, 124)
        Me.DTFechaDesde.Name = "DTFechaDesde"
        Me.DTFechaDesde.Size = New System.Drawing.Size(95, 20)
        Me.DTFechaDesde.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hasta"
        '
        'DTFechaHasta
        '
        Me.DTFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaHasta.Location = New System.Drawing.Point(213, 124)
        Me.DTFechaHasta.Name = "DTFechaHasta"
        Me.DTFechaHasta.Size = New System.Drawing.Size(95, 20)
        Me.DTFechaHasta.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblID)
        Me.GroupBox1.Controls.Add(Me.OptTodosSocios)
        Me.GroupBox1.Controls.Add(Me.DTFechaHasta)
        Me.GroupBox1.Controls.Add(Me.OptSociosespecifico)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.DTFechaDesde)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.OptMontos)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 159)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una tarea a realizar"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(50, 78)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 13)
        Me.LblID.TabIndex = 13
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(507, 187)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 14
        Me.BtnLimpiar.Text = "Limpiar grilla"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(669, 187)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(55, 228)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(930, 313)
        Me.Grilla.TabIndex = 16
        '
        'BtnGenerarInforme
        '
        Me.BtnGenerarInforme.Location = New System.Drawing.Point(588, 187)
        Me.BtnGenerarInforme.Name = "BtnGenerarInforme"
        Me.BtnGenerarInforme.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerarInforme.TabIndex = 17
        Me.BtnGenerarInforme.Text = "Imprimir"
        Me.BtnGenerarInforme.UseVisualStyleBackColor = True
        '
        'FrmModuloInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.BtnGenerarInforme)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModuloInformes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo Informes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents OptTodosSocios As System.Windows.Forms.RadioButton
    Friend WithEvents OptSociosespecifico As System.Windows.Forms.RadioButton
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OptMontos As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents BtnGenerarInforme As System.Windows.Forms.Button
    Friend WithEvents LblID As System.Windows.Forms.Label
End Class
