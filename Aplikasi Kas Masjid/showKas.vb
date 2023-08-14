Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms

Public Class showKas

    'declare f to double. Then, to print => Format(Val(f), "###,###") to insert db => Format(Val(f), 0)
    'date, to insert mysql => dtpTgl.Value.ToString("yyyy-MM-dd")
    'FormatDateTime(row(3), DateFormat.ShortDate), Format(row(4), "###,###")

    Sub tampilDataGridBeforeFilter()
        koneksi()
        Dim noUrut As Integer = 0
        Dim masuk As String
        Dim keluar As String
        Dim saldo As Integer = 0
        DataGridViewKas.Rows.Clear()
        Try
            'tampilkan datagrid
            da = New OdbcDataAdapter("SELECT kas.tgl, kas.jenis, kegiatan.kegiatan, kas.ket, kas.masuk, kas.keluar FROM kas LEFT JOIN kegiatan ON kegiatan.kegiatan_id = kas.kegiatan_id GROUP BY kas.kas_id ORDER BY kas.tgl DESC", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                'prepare variabel pendukung
                noUrut += 1
                saldo = saldo + (row(4) - row(5))

                'ganti masuk jadi 0 jika tbmasuk = 0
                If CInt(row(4)) > 0 Then
                    masuk = Format(row(4), "###,###")
                Else
                    masuk = 0
                End If

                'ganti keluar jadi 0 jika tbkeluar = 0
                If CInt(row(5)) > 0 Then
                    keluar = Format(row(5), "###,###")
                Else
                    keluar = 0
                End If
                DataGridViewKas.Rows.Add((noUrut), tglBulanTahun(row(0)), row(1), row(2), row(3), (masuk), (keluar), Format(saldo, " Rp ###,###"))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data kas GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub

    Sub isiCbKegiatanId()
        Try
            cmd = New OdbcCommand("SELECT kegiatan_id FROM kegiatan", con)
            dr = cmd.ExecuteReader
            cbKegiatanId.Items.Clear()
            cbKegiatanId.Items.Add("SEMUA")
            Do While dr.Read
                cbKegiatanId.Items.Add(dr.Item("kegiatan_id"))
            Loop
        Catch ex As Exception
            cbKegiatanId.Text = "errorGetData"
            MsgBox("GAGAL mendapatkan ID Kegiatan, periksa koneksi databse, atau query database.", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub setFieldWithDb()
        isiCbKegiatanId()
        rewriteLbTotalKas()
        'Queryable tgl min tgll max
        Dim cekTglMinMax As String = "SELECT MIN(tgl) AS tgl_min, MAX(tgl) AS tgl_max FROM kas"
        cmd = New OdbcCommand(cekTglMinMax, con)
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr.Item("tgl_min")) And IsDBNull(dr.Item("tgl_max")) Then
            cbJenisKas.Enabled = False
            dtpTglAwal.Enabled = False
            dtpTglAkhir.Enabled = False
            cbKegiatanId.Enabled = False
            tbKegiatan.Enabled = False
            btnCetakReport.Enabled = False
        Else
            Dim minDate As Date = FormatDateTime(dr.Item("tgl_min"), DateFormat.ShortDate)
            Dim maxDate As Date = FormatDateTime(dr.Item("tgl_max"), DateFormat.ShortDate)
            cbJenisKas.Enabled = True
            dtpTglAwal.Enabled = True
            dtpTglAkhir.Enabled = True
            cbKegiatanId.Enabled = True
            tbKegiatan.Enabled = True
            btnCetakReport.Enabled = True
            'ComboBoxSelectedItem
            cbJenisKas.SelectedItem = "SEMUA"
            cbKegiatanId.SelectedItem = "SEMUA"
            'set mindate maxdate
            dtpTglAwal.MinDate = minDate
            dtpTglAwal.MaxDate = maxDate
            dtpTglAkhir.MinDate = minDate
            dtpTglAkhir.MaxDate = maxDate
            'set dtp Text
            dtpTglAwal.Text = minDate
            dtpTglAkhir.Text = maxDate
        End If
    End Sub

    Sub rewriteLbTotalKas()
        Try
            'tampilkan total masuk kas
            cmd = New OdbcCommand("SELECT (SUM(masuk) - SUM(keluar)) AS saldo FROM kas", con)
            'Dim saldo As Integer = cmd.ExecuteScalar()
            'Write lbTotalKas
            Dim saldo As Integer
            If IsDBNull(cmd.ExecuteScalar()) Then
                lbTotalKas.Text = "Rp 0"
            Else
                saldo = cmd.ExecuteScalar()
                lbTotalKas.Text = Format(saldo, "Rp ###,###")
            End If
        Catch ex As Exception
            MsgBox("Menampilkan jumlah saldo kas GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub


    Sub tampilDataGridAfterFilter()
        koneksi()
        'override this
        If cbJenisKas.Text = "" Then
            cbJenisKas.Text = "SEMUA"
        ElseIf cbKegiatanId.Text = "" Then
            cbKegiatanId.Text = "SEMUA"
        End If

        Dim noUrut As Integer = 0
        Dim masuk As String
        Dim keluar As String
        Dim saldo As Integer = 0

        'persiapan query untuk kegiatan_id
        Dim kegiatan_id As String
        If cbKegiatanId.Text = "SEMUA" Then
            kegiatan_id = "%"
        Else
            kegiatan_id = cbKegiatanId.Text
        End If

        'persiapan query untuk jenis
        Dim jenis As String = "%"
        If cbJenisKas.Text = "MASUK" Then
            jenis = "Masuk"
        ElseIf cbJenisKas.Text = "KELUAR" Then
            jenis = "Keluar"
        End If

        'persiapan query untuk tgl_awal
        Dim tglAwal As String = dtpTglAwal.Value.ToString("yyyy-MM-dd")

        'persiapan query untuk tgl_akhir
        Dim tglAkhir As String = dtpTglAkhir.Value.ToString("yyyy-MM-dd")

        DataGridViewKas.Rows.Clear()
        Try
            'tampilkan datagrid
            da = New OdbcDataAdapter("SELECT kas.tgl, kas.jenis, kegiatan.kegiatan, kas.ket, kas.masuk, kas.keluar FROM kas LEFT JOIN kegiatan ON kegiatan.kegiatan_id = kas.kegiatan_id WHERE kas.kegiatan_id LIKE '" & kegiatan_id & "' AND (kas.tgl BETWEEN '" & tglAwal & "' AND '" & tglAkhir & "') AND kas.jenis LIKE '" & jenis & "' GROUP BY kas.kas_id ORDER BY kas.tgl DESC", con)
            dt = New DataTable
            da.Fill(dt)

            'JIKA ROW 0 TAMPILKAN PESAN ERROR, jika lebih tampilkan data
            If dt.Rows.Count = 0 Then
                btnCetakReport.Enabled = False
                'ubah label hidden jadi Rp 0
                lbHiddenTotalKeluarFiltered.Text = "Rp 0"
                lbHiddenTotalMasukFiltered.Text = "Rp 0"
                lbHiddenTotalSaldoFiltered.Text = "Rp 0"
            Else
                btnCetakReport.Enabled = True
                For Each row In dt.Rows
                    'prepare variabel pendukung
                    noUrut += 1
                    saldo = saldo + (row(4) - row(5))

                    'ganti masuk jadi 0 jika tbmasuk = 0
                    If CInt(row(4)) > 0 Then
                        masuk = Format(row(4), "###,###")
                    Else
                        masuk = 0
                    End If

                    'ganti keluar jadi 0 jika tbkeluar = 0
                    If CInt(row(5)) > 0 Then
                        keluar = Format(row(5), "###,###")
                    Else
                        keluar = 0
                    End If
                    DataGridViewKas.Rows.Add((noUrut), tglBulanTahun(row(0)), row(1), row(2), row(3), (masuk), (keluar), Format(saldo, " Rp ###,###"))
                Next
                dt.Rows.Clear()

                'isikan field hidden total
                cmd = New OdbcCommand("SELECT SUM(keluar) AS total_keluar, SUM(masuk) AS total_masuk, (SUM(masuk) - SUM(keluar)) AS total_saldo FROM kas LEFT JOIN kegiatan ON kegiatan.kegiatan_id = kas.kegiatan_id WHERE kas.kegiatan_id LIKE '" & kegiatan_id & "' AND (kas.tgl BETWEEN '" & tglAwal & "' AND '" & tglAkhir & "') AND kas.jenis LIKE '" & jenis & "'", con)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    lbHiddenTotalKeluarFiltered.Text = Format(dr.Item("total_keluar"), "Rp ###,###")
                    lbHiddenTotalMasukFiltered.Text = Format(dr.Item("total_masuk"), "Rp ###,###")
                    lbHiddenTotalSaldoFiltered.Text = Format(dr.Item("total_saldo"), "Rp ###,###")
                End If

            End If
        Catch ex As Exception
            tampilDataGridBeforeFilter()
            MsgBox("Menampilkan data kas GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
        'End If
    End Sub

    Private Sub showKas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        setFieldWithDb()
    End Sub

    Private Sub cbKegiatanId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKegiatanId.SelectedIndexChanged
        If cbKegiatanId.Text = "SEMUA" Then
            tbKegiatan.Text = "SEMUA"
        Else
            Try
                cmd = New OdbcCommand("SELECT kegiatan FROM kegiatan WHERE kegiatan_id = '" & cbKegiatanId.Text & "'", con)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    tbKegiatan.Text = dr.Item("kegiatan")
                Else
                    MsgBox("ID Kegiatan tidak ada", vbInformation, "PERHATIAN")
                End If
            Catch ex As Exception
                tbKegiatan.Text = "errorGetData"
            End Try
        End If
        tampilDataGridAfterFilter()
    End Sub

    Private Sub cbJenisKas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbJenisKas.SelectedIndexChanged
        tampilDataGridAfterFilter()
    End Sub

    Private Sub dtpTglAwal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTglAwal.ValueChanged
        tampilDataGridAfterFilter()
    End Sub

    Private Sub dtpTglAkhir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTglAkhir.ValueChanged
        tampilDataGridAfterFilter()
    End Sub

    Private Sub btnCetakReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetakReport.Click
        Dim dtReport As New DataTable
        With dtReport
            .Columns.Add("no")
            .Columns.Add("tanggal")
            .Columns.Add("keterangan")
            .Columns.Add("masuk")
            .Columns.Add("keluar")
            .Columns.Add("saldo")
        End With
        For Each row As DataGridViewRow In DataGridViewKas.Rows
            dtReport.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value)
        Next

        'isikan ke parameter
        Dim parameters(14) As ReportParameter '15 field 14 in array

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
        cmd = New OdbcCommand("SELECT (SELECT posisi.posisi FROM posisi WHERE posisi.posisi_id = 'POS-1') AS pos_takmir, (SELECT posisi.posisi FROM posisi WHERE posisi.posisi_id = 'POS-3') AS pos_bendahara, (SELECT posisi_detail.pj FROM posisi_detail JOIN posisi ON posisi.posisi_id = posisi_detail.posisi_id WHERE posisi.posisi_id = 'POS-1') AS pj_takmir, posisi_detail.pj AS pj_bendahara FROM posisi_detail JOIN posisi ON posisi.posisi_id = posisi_detail.posisi_id WHERE posisi.posisi_id = 'POS-3'", con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            parameters(4) = New ReportParameter("mengetahui_pos_takmir", dr.Item("pos_takmir").ToString)
            parameters(5) = New ReportParameter("mengetahui_pos_bendahara", dr.Item("pos_bendahara").ToString)
            parameters(6) = New ReportParameter("mengetahui_pj_takmir", "(" & dr.Item("pj_takmir").ToString & ")")
            parameters(7) = New ReportParameter("mengetahui_pj_bendahara", "(" & dr.Item("pj_bendahara").ToString & ")")
        Else
            parameters(4) = New ReportParameter("mengetahui_pos_takmir", "KETUA TAKMIR")
            parameters(5) = New ReportParameter("mengetahui_pos_bendahara", "BENDAHARA")
            parameters(6) = New ReportParameter("mengetahui_pj_takmir", "(NAMA TAKMIR)")
            parameters(7) = New ReportParameter("mengetahui_pj_bendahara", "(NAMA BENDAHARA)")
        End If

        'Isikan sesmua parameter header
        Dim peridoeKas As String = ""
        If dtpTglAwal.Text = dtpTglAkhir.Text Then
            peridoeKas = dtpTglAwal.Value.ToString("dd") & "/" & namaBulan(dtpTglAwal.Text) & "/" & dtpTglAwal.Value.ToString("yyyy")
        Else
            peridoeKas = dtpTglAwal.Value.ToString("dd") & "/" & namaBulan(dtpTglAwal.Text) & "/" & dtpTglAwal.Value.ToString("yyyy") & " s.d. " & dtpTglAkhir.Value.ToString("dd") & "/" & namaBulan(dtpTglAkhir.Text) & "/" & dtpTglAkhir.Value.ToString("yyyy")
        End If

        Dim jenis As String = "MASUK & KELUAR"
        If cbJenisKas.Text = "MASUK" Then
            jenis = "Masuk"
        ElseIf cbJenisKas.Text = "KELUAR" Then
            jenis = "Keluar"
        End If

        parameters(8) = New ReportParameter("header_periode_kas", peridoeKas)
        parameters(9) = New ReportParameter("header_jenis_kas", jenis)
        parameters(10) = New ReportParameter("header_kegiatan", tbKegiatan.Text)
        parameters(11) = New ReportParameter("header_tgl_cetak", Format(Now, "dd") & "/" & namaBulan(Now) & "/" & Format(Now, "yyyy") & " " & FormatDateTime(Now, DateFormat.ShortTime))

        ''Isikan sesmua parameter ket
        parameters(12) = New ReportParameter("ket_total_masuk", lbHiddenTotalMasukFiltered.Text)
        parameters(13) = New ReportParameter("ket_total_keluar", lbHiddenTotalKeluarFiltered.Text)
        parameters(14) = New ReportParameter("ket_total_saldo", lbHiddenTotalSaldoFiltered.Text)

        'SetAttr parameters di report
        reportKas.ReportViewer1.LocalReport.SetParameters(parameters)
        reportKas.ReportViewer1.LocalReport.Refresh()
        reportKas.ReportViewer1.LocalReport.DataSources.Item(0).Value = dtReport
        reportKas.ShowDialog()
        reportKas.Dispose()
    End Sub
End Class