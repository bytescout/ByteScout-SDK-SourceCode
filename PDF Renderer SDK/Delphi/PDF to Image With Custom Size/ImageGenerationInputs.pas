unit ImageGenerationInputs;

interface

type
  TCustomSize = record
    Width: integer;
    Height: integer;
  end;

  TImageGenerationInputs = class
  private
    FCustomSizes: array of TCustomSize;
  public
    EnableSaveAsPng: boolean;
    EnableSaveAsJpeg: boolean;
    EnableSaveAsTiff: boolean;

    constructor Create();
    procedure AddCustomSize(AWidth, AHeight: integer);
    function Count(): integer;
    function GetCustomSize(AIndex: integer): TCustomSize;
  end;

implementation

constructor TImageGenerationInputs.Create();
begin
  SetLength(FCustomSizes, 0);
  EnableSaveAsPng := true;
end;

procedure TImageGenerationInputs.AddCustomSize(AWidth, AHeight: integer);
var
  len: integer;
begin
  len := Length(FCustomSizes);
  SetLength(FCustomSizes, len + 1);
  FCustomSizes[len].Width := AWidth;
  FCustomSizes[len].Height := AHeight;
end;

function TImageGenerationInputs.Count(): integer;
begin
  Result := Length(FCustomSizes);
end;

function TImageGenerationInputs.GetCustomSize(AIndex: integer): TCustomSize;
begin
  Result := FCustomSizes[AIndex];
end;

end.
