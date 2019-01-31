VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "PDF to JSON"
   ClientHeight    =   1095
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   3675
   LinkTopic       =   "Form1"
   ScaleHeight     =   1095
   ScaleWidth      =   3675
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_pdf_to_json 
      Caption         =   "Convert PDF to JSON"
      Height          =   855
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3495
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmd_pdf_to_json_Click()
    
    ' Hanlde Error
    On Error GoTo ErrorHandler:
    
    ' Create Bytescout.PDFExtractor.JSONExtractor object
    Set extractor = CreateObject("Bytescout.PDFExtractor.JSONExtractor")
    
    ' Set Registration name and key
    extractor.RegistrationName = "demo"
    extractor.RegistrationKey = "demo"
  
    ' Load sample PDF document
    extractor.LoadDocumentFromFile "sample.pdf"
    
    ' Peform Save to JSON file
    extractor.SaveJSONToFile "output.json"
    
    ' Show Success Message
    MsgBox "Extracted data saved to 'output.json' file.", vbInformation, "Success"
    
    ' Close form
    Unload Me
    
ErrorHandler:
If Err.Number <> 0 Then
    MsgBox Err.Description, vbInformation, "Error"
End If

End Sub
