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


Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Globalization
Imports System.Threading
Imports System.Runtime.InteropServices

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

Module Module1
    Public Class Win32Interop
        <DllImport("crtdll.dll")> _
        Public Shared Function _kbhit() As Integer
        End Function
    End Class

    Sub Main(ByVal args As String())
        Dim capturer As New Capturer()

        If args.Length < 1 Then
            usage(capturer)
            Exit Sub
        End If

        capturer.OutputFileName = args(0)
        capturer.CapturingType = CaptureAreaType.catRegion

	' set border style
        capturer.CaptureAreaBorderType = CaptureAreaBorderType.cabtDashed

	' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
	' capturer.CaptureTransparentControls = true

	' // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	' // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	' capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2



        setParams(args, capturer)

        Try
            capturer.Run()

	' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	' using Thread.Sleep(1) inside the checking loop, so you have the loop like
	' Do 
	' Thread.Sleep(1) 
	' While StopButtonNotClicked

            Console.WriteLine("Starting capture - Hit a key to stop ...")

            Dim s As String = capturer.CurrentVideoCodecName
            Console.WriteLine(String.Format("Using video compressor - {0}", s))

            s = capturer.CurrentAudioCodecName
            Console.WriteLine(String.Format("Using audio compressor - {0}", s))

            s = capturer.CurrentAudioDeviceLineName
            Console.WriteLine(String.Format("Using audio input line - {0}", s))

            Dim i As Integer = 0
            Dim spin As String = "|/-\"
            While Win32Interop._kbhit() = 0
                Console.Write(String.Format(vbCr & "Encoding {0}", spin(i)))
                i = i + 1
                i = i Mod 4
                Thread.Sleep(50)
            End While

            capturer.Stop()

        ' Release(Resources)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(capturer)
        capturer = Nothing

            Console.Write(vbLf & "Done")
            Console.Read()
        Catch generatedExceptionName As Exception
            Console.WriteLine(capturer.LastError)
        End Try
    End Sub

    Private Sub usage(ByVal capturer As Capturer)
        Console.WriteLine("Usage : CaptureScreenCSharp.exe <outfilename> [left] [top] [width] [height] [fps] [v-codec] [a-codec] [audioline]" & vbLf)
        Console.WriteLine("[left, top, width, height] is the rectangle to be captured")
        Console.WriteLine("[v-codec] is the index of the video codec in the list to use.")
        Console.WriteLine("[a-codec] is the index of the audio codec in the list to use.")
        Console.WriteLine("[audioline] is the index of the audio line in the list to capture from")
        Console.WriteLine("If either codec is unspecified, it defaults to 'Microsoft Video 1' and 'GSM 6.10'")
        Console.WriteLine("If audioline is unspecified, it uses the microphone")
        Console.WriteLine("To capture the currently playing output, select the stereo, mono or wave mix")

        Console.WriteLine("Installed Video Codecs (Note : Not all of them may work)")

        For i As Integer = 0 To capturer.VideoCodecsCount - 1
            Dim name As String = capturer.GetVideoCodecName(i)
            Console.WriteLine(String.Format("    {0}. {1}", i, name))
        Next

        Console.WriteLine(vbLf & "Installed Audio Codecs (Note : Not all of them may work)")
        For i As Integer = 0 To capturer.AudioCodecsCount - 1
            Dim name As String = capturer.GetAudioCodecName(i)
            Console.WriteLine(String.Format("    {0}. {1}", i, name))
        Next

        Console.WriteLine(vbLf & "Audio input lines")
        For i As Integer = 0 To capturer.CurrentAudioDeviceLineCount - 1
            Dim name As String = capturer.GetCurrentAudioDeviceLineName(i)
            Console.WriteLine(String.Format("    {0}. {1}", i, name))
        Next
    End Sub

    Private Sub setParams(ByVal args As String(), ByVal capturer As Capturer)
        If args.Length > 1 Then
            Dim left As Integer = Integer.Parse(args(1))
            capturer.CaptureRectLeft = left
        End If

        If args.Length > 2 Then
            Dim top As Integer = Integer.Parse(args(2))
            capturer.CaptureRectTop = top
        End If

        If args.Length > 3 Then
            Dim width As Integer = Integer.Parse(args(3))
            capturer.CaptureRectWidth = width
        End If

        If args.Length > 5 Then
            Dim height As Integer = Integer.Parse(args(5))
            capturer.CaptureRectHeight = height
        End If

        If args.Length > 6 Then
            Dim fps As Single = Single.Parse(args(6), CultureInfo.InvariantCulture)
            capturer.FPS = fps
        End If

        If args.Length > 7 Then
            Dim vCodec As Integer = Integer.Parse(args(7))
            capturer.CurrentVideoCodec = vCodec
        End If

        If args.Length > 8 Then
            Dim aCodec As Integer = Integer.Parse(args(8))
            capturer.CurrentAudioCodec = aCodec
        End If

        If args.Length > 9 Then
            Dim aLine As Integer = Integer.Parse(args(9))
            capturer.CurrentAudioDeviceLine = aLine
        End If
    End Sub

End Module
