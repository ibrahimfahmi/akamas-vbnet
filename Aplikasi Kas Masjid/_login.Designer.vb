<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.checkBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AKAMAS.My.Resources.Resources.lock
        Me.PictureBox1.Location = New System.Drawing.Point(-32, 76)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(341, 380)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'tUsername
        '
        Me.tUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsername.Location = New System.Drawing.Point(278, 160)
        Me.tUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tUsername.MaxLength = 25
        Me.tUsername.Name = "tUsername"
        Me.tUsername.Size = New System.Drawing.Size(325, 44)
        Me.tUsername.TabIndex = 1
        '
        'tPassword
        '
        Me.tPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPassword.Location = New System.Drawing.Point(278, 260)
        Me.tPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPassword.MaxLength = 256
        Me.tPassword.Name = "tPassword"
        Me.tPassword.Size = New System.Drawing.Size(325, 44)
        Me.tPassword.TabIndex = 2
        '
        'checkBoxShowPass
        '
        Me.checkBoxShowPass.AutoSize = True
        Me.checkBoxShowPass.Location = New System.Drawing.Point(278, 328)
        Me.checkBoxShowPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.checkBoxShowPass.Name = "checkBoxShowPass"
        Me.checkBoxShowPass.Size = New System.Drawing.Size(148, 24)
        Me.checkBoxShowPass.TabIndex = 3
        Me.checkBoxShowPass.Text = "Show Password"
        Me.checkBoxShowPass.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SandyBrown
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogin.Location = New System.Drawing.Point(278, 370)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(325, 44)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SILAKAN MASUK"
        '
        '_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(672, 474)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.checkBoxShowPass)
        Me.Controls.Add(Me.tPassword)
        Me.Controls.Add(Me.tUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "_login"
        Me.Text = "Login [AKAMAS]"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tUsername As System.Windows.Forms.TextBox
    Friend WithEvents tPassword As System.Windows.Forms.TextBox
    Friend WithEvents checkBoxShowPass As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
