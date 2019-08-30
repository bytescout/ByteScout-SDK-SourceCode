Readme for live web cam barcode scanning ASP.NET demo 

Supports all browsers by using 2 modes: 

(required mode is automatically detected by the javascript)
- HTML5 based web camera capture (supported by Google Chrome, Firefox, Safari, Safari on iOS browsers)
- Flash based web camera capture (supported by Internet Explorer 9+ and any browser with flash support)

IMPORTANT about HTML5 webcamera support (Chrome, Firefox, Safari on desktop and iOS): it is required to run your website (even test website) via SSL connection. Otherwise, web camera won't initialize at all as it requies SSL connection. 

Visual Studio 2008/2010 or higher is required for this sample to run!

1) Install evaluation copy of BarCode Reader SDK from www.bytescout.com
2) in Visual Studio use File - Open - Web-Site.. and open the folder with this sample
3) Add a reference to ByteScout BarCode Reader dll using the menu: Website - Add Reference (find Bytescout Barcode Reader SDK on .NET tab, select and click OK to add a reference)
4) Right-click on "Default.aspx" file and select "Set As Start Page"
5) Run the project in debug mode
6) Visual Studio will run your project in Internet Explorer or another browser
If it run Internet Explorer then better copy the link from the IE and copy-and-paste to another browser with HTML5 web cam support like Google Chrome, Firefox or Safari
7) When browser asks for permission to access web-cam click "Allow" to allow access to web cam 
8) click "START BARCODE SCAN.." button so the page will start automatically to grab frames from video and sending it to server-side code to read barcodes using Barcode Reader SDK
9) IMPORTANT: barcode should be in focus. Some webcams are not focusing on small barcodes, you may need to adjust the focus on your webcam so it will work OK with small images like barcodes

10) Click Stop to stop barcode scanning
Select barcode type to scan if need to scan a particular barcode type (by default scans for all known types)


TESTING:
- we recommend to use the Conveyor plugin to test your web app from local net or public url: https://marketplace.visualstudio.com/items?itemName=vs-publisher-1448185.ConveyorbyKeyoti
