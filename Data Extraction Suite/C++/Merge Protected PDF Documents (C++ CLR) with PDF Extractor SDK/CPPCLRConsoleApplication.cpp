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
using Bytescout::PDFExtractor::DocumentMerger;


// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::String ^document, System::String ^%password);


int main(array<System::String ^> ^args)
{
	String^ input1(".\\encrypted1 (password is 'password').pdf");
	String^ input2(".\\encrypted2 (password is 'password').pdf");
	String^ output(".\\result.pdf");

	// Create DocumentMerger instance
	DocumentMerger^ merger = gcnew DocumentMerger("demo", "demo");

	// Handle `PasswordRequired` event
	merger->PasswordRequired += gcnew Bytescout::PDFExtractor::PasswordEventHandler(&OnPasswordRequired);

	// Ignore document permissions
	merger->CheckPermissions = false;

	// Merge documents 
	array<String^>^ files = gcnew array<String^>(2) { input1, input2 };
	merger->Merge(files, output);

	delete merger;

	// Open the output document in default associated application (for demonstration)
	Diagnostics::Process::Start(output);
	
    return 0;
}

// `PasswordRequired` event handler
void OnPasswordRequired(System::Object ^sender, System::String ^document, System::String ^%password)
{
	// Ask user for password and put it to `Password` property.
	password = "password";
}
