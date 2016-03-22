//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using Bytescout.PDFExtractor;

namespace RotateDocument
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputFile = "sample1.pdf";

			using (DocumentRotator rotator = new DocumentRotator("demo", "demo"))
            {
                rotator.Rotate(inputFile, "result.pdf", RotationAngle.Deg90);
            }

			Process.Start("result.pdf");
		}
	}
}
