//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


var merger = new ActiveXObject("Bytescout.PDFExtractor.DocumentMerger");
merger.RegistrationName = "demo";
merger.RegistrationKey = "demo";

var comHelpers = new ActiveXObject("Bytescout.PDFExtractor.ComHelpers");

var aFiles = ['.. \ .. \ sample1.pdf', '.. \ .. \ sample2.pdf'];
var compArray = comHelpers.CreateCompatibleArray(aFiles);

filename = 'output.pdf';
merger.Merge(compArray, filename);
merger = null;
