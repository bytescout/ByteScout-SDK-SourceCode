Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.dataGrid1 = New System.Windows.Forms.DataGrid()
		Me.dataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
		Me.dataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.btnImport = New System.Windows.Forms.Button()
		Me.btnExport = New System.Windows.Forms.Button()
		Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		DirectCast(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' dataGrid1
		' 
		Me.dataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dataGrid1.DataMember = ""
		Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.dataGrid1.Location = New System.Drawing.Point(12, 12)
		Me.dataGrid1.Name = "dataGrid1"
		Me.dataGrid1.Size = New System.Drawing.Size(438, 308)
		Me.dataGrid1.TabIndex = 0
		Me.dataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dataGridTableStyle1})
		' 
		' dataGridTableStyle1
		' 
		Me.dataGridTableStyle1.DataGrid = Me.dataGrid1
		Me.dataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.dataGridTextBoxColumn1})
		Me.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
		' 
		' dataGridTextBoxColumn1
		' 
		Me.dataGridTextBoxColumn1.Format = ""
		Me.dataGridTextBoxColumn1.FormatInfo = Nothing
		Me.dataGridTextBoxColumn1.NullText = ""
		Me.dataGridTextBoxColumn1.Width = 75
		' 
		' btnImport
		' 
		Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnImport.Location = New System.Drawing.Point(238, 326)
		Me.btnImport.Name = "btnImport"
		Me.btnImport.Size = New System.Drawing.Size(212, 23)
		Me.btnImport.TabIndex = 1
		Me.btnImport.Text = "Import from DataGrid to spreadsheet"
		Me.btnImport.UseVisualStyleBackColor = True
		AddHandler Me.btnImport.Click, New System.EventHandler(AddressOf Me.btnImport_Click)
		' 
		' btnExport
		' 
		Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExport.Location = New System.Drawing.Point(238, 355)
		Me.btnExport.Name = "btnExport"
		Me.btnExport.Size = New System.Drawing.Size(212, 23)
		Me.btnExport.TabIndex = 2
		Me.btnExport.Text = "Export from spreadsheet to DataGrid"
		Me.btnExport.UseVisualStyleBackColor = True
		AddHandler Me.btnExport.Click, New System.EventHandler(AddressOf Me.btnExport_Click)
		' 
		' openFileDialog1
		' 
		Me.openFileDialog1.FileName = "openFileDialog1"
		Me.openFileDialog1.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files|*.*"
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(462, 390)
		Me.Controls.Add(Me.btnExport)
		Me.Controls.Add(Me.btnImport)
		Me.Controls.Add(Me.dataGrid1)
		Me.Name = "Form1"
		Me.Text = "ImportFromWinFormsDataGrid"
		DirectCast(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private dataGrid1 As System.Windows.Forms.DataGrid
	Private btnImport As System.Windows.Forms.Button
	Private btnExport As System.Windows.Forms.Button
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private dataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
	Private dataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn

End Class
