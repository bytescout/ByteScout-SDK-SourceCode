'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up '
'                                                                                           '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 '
' http://www.bytescout.com                                                                  '
'                                                                                           '
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
