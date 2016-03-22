'*******************************************************************
'       ByteScout Screen Capturing SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

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

        cmbCapturingType.SelectedIndex = 0

    End Sub

	Private Sub btnStart_Click(sender As Object, e As EventArgs)

        Dim captureType As CaptureAreaType = CaptureAreaType.catMouse

		If cmbCapturingType.SelectedIndex = 1 Then
			captureType = CaptureAreaType.catScreen
		End If

        StartRecording(captureType)

	End Sub

	Private Sub btnStop_Click(sender As Object, e As EventArgs)

        StopRecording()

    End Sub

    Private Sub StartRecording(ByVal captureType As CaptureAreaType)

        btnStart.Enabled = False
        btnStop.Enabled = True

        _capturingThreadData = New CapturingThreadData()
        _capturingThreadData.CaptureType = captureType

        _capturingThread = New Thread(AddressOf CapturingThread.ThreadProc)
        _capturingThread.Start(_capturingThreadData)

    End Sub

    Private Sub StopRecording()

        btnStop.Enabled = False

        Cursor = Cursors.WaitCursor

        Try
            ' stop recording thread
            _capturingThread.Interrupt()
            _capturingThread.Join()
        Finally
            Cursor = Cursors.[Default]
        End Try

        If _capturingThreadData.Result <> 0 Then
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

    End Sub
End Class
