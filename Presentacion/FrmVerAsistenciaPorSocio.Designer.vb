<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerAsistenciaPorSocio
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GimnasioDataSet3 = New Equilibrium_Gym.GimnasioDataSet3()
        Me.VerAsistenciaPorSocioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerAsistenciaPorSocioTableAdapter = New Equilibrium_Gym.GimnasioDataSet3TableAdapters.VerAsistenciaPorSocioTableAdapter()
        Me.TBIDSocio = New System.Windows.Forms.TextBox()
        CType(Me.GimnasioDataSet3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.VerAsistenciaPorSocioBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VerAsistenciaPorSocioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Equilibrium_Gym.VerAsistenciasPorSocio.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1044, 564)
        Me.ReportViewer1.TabIndex = 0
        '
        'GimnasioDataSet3
        '
        Me.GimnasioDataSet3.DataSetName = "GimnasioDataSet3"
        Me.GimnasioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VerAsistenciaPorSocioBindingSource
        '
        Me.VerAsistenciaPorSocioBindingSource.DataMember = "VerAsistenciaPorSocio"
        Me.VerAsistenciaPorSocioBindingSource.DataSource = Me.GimnasioDataSet3
        '
        'VerAsistenciaPorSocioTableAdapter
        '
        Me.VerAsistenciaPorSocioTableAdapter.ClearBeforeFill = true
        '
        'TBIDSocio
        '
        Me.TBIDSocio.Location = New System.Drawing.Point(740, 13)
        Me.TBIDSocio.Name = "TBIDSocio"
        Me.TBIDSocio.Size = New System.Drawing.Size(100, 20)
        Me.TBIDSocio.TabIndex = 1
        '
        'FrmVerAsistenciaPorSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.TBIDSocio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmVerAsistenciaPorSocio"
        Me.ShowIcon = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVerAsistenciaPorSocio"
        CType(Me.GimnasioDataSet3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.VerAsistenciaPorSocioBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VerAsistenciaPorSocioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GimnasioDataSet3 As Equilibrium_Gym.GimnasioDataSet3
    Friend WithEvents VerAsistenciaPorSocioTableAdapter As Equilibrium_Gym.GimnasioDataSet3TableAdapters.VerAsistenciaPorSocioTableAdapter
    Friend WithEvents TBIDSocio As System.Windows.Forms.TextBox
End Class
