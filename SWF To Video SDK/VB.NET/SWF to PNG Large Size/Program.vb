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
        Dim z As New SWFToVideo()
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


        ' Select 20th frame
        converter.StartFrame = 20
        converter.StopFrame = 20

        ' large output size
        converter.OutputWidth = 2500
        converter.OutputHeight = 2500


        ' Run conversion
        converter.ConvertToPNG("result.png")

        ' release resources
        System.Runtime.InteropServices.Marshal.ReleaseComObject(converter)
        converter = Nothing


        ' Open the result in default application
        Process.Start("result.png")
    End Sub
End Class
