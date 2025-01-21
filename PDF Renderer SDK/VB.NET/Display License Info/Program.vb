'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFRenderer

Class Program
    Friend Shared Sub Main(args As String())

        ' LicenseInfo can be retrieved by createing instance of any renderer class,
        ' Because all of them are derived from BaseRenderer
        Dim renderer As New RasterRenderer()
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Get License Info
        Dim licenseInfo = renderer.LicenseInfo

        ' Show Info
        Console.WriteLine("===============================")
        Console.WriteLine("======== License Info =========")
        Console.WriteLine("===============================" & Environment.NewLine)

        Console.WriteLine($"License type: {licenseInfo.LicenseType}")
        Console.WriteLine($"License limit type: {licenseInfo.LimitType}")
        Console.WriteLine($"Limit of license units: {licenseInfo.Limit}")
        Console.WriteLine($"License limit term: {licenseInfo.LimitTerm}")
        Console.WriteLine($"No of remaining license units: {licenseInfo.Remainder}")
        Console.WriteLine($"Update expires On: {licenseInfo.UpdatesExpireOn}")

        Console.ReadLine()

    End Sub
End Class
