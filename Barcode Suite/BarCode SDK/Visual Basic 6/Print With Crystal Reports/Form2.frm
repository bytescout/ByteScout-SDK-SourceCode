VERSION 5.00
Begin VB.Form Form2 
   Caption         =   "Barcode Printing Application"
   ClientHeight    =   1905
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   4185
   ControlBox      =   0   'False
   LinkTopic       =   "Form2"
   ScaleHeight     =   1905
   ScaleWidth      =   4185
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command4 
      Cancel          =   -1  'True
      Caption         =   "E&XIT"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1455
      Left            =   2880
      TabIndex        =   1
      Top             =   240
      Width           =   975
   End
   Begin VB.CommandButton cmd_gen_cr_with_barcodes 
      Caption         =   "Generate Crystal Report with Barcodes"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1455
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   2415
   End
End
Attribute VB_Name = "Form2"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Variable Declaration
'Dim pic1 As String 'Stores Image path
'Dim h, w As Double 'Stores Height and width of Image

'Dim bmp_path As String
'Dim png_path As String

Private Sub cmd_gen_cr_with_barcodes_Click()
Form1.Command2_Click
Form1.Show
End Sub

Private Sub Command4_Click()
Unload Me
End Sub
Private Sub Form_Load()
Call conn  'It will call Conn method to establish connection with Database
End Sub
'Method to insert path of images to database
 Private Sub insert_into_DB()
 Dim query As String
 
 'Delete old Data clears Database
 If rs.State = 1 Then rs.Close
 query = "delete * from test"
 rs.Open query, cn, 1, 1
 
 'Insert Data to Database
 num1 = 1
 If rs.State = 1 Then rs.Close
 query = "insert into test values(" & num1 & ",'" & bmp_path & "')"
 rs.Open query, cn, 1, 1
 
 If rs.State = 1 Then rs.Close
 query = "insert into test values(" & num1 & ",'" & png_path & "')"
 rs.Open query, cn, 1, 1
 End Sub
 
'Method to create connection with Database
Public Sub conn()
On Error GoTo checkErr 'Error Handler
Dim path As String
path = App.path & "\temp.mdb"
Set cn = New ADODB.Connection
cn.Provider = "Microsoft.Jet.OLEDB.4.0"
cn.ConnectionString = path
cn.Properties("Jet OLEDB:Database Password") = "crystal_report"
cn.Open
OpenDatabase = True
Exit Sub
checkErr:
MsgBox Err.Description, vbExclamation, Err.Number
End Sub
