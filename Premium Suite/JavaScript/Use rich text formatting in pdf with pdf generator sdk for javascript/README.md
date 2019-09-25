## How to use rich text formatting in pdf with pdf generator sdk for javascript in JavaScript using ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to use rich text formatting in pdf with pdf generator sdk for javascript in JavaScript

This sample source code below will display you how to use rich text formatting in pdf with pdf generator sdk for javascript in JavaScript. What is ByteScout Premium Suite? It is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can help you to use rich text formatting in pdf with pdf generator sdk for javascript in your JavaScript application.

The SDK samples given below describe how to quickly make your application do use rich text formatting in pdf with pdf generator sdk for javascript in JavaScript with the help of ByteScout Premium Suite. This JavaScript sample code is all you need for your app. Just copy and paste the code, add references (if needs to) and you are all set! If you want to use these JavaScript sample examples in one or many applications then they can be used easily.

ByteScout provides the free trial version of ByteScout Premium Suite along with the documentation and source code samples.

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


    // add new page
    pdf.pageAdd();

    // draw formatted text
    pdf.textAdd(20, 50, 'You can use HTML tags for text formatting: &lt;b&gt; for <b>bold</b> and &lt;i&gt; for <i>italic</i> or &lt;s&gt; for <s>striked style</s>.');

    // draw formatted text
    pdf.textAdd(10, 100, 'You may also change <font face="Helvetica" size="20" color="#0000ff">font size and</font> <font face="Courier" size="20" color="#ff0000">color</font> and use <u><b>mixed <i>styles</i></b></u>.');


    // draw formatted text
    pdf.textAdd(10, 140, 'Zapf-Dingbats and Symbol fonts:');

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