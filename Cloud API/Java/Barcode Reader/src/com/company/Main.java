package com.company;

import org.apache.http.HttpEntity;
import org.apache.http.client.methods.CloseableHttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.client.utils.URIBuilder;
import org.apache.http.entity.ContentType;
import org.apache.http.entity.mime.MultipartEntityBuilder;
import org.apache.http.entity.mime.content.FileBody;
import org.apache.http.entity.mime.content.StringBody;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClients;
import org.apache.http.util.EntityUtils;

import java.io.File;
import java.io.IOException;
import java.net.URISyntaxException;

// This example demonstrates the using of Barcode Reader Web API

public class Main
{
	// Your authentication key
    final static String API_KEY = "#####################################";

    public static void main(String[] args) throws IOException, URISyntaxException
    {
	    String inputFile = "QRCode.jpg";
	    String uploadedFileId = null;

        CloseableHttpClient httpClient = HttpClients.createDefault();

        try
        {
	        // 1. UPLOAD FILE

	        // Create POST request for File API /api/v1/file/upload
            HttpPost httpPost = new HttpPost("https://bytescout.io/api/v1/file/upload?apiKey=" + API_KEY);

	        // Fill form-data according to API ( https://bytescout.io/docs/index )
            FileBody fileBody = new FileBody(new File(inputFile));
            HttpEntity reqEntity = MultipartEntityBuilder.create()
                .addPart("file", fileBody)
                .addPart("storageTime", new StringBody("600", ContentType.TEXT_PLAIN))
                .build();
	        httpPost.setEntity(reqEntity);

            System.out.println("executing request " + httpPost.getRequestLine());
	        CloseableHttpResponse response = httpClient.execute(httpPost);
	        System.out.println(response.getStatusLine());

	        try
            {
                HttpEntity resEntity = response.getEntity();
                if (resEntity != null)
                {
	                // Get uploaded file ID from the response
	                uploadedFileId = EntityUtils.toString(resEntity);
	                System.out.println("Uploaded file ID: " + uploadedFileId);
                }
                EntityUtils.consume(resEntity);
            }
            finally
            {
                response.close();
            }

	        // 2. READ BARCODE

	        // Prepare URL for Barcode Reader API /api/v1/barcodereader/read
	        String uri = new URIBuilder("https://bytescout.io/api/v1/barcodereader/read")
				.addParameter("apiKey", API_KEY) // set API Key
		        .addParameter("properties.barcodeTypesToFind.qrCode", "true") // enable QR Code decoding
		        .addParameter("inputType", "fileID") // set input type
		        .addParameter("input", uploadedFileId) // set Input to the file ID we've got on the previous step
		        .toString();

	        HttpGet httpGet = new HttpGet(uri);

	        // Set the result format to JSON. Change to "application/xml" if you prefer XML.
	        httpGet.setHeader("Accept", "application/json");

	        System.out.println("Executing request " + httpGet.getRequestLine());

	        response = httpClient.execute(httpGet);

	        System.out.println(response.getStatusLine());

	        try
	        {
		        HttpEntity resEntity = response.getEntity();
		        if (resEntity != null)
		        {
			        // Get decoded barcodes
			        String result = EntityUtils.toString(resEntity);
			        System.out.println("Found barcodes: " + result);
		        }
		        EntityUtils.consume(resEntity);
	        }
	        finally
	        {
		        response.close();
	        }
        }
        finally
        {
            httpClient.close();
        }
    }
}
