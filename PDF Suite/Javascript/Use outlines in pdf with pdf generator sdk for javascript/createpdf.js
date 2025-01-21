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
    
    var text = "The quick brown fox jumps over the lazy dog";

	// Add pages and text:
    pdf.pageAdd();
    pdf.addAnchor("#page1", 1, 0);
    pdf.textAdd(20, 20, text);
    pdf.textAdd(50, 220, text);
    pdf.textAdd(50, 420, text);
    pdf.textAdd(100, 620, text);
    
    pdf.pageAdd();
    pdf.addAnchor("#page2", 2, 0);
    pdf.textAdd(20, 20, text);
    
    pdf.pageAdd();
    pdf.addAnchor("#page3", 3, 0);
    pdf.textAdd(20, 20, text);

	// Make bookmarks (outlines):
	var first = pdf.addBookmark(null, "First Chapter", "#page1");
	pdf.addBookmark(first, "Part A", "#1#200");
	var firstB = pdf.addBookmark(first, "Part B", "#1#400");
	pdf.addBookmark(firstB, "Details", "#1#600");
	pdf.addBookmark(null, "Second Chapter", "#page2");
	pdf.addBookmark(null, "Third Chapter", "#page3");
	pdf.addBookmark(null, "External URL", "www.google.com");
	
	// return BytescoutPDF object instance
    return pdf;
}

