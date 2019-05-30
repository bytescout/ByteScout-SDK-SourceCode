'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

document.RegistrationName = "demo"
document.RegistrationKey = "demo"

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

Set pictures = worksheet.Pictures

' add a picture to specified cell
pictures.Add 1, 1, "image1.jpg" 

' add a picture by absolute pixel coordinates
pictures.Add_3 "image2.jpg", 550, 100

' fit picture into cell range
Set picture = pictures.AddAndFitInto(27, 1, 32, 5, "image1.jpg")

' rotate the last added picture
picture.Rotation = 45


' delete output file if exists already
Set fso = CreateObject("Scripting.FileSystemObject")
If (fso.FileExists("Output.xls")) Then fso.DeleteFile("Output.xls")
Set fso = nothing

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing

