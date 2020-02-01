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


#include "stdafx.h"

//
// This example demonstrates how to provide password for protected PDF files.
//

using namespace System;
using Bytescout::PDFExtractor::XLSExtractor;


// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::EventArgs ^e);


int main(array<System::String ^> ^args)
{
	String^ input(".\\encrypted (password is 'password').pdf");
	String^ output(".\\result.xls");

	// Create XLSExtractor instance
	XLSExtractor^ pExtractor = gcnew XLSExtractor("demo", "demo");

	// Handle `PasswordRequired` event
	pExtractor->PasswordRequired += gcnew System::EventHandler(&OnPasswordRequired);

	// Load PDF document
	pExtractor->LoadDocumentFromFile(input);

	// Save Excel document
	pExtractor->SaveToXLSFile(output);

	delete pExtractor;

	// Open the output document in default associated application (for demonstration)
	Diagnostics::Process::Start(output);
	
    return 0;
}

// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::EventArgs ^e)
{
	// Ask user for password and put it to `Password` property.
	safe_cast<XLSExtractor^>(sender)->Password = "password";
}
