<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerAsistencias
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
        Me.BtnGenerarInforme = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblID = New System.Windows.Forms.Label()
        Me.OptTodasAsistencias = New System.Windows.Forms.RadioButton()
        Me.DTFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.OptSociosespecifico = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.DTFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OptFiltro = New System.Windows.Forms.RadioButton()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.LblInexistente = New System.Windows.Forms.LinkLabel()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGenerarInforme
        '
        Me.BtnGenerarInforme.Location = New System.Drawing.Point(588, 187)
        Me.BtnGenerarInforme.Name = "BtnGenerarInforme"
        Me.BtnGenerarInforme.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerarInforme.TabIndex = 23
        Me.BtnGenerarInforme.Text = "Imprimir"
        Me.BtnGenerarInforme.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(55, 228)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(930, 313)
        Me.Grilla.TabIndex = 22
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(669, 187)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 21
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(507, 187)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 20
        Me.BtnLimpiar.Text = "Limpiar grilla"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblID)
        Me.GroupBox1.Controls.Add(Me.OptTodasAsistencias)
        Me.GroupBox1.Controls.Add(Me.DTFechaHasta)
        Me.GroupBox1.Controls.Add(Me.OptSociosespecifico)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.DTFechaDesde)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.OptFiltro)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 159)
        Me.GroupBox1.TabIndex = 19
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
        'OptTodasAsistencias
        '
        Me.OptTodasAsistencias.AutoSize = True
        Me.OptTodasAsistencias.Location = New System.Drawing.Point(6, 27)
        Me.OptTodasAsistencias.Name = "OptTodasAsistencias"
        Me.OptTodasAsistencias.Size = New System.Drawing.Size(160, 17)
        Me.OptTodasAsistencias.TabIndex = 2
        Me.OptTodasAsistencias.TabStop = True
        Me.OptTodasAsistencias.Text = "Mostrar todas las asistencias"
        Me.OptTodasAsistencias.UseVisualStyleBackColor = True
        '
        'DTFechaHasta
        '
        Me.DTFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaHasta.Location = New System.Drawing.Point(213, 124)
        Me.DTFechaHasta.Name = "DTFechaHasta"
        Me.DTFechaHasta.Size = New System.Drawing.Size(95, 20)
        Me.DTFechaHasta.TabIndex = 12
        '
        'OptSociosespecifico
        '
        Me.OptSociosespecifico.AutoSize = True
        Me.OptSociosespecifico.Location = New System.Drawing.Point(6, 50)
        Me.OptSociosespecifico.Name = "OptSociosespecifico"
        Me.OptSociosespecifico.Size = New System.Drawing.Size(302, 17)
        Me.OptSociosespecifico.TabIndex = 3
        Me.OptSociosespecifico.TabStop = True
        Me.OptSociosespecifico.Text = "Mostrar asistencias de pago acerca de un socio especifico"
        Me.OptSociosespecifico.UseVisualStyleBackColor = True
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
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(95, 75)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(189, 20)
        Me.TBNombre.TabIndex = 4
        '
        'DTFechaDesde
        '
        Me.DTFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaDesde.Location = New System.Drawing.Point(71, 124)
        Me.DTFechaDesde.Name = "DTFechaDesde"
        Me.DTFechaDesde.Size = New System.Drawing.Size(95, 20)
        Me.DTFechaDesde.TabIndex = 10
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Desde"
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
        'OptFiltro
        '
        Me.OptFiltro.AutoSize = True
        Me.OptFiltro.Location = New System.Drawing.Point(6, 101)
        Me.OptFiltro.Name = "OptFiltro"
        Me.OptFiltro.Size = New System.Drawing.Size(153, 17)
        Me.OptFiltro.TabIndex = 8
        Me.OptFiltro.TabStop = True
        Me.OptFiltro.Text = "Filtrar asistencias por fecha"
        Me.OptFiltro.UseVisualStyleBackColor = True
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
        Me.LblInexistente.TabIndex = 30
        Me.LblInexistente.TabStop = True
        Me.LblInexistente.Text = "Datos inexistentes"
        '
        'FrmVerAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.LblInexistente)
        Me.Controls.Add(Me.BtnGenerarInforme)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Name = "FrmVerAsistencias"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de asistencias"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnGenerarInforme As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents OptTodasAsistencias As System.Windows.Forms.RadioButton
    Friend WithEvents DTFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents OptSociosespecifico As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents DTFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OptFiltro As System.Windows.Forms.RadioButton
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents LblInexistente As System.Windows.Forms.LinkLabel
End Class
