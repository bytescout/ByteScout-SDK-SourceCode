//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
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

/*
The following options are available through profiles:
(JSON can be single/double-quoted and contain comments.)
{
    "profiles": [
        {
            "profile1": {
                "TextSmoothingMode": "HighQuality", // Valid values: "HighSpeed", "HighQuality"
                "VectorSmoothingMode": "HighQuality", // Valid values: "HighSpeed", "HighQuality"
                "ImageInterpolationMode": "HighQuality", // Valid values: "HighSpeed", "HighQuality"
                "RenderTextObjects": true, // Valid values: true, false
                "RenderVectorObjects": true, // Valid values: true, false
                "RenderImageObjects": true, // Valid values: true, false
                "RenderCurveVectorObjects": true, // Valid values: true, false
                "JPEGQuality": 85, // from 0 (lowest) to 100 (highest)
                "TIFFCompression": "LZW", // Valid values: "None", "LZW", "CCITT3", "CCITT4", "RLE"
                "RotateFlipType": "RotateNoneFlipNone", // RotateFlipType enum values from here: https://docs.microsoft.com/en-us/dotnet/api/system.drawing.rotatefliptype?view=netframework-2.0
                "ImageBitsPerPixel": "BPP24", // Valid values: "BPP1", "BPP8", "BPP24", "BPP32"
                "OneBitConversionAlgorithm": "OtsuThreshold", // Valid values: "OtsuThreshold", "BayerOrderedDithering"
                "FontHintingMode": "Default", // Valid values: "Default", "Stronger"
                "NightMode": false // Valid values: true, false
            }
        }
    ]
}
*/

public class Main
{
    // The authentication key (API Key).
    // Get your own by registering at https://app.pdf.co
    final static String API_KEY = "***********************************";

    // Direct URL of source PDF file.
    // You can also upload your own file into PDF.co and use it as url. Check "Upload File" samples for code snippets: https://github.com/bytescout/pdf-co-api-samples/tree/master/File%20Upload/    
    final static String SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf";
    // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    final static String Pages = "";
    // PDF document password. Leave empty for unprotected documents.
    final static String Password = "";
    // Destination TIFF file name
    final static Path DestinationFile = Paths.get(".\\result.tif");
    // Advanced options
    final static String Profiles = "{ 'profiles': [ { 'profile1': { 'TIFFCompression': 'CCITT4' } } ] }";

    public static void main(String[] args) throws IOException
    {
        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // Prepare URL for `PDF To TIFF` API call
        String query = "https://api.pdf.co/v1/pdf/convert/to/tiff";

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
		String jsonPayload = String.format("{\"name\": \"%s\", \"password\": \"%s\", \"pages\": \"%s\", \"url\": \"%s\", \"profiles\": \"%s\"}",
                DestinationFile.getFileName(),
                Password,
                Pages,
                SourceFileUrl,
                Profiles);

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
                // Get URL of generated TIFF file
                String resultFileUrl = json.get("url").getAsString();

                // Download TIFF file
                downloadFile(webClient, resultFileUrl, DestinationFile.toFile());

                System.out.printf("Generated TIFF file saved as \"%s\" file.", DestinationFile.toString());
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