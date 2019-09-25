## How to set pdf font style with pdf generator sdk for javascript in JavaScript with ByteScout Premium Suite

### Learn to set pdf font style with pdf generator sdk for javascript in JavaScript

These source code samples are assembled by their programming language and functions they apply. What is ByteScout Premium Suite? It is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to set pdf font style with pdf generator sdk for javascript in your JavaScript application.

Want to quickly learn? This fast application programming interfaces of ByteScout Premium Suite for JavaScript plus the guidelines and the code below will help you quickly learn how to set pdf font style with pdf generator sdk for javascript. This JavaScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Further improvement of the code will make it more robust.

Our website gives trial version of ByteScout Premium Suite for free. It also includes documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****checkdatauri.js:**
    
```
	// checks if we have datauri support in current browser
        // if we have support for datauri support then we can stream generated PDF right into the browser
        // otherwise we should use Downloadify script to allow user to save PDF file
	function CheckDataURISupport(){

	var result = true;
	var checkDataURISupportImage = new Image();

	checkDataURISupportImage.onload = checkDataURISupportImage.onerror = function(){
		if(this.width != 1 || this.height != 1){
			result = false;
		}
	}
	checkDataURISupportImage.src = "data:image/gif;base64,R0lGODlhAQABAAD/ACwAAAAAAQABAAACADs=";
	// check if we have datauri support in current browser - end

		return result;
	}


```

<!-- code block end -->    

<!-- code block begin -->

##### ****createpdf.js:**
    
```
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

    // set font name
    pdf.fontSetName('Times-Roman');
    // set font size
    pdf.fontSetSize(16);

    // set font style with parameters: bold, italic, underline
    pdf.fontSetStyle(true, false, false, true);

    // set font color in RGB format to 25,25,255 - blue color
    pdf.fontSetColor(0, 0, 255);

    // draw text
    pdf.textAdd(20, 20, 'Trying Bold Style');

    // set font style to bold underline
    pdf.fontSetStyle(true, false, true);

    // set font color to red
    pdf.fontSetColor(255, 0, 0);

    // draw text
    pdf.textAdd(20, 40, 'Trying Bold Underline Style and <s>striked</s> text');

    // set font style to underline
    pdf.fontSetStyle(false, false, true);

    // set font color to green
    pdf.fontSetColor(0, 255, 0);

    // draw text
    pdf.textAdd(20, 60, 'Trying Underline Style');

    // return BytescoutPDF object instance
    return pdf;
}


```

<!-- code block end -->