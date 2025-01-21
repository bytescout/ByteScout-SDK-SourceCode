'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' x64 IMPORTANT NOTE: set CPU to x86 to build in x86 mode

Imports System.Diagnostics
Imports BytescoutSWFToVideo

Class Program
    Friend Shared Sub Main(args As String())
        ' Create an instance of SWFToVideo ActiveX object
        Dim converter As New SWFToVideo()

        ' Set debug log
        'converter.SetLogFile("log.txt");

        ' Register SWFToVideo
        converter.RegistrationName = "demo"
        converter.RegistrationKey = "demo"

        ' Enable trasparency - set BEFORE setting input SWF filename
        converter.RGBAMode = True

        ' Set input SWF file
        converter.InputSWFFileName = "Shapes.swf"
    

        ' Extract all frames to .\Output sub-folder
        converter.ConvertAllToPNG(".\Output")

        ' release resources
        System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
        converter = Nothing

        ' Open the first extracted frame in default application
        Process.Start("frame0.png")
    End Sub
End Class
