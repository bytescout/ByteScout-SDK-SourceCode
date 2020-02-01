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


Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports BytescoutImageToVideo
Imports ImageToVideoDemo.Properties

Public Partial Class MainForm
	Inherits Form
	Public Const WM_APP As Integer = &H8000
	Public Const WM_CONVERSION_PROGRESS As Integer = WM_APP + 1

	Private _imageToVideo As New ImageToVideo()
	Private _outputFile As String = ""
	Private _randomGenerator As New Random()

	Public Sub New()
		InitializeComponent()

		_imageToVideo.RegistrationName = "demo"
		_imageToVideo.RegistrationKey = "demo"

		AddHandler Application.Idle, AddressOf Application_Idle
	End Sub

	Protected Overrides Sub OnLoad(e As EventArgs)
		cbAutoFitImages.Checked = _imageToVideo.AutoFitImages
		cbKeepAspectRatio.Checked = _imageToVideo.KeepAspectRatio
		btnBackgroundColor.BackColor = ColorTranslator.FromOle(CInt(_imageToVideo.BackgroundColor))
		tbMovieWidth.Text = _imageToVideo.OutputWidth.ToString(CultureInfo.InvariantCulture)
		tbMovieHeight.Text = _imageToVideo.OutputHeight.ToString(CultureInfo.InvariantCulture)

		' Get list of available AVI audio codecs
		For i As Integer = 0 To _imageToVideo.AudioCodecsCount - 1
			cmbAviAudioCodecs.Items.Add(_imageToVideo.GetAudioCodecName(i))
		Next
		' Select current AVI audio codec
		cmbAviAudioCodecs.SelectedIndex = _imageToVideo.CurrentAudioCodec

		' Get list of available AVI video codecs
		For i As Integer = 0 To _imageToVideo.VideoCodecsCount - 1
			cmbAviVideoCodecs.Items.Add(_imageToVideo.GetVideoCodecName(i))
		Next
		' Select current AVI video codec
		cmbAviVideoCodecs.SelectedIndex = _imageToVideo.CurrentVideoCodec

		' Get list of available WMV audio codecs
		For i As Integer = 0 To _imageToVideo.WMVAudioCodecsCount - 1
			cmbWmvAudioCodecs.Items.Add(_imageToVideo.GetWMVAudioCodecName(i))
		Next
		' Select current WMV audio codec
		cmbWmvAudioCodecs.SelectedIndex = _imageToVideo.CurrentWMVAudioCodec

		' Get list of available WMV video codecs
		For i As Integer = 0 To _imageToVideo.WMVVideoCodecsCount - 1
			cmbWmvVideoCodecs.Items.Add(_imageToVideo.GetWMVVideoCodecName(i))
		Next
		' Select current WMV video codec
		cmbWmvVideoCodecs.SelectedIndex = _imageToVideo.CurrentWMVVideoCodec

		tbFPS.Text = _imageToVideo.FPS.ToString(CultureInfo.InvariantCulture)

		MyBase.OnLoad(e)
	End Sub

	Private Sub Application_Idle(sender As Object, e As EventArgs)
		Dim imageIsSelected As Boolean = lvInputFiles.SelectedIndices.Count > 0
		Dim imagesAdded As Boolean = lvInputFiles.Items.Count > 0

		btnMoveUp.Enabled = imageIsSelected
		btnMoveDown.Enabled = imageIsSelected
		btnRemove.Enabled = imageIsSelected
		btnRemoveAll.Enabled = imagesAdded

		nudSlideDuration.Enabled = imageIsSelected
		cmbSlideRotation.Enabled = imageIsSelected
		cmbVisualEffect.Enabled = imageIsSelected
		cmbVisualEffectTransition.Enabled = imageIsSelected
		nudVisualEffectDuration.Enabled = imageIsSelected
		cmbTransitionEffectBefore.Enabled = imageIsSelected AndAlso Not cbTransitionEffectBeforeRandom.Checked
		nudTransitionEffectBeforeDuration.Enabled = imageIsSelected
		cbTransitionEffectBeforeRandom.Enabled = imageIsSelected
		cmbTransitionEffectAfter.Enabled = imageIsSelected AndAlso Not cbTransitionEffectAfterRandom.Checked
		nudTransitionEffectAfterDuration.Enabled = imageIsSelected
		cbTransitionEffectAfterRandom.Enabled = imageIsSelected

		btnCreateMovie.Enabled = imagesAdded
	End Sub

	Private Sub btnAddImage_Click(sender As Object, e As EventArgs)
		Dim firstAddedItem As ListViewItem = Nothing

		Dim dlg As New OpenFileDialog()
		dlg.CheckFileExists = False
		dlg.CheckPathExists = False
		dlg.Filter = "Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.JPEG;*.PNG;*.BMP;|JPEG Files(*.JPG)|*.JPG;*.JPEG|PNG Files(*.PNG)|*.PNG|BMP Files(*.BMP)|*.BMP|All files (*.*)|*.*"
		dlg.Multiselect = True
		dlg.SupportMultiDottedExtensions = True
		dlg.Title = "Select Files"

		If String.IsNullOrEmpty(Settings.Default.LastUsedFolder) Then
			Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		End If

		dlg.InitialDirectory = Settings.Default.LastUsedFolder

		If dlg.ShowDialog() = DialogResult.OK Then
			Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames(0))

			Cursor = Cursors.WaitCursor
			lvInputFiles.BeginUpdate()

			Try
				For Each file As String In dlg.FileNames
					Dim slideOptions As New SlideOptions()
					slideOptions.ImageFile = file

					Dim item As New ListViewItem(Convert.ToString(lvInputFiles.Items.Count + 1))
					item.SubItems.Add(Path.GetFileName(file))
					item.Tag = slideOptions

					lvInputFiles.Items.Add(item)

					If firstAddedItem Is Nothing Then
						firstAddedItem = item
					End If
				Next

				If firstAddedItem IsNot Nothing Then
					lvInputFiles.SelectedItems.Clear()
					firstAddedItem.Selected = True
					firstAddedItem.EnsureVisible()
				End If
			Finally
				lvInputFiles.EndUpdate()
				Cursor = Cursors.Default
			End Try

			lvInputFiles.Select()
		End If
	End Sub

	Private Sub btnAddFolder_Click(sender As Object, e As EventArgs)
		Dim dlg As New FolderBrowserDialog()

		dlg.Description = "Select Folder"
		dlg.ShowNewFolderButton = False

		If String.IsNullOrEmpty(Settings.Default.LastUsedFolder) Then
			Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		End If

		dlg.SelectedPath = Settings.Default.LastUsedFolder

		If dlg.ShowDialog() = DialogResult.OK Then
			Settings.Default.LastUsedFolder = dlg.SelectedPath

			Dim dir As New DirectoryInfo(dlg.SelectedPath)
			Dim firstAddedItem As ListViewItem = Nothing

			Cursor = Cursors.WaitCursor
			Application.DoEvents()
			lvInputFiles.BeginUpdate()

			Try
				Dim files As FileInfo() = dir.GetFiles()

				For Each file As FileInfo In files
					Dim ext As String = file.Extension.ToLower()

					If ext = ".jpg" OrElse ext = ".jpeg" OrElse ext = ".png" OrElse ext = ".bmp" Then
						Dim slideOptions As New SlideOptions()
						slideOptions.ImageFile = file.FullName

						Dim item As New ListViewItem(Convert.ToString(lvInputFiles.Items.Count + 1))
						item.SubItems.Add(Path.GetFileName(file.FullName))
						item.Tag = slideOptions
						lvInputFiles.Items.Add(item)

						If firstAddedItem Is Nothing Then
							firstAddedItem = item
						End If
					End If
				Next

				If firstAddedItem IsNot Nothing Then
					lvInputFiles.SelectedItems.Clear()
					firstAddedItem.Selected = True
					firstAddedItem.EnsureVisible()
				End If
			Finally
				lvInputFiles.EndUpdate()
				Cursor = Cursors.Default
			End Try

			lvInputFiles.Select()
		End If
	End Sub

	Private Sub btnMoveUp_Click(sender As Object, e As EventArgs)
		Dim selectedItem As ListViewItem = lvInputFiles.SelectedItems(0)
		Dim x As Integer = selectedItem.Index

		If x > 0 Then
			lvInputFiles.BeginUpdate()

			Try
				lvInputFiles.Items.Remove(selectedItem)
				lvInputFiles.Items.Insert(x - 1, selectedItem)
				selectedItem.EnsureVisible()

				For Each item As ListViewItem In lvInputFiles.Items
					item.SubItems(0).Text = Convert.ToString(item.Index + 1)
				Next
			Finally
				lvInputFiles.EndUpdate()
			End Try
		End If

		lvInputFiles.Select()
	End Sub

	Private Sub btnMoveDown_Click(sender As Object, e As EventArgs)
		Dim selectedItem As ListViewItem = lvInputFiles.SelectedItems(0)
		Dim x As Integer = selectedItem.Index

		If x < lvInputFiles.Items.Count - 1 Then
			lvInputFiles.BeginUpdate()

			Try
				lvInputFiles.Items.Remove(selectedItem)
				lvInputFiles.Items.Insert(x + 1, selectedItem)
				selectedItem.EnsureVisible()

				For Each item As ListViewItem In lvInputFiles.Items
					item.SubItems(0).Text = Convert.ToString(item.Index + 1)
				Next
			Finally
				lvInputFiles.EndUpdate()
			End Try
		End If

		lvInputFiles.Select()
	End Sub

	Private Sub btnRemove_Click(sender As Object, e As EventArgs)
		Dim selectedItem As ListViewItem = lvInputFiles.SelectedItems(0)
		Dim x As Integer = selectedItem.Index

		lvInputFiles.BeginUpdate()

		Try
			lvInputFiles.Items.Remove(selectedItem)

			For Each item As ListViewItem In lvInputFiles.Items
				item.SubItems(0).Text = Convert.ToString(item.Index + 1)
			Next
		Finally
			lvInputFiles.EndUpdate()
		End Try

		If x > 0 Then
			lvInputFiles.Items(x - 1).Selected = True
		ElseIf x < lvInputFiles.Items.Count Then
			lvInputFiles.Items(x).Selected = True
		End If

		lvInputFiles.Select()
	End Sub

	Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs)
		lvInputFiles.BeginUpdate()

		Try
			lvInputFiles.Items.Clear()
			_imageToVideo.Slides.Clear()
		Finally
			lvInputFiles.EndUpdate()
		End Try
	End Sub

	Private Sub lvInputFiles_SelectedIndexChanged(sender As Object, e As EventArgs)
		RemoveHandler nudSlideDuration.ValueChanged, AddressOf nudSlideDuration_ValueChanged
		RemoveHandler cmbSlideRotation.SelectedIndexChanged, AddressOf cmbSlideRotation_SelectedIndexChanged
		RemoveHandler cmbVisualEffect.SelectedIndexChanged, AddressOf cmbVisualEffect_SelectedIndexChanged
		RemoveHandler cmbVisualEffectTransition.SelectedIndexChanged, AddressOf cmbVisualEffectTransition_SelectedIndexChanged
		RemoveHandler nudVisualEffectDuration.ValueChanged, AddressOf nudVisualEffectDuration_ValueChanged
		RemoveHandler cmbTransitionEffectBefore.SelectedIndexChanged, AddressOf cmbTransitionEffectBefore_SelectedIndexChanged
		RemoveHandler nudTransitionEffectBeforeDuration.ValueChanged, AddressOf nudTransitionEffectBeforeDuration_ValueChanged
		RemoveHandler cbTransitionEffectBeforeRandom.CheckedChanged, AddressOf cbTransitionEffectBeforeRandom_CheckedChanged
		RemoveHandler cmbTransitionEffectAfter.SelectedIndexChanged, AddressOf cmbTransitionEffectAfter_SelectedIndexChanged
		RemoveHandler nudTransitionEffectAfterDuration.ValueChanged, AddressOf nudTransitionEffectAfterDuration_ValueChanged
		RemoveHandler cbTransitionEffectAfterRandom.CheckedChanged, AddressOf cbTransitionEffectAfterRandom_CheckedChanged

		Dim selectedItems As ListView.SelectedListViewItemCollection = lvInputFiles.SelectedItems

		If selectedItems.Count > 0 Then
			Dim slideOptions As SlideOptions = DirectCast(selectedItems(0).Tag, SlideOptions)

			nudSlideDuration.Value = slideOptions.SlideDuration
			cmbSlideRotation.SelectedIndex = CInt(slideOptions.SlideRotation)
			cmbVisualEffect.SelectedIndex = CInt(slideOptions.VisualEffect)
			cmbVisualEffectTransition.SelectedIndex = CInt(slideOptions.VisualEffectTransition)
			nudVisualEffectDuration.Value = slideOptions.VisualEffectDuration
			cmbTransitionEffectBefore.SelectedIndex = CInt(slideOptions.TransitionEffectBefore) + 1
			nudTransitionEffectBeforeDuration.Value = slideOptions.TransitionEffectBeforeDuration
			cbTransitionEffectBeforeRandom.Checked = slideOptions.RandomTransitionEffectBefore
			cmbTransitionEffectAfter.SelectedIndex = CInt(slideOptions.TransitionEffectAfter) + 1
			nudTransitionEffectAfterDuration.Value = slideOptions.TransitionEffectAfterDuration
			cbTransitionEffectAfterRandom.Checked = slideOptions.RandomTransitionEffectAfter

			AddHandler nudSlideDuration.ValueChanged, AddressOf nudSlideDuration_ValueChanged
			AddHandler cmbSlideRotation.SelectedIndexChanged, AddressOf cmbSlideRotation_SelectedIndexChanged
			AddHandler cmbVisualEffect.SelectedIndexChanged, AddressOf cmbVisualEffect_SelectedIndexChanged
			AddHandler cmbVisualEffectTransition.SelectedIndexChanged, AddressOf cmbVisualEffectTransition_SelectedIndexChanged
			AddHandler nudVisualEffectDuration.ValueChanged, AddressOf nudVisualEffectDuration_ValueChanged
			AddHandler cmbTransitionEffectBefore.SelectedIndexChanged, AddressOf cmbTransitionEffectBefore_SelectedIndexChanged
			AddHandler nudTransitionEffectBeforeDuration.ValueChanged, AddressOf nudTransitionEffectBeforeDuration_ValueChanged
			AddHandler cbTransitionEffectBeforeRandom.CheckedChanged, AddressOf cbTransitionEffectBeforeRandom_CheckedChanged
			AddHandler cmbTransitionEffectAfter.SelectedIndexChanged, AddressOf cmbTransitionEffectAfter_SelectedIndexChanged
			AddHandler nudTransitionEffectAfterDuration.ValueChanged, AddressOf nudTransitionEffectAfterDuration_ValueChanged
			AddHandler cbTransitionEffectAfterRandom.CheckedChanged, AddressOf cbTransitionEffectAfterRandom_CheckedChanged
		End If
	End Sub

	Private Sub nudSlideDuration_ValueChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.SlideDuration = CInt(Math.Truncate(nudSlideDuration.Value))
	End Sub

	Private Sub cmbSlideRotation_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.SlideRotation = DirectCast(cmbSlideRotation.SelectedIndex, RotationAngle)
	End Sub

	Private Sub cmbVisualEffect_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.VisualEffect = DirectCast(cmbVisualEffect.SelectedIndex, VisualEffectType)
	End Sub

	Private Sub cmbVisualEffectTransition_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.VisualEffectTransition = DirectCast(cmbVisualEffectTransition.SelectedIndex, SlideEffectType)
	End Sub

	Private Sub nudVisualEffectDuration_ValueChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.VisualEffectDuration = CInt(Math.Truncate(nudVisualEffectDuration.Value))
	End Sub

	Private Sub cmbTransitionEffectBefore_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.TransitionEffectBefore = DirectCast(cmbTransitionEffectBefore.SelectedIndex - 1, TransitionEffectType)
	End Sub

	Private Sub nudTransitionEffectBeforeDuration_ValueChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.TransitionEffectBeforeDuration = CInt(Math.Truncate(nudTransitionEffectBeforeDuration.Value))
	End Sub

	Private Sub cmbTransitionEffectAfter_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.TransitionEffectAfter = DirectCast(cmbTransitionEffectAfter.SelectedIndex - 1, TransitionEffectType)
	End Sub

	Private Sub nudTransitionEffectAfterDuration_ValueChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.TransitionEffectAfterDuration = CInt(Math.Truncate(nudTransitionEffectAfterDuration.Value))
	End Sub

	Private Sub cbTransitionEffectBeforeRandom_CheckedChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.RandomTransitionEffectBefore = cbTransitionEffectBeforeRandom.Checked
	End Sub

	Private Sub cbTransitionEffectAfterRandom_CheckedChanged(sender As Object, e As EventArgs)
		Dim slideOptions As SlideOptions = DirectCast(lvInputFiles.SelectedItems(0).Tag, SlideOptions)
		slideOptions.RandomTransitionEffectAfter = cbTransitionEffectAfterRandom.Checked
	End Sub

	Private Sub btnVideoCodecProps_Click(sender As Object, e As EventArgs)
		Try
			_imageToVideo.ShowVideoCodecSettingsDialogModal(Handle.ToInt32())
		Catch generatedExceptionName As Exception
		End Try
	End Sub

	Private Sub cmbWmvAudioCodecs_SelectedIndexChanged(sender As Object, e As EventArgs)
		_imageToVideo.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString()

		cmbWmvAudioFormats.Items.Clear()

		' Get list of available WMV audio formats
		For i As Integer = 0 To _imageToVideo.WMVAudioFormatCount - 1
			cmbWmvAudioFormats.Items.Add(_imageToVideo.GetWMVAudioFormatDescription(i))
		Next
		' Select current WMV audio format
		cmbWmvAudioFormats.SelectedIndex = _imageToVideo.CurrentWMVAudioFormat
	End Sub

	Protected Overrides Sub OnClosing(e As System.ComponentModel.CancelEventArgs)
		Settings.Default.Save()

		MyBase.OnClosing(e)
	End Sub

	Private Sub btnBackgroundImageBrowse_Click(sender As Object, e As EventArgs)
		Dim dlg As New OpenFileDialog()
		dlg.CheckFileExists = False
		dlg.CheckPathExists = False
		dlg.Multiselect = False
		dlg.Filter = "Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.JPEG;*.PNG;*.BMP;|JPEG Files(*.JPG)|*.JPG;*.JPEG|PNG Files(*.PNG)|*.PNG|BMP Files(*.BMP)|*.BMP|All files (*.*)|*.*"
		dlg.Multiselect = True
		dlg.SupportMultiDottedExtensions = True
		dlg.Title = "Select background image"

		If String.IsNullOrEmpty(Settings.Default.LastUsedFolder) Then
			Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		End If

		dlg.InitialDirectory = Settings.Default.LastUsedFolder

		If dlg.ShowDialog() = DialogResult.OK Then
			Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames(0))
			tbBackgroundImage.Text = dlg.FileName
		End If
	End Sub

	Private Sub btnAudioTrackBrowse_Click(sender As Object, e As EventArgs)
		Dim dlg As New OpenFileDialog()
		dlg.CheckFileExists = False
		dlg.CheckPathExists = False
		dlg.Multiselect = False
		dlg.Filter = "Sound Files(*.MP3;*.WAV)|*.MP3;*.WAV|MP3 Files(*.MP3)|*.MP3|WAV Files(*.WAV)|*.WAV|All files (*.*)|*.*"
		dlg.Multiselect = True
		dlg.SupportMultiDottedExtensions = True
		dlg.Title = "Select background image"

		If String.IsNullOrEmpty(Settings.Default.LastUsedFolder) Then
			Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
		End If

		dlg.InitialDirectory = Settings.Default.LastUsedFolder

		If dlg.ShowDialog() = DialogResult.OK Then
			Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames(0))
			tbAudioTrack.Text = dlg.FileName
		End If
	End Sub

	Private Sub btnBackgroundColor_Click(sender As Object, e As EventArgs)
		Dim colorDialog As New ColorDialog()
		colorDialog.Color = btnBackgroundColor.BackColor

		If colorDialog.ShowDialog() = DialogResult.OK Then
			btnBackgroundColor.BackColor = colorDialog.Color
		End If
	End Sub

	Protected Overrides Sub WndProc(ByRef m As Message)
		If m.HWnd = Handle AndAlso m.Msg = WM_CONVERSION_PROGRESS Then
			' Show progress
			Dim progress As Integer = m.WParam.ToInt32()
			toolStripProgressBar1.Value = progress

			' Finished!
			If progress = 100 AndAlso _imageToVideo.IsRunning Then
				' wait a bit the converter finished and released resources
				While _imageToVideo.IsRunning
					Thread.Sleep(200)
				End While

				toolStripStatusLabel1.Text = "Saved to file " & _outputFile
				btnCreateMovie.Text = "Create Movie"
				btnCreateMovie.Image = My.Resources.film
				toolStripProgressBar1.Value = 0

				' Open folder containing the generated file
				Process.Start("explorer.exe", "/select,""" & _outputFile & """")

				' Play generated file
				If cbPlayGeneratedFile.Checked Then
					Try
						Dim process As New Process()
						process.StartInfo.FileName = _outputFile
						process.StartInfo.UseShellExecute = True
						process.Start()
					Catch
					End Try
				End If
			End If
		End If

		MyBase.WndProc(m)
	End Sub

	Private Sub btnCreateMovie_Click(sender As Object, e As EventArgs)
		If Not _imageToVideo.IsRunning Then
			Dim dlg As New SaveFileDialog()
			dlg.Filter = "WMV files (*.wmv)|*.wmv|AVI files (*.avi)|*.avi|All files (*.*)|*.*"

			If tabControl2.SelectedIndex = 0 Then
				dlg.DefaultExt = "*.wmv"
				dlg.FilterIndex = 1
			Else
				dlg.DefaultExt = "*.avi"
				dlg.FilterIndex = 2
			End If

			dlg.FileName = "movie"
			dlg.Title = "Save generated video as"

			If String.IsNullOrEmpty(Settings.Default.LastUsedFolder2) Then
				Settings.Default.LastUsedFolder2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
			End If

			dlg.InitialDirectory = Settings.Default.LastUsedFolder2

			If dlg.ShowDialog() = DialogResult.OK Then
				Settings.Default.LastUsedFolder2 = Path.GetDirectoryName(dlg.FileName)

				Dim intValue As Integer
				Dim floatValue As Single

				_imageToVideo.AutoFitImages = cbAutoFitImages.Checked
				_imageToVideo.KeepAspectRatio = cbKeepAspectRatio.Checked
				_imageToVideo.BackgroundColor = CUInt(ColorTranslator.ToOle(btnBackgroundColor.BackColor))

				If tbBackgroundImage.Text.Length > 0 Then
					_imageToVideo.SetBackgroundPictureFileName(tbBackgroundImage.Text)
				End If

				If Integer.TryParse(tbMovieWidth.Text, intValue) Then
					_imageToVideo.OutputWidth = intValue
				End If
				If Integer.TryParse(tbMovieHeight.Text, intValue) Then
					_imageToVideo.OutputHeight = intValue
				End If

				If tbAudioTrack.Text.Length > 0 Then
					_imageToVideo.ExternalAudioTrackFromFileName = tbAudioTrack.Text
				End If

				_imageToVideo.CurrentAudioCodec = cmbAviAudioCodecs.SelectedIndex
				_imageToVideo.CurrentVideoCodec = cmbAviVideoCodecs.SelectedIndex
				_imageToVideo.CurrentWMVAudioCodec = cmbWmvAudioCodecs.SelectedIndex
				_imageToVideo.CurrentWMVAudioFormat = cmbWmvAudioFormats.SelectedIndex
				_imageToVideo.CurrentWMVVideoCodec = cmbWmvVideoCodecs.SelectedIndex

				If Integer.TryParse(tbBitrate.Text, intValue) Then
					_imageToVideo.WMVVideoBitrate = intValue * 1024
				End If

				If Single.TryParse(tbFPS.Text, floatValue) Then
					_imageToVideo.FPS = floatValue
				End If

				_outputFile = dlg.FileName
				_imageToVideo.OutputVideoFileName = _outputFile
				_imageToVideo.SetProgressNotifyWindow(Handle.ToInt32(), WM_CONVERSION_PROGRESS, 0)

				_imageToVideo.Slides.Clear()

				For Each item As ListViewItem In lvInputFiles.Items
					Dim slideInfo As SlideOptions = DirectCast(item.Tag, SlideOptions)
					Dim slide As Slide = _imageToVideo.AddImageFromFileName(slideInfo.ImageFile)
					slide.Duration = slideInfo.SlideDuration
					slide.RotationAngle = slideInfo.SlideRotation
					slide.VisualEffect = slideInfo.VisualEffect
					slide.Effect = slideInfo.VisualEffectTransition
					slide.EffectDuration = slideInfo.VisualEffectDuration
					slide.InEffect = CType(IIf(slideInfo.RandomTransitionEffectBefore, GetRandomEffect(), slideInfo.TransitionEffectBefore), TransitionEffectType)
					slide.InEffectDuration = slideInfo.TransitionEffectBeforeDuration
					slide.OutEffect = CType(IIf(slideInfo.RandomTransitionEffectAfter, GetRandomEffect(), slideInfo.TransitionEffectAfter), TransitionEffectType)
					slide.OutEffectDuration = slideInfo.TransitionEffectAfterDuration
				Next

				_imageToVideo.Run()

				toolStripStatusLabel1.Text = "Generating video..."
				btnCreateMovie.Text = "Stop"
				btnCreateMovie.Image = My.Resources._stop
			End If
		Else
			' Stop generation
			_imageToVideo.Stop()

			' wait a bit the converter finished and released resources
			While _imageToVideo.IsRunning
				Thread.Sleep(200)
			End While

			toolStripStatusLabel1.Text = "Interrupted by user."
			btnCreateMovie.Text = "Create Movie"
			btnCreateMovie.Image = My.Resources.film
			toolStripProgressBar1.Value = 0
		End If
	End Sub

	Private Function GetRandomEffect() As TransitionEffectType
		Return DirectCast(_randomGenerator.Next(0, 140), TransitionEffectType)
	End Function

	Private Sub linkVisitSDKHome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		Try
			Dim process As New Process()
			process.StartInfo.FileName = "http://bytescout.com/products/developer/imagetovideosdk/imagetovideosdk.html"
			process.StartInfo.UseShellExecute = True
			process.Start()
		Catch exception As Exception
			MessageBox.Show(exception.Message)
		End Try
	End Sub
End Class
