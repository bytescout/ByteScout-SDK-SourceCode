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

    Private _capturingThread As Thread
    Private _capturingThreadData As CapturingThreadData  ' data to exchange between form and capturing thread

    Public Sub New()

        InitializeComponent()

        _capturingThreadData = New CapturingThreadData()

        cmbCapturingType.SelectedIndex = 0

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim captureType As CaptureAreaType = CaptureAreaType.catMouse

        If cmbCapturingType.SelectedIndex = 1 Then
            captureType = CaptureAreaType.catScreen
        End If

        StartRecording(captureType)

    End Sub

    Private Sub btnPauseResume_Click(sender As System.Object, e As System.EventArgs) Handles btnPauseResume.Click

        PauseOrResumeRecording()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        StopRecording()

    End Sub

    Private Sub StartRecording(ByVal captureType As CaptureAreaType)

        btnStart.Enabled = False
        btnPauseResume.Enabled = True
        btnStop.Enabled = True

        _capturingThreadData.CaptureType = captureType

        ' Start thread
        _capturingThread = New Thread(AddressOf CapturingThread.ThreadProc)
        _capturingThread.Start(_capturingThreadData)

        ' Signal to start the recording
        _capturingThreadData.StartOrResumeEvent.Set()
        
    End Sub

    Private Sub PauseOrResumeRecording()

        btnStart.Enabled = False
        btnPauseResume.Enabled = True
        btnStop.Enabled = True

        If btnPauseResume.Text = "Pause" Then
            ' Signal to pause
            _capturingThreadData.PauseEvent.Set()
            btnPauseResume.Text = "Resume"

        Else
            ' Signal to resume
            _capturingThreadData.StartOrResumeEvent.Set()
            btnPauseResume.Text = "Pause"
        End If

    End Sub

    Private Sub StopRecording()

        Cursor = Cursors.WaitCursor

        ' Signal to stop
        _capturingThreadData.StopEvent.Set()

        Try
            _capturingThread.Join()
        Finally
            Cursor = Cursors.Default
        End Try

        If Not _capturingThreadData.Success Then
            MessageBox.Show("Capturing failed. Error: " & _capturingThreadData.ErrorText)
        Else
            Dim dlg As New SaveFileDialog()
            dlg.DefaultExt = "*.wmv"
            dlg.Filter = "WMV files (*.wmv)|*.wmv|All files (*.*)|*.*"

            dlg.FileName = "Screencast"
            dlg.Title = "Save captured video as"

            If dlg.ShowDialog() = DialogResult.OK Then
                File.Copy(_capturingThreadData.TempFile, dlg.FileName, True)
                ' start the video in default associated application
                Process.Start(dlg.FileName)
            End If

            File.Delete(_capturingThreadData.TempFile)
        End If

        btnStart.Enabled = True
        btnPauseResume.Enabled = False
        btnStop.Enabled = False
        btnPauseResume.Text = "Pause"

    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        _capturingThreadData.StopEvent.Set()

    End Sub
End Class
