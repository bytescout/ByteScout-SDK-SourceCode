//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;

using Bytescout.BarCode;
using Microsoft.Reporting.WebForms;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
		// Fill the datasource from DB
		AdventureWorksTableAdapters.vProductAndDescriptionTableAdapter ta = 
			new AdventureWorksTableAdapters.vProductAndDescriptionTableAdapter();
		AdventureWorks.vProductAndDescriptionDataTable dt = 
			new AdventureWorks.vProductAndDescriptionDataTable();
		ta.Fill(dt);

		Barcode bc = new Barcode(SymbologyType.Code128);
		bc.RegistrationName = "support@bytescout.com";
		bc.RegistrationKey = "BE75-6B80-111C-E8B1-11E";
    	bc.DrawCaption = false;

		// Update DataTable with barcode image
		foreach (AdventureWorks.vProductAndDescriptionRow row in dt.Rows)
		{
			// Set the value to encode
			bc.Value = row.ProductID.ToString();
			// Generate the barcode image and store it into the Barcode Column
			row.Barcode = bc.GetImageBytesPNG();
		}

		// Create Report Data Source
		Microsoft.Reporting.WebForms.ReportDataSource rptDataSource = 
			new ReportDataSource("AdventureWorks_vProductAndDescription", dt);

		ReportViewer1.LocalReport.DataSources.Add(rptDataSource);
		ReportViewer1.LocalReport.ReportPath = Server.MapPath("BarcodeReport.rdlc");
		ReportViewer1.LocalReport.Refresh();
    }
}
