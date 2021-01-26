## How to add watermark to image in ASP classic using ByteScout Watermarking SDK

### Tutorial on how to add watermark to image in ASP classic

These source code samples are listed and grouped by their programming language and functions they use. ByteScout Watermarking SDK is the powerful SDK can apply high quality visible and semivisible watermarks into PNG, JPG, BMP pictures and TIFF scans. Doznes of presets are available, multiple watermarks can be applied. Can add logo based watermark from image, can adjust font size, font family, colors. It can add watermark to image in ASP classic.

This code snippet below for ByteScout Watermarking SDK works best when you need to quickly add watermark to image in your ASP classic application. Follow the instructions from the scratch to work and copy the ASP classic code. Use of ByteScout Watermarking SDK in ASP classic is also explained in the documentation included along with the product.

You can download free trial version of ByteScout Watermarking SDK from our website to see and try many others source code samples for ASP classic.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Watermarking%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Watermarking%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### **WatermarkImage.asp:**
    
```
<%

' In case of "Server.CreateObject Failed", "Server object error "ASP 0177 : 8000ffff" or similar errors:
' Please try the following:
' - Open IIS 
' - Find application pools (DefaultAppPool is used by default)
' - Open its properties and check .NET CLR version selected:
' - if you have  .NET 1.1 then change to .NET CLR 2.00
' - if you have .NET CLR 2.00 then try to change to .NET CLR 4.0


Set watermarker = Server.CreateObject("Bytescout.Watermarking.Watermarker")

' Initialize library
watermarker.InitLibrary "demo", "demo"

' Set input file name
Dim inputFilePath
inputFilePath = Server.MapPath("sample_image.jpg")

' Add image to apply watermarks to
watermarker.AddInputFile inputFilePath

' Create new watermark
Set preset = Server.CreateObject("Bytescout.Watermarking.Presets.SimpleText")

' Set watermark text
preset.Text = "Bytescout Watermarking SDK"

' Set watermark font
Set font = Server.CreateObject("Bytescout.Watermarking.WatermarkFont")
font.Name = "Arial"
font.Style = 1 ' Bold
font.SizeType = 1 ' Points
font.Size = 18
preset.Font = font

' Set watermark text color
preset.SetTextColor 255, 255, 255, 255 ' White color in ARGB values

' Add watermark to watermarker
waterMarker.AddWatermark(preset)

' Apply watermarks
waterMarker.Execute()

' generate and get barcode image as PNG image array of bytes
 OutImage = bc.GetImageBytes

 response.ContentType = "image/png"

 ' add content type header 
 response.AddHeader "Content-Type", "image/png"

 ' set the content disposition
 response.AddHeader "Content-Disposition", "inline;filename=OutImage.png" 

 ' write the binary image to the Response output stream 
 response.BinaryWrite OutImage
 response.End

' Cleanup
Set font = Nothing
Set preset = Nothing
Set watermarker = Nothing

%>

```

<!-- code block end -->