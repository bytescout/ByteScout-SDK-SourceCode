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
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using BytescoutImageToVideo;
using ImageToVideoDemo.Properties;

namespace ImageToVideoDemo
{
	public partial class MainForm : Form
	{
		public const int WM_APP = 0x8000;
		public const int WM_CONVERSION_PROGRESS = WM_APP + 1;

		private ImageToVideo _imageToVideo = new ImageToVideo();
		private string _outputFile = "";
		private Random _randomGenerator = new Random();

		public MainForm()
		{
			InitializeComponent();

			_imageToVideo.RegistrationName = "demo";
			_imageToVideo.RegistrationKey = "demo";

			Application.Idle += Application_Idle;
		}

		protected override void OnLoad(EventArgs e)
		{
			cbAutoFitImages.Checked = _imageToVideo.AutoFitImages;
			cbKeepAspectRatio.Checked = _imageToVideo.KeepAspectRatio;
			btnBackgroundColor.BackColor = ColorTranslator.FromOle((int) _imageToVideo.BackgroundColor);
			tbMovieWidth.Text = _imageToVideo.OutputWidth.ToString(CultureInfo.InvariantCulture);
			tbMovieHeight.Text = _imageToVideo.OutputHeight.ToString(CultureInfo.InvariantCulture);

			// Get list of available AVI audio codecs
			for (int i = 0; i < _imageToVideo.AudioCodecsCount; i++)
				cmbAviAudioCodecs.Items.Add(_imageToVideo.GetAudioCodecName(i));
			// Select current AVI audio codec
			cmbAviAudioCodecs.SelectedIndex = _imageToVideo.CurrentAudioCodec;

			// Get list of available AVI video codecs
			for (int i = 0; i < _imageToVideo.VideoCodecsCount; i++)
				cmbAviVideoCodecs.Items.Add(_imageToVideo.GetVideoCodecName(i));
			// Select current AVI video codec
			cmbAviVideoCodecs.SelectedIndex = _imageToVideo.CurrentVideoCodec;

			// Get list of available WMV audio codecs
			for (int i = 0; i < _imageToVideo.WMVAudioCodecsCount; i++)
				cmbWmvAudioCodecs.Items.Add(_imageToVideo.GetWMVAudioCodecName(i));
			// Select current WMV audio codec
			cmbWmvAudioCodecs.SelectedIndex = _imageToVideo.CurrentWMVAudioCodec;

			// Get list of available WMV video codecs
			for (int i = 0; i < _imageToVideo.WMVVideoCodecsCount; i++)
				cmbWmvVideoCodecs.Items.Add(_imageToVideo.GetWMVVideoCodecName(i));
			// Select current WMV video codec
			cmbWmvVideoCodecs.SelectedIndex = _imageToVideo.CurrentWMVVideoCodec;

			tbFPS.Text = _imageToVideo.FPS.ToString(CultureInfo.InvariantCulture);

			base.OnLoad(e);
		}

		private void Application_Idle(object sender, EventArgs e)
		{
			bool imageIsSelected = lvInputFiles.SelectedIndices.Count > 0;
			bool imagesAdded = lvInputFiles.Items.Count > 0;

			btnMoveUp.Enabled = imageIsSelected;
			btnMoveDown.Enabled = imageIsSelected;
			btnRemove.Enabled = imageIsSelected;
			btnRemoveAll.Enabled = imagesAdded;

			nudSlideDuration.Enabled = imageIsSelected;
			cmbSlideRotation.Enabled = imageIsSelected;
			cmbVisualEffect.Enabled = imageIsSelected;
			cmbVisualEffectTransition.Enabled = imageIsSelected;
			nudVisualEffectDuration.Enabled = imageIsSelected;
			cmbTransitionEffectBefore.Enabled = imageIsSelected && !cbTransitionEffectBeforeRandom.Checked;
			nudTransitionEffectBeforeDuration.Enabled = imageIsSelected;
			cbTransitionEffectBeforeRandom.Enabled = imageIsSelected;
			cmbTransitionEffectAfter.Enabled = imageIsSelected && !cbTransitionEffectAfterRandom.Checked;
			nudTransitionEffectAfterDuration.Enabled = imageIsSelected;
			cbTransitionEffectAfterRandom.Enabled = imageIsSelected;

			btnCreateMovie.Enabled = imagesAdded;
		}

		private void btnAddImage_Click(object sender, EventArgs e)
		{
			ListViewItem firstAddedItem = null;

			OpenFileDialog dlg = new OpenFileDialog();
			dlg.CheckFileExists = false;
			dlg.CheckPathExists = false;
			dlg.Filter =
				"Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.JPEG;*.PNG;*.BMP;|JPEG Files(*.JPG)|*.JPG;*.JPEG|PNG Files(*.PNG)|*.PNG|BMP Files(*.BMP)|*.BMP|All files (*.*)|*.*";
			dlg.Multiselect = true;
			dlg.SupportMultiDottedExtensions = true;
			dlg.Title = "Select Files";

			if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder))
				Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			dlg.InitialDirectory = Settings.Default.LastUsedFolder;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames[0]);

				Cursor = Cursors.WaitCursor;
				lvInputFiles.BeginUpdate();

				try
				{
					foreach (string file in dlg.FileNames)
					{
						SlideOptions slideOptions = new SlideOptions();
						slideOptions.ImageFile = file;

						ListViewItem item = new ListViewItem(Convert.ToString(lvInputFiles.Items.Count + 1));
						item.SubItems.Add(Path.GetFileName(file));
						item.Tag = slideOptions;
						
						lvInputFiles.Items.Add(item);

						if (firstAddedItem == null)
							firstAddedItem = item;
					}

					if (firstAddedItem != null)
					{
						lvInputFiles.SelectedItems.Clear();
						firstAddedItem.Selected = true;
						firstAddedItem.EnsureVisible();
					}
				}
				finally
				{
					lvInputFiles.EndUpdate();
					Cursor = Cursors.Default;
				}

				lvInputFiles.Select();
			}
		}

		private void btnAddFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dlg = new FolderBrowserDialog();

			dlg.Description = "Select Folder";
			dlg.ShowNewFolderButton = false;

			if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder))
				Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			dlg.SelectedPath = Settings.Default.LastUsedFolder;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.LastUsedFolder = dlg.SelectedPath;

				DirectoryInfo dir = new DirectoryInfo(dlg.SelectedPath);
				ListViewItem firstAddedItem = null;

				Cursor = Cursors.WaitCursor;
				Application.DoEvents();
				lvInputFiles.BeginUpdate();

				try
				{
					FileInfo[] files = dir.GetFiles();

					foreach (FileInfo file in files)
					{
						string ext = file.Extension.ToLower();

						if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp")
						{
							SlideOptions slideOptions = new SlideOptions();
							slideOptions.ImageFile = file.FullName;

							ListViewItem item = new ListViewItem(Convert.ToString(lvInputFiles.Items.Count + 1));
							item.SubItems.Add(Path.GetFileName(file.FullName));
							item.Tag = slideOptions;
							lvInputFiles.Items.Add(item);

							if (firstAddedItem == null)
								firstAddedItem = item;
						}
					}

					if (firstAddedItem != null)
					{
						lvInputFiles.SelectedItems.Clear();
						firstAddedItem.Selected = true;
						firstAddedItem.EnsureVisible();
					}
				}
				finally
				{
					lvInputFiles.EndUpdate();
					Cursor = Cursors.Default;
				}

				lvInputFiles.Select();
			}
		}

		private void btnMoveUp_Click(object sender, EventArgs e)
		{
			ListViewItem selectedItem = lvInputFiles.SelectedItems[0];
			int x = selectedItem.Index;

			if (x > 0)
			{
				lvInputFiles.BeginUpdate();

				try
				{
					lvInputFiles.Items.Remove(selectedItem);
					lvInputFiles.Items.Insert(x - 1, selectedItem);
					selectedItem.EnsureVisible();

					foreach (ListViewItem item in lvInputFiles.Items)
						item.SubItems[0].Text = Convert.ToString(item.Index + 1);
				}
				finally
				{
					lvInputFiles.EndUpdate();
				}
			}

			lvInputFiles.Select();
		}

		private void btnMoveDown_Click(object sender, EventArgs e)
		{
			ListViewItem selectedItem = lvInputFiles.SelectedItems[0];
			int x = selectedItem.Index;

			if (x < lvInputFiles.Items.Count - 1)
			{
				lvInputFiles.BeginUpdate();

				try
				{
					lvInputFiles.Items.Remove(selectedItem);
					lvInputFiles.Items.Insert(x + 1, selectedItem);
					selectedItem.EnsureVisible();

					foreach (ListViewItem item in lvInputFiles.Items)
						item.SubItems[0].Text = Convert.ToString(item.Index + 1);
				}
				finally
				{
					lvInputFiles.EndUpdate();
				}
			}

			lvInputFiles.Select();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			ListViewItem selectedItem = lvInputFiles.SelectedItems[0];
			int x = selectedItem.Index;

			lvInputFiles.BeginUpdate();

			try
			{
				lvInputFiles.Items.Remove(selectedItem);
				
				foreach (ListViewItem item in lvInputFiles.Items)
					item.SubItems[0].Text = Convert.ToString(item.Index + 1);
			}
			finally
			{
				lvInputFiles.EndUpdate();
			}

			if (x > 0)
				lvInputFiles.Items[x - 1].Selected = true;
			else if (x < lvInputFiles.Items.Count)
				lvInputFiles.Items[x].Selected = true;

			lvInputFiles.Select();
		}

		private void btnRemoveAll_Click(object sender, EventArgs e)
		{
			lvInputFiles.BeginUpdate();

			try
			{
				lvInputFiles.Items.Clear();
				_imageToVideo.Slides.Clear();
			}
			finally
			{
				lvInputFiles.EndUpdate();
			}
		}

		private void lvInputFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			nudSlideDuration.ValueChanged -= nudSlideDuration_ValueChanged;
			cmbSlideRotation.SelectedIndexChanged -= cmbSlideRotation_SelectedIndexChanged;
			cmbVisualEffect.SelectedIndexChanged -= cmbVisualEffect_SelectedIndexChanged;
			cmbVisualEffectTransition.SelectedIndexChanged -= cmbVisualEffectTransition_SelectedIndexChanged;
			nudVisualEffectDuration.ValueChanged -= nudVisualEffectDuration_ValueChanged;
			cmbTransitionEffectBefore.SelectedIndexChanged -= cmbTransitionEffectBefore_SelectedIndexChanged;
			nudTransitionEffectBeforeDuration.ValueChanged -= nudTransitionEffectBeforeDuration_ValueChanged;
			cbTransitionEffectBeforeRandom.CheckedChanged -= cbTransitionEffectBeforeRandom_CheckedChanged;
			cmbTransitionEffectAfter.SelectedIndexChanged -= cmbTransitionEffectAfter_SelectedIndexChanged;
			nudTransitionEffectAfterDuration.ValueChanged -= nudTransitionEffectAfterDuration_ValueChanged;
			cbTransitionEffectAfterRandom.CheckedChanged -= cbTransitionEffectAfterRandom_CheckedChanged;

			ListView.SelectedListViewItemCollection selectedItems = lvInputFiles.SelectedItems;

			if (selectedItems.Count > 0)
			{
				SlideOptions slideOptions = (SlideOptions) selectedItems[0].Tag;

				nudSlideDuration.Value = slideOptions.SlideDuration;
				cmbSlideRotation.SelectedIndex = (int) slideOptions.SlideRotation;
				cmbVisualEffect.SelectedIndex = (int) slideOptions.VisualEffect;
				cmbVisualEffectTransition.SelectedIndex = (int) slideOptions.VisualEffectTransition;
				nudVisualEffectDuration.Value = slideOptions.VisualEffectDuration;
				cmbTransitionEffectBefore.SelectedIndex = (int) slideOptions.TransitionEffectBefore + 1;
				nudTransitionEffectBeforeDuration.Value = slideOptions.TransitionEffectBeforeDuration;
				cbTransitionEffectBeforeRandom.Checked = slideOptions.RandomTransitionEffectBefore;
				cmbTransitionEffectAfter.SelectedIndex = (int) slideOptions.TransitionEffectAfter + 1;
				nudTransitionEffectAfterDuration.Value = slideOptions.TransitionEffectAfterDuration;
				cbTransitionEffectAfterRandom.Checked = slideOptions.RandomTransitionEffectAfter;

				nudSlideDuration.ValueChanged += nudSlideDuration_ValueChanged;
				cmbSlideRotation.SelectedIndexChanged += cmbSlideRotation_SelectedIndexChanged;
				cmbVisualEffect.SelectedIndexChanged += cmbVisualEffect_SelectedIndexChanged;
				cmbVisualEffectTransition.SelectedIndexChanged += cmbVisualEffectTransition_SelectedIndexChanged;
				nudVisualEffectDuration.ValueChanged += nudVisualEffectDuration_ValueChanged;
				cmbTransitionEffectBefore.SelectedIndexChanged += cmbTransitionEffectBefore_SelectedIndexChanged;
				nudTransitionEffectBeforeDuration.ValueChanged += nudTransitionEffectBeforeDuration_ValueChanged;
				cbTransitionEffectBeforeRandom.CheckedChanged += cbTransitionEffectBeforeRandom_CheckedChanged;
				cmbTransitionEffectAfter.SelectedIndexChanged += cmbTransitionEffectAfter_SelectedIndexChanged;
				nudTransitionEffectAfterDuration.ValueChanged += nudTransitionEffectAfterDuration_ValueChanged;
				cbTransitionEffectAfterRandom.CheckedChanged += cbTransitionEffectAfterRandom_CheckedChanged;
			}
		}

		private void nudSlideDuration_ValueChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.SlideDuration = (int) nudSlideDuration.Value;
		}

		private void cmbSlideRotation_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.SlideRotation = (RotationAngle) cmbSlideRotation.SelectedIndex;
		}

		private void cmbVisualEffect_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.VisualEffect = (VisualEffectType) cmbVisualEffect.SelectedIndex;
		}

		private void cmbVisualEffectTransition_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.VisualEffectTransition = (SlideEffectType) cmbVisualEffectTransition.SelectedIndex;
		}

		private void nudVisualEffectDuration_ValueChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.VisualEffectDuration = (int) nudVisualEffectDuration.Value;
		}

		private void cmbTransitionEffectBefore_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.TransitionEffectBefore = (TransitionEffectType) (cmbTransitionEffectBefore.SelectedIndex - 1);
		}

		private void nudTransitionEffectBeforeDuration_ValueChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.TransitionEffectBeforeDuration = (int) nudTransitionEffectBeforeDuration.Value;
		}

		private void cmbTransitionEffectAfter_SelectedIndexChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.TransitionEffectAfter = (TransitionEffectType) (cmbTransitionEffectAfter.SelectedIndex - 1);
		}

		private void nudTransitionEffectAfterDuration_ValueChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.TransitionEffectAfterDuration = (int) nudTransitionEffectAfterDuration.Value;
		}

		void cbTransitionEffectBeforeRandom_CheckedChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.RandomTransitionEffectBefore = cbTransitionEffectBeforeRandom.Checked;
		}

		void cbTransitionEffectAfterRandom_CheckedChanged(object sender, EventArgs e)
		{
			SlideOptions slideOptions = (SlideOptions) lvInputFiles.SelectedItems[0].Tag;
			slideOptions.RandomTransitionEffectAfter = cbTransitionEffectAfterRandom.Checked;
		}

		private void btnVideoCodecProps_Click(object sender, EventArgs e)
		{
			try
			{
				_imageToVideo.ShowVideoCodecSettingsDialogModal(Handle.ToInt32());
			}
			catch (Exception)
			{
			}
		}

		private void cmbWmvAudioCodecs_SelectedIndexChanged(object sender, EventArgs e)
		{
			_imageToVideo.CurrentWMVAudioCodecName = cmbWmvAudioCodecs.SelectedItem.ToString();

			cmbWmvAudioFormats.Items.Clear();

			// Get list of available WMV audio formats
			for (int i = 0; i < _imageToVideo.WMVAudioFormatCount; i++)
				cmbWmvAudioFormats.Items.Add(_imageToVideo.GetWMVAudioFormatDescription(i));
			// Select current WMV audio format
			cmbWmvAudioFormats.SelectedIndex = _imageToVideo.CurrentWMVAudioFormat;
		}

		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			Settings.Default.Save();

			base.OnClosing(e);
		}

		private void btnBackgroundImageBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.CheckFileExists = false;
			dlg.CheckPathExists = false;
			dlg.Multiselect = false;
			dlg.Filter = "Image Files(*.JPG;*.PNG;*.BMP)|*.JPG;*.JPEG;*.PNG;*.BMP;|JPEG Files(*.JPG)|*.JPG;*.JPEG|PNG Files(*.PNG)|*.PNG|BMP Files(*.BMP)|*.BMP|All files (*.*)|*.*";
			dlg.Multiselect = true;
			dlg.SupportMultiDottedExtensions = true;
			dlg.Title = "Select background image";

			if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder))
				Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			dlg.InitialDirectory = Settings.Default.LastUsedFolder;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames[0]);
				tbBackgroundImage.Text = dlg.FileName;
			}
		}

		private void btnAudioTrackBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.CheckFileExists = false;
			dlg.CheckPathExists = false;
			dlg.Multiselect = false;
			dlg.Filter = "Sound Files(*.MP3;*.WAV)|*.MP3;*.WAV|MP3 Files(*.MP3)|*.MP3|WAV Files(*.WAV)|*.WAV|All files (*.*)|*.*";
			dlg.Multiselect = true;
			dlg.SupportMultiDottedExtensions = true;
			dlg.Title = "Select background image";

			if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder))
				Settings.Default.LastUsedFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

			dlg.InitialDirectory = Settings.Default.LastUsedFolder;

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				Settings.Default.LastUsedFolder = Path.GetDirectoryName(dlg.FileNames[0]);
				tbAudioTrack.Text = dlg.FileName;
			}
		}

		private void btnBackgroundColor_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = btnBackgroundColor.BackColor;

			if (colorDialog.ShowDialog() == DialogResult.OK)
				btnBackgroundColor.BackColor = colorDialog.Color;
		}

		protected override void WndProc(ref Message m)
		{
			if (m.HWnd == Handle && m.Msg == WM_CONVERSION_PROGRESS)
			{
				// Show progress
				int progress = m.WParam.ToInt32();
				toolStripProgressBar1.Value = progress;

				// Finished!
				if (progress == 100 && _imageToVideo.IsRunning)
				{
					// wait a bit the converter finished and released resources
					while (_imageToVideo.IsRunning)
						Thread.Sleep(200);

					toolStripStatusLabel1.Text = "Saved to file " + _outputFile;
					btnCreateMovie.Text = "Create Movie";
					btnCreateMovie.Image = Resources.film;
					toolStripProgressBar1.Value = 0;

					// Open folder containing the generated file
					Process.Start("explorer.exe", "/select,\"" + _outputFile + "\"");

					// Play generated file
					if (cbPlayGeneratedFile.Checked)
					{
						try
						{
							Process process = new Process();
							process.StartInfo.FileName = _outputFile;
							process.StartInfo.UseShellExecute = true;
							process.Start();
						}
						catch
						{
						}
					}
				}
			}

			base.WndProc(ref m);
		}

		private void btnCreateMovie_Click(object sender, EventArgs e)
		{
			if (!_imageToVideo.IsRunning)
			{
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.Filter = "WMV files (*.wmv)|*.wmv|AVI files (*.avi)|*.avi|All files (*.*)|*.*";

				if (tabControl2.SelectedIndex == 0)
				{
					dlg.DefaultExt = "*.wmv";
					dlg.FilterIndex = 1;
				}
				else
				{
					dlg.DefaultExt = "*.avi";
					dlg.FilterIndex = 2;
				}

				dlg.FileName = "movie";
				dlg.Title = "Save generated video as";

				if (String.IsNullOrEmpty(Settings.Default.LastUsedFolder2))
					Settings.Default.LastUsedFolder2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

				dlg.InitialDirectory = Settings.Default.LastUsedFolder2;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					Settings.Default.LastUsedFolder2 = Path.GetDirectoryName(dlg.FileName);

					int intValue;
					float floatValue;

					_imageToVideo.AutoFitImages = cbAutoFitImages.Checked;
					_imageToVideo.KeepAspectRatio = cbKeepAspectRatio.Checked;
					_imageToVideo.BackgroundColor = (uint) ColorTranslator.ToOle(btnBackgroundColor.BackColor);

					if (tbBackgroundImage.Text.Length > 0)
						_imageToVideo.SetBackgroundPictureFileName(tbBackgroundImage.Text);

					if (int.TryParse(tbMovieWidth.Text, out intValue))
						_imageToVideo.OutputWidth = intValue;
					if (int.TryParse(tbMovieHeight.Text, out intValue))
						_imageToVideo.OutputHeight = intValue;

					if (tbAudioTrack.Text.Length > 0)
						_imageToVideo.ExternalAudioTrackFromFileName = tbAudioTrack.Text;

					_imageToVideo.CurrentAudioCodec = cmbAviAudioCodecs.SelectedIndex;
					_imageToVideo.CurrentVideoCodec = cmbAviVideoCodecs.SelectedIndex;
					_imageToVideo.CurrentWMVAudioCodec = cmbWmvAudioCodecs.SelectedIndex;
					_imageToVideo.CurrentWMVAudioFormat = cmbWmvAudioFormats.SelectedIndex;
					_imageToVideo.CurrentWMVVideoCodec = cmbWmvVideoCodecs.SelectedIndex;

					if (int.TryParse(tbBitrate.Text, out intValue))
						_imageToVideo.WMVVideoBitrate = intValue * 1024;

					if (float.TryParse(tbFPS.Text, out floatValue))
						_imageToVideo.FPS = floatValue;

					_outputFile = dlg.FileName;
					_imageToVideo.OutputVideoFileName = _outputFile;
					_imageToVideo.SetProgressNotifyWindow(Handle.ToInt32(), WM_CONVERSION_PROGRESS, 0);

					_imageToVideo.Slides.Clear();

					foreach (ListViewItem item in lvInputFiles.Items)
					{
						SlideOptions slideInfo = (SlideOptions) item.Tag;
						Slide slide = _imageToVideo.AddImageFromFileName(slideInfo.ImageFile);
						slide.Duration = slideInfo.SlideDuration;
						slide.RotationAngle = slideInfo.SlideRotation;
						slide.VisualEffect = slideInfo.VisualEffect;
						slide.Effect = slideInfo.VisualEffectTransition;
						slide.EffectDuration = slideInfo.VisualEffectDuration;
						slide.InEffect = slideInfo.RandomTransitionEffectBefore ? GetRandomEffect() : slideInfo.TransitionEffectBefore;
						slide.InEffectDuration = slideInfo.TransitionEffectBeforeDuration;
						slide.OutEffect = slideInfo.RandomTransitionEffectAfter ? GetRandomEffect() : slideInfo.TransitionEffectAfter;
						slide.OutEffectDuration = slideInfo.TransitionEffectAfterDuration;
					}

					_imageToVideo.Run();
					
					toolStripStatusLabel1.Text = "Generating video...";
					btnCreateMovie.Text = "Stop";
					btnCreateMovie.Image = Resources.stop;
				}
			}
			else
			{
				// Stop generation
				_imageToVideo.Stop();
				
				// wait a bit the converter finished and released resources
				while (_imageToVideo.IsRunning)
					Thread.Sleep(200);
				
				toolStripStatusLabel1.Text = "Interrupted by user.";
				btnCreateMovie.Text = "Create Movie";
				btnCreateMovie.Image = Resources.film;
				toolStripProgressBar1.Value = 0;
			}
		}

		private TransitionEffectType GetRandomEffect()
		{
			return (TransitionEffectType) _randomGenerator.Next(0, 140);
		}

		private void linkVisitSDKHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = @"http://bytescout.com/products/developer/imagetovideosdk/imagetovideosdk.html";
				process.StartInfo.UseShellExecute = true;
				process.Start();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}
	}
}
