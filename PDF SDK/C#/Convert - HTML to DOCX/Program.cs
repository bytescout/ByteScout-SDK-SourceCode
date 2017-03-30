using System.Diagnostics;
using Bytescout.PDF.Converters;

namespace ConvertHtmlToDocx
{
	class Program
	{
		static void Main(string[] args)
		{
			using (HtmlToDocxConverter converter = new HtmlToDocxConverter())
			{
				converter.ConvertHtmlToDocx("sample.html", "result.docx");
			}

			// Open result file in default DOCX associated application
			Process.Start("result.docx");
		}
	}
}
