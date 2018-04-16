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


    // add new page
    pdf.pageAdd();

    // draw formatted text
    pdf.textAdd(20, 50, 'You can use HTML tags for text formatting: &lt;b&gt; for <b>bold</b> and &lt;i&gt; for <i>italic</i> or &lt;s&gt; for <s>striked style</s>.');

    // draw formatted text
    pdf.textAdd(10, 100, 'You may also change <font face="Helvetica" size="20" color="#0000ff">font size and</font> <font face="Courier" size="20" color="#ff0000">color</font> and use <u><b>mixed <i>styles</i></b></u>.');


    // draw formatted text
    pdf.textAdd(10, 140, 'Zapf-Dingbats and Symbol fonts:');

    // set zapf dingbats built in font to use
    pdf.fontSetName("zapfDingbats");
    pdf.fontSetSize(25);

    // draw symbols, see map of letters to symbols at https://images.google.com/?q=zapf+dingbats+font+symbols
    pdf.textSetBox(10,150,500,300); // define output rectangle
    pdf.textAddToBox("1234567890!@#$%^&*()ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")

    // set symbol font
    pdf.fontSetName("Symbol");
    pdf.fontSetSize(25);

    // draw symbols, see map of letters to symbols at https://images.google.com/?q=zapf+dingbats+font+symbols
    pdf.textSetBox(10,310,500,800); // define output rectangle
    pdf.textAddToBox("1234567890!@#$%^&*()ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")

    // return BytescoutPDF object instance
    return pdf;
}

