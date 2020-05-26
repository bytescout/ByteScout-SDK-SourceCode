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


Imports Bytescout.PDFExtractor

Module Module1

    Sub Main()

        ' LicenseInfo can be retrieved by createing instance of any extractor class,
        ' Because all of them are derived from BaseExtractor
        Dim extractor As New TextExtractor()
        extractor.RegistrationName = "demo"
        extractor.RegistrationKey = "demo"

        ' Get License Info
        Dim licenseInfo = extractor.LicenseInfo

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

End Module
