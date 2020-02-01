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
#include "comip.h"

#import "c:\\Program Files\\Bytescout PDF Extractor SDK\\net4.00\\Bytescout.PDFExtractor.tlb" raw_interfaces_only

using namespace Bytescout_PDFExtractor;

int _tmain(int argc, _TCHAR* argv[])
{
	// Initialize COM.
	HRESULT hr = CoInitializeEx(NULL, COINIT_APARTMENTTHREADED);

	// Create CSVExtractor instance
	_CSVExtractorPtr pICSVExtractor(__uuidof(CSVExtractor));
	pICSVExtractor->put_RegistrationName(_bstr_t(L"DEMO"));
	pICSVExtractor->put_RegistrationKey(_bstr_t(L"DEMO"));

	// Create TableDetector instance
	_TableDetectorPtr pITableDetector(__uuidof(TableDetector));
	pITableDetector->put_RegistrationName(_bstr_t(L"DEMO"));
	pITableDetector->put_RegistrationKey(_bstr_t(L"DEMO"));

	// Set table detection mode to "bordered tables" - best for tables with closed solid borders.
	pITableDetector->put_ColumnDetectionMode(ColumnDetectionMode_BorderedTables);

	// We should define what kind of tables we should detect.
	// So we set min required number of columns to 2 ...
	pITableDetector->put_DetectionMinNumberOfColumns(2);
	// ... and we set min required number of rows to 2
	pITableDetector->put_DetectionMinNumberOfRows(2);

	// Load sample PDF document
	_bstr_t inputFile(L"..\\..\\sample3.pdf");
	pICSVExtractor->LoadDocumentFromFile(inputFile);
	pITableDetector->LoadDocumentFromFile(inputFile);

	// Get page count
	long pageCount;
	pITableDetector->GetPageCount(&pageCount);

	for (int pageIndex = 0; pageIndex < pageCount; pageIndex++)
	{
		int t = 1;
		VARIANT_BOOL vbResult;

		// Find first table and continue if found
		pITableDetector->FindTable(pageIndex, &vbResult);
		if (vbResult == VARIANT_TRUE)
		{
			do
			{
				float left, top, width, height;
				pITableDetector->GetFoundTableRectangle_Left(&left);
				pITableDetector->GetFoundTableRectangle_Top(&top);
				pITableDetector->GetFoundTableRectangle_Width(&width);
				pITableDetector->GetFoundTableRectangle_Height(&height);

				// Set extraction area for CSV extractor to rectangle received from the table detector
				pICSVExtractor->SetExtractionArea(left, top, width, height);
				// Export the table to CSV file
				CString fileName;
				fileName.Format(L"page-%d-table-%d.csv", pageIndex, t);
				pICSVExtractor->SavePageCSVToFile(pageIndex, _bstr_t(fileName));
				t++;

				pITableDetector->FindNextTable(&vbResult);
			} while (vbResult == VARIANT_TRUE);
		}
	}

	pICSVExtractor->Release();
	pITableDetector->Release();

	CoUninitialize();

	return 0;
}

