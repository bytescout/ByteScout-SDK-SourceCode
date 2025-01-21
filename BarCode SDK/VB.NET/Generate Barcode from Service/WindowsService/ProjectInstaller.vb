'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration.Install


<RunInstaller(True)> _
Public Partial Class ProjectInstaller
	Inherits System.Configuration.Install.Installer
	Public Sub New()
		InitializeComponent()
	End Sub
End Class
