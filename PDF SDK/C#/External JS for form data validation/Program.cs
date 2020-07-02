//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDF;

namespace ExternalJsFormValidation
{
    /// <summary>
    /// This example demonstrates validation of form with JavaScript
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // If you wish to load an existing document uncomment the line below and comment the Add page section instead
            // pdfDocument.Load(@".\existing_document.pdf");

            // Add page
            Page page = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page);

            // Get page canvas
            Canvas canvas = page.Canvas;

            // Prepare font and brush
            Font font = new Font(StandardFonts.Helvetica, 15);
            SolidBrush blackBrush = new SolidBrush();

            // Draw First Name Label
            canvas.DrawString("First Name: ", font, blackBrush, 50, 50);

            // Create First Name EditBox
            EditBox firstName = new EditBox(130, 50, 100, 30, "FirstName");
            
            // Add javascript validation of focus lose
            firstName.OnLoseFocus = new JavaScriptAction(@"
if(event.value == ''){
    app.alert('First Name is required!');
}
");
            // Add First Name Editbox to page
            page.Annotations.Add(firstName);

            // Draw Last Name Label
            canvas.DrawString("Last Name: ", font, blackBrush, 50, 100);

            // Create Last Name EditBox
            EditBox lastName = new EditBox(130, 100, 100, 30, "LastName");
            
            // Add javascript validation on focus lose
            lastName.OnLoseFocus = new JavaScriptAction(@"
if(event.value == ''){
    app.alert('Last Name is required!');
}
");
            page.Annotations.Add(lastName);

            // Create a button
            PushButton btnSubmit = new PushButton(50, 150, 150, 30, "SayHello");
            btnSubmit.Caption = "Say Hello!";

            // Javascript action to validate as well as displaying message
            btnSubmit.OnMouseDown = new JavaScriptAction(@"

var valFirstName = this.getField('FirstName').value;
var valLastName = this.getField('LastName').value;

if(valFirstName == '' || valLastName == ''){
    app.alert('Please complete incompete values in form!');
}
else{
    var messageToDisplay = 'Hello, ' + valLastName + ' ' + valFirstName + '!';
    app.alert(messageToDisplay, 4);
}

");

            page.Annotations.Add(btnSubmit);

            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
