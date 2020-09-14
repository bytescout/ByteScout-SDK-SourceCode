program SubmitFormAction;

//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//

{$APPTYPE CONSOLE}

uses
  SysUtils,
  ActiveX,
  ComObj,
  ShellApi,
  Windows,
  Bytescout_PDF_TLB in 'C:\Program Files\Borland\BDS\4.0\Imports\Bytescout_PDF_TLB.pas';

var
  doc: _Document;
  page: _Page;
  font: _Font;
  brush: _Brush;
  color: _Color;
  edit_box: _EditBox;
  check_box: _CheckBox;
  submit_button: _PushButton;
  submit_action: _SubmitFormAction;
  reset_button: _PushButton;
  reset_action: _ResetFormAction; 

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

  // create sample form
  color := doc.ComHelpers.CreateColorRGB(0, 0, 0) as _Color;
  font := doc.ComHelpers.CreateStandardFont(STANDARDFONTS_TIMES, 14);
  brush := doc.ComHelpers.CreateSolidBrush(color) as _Brush;

  // create edit box
  edit_box := doc.ComHelpers.CreateEditBox(20, 20, 100, 25, 'editBox1');
  edit_box.Text := 'editBox1';
  page.Annotations.Add(edit_box as _Annotation);

  // create check box
  check_box := doc.ComHelpers.CreateCheckBox(20, 60, 15, 15, 'checkBox1');
  page.Annotations.Add(check_box as _Annotation);
  page.Canvas.DrawString('CheckBox', font, brush, 45, 60);

  // add submit button
  submit_button := doc.ComHelpers.CreatePushButton(20, 120, 80, 25, 'buttonSubmit');
  submit_button.Caption := 'Submit';
  page.Annotations.Add(submit_button as _Annotation);
  // add action
  submit_action := doc.ComHelpers.CreateSubmitFormAction('http://login.live.com');
  submit_action.SubmitFormat := SUBMITDATAFORMAT_HTML;
  submit_action.SubmitMethod := SUBMITMETHOD_GET;
  submit_action.Fields.Add(edit_box as _Field);
  submit_action.Fields.Add(check_box as _Field);
  submit_button.OnActivated := submit_action as _Action;

  // add reset button
  reset_button := doc.ComHelpers.CreatePushButton(120, 120, 80, 25, 'butonReset');
  reset_button.Caption := 'Reset';
  page.Annotations.Add(reset_button as _Annotation);
  // Add action
  reset_action := doc.ComHelpers.CreateResetFormAction();
  reset_action.Fields.Add(edit_box as _Field);
  reset_action.Fields.Add(check_box as _Field);
  reset_button.OnActivated := reset_action as _Action;

  // Ssave document to file
  doc.Save(OUTPUT_FILE_NAME);

  // show document in default pdf viewer
  ShellExecute(0, 'open', PAnsiChar(OUTPUT_FILE_NAME), nil, nil, SW_SHOWNORMAL);

  // free document object
  doc.Dispose();

  // required for console applications, initializes ActiveX support
  CoUninitialize();
end.
