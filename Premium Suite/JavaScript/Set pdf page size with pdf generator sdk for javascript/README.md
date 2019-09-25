## How to set pdf page size with pdf generator sdk for javascript in JavaScript with ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to set pdf page size with pdf generator sdk for javascript in JavaScript

Every ByteScout tool includes simple example JavaScript source codes that you can get here or in the folder with installed ByteScout product. ByteScout Premium Suite: the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can set pdf page size with pdf generator sdk for javascript in JavaScript.

The following code snippet for ByteScout Premium Suite works best when you need to quickly set pdf page size with pdf generator sdk for javascript in your JavaScript application. Just copy and paste the code into your JavaScript application’s code and follow the instructions. Enjoy writing a code with ready-to-use sample codes in JavaScript.

You can download free trial version of ByteScout Premium Suite from our website to see and try many others source code samples for JavaScript.

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


```

<!-- code block end -->