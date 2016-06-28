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

import java.io.*;
import java.net.URISyntaxException;

// This example demonstrates the using of HTML to PDF Web API

public class Main
{
	// The authentication key (API Key). 
    // Get your own by registering at https://secure.bytescout.com/users/sign_up
    final static String API_KEY = "##################################";

    public static void main(String[] args) throws IOException, URISyntaxException
    {
	    String inputURL = "http://google.com";
	    String resultFileURL = null;

        CloseableHttpClient httpClient = HttpClients.createDefault();

        try
        {
	        // 1. SEND CONVERSION COMMAND

	        // Prepare URL for HTML to PDF API: /api/v1/htmltopdf/convert
	        String uri = new URIBuilder("https://bytescout.io//api/v1/htmltopdf/convert")
		        .addParameter("apiKey", API_KEY) // Your authentication key
		        .addParameter("properties.title", "GOOGLE.COM") // set PDF document title (optional)
		        .addParameter("properties.orientation", "landscape") // set page orientation (portrait/landscape)
		        .addParameter("properties.headerHTML", "<div style=\"display: block; text-align: right;\">*** Header ***</div>") // set header text for each PDF page (optional)
		        .addParameter("properties.footerHTML", "*** Footer ***") // set footer text for each PDF page (optional)
		        .addParameter("inputType", "link") // set input type
		        .addParameter("input", inputURL) // set URL to convert
		        .addParameter("outputType", "link") // set OutputType to Link
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


	        // 2. DOWNLOAD FILE FROM LINK

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
				        FileOutputStream outputStream = new FileOutputStream("result.pdf");
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
