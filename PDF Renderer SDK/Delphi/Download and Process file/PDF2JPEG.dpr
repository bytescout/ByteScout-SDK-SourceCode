program PDF2JPEG;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  Classes,
  IdHTTP,
  ShellApi,
  Windows,
  Bytescout_PDFRenderer_TLB in 'c:\program files\borland\bds\4.0\Imports\Bytescout_PDFRenderer_TLB.pas';

var
  renderer: _RasterRenderer;
  stream: TFileStream;
  http: TIdHTTP;
  i: integer;
  page_file_name: WideString;

const
  INPUT_FILE_NAME: string = 'sample.pdf';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  renderer := CoRasterRenderer.Create();
  renderer.RegistrationName := 'demo';
  renderer.RegistrationKey := 'demo';

  // get file from url
  stream := TFileStream.Create(INPUT_FILE_NAME, fmCreate);
  http := TIdHTTP.Create(nil);
  http.Get('http://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/' + INPUT_FILE_NAME, stream);
  stream.Free();
  http.Free();

  renderer.LoadDocumentFromFile(INPUT_FILE_NAME);

  // render document page to JPG image file.
  for i := 0 to renderer.GetPageCount() - 1 do begin

    page_file_name := Format('image%d.jpg', [i]);
    renderer.Save(page_file_name, RasterImageFormat_JPEG, i, 96);
  end;

  // free renderer object
  renderer.Dispose();

  CoUninitialize();
end.
