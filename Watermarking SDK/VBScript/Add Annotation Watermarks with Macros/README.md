## How to add annotation watermarks with macros in VBScript using ByteScout Watermarking SDK

### Write code in VBScript to add annotation watermarks with macros with this step-by-step tutorial

On this page you will learn from code samples for programming in VBScript.Writing of the code to add annotation watermarks with macros in VBScript can be done by developers of any level using ByteScout Watermarking SDK. ByteScout Watermarking SDK is the software development kit that helps to quickly implement adding of watermarks on top of PNG, JPG, BMP images as well as on multipaged TIFF files. You may select ready to use presets or create your own preset with semitransparent logo images, text lines with adjustable font size, family, color, rotation. It can add annotation watermarks with macros in VBScript.

The SDK samples like this one below explain how to quickly make your application do add annotation watermarks with macros in VBScript with the help of ByteScout Watermarking SDK. Just copy and paste the code into your VBScript application’s code and follow the instruction. This basic programming language sample code for VBScript will do the whole work for you to add annotation watermarks with macros.

ByteScout Watermarking SDK free trial version is available on our website. VBScript and other programming languages are supported.

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

##### ****AnnotationWithMacros.vbs:**
    
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
outputFilePath = "result.png"

' Add image to apply watermarks to
watermarker.AddInputFile_2 inputFilePath, outputFilePath

' Create new watermark
Set preset = CreateObject("Bytescout.Watermarking.Presets.TextAnnotation")

' Set watermark text with macros.
' Complete list of available macros please see in the SDK documentation.
preset.Text = "Date Time: {{LOCAL_DATE_LONG}} {{LOCAL_TIME}}" & vbCrLf & _
            "Filename: {{FILENAME}}" & vbCrLf & _
            "Manufacturer: {{EXIF_EQUIPMENT_MANUFACTURER}}" & vbCrLf & _
            "Model: {{EXIF_EQUIPMENT_MODEL}}" & vbCrLf & _
            "Software: {{EXIF_SOFTWARE_USED}}" & vbCrLf & _
            "Date/Time: {{EXIF_ORIGINAL_DATE}}" & vbCrLf & _
            "Exposure Time: {{EXIF_EXPOSURE_TIME}} sec" & vbCrLf & _
            "Exposure Program: {{EXIF_EXPOSURE_PROGRAM}}" & vbCrLf & _
            "Exposure Bias: {{EXIF_EXPOSURE_BIAS}} EV" & vbCrLf & _
            "F Number: F {{EXIF_F_NUMBER}}" & vbCrLf & _
            "ISO Speed Rating: ISO {{EXIF_ISO_SPEED}}" & vbCrLf & _
            "Flash: {{EXIF_FLASH}}" & vbCrLf & _
            "Focal Length: {{EXIF_FOCAL_LENGTH}} mm" & vbCrLf & _
            "Metering Mode: {{EXIF_METERING_MODE}}"

' Set watermark font
Set font = CreateObject("Bytescout.Watermarking.WatermarkFont")
font.Name = "Arial"
font.Style = 1 ' Bold
font.SizeType = 1 ' Points
font.Size = 12
preset.Font = font

' Set text color
preset.SetTextColor 255, 255, 255, 255 ' White color in ARGB values

' Add watermark to watermarker
waterMarker.AddWatermark(preset)

' Apply watermarks
waterMarker.Execute()

' open generated image file in default image viewer installed in Windows
Set shell = CreateObject("WScript.Shell")
shell.Run outputFilePath, 1, false
Set shell = Nothing

' Cleanup
Set font = Nothing
Set preset = Nothing
Set watermarker = Nothing

```

<!-- code block end -->