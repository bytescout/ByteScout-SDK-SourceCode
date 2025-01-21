'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.IO
Imports Bytescout.BarCodeReader

Public Class _Default
    Inherits System.Web.UI.Page

    ' IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

    ' Temporary folder access is required for web application when you use ByteScout SDK in it.
    ' If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

    ' SOLUTION:

    ' If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

    ' If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

    ' In this case
    ' - check the User or User Group your web application is running under
    ' - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
    ' - restart your web application and try again

    Private Sub UploadButton_Click(sender As Object, e As System.EventArgs) Handles UploadButton.Click

        Dim savePath As String = "\uploads\"

        If (FileUpload1.HasFile) Then

            Dim virtualFilePath As String = Path.Combine(savePath, FileUpload1.FileName)

            Dim serverFilePath As String = Server.MapPath(virtualFilePath)
            If Not Directory.Exists(Path.GetDirectoryName(serverFilePath)) Then
                Directory.CreateDirectory(Path.GetDirectoryName(serverFilePath))
            End If

            FileUpload1.SaveAs(serverFilePath)

            Dim image As System.Drawing.Image = Nothing

            Try
                Using fileStream As FileStream = File.OpenRead(serverFilePath)
                    image = System.Drawing.Image.FromStream(fileStream)
                End Using

            Catch ex As Exception

            End Try

            If image Is Nothing Then
                UploadStatusLabel.Visible = True
                UploadStatusLabel.Text = "Your file is not an image."
                Image1.Visible = False
                ListBox1.Visible = False
            Else
                UploadStatusLabel.Visible = False
                Image1.ImageUrl = virtualFilePath
                Image1.Visible = True
                Image1.Width = image.Width
                Image1.Height = image.Height
                ListBox1.Items.Clear()
                ListBox1.Visible = True

                FindBarcodes(serverFilePath)

                If ListBox1.Items.Count = 0 Then
                    ListBox1.Items.Add("No barcodes found")
                End If

            End If

        Else
            'Notify the user that a file was not uploaded.
            UploadStatusLabel.Text = "You did not specify a file to upload."
        End If

    End Sub

    Private Sub FindBarcodes(fileName As String)

        Dim reader As Reader = New Reader()

        ' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
		' Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
		' or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
		reader.BarcodeTypesToFind.SetAll1D()

        ' reader.MediumTrustLevelCompatible = True ' uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

        reader.ReadFromFile(fileName)

        For Each barcode As FoundBarcode In reader.FoundBarcodes
            ListBox1.Items.Add(String.Format("{0} : {1}", barcode.Type, barcode.Value))
        Next

    End Sub

End Class
