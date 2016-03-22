'*******************************************************************
'       ByteScout Image To Video SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Collections.Generic
Imports System.Text
Imports BytescoutImageToVideo

Public Class SlideOptions
	' Image file path
	Public ImageFile As String

	' Slide properties
	Public SlideDuration As Integer = 3000
	Public SlideRotation As RotationAngle = RotationAngle.raNone
	Public VisualEffect As VisualEffectType = VisualEffectType.veNone
	Public VisualEffectTransition As SlideEffectType = SlideEffectType.seNone
	Public VisualEffectDuration As Integer = 1000
	Public TransitionEffectBefore As TransitionEffectType = TransitionEffectType.teNone
	Public TransitionEffectBeforeDuration As Integer = 1000
	Public RandomTransitionEffectBefore As Boolean = True
	Public TransitionEffectAfter As TransitionEffectType = TransitionEffectType.teNone
	Public TransitionEffectAfterDuration As Integer = 1000
	Public RandomTransitionEffectAfter As Boolean = True
End Class
