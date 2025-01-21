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
				RequestBody body = RequestBody.create(mediaType, "{\n    \"url\": \"https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf\"\n}");
				Request request = new Request.Builder()
						.url("https://localhost/file/hash")
						.method("POST", body)
						.addHeader("x-api-key", "{{x-api-key}}")
						.addHeader("Content-Type", "application/json")
						.build();
				Response response = client.newCall(request).execute();
				System.out.println(response.body().string());
		}
}
