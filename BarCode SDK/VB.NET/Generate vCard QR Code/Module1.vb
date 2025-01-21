'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Drawing.Imaging
Imports System.IO
Imports Bytescout.BarCode
Imports Thought.vCards

Module Module1

    ''' <summary>
    ''' This example demonstrates generation of QR Code encoded vCard.
    ''' It uses vCard library by David Pinch:
    ''' 
    ''' vCard Class Library for .NET (Version 0.4; LGPL license)
    ''' Copyright (c) 2007-2009 David Pinch 
    ''' http://www.thoughtproject.com/Libraries/vCard/
    ''' </summary>
    Sub Main()

        ' Generate vCard
        Dim vCard As New vCard()
        vCard.GivenName = "Forrest"
        vCard.FamilyName = "Gump"
        vCard.Organization = "Bubba Gump Shrimp Co."
        vCard.Title = "Shrimp Man"
        vCard.Phones.Add(New vCardPhone("(111) 555-1212", vCardPhoneTypes.Home))
        vCard.EmailAddresses.Add(New vCardEmailAddress("forrestgump@example.com", vCardEmailAddressType.Internet))

        Dim address As New vCardDeliveryAddress()
        address.AddressType = vCardDeliveryAddressTypes.Home
        address.Street = "100 Waters Edge"
        address.City = "Baytown"
        address.Region = "LA"
        address.PostalCode = "30314"
        address.Country = "United States of America"
        vCard.DeliveryAddresses.Add(address)

        ' Save vCard data to string
        Dim writer As New vCardStandardWriter()
        Dim stringWriter As New StringWriter()
        writer.Write(vCard, stringWriter)

        ' Create Bytescout.Barcode instance
        Using barcode As New Barcode
            ' Set barcode type
            barcode.Symbology = SymbologyType.QRCode
            ' Set barcode value
            barcode.Value = stringWriter.ToString()
            ' Save barcode to image
            barcode.SaveImage("result.png", ImageFormat.Png)

            ' Open generated barcode image in default associated application 
            Process.Start("result.png")
        End Using

    End Sub

End Module
