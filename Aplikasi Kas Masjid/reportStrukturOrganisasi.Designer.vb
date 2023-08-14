<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportStrukturOrganisasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.strukturOrganisasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAKAMAS = New AKAMAS.DataSetAKAMAS()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.strukturOrganisasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAKAMAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'strukturOrganisasiBindingSource
        '
        Me.strukturOrganisasiBindingSource.DataMember = "strukturOrganisasi"
        Me.strukturOrganisasiBindingSource.DataSource = Me.DataSetAKAMAS
        '
        'DataSetAKAMAS
        '
        Me.DataSetAKAMAS.DataSetName = "DataSetAKAMAS"
        Me.DataSetAKAMAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetAKAMAS"
        ReportDataSource2.Value = Me.strukturOrganisasiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AKAMAS.reportContentStrukturOrganisasi.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(782, 553)
        Me.ReportViewer1.TabIndex = 0
        '
        'reportStrukturOrganisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportStrukturOrganisasi"
        Me.Text = "Report Struktur Organisasi [AKAMAS]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.strukturOrganisasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAKAMAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents strukturOrganisasiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetAKAMAS As AKAMAS.DataSetAKAMAS
End Class
