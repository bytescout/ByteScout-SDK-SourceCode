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


Imports System.Data
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports Bytescout.BarCode

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()

		Try
			' MODIFY THE CONNECTION STRING WITH YOUR SERVER CONNECTION INFO!!!
			Const  connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=master;Integrated Security=true;"

			Using connection As New SqlConnection(connectionString)
				connection.Open()

				' Create a database for demonstration purposes
				'''////////////////////////////////////////////////////////////////////////////////////

				Dim o As [Object] = ExecuteQueryScalar(connection, "SELECT DB_ID('example_db')")

				' if 'example_db' does not exist, create it
				If o Is Nothing OrElse TypeOf o Is DBNull Then
					' Create empty database
					ExecuteQueryWithoutResult(connection, "CREATE DATABASE example_db")
					' Switch to created database
					ExecuteQueryWithoutResult(connection, "USE example_db")
					' Create a table
					ExecuteQueryWithoutResult(connection, "CREATE TABLE Products ([Product ID] int, [Product Name] nvarchar(100), [Product Description] nvarchar(255))")
					' Fill the table with data
					ExecuteQueryWithoutResult(connection, "INSERT Products VALUES(1, 'Spreadsheet Tools', 'Convert XLS, XLSX, CSV, ODS spreadsheet into HTML, PDF, XLS, XLSX, CSV formats WITHOUT EXCEL installed')")
					ExecuteQueryWithoutResult(connection, "INSERT Products VALUES(2, 'Watermarking PRO', 'Professional tool to protect images: multiple watermarks, custom position for watermarks, image effects, EXIF and IPTC macros for text and more')")
					ExecuteQueryWithoutResult(connection, "INSERT Products VALUES(3, 'Watermarking', 'Protect copyrights for your images with professional looking watermarks with this easy to use tool')")
					ExecuteQueryWithoutResult(connection, "INSERT Products VALUES(4, 'PPT To Video Scout', 'converts PowerPoint presentations (PPT, PPTX) into AVI,MPEG,WMV, FLV (flash video) video movies with sound')")
				End If


				' Create a datataset from query.
				' Query result columns must conform to field names we used in the report designer

				Dim dataAdapter As New SqlDataAdapter("SELECT [Product ID], [Product Name], [Product Description] FROM example_db.dbo.Products", connection)

				' fill dataset
				Dim dataSet As New DataSet()
				dataAdapter.Fill(dataSet)

				' don't forget to close the connection
				connection.Close()

				' add virtual column into the result table
				dataSet.Tables(0).Columns.Add(New DataColumn("BarCode", GetType(Byte())))

				' create barcode object
				Dim bc As New Barcode(SymbologyType.Code39)
				bc.DrawCaption = False

				For Each row As DataRow In dataSet.Tables(0).Rows
					' set barcode value
					bc.Value = (Convert.ToString(row("Product ID")))

					' retrieve generated image bytes
					Dim barcodeBytes As Byte() = bc.GetImageBytesWMF()

					' fill virtual column with generated image bytes
					row("BarCode") = barcodeBytes
				Next

				' set report datasource
				CrystalReport11.SetDataSource(dataSet.Tables(0))
			End Using
		Catch ex As Exception
			Trace.WriteLine("Error: " & ex.Message)
		End Try
	End Sub

	Private Shared Sub ExecuteQueryWithoutResult(connection As SqlConnection, query As String)
		Using command As New SqlCommand(query, connection)
			command.ExecuteNonQuery()
		End Using
	End Sub

	Private Shared Function ExecuteQueryScalar(connection As SqlConnection, query As String) As Object
		Using command As New SqlCommand(query, connection)
			Return command.ExecuteScalar()
		End Using
	End Function
End Class
