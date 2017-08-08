VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   1800
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   3750
   LinkTopic       =   "Form1"
   ScaleHeight     =   1800
   ScaleWidth      =   3750
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton btnStartRecording 
      Caption         =   "Start"
      Height          =   495
      Left            =   240
      TabIndex        =   0
      Top             =   1080
      Width           =   1455
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   240
      TabIndex        =   2
      Text            =   "Output.wmv"
      Top             =   360
      Width           =   3255
   End
   Begin VB.CommandButton btnStopRecording 
      Caption         =   "Stop"
      Height          =   495
      Left            =   1800
      TabIndex        =   1
      Top             =   1080
      Width           =   1695
   End
   Begin VB.Label Label1 
      Caption         =   "Output filename (WMV or AVI)"
      Height          =   255
      Left            =   240
      TabIndex        =   3
      Top             =   120
      Width           =   3135
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

' declare global Capturer object
' if you get the error then go to Project | References and then
' search for Bytescout Screen Capturing SDK,  check this and click OK
' to add the reference to Screen Capturing SDK
Private capturer As New BytescoutScreenCapturingLib.capturer

Private Sub btnStartRecording_Click()

capturer.OutputFileName = Text1.Text
capturer.AnimateMouseButtons = True
capturer.AnimateMouseClicks = True
capturer.CapturingType = 3

' set width of the output video
' capturer.OutputWidth = 1280
' set height of the output video
' capturer.OutputHeight = 720

	' // WMV and WEBM output use WMVVideoBitrate property to control output video bitrate
   	' // so try to increase it by x2 or x3 times if you think the output video are you are getting is laggy
	' capturer.WMVVideoBitrate = capturer.WMVVideoBitrate * 2


' uncomment to set Bytescout Lossless Video format output video compression method
' do not forget to set file to .avi format if you use Video Codec Name

'capturer.CurrentVideoCodecName = "Bytescout Lossless"

' uncomment to enable recording of semitransparent or layered windows (Warning: may cause mouse cursor flickering)
' capturer.CaptureTransparentControls = true

' run video capturing
capturer.Run

End Sub

Private Sub btnStopRecording_Click()
 
 capturer.Stop
 
End Sub

Private Sub Form_Load()

' destroy Capturer object so the video will be saved into the disk
Set capturer = Nothing
Set capturer = New BytescoutScreenCapturingLib.capturer

End Sub
