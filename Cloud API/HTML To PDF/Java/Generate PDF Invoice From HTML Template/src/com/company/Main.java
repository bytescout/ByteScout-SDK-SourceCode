package com.company;

import com.google.gson.JsonObject;
import com.google.gson.JsonParser;
import com.google.gson.JsonPrimitive;
import okhttp3.*;

import java.io.*;
import java.nio.file.Files;
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
        // HTML template
        final String template = new String(Files.readAllBytes(Paths.get(".\\invoice_template.html")));
        // Data to fill the template
        final String templateData = new String(Files.readAllBytes(Paths.get(".\\invoice_data.json")));
        // Destination PDF file name
        final Path destinationFile = Paths.get(".\\result.pdf");

        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // Prepare URL for `HTML to PDF` API call
        String query = String.format(
                "https://bytescout.io/v1/pdf/convert/from/html?name=%s",
                destinationFile.getFileName());

        // Prepare request body in JSON format
        JsonObject jsonBody = new JsonObject();
        jsonBody.add("html", new JsonPrimitive(template));
        jsonBody.add("templateData", new JsonPrimitive(templateData));

        RequestBody body = RequestBody.create(MediaType.parse("application/json"), jsonBody.toString());

        // Prepare request
        Request request = new Request.Builder()
                .url(query)
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
                downloadFile(webClient, resultFileUrl, destinationFile.toFile());

                System.out.printf("Generated PDF file saved as \"%s\" file.", destinationFile.toString());
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
