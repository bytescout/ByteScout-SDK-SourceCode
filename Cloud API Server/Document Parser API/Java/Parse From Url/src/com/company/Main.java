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
import com.google.gson.JsonPrimitive;
import okhttp3.*;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.nio.charset.StandardCharsets;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.

public class Main {

    public static void main(String[] args) throws IOException {
        // Source PDF file
        final String SourceFileUrl = "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf";
        // PDF document password. Leave empty for unprotected documents.
        final String Password = "";
        // Destination JSON file name
        final Path DestinationFile = Paths.get(".\\result.json");

        // Template text. Use Document Parser (https://pdf.co/document-parser, https://app.pdf.co/document-parser)
        // to create templates.
        // Read template from file:
        String templateText = new String(Files.readAllBytes(Paths.get(".\\MultiPageTable-template1.yml")), StandardCharsets.UTF_8);

        // Create HTTP client instance
        OkHttpClient webClient = new OkHttpClient();

        // PARSE UPLOADED PDF DOCUMENT
        ParseDocument(webClient, DestinationFile, Password, SourceFileUrl, templateText);
    }

    public static void ParseDocument(OkHttpClient webClient, Path destinationFile,
                                     String password, String uploadedFileUrl, String templateText) throws IOException {
        // Prepare POST request body in JSON format
        JsonObject jsonBody = new JsonObject();
        jsonBody.add("url", new JsonPrimitive(uploadedFileUrl));
        jsonBody.add("template", new JsonPrimitive(templateText));

        RequestBody body = RequestBody.create(MediaType.parse("application/json"), jsonBody.toString());

        // Prepare request to `Document Parser` API
        Request request = new Request.Builder()
                .url("https://localhost/pdf/documentparser")
                .addHeader("Content-Type", "application/json")
                .post(body)
                .build();

        // Execute request
        Response response = webClient.newCall(request).execute();

        if (response.code() == 200) {
            // Parse JSON response
            JsonObject json = new JsonParser().parse(response.body().string()).getAsJsonObject();

            boolean error = json.get("error").getAsBoolean();
            if (!error) {
                // Get URL of generated JSON file
                String resultFileUrl = json.get("url").getAsString();

                // Download JSON file
                downloadFile(webClient, resultFileUrl, destinationFile.toFile());

                System.out.printf("Generated JSON file saved as \"%s\" file.", destinationFile.toString());
            } else {
                // Display service reported error
                System.out.println(json.get("message").getAsString());
            }
        } else {
            // Display request error
            System.out.println(response.code() + " " + response.message());
        }
    }

    public static void downloadFile(OkHttpClient webClient, String url, File destinationFile) throws IOException {
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
