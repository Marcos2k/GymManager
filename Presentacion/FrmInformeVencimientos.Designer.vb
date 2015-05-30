<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformeVencimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformeVencimientos))
        Me.ConsultarDeudoresPorFechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GimnasioDataSet = New Equilibrium_Gym.GimnasioDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsultarDeudoresPorFechaTableAdapter = New Equilibrium_Gym.GimnasioDataSetTableAdapters.ConsultarDeudoresPorFechaTableAdapter()
        Me.TBDia = New System.Windows.Forms.TextBox()
        CType(Me.ConsultarDeudoresPorFechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GimnasioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultarDeudoresPorFechaBindingSource
        '
        Me.ConsultarDeudoresPorFechaBindingSource.DataMember = "ConsultarDeudoresPorFecha"
        Me.ConsultarDeudoresPorFechaBindingSource.DataSource = Me.GimnasioDataSet
        '
        'GimnasioDataSet
        '
        Me.GimnasioDataSet.DataSetName = "GimnasioDataSet"
        Me.GimnasioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ConsultarDeudoresPorFechaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Equilibrium_Gym.InformeDeVencimientos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1044, 564)
        Me.ReportViewer1.TabIndex = 0
        '
        'ConsultarDeudoresPorFechaTableAdapter
        '
        Me.ConsultarDeudoresPorFechaTableAdapter.ClearBeforeFill = True
        '
        'TBDia
        '
        Me.TBDia.Location = New System.Drawing.Point(860, 50)
        Me.TBDia.Name = "TBDia"
        Me.TBDia.Size = New System.Drawing.Size(100, 20)
        Me.TBDia.TabIndex = 2
        '
        'FrmInformeVencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.TBDia)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInformeVencimientos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de vencimientos"
        CType(Me.ConsultarDeudoresPorFechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GimnasioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsultarDeudoresPorFechaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GimnasioDataSet As Equilibrium_Gym.GimnasioDataSet
    Friend WithEvents ConsultarDeudoresPorFechaTableAdapter As Equilibrium_Gym.GimnasioDataSetTableAdapters.ConsultarDeudoresPorFechaTableAdapter
    Friend WithEvents TBDia As System.Windows.Forms.TextBox
End Class
