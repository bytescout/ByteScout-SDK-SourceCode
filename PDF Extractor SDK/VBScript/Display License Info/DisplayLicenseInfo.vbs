'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' LicenseInfo can be retrieved by createing instance of any extractor class,
' Because all of them are derived from BaseExtractor
Set extractor = CreateObject("Bytescout.PDFExtractor.TextExtractor")
extractor.RegistrationName = "demo"
extractor.RegistrationKey = "demo"

' Set license Info
Set licenseInfo = extractor.LicenseInfo

outputMsg = "===============================" + vbCRLF
outputMsg = outputMsg + "======== License Info =========" + vbCRLF
outputMsg = outputMsg + "===============================" + vbCRLF

outputMsg = outputMsg + "License type: " & licenseInfo.LicenseType & vbCRLF
outputMsg = outputMsg + "License limit type: " & licenseInfo.LimitType & vbCRLF
outputMsg = outputMsg + "Limit of license units: " & licenseInfo.Limit & vbCRLF
outputMsg = outputMsg + "License limit term: " & licenseInfo.LimitTerm & vbCRLF
outputMsg = outputMsg + "No of remaining license units: " & licenseInfo.Remainder & vbCRLF
outputMsg = outputMsg + "Update expires On: " & licenseInfo.UpdatesExpireOn & vbCRLF

outputMsg = outputMsg + "===============================" + vbCRLF

MsgBox outputMsg

Set extractor = Nothing
