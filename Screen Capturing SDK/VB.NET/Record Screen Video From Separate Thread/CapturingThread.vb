'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading
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

Public Class CapturingThread

    Public Shared Sub ThreadProc(ByVal obj As Object)

        Dim data As CapturingThreadData = DirectCast(obj, CapturingThreadData)
        data.Success = True

        ' Prepare Capturer:

        Dim capturer As New Capturer()
        capturer.RegistrationName = "demo"
        capturer.RegistrationKey = "demo"

        capturer.CaptureRectLeft = data.CaptureRectangle.Left
        capturer.CaptureRectTop = data.CaptureRectangle.Top
        capturer.CaptureRectWidth = data.CaptureRectangle.Width
        capturer.CaptureRectHeight = data.CaptureRectangle.Height

        capturer.OutputWidth = 640
        capturer.OutputHeight = 480

        ' // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
        ' // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
        ' capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2
        
        data.TempFile = Path.GetTempFileName()
        data.TempFile = Path.ChangeExtension(data.TempFile, ".wmv")

        capturer.OutputFileName = data.TempFile
        capturer.CapturingType = data.CaptureType

        ' set border around captured area if we are not capturing entire screen
        If capturer.CapturingType <> CaptureAreaType.catScreen And capturer.CapturingType <> CaptureAreaType.catWebcamFullScreen Then

            capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed
            capturer.CaptureAreaBorderColor = CType(ColorTranslator.ToOle(Color.Red), UInteger)

        End If


        ' Wait for events:

        Dim events As WaitHandle() = New WaitHandle() {data.StartOrResumeEvent, data.PauseEvent, data.StopEvent}

        Try

            While (True)

                Dim i As Integer = WaitHandle.WaitAny(events)

                If events(i) Is data.StartOrResumeEvent Then

                    If Not capturer.IsRunning Then
                        capturer.Run()
                    End If

                ElseIf events(i) Is data.PauseEvent Then

                    If capturer.IsRunning Then
                        capturer.Pause()
                    End If

                ElseIf events(i) Is data.StopEvent Then

                    capturer.Stop()
                    Exit While

                End If
                
            End While

        Catch ex As Exception

            data.ErrorText = ex.Message
            data.Success = False

        Finally

            ' Release resources
            Marshal.ReleaseComObject(capturer)

        End Try

    End Sub

End Class
