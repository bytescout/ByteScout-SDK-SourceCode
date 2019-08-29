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


Imports System.IO
Imports Bytescout.BarCodeReader
Imports Thought.vCards

Module Module1
    ''' <summary>
    ''' This example demonstrates reading of QR Code encoded vCard.
    ''' It uses vCard library by David Pinch:
    ''' 
    ''' vCard Class Library for .NET (Version 0.4; LGPL license)
    ''' Copyright (c) 2007-2009 David Pinch 
    ''' http://www.thoughtproject.com/Libraries/vCard/
    ''' </summary>
    Sub Main()

        ' Create Bytescout.BarCodeReader.Reader instance
        Using reader As New Reader

            ' Enable QR Code decoding
            reader.BarcodeTypesToFind.QRCode = True

            ' -----------------------------------------------------------------------
            ' NOTE: We can read barcodes from specific page to increase performance .
            ' For sample please refer to "Decoding barcodes from PDF by pages" program.
            ' ----------------------------------------------------------------------- 

            ' Decode QR Code from image
            Dim barcodes = reader.ReadFrom("sample_vcard.gif")

            If barcodes.Length > 0 Then

                Dim vcardBarcode = barcodes(0)

                ' Decode vCard information from barcode value
                Dim stringReader As New StringReader(vcardBarcode.Value)
                Dim vCard As New vCard(stringReader)

                ' Display some decoded info:
                Console.WriteLine("GivenName: " + vCard.GivenName)
                Console.WriteLine("FamilyName: " + vCard.FamilyName)
                Console.WriteLine("Organization: " + vCard.Organization)
                Console.WriteLine("Title: " + vCard.Title)
                Console.WriteLine("Phone: " & vCard.Phones(0).FullNumber)
                Console.WriteLine("EmailAddresses: " & vCard.EmailAddresses(0).Address)
                Console.WriteLine("DeliveryAddress: " & vCard.DeliveryAddresses(0).Street & " " & vCard.DeliveryAddresses(0).City & " " & _
                    vCard.DeliveryAddresses(0).Region & " " & vCard.DeliveryAddresses(0).PostalCode & " " & vCard.DeliveryAddresses(0).Country)

            End If

        End Using

        Console.WriteLine()
        Console.WriteLine("Press any key...")
        Console.ReadKey()

    End Sub

End Module
