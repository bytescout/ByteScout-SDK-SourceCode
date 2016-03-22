namespace ScreenCapturing
{
	sealed partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.label1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbRecord = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsmiRectangularRegion2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMouseRegion2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiWindow2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFullScreen2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbRecordWithCam = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsmiRectangularRegion = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiMouseRegion = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFullScreen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbSettings = new System.Windows.Forms.ToolStripButton();
			this.tsbPlay = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.statusBar.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label1});
			this.statusBar.Location = new System.Drawing.Point(0, 85);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(417, 22);
			this.statusBar.SizingGrip = false;
			this.statusBar.TabIndex = 1;
			this.statusBar.Text = "statusStrip1";
			// 
			// label1
			// 
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(402, 17);
			this.label1.Spring = true;
			this.label1.Text = "Ready";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackgroundImage = global::ScreenCapturing.Properties.Resources.background;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRecord,
            this.tsbRecordWithCam,
            this.toolStripSeparator2,
            this.tsbPlay,
            this.toolStripSeparator1,
            this.tsbSettings});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(417, 86);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbRecord
			// 
			this.tsbRecord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRectangularRegion2,
            this.tsmiMouseRegion2,
            this.tsmiWindow2,
            this.tsmiFullScreen2});
			this.tsbRecord.Image = global::ScreenCapturing.Properties.Resources.record;
			this.tsbRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRecord.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
			this.tsbRecord.Name = "tsbRecord";
			this.tsbRecord.Size = new System.Drawing.Size(77, 83);
			this.tsbRecord.Text = "Record";
			this.tsbRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbRecord.ToolTipText = "Records a movie using the current settings";
			this.tsbRecord.Click += new System.EventHandler(this.tsbRecord_Click);
			// 
			// tsmiRectangularRegion2
			// 
			this.tsmiRectangularRegion2.Name = "tsmiRectangularRegion2";
			this.tsmiRectangularRegion2.Size = new System.Drawing.Size(211, 22);
			this.tsmiRectangularRegion2.Text = "Rectangular region";
			this.tsmiRectangularRegion2.Click += new System.EventHandler(this.tsmiRectangularRegion_Click);
			// 
			// tsmiMouseRegion2
			// 
			this.tsmiMouseRegion2.Name = "tsmiMouseRegion2";
			this.tsmiMouseRegion2.Size = new System.Drawing.Size(211, 22);
			this.tsmiMouseRegion2.Text = "Region around the Mouse";
			this.tsmiMouseRegion2.Click += new System.EventHandler(this.tsmiMouseRegion_Click);
			// 
			// tsmiWindow2
			// 
			this.tsmiWindow2.Name = "tsmiWindow2";
			this.tsmiWindow2.Size = new System.Drawing.Size(211, 22);
			this.tsmiWindow2.Text = "Window";
			this.tsmiWindow2.Visible = false;
			// 
			// tsmiFullScreen2
			// 
			this.tsmiFullScreen2.Name = "tsmiFullScreen2";
			this.tsmiFullScreen2.Size = new System.Drawing.Size(211, 22);
			this.tsmiFullScreen2.Text = "Full Screen";
			this.tsmiFullScreen2.Click += new System.EventHandler(this.tsmiFullScreen_Click);
			// 
			// tsbRecordWithCam
			// 
			this.tsbRecordWithCam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRectangularRegion,
            this.tsmiMouseRegion,
            this.tsmiWindow,
            this.tsmiFullScreen});
			this.tsbRecordWithCam.Image = global::ScreenCapturing.Properties.Resources.record_cam;
			this.tsbRecordWithCam.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbRecordWithCam.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
			this.tsbRecordWithCam.Name = "tsbRecordWithCam";
			this.tsbRecordWithCam.Size = new System.Drawing.Size(131, 83);
			this.tsbRecordWithCam.Text = "Record with webcam";
			this.tsbRecordWithCam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbRecordWithCam.ToolTipText = "Records a movie using the current settings";
			this.tsbRecordWithCam.Click += new System.EventHandler(this.tsbRecord_Click);
			// 
			// tsmiRectangularRegion
			// 
			this.tsmiRectangularRegion.Name = "tsmiRectangularRegion";
			this.tsmiRectangularRegion.Size = new System.Drawing.Size(211, 22);
			this.tsmiRectangularRegion.Text = "Rectangular region";
			this.tsmiRectangularRegion.Click += new System.EventHandler(this.tsmiRectangularRegion_Click);
			// 
			// tsmiMouseRegion
			// 
			this.tsmiMouseRegion.Name = "tsmiMouseRegion";
			this.tsmiMouseRegion.Size = new System.Drawing.Size(211, 22);
			this.tsmiMouseRegion.Text = "Region around the Mouse";
			this.tsmiMouseRegion.Click += new System.EventHandler(this.tsmiMouseRegion_Click);
			// 
			// tsmiWindow
			// 
			this.tsmiWindow.Name = "tsmiWindow";
			this.tsmiWindow.Size = new System.Drawing.Size(211, 22);
			this.tsmiWindow.Text = "Window";
			this.tsmiWindow.Visible = false;
			// 
			// tsmiFullScreen
			// 
			this.tsmiFullScreen.Name = "tsmiFullScreen";
			this.tsmiFullScreen.Size = new System.Drawing.Size(211, 22);
			this.tsmiFullScreen.Text = "Full Screen";
			this.tsmiFullScreen.Click += new System.EventHandler(this.tsmiFullScreen_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 86);
			// 
			// tsbSettings
			// 
			this.tsbSettings.Image = global::ScreenCapturing.Properties.Resources.gear;
			this.tsbSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSettings.Name = "tsbSettings";
			this.tsbSettings.Size = new System.Drawing.Size(68, 83);
			this.tsbSettings.Text = "Settings";
			this.tsbSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbSettings.ToolTipText = "Shows settings dialog";
			this.tsbSettings.Click += new System.EventHandler(this.tsbSettings_Click);
			// 
			// tsbPlay
			// 
			this.tsbPlay.Enabled = false;
			this.tsbPlay.Image = global::ScreenCapturing.Properties.Resources.play;
			this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbPlay.Name = "tsbPlay";
			this.tsbPlay.Size = new System.Drawing.Size(68, 83);
			this.tsbPlay.Text = "Play";
			this.tsbPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbPlay.ToolTipText = "Tries to play the recorded movie in default video player";
			this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 107);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Bytescout Screen Capturing";
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSettings;
		private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripDropDownButton tsbRecordWithCam;
        private System.Windows.Forms.ToolStripMenuItem tsmiRectangularRegion;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiFullScreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiMouseRegion;
		private System.Windows.Forms.ToolStripStatusLabel label1;
		private System.Windows.Forms.ToolStripDropDownButton tsbRecord;
		private System.Windows.Forms.ToolStripMenuItem tsmiRectangularRegion2;
		private System.Windows.Forms.ToolStripMenuItem tsmiMouseRegion2;
		private System.Windows.Forms.ToolStripMenuItem tsmiWindow2;
		private System.Windows.Forms.ToolStripMenuItem tsmiFullScreen2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}

