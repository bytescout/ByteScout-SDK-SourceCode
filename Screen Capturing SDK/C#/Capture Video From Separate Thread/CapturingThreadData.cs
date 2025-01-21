//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using BytescoutScreenCapturingLib;


// NOTE: if you are getting error like "invalid image" related to loading the SDK's dll then 
// try to do the following:
// 1) remove the reference to the SDK by View - Solution Explorer
// then click on References, select Bytescout... reference name and right-click it and select Remove
// 2) To re-add click on the menu: Project - Add Reference
// 3) In "Add Reference" dialog switch to "COM" tab and find Bytescout...
// 4) Select it and click "Add" 
// 5) Recompile the application 



namespace CaptureFromSeparateThread
{
	public class CapturingThreadData
	{
		public CaptureAreaType CaptureType;
		public String TempFile;
        public Rectangle CaptureRectangle = new Rectangle(0, 0, 320, 240);

		public bool Success;
		public string ErrorText;

	    public AutoResetEvent StartOrResumeEvent = new AutoResetEvent(false); // event signalling to start or resume the recodring
	    public AutoResetEvent PauseEvent = new AutoResetEvent(false); // event signalling to pause the recodring
	    public AutoResetEvent StopEvent = new AutoResetEvent(false); // event signalling to stop the recording 
	}
}
