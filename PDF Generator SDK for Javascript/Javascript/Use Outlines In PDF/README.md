## How to use outlines in PDF in Javascript using ByteScout PDF Generator for Javascript

### This tutorial will show how to use outlines in PDF in Javascript

With this source code sample you may quickly learn how to use outlines in PDF in Javascript. ByteScout PDF Generator for Javascript can use outlines in PDF. It can be used from Javascript. ByteScout PDF Generator for Javascript is the client-side Javascript library for PDF generation on client-side without server-side programming required. Can create invoices, tables with text, images, HTML formatting.

The SDK samples like this one below explain how to quickly make your application do use outlines in PDF in Javascript with the help of ByteScout PDF Generator for Javascript. Just copy and paste the code into your Javascript application’s code and follow the instruction. Use of ByteScout PDF Generator for Javascript in Javascript is also explained in the documentation included along with the product.

You can download free trial version of ByteScout PDF Generator for Javascript from our website to see and try many others source code samples for Javascript.

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


```

<!-- code block end -->