## How to generate barcode from service with barcode sdk for service controller in VB.NET with ByteScout Barcode Suite

### Learn in simple ways: How to generate barcode from service with barcode sdk for service controller in VB.NET

These simple tutorials explain the code material for beginners and advanced programmers who are using VB.NET. Service controller in VB.NET can be applied with ByteScout Barcode Suite. ByteScout Barcode Suite is the set that includes three different SDK products to generate barcodes, read barcodes and read and write spreadsheets: Barcode SDK, Barcode Reader SDK and Spreadsheet SDK.

Use the code displayed below in your application to save a lot of time on writing and testing code.  This sample code in VB.NET is all you need. Just copy-paste it to the code editor, then add a reference to ByteScout Barcode Suite and you are ready to try it! Want to see how it works with your data then code testing will allow the function to be tested and work properly.

Free! Free! Free! ByteScout free trial version is available for FREE download from our website. Programming tutorials along with source code samples are assembled.

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Barcode%20Suite%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Barcode%20Suite%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore SDK Docs](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Documentation](https://pdf.co/documentation/api?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### ****Form1.Designer.vb:**
    
```
Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.btnInstallService = New System.Windows.Forms.Button()
		Me.btnUninstallService = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' btnInstallService
		' 
		Me.btnInstallService.Location = New System.Drawing.Point(12, 12)
		Me.btnInstallService.Name = "btnInstallService"
		Me.btnInstallService.Size = New System.Drawing.Size(125, 23)
		Me.btnInstallService.TabIndex = 0
		Me.btnInstallService.Text = "Install Service"
		Me.btnInstallService.UseVisualStyleBackColor = True
		AddHandler Me.btnInstallService.Click, New System.EventHandler(AddressOf Me.btnInstallService_Click)
		' 
		' btnUninstallService
		' 
		Me.btnUninstallService.Location = New System.Drawing.Point(143, 12)
		Me.btnUninstallService.Name = "btnUninstallService"
		Me.btnUninstallService.Size = New System.Drawing.Size(125, 23)
		Me.btnUninstallService.TabIndex = 1
		Me.btnUninstallService.Text = "Uninstall Service"
		Me.btnUninstallService.UseVisualStyleBackColor = True
		AddHandler Me.btnUninstallService.Click, New System.EventHandler(AddressOf Me.btnUninstallService_Click)
		' 
		' btnExit
		' 
		Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnExit.Location = New System.Drawing.Point(193, 77)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		AddHandler Me.btnExit.Click, New System.EventHandler(AddressOf Me.btnExit_Click)
		' 
		' Form1
		' 
		Me.AcceptButton = Me.btnExit
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(282, 112)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnUninstallService)
		Me.Controls.Add(Me.btnInstallService)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "Form1"
		Me.Text = "Service Controller"
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private btnInstallService As System.Windows.Forms.Button
	Private btnUninstallService As System.Windows.Forms.Button
	Private btnExit As System.Windows.Forms.Button
End Class


```

<!-- code block end -->    

<!-- code block begin -->

##### ****Form1.vb:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Program.vb:**
    
```
Imports System.Collections.Generic
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
	''' </summary>
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New Form1())
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ServiceController.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{05906433-726B-4F50-A415-742D350390F5}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>ServiceController</RootNamespace>
    <AssemblyName>ServiceController</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <PublishUrl>publish\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
  </PropertyGroup>
  <PropertyGroup>
    <SignAssembly>true</SignAssembly>
  </PropertyGroup>
  <PropertyGroup>
    <AssemblyOriginatorKeyFile>key.snk</AssemblyOriginatorKeyFile>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>ServiceController.Program</StartupObject>
  </PropertyGroup>
  <PropertyGroup>
    <ApplicationManifest>app.manifest</ApplicationManifest>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Debug|AnyCPU'">
    <DebugSymbols>true</DebugSymbols>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG,TRACE</DefineConstants>
    <DebugType>full</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Release|AnyCPU'">
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <Optimize>true</Optimize>
    <DebugType>pdbonly</DebugType>
    <PlatformTarget>AnyCPU</PlatformTarget>
    <ErrorReport>prompt</ErrorReport>
    <CodeAnalysisRuleSet>MinimumRecommendedRules.ruleset</CodeAnalysisRuleSet>
  </PropertyGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
  </ItemGroup>
  <ItemGroup>
  </ItemGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Management" />
    <Reference Include="System.ServiceProcess" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
    </Compile>
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Program.vb" />
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Properties\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="Properties\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
    <Compile Include="ServiceInstaller.vb" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.resx">
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.vb</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="app.manifest">
      <SubType>Designer</SubType>
    </None>
    <None Include="key.snk" />
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows Installer 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include="..\WindowsService1\WindowsService1.vbproj">
      <Project>{881CF3F4-4893-4B56-9EDF-1874A3387C77}</Project>
      <Name>WindowsService1</Name>
    </ProjectReference>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->    

<!-- code block begin -->

##### ****ServiceInstaller.vb:**
    
```
Imports System
Imports System.Runtime.InteropServices
Imports System.Threading

Public NotInheritable Class ServiceInstaller
	Private Sub New()
	End Sub
	Private Const STANDARD_RIGHTS_REQUIRED As Integer = &Hf0000
	Private Const SERVICE_WIN32_OWN_PROCESS As Integer = &H10

	<StructLayout(LayoutKind.Sequential)> _
	Private Class SERVICE_STATUS
		Public dwServiceType As Integer = 0
		Public dwCurrentState As ServiceState = 0
		Public dwControlsAccepted As Integer = 0
		Public dwWin32ExitCode As Integer = 0
		Public dwServiceSpecificExitCode As Integer = 0
		Public dwCheckPoint As Integer = 0
		Public dwWaitHint As Integer = 0
	End Class

	#Region "OpenSCManager"
	Private Declare Unicode Function OpenSCManager Lib "advapi32.dll" Alias "OpenSCManagerW" (machineName As String, databaseName As String, dwDesiredAccess As ScmAccessRights) As IntPtr
	#End Region

	#Region "OpenService"
	<DllImport("advapi32.dll", SetLastError := True, CharSet := CharSet.Auto)> _
	Private Shared Function OpenService(hSCManager As IntPtr, lpServiceName As String, dwDesiredAccess As ServiceAccessRights) As IntPtr
	End Function
	#End Region

	#Region "CreateService"
	<DllImport("advapi32.dll", SetLastError := True, CharSet := CharSet.Auto)> _
	Private Shared Function CreateService(hSCManager As IntPtr, lpServiceName As String, lpDisplayName As String, dwDesiredAccess As ServiceAccessRights, dwServiceType As Integer, dwStartType As ServiceBootFlag, _
		dwErrorControl As ServiceError, lpBinaryPathName As String, lpLoadOrderGroup As String, lpdwTagId As IntPtr, lpDependencies As String, lp As String, _
		lpPassword As String) As IntPtr
	End Function
	#End Region

	#Region "CloseServiceHandle"
	<DllImport("advapi32.dll", SetLastError := True)> _
	Private Shared Function CloseServiceHandle(hSCObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function
	#End Region

	#Region "QueryServiceStatus"
	<DllImport("advapi32.dll")> _
	Private Shared Function QueryServiceStatus(hService As IntPtr, lpServiceStatus As SERVICE_STATUS) As Integer
	End Function
	#End Region

	#Region "DeleteService"
	<DllImport("advapi32.dll", SetLastError := True)> _
	Private Shared Function DeleteService(hService As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function
	#End Region

	#Region "ControlService"
	<DllImport("advapi32.dll")> _
	Private Shared Function ControlService(hService As IntPtr, dwControl As ServiceControl, lpServiceStatus As SERVICE_STATUS) As Integer
	End Function
	#End Region

	#Region "StartService"
	<DllImport("advapi32.dll", SetLastError := True)> _
	Private Shared Function StartService(hService As IntPtr, dwNumServiceArgs As Integer, lpServiceArgVectors As Integer) As Integer
	End Function
	#End Region

	Public Shared Sub Uninstall(serviceName As String)
		Dim scm As IntPtr = OpenSCManager(ScmAccessRights.AllAccess)

		Try
			Dim service As IntPtr = OpenService(scm, serviceName, ServiceAccessRights.AllAccess)
			If service = IntPtr.Zero Then
				Throw New ApplicationException("Service not installed.")
			End If

			Try
				StopService(service)
				If Not DeleteService(service) Then
					Throw New ApplicationException("Could not delete service " & Marshal.GetLastWin32Error())
				End If
			Finally
				CloseServiceHandle(service)
			End Try
		Finally
			CloseServiceHandle(scm)
		End Try
	End Sub

	Public Shared Function ServiceIsInstalled(serviceName As String) As Boolean
		Dim scm As IntPtr = OpenSCManager(ScmAccessRights.Connect)

		Try
			Dim service As IntPtr = OpenService(scm, serviceName, ServiceAccessRights.QueryStatus)

			If service = IntPtr.Zero Then
				Return False
			End If

			CloseServiceHandle(service)
			Return True
		Finally
			CloseServiceHandle(scm)
		End Try
	End Function

	Public Shared Sub Install(serviceName As String, displayName As String, fileName As String)
		Dim scm As IntPtr = OpenSCManager(ScmAccessRights.AllAccess)

		Try
			Dim service As IntPtr = OpenService(scm, serviceName, ServiceAccessRights.AllAccess)

			If service = IntPtr.Zero Then
				service = CreateService(scm, serviceName, displayName, ServiceAccessRights.AllAccess, SERVICE_WIN32_OWN_PROCESS, ServiceBootFlag.AutoStart, _
					ServiceError.Normal, fileName, Nothing, IntPtr.Zero, Nothing, Nothing, _
					Nothing)
			End If

			If service = IntPtr.Zero Then
				Throw New ApplicationException("Failed to install service.")
			End If
		Finally
			CloseServiceHandle(scm)
		End Try
	End Sub

	Public Shared Sub InstallAndStart(serviceName As String, displayName As String, fileName As String)
		Dim scm As IntPtr = OpenSCManager(ScmAccessRights.AllAccess)

		Try
			Dim service As IntPtr = OpenService(scm, serviceName, ServiceAccessRights.AllAccess)

			If service = IntPtr.Zero Then
				service = CreateService(scm, serviceName, displayName, ServiceAccessRights.AllAccess, SERVICE_WIN32_OWN_PROCESS, ServiceBootFlag.AutoStart, _
					ServiceError.Normal, fileName, Nothing, IntPtr.Zero, Nothing, Nothing, _
					Nothing)
			End If

			If service = IntPtr.Zero Then
				Throw New ApplicationException("Failed to install service.")
			End If

			Try
				StartService(service)
			Finally
				CloseServiceHandle(service)
			End Try
		Finally
			CloseServiceHandle(scm)
		End Try
	End Sub

	Public Shared Sub StartService(serviceName As String)
		Dim scm As IntPtr = OpenSCManager(ScmAccessRights.Connect)

		Try
			Dim service As IntPtr = OpenService(scm, serviceName, ServiceAccessRights.QueryStatus Or ServiceAccessRights.Start)
			If service = IntPtr.Zero Then
				Throw New ApplicationException("Could not open service.")
			End If

			Try
				StartService(service)
			Finally
				CloseServiceHandle(service)
			End Try
		Finally
			CloseServiceHandle(scm)
		End Try
	End Sub

	Public Shared Sub StopService(serviceName As String)
		Dim scm As IntPtr = OpenSCManager(ScmAccessRights.Connect)

		Try
			Dim service As IntPtr = OpenService(scm, serviceName, ServiceAccessRights.QueryStatus Or ServiceAccessRights.[Stop])
			If service = IntPtr.Zero Then
				Throw New ApplicationException("Could not open service.")
			End If

			Try
				StopService(service)
			Finally
				CloseServiceHandle(service)
			End Try
		Finally
			CloseServiceHandle(scm)
		End Try
	End Sub

	Private Shared Sub StartService(service As IntPtr)
		Dim status As New SERVICE_STATUS()
		StartService(service, 0, 0)
        Dim changedStatus As Boolean = WaitForServiceStatus(service, ServiceState.StartPending, ServiceState.Running)
		If Not changedStatus Then
			Throw New ApplicationException("Unable to start service")
		End If
	End Sub

	Private Shared Sub StopService(service As IntPtr)
		Dim status As New SERVICE_STATUS()
		ControlService(service, ServiceControl.[Stop], status)
        Dim changedStatus As Boolean = WaitForServiceStatus(service, ServiceState.StopPending, ServiceState.Stopped)
		If Not changedStatus Then
			Throw New ApplicationException("Unable to stop service")
		End If
	End Sub

	Public Shared Function GetServiceStatus(serviceName As String) As ServiceState
		Dim scm As IntPtr = OpenSCManager(ScmAccessRights.Connect)

		Try
			Dim service As IntPtr = OpenService(scm, serviceName, ServiceAccessRights.QueryStatus)
			If service = IntPtr.Zero Then
				Return ServiceState.NotFound
			End If

			Try
				Return GetServiceStatus(service)
			Finally
				CloseServiceHandle(service)
			End Try
		Finally
			CloseServiceHandle(scm)
		End Try
	End Function

	Private Shared Function GetServiceStatus(service As IntPtr) As ServiceState
		Dim status As New SERVICE_STATUS()

		If QueryServiceStatus(service, status) = 0 Then
			Throw New ApplicationException("Failed to query service status.")
		End If

		Return status.dwCurrentState
	End Function

	Private Shared Function WaitForServiceStatus(service As IntPtr, waitStatus As ServiceState, desiredStatus As ServiceState) As Boolean
		Dim status As New SERVICE_STATUS()

		QueryServiceStatus(service, status)
		If status.dwCurrentState = desiredStatus Then
			Return True
		End If

		Dim dwStartTickCount As Integer = Environment.TickCount
		Dim dwOldCheckPoint As Integer = status.dwCheckPoint

		While status.dwCurrentState = waitStatus
			' Do not wait longer than the wait hint. A good interval is
			' one tenth the wait hint, but no less than 1 second and no
			' more than 10 seconds.

			Dim dwWaitTime As Integer = status.dwWaitHint \ 10

			If dwWaitTime < 1000 Then
				dwWaitTime = 1000
			ElseIf dwWaitTime > 10000 Then
				dwWaitTime = 10000
			End If

			Thread.Sleep(dwWaitTime)

			' Check the status again.

			If QueryServiceStatus(service, status) = 0 Then
				Exit While
			End If

			If status.dwCheckPoint > dwOldCheckPoint Then
				' The service is making progress.
				dwStartTickCount = Environment.TickCount
				dwOldCheckPoint = status.dwCheckPoint
			Else
				If Environment.TickCount - dwStartTickCount > status.dwWaitHint Then
					' No progress made within the wait hint
					Exit While
				End If
			End If
		End While
		Return (status.dwCurrentState = desiredStatus)
	End Function

	Private Shared Function OpenSCManager(rights As ScmAccessRights) As IntPtr
		Dim scm As IntPtr = OpenSCManager(Nothing, Nothing, rights)
		If scm = IntPtr.Zero Then
			Throw New ApplicationException("Could not connect to service control manager.")
		End If

		Return scm
	End Function
End Class

Public Enum ServiceState
	Unknown = -1
	' The state cannot be (has not been) retrieved.
	NotFound = 0
	' The service is not known on the host server.
	Stopped = 1
	StartPending = 2
	StopPending = 3
	Running = 4
	ContinuePending = 5
	PausePending = 6
	Paused = 7
End Enum

<Flags> _
Public Enum ScmAccessRights
	Connect = &H1
	CreateService = &H2
	EnumerateService = &H4
	Lock = &H8
	QueryLockStatus = &H10
	ModifyBootConfig = &H20
	StandardRightsRequired = &Hf0000
    AllAccess = (StandardRightsRequired Or Connect Or CreateService Or EnumerateService Or Lock Or QueryLockStatus Or ModifyBootConfig)
End Enum

<Flags> _
Public Enum ServiceAccessRights
	QueryConfig = &H1
	ChangeConfig = &H2
	QueryStatus = &H4
	EnumerateDependants = &H8
	Start = &H10
	[Stop] = &H20
	PauseContinue = &H40
	Interrogate = &H80
	UserDefinedControl = &H100
	Delete = &H10000
	StandardRightsRequired = &Hf0000
	AllAccess = (StandardRightsRequired Or QueryConfig Or ChangeConfig Or QueryStatus Or EnumerateDependants Or Start Or [Stop] Or PauseContinue Or Interrogate Or UserDefinedControl)
End Enum

Public Enum ServiceBootFlag
	Start = &H0
	SystemStart = &H1
	AutoStart = &H2
	DemandStart = &H3
	Disabled = &H4
End Enum

Public Enum ServiceControl
	[Stop] = &H1
	Pause = &H2
	[Continue] = &H3
	Interrogate = &H4
	Shutdown = &H5
	ParamChange = &H6
	NetBindAdd = &H7
	NetBindRemove = &H8
	NetBindEnable = &H9
	NetBindDisable = &Ha
End Enum

Public Enum ServiceError
	Ignore = &H0
	Normal = &H1
	Severe = &H2
	Critical = &H3
End Enum

```

<!-- code block end -->