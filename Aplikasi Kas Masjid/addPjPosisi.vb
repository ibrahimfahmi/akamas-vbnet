Imports System.Data.Odbc

Public Class addPjPosisi

    Sub tampilData()
        DataGridViewPj.Rows.Clear()
        Try
            da = New OdbcDataAdapter("SELECT posisi_detail.*, posisi.posisi FROM posisi_detail LEFT JOIN posisi ON posisi.posisi_id = posisi_detail.posisi_id ORDER BY posisi_detail.pj_id ASC", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridViewPj.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub

    Sub isiTbIdPj()
        tbIdPj.Text = generateNewId("posisi_detail", "pj_id", "PJD-")
    End Sub

    Sub isiCbIdPosisi()
        Try
            cmd = New OdbcCommand("SELECT posisi_id FROM posisi", con)
            dr = cmd.ExecuteReader
            cbIdPosisi.Items.Clear()
            Do While dr.Read
                cbIdPosisi.Items.Add(dr.Item("posisi_id"))
            Loop
        Catch ex As Exception
            cbIdPosisi.Text = "errorGetData"
            MsgBox("GAGAL mendapatkan ID Posisi, periksa koneksi databse, atau query database.", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub isiTbNamaPosisi()
        Try
            cmd = New OdbcCommand("SELECT posisi FROM posisi WHERE posisi_id = '" & cbIdPosisi.Text & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                tbNamaPosisi.Text = dr.Item("posisi")
            Else
                MsgBox("ID Posisi tidak ada", vbInformation, "PERHATIAN")
            End If
        Catch ex As Exception
            tbNamaPosisi.Text = "errorGetData"
        End Try
    End Sub


    Sub resetForm()
        isiTbIdPj()
        cbIdPosisi.Text = ""
        tbNamaPosisi.Text = ""
        tbNamaPj.Text = ""
        cbIdPosisi.Focus()
    End Sub


    Private Sub addPjPosisi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbIdPosisi.Focus()
        koneksi()
        isiTbIdPj()
        isiCbIdPosisi()
        tampilData()
    End Sub

    Private Sub cbIdPosisi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIdPosisi.SelectedIndexChanged
        isiTbNamaPosisi()
        tbNamaPj.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan edit, dan beri notiff
        If cbIdPosisi.Text = "" Then
            cekTbKosong = True
            cbIdPosisi.Focus()
        ElseIf tbNamaPj.Text = "" Then
            cekTbKosong = True
            tbNamaPj.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            Try
                Dim sql As String = "INSERT INTO posisi_detail (pj_id, posisi_id, pj) VALUES ('" & tbIdPj.Text & "', '" & cbIdPosisi.Text & "', '" & tbNamaPj.Text & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Tampilkan data lalu generate new id dan kosongkan tbIdPj
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

    Private Sub DataGridViewPj_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewPj.CellContentClick
        Dim i As Integer
        i = DataGridViewPj.CurrentRow.Index

        'overwrite tb dengan isian datgrid
        tbIdPj.Text = DataGridViewPj.Item(0, i).Value
        cbIdPosisi.Text = DataGridViewPj.Item(1, i).Value
        If IsDBNull(DataGridViewPj.Item(3, i).Value) = True Then
            tbNamaPosisi.Text = "Hanya bisa delete"
        Else
            tbNamaPosisi.Text = DataGridViewPj.Item(3, i).Value
        End If
        tbNamaPj.Text = DataGridViewPj.Item(2, i).Value
        'matikn btnsave
        btnSave.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim cekTbKosong As Boolean = False

        'jika ada tabel kosong = true gagalkan edit, dan beri notiff
        If cbIdPosisi.Text = "" Then
            cekTbKosong = True
            cbIdPosisi.Focus()
        ElseIf tbNamaPj.Text = "" Then
            cekTbKosong = True
            tbNamaPj.Focus()
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            Try
                Dim sql As String = "UPDATE posisi_detail SET posisi_id = '" & cbIdPosisi.Text & "', pj = '" & tbNamaPj.Text & "' WHERE pj_id = '" & tbIdPj.Text & "'"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Tampilkan data lalu generate new id dan kosongkan tbIdPj
                resetForm()
                tampilData()
                MsgBox("Edit data BERHASIL", vbInformation, "INFORMASI")
            Catch ex As Exception
                resetForm()
                MsgBox("Edit data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim a As String = DataGridViewPj.Item(0, DataGridViewPj.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Posisi yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan ID Posisi = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                Try
                    cmd = New OdbcCommand("DELETE FROM posisi_detail WHERE pj_id = '" & a & "'", con)
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

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        resetForm()
        'nyalakan btnsave
        btnSave.Enabled = True
    End Sub
End Class