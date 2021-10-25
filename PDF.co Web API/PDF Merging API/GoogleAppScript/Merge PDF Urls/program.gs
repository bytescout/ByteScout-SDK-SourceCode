// Handle PDF.co Menu on Google Sheet Open Event
function onOpen() {
  var spreadsheet = SpreadsheetApp.getActive();
  var menuItems = [
    {name: 'CreatePDF', functionName: 'mergePDFDocuments'} 
  ];
  spreadsheet.addMenu('PDF.co', menuItems);
}
  
/**
 * A function that adds headers and some initial data to the spreadsheet.
 */
function mergePDFDocuments() {
  var spreadsheet = SpreadsheetApp.getActive();

  // Get PDF.co API Key Cell
  let pdfCoAPIKeyCell = spreadsheet.getRange("B1");

  // Get Cells for Input/Output
  let pdfUrlCell = spreadsheet.getRange("A4"); 
  let resultUrlCell =  spreadsheet.getRange("B4");

  let pdfCoAPIKey = pdfCoAPIKeyCell.getValue();
  let pdfUrl = pdfUrlCell.getValue();
  
  // Prepare Payload
  var data = {
    "async": false,
    "encrypt": false,
    "inline": true,
    "name": "result",
    "url": pdfUrl
  };

  // Prepare Request Options
  var options = {
    'method' : 'post',
    'contentType': 'application/json',
    'headers': {
      "x-api-key": pdfCoAPIKey
    },
    // Convert the JavaScript object to a JSON string.
    'payload' : JSON.stringify(data)
  };
  
  // Get Response
  // https://developers.google.com/apps-script/reference/url-fetch
  var pdfCoResponse = UrlFetchApp.fetch('https://api.pdf.co/v1/pdf/merge', options);

  var pdfCoRespContent = pdfCoResponse.getContentText();
  var pdfCoRespJson = JSON.parse(pdfCoRespContent);

  // Display Result
  if(!pdfCoRespJson.error){
    resultUrlCell.setValue(pdfCoRespJson.url);
  }
  else{
    resultUrlCell.setValue(pdfCoRespJson.message);
  }
}
  