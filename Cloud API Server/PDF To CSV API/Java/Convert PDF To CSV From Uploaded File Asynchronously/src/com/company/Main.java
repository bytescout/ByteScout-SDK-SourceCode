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

import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import okhttp3.*;

import java.io.*;
import java.net.*;
import java.nio.file.Path;
import java.nio.file.Paths;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

//
// PDF.co Web API example for processing large documents using asynchronous API.
//
public class Main
{
    // Source PDF file
    final static Path SourceFile = Paths.get(".\\sample.pdf");
    // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    final static String Pages = "";
    // PDF document password. Leave empty for unprotected documents.
    final static String Password = "";
    // Destination CSV file name
    final static Path DestinationFile = Paths.get(".\\result.csv");
    // (!) Create asynchronous job
	final static boolean Async = true;

    public static void main(String[] args) throws IOException
    {
        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // 1. RETRIEVE THE PRESIGNED URL TO UPLOAD THE FILE.
        // * If you already have a direct file URL, skip to the step 3.

        // Prepare URL for `Get Presigned URL` API call
        String query = String.format(
                "https://localhost/file/upload/get-presigned-url?contenttype=application/octet-stream&name=%s",
                SourceFile.getFileName());

        // Prepare request
        Request request = new Request.Builder()
                .url(query)
                .build();

        // Execute request
        Response response = webClient.newCall(request).execute();

        if (response.code() == 200)
        {
            // Parse JSON response
            JsonObject json = new JsonParser().parse(response.body().string()).getAsJsonObject();

            String status = json.get("status").getAsString();
            if (!status.equals("error"))
            {
                // Get URL to use for the file upload
                String uploadUrl = json.get("presignedUrl").getAsString();
                // Get URL of uploaded file to use with later API calls
                String uploadedFileUrl = json.get("url").getAsString();

                // 2. UPLOAD THE FILE TO CLOUD.
                if (uploadFile(webClient, uploadUrl, SourceFile))
                {
                    // 3. CONVERT UPLOADED PDF FILE TO CSV

                    PdfToCsv(webClient, DestinationFile, Password, Pages, uploadedFileUrl);
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

    public static void PdfToCsv(OkHttpClient webClient, Path destinationFile,
        String password, String pages, String uploadedFileUrl) throws IOException
    {
        // Prepare URL for `PDF To CSV` API call
        String query = String.format(
                "https://localhost/pdf/convert/to/csv?name=%s&password=%s&pages=%s&url=%s&async=%s",
                destinationFile.getFileName(),
                password,
                pages,
                uploadedFileUrl,
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

            String status = json.get("status").getAsString();
            if (!status.equals("error"))
            {
                // Asynchronous job ID
                String jobId = json.get("jobId").getAsString();
                // Get URL of generated CSV file
                String resultFileUrl = json.get("url").getAsString();

                // Check the job status in a loop.
                // If you don't want to pause the main thread you can rework the code
                // to use a separate thread for the status checking and completion.
                do
                {
                    status = checkJobStatus(webClient,  jobId); // Possible statuses: "working", "failed", "aborted", "success".

                    // Display timestamp and status (for demo purposes)
                    System.out.println(java.time.LocalDateTime.now() + ": " + status);

                    if (status.equals("success"))
                    {
                        // Download CSV file
                        downloadFile(webClient, resultFileUrl, destinationFile.toFile());

                        System.out.printf("Generated CSV file saved as \"%s\" file.", destinationFile.toString());
                        break;
                    }
                    else if (status.equals("working"))
                    {
                        // Pause for a few seconds
                        try {
                            Thread.sleep(3000);
                        } catch (InterruptedException e) {
                            e.printStackTrace();
                        }
                    }
                    else
                    {
                        System.out.printf(status);
                        break;
                    }
                }
                while (true);
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

    public static boolean uploadFile(OkHttpClient webClient, String url, Path sourceFile) throws IOException
    {
        // Prepare request body
        RequestBody body = RequestBody.create(MediaType.parse("application/octet-stream"), sourceFile.toFile());

        // Prepare request
        Request request = new Request.Builder()
                .url(url)
                .addHeader("content-type", "application/octet-stream")
                .put(body)
                .build();

        // Execute request
        Response response = webClient.newCall(request).execute();

        return (response.code() == 200);
    }

    public static String checkJobStatus(OkHttpClient webClient, String jobId) throws IOException
    {
        // Prepare URL for `PDF To CSV` API call
        String url = String.format("https://localhost/job/check?jobid=%s", jobId);

        // Prepare request
        Request request = new Request.Builder()
                .url(url)
                .build();

        // Execute request
        Response response = webClient.newCall(request).execute();

        // Parse JSON response
        JsonObject json = new JsonParser().parse(response.body().string()).getAsJsonObject();

        return json.get("status").getAsString();
    }

    public static void downloadFile(OkHttpClient webClient, String url, File destinationFile) throws IOException
    {
        // Prepare request
        Request request = new Request.Builder()
                .url(url)
                .build();
        // Execute request
        Response response = webClient.newCall(request).execute();

        byte[] fileBytes = response.body().bytes();

        // Save downloaded bytes to file
        OutputStream output = new FileOutputStream(destinationFile);
        output.write(fileBytes);
        output.flush();
        output.close();
    }
}
