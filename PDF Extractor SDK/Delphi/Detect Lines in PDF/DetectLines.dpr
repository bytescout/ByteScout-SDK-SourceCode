program DetectLines;

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

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  Bytescout_PDFExtractor_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDFExtractor_TLB.pas';

var
  line_detector: _LineDetector;
  found_lines: _FoundLinesCollection;
  i: integer;
  line: _FoundLine;

const
  INPUT_FILE_NAME: string = 'sample2.pdf';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create Bytescout.PDFExtractor.LineDetector instance
  line_detector := CoLineDetector.Create();
  line_detector.RegistrationName := 'demo';
  line_detector.RegistrationKey := 'demo';

  // load sample PDF document
  line_detector.LoadDocumentFromFile(INPUT_FILE_NAME);

  found_lines := line_detector.FindLines(1, LineOrientationsToFind_HorizontalAndVertical);

  WriteLn(Format('Number of lines found: %d', [found_lines.Count]));

  for i := 0 to found_lines.Count - 1 do begin

    line := found_lines.Item[i];

    WriteLn(Format('Line #%d', [i]));

    // line Orientation
    WriteLn(Format('LineOrientation: %d', [line.LineOrientation]));

    // starting point of the line
    WriteLn(Format('From point: x: %f, y: %f', [line.From.x, line.From.y]));

    // ending point of the line
    WriteLn(Format('To point: x: %f, y: %f', [line.To_.x, line.To_.y]));

    // line width
    WriteLn(Format('Width: %f', [line.Width]));
  end;

  line_detector.Dispose();

  CoUninitialize();
end.
