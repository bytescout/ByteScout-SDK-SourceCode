//*****************************************************************************************//
//                                                                                         //
// Download offline evaluation version (DLL): https://bytescout.com/download/web-installer //
//                                                                                         //
// Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   //
//                                                                                         //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               //
// http://www.bytescout.com                                                                //
//                                                                                         //
//*****************************************************************************************//



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
