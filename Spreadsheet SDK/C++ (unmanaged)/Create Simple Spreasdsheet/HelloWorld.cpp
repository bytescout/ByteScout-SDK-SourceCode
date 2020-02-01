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


// IMPORTANT: Copy ByteScout.Spreadsheet.tlb into the project folder
// HelloWorld.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <windows.h>

#pragma warning (disable: 4278)


#import "c:\windows\system32\stdole2.tlb" rename_namespace("BytescoutSpreadsheet") exclude("GUID", "DISPPARAMS", "EXCEPINFO",  \
	"OLE_XPOS_PIXELS", "OLE_YPOS_PIXELS", "OLE_XSIZE_PIXELS", "OLE_YSIZE_PIXELS", "OLE_XPOS_HIMETRIC",  \
	"OLE_YPOS_HIMETRIC", "OLE_XSIZE_HIMETRIC", "OLE_YSIZE_HIMETRIC", "OLE_XPOS_CONTAINER", \
	"OLE_YPOS_CONTAINER", "OLE_XSIZE_CONTAINER", "OLE_YSIZE_CONTAINER", "OLE_HANDLE", "OLE_OPTEXCLUSIVE", \
	"OLE_CANCELBOOL", "OLE_ENABLEDEFAULTBOOL", "FONTSIZE", "OLE_COLOR")


// To use managed-code servers like the C# server, 
// we have to import the common language runtime:
#import <mscorlib.tlb> raw_interfaces_only
#import <System.tlb> raw_interfaces_only
#import <System.Drawing.tlb> raw_interfaces_only

#import "Bytescout.Spreadsheet.tlb" rename_namespace("BytescoutSpreadsheet") //no_namespace named_guids 
int main(int argc, char* argv[])
{
	// initialize OLE
	HRESULT hr = CoInitialize(NULL);

	// check for errors
	if (FAILED(hr)) {
	MessageBox(0,"OLE initialization errp","error",MB_OK);
	return -1;
	}
	// declare document object

	ISpreadsheet * Doc = NULL;
	CLSID clsid;
		_Worksheets* worksheets = NULL;
		_Worksheet* worksheet = NULL;
			_Cell* cell = NULL;

	// get inuque ID for ISpreadsheet interface
	hr = CLSIDFromProgID(OLESTR("Bytescout.Spreadsheet.Spreadsheet"), &clsid);
	// check for errors
	if (FAILED(hr)) {
	MessageBox(0,"Can't get CLSID for ISpreadsheet interface","error",MB_OK);
	goto Uninit;
	};
	// create Spreadsheet object
	hr = CoCreateInstance(clsid, NULL, CLSCTX_INPROC_SERVER, __uuidof(ISpreadsheet), (LPVOID*)&Doc);
	// check for errors
	if (FAILED(hr)) {
	MessageBox(0,"Can't create Spreadsheet object","error",MB_OK);
	goto Uninit;
	}

	//IWorksheets* worksheets = NULL;
	

	Doc->get_Worksheets(&worksheets);




	worksheet = reinterpret_cast<IWorksheets*>(worksheets)->Add("Sheet 1");



	cell = reinterpret_cast<IWorksheet*>(worksheet)->Cell("A1");

	reinterpret_cast<ICell*>(cell)->PutValueAsHTML("test value");
	
	Doc->SaveAs("output.xls");

	// release PDFDoc object
	Doc->Release();

	// uninitialize OLE libraries
	Uninit:
	CoUninitialize();
	return 0;
}

