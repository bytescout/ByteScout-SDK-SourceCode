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
using System.Text;
using BytescoutImageToVideo;

namespace ImageToVideoDemo
{
	public class SlideOptions
	{
		// Image file path
		public string ImageFile;

		// Slide properties
		public int SlideDuration = 1500;
		public RotationAngle SlideRotation = RotationAngle.raNone;
		public VisualEffectType VisualEffect = VisualEffectType.veNone;
		public SlideEffectType VisualEffectTransition = SlideEffectType.seNone;
		public int VisualEffectDuration = 1000;
		public TransitionEffectType TransitionEffectBefore = TransitionEffectType.teNone;
		public int TransitionEffectBeforeDuration = 1000;
		public bool RandomTransitionEffectBefore = true;
		public TransitionEffectType TransitionEffectAfter = TransitionEffectType.teNone;
		public int TransitionEffectAfterDuration = 1000;
		public bool RandomTransitionEffectAfter = true;
	}
}
