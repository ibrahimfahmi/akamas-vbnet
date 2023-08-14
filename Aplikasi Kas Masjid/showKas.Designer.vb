<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showKas
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbJenisKas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.cbKegiatanId = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbKegiatan = New System.Windows.Forms.TextBox()
        Me.DataGridViewKas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCetakReport = New System.Windows.Forms.Button()
        Me.lbTotalKas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbHiddenTotalMasukFiltered = New System.Windows.Forms.Label()
        Me.lbHiddenTotalKeluarFiltered = New System.Windows.Forms.Label()
        Me.lbHiddenTotalSaldoFiltered = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridViewKas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.877115!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.45713!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.877115!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.45576!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.877115!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.45576!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpTglAwal, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbJenisKas, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpTglAkhir, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbKegiatanId, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbKegiatan, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 12)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(957, 119)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 52)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ID Kegiatan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 5)
        Me.Label4.Margin = New System.Windows.Forms.Padding(15, 5, 5, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 51)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Jenis Kas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTglAwal
        '
        Me.dtpTglAwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglAwal.Location = New System.Drawing.Point(405, 15)
        Me.dtpTglAwal.Margin = New System.Windows.Forms.Padding(3, 15, 5, 3)
        Me.dtpTglAwal.MinDate = New Date(1753, 1, 3, 0, 0, 0, 0)
        Me.dtpTglAwal.Name = "dtpTglAwal"
        Me.dtpTglAwal.Size = New System.Drawing.Size(226, 27)
        Me.dtpTglAwal.TabIndex = 2
        Me.dtpTglAwal.Value = New Date(2022, 6, 19, 23, 33, 15, 0)
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(15, 5, 5, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tgl. Awal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbJenisKas
        '
        Me.cbJenisKas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenisKas.FormattingEnabled = True
        Me.cbJenisKas.Items.AddRange(New Object() {"SEMUA", "MASUK", "KELUAR"})
        Me.cbJenisKas.Location = New System.Drawing.Point(87, 15)
        Me.cbJenisKas.Margin = New System.Windows.Forms.Padding(3, 15, 5, 3)
        Me.cbJenisKas.Name = "cbJenisKas"
        Me.cbJenisKas.Size = New System.Drawing.Size(226, 28)
        Me.cbJenisKas.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(651, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(15, 5, 5, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 51)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Tgl. Akhir"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTglAkhir
        '
        Me.dtpTglAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglAkhir.Location = New System.Drawing.Point(723, 15)
        Me.dtpTglAkhir.Margin = New System.Windows.Forms.Padding(3, 15, 5, 3)
        Me.dtpTglAkhir.Name = "dtpTglAkhir"
        Me.dtpTglAkhir.Size = New System.Drawing.Size(224, 27)
        Me.dtpTglAkhir.TabIndex = 15
        Me.dtpTglAkhir.Value = New Date(2022, 6, 19, 23, 33, 15, 0)
        '
        'cbKegiatanId
        '
        Me.cbKegiatanId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKegiatanId.FormattingEnabled = True
        Me.cbKegiatanId.Location = New System.Drawing.Point(87, 74)
        Me.cbKegiatanId.Margin = New System.Windows.Forms.Padding(3, 15, 5, 3)
        Me.cbKegiatanId.Name = "cbKegiatanId"
        Me.cbKegiatanId.Size = New System.Drawing.Size(226, 28)
        Me.cbKegiatanId.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(333, 64)
        Me.Label5.Margin = New System.Windows.Forms.Padding(15, 5, 5, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 52)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Kegi-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "atan"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbKegiatan
        '
        Me.tbKegiatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKegiatan.Location = New System.Drawing.Point(405, 74)
        Me.tbKegiatan.Margin = New System.Windows.Forms.Padding(3, 15, 5, 3)
        Me.tbKegiatan.Name = "tbKegiatan"
        Me.tbKegiatan.ReadOnly = True
        Me.tbKegiatan.Size = New System.Drawing.Size(226, 27)
        Me.tbKegiatan.TabIndex = 19
        '
        'DataGridViewKas
        '
        Me.DataGridViewKas.AllowUserToAddRows = False
        Me.DataGridViewKas.AllowUserToDeleteRows = False
        Me.DataGridViewKas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewKas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewKas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridViewKas.Location = New System.Drawing.Point(13, 174)
        Me.DataGridViewKas.Name = "DataGridViewKas"
        Me.DataGridViewKas.ReadOnly = True
        Me.DataGridViewKas.RowTemplate.Height = 24
        Me.DataGridViewKas.Size = New System.Drawing.Size(957, 227)
        Me.DataGridViewKas.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 51
        '
        'Column2
        '
        Me.Column2.HeaderText = "Tanggal"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 85
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 66
        '
        'Column4
        '
        Me.Column4.HeaderText = "Kegiatan"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 89
        '
        'Column5
        '
        Me.Column5.HeaderText = "Keterangan"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 107
        '
        'Column6
        '
        Me.Column6.HeaderText = "Masuk"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 74
        '
        'Column7
        '
        Me.Column7.HeaderText = "Keluar"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 74
        '
        'Column8
        '
        Me.Column8.HeaderText = "Saldo"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 69
        '
        'btnCetakReport
        '
        Me.btnCetakReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCetakReport.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCetakReport.Location = New System.Drawing.Point(410, 407)
        Me.btnCetakReport.Name = "btnCetakReport"
        Me.btnCetakReport.Size = New System.Drawing.Size(163, 34)
        Me.btnCetakReport.TabIndex = 20
        Me.btnCetakReport.Text = "CETAK REPORT"
        Me.btnCetakReport.UseVisualStyleBackColor = False
        '
        'lbTotalKas
        '
        Me.lbTotalKas.AutoSize = True
        Me.lbTotalKas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalKas.ForeColor = System.Drawing.Color.White
        Me.lbTotalKas.Location = New System.Drawing.Point(105, 142)
        Me.lbTotalKas.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.lbTotalKas.Name = "lbTotalKas"
        Me.lbTotalKas.Size = New System.Drawing.Size(141, 24)
        Me.lbTotalKas.TabIndex = 24
        Me.lbTotalKas.Text = "Rp total_saldo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 24)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Total Kas"
        '
        'lbHiddenTotalMasukFiltered
        '
        Me.lbHiddenTotalMasukFiltered.AutoSize = True
        Me.lbHiddenTotalMasukFiltered.Location = New System.Drawing.Point(19, 404)
        Me.lbHiddenTotalMasukFiltered.Name = "lbHiddenTotalMasukFiltered"
        Me.lbHiddenTotalMasukFiltered.Size = New System.Drawing.Size(184, 17)
        Me.lbHiddenTotalMasukFiltered.TabIndex = 26
        Me.lbHiddenTotalMasukFiltered.Text = "lbHiddenTotalMasukFiltered"
        Me.lbHiddenTotalMasukFiltered.Visible = False
        '
        'lbHiddenTotalKeluarFiltered
        '
        Me.lbHiddenTotalKeluarFiltered.AutoSize = True
        Me.lbHiddenTotalKeluarFiltered.Location = New System.Drawing.Point(19, 427)
        Me.lbHiddenTotalKeluarFiltered.Name = "lbHiddenTotalKeluarFiltered"
        Me.lbHiddenTotalKeluarFiltered.Size = New System.Drawing.Size(184, 17)
        Me.lbHiddenTotalKeluarFiltered.TabIndex = 27
        Me.lbHiddenTotalKeluarFiltered.Text = "lbHiddenTotalKeluarFiltered"
        Me.lbHiddenTotalKeluarFiltered.Visible = False
        '
        'lbHiddenTotalSaldoFiltered
        '
        Me.lbHiddenTotalSaldoFiltered.AutoSize = True
        Me.lbHiddenTotalSaldoFiltered.Location = New System.Drawing.Point(579, 407)
        Me.lbHiddenTotalSaldoFiltered.Name = "lbHiddenTotalSaldoFiltered"
        Me.lbHiddenTotalSaldoFiltered.Size = New System.Drawing.Size(179, 17)
        Me.lbHiddenTotalSaldoFiltered.TabIndex = 28
        Me.lbHiddenTotalSaldoFiltered.Text = "lbHiddenTotalSaldoFiltered"
        Me.lbHiddenTotalSaldoFiltered.Visible = False
        '
        'showKas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(982, 453)
        Me.Controls.Add(Me.lbHiddenTotalSaldoFiltered)
        Me.Controls.Add(Me.lbHiddenTotalKeluarFiltered)
        Me.Controls.Add(Me.lbHiddenTotalMasukFiltered)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbTotalKas)
        Me.Controls.Add(Me.btnCetakReport)
        Me.Controls.Add(Me.DataGridViewKas)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "showKas"
        Me.Text = "Lihat Kas [AKAMAS]"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridViewKas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbJenisKas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewKas As System.Windows.Forms.DataGridView
    Friend WithEvents btnCetakReport As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbKegiatanId As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbKegiatan As System.Windows.Forms.TextBox
    Friend WithEvents lbTotalKas As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbHiddenTotalMasukFiltered As System.Windows.Forms.Label
    Friend WithEvents lbHiddenTotalKeluarFiltered As System.Windows.Forms.Label
    Friend WithEvents lbHiddenTotalSaldoFiltered As System.Windows.Forms.Label
End Class
