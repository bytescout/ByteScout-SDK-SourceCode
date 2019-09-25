## How to add image to PDF from canvas in Javascript and ByteScout PDF Generator for Javascript

### Write code in Javascript to add image to PDF from canvas with this step-by-step tutorial

ByteScout tutorials are designed to explain the code for both Javascript beginners and advanced programmers. ByteScout PDF Generator for Javascript is the client-side Javascript library for PDF generation on client-side without server-side programming required. Can create invoices, tables with text, images, HTML formatting. It can add image to PDF from canvas in Javascript.

Fast application programming interfaces of ByteScout PDF Generator for Javascript for Javascript plus the instruction and the code below will help you quickly learn how to add image to PDF from canvas. Just copy and paste the code into your Javascript application’s code and follow the instruction. Test Javascript sample code examples whether they respond your needs and requirements for the project.

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

if (!IsInternetExplorer8OrLower) // images and drawings from canvas are supported on IE version 9 and higher, other modern browsers should work fine
{
    // create temporary canvas (you can also simply get existing canvas)
    var canvas = document.createElement('canvas');
    // set width and height
    canvas.width = 320;
    canvas.height = 240;

    // get context from canvas (to draw on)
    var context = canvas.getContext("2d");

    // set white background color
    context.fillStyle = "#EEEEEE";
    // and fill the background with white color
    context.fillRect(0, 0, 320, 240);

    // draw the yellow circle
    context.strokeStyle = "#000000";
    context.fillStyle = "#FFFF00";
    context.beginPath();
    context.arc(100, 100, 50, 0, Math.PI * 2, true);
    context.closePath();
    context.stroke();
    context.fill();

    // load image from canvas into BytescoutPDF
    pdf.imageLoadFromCanvas(canvas);

    // place this mage at given X, Y coordinates on the page
    pdf.imagePlace(20, 40);

    // place this mage at given coordinates and dimesionson on the page
    pdf.imagePlaceSetSize(20, 170, 0, 80, 60);
}

    // return BytescoutPDF object instance
    return pdf;
}


```

<!-- code block end -->