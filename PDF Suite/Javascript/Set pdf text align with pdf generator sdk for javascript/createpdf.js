//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
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

    // add new page
    pdf.pageAdd();
    
    pdf.textSetBoxPadding(3);

    // set text box
    pdf.textSetBox(50, 50, 500, 500);
    // and draw a rectangle around it
    pdf.graphicsDrawRectangle(50, 50, 500, 500);

    // add aligned text:

    pdf.textSetAlign(BytescoutPDF.LEFT);
    pdf.textAddToBox('Left aligned text: café, communiqué, fête, fiancée, mêlée, émigré, pâté, protégé; ', true);

    pdf.textSetAlign(BytescoutPDF.CENTER);
    pdf.textAddToBox('Center aligned text', true);

    pdf.textSetAlign(BytescoutPDF.RIGHT);
    pdf.textAddToBox('Right aligned text', true);

    pdf.textSetAlign(BytescoutPDF.JUSTIFIED);
    pdf.textAddToBox('Justfied text Justfied text Justfied text Justfied text Justfied text Justfied text Justfied text Justfied text', true);

    // return BytescoutPDF object instance
    return pdf;
}

