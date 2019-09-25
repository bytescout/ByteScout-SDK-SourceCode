## How to set PDF page orientation in Javascript and ByteScout PDF Generator for Javascript

### This code in Javascript shows how to set PDF page orientation with this how to tutorial

Learn how to set PDF page orientation in Javascript with this source code sample. ByteScout PDF Generator for Javascript is the client-side Javascript library for PDF generation on client-side without server-side programming required. Can create invoices, tables with text, images, HTML formatting. It can be used to set PDF page orientation using Javascript.

Fast application programming interfaces of ByteScout PDF Generator for Javascript for Javascript plus the instruction and the code below will help you quickly learn how to set PDF page orientation. In your Javascript project or application you may simply copy & paste the code and then run your app! You can use these Javascript sample examples in one or many applications.

ByteScout free trial version is available for download from our website. It includes all these programming tutorials along with source code samples.

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

    // add a page with portrait orientation
    pdf.pageSetOrientation(BytescoutPDF.PORTRAIT); // BytescoutPDF.PORTRAIT = portrait, BytescoutPDF.LANDSCAPE = landscape
    pdf.pageAdd();
    
    pdf.textAdd(50, 50, 'Portrait page orientation', 0);
    
    // add a page with landscape orientation
    pdf.pageSetOrientation(BytescoutPDF.LANDSCAPE);
    pdf.pageAdd();
    
    pdf.textAdd(50, 50, 'Landscape page orientation', 0);

    // return BytescoutPDF object instance
    return pdf;
}


```

<!-- code block end -->