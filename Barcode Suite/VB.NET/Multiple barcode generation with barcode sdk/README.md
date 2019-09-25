## multiple barcode generation with barcode sdk in VB.NET and ByteScout Barcode Suite

### Learn to code multiple barcode generation with barcode sdk in VB.NET: How-To tutorial

These source code samples are assembled by their programming language and functions they use. ByteScout Barcode Suite was made to help with multiple barcode generation with barcode sdk in VB.NET. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

VB.NET code snippet like this for ByteScout Barcode Suite works best when you need to quickly implement multiple barcode generation with barcode sdk in your VB.NET application. To use multiple barcode generation with barcode sdk in your VB.NET project or application just copy & paste the code and then run your app! Enjoy writing a code with ready-to-use sample VB.NET codes to add multiple barcode generation with barcode sdk functions using ByteScout Barcode Suite in VB.NET.

On our website you may get trial version of ByteScout Barcode Suite for free. Source code samples are included to help you with your VB.NET application.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****Form1.Designer.vb:**
    
```
Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.progressBar = New System.Windows.Forms.ProgressBar
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.label33 = New System.Windows.Forms.Label
        Me.label28 = New System.Windows.Forms.Label
        Me.tbValueTemplate = New System.Windows.Forms.TextBox
        Me.nudValueStartAt = New System.Windows.Forms.NumericUpDown
        Me.label24 = New System.Windows.Forms.Label
        Me.cmbValueDigits = New System.Windows.Forms.ComboBox
        Me.nudValueEndAt = New System.Windows.Forms.NumericUpDown
        Me.nudValueStepBy = New System.Windows.Forms.NumericUpDown
        Me.label30 = New System.Windows.Forms.Label
        Me.label31 = New System.Windows.Forms.Label
        Me.label32 = New System.Windows.Forms.Label
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.nudCounterStartAt = New System.Windows.Forms.NumericUpDown
        Me.label25 = New System.Windows.Forms.Label
        Me.label34 = New System.Windows.Forms.Label
        Me.label22 = New System.Windows.Forms.Label
        Me.cmbCounterDigits = New System.Windows.Forms.ComboBox
        Me.tbFileNameTemplate = New System.Windows.Forms.TextBox
        Me.label26 = New System.Windows.Forms.Label
        Me.nudCounterStepBy = New System.Windows.Forms.NumericUpDown
        Me.label27 = New System.Windows.Forms.Label
        Me.btnGenerate = New System.Windows.Forms.Button
        Me.label29 = New System.Windows.Forms.Label
        Me.cmbImageFormat = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.cmbBarcodeType = New System.Windows.Forms.ComboBox
        Me.groupBox3.SuspendLayout()
        CType(Me.nudValueStartAt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudValueEndAt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudValueStepBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.nudCounterStartAt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCounterStepBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'progressBar
        '
        Me.progressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar.Location = New System.Drawing.Point(175, 395)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(213, 10)
        Me.progressBar.TabIndex = 22
        Me.progressBar.Visible = False
        '
        'groupBox3
        '
        Me.groupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox3.Controls.Add(Me.label33)
        Me.groupBox3.Controls.Add(Me.label28)
        Me.groupBox3.Controls.Add(Me.tbValueTemplate)
        Me.groupBox3.Controls.Add(Me.nudValueStartAt)
        Me.groupBox3.Controls.Add(Me.label24)
        Me.groupBox3.Controls.Add(Me.cmbValueDigits)
        Me.groupBox3.Controls.Add(Me.nudValueEndAt)
        Me.groupBox3.Controls.Add(Me.nudValueStepBy)
        Me.groupBox3.Controls.Add(Me.label30)
        Me.groupBox3.Controls.Add(Me.label31)
        Me.groupBox3.Controls.Add(Me.label32)
        Me.groupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.groupBox3.Location = New System.Drawing.Point(12, 43)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(376, 160)
        Me.groupBox3.TabIndex = 18
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Barcode Value"
        '
        'label33
        '
        Me.label33.AutoSize = True
        Me.label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label33.Location = New System.Drawing.Point(6, 52)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(47, 13)
        Me.label33.TabIndex = 18
        Me.label33.Text = "Counter:"
        '
        'label28
        '
        Me.label28.AutoSize = True
        Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label28.Location = New System.Drawing.Point(6, 23)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(51, 13)
        Me.label28.TabIndex = 17
        Me.label28.Text = "Template"
        '
        'tbValueTemplate
        '
        Me.tbValueTemplate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbValueTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbValueTemplate.Location = New System.Drawing.Point(106, 20)
        Me.tbValueTemplate.Name = "tbValueTemplate"
        Me.tbValueTemplate.Size = New System.Drawing.Size(264, 20)
        Me.tbValueTemplate.TabIndex = 16
        Me.tbValueTemplate.Text = "[N]"
        '
        'nudValueStartAt
        '
        Me.nudValueStartAt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.nudValueStartAt.Location = New System.Drawing.Point(106, 49)
        Me.nudValueStartAt.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.nudValueStartAt.Name = "nudValueStartAt"
        Me.nudValueStartAt.Size = New System.Drawing.Size(63, 20)
        Me.nudValueStartAt.TabIndex = 0
        Me.nudValueStartAt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label24
        '
        Me.label24.AutoSize = True
        Me.label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label24.Location = New System.Drawing.Point(59, 53)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(41, 13)
        Me.label24.TabIndex = 5
        Me.label24.Text = "Start at"
        '
        'cmbValueDigits
        '
        Me.cmbValueDigits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbValueDigits.FormattingEnabled = True
        Me.cmbValueDigits.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbValueDigits.Location = New System.Drawing.Point(106, 127)
        Me.cmbValueDigits.Name = "cmbValueDigits"
        Me.cmbValueDigits.Size = New System.Drawing.Size(63, 21)
        Me.cmbValueDigits.TabIndex = 3
        Me.cmbValueDigits.Text = "3"
        '
        'nudValueEndAt
        '
        Me.nudValueEndAt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.nudValueEndAt.Location = New System.Drawing.Point(106, 101)
        Me.nudValueEndAt.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.nudValueEndAt.Name = "nudValueEndAt"
        Me.nudValueEndAt.Size = New System.Drawing.Size(63, 20)
        Me.nudValueEndAt.TabIndex = 2
        Me.nudValueEndAt.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'nudValueStepBy
        '
        Me.nudValueStepBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.nudValueStepBy.Location = New System.Drawing.Point(106, 75)
        Me.nudValueStepBy.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.nudValueStepBy.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudValueStepBy.Name = "nudValueStepBy"
        Me.nudValueStepBy.Size = New System.Drawing.Size(63, 20)
        Me.nudValueStepBy.TabIndex = 1
        Me.nudValueStepBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label30.Location = New System.Drawing.Point(59, 130)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(33, 13)
        Me.label30.TabIndex = 9
        Me.label30.Text = "Digits"
        '
        'label31
        '
        Me.label31.AutoSize = True
        Me.label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label31.Location = New System.Drawing.Point(59, 105)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(38, 13)
        Me.label31.TabIndex = 12
        Me.label31.Text = "End at"
        '
        'label32
        '
        Me.label32.AutoSize = True
        Me.label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label32.Location = New System.Drawing.Point(59, 79)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(43, 13)
        Me.label32.TabIndex = 8
        Me.label32.Text = "Step by"
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.nudCounterStartAt)
        Me.groupBox2.Controls.Add(Me.label25)
        Me.groupBox2.Controls.Add(Me.label34)
        Me.groupBox2.Controls.Add(Me.label22)
        Me.groupBox2.Controls.Add(Me.cmbCounterDigits)
        Me.groupBox2.Controls.Add(Me.tbFileNameTemplate)
        Me.groupBox2.Controls.Add(Me.label26)
        Me.groupBox2.Controls.Add(Me.nudCounterStepBy)
        Me.groupBox2.Controls.Add(Me.label27)
        Me.groupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(12, 210)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(376, 131)
        Me.groupBox2.TabIndex = 16
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "File Name"
        '
        'nudCounterStartAt
        '
        Me.nudCounterStartAt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.nudCounterStartAt.Location = New System.Drawing.Point(106, 47)
        Me.nudCounterStartAt.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.nudCounterStartAt.Name = "nudCounterStartAt"
        Me.nudCounterStartAt.Size = New System.Drawing.Size(63, 20)
        Me.nudCounterStartAt.TabIndex = 0
        Me.nudCounterStartAt.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label25
        '
        Me.label25.AutoSize = True
        Me.label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label25.Location = New System.Drawing.Point(59, 51)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(41, 13)
        Me.label25.TabIndex = 5
        Me.label25.Text = "Start at"
        '
        'label34
        '
        Me.label34.AutoSize = True
        Me.label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label34.Location = New System.Drawing.Point(6, 50)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(47, 13)
        Me.label34.TabIndex = 19
        Me.label34.Text = "Counter:"
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label22.Location = New System.Drawing.Point(6, 23)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(51, 13)
        Me.label22.TabIndex = 19
        Me.label22.Text = "Template"
        '
        'cmbCounterDigits
        '
        Me.cmbCounterDigits.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbCounterDigits.FormattingEnabled = True
        Me.cmbCounterDigits.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbCounterDigits.Location = New System.Drawing.Point(106, 99)
        Me.cmbCounterDigits.Name = "cmbCounterDigits"
        Me.cmbCounterDigits.Size = New System.Drawing.Size(63, 21)
        Me.cmbCounterDigits.TabIndex = 3
        Me.cmbCounterDigits.Text = "3"
        '
        'tbFileNameTemplate
        '
        Me.tbFileNameTemplate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFileNameTemplate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tbFileNameTemplate.Location = New System.Drawing.Point(106, 20)
        Me.tbFileNameTemplate.Name = "tbFileNameTemplate"
        Me.tbFileNameTemplate.Size = New System.Drawing.Size(264, 20)
        Me.tbFileNameTemplate.TabIndex = 0
        Me.tbFileNameTemplate.Text = "barcode[N]"
        '
        'label26
        '
        Me.label26.AutoSize = True
        Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label26.Location = New System.Drawing.Point(59, 77)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(43, 13)
        Me.label26.TabIndex = 8
        Me.label26.Text = "Step by"
        '
        'nudCounterStepBy
        '
        Me.nudCounterStepBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.nudCounterStepBy.Location = New System.Drawing.Point(106, 73)
        Me.nudCounterStepBy.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        Me.nudCounterStepBy.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCounterStepBy.Name = "nudCounterStepBy"
        Me.nudCounterStepBy.Size = New System.Drawing.Size(63, 20)
        Me.nudCounterStepBy.TabIndex = 1
        Me.nudCounterStepBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label27
        '
        Me.label27.AutoSize = True
        Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label27.Location = New System.Drawing.Point(59, 102)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(33, 13)
        Me.label27.TabIndex = 9
        Me.label27.Text = "Digits"
        '
        'btnGenerate
        '
        Me.btnGenerate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnGenerate.Image = Global.MultipleBarcodeGeneration.My.Resources.Resources.disk_multiple
        Me.btnGenerate.Location = New System.Drawing.Point(174, 353)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.btnGenerate.Size = New System.Drawing.Size(214, 41)
        Me.btnGenerate.TabIndex = 20
        Me.btnGenerate.Text = "Generate multiple barcodes"
        Me.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'label29
        '
        Me.label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label29.AutoSize = True
        Me.label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label29.Location = New System.Drawing.Point(7, 367)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(86, 13)
        Me.label29.TabIndex = 21
        Me.label29.Text = "Image format"
        '
        'cmbImageFormat
        '
        Me.cmbImageFormat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImageFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbImageFormat.FormattingEnabled = True
        Me.cmbImageFormat.Items.AddRange(New Object() {"PNG", "JPG", "BMP", "TIFF", "GIF"})
        Me.cmbImageFormat.Location = New System.Drawing.Point(99, 364)
        Me.cmbImageFormat.Name = "cmbImageFormat"
        Me.cmbImageFormat.Size = New System.Drawing.Size(67, 21)
        Me.cmbImageFormat.TabIndex = 19
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(7, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 13)
        Me.label1.TabIndex = 24
        Me.label1.Text = "Barcode type"
        '
        'cmbBarcodeType
        '
        Me.cmbBarcodeType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBarcodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarcodeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbBarcodeType.FormattingEnabled = True
        Me.cmbBarcodeType.Location = New System.Drawing.Point(118, 16)
        Me.cmbBarcodeType.Name = "cmbBarcodeType"
        Me.cmbBarcodeType.Size = New System.Drawing.Size(269, 21)
        Me.cmbBarcodeType.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 414)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmbBarcodeType)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.label29)
        Me.Controls.Add(Me.cmbImageFormat)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Barcode Generation"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.nudValueStartAt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudValueEndAt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudValueStepBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.nudCounterStartAt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCounterStepBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

	#End Region

	Private progressBar As System.Windows.Forms.ProgressBar
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private label33 As System.Windows.Forms.Label
	Private label28 As System.Windows.Forms.Label
	Private tbValueTemplate As System.Windows.Forms.TextBox
	Private nudValueStartAt As System.Windows.Forms.NumericUpDown
	Private label24 As System.Windows.Forms.Label
	Private cmbValueDigits As System.Windows.Forms.ComboBox
	Private nudValueEndAt As System.Windows.Forms.NumericUpDown
	Private nudValueStepBy As System.Windows.Forms.NumericUpDown
	Private label30 As System.Windows.Forms.Label
	Private label31 As System.Windows.Forms.Label
	Private label32 As System.Windows.Forms.Label
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private nudCounterStartAt As System.Windows.Forms.NumericUpDown
	Private label25 As System.Windows.Forms.Label
	Private label34 As System.Windows.Forms.Label
	Private label22 As System.Windows.Forms.Label
	Private cmbCounterDigits As System.Windows.Forms.ComboBox
	Private tbFileNameTemplate As System.Windows.Forms.TextBox
	Private label26 As System.Windows.Forms.Label
	Private nudCounterStepBy As System.Windows.Forms.NumericUpDown
	Private label27 As System.Windows.Forms.Label
    Private WithEvents btnGenerate As System.Windows.Forms.Button
	Private label29 As System.Windows.Forms.Label
	Private cmbImageFormat As System.Windows.Forms.ComboBox
	Private label1 As System.Windows.Forms.Label
	Private cmbBarcodeType As System.Windows.Forms.ComboBox
End Class


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
Imports System.IO
Imports System.Windows.Forms
Imports Bytescout.BarCode

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()

        For Each st As SymbologyType In [Enum].GetValues(GetType(SymbologyType))
            cmbBarcodeType.Items.Add(st)
        Next

		cmbBarcodeType.SelectedIndex = 0
		cmbImageFormat.SelectedIndex = 0
	End Sub

    Private Sub btnGenerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerate.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        folderBrowserDialog.Description = "Select output folder"

        If folderBrowserDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim fileNameTemplate As String = tbFileNameTemplate.Text & "." & Convert.ToString(cmbImageFormat.SelectedItem).ToLower()
        Dim counterStartAt As UInteger = CUInt(Math.Truncate(nudCounterStartAt.Value))
        Dim counterStepBy As UInteger = CUInt(Math.Truncate(nudCounterStepBy.Value))
        Dim counterDigits As UInteger = Convert.ToUInt32(cmbCounterDigits.Text)

        If Not fileNameTemplate.Contains("[N]") Then
            MessageBox.Show("File name template does not contain the counter placeholder [N]")
            Return
        End If

        Dim valueTemplate As String = tbValueTemplate.Text
        Dim valueStartAt As UInteger = CUInt(Math.Truncate(nudValueStartAt.Value))
        Dim valueStepBy As UInteger = CUInt(Math.Truncate(nudValueStepBy.Value))
        Dim valueEndAt As UInteger = CUInt(Math.Truncate(nudValueEndAt.Value))
        Dim valueDigits As UInteger = Convert.ToUInt32(cmbValueDigits.Text)

        If Not valueTemplate.Contains("[N]") Then
            MessageBox.Show("Barcode value template does not contain the counter placeholder [N]")
            Return
        End If

        Cursor = Cursors.WaitCursor
        progressBar.Visible = True
        btnGenerate.Text = "Stop"

        Try
            progressBar.Value = CInt(valueStartAt)
            progressBar.Minimum = CInt(valueStartAt)
            progressBar.Maximum = CInt(valueEndAt)
            progressBar.Step = CInt(valueStepBy)

            GenerateBarcodes(valueTemplate, valueStartAt, valueEndAt, valueStepBy, valueDigits, fileNameTemplate, _
             counterStartAt, counterStepBy, counterDigits, folderBrowserDialog.SelectedPath)
        Catch exception As Exception
            MessageBox.Show(exception.Message)
        Finally
            Cursor = Cursors.Default
            progressBar.Visible = False
            btnGenerate.Text = "Generate multiple barcodes"
        End Try
    End Sub

	Private Sub GenerateBarcodes(valueTemplate As String, valueStartAt As UInteger, valueEndAt As UInteger, valueStepBy As UInteger, valueDigits As UInteger, fileNameTemplate As String, _
		counterStartAt As UInteger, counterStepBy As UInteger, counterDigits As UInteger, outputFolder As String)
		Dim barcode As New Barcode()
		barcode.RegistrationKey = "demo"
		barcode.RegistrationName = "demo"

		barcode.Symbology = CType(cmbBarcodeType.SelectedItem, SymbologyType)
		' Set up additional barcode properties here.
		'barcode.AdditionalCaption = "...";

		Dim c As UInteger = counterStartAt

		Dim i As UInteger = valueStartAt
		While i <= valueEndAt
            Dim value As String = String.Format("{0:D" & valueDigits & "}", i)
            Dim counter As String = String.Format("{0:D" & counterDigits & "}", c)
			Dim fileName As String = fileNameTemplate.Replace("[N]", counter)

			progressBar.PerformStep()

			barcode.Value = valueTemplate.Replace("[N]", value)

			barcode.SaveImage(Path.Combine(outputFolder, fileName))

			c += counterStepBy

			Application.DoEvents()
			i += valueStepBy
		End While
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleBarcodeGeneration.VS2005.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>8.0.50727</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{18B7AC2E-F98D-4EA1-8D28-5D2DF6420ABB}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleBarcodeGeneration</RootNamespace>
    <AssemblyName>MultipleBarcodeGeneration</AssemblyName>
    <StartupObject>MultipleBarcodeGeneration.Program</StartupObject>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\disk_multiple.png" />
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleBarcodeGeneration.VS2008.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="3.5" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{18B7AC2E-F98D-4EA1-8D28-5D2DF6420ABB}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleBarcodeGeneration</RootNamespace>
    <AssemblyName>MultipleBarcodeGeneration</AssemblyName>
    <StartupObject>MultipleBarcodeGeneration.Program</StartupObject>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\disk_multiple.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleBarcodeGeneration.VS2010.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{18B7AC2E-F98D-4EA1-8D28-5D2DF6420ABB}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleBarcodeGeneration</RootNamespace>
    <AssemblyName>MultipleBarcodeGeneration</AssemblyName>
    <StartupObject>MultipleBarcodeGeneration.Program</StartupObject>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\disk_multiple.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleBarcodeGeneration.VS2012.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{18B7AC2E-F98D-4EA1-8D28-5D2DF6420ABB}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleBarcodeGeneration</RootNamespace>
    <AssemblyName>MultipleBarcodeGeneration</AssemblyName>
    <StartupObject>MultipleBarcodeGeneration.Program</StartupObject>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\disk_multiple.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleBarcodeGeneration.VS2013.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="12.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{18B7AC2E-F98D-4EA1-8D28-5D2DF6420ABB}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleBarcodeGeneration</RootNamespace>
    <AssemblyName>MultipleBarcodeGeneration</AssemblyName>
    <StartupObject>MultipleBarcodeGeneration.Program</StartupObject>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\disk_multiple.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****MultipleBarcodeGeneration.VS2015.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{18B7AC2E-F98D-4EA1-8D28-5D2DF6420ABB}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>MultipleBarcodeGeneration</RootNamespace>
    <AssemblyName>MultipleBarcodeGeneration</AssemblyName>
    <StartupObject>MultipleBarcodeGeneration.Program</StartupObject>
    <TargetFrameworkVersion>v4.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Bytescout.BarCode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <SubType>Designer</SubType>
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="Resources\disk_multiple.png" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Collections.Generic
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New Form1())
	End Sub
End Class

```

<!-- code block end -->