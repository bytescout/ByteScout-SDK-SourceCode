VERSION 5.00
Begin VB.Form Form1 
   AutoRedraw      =   -1  'True
   Caption         =   "Form1"
   ClientHeight    =   4845
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9795
   LinkTopic       =   "Form1"
   ScaleHeight     =   4845
   ScaleWidth      =   9795
   StartUpPosition =   3  'Windows Default
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

 ' IMPORTANT NOTE for this sample: click on Form1 in the Design mode and set "AutoRedraw" property to True to make all drawings visible
 
 Set bc = CreateObject("Bytescout.BarCode.Barcode")


 ' set symbology type
 bc.Symbology = 1 ' 1 = Code39

 ' set value to encode
 bc.Value = "012345"
  
 ' draw code 39 barcode to the form at (0,0)
 bc.DrawHDC hDC, 0, 0
  
 ' now drawing 2D Aztec barcode
 
 ' set symbology type
 bc.Symbology = 17 ' 17 = Aztec
 ' set value to encode
 bc.Value = "012345"

' draw 2D Aztec barcode to the form at (0,200)
 bc.DrawHDC hDC, 0, 200

 Set bc = Nothing

End Sub
