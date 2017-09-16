//****************************************************************************//
//                                                                            //
// Download evaluation version: https://bytescout.com/download/web-installer  //
//                                                                            //
// Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    //
//                                                                            //
// Copyright © 2017 ByteScout Inc. All rights reserved.                       //
// http://www.bytescout.com                                                   //
//                                                                            //
//****************************************************************************//


// HelloWorld.cpp : main project file.

#include "stdafx.h"

using namespace System;
using namespace System::IO;
using namespace Bytescout::Spreadsheet;

int main(array<System::String ^> ^args)
{
    // Create new Spreadsheet
	Spreadsheet document;

	// Add new worksheet
	Worksheet^ worksheet = document.Workbook->Worksheets->Add("HelloWorld");

	// Set cell value
	worksheet->Cell(0, 0)->Value = "Hello, World!";

	// delete output file if exists already
	if (File::Exists("Output.xls"))
	{
		File::Delete("Output.xls");
	}

	// Save document
	document.SaveAs("Output.xls");

	// Close Spreadsheet
	document.Close();

	System::Diagnostics::Process::Start("Output.xls");

    return 0;
}
