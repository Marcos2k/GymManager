<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoDeudoresTotales
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GenerarInformeTodosLosDeudoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GimnasioDataSet2 = New Equilibrium_Gym.GimnasioDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GenerarInformeTodosLosDeudoresTableAdapter = New Equilibrium_Gym.GimnasioDataSet2TableAdapters.GenerarInformeTodosLosDeudoresTableAdapter()
        CType(Me.GenerarInformeTodosLosDeudoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GimnasioDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenerarInformeTodosLosDeudoresBindingSource
        '
        Me.GenerarInformeTodosLosDeudoresBindingSource.DataMember = "GenerarInformeTodosLosDeudores"
        Me.GenerarInformeTodosLosDeudoresBindingSource.DataSource = Me.GimnasioDataSet2
        '
        'GimnasioDataSet2
        '
        Me.GimnasioDataSet2.DataSetName = "GimnasioDataSet2"
        Me.GimnasioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GenerarInformeTodosLosDeudoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Equilibrium_Gym.ListadoDeDeudores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1044, 564)
        Me.ReportViewer1.TabIndex = 0
        '
        'GenerarInformeTodosLosDeudoresTableAdapter
        '
        Me.GenerarInformeTodosLosDeudoresTableAdapter.ClearBeforeFill = True
        '
        'FrmListadoDeudoresTotales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmListadoDeudoresTotales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmListadoDeudoresTotales"
        CType(Me.GenerarInformeTodosLosDeudoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GimnasioDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GenerarInformeTodosLosDeudoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GimnasioDataSet2 As Equilibrium_Gym.GimnasioDataSet2
    Friend WithEvents GenerarInformeTodosLosDeudoresTableAdapter As Equilibrium_Gym.GimnasioDataSet2TableAdapters.GenerarInformeTodosLosDeudoresTableAdapter
End Class
