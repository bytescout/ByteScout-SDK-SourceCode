'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
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
