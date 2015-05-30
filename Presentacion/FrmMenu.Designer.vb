<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SociosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccederAlModuloToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccederAlModuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnaCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccederAlModuloDeInformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarVencimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SociosToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.InformesToolStripMenuItem, Me.AcercaToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.Name = "MenuStrip"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SociosToolStripMenuItem1, Me.PagosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        resources.ApplyResources(Me.SociosToolStripMenuItem, "SociosToolStripMenuItem")
        '
        'SociosToolStripMenuItem1
        '
        Me.SociosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccederAlModuloToolStripMenuItem1, Me.AsistenciasToolStripMenuItem})
        Me.SociosToolStripMenuItem1.Name = "SociosToolStripMenuItem1"
        resources.ApplyResources(Me.SociosToolStripMenuItem1, "SociosToolStripMenuItem1")
        '
        'AccederAlModuloToolStripMenuItem1
        '
        Me.AccederAlModuloToolStripMenuItem1.Name = "AccederAlModuloToolStripMenuItem1"
        resources.ApplyResources(Me.AccederAlModuloToolStripMenuItem1, "AccederAlModuloToolStripMenuItem1")
        '
        'AsistenciasToolStripMenuItem
        '
        Me.AsistenciasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.ConsultarToolStripMenuItem})
        Me.AsistenciasToolStripMenuItem.Name = "AsistenciasToolStripMenuItem"
        resources.ApplyResources(Me.AsistenciasToolStripMenuItem, "AsistenciasToolStripMenuItem")
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        resources.ApplyResources(Me.RegistrarToolStripMenuItem, "RegistrarToolStripMenuItem")
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        resources.ApplyResources(Me.ConsultarToolStripMenuItem, "ConsultarToolStripMenuItem")
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccederAlModuloToolStripMenuItem})
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        resources.ApplyResources(Me.PagosToolStripMenuItem, "PagosToolStripMenuItem")
        '
        'AccederAlModuloToolStripMenuItem
        '
        Me.AccederAlModuloToolStripMenuItem.Name = "AccederAlModuloToolStripMenuItem"
        resources.ApplyResources(Me.AccederAlModuloToolStripMenuItem, "AccederAlModuloToolStripMenuItem")
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.CategoriasToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        resources.ApplyResources(Me.MantenimientoToolStripMenuItem, "MantenimientoToolStripMenuItem")
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioToolStripMenuItem, Me.ModificarUsuarioToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        resources.ApplyResources(Me.UsuariosToolStripMenuItem, "UsuariosToolStripMenuItem")
        '
        'AgregarUsuarioToolStripMenuItem
        '
        Me.AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        resources.ApplyResources(Me.AgregarUsuarioToolStripMenuItem, "AgregarUsuarioToolStripMenuItem")
        '
        'ModificarUsuarioToolStripMenuItem
        '
        Me.ModificarUsuarioToolStripMenuItem.Name = "ModificarUsuarioToolStripMenuItem"
        resources.ApplyResources(Me.ModificarUsuarioToolStripMenuItem, "ModificarUsuarioToolStripMenuItem")
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUnaCategoriaToolStripMenuItem})
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        resources.ApplyResources(Me.CategoriasToolStripMenuItem, "CategoriasToolStripMenuItem")
        '
        'AgregarUnaCategoriaToolStripMenuItem
        '
        Me.AgregarUnaCategoriaToolStripMenuItem.Name = "AgregarUnaCategoriaToolStripMenuItem"
        resources.ApplyResources(Me.AgregarUnaCategoriaToolStripMenuItem, "AgregarUnaCategoriaToolStripMenuItem")
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccederAlModuloDeInformesToolStripMenuItem, Me.ConsultarVencimientosToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        resources.ApplyResources(Me.InformesToolStripMenuItem, "InformesToolStripMenuItem")
        '
        'AccederAlModuloDeInformesToolStripMenuItem
        '
        Me.AccederAlModuloDeInformesToolStripMenuItem.Name = "AccederAlModuloDeInformesToolStripMenuItem"
        resources.ApplyResources(Me.AccederAlModuloDeInformesToolStripMenuItem, "AccederAlModuloDeInformesToolStripMenuItem")
        '
        'ConsultarVencimientosToolStripMenuItem
        '
        Me.ConsultarVencimientosToolStripMenuItem.Name = "ConsultarVencimientosToolStripMenuItem"
        resources.ApplyResources(Me.ConsultarVencimientosToolStripMenuItem, "ConsultarVencimientosToolStripMenuItem")
        '
        'AcercaToolStripMenuItem
        '
        Me.AcercaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionDelSistemaToolStripMenuItem})
        Me.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem"
        resources.ApplyResources(Me.AcercaToolStripMenuItem, "AcercaToolStripMenuItem")
        '
        'InformacionDelSistemaToolStripMenuItem
        '
        Me.InformacionDelSistemaToolStripMenuItem.Name = "InformacionDelSistemaToolStripMenuItem"
        resources.ApplyResources(Me.InformacionDelSistemaToolStripMenuItem, "InformacionDelSistemaToolStripMenuItem")
        '
        'FrmMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmMenu"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents SociosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SociosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccederAlModuloToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccederAlModuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccederAlModuloDeInformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarUnaCategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarVencimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsistenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
