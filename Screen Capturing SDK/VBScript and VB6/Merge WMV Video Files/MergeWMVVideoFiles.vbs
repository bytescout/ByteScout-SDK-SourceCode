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


' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' Merge WMV files that were previously created by the ByteScout Screen Capturer (must be of same size, FPS and type)
capturer.JoinWMVFiles "Sample1.wmv", "Sample2.wmv", "output.wmv"

MsgBox "Files merged successfully!"

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
