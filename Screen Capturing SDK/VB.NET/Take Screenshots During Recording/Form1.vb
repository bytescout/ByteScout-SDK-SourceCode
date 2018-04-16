'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports BytescoutScreenCapturingLib

Public Class Form1

	' NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
	' try to do the following:
	' 1) remove the reference to the SDK by View - Solution Explorer
	' then click on References, select Bytescout... reference name and right-click it and select Remove
	' 2) To re-add click on the menu: Project - Add Reference
	' 3) In "Add Reference" dialog switch to "COM" tab and find "BytescoutScreenCapturing 1.0 Type Library"
	' 4) Select it and click "Add" 
	' 5) Recompile the application 
	' Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

	Dim _capturer As Capturer = Nothing

	Dim _screencastCount As Integer = 0
	Dim _screenshotCount As Integer = 0

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		' Create and setup Capturer object:

		_capturer = New Capturer()

		' Capture the full screen
		_capturer.CapturingType = CaptureAreaType.catScreen

		' Set movie width and height to the current monitor dimensions
		_capturer.OutputWidth = _capturer.MonitorWidth
		_capturer.OutputHeight = _capturer.MonitorHeight

		' Setup screenshots
		_capturer.ScreenshotImageFormat = ScreenshotImageType.ssitPng ' Save images in PNG format
		_capturer.ScreenshotOutputFolder = "\."	' Save to the current folder
		_capturer.ScreenshotSavingType = ScreenshotSavingType.ssstManual ' Take screenshots manually

	End Sub

	Private Sub buttonStart_Click(sender As Object, e As EventArgs) Handles buttonStart.Click

		_screencastCount = _screencastCount + 1
		Dim fileName As String = String.Format("screencast{0}.wmv", _screencastCount)

		' Start screen recording
		_capturer.OutputFileName = fileName
		_capturer.Run()

		buttonStart.Enabled = False
		buttonStop.Enabled = True
		buttonScreenshot.Enabled = True

	End Sub

	Private Sub buttonStop_Click(sender As Object, e As EventArgs) Handles buttonStop.Click

		' Stop recording
		_capturer.Stop()

		buttonStart.Enabled = True
		buttonStop.Enabled = False
		buttonScreenshot.Enabled = False

		MessageBox.Show("Screencast saved to " + _capturer.OutputFileName, ProductName)

	End Sub

	Private Sub buttonScreenshot_Click(sender As Object, e As EventArgs) Handles buttonScreenshot.Click

		_screenshotCount = _screenshotCount + 1
		Dim fileName As String = String.Format("screenshot{0}.png", _screenshotCount)

		' Take screenshot during the recording
		_capturer.TakeScreenshot(fileName)

		MessageBox.Show("Screenshot saved to " + fileName, ProductName)

	End Sub

End Class
