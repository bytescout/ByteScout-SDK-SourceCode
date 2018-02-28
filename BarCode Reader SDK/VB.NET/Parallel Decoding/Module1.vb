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

    Const InputFile As String = ".\example.pdf"

    ' Limit to 4 threads in queue.
    ' Set this value to number of your processor cores for max performance.
    Dim ThreadLimiter As Semaphore = New Semaphore(4, 4)

    
    <MTAThread()> Sub Main()

        Const numberOfRuns As Integer = 10
        Dim doneEvents(numberOfRuns - 1) As ManualResetEvent

        For i As Integer = 0 To numberOfRuns - 1

            ' Wait for the queue
            ThreadLimiter.WaitOne()

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

        Console.WriteLine("Thread #" & threadIndex & " started...")

        Try

            Dim reader As New Reader()
            reader.RegistrationName = "demo"
            reader.RegistrationKey = "demo"

            ' Set barcode type to find
            reader.BarcodeTypesToFind.Code128 = True

            ' Read barcodes
            Dim barcodes As FoundBarcode() = reader.ReadFrom(InputFile)

            Console.WriteLine("Thread #" & threadIndex & " finished with " & barcodes.Length & " barcodes found.")

        Catch ex As Exception

            Console.WriteLine("Thread #" & threadIndex & " failed with exception:\r\n" & ex.Message)

        Finally

            ' Signal the thread is finished
            waitEvent.Set()

            ' Release semaphore
            ThreadLimiter.Release()

        End Try
        
    End Sub

End Module
