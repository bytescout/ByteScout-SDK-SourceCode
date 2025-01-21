//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

var request = require('request');
var fs = require('fs');
var options = {
  'method': 'POST',
  'url': 'https://localhost/file/upload',
  'headers': {
    'x-api-key': '{{x-api-key}}'
  },
  formData: {
    'file': {
      'value': fs.createReadStream('/path/to/file'),
      'options': {
        'filename': 'filename'
        'contentType': null
      }
    }
  }
};
request(options, function (error, response) {
  if (error) throw new Error(error);
  console.log(response.body);
});
