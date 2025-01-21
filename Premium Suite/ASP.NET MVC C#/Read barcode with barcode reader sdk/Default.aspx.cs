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
using Bytescout.BarCodeReader;

namespace SimpleWebTestSharp
{
	public partial class _Default : System.Web.UI.Page
	{
        /*
        IF YOU SEE TEMPORARY FOLDER ACCESS ERRORS: 

        Temporary folder access is required for web application when you use ByteScout SDK in it.
        If you are getting errors related to the access to temporary folder like "Access to the path 'C:\Windows\TEMP\... is denied" then you need to add permission for this temporary folder to make ByteScout SDK working on that machine and IIS configuration because ByteScout SDK requires access to temp folder to cache some of its data for more efficient work.

        SOLUTION:

        If your IIS Application Pool has "Load User Profile" option enabled the IIS provides access to user's temp folder. Check user's temporary folder

        If you are running Web Application under an impersonated account or IIS_IUSRS group, IIS may redirect all requests into separate temp folder like "c:\temp\".

        In this case
        - check the User or User Group your web application is running under
        - then add permissions for this User or User Group to read and write into that temp folder (c:\temp or c:\windows\temp\ folder)
        - restart your web application and try again

        */

		protected void Page_Load(object sender, EventArgs e)
		{
			Image1.ImageUrl = "BarcodePhoto.jpg";

			Reader reader = new Reader();

			// Limit search to 1D barcodes only (exclude 2D barcodes to speed up the search).
			// Change to reader.BarcodeTypesToFind.SetAll() to scan for all supported 1D and 2D barcodes 
			// or select specific type, e.g. reader.BarcodeTypesToFind.PDF417 = True
			reader.BarcodeTypesToFind.SetAll1D();

			// reader.MediumTrustLevelCompatible = true; // uncomment this line to enable Medium Trust compatible mode (slows down the recognition process as direct image data access is disabled in Medium Trust mode)

			reader.ReadFromFile(Server.MapPath("BarcodePhoto.jpg"));

			foreach (FoundBarcode barcode in reader.FoundBarcodes)
			{
				ListBox1.Items.Add(String.Format("{0} : {1}", barcode.Type, barcode.Value));
			}
		}
	}
}
