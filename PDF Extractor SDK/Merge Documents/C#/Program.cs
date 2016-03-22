//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace MergeDocuments
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputFiles = new string[] {"sample1.pdf", "sample2.pdf", "sample3.pdf"};

			using (DocumentMerger merger = new DocumentMerger("demo", "demo"))
            {
                merger.Merge(inputFiles, "result.pdf");
            }

			Process.Start("result.pdf");
		}
	}
}
