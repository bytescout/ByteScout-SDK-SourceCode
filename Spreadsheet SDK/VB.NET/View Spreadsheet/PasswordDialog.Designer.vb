Partial Class PasswordDialog
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
		Me.textBoxPassword = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.checkBoxHide = New System.Windows.Forms.CheckBox()
		Me.btnOk = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' textBoxPassword
		' 
		Me.textBoxPassword.Location = New System.Drawing.Point(79, 39)
		Me.textBoxPassword.Name = "textBoxPassword"
		Me.textBoxPassword.Size = New System.Drawing.Size(168, 22)
		Me.textBoxPassword.TabIndex = 1
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Location = New System.Drawing.Point(4, 42)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(73, 17)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Password:"
		' 
		' checkBoxHide
		' 
		Me.checkBoxHide.AutoSize = True
		Me.checkBoxHide.Location = New System.Drawing.Point(7, 12)
		Me.checkBoxHide.Name = "checkBoxHide"
		Me.checkBoxHide.Size = New System.Drawing.Size(123, 21)
		Me.checkBoxHide.TabIndex = 3
		Me.checkBoxHide.Text = "Hide password"
		Me.checkBoxHide.UseVisualStyleBackColor = True
		AddHandler Me.checkBoxHide.CheckedChanged, New System.EventHandler(AddressOf Me.checkBoxHide_CheckedChanged)
		' 
		' btnOk
		' 
		Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnOk.Location = New System.Drawing.Point(91, 67)
		Me.btnOk.Name = "btnOk"
		Me.btnOk.Size = New System.Drawing.Size(75, 23)
		Me.btnOk.TabIndex = 4
		Me.btnOk.Text = "Ok"
		Me.btnOk.UseVisualStyleBackColor = True
		AddHandler Me.btnOk.Click, New System.EventHandler(AddressOf Me.btnOk_Click)
		' 
		' btnCancel
		' 
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(172, 67)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 5
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		AddHandler Me.btnCancel.Click, New System.EventHandler(AddressOf Me.btnCancel_Click)
		' 
		' PasswordDialog
		' 
		Me.AcceptButton = Me.btnOk
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnCancel
		Me.ClientSize = New System.Drawing.Size(255, 98)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnOk)
		Me.Controls.Add(Me.checkBoxHide)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.textBoxPassword)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "PasswordDialog"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Please enter a password"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	#End Region

	Private textBoxPassword As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private checkBoxHide As System.Windows.Forms.CheckBox
	Private btnOk As System.Windows.Forms.Button
	Private btnCancel As System.Windows.Forms.Button
End Class
