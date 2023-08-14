<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPjPosisi
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
        Me.tbNamaPj = New System.Windows.Forms.TextBox()
        Me.tbNamaPosisi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbIdPosisi = New System.Windows.Forms.ComboBox()
        Me.tbIdPj = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataGridViewPj = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridViewPj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.tbNamaPj, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNamaPosisi, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbIdPosisi, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbIdPj, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(559, 242)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'tbNamaPj
        '
        Me.tbNamaPj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaPj.Location = New System.Drawing.Point(149, 195)
        Me.tbNamaPj.Margin = New System.Windows.Forms.Padding(3, 15, 10, 5)
        Me.tbNamaPj.MaxLength = 30
        Me.tbNamaPj.Name = "tbNamaPj"
        Me.tbNamaPj.Size = New System.Drawing.Size(400, 27)
        Me.tbNamaPj.TabIndex = 13
        '
        'tbNamaPosisi
        '
        Me.tbNamaPosisi.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbNamaPosisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNamaPosisi.Location = New System.Drawing.Point(149, 135)
        Me.tbNamaPosisi.Margin = New System.Windows.Forms.Padding(3, 15, 10, 5)
        Me.tbNamaPosisi.MaxLength = 20
        Me.tbNamaPosisi.Name = "tbNamaPosisi"
        Me.tbNamaPosisi.ReadOnly = True
        Me.tbNamaPosisi.Size = New System.Drawing.Size(400, 27)
        Me.tbNamaPosisi.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 15, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID PJ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 15, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Posisi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 15, 3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Posisi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 15, 3, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama PJ"
        '
        'cbIdPosisi
        '
        Me.cbIdPosisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIdPosisi.FormattingEnabled = True
        Me.cbIdPosisi.Location = New System.Drawing.Point(149, 75)
        Me.cbIdPosisi.Margin = New System.Windows.Forms.Padding(3, 15, 10, 5)
        Me.cbIdPosisi.Name = "cbIdPosisi"
        Me.cbIdPosisi.Size = New System.Drawing.Size(400, 28)
        Me.cbIdPosisi.TabIndex = 0
        '
        'tbIdPj
        '
        Me.tbIdPj.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbIdPj.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIdPj.Location = New System.Drawing.Point(149, 15)
        Me.tbIdPj.Margin = New System.Windows.Forms.Padding(3, 15, 10, 5)
        Me.tbIdPj.MaxLength = 40
        Me.tbIdPj.Name = "tbIdPj"
        Me.tbIdPj.ReadOnly = True
        Me.tbIdPj.Size = New System.Drawing.Size(400, 27)
        Me.tbIdPj.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSave.Location = New System.Drawing.Point(240, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 34)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnEdit.Location = New System.Drawing.Point(352, 260)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(106, 34)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Tan
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(464, 260)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 34)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'DataGridViewPj
        '
        Me.DataGridViewPj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewPj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPj.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridViewPj.Location = New System.Drawing.Point(12, 300)
        Me.DataGridViewPj.Name = "DataGridViewPj"
        Me.DataGridViewPj.ReadOnly = True
        Me.DataGridViewPj.RowTemplate.Height = 24
        Me.DataGridViewPj.Size = New System.Drawing.Size(558, 241)
        Me.DataGridViewPj.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID PJ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 66
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID Posisi"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 87
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nama PJ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 90
        '
        'Column4
        '
        Me.Column4.HeaderText = "Posisi"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 70
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.Peru
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(128, 260)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(106, 34)
        Me.btnNew.TabIndex = 27
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'addPjPosisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(582, 553)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.DataGridViewPj)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addPjPosisi"
        Me.Text = "Tambah Penanggung jawab [AKAMAS]"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridViewPj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbIdPosisi As System.Windows.Forms.ComboBox
    Friend WithEvents tbIdPj As System.Windows.Forms.TextBox
    Friend WithEvents tbNamaPj As System.Windows.Forms.TextBox
    Friend WithEvents tbNamaPosisi As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DataGridViewPj As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
