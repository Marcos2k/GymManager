Imports System.Windows.Forms

Public Class FrmMenu
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub SociosToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SociosToolStripMenuItem1.Click

    End Sub
    Private Sub AccederAlModuloToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AccederAlModuloToolStripMenuItem1.Click
        FrmSocios.MdiParent = Me
        FrmSocios.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AccederAlModuloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccederAlModuloToolStripMenuItem.Click
        FrmPagos.MdiParent = Me
        FrmPagos.Show()
    End Sub

    Private Sub AccederAlModuloDeInformesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccederAlModuloDeInformesToolStripMenuItem.Click
        FrmModuloInformes.MdiParent = Me
        FrmModuloInformes.Show()
    End Sub

    Private Sub AgregarUnaCategoriaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarUnaCategoriaToolStripMenuItem.Click
        FrmCategoria.MdiParent = Me
        FrmCategoria.Show()
    End Sub

    Private Sub Menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call EstablecerImagenFondoParaFormLoad()
        'Actualizamos los registros que deben en el dia de la fecha
        Socios.ActulizarDeudores()
        Socios.IncrementarCantidadCuota()
    End Sub
#Region "Proceso de cambio de la imagen de fondo de un Formulario MDI"
    Private Sub EstablecerImagenFondoParaFormLoad()

        Try
            ' Asignamos una imagen al fondo del formulario.
            Me.BackgroundImage = _
            Image.FromFile("crystalindigofondo.jpg") 'Busca la imagen desde la carpeta Bin/Debug

            ' Ajustamos la imagen dentro del rectángulo
            ' cliente del control.
            ' Por ejemplo.: 
            ' Si la imagen es muy 'grande' y ponemos *center* 
            ' la imagen no se ve entera, solo se ve la parte 
            ' superior izquierda que *entra* en el formulario
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Finally
            ' Si no se carga la imagen se muestra 
            ' el color de fondo por defecto
        End Try
    End Sub
#End Region

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        FrmAgregar_usuario.MdiParent = Me
        FrmAgregar_usuario.Show()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        FrmModificarUsuario.MdiParent = Me
        FrmModificarUsuario.Show()
    End Sub

    Private Sub InformacionDelSistemaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InformacionDelSistemaToolStripMenuItem.Click
        FrmAcerca.MdiParent = Me
        FrmAcerca.Show()
    End Sub

    Private Sub ConsultarVencimientosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarVencimientosToolStripMenuItem.Click
        FrmVencimientos.MdiParent = Me
        FrmVencimientos.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarToolStripMenuItem.Click
        FrmRegistrarAsistencias.MdiParent = Me
        FrmRegistrarAsistencias.Show()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        FrmVerAsistencias.MdiParent = Me
        FrmVerAsistencias.Show()
    End Sub
End Class
