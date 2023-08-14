Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms

Public Class showStrukturOrganisasi

    Private Sub showStrukturOrganisasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Dim noUrut As Integer = 0
        DataGridViewStrukturOrganisasi.Rows.Clear()
        Try
            'rubah lbNamaMasjid
            cmd = New OdbcCommand("SELECT nama_masjid FROM identitas WHERE identitas_id = 'IDM-1'", con)
            Dim nama_masjid As String = cmd.ExecuteScalar
            lbNamaMasjid.Text = "'" & nama_masjid.ToUpper() & "'"

            'isikan data ke datagrid
            da = New OdbcDataAdapter("SELECT posisi.posisi, GROUP_CONCAT(posisi_detail.pj SEPARATOR ', ') AS pj FROM posisi_detail JOIN posisi ON posisi.posisi_id = posisi_detail.posisi_id GROUP BY posisi.posisi_id ORDER BY posisi.posisi_id", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                'prepare variabel pendukung
                noUrut += 1
                DataGridViewStrukturOrganisasi.Rows.Add((noUrut), row(0), row(1))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub

    Private Sub btnCetakReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakReport.Click
        Dim dtReport As New DataTable
        With dtReport
            .Columns.Add("no")
            .Columns.Add("nama_posisi")
            .Columns.Add("nama_pj")
        End With
        For Each row As DataGridViewRow In DataGridViewStrukturOrganisasi.Rows
            dtReport.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value)
        Next

        'isikan ke parameter
        Dim parameters(7) As ReportParameter

        'Isikan sesmua parameter kop
        cmd = New OdbcCommand("SELECT nama_masjid, alamat_singkat, alamat_sekretariat, telp FROM identitas WHERE identitas_id = 'IDM-1'", con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            parameters(0) = New ReportParameter("nama_masjid", dr.Item("nama_masjid").ToString)
            parameters(1) = New ReportParameter("alamat_singkat", dr.Item("alamat_singkat").ToString)
            parameters(2) = New ReportParameter("alamat_sekretariat", "Sekretariat : " & dr.Item("alamat_sekretariat").ToString)
            parameters(3) = New ReportParameter("telp", "Telp. " & dr.Item("telp").ToString)
        Else
            parameters(0) = New ReportParameter("nama_masjid", "Nama Masjid")
            parameters(1) = New ReportParameter("alamat_singkat", "Alamat Singkat")
            parameters(2) = New ReportParameter("alamat_sekretariat", "Alamat Sekretariat")
            parameters(3) = New ReportParameter("telp", "Telp.")
        End If

        'Isikan sesmua parameter mengetahui
        cmd = New OdbcCommand("SELECT (SELECT posisi.posisi FROM posisi WHERE posisi.posisi_id = 'POS-1') AS pos_takmir, (SELECT posisi.posisi FROM posisi WHERE posisi.posisi_id = 'POS-2') AS pos_sekretaris, (SELECT posisi_detail.pj FROM posisi_detail JOIN posisi ON posisi.posisi_id = posisi_detail.posisi_id WHERE posisi.posisi_id = 'POS-1') AS pj_takmir, posisi_detail.pj AS pj_sekretaris FROM posisi_detail JOIN posisi ON posisi.posisi_id = posisi_detail.posisi_id WHERE posisi.posisi_id = 'POS-2'", con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            parameters(4) = New ReportParameter("mengetahui_pos_takmir", dr.Item("pos_takmir").ToString)
            parameters(5) = New ReportParameter("mengetahui_pos_sekretaris", dr.Item("pos_sekretaris").ToString)
            parameters(6) = New ReportParameter("mengetahui_pj_takmir", "(" & dr.Item("pj_takmir").ToString & ")")
            parameters(7) = New ReportParameter("mengetahui_pj_sekretaris", "(" & dr.Item("pj_sekretaris").ToString & ")")
        Else
            parameters(4) = New ReportParameter("mengetahui_pos_takmir", "KETUA TAKMIR")
            parameters(5) = New ReportParameter("mengetahui_pos_sekretaris", "SEKRETARIS")
            parameters(6) = New ReportParameter("mengetahui_pj_takmir", "(NAMA TAKMIR)")
            parameters(7) = New ReportParameter("mengetahui_pj_sekretaris", "(NAMA SEKRETARIS)")
        End If

        'SetAttr parameters di report
        reportStrukturOrganisasi.ReportViewer1.LocalReport.SetParameters(parameters)
        reportKas.ReportViewer1.LocalReport.Refresh()
        reportStrukturOrganisasi.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtReport
        reportStrukturOrganisasi.ShowDialog()
        reportStrukturOrganisasi.Dispose()
    End Sub
End Class