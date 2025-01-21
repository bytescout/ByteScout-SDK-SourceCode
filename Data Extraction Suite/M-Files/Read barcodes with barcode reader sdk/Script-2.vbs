'*******************************************************************************************'
'                                                                                           '
' Get API Key https://app.pdf.co/signup                                                     '
' API Documentation: https://developer.pdf.co/api/index.html                                '
'                                                                                           '
' Note: Replace placeholder values in the code with your API Key                            '
' and file paths (if applicable)                                                            '
'                                                                      '
'*******************************************************************************************'


'M-Files Workflow Action Script to remove state and workflow property from object.
'Place action code in the last 'end' state of the workflow.
'updated 2015-03-12, mika, pschokker

' Option Explicit

Dim oPropVals : Set oPropVals = CreateObject ("MFilesAPI.PropertyValues")
Dim oPropVal : Set oPropVal = CreateObject ("MFilesAPI.PropertyValue")

' Clear workflow
oPropVal.PropertyDef = 38
oPropval.TypedValue.SetValue MFDataTypeLookup, "" 
oPropVals.Add -1, oPropVal

' Clear state
oPropVal.PropertyDef = 39
oPropval.TypedValue.SetValue MFDataTypeLookup, ""
oPropVals.Add -1, oPropVal

Call Vault.ObjectPropertyOperations.SetProperties( ObjVer, oPropVals )

