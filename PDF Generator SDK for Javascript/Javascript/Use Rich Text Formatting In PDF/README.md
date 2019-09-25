## How to use rich text formatting in PDF in Javascript with ByteScout PDF Generator for Javascript

### How to code in Javascript to use rich text formatting in PDF with this step-by-step tutorial

Sample source code below will show you how to cope with a difficult task like use rich text formatting in PDF in Javascript. ByteScout PDF Generator for Javascript can use rich text formatting in PDF. It can be used from Javascript. ByteScout PDF Generator for Javascript is the client-side javascript library to generate pdf documents right in a browser with no server-side programming is required. Select fonts, use HTML formatting, generate tables with text wrapping, add images.

This code snippet below for ByteScout PDF Generator for Javascript works best when you need to quickly use rich text formatting in PDF in your Javascript application. In order to implement the functionality, you should copy and paste this code for Javascript below into your code editor with your app, compile and run your application. You can use these Javascript sample examples in one or many applications.

Trial version of ByteScout PDF Generator for Javascript can be downloaded for free from our website. It also includes source code samples for Javascript and other programming languages.

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