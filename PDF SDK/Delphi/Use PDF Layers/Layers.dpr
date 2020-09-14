program Layers;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  ComObj,
  ShellApi,
  Windows,
  Variants,
  Bytescout_PDF_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDF_TLB.pas';

var
  doc: _Document;
  page: _Page;
  canvas: _Canvas;
  all_contents: _Layer;
  layer1, layer2, layer3: _Layer;
  color: _Color;
  brush: _Brush;
  points_safe_array: PSafeArray;
  points_array: _PointsArray;
  bound: SAFEARRAYBOUND;
  group: _OptionalContentGroup;

const
  OUTPUT_FILE_NAME: string = 'result.pdf';

begin
  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create new document
  doc := CoDocument.Create();
  doc.RegistrationName := 'demo';
  doc.RegistrationKey := 'demo';

  // add page
  page := doc.ComHelpers.CreatePage(PAPERFORMAT_A4);
  doc.Pages.Add(page);

  canvas := page.Canvas;

  // add main layer
  all_contents := doc.ComHelpers.CreateLayer('Main Layer');
  canvas.BeginMarkedContent(all_contents);

  color := doc.ComHelpers.CreateColorRGB(0, 255, 0) as _Color;
  brush := doc.ComHelpers.CreateSolidBrush(color) as _Brush;

  // add sub-layer
  layer1 := doc.ComHelpers.CreateLayer('Square');
  canvas.BeginMarkedContent(layer1);
  canvas.DrawRectangle_2(brush, 20, 20, 100, 100);
  canvas.EndMarkedContent();

  color := doc.ComHelpers.CreateColorRGB(255, 0, 0) as _Color;
  brush := doc.ComHelpers.CreateSolidBrush(color) as _Brush;

  // add second sub-layer
  layer2 := doc.ComHelpers.CreateLayer('Circle');
  canvas.BeginMarkedContent(layer2);
  canvas.DrawCircle_2(brush, 70, 180, 50);
  canvas.EndMarkedContent();

  color := doc.ComHelpers.CreateColorRGB(0, 0, 255) as _Color;
  brush := doc.ComHelpers.CreateSolidBrush(color) as _Brush;

  // empty safe array, need to correctly create an array of points
  bound.cElements := 3;
  bound.lLbound := 0;
  points_safe_array := SafeArrayCreate(VT_VARIANT, 1, bound);
  points_array := doc.ComHelpers.CreatePointsArray(points_safe_array);
  // first point coordinates
  points_array.AddPoint(20, 340);
  // second point coordinates
  points_array.AddPoint(70, 240);
  // third point coordinates
  points_array.AddPoint(120, 340);

  // add third sub-layer
  layer3 := doc.ComHelpers.CreateLayer('Triangle');
  canvas.BeginMarkedContent(layer3);
  canvas.DrawPolygon_2(brush, points_array);
  canvas.EndMarkedContent();

  canvas.EndMarkedContent();

  doc.OptionalContents.Layers.Add(layer1);
  doc.OptionalContents.Layers.Add(layer2);
  doc.OptionalContents.Layers.Add(layer3);
  doc.OptionalContents.Layers.Add(all_contents);

  // configure layers

  // group sub-layers
  group := doc.ComHelpers.CreateOptionalContentGroup();
  group.Add(doc.ComHelpers.CreateOptionalContentGroupLayer(layer1) as _OptionalContentGroupItem);
  group.Add(doc.ComHelpers.CreateOptionalContentGroupLayer(layer2) as _OptionalContentGroupItem);
  group.Add(doc.ComHelpers.CreateOptionalContentGroupLayer(layer3) as _OptionalContentGroupItem);

  // Order sub-layers
  doc.OptionalContents.Configuration.Order.Add(doc.ComHelpers.CreateOptionalContentGroupLayer(all_contents) as _OptionalContentGroupItem);
  doc.OptionalContents.Configuration.Order.Add(group as _OptionalContentGroupItem);

  // make the third layer invisible by default (for example)
  // doc.OptionalContents.Configuration.OFF.Add(layer3);

  // force the PDF viewer to show the layers panel initially
  doc.PageMode := PAGEMODE_OPTIONALCONTENT;

  // save document to file
  doc.Save(OUTPUT_FILE_NAME);

  // show document in default pdf viewer
  ShellExecute(0, 'open', PAnsiChar(OUTPUT_FILE_NAME), nil, nil, SW_SHOWNORMAL);

  // free document object
  doc.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
