﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListado))
        Me.MostrarSociosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquilibriumDataSet2 = New Equilibrium_Gym.EquilibriumDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MostrarSociosTableAdapter = New Equilibrium_Gym.EquilibriumDataSet2TableAdapters.MostrarSociosTableAdapter()
        CType(Me.MostrarSociosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquilibriumDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MostrarSociosBindingSource
        '
        Me.MostrarSociosBindingSource.DataMember = "MostrarSocios"
        Me.MostrarSociosBindingSource.DataSource = Me.EquilibriumDataSet2
        '
        'EquilibriumDataSet2
        '
        Me.EquilibriumDataSet2.DataSetName = "EquilibriumDataSet2"
        Me.EquilibriumDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MostrarSociosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Equilibrium_Gym.LitstadoDeSocios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1044, 564)
        Me.ReportViewer1.TabIndex = 0
        '
        'MostrarSociosTableAdapter
        '
        Me.MostrarSociosTableAdapter.ClearBeforeFill = True
        '
        'FrmListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 564)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de socios"
        CType(Me.MostrarSociosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquilibriumDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MostrarSociosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquilibriumDataSet2 As Equilibrium_Gym.EquilibriumDataSet2
    Friend WithEvents MostrarSociosTableAdapter As Equilibrium_Gym.EquilibriumDataSet2TableAdapters.MostrarSociosTableAdapter
End Class
