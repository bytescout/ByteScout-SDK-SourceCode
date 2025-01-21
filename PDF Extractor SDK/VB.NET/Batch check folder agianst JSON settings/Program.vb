'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports Bytescout.PDFExtractor
Imports System.IO
Imports Newtonsoft.Json

Class Program

    Friend Shared Sub Main(args As String())

        Try

            ' Get all settings VM
            Dim allSettings As SettingsVM = GetSettingsVM("settings.json")

            ' Create Bytescout.PDFExtractor.TextExtractor instance
            Dim extractor As New TextExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            For Each fileName As String In Directory.GetFiles("InputFiles")

                ' Load sample PDF document
                extractor.LoadDocumentFromFile(fileName)

                ' Enable regex search
                extractor.RegexSearch = True

                ' Get Number of pages PDF contains
                Dim pageCount As Int32 = extractor.GetPageCount()

                For iPage As Int32 = 0 To pageCount - 1

                    ' Loop through all search settings
                    For Each itmSearchSetting As Settings In allSettings.Settings

                        ' If found, then copy file to sub-category folder
                        If extractor.Find(iPage, itmSearchSetting.regex, False) Then

                            ' If Directory does Not exists, then create them
                            If (Not Directory.Exists($"{allSettings.MainFolderName}/{itmSearchSetting.category}")) Then
                                Directory.CreateDirectory($"{allSettings.MainFolderName}/{itmSearchSetting.category}")
                            End If

                            ' Copy File
                            File.Copy(fileName, $"{allSettings.MainFolderName}/{itmSearchSetting.category}/{Path.GetFileName(fileName)}", True)

                        End If
                    Next
                Next
            Next

            ' Cleanup
            extractor.Dispose()

        Catch ex As Exception

            Console.WriteLine("Error: " + ex.Message)

        End Try

        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")
        Console.ReadLine()

    End Sub

    Shared Function GetSettingsVM(ByVal settingsFileName As String) As SettingsVM

        Dim allJson As String = File.ReadAllText(settingsFileName)

        Return JsonConvert.DeserializeObject(Of SettingsVM)(allJson)

    End Function


End Class
