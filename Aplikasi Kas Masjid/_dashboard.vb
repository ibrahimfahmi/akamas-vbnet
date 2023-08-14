'Imports System.Data.Odbc

Public Class _dashboard

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        _about.Show()
    End Sub

    Private Sub LoggOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoggOutToolStripMenuItem.Click
        MsgBox("Berhasil Log Out! Silakan login kembali", vbInformation, "INFORMASI")
        _login.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub dashboard_v2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ganti label haritgl
        lbHariTangaal.Text = hariBulanTahun(Now)
        'masaukkan data ke tampilan
        changeDataDasahboard()
    End Sub

    Private Sub IdentitasMasjidToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdentitasMasjidToolStripMenuItem.Click
        identitasMasjid.Show()
    End Sub

    Private Sub InputPosisiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputPosisiToolStripMenuItem.Click
        addPosisi.Show()
    End Sub

    Private Sub InputPenanggungJawabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputPenanggungJawabToolStripMenuItem.Click
        addPjPosisi.Show()
    End Sub

    Private Sub KegiatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KegiatanToolStripMenuItem.Click
        addKegiatan.Show()
    End Sub

    Private Sub MasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasukToolStripMenuItem.Click
        addKasMasuk.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        addKasKeluar.Show()
    End Sub

    Private Sub UserAplikasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAplikasiToolStripMenuItem.Click
        kelolaUser(lbHiddenUserId.Text)
        user.Show()
    End Sub

    Private Sub StrukturOrganisasiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrukturOrganisasiToolStripMenuItem1.Click
        showStrukturOrganisasi.Show()
    End Sub

    Private Sub KasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasToolStripMenuItem1.Click
        showKas.Show()
    End Sub
End Class