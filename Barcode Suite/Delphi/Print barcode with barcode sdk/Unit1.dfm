object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 315
  ClientWidth = 510
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Button1: TButton
    Left = 8
    Top = 8
    Width = 494
    Height = 33
    Caption = 'Generate Code39 barcode and print'
    TabOrder = 0
    OnClick = Button1Click
  end
  object Memo1: TMemo
    Left = 8
    Top = 47
    Width = 494
    Height = 260
    Lines.Strings = (
      ' IMPORTANT:'
      
        '  To work with Bytescout BarCode SDK you need to import this as ' +
        'a component into Delphi'
      ''
      
        ' To import Bytescout BarCode SDK into Delphi 2006 or higher do t' +
        'he following:'
      ' 1) Click Component | Import Component..'
      ' 2) Select Type Library and click Next'
      
        ' 3) Find and select Bytescout BarCode SDK in the list of availab' +
        'le type libraries and'
      ' 4) Click Next'
      ' 5) Click Next on next screen'
      
        ' 6) Select "Add Bytescout_BarCode_TLB.pas" into Project" and cli' +
        'ck Finish'
      ''
      
        ' This will add Bytescout_BarCode_TLB.pas into your project and n' +
        'ow you can use BarCode object interface (_BarCode class)')
    ScrollBars = ssBoth
    TabOrder = 1
  end
end
