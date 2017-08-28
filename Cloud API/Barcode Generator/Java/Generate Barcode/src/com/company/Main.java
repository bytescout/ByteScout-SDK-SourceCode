package com.company;

import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.Response;

import java.io.*;
import java.nio.file.Path;
import java.nio.file.Paths;

public class Main
{
    // (!) If you are getting '(403) Forbidden' error please ensure you have set the correct API_KEY

    // The authentication key (API Key).
    // Get your own by registering at https://secure.bytescout.com/users/sign_up
    final static String API_KEY = "***********************************";

    public static void main(String[] args) throws IOException
    {
        // Result file name
		final Path ResultFile = Paths.get(".\\barcode.png");
        // Barcode type. See valid barcode types in the documentation https://secure.bytescout.com/cloudapi.html#api-Default-barcodeGenerateGet
		final String BarcodeType = "Code128";
        // Barcode value
		final String BarcodeValue = "qweasd123456";

        // Prepare URL for `Barcode Generator` API call
        String query = String.format(
                "https://bytescout.io/v1/barcode/generate?name=%1s&type=%2s&value=%3s",
                ResultFile.getFileName(),
                BarcodeType,
                BarcodeValue);

        // Create standard HTTP client instance
        OkHttpClient webClient = new OkHttpClient();
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
                // Get URL of generated barcode image file
                String resultFileUrl = json.get("url").getAsString();

                // Download the image file
                downloadFile(webClient, resultFileUrl, ResultFile.toFile());

                System.out.printf("Generated barcode saved to \"%1s\" file.", ResultFile.toString());
            }
            else
            {
                System.out.println(json.get("message").getAsString());
            }
        }
        else
        {
            System.out.println(response.code() + " " + response.message());
        }
    }

    public static void downloadFile(OkHttpClient webClient, String url, File destinationFile) throws IOException
    {
        Request request = new Request.Builder()
                .url(url)
                .build();

        Response response = webClient.newCall(request).execute();
        InputStream inputStream = response.body().byteStream();
        BufferedInputStream input = new BufferedInputStream(inputStream);
        OutputStream output = new FileOutputStream(destinationFile);

        byte[] data = new byte[1024];
        int count;
        while ((count = input.read(data)) != -1)
            output.write(data, 0, count);
        output.flush();
        output.close();
        input.close();
        response.close();
    }
}
