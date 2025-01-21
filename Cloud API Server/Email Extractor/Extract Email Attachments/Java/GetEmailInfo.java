//*******************************************************************************************//
//                                                                                           //
// Get Your API Key: https://app.pdf.co/signup                                               //
// API Documentation: https://developer.pdf.co/api/index.html                                //
//                                                                                           //
// Note: Replace placeholder values in the code with your API Key                            //
// and file paths (if applicable)                                                            //
//                                                                                           //
//*******************************************************************************************//


import java.io.*;
import okhttp3.*;

// Please NOTE: In this sample we're assuming Cloud Api Server is hosted at "https://localhost". 
// If it's not then please replace this with with your hosting url.
public class main {
		public static void main(String []args) throws IOException{
				OkHttpClient client = new OkHttpClient().newBuilder()
						.build();
				MediaType mediaType = MediaType.parse("application/json");
				RequestBody body = new MultipartBody.Builder().setType(MultipartBody.FORM)
						.addFormDataPart("url", "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/email-extractor/sample.eml")
						.build();
				Request request = new Request.Builder()
						.url("https://localhost/email/extract-attachments")
						.method("POST", body)
						.addHeader("Content-Type", "application/json")
						.addHeader("x-api-key", "{{x-api-key}}")
						.build();
				Response response = client.newCall(request).execute();
				System.out.println(response.body().string());
		}
}
