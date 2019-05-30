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

    // set page size.
    // select one of predefined page sizes:
    // BytescoutPDF.A0 
	// BytescoutPDF.A1
    // BytescoutPDF.A2 
	// BytescoutPDF.A3
	// BytescoutPDF.A4
	// BytescoutPDF.A5 
	// BytescoutPDF.A6 
	// BytescoutPDF.A7 
	// BytescoutPDF.Letter
	// BytescoutPDF.Legal 
	// BytescoutPDF.Executive
	// BytescoutPDF.JisB5 
    pdf.pageSetSize(BytescoutPDF.Letter);

    // or you may set CUSTOM page size, for example set to 5x7 inches
    // pdf.pageSetWidth(5*72); // 5 inches * 72 DPI (dots per inch)
    // pdf.pageSetHeight(7*72); // 7 inches * 72 DPI 

    // set page orientation (PORTRAIT or LANDSCAPE)
    pdf.pageSetOrientation(BytescoutPDF.PORTRAIT); 

    // add new page
    pdf.pageAdd();
    
    pdf.textAdd(50, 50, '"Letter" page size', 0);

    // return BytescoutPDF object instance
    return pdf;
}

