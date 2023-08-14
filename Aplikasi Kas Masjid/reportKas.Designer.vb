<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportKas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetAKAMAS = New AKAMAS.DataSetAKAMAS()
        Me.kasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetAKAMAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetAKAMAS"
        ReportDataSource1.Value = Me.kasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AKAMAS.reportContentKas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(782, 553)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetAKAMAS
        '
        Me.DataSetAKAMAS.DataSetName = "DataSetAKAMAS"
        Me.DataSetAKAMAS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'kasBindingSource
        '
        Me.kasBindingSource.DataMember = "kas"
        Me.kasBindingSource.DataSource = Me.DataSetAKAMAS
        '
        'reportKas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reportKas"
        Me.Text = "Report Kas [AKAMAS]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetAKAMAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents kasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetAKAMAS As AKAMAS.DataSetAKAMAS
End Class
