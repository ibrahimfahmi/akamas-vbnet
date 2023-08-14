Imports System.Data.Odbc

Public Class addKegiatan

    Sub tampilData()
        DataGridViewKegiatan.Rows.Clear()
        Try
            da = New OdbcDataAdapter("SELECT * FROM kegiatan ORDER BY kegiatan_id ASC", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridViewKegiatan.Rows.Add(row(0), row(1))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data kegiatan GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub

    Sub isiTbKegiatanId()
        tbKegiatanId.Text = generateNewId("kegiatan", "kegiatan_id", "KGT-")
    End Sub

    Sub resetForm()
        isiTbKegiatanId()
        tbKegiatan.Text = ""
        tbKegiatan.Focus()
    End Sub

    Private Sub addKegiatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
        isiTbKegiatanId()
        tbKegiatan.Focus()
    End Sub

    Private Sub DataGridViewKegiatan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewKegiatan.CellContentClick
        Dim i As Integer
        i = DataGridViewKegiatan.CurrentRow.Index

        'overwrite tb dengan isian datgrid
        tbKegiatanId.Text = DataGridViewKegiatan.Item(0, i).Value
        tbKegiatan.Text = DataGridViewKegiatan.Item(1, i).Value
        'matikan btnsave
        btnSave.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan edit, dan beri notiff
        If tbKegiatan.Text = "" Then
            cekTbKosong = True
            tbKegiatan.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            Try
                Dim sql As String = "UPDATE kegiatan SET kegiatan = '" & tbKegiatan.Text & "' WHERE kegiatan_id = '" & tbKegiatanId.Text & "'"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Tampilkan data lalu generate new id dan kosongkan tbPosisi
                tampilData()
                resetForm()
                MsgBox("Edit data BERHASIL", vbInformation, "INFORMASI")
            Catch ex As Exception
                resetForm()
                MsgBox("Edit data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim a As String = DataGridViewKegiatan.Item(0, DataGridViewKegiatan.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Kegiatan yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan ID Kegiatan = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                Try
                    cmd = New OdbcCommand("DELETE FROM kegiatan WHERE kegiatan_id = '" & a & "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                    con.Close()
                    tampilData()
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan insert, dan beri notiff
        If tbKegiatan.Text = "" Then
            cekTbKosong = True
            tbKegiatan.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            Try
                Dim sql As String = "INSERT INTO kegiatan (kegiatan_id, kegiatan) VALUES ('" & tbKegiatanId.Text & "', '" & tbKegiatan.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Tampilkan data lalu generate new id dan kosongkan tbPosisi
                tampilData()
                changeDataDasahboard()
                resetForm()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            Catch ex As Exception
                resetForm()
                MsgBox("Menyimpan data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
            End Try
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        resetForm()
        'nyalkan btnsave
        btnSave.Enabled = True
    End Sub
End Class