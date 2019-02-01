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


Imports System.Drawing
Imports System.Windows.Forms
Imports BytescoutSWFToVideo

Public Partial Class Form1
	Inherits Form
	Private m_g As Graphics
	Private m_hdc As IntPtr
	Private swf As New SWFToVideoClass()

	Public Sub New()
		InitializeComponent()
	End Sub

    Private Sub buttonConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonConvert.Click
        If Not swf.IsRunning Then
            swf.SWFConversionMode = SWFConversionModeType.SWFWithLiveData
            swf.ConversionTimeOut = 15000

            swf.InputSWFFileName = "test.swf"
            swf.OutputVideoFileName = "test.wmv"
            swf.OutputWidth = 640
            swf.OutputHeight = 480

            swf.SetPreviewContext(m_hdc.ToInt32(), 0, 0, pictureBox1.Width, pictureBox1.Height, 30)
            swf.Run()
        End If
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        m_g = pictureBox1.CreateGraphics()
        m_hdc = m_g.GetHdc()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        m_g.ReleaseHdc(m_hdc)
        m_g.Dispose()

	' release resources
	System.Runtime.InteropServices.Marshal.ReleaseComObject(swf)
	swf = Nothing

    End Sub
End Class
