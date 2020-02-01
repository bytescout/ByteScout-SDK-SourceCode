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
Imports System.Collections.Generic
Imports System.Text

Imports Bytescout.BarCode
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Drawing

Public Class BarcodePrinter
    Private m_barcode As New Barcode()
    Private m_widthInches As Single
    Private m_heightInches As Single

    Public Sub Print(ByVal type As SymbologyType, ByVal value As String, ByVal caption As String, ByVal widthInches As Single, ByVal heightInches As Single)
        m_barcode.Symbology = type
        m_barcode.Value = value
        m_barcode.Caption = caption

        m_widthInches = widthInches
        m_heightInches = heightInches

        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, New PrintPageEventHandler(AddressOf printDoc_PrintPage)

        Dim dlgSettings As New PrintDialog()
        dlgSettings.Document = printDoc

        If dlgSettings.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Sub printDoc_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim position As New Point(100, 100)

        m_barcode.FitInto(New SizeF(m_widthInches, m_heightInches), GraphicsUnit.Inch)
        m_barcode.Draw(e.Graphics, position)
    End Sub
End Class
