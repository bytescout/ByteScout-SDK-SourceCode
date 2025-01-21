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

' Merge WMV files that were previously created by the ByteScout Screen Capturer (must be of same size, FPS and type)
capturer.JoinWMVFiles "Sample1.wmv", "Sample2.wmv", "output.wmv"

MsgBox "Files merged successfully!"

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
