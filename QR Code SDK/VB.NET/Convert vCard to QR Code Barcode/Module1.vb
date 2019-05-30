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


Imports System.Drawing.Imaging
Imports System.IO
Imports Bytescout.BarCode
Imports Thought.vCards

Module Module1

    Sub Main()

        ' Generate vCard
        Dim vCard = new vCard()
        vCard.GivenName = "Forrest"
        vCard.FamilyName = "Gump"
        vCard.Organization = "Bubba Gump Shrimp Co."
        vCard.Title = "Shrimp Man"
        vCard.Phones.Add(new vCardPhone("(111) 555-1212", vCardPhoneTypes.Home))
        vCard.EmailAddresses.Add(new vCardEmailAddress("forrestgump@example.com", vCardEmailAddressType.Internet))
			
        Dim address = new vCardDeliveryAddress()
        address.AddressType.Add(vCardDeliveryAddressTypes.Home)
        address.Street = "100 Waters Edge"
        address.City = "Baytown"
        address.Region = "LA"
        address.PostalCode = "30314"
        address.Country = "United States of America"
        vCard.DeliveryAddresses.Add(address)

        ' Save vCard data to string
        Dim writer = new vCardStandardWriter()
        Dim stringWriter = new StringWriter()
        writer.Write(vCard, stringWriter)

        ' Create and activate QRCode instance
        Using barcode As New QRCode("demo", "demo")

            ' Set value            
            barcode.Value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz 1234567890"

            ' Set barcode value
            barcode.Value = stringWriter.ToString()

            ' Save barcode image to file
            barcode.SaveImage("result.png")

        End Using

        ' Open the image in default image viewer (for demo purpose)
        Process.Start("result.png")

    End Sub

End Module
