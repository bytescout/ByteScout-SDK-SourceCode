## How to PDF text search API for src in Java and ByteScout Cloud API Server ByteScout Cloud API Server: API server that is ready to use and can be installed and deployed in less than 30 minutes on your own Windows server or server in a cloud. It can save data and files on your local server-based file storage or in Amazon AWS S3 storage. Data is processed solely on the API server and is powered by ByteScout engine, no cloud services or Internet connection is required for data processing..

## REQUEST FREE TECH SUPPORT

[Click here to get in touch](https://bytescout.zendesk.com/hc/en-us/requests/new?subject=ByteScout%20Cloud%20API%20Server%20Question)

or just send email to [support@bytescout.com](mailto:support@bytescout.com?subject=ByteScout%20Cloud%20API%20Server%20Question) 

## ON-PREMISE OFFLINE SDK 

[Get Your 60 Day Free Trial](https://bytescout.com/download/web-installer?utm_source=github-readme)
[Explore Documentation](https://bytescout.com/documentation/index.html?utm_source=github-readme)
[Explore Source Code Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/)
[Sign Up For Online Training](https://academy.bytescout.com/)


## ON-DEMAND REST WEB API

[Get your API key](https://app.pdf.co/signup?utm_source=github-readme)
[Security](https://pdf.co/security)
[Explore Web API Documentation](https://apidocs.pdf.co?utm_source=github-readme)
[Explore Web API Samples](https://github.com/bytescout/ByteScout-SDK-SourceCode/tree/master/PDF.co%20Web%20API)

## VIDEO REVIEW

[https://www.youtube.com/watch?v=NEwNs2b9YN8](https://www.youtube.com/watch?v=NEwNs2b9YN8)




<!-- code block begin -->

##### **Main.java:**
    
```
package com.company;

import com.google.gson.JsonArray;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import okhttp3.*;

import java.io.*;
import java.net.*;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.
public class Main
{
    // Direct URL of source PDF file.
    final static String SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf";

    // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    final static String Pages = "";

    // PDF document password. Leave empty for unprotected documents.
	final static String Password = "";

    // Search string.
	final static String SearchString = "\\d{1,}\\.\\d\\d"; // Regular expression to find numbers like '100.00'
    // Note: do not use `+` char in regex, but use `{1,}` instead.
    // `+` char is valid for URL and will not be escaped, and it will become a space char on the server side.

    // Enable regular expressions (Regex)
    final static boolean RegexSearch = true;

    // (!) Make asynchronous job
    final static  boolean Async = true;


    public static void main(String[] args) throws IOException
    {
        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // Prepare URL for PDF text search API call.
        String query = String.format(
                "https://localhost/pdf/find?password=%s&pages=%s&url=%s&searchString=%s&regexSearch=%s&async=%s",
                Password,
                Pages,
                SourceFileURL,
                SearchString,
                RegexSearch,
                Async);
        
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

        DateTimeFormatter dtf = DateTimeFormatter.ofPattern("MM/dd/yyyy HH:mm:ss");

        // Prepare request
        Request request = new Request.Builder()
                .url(url)
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
                // Asynchronous job ID
                String jobId = json.get("jobId").getAsString();

                System.out.println("Job#" + jobId + ": has been created. - " + dtf.format(LocalDateTime.now()));

                // URL of generated json file that will available after the job completion
                String resultFileUrl = json.get("url").getAsString();

                // Check the job status in a loop.
                // If you don't want to pause the main thread you can rework the code
                // to use a separate thread for the status checking and completion.
                do {
                    String status = CheckJobStatus(webClient, jobId);  // Possible statuses: "working", "failed", "aborted", "success".

                    System.out.println("Job#" + jobId + ": " + status + " - " + dtf.format(LocalDateTime.now()));


                    if(status.compareToIgnoreCase("success") == 0){

                        // Build request for job url
                        request = new Request.Builder()
                                .url(resultFileUrl)
                                .build();

                        // Execute request
                        response =  webClient.newCall(request).execute();

                        // Parse JSON response
                        JsonArray jsonArray = new JsonParser().parse(response.body().string()).getAsJsonArray();

                        // Display found items in console
                        for (JsonElement element : jsonArray)
                        {
                            JsonObject item = (JsonObject) element;
                            System.out.println("Found text " + item.get("text") + " at coordinates " + item.get("left") + ", "+ item.get("top"));
                        }

                        break;
                    }
                    else if (status.compareToIgnoreCase("working") == 0){
                        // Pause for a few seconds
                        try{
                            Thread.sleep(3000);
                        }
                        catch (InterruptedException ex){
                            Thread.currentThread().interrupt(); // restore interrupted status
                        }
                    }
                    else{
                        System.out.println(status);
                        break;
                    }
                }while (true);
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


    // Check Job Status
    private  static String CheckJobStatus(OkHttpClient webClient, String jobId) throws IOException {

        String url = "https://localhost/job/check?jobid=" + jobId;

        // Prepare request
        Request request = new Request.Builder()
                .url(url)
                .build();

        // Execute request
        Response response = webClient.newCall(request).execute();

        if (response.code() == 200)
        {
            // Parse JSON response
            JsonObject json = new JsonParser().parse(response.body().string()).getAsJsonObject();

            return json.get("status").getAsString();
        }
        else
        {
            // Display request error
            System.out.println(response.code() + " " + response.message());
        }

        return "Failed";
    }
}
```

<!-- code block end -->