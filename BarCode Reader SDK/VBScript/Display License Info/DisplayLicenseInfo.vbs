'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' Create reader class instance
Set reader = CreateObject("Bytescout.BarCodeReader.Reader")
reader.RegistrationName = "demo"
reader.RegistrationKey = "demo"

' Set license Info
Set licenseInfo = reader.LicenseInfo

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

Set reader = Nothing
