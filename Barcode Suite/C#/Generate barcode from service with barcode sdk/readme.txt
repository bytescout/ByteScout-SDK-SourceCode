This is simple .NET service created by Microsoft guidelines ( http://msdn.microsoft.com/en-us/library/d56de412(v=vs.80).aspx )
"ServiceController" - simple GUI application that starts and stops the service;
"WindowsService1" - service itself.

This sample service generates PDF files with random GS1-128 barcode every five seconds 
and puts them to "c:\barcodes" folder.

Check the Service1.vb file. 
There is barcode generation and email sending example code.

ServiceController requries Administrator rights to run, so you should run the Visual Studio as Administrator to be able to run the ServiceController from Debug. 
Or run the compiled executable directly. It will ask for Administrative rights on start.