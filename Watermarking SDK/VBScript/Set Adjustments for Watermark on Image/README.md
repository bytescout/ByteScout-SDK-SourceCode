## How to set adjustments for watermark on image in VBScript with ByteScout Watermarking SDK

### This code in VBScript shows how to set adjustments for watermark on image with this how to tutorial

Source code documentation samples provide quick and easy way to add a required functionality into your application. Want to set adjustments for watermark on image in your VBScript app? ByteScout Watermarking SDK is designed for it. ByteScout Watermarking SDK is the software development kit that helps to quickly implement adding of watermarks on top of PNG, JPG, BMP images as well as on multipaged TIFF files. You may select ready to use presets or create your own preset with semitransparent logo images, text lines with adjustable font size, family, color, rotation.

You will save a lot of time on writing and testing code as you may just take the VBScript code from ByteScout Watermarking SDK for set adjustments for watermark on image below and use it in your application. Just copy and paste the code into your VBScript application’s code and follow the instruction. This basic programming language sample code for VBScript will do the whole work for you to set adjustments for watermark on image.

Our website provides trial version of ByteScout Watermarking SDK for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Watermarking%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Watermarking%20SDK%20Question) 

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

##### ****Adjustments.vbs:**
    
```
' Create Watermarker instance
Set watermarker = CreateObject("Bytescout.Watermarking.Watermarker")

' Initialize library
watermarker.InitLibrary "demo", "demo"

' Set input file name
Dim inputFilePath
inputFilePath = "..\sample_image.jpg"
' Set output file title
Dim outputFilePath
outputFilePath = "result.jpg"

' Add image to apply watermarks to
watermarker.AddInputFile_2 inputFilePath, outputFilePath

' Create new watermark
Set preset = CreateObject("Bytescout.Watermarking.Presets.SimpleText")

' Set watermark text
preset.Text = "Bytescout Watermarking"

' Set watermark font
Set font = CreateObject("Bytescout.Watermarking.WatermarkFont")
font.Name = "Arial"
font.Style = 1 ' Bold
font.SizeType = 1 ' Points
font.Size = 18
preset.Font = font

' Set watermark text color
preset.SetTextColor 255, 255, 255, 255 ' White color in ARGB values

' Create OutputOptions instance
Set outputOptions = CreateObject("Bytescout.Watermarking.OutputOptions")
' Set JPEG quality
outputOptions.Quality = 95
' Resize
outputOptions.Resize = True
outputOptions.ResizeType = 1 ' Percentage
outputOptions.ResizePercentage = 75 ' resize image to 75%
' Add effects
outputOptions.UseEffects = True
outputOptions.Effects = 2 Or 256 ' Sepia with light oil texture

waterMarker.OutputOptions = outputOptions

' Add watermark to watermarker
waterMarker.AddWatermark(preset)

' Apply watermarks
waterMarker.Execute()

' open generated image file in default image viewer installed in Windows
Set shell = CreateObject("WScript.Shell")
shell.Run outputFilePath, 1, false
Set shell = Nothing

' Cleanup
Set outputOptions = Nothing
Set font = Nothing
Set preset = Nothing
Set watermarker = Nothing

```

<!-- code block end -->