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
import java.io.FileOutputStream;
import java.io.IOException;
import java.net.URISyntaxException;

// This example demonstrates the using of PDF Renderer Web API

public class Main
{
	// The authentication key (API Key). 
    // Get your own by registering at https://secure.bytescout.com/users/sign_up
    final static String API_KEY = "#####################################";

    public static void main(String[] args) throws IOException, URISyntaxException
    {
	    String inputFile = "sample.pdf";
	    String uploadedFileId = null;
	    String resultFileURL = null;

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


	        // 2. CONVERT PDF TO IMAGE

	        if (uploadedFileId != null)
	        {
		        // Prepare URL for PDF Renderer API: /api/v1/pdfrenderer/render
		        String uri = new URIBuilder("https://bytescout.io/api/v1/pdfrenderer/render")
			        .addParameter("apiKey", API_KEY) // set API Key
			        .addParameter("properties.pageIndex", "0") // set page index to convert (optional)
			        .addParameter("properties.resolution", "300") // set rendering resolution
			        .addParameter("properties.JPEGQuality", "85") // set JPEG quality
			        .addParameter("properties.rasterOutputFormat", "jpeg") // set JPEG output format
			        .addParameter("inputType", "fileID") // set input type
			        .addParameter("input", uploadedFileId) // set Input to the file ID we've got on the previous step
			        .addParameter("outputType", "link") // set output type to Link
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
				        // The response text contains the result file link
				        resultFileURL = EntityUtils.toString(resEntity);
			        }
			        EntityUtils.consume(resEntity);
		        }
		        finally
		        {
			        response.close();
		        }


		        // 3. DOWNLOAD IMAGE FILE FROM LINK

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
					        FileOutputStream outputStream = new FileOutputStream("result.jpg");
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
        }
        finally
        {
            httpClient.close();
        }
    }
}
