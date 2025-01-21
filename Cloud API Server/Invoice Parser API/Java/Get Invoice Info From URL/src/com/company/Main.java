//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


package com.company;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import okhttp3.*;

import java.io.*;
import java.net.*;
import java.util.Map;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.
public class Main
{
    // The authentication key (API Key).
    // Get your own by registering at https://app.pdf.co/documentation/api
    final static String API_KEY = "***********************************";

    // Direct URL of PDF file to get information
	final static String SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-json/sample.pdf";


    public static void main(String[] args) throws IOException
    {
        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // Prepare URL for `Invoice Parser` API call
        String query = "https://localhost/pdf/invoiceparser";

        // Make correctly escaped (encoded) URL
        URL url = null;
        try
        {
            url = new URI(null, query, null).toURL();
        }
        catch (URISyntaxException e)
        {
            e.printStackTrace();
        }

        // Create JSON payload
		String jsonPayload = String.format("{\"url\": \"%s\", \"inline\": \"True\"}",
                SourceFileURL);

        // Prepare request body
        RequestBody body = RequestBody.create(MediaType.parse("application/json"), jsonPayload);
        
        // Prepare request
        Request request = new Request.Builder()
            .url(url)
            .addHeader("x-api-key", API_KEY) // (!) Set API Key
            .addHeader("Content-Type", "application/json")
            .post(body)
            .build();
        
        // Execute request
        Response response = webClient.newCall(request).execute();

        if (response.code() == 200)
        {
            // Parse JSON response
            JsonObject json = new JsonParser().parse(response.body().string()).getAsJsonObject();

            boolean error = json.get("error").getAsBoolean();
            if (!error)
            {
                // Display PDF document information
                JsonObject info = (JsonObject) json.get("body");
                for (Map.Entry<String, JsonElement> entry : info.entrySet())
                {
                    System.out.println(entry.getKey() + ": " + entry.getValue());
                }
            }
            else
            {
                // Display service reported error
                System.out.println(json.get("message").getAsString());
            }
        }
        else
        {
            // Display request error
            System.out.println(response.code() + " " + response.message());
        }
    }
}
