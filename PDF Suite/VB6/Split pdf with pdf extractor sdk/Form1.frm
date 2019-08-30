VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Split PDF"
   ClientHeight    =   1095
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   3675
   LinkTopic       =   "Form1"
   ScaleHeight     =   1095
   ScaleWidth      =   3675
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmd_split_pdf 
      Caption         =   "Split PDF"
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
Private Sub cmd_split_pdf_Click()
    
    ' Hanlde Error
    On Error GoTo ErrorHandler:
    
    ' Create Bytescout.PDFExtractor.DocumentSplitter object
    Set splitter = CreateObject("Bytescout.PDFExtractor.DocumentSplitter")
    
    ' Set Registration name and key
    splitter.RegistrationName = "demo"
    splitter.RegistrationKey = "demo"
  
    ' Set input file
    inputFile = "sample.pdf"
    
    ' Enable splitting parts optimization (remove unused resources)
    splitter.OptimizeSplittedDocuments = True
    
    ' Extract a single page:
    ' ======================
    splitter.ExtractPage inputFile, "page3.pdf", 3 ' (!) Note: page number is 1-based.
    
    MsgBox "Extracted page #3 to file 'page3.pdf'.", vbInformation, "Success"


    ' Split in two parts:
    ' ===================
    
    splitter.Split inputFile, "part1.pdf", "part2.pdf", 3 ' (!) Note: page number is 1-based.
    
    MsgBox "Splitted at page #3 to files 'part1.pdf' and 'part2.pdf'.", vbInformation, "Success"
    
    
    ' Split by ranges:
    ' ================
    
    ' SplitCOM() returns array with file names. Files are saved to the system temporary directory.
    Dim outFiles
    outFiles = splitter.SplitCOM(inputFile, "1-3,4-") ' (!) Note: page numbers are 1-based; the ending "-" means "to the end".
    
    Dim fileNames
    For Each of In outFiles
        fileNames = fileNames & of & vbCrLf
    Next
    
    MsgBox "Splitted by ranges to files: " & vbCrLf & fileNames, vbInformation, "Success"
        
    ' Close form
    Unload Me
    
ErrorHandler:
If Err.Number <> 0 Then
    MsgBox Err.Description, vbInformation, "Error"
End If

End Sub
