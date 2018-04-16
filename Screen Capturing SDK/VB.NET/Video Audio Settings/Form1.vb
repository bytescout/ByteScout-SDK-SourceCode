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


Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports BytescoutScreenCapturingLib

' NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
' try to do the following:
' 1) remove the reference to the SDK by View - Solution Explorer
' then click on References, select Bytescout... reference name and right-click it and select Remove
' 2) To re-add click on the menu: Project - Add Reference
' 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
' 4) Select it and click "Add" 
' 5) Recompile the application 
' Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

Public Partial Class Form1
	Inherits Form
	Private capturer As Capturer = Nothing

	Private _recording As Boolean = False
	Private _paused As Boolean = False

	Public Sub New()
		InitializeComponent()

		' Create Capturer instance
		capturer = New Capturer()
		capturer.RegistrationName = "demo"
		' put your registration name here
		capturer.RegistrationKey = "demo"
        ' put your registration key here

		' Get list of available audio devices
		For i As Integer = 0 To capturer.AudioDeviceCount - 1
			Dim line As String = capturer.GetAudioDeviceName(i)
			cmbAudioDevices.Items.Add(line)
		Next

		' Select current audio device
        If cmbAudioDevices.Items.Count > 0 Then
            cmbAudioDevices.SelectedIndex = capturer.CurrentAudioDevice
        End If

        ' Get list of available AVI audio codecs
        For i As Integer = 0 To capturer.AudioCodecsCount - 1
            Dim codec As String = capturer.GetAudioCodecName(i)
            cmbAviAudioCodecs.Items.Add(codec)
        Next

        ' Select current AVI audio codec
        cmbAviAudioCodecs.SelectedIndex = capturer.CurrentAudioCodec


        ' Get list of available web camera devices
        For i As Integer = 0 To capturer.WebCamCount - 1
            Dim camera As String = capturer.GetWebCamName(i)
            cmbWebCameras.Items.Add(camera)
        Next

        ' Select current web camera
		If cmbWebCameras.Items.Count <> 0 Then
        cmbWebCameras.SelectedIndex = capturer.CurrentWebCam
		Else
			cmbWebCameras.Items.Add("No devices")
			cmbWebCameras.SelectedIndex = 0
			cmbWebCameras.Enabled = False
			cbShowWebCamOverlay.Enabled = False
		End If

        ' Get list of available AVI video codecs
        For i As Integer = 0 To capturer.VideoCodecsCount - 1
            Dim codec As String = capturer.GetVideoCodecName(i)
            cmbAviVideoCodecs.Items.Add(codec)
        Next

        ' Select current AVI video codec
        cmbAviVideoCodecs.SelectedIndex = capturer.CurrentVideoCodec

        ' Get list of available WMV audio codecs
        For i As Integer = 0 To capturer.WMVAudioCodecsCount - 1
            Dim codec As String = capturer.GetWMVAudioCodecName(i)
            cmbWmvAudioCodecs.Items.Add(codec)
        Next

        ' Select current WMV audio codec
        cmbWmvAudioCodecs.SelectedIndex = capturer.CurrentWMVAudioCodec

        ' Get list of available WMV video codecs
        For i As Integer = 0 To capturer.WMVVideoCodecsCount - 1
            Dim codec As String = capturer.GetWMVVideoCodecName(i)
            cmbWmvVideoCodecs.Items.Add(codec)
        Next

        ' Select current WMV video codec
        cmbWmvVideoCodecs.SelectedIndex = capturer.CurrentWMVVideoCodec

        ' Fill list of FPS values
		cmbFPS.Items.AddRange(New Object() {5F, 7.5F, 10F, 12F, 14.985F, 15F, _
			19.98F, 20F, 23.976F, 24F, 25F, 29.97F, _
			30F, 50F, 59.94F, 60})
        ' Select current FPS
        cmbFPS.SelectedItem = 14.985F

		cbCaptureLayeredWindows.Checked = capturer.CaptureTransparentControls
		nudMouseHotSpot.Value = capturer.MouseSpotRadius
	End Sub

	' Rectangular region recording mode is selected
    Private Sub cbEnableAudio_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbEnableAudio.CheckedChanged
        cmbAudioDevices.Enabled = cbEnableAudio.Checked
        cmbAudioLines.Enabled = cbEnableAudio.Checked
    End Sub

    Private Sub cmbAudioDevices_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbAudioDevices.SelectedIndexChanged
        If  cmbAudioLines.Items.Count>0
        capturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString()
        End If

        cmbAudioLines.Items.Clear()

        ' Get list of available audio lines of current audio device
        For i As Integer = 0 To capturer.CurrentAudioDeviceLineCount - 1
            Dim line As String = capturer.GetCurrentAudioDeviceLineName(i)
            cmbAudioLines.Items.Add(line)
        Next

        ' Select current audio line
		If cmbAudioLines.Items.Count > 0 Then
        cmbAudioLines.SelectedIndex = capturer.CurrentAudioDeviceLine
		End If
    End Sub

    Private Sub cmbWmvAudioCodecs_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbWmvAudioCodecs.SelectedIndexChanged
        capturer.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString()

        cmbWmvAudioFormats.Items.Clear()

        ' Get list of available WMV audio formats
        For i As Integer = 0 To capturer.WMVAudioFormatCount - 1
            Dim codec As String = capturer.GetWMVAudioFormatDescription(i)
            cmbWmvAudioFormats.Items.Add(codec)
        Next

        ' Select current WMV audio format
        cmbWmvAudioFormats.SelectedIndex = capturer.CurrentWMVAudioFormat
    End Sub

    Private Sub rbRectRegion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRectRegion.CheckedChanged
        tbX.Enabled = rbRectRegion.Checked
        tbY.Enabled = rbRectRegion.Checked
        tbWidth.Enabled = rbRectRegion.Checked OrElse rbRegionAroundMouse.Checked
        tbHeight.Enabled = rbRectRegion.Checked OrElse rbRegionAroundMouse.Checked
    End Sub

	' Region around the mouse recording mode is selected
    Private Sub rbRegionAroundMouse_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRegionAroundMouse.CheckedChanged
        tbX.Enabled = rbRectRegion.Checked
        tbY.Enabled = rbRectRegion.Checked
        tbWidth.Enabled = rbRectRegion.Checked OrElse rbRegionAroundMouse.Checked
        tbHeight.Enabled = rbRectRegion.Checked OrElse rbRegionAroundMouse.Checked
    End Sub

	' Full screen recording mode is selected
    Private Sub rbFullscreen_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFullscreen.CheckedChanged
        tbX.Enabled = rbRectRegion.Checked
        tbY.Enabled = rbRectRegion.Checked
        tbWidth.Enabled = rbRectRegion.Checked OrElse rbRegionAroundMouse.Checked
        tbHeight.Enabled = rbRectRegion.Checked OrElse rbRegionAroundMouse.Checked
    End Sub

	' Show video code internal properties dialog
    Private Sub btnVideoCodecProps_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        capturer.CurrentVideoCodec = cmbAviVideoCodecs.SelectedIndex
        capturer.ShowVideoCodecSettingsDialog(Handle.ToInt32())
    End Sub

	' Show log
    Private Sub linkViewLog_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkViewLog.LinkClicked
        Dim logFile As String = Path.GetTempPath() & "Capturing Log.txt"

        If File.Exists(logFile) Then
            Dim prc As New Process()
            prc.StartInfo.FileName = logFile
            prc.StartInfo.UseShellExecute = True

            Try
                prc.Start()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

	Private Sub btnStartRecording_Click(sender As Object, e As System.EventArgs)
        ' Set up the capturer

        If cbLog.Checked Then
            capturer.SetLogFile(Path.GetTempPath() & "Capturing Log.txt")
        End If

        Dim captureToAvi As Boolean = (tabControl1.SelectedIndex = 1)

        capturer.AudioEnabled = cbEnableAudio.Checked
        capturer.CurrentAudioDeviceName = cmbAudioDevices.SelectedItem.ToString()
		If cmbAudioLines.Items.Count > 0 Then
        capturer.CurrentAudioDeviceLineName = cmbAudioLines.SelectedItem.ToString()
		End If

        If captureToAvi Then
            capturer.CurrentAudioCodecName = cmbAviAudioCodecs.SelectedItem.ToString()
            capturer.CurrentVideoCodecName = cmbAviVideoCodecs.SelectedItem.ToString()
        Else
            ' capture to WMV
            capturer.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString()
            capturer.CurrentWMVAudioFormat = cmbWmvAudioFormats.SelectedIndex
            capturer.CurrentWMVVideoCodecName = cmbWmvVideoCodecs.SelectedItem.ToString()
        End If

        capturer.MouseAnimationDuration = 400
        capturer.FPS = Single.Parse(cmbFPS.Text)
		capturer.CaptureTransparentControls = cbCaptureLayeredWindows.Checked
		capturer.MouseSpotRadius = CInt(Math.Truncate(nudMouseHotSpot.Value))

        capturer.CaptureRectLeft = Integer.Parse(tbX.Text)
        capturer.CaptureRectTop = Integer.Parse(tbY.Text)
        capturer.CaptureRectWidth = Integer.Parse(tbWidth.Text)
        capturer.CaptureRectHeight = Integer.Parse(tbHeight.Text)

        capturer.OutputWidth = Integer.Parse(tbWidth.Text)
        capturer.OutputHeight = Integer.Parse(tbHeight.Text)

        ' Set capturing mode

        If rbRectRegion.Checked Then
            capturer.CapturingType = CaptureAreaType.catRegion
	    ' set border style
            capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed
        ElseIf rbRegionAroundMouse.Checked Then
            capturer.CapturingType = CaptureAreaType.catMouse
	    ' set border style
            capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed
        Else
            capturer.CapturingType = CaptureAreaType.catScreen
        End If

        If cbShowWebCamOverlay.Checked Then
            ' Set web camera device to add overlaying video to the source
            capturer.AddWebCamVideo = True

            ' Set device name or you can set device by index using .CurrentCaptureDevice property
            capturer.CurrentWebCam = cmbWebCameras.SelectedIndex

            ' Set rectangle to show overlaying video from webcam into the rectangle 160x120 (starting with left point at 10,10)
			capturer.SetWebCamVideoRectangle(Integer.Parse(tbWebCameraX.Text), Integer.Parse(tbWebCameraY.Text), Integer.Parse(tbWebCameraWidth.Text), Integer.Parse(tbWebCameraHeight.Text))
        End If

        ' Save to temp file

        Dim filename As String = Path.GetTempFileName()
        filename = Path.ChangeExtension(filename, CType(IIf(captureToAvi, "avi", "wmv"), String))
        capturer.OutputFileName = filename

        Try
            ' Start capturing
			Try
				Cursor = Cursors.WaitCursor
            capturer.Run()

	' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	' using Thread.Sleep(1) inside the checking loop, so you have the loop like
	' Do 
	' Thread.Sleep(1) 
	' While StopButtonNotClicked


	' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	' using Thread.Sleep(1) inside the checking loop, so you have the loop like
	' Do 
	' Thread.Sleep(1) 
	' While StopButtonNotClicked

			Finally
                Cursor = Cursors.Default
			End Try

            _recording = True
            btnStartRecording.Enabled = False
			btnPauseRecording.Enabled = True
            btnStopRecording.Enabled = True

            ' Wait for "Stop Recording" button pressed
            While _recording
                Thread.Sleep(10)
                Application.DoEvents()
            End While

            ' Stop capturing
			Try
				Cursor = Cursors.WaitCursor
                capturer.Stop()
			Finally
                Cursor = Cursors.Default
			End Try

            ' Ask for output file name
            Dim dlg As New SaveFileDialog()

            dlg.Title = "Save captured video as"
            dlg.FileName = "Screencast"

            If captureToAvi Then
                dlg.DefaultExt = "*.avi"
                dlg.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*"
            Else
                dlg.DefaultExt = "*.wmv"
                dlg.Filter = "WMV files (*.wmv)|*.wmv|All files (*.*)|*.*"
            End If

            If dlg.ShowDialog() = DialogResult.OK Then
                ' Save to specified file name
                File.Copy(capturer.OutputFileName, dlg.FileName, True)
            End If

            ' clean up
            Try
                File.Delete(capturer.OutputFileName)
            Catch
            End Try

            btnStartRecording.Enabled = True
			btnPauseRecording.Enabled = False
            btnStopRecording.Enabled = False

            ' open saved video in default video viewer
			Try
            Process.Start(dlg.FileName)
			Catch
			End Try
        Catch ex As COMException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

	Private Sub btnPauseRecording_Click(sender As Object, e As EventArgs)
		Dim captureToAvi As Boolean = (tabControl1.SelectedIndex = 1)

		If captureToAvi Then
			MessageBox.Show("Pausing is only available for WMV format yet.")
			Return
		End If

		If Not _paused Then
			capturer.Pause()
			_paused = True
			btnPauseRecording.Text = "Resume recodring"
		Else
			' Resume capturing
			capturer.Run()
			_paused = False
			btnPauseRecording.Text = "Pause recording"
		End If
	End Sub

	Private Sub btnStopRecording_Click(sender As Object, e As System.EventArgs)
        ' Toggle recording flag
        If _recording Then
            _recording = False
        End If
    End Sub
End Class
