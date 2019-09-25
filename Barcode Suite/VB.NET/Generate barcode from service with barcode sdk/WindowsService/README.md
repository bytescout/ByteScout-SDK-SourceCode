## How to generate barcode from service with barcode sdk for windows service in VB.NET and ByteScout Barcode Suite

### How to generate barcode from service with barcode sdk in VB.NET with easy ByteScout code samples to make windows service. Step-by-step tutorial

Quick guide:Learn how to generate barcode from service with barcode sdk in VB.NET. ByteScout Barcode Suite was designed to assist windows service in VB.NET. ByteScout Barcode Suite is the bundle that privides 3  SDK products to generate barcodes (Barcode SDK), read barcodes (Barcode Reaer SDK) and read and write spreadsheets (Spreadsheet SDK).

If you want to speed up the application’s code writing then VB.NET code samples for VB.NET developers help to implement using ByteScout Barcode Suite. Follow the tutorial and copy - paste code for VB.NET into your project's code editor. Check VB.NET sample code examples to see if they respond to your needs and requirements for the project.

ByteScout Barcode Suite - free trial version is available on our website. Also, there are other code samples to help you with your VB.NET application included into trial version.

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

##### ****Program.vb:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProjectInstaller.Designer.vb:**
    
```
Partial Class ProjectInstaller
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

	#Region "Component Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.serviceProcessInstaller1 = New System.ServiceProcess.ServiceProcessInstaller()
		Me.serviceInstaller1 = New System.ServiceProcess.ServiceInstaller()
		' 
		' serviceProcessInstaller1
		' 
		Me.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem
		Me.serviceProcessInstaller1.Password = Nothing
		Me.serviceProcessInstaller1.Username = Nothing
		' 
		' serviceInstaller1
		' 
		Me.serviceInstaller1.ServiceName = "Service1"
		' 
		' ProjectInstaller
		' 
		Me.Installers.AddRange(New System.Configuration.Install.Installer() {Me.serviceProcessInstaller1, Me.serviceInstaller1})

	End Sub

	#End Region

	Private serviceProcessInstaller1 As System.ServiceProcess.ServiceProcessInstaller
	Private serviceInstaller1 As System.ServiceProcess.ServiceInstaller
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****ProjectInstaller.vb:**
    
```
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

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Service1.Designer.vb:**
    
```
Partial Class Service1
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

	#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.eventLog1 = New System.Diagnostics.EventLog()
		DirectCast(Me.eventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Service1
		' 
		Me.ServiceName = "Service1"
		DirectCast(Me.eventLog1, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private eventLog1 As System.Diagnostics.EventLog
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****Service1.vb:**
    
```
Imports System.IO
Imports System.ServiceProcess
Imports System.Timers
Imports Bytescout.BarCode

Public Partial Class Service1
	Inherits ServiceBase
	Private _timer As Timer = Nothing

	Public Sub New()
		InitializeComponent()

		If Not System.Diagnostics.EventLog.SourceExists("MySource") Then
			System.Diagnostics.EventLog.CreateEventSource("MySource", "MyNewLog")
		End If

		eventLog1.Source = "MySource"
		eventLog1.Log = "MyNewLog"
	End Sub

	Protected Overrides Sub OnStart(args As String())
		eventLog1.WriteEntry("In OnStart")

		If _timer IsNot Nothing Then
			_timer.[Stop]()
			RemoveHandler _timer.Elapsed, AddressOf Timer_Elapsed
			_timer.Dispose()
		End If

		_timer = New Timer(5000)
		AddHandler _timer.Elapsed, AddressOf Timer_Elapsed
		_timer.Start()
	End Sub

	Protected Overrides Sub OnStop()
		eventLog1.WriteEntry("In OnStop.")

		If _timer IsNot Nothing Then
			_timer.[Stop]()
			RemoveHandler _timer.Elapsed, AddressOf Timer_Elapsed
			_timer.Dispose()
			_timer = Nothing
		End If
	End Sub

	Private Sub Timer_Elapsed(sender As Object, e As ElapsedEventArgs)
		Dim barcode As Barcode = Nothing

		Try
			' Generate sample barcode value by random number
			Dim random As New Random()
			Dim barcodeValue As String = "(00)" & random.[Next]().ToString("000000000000000000")

			' Create Bytescout.BarCode object and setup the barcode
			barcode = New Barcode("demo", "demo")
			barcode.Symbology = SymbologyType.GS1_128
			barcode.Value = barcodeValue

			Dim outputDirectory As String = "c:\barcodes"
			If Not Directory.Exists(outputDirectory) Then
				Directory.CreateDirectory(outputDirectory)
			End If

			Dim fileName As String = barcodeValue & ".pdf"
			Dim filePath As String = Path.Combine(outputDirectory, fileName)

			' Save barcode to new PDF file
			barcode.DrawToNewPDF(filePath, 500, 500, 50, 50)


				' Sending email message example:
				'
'				System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
'				message.To.Add("luckyperson@online.microsoft.com");
'				message.Subject = fileName;
'				message.From = new System.Net.Mail.MailAddress("From@online.microsoft.com");
'				message.Body = "This is the message body";
'				message.Attachments.Add(new System.Net.Mail.Attachment(filePath));
'				
'				System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("your_smtp_host");
'				smtp.Send(message);
'				

			eventLog1.WriteEntry("Generated " & fileName)
		Catch exception As Exception
			eventLog1.WriteEntry(exception.Message)
		Finally
			If barcode IsNot Nothing Then
				barcode.Dispose()
			End If
		End Try
	End Sub
End Class

```

<!-- code block end -->    

<!-- code block begin -->

##### ****WindowsService1.vbproj:**
    
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Build">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>8.0.30703</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{881CF3F4-4893-4B56-9EDF-1874A3387C77}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <AppDesignerFolder>Properties</AppDesignerFolder>
    <RootNamespace>WindowsService1</RootNamespace>
    <AssemblyName>WindowsService1</AssemblyName>
    <TargetFrameworkVersion>v2.0</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
  </PropertyGroup>
  <PropertyGroup>
    <StartupObject>WindowsService1.Program</StartupObject>
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
    <Reference Include="Bytescout.BarCode, Version=2.2.0.413, Culture=neutral, PublicKeyToken=f7dd1bd9d40a50eb, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\..\Program Files\Bytescout BarCode SDK\net2.00\Bytescout.BarCode.dll</HintPath>
    </Reference>
    <Reference Include="System" />
    <Reference Include="System.Configuration.Install" />
    <Reference Include="System.Data" />
    <Reference Include="System.Management" />
    <Reference Include="System.ServiceProcess" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Program.vb" />
    <Compile Include="ProjectInstaller.Designer.vb">
      <DependentUpon>ProjectInstaller.vb</DependentUpon>
    </Compile>
    <Compile Include="ProjectInstaller.vb">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include="Properties\AssemblyInfo.vb" />
    <Compile Include="Service1.Designer.vb">
      <DependentUpon>Service1.vb</DependentUpon>
    </Compile>
    <Compile Include="Service1.vb">
      <SubType>Component</SubType>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="ProjectInstaller.resx">
      <DependentUpon>ProjectInstaller.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Service1.resx">
      <DependentUpon>Service1.vb</DependentUpon>
    </EmbeddedResource>
  </ItemGroup>
  <Import Project="$(MSBuildBinPath)\Microsoft.VisualBasic.Targets" />
</Project>
```

<!-- code block end -->