## How to convert PDF to JPEG in Delphi and ByteScout PDF Renderer SDK

### How to code in Delphi to convert PDF to JPEG with this step-by-step tutorial

Every ByteScout tool contains example Delphi source codes that you can find here or in the folder with installed ByteScout product. ByteScout PDF Renderer SDK is the software development kit for rendering of PDF files into high quality images or thumbnails. Various functions are included as well: batch processing, PNG, TIFF output, selection area to render, layers management to render text or images or vectors only. Designed for use from web, desktop and middleware applications and you can use it to convert PDF to JPEG with Delphi.

Fast application programming interfaces of ByteScout PDF Renderer SDK for Delphi plus the instruction and the code below will help you quickly learn how to convert PDF to JPEG. In order to implement the functionality, you should copy and paste this code for Delphi below into your code editor with your app, compile and run your application. Enjoy writing a code with ready-to-use sample codes in Delphi.

Trial version of ByteScout PDF Renderer SDK can be downloaded for free from our website. It also includes source code samples for Delphi and other programming languages.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20PDF%20Renderer%20SDK%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20PDF%20Renderer%20SDK%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=eenhl7106lA](https://www.youtube.com/watch?v=eenhl7106lA)




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