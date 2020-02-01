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


Imports BytescoutScreenCapturingLib

Public Class Form1

#Region "Fields"

    Private _capturer As BytescoutScreenCapturingLib.Capturer
    Private _converting As Boolean = False
    Private _paused As Boolean = False

#End Region

    ''' <summary>
    ''' Form load event handler
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _cmbQuality.DataSource = [Enum].GetValues(GetType(VideoQualityProfileType))
            _cmbQuality.SelectedIndex = 0

            _capturer = New BytescoutScreenCapturingLib.Capturer()
            _capturer.RegistrationName = "demo"
            _capturer.RegistrationKey = "demo"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Handle screen capture button click
    ''' </summary>
    Private Sub _btnScreenCapture_Click(sender As Object, e As EventArgs) Handles _btnScreenCapture.Click
        Try

            If _converting Then

                If _capturer.IsRunning Then
                    _capturer.[Stop]()
                End If

                StopCapturer()

                _btnPauseScreenCapture.Visible = False

            Else

                _capturer.OutputWidth = CInt(_numWidth.Value)
                _capturer.OutputHeight = CInt(_numHeight.Value)
                _capturer.FPS = CSng(_numFramerate.Value)

                _capturer.SetVideoQualityProfile(CType(_cmbQuality.SelectedItem, BytescoutScreenCapturingLib.VideoQualityProfileType))

                _lblBitrate.Text = String.Format("Bitrate: {0}[kbps], Wmv Quality: {1}, MinQuantizer: {2}, MaxQuantizer: {3}", _capturer.WMVVideoBitrate / 1000, _capturer.WmvVideoQuality, _capturer.WebmMinQuantizer, _capturer.WebmMaxQuantizer)

                _capturer.AnimateMouseClicks = True
                _capturer.AnimateMouseButtons = True
                _capturer.CapturingType = BytescoutScreenCapturingLib.CaptureAreaType.catScreen

                _capturer.OutputFileName = _txtOutputFile.Text

                _capturer.EncoderThreadsCount = CInt(_numEncodingThreads.Value)

                _capturer.AudioEnabled = False

                _capturer.Run()

                _converting = True
                _btnScreenCapture.Text = "Stop screen capture"

                _btnPauseScreenCapture.Visible = True
                _paused = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub _btnPauseScreenCapture_Click(sender As Object, e As EventArgs) Handles _btnPauseScreenCapture.Click
        If _paused Then
            _capturer.Run()
            _btnPauseScreenCapture.Text = "Pause Screen Capture"
            _paused = False
        Else
            _capturer.Pause()
            _btnPauseScreenCapture.Text = "Resume Screen Capture"
            _paused = True
        End If
    End Sub

    Private Sub StopCapturer()
        _converting = False
        _btnScreenCapture.Text = "Screen capture video"

        Process.Start(_txtOutputFile.Text)
    End Sub

End Class
