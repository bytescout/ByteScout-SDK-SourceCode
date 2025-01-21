'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


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
