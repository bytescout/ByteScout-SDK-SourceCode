'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' Merge AVI files that were previously created by the ByteScout Screen Capturer (must be of same size, FPS and type)
capturer.JoinAVIFiles "Sample1.avi", "Sample2.avi", "output.avi"

MsgBox "Files merged successfully!"

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
