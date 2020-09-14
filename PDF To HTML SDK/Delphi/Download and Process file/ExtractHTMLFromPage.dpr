program ExtractHTMLFromPage;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  IdHTTP,
  Classes,
  Bytescout_PDF2HTML_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDF2HTML_TLB.pas';

var
  extractor: _HTMLExtractor;
  stream: TFileStream;
  http: TIdHTTP;

const
  INPUT_FILE_NAME: string = 'sample.pdf';
  OUTPUT_FILE_NAME: string = 'output.html';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create Bytescout.PDF2HTML.HTMLExtractor instance
  extractor := CoHTMLExtractor.Create();
  extractor.RegistrationName := 'demo';
  extractor.RegistrationKey := 'demo';

  // get file from url
  stream := TFileStream.Create(INPUT_FILE_NAME, fmCreate);
  http := TIdHTTP.Create(nil);
  http.Get('http://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/' + INPUT_FILE_NAME, stream);
  stream.Free();
  http.Free();

  extractor.LoadDocumentFromFile(INPUT_FILE_NAME);

  // convert 1-st page to HTML and save it to file
  extractor.SaveHtmlPageToFile(0, OUTPUT_FILE_NAME);

  // free extractor object
  extractor.Dispose();

  CoUninitialize();
end.
