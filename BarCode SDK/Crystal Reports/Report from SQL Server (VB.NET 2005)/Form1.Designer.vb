Partial Class Form1
	Private components As System.ComponentModel.IContainer = Nothing

	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	Private Sub InitializeComponent()
		Me.crystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.CrystalReport11 = New ReportFromSqlServer.CrystalReport1()
		Me.SuspendLayout()
		' 
		' crystalReportViewer1
		' 
		Me.crystalReportViewer1.ActiveViewIndex = 0
		Me.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.crystalReportViewer1.Location = New System.Drawing.Point(0, 0)
		Me.crystalReportViewer1.Name = "crystalReportViewer1"
		Me.crystalReportViewer1.ReportSource = Me.CrystalReport11
		Me.crystalReportViewer1.Size = New System.Drawing.Size(799, 566)
		Me.crystalReportViewer1.TabIndex = 0
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(799, 566)
		Me.Controls.Add(Me.crystalReportViewer1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private crystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
	Private CrystalReport11 As CrystalReport1


End Class

