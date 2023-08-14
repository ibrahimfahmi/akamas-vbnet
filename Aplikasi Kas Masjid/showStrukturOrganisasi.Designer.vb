<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class showStrukturOrganisasi
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
        Me.btnCetakReport = New System.Windows.Forms.Button()
        Me.DataGridViewStrukturOrganisasi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbNamaMasjid = New System.Windows.Forms.Label()
        CType(Me.DataGridViewStrukturOrganisasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCetakReport
        '
        Me.btnCetakReport.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCetakReport.Location = New System.Drawing.Point(310, 257)
        Me.btnCetakReport.Name = "btnCetakReport"
        Me.btnCetakReport.Size = New System.Drawing.Size(163, 34)
        Me.btnCetakReport.TabIndex = 14
        Me.btnCetakReport.Text = "CETAK REPORT"
        Me.btnCetakReport.UseVisualStyleBackColor = False
        '
        'DataGridViewStrukturOrganisasi
        '
        Me.DataGridViewStrukturOrganisasi.AllowUserToAddRows = False
        Me.DataGridViewStrukturOrganisasi.AllowUserToDeleteRows = False
        Me.DataGridViewStrukturOrganisasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewStrukturOrganisasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStrukturOrganisasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2})
        Me.DataGridViewStrukturOrganisasi.Location = New System.Drawing.Point(13, 41)
        Me.DataGridViewStrukturOrganisasi.Name = "DataGridViewStrukturOrganisasi"
        Me.DataGridViewStrukturOrganisasi.ReadOnly = True
        Me.DataGridViewStrukturOrganisasi.RowTemplate.Height = 24
        Me.DataGridViewStrukturOrganisasi.Size = New System.Drawing.Size(757, 210)
        Me.DataGridViewStrukturOrganisasi.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 51
        '
        'Column3
        '
        Me.Column3.HeaderText = "Posisi"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama PJ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Struktur Organisasi"
        '
        'lbNamaMasjid
        '
        Me.lbNamaMasjid.AutoSize = True
        Me.lbNamaMasjid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNamaMasjid.ForeColor = System.Drawing.Color.White
        Me.lbNamaMasjid.Location = New System.Drawing.Point(182, 9)
        Me.lbNamaMasjid.Name = "lbNamaMasjid"
        Me.lbNamaMasjid.Size = New System.Drawing.Size(135, 20)
        Me.lbNamaMasjid.TabIndex = 17
        Me.lbNamaMasjid.Text = "NAMA MASJID"
        Me.lbNamaMasjid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'showStrukturOrganisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(782, 303)
        Me.Controls.Add(Me.lbNamaMasjid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewStrukturOrganisasi)
        Me.Controls.Add(Me.btnCetakReport)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "showStrukturOrganisasi"
        Me.Text = "Lihat Struktur Organisasi [AKAMAS]"
        CType(Me.DataGridViewStrukturOrganisasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCetakReport As System.Windows.Forms.Button
    Friend WithEvents DataGridViewStrukturOrganisasi As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbNamaMasjid As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
