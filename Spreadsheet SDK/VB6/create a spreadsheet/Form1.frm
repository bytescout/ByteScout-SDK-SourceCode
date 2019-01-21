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
   Begin VB.Label Label1 
      Caption         =   "See the Output.xls file in the same folder"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   204
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1695
      Left            =   360
      TabIndex        =   0
      Top             =   360
      Width           =   3015
      WordWrap        =   -1  'True
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()

Set document = CreateObject("Bytescout.Spreadsheet.Spreadsheet")

 ' Add new worksheet
Set worksheet = document.Workbook.Worksheets.Add("HelloWorld")

' get cell value
Set cell = worksheet.Item(0, 0) ' you can also use worksheet.Cell("A1") as well

' set cell value
cell.Value = "Hello, World!"

' delete output file if exists already
Set fso = CreateObject("Scripting.FileSystemObject")
If (fso.FileExists("Output.xls")) Then fso.DeleteFile ("Output.xls")
Set fso = Nothing

' save document
document.SaveAs "Output.xls"

' close Spreadsheet
Set document = Nothing

End Sub
