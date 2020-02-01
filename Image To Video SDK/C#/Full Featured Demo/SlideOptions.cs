//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
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
