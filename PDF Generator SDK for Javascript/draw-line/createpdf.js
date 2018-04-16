//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//


// function that creates BytescoutPDF instance (defined in BytescoutPDF.js script which have to be included into the same page)
// then calls API methods and properties to create PDF document
// and returns created BytescoutPDF object instance
// this CreatePDF() function is called from Sample.html
// IsInternetExplorer8OrLower parameter indicates if we use IE8 or lower so we CAN'T use images (as it requires HTML5 Canvas available in IE9 or higher). Other browsers should be working fine


// IMPORTANT ABOUT IMAGES: 
// When using Firefox or IE, pdf generation may fail because images are not accessible when pdf generation works
// the solution for this issue is to preload images in main HTML document before running PDF generation
// to preload images, put them into hidden div block "pdfreportimages" - you can see it in the sample.html right after <body> opening tag


function CreatePDF(IsInternetExplorer8OrLower) {

    // create BytescoutPDF object instance
    var pdf = new BytescoutPDF();

    // set document properties: Title, subject, keywords, author name and creator name
    pdf.propertiesSet("Sample document title", "Sample subject", "keyword1, keyword 2, keyword3", "Document Author Name", "Document Creator Name");

    // set page size
    pdf.pageSetSize(BytescoutPDF.A4);

    // set page orientation (BytescoutPDF.PORTRAIT = portrait, BytescoutPDF.LANDSCAPE = landscape)
    pdf.pageSetOrientation(BytescoutPDF.PORTRAIT);

    // add new page
    pdf.pageAdd();

    // draw lines with different widths
    for (var j = 0; j < 10; j++) {
        // set color in RGB format (0,0,0 is black color)
        pdf.graphicsSetColor(0, 0, 0);

        // set line width
        pdf.graphicsSetLineWidth(1 + j);

        // draw a line from one point to another
        pdf.graphicsDrawLine(20, 20 + j * 15, 120, 20 + j * 15);
    }

    // draw lines with different colors (trying different Green components
    for (var j = 0; j < 25; j++) {
        // set new line color in RGB format by changing G component
        pdf.graphicsSetColor(25, 10 * j, 25);

        // set line width
        pdf.graphicsSetLineWidth(3);

        // draw a line from one point to another
        pdf.graphicsDrawLine(140, 20 + j * 8, 300, 20 + j * 8);
    }


    // draw lines with different line endings
    // available line endings:
    // BytescoutPDF.BUTT_CAP (default)
    // BytescoutPDF.ROUND_CAP
    // BytescoutPDF.PROJECTING_SQUARE_CAP

    // draw line with line end type = 0

    // set new line color in RGB format to Black (0,0,0)
    pdf.graphicsSetColor(0, 0, 0);

    // set line width
    pdf.graphicsSetLineWidth(10);
    // set line ending type
    pdf.graphicsSetLineEndType(BytescoutPDF.BUTT_CAP);

    // draw a line from one point to another
    pdf.graphicsDrawLine(320, 20, 380, 20);

    // set line width
    pdf.graphicsSetLineWidth(10);
    // set line ending type
    pdf.graphicsSetLineEndType(BytescoutPDF.ROUND_CAP);

    // draw a line from one point to another
    pdf.graphicsDrawLine(320, 40, 380, 40);

    // set line width
    pdf.graphicsSetLineWidth(10);
    // set line ending type
    pdf.graphicsSetLineEndType(BytescoutPDF.PROJECTING_SQUARE_CAP);

    // draw a line from one point to another
    pdf.graphicsDrawLine(320, 60, 380, 60);


    // return BytescoutPDF object instance
    return pdf;
}

