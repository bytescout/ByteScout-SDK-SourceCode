'*******************************************************************
'       ByteScout Screen Capturing SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

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

	' set border style
        capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed

        Try
            capturer.Run()

	'// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	'// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	'// Do {
	'// Thread.Sleep(1) 
	'// }
	'// While(StopButtonNotClicked);

        Catch ex As COMException
            data.ErrorText = ex.Message
            data.Result = 1
            Return
        End Try

        Try
            Thread.Sleep(Timeout.Infinite)
        Catch generatedExceptionName As ThreadInterruptedException
            capturer.Stop()

            ' Release(Resources)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(capturer)
            capturer = Nothing

            data.Result = 0
        Catch ex As Exception
            data.ErrorText = ex.Message
            data.Result = 1
        End Try

    End Sub

End Class
