//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//



 var bc = WScript.CreateObject('Bytescout.BarCode.Barcode');

 // set symbology to Code39
 bc.Symbology = 1; // 1 = Code39 symbology type

 // set barcode value to encode
 bc.Value = "012345";

 // Saving Code39 barcode to 'Code39.png'

 bc.SaveImage ("Code39.png");

 // Encoding '012345' using Aztec symbology

 // set symbology to Aztec (2D)
 bc.Symbology = 17; // 17 = Aztec

 // set barcode value to encode
 bc.Value = "012345";

 // Encoding '012345' using Aztec  symbology" & vbCRLF & bc.GetValueRestrictions(17), where 17 = Code39 symbology

 bc.SaveImage ("Aztec.png");

 bc = null
