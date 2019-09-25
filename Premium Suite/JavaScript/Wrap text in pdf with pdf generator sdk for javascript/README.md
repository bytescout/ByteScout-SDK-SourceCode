## wrap text in pdf with pdf generator sdk for javascript in JavaScript using ByteScout Premium Suite

### Build wrap text in pdf with pdf generator sdk for javascript in JavaScript: ### Step-by-step instructions on how to do wrap text in pdf with pdf generator sdk for javascript in JavaScript

ByteScout tutorials describe the stuff for programmers who use JavaScript. Wrap text in pdf with pdf generator sdk for javascript in JavaScript can be applied with ByteScout Premium Suite. ByteScout Premium Suite is the set that includes 12 SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording.

If you want to quickly learn then these fast application programming interfaces of ByteScout Premium Suite for JavaScript plus the guideline and the JavaScript code below will help you quickly learn wrap text in pdf with pdf generator sdk for javascript. Follow the steps-by-step instructions from the scratch to work and copy and paste code for JavaScript into your editor. Check these JavaScript sample code examples to see if they acknowledge to your needs and requirements for the project.

ByteScout Premium Suite free trial version is available for download from our website. Free trial also includes programming tutorials along with source code samples.

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

	pdf.textSetBoxPadding(3);
	
    // set text box
    pdf.textSetBox(50, 50, 500, 100);
    // and draw a rectangle around it
    pdf.graphicsDrawRectangle(50, 50, 500, 100);

    // add text with default alignment
    pdf.textAddToBox('café, communiqué, fête, fiancée, mêlée, émigré, pâté, protégé; Left aligned text Left aligned text Left aligned text Left aligned text Left aligned text Left aligned text Left aligned text', true);

    // set another text box
    pdf.textSetBox(50, 200, 500, 100);
    // and draw a rectangle around it
    pdf.graphicsDrawRectangle(50, 200, 500, 100);

    // add justified text
    pdf.textSetAlign(BytescoutPDF.JUSTIFIED);
    pdf.textAddToBox('café, communiqué, fête, fiancée, mêlée, émigré, pâté, protégé; Justfied text Justfied text Justfied text Justfied text Justfied text Justfied text Justfied text Justfied text Justfied text', true);

    // return BytescoutPDF object instance
    return pdf;
}


```

<!-- code block end -->