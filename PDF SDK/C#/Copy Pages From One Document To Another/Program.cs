using System.Diagnostics;
using Bytescout.PDF;

namespace CopyPagesFromOneDocumentToAnother
{
	class Program
	{
		static void Main(string[] args)
		{
			// Open first document
			Document document1 = new Document("document1.pdf");
			document1.RegistrationName = "demo";
			document1.RegistrationKey = "demo";
			// Open second document
			Document document2 = new Document("document2.pdf");
			document2.RegistrationName = "demo";
			document2.RegistrationKey = "demo";
			
			// Add pages from document2 to document1
			for (int i = 0; i < document2.Pages.Count; ++i)
			{
				document1.Pages.Add(document2.Pages[i]);
			}

			// Save merged document
			document1.Save("MergedDocument.pdf");

			// Open merged document in default PDF viewer application
			Process.Start("MergedDocument.pdf");
		}
	}
}
