## How to set PDF font name in Javascript with ByteScout PDF Generator for Javascript

### Tutorial on how to set PDF font name in Javascript

The documentation is designed to help you to implement the features on your side. Want to set PDF font name in your Javascript app? ByteScout PDF Generator for Javascript is designed for it. ByteScout PDF Generator for Javascript is the client-side Javascript library for PDF generation on client-side without server-side programming required. Can create invoices, tables with text, images, HTML formatting.

You will save a lot of time on writing and testing code as you may just take the Javascript code from ByteScout PDF Generator for Javascript for set PDF font name below and use it in your application. This Javascript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! Test Javascript sample code examples whether they respond your needs and requirements for the project.

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

    // set page size
    pdf.pageSetSize(BytescoutPDF.A4);

    // set page orientation (BytescoutPDF.PORTRAIT = portrait, BytescoutPDF.LANDSCAPE = landscape)
    pdf.pageSetOrientation(BytescoutPDF.PORTRAIT);

    // add new page
    pdf.pageAdd();

    // set font color in RGB format to 0,0,0 - black color
    pdf.fontSetColor(0, 0, 0);

    // set font size
    pdf.fontSetSize(14);

    // BytescoutPDF.js provides support for built-in PDF fonts
    // which are demonstrated in this sample

    // trying Times-Roman
    pdf.fontSetName('Times-Roman');
    // draw text
    pdf.textAdd(20, 20, 'Hello Times Roman!');

    // trying Helvetica
    pdf.fontSetName('Helvetica');
    // draw text
    pdf.textAdd(20, 60, 'Hello Helvetica!');

    // trying Courier-Bold
    pdf.fontSetName('Courier');
    // draw text
    pdf.textAdd(20, 100, 'Hello Courier!');

    // set zapf dingbats built in font to use
    pdf.fontSetName("zapfDingbats");
    pdf.fontSetSize(25);

    // draw symbols, see map of letters to symbols at https://images.google.com/?q=zapf+dingbats+font+symbols
    pdf.textSetBox(10,150,500,300); // define output rectangle
    pdf.textAddToBox("1234567890!@#$%^&*()ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")

    // set symbol font
    pdf.fontSetName("Symbol");
    pdf.fontSetSize(25);

    // draw symbols, see map of letters to symbols at https://images.google.com/?q=zapf+dingbats+font+symbols
    pdf.textSetBox(10,310,500,800); // define output rectangle
    pdf.textAddToBox("1234567890!@#$%^&*()ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz")

    

    // return BytescoutPDF object instance
    return pdf;
}


```

<!-- code block end -->