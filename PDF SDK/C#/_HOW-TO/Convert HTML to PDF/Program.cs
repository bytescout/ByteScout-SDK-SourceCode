using System.Diagnostics;
using System.Drawing.Printing;
using Bytescout.PDF.Converters;

namespace ConvertHtmlToPdf
{
	class Program
	{
		static void Main(string[] args)
		{
			using (HtmlToPdfConverter converter = new HtmlToPdfConverter())
			{
				converter.PageSize = PaperKind.A4;
				converter.Orientation = PaperOrientation.Portrait;
				converter.Footer = "<p style=\"color: blue;\">FOOTER TEXT</p>";
				
				converter.ConvertHtmlToPdf("sample.html", "result.pdf");
			}

			// Open result file in default PDF viewer
			Process.Start("result.pdf");
		}
	}
}
