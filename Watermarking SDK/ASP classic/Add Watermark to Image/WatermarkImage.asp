'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


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
