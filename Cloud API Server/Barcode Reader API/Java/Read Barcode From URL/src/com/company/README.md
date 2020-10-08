## How to read barcode from URL for barcode reader API in Java with ByteScout Cloud API Server ByteScout Cloud API Server: the ready to deploy Web API Server that can be deployed in less than thirty minutes into your own in-house Windows server (no Internet connnection is required to process data!) or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using built-in ByteScout powered engine, no cloud services are used to process your data!.

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

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import okhttp3.*;

import java.io.*;
import java.net.*;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.
public class Main
{
    // Direct URL of source file to search barcodes in.
	final static String SourceFileURL = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf";
    // Comma-separated list of barcode types to search.
    // barcode types 
    final static String BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13";
    // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    final static String Pages = "";


    public static void main(String[] args) throws IOException
    {
        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // Prepare URL for `Barcode Reader` API call
        String query = String.format(
                "https://localhost/barcode/read/from/url?types=%s&pages=%s&url=%s",
                BarcodeTypes,
                Pages,
                SourceFileURL);
        
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

            boolean error = json.get("error").getAsBoolean();
            if (!error)
            {
                // Display found barcodes in console
                for (JsonElement element : json.get("barcodes").getAsJsonArray())
                {
                    JsonObject barcode = (JsonObject) element;
                    System.out.println("Found barcode:");
                    System.out.println("  Type: " + barcode.get("TypeName").getAsString());
                    System.out.println("  Value: " + barcode.get("Value").getAsString());
                    System.out.println("  Document Page Index: " + barcode.get("Page").getAsString());
                    System.out.println("  Rectangle: " + barcode.get("Rect").getAsString());
                    System.out.println("  Confidence: " + barcode.get("Confidence").getAsString());
                    System.out.println();
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

```

<!-- code block end -->