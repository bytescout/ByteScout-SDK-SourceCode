VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Merge PDF"
   ClientHeight    =   1095
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   3675
   LinkTopic       =   "Form1"
   ScaleHeight     =   1095
   ScaleWidth      =   3675
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_merge_pdf 
      Caption         =   "Merge PDF"
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
Private Sub cmd_merge_pdf_Click()
    
    ' Hanlde Error
    On Error GoTo ErrorHandler:
    
        ' Create Bytescout.PDFExtractor.DocumentMerger object
        Set merger = CreateObject("Bytescout.PDFExtractor.DocumentMerger")
        merger.RegistrationName = "demo"
        merger.RegistrationKey = "demo"

        merger.Merge2 "sample1.pdf", "sample2.pdf", "result.pdf"
                                        
        Set merger = Nothing

        MsgBox "Merged document saved as 'result.pdf'.", vbInformation, "Success"

    ' Close form
    Unload Me
    
ErrorHandler:
If Err.Number <> 0 Then
    MsgBox Err.Description, vbInformation, "Error"
End If

End Sub
