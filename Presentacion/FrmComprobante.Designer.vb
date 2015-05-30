<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprobante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComprobante))
        Me.GenerarComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquilibriumDataSet = New Equilibrium_Gym.EquilibriumDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GenerarComprobanteTableAdapter = New Equilibrium_Gym.EquilibriumDataSetTableAdapters.GenerarComprobanteTableAdapter()
        CType(Me.GenerarComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquilibriumDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenerarComprobanteBindingSource
        '
        Me.GenerarComprobanteBindingSource.DataMember = "GenerarComprobante"
        Me.GenerarComprobanteBindingSource.DataSource = Me.EquilibriumDataSet
        '
        'EquilibriumDataSet
        '
        Me.EquilibriumDataSet.DataSetName = "EquilibriumDataSet"
        Me.EquilibriumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSEquilibirum"
        ReportDataSource1.Value = Me.GenerarComprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Equilibrium_Gym.Comprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1044, 564)
        Me.ReportViewer1.TabIndex = 0
        '
        'GenerarComprobanteTableAdapter
        '
        Me.GenerarComprobanteTableAdapter.ClearBeforeFill = True
        '
        'FrmComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmComprobante"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante de pago"
        CType(Me.GenerarComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquilibriumDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GenerarComprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquilibriumDataSet As Equilibrium_Gym.EquilibriumDataSet
    Friend WithEvents GenerarComprobanteTableAdapter As Equilibrium_Gym.EquilibriumDataSetTableAdapters.GenerarComprobanteTableAdapter
End Class
