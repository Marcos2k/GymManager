<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarUsuario))
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblAcceso = New System.Windows.Forms.Label()
        Me.CBAcceso = New System.Windows.Forms.ComboBox()
        Me.TBContraseñaValidar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(191, 197)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 17
        Me.BtnAgregar.Text = "Modificar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LblAcceso
        '
        Me.LblAcceso.AutoSize = True
        Me.LblAcceso.Location = New System.Drawing.Point(25, 156)
        Me.LblAcceso.Name = "LblAcceso"
        Me.LblAcceso.Size = New System.Drawing.Size(43, 13)
        Me.LblAcceso.TabIndex = 16
        Me.LblAcceso.Text = "Acceso"
        '
        'CBAcceso
        '
        Me.CBAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAcceso.FormattingEnabled = True
        Me.CBAcceso.Location = New System.Drawing.Point(127, 153)
        Me.CBAcceso.Name = "CBAcceso"
        Me.CBAcceso.Size = New System.Drawing.Size(139, 21)
        Me.CBAcceso.TabIndex = 15
        '
        'TBContraseñaValidar
        '
        Me.TBContraseñaValidar.Location = New System.Drawing.Point(127, 81)
        Me.TBContraseñaValidar.Name = "TBContraseñaValidar"
        Me.TBContraseñaValidar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseñaValidar.Size = New System.Drawing.Size(139, 20)
        Me.TBContraseñaValidar.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Contraseña nueva"
        '
        'TBContraseña
        '
        Me.TBContraseña.Location = New System.Drawing.Point(128, 117)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseña.Size = New System.Drawing.Size(139, 20)
        Me.TBContraseña.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contraseña actual"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(127, 46)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(139, 20)
        Me.TBUsuario.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre de usuario"
        '
        'FrmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 262)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LblAcceso)
        Me.Controls.Add(Me.CBAcceso)
        Me.Controls.Add(Me.TBContraseñaValidar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModificarUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents LblAcceso As System.Windows.Forms.Label
    Friend WithEvents CBAcceso As System.Windows.Forms.ComboBox
    Friend WithEvents TBContraseñaValidar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
