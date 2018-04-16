//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


 var capturer = WScript.CreateObject('BytescoutScreenCapturing.Capturer');

 // set output video file name to .WMV or .AVI
 capturer.OutputFileName = "EntireScreenCaptured.wmv";

 // set capturing type to the caScreen =3 to capture the entire screen
 capturer.CapturingType = 3;

 // output video width
 capturer.OutputWidth = 640;

 // output video height
 capturer.OutputHeight = 480;
 
 // uncomment to set Bytescout Lossless Video format output video compression method
 // do not forget to set file to .avi format if you use Video Codec Name
 // capturer.CurrentVideoCodecName = "Bytescout Lossless"; 

 // uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
 // capturer.CaptureTransparentControls = true;


 // run video capturing 
 capturer.Run();

	// IMPORTANT: if you want to check for some code if need to stop the recording then make sure you are 
	// using Thread.Sleep(1) inside the checking loop, so you have the loop like
	// Do 
	// Thread.Sleep(1) 
	// While StopButtonNotClicked


 // wait for 15seconds (15000 msec)
 WScript.Sleep(15000);

 // stop capturing
 capturer.Stop();

 // destroy Capturer object so the video will be saved into the disk
 capturer = null;

