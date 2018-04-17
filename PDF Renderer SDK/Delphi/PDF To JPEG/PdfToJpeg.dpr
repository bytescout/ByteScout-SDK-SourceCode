program PdfToJpeg;

{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils,
  ComObj,
  ActiveX;

var
  renderer: Variant;
  renderingResolution: Integer;
  outputImageFormat: Integer;
  pageIndex: Integer;

begin

  try

    CoInitialize(nil);

    // Create and initialize Bytescout.PDFRenderer.RasterRenderer object
    renderer := CreateOleObject('Bytescout.PDFRenderer.RasterRenderer');
    renderer.RegistrationName := 'demo';
    renderer.RegistrationKey := 'demo';

    // Load sample PDF document
    renderer.LoadDocumentFromFile('..\..\multipage.pdf');

    // Render PDF document at 96 DPI - default PC display resolution
    // To get higher quality output, set 200, 300 or more
    renderingResolution := 96;

    // Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
    outputImageFormat := 1;

    // Iterate through pages
    for pageIndex := 0 to renderer.GetPageCount - 1 do
    begin
      // Render document page to JPEG image file
      renderer.Save('page' + IntToStr(pageIndex) + '.jpg', outputImageFormat, pageIndex, renderingResolution);
    end;

  except
    on E: Exception do
      Writeln(E.ClassName, ': ', E.Message);
  end;
end.
