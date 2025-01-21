'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode.

Imports System.Diagnostics
Imports System.Threading
Imports BytescoutSWFToVideo

Class Program
    Friend Shared Sub Main(ByVal args As String())
        ' Create an instance of SWFToVideo ActiveX object
        Dim converter As New SWFToVideo()

        ' Set debug log
        'converter.SetLogFile("log.txt");

        ' Register SWFToVideo
        converter.RegistrationName = "demo"
        converter.RegistrationKey = "demo"

        ' Set the converter to the live data conversion mode
        ' (it will fully load the embedded video stream before the conversion)
        converter.SWFConversionMode = SWFConversionModeType.SWFWithLiveData

        ' set input SWF file 
        converter.InputSWFFileName = "shapes.swf"

        ' set output AVI or WMV video filename
        converter.OutputVideoFileName = "result.wmv"

        ' Don't let it run infinitely
        converter.ConversionTimeOut = 5000
        ' 5000ms = 5 seconds 
        ' set FPS 
        converter.FPS = 29.97F


        ' you may calculate output video duration using information about the the source swf movie
        ' WARNING #1: this method to calculate the output video duration is not working for movies with dynamic scenes 
        ' and interactive scripts as in these movies it is not possible to calculate the precise duration of the movie 
        ' WARNING #2: you should set the input swf or flv filename (or url) before this calculation

        ' So the movie duration is calculated as the following:
        ' as swf frame count (number of frames in the swf) / movieFPS (frames per second defined in swf)
        ' and then multiplied by 1000 (as we are setting the .ConverstionTimeout in milliseconds)
        ' as the following (uncomment if you want to set the length of the output video to the same as the original swf)
        ' or as the following source code (uncomment to enable):

        ' converter.ConversionTimeout = 1000 * (converter.FrameCount / converter.MovieFPS)

        ' Set output movie dimensions 
        converter.OutputWidth = 320
        converter.OutputHeight = 240

        ' Run the conversion
        converter.Run()

        ' Show conversion progress:

        Dim i As Integer = 0
        Dim spin As Char() = New Char() {"|"c, "/"c, "-"c, "\"c}

        While Not Console.KeyAvailable AndAlso converter.IsRunning
            Dim progress As Single = converter.ConversionProgress
            Console.WriteLine([String].Format("Converting images {0}% {1}", progress, spin(i)))
            Console.CursorTop -= 1
            i = i + 1
            i = i Mod 4
            Thread.Sleep(50)
        End While

        If converter.IsRunning Then
            converter.Stop()
            Console.WriteLine("Conversion aborted by user.")
        Else
            Console.WriteLine("Conversion competed successfully.")
        End If

        ' release resources
        System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
        converter = Nothing


        ' Open the result in default media player
        Process.Start("result.wmv")

        Console.WriteLine()
        Console.WriteLine("Hit any key...")
        Console.ReadKey()
    End Sub
End Class
