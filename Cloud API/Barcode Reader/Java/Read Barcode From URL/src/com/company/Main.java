package com.company;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import okhttp3.*;

import java.io.*;

public class Main
{
    // (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY

    // The authentication key (API Key).
    // Get your own by registering at https://secure.bytescout.com/users/sign_up
    final static String API_KEY = "***********************************";

    // Direct URL of source file to search barcodes in.
	final static String SourceFileURL = "https://s3-us-west-2.amazonaws.com/bytescout-com/files/demo-files/cloud-api/barcode-reader/sample.pdf";
    // Comma-separated list of barcode types to search.
    // See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeReadFromUrlGet
    final static String BarcodeTypes = "Code128,Code39,Interleaved2of5,EAN13";
    // Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: '0,2-5,7-'.
    final static String Pages = "";


    public static void main(String[] args) throws IOException
    {
        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // Prepare URL for `Barcode Reader` API call
        String query = String.format(
                "https://bytescout.io/v1/barcode/read/from/url?types=%s&pages=%s&url=%s",
                BarcodeTypes,
                Pages,
                SourceFileURL);

        // Prepare request
        Request request = new Request.Builder()
                .url(query)
                .addHeader("x-api-key", API_KEY) // (!) Set API Key
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
