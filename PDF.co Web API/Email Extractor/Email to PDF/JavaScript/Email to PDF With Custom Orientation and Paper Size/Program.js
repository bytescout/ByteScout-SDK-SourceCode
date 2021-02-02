//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


var request = require('request');

var options = {
  'method': 'POST',
  'url': 'https://api.pdf.co/v1/pdf/convert/from/email',
  'headers': {
    'Content-Type': 'application/json',
    'x-api-key': '{{x-api-key}}'
  },
  body: JSON.stringify({"url":"https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/email-to-pdf/sample.eml","embedAttachments":true,"name":"email-with-attachments","async":false,"encrypt":false,"profiles":"{\"orientation\": \"landscape\", \"paperSize\": \"letter\" }"})

};

request(options, function (error, response) {
  if (error) throw new Error(error);
  console.log(response.body);
});
