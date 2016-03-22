//*******************************************************************
//       ByteScout Image To Video SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

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
