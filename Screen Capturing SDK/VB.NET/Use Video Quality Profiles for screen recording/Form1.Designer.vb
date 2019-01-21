<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._btnPauseScreenCapture = New System.Windows.Forms.Button()
        Me._btnScreenCapture = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me._numEncodingThreads = New System.Windows.Forms.NumericUpDown()
        Me._lblBitrate = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me._cmbQuality = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me._numFramerate = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me._numHeight = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me._numWidth = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me._txtOutputFile = New System.Windows.Forms.TextBox()
        CType(Me._numEncodingThreads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._numFramerate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._numWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_btnPauseScreenCapture
        '
        Me._btnPauseScreenCapture.Location = New System.Drawing.Point(201, 202)
        Me._btnPauseScreenCapture.Margin = New System.Windows.Forms.Padding(4)
        Me._btnPauseScreenCapture.Name = "_btnPauseScreenCapture"
        Me._btnPauseScreenCapture.Size = New System.Drawing.Size(163, 28)
        Me._btnPauseScreenCapture.TabIndex = 34
        Me._btnPauseScreenCapture.Text = "Pause Screen Capture"
        Me._btnPauseScreenCapture.UseVisualStyleBackColor = True
        Me._btnPauseScreenCapture.Visible = False
        '
        '_btnScreenCapture
        '
        Me._btnScreenCapture.Location = New System.Drawing.Point(15, 202)
        Me._btnScreenCapture.Margin = New System.Windows.Forms.Padding(4)
        Me._btnScreenCapture.Name = "_btnScreenCapture"
        Me._btnScreenCapture.Size = New System.Drawing.Size(163, 28)
        Me._btnScreenCapture.TabIndex = 33
        Me._btnScreenCapture.Text = "Screen capture video"
        Me._btnScreenCapture.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(13, 147)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(192, 17)
        Me.label6.TabIndex = 32
        Me.label6.Text = "Number of encoding threads:"
        '
        '_numEncodingThreads
        '
        Me._numEncodingThreads.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me._numEncodingThreads.Location = New System.Drawing.Point(213, 144)
        Me._numEncodingThreads.Margin = New System.Windows.Forms.Padding(4)
        Me._numEncodingThreads.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me._numEncodingThreads.Name = "_numEncodingThreads"
        Me._numEncodingThreads.Size = New System.Drawing.Size(127, 22)
        Me._numEncodingThreads.TabIndex = 31
        Me._numEncodingThreads.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        '_lblBitrate
        '
        Me._lblBitrate.Location = New System.Drawing.Point(348, 147)
        Me._lblBitrate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me._lblBitrate.Name = "_lblBitrate"
        Me._lblBitrate.Size = New System.Drawing.Size(408, 51)
        Me._lblBitrate.TabIndex = 30
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(512, 78)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(52, 17)
        Me.label5.TabIndex = 29
        Me.label5.Text = "Quality"
        '
        '_cmbQuality
        '
        Me._cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbQuality.FormattingEnabled = True
        Me._cmbQuality.Location = New System.Drawing.Point(516, 98)
        Me._cmbQuality.Margin = New System.Windows.Forms.Padding(4)
        Me._cmbQuality.Name = "_cmbQuality"
        Me._cmbQuality.Size = New System.Drawing.Size(240, 24)
        Me._cmbQuality.TabIndex = 28
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(348, 78)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(73, 17)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Framerate"
        '
        '_numFramerate
        '
        Me._numFramerate.DecimalPlaces = 2
        Me._numFramerate.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me._numFramerate.Location = New System.Drawing.Point(348, 98)
        Me._numFramerate.Margin = New System.Windows.Forms.Padding(4)
        Me._numFramerate.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me._numFramerate.Name = "_numFramerate"
        Me._numFramerate.Size = New System.Drawing.Size(160, 22)
        Me._numFramerate.TabIndex = 26
        Me._numFramerate.ThousandsSeparator = True
        Me._numFramerate.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(180, 78)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 17)
        Me.label3.TabIndex = 25
        Me.label3.Text = "Height"
        '
        '_numHeight
        '
        Me._numHeight.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me._numHeight.Location = New System.Drawing.Point(180, 98)
        Me._numHeight.Margin = New System.Windows.Forms.Padding(4)
        Me._numHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me._numHeight.Name = "_numHeight"
        Me._numHeight.Size = New System.Drawing.Size(160, 22)
        Me._numHeight.TabIndex = 24
        Me._numHeight.Value = New Decimal(New Integer() {768, 0, 0, 0})
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 78)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 17)
        Me.label2.TabIndex = 23
        Me.label2.Text = "Width"
        '
        '_numWidth
        '
        Me._numWidth.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me._numWidth.Location = New System.Drawing.Point(12, 98)
        Me._numWidth.Margin = New System.Windows.Forms.Padding(4)
        Me._numWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me._numWidth.Name = "_numWidth"
        Me._numWidth.Size = New System.Drawing.Size(160, 22)
        Me._numWidth.TabIndex = 22
        Me._numWidth.Value = New Decimal(New Integer() {1024, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 9)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 17)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Output file"
        '
        '_txtOutputFile
        '
        Me._txtOutputFile.Location = New System.Drawing.Point(12, 33)
        Me._txtOutputFile.Margin = New System.Windows.Forms.Padding(4)
        Me._txtOutputFile.Name = "_txtOutputFile"
        Me._txtOutputFile.Size = New System.Drawing.Size(300, 22)
        Me._txtOutputFile.TabIndex = 20
        Me._txtOutputFile.Text = "output.wmv"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 251)
        Me.Controls.Add(Me._btnPauseScreenCapture)
        Me.Controls.Add(Me._btnScreenCapture)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me._numEncodingThreads)
        Me.Controls.Add(Me._lblBitrate)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me._cmbQuality)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me._numFramerate)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me._numHeight)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me._numWidth)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._txtOutputFile)
        Me.Name = "Form1"
        Me.Text = "Screen Capture Video"
        CType(Me._numEncodingThreads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._numFramerate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._numWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents _btnPauseScreenCapture As Button
    Private WithEvents _btnScreenCapture As Button
    Private WithEvents label6 As Label
    Private WithEvents _numEncodingThreads As NumericUpDown
    Private WithEvents _lblBitrate As Label
    Private WithEvents label5 As Label
    Private WithEvents _cmbQuality As ComboBox
    Private WithEvents label4 As Label
    Private WithEvents _numFramerate As NumericUpDown
    Private WithEvents label3 As Label
    Private WithEvents _numHeight As NumericUpDown
    Private WithEvents label2 As Label
    Private WithEvents _numWidth As NumericUpDown
    Private WithEvents label1 As Label
    Private WithEvents _txtOutputFile As TextBox
End Class
