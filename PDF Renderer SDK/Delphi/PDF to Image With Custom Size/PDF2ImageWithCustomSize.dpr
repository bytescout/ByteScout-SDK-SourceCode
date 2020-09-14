program PDF2ImageWithCustomSize;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  Bytescout_PDFRenderer_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDFRenderer_TLB.pas',
  ImageGenerationInputs in 'ImageGenerationInputs.pas';

var
  renderer: _RasterRenderer;
  image_generation_inputs: TImageGenerationInputs;
  rendering_options: _RenderingOptions;
  page_index: integer;
  custom_size: TCustomSize;
  i: integer;
  image_file_name: string;

const
  INPUT_FILE_NAME: string = 'multipage.pdf';

begin
  // disable floating point exception to conform to .NET floating point operations behavior.
  System.Set8087CW($133F);

  // required for console applications, initializes ActiveX support
  CoInitialize(nil);

  // create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it
  renderer := CoRasterRenderer.Create();
  renderer.RegistrationName := 'demo';
  renderer.RegistrationKey := 'demo';

  // specify Image Generation Inputs
  image_generation_inputs := TImageGenerationInputs.Create();

  image_generation_inputs.AddCustomSize(320, 420);
  image_generation_inputs.AddCustomSize(600, 800);

  image_generation_inputs.EnableSaveAsPng := true;
  image_generation_inputs.EnableSaveAsJpeg := true;
  image_generation_inputs.EnableSaveAsTiff := true;

  // load PDF document
  renderer.LoadDocumentFromFile(INPUT_FILE_NAME);

  // specify Rendering Options to fine tune output generation
  rendering_options := CoRenderingOptions.Create();
  rendering_options.TIFFCompression := TIFFCompression_None;
  rendering_options.VectorSmoothingMode := GraphicsTransformationQuality_HighQuality;

  for i := 0 to image_generation_inputs.Count() - 1 do begin

    custom_size := image_generation_inputs.GetCustomSize(i);

    // loop through all pages
    for page_index := 0 to renderer.GetPageCount() - 1 do begin

      // perform save as PNG, if specified
      if (image_generation_inputs.EnableSaveAsPng) then begin

        image_file_name := Format('output_%dx%d_page%d.png', [custom_size.Width, custom_size.Height, page_index]);

        // save png image per page, per custom size
        renderer.Save_4(image_file_name, RasterImageFormat_PNG, page_index,
          custom_size.Width, custom_size.Height, rendering_options);

        WriteLn(image_file_name + ' - generated');
      end;

      // perform save as JPG, if specified
      if (image_generation_inputs.EnableSaveAsJpeg) then begin

        image_file_name := Format('output_%dx%d_page%d.jpg', [custom_size.Width, custom_size.Height, page_index]);

        // save jpg image per page, per custom size
        renderer.Save_4(image_file_name, RasterImageFormat_JPEG, page_index,
          custom_size.Width, custom_size.Height, rendering_options);

        WriteLn(image_file_name + ' - generated');
      end;

      // perform save as TIFF, if specified
      if (image_generation_inputs.EnableSaveAsTiff) then begin

        image_file_name := Format('output_%dx%d_page%d.tiff', [custom_size.Width, custom_size.Height, page_index]);

        // save tiff image per page, per custom size
        renderer.SaveMultipageTiff_4(image_file_name, 0,
          renderer.GetPageCount() - 1, custom_size.Width, custom_size.Height,
          rendering_options);

        WriteLn(image_file_name + ' - generated');
      end;
    end;
  end;

  // cleanup
  image_generation_inputs.Free();
  renderer.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
