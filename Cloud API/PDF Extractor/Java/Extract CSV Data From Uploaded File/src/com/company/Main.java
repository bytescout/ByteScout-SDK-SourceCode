package com.company;

import org.apache.http.HttpEntity;
import org.apache.http.client.methods.CloseableHttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.ContentType;
import org.apache.http.entity.mime.MultipartEntityBuilder;
import org.apache.http.entity.mime.content.FileBody;
import org.apache.http.entity.mime.content.StringBody;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClients;
import org.apache.http.util.EntityUtils;
import org.apache.http.client.utils.URIBuilder;

import java.io.File;
import java.io.IOException;
import java.net.URISyntaxException;

// This example demonstrates the using of PDF Extractor Web API

public class Main
{
	// Your authentication key
    final static String API_KEY = "##################################";

    public static void main(String[] args) throws IOException, URISyntaxException
    {
	    String inputFile = "sample.pdf";
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

	        // 2. Extract PDF document content as CSV

	        // Prepare URL for CSV Extractor API: GET /api/v1/pdfextractor/csvextractor/extract
	        String uri = new URIBuilder("https://bytescout.io/api/v1/pdfextractor/csvextractor/extract")
		        .addParameter("apiKey", API_KEY) // Your authentication key
		        .addParameter("properties.csvSeparatorSymbol", ";") // set CSV separator char
		        .addParameter("properties.csvQuotaionSymbol", "\"") // set CSV qutation char
		        .addParameter("properties.trimSpaces", "true") // trim spaces
		        .addParameter("inputType", "fileID") // set input type
		        .addParameter("input", uploadedFileId) // set "input" to the file ID we've got on the previous step
		        .addParameter("outputType", "content") // set "outputType" to "content"
		        .toString();

	        HttpGet httpGet = new HttpGet(uri);

	        System.out.println("Executing request " + httpGet.getRequestLine());

	        response = httpClient.execute(httpGet);

	        System.out.println(response.getStatusLine());

	        try
	        {
		        HttpEntity resEntity = response.getEntity();
		        if (resEntity != null)
		        {
			        // Get extracted text and display it in console
			        String result = EntityUtils.toString(resEntity);
			        System.out.println(result);
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
