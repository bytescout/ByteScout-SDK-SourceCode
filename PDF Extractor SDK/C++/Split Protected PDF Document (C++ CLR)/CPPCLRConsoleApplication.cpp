//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


#include "stdafx.h"

//
// This example demonstrates how to provide password for protected PDF files.
//

using namespace System;
using Bytescout::PDFExtractor::DocumentSplitter;


// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::String ^document, System::String ^%password);


int main(array<System::String ^> ^args)
{
	String^ input(".\\encrypted (password is 'password').pdf");
	String^ output1(".\\result1.pdf");
	String^ output2(".\\result2.pdf");

	// Create DocumentSplitter instance
	DocumentSplitter^ merger = gcnew DocumentSplitter("demo", "demo");

	// Handle `PasswordRequired` event
	merger->PasswordRequired += gcnew Bytescout::PDFExtractor::PasswordEventHandler(&OnPasswordRequired);

	// Ignore document permissions
	merger->CheckPermissions = false;

	// Split document
	merger->Split(input, output1, output2, 3);

	delete merger;

	// Open the output documents in default associated application (for demonstration)
	Diagnostics::Process::Start(output1);
	Diagnostics::Process::Start(output2);
	
    return 0;
}

// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::String ^document, System::String ^%password)
{
	// Ask user for password and put it to `Password` property.
	password = "password";
}
