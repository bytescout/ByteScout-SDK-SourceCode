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


Set bc = Server.CreateObject("Bytescout.BarCode.Barcode")
bc.RegistrationName="demo"
bc.RegistrationKey="demo"

' set barcode type to Datamatrix
bc.Symbology = 15 ' 15 = DataMatrix

' set barcode value to encode
bc.Value = "http://www.bytescout.com"

' generate and get barcode image as PNG image array of bytes
 BarCodeImage = bc.GetImageBytesPNG

 response.ContentType = "image/png"

 ' add content type header 
 response.AddHeader "Content-Type", "image/png"

 ' set the content disposition
 response.AddHeader "Content-Disposition", "inline;filename=BarCode.png" 

 ' write the binary image to the Response output stream 
 response.BinaryWrite BarCodeImage
 response.End

' disconnect from libraries
Set bc = Nothing

%>
