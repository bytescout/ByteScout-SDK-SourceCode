## How to draw line in PDF in Javascript using ByteScout PDF Generator for Javascript

### This tutorial will show how to draw line in PDF in Javascript

Learn how to draw line in PDF in Javascript with this source code sample. What is ByteScout PDF Generator for Javascript? It is the client-side Javascript library for PDF generation on client-side without server-side programming required. Can create invoices, tables with text, images, HTML formatting. It can help you to draw line in PDF in your Javascript application.

Javascript code samples for Javascript developers help to speed up coding of your application when using ByteScout PDF Generator for Javascript. In order to implement the functionality, you should copy and paste this code for Javascript below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in Javascript.

Free trial version of ByteScout PDF Generator for Javascript is available for download from our website. Get it to try other source code samples for Javascript.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Generator%20for%20Javascript%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Generator%20for%20Javascript%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=tC6w8k9uzCo](https://www.youtube.com/watch?v=tC6w8k9uzCo)




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


```

<!-- code block end -->