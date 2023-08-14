<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addKasMasuk
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
        Me.tbKasId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbKet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNominal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbKegiatan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbKegiatanId = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewKasMasuk = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbTotalMasuk = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridViewKasMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Controls.Add(Me.tbKasId, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbKet, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNominal, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpTgl, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbKegiatan, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbKegiatanId, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(957, 179)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'tbKasId
        '
        Me.tbKasId.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbKasId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKasId.Location = New System.Drawing.Point(128, 20)
        Me.tbKasId.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbKasId.MaxLength = 10
        Me.tbKasId.Name = "tbKasId"
        Me.tbKasId.ReadOnly = True
        Me.tbKasId.Size = New System.Drawing.Size(340, 27)
        Me.tbKasId.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ID Kas"
        '
        'tbKet
        '
        Me.tbKet.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKet.Location = New System.Drawing.Point(606, 138)
        Me.tbKet.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbKet.MaxLength = 200
        Me.tbKet.Name = "tbKet"
        Me.tbKet.Size = New System.Drawing.Size(340, 27)
        Me.tbKet.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(488, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Keterangan"
        '
        'tbNominal
        '
        Me.tbNominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNominal.Location = New System.Drawing.Point(606, 79)
        Me.tbNominal.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbNominal.MaxLength = 14
        Me.tbNominal.Name = "tbNominal"
        Me.tbNominal.Size = New System.Drawing.Size(340, 27)
        Me.tbNominal.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(488, 79)
        Me.Label8.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 24)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nominal"
        '
        'dtpTgl
        '
        Me.dtpTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTgl.Location = New System.Drawing.Point(606, 20)
        Me.dtpTgl.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(340, 27)
        Me.dtpTgl.TabIndex = 2
        Me.dtpTgl.Value = New Date(2022, 6, 19, 23, 33, 15, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(488, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tanggal"
        '
        'tbKegiatan
        '
        Me.tbKegiatan.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbKegiatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKegiatan.Location = New System.Drawing.Point(128, 138)
        Me.tbKegiatan.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbKegiatan.MaxLength = 50
        Me.tbKegiatan.Name = "tbKegiatan"
        Me.tbKegiatan.ReadOnly = True
        Me.tbKegiatan.Size = New System.Drawing.Size(340, 27)
        Me.tbKegiatan.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Kegiatan"
        '
        'cbKegiatanId
        '
        Me.cbKegiatanId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKegiatanId.FormattingEnabled = True
        Me.cbKegiatanId.Location = New System.Drawing.Point(128, 74)
        Me.cbKegiatanId.Margin = New System.Windows.Forms.Padding(3, 15, 10, 5)
        Me.cbKegiatanId.Name = "cbKegiatanId"
        Me.cbKegiatanId.Size = New System.Drawing.Size(340, 28)
        Me.cbKegiatanId.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Kegiatan"
        '
        'DataGridViewKasMasuk
        '
        Me.DataGridViewKasMasuk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewKasMasuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewKasMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKasMasuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridViewKasMasuk.Location = New System.Drawing.Point(13, 237)
        Me.DataGridViewKasMasuk.Name = "DataGridViewKasMasuk"
        Me.DataGridViewKasMasuk.ReadOnly = True
        Me.DataGridViewKasMasuk.RowTemplate.Height = 24
        Me.DataGridViewKasMasuk.Size = New System.Drawing.Size(957, 304)
        Me.DataGridViewKasMasuk.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Kas"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 74
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID Kegiatan"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 106
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kegiatan"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 89
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tanggal"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 85
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nominal"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 84
        '
        'Column6
        '
        Me.Column6.HeaderText = "Keterangan"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 107
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.Tan
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(864, 197)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 34)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnEdit.Location = New System.Drawing.Point(752, 197)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(106, 34)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSave.Location = New System.Drawing.Point(640, 197)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 34)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lbTotalMasuk
        '
        Me.lbTotalMasuk.AutoSize = True
        Me.lbTotalMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalMasuk.ForeColor = System.Drawing.Color.White
        Me.lbTotalMasuk.Location = New System.Drawing.Point(127, 201)
        Me.lbTotalMasuk.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.lbTotalMasuk.Name = "lbTotalMasuk"
        Me.lbTotalMasuk.Size = New System.Drawing.Size(151, 24)
        Me.lbTotalMasuk.TabIndex = 22
        Me.lbTotalMasuk.Text = "Rp total_masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 201)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Kas Masuk"
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.Peru
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(528, 197)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(106, 34)
        Me.btnNew.TabIndex = 24
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'addKasMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbTotalMasuk)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.DataGridViewKasMasuk)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "addKasMasuk"
        Me.Text = "Tambah Kas Masuk [AKAMAS]"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridViewKasMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbKegiatan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbNominal As System.Windows.Forms.TextBox
    Friend WithEvents tbKet As System.Windows.Forms.TextBox
    Friend WithEvents cbKegiatanId As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewKasMasuk As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tbKasId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbTotalMasuk As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
