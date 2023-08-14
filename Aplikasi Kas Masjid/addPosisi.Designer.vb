<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPosisi
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
        Me.DataGridViewPosisi = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbPosisi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPosisiId = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPosisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewPosisi
        '
        Me.DataGridViewPosisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewPosisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPosisi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridViewPosisi.Location = New System.Drawing.Point(12, 195)
        Me.DataGridViewPosisi.Name = "DataGridViewPosisi"
        Me.DataGridViewPosisi.ReadOnly = True
        Me.DataGridViewPosisi.RowTemplate.Height = 24
        Me.DataGridViewPosisi.Size = New System.Drawing.Size(557, 196)
        Me.DataGridViewPosisi.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID POSISI"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 94
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAMA POSISI"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
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
        Me.TableLayoutPanel1.Controls.Add(Me.tbPosisi, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPosisiId, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(557, 131)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'tbPosisi
        '
        Me.tbPosisi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbPosisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPosisi.Location = New System.Drawing.Point(148, 85)
        Me.tbPosisi.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbPosisi.MaxLength = 20
        Me.tbPosisi.Name = "tbPosisi"
        Me.tbPosisi.Size = New System.Drawing.Size(399, 27)
        Me.tbPosisi.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Posisi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 20, 3, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Posisi"
        '
        'tbPosisiId
        '
        Me.tbPosisiId.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbPosisiId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPosisiId.Location = New System.Drawing.Point(148, 20)
        Me.tbPosisiId.Margin = New System.Windows.Forms.Padding(3, 20, 10, 5)
        Me.tbPosisiId.MaxLength = 10
        Me.tbPosisiId.Name = "tbPosisiId"
        Me.tbPosisiId.ReadOnly = True
        Me.tbPosisiId.Size = New System.Drawing.Size(399, 27)
        Me.tbPosisiId.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSave.Location = New System.Drawing.Point(239, 155)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 34)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.PeachPuff
        Me.btnEdit.Location = New System.Drawing.Point(351, 155)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(106, 34)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Tan
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(463, 155)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(106, 34)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.Peru
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(127, 155)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(106, 34)
        Me.btnNew.TabIndex = 28
        Me.btnNew.Text = "NEW"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'addPosisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(582, 403)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DataGridViewPosisi)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addPosisi"
        Me.Text = "Tambah Posisi [AKAMAS]"
        CType(Me.DataGridViewPosisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewPosisi As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbPosisi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbPosisiId As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
