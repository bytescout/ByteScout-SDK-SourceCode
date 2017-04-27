package com.company;

import com.bytescout.client.ApiClient;
import com.bytescout.client.Configuration;
import com.bytescout.client.api.DefaultApi;
import com.bytescout.client.auth.ApiKeyAuth;
import com.bytescout.client.model.FileUploadBase64RequestModel;
import com.bytescout.client.model.SingleResponseModel;
import sun.misc.BASE64Encoder;

import java.io.IOException;
import java.net.URISyntaxException;
import java.net.URL;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.nio.file.StandardCopyOption;

public class Main
{
    // The authentication key (API Key).
    // Get your own by registering at https://secure.bytescout.com/users/sign_up
    final static String API_KEY = "##################################";

    public static void main(String[] args) throws IOException, URISyntaxException
    {
        Path inputFilePath = Paths.get("sample.pdf");
        Path outputFilePath = Paths.get("result.csv");

        try
        {
            // Configure API key authorization
            ApiClient defaultClient = Configuration.getDefaultApiClient();
            ApiKeyAuth apiKey = (ApiKeyAuth) defaultClient.getAuthentication("api_key");
            apiKey.setApiKey(API_KEY);

            // Create API instance
            DefaultApi api = new DefaultApi();

            // Convert file bytes to Base64-encoded string
            byte[] bytes = Files.readAllBytes(inputFilePath);
            String encodedBytes = new BASE64Encoder().encode(bytes);

            // Upload file to cloud (for temporary storage)
            FileUploadBase64RequestModel fileUploadRequest = new FileUploadBase64RequestModel();
            fileUploadRequest.setFile(encodedBytes);
            SingleResponseModel uploadResponse = api.fileUploadBase64Post(fileUploadRequest, inputFilePath.getFileName().toString());

            if (!uploadResponse.getError())
            {
                // Convert uploaded PDF to CSV
                String uploadedFileAccessUrl = uploadResponse.getUrl();
                String fileName = outputFilePath.getFileName().toString();
                String pages = ""; // Comma-separated list of pages in form "1,3,4" (leave empty for all pages)
                SingleResponseModel conversionResponse = api.pdfConvertToCsvGet(pages, fileName, uploadedFileAccessUrl);

                if (!conversionResponse.getError())
                {
                    // Download the converted file
                    String resultUrl = conversionResponse.getUrl();
                    URL website = new URL(resultUrl);
                    Files.copy(website.openStream(), outputFilePath, StandardCopyOption.REPLACE_EXISTING);
                }
            }
        }
        catch (Exception e)
        {
            System.err.println(e.getMessage());
            e.printStackTrace();
        }
    }
}
