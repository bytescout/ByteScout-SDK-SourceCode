'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
'*******************************************************************************************'


Imports System.Windows.Forms

Imports BytescoutImageToVideo

Public Partial Class Form1
	Inherits Form
	Public Const WM_APP As Integer = &H8000
	Public Const WM_CONVERSION_PROGRESS As Integer = WM_APP + 1

	Private converter As New ImageToVideo()

	Public Sub New()
		InitializeComponent()

		converter.RegistrationName = "demo"
		converter.RegistrationKey = "demo"

	End Sub

    Private Sub buttonConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonConvert.Click
        If Not converter.IsRunning Then

            ' Set default "in" effect for slides (you can also set effects for each single slide)
            converter.Slides.DefaultSlideInEffect = 1 ' teFadeIn (1) - fades in effect for slides transition
            converter.Slides.DefaultSlideInEffectDuration = 500 ' 500 msec for in effect

            ' Add images and set the duration for every slide
            Dim slide As Slide
            slide = converter.AddImageFromFileName("..\..\..\..\slide1.jpg")
            slide.Duration = 3000 ' 3000ms = 3s
            slide = converter.AddImageFromFileName("..\..\..\..\slide2.jpg")
            slide.Duration = 3000
            slide = converter.AddImageFromFileName("..\..\..\..\slide3.jpg")
            slide.Duration = 3000

            ' Set output video size
            converter.OutputWidth = 400
            converter.OutputHeight = 300

            ' Set output video file name
            converter.OutputVideoFileName = "result.wmv"

            ' Set progress notification target window
            converter.SetProgressNotifyWindow(Handle.ToInt32(), WM_CONVERSION_PROGRESS, 0)

            ' Run the conversion
            converter.Run()
        End If
    End Sub

    Protected Overloads Overrides Sub WndProc(ByRef m As Message)

        If m.HWnd = Handle AndAlso m.Msg = WM_CONVERSION_PROGRESS Then
            progressBar1.Value = m.WParam.ToInt32()
        End If

        MyBase.WndProc(m)
    End Sub
End Class
