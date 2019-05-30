'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.Threading
Imports System.Diagnostics

Imports BytescoutScreenCapturingLib
' import bytescout screen capturing activex object 


' NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
' try to do the following:
' 1) remove the reference to the SDK by View - Solution Explorer
' then click on References, select Bytescout... reference name and right-click it and select Remove
' 2) To re-add click on the menu: Project - Add Reference
' 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
' 4) Select it and click "Add" 
' 5) Recompile the application 
' Note: if you need to run on both x64 and x86 then please make sure you have set "Embed Interop Types" to True for this reference

Class Program
	Friend Shared Sub Main(args As String())
		Dim capturer As New Capturer()
		' create new screen capturer object
		capturer.CapturingType = CaptureAreaType.catScreen
		' set capturing area type to catScreen to capture whole screen
		' Set webcamera device by name (.CurrentWebCamname property)
		' or set it by index using .CurrentWebCam property
		capturer.CurrentWebCam = 0

		' Set rectangle to show overlaying video from webcam into the rectangle 160x120 (starting with left point at 10, 10)
		capturer.SetWebCamVideoRectangle(10, 10, 160, 120)

		' Enable webcam overlaying capture device
		capturer.AddWebCamVideo = True

		capturer.OutputFileName = "ScreenWithWebCameraCaptured.wmv"
		' set output video filename to .WMV or .AVI file
		' set output video width and height
		capturer.OutputWidth = 640
		capturer.OutputHeight = 480

	' // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	' // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	' capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2


		capturer.Run()

	' IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	' using Thread.Sleep(1) inside the checking loop, so you have the loop like
	' Do 
	' Thread.Sleep(1) 
	' While StopButtonNotClicked

		' run screen video capturing 
		Thread.Sleep(10000)
		' wait for 10 seconds
		capturer.[Stop]()
		' stop video capturing
		Process.Start("ScreenWithWebCameraCaptured.wmv")
	End Sub
End Class
