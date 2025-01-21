//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.IO;
using System.ServiceProcess;
using System.Timers;
using Bytescout.BarCode;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
	    private Timer _timer = null;

        public Service1()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
            {
                System.Diagnostics.EventLog.CreateEventSource( "MySource", "MyNewLog");
            }
            
            eventLog1.Source = "MySource";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("In OnStart");

			if (_timer != null)
			{
				_timer.Stop();
				_timer.Elapsed -= Timer_Elapsed;
				_timer.Dispose();
			}

			_timer = new Timer(5000);
			_timer.Elapsed += Timer_Elapsed;
			_timer.Start();
        }

	    protected override void OnStop()
        {
			eventLog1.WriteEntry("In OnStop.");
			
			if (_timer != null)
			{
				_timer.Stop();
				_timer.Elapsed -= Timer_Elapsed;
				_timer.Dispose();
				_timer = null;
			}
        }

	    void Timer_Elapsed(object sender, ElapsedEventArgs e)
	    {
		    Barcode barcode = null;

		    try
		    {
		    	// Generate sample barcode value by random number
			    Random random = new Random();
				string barcodeValue = "(00)" + random.Next().ToString("000000000000000000");

				// Create Bytescout.BarCode object and setup the barcode
			    barcode = new Barcode("demo", "demo");
			    barcode.Symbology = SymbologyType.GS1_128;
			    barcode.Value = barcodeValue;

			    string outputDirectory = "c:\\barcodes";
		        if (!Directory.Exists(outputDirectory))
		            Directory.CreateDirectory(outputDirectory);

		        string fileName = barcodeValue + ".pdf";
			    string filePath = Path.Combine(outputDirectory, fileName);

                // Save barcode to new PDF file
				barcode.DrawToNewPDF(filePath, 500, 500, 50, 50);

				eventLog1.WriteEntry("Generated " + fileName);

				// Sending email message example:
				/*
				System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
				message.To.Add("luckyperson@online.microsoft.com");
				message.Subject = fileName;
				message.From = new System.Net.Mail.MailAddress("From@online.microsoft.com");
				message.Body = "This is the message body";
				message.Attachments.Add(new System.Net.Mail.Attachment(filePath));
				
				System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("your_smtp_host");
				smtp.Send(message);
				*/
		    }
			catch (Exception exception)
			{
				eventLog1.WriteEntry(exception.Message);
			}
		    finally
		    {
			    if (barcode != null)
			    {
				    barcode.Dispose();
			    }
		    }
	    }
    }
}
