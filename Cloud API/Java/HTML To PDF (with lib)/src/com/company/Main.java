package com.company;

import com.bytescout.client.ApiException;
import com.bytescout.client.api.HTMLToPDFApi;
import com.bytescout.client.model.HtmlToPdfOptionsVm;
import com.bytescout.client.model.HtmlToPdfRequestVm;
import sun.plugin2.util.SystemUtil;

import java.io.FileOutputStream;
import java.io.IOException;
import java.net.URISyntaxException;

// This example demonstrates the using of HTML To PDF Web API

public class Main
{
	// Your authentication key (sign up at http://bytescout.io to get your own)
    final static String API_KEY = "#####################################";

    public static void main(String[] args) throws IOException, URISyntaxException
    {
	    // Create Barcode Generator API object instance
	    HTMLToPDFApi api = new HTMLToPDFApi();

	    // Create barcode properties
	    HtmlToPdfOptionsVm properties = new HtmlToPdfOptionsVm();
	    // Set PDF document title
	    properties.setTitle("GOOGLE.COM");
	    // Set page orientation (portrait/landscape)
	    properties.setOrientation(HtmlToPdfOptionsVm.OrientationEnum.LANDSCAPE);
	    // Set header text for each PDF page (optional)
	    properties.setHeaderHTML("*** Header ***");
	    // Set footer text for each PDF page (optional)
	    properties.setFooterHTML("*** Footer ***");

	    // Create barcode request data
	    HtmlToPdfRequestVm data = new HtmlToPdfRequestVm();
	    // Pass properties
	    data.setProperties(properties);
	    // Set output type to ContentBase64 (the result file will be returned as base64-encoded string)
	    data.setOutputType(HtmlToPdfRequestVm.OutputTypeEnum.CONTENTBASE64);
	    // Set input type to Link
	    data.setInputType(HtmlToPdfRequestVm.InputTypeEnum.LINK);
	    // Set URL of web page to convert
	    data.setInput("http://google.com");

	    try
	    {
		    // Get converted PDF file from Web API
		    String base64EncodedImageFile = api.hTMLToPDFPostHtmlToPdf(data, API_KEY);
		    // Decode base64 string to byte array
		    byte[] bytes = SystemUtil.decodeBase64(base64EncodedImageFile);
		    // Write bytes to file
		    FileOutputStream outputStream = new FileOutputStream("result.pdf");
		    outputStream.write(bytes);
		    outputStream.close();
	    }
	    catch (ApiException e)
	    {
		    System.out.println(e.getMessage());
	    }
    }
}
