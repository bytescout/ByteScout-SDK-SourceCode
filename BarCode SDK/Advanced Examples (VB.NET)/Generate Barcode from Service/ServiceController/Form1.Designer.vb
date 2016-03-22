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
		Me.btnInstallService = New System.Windows.Forms.Button()
		Me.btnUninstallService = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' btnInstallService
		' 
		Me.btnInstallService.Location = New System.Drawing.Point(12, 12)
		Me.btnInstallService.Name = "btnInstallService"
		Me.btnInstallService.Size = New System.Drawing.Size(125, 23)
		Me.btnInstallService.TabIndex = 0
		Me.btnInstallService.Text = "Install Service"
		Me.btnInstallService.UseVisualStyleBackColor = True
		AddHandler Me.btnInstallService.Click, New System.EventHandler(AddressOf Me.btnInstallService_Click)
		' 
		' btnUninstallService
		' 
		Me.btnUninstallService.Location = New System.Drawing.Point(143, 12)
		Me.btnUninstallService.Name = "btnUninstallService"
		Me.btnUninstallService.Size = New System.Drawing.Size(125, 23)
		Me.btnUninstallService.TabIndex = 1
		Me.btnUninstallService.Text = "Uninstall Service"
		Me.btnUninstallService.UseVisualStyleBackColor = True
		AddHandler Me.btnUninstallService.Click, New System.EventHandler(AddressOf Me.btnUninstallService_Click)
		' 
		' btnExit
		' 
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnExit.Location = New System.Drawing.Point(193, 77)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		AddHandler Me.btnExit.Click, New System.EventHandler(AddressOf Me.btnExit_Click)
		' 
		' Form1
		' 
		Me.AcceptButton = Me.btnExit
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(282, 112)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnUninstallService)
		Me.Controls.Add(Me.btnInstallService)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "Form1"
		Me.Text = "Service Controller"
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private btnInstallService As System.Windows.Forms.Button
	Private btnUninstallService As System.Windows.Forms.Button
	Private btnExit As System.Windows.Forms.Button
End Class

