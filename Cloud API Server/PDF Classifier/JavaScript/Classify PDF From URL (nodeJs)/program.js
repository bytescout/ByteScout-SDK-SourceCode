//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


var request = require('request');
var options = {
	'method': 'POST',
	'url': 'http://localhost:80/pdf/classifier',
	'headers': {
		'Content-Type': 'application/json'
	},
	body: JSON.stringify({
	 "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/document-parser/sample-invoice.pdf",
	 "rulescsv": "Amazon,Amazon Web Services Invoice|Amazon CloudFront\nDigital Ocean,DigitalOcean|DOInvoice\nAcme,ACME Inc.|1540 Long Street, Jacksonville, 32099",
	 "caseSensitive": "true",
	 "async": false,
	 "encrypt": "false",
	 "inline": "true",
	 "password": "",
	 "profiles": ""
	})

};
request(options, function (error, response) {
	if (error) throw new Error(error);
	console.log(response.body);
});

