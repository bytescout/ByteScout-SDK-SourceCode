*Access*

Access to API requires api key to be sent as x-api-key in the header.

If responses says "message":"Forbidden" then it means your api key expired. Contact SUPPORT@BYTESCOUT.COM for assistance

Free Trial Sign Up (no credit card required) is here

Workflow

Cloud API works with URLs to files. If you have a file to process then you need to upload it first as temporary file (see below)

You may provide your own URL or upload your local file as the temporary file to Cloud API (see below)

Temporary uploaded files are securily stored for 24 hours only and removed automatically

1. Convert URL to PDF

cURL

`curl -H "x-api-key: INSERT-YOUR-API-KEY-HERE" "https://bytescout.io/v1/pdf/convert/from/url?url=wikipedia.com"`

JQuery:

```
<input type="text" id="inputUrl" placeholder='http://wikipedia.com' autofocus>

<button id='button-main'>Proceed</button>
<div id='result'></div>
								  
<script>

$( "#button-main" ).click(function() {
var apiKey = 'INSERT-YOUR-API-KEY-HERE';
url = $('#inputUrl').val();
var apiEndpoint = "https://bytescout.io/v1/pdf/convert/from/url?url=" + url;
			
$.ajax({
	url: apiEndpoint,
	type: "POST",
	contentType: "json",
	headers: {'x-api-key': apiKey}, // setting your api key
	success: function (result) {
		//console.log(result); 
		// save link to output
		$('#output').text(result['url']);
	},
	error: function (result) {
		//console.log(result); 		
	    $('#output').text(result);
	}
  });
});		
</script>
 ```
 

2. Upload local file as the temporary file so may use it with API:


2.a. get the presignedUrl to upload file to (the url is valid for 15 minutes) and the url to the uploaded file:

The presigned url is the special temporary url that you may post your file to. Then you may use the uploaded file with Cloud API 

cURL:

`curl -H "x-api-key: INSERT-YOUR-API-KEY-HERE" "https://bytescout.io/v1/file/upload/get-presigned-url"`

Output:

```
{
  "error":false,
  "status":200,
  "name":null,
  "url":"unique-link-to-download-your-file",
  "presignedUrl":"unique-link-to-upload-your-file"
}  
```

2.b. upload the local file :

`curl -v -T "local-file.pdf" "unique-link-to-upload-your-file"`

Output:
```
...
< HTTP/1.1 200 OK
```

Now you may access your file using `unique-link-to-download-your-file`

HTML and JQuery: upload file and get url:

```
<form id="MyForm" method="POST" enctype="multipart/form-data" >
    <input id="MyFile" name="file" type="file"/> 
    <button id="MyButton" type="submit">Send File</button>
</form>

<script>
// set up the handled to be executed on the form submit
$(function() {
  $('#MyForm').on('submit', uploadTempFile); // set event for 'submit' event
});  

function uploadTempFile(e) {
    e.preventDefault();

    // store bytescout cloud api key into variable 
    
    var apiKey = "<strong><INSERT-YOUR-API-KEY-HERE</strong>";
    
    // 1. retrieve the presigned url to upload file
    $.ajax({
      type: 'GET',
      headers: {'x-api-key': apiKey}, // setting your api key
      url: "https://bytescout.io/v1/file/upload/get-presigned-url",
    })
    .success(function(result) {
      
      // now we have: presignedUrl in result['presignedUrl']
      // and the url for future uploaded file in result['url']
      // alert(' we got the url to upload file ' + result['presignedUrl']);
        
      // 2. get the local file from the html form
      var fFile = $('#MyFile').get()[0].files[0];
      
      // 3. finally upload the local file to cloud api
      $.ajax({
        type: 'PUT',
        // set the presigned url we are sending local file to
        url: result['presignedUrl']
        // content type to upload file
        contentType: 'binary/octet-stream',
        // do not touch as it is important for upload via presigned url
        processData: false,
        // the loca file to be uploaded
        data: fFile
      })
      .success(function() {
        // file was successfully uploaded
        alert('File was uploaded! And available at ' + result['url']);
        console.log('url = ' + result['url']);
        
        // now work with the uploaded file 
        // ....
        // ....
        // ....
      })
      .error(function() {
        // show alert if file was not uploaded via presigned url
        alert('File NOT uploaded via presigned url');
        console.log( arguments);
      });
    })
    .error(function() {
      alert('cant get the presigned url');
      console.log( arguments);
    });

    return false;
  });
}
</script>
```

3. Extract CSV from PDF:

`curl -H "x-api-key: INSERT-YOUR-API-KEY-HERE" "https://bytescout.io/v1/pdf/convert/to/csv?url=unique-link-to-download-your-file"`

HTML and JQuery: upload pdf and extract CSV:

```
<form id="MyForm" method="POST" enctype="multipart/form-data" >
    <input id="MyFile" name="file" type="file"/> 
    <button id="MyButton" type="submit">Send File</button>
</form>

<div id='result'></div>

<script>
// set up the handled to be executed on the form submit
$(function() {
  $('#MyForm').on('submit', uploadAndConvert); // set event for 'submit' event
});  

function uploadAndConvert(e) {
    e.preventDefault();

    // store bytescout cloud api key into variable 
    
    var apiKey = "<strong><INSERT-YOUR-API-KEY-HERE</strong>";
    
    // 1. retrieve the presigned url to upload file
    $.ajax({
      type: 'GET',
      headers: {'x-api-key': apiKey}, // setting your api key
      url: "https://bytescout.io/v1/file/upload/get-presigned-url",
    })
    .success(function(result) {
      
      // now we have: presignedUrl in result['presignedUrl']
      // and the url for future uploaded file in result['url']
      // alert(' we got the url to upload file ' + result['presignedUrl']);
        
      // 2. get the local file from the html form
      var fFile = $('#MyFile').get()[0].files[0];
      
      // 3. finally upload the local file to cloud api
      $.ajax({
        type: 'PUT',
        // set the presigned url we are sending local file to
        url: result['presignedUrl']
        // content type to upload file
        contentType: 'binary/octet-stream',
        // do not touch as it is important for upload via presigned url
        processData: false,
        // the loca file to be uploaded
        data: fFile
      })
      .success(function() {
        // file was successfully uploaded
        alert('File was uploaded! And available at ' + result['url']);
        console.log('url = ' + result['url']);
        
        // now work with the uploaded file 
          
          Convert PDF to CSV        
          var apiKey = "<strong><INSERT-YOUR-API-KEY-HERE</strong>";
          
          var pages = '0'; // set pages to convert

          url = result['url'];
          var apiEndpoint = "https://bytescout.io/v1/pdf/convert/to/csv?url=" + url;
          			
          $.ajax({
          	url: apiEndpoint,
          	type: "POST",
          	contentType: "json",
          	headers: {'x-api-key': apiKey}, // setting your api key
          	success: function (result) {
          		//console.log(result); 
          		// save link to output
          		$('#output').text(result['url']);
          	},
          	error: function (result) {
          		//console.log(result); 		
          	    $('#output').text(result);
          	}
            });
          });	        
      })
      .error(function() {
        // show alert if file was not uploaded via presigned url
        alert('File NOT uploaded via presigned url');
        console.log( arguments);
      });
    })
    .error(function() {
      alert('cant get the presigned url');
      console.log( arguments);
    });

    return false;
  });
}
</script>
```

4. PDF to PNG:

`curl -H "x-api-key: INSERT-YOUR-API-KEY-HERE" "https://bytescout.io/v1/pdf/convert/to/png?url=unique-link-to-download-your-file"`

HTML and JQuery: upload pdf and convert to PNG:

```
<form id="MyForm" method="POST" enctype="multipart/form-data" >
    <input id="MyFile" name="file" type="file"/> 
    <button id="MyButton" type="submit">Send File</button>
</form>

<div id='result'></div>

<script>
// set up the handled to be executed on the form submit
$(function() {
  $('#MyForm').on('submit', uploadAndConvert); // set event for 'submit' event
});  

function uploadAndConvert(e) {
    e.preventDefault();

    // store bytescout cloud api key into variable 
    
    var apiKey = "<strong><INSERT-YOUR-API-KEY-HERE</strong>";
    
    // 1. retrieve the presigned url to upload file
    $.ajax({
      type: 'GET',
      headers: {'x-api-key': apiKey}, // setting your api key
      url: "https://bytescout.io/v1/file/upload/get-presigned-url",
    })
    .success(function(result) {
      
      // now we have: presignedUrl in result['presignedUrl']
      // and the url for future uploaded file in result['url']
      // alert(' we got the url to upload file ' + result['presignedUrl']);
        
      // 2. get the local file from the html form
      var fFile = $('#MyFile').get()[0].files[0];
      
      // 3. finally upload the local file to cloud api
      $.ajax({
        type: 'PUT',
        // set the presigned url we are sending local file to
        url: result['presignedUrl']
        // content type to upload file
        contentType: 'binary/octet-stream',
        // do not touch as it is important for upload via presigned url
        processData: false,
        // the loca file to be uploaded
        data: fFile
      })
      .success(function() {
        // file was successfully uploaded
        alert('File was uploaded! And available at ' + result['url']);
        console.log('url = ' + result['url']);
        
        // now work with the uploaded file 
          
          Convert PDF to PNG        
          var apiKey = "<strong><INSERT-YOUR-API-KEY-HERE</strong>";
          
          var pages = '0'; // set pages to convert

          url = result['url'];
          var apiEndpoint = "https://bytescout.io/v1/pdf/convert/to/png?url=" + url;
          			
          $.ajax({
          	url: apiEndpoint,
          	type: "POST",
          	contentType: "json",
          	headers: {'x-api-key': apiKey}, // setting your api key
          	success: function (result) {
          		//console.log(result); 
          		// save link to output
          		$('#output').text(result['url']);
          	},
          	error: function (result) {
          		//console.log(result); 		
          	    $('#output').text(result);
          	}
            });
          });	        
      })
      .error(function() {
        // show alert if file was not uploaded via presigned url
        alert('File NOT uploaded via presigned url');
        console.log( arguments);
      });
    })
    .error(function() {
      alert('cant get the presigned url');
      console.log( arguments);
    });

    return false;
  });
}
</script>
```

5. PDF to JPG:

`curl -H "x-api-key: INSERT-YOUR-API-KEY-HERE" "https://bytescout.io/v1/pdf/convert/to/jpg?url=unique-link-to-download-your-file"`

6. PDF split (into multiple documents with selected pages):

pages param tells which page or page ranges to split 

`curl -H "x-api-key: "<strong><INSERT-YOUR-API-KEY-HERE</strong>"" 'https://bytescout.io/v1/pdf/split?url=unique-link-to-download-your-file&pages=1,2,3-5'`

Output:

```
{
  "error":false,
  "status":200,
  "urls":[
    "https://FIRST-FILE-URL",
    "https://SECOND-FILE-URL",
    "https://THIRD-FILE-URL"
    ]
}
```
