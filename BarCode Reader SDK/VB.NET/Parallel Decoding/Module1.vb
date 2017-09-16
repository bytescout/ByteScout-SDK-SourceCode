'****************************************************************************'
'                                                                            '
' Download evaluation version: https://bytescout.com/download/web-installer  '
'                                                                            '
' Signup Cloud API free trial: https://secure.bytescout.com/users/sign_up    '
'                                                                            '
' Copyright © 2017 ByteScout Inc. All rights reserved.                       '
' http://www.bytescout.com                                                   '
'                                                                            '
'****************************************************************************'


Imports Bytescout.BarCodeReader
Imports System.Threading

Module Module1

    <MTAThread()> Sub Main()

        Const numberOfRuns As Integer = 10
        Dim doneEvents(numberOfRuns - 1) As ManualResetEvent

        ThreadPool.SetMaxThreads(8, 8)

        For i As Integer = 0 To numberOfRuns - 1

            doneEvents(i) = New ManualResetEvent(False)
            ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf ThreadProc), New Object() {i, doneEvents(i)})

        Next

        WaitHandle.WaitAll(doneEvents)

        Console.WriteLine("All threads done.")
        Console.WriteLine()

        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()

    End Sub

    Sub ThreadProc(ByVal stateInfo As Object)

        Dim threadIndex As Integer = stateInfo(0)
        Dim waitEvent As ManualResetEvent = stateInfo(1)

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Set barcode type to find
        reader.BarcodeTypesToFind.Code128 = True

        ' Read barcodes
        Dim barcodes As FoundBarcode() = reader.ReadFrom("example.pdf")

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Thread #{0}\r\n  Found barcode with type '{1}' and value '{2}'", threadIndex, barcode.Type, barcode.Value)
        Next

        waitEvent.Set()

    End Sub

End Module
