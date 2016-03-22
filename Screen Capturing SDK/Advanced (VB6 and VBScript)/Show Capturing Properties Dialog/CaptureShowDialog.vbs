'*******************************************************************
'       ByteScout Screen Capturing SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' create video capturer activex object
Set capturer = CreateObject("BytescoutScreenCapturing.Capturer")

' set output video file name
capturer.OutputFileName = "CapturedOutput.avi" 

' show capturing properties dialog
capturer.ShowCaptureFilterPropertiesDialog (0)


' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
