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
        Dim Margins1 As Bytescout.BarCode.Margins = New Bytescout.BarCode.Margins
        Dim SymbologyOptions1 As Bytescout.BarCode.SymbologyOptions = New Bytescout.BarCode.SymbologyOptions
        Me.BarcodeControl1 = New Bytescout.BarCode.BarcodeControl
        Me.SuspendLayout()
        '
        'BarcodeControl1
        '
        Me.BarcodeControl1.AddChecksum = False
        Me.BarcodeControl1.AddChecksumToCaption = False
        Me.BarcodeControl1.AdditionalCaption = ""
        Me.BarcodeControl1.AdditionalCaptionFont = New System.Drawing.Font("Arial", 12.0!)
        Me.BarcodeControl1.AdditionalCaptionPosition = Bytescout.BarCode.CaptionPosition.Above
        Me.BarcodeControl1.Angle = Bytescout.BarCode.RotationAngle.Degrees0
        Me.BarcodeControl1.BarHeight = 50
        Me.BarcodeControl1.CaptionFont = New System.Drawing.Font("Arial", 12.0!)
        Me.BarcodeControl1.CaptionPosition = Bytescout.BarCode.CaptionPosition.Below
        Me.BarcodeControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BarcodeControl1.DrawCaption = True
        Me.BarcodeControl1.HorizontalAlignment = Bytescout.BarCode.BarcodeHorizontalAlignment.Center
        Me.BarcodeControl1.Location = New System.Drawing.Point(0, 0)
        Margins1.Bottom = 0
        Margins1.Left = 0
        Margins1.Right = 0
        Margins1.Top = 0
        Me.BarcodeControl1.Margins = Margins1
        Me.BarcodeControl1.Name = "BarcodeControl1"
        Me.BarcodeControl1.NarrowBarWidth = 3
        SymbologyOptions1.CodabarChecksumAlgorithm = Bytescout.BarCode.CodabarChecksumAlgorithm.Modulo9
        SymbologyOptions1.CodabarStartSymbol = Bytescout.BarCode.CodabarSpecialSymbol.A
        SymbologyOptions1.CodabarStopSymbol = Bytescout.BarCode.CodabarSpecialSymbol.A
        SymbologyOptions1.Code128Alphabet = Bytescout.BarCode.Code128Alphabet.[Auto]
        SymbologyOptions1.DrawIntercharacterGap = True
        SymbologyOptions1.ShowStartStop = False
        Me.BarcodeControl1.Options = SymbologyOptions1
        Me.BarcodeControl1.RegistrationKey = ""
        Me.BarcodeControl1.RegistrationName = ""
        Me.BarcodeControl1.RenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BarcodeControl1.Size = New System.Drawing.Size(284, 264)
        Me.BarcodeControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        Me.BarcodeControl1.Symbology = Bytescout.BarCode.SymbologyType.Code39
        Me.BarcodeControl1.TabIndex = 0
        Me.BarcodeControl1.Value = "5712349"
        Me.BarcodeControl1.VerticalAlignment = Bytescout.BarCode.BarcodeVerticalAlignment.Middle
        Me.BarcodeControl1.WideToNarrowRatio = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.BarcodeControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarcodeControl1 As Bytescout.BarCode.BarcodeControl

End Class
