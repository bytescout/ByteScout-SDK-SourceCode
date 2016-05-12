package com.company;

import org.apache.http.HttpEntity;
import org.apache.http.client.methods.CloseableHttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.utils.URIBuilder;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClients;
import org.apache.http.util.EntityUtils;

import java.io.FileOutputStream;
import java.io.IOException;
import java.net.URISyntaxException;

// This example demonstrates the using of Barcode Generator Web API

public class Main
{
	// Your authentication key
    final static String API_KEY = "#####################################";

    public static void main(String[] args) throws IOException, URISyntaxException
    {
	    String resultFileURL = null;

        CloseableHttpClient httpClient = HttpClients.createDefault();

        try
        {
	        // 1. GENERATE BARCODE

	        // Prepare URL for Barcode Generator API: /api/v1/barcode/generate
	        String uri = new URIBuilder("https://bytescout.io/api/v1/barcode/generate")
		        .addParameter("apiKey", API_KEY) // set API Key
		        .addParameter("properties.symbology", "qrCode") // set barcode type
		        .addParameter("properties.outputFileType", "png") // set output image format
		        .addParameter("outputType", "link") // set output type to Link
		        .addParameter("input", "123456abcdef") // set barcode value
		        .toString();

	        HttpGet httpGet = new HttpGet(uri);

	        System.out.println("Executing request " + httpGet.getRequestLine());

	        CloseableHttpResponse response = httpClient.execute(httpGet);

	        System.out.println(response.getStatusLine());

	        try
	        {
		        HttpEntity resEntity = response.getEntity();
		        if (resEntity != null)
		        {
			        // The response text contains the result file link
			        resultFileURL = EntityUtils.toString(resEntity);
		        }
		        EntityUtils.consume(resEntity);
	        }
	        finally
	        {
		        response.close();
	        }

	        // 2. DOWNLOAD IMAGE FILE FROM LINK

	        if (resultFileURL != null)
	        {
		        httpGet = new HttpGet(resultFileURL);

		        System.out.println("Executing request " + httpGet.getRequestLine());

		        response = httpClient.execute(httpGet);

		        System.out.println(response.getStatusLine());

		        try
		        {
			        HttpEntity resEntity = response.getEntity();
			        if (resEntity != null)
			        {
				        // Save response stream to file
				        FileOutputStream outputStream = new FileOutputStream("barcode.png");
				        resEntity.writeTo(outputStream);
				        outputStream.close();
			        }
			        EntityUtils.consume(resEntity);
		        }
		        finally
		        {
			        response.close();
		        }
	        }
        }
        finally
        {
            httpClient.close();
        }
    }
}
