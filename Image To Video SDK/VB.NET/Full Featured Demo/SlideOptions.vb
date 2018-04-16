'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


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
