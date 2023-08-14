Imports System.Data.Odbc

Public Class addKasKeluar

    'declare f to double. Then, to print => Format(Val(f), "###,###") to insert db => Format(Val(f), 0)
    'date, to insert mysql => dtpTgl.Value.ToString("yyyy-MM-dd")
    Dim valTbNominalBeforeFormat As Double
    Dim valTbNominalAfterFormat As Integer
    Dim valDtpTglInsert As String

    Sub tampilData()
        isiTbKasId()
        isiCbKegiatanId()
        rewriteLbKasMasuk()
        isiDataGridViewKasMasuk()
        dtpTgl.Text = Now
    End Sub

    Sub isiDataGridViewKasMasuk()
        DataGridViewKasKeluar.Rows.Clear()
        Try
            'tampilkan datagrid history masuk
            da = New OdbcDataAdapter("SELECT kas.kas_id, kas.kegiatan_id, kegiatan.kegiatan, kas.tgl, kas.keluar, kas.ket FROM kas LEFT JOIN kegiatan ON kegiatan.kegiatan_id = kas.kegiatan_id WHERE kas.keluar != 0 ORDER BY kas.tgl DESC", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridViewKasKeluar.Rows.Add(row(0), row(1), row(2), FormatDateTime(row(3), DateFormat.ShortDate), Format(row(4), "###,###"), row(5))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data kas keluar GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub

    Sub isiCbKegiatanId()
        Try
            cmd = New OdbcCommand("SELECT kegiatan_id FROM kegiatan", con)
            dr = cmd.ExecuteReader
            cbKegiatanId.Items.Clear()
            Do While dr.Read
                cbKegiatanId.Items.Add(dr.Item("kegiatan_id"))
            Loop
        Catch ex As Exception
            cbKegiatanId.Text = "errorGetData"
            MsgBox("GAGAL mendapatkan ID Kegiatan, periksa koneksi databse, atau query database.", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub rewriteLbKasMasuk()
        Try
            koneksi()
            'tampilkan total masuk kas
            cmd = New OdbcCommand("SELECT SUM(keluar) AS total_keluar FROM kas", con)
            'Dim total_keluar As Integer = cmd.ExecuteScalar()
            Dim total_keluar As Integer
            If IsDBNull(cmd.ExecuteScalar()) Then
                lbTotalKeluar.Text = "Rp 0"
            Else
                total_keluar = cmd.ExecuteScalar()
                lbTotalKeluar.Text = Format(total_keluar, "Rp ###,###")
            End If
        Catch ex As Exception
            MsgBox("Menampilkan jumlah kas keluar GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub

    Sub isiTbKasId()
        tbKasId.Text = generateNewId("kas", "kas_id", "KAS-")
    End Sub

    Sub resetForm()
        isiTbKasId()
        cbKegiatanId.Text = ""
        tbKegiatan.Text = ""
        dtpTgl.Text = Now
        tbNominal.Text = ""
        tbKet.Text = ""
        cbKegiatanId.Focus()
    End Sub

    Private Sub addKasMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
    End Sub

    Private Sub tbNominal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbNominal.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub tbNominal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNominal.TextChanged
        If tbNominal.Text = "" Or Not IsNumeric(tbNominal.Text) Then
            Exit Sub
        End If

        valTbNominalBeforeFormat = tbNominal.Text
        tbNominal.Text = Format(Val(valTbNominalBeforeFormat), "###,###")
        tbNominal.SelectionStart = Len(tbNominal.Text)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan insert, dan beri notiff
        If cbKegiatanId.Text = "" Then
            cekTbKosong = True
            cbKegiatanId.Focus()
        ElseIf dtpTgl.Text = "" Then
            cekTbKosong = True
            dtpTgl.Focus()
        ElseIf tbNominal.Text = "" Then
            cekTbKosong = True
            tbNominal.Focus()
        ElseIf tbKet.Text = "" Then
            cekTbKosong = True
            tbKet.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            valTbNominalBeforeFormat = tbNominal.Text
            valTbNominalAfterFormat = Format(valTbNominalBeforeFormat, 0)
            valDtpTglInsert = dtpTgl.Value.ToString("yyyy-MM-dd")
            Try
                Dim sql As String = "INSERT INTO kas (kas_id, kegiatan_id, jenis, masuk, keluar, tgl, ket) VALUES ('" & tbKasId.Text & "', '" & cbKegiatanId.Text & "', 'Keluar', '0', '" & valTbNominalAfterFormat & "', '" & valDtpTglInsert & "', '" & tbKet.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'tampilkan data lalu generate new id
                resetForm()
                tampilData()
                changeDataDasahboard()
                MsgBox("Menyimpan data berhasil", vbInformation, "informasi")
            Catch ex As Exception
                resetForm()
                MsgBox("Menyimpan data gagal, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "peringatan")
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim a As String = DataGridViewKasKeluar.Item(0, DataGridViewKasKeluar.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Kas yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan ID Kas = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                Try
                    cmd = New OdbcCommand("DELETE FROM kas WHERE kas_id = '" & a & "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                    con.Close()
                    tampilData()
                    rewriteLbKasMasuk()
                    changeDataDasahboard()
                    resetForm()
                    'nyalakan btnsave
                    btnSave.Enabled = True
                Catch ex As Exception
                    MsgBox("Menghapus data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
                End Try
            End If
        End If
    End Sub

    Private Sub cbKegiatanId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKegiatanId.SelectedIndexChanged
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
        dtpTgl.Focus()
    End Sub

    Private Sub DataGridViewKasMasuk_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewKasKeluar.CellContentClick
        Dim i As Integer
        i = DataGridViewKasKeluar.CurrentRow.Index

        'overwrite tb dengan isian datgrid
        tbKasId.Text = DataGridViewKasKeluar.Item(0, i).Value
        cbKegiatanId.Text = DataGridViewKasKeluar.Item(1, i).Value
        If IsDBNull(DataGridViewKasKeluar.Item(2, i).Value) = True Then
            tbKegiatan.Text = "Hanya bisa delete"
        Else
            tbKegiatan.Text = DataGridViewKasKeluar.Item(2, i).Value
        End If
        dtpTgl.Text = FormatDateTime(DataGridViewKasKeluar.Item(3, i).Value, DateFormat.ShortDate)
        tbNominal.Text = DataGridViewKasKeluar.Item(4, i).Value
        tbKet.Text = DataGridViewKasKeluar.Item(5, i).Value
        'matikan btnsave
        btnSave.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan insert, dan beri notiff
        If cbKegiatanId.Text = "" Then
            cekTbKosong = True
            cbKegiatanId.Focus()
        ElseIf dtpTgl.Text = "" Then
            cekTbKosong = True
            dtpTgl.Focus()
        ElseIf tbNominal.Text = "" Then
            cekTbKosong = True
            tbNominal.Focus()
        ElseIf tbKet.Text = "" Then
            cekTbKosong = True
            tbKet.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            valTbNominalBeforeFormat = tbNominal.Text
            valTbNominalAfterFormat = Format(valTbNominalBeforeFormat, 0)
            valDtpTglInsert = dtpTgl.Value.ToString("yyyy-MM-dd")
            Try
                Dim sql As String = "UPDATE kas SET kegiatan_id = '" & cbKegiatanId.Text & "', keluar = '" & valTbNominalAfterFormat & "', tgl = '" & valDtpTglInsert & "', ket = '" & tbKet.Text & "' WHERE kas_id = '" & tbKasId.Text & "'"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'tampilkan data lalu generate new id
                resetForm()
                tampilData()
                changeDataDasahboard()
                MsgBox("Edit data berhasil", vbInformation, "informasi")
            Catch ex As Exception
                resetForm()
                MsgBox("Edit data gagal, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "peringatan")
            End Try
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        resetForm()
        'nyalakan btnsave
        btnSave.Enabled = True
    End Sub
End Class