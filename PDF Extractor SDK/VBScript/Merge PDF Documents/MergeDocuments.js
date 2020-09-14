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


var merger = new ActiveXObject("Bytescout.PDFExtractor.DocumentMerger");
merger.RegistrationName = "demo";
merger.RegistrationKey = "demo";

var comHelpers = new ActiveXObject("Bytescout.PDFExtractor.ComHelpers");

var aFiles = ['.. \ .. \ sample1.pdf', '.. \ .. \ sample2.pdf'];
var compArray = comHelpers.CreateCompatibleArray(aFiles);

filename = 'output.pdf';
merger.Merge(compArray, filename);
merger = null;
