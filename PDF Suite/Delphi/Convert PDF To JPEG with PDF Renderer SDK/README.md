## How to convert PDF to JPEG with PDF renderer SDK in Delphi using ByteScout PDF Suite

### Learn to convert PDF to JPEG with PDF renderer SDK in Delphi

An easy to understand sample source code to learn how to convert PDF to JPEG with PDF renderer SDK in Delphi What is ByteScout PDF Suite? It is the set that includes 6 SDK products to work with PDF from generating rich PDF reports to extracting data from PDF documents and converting them to HTML. This bundle includes PDF (Generator) SDK, PDF Renderer SDK, PDF Extractor SDK, PDF to HTML SDK, PDF Viewer SDK and PDF Generator SDK for Javascript. It can help you to convert PDF to JPEG with PDF renderer SDK in your Delphi application.

Want to quickly learn? This fast application programming interfaces of ByteScout PDF Suite for Delphi plus the guidelines and the code below will help you quickly learn how to convert PDF to JPEG with PDF renderer SDK. Follow the instructions from scratch to work and copy the Delphi code. Enjoy writing a code with ready-to-use sample Delphi codes.

If you want to try other source code samples then the free trial version of ByteScout PDF Suite is available for download from our website. Just try other source code samples for Delphi.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****PdfToJpeg.dpr:**
    
```
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

```

<!-- code block end -->