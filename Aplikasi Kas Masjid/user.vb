Imports System.Data.Odbc

Public Class user

    Sub tampilData()
        If checkboxSetAdmin.Enabled = True Then
            isiTbUserId()
        End If
        isiDataGridViewUser()
    End Sub

    Sub isiDataGridViewUser()
        DataGridViewUser.Rows.Clear()
        Try
            'tampilkan datagrid history masuk
            da = New OdbcDataAdapter("SELECT user_id, username, fullname, role FROM user ORDER BY user_id ASC", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridViewUser.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data user GAGAL, periksa database atau query database kemungkinan ada yang salah.")
        End Try
    End Sub

    Sub isiTbUserId()
        tbUserId.Text = generateNewId("user", "user_id", "USR-")
    End Sub

    Sub resetForm()
        isiTbUserId()
        tbUsername.Text = ""
        tbFullname.Text = ""
        tbPassword.Text = ""
        checkboxSetAdmin.Checked = False
        tbUsername.Focus()
    End Sub

    Private Sub user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
        tbPassword.PasswordChar = "X"
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxShowPass.CheckedChanged
        If checkBoxShowPass.Checked = True Then
            tbPassword.PasswordChar = ""
        Else
            tbPassword.PasswordChar = "X"
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cekTbKosong As Boolean = False
        Dim role As String

        'jika ada tabel kosong = true gagalkan edit, dan beri notiff
        If tbUsername.Text = "" Then
            cekTbKosong = True
            tbUsername.Focus()
        ElseIf tbFullname.Text = "" Then
            cekTbKosong = True
            tbFullname.Focus()
        ElseIf tbPassword.Text = "" Then
            cekTbKosong = True
            tbPassword.Focus()
        End If

        If checkboxSetAdmin.Checked = True Then
            role = "admin"
        Else
            role = "user"
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            Try
                Dim sql As String = "INSERT INTO user (user_id, username, fullname, password, role) VALUES ('" & tbUserId.Text & "', '" & tbUsername.Text & "', '" & tbFullname.Text & "', '" & tbPassword.Text & "', '" & role & "')"
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Tampilkan data lalu generate new id dan kosongkan tbIdPj
                resetForm()
                tampilData()
                changeDataDasahboard()
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            Catch ex As Exception
                resetForm()
                MsgBox("Menyimpan data GAGAL. Periksa USERNAME sudah digunakan atau belum, bisa juga koneksi database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim cekEditPassword As Boolean
        Dim cekTbKosong As Boolean = False
        Dim role As String

        'jika ada tabel kosong = true gagalkan edit, dan beri notiff
        If tbUsername.Text = "" Then
            cekTbKosong = True
            tbUsername.Focus()
        ElseIf tbFullname.Text = "" Then
            cekTbKosong = True
            tbFullname.Focus()
        End If

        If tbPassword.Text = "" Then
            cekEditPassword = False
        Else
            cekEditPassword = True
        End If

        If checkboxSetAdmin.Checked = True Then
            role = "admin"
        Else
            role = "user"
        End If

        If cekTbKosong = True Then
            MsgBox("Maaf, semua isian tidak boleh kosong.", vbInformation, "PERHATIAN")
        Else
            Try
                Dim sql As String
                'jika cekEditPassFalse edit username dan fullname saja
                If cekEditPassword = False Then
                    sql = "UPDATE user SET username = '" & tbUsername.Text & "', fullname = '" & tbFullname.Text & "', role = '" & role & "' WHERE user_id = '" & tbUserId.Text & "'"
                Else
                    sql = "UPDATE user SET username = '" & tbUsername.Text & "', fullname = '" & tbFullname.Text & "', password = '" & tbPassword.Text & "', role = '" & role & "' WHERE user_id = '" & tbUserId.Text & "'"
                End If
                cmd = New OdbcCommand(sql, con)
                cmd.ExecuteNonQuery()
                'Tampilkan data lalu generate new id jika admin, tpi kalo user biarkan saja
                If checkboxSetAdmin.Enabled = True Then
                    resetForm()
                End If
                tampilData()
                MsgBox("Edit data BERHASIL", vbInformation, "INFORMASI")
                'edit halo user nama dashboard
                If _dashboard.lbHiddenUserId.Text = tbUserId.Text Then
                    _dashboard.lbSelamatDatang.Text = "Halo, " & tbFullname.Text.ToString.ToUpper
                End If
            Catch ex As Exception
                resetForm()
                MsgBox("Edit data GAGAL, periksa database atau query database kemungkinan ada yang salah.", vbInformation, "PERINGATAN")
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim a As String = DataGridViewUser.Item(0, DataGridViewUser.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data User yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan ID User = " & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                Try
                    cmd = New OdbcCommand("DELETE FROM user WHERE user_id = '" & a & "'", con)
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

    Private Sub DataGridViewUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewUser.CellContentClick
        Dim i As Integer
        i = DataGridViewUser.CurrentRow.Index

        'overwrite tb dengan isian datgrid
        tbUserId.Text = DataGridViewUser.Item(0, i).Value
        tbUsername.Text = DataGridViewUser.Item(1, i).Value
        tbFullname.Text = DataGridViewUser.Item(2, i).Value
        If DataGridViewUser.Item(3, i).Value = "admin" Then
            checkboxSetAdmin.Checked = True
        Else
            checkboxSetAdmin.Checked = False
        End If
        If DataGridViewUser.Item(0, i).Value = "USR-1" Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
        'matikan btnsave
        btnSave.Enabled = False
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        resetForm()
        'nyalakan btnsave
        btnSave.Enabled = True
    End Sub
End Class