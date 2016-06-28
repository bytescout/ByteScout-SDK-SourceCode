package com.company;

import com.bytescout.client.ApiException;
import com.bytescout.client.api.BarcodeApi;
import com.bytescout.client.model.BarcodeOptionsVm;
import com.bytescout.client.model.BarcodeRequestVm;
import sun.plugin2.util.SystemUtil;

import java.io.FileOutputStream;
import java.io.IOException;
import java.net.URISyntaxException;

// This example demonstrates the using of Barcode Generator Web API

public class Main
{
	// The authentication key (API Key). 
    // Get your own by registering at https://secure.bytescout.com/users/sign_up
    final static String API_KEY = "#####################################";
    
    public static void main(String[] args) throws IOException, URISyntaxException
    {
	    // Create Barcode Generator API object instance
	    BarcodeApi api = new BarcodeApi();

	    // Create barcode properties
	    BarcodeOptionsVm properties = new BarcodeOptionsVm();
	    // Set barcode type (symbology)
	    properties.setSymbology(BarcodeOptionsVm.SymbologyEnum.QRCODE);
	    // Set output image format
	    properties.setOutputFileType(BarcodeOptionsVm.OutputFileTypeEnum.PNG);

	    // Create barcode request data
	    BarcodeRequestVm data = new BarcodeRequestVm();
	    // Pass properties
	    data.setProperties(properties);
	    // Set output type to ContentBase64 (the result image will be returned as base64-encoded string)
	    data.setOutputType(BarcodeRequestVm.OutputTypeEnum.CONTENTBASE64);
	    // Set input type to Value
	    data.setInputType(BarcodeRequestVm.InputTypeEnum.VALUE);
	    // Set barcode value
	    data.setInput("BARCODE VALUE 1234567");

	    try
	    {
		    // Get barcode from Web API
		    String base64EncodedImageFile = api.barcodePostBarCode(data, API_KEY);
		    // Decode base64 string to byte array
		    byte[] bytes = SystemUtil.decodeBase64(base64EncodedImageFile);
		    // Write bytes to file
		    FileOutputStream outputStream = new FileOutputStream("barcode.png");
		    outputStream.write(bytes);
		    outputStream.close();
	    }
	    catch (ApiException e)
	    {
		    System.out.println(e.getMessage());
	    }
    }
}
