## How to draw invoice spanning multiple page in Javascript and ByteScout PDF Generator for Javascript

### Write code in Javascript to draw invoice spanning multiple page with this step-by-step tutorial

The sample source code below will teach you how to draw invoice spanning multiple page in Javascript. Want to draw invoice spanning multiple page in your Javascript app? ByteScout PDF Generator for Javascript is designed for it. ByteScout PDF Generator for Javascript is the client-side javascript library to generate pdf documents right in a browser with no server-side programming is required. Select fonts, use HTML formatting, generate tables with text wrapping, add images.

The SDK samples like this one below explain how to quickly make your application do draw invoice spanning multiple page in Javascript with the help of ByteScout PDF Generator for Javascript. Just copy and paste the code into your Javascript application’s code and follow the instruction. Test Javascript sample code examples whether they respond your needs and requirements for the project.

ByteScout PDF Generator for Javascript free trial version is available on our website. Javascript and other programming languages are supported.

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

// This is page start height which will be available after drawing of page header
var PageHeightUtilized = 90;

// This is total page height which will be available after deduction of footer
var TotalPageHeight = 740;

// create BytescoutPDF object instance
var pdf = new BytescoutPDF();

function CreatePDF(IsInternetExplorer8OrLower) {

    // set document properties: Title, subject, keywords, author name and creator name
    pdf.propertiesSet('Sample Invoice', 'Invoice #1234', 'invoice, company, customer', 'Document Author', 'Document Creator');

    // set page size
    pdf.pageSetSize(BytescoutPDF.Letter);

    // set portrait page orientation
    pdf.pageSetOrientation(BytescoutPDF.PORTRAIT);

    // set font name
    pdf.fontSetName('Times-Roman');

    // add header for all pages
    pdf.onHeader(function () {

        // we can use images only if we are on IE9 or higher (or non-IE browser)
        if (!IsInternetExplorer8OrLower) {
            // add logo
            pdf.imageLoadFromUrl('logo.png');
            pdf.imagePlace(20, 20);
        }

        // add requisites
        pdf.fontSetStyle(true, false, false);
        pdf.fontSetSize(24);
        pdf.textAdd(450, 55, 'INVOICE');

        pdf.fontSetSize(16);
        pdf.textAdd(200, 20, '(keine Rückerstattung)');

    });

    // add footer for all pages
    pdf.onFooter(function () {

        pdf.graphicsDrawLine(20, 750, 590, 750);

        pdf.fontSetSize(10);
        pdf.fontSetStyle(false, true, false);
        pdf.textAdd(20, 770, 'Page ' + pdf.pageGetIndex() + ' of ' + pdf.pageGetCount());
    });

    // add new page
    addNewPage(pdf);

    pdf.fontSetSize(12);
    pdf.textAdd(50, 90, 'COMPANY NAME', 0);

    pdf.fontSetSize(11);
    pdf.fontSetStyle(false, false, false);
    pdf.textAdd(50, 120, 'Address', 0);
    pdf.textAdd(50, 140, 'Phone, fax', 0);
    pdf.textAdd(50, 160, 'E-mail', 0);

    pdf.textAdd(400, 120, 'DATE', 0);
    pdf.textAdd(400, 140, 'INVOICE #', 0);
    pdf.textAdd(400, 160, 'FOR', 0);

    // Update PageHeightUtilized
    PageHeightUtilized = 160;

    // Add some space 
    PageHeightUtilized += 40;

    var NoOfRows = +$("#txtNoOfRows").val();
    AddTableToPDF(NoOfRows);

    // Check whether new page needed to add signature section
    if (checkNewPageNeeded(50)) {
        // Add new page
        addNewPage();
    }

    // add signature
    pdf.fontSetSize(13);
    pdf.textAdd(395, (PageHeightUtilized + 50), 'Signature', 0);
    pdf.graphicsDrawLine(450, (PageHeightUtilized + 50), 570, (PageHeightUtilized + 50));

    // return BytescoutPDF object instance
    return pdf;
}

function checkNewPageNeeded(expectedElementHeight) {
    return (PageHeightUtilized + expectedElementHeight) > TotalPageHeight;
}

function addNewPage() {
    // add new page
    pdf.pageAdd();

    // reset Page Utilized height to initial height which will be available after adding header;
    PageHeightUtilized = 100;
}

function AddTableToPDF(NoOfRows) {

    // Start adding table
    pdf.textSetBoxPadding(3, 2, 2, 3);

    var isHeaderAdded = false;

    for (let itmRow = 1; itmRow <= NoOfRows;) {
        if (checkNewPageNeeded(20)) {
            // Add new page
            addNewPage();

            // Reset Header Added
            isHeaderAdded = false;
        }

        if (!isHeaderAdded) {
            addTableHeaderRow();
            isHeaderAdded = true;
        }
        else {
            addTableRow(itmRow);

            // Decrease no of rows
            itmRow++;
        }
    }
}

function addTableHeaderRow() {

    pdf.fontSetSize(12);
    pdf.fontSetStyle(true, false, false);

    // draw table header
    pdf.graphicsDrawRectangle(50, PageHeightUtilized, 520, 20);

    pdf.graphicsDrawLine(50, (PageHeightUtilized + 20), 570, (PageHeightUtilized + 20));
    pdf.textSetAlign(BytescoutPDF.LEFT);

    // add 'Description' column
    pdf.textSetBox(50, PageHeightUtilized, 220, 20);
    pdf.textAddToBox('Description');
    pdf.graphicsDrawLine(270, PageHeightUtilized, 270, (PageHeightUtilized + 20));

    // add 'Quantity' column
    pdf.textSetBox(270, PageHeightUtilized, 80, 20);
    pdf.textAddToBox('Quantity');
    pdf.graphicsDrawLine(350, PageHeightUtilized, 350, (PageHeightUtilized + 20));

    // add 'Price' column
    pdf.textSetAlign(BytescoutPDF.RIGHT);
    pdf.textSetBox(350, PageHeightUtilized, 100, 20);
    pdf.textAddToBox('Price');
    pdf.graphicsDrawLine(450, PageHeightUtilized, 450, (PageHeightUtilized + 20));

    // add 'Amount' column
    pdf.textSetBox(450, PageHeightUtilized, 120, 20);
    pdf.textAddToBox('Amount');

    // Increase PageHeightUtilized
    PageHeightUtilized += 20;
}

function addTableRow(rowNo) {

    pdf.fontSetSize(11);
    pdf.fontSetStyle(false, false, false);

    // draw table header
    pdf.graphicsDrawRectangle(50, PageHeightUtilized, 520, 20);
    pdf.graphicsDrawLine(50, (PageHeightUtilized + 20), 570, (PageHeightUtilized + 20));
    pdf.textSetAlign(BytescoutPDF.LEFT);

    // add 'Description' column
    pdf.textSetBox(50, PageHeightUtilized, 220, 20);
    pdf.textAddToBox('Description for item - ' + rowNo);
    pdf.graphicsDrawLine(270, PageHeightUtilized, 270, (PageHeightUtilized + 20));

    // add 'Quantity' column
    pdf.textSetBox(270, PageHeightUtilized, 80, 20);
    pdf.textAddToBox('###');
    pdf.graphicsDrawLine(350, PageHeightUtilized, 350, (PageHeightUtilized + 20));

    pdf.textSetAlign(BytescoutPDF.RIGHT);
    // add 'Price' column
    pdf.textSetBox(350, PageHeightUtilized, 100, 20);
    pdf.textAddToBox('$
```

<!-- code block end -->    
);
    pdf.graphicsDrawLine(450, PageHeightUtilized, 450, (PageHeightUtilized + 20));

    // add 'Amount' column
    pdf.textSetBox(450, PageHeightUtilized, 120, 20);
    pdf.textAddToBox('$.
);

    // Increase PageHeightUtilized
    PageHeightUtilized += 20;

}
```

<!-- code block end -->