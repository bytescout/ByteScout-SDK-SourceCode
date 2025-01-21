'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

if capturer.WebCamCount > 0 Then
 for i=0 to capturer.WebCamCount-1
  MsgBox "Webcamera device name = " & CStr(i) & ", Name: " & capturer.GetWebCamName (i)
 next
Else
 MsgBox "no web cam installed or plugged to this computer"
End If



Set Capturer = Nothing
