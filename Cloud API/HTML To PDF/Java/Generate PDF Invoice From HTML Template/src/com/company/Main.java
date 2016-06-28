package com.company;

import org.apache.http.HttpEntity;
import org.apache.http.client.methods.CloseableHttpResponse;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.ContentType;
import org.apache.http.entity.StringEntity;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClients;
import org.apache.http.message.BasicHeader;
import org.apache.http.util.EntityUtils;
import org.json.simple.JSONObject;

import java.io.*;
import java.net.URISyntaxException;

// This example demonstrates creation of PDF document from the HTML template and the template data in JSON form.

public class Main
{
	// The authentication key (API Key). 
    // Get your own by registering at https://secure.bytescout.com/users/sign_up
    final static String API_KEY = "******************************";

    public static void main(String[] args) throws IOException, URISyntaxException
    {
	    String template = loadFromFile("invoice_template.html");
	    String templateData = loadFromFile("invoice_data.json");

        String resultFileURL = null;

        CloseableHttpClient httpClient = HttpClients.createDefault();

        try
        {
            // 1. SEND CONVERSION COMMAND

            // Create POST request to HTML to PDF API: /api/v1/file/upload
            HttpPost httpPost = new HttpPost("https://bytescout.io//api/v1/htmltopdf/convert?apiKey=" + API_KEY);

            // Prepare request data in JSON format
            JSONObject jsonObject = new JSONObject();
            JSONObject converterProperties = new JSONObject();
            converterProperties.put("templateData", templateData);
            jsonObject.put("properties", converterProperties);
            jsonObject.put("inputType", "value");
            jsonObject.put("input", template);
            jsonObject.put("outputType", "link");

            // Set request params
            httpPost.setEntity(new StringEntity(jsonObject.toString(), ContentType.APPLICATION_JSON));
            httpPost.addHeader(new BasicHeader("Content-Type", "application/json"));

            System.out.println("executing request " + httpPost.getRequestLine());
            CloseableHttpResponse response = httpClient.execute(httpPost);
            System.out.println(response.getStatusLine());

            try
            {
                HttpEntity resEntity = response.getEntity();
                if (resEntity != null)
                {
                    // The response text contains the result file link
                    resultFileURL = EntityUtils.toString(resEntity);
                    System.out.println("Result file URL: " + resultFileURL);
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
                HttpGet httpGet = new HttpGet(resultFileURL);

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

    private static String loadFromFile(String fileName)
    {
        try
        {
            File file = new File(fileName);
            FileInputStream fileStream = new FileInputStream(file);
            byte[] bytes = new byte[(int) file.length()];
            fileStream.read(bytes);
            fileStream.close();

            return new String(bytes, "UTF-8");
        }
        catch (FileNotFoundException e)
        {
            e.printStackTrace();
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }

        return null;
    }
}
