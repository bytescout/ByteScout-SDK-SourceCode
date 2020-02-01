'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System.Windows.Forms

Imports BytescoutSWFToVideo

Public Partial Class Form1
	Inherits Form
	Public Const WM_APP As Integer = &H8000
	Public Const WM_CONVERSION_PROGRESS As Integer = WM_APP + 1

	Private swf As New SWFToVideoClass()

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub buttonConvert_Click(sender As Object, e As EventArgs)
		If Not swf.IsRunning Then
			swf.SWFConversionMode = SWFConversionModeType.SWFAnimation
		        swf.ConversionTimeOut = 5000

		' you may calculate output video duration using information about the the source swf movie
		' WARNING #1: this method to calculate the output video duration is not working for movies with dynamic scenes 
		' and interactive scripts as in these movies it is not possible to calculate the precise duration of the movie 
		' WARNING #2: you should set the input swf or flv filename (or url) before this calculation

		' So the movie duration is calculated as the following:
		' as swf frame count (number of frames in the swf) / movieFPS (frames per second defined in swf)
		' and then multiplied by 1000 (as we are setting the .ConverstionTimeout in milliseconds)
		' as the following (uncomment if you want to set the length of the output video to the same as the original swf)
		' or as the following source code (uncomment to enable):

		' swf.ConversionTimeout = 1000 * (swf.FrameCount / swf.MovieFPS)


			swf.InputSWFFileName = "test.swf"
			swf.OutputVideoFileName = "test.wmv"

			swf.SetProgressNotifyWindow(Handle.ToInt32(), WM_CONVERSION_PROGRESS, 0)

			swf.Run()
		End If
	End Sub

	Protected Overloads Overrides Sub WndProc(ByRef m As Message)
		If m.HWnd = Handle AndAlso m.Msg = WM_CONVERSION_PROGRESS Then
			progressBar1.Value = m.WParam.ToInt32()
		End If

		MyBase.WndProc(m)
	End Sub
End Class
