'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System
Imports System.IO
Imports System.Management
Imports System.Windows.Forms
Imports System.ServiceProcess

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub btnInstallService_Click(sender As Object, e As EventArgs)
		Try
			' Install the service
			ServiceInstaller.Install("Service1", "Service1", Path.GetFullPath("WindowsService1.exe"))

			' Set the service option "Allow desktop interaction".
			Dim co As New ConnectionOptions()
			co.Impersonation = ImpersonationLevel.Impersonate
			Dim mgmtScope As New ManagementScope("root\CIMV2", co)
			mgmtScope.Connect()
			Dim wmiService As New ManagementObject("Win32_Service.Name='Service1'")
			Dim InParam As ManagementBaseObject = wmiService.GetMethodParameters("Change")
			InParam("DesktopInteract") = True
			Dim OutParam As ManagementBaseObject = wmiService.InvokeMethod("Change", InParam, Nothing)

			' Start the service
			ServiceInstaller.StartService("Service1")
		Catch exception As Exception
			MessageBox.Show(exception.Message)
		End Try
	End Sub

	Private Sub btnUninstallService_Click(sender As Object, e As EventArgs)
		Try
			ServiceInstaller.Uninstall("Service1")
		Catch exception As Exception
			MessageBox.Show(exception.Message)
		End Try
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub
End Class
