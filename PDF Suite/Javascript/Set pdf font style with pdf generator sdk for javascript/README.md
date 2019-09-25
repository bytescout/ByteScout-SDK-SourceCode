## How to set pdf font style with pdf generator sdk for javascript in Javascript with ByteScout PDF Suite

### Learning is essential in computer world and the tutorial below will demonstrate how to set pdf font style with pdf generator sdk for javascript in Javascript

The sample source codes on this page shows how to set pdf font style with pdf generator sdk for javascript in Javascript. ByteScout PDF Suite is the bundle that provides six different SDK libraries to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can be applied to set pdf font style with pdf generator sdk for javascript using Javascript.

Want to quickly learn? This fast application programming interfaces of ByteScout PDF Suite for Javascript plus the guidelines and the code below will help you quickly learn how to set pdf font style with pdf generator sdk for javascript.  Simply copy and paste in your Javascript project or application you and then run your app! If you want to use these Javascript sample examples in one or many applications then they can be used easily.

ByteScout PDF Suite free trial version is available on our website. Javascript and other programming languages are supported.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

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