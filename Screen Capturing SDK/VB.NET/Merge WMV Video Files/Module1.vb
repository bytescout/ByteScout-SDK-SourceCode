'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' import bytescout screen capturing activex object 
Imports BytescoutScreenCapturingLib

Module Module1

    Sub Main(ByVal args As String())

        ' Create new Capturer object
        Dim capturer As New Capturer

        ' Merge WMV files that were previously created by the ByteScout Screen Capturer (must be of same size, FPS and type)
        capturer.JoinWMVFiles("Sample1.wmv", "Sample2.wmv", "output.wmv")

        Console.WriteLine("Files merged successfully!")

        ' Open output file with associated application
        Process.Start("output.wmv")

    End Sub

End Module
