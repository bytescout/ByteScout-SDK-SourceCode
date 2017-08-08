VERSION 5.00
Object = "{C4847593-972C-11D0-9567-00A0C9273C2A}#8.0#0"; "crviewer.dll"
Begin VB.Form Form1 
   Caption         =   "Barcode Print Preview"
   ClientHeight    =   8865
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   13890
   LinkTopic       =   "Form1"
   ScaleHeight     =   8865
   ScaleWidth      =   13890
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.PictureBox Picture1 
      AutoSize        =   -1  'True
      Height          =   1695
      Left            =   2640
      ScaleHeight     =   1635
      ScaleWidth      =   11835
      TabIndex        =   2
      Top             =   7440
      Visible         =   0   'False
      Width           =   11895
   End
   Begin CRVIEWERLibCtl.CRViewer CRViewer1 
      Height          =   6495
      Left            =   2520
      TabIndex        =   1
      Top             =   120
      Width           =   15975
      DisplayGroupTree=   -1  'True
      DisplayToolbar  =   -1  'True
      EnableGroupTree =   -1  'True
      EnableNavigationControls=   -1  'True
      EnableStopButton=   -1  'True
      EnablePrintButton=   -1  'True
      EnableZoomControl=   -1  'True
      EnableCloseButton=   -1  'True
      EnableProgressControl=   -1  'True
      EnableSearchControl=   -1  'True
      EnableRefreshButton=   -1  'True
      EnableDrillDown =   -1  'True
      EnableAnimationControl=   -1  'True
      EnableSelectExpertButton=   0   'False
      EnableToolbar   =   -1  'True
      DisplayBorder   =   -1  'True
      DisplayTabs     =   -1  'True
      DisplayBackgroundEdge=   -1  'True
      SelectionFormula=   ""
      EnablePopupMenu =   -1  'True
      EnableExportButton=   0   'False
      EnableSearchExpertButton=   0   'False
      EnableHelpButton=   0   'False
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Generate Crystal Report"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1095
      Left            =   120
      TabIndex        =   0
      Top             =   7080
      Visible         =   0   'False
      Width           =   1695
   End
   Begin VB.Image Image1 
      Height          =   1695
      Left            =   2640
      Stretch         =   -1  'True
      Top             =   9240
      Visible         =   0   'False
      Width           =   11895
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'DEFINITcION:
'need to write the simple app showing insertion of generated images(will provide the dll that
'generates images in png, bmp, gif formats) into Crystal Report 8.5 in Visual Basic 6

'Add REFRENCE Microsoft Scripting Runtime
Public cn As ADODB.Connection
Public crx As New CRAXDRT.Application

Dim rpt As CRAXDRT.Report 'Variable for Report
Dim db As CRAXDRT.Database 'variable for Report Database
Dim crTab As CRAXDRT.DatabaseTable 'Variable for Report Database Table
Dim rs As New ADODB.Recordset
Dim WithEvents sect As CRAXDRT.Section 'Variable for Sector of Report
Attribute sect.VB_VarHelpID = -1

Dim pic1 As String 'Stores Image path
Dim h, w As Double 'Stores Height and width

Private Sub Command6_Click()
Unload Me
End Sub
Private Sub sect_Format(ByVal pFormattingInfo As Object)
Dim fso As New FileSystemObject 'Variable for Files,Folders add,edit,delete etc

Dim bmp As StdPicture 'store .bmp file's memory or buffer
Dim gif As StdPicture 'store .gif file's memory or buffer
Dim ext As String 'store Extension of image file

pic1 = sect.ReportObjects.Item("Field2").Value 'gets and stores image path

'check for image available or not
If fso.FileExists(pic1) = False Then
    MsgBox "File not found"
    Exit Sub
End If

ext = Right(pic1, 3) 'gets and stores extension of image
'checks for particular extension and loads it to picturebox control
If ext = "png" Then
    PngPictureLoad pic1, Picture1, True
ElseIf ext = "bmp" Then
    Picture1.Picture = LoadPicture(pic1)
ElseIf ext = "gif" Then
    Image1.Picture = LoadPicture(pic1)
    Picture1.Picture = LoadPicture(pic1)
End If


If ext = "png" Then
    PngPictureLoad pic1, Picture1, True 'It loads file to Picture box control, the method "PngPictureLoad" is defined in Module "Module1"
    With sect.ReportObjects 'it refers to section of Report
        pic1 = .Item("Field2").Value 'It gets and stores Image path
        Call pic_size 'It will get the size of image the method 'pic_size' is defined bellow
        'Set .Item(3).FormattedPicture = Image1.Picture 'It will load Image or picture to Crystal Report
        Set .Item(3).FormattedPicture = Picture1.Picture 'It will load Image or picture to Crystal Report
        .Item(3).Width = w 'It will set width of Image
        .Item(3).Height = h 'It will set height of Image
    End With
ElseIf ext = "bmp" Then
    Image1.Picture = LoadPicture(pic1) 'It loads file to Picture box control
    With sect.ReportObjects 'it refers to section of Report
        pic1 = .Item("Field2").Value 'It gets and stores Image path
        Call pic_size 'It will get the size of image the method 'pic_size' is defined bellow
        Set bmp = LoadPicture(.Item("Field2").Value) 'It will load Image or picture to bmp variable
        
        Set .Item(3).FormattedPicture = bmp 'It will load Image or picture to Crystal Report
        .Item(3).Width = w 'It will set width of Image
        .Item(3).Height = h 'It will set height of Image
    End With
ElseIf ext = "gif" Then
    Image1.Picture = LoadPicture(pic1) 'It loads file to Picture box control
    With sect.ReportObjects 'it refers to section of Report
        pic1 = .Item("Field2").Value 'It gets and stores Image path
        Call pic_size 'It will get the size of image the method 'pic_size' is defined bellow
        Set gif = LoadPicture(.Item("Field2").Value) 'It will load Image or picture to gif variable
        
        Set .Item(3).FormattedPicture = gif 'It will load Image or picture to Crystal Report
        .Item(3).Width = w 'It will set width of Image
        .Item(3).Height = h 'It will set height of Image
    End With
End If
End Sub

Public Sub Command2_Click()
Call conn 'Calls Conn method to connect with Database which is defined below
Dim rpt_path, pwd As String 'rpt_path stores Report Path and pwd stores Password of Database

pwd = Chr(10) & "crystal_report" 'It gets and stores Password of Database
rpt_path = App.path & "\Report2.rpt" 'It gets and stores Report Path
    Set appl = New CRAXDRT.Application 'sets Crystal Report as Application to "appl" variable
    Set rpt = appl.OpenReport(rpt_path) 'sets Report path to rpt variable

    'below loop tells Crystal Report to follow Database
    For Each crTab In rpt.Database.Tables
        crTab.Location = App.path & "\temp.mdb"
        crTab.SetSessionInfo "", pwd
    Next
    Set sect = Nothing 'sect variable gets blank
    Set sect = rpt.Sections("Section5") 'sect variable gets Section of CR
    rpt.DisplayProgressDialog = True 'It shows Progressbar to display CR

    If rs.State = 1 Then rs.Close 'Checks if rs is open then it will close 'RS->Recordset of Database
    rs.Open "SELECT * FROM test", cn, 1, 1 'rs open with new query
    rpt.Database.SetDataSource rs, 3, 1 'sets rs to Crystal Report

    'Check if rs has no record then it will display massege that no files to load
    If rs.RecordCount <= 0 Then
        MsgBox "NO Files To Load", vbInformation
        Exit Sub
    End If
    
    CRViewer1.ReportSource = rpt 'CRViewer control gets which report to display
    CRViewer1.ViewReport 'It will Display Report
    CRViewer1.Zoom 1 'Crystal Report Zoom 100%
    pic1 = rs.Fields(1).Value 'gets and stores Image path
End Sub

'Method to create connection with Database
Public Sub conn()
On Error GoTo checkErr
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

Private Sub Form_Load()
Call conn 'It will call Conn method to establish connection with Database
End Sub

Private Sub Form_Resize()
'setting Crystal Report to Form
CRViewer1.Top = 0
CRViewer1.Left = 0
CRViewer1.Height = ScaleHeight
CRViewer1.Width = ScaleWidth
End Sub
Private Sub Form_Unload(Cancel As Integer)
If cn.State = 1 Then cn.Close 'close connection
If rs.State = 1 Then rs.Close 'close recordset
End Sub

'This method loads image to picturebox control and then sets height and width of image
Private Sub pic_size()
Dim ext As String
ext = Right(pic1, 3)
If ext = "png" Then
    'PngImageLoad pic1, Image1
    PngPictureLoad pic1, Picture1, False
ElseIf ext = "bmp" Then
    'Image1.Picture = LoadPicture(pic1)
    Picture1.Picture = LoadPicture(pic1)
ElseIf ext = "gif" Then
    'Image1.Picture = LoadPicture(pic1)
    Picture1.Picture = LoadPicture(pic1)
End If

'h = Image1.Height
'w = Image1.Width
h = Picture1.Height
w = Picture1.Width
'MsgBox "Height : " & h & vbCrLf & "Width : " & w
End Sub
