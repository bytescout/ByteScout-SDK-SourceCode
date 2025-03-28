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
public class Main
{
    // The authentication key (API Key).
    // Get your own by registering at https://app.pdf.co/documentation/api
    final static String API_KEY = "***********************************";


    // Direct URL of source PDF file.
    final static String SourceFileUrl = "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample1.pdf";

    // Destination PDF file name
    final static Path DestinationFile = Paths.get(".\\protected.pdf");

    // Passwords to protect PDF document
    // The owner password will be required for document modification.
    // The user password only allows to view and print the document.
    final static String OwnerPassword = "123456";
    final static String UserPassword = "654321";

    // Encryption algorithm.
    // Valid values: "RC4_40bit", "RC4_128bit", "AES_128bit", "AES_256bit".
    final static String EncryptionAlgorithm = "AES_128bit";

    // Allow or prohibit content extraction for accessibility needs.
    final static boolean AllowAccessibilitySupport = true;

    // Allow or prohibit assembling the document.
    final static boolean AllowAssemblyDocument = true;

    // Allow or prohibit printing PDF document.
    final static boolean AllowPrintDocument = true;

    // Allow or prohibit filling of interactive form fields (including signature fields) in PDF document.
    final static boolean AllowFillForms = true;

    // Allow or prohibit modification of PDF document.
    final static boolean AllowModifyDocument = true;

    // Allow or prohibit copying content from PDF document.
    final static boolean AllowContentExtraction = true;

    // Allow or prohibit interacting with text annotations and forms in PDF document.
    final static boolean AllowModifyAnnotations = true;

    // Allowed printing quality.
    // Valid values: "HighResolution", "LowResolution"
    final static String PrintQuality = "HighResolution";

    // Runs processing asynchronously.
    // Returns Use JobId that you may use with /job/check to check state of the processing (possible states: working, failed, aborted and success).
    final static boolean async = false;


    public static void main(String[] args) throws IOException
    {
        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // Prepare URL for `PDF Security` API call
        String query = "https://localhost/pdf/security/add";

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
		String jsonPayload = String.format("{\n" +
                        "    \"name\": \"%s\",\n" +
                        "    \"url\": \"%s\",\n" +
                        "    \"ownerPassword\": \"%s\",\n" +
                        "    \"userPassword\": \"%s\",\n" +
                        "    \"EncryptionAlgorithm\": \"%s\",\n" +
                        "    \"AllowAccessibilitySupport\": %s,\n" +
                        "    \"AllowAssemblyDocument\": %s,\n" +
                        "    \"AllowPrintDocument\": %s,\n" +
                        "    \"AllowFillForms\": %s,\n" +
                        "    \"AllowModifyDocument\": %s,\n" +
                        "    \"AllowContentExtraction\": %s,\n" +
                        "    \"AllowModifyAnnotations\": %s,\n" +
                        "    \"PrintQuality\": \"%s\",\n" +
                        "    \"async\": %s\n" +
                        "}",
                DestinationFile.getFileName(), SourceFileUrl, OwnerPassword, UserPassword, EncryptionAlgorithm,
                Boolean.toString(AllowAccessibilitySupport), Boolean.toString(AllowAssemblyDocument), Boolean.toString(AllowPrintDocument),
                Boolean.toString(AllowFillForms), Boolean.toString(AllowModifyDocument), Boolean.toString(AllowContentExtraction),
                Boolean.toString(AllowModifyAnnotations),PrintQuality, Boolean.toString(async)
        );

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
                // Get URL of generated PDF file
                String resultFileUrl = json.get("url").getAsString();

                // Download PDF file
                downloadFile(webClient, resultFileUrl, DestinationFile.toFile());

                System.out.printf("Generated PDF file saved as \"%s\" file.", DestinationFile.toString());
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

        response.close();
    }
}
