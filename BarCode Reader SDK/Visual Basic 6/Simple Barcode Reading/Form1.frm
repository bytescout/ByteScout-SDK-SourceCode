VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   2400
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   3750
   LinkTopic       =   "Form1"
   ScaleHeight     =   2400
   ScaleWidth      =   3750
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

Set bc = CreateObject("Bytescout.BarCodeReader.Reader")

' Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
' Change to bc.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
' or select specific type, e.g. bc.BarcodeTypesToFind.PDF417 = True
bc.BarcodeTypesToFind.SetAll1D()

bc.ReadFromFile "BarcodePhoto.jpg"

For i = 0 To bc.FoundCount - 1
     Msgbox "Found barcode on page #" & CStr(bc.GetFoundBarcodePage(i)) & " with type " & Cstr(bc.GetFoundBarcodeType(i)) & " and value " & bc.GetFoundBarcodeValue(i)
Next

Set bc = Nothing

End Sub
