<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class identitasMasjid
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbTelp = New System.Windows.Forms.TextBox()
        Me.tbAlmatSekre = New System.Windows.Forms.TextBox()
        Me.tbAlamatSingkat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNamaMasjid = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.SandyBrown
        Me.btnEdit.Location = New System.Drawing.Point(526, 300)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(119, 41)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.Tan
        Me.btnReset.Location = New System.Drawing.Point(651, 300)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(119, 41)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.15588!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.84412!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbTelp, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbAlmatSekre, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbAlamatSingkat, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNamaMasjid, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(757, 270)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'tbTelp
        '
        Me.tbTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelp.Location = New System.Drawing.Point(201, 221)
        Me.tbTelp.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbTelp.MaxLength = 15
        Me.tbTelp.Name = "tbTelp"
        Me.tbTelp.Size = New System.Drawing.Size(546, 27)
        Me.tbTelp.TabIndex = 4
        '
        'tbAlmatSekre
        '
        Me.tbAlmatSekre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlmatSekre.Location = New System.Drawing.Point(201, 154)
        Me.tbAlmatSekre.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbAlmatSekre.MaxLength = 120
        Me.tbAlmatSekre.Name = "tbAlmatSekre"
        Me.tbAlmatSekre.Size = New System.Drawing.Size(546, 27)
        Me.tbAlmatSekre.TabIndex = 3
        '
        'tbAlamatSingkat
        '
        Me.tbAlamatSingkat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlamatSingkat.Location = New System.Drawing.Point(201, 87)
        Me.tbAlamatSingkat.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbAlamatSingkat.MaxLength = 50
        Me.tbAlamatSingkat.Name = "tbAlamatSingkat"
        Me.tbAlamatSingkat.Size = New System.Drawing.Size(546, 27)
        Me.tbAlamatSingkat.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Masjid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alamat Singkat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat Sekretariat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 221)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telp."
        '
        'tbNamaMasjid
        '
        Me.tbNamaMasjid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaMasjid.Location = New System.Drawing.Point(201, 20)
        Me.tbNamaMasjid.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbNamaMasjid.MaxLength = 40
        Me.tbNamaMasjid.Name = "tbNamaMasjid"
        Me.tbNamaMasjid.Size = New System.Drawing.Size(546, 27)
        Me.tbNamaMasjid.TabIndex = 1
        '
        'identitasMasjid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(782, 353)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEdit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "identitasMasjid"
        Me.Text = "Identitas Masjid [AKAMAS]"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbTelp As System.Windows.Forms.TextBox
    Friend WithEvents tbAlmatSekre As System.Windows.Forms.TextBox
    Friend WithEvents tbAlamatSingkat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbNamaMasjid As System.Windows.Forms.TextBox
End Class
