Imports System.Data.Odbc

Public Class addPosisi

    Sub tampilData()
        DataGridViewPosisi.Rows.Clear()
        Try
            da = New OdbcDataAdapter("SELECT * FROM posisi ORDER BY posisi_id ASC", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridViewPosisi.Rows.Add(row(0), row(1))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub

    Sub isiPosisiId()
        tbPosisiId.Text = generateNewId("posisi", "posisi_id", "POS-")
    End Sub

    Sub resetForm()
        isiPosisiId()
        tbPosisi.Text = ""
        tbPosisi.Focus()
    End Sub

    Private Sub addPosisi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        isiPosisiId()
        tampilData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan edit, dan beri notiff
        If tbPosisi.Text = "" Then
            cekTbKosong = True
            tbPosisi.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            Try
                Dim sql As String = "INSERT INTO posisi (posisi_id, posisi) VALUES ('" & tbPosisiId.Text & "', '" & tbPosisi.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Tampilkan data lalu generate new id dan kosongkan tbPosisi
                resetForm()
                tampilData()
                changeDataDasahboard()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            Catch ex As Exception
                resetForm()
                MsgBox("Menyimpan data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim a As String = DataGridViewPosisi.Item(0, DataGridViewPosisi.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Posisi yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan ID Posisi = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                Try
                    cmd = New OdbcCommand("DELETE FROM posisi WHERE posisi_id = '" & a & "'", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                    con.Close()
                    resetForm()
                    tampilData()
                    changeDataDasahboard()
                    'nyalakan btnsave
                    btnSave.Enabled = True
                Catch ex As Exception
                    MsgBox("Menghapus data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
                End Try
            End If
        End If
    End Sub

    Private Sub DataGridViewPosisi_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPosisi.CellContentClick
        Dim i As Integer
        i = DataGridViewPosisi.CurrentRow.Index

        'overwrite tb dengan isian datgrid
        tbPosisiId.Text = DataGridViewPosisi.Item(0, i).Value
        tbPosisi.Text = DataGridViewPosisi.Item(1, i).Value

        'matikan btndelete jika ketua, sekre, benda
        If DataGridViewPosisi.Item(0, i).Value = "POS-1" Or DataGridViewPosisi.Item(0, i).Value = "POS-2" Or DataGridViewPosisi.Item(0, i).Value = "POS-3" Then
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        Else
            btnEdit.Enabled = False
            btnDelete.Enabled = True
        End If
        'matikan btnsave
        btnSave.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan edit, dan beri notiff
        If tbPosisi.Text = "" Then
            cekTbKosong = True
            tbPosisi.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            Try
                Dim sql As String = "UPDATE posisi SET posisi = '" & tbPosisi.Text & "' WHERE posisi_id = '" & tbPosisiId.Text & "'"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Tampilkan data lalu generate new id dan kosongkan tbPosisi
                resetForm()
                tampilData()
                MsgBox("Edit data BERHASIL", vbInformation, "INFORMASI")
            Catch ex As Exception
                resetForm()
                MsgBox("Edit data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
            End Try
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        resetForm()
        'nyalakan btnsave
        btnSave.Enabled = True
    End Sub
End Class