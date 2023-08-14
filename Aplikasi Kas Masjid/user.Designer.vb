<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.tbUserId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbFullname = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.DataGridViewUser = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkBoxShowPass = New System.Windows.Forms.CheckBox()
        Me.checkboxSetAdmin = New System.Windows.Forms.CheckBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.07794!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.92206!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.08!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.92!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbUsername, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbUserId, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbFullname, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPassword, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 15)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1078, 155)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'tbUsername
        '
        Me.tbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.Location = New System.Drawing.Point(143, 102)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(3, 25, 11, 6)
        Me.tbUsername.MaxLength = 15
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(342, 31)
        Me.tbUsername.TabIndex = 1
        '
        'tbUserId
        '
        Me.tbUserId.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUserId.Location = New System.Drawing.Point(143, 25)
        Me.tbUserId.Margin = New System.Windows.Forms.Padding(3, 25, 11, 6)
        Me.tbUserId.MaxLength = 10
        Me.tbUserId.Name = "tbUserId"
        Me.tbUserId.ReadOnly = True
        Me.tbUserId.Size = New System.Drawing.Size(338, 31)
        Me.tbUserId.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(11, 25, 3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ID User"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(549, 102)
        Me.Label8.Margin = New System.Windows.Forms.Padding(11, 25, 3, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 26)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(549, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 25, 3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fullname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(11, 25, 3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'tbFullname
        '
        Me.tbFullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFullname.Location = New System.Drawing.Point(682, 25)
        Me.tbFullname.Margin = New System.Windows.Forms.Padding(3, 25, 11, 6)
        Me.tbFullname.MaxLength = 20
        Me.tbFullname.Name = "tbFullname"
        Me.tbFullname.Size = New System.Drawing.Size(342, 31)
        Me.tbFullname.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(682, 102)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(3, 25, 11, 6)
        Me.tbPassword.MaxLength = 8
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(342, 31)
        Me.tbPassword.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSave.Location = New System.Drawing.Point(720, 178)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 42)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Tan
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(972, 178)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 42)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnEdit.Location = New System.Drawing.Point(846, 178)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(119, 42)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'DataGridViewUser
        '
        Me.DataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridViewUser.Location = New System.Drawing.Point(14, 229)
        Me.DataGridViewUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridViewUser.Name = "DataGridViewUser"
        Me.DataGridViewUser.ReadOnly = True
        Me.DataGridViewUser.RowTemplate.Height = 24
        Me.DataGridViewUser.Size = New System.Drawing.Size(1078, 454)
        Me.DataGridViewUser.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID User"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 89
        '
        'Column2
        '
        Me.Column2.HeaderText = "Username"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 108
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fullname"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 99
        '
        'Column4
        '
        Me.Column4.HeaderText = "Role"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 67
        '
        'checkBoxShowPass
        '
        Me.checkBoxShowPass.AutoSize = True
        Me.checkBoxShowPass.Location = New System.Drawing.Point(442, 188)
        Me.checkBoxShowPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.checkBoxShowPass.Name = "checkBoxShowPass"
        Me.checkBoxShowPass.Size = New System.Drawing.Size(148, 24)
        Me.checkBoxShowPass.TabIndex = 5
        Me.checkBoxShowPass.Text = "Show Password"
        Me.checkBoxShowPass.UseVisualStyleBackColor = True
        '
        'checkboxSetAdmin
        '
        Me.checkboxSetAdmin.AutoSize = True
        Me.checkboxSetAdmin.Location = New System.Drawing.Point(123, 188)
        Me.checkboxSetAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.checkboxSetAdmin.Name = "checkboxSetAdmin"
        Me.checkboxSetAdmin.Size = New System.Drawing.Size(311, 24)
        Me.checkboxSetAdmin.TabIndex = 4
        Me.checkboxSetAdmin.Text = "Jadikan user ini sebagai Administrator?"
        Me.checkboxSetAdmin.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.Peru
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(594, 178)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(119, 42)
        Me.btnNew.TabIndex = 29
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(1105, 698)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.checkboxSetAdmin)
        Me.Controls.Add(Me.checkBoxShowPass)
        Me.Controls.Add(Me.DataGridViewUser)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "user"
        Me.Text = "User Aplikasi [AKAMAS]"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbUserId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbUsername As System.Windows.Forms.TextBox
    Friend WithEvents tbFullname As System.Windows.Forms.TextBox
    Friend WithEvents tbPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewUser As System.Windows.Forms.DataGridView
    Friend WithEvents checkBoxShowPass As System.Windows.Forms.CheckBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkboxSetAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
