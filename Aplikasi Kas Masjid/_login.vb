Imports System.Data.Odbc

Public Class _login

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tUsername.Focus()
        koneksi()
        tPassword.PasswordChar = "*"
    End Sub

    Private Sub tPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tPassword.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub checkBoxShowPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBoxShowPass.CheckedChanged
        If checkBoxShowPass.Checked = True Then
            tPassword.PasswordChar = ""
        Else
            tPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        btnLogin.Text = "Loading..."
        btnLogin.Enabled = False
        If tUsername.Text = "" Or tUsername.Text = "" Then
            btnLogin.Text = "Login"
            btnLogin.Enabled = True
            MsgBox("Username atau password tidak boleh kosong!", vbInformation, "PERINGATAN")
        Else
            Dim cekRow As String = "SELECT * FROM user WHERE username = '" & tUsername.Text.ToLower & "' AND password = '" & tPassword.Text & "'"
            cmd = New OdbcCommand(cekRow, con)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                MsgBox("Login berhasil!", vbInformation, "INFORMASI")
                tUsername.Text = ""
                tPassword.Text = ""
                checkBoxShowPass.Checked = False
                btnLogin.Text = "Login"
                btnLogin.Enabled = True
                tUsername.Focus()
                _dashboard.lbSelamatDatang.Text = "Halo, " & dr.Item("fullname").ToString.ToUpper
                _dashboard.lbHiddenUserId.Text = dr.Item("user_id")
                _dashboard.Show()
                Me.Hide()
            Else
                MsgBox("Username atau password salah!", vbInformation, "PERINGATAN")
                tUsername.Text = ""
                tPassword.Text = ""
                checkBoxShowPass.Checked = False
                btnLogin.Text = "Login"
                btnLogin.Enabled = True
                tUsername.Focus()
            End If
        End If
    End Sub
End Class
