'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


' IMPORTANT:
' Copy input.doc to your my documents folder
' and change the path to "input.doc" below 
' Word requires to provide absolute path to input files
'
'


Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Imports Bytescout.BarCode

Module Module1
    <STAThread()> _
    Sub Main()
        ' Create new barcode
        Dim barcode As New Barcode()

        ' Set symbology
        barcode.Symbology = SymbologyType.Codabar
        ' Set value
        barcode.Value = "123456"

        ' Add checksum to barcode
        barcode.AddChecksum = True

        ' Create word instance
        Dim appWord As New Microsoft.Office.Interop.Word.Application()

        ' Hide word
        appWord.Visible = False

        ' Create missing object
        Dim mis As Object = System.Reflection.Missing.Value
        ' Template file - change to the appropraite path where you copied input.doc
        Dim fileInput As Object = "C:\input.doc"
        ' Template file -  change to the appropraite path where you copied input.doc
        Dim fileOutput As Object = "C:\output.doc"

        ' Open document
        Dim docWord As Microsoft.Office.Interop.Word.Document = appWord.Documents.Open(fileInput, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis)

        ' Set bookmark name
        Dim bookmarkName As Object = "MyBookmark"

        ' Get bookmark location
        Dim bookmarkLocation As Microsoft.Office.Interop.Word.Range = docWord.Bookmarks(bookmarkName).Range()

        ' Get barcode image
        Dim image As Bitmap = DirectCast(barcode.GetImage(), Bitmap)

        ' Copy image to the clipboard
        Clipboard.SetDataObject(image)

        ' Paste barcode image to the document
        bookmarkLocation.Paste()

        ' Save to the new document
        docWord.SaveAs(fileOutput, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis, mis)

        ' We needn't save changes
        Dim saveChanges As Object = False

        ' Close word application
        appWord.Quit(saveChanges, mis, mis)

        ' Release COM object
        System.Runtime.InteropServices.Marshal.ReleaseComObject(appWord)
    End Sub

End Module
