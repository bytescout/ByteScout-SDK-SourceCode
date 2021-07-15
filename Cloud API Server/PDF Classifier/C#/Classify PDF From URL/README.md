## PDF classifier in C# and ByteScout Cloud API Server ByteScout Cloud API Server: the ready to use Web API Server that can be deployed in less than 30 minutes into your own in-house server or into private cloud server. Can store data on in-house local server based storage or in Amazon AWS S3 bucket. Processing data solely on the server using buil-in ByteScout powered engine, no cloud services are used to process your data!.

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

##### **program.cs:**
    
```
using System;
using RestSharp;
namespace HelloWorldApplication {
	class HelloWorld {
		static void Main(string[] args) {
			var client = new RestClient("http://localhost:80/pdf/classifier");
			client.Timeout = -1;
			var request = new RestRequest(Method.POST);
			request.AddHeader("Content-Type", "application/json");
			var body = @"{" + "\n" +
			@"    ""url"": ""https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/document-parser/sample-invoice.pdf""," + "\n" +
			@"    ""rulescsv"": ""Amazon,Amazon Web Services Invoice|Amazon CloudFront\nDigital Ocean,DigitalOcean|DOInvoice\nAcme,ACME Inc.|1540 Long Street, Jacksonville, 32099""," + "\n" +
			@"    ""caseSensitive"": ""true""," + "\n" +
			@"    ""async"": false," + "\n" +
			@"    ""encrypt"": ""false""," + "\n" +
			@"    ""inline"": ""true""," + "\n" +
			@"    ""password"": """"," + "\n" +
			@"    ""profiles"": """"" + "\n" +
			@"} ";
			request.AddParameter("application/json", body,  ParameterType.RequestBody);
			IRestResponse response = client.Execute(request);
			Console.WriteLine(response.Content);
		}
	}
}


```

<!-- code block end -->