'*******************************************************************
'       ByteScout Screen Capturing SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Drawing
Imports BytescoutScreenCapturingLib

Public Class CapturingThreadData
	Public CaptureType As CaptureAreaType
    Public TempFile As String
    Public CaptureRectangle As Rectangle = New Rectangle(0, 0, 320, 240)

    Public Result As Integer = 0  ' 0 - success; 1 - error
	Public ErrorText As String
End Class


