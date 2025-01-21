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
public class main {
	public static void main(String []args) throws IOException{
		OkHttpClient client = new OkHttpClient().newBuilder()
			.build();
		MediaType mediaType = MediaType.parse("application/json");
		RequestBody body = RequestBody.create(mediaType, "{\n    \"url\": \"https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/document-parser/sample-invoice.pdf\",\n    \"rulescsv\": \"Amazon,Amazon Web Services Invoice|Amazon CloudFront\\nDigital Ocean,DigitalOcean|DOInvoice\\nAcme,ACME Inc.|1540 Long Street, Jacksonville, 32099\",\n    \"caseSensitive\": \"true\",\n    \"async\": false,\n    \"encrypt\": \"false\",\n    \"inline\": \"true\",\n    \"password\": \"\",\n    \"profiles\": \"\"\n} ");
		Request request = new Request.Builder()
			.url("http://localhost:80/pdf/classifier")
			.method("POST", body)
			.addHeader("Content-Type", "application/json")
			.build();
		Response response = client.newCall(request).execute();
		System.out.println(response.body().string());
	}
}

