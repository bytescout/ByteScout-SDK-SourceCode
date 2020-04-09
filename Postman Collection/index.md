
# PDF.co API v.1

- [PDF.co Web API (Application Programming Interface)](#pdfco-web-api-application-programming-interface)
  - [Key Benefits](#key-benefits)
  - [How to use API with URL as input](#how-to-use-api-with-url-as-input)
  - [How to use API with file as input](#how-to-use-api-with-file-as-input)
  - [How to use API with large files and with 100+ pages documents](#how-to-use-api-with-large-files-and-with-100-pages-documents)
  - [Source Code Samples](#source-code-samples)
  - [Known Issues](#known-issues)
  - [Contact Customer Support for API users](#contact-customer-support-for-api-users)
 
## Postman Collection

Postman collection is [here](https://documenter.getpostman.com/view/10596283/SzKbNwAn?version=latest)
 

##  Key Benefits

- **Security**: API runs on the secure Amazon AWS infrastructure. All data transfers are encrypted by SSL/TLS encryption.
- **Asynchronous mode** is supported so you can process large files and documents with hundreds of pages in the cloud.
- **Credits** based system. For evert page/image processed *credits* are reduced on your account. You get monthly amount of credits based on your subscription, also you may always purchase additional *credits*.
For example, processing/generating document with 2 pages requires 2 credits. Separate methods like uploading, background job check require 1 credit. You may always see how may credits are left using `remainingCredits` property in the returned result.

- **Zapier plugin** [is available](https://pdf.co/zapier/)
- **Offline** SDKs and on-premise API server [are available too](https://pdf.co/offline-download)
- Includes **built-in OCR** and **Image Recognition**

## How to use API with URL as input

- Generate a *temporary* public link to your document or file on your side
- Call any API method with `url` param set to your file's url
- It will return JSON with a temporary URL to new generated file. Some endpoints like `pdf/to/text` have `inline` property to return generated content inside `body` property of the response.

## How to use API with file as input

- Upload your file using `file` input param available in many API methods
- API methods will return JSON with a temporary URL to new generated file. Some endpoints like `pdf/to/text` have `inline` property to return generated content inside `body` property of the response.

## How to use API with large files and with 100+ pages documents

We've designed this mode to be scalable and support large files and documents with hundreds of pages.

- Default timeout for all API calls is around `25` seconds. If your call to API (for example, if you run text recognition on 100+ pages scanned document) takes more time then you should use *async* mode.
- Enable `async` mode by setting `async` input parameter to `true`. This will tell API method to run processing and background and method will immediately return unique id of new background job (as `jobId` property).
- Check status of background job status using `/job/check` and wait until it returns `status` as `success`

**Asynchronious mode and background jobs: step by step**

1. Request a temporary URL for upload using `/file/upload/get-presigned-url`
2. Upload your file using `POST` to this temporary URL using any 3rd party way or use `/file/upload` API method
3. Call API method with this temporary URL as input in `url` param. Set `async` param to `true` so API method will return immediately and will send you output URL (or set of URLs) along with `jobId` immediately. `jobId` is the unique identificator of the background job that will be running on the server.
4. Now check `status` of this background job using `/job/check` API method with `jobId` param. It will return execution `status`.
5. Once `/job/check` returns `status` param as `success` you may use the previously generated output URL (or set of URLs) to download generated data.

## Source Code Samples

We have hundreds of ready to copy Explore [Source Code Samples on Github](https://github.com/bytescout/pdf-co-api-samples) available for Javascript, Node.js, PHP, Java, C# and Visual Basic NET.

## Known Issues

- `SSL certificate error: unable to get local issuer certificate` in PHP: check [this solution on Stackoverflow](https://stackoverflow.com/a/32095378/712093)

## Contact Customer Support for API users

Our **dedicated**  API users support team is happy to help with integrations and with proof of concept projects! Please [click here to send request](https://support.bytescout.com/hc/en-us/requests/new?subject=PDF.co%20API) (recommended) or send email to [pdfco@bytescout.zendesk.com](mailto:pdfco@bytescout.zendesk.com?subject=PDF.co%20API%20support)


## Indices

* [Delete Files](#delete-files)

  * [/file/delete](#1-filedelete)
  * [/file/delete](#2-filedelete)

* [Electronic Signatures and Filling PDF Forms/Add Electronic Signatures To PDF, PNG, JPG or TIFF scan](#electronic-signatures-and-filling-pdf-formsadd-electronic-signatures-to-pdf,-png,-jpg-or-tiff-scan)

  * [/pdf/sign](#1-pdfsign)
  * [/pdf/sign](#2-pdfsign)
  * [/pdf/sign](#3-pdfsign)

* [Electronic Signatures and Filling PDF Forms/Manage E-Signed and Draft Documents](#electronic-signatures-and-filling-pdf-formsmanage-e-signed-and-draft-documents)

  * [/documents](#1-documents)
  * [/documents/:id](#2-documents:id)

* [Electronic Signatures and Filling PDF Forms/Manage Fillable Templates](#electronic-signatures-and-filling-pdf-formsmanage-fillable-templates)

  * [/templates](#1-templates)
  * [/templates/:id](#2-templates:id)

* [Electronic Signatures and Filling PDF Forms/Send E-Signature Request](#electronic-signatures-and-filling-pdf-formssend-e-signature-request)

  * [/templates/:id/use](#1-templates:iduse)

* [Extract Complex Data from PDF](#extract-complex-data-from-pdf)

  * [/pdf/documentparser](#1-pdfdocumentparser)
  * [/pdf/documentparser/templates](#2-pdfdocumentparsertemplates)
  * [/pdf/documentparser/templates/:id](#3-pdfdocumentparsertemplates:id)
  * [/pdf/documentparser/results](#4-pdfdocumentparserresults)
  * [/pdf/documentparser/results](#5-pdfdocumentparserresults)
  * [/pdf/documentparser/results/:id](#6-pdfdocumentparserresults:id)
  * [/pdf/documentparser/results/:id/file/url](#7-pdfdocumentparserresults:idfileurl)

* [Extract Data From Spreadsheets/XLS / XLSX to CSV](#extract-data-from-spreadsheetsxls--xlsx-to-csv)

  * [/xls/convert/to/csv](#1-xlsconverttocsv)
  * [/xls/convert/to/csv](#2-xlsconverttocsv)

* [Extract Data From Spreadsheets/XLS/XLSX to HTML](#extract-data-from-spreadsheetsxlsxlsx-to-html)

  * [/xls/convert/to/html](#1-xlsconverttohtml)
  * [/xls/convert/to/html](#2-xlsconverttohtml)

* [Extract Data From Spreadsheets/XLS/XLSX to JSON](#extract-data-from-spreadsheetsxlsxlsx-to-json)

  * [/xls/convert/to/json](#1-xlsconverttojson)
  * [/xls/convert/to/json](#2-xlsconverttojson)

* [Extract Raw Data From PDF/PDF To CSV](#extract-raw-data-from-pdfpdf-to-csv)

  * [/pdf/convert/to/csv](#1-pdfconverttocsv)
  * [/pdf/convert/to/csv](#2-pdfconverttocsv)

* [Extract Raw Data From PDF/PDF To JSON](#extract-raw-data-from-pdfpdf-to-json)

  * [/pdf/convert/to/json](#1-pdfconverttojson)
  * [/pdf/convert/to/json](#2-pdfconverttojson)

* [Extract Raw Data From PDF/PDF To TEXT](#extract-raw-data-from-pdfpdf-to-text)

  * [/pdf/convert/to/text](#1-pdfconverttotext)
  * [/pdf/convert/to/text](#2-pdfconverttotext)

* [Extract Raw Data From PDF/PDF To XLS](#extract-raw-data-from-pdfpdf-to-xls)

  * [/pdf/convert/to/xls](#1-pdfconverttoxls)
  * [/pdf/convert/to/xls](#2-pdfconverttoxls)

* [Extract Raw Data From PDF/PDF To XLSX](#extract-raw-data-from-pdfpdf-to-xlsx)

  * [/pdf/convert/to/xls](#1-pdfconverttoxls-1)
  * [/pdf/convert/to/xls](#2-pdfconverttoxls-1)

* [Extract Raw Data From PDF/PDF To XML](#extract-raw-data-from-pdfpdf-to-xml)

  * [/pdf/convert/to/xml](#1-pdfconverttoxml)
  * [/pdf/convert/to/xml](#2-pdfconverttoxml)

* [Extract Raw Data From PDF/PDF to HTML](#extract-raw-data-from-pdfpdf-to-html)

  * [/pdf/convert/to/html](#1-pdfconverttohtml)
  * [/pdf/convert/to/html](#2-pdfconverttohtml)

* [Generate Barcodes](#generate-barcodes)

  * [/barcode/generate](#1-barcodegenerate)
  * [/barcode/generate](#2-barcodegenerate)

* [Generate PDF documents/PDF from CSV](#generate-pdf-documentspdf-from-csv)

  * [/pdf/convert/from/csv](#1-pdfconvertfromcsv)
  * [/pdf/convert/from/csv](#2-pdfconvertfromcsv)

* [Generate PDF documents/PDF from Doc, DocX, RTF, TXT, XPS](#generate-pdf-documentspdf-from-doc,-docx,-rtf,-txt,-xps)

  * [/pdf/convert/from/doc](#1-pdfconvertfromdoc)
  * [/pdf/convert/from/doc](#2-pdfconvertfromdoc)

* [Generate PDF documents/PDF from HTML](#generate-pdf-documentspdf-from-html)

  * [/pdf/convert/from/html](#1-pdfconvertfromhtml)
  * [/pdf/convert/from/html](#2-pdfconvertfromhtml)

* [Generate PDF documents/PDF from Images](#generate-pdf-documentspdf-from-images)

  * [/pdf/convert/from/image](#1-pdfconvertfromimage)
  * [/pdf/convert/from/image](#2-pdfconvertfromimage)

* [Generate PDF documents/PDF from Website URL](#generate-pdf-documentspdf-from-website-url)

  * [/pdf/convert/from/url](#1-pdfconvertfromurl)

* [Generate PDF documents/PDF from XLS or XLSX](#generate-pdf-documentspdf-from-xls-or-xlsx)

  * [/xls/convert/to/pdf](#1-xlsconverttopdf)
  * [/xls/convert/to/pdf](#2-xlsconverttopdf)

* [Manage Background Jobs](#manage-background-jobs)

  * [/job/check](#1-jobcheck)
  * [/job/check](#2-jobcheck)

* [PDF Tools/Add Text and Images to PDF](#pdf-toolsadd-text-and-images-to-pdf)

  * [/pdf/edit/add](#1-pdfeditadd)
  * [/pdf/edit/add](#2-pdfeditadd)

* [PDF Tools/Delete Text from PDF](#pdf-toolsdelete-text-from-pdf)

  * [/pdf/edit/delete-text (multiple replacements)](#1-pdfeditdelete-text-(multiple-replacements))
  * [/pdf/edit/delete-text (single replacement)](#2-pdfeditdelete-text-(single-replacement))
  * [/pdf/edit/delete-text](#3-pdfeditdelete-text)

* [PDF Tools/Make Text Searchable PDF](#pdf-toolsmake-text-searchable-pdf)

  * [/pdf/makesearchable](#1-pdfmakesearchable)
  * [/pdf/makesearchable](#2-pdfmakesearchable)

* [PDF Tools/Merge and Split PDF/Delete Pages](#pdf-toolsmerge-and-split-pdfdelete-pages)

  * [/pdf/edit/delete-pages](#1-pdfeditdelete-pages)
  * [/pdf/edit/delete-pages](#2-pdfeditdelete-pages)

* [PDF Tools/Merge and Split PDF/Merge](#pdf-toolsmerge-and-split-pdfmerge)

  * [/pdf/merge](#1-pdfmerge)
  * [/pdf/merge](#2-pdfmerge)

* [PDF Tools/Merge and Split PDF/Split](#pdf-toolsmerge-and-split-pdfsplit)

  * [/pdf/split](#1-pdfsplit)
  * [/pdf/split](#2-pdfsplit)

* [PDF Tools/Optimize PDF](#pdf-toolsoptimize-pdf)

  * [/pdf/optimize](#1-pdfoptimize)
  * [/pdf/optimize](#2-pdfoptimize)

* [PDF Tools/Search and Replace Text](#pdf-toolssearch-and-replace-text)

  * [/pdf/edit/replace-text](#1-pdfeditreplace-text)
  * [/pdf/edit/replace-text (single replacement)](#2-pdfeditreplace-text-(single-replacement))
  * [/pdf/edit/replace-text (mutliple replacements)](#3-pdfeditreplace-text-(mutliple-replacements))

* [PDF Tools/Search and Replace Text with Image](#pdf-toolssearch-and-replace-text-with-image)

  * [/pdf/edit/replace-text-with-image](#1-pdfeditreplace-text-with-image)
  * [/pdf/edit/replace-text-with-image](#2-pdfeditreplace-text-with-image)

* [Read Barcodes](#read-barcodes)

  * [/barcode/read/from/url](#1-barcodereadfromurl)
  * [/barcode/read/from/url](#2-barcodereadfromurl)

* [Read PDF Information](#read-pdf-information)

  * [/pdf/info](#1-pdfinfo)
  * [/pdf/info](#2-pdfinfo)

* [Render PDF to Image/PDF to JPG](#render-pdf-to-imagepdf-to-jpg)

  * [/pdf/convert/to/jpg](#1-pdfconverttojpg)
  * [/pdf/convert/to/jpg](#2-pdfconverttojpg)

* [Render PDF to Image/PDF to PNG](#render-pdf-to-imagepdf-to-png)

  * [/pdf/convert/to/png](#1-pdfconverttopng)
  * [/pdf/convert/to/png](#2-pdfconverttopng)

* [Render PDF to Image/PDF to TIFF](#render-pdf-to-imagepdf-to-tiff)

  * [/pdf/convert/to/tiff](#1-pdfconverttotiff)
  * [/pdf/convert/to/tiff](#2-pdfconverttotiff)

* [Render PDF to Image/URL as JPG](#render-pdf-to-imageurl-as-jpg)

  * [/url/convert/to/jpg](#1-urlconverttojpg)
  * [/url/convert/to/jpg](#2-urlconverttojpg)

* [Render PDF to Image/URL as PNG](#render-pdf-to-imageurl-as-png)

  * [/url/convert/to/png](#1-urlconverttopng)
  * [/url/convert/to/png](#2-urlconverttopng)

* [Search inside PDF or Image](#search-inside-pdf-or-image)

  * [/pdf/find](#1-pdffind)
  * [/pdf/find](#2-pdffind)

* [Upload Files/Calculate Hash](#upload-filescalculate-hash)

  * [/file/hash](#1-filehash)
  * [/file/hash](#2-filehash)

* [Upload Files/From Base64](#upload-filesfrom-base64)

  * [/file/upload/base64](#1-fileuploadbase64)

* [Upload Files/From Local File](#upload-filesfrom-local-file)

  * [/file/upload/url](#1-fileuploadurl)

* [Upload Files/From URL](#upload-filesfrom-url)

  * [/file/upload/url](#1-fileuploadurl-1)
  * [/file/upload/url](#2-fileuploadurl)

* [Upload Files/Presigned URL (recommended)](#upload-filespresigned-url-(recommended))

  * [/file/upload/get-presigned-url](#1-fileuploadget-presigned-url)


--------


## Delete Files
**Description:** Calculate and return MD5 hash of file by url. Commonly used to control if source document has been changed or not because every little change will cause hash string to differ as well. `GET` or `POST` request.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|

**Example**

Sample Request:

! Don't forget to set `x-api-key` url param or http header param (preferred) to API key, get yours [here](https://app.pdf.co/signup)

```
POST
{
	"file": "https://pdf-temp-files.s3.amazonaws.com/3d5df1d2b0464360ad5df2f13426efa2/sample.pdf"
}
```



### 1. /file/delete



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/file/delete
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| file | https://pdf-temp-files.s3.amazonaws.com/b5c1e67d98ab438292ff1fea0c7cdc9d/sample.pdf | required. URL of the file to delete. Must be a String. |



***Responses:***


Status: /file/delete | Code: 200



```js
{
  "error": false,
  "status": 200,
  "remainingCredits": 9999986
}
```



### 2. /file/delete



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/file/delete
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| file | https://pdf-temp-files.s3.amazonaws.com/cc380d488969497e80bd7e18ce5b5a3c/sample.pdf | required. URL of the file to delete. Must be a String. |



***Responses:***


Status: /file/delete | Code: 404



```js
{
  "error": false,
  "status": 200,
  "remainingCredits": 9999986
}
```



## Electronic Signatures and Filling PDF Forms/Add Electronic Signatures To PDF, PNG, JPG or TIFF scan



### 1. /pdf/sign


**Example 1: adding e-signature, certificate page and audit log**

! Don't forget to set `x-api-key` url param or http header param (preferred) to API key, get yours [here](https://app.pdf.co/signup)

**POST**

```
{
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/NDATemplate.pdf",
    "name": "Agreement",
    "async": false,
    "encrypt": false,
    "images": [
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/signatureSample.png",
            "x": 15,
            "y": 15,
            "width": 200,
            "height": 100,
            "pages": "0,1",
            "transparent": true
        }
    ],
    "certificate": {
        "title": "E-Signature Certificate",
        "documentReference": "1234567890",
        "parties": [
            {
                "partyId": "1234567890party1",
                "name": "John Smith",
                "email": "john@example.com",
                "ipAddress": "127.0.0.1",
                "timestamp": 1575629525,
                "role": "owner"
            },
            {
                "partyId": "1234567890party2",
                "name": "Dave Doe",
                "email": "dave@example.com",
                "ipAddress": "127.0.0.2",
                "timestamp": 1575629522,
                "role": "party"
            }

        ],
        "audit": [
            {
                "timestamp": 1575557523,
                "message": "Agreement was created"
            },
            {
                "timestamp": 1575629525,
                "message": "Agreement was signed by John Smith (john@example.com)\nIP: 127.0.0.1"
            },
            {
                "timestamp": 1575629526,
                "message": "Agreement was signed by Dave Doe (dave@example.com)\nIP: 127.0.0.2"
            },
            {
                "timestamp": 1575629527,
                "message": "Agreement was finalized"
            }
        ],
        "footer": "This document was e-signed via PDF.co Web API"
    }
}
```


***Endpoint:***

```bash
Method: POST
Type: RAW
URL: https://api.pdf.co/v1/pdf/sign
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

```js        
{
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/NDATemplate.pdf",
    "name": "Agreement",
    "async": false,
    "encrypt": false,
    "images": [
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/signatureSample.png",
            "x": 15,
            "y": 15,
            "width": 200,
            "height": 100,
            "pages": "0,1",
            "transparent": true
        }
    ],
    "certificate": {
        "title": "E-Signature Certificate",
        "documentReference": "1234567890",
        "parties": [
            {
                "partyId": "1234567890party1",
                "name": "John Smith",
                "email": "john@example.com",
                "ipAddress": "127.0.0.1",
                "timestamp": 1575629525,
                "role": "owner"
            },
            {
                "partyId": "1234567890party2",
                "name": "Dave Doe",
                "email": "dave@example.com",
                "ipAddress": "127.0.0.2",
                "timestamp": 1575629522,
                "role": "party"
            }

        ],
        "audit": [
            {
                "timestamp": 1575557523,
                "message": "Agreement was created"
            },
            {
                "timestamp": 1575629525,
                "message": "Agreement was signed by John Smith (john@example.com)\nIP: 127.0.0.1"
            },
            {
                "timestamp": 1575629526,
                "message": "Agreement was signed by Dave Doe (dave@example.com)\nIP: 127.0.0.2"
            },
            {
                "timestamp": 1575629527,
                "message": "Agreement was finalized"
            }
        ],
        "footer": "This document was e-signed via PDF.co Web API"
    }
}
```



***Responses:***


Status: /pdf/sign | Code: 200



```js
{
    "hash": "8f6770019b6b3369d34ac63685221cdf8a69b0a021a6cf5c18cf19009cf5595e",
    "url": "https://pdf-temp-files.s3.amazonaws.com/12104f53bc5b4c1097dfd5d7ac780507/Agreement.pdf",
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "Agreement",
    "remainingCredits": 98132
}
```



### 2. /pdf/sign


**Example 2 - adding e-signature to JPG or PNG file**

**POST**

```
{
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/NDATemplate.png",
    "name": "Agreement",
    "async": false,
    "encrypt": false,
    "images": [
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/signatureSample.png",
            "x": 15,
            "y": 15,
            "width": 200,
            "height": 100,
            "pages": "0",
            "transparent": true
        }
    ],
    "certificate": {
        "title": "E-Signature Certificate",
        "documentReference": "1234567890",
        "parties": [
            {
                "partyId": "1234567890party1",
                "name": "John Smith",
                "email": "john@example.com",
                "ipAddress": "127.0.0.1",
                "timestamp": 1575629525,
                "role": "owner"
            },
            {
                "partyId": "1234567890party2",
                "name": "Dave Doe",
                "email": "dave@example.com",
                "ipAddress": "127.0.0.2",
                "timestamp": 1575629522,
                "role": "party"
            }

        ],
        "audit": [
            {
                "timestamp": 1575557523,
                "message": "Agreement was created"
            },
            {
                "timestamp": 1575629525,
                "message": "Agreement was signed by John Smith (john@example.com)\nIP: 127.0.0.1"
            },
            {
                "timestamp": 1575629526,
                "message": "Agreement was signed by Dave Doe (dave@example.com)\nIP: 127.0.0.2"
            },
            {
                "timestamp": 1575629527,
                "message": "Agreement was finalized"
            }
        ],
        "footer": "This document was e-signed via PDF.co Web API"
    }
}
```




***Endpoint:***

```bash
Method: POST
Type: RAW
URL: https://api.pdf.co/v1/pdf/sign
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

```js        
{
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/NDATemplate.png",
    "name": "Agreement",
    "async": false,
    "encrypt": false,
    "images": [
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/signatureSample.png",
            "x": 15,
            "y": 15,
            "width": 200,
            "height": 100,
            "pages": "0",
            "transparent": true
        }
    ],
    "certificate": {
        "title": "E-Signature Certificate",
        "documentReference": "1234567890",
        "parties": [
            {
                "partyId": "1234567890party1",
                "name": "John Smith",
                "email": "john@example.com",
                "ipAddress": "127.0.0.1",
                "timestamp": 1575629525,
                "role": "owner"
            },
            {
                "partyId": "1234567890party2",
                "name": "Dave Doe",
                "email": "dave@example.com",
                "ipAddress": "127.0.0.2",
                "timestamp": 1575629522,
                "role": "party"
            }

        ],
        "audit": [
            {
                "timestamp": 1575557523,
                "message": "Agreement was created"
            },
            {
                "timestamp": 1575629525,
                "message": "Agreement was signed by John Smith (john@example.com)\nIP: 127.0.0.1"
            },
            {
                "timestamp": 1575629526,
                "message": "Agreement was signed by Dave Doe (dave@example.com)\nIP: 127.0.0.2"
            },
            {
                "timestamp": 1575629527,
                "message": "Agreement was finalized"
            }
        ],
        "footer": "This document was e-signed via PDF.co Web API"
    }
}
```



***Responses:***


Status: /pdf/sign | Code: 200



```js
{
    "hash": "7ea5f31875cc1bc90333bbc36114f99aa1b8ac61b498bf11bc2c97cad984ab24",
    "url": "https://pdf-temp-files.s3.amazonaws.com/4fa1d1864dc446db84732126cb2e398e/Agreement.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "Agreement",
    "remainingCredits": 98127
}
```



### 3. /pdf/sign


**Example 3: adding e-signature and certificate to TIFF scan**

**POST**

```
{
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/NDATemplate.tiff",
    "name": "Agreement",
    "async": false,
    "encrypt": false,
    "images": [
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/signatureSample.png",
            "x": 15,
            "y": 15,
            "width": 200,
            "height": 100,
            "pages": "0",
            "transparent": true
        }
    ],
    "certificate": {
        "title": "E-Signature Certificate",
        "documentReference": "1234567890",
        "parties": [
            {
                "partyId": "1234567890party1",
                "name": "John Smith",
                "email": "john@example.com",
                "ipAddress": "127.0.0.1",
                "timestamp": 1575629525,
                "role": "owner"
            },
            {
                "partyId": "1234567890party2",
                "name": "Dave Doe",
                "email": "dave@example.com",
                "ipAddress": "127.0.0.2",
                "timestamp": 1575629522,
                "role": "party"
            }

        ],
        "audit": [
            {
                "timestamp": 1575557523,
                "message": "Agreement was created"
            },
            {
                "timestamp": 1575629525,
                "message": "Agreement was signed by John Smith (john@example.com)\nIP: 127.0.0.1"
            },
            {
                "timestamp": 1575629526,
                "message": "Agreement was signed by Dave Doe (dave@example.com)\nIP: 127.0.0.2"
            },
            {
                "timestamp": 1575629527,
                "message": "Agreement was finalized"
            }
        ],
        "footer": "This document was e-signed via PDF.co Web API"
    }
}
```



***Endpoint:***

```bash
Method: POST
Type: RAW
URL: https://api.pdf.co/v1/pdf/sign
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

```js        
{
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/NDATemplate.tiff",
    "name": "Agreement",
    "async": false,
    "encrypt": false,
    "images": [
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-sign/signatureSample.png",
            "x": 15,
            "y": 15,
            "width": 200,
            "height": 100,
            "pages": "0",
            "transparent": true
        }
    ],
    "certificate": {
        "title": "E-Signature Certificate",
        "documentReference": "1234567890",
        "parties": [
            {
                "partyId": "1234567890party1",
                "name": "John Smith",
                "email": "john@example.com",
                "ipAddress": "127.0.0.1",
                "timestamp": 1575629525,
                "role": "owner"
            },
            {
                "partyId": "1234567890party2",
                "name": "Dave Doe",
                "email": "dave@example.com",
                "ipAddress": "127.0.0.2",
                "timestamp": 1575629522,
                "role": "party"
            }

        ],
        "audit": [
            {
                "timestamp": 1575557523,
                "message": "Agreement was created"
            },
            {
                "timestamp": 1575629525,
                "message": "Agreement was signed by John Smith (john@example.com)\nIP: 127.0.0.1"
            },
            {
                "timestamp": 1575629526,
                "message": "Agreement was signed by Dave Doe (dave@example.com)\nIP: 127.0.0.2"
            },
            {
                "timestamp": 1575629527,
                "message": "Agreement was finalized"
            }
        ],
        "footer": "This document was e-signed via PDF.co Web API"
    }
}
```



***Responses:***


Status: /pdf/sign | Code: 200



```js
{
    "hash": "e2847f25ac8c44b09366daba631e28d426a34b92f6b939972609586b3b1b6bfd",
    "url": "https://pdf-temp-files.s3.amazonaws.com/6bbba061709c431297ea77ea51a29e67/Agreement.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "Agreement",
    "remainingCredits": 98122
}
```



## Electronic Signatures and Filling PDF Forms/Manage E-Signed and Draft Documents



### 1. /documents


**Description:** returns list of all current user's documents data. You may check *status* of each document and get additional information. Please use `GET` request.

**Status Errors**

| Code	| Description|
|-- |--
|`401`|	unauthorized|



***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/documents
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| x-api-key | {{x-api-key}} |  |



### 2. /documents/:id


**Description:** Returns detailed information about document by document's id: meta information, information about parties, document status, audit log. Please use `GET` request.

**Status Errors**

| Code	| Description|
|-- |--
|`401`|	unauthorized|
|`404`|	record not found|



***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/documents/b9d00ce740789717b3fa588684234d0e4ce8c667ad813945d9
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| x-api-key | {{x-api-key}} |  |



## Electronic Signatures and Filling PDF Forms/Manage Fillable Templates



### 1. /templates


**Description:** Returns list of existing document templates list for the current user. You should use PDF.co web-interface for end-users to create, edit templates, assign fields and manage list of parties for the document. Please use `GET` request.

**Status Errors**

| Code	| Description|
|-- |--
|`401`|	unauthorized|



***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/templates
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| x-api-key | {{x-api-key}} |  |



***Responses:***


Status: /templates | Code: 200



```js
[
  {
    "id": "c57f79aa",
    "title": "IT Services Agreement - for our group",
    "description": "IT Services Agreement - template for our group",
    "mode": "unlisted",
    "created_at": "2017-12-02T15:35:59.565Z",
    "updated_at": "2017-12-02T15:36:52.643Z",
    "url": "http://pdf.co/t/information-tec-c57f79aa",
    "url_public": "http://pdf.co/t/information-tec-c57f79aa?secret_token=e12d74d076694e6b97c1"
  },
  {
    "id": "cd70e9e0",
    "title": "Information Technology Professional Services Agreement",
    "description": "Information Technology Professional Services Agreement template",
    "mode": "private",
    "created_at": "2017-12-02T15:29:09.362Z",
    "updated_at": "2017-12-02T15:34:34.934Z",
    "url": "http://pdf.co/t/information-tec-cd70e9e0",
    "url_public": null
  },
  {
    "id": "17a998ec",
    "title": "Non-Disclosure Agreement Template",
    "description": "Non-Disclosure Agreement template",
    "mode": "unlisted_notify",
    "created_at": "2017-11-24T13:05:58.697Z",
    "updated_at": "2017-12-02T15:33:28.720Z",
    "url": "http://pdf.co/t/contract-nda-17a998ec",
    "url_public": "http://pdf.co/t/contract-nda-17a998ec?secret_token=6c93ce3c39dfefecc82e"
  }
]
```



### 2. /templates/:id


**Description:** Document template information. `GET` request.

**Status Errors**

| Code	| Description|
|-- |--
|`401`|	unauthorized|
|`404`|	record not found|



***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/templates/cd70e9e0
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| x-api-key | {{x-api-key}} |  |



***Responses:***


Status: /templates/:id | Code: 404



```js
{
    "status": "error",
    "errorCode": 404,
    "error": true,
    "message": "record not found. Please check API documentation at https://apidocs.pdf.co/"
}
```



Status: /templates/:id | Code: 404



```js
{
  "id": "cd70e9e0",
  "title": "Information Technology Professional Services Agreement",
  "mode": "private",
  "fields": [
    {
      "role": "Client",
      "height": 63.33262935586062,
      "width": 130.5427666314678,
      "x": 46.853220696937704,
      "y": 725.4171066525871,
      "page": 1,
      "type": "signature",
      "name": "s1_s1",
      "transparent": true,
      "party_name": null,
      "party_email": null
    },
    {
      "role": "Contractor",
      "height": 63.33262935586062,
      "width": 130.5427666314678,
      "x": 416.5089757127772,
      "y": 717.9852164730729,
      "page": 1,
      "type": "signature",
      "name": "s2_s1",
      "transparent": true,
      "party_name": null,
      "party_email": null
    },
    {
      "role": "Client",
      "height": 21.972544878563887,
      "width": 344.4519535374868,
      "x": 75.28827877507919,
      "y": 179.3347412882788,
      "page": 0,
      "type": "text",
      "name": "s1_t1",
      "transparent": true,
      "party_name": null,
      "party_email": null
    },
    {
      "role": "Contractor",
      "height": 10.986272439281944,
      "width": 355.4382259767687,
      "x": 77.22703273495249,
      "y": 202.92291446673707,
      "page": 0,
      "type": "text",
      "name": "s2_t1",
      "transparent": true,
      "party_name": null,
      "party_email": null
    },
    {
      "role": "Client",
      "height": 10.986272439281944,
      "width": 102.75395987328406,
      "x": 342.8363252375924,
      "y": 402.2914466737065,
      "page": 0,
      "type": "date",
      "name": "s1_d1",
      "transparent": true,
      "party_name": null,
      "party_email": null
    },
    {
      "role": "Client",
      "height": 10.986272439281944,
      "width": 113.74023231256601,
      "x": 68.17951425554382,
      "y": 414.24709609292506,
      "page": 0,
      "type": "date",
      "name": "s1_d2",
      "transparent": true,
      "party_name": null,
      "party_email": null
    }
  ],
  "slug": "information-tec-cd70e9e0",
  "created_at": "2017-12-02T15:29:09.362Z",
  "updated_at": "2017-12-02T15:34:34.934Z",
  "url": "http://pdf.co/t/information-tec-cd70e9e0",
  "roles": [
    "Client",
    "Contractor"
  ],
  "url_public": null,
  "sign_by_owner": false,
  "sign_by_owner_as": ""
}
```



## Electronic Signatures and Filling PDF Forms/Send E-Signature Request



### 1. /templates/:id/use


**Description:** This method creates new document from existing template and sends new e-signature request to fill and e-sign (if need to) new document to parties via email. Please use `GET` request.

**Status Errors**

| Code	| Description|
|-- |--
|`401`|	unauthorized|
|`404`|	record not found|



***Endpoint:***

```bash
Method: POST
Type: RAW
URL: https://api.pdf.co/v1/templates/726b835a/use
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

```js        
{
  "roles": [
    {
      "role": "Client",
      "name": "Super Company, Inc.",
      "email": "contracts@example.com"
    },
    {
      "role": "Contractor",
      "name": "Alyssa French",
      "email": "alyssa@example.com"
    }
  ],
  "fields": [
    {
      "s1_t1": "Brett Wheeler (CEO)"
    }
  ]
}
```



***Responses:***


Status: /templates/:id/use | Code: 404



```js
{
    "status": "error",
    "errorCode": 404,
    "error": true,
    "message": "record not found. Please check API documentation at https://apidocs.pdf.co/"
}
```



## Extract Complex Data from PDF
Document Parser is the powerful parser that can read multiple values from documents. 
Supports extraction by coordinates, by patterns. Supports multiple languages inside the same document. Can extract tables (including multi-page tables)



### 1. /pdf/documentparser


**Description:** Parses and gets data from documents using previously prepared custom data extraction template. With this API method you may extract data from custom areas, by search, form fields, tables, multiple pages and more!
Please use `GET` or `POST` request.

To create and prepare new document parsing template, please download and use [Document Parser Template Editor (for Windows)](https://cdn.bytescout.com/TemplateEditor.zip)

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|

**Example**

Sample PDF document with tables and multiple pages:
https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf

**SampleTemplate.yml:**

```
---
# Template that demonstrates parsing of multi-page table using only
# regular expressions for the table start, end, and rows.
# If regular expression cannot be written for every table row (for example,
# if the table contains empty cells), try the second method demonstrated
# in `MultiPageTable-template2.yml` template.
templateVersion: 3
templatePriority: 0
sourceId: Multipage Table Test
detectionRules:
  keywords:
  - Sample document with multi-page table
fields:
  total:
    type: regex
    expression: TOTAL {{DECIMAL}}
    dataType: decimal
tables:
- name: table1
  start:
    # regular expression to find the table start in document
    expression: Item\s+Description\s+Price\s+Qty\s+Extended Price
  end:
    # regular expression to find the table end in document
    expression: TOTAL\s+\d+\.\d\d
  row:
    # regular expression to find table rows
    expression: '^\s*(?<itemNo>\d+)\s+(?<description>.+?)\s+(?<price>\d+\.\d\d)\s+(?<qty>\d+)\s+(?<extPrice>\d+\.\d\d)'
  columns:
  - name: itemNo
    type: integer
  - name: description
    type: string
  - name: price
    type: decimal
  - name: qty
    type: integer
  - name: extPrice
    type: decimal
  multipage: true
```

NOTE: this template should be set as `template` param. Also you see [Template Creation Guide](https://apidocs.pdf.co/document-parser-template-guide) and download [Document Parser Template Editor for Windows Desktop](https://cdn.bytescout.com/TemplateEditor.zip) for full experience.


**Sample Request:**

! Don't forget to set `x-api-key` url param or http header param (preferred) to API key, get yours [here](https://app.pdf.co/signup)


**POST**

```
{
"url" : "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf",
"inline": "true",
"template": "--- 
detectionRules: 
  keywords: 
    - "Sample document with multi-page table"
fields: 
  total: 
    dataType: decimal
    expression: "TOTAL {{DECIMAL}}"
    type: regex
sourceId: "Multipage Table Test"
tables: 
  - 
    columns: 
      - 
        name: itemNo
        type: integer
      - 
        name: description
        type: string
      - 
        name: price
        type: decimal
      - 
        name: qty
        type: integer
      - 
        name: extPrice
        type: decimal
    end: 
      expression: TOTAL\s+\d+\.\d\d
    multipage: true
    name: table1
    row: 
      expression: ^\s*(?<itemNo>\d+)\s+(?<description>.+?)\s+(?<price>\d+\.\d\d)\s+(?<qty>\d+)\s+(?<extPrice>\d+\.\d\d)
    start: 
      expression: "Item\\s+Description\\s+Price\\s+Qty\\s+Extended Price"
templatePriority: 0
templateVersion: 3
"

}
```


***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/documentparser
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| inline | true | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/document-parser/MultiPageTable.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| template | --- 
detectionRules: 
  keywords: 
    - "Sample document with multi-page table"
fields: 
  total: 
    dataType: decimal
    expression: "TOTAL {{DECIMAL}}"
    type: regex
sourceId: "Multipage Table Test"
tables: 
  - 
    columns: 
      - 
        name: itemNo
        type: integer
      - 
        name: description
        type: string
      - 
        name: price
        type: decimal
      - 
        name: qty
        type: integer
      - 
        name: extPrice
        type: decimal
    end: 
      expression: TOTAL\s+\d+\.\d\d
    multipage: true
    name: table1
    row: 
      expression: ^\s*(?<itemNo>\d+)\s+(?<description>.+?)\s+(?<price>\d+\.\d\d)\s+(?<qty>\d+)\s+(?<extPrice>\d+\.\d\d)
    start: 
      expression: "Item\\s+Description\\s+Price\\s+Qty\\s+Extended Price"
templatePriority: 0
templateVersion: 3
 | optional. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |
| outputFormat |  | optional. Format of output File. Valid values: JSON, YAML, XML, CSV. Must be a String. |
| generateCsvHeaders |  | optional. Must be one of: `true`, `false`. Default: `true`. |
| templateId |  | optional. Id of a saved template on [site](https://pdf.co/document-parser/templates). If in request present both template and templateId, content of template will be overwritten by content of saved template. Must be a string. |



***Responses:***


Status: /pdf/documentparser | Code: 200



```js
{
    "body": {
        "templateId": null,
        "templateVersion": "3",
        "sourceId": "Multipage Table Test",
        "fields": {
            "total": {
                "value": 450,
                "pageIndex": 1
            }
        },
        "tables": [
            {
                "name": "table1",
                "rows": [
                    {
                        "itemNo": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 1",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 2,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 2",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 3,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 3",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 4,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 4",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 5,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 5",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 6,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 6",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 7,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 7",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 8,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 8",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 9,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 9",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 10",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 11,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 11",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 12,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 12",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 13,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 13",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 14,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 14",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 15,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 15",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 16,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 16",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 17,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 17",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 18,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 18",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 19,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 19",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 20,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 20",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 21,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 21",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 22,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 22",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 23,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 23",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 24,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 24",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 25,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 25",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 26,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 26",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 27,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 27",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 28,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 28",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 29,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 29",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 30,
                            "pageIndex": 0
                        },
                        "description": {
                            "value": "Item 30",
                            "pageIndex": 0
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 0
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 0
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 0
                        }
                    },
                    {
                        "itemNo": {
                            "value": 31,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 31",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 32,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 32",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 33,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 33",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 34,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 34",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 35,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 35",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 36,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 36",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 37,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 37",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 38,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 38",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 39,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 39",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 40,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 40",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 41,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 41",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 42,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 42",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 43,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 43",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 44,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 44",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    },
                    {
                        "itemNo": {
                            "value": 45,
                            "pageIndex": 1
                        },
                        "description": {
                            "value": "Item 45",
                            "pageIndex": 1
                        },
                        "price": {
                            "value": 10,
                            "pageIndex": 1
                        },
                        "qty": {
                            "value": 1,
                            "pageIndex": 1
                        },
                        "extPrice": {
                            "value": 10,
                            "pageIndex": 1
                        }
                    }
                ]
            }
        ]
    },
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "MultiPageTable.json",
    "remainingCredits": 98587
}
```



### 2. /pdf/documentparser/templates


Return all YAML formatted templates for document parser for this user. Please use GET request.


***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/pdf/documentparser/templates
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Responses:***


Status: pdf/documentparser/templates | Code: 0



```js
{
    "templates": [
        {
            "id": 40,
            "type": "user",
            "title": "Untitled",
            "description": "Untitled"
        },
        {
            "id": 1,
            "type": "system",
            "title": "Invoice Parser",
            "description": "Parses invoices and extracts invoice number, company name, due date, amount, tax"
        }
    ],
    "remainingCredits": 94229
}
```



### 3. /pdf/documentparser/templates/:id


Return detailed information for document parser template by template’s id. Please use GET request.


***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/pdf/documentparser/templates/:id
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Responses:***


Status: pdf/documentparser/templates/:id | Code: 200



```js
{
    "id": 40,
    "type": "user",
    "title": "Untitled",
    "description": "Untitled",
    "body": "---\r\n  fields:\r\n    amount:\r\n      expression: '{{MONEY}}'\r\n    date:\r\n      expression: '{{DATE}}'\r\n  ",
    "remainingCredits": 94228
}
```



### 4. /pdf/documentparser/results


Return all document parser results for this user. Please use GET request.


***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/pdf/documentparser/results
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Query params:***

| Key | Value | Description |
| --- | ------|-------------|
| templateId |  | optional. Return all results for this document parser template id. Must be a String. |



***Responses:***


Status: pdf/documentparser/results | Code: 200



```js
{
    "results": [
        {
            "id": 74,
            "templateId": 40,
            "body": {
                "fields": {
                    "date": {
                        "value": ""
                    },
                    "amount": {
                        "value": "2",
                        "pageIndex": 0
                    }
                },
                "sourceId": null,
                "templateId": null,
                "templateVersion": "3"
            },
            "createdAt": "2020-03-23T11:17:30.152Z",
            "filename": "EINPresswire-Report-512260784-bytescout-announces-release-of-its-data-extraction-tools-for-on-cloud-deployments.pdf"
        }
    ],
    "remainingCredits": 94220
}
```



### 5. /pdf/documentparser/results


**Description** Create document parser result for this user. Please use POST request.

**Input Parameters**

| Param | Description |
|-- |--
|`templateId` | optional. Create document parser result with this template id. Must be a String.|
|`result` | optional. JSONB storage for storing document parser result. Must be a String.|
|`resultType` | optional. Result format. Valid values: JSON, YAML, XML, CSV. Must be a String.|
|`fileUrl` | optional. URL to source PDF File. Must be a String.|

**Status Errors**

|Code |	Description|
|-- |--
|`200` | The request has succeeded|
|`400` | bad input parameters|
|`401`| unauthorized|


***Endpoint:***

```bash
Method: POST
Type: RAW
URL: https://api.pdf.co/v1/pdf/documentparser/results
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

```js        
{
    "fileUrl": "https://github.com/bytescout/ByteScout-SDK-SourceCode/raw/master/Document%20Parser%20SDK/DigitalOcean.pdf",
    "templateId": 48,
    "formatType": "CSV",
    "result": "companyName,companyName2,invoiceId,dateIssued,dateDue,total,subTotal,tax\r\n,,,,,450.00,,\r\n\r\n"
}
```



### 6. /pdf/documentparser/results/:id


DELETE document parser result with given id. Please use DELETE request.


***Endpoint:***

```bash
Method: DELETE
Type: 
URL: https://api.pdf.co/v1/pdf/documentparser/results/:id
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



### 7. /pdf/documentparser/results/:id/file/url


Get source file url for document parser result.


***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/pdf/documentparser/results/:id/file/url
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



## Extract Data From Spreadsheets/XLS / XLSX to CSV



### 1. /xls/convert/to/csv



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/xls/convert/to/csv
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/other/Input.xls | optional. URL of the source XLS file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| quotationSymbol |  | optional. Must be a String. |
| separatorSymbol |  | optional. Must be a String. |
| worksheetIndex |  | optional. Must be a String. |
| inline | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /xls/convert/to/csv | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/a078b91ed5d744939a6af5e53052e158/Input.csv?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGcaDEe60q1agcli%2Ff2A9iKBAb3Qjy8tzVw7R3ErbNKGZE6aQU0Avc%2B008akXmk6CZDPdGu78HywnNss9O29FLGR9WnvoC7yYxLTYr7n1DSzRzDd4K0eTENiYo4bXa1GmO%2FzexdhKAFce6FmLAq8kC%2B3v24JdgdpdcBo15evu8tgqylTd07j2byk6v1%2BSlaFUClP3yi7ovTyBTIoW3f4K2nDeIbS%2BjQUq8s4jIdk8YZdhnc3TRSA9BwBmquHYKM6pNYaag%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHBN55YVQF/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T135922Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=0061e96b89c9429b0436c24706918fd03eca92107f49e7e73e1450033a0cf386",
    "error": false,
    "status": 200,
    "name": "Input.csv",
    "remainingCredits": 98515
}
```



### 2. /xls/convert/to/csv



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/xls/convert/to/csv
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/other/Input.xls | optional. URL of the source XLS file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| quotationSymbol |  | optional. Must be a String. |
| separatorSymbol |  | optional. Must be a String. |
| worksheetIndex |  | optional. Must be a String. |
| inline | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /xls/convert/to/csv | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/4d478a265f0246369d79a9453fd71ca4/Input.csv?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGcaDFBsw5A7XqASdLuJ0SKBASsTrRVmRNNB3W34v1fIytXgG%2F5elTI8m3whGMzQvxp0z0jicD7Yov%2BD%2FWcnJbEBf0mLpwxCK3HblbVyKYSD2k92v37BgFbdarcKkIBhFcBmKv2nzPaiGIfLAhZ0qc9pblouX0FbGKv2l%2BTnuTU1zH9%2B1MYxrot%2F1bnENhA8sARpQyjHovTyBTIolzmsH7YJaPten76GJRk8KgKLPZTYvQo78ObjkTowYEgqu%2F4WUgywSw%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHOXVR4OGA/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T135934Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=9500370d9413b9553b48ff59c45d5c4f0662bb52fd8ce7421d3b33cad8a2fe7f",
    "error": false,
    "status": 200,
    "name": "Input.csv",
    "remainingCredits": 98514
}
```



## Extract Data From Spreadsheets/XLS/XLSX to HTML



### 1. /xls/convert/to/html



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/xls/convert/to/html
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/other/Input.xls | optional. URL of the source XLS file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| worksheetIndex |  | optional. Must be a String. |
| inline | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /xls/convert/to/html | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/8406acd541b0447592d7d8558f997cf6/Input.html?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGcaDO3yJcYzYEWEd%2BoC0SKBAXDCz0E4AB5tI8zUVPS9O72Y0GHFnpMenQZ4PAcQjgSe%2Bthz%2FfjjpxjsUp5cd7wh2DxIBOq%2FlAE74tdd16bWDsAmImY1fO0MjQ9PaDRo7qd57RRw1WwBATIutP7otKkkUtfhdZfINEbEBRKyxNE7Zh%2FjOsJcgOwE4Ahnr%2FoPml500Ci5o%2FTyBTIoe%2FLQx0ZdvqIQ1Ms8p%2BamqldOY09iyFXAu4AeLBcjC64KRmTttaMNOw%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHCKKGFCNE/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T140127Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=97d913ae3561257b4e522f9069a912ce9cbade1035f42efe7bc3ee3955019183",
    "error": false,
    "status": 200,
    "name": "Input.html",
    "remainingCredits": 98513
}
```



### 2. /xls/convert/to/html



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/xls/convert/to/html
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/other/Input.xls | optional. URL of the source XLS file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| worksheetIndex |  | optional. Must be a String. |
| inline | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /xls/convert/to/html | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/2edb166da555455690315ae71e63c15c/Input.html?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGcaDMcfu4ocoAKzyo3y7iKBAYimtjz7mYR6kSOZh4UjUpgmC9oO2Bcb2PNUpbDPd7GtU18I4JNRZYblzG6JrNXq%2FiYgy8OuQuBE5uOZLMFjQ%2B6TUIM%2F3bQSJCOI9F29CjY8tE0h6UZfAwi7d%2BgHs%2Fe7KPeKc8AdF%2FXhSDas3Kwuj6u4d%2Bi%2FIrHaefrS1kVYAIFacijFo%2FTyBTIouRL0Ilias0R%2Bn7ISFzx5l1G7O%2FXxEMGCLjvF4fEHyPHjMD3gm2S29w%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHOHNXRBHS/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T140139Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=c921e574385f1f0a0a5bd7265af5fc75ef8ea971516491941f7b0c735c3b2fe1",
    "error": false,
    "status": 200,
    "name": "Input.html",
    "remainingCredits": 98512
}
```



## Extract Data From Spreadsheets/XLS/XLSX to JSON



### 1. /xls/convert/to/json



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/xls/convert/to/json
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/other/Input.xls | optional. URL of the source XLS file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| worksheetIndex |  | optional. Must be a String. |
| inline | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /xls/convert/to/json | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/30a5694fee5640939b203d6a4434909b/Input.json?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGcaDKfddzW%2FdNC49OENSSKBAZNTa8%2BPbUI3bpnHgoobJ%2BvYZbFzMw3YWaWWftprTe68CtkWTidk8myYaX9%2BvF8f4gmOd6nEvlq5SEuGphs5oIJNkvVPi5H2SVGlPqziTxyOA1jrq%2BQz1R5Qvc6FjSC3kafHqLisjNjCjYtE6lYKBGREXHjcpERewAg4U6coDVfsgCj3ofTyBTIoXnze1%2BCdl6gs9mHWqkS%2FAtJfqwHXQnebOrMRbzxb5g3YP%2Boo4pXlAA%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHA24DGFMR/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T135814Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=943c02e5291d287c40a6d1760979c61b30069bb47c1a415c3d188d65f1758057",
    "error": false,
    "status": 200,
    "name": "Input.json",
    "remainingCredits": 98517
}
```



### 2. /xls/convert/to/json



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/xls/convert/to/json
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/other/Input.xls | optional. URL of the source XLS file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| worksheetIndex |  | optional. Must be a String. |
| inline | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /xls/convert/to/json | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/18009bcb2d414cb794fa41032cbd7d0b/Input.json?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGcaDPYo6i5PK8497%2BllZiKBAYbQsgUq76LLLL265cy6QB5rJhrQEQBVlw2XdYpfNuBogitkFJE7ZdUKvIuP4h3%2BxJ861WpOUhheZSE5P4GpCoac6gUYJB5Qv8IEXBIDNjevMwI4ZYaHjUIqhRSjenDuMDCd406CXFDlqKrJM%2BzYmWnL%2FC2YNyN0CVr6snsvnaS7ySiFovTyBTIoG8X6teTW6Niw6yZIjR2QfkLQ20P720ku%2BsZwtImqLuxxxyzUJwLdBQ%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHFZBBM6NT/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T135827Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=59606ca78a0de19115f3981b3bef3e8ca12649fa0612e90171bb0edc4c63f909",
    "error": false,
    "status": 200,
    "name": "Input.json",
    "remainingCredits": 98516
}
```



## Extract Raw Data From PDF/PDF To CSV



### 1. /pdf/convert/to/csv



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/csv
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| inline |  | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-csv/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.csv | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/csv | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/db4decf740cf4c3fbd8ba9d66a31728e/result.csv",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.csv",
    "remainingCredits": 98573
}
```



### 2. /pdf/convert/to/csv



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/csv
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| inline |  | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-csv/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.csv | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/csv | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/07b3698e5ff2441aa03d788664bb0a00/result.csv",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.csv",
    "remainingCredits": 98569
}
```



## Extract Raw Data From PDF/PDF To JSON



### 1. /pdf/convert/to/json



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/json
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use JobId that you may use with /job/check to check state of the processing (possible states: working, failed, aborted and success). Must be one of: true, false. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: true, false. |
| inline | true | optional. Must be one of: true, false. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-json/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.csv | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. 51.8, 114.8, 235.5, 204.0. You can use our PDF Multitool to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when lineGrouping is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at 0 (zero). To set a range use the dash -, for example: 0,2-5,7-. To set a range from index to the last page use range like this: 2- (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: 0,2-5,7- means first page, then 3rd page to 6th page, and then the range from 8th (index = 7) page till the end of the document. Must be a String |
| lineGrouping |  | optional. Line grouping within table cells. Add Use lineGrouping=1 to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/json | Code: 200



```js
{
    "body": {
        "document": {
            "page": {
                "@index": "0",
                "row": [
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "24.0",
                                    "@fontStyle": "Bold",
                                    "@color": "#538DD3",
                                    "@x": "36.00",
                                    "@y": "34.44",
                                    "@width": "242.81",
                                    "@height": "24.00",
                                    "#text": "Your Company Name"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "76.94",
                                    "@width": "66.62",
                                    "@height": "11.04",
                                    "#text": "Your Address"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "91.46",
                                    "@width": "69.14",
                                    "@height": "11.04",
                                    "#text": "City, State Zip"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "461.02",
                                    "@y": "115.94",
                                    "@width": "98.42",
                                    "@height": "11.04",
                                    "#text": "Invoice No. 123456"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "436.54",
                                    "@y": "130.46",
                                    "@width": "122.90",
                                    "@height": "11.04",
                                    "#text": "Invoice Date 01/01/2016"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "36.00",
                                    "@y": "154.94",
                                    "@width": "63.62",
                                    "@height": "11.04",
                                    "#text": "Client Name"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "169.70",
                                    "@width": "40.34",
                                    "@height": "11.04",
                                    "#text": "Address"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "184.22",
                                    "@width": "69.14",
                                    "@height": "11.04",
                                    "#text": "City, State Zip"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "233.30",
                                    "@width": "28.70",
                                    "@height": "11.04",
                                    "#text": "Notes"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "36.00",
                                    "@y": "316.25",
                                    "@width": "22.58",
                                    "@height": "11.04",
                                    "#text": "Item"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "247.61",
                                    "@y": "316.25",
                                    "@width": "44.64",
                                    "@height": "11.04",
                                    "#text": "Quantity"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "398.95",
                                    "@y": "316.25",
                                    "@width": "26.91",
                                    "@height": "11.04",
                                    "#text": "Price"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "533.14",
                                    "@y": "316.25",
                                    "@width": "26.30",
                                    "@height": "11.04",
                                    "#text": "Total"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "341.33",
                                    "@width": "30.62",
                                    "@height": "11.04",
                                    "#text": "Item 1"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "286.13",
                                    "@y": "341.33",
                                    "@width": "6.12",
                                    "@height": "11.04",
                                    "#text": "1"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "398.35",
                                    "@y": "341.33",
                                    "@width": "27.51",
                                    "@height": "11.04",
                                    "#text": "40.00"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "531.94",
                                    "@y": "341.33",
                                    "@width": "27.50",
                                    "@height": "11.04",
                                    "#text": "40.00"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "362.45",
                                    "@width": "30.62",
                                    "@height": "11.04",
                                    "#text": "Item 2"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "286.13",
                                    "@y": "362.45",
                                    "@width": "6.12",
                                    "@height": "11.04",
                                    "#text": "2"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "398.35",
                                    "@y": "362.45",
                                    "@width": "27.51",
                                    "@height": "11.04",
                                    "#text": "30.00"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "531.94",
                                    "@y": "362.45",
                                    "@width": "27.50",
                                    "@height": "11.04",
                                    "#text": "60.00"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "383.57",
                                    "@width": "30.62",
                                    "@height": "11.04",
                                    "#text": "Item 3"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "286.13",
                                    "@y": "383.57",
                                    "@width": "6.12",
                                    "@height": "11.04",
                                    "#text": "3"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "398.35",
                                    "@y": "383.57",
                                    "@width": "27.51",
                                    "@height": "11.04",
                                    "#text": "20.00"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "531.94",
                                    "@y": "383.57",
                                    "@width": "27.50",
                                    "@height": "11.04",
                                    "#text": "60.00"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "404.93",
                                    "@width": "30.62",
                                    "@height": "11.04",
                                    "#text": "Item 4"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "286.13",
                                    "@y": "404.93",
                                    "@width": "6.12",
                                    "@height": "11.04",
                                    "#text": "4"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "398.35",
                                    "@y": "404.93",
                                    "@width": "27.51",
                                    "@height": "11.04",
                                    "#text": "10.00"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "531.94",
                                    "@y": "404.93",
                                    "@width": "27.50",
                                    "@height": "11.04",
                                    "#text": "40.00"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "389.11",
                                    "@y": "425.83",
                                    "@width": "36.75",
                                    "@height": "11.04",
                                    "#text": "TOTAL"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "525.82",
                                    "@y": "425.83",
                                    "@width": "33.62",
                                    "@height": "11.04",
                                    "#text": "200.00"
                                }
                            }
                        ]
                    }
                ]
            }
        }
    },
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "sample.json",
    "remainingCredits": 98565
}
```



### 2. /pdf/convert/to/json



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/json
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use JobId that you may use with /job/check to check state of the processing (possible states: working, failed, aborted and success). Must be one of: true, false. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: true, false. |
| inline | true | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-json/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.csv | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. 51.8, 114.8, 235.5, 204.0. You can use our PDF Multitool to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when lineGrouping is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at 0 (zero). To set a range use the dash -, for example: 0,2-5,7-. To set a range from index to the last page use range like this: 2- (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: 0,2-5,7- means first page, then 3rd page to 6th page, and then the range from 8th (index = 7) page till the end of the document. Must be a String |
| lineGrouping |  | optional. Line grouping within table cells. Add Use lineGrouping=1 to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/json | Code: 200



```js
{
    "body": {
        "document": {
            "page": {
                "@index": "0",
                "row": [
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "24.0",
                                    "@fontStyle": "Bold",
                                    "@color": "#538DD3",
                                    "@x": "36.00",
                                    "@y": "34.44",
                                    "@width": "242.81",
                                    "@height": "24.00",
                                    "#text": "Your Company Name"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "76.94",
                                    "@width": "66.62",
                                    "@height": "11.04",
                                    "#text": "Your Address"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "91.46",
                                    "@width": "69.14",
                                    "@height": "11.04",
                                    "#text": "City, State Zip"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "461.02",
                                    "@y": "115.94",
                                    "@width": "98.42",
                                    "@height": "11.04",
                                    "#text": "Invoice No. 123456"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "436.54",
                                    "@y": "130.46",
                                    "@width": "122.90",
                                    "@height": "11.04",
                                    "#text": "Invoice Date 01/01/2016"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "36.00",
                                    "@y": "154.94",
                                    "@width": "63.62",
                                    "@height": "11.04",
                                    "#text": "Client Name"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "169.70",
                                    "@width": "40.34",
                                    "@height": "11.04",
                                    "#text": "Address"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "184.22",
                                    "@width": "69.14",
                                    "@height": "11.04",
                                    "#text": "City, State Zip"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "233.30",
                                    "@width": "28.70",
                                    "@height": "11.04",
                                    "#text": "Notes"
                                }
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "36.00",
                                    "@y": "316.25",
                                    "@width": "22.58",
                                    "@height": "11.04",
                                    "#text": "Item"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "247.61",
                                    "@y": "316.25",
                                    "@width": "44.64",
                                    "@height": "11.04",
                                    "#text": "Quantity"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "398.95",
                                    "@y": "316.25",
                                    "@width": "26.91",
                                    "@height": "11.04",
                                    "#text": "Price"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "533.14",
                                    "@y": "316.25",
                                    "@width": "26.30",
                                    "@height": "11.04",
                                    "#text": "Total"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "341.33",
                                    "@width": "30.62",
                                    "@height": "11.04",
                                    "#text": "Item 1"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "286.13",
                                    "@y": "341.33",
                                    "@width": "6.12",
                                    "@height": "11.04",
                                    "#text": "1"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "398.35",
                                    "@y": "341.33",
                                    "@width": "27.51",
                                    "@height": "11.04",
                                    "#text": "40.00"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "531.94",
                                    "@y": "341.33",
                                    "@width": "27.50",
                                    "@height": "11.04",
                                    "#text": "40.00"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "362.45",
                                    "@width": "30.62",
                                    "@height": "11.04",
                                    "#text": "Item 2"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "286.13",
                                    "@y": "362.45",
                                    "@width": "6.12",
                                    "@height": "11.04",
                                    "#text": "2"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "398.35",
                                    "@y": "362.45",
                                    "@width": "27.51",
                                    "@height": "11.04",
                                    "#text": "30.00"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "531.94",
                                    "@y": "362.45",
                                    "@width": "27.50",
                                    "@height": "11.04",
                                    "#text": "60.00"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "383.57",
                                    "@width": "30.62",
                                    "@height": "11.04",
                                    "#text": "Item 3"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "286.13",
                                    "@y": "383.57",
                                    "@width": "6.12",
                                    "@height": "11.04",
                                    "#text": "3"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "398.35",
                                    "@y": "383.57",
                                    "@width": "27.51",
                                    "@height": "11.04",
                                    "#text": "20.00"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "531.94",
                                    "@y": "383.57",
                                    "@width": "27.50",
                                    "@height": "11.04",
                                    "#text": "60.00"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "36.00",
                                    "@y": "404.93",
                                    "@width": "30.62",
                                    "@height": "11.04",
                                    "#text": "Item 4"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "286.13",
                                    "@y": "404.93",
                                    "@width": "6.12",
                                    "@height": "11.04",
                                    "#text": "4"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "398.35",
                                    "@y": "404.93",
                                    "@width": "27.51",
                                    "@height": "11.04",
                                    "#text": "10.00"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@x": "531.94",
                                    "@y": "404.93",
                                    "@width": "27.50",
                                    "@height": "11.04",
                                    "#text": "40.00"
                                }
                            }
                        ]
                    },
                    {
                        "column": [
                            {
                                "text": ""
                            },
                            {
                                "text": ""
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "389.11",
                                    "@y": "425.83",
                                    "@width": "36.75",
                                    "@height": "11.04",
                                    "#text": "TOTAL"
                                }
                            },
                            {
                                "text": {
                                    "@fontName": "Arial",
                                    "@fontSize": "11.0",
                                    "@fontStyle": "Bold",
                                    "@x": "525.82",
                                    "@y": "425.83",
                                    "@width": "33.62",
                                    "@height": "11.04",
                                    "#text": "200.00"
                                }
                            }
                        ]
                    }
                ]
            }
        }
    },
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "sample.json",
    "remainingCredits": 98561
}
```



## Extract Raw Data From PDF/PDF To TEXT



### 1. /pdf/convert/to/text



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/text
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| inline | true | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.txt | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/text | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/df4a91ecbf804d368cfb9aa38b1cf578/result.txt",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.txt",
    "remainingCredits": 98558
}
```



### 2. /pdf/convert/to/text



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/text
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| inline | true | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.txt | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/text | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/9e317660f461448495cea1fae85cb9a7/result.txt",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.txt",
    "remainingCredits": 98555
}
```



## Extract Raw Data From PDF/PDF To XLS



### 1. /pdf/convert/to/xls



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/xls
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| inline | true | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-excel/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.xls | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/xls | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/4547dc38647644cd851669d9fb28a354/result.xls",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.xls",
    "remainingCredits": 98550
}
```



### 2. /pdf/convert/to/xls



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/xls
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| inline | true | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-excel/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.xls | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/xls | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/56b4223532734247897f7da82a7a6a47/result.xls",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.xls",
    "remainingCredits": 98545
}
```



## Extract Raw Data From PDF/PDF To XLSX



### 1. /pdf/convert/to/xls



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/xlsx
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Query params:***

| Key | Value | Description |
| --- | ------|-------------|
|  |  |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-excel/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.xlsx | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/xls | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/199ceb67bab24efea8e2174fd78df0e3/result.xlsx",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.xlsx",
    "remainingCredits": 98541
}
```



### 2. /pdf/convert/to/xls



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/xlsx
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Query params:***

| Key | Value | Description |
| --- | ------|-------------|
|  |  |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-excel/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.xlsx | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/xls | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/8417db54c9e74962bbb8099b2a1630b7/result.xlsx",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.xlsx",
    "remainingCredits": 98537
}
```



## Extract Raw Data From PDF/PDF To XML



### 1. /pdf/convert/to/xml



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/xml
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| inline | true | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-xml/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.xml | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/xml | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/be1ff3296d0c4f06bfa66f3241604fe2/result.xml",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.xml",
    "remainingCredits": 98532
}
```



### 2. /pdf/convert/to/xml



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/xml
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| inline |  | optional. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-xml/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| name | result.xml | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| unwrap |  | optional. Unwrap lines into a single line within table cells when `lineGrouping` is enabled. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| lineGrouping |  | optional. Line grouping within table cells. Add Use `lineGrouping=1` to enable the grouping. Must be a String. |



***Responses:***


Status: /pdf/convert/to/xml | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/b8c60b5adb214fd08dcb6ba9e326cbcb/result.xml",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.xml",
    "remainingCredits": 98527
}
```



## Extract Raw Data From PDF/PDF to HTML



### 1. /pdf/convert/to/html



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/html
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-html/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.html | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| simple | false | optional. Set `true` to convert to a plain HTML format. Default is the rich HTML & CSS format keeping the document design. Must be one of: `true`, `false`. |
| columns | false | optional. Set `true` if the PDF document is arranged in columns like a newspaper. Default is `false`. Must be one of: `true`, `false`. |



***Responses:***


Status: /pdf/convert/to/html | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/ff03dd4ebbd742f083fbe87c96d55349/index.html",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.html",
    "remainingCredits": 98524
}
```



### 2. /pdf/convert/to/html



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/html
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-html/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.html | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| simple | false | optional. Set `true` to convert to a plain HTML format. Default is the rich HTML & CSS format keeping the document design. Must be one of: `true`, `false`. |
| columns | false | optional. Set `true` if the PDF document is arranged in columns like a newspaper. Default is `false`. Must be one of: `true`, `false`. |



***Responses:***


Status: /pdf/convert/to/html | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/cabfe6f23ca541d39f277e502d886410/index.html",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.html",
    "remainingCredits": 98518
}
```



## Generate Barcodes
**Description:** Generates high quality printable and scannable barcodes as images or PDF. All popular types are supported from Code 39, Code 128 to QR Code, Datamatrix and PDF417. `GET` or `POST` request.

Other supported values for `type` param to set other barcodes:

`Code128`, `Code39`, `Postnet`, `UPCA`, `EAN8`, `ISBN`, `Codabar`, `I2of5`, `Code93`, `EAN13`, `JAN13`, `Bookland`, `UPCE`, `PDF417`, `PDF417Truncated`, `DataMatrix`, `QRCode`, `Aztec`, `Planet`, `EAN128`, `GS1_128`, `USPSSackLabel`, `USPSTrayLabel`, `DeutschePostIdentcode`, `DeutschePostLeitcode`, `Numly`, `PZN`, `OpticalProduct`, `SwissPostParcel`, `RoyalMail`, `DutchKix`, `SingaporePostalCode`, `EAN2`, `EAN5`, `EAN14`, `MacroPDF417`, `MicroPDF417`, `GS1_DataMatrix`, `Telepen`, `IntelligentMail`, `GS1_DataBar_Omnidirectional`, `GS1_DataBar_Truncated`, `GS1_DataBar_Stacked`, `GS1_DataBar_Stacked_Omnidirectional`, `GS1_DataBar_Limited`, `GS1_DataBar_Expanded`, `GS1_DataBar_Expanded_Stacked`, `MaxiCode`, `Plessey`, `MSI`, `ITF14`, `GTIN12`, `GTIN8`, `GTIN13`, `GTIN14`.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| all is OK|
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|

**Example**

Sample Request:

! Don't forget to set `x-api-key` url param or http header param (preferred) to API key, get yours [here](https://app.pdf.co/signup)


**POST**

```
{
"name" : "barcode.png",
"type" : "Code128",
"value" : "abcdef123456"
}
```



### 1. /barcode/generate



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/barcode/generate
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional.	Enable encryption for output file. Must be one of: `true`, `false`. |
| name | barcode.png | optional.	Filename for the generated image. Must be a String |
| value | abcdef123456 | optional. Value to be encoded into barcode. Must be a String |
| type | Code128 | optional. Sets barcode type. `QRCode` by default. Must be a String |



***Responses:***


Status: /barcode/generate | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/8f8aaca421d64bc2a9bb9158c024db95/barcode.png",
    "error": false,
    "status": 200,
    "name": "barcode.png",
    "remainingCredits": 98161
}
```



### 2. /barcode/generate



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/barcode/generate
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional.	Enable encryption for output file. Must be one of: `true`, `false`. |
| name | barcode.png | optional.	Filename for the generated image. Must be a String |
| value | abcdef123456 | optional. Value to be encoded into barcode. Must be a String |
| type | Code128 | optional. Sets barcode type. `QRCode` by default. Must be a String |



***Responses:***


Status: /barcode/generate | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/b867d6fcab2d4930845450752849e619/barcode.png",
    "error": false,
    "status": 200,
    "name": "barcode.png",
    "remainingCredits": 98160
}
```



## Generate PDF documents/PDF from CSV



### 1. /pdf/convert/from/csv



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/csv
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/csv-to-pdf/sample.csv | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String.| |



***Responses:***


Status: /pdf/convert/from/csv | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/4b13a7cef51047edb68dde6cab0b4050/result.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98509
}
```



### 2. /pdf/convert/from/csv



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/csv
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/csv-to-pdf/sample.csv | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String.| |



***Responses:***


Status: /pdf/convert/from/csv | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/01ede81738a44b4fa5a6b909115ae0a3/result.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98506
}
```



## Generate PDF documents/PDF from Doc, DocX, RTF, TXT, XPS



### 1. /pdf/convert/from/doc



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/doc
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/doc-to-pdf/sample.docx | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |



***Responses:***


Status: /pdf/convert/from/doc | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/f6cc6b12f4d841f2a4cf5e432a7a57e9/result.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98503
}
```



### 2. /pdf/convert/from/doc



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/doc
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/doc-to-pdf/sample.docx | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |



***Responses:***


Status: /pdf/convert/from/doc | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/0181a7ebda5c438e893fa62cce9d0c8f/result.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98497
}
```



## Generate PDF documents/PDF from HTML



### 1. /pdf/convert/from/html



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/html
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| templatedata |  | optional. JSON model which will be used for processing HTML template. Must be a String. |
| html | <h1>Hello World!</h1> | optional. HTML code. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-html/sample.html | optional. URL of the source Html file. Must be a String. |



***Responses:***


Status: /pdf/convert/from/html | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/ab6203023be74b2285b3c49e49d414c2/result.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98494
}
```



### 2. /pdf/convert/from/html



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/html
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| templatedata |  | optional. JSON model which will be used for processing HTML template. Must be a String. |
| html | <h1>Hello World!</h1> | optional. HTML code. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-html/sample.html | optional. URL of the source Html file. Must be a String. |



***Responses:***


Status: /pdf/convert/from/html | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/e15da390859a436b9606ad6252bef684/result.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98491
}
```



## Generate PDF documents/PDF from Images



### 1. /pdf/convert/from/image



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/image
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image1.png,https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image2.jpg | required. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |



***Responses:***


Status: /pdf/convert/from/image | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/15a3dfc7eabb493cbf82100632b7dd05/result.pdf",
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98479
}
```



### 2. /pdf/convert/from/image



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/image
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image1.png,https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image2.jpg | required. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |



***Responses:***


Status: /pdf/convert/from/image | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/ac2082a8cb734c6184645d85b15a0d50/result.pdf",
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98473
}
```



## Generate PDF documents/PDF from Website URL



### 1. /pdf/convert/from/url



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/from/url
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.	Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| templatedata |  | optional. JSON model which will be used for processing HTML template. Must be a String. |
| url | https://www.wikipedia.org | required. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |



***Responses:***


Status: /pdf/convert/from/url | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/ac21bf89372f47ef80a351cccff564db/result.pdf",
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98485
}
```



## Generate PDF documents/PDF from XLS or XLSX



### 1. /xls/convert/to/pdf



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/xls/convert/to/pdf
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/other/Input.xls | optional. URL of the XLS file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| worksheetIndex |  | optional. Must be a String. |
| inline | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /xls/convert/to/pdf | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/a831faf7fac24f83ac5493a27f0302e0/Input.pdf?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGgaDJ%2FEYZpwshwOnrsqnCKBAeLonQsVRzI4LxRm36U%2FC%2FiDP7iamfb2ZEM81cAZHq2hLikFOnejAdNXQiidjQSuMwSMCbnsds7Ywo1XB33tlziWhJqD%2FyavFUdu6oCmUfpBzyK9Dbm%2F3O9SG3rkOIfnYEgPhTZioZ5elCP6Hj%2B22dCmqw7V%2Bpm5bYHkwMTiVqmO0CidpvTyBTIouazv7Iaj1DceXgMVdWQR3kIr49%2FyXx8FEG7waFuf0uL2GbvOoICgRA%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHEWRKLYXJ/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T140723Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=08d6b9cf65ddb25016ebdee028fdafd677c2f426b8909708388764b740e49604",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "Input.pdf",
    "remainingCredits": 98470
}
```



### 2. /xls/convert/to/pdf



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/xls/convert/to/pdf
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional.Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt | true | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/other/Input.xls | optional. URL of the XLS file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| worksheetIndex |  | optional. Must be a String. |
| inline | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /xls/convert/to/pdf | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/25533bda87b3465e8e8d489d6e23403b/Input.pdf?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGgaDHksDAqw%2FKcvC2zJ4iKBAXCElPxYDMJDksV4mvBcFV4LRCYlZyx933mtf4jvOXh7E4ajPzJB8KjRcdngotG97e1fKUnw2VFIfLV3Bnd47pIL%2F2QMZLBDy3N6ZAAA5Max2DU2QNTi3t5TpEy%2BTTpm1IX2sMtDT9IbKaCGfBfn%2B9fP4hvejyFgEVUGaQHibxgR5iiopvTyBTIo9tVd2zglZtZwYE09DybJipdUk7GW4q5ZKHLy7m87KNpLFFNh0%2BjvFQ%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHIIIV5B6J/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T140735Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=49b33fec607f3bf298d24876712a936ffc5de03d7b3e54b6c3b2f0755cbe9b18",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "Input.pdf",
    "remainingCredits": 98467
}
```



## Manage Background Jobs
**Description:** This method checks status of backgroud job by their `jobId`. You may create background job by calling API methods with `async` parameter set to `true`.
Checks and returns status of a job that is running in background.

Available statuses are:
- `working`: this background job is still working.
- `failed`: this background job failed to execute.
- `aborted`: this background job aborted by user.
- `success`: this background job successfully executed.

Please use `GET` or `POST` request.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|

**Example**

Sample Request:

! Don't forget to set `x-api-key` url param or http header param (preferred) to API key, get yours [here](https://app.pdf.co/signup)


**POST**

```
{
	"jobid" : "123"
}
```



### 1. /job/check



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/job/check
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| jobid | 123 | required. Id of processing that was started asynchronously. Must be a String. |



***Responses:***


Status: /job/check | Code: 200



```js
{
    "status": "unknown",
    "message": "Job doesn't exist",
    "remainingCredits": 98142
}
```



### 2. /job/check



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/job/check
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| jobid | 123 | required. Id of processing that was started asynchronously. Must be a String. |



***Responses:***


Status: /job/check | Code: 200



```js
{
    "status": "unknown",
    "message": "Job doesn't exist",
    "remainingCredits": 98142
}
```



## PDF Tools/Add Text and Images to PDF



### 1. /pdf/edit/add



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/edit/add
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async | false | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| width | 159 | optional. Width of the image in PDF Points (1/72 in.). Must be a Integer.  |
| height | 43 | optional. Height of the image in PDF Points (1/72 in.). Must be a Integer. Works in in "type" = "image" mode only. |
| y | 50 | optional. Y coordinate of the image or text in PDF Points (1/72 in.). Must be a Integer. |
| x | 400 | optional. X coordinate of the image or text in PDF Points (1/72 in.). Must be a Integer. |
| transparent |  | optional. Enables transparency.  Must be one of: `true`, `false`. |
| color |  | optional. Sets color in HTML  format. Must be a String. |
| urlimage | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png | optional. URL of the image file  to be added (should be PNG, PNG with transparency or  JPG). Must be a String. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | newDocument | optional. File name for generated output. Must be a String. |
| text | test test1 test2 | optional. Text to be added. Set "type" to "annotation" to enable text annotation mode. Must be a String. |
| type | annotation | optional. Switches the mode, should be "annotation" (for text to be added) or "image" (for image to be added). For image and text or multiple text and images please use POST /pdf/edit/add |
| fontname |  | optional. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/edit/add | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/d3ab20a49de74959a5ed330065dc7278/newDocument-edited.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "newDocument-edited",
    "remainingCredits": 98370
}
```



### 2. /pdf/edit/add



***Endpoint:***

```bash
Method: POST
Type: RAW
URL: https://api.pdf.co/v1/pdf/edit/add
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

```js        
{
    "async": false,
    "name": "newDocument",
    "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/sample.pdf",
    "annotations":[
        {
            "text":"Testing, one, two, three.",
            "x": 10,
            "y": 10,
            "size": 12,
            "pages": "0-"
        },
        {
            "text":"Testing Clickable Links \r\n(CLICK ME!)",
            "x": 200,
            "y": 200,
            "size": 24,
            "pages": "0-",
            "color": "CCBBAA",
            "link": "https://bytescout.com/"
        }          
        
    ],
    
    "images": [
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png",
            "x": 450,
            "y": 10,
            "pages": "0"
        },
        {
            "url": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png",
            "x": 450,
            "y": 100,
            "width": 50,
            "height": 50,
            "pages": "0"
        },
        {
            "url": "bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-edit/logo.png",
            "x": 200,
            "y": 250,
            "pages": "0",
            "link": "www.pdf.co"
        }
        
    ]
}
```



***Responses:***


Status: /pdf/edit/add | Code: 200



## PDF Tools/Delete Text from PDF



### 1. /pdf/edit/delete-text (multiple replacements)



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/edit/delete-text
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | pdfWithTextDeleted | optional. File name for generated output. Must be a String. |
| caseSensitive | false | optional. `true` or `false`. Set to false by default |
| searchStrings[] | conspicuous feature | required. Array of words to delete. Must contain at least 1 word. Example: `['Hello', 'World']` |
| password |  | optional. Password of PDF file. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/edit/delete-text | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/9e531aa9da3e49a0b16b4b7d69d27e01/pdfWithTextDeleted.pdf",
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "pdfWithTextDeleted",
    "remainingCredits": 98358
}
```



### 2. /pdf/edit/delete-text (single replacement)



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/edit/delete-text
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | pdfWithTextDeleted | optional. File name for generated output. Must be a String. |
| caseSensitive | false | optional. `true` or `false`. Set to false by default |
| searchString | conspicuous feature | required. Array of words to delete. Must contain at least 1 word. Example: `['Hello', 'World']` |
| password |  | optional. Password of PDF file. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/edit/delete-text | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/d2bd21eb324e4215a79cf6ef0aa8e9c5/pdfWithTextDeleted.pdf",
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "pdfWithTextDeleted",
    "remainingCredits": 98346
}
```



### 3. /pdf/edit/delete-text



***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/pdf/edit/delete-text
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |



***Query params:***

| Key | Value | Description |
| --- | ------|-------------|
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | URL of the source PDF file. Must be a String. |
| searchString | conspicuous | required. Text to delete |
| x-api-key | {{x-api-key}} |  |



***Responses:***


Status: /pdf/edit/delete-text | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/826c6485449748268552ad1b46e2f905/sample.pdf",
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "sample.pdf",
    "remainingCredits": 98334
}
```



## PDF Tools/Make Text Searchable PDF



### 1. /pdf/makesearchable



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/makesearchable
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-make-searchable/sample.pdf | required. URL of the input PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| lang | eng | optional. Language of PDF file (eng, fra, spa, deu). Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/makesearchable | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/6e6174a7bc1a4bf99e7be78755a4cf24/result.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98428
}
```



### 2. /pdf/makesearchable



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/makesearchable
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-make-searchable/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| profiles |  | optional. Must be a String. |
| lang | eng | optional. Language of PDF file (eng, fra, spa, deu). Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/makesearchable | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/4df96050d809442cb7909094d2892849/result.pdf",
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98423
}
```



## PDF Tools/Merge and Split PDF/Delete Pages



### 1. /pdf/edit/delete-pages



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/edit/delete-pages
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| pages | 1-2 | optional. Comma-separated list of page indices (or ranges) to remove. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/edit/delete-pages | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/d000e39dad7b4cf9a3098132465f1bd6/result.pdf",
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98437
}
```



### 2. /pdf/edit/delete-pages



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/edit/delete-pages
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| pages | 1-2 | optional. Comma-separated list of page indices (or ranges) to remove. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/edit/delete-pages | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/e9efe4c9dbcb48148705c967aa6ebfd5/result.pdf",
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98433
}
```



## PDF Tools/Merge and Split PDF/Merge



### 1. /pdf/merge



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/merge
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample1.pdf,https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample2.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |



***Responses:***


Status: /pdf/merge | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/cee96f2b039543ffa7e61e059860a721/result.pdf",
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98466
}
```



### 2. /pdf/merge



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/merge
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample1.pdf,https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-merge/sample2.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |



***Responses:***


Status: /pdf/merge | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/3ec287356c0b4e02b5231354f94086f2/result.pdf",
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98465
}
```



## PDF Tools/Merge and Split PDF/Split



### 1. /pdf/split



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/split
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| pages | 1-2,3- | Define comma-separated indices of pages (or ranges) that you want to split from the document. The first page indice is always `1`. For example, if you have a 7 page document that you want split into 3 separate PDFs but different number of pages it would go like this: `1, 2, 3-` or `1, 2, 3-7` which will result in 1 PDF with page one, 1 PDF with page two and one PDF with the rest of the pages. Must be a String. |



***Responses:***


Status: /pdf/split | Code: 200



```js
{
    "urls": [
        "https://pdf-temp-files.s3.amazonaws.com/c651ababa85c423aa7b134d0e17ca269/result_page1-2.pdf",
        "https://pdf-temp-files.s3.amazonaws.com/245405c93e764dcbaffa37a38af8219a/result_page3-4.pdf"
    ],
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98453
}
```



### 2. /pdf/split



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/split
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| pages | 1-2,3- | Define comma-separated indices of pages (or ranges) that you want to split from the document. The first page indice is always `1`. For example, if you have a 7 page document that you want split into 3 separate PDFs but different number of pages it would go like this: `1, 2, 3-` or `1, 2, 3-7` which will result in 1 PDF with page one, 1 PDF with page two and one PDF with the rest of the pages. Must be a String. |



***Responses:***


Status: /pdf/split | Code: 200



```js
{
    "urls": [
        "https://pdf-temp-files.s3.amazonaws.com/1e9a7f2c46834160903276716424382b/result_page1-2.pdf",
        "https://pdf-temp-files.s3.amazonaws.com/c976b9f89a2e460786a3d5c0deeeef67/result_page3-4.pdf"
    ],
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "result.pdf",
    "remainingCredits": 98441
}
```



## PDF Tools/Optimize PDF



### 1. /pdf/optimize



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/optimize
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-optimize/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |



***Responses:***


Status: /pdf/optimize | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/798592f9d35047af92cf9e4d05c1ba41/result-compressed.pdf",
    "fileSize": 798621,
    "pageCount": 5,
    "error": false,
    "status": 200,
    "name": "result-compressed.pdf",
    "remainingCredits": 98398
}
```



### 2. /pdf/optimize



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/optimize
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional.Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-optimize/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.pdf | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |



***Responses:***


Status: /pdf/optimize | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/beba64cbc2984830b9fd974f3b834528/result-compressed.pdf",
    "fileSize": 798621,
    "pageCount": 5,
    "error": false,
    "status": 200,
    "name": "result-compressed.pdf",
    "remainingCredits": 98373
}
```



## PDF Tools/Search and Replace Text



### 1. /pdf/edit/replace-text



***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/pdf/edit/replace-text
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |



***Query params:***

| Key | Value | Description |
| --- | ------|-------------|
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf |  |
| searchString | conspicuous |  |
| replaceString | replaced |  |
| x-api-key | {{x-api-key}} |  |



***Responses:***


Status: /pdf/edit/replace-text | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/ab8f4b9e230d45e5a6dde379992c9f1d/sample.pdf",
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "sample.pdf",
    "remainingCredits": 98322
}
```



### 2. /pdf/edit/replace-text (single replacement)



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/edit/replace-text
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | finalFile | optional. File name for generated output. Must be a String. |
| caseSensitive | true | optional. `true` or `false`. Set to false by default |
| searchString | onspicuous feature | required for single text replacement. Word to be replaced. Must be a String |
| replaceString | Replaced1 | required for single text replacement. Word to be replaced with. Must be a String |
| searchStrings |  | required for batch text replacements. Array of words to be replaced. Must contain at least 1 word. Example: `['Hello', 'World']` |
| replaceStrings |  | required for batch text replacements. Array of words to be replaced with. Must contain at least 1 word. Example: `['Hello', 'World']` |
| password |  | optional. Password of PDF file. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/edit/replace-text | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/1a0e9a51e2d04fe4bcce0a6a31c365a8/finalFile.pdf",
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "finalFile",
    "remainingCredits": 98310
}
```



### 3. /pdf/edit/replace-text (mutliple replacements)



***Endpoint:***

```bash
Method: POST
Type: RAW
URL: https://api.pdf.co/v1/pdf/edit/replace-text
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

```js        
{
  "url": "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf",
  "searchStrings": [
    "conspicuous feature",
    "Martian"
  ],
  "replaceStrings": [
    "Replaced1",
    "Replaced2"
  ],
  "caseSensitive": true,
  "name": "finalFile"
}
```



***Responses:***


Status: /pdf/edit/replace-text | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/5e02856782ea4f90b0c47c052565ae01/finalFile.pdf",
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "finalFile",
    "remainingCredits": 98298
}
```



## PDF Tools/Search and Replace Text with Image



### 1. /pdf/edit/replace-text-with-image



***Endpoint:***

```bash
Method: GET
Type: 
URL: https://api.pdf.co/v1/pdf/edit/replace-text-with-image
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
|  |  |  |



***Query params:***

| Key | Value | Description |
| --- | ------|-------------|
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf |  |
| searchString | Hypothesis |  |
| replaceImage | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image1.png |  |
| x-api-key | {{x-api-key}} |  |



***Responses:***


Status: /pdf/edit/replace-text-with-image | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/79abf7b75a584939879992cc9c4d0967/sample.pdf",
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "sample.pdf",
    "remainingCredits": 98254
}
```



### 2. /pdf/edit/replace-text-with-image



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/edit/replace-text-with-image
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| caseSensitive | true | optional. `true` or `false`. Set to false by default |
| searchString | Hypothesis | required. Word to be replaced. Must contain at least 1 word. Example: `'Hello'` |
| replaceImage | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/image-to-pdf/image1.png | required. Image url to be inserted in doc: `http://www.xyz.com/image.png` |
| password |  | optional. Password of PDF file. Must be a String. |
| pages | 0 | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/edit/replace-text-with-image | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/6f61a5e6af8a48baae5df4a1c1842be4/sample.pdf",
    "pageCount": 4,
    "error": false,
    "status": 200,
    "name": "sample.pdf",
    "remainingCredits": 98210
}
```



## Read Barcodes
**Description:** Read barcodes from images, tiff, pdf documents, scanned documents. All popular types of barcodes are supported from Code 39, Code 128 to QR Code, Datamatrix and PDF417. Supports noisy and damaged barcodes, scans, documents. `GET` or `POST` request.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|

**Example**

Sample Request:

! Don't forget to set `x-api-key` url param or http header param (preferred) to API key, get yours [here](https://app.pdf.co/signup)


**POST**

```
{
	"types" : "Code128,Code39,Interleaved2of5,EAN13",
	"pages" : "",
	"url" : "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf"
}
```



### 1. /barcode/read/from/url



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/barcode/read/from/url
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| types | Code128,Code39,Interleaved2of5,EAN13 | optional. Comma-separated list of barcode types to decode. Valid types: `AustralianPostCode`, `Aztec`, `CircularI2of5`, `Codabar`, `CodablockF`, `Code128`, `Code16K`, `Code39`, `Code39Extended`, `Code39Mod43`, `Code39Mod43Extended`, `Code93`, `DataMatrix`, `EAN13`, `EAN2`, `EAN5`, `EAN8`, `GS1`, `GS1DataBarExpanded`, `GS1DataBarExpandedStacked`, `GS1DataBarLimited`, `GS1DataBarOmnidirectional`, `GS1DataBarStacked`, `GTIN12`, `GTIN13`, `GTIN14`, `GTIN8`, `IntelligentMail`, `Interleaved2of5`, `ITF14`, `MaxiCode`, `MICR`, `MicroPDF`, `MSI`, `PatchCode`, `PDF417`, `Pharmacode`, `PostNet`, `PZN`, `QRCode`, `RoyalMail`, `RoyalMailKIX`, `Trioptic`, `UPCA`, `UPCE`, `UPU`. Must be a String. |
| file |  | optional. Source barcodes file. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf | optional. URL of the image or pdf file to decode barcodes from. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /barcode/read/from/url | Code: 200



```js
{
    "barcodes": [
        {
            "Value": "test123",
            "RawData": null,
            "Type": 2,
            "Rect": "{X=111,Y=60,Width=255,Height=37}",
            "Page": 0,
            "File": "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 0.90625155,
            "TypeName": "Code128"
        },
        {
            "Value": "123456",
            "RawData": null,
            "Type": 4,
            "Rect": "{X=111,Y=129,Width=306,Height=37}",
            "Page": 0,
            "File": "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 0.7710818,
            "TypeName": "Code39"
        },
        {
            "Value": "<FNC1>0112345678901231",
            "RawData": null,
            "Type": 2,
            "Rect": "{X=111,Y=198,Width=305,Height=37}",
            "Page": 0,
            "File": "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 0.9156459,
            "TypeName": "Code128"
        },
        {
            "Value": "12345670",
            "RawData": [
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                0
            ],
            "Type": 5,
            "Rect": "{X=111,Y=267,Width=182,Height=0}",
            "Page": 0,
            "File": "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 1,
            "TypeName": "I2of5"
        },
        {
            "Value": "1234567890128",
            "RawData": null,
            "Type": 6,
            "Rect": "{X=102,Y=336,Width=71,Height=72}",
            "Page": 0,
            "File": "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 0.895925164,
            "TypeName": "EAN13"
        }
    ],
    "pageCount": 1,
    "error": false,
    "status": 200,
    "remainingCredits": 98155
}
```



### 2. /barcode/read/from/url



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/barcode/read/from/url
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use JobId that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of:  `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| types | Code128,Code39,Interleaved2of5,EAN13 | optional. Comma-separated list of barcode types to decode. Valid types: `AustralianPostCode`, `Aztec`, `CircularI2of5`, `Codabar`, `CodablockF`, `Code128`, `Code16K`, `Code39`, `Code39Extended`, `Code39Mod43`, `Code39Mod43Extended`, `Code93`, `DataMatrix`, `EAN13`, `EAN2`, `EAN5`, `EAN8`, `GS1`, `GS1DataBarExpanded`, `GS1DataBarExpandedStacked`, `GS1DataBarLimited`, `GS1DataBarOmnidirectional`, `GS1DataBarStacked`, `GTIN12`, `GTIN13`, `GTIN14`, `GTIN8`, `IntelligentMail`, `Interleaved2of5`, `ITF14`, `MaxiCode`, `MICR`, `MicroPDF`, `MSI`, `PatchCode`, `PDF417`, `Pharmacode`, `PostNet`, `PZN`, `QRCode`, `RoyalMail`, `RoyalMailKIX`, `Trioptic`, `UPCA`, `UPCE`, `UPU`. Must be a String. |
| file |  | optional. Source barcodes file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf | optional. URL of the image or pdf file to decode barcodes from. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /barcode/read/from/url | Code: 200



```js
{
    "barcodes": [
        {
            "Value": "test123",
            "RawData": null,
            "Type": 2,
            "Rect": "{X=111,Y=60,Width=255,Height=37}",
            "Page": 0,
            "File": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 0.90625155,
            "TypeName": "Code128"
        },
        {
            "Value": "123456",
            "RawData": null,
            "Type": 4,
            "Rect": "{X=111,Y=129,Width=306,Height=37}",
            "Page": 0,
            "File": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 0.7710818,
            "TypeName": "Code39"
        },
        {
            "Value": "<FNC1>0112345678901231",
            "RawData": null,
            "Type": 2,
            "Rect": "{X=111,Y=198,Width=305,Height=37}",
            "Page": 0,
            "File": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 0.9156459,
            "TypeName": "Code128"
        },
        {
            "Value": "12345670",
            "RawData": [
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                0
            ],
            "Type": 5,
            "Rect": "{X=111,Y=267,Width=182,Height=0}",
            "Page": 0,
            "File": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 1,
            "TypeName": "I2of5"
        },
        {
            "Value": "1234567890128",
            "RawData": null,
            "Type": 6,
            "Rect": "{X=102,Y=336,Width=71,Height=72}",
            "Page": 0,
            "File": "https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/barcode-reader/sample.pdf",
            "Confidence": 0.895925164,
            "TypeName": "EAN13"
        }
    ],
    "pageCount": 1,
    "error": false,
    "status": 200,
    "remainingCredits": 98150
}
```



## Read PDF Information



### 1. /pdf/info


**Description:** Gets PDF document information. `GET` or `POST` request.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/info
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| file |  | optional. Source PDF file |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-info/sample.pdf | optional. URL of the source PDF file. Must be a String |
| password |  | optional. Password of PDF file. Must be a String |



***Responses:***


Status: /pdf/info | Code: 200



```js
{
    "info": {
        "PageCount": 1,
        "Author": "Alice V. Knox",
        "Title": "Kid's News 1",
        "Producer": "Acrobat Distiller 4.0 for Windows",
        "Subject": "Kid's News 1",
        "CreationDate": "8/15/2001 2:50:36 PM",
        "Bookmarks": "",
        "Keywords": "",
        "Creator": "Adobe PageMaker 6.52",
        "Encrypted": false
    },
    "error": false,
    "status": 200,
    "remainingCredits": 98611
}
```



### 2. /pdf/info



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/info
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-info/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |



***Responses:***


Status: https://api.pdf.co/v1/pdf/info | Code: 200



```js
{
    "info": {
        "PageCount": 1,
        "Author": "Alice V. Knox",
        "Title": "Kid's News 1",
        "Producer": "Acrobat Distiller 4.0 for Windows",
        "Subject": "Kid's News 1",
        "CreationDate": "8/15/2001 2:50:36 PM",
        "Bookmarks": "",
        "Keywords": "",
        "Creator": "Adobe PageMaker 6.52",
        "Encrypted": false
    },
    "error": false,
    "status": 200,
    "remainingCredits": 98612
}
```



## Render PDF to Image/PDF to JPG



### 1. /pdf/convert/to/jpg



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/jpg
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/convert/to/jpg | Code: 200



```js
{
    "urls": [
        "https://pdf-temp-files.s3.amazonaws.com/b3460e17d7724ddeaf721e4f974c9a8b/sample.jpg",
        "https://pdf-temp-files.s3.amazonaws.com/e713e84bacd342c9b26f5eb56a6a9ff4/sample.jpg"
    ],
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "sample.jpg",
    "remainingCredits": 98202
}
```



### 2. /pdf/convert/to/jpg



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/jpg
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/convert/to/jpg | Code: 200



```js
{
    "urls": [
        "https://pdf-temp-files.s3.amazonaws.com/f6e660b095ea417aa132a3264a69fdf9/sample.jpg",
        "https://pdf-temp-files.s3.amazonaws.com/de8b95b2e4484bdd8414f5f51b5d5aac/sample.jpg"
    ],
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "sample.jpg",
    "remainingCredits": 98194
}
```



## Render PDF to Image/PDF to PNG



### 1. /pdf/convert/to/png



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/png
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/convert/to/png | Code: 200



```js
{
    "urls": [
        "https://pdf-temp-files.s3.amazonaws.com/556535729d3c4d3bad262972b3fa5950/sample.png",
        "https://pdf-temp-files.s3.amazonaws.com/adb49c67f1cf4c9ca8a129a19511418e/sample.png"
    ],
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "sample.png",
    "remainingCredits": 98186
}
```



### 2. /pdf/convert/to/png



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/png
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/convert/to/png | Code: 200



```js
{
    "urls": [
        "https://pdf-temp-files.s3.amazonaws.com/e6512bf7a5d745f08a33c6f501af3b7f/sample.png",
        "https://pdf-temp-files.s3.amazonaws.com/18c9dbff950842a3b8e201f70c50932d/sample.png"
    ],
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "sample.png",
    "remainingCredits": 98178
}
```



## Render PDF to Image/PDF to TIFF



### 1. /pdf/convert/to/tiff



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/tiff
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.tiff | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/convert/to/tiff | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/a24a3a4f81c84859b34992f87b1e14bc/result.tiff",
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "result.tiff",
    "remainingCredits": 98170
}
```



### 2. /pdf/convert/to/tiff



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/convert/to/tiff
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3-us-west-2.amazonaws.com/files/demo-files/cloud-api/pdf-to-image/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| name | result.tiff | optional. File name for generated output. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String. |
| rect |  | optional. Defines coordinates for extraction, e.g. `51.8, 114.8, 235.5, 204.0`. You can use our [PDF Multitool](https://bytescout.com/download/download_freeware.html) to easily select and copy coordinates. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |



***Responses:***


Status: /pdf/convert/to/tiff | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/e6fb9be16cd14a8c94e94cdcef2afb45/result.tiff",
    "pageCount": 2,
    "error": false,
    "status": 200,
    "name": "result.tiff",
    "remainingCredits": 98162
}
```



## Render PDF to Image/URL as JPG



### 1. /url/convert/to/jpg


**Description:** Create high-quality JPEG screenshot of web page using its URL. `GET` or `POST` request.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|


***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/url/convert/to/jpg
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://www.wikipedia.org | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| width |  | optional. Must be a Integer. |
| height |  | optional. Must be a Integer. |



***Responses:***


Status: /url/convert/to/jpg | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/f663e271632447bf9e1ae151e8866bf7/www-wikipedia-org.png",
    "error": false,
    "status": 200,
    "name": "www-wikipedia-org.png",
    "remainingCredits": 98149
}
```



### 2. /url/convert/to/jpg



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/url/convert/to/jpg
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| url | https://www.wikipedia.org | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| width |  | optional. Must be a Integer. |
| height |  | optional. Must be a Integer. |



***Responses:***


Status: /url/convert/to/jpg | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/f63c6d5de65a4036b920aa8a482c8e1a/www-wikipedia-org.png",
    "error": false,
    "status": 200,
    "name": "www-wikipedia-org.png",
    "remainingCredits": 98148
}
```



## Render PDF to Image/URL as PNG



### 1. /url/convert/to/png


**Description:** Create high-quality PNG screenshot of web page using its URL. `GET` or `POST` request.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/url/convert/to/png
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://www.wikipedia.org | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| width |  | optional. Must be a Integer. |
| height |  | optional. Must be a Integer. |



***Responses:***


Status: /url/convert/to/png | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/c6c2e7ebce564fd098b0f1121010c409/www-wikipedia-org.png",
    "error": false,
    "status": 200,
    "name": "www-wikipedia-org.png",
    "remainingCredits": 98147
}
```



### 2. /url/convert/to/png


**Description:** Create high-quality PNG screenshot of web page using its URL. `GET` or `POST` request.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/url/convert/to/png
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| url | https://www.wikipedia.org | optional. URL of the source PDF file. Must be a String. |
| name |  | optional. File name for generated output. Must be a String. |
| width |  | optional. Must be a Integer. |
| height |  | optional. Must be a Integer. |



***Responses:***


Status: /url/convert/to/png | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/f8ce9eb29b234f33bb2753786f832b52/www-wikipedia-org.png",
    "error": false,
    "status": 200,
    "name": "www-wikipedia-org.png",
    "remainingCredits": 98146
}
```



## Search inside PDF or Image
**Description:** Finds text in pdf and returns coordinates. `GET` or `POST` request.

**Status Errors**

| Code	| Description|
|-- |--
|`200`| The request has succeeded|
|`400`| bad input parameters|
|`401`|	unauthorized|
|`403`|	not enough credits|
|`405`|	Timeout error. To process large documents or files please use asynchronous mode ( set `async` parameter to true) and then check the status using `/job/check` endpoint. If file contains many pages then specify a page range using pages parameter. The number of pages of the document can be obtained using the endpoint `/pdf/info`|

**Example**

Sample Request:

! Don't forget to set `x-api-key` url param or http header param (preferred) to API key, get yours [here](https://app.pdf.co/signup)


**POST**

```
{
	"password" : "",
	"pages" : "",
	"url" : "https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf",
	"searchString" : "Invoice Date \d+/\d+/\d+",
	"regexSearch" : "true"
}
```

**Response**

```
200
{
  "body": [
      {
          "text": "Invoice Date 01/01/2016",
          "left": 436.5400085449219,
          "top": 130.4599995137751,
          "width": 122.85311957550027,
          "height": 11.040000486224898,
          "pageIndex": 0,
          "bounds": {
              "location": {
                  "isEmpty": false,
                  "x": 436.54,
                  "y": 130.46
              },
              "size": "122.853119, 11.0400009",
              "x": 436.54,
              "y": 130.46,
              "width": 122.853119,
              "height": 11.0400009,
              "left": 436.54,
              "top": 130.46,
              "right": 559.3931,
              "bottom": 141.5,
              "isEmpty": false
          },
          "elementCount": 1,
          "elements": [
              {
                  "index": 0,
                  "left": 436.5400085449219,
                  "top": 130.4599995137751,
                  "width": 122.85311957550027,
                  "height": 11.040000486224898,
                  "angle": 0,
                  "text": "Invoice Date 01/01/2016",
                  "isNewLine": true,
                  "fontIsBold": true,
                  "fontIsItalic": false,
                  "fontName": "Arial",
                  "fontSize": 11,
                  "fontColor": "0, 0, 0",
                  "fontColorAsOleColor": 0,
                  "fontColorAsHtmlColor": "#000000",
                  "bounds": {
                      "location": {
                          "isEmpty": false,
                          "x": 436.54,
                          "y": 130.46
                      },
                      "size": "122.853119, 11.0400009",
                      "x": 436.54,
                      "y": 130.46,
                      "width": 122.853119,
                      "height": 11.0400009,
                      "left": 436.54,
                      "top": 130.46,
                      "right": 559.3931,
                      "bottom": 141.5,
                      "isEmpty": false
                  }
              }
          ]
      }
  ],
  "pageCount": 1,
  "error": false,
  "status": 200,
  "name": "sample.json",
  "remainingCredits": 998
}
```



### 1. /pdf/find



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/find
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source PDF file. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| searchString | Invoice Date \d+/\d+/\d+ | required. Source PDF file. |
| name |  | optional. File name for generated output. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| inline |  | optional. Must be one of: `true`, `false`. |
| wordMatchingMode |  | optional. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String |
| regexSearch | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /pdf/find | Code: 200



```js
{
    "body": [
        {
            "text": "Invoice Date 01/01/2016",
            "left": 436.5400085449219,
            "top": 130.4599995137751,
            "width": 122.85311957550027,
            "height": 11.040000486224898,
            "pageIndex": 0,
            "bounds": {
                "location": {
                    "isEmpty": false,
                    "x": 436.54,
                    "y": 130.46
                },
                "size": "122.853119, 11.0400009",
                "x": 436.54,
                "y": 130.46,
                "width": 122.853119,
                "height": 11.0400009,
                "left": 436.54,
                "top": 130.46,
                "right": 559.3931,
                "bottom": 141.5,
                "isEmpty": false
            },
            "elementCount": 1,
            "elements": [
                {
                    "index": 0,
                    "left": 436.5400085449219,
                    "top": 130.4599995137751,
                    "width": 122.85311957550027,
                    "height": 11.040000486224898,
                    "angle": 0,
                    "text": "Invoice Date 01/01/2016",
                    "isNewLine": true,
                    "fontIsBold": true,
                    "fontIsItalic": false,
                    "fontName": "Arial",
                    "fontSize": 11,
                    "fontColor": "0, 0, 0",
                    "fontColorAsOleColor": 0,
                    "fontColorAsHtmlColor": "#000000",
                    "bounds": {
                        "location": {
                            "isEmpty": false,
                            "x": 436.54,
                            "y": 130.46
                        },
                        "size": "122.853119, 11.0400009",
                        "x": 436.54,
                        "y": 130.46,
                        "width": 122.853119,
                        "height": 11.0400009,
                        "left": 436.54,
                        "top": 130.46,
                        "right": 559.3931,
                        "bottom": 141.5,
                        "isEmpty": false
                    }
                }
            ]
        }
    ],
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "sample.json",
    "remainingCredits": 98582
}
```



### 2. /pdf/find



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/pdf/find
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| async |  | optional. Runs processing asynchronously. Returns Use `JobId` that you may use with `/job/check` to check state of the processing (possible states: `working`, `failed`, `aborted` and `success`). Must be one of: `true`, `false`. |
| encrypt |  | optional. Enable encryption for output file. Must be one of: `true`, `false`. |
| file |  | optional. Source file. For large files please upload files using file uploading endpoints in this API first and use "url" field |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-to-text/sample.pdf | optional. URL of the source PDF file. Must be a String. |
| searchString | Invoice Date \d+/\d+/\d+ | required. Source PDF file. |
| name |  | optional. File name for generated output. Must be a String. |
| pages |  | optional. Comma-separated list of page indices (or ranges) to process. IMPORTANT: the very first page starts at `0` (zero). To set a range use the dash `-`, for example: `0,2-5,7-`. To set a range from index to the last page use range like this: `2-` (from page #3 as the index starts at zero and till the of the document). For ALL pages just leave this param empty. Example: `0,2-5,7-` means first page, then 3rd page to 6th page, and then the range from 8th (index = `7`) page till the end of the document. Must be a String. |
| inline |  | optional. Must be one of: `true`, `false`. |
| wordMatchingMode |  | optional. Must be a String. |
| password |  | optional. Password of PDF file. Must be a String |
| regexSearch | true | optional. Must be one of: `true`, `false`. |



***Responses:***


Status: /pdf/find | Code: 200



```js
{
    "body": [
        {
            "text": "Invoice Date 01/01/2016",
            "left": 436.5400085449219,
            "top": 130.4599995137751,
            "width": 122.85311957550027,
            "height": 11.040000486224898,
            "pageIndex": 0,
            "bounds": {
                "location": {
                    "isEmpty": false,
                    "x": 436.54,
                    "y": 130.46
                },
                "size": "122.853119, 11.0400009",
                "x": 436.54,
                "y": 130.46,
                "width": 122.853119,
                "height": 11.0400009,
                "left": 436.54,
                "top": 130.46,
                "right": 559.3931,
                "bottom": 141.5,
                "isEmpty": false
            },
            "elementCount": 1,
            "elements": [
                {
                    "index": 0,
                    "left": 436.5400085449219,
                    "top": 130.4599995137751,
                    "width": 122.85311957550027,
                    "height": 11.040000486224898,
                    "angle": 0,
                    "text": "Invoice Date 01/01/2016",
                    "isNewLine": true,
                    "fontIsBold": true,
                    "fontIsItalic": false,
                    "fontName": "Arial",
                    "fontSize": 11,
                    "fontColor": "0, 0, 0",
                    "fontColorAsOleColor": 0,
                    "fontColorAsHtmlColor": "#000000",
                    "bounds": {
                        "location": {
                            "isEmpty": false,
                            "x": 436.54,
                            "y": 130.46
                        },
                        "size": "122.853119, 11.0400009",
                        "x": 436.54,
                        "y": 130.46,
                        "width": 122.853119,
                        "height": 11.0400009,
                        "left": 436.54,
                        "top": 130.46,
                        "right": 559.3931,
                        "bottom": 141.5,
                        "isEmpty": false
                    }
                }
            ]
        }
    ],
    "pageCount": 1,
    "error": false,
    "status": 200,
    "name": "sample.json",
    "remainingCredits": 98577
}
```



## Upload Files/Calculate Hash



### 1. /file/hash



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/file/hash
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| file |  | optional. Source file to calculate hash. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the file to calculate hash. Must be a String. |



***Responses:***


Status: /file/hash | Code: 200



```js
{
    "hash": "d942e5becdcb0386598cce15e9e56deb1ca9d893b8578a88eca4a62f02c4000b",
    "remainingCredits": 98144
}
```



### 2. /file/hash



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/file/hash
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| file |  | optional. Source file to calculate hash. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | optional. URL of the file to calculate hash. Must be a String. |



***Responses:***


Status: /file/hash | Code: 200



```js
{
    "hash": "d942e5becdcb0386598cce15e9e56deb1ca9d893b8578a88eca4a62f02c4000b",
    "remainingCredits": 98143
}
```



## Upload Files/From Base64



### 1. /file/upload/base64



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/file/upload/base64
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| name | custom name | optional. The name the file will be stored with. Must be a String. |
| file | data:image/gif;base64,R0lGODlhEAAQAPUtACIiIScnJigoJywsLDIyMjMzMzU1NTc3Nzg4ODk5OTs7Ozw8PEJCQlBQUFRUVFVVVVhYWG1tbXt7fInDRYvESYzFSo/HT5LJVJPJVJTKV5XKWJbKWZbLWpfLW5jLXJrMYaLRbaTScKXScKXScafTdIGBgYODg6alprLYhbvekr3elr3el9Dotf///wAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACH5BAAAAAAAIf8LSW1hZ2VNYWdpY2sNZ2FtbWE9MC40NTQ1NQAsAAAAABAAEAAABpJAFGgkKhpFIRHpw2qBLJiLdCrNTFKt0wjD2Xi/G09l1ZIwRJeNZs3uUFQtEwCCVrM1bnhJYHDU73ktJQELBH5pbW+CAQoIhn94ioMKB46HaoGTB5WPaZmMm5wOIRcekqChliIZFXqoqYYkE2SaoZuWH1gmAgsIvr8ICQUPTRIABgTJyskFAw1ZDBAO09TUDw0RQQA7 | required. Base64-encoded file bytes. Must be a String. |



***Responses:***


Status: https://api.pdf.co/v1/file/upload/base64 | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/a8ac8a3cec3344f08f556bfd2d678b2f/uploadfile.txt",
    "error": false,
    "status": 200,
    "remainingCredits": 98145
}
```



## Upload Files/From Local File



### 1. /file/upload/url



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/file/upload
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| name |  | optional. The name the file will be stored with. Must be a String. |
| file |  | required. Local file should be selected |



***Responses:***


Status: /file/upload/url | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/1a4a92ac805c41c28ef75a24e0f35ba5/sample.pdf",
    "error": false,
    "status": 200,
    "name": "sample.pdf",
    "remainingCredits": 98145
}
```



## Upload Files/From URL



### 1. /file/upload/url



***Endpoint:***

```bash
Method: POST
Type: FORMDATA
URL: https://api.pdf.co/v1/file/upload/url
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| name |  | optional. The name the file will be stored with. Must be a String. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | required. URL of the file to upload. Must be a String. |



***Responses:***


Status: /file/upload/url | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/1a4a92ac805c41c28ef75a24e0f35ba5/sample.pdf",
    "error": false,
    "status": 200,
    "name": "sample.pdf",
    "remainingCredits": 98145
}
```



### 2. /file/upload/url



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/file/upload/url
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Body:***

| Key | Value | Description |
| --- | ------|-------------|
| name |  | optional. The name the file will be stored with. Must be a String. |
| url | https://bytescout-com.s3.amazonaws.com/files/demo-files/cloud-api/pdf-split/sample.pdf | required. URL of the file to upload. Must be a String. |



***Responses:***


Status: /file/upload/url | Code: 200



```js
{
    "url": "https://pdf-temp-files.s3.amazonaws.com/703aa298cfe745baa3449fbdaba4d1d7/sample.pdf",
    "error": false,
    "status": 200,
    "name": "sample.pdf",
    "remainingCredits": 98145
}
```



## Upload Files/Presigned URL (recommended)



### 1. /file/upload/get-presigned-url



***Endpoint:***

```bash
Method: GET
Type: FORMDATA
URL: https://api.pdf.co/v1/file/upload/get-presigned-url
```


***Headers:***

| Key | Value | Description |
| --- | ------|-------------|
| Content-Type | application/json |  |
| x-api-key | {{x-api-key}} |  |



***Query params:***

| Key | Value | Description |
| --- | ------|-------------|
| name | test.pdf | The name the file will be stored with. Must be a String. |
| encrypt | true | Enable encryption for output file. Must be one of: `true`, `false`. |



***Responses:***


Status: /file/upload/get-presigned-url | Code: 200



```js
{
    "presignedUrl": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/0c72bf56341142ba83c8f98b47f14d62/test.pdf?X-Amz-Expires=900&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAIZJDPLX6D7EHVCKA/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T143951Z&X-Amz-SignedHeaders=host&X-Amz-Signature=8650913644b6425ba8d52b78634698e5fc8970157d971a96f0279a64f4ba87fc",
    "url": "https://pdf-temp-files.s3-us-west-2.amazonaws.com/0c72bf56341142ba83c8f98b47f14d62/test.pdf?X-Amz-Expires=3600&x-amz-security-token=FwoGZXIvYXdzEGgaDA9KaTOXRjkCdCqSTCKBAW9tReCLk1fVTZBH9exl9VIbP8Gfp1pE9hg6et94IBpNamOaBJ6%2B9Vsa5zxfiddlgA%2BxQ4tpd9gprFAxMzjN7UtjU%2B2gf%2FKbUKc2lfV18D2wXKd1FEhC6kkGJVL5UaoFONG%2Fw2jXfLxe3nCfquMEDo12XzcqIQtNFWXjKPWBkQEvmii4tfTyBTIot4Na%2BAUqkLshH0R7HVKlEBV8btqa0ctBjwzwpWkoU%2BF%2BCtnm8Lm4Eg%3D%3D&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIA4NRRSZPHEGHTOA4W/20200302/us-west-2/s3/aws4_request&X-Amz-Date=20200302T143951Z&X-Amz-SignedHeaders=host;x-amz-security-token&X-Amz-Signature=243419ac4a9a315eebc2db72df0817de6a261a684482bbc897f0e7bb5d202bb9",
    "error": false,
    "status": 200,
    "name": "test.pdf",
    "remainingCredits": 98145
}
```



---
[Back to top](#pdfco-api-v1)
> Made with &#9829; by [thedevsaddam](https://github.com/thedevsaddam) | Generated at: 2020-04-09 21:12:08 by [docgen](https://github.com/thedevsaddam/docgen)
