Imports System.Data.Odbc

Module ModuleAKAMAS
    Public con As OdbcConnection
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public cmd As OdbcCommand

    Public MyDB As String
    Public Sub koneksi()
        Try
            MyDB = "Driver={Mysql odbc 3.51 driver};database=akamas;server=localhost;uid=root"
            con = New OdbcConnection(MyDB)
            If con.State = ConnectionState.Closed Then con.Open()
        Catch ex As Exception
            MsgBox("Koneksi ke database gagal", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Public Function namaHari(ByVal dTanggal As Date) As String
        Dim aHari() As String = {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jum'at", "Sabtu"}
        namaHari = aHari(Math.Abs(Weekday(dTanggal) - 1))
        Return namaHari
    End Function

    Public Function namaBulan(ByVal dBulan As Date) As String
        Dim aBulan() As String = {"Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des"}
        namaBulan = aBulan(Math.Abs(Month(dBulan) - 1))
        Return namaBulan
    End Function

    Public Function hariBulanTahun(ByVal dHariBulanTahun As Date) As String
        hariBulanTahun = namaHari(dHariBulanTahun) & ", " & Format(dHariBulanTahun, "dd") & " " & namaBulan(dHariBulanTahun) & " " & Format(dHariBulanTahun, "yyyy")
        Return hariBulanTahun
    End Function

    Public Function tglBulanTahun(ByVal dTanggal As Date) As String
        Dim aBulan() As String = {"Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des"}
        tglBulanTahun = aBulan(Math.Abs(Month(dTanggal) - 1))
        Return Format(dTanggal, "dd") & " " & tglBulanTahun & " " & Format(dTanggal, "yyyy")
    End Function

    Public Sub changeDataDasahboard()
        Try
            koneksi()

            'hitung user
            cmd = New OdbcCommand("SELECT COUNT(*) AS user_total FROM user", con)
            Dim user_total As Integer = cmd.ExecuteScalar()
            _dashboard.lbTotalUser.Text = user_total

            'hitung kegiatan
            cmd = New OdbcCommand("SELECT COUNT(*) AS kegiatan_total FROM kegiatan", con)
            Dim kegiatan_total As Integer = cmd.ExecuteScalar()
            _dashboard.lbKegiatan.Text = kegiatan_total

            'hitung posisi pengurus
            cmd = New OdbcCommand("SELECT COUNT(*) AS posisi_total FROM posisi", con)
            Dim posisi_total As Integer = cmd.ExecuteScalar()
            _dashboard.lbPosisi.Text = posisi_total

            'hitung pengurus
            cmd = New OdbcCommand("SELECT COUNT(*) AS pj_total FROM posisi_detail", con)
            Dim pj_total As Integer = cmd.ExecuteScalar()
            _dashboard.lbPjPosisi.Text = pj_total

            'hitung pengurus
            cmd = New OdbcCommand("SELECT (SUM(masuk) - SUM(keluar)) AS saldo FROM kas", con)
            'Dim saldo As Integer = cmd.ExecuteScalar()
            Dim saldo As Integer
            If IsDBNull(cmd.ExecuteScalar()) Then
                _dashboard.lbSaldo.Text = "Rp 0"
            Else
                saldo = cmd.ExecuteScalar()
                _dashboard.lbSaldo.Text = Format(saldo, "Rp ###,###")
            End If

            'get nama masjid
            cmd = New OdbcCommand("SELECT nama_masjid FROM identitas WHERE identitas_id = 'IDM-1'", con)
            Dim nama_masjid As String = cmd.ExecuteScalar()
            _dashboard.lbNamaMasjid.Text = nama_masjid.ToUpper()

            'get alamat sekre masjid
            cmd = New OdbcCommand("SELECT alamat_sekretariat FROM identitas WHERE identitas_id = 'IDM-1'", con)
            Dim alamat_sekre As String = cmd.ExecuteScalar()
            _dashboard.lbSekreMasjid.Text = alamat_sekre

            'get telp. masjid
            cmd = New OdbcCommand("SELECT telp FROM identitas WHERE identitas_id = 'IDM-1'", con)
            Dim telp As String = cmd.ExecuteScalar()
            _dashboard.lbTelp.Text = telp
        Catch ex As Exception
            MsgBox("Gagal mendapatkan data untuk tampilan dashboard, periksa koneksi atau query untuk mendapatkan data ke database", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Public Function generateNewId(ByVal tabel As String, ByVal field_id As String, ByVal aksen As String)
        Dim createNewId As String
        createNewId = "errorGetData"
        Try
            koneksi()
            'persiapan variabel last_id
            Dim last_id As String
            'hitung dulu baris yang ada di tabel
            cmd = New OdbcCommand("SELECT COUNT(*) AS total_row FROM " & tabel, con)
            Dim checkRow As Integer = cmd.ExecuteScalar()
            If checkRow > 0 Then
                cmd = New OdbcCommand("SELECT MAX(" & field_id & ") AS last_id FROM " & tabel, con)
                last_id = cmd.ExecuteScalar()
            Else
                last_id = "ABC-0"
            End If
            Dim next_id As Integer = CInt(last_id.Substring(4)) + 1
            createNewId = aksen & next_id
        Catch ex As Exception
            MsgBox("Gagal mendapatkan data, periksa apakah pemanggilan fungsi sudah benar. Function generateNewId(ByVal tabel As String, ByVal field_id As String, ByVal aksen As String)", vbInformation, "PERINGATAN")
            'MsgBox(last_id)
        End Try
        Return createNewId
    End Function

    Sub kelolaUser(ByVal user_id As String)
        Dim cekRow As String = "SELECT user_id, username, fullname, role FROM user WHERE user_id = '" & user_id & "'"
        cmd = New OdbcCommand(cekRow, con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            'jika role = admin or jika role = user
            If dr.Item("role") = "admin" Then
                user.DataGridViewUser.Enabled = True
                user.btnDelete.Enabled = True
                user.btnSave.Enabled = True
                user.checkboxSetAdmin.Enabled = True
            ElseIf dr.Item("role") = "user" Then
                user.DataGridViewUser.Enabled = False
                user.btnDelete.Enabled = False
                user.btnSave.Enabled = False
                user.checkboxSetAdmin.Enabled = False
                'masukkan data akun user tsb
                user.tbUserId.Text = dr.Item("user_id")
                user.tbUsername.Text = dr.Item("username")
                user.tbFullname.Text = dr.Item("fullname")
            End If
        End If
    End Sub

End Module
