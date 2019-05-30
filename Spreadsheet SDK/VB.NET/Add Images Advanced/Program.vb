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


Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports Bytescout.Spreadsheet
Imports Bytescout.Spreadsheet.MSODrawing

Namespace AddImages
	Class Program
		Friend Shared Sub Main(args As String())
			' Create spreadsheet
			Dim doc As New Spreadsheet()
			' Add worksheet
			Dim worksheet As Worksheet = doc.Worksheets.Add()

			' Put an image to "C3" cell
			Dim shape As PictureShape = worksheet.Pictures.Add(2, 2, "image1.jpg")

			' Make the picture "floating". It will be not moved if you move or resize the "C3" cell
			shape.PlacementType = Placement.FreeFloating

			' Make the picture brighter
			shape.Brightness = 0.8F

			' Put second image to "K11" cell
			shape = worksheet.Pictures.Add(10, 10, "image2.jpg")

			' Make the picture bound to the cell. It will be moved alonf with the "K11" cell
			shape.PlacementType = Placement.Move

			' Crop 10% from left and right side of the image
			shape.CropFromLeft = 0.1F
			shape.CropFromRight = 0.1F

			' Delete output file if exists
			If File.Exists("output.xls") Then
				File.Delete("output.xls")
			End If

			' Save document
			doc.SaveAs("output.xls")

			' Close spreadsheet
			doc.Close()

			' Open generated XLS document in default application
			Process.Start("output.xls")

			doc.Dispose()
		End Sub
	End Class
End Namespace
