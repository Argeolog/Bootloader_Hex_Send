<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Anasayfa
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Hex_Sec_Buton = New System.Windows.Forms.Button()
		Me.Gonder_Buton = New System.Windows.Forms.Button()
		Me.Dosya_Yolu_Text = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Cihaz_Durumu_Label = New System.Windows.Forms.ToolStripStatusLabel()
		Me.Hex_Datagrid = New System.Windows.Forms.DataGridView()
		Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Veri_ilerleme_Progress = New System.Windows.Forms.ProgressBar()
		Me.Cihaz_Adi_Yaz = New System.Windows.Forms.Button()
		Me.Flash_Hafiza_Sil_Buton = New System.Windows.Forms.Button()
		Me.Cihaz_Adi_Text = New System.Windows.Forms.TextBox()
		Me.Cihaz_Adi_Dogru_mu_Buton = New System.Windows.Forms.Button()
		Me.Cihaz_Adi_Oku_Buton = New System.Windows.Forms.Button()
		Me.Cihaz_Ayar_Page_Sil_Buton = New System.Windows.Forms.Button()
		Me.StatusStrip1.SuspendLayout()
		CType(Me.Hex_Datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Hex_Sec_Buton
		'
		Me.Hex_Sec_Buton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Hex_Sec_Buton.Location = New System.Drawing.Point(850, 12)
		Me.Hex_Sec_Buton.Name = "Hex_Sec_Buton"
		Me.Hex_Sec_Buton.Size = New System.Drawing.Size(111, 34)
		Me.Hex_Sec_Buton.TabIndex = 0
		Me.Hex_Sec_Buton.Text = "Hex,Bin Seç"
		Me.Hex_Sec_Buton.UseVisualStyleBackColor = True
		'
		'Gonder_Buton
		'
		Me.Gonder_Buton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Gonder_Buton.Location = New System.Drawing.Point(11, 565)
		Me.Gonder_Buton.Name = "Gonder_Buton"
		Me.Gonder_Buton.Size = New System.Drawing.Size(583, 53)
		Me.Gonder_Buton.TabIndex = 1
		Me.Gonder_Buton.Text = "Yazdır"
		Me.Gonder_Buton.UseVisualStyleBackColor = True
		'
		'Dosya_Yolu_Text
		'
		Me.Dosya_Yolu_Text.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Dosya_Yolu_Text.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Dosya_Yolu_Text.Location = New System.Drawing.Point(79, 20)
		Me.Dosya_Yolu_Text.Name = "Dosya_Yolu_Text"
		Me.Dosya_Yolu_Text.ReadOnly = True
		Me.Dosya_Yolu_Text.Size = New System.Drawing.Size(765, 20)
		Me.Dosya_Yolu_Text.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(9, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(61, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Dosya Yolu"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.Cihaz_Durumu_Label})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 625)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(973, 26)
		Me.StatusStrip1.TabIndex = 6
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel1
		'
		Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
		Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(117, 21)
		Me.ToolStripStatusLabel1.Text = "Cihaz Durumu :"
		'
		'Cihaz_Durumu_Label
		'
		Me.Cihaz_Durumu_Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Cihaz_Durumu_Label.ForeColor = System.Drawing.Color.Red
		Me.Cihaz_Durumu_Label.Name = "Cihaz_Durumu_Label"
		Me.Cihaz_Durumu_Label.Size = New System.Drawing.Size(84, 21)
		Me.Cihaz_Durumu_Label.Text = "Bağlı Değil"
		'
		'Hex_Datagrid
		'
		Me.Hex_Datagrid.AllowUserToAddRows = False
		Me.Hex_Datagrid.AllowUserToDeleteRows = False
		Me.Hex_Datagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Hex_Datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
		Me.Hex_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Hex_Datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24, Me.Column25, Me.Column26, Me.Column27})
		Me.Hex_Datagrid.Location = New System.Drawing.Point(13, 52)
		Me.Hex_Datagrid.Name = "Hex_Datagrid"
		Me.Hex_Datagrid.ReadOnly = True
		Me.Hex_Datagrid.Size = New System.Drawing.Size(948, 467)
		Me.Hex_Datagrid.TabIndex = 7
		'
		'Column10
		'
		Me.Column10.HeaderText = "Adres"
		Me.Column10.Name = "Column10"
		Me.Column10.ReadOnly = True
		'
		'Column11
		'
		Me.Column11.HeaderText = "0"
		Me.Column11.Name = "Column11"
		Me.Column11.ReadOnly = True
		Me.Column11.Width = 25
		'
		'Column12
		'
		Me.Column12.HeaderText = "1"
		Me.Column12.Name = "Column12"
		Me.Column12.ReadOnly = True
		Me.Column12.Width = 25
		'
		'Column13
		'
		Me.Column13.HeaderText = "2"
		Me.Column13.Name = "Column13"
		Me.Column13.ReadOnly = True
		Me.Column13.Width = 25
		'
		'Column14
		'
		Me.Column14.HeaderText = "3"
		Me.Column14.Name = "Column14"
		Me.Column14.ReadOnly = True
		Me.Column14.Width = 25
		'
		'Column15
		'
		Me.Column15.HeaderText = "4"
		Me.Column15.Name = "Column15"
		Me.Column15.ReadOnly = True
		Me.Column15.Width = 25
		'
		'Column16
		'
		Me.Column16.HeaderText = "5"
		Me.Column16.Name = "Column16"
		Me.Column16.ReadOnly = True
		Me.Column16.Width = 25
		'
		'Column17
		'
		Me.Column17.HeaderText = "6"
		Me.Column17.Name = "Column17"
		Me.Column17.ReadOnly = True
		Me.Column17.Width = 25
		'
		'Column18
		'
		Me.Column18.HeaderText = "7"
		Me.Column18.Name = "Column18"
		Me.Column18.ReadOnly = True
		Me.Column18.Width = 25
		'
		'Column19
		'
		Me.Column19.HeaderText = "8"
		Me.Column19.Name = "Column19"
		Me.Column19.ReadOnly = True
		Me.Column19.Width = 25
		'
		'Column20
		'
		Me.Column20.HeaderText = "9"
		Me.Column20.Name = "Column20"
		Me.Column20.ReadOnly = True
		Me.Column20.Width = 25
		'
		'Column21
		'
		Me.Column21.HeaderText = "A"
		Me.Column21.Name = "Column21"
		Me.Column21.ReadOnly = True
		Me.Column21.Width = 25
		'
		'Column22
		'
		Me.Column22.HeaderText = "B"
		Me.Column22.Name = "Column22"
		Me.Column22.ReadOnly = True
		Me.Column22.Width = 25
		'
		'Column23
		'
		Me.Column23.HeaderText = "C"
		Me.Column23.Name = "Column23"
		Me.Column23.ReadOnly = True
		Me.Column23.Width = 25
		'
		'Column24
		'
		Me.Column24.HeaderText = "D"
		Me.Column24.Name = "Column24"
		Me.Column24.ReadOnly = True
		Me.Column24.Width = 25
		'
		'Column25
		'
		Me.Column25.HeaderText = "E"
		Me.Column25.Name = "Column25"
		Me.Column25.ReadOnly = True
		Me.Column25.Width = 25
		'
		'Column26
		'
		Me.Column26.HeaderText = "F"
		Me.Column26.Name = "Column26"
		Me.Column26.ReadOnly = True
		Me.Column26.Width = 25
		'
		'Column27
		'
		Me.Column27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
		Me.Column27.HeaderText = "Ascii"
		Me.Column27.Name = "Column27"
		Me.Column27.ReadOnly = True
		'
		'Veri_ilerleme_Progress
		'
		Me.Veri_ilerleme_Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Veri_ilerleme_Progress.BackColor = System.Drawing.SystemColors.Control
		Me.Veri_ilerleme_Progress.Location = New System.Drawing.Point(12, 525)
		Me.Veri_ilerleme_Progress.Name = "Veri_ilerleme_Progress"
		Me.Veri_ilerleme_Progress.Size = New System.Drawing.Size(582, 34)
		Me.Veri_ilerleme_Progress.TabIndex = 8
		'
		'Cihaz_Adi_Yaz
		'
		Me.Cihaz_Adi_Yaz.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cihaz_Adi_Yaz.Location = New System.Drawing.Point(850, 583)
		Me.Cihaz_Adi_Yaz.Name = "Cihaz_Adi_Yaz"
		Me.Cihaz_Adi_Yaz.Size = New System.Drawing.Size(111, 35)
		Me.Cihaz_Adi_Yaz.TabIndex = 9
		Me.Cihaz_Adi_Yaz.Text = "Cihaz Adı Yaz"
		Me.Cihaz_Adi_Yaz.UseVisualStyleBackColor = True
		'
		'Flash_Hafiza_Sil_Buton
		'
		Me.Flash_Hafiza_Sil_Buton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Flash_Hafiza_Sil_Buton.Location = New System.Drawing.Point(725, 542)
		Me.Flash_Hafiza_Sil_Buton.Name = "Flash_Hafiza_Sil_Buton"
		Me.Flash_Hafiza_Sil_Buton.Size = New System.Drawing.Size(119, 35)
		Me.Flash_Hafiza_Sil_Buton.TabIndex = 10
		Me.Flash_Hafiza_Sil_Buton.Text = "Program Flash Sil"
		Me.Flash_Hafiza_Sil_Buton.UseVisualStyleBackColor = True
		'
		'Cihaz_Adi_Text
		'
		Me.Cihaz_Adi_Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cihaz_Adi_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
		Me.Cihaz_Adi_Text.Location = New System.Drawing.Point(850, 542)
		Me.Cihaz_Adi_Text.MaxLength = 6
		Me.Cihaz_Adi_Text.Multiline = True
		Me.Cihaz_Adi_Text.Name = "Cihaz_Adi_Text"
		Me.Cihaz_Adi_Text.Size = New System.Drawing.Size(111, 35)
		Me.Cihaz_Adi_Text.TabIndex = 11
		Me.Cihaz_Adi_Text.Text = "Test"
		'
		'Cihaz_Adi_Dogru_mu_Buton
		'
		Me.Cihaz_Adi_Dogru_mu_Buton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cihaz_Adi_Dogru_mu_Buton.Location = New System.Drawing.Point(725, 583)
		Me.Cihaz_Adi_Dogru_mu_Buton.Name = "Cihaz_Adi_Dogru_mu_Buton"
		Me.Cihaz_Adi_Dogru_mu_Buton.Size = New System.Drawing.Size(119, 35)
		Me.Cihaz_Adi_Dogru_mu_Buton.TabIndex = 12
		Me.Cihaz_Adi_Dogru_mu_Buton.Text = "Cihaz Adını Doğrula"
		Me.Cihaz_Adi_Dogru_mu_Buton.UseVisualStyleBackColor = True
		'
		'Cihaz_Adi_Oku_Buton
		'
		Me.Cihaz_Adi_Oku_Buton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cihaz_Adi_Oku_Buton.Location = New System.Drawing.Point(600, 542)
		Me.Cihaz_Adi_Oku_Buton.Name = "Cihaz_Adi_Oku_Buton"
		Me.Cihaz_Adi_Oku_Buton.Size = New System.Drawing.Size(119, 35)
		Me.Cihaz_Adi_Oku_Buton.TabIndex = 13
		Me.Cihaz_Adi_Oku_Buton.Text = "Cihaz Adı Oku"
		Me.Cihaz_Adi_Oku_Buton.UseVisualStyleBackColor = True
		'
		'Cihaz_Ayar_Page_Sil_Buton
		'
		Me.Cihaz_Ayar_Page_Sil_Buton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Cihaz_Ayar_Page_Sil_Buton.Location = New System.Drawing.Point(600, 583)
		Me.Cihaz_Ayar_Page_Sil_Buton.Name = "Cihaz_Ayar_Page_Sil_Buton"
		Me.Cihaz_Ayar_Page_Sil_Buton.Size = New System.Drawing.Size(119, 35)
		Me.Cihaz_Ayar_Page_Sil_Buton.TabIndex = 14
		Me.Cihaz_Ayar_Page_Sil_Buton.Text = "Cihaz Ayar Flash Sil"
		Me.Cihaz_Ayar_Page_Sil_Buton.UseVisualStyleBackColor = True
		'
		'Anasayfa
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(973, 651)
		Me.Controls.Add(Me.Cihaz_Ayar_Page_Sil_Buton)
		Me.Controls.Add(Me.Cihaz_Adi_Oku_Buton)
		Me.Controls.Add(Me.Cihaz_Adi_Dogru_mu_Buton)
		Me.Controls.Add(Me.Cihaz_Adi_Text)
		Me.Controls.Add(Me.Flash_Hafiza_Sil_Buton)
		Me.Controls.Add(Me.Cihaz_Adi_Yaz)
		Me.Controls.Add(Me.Veri_ilerleme_Progress)
		Me.Controls.Add(Me.Hex_Datagrid)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Dosya_Yolu_Text)
		Me.Controls.Add(Me.Gonder_Buton)
		Me.Controls.Add(Me.Hex_Sec_Buton)
		Me.Name = "Anasayfa"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Anasayfa"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.Hex_Datagrid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Hex_Sec_Buton As Button
	Friend WithEvents Gonder_Buton As Button
	Friend WithEvents Dosya_Yolu_Text As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
	Friend WithEvents Cihaz_Durumu_Label As ToolStripStatusLabel
	Friend WithEvents Hex_Datagrid As DataGridView
	Friend WithEvents Column10 As DataGridViewTextBoxColumn
	Friend WithEvents Column11 As DataGridViewTextBoxColumn
	Friend WithEvents Column12 As DataGridViewTextBoxColumn
	Friend WithEvents Column13 As DataGridViewTextBoxColumn
	Friend WithEvents Column14 As DataGridViewTextBoxColumn
	Friend WithEvents Column15 As DataGridViewTextBoxColumn
	Friend WithEvents Column16 As DataGridViewTextBoxColumn
	Friend WithEvents Column17 As DataGridViewTextBoxColumn
	Friend WithEvents Column18 As DataGridViewTextBoxColumn
	Friend WithEvents Column19 As DataGridViewTextBoxColumn
	Friend WithEvents Column20 As DataGridViewTextBoxColumn
	Friend WithEvents Column21 As DataGridViewTextBoxColumn
	Friend WithEvents Column22 As DataGridViewTextBoxColumn
	Friend WithEvents Column23 As DataGridViewTextBoxColumn
	Friend WithEvents Column24 As DataGridViewTextBoxColumn
	Friend WithEvents Column25 As DataGridViewTextBoxColumn
	Friend WithEvents Column26 As DataGridViewTextBoxColumn
	Friend WithEvents Column27 As DataGridViewTextBoxColumn
	Friend WithEvents Veri_ilerleme_Progress As ProgressBar
	Friend WithEvents Cihaz_Adi_Yaz As Button
	Friend WithEvents Flash_Hafiza_Sil_Buton As Button
	Friend WithEvents Cihaz_Adi_Text As TextBox
	Friend WithEvents Cihaz_Adi_Dogru_mu_Buton As Button
	Friend WithEvents Cihaz_Adi_Oku_Buton As Button
	Friend WithEvents Cihaz_Ayar_Page_Sil_Buton As Button
End Class
