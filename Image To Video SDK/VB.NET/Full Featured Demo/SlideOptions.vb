'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


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
