VERSION 5.00
Begin VB.Form Form1 
   AutoRedraw      =   -1  'True
   Caption         =   "Form1"
   ClientHeight    =   2175
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7770
   LinkTopic       =   "Form1"
   ScaleHeight     =   2175
   ScaleWidth      =   7770
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Print Barcode to the selected printer with 300 DPI quality and physycal size (4x1 inches)"
      Height          =   855
      Left            =   120
      TabIndex        =   1
      Top             =   840
      Width           =   6975
   End
   Begin VB.ComboBox cboPrinterList 
      Height          =   315
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   6975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
  ' set printer to the selected printer
  Call SelectPrinter(cboPrinterList.Text)
  ' call function to print barcode to Printer object
 Call PrintBarCode
End Sub

 
' populate list of printers on form load
Private Sub Form_Load()

Dim dev As Printer, Index As Integer, CurrentPrinter As Integer
CurrentPrinter = -1
Index = 0
For Each dev In Printers
cboPrinterList.AddItem dev.DeviceName
If Printer.DeviceName = dev.DeviceName Then
CurrentPrinter = Index
End If
       Index = Index + 1
Next
If CurrentPrinter <> -1 Then
 cboPrinterList.ListIndex = CurrentPrinter
End If

End Sub
 
'===========================
'Function to select printer
'===========================

Function SelectPrinter(ByVal printer_name As String) As Boolean
    Dim i As Integer

    SelectPrinter = False
    For i = 0 To Printers.Count - 1
        ' if the specified printer is found, select it and return True
        If Printers(i).DeviceName = printer_name Then
            Set Printer = Printers(i)
            SelectPrinter = True
            Exit For
        End If
    Next i
End Function


' print barcode to the Printer object

Private Sub PrintBarCode()
 
' this method prints a barcode via temporary EMF metafile allowing to set target physical size and DPI resolution quality

Const DPIQuality = 300 ' 300 DPI as printing resolution (DPI) quality
Const WidthInInches = 4 ' 4 inches as width for the barcode generated
Const HeightInInches = 1 ' 1 inches as height for the barcode generated

 ' create barcode object as ActiveX
 Dim BC
 Set BC = CreateObject("Bytescout.BarCode.Barcode")

 Printer.PrintQuality = DPIQuality ' set the printer quality to 300 dpi

 ' IMPORTANT: call Printer.Print Space(1) to initialize the Printer
 ' this is how Microsoft advises to do in their KB article (search for Printer.Print string): http://support.microsoft.com/kb/146022
 Printer.Print Space(1) ' initialize hDC of Printer object
 
 ' set the same DPI resolution (300 DPI) to generate barcode image
 BC.ResolutionX = DPIQuality
 BC.ResolutionY = DPIQuality
 
 ' set barcode symbology type
 BC.Symbology = 0 ' Code 39 = 0 (see the documentation for other barcode types)
 
 ' set barcode value
 BC.Value = "1234567890"
 
 
 ' use .FitInto_3 method to set the size in inches (you can also set in mm, cm, pixels - see the documentation for more)
 BC.FitInto_3 WidthInInches, HeightInInches, 2 ' fit into 3.5x0.875 inches (2 = inch)
  
' save barcode into temprorary EMF image

' create FileSystemObject to work with files
Dim FSO As Object
Set FSO = CreateObject("Scripting.filesystemobject")

' get temporary filename to save a temporary .EMF file
Dim tempEMFFileName
tempEMFFileName = FSO.GetTempName() & ".EMF"

' save EMF metafile into the temporary file
BC.SaveImage tempEMFFileName

' now we paint EMF file to Printer object
' default units for Printer in VB6 is Twips, which is 1440 per Inch
' so we calculate 3.5 inches as 3.5 * TwipsPerInch
Const TwipsPerInch = 1440
' now printing the picture at 0,0 with 3.5 inches X 0.875 inches
Printer.PaintPicture LoadPicture(tempEMFFileName), 0, 200, 3.5 * TwipsPerInch, 0.875 * TwipsPerInch

' now remove temporary EMF file
FSO.deletefile tempEMFFileName, True
Set FSO = Nothing
 
 ' finally send command to print the page
Printer.EndDoc
 
Set BC = Nothing


End Sub
