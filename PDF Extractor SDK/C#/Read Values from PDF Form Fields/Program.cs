//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2019 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System;
using System.Xml;
using Bytescout.PDFExtractor;

namespace ReadValuesFromFormFields
{
    class Program
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
				foreach (XmlNode controlNode in formControls)
				{
					XmlAttribute typeAttribute = controlNode.Attributes["type"];

					// Show textboxes
					if (typeAttribute.Value == "editbox")
					{
						Console.WriteLine("EDITBOX:");
						Console.WriteLine("  id = " + controlNode.Attributes["id"].Value);
						Console.WriteLine("  text = " + controlNode.InnerText);
					}
					// Show checkboxes
					else if (typeAttribute.Value == "checkbox")
					{
						Console.WriteLine("CHECKBOX:");
                        Console.WriteLine("  id = " + controlNode.Attributes["id"].Value);
                        Console.WriteLine("  state = " + controlNode.Attributes["state"].Value);
					}
                    // Show radio-buttons
                    else if (typeAttribute.Value == "radiobutton")
					{
						Console.WriteLine("RADIOBUTTON:");
                        Console.WriteLine("  group = " + controlNode.Attributes["id"].Value);
                        Console.WriteLine("  state = " + controlNode.Attributes["state"].Value);
                        Console.WriteLine("  value = " + controlNode.InnerText);
					}
                    // Show comboboxes
                    else if (typeAttribute.Value == "combobox")
					{
						Console.WriteLine("COMBOBOX:");
                        Console.WriteLine("  id = " + controlNode.Attributes["id"].Value);
                        // list items:
                        foreach (XmlNode valueNode in controlNode.SelectNodes("values/value"))
                        {
                            if (valueNode.Attributes["selected"]?.Value == "true")
                                Console.WriteLine("  value (selected) = " + valueNode.InnerText);
                            else
                                Console.WriteLine("  value = " + valueNode.InnerText);
                        }
					}
                    // Show listboxes
                    else if (typeAttribute.Value == "listbox")
					{
						Console.WriteLine("LISTBOX:");
                        Console.WriteLine("  id = " + controlNode.Attributes["id"].Value);
                        // list items:
                        foreach (XmlNode valueNode in controlNode.SelectNodes("values/value"))
                        {
                            if (valueNode.Attributes["selected"]?.Value == "true")
                                Console.WriteLine("  value (selected) = " + valueNode.InnerText);
                            else
                                Console.WriteLine("  value = " + valueNode.InnerText);
                        }
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
