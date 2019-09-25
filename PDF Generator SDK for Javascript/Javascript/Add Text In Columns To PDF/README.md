## How to add text in columns to PDF in Javascript using ByteScout PDF Generator for Javascript

### This code in Javascript shows how to add text in columns to PDF with this how to tutorial

These source code samples are listed and grouped by their programming language and functions they use. Want to add text in columns to PDF in your Javascript app? ByteScout PDF Generator for Javascript is designed for it. ByteScout PDF Generator for Javascript is the client-side javascript library to generate pdf documents right in a browser with no server-side programming is required. Select fonts, use HTML formatting, generate tables with text wrapping, add images.

This code snippet below for ByteScout PDF Generator for Javascript works best when you need to quickly add text in columns to PDF in your Javascript application. This Javascript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test Javascript sample code examples whether they respond your needs and requirements for the project.

Trial version of ByteScout PDF Generator for Javascript is available for free. Source code samples are included to help you with your Javascript app.

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

    // add new page
    pdf.pageAdd();

	pdf.textSetBoxPadding(3);

    // set text box for first column
    pdf.textSetBox(50, 50, 200, 200);
    // draw a rectangle around it
    pdf.graphicsDrawRectangle(50, 50, 200, 200);
    // add text:
    pdf.textAddToBox('café, communiqué, fête, fiancée, mêlée, émigré, pâté, protégé; First column', true);
    pdf.textAddToBox('First column', true);
    pdf.textAddToBox('First column', true);

    // set text box for second column
    pdf.textSetBox(250, 50, 200, 200);
    // draw a rectangle around it
    pdf.graphicsDrawRectangle(250, 50, 200, 200);
    // add text:
    pdf.textAddToBox('Second column', true);
    pdf.textAddToBox('Second column', true);
    pdf.textAddToBox('Second column', true);

    // return BytescoutPDF object instance
    return pdf;
}


```

<!-- code block end -->