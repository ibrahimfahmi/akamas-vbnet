Public Class reportStrukturOrganisasi

    Private Sub reportStrukturOrganisasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.Normal)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        'Me.ReportViewer1.ZoomPercent = 25
    End Sub
End Class