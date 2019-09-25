## How to convert PDF to JPEG with PDF renderer SDK in Delphi and ByteScout Premium Suite

### Continuous learning is a crucial part of computer science and this tutorial shows how to convert PDF to JPEG with PDF renderer SDK in Delphi

Source code documentation samples give simple and easy method to install a needed feature into your application. ByteScout Premium Suite is the bundle that includes twelve SDK products from ByteScout including tools and components for PDF, barcodes, spreadsheets, screen video recording. It can convert PDF to JPEG with PDF renderer SDK in Delphi.

The SDK samples given below describe how to quickly make your application do convert PDF to JPEG with PDF renderer SDK in Delphi with the help of ByteScout Premium Suite. IF you want to implement the functionality, just copy and paste this code for Delphi below into your code editor with your app, compile and run your application. Check Delphi sample code samples to see if they respond to your needs and requirements for the project.

ByteScout provides the free trial version of ByteScout Premium Suite along with the documentation and source code samples.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Premium%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Premium%20Suite%20Question) 

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