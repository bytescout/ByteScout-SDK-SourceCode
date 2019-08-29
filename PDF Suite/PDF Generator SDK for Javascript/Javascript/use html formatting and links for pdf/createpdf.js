//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


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
    
    // add 1st page
    pdf.pageAdd();
    // add page header with anchor
    pdf.textAdd(10, 20, '<a name="#page1"/><font face="Courier" size="15" color="#00ff00"><b><i>Page 1</i></b></font>', 0);
    // add link to page 2 by anchor
    pdf.textAdd(10, 50,'<u><font face="Helvetica" size="12" color="#0000ff"><a href="#page2">link to page #2 by anchor</a></font></u>', 0);
    // add link to page 3 by page number and offset ("#3#10")
    pdf.textAdd(10, 70,'<u><font face="Helvetica" size="12" color="#0000ff"><a href="#3#10">link to page #3 by page number and offset</a></font></u>', 0);
    
    // add 2nd page
    pdf.pageAdd();
    // add page header with anchor
    pdf.textAdd(10, 20, '<a name="#page2"/><font face="Courier" size="15" color="#00ff00"><b><i>Page 2</i></b></font>', 0);
    // add link to page 1 by anchor
    pdf.textAdd(10, 50,'<u><font face="Helvetica" size="12" color="#0000ff"><a href="#page1">link to page #1 by anchor</a></font></u>', 0);
    // add link to page 3 by page number and offset
    pdf.textAdd(10, 70,'<u><font face="Helvetica" size="12" color="#0000ff"><a href="#3#0">link to page #3 by page number and offset</a></font></u>', 0);
    
    // add 3nd page
    pdf.pageAdd();
    // add page header
    pdf.textAdd(10, 20, '<font face="Courier" size="15" color="#00ff00"><b><i>Page 3</i></b></font>', 0);
    // add link to page 1 by anchor
    pdf.textAdd(10, 50,'<u><font face="Helvetica" size="12" color="#0000ff"><a href="#page1">link to page #1 by anchor</a></font></u>', 0);
    // add link to page 2 by page number and offset
    pdf.textAdd(10, 70,'<u><font face="Helvetica" size="12" color="#0000ff"><a href="#2#0">link to page #2 by page number and offset</a></font></u>', 0);
    
    // add an external link
    pdf.pageSetIndex(1); // return back to the first page
    pdf.textAdd(100, 300, "link to www.google.com");
	pdf.addLink(100, 280, 200, 30, 'http://www.google.com');
	
    // return BytescoutPDF object instance
    return pdf;
}

