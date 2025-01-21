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
using System.Diagnostics;
using System.Xml;
using Bytescout.PDFExtractor;

namespace ExtractFilledFormData
{
	static class Program
	{
		static void Main()
		{
			// Create XMLExtractor instance
			XMLExtractor extractor = new XMLExtractor();
			extractor.RegistrationName = "demo";
			extractor.RegistrationKey = "demo";

			// Load sample PDF document
			extractor.LoadDocumentFromFile(@".\filled_form.pdf");

			// Get PDF document text as XML
			string xmlText = extractor.GetXML();

			// Load XML
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xmlText);

			// Select all "control" nodes
			XmlNodeList formControls = xmlDocument.SelectNodes("//control");
			if (formControls != null)
			{
				foreach (XmlNode formControl in formControls)
				{
					XmlAttribute typeAttribute = formControl.Attributes["type"];

					// Show filled textboxes
					if (typeAttribute.Value == "editbox")
					{
						if (!String.IsNullOrEmpty(formControl.InnerText))
							Console.WriteLine("EDITBOX " + formControl.Attributes["id"].Value + ": " + formControl.InnerText);
					}
					// Show checked checkboxes
					else if (typeAttribute.Value == "checkbox")
					{
						if (formControl.Attributes["state"].Value == "1")
						    Console.WriteLine("CHECKBOX " + formControl.Attributes["id"].Value + ": " + formControl.Attributes["state"].Value);
					}
				}
			}

			// Cleanup
			extractor.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
		    Console.ReadKey();
		}
	}
}
