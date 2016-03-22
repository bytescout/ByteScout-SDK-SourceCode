'*******************************************************************
'       ByteScout BarCode SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Collections.Generic
Imports System.ServiceProcess
Imports System.Text

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	Friend Shared Sub Main()
		Dim servicesToRun As ServiceBase() = New ServiceBase() {New Service1()}

		ServiceBase.Run(servicesToRun)
	End Sub
End Class
