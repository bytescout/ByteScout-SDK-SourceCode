'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Collections.Generic
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.Run(New Form1())
	End Sub
End Class
