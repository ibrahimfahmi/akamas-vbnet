Imports System.Data.Odbc

Public Class identitasMasjid

    Private Sub identitasMasjid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tbNamaMasjid.Focus()

        'isi keterangan sesuai dengan table
        Try
            da = New OdbcDataAdapter("SELECT nama_masjid, alamat_singkat, alamat_sekretariat, telp FROM identitas WHERE identitas_id = 'IDM-1'", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                tbNamaMasjid.Text = row(0)
                tbAlamatSingkat.Text = row(1)
                tbAlmatSekre.Text = row(2)
                tbTelp.Text = row(3)
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Database error, gagal mendapatkan data identitas.", vbInformation, "PERINGATAN")
        End Try

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        tbNamaMasjid.Text = ""
        tbAlamatSingkat.Text = ""
        tbAlmatSekre.Text = ""
        tbTelp.Text = ""
        tbNamaMasjid.Focus()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan edit, dan beri notiff
        If tbNamaMasjid.Text = "" Then
            cekTbKosong = True
            tbNamaMasjid.Focus()
        ElseIf tbAlamatSingkat.Text = "" Then
            cekTbKosong = True
            tbAlamatSingkat.Focus()
        ElseIf tbAlmatSekre.Text = "" Then
            cekTbKosong = True
            tbAlmatSekre.Focus()
        ElseIf tbTelp.Text = "" Then
            cekTbKosong = True
            tbTelp.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            'edit tabel database
            Try
                cmd = New OdbcCommand("UPDATE identitas SET nama_masjid = '" & tbNamaMasjid.Text & "', alamat_singkat = '" & tbAlamatSingkat.Text & "', alamat_sekretariat = '" & tbAlmatSekre.Text & "', telp = '" & tbTelp.Text & "' WHERE identitas_id = 'IDM-1'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Update data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                changeDataDasahboard()
            Catch ex As Exception
                MsgBox("Update data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "INFORMASI")
            End Try
        End If
    End Sub
End Class