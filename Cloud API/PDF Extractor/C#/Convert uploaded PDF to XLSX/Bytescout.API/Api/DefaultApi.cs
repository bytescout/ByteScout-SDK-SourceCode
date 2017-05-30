using System;
using System.Collections.Generic;
using RestSharp;
using Bytescout.Api.Client;
using Bytescout.Api.Model;

namespace Bytescout.Api.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        /// <summary>
        ///  Barcode generation via GET request.
        /// </summary>
        /// <param name="name">Filename for the generated image.</param>
        /// <param name="type">Barcode type. Valid values: Code128, Code39, Postnet, UPCA, EAN8, ISBN, Codabar, I2of5, Code93, EAN13, JAN13, Bookland, UPCE, PDF417, PDF417Truncated, DataMatrix, QRCode, Aztec, Planet, EAN128, GS1_128, USPSSackLabel, USPSTrayLabel, DeutschePostIdentcode, DeutschePostLeitcode, Numly, PZN, OpticalProduct, SwissPostParcel, RoyalMail, DutchKix, SingaporePostalCode, EAN2, EAN5, EAN14, MacroPDF417, MicroPDF417, GS1_DataMatrix, Telepen, IntelligentMail, GS1_DataBar_Omnidirectional, GS1_DataBar_Truncated, GS1_DataBar_Stacked, GS1_DataBar_Stacked_Omnidirectional, GS1_DataBar_Limited, GS1_DataBar_Expanded, GS1_DataBar_Expanded_Stacked, MaxiCode, Plessey, MSI, ITF14, GTIN12, GTIN8, GTIN13, GTIN14.</param>
        /// <param name="value">Barcode value.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel BarcodeGenerateGet (string name, string type, string value);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty BarcodeGenerateOptions ();
        /// <summary>
        ///  Barcode generation via POST request.
        /// </summary>
        /// <param name="name">Filename for the generated image.</param>
        /// <param name="type">Barcode type. Valid values: Code128, Code39, Postnet, UPCA, EAN8, ISBN, Codabar, I2of5, Code93, EAN13, JAN13, Bookland, UPCE, PDF417, PDF417Truncated, DataMatrix, QRCode, Aztec, Planet, EAN128, GS1_128, USPSSackLabel, USPSTrayLabel, DeutschePostIdentcode, DeutschePostLeitcode, Numly, PZN, OpticalProduct, SwissPostParcel, RoyalMail, DutchKix, SingaporePostalCode, EAN2, EAN5, EAN14, MacroPDF417, MicroPDF417, GS1_DataMatrix, Telepen, IntelligentMail, GS1_DataBar_Omnidirectional, GS1_DataBar_Truncated, GS1_DataBar_Stacked, GS1_DataBar_Stacked_Omnidirectional, GS1_DataBar_Limited, GS1_DataBar_Expanded, GS1_DataBar_Expanded_Stacked, MaxiCode, Plessey, MSI, ITF14, GTIN12, GTIN8, GTIN13, GTIN14.</param>
        /// <param name="value">Barcode value.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel BarcodeGeneratePost (string name, string type, string value);
        /// <summary>
        ///  Read barcodes via GET request.
        /// </summary>
        /// <param name="types">Comma-separated list of barcode types to decode. Valid types: AustralianPostCode, Aztec, CircularI2of5, Codabar, CodablockF, Code128, Code16K, Code39, Code39Extended, Code39Mod43, Code39Mod43Extended, Code93, DataMatrix, EAN13, EAN2, EAN5, EAN8, GS1, GS1DataBarExpanded, GS1DataBarExpandedStacked, GS1DataBarLimited, GS1DataBarOmnidirectional, GS1DataBarStacked, GTIN12, GTIN13, GTIN14, GTIN8, IntelligentMail, Interleaved2of5, ITF14, MaxiCode, MICR, MicroPDF, MSI, PatchCode, PDF417, Pharmacode, PostNet, PZN, QRCode, RoyalMail, RoyalMailKIX, Trioptic, UPCA, UPCE, UPU.</param>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="url">URL of the image to decode barcodes from.</param>
        /// <returns>BarcodeReaderResponseModel</returns>
        BarcodeReaderResponseModel BarcodeReadFromUrlGet (string types, string pages, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty BarcodeReadFromUrlOptions ();
        /// <summary>
        ///  Read barcodes via POST request.
        /// </summary>
        /// <param name="types">Comma-separated list of barcode types to decode. Valid types: AustralianPostCode, Aztec, CircularI2of5, Codabar, CodablockF, Code128, Code16K, Code39, Code39Extended, Code39Mod43, Code39Mod43Extended, Code93, DataMatrix, EAN13, EAN2, EAN5, EAN8, GS1, GS1DataBarExpanded, GS1DataBarExpandedStacked, GS1DataBarLimited, GS1DataBarOmnidirectional, GS1DataBarStacked, GTIN12, GTIN13, GTIN14, GTIN8, IntelligentMail, Interleaved2of5, ITF14, MaxiCode, MICR, MicroPDF, MSI, PatchCode, PDF417, Pharmacode, PostNet, PZN, QRCode, RoyalMail, RoyalMailKIX, Trioptic, UPCA, UPCE, UPU.</param>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="url">URL of the image to decode barcodes from.</param>
        /// <returns>BarcodeReaderResponseModel</returns>
        BarcodeReaderResponseModel BarcodeReadFromUrlPost (string types, string pages, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty FileUploadBase64Options ();
        /// <summary>
        ///  Upload a file to the cloud to use in other API methods. Uploaded files are automatically deleted after 1 hour.
        /// </summary>
        /// <param name="fileUploadBase64RequestModel"></param>
        /// <param name="name">The name the file will be stored with.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel FileUploadBase64Post (FileUploadBase64RequestModel fileUploadBase64RequestModel, string name);
        /// <summary>
        ///  Gets preassigned URL for binary file upload to the cloud to use in other API methods. Uploaded files are automatically deleted after 1 hour.
        /// </summary>
        /// <param name="contenttype">Content-Type describing the data contained in the request body, Use &#39;binary/octet-stream&#39;.</param>
        /// <param name="name">The name the file will be stored with.</param>
        /// <returns>PresignedUrlResponseModel</returns>
        PresignedUrlResponseModel FileUploadGetPresignedUrlGet (string contenttype, string name);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty FileUploadGetPresignedUrlOptions ();
        /// <summary>
        ///  CSV to PDF conversion via GET request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param>
        /// <param name="url">URL of the source CSV file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertFromCsvGet (string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertFromCsvOptions ();
        /// <summary>
        ///  CSV to PDF conversion via POST request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param>
        /// <param name="url">URL of the source CSV file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertFromCsvPost (string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertFromHtmlOptions ();
        /// <summary>
        ///  HTML to PDF conversion via POST request.
        /// </summary>
        /// <param name="text">HTML data to convert to PDF.</param>
        /// <param name="name">File name for the generated result.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertFromHtmlPost (Text text, string name);
        /// <summary>
        ///  Image to PDF conversion via GET request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param>
        /// <param name="url">URL of the source image file.</param>
        /// <returns>JobSingleResponseModel</returns>
        JobSingleResponseModel PdfConvertFromImageGet (string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertFromImageOptions ();
        /// <summary>
        ///  Image to PDF conversion via POST request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param>
        /// <param name="url">URL of the source image file.</param>
        /// <returns>JobSingleResponseModel</returns>
        JobSingleResponseModel PdfConvertFromImagePost (string name, string url);
        /// <summary>
        ///  Saves a web page to PDF document via GET request.
        /// </summary>
        /// <param name="url">URL of the web page to be saved as PDF document.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertFromUrlGet (string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertFromUrlOptions ();
        /// <summary>
        ///  Saves a web page to PDF document via POST request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param>
        /// <param name="url">URL of the web page to be saved as PDF document.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertFromUrlPost (string name, string url);
        /// <summary>
        ///  PDF to CSV conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToCsvGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToCsvOptions ();
        /// <summary>
        ///  PDF to CSV conversion via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToCsvPost (string pages, string name, string url);
        /// <summary>
        ///  PDF to DOCX conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToDocxGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToDocxOptions ();
        /// <summary>
        ///  PDF to DOCX conversion via POST request.
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToDocxPost (string pages, string name, string url);
        /// <summary>
        ///  PDF to HTML conversion via GET request.
        /// </summary>
        /// <param name="simple">Set &#39;true&#39; to convert to a plain HTML format. Default is the rich HTML &amp; CSS format keeping the document design.</param>
        /// <param name="columns">Set &#39;true&#39; if the PDF document is arranged in columns like a newspaper. Default is &#39;false&#39;.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <param name="name">File name for generated result.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToHtmlGet (string simple, string columns, string url, string name);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToHtmlOptions ();
        /// <summary>
        ///  PDF to HTML conversion via POST request.
        /// </summary>
        /// <param name="simple">Set &#39;true&#39; to convert to a plain HTML format. Default is the rich HTML &amp; CSS format keeping the document design.</param>
        /// <param name="columns">Set &#39;true&#39; if the PDF document is arranged in columns like a newspaper. Default is &#39;false&#39;.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <param name="name">File name for generated result.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToHtmlPost (string simple, string columns, string url, string name);
        /// <summary>
        ///  PDF to JPEG image conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>MultiResponseModel</returns>
        MultiResponseModel PdfConvertToJpgGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToJpgOptions ();
        /// <summary>
        ///  PDF to JPEG image conversion via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>MultiResponseModel</returns>
        MultiResponseModel PdfConvertToJpgPost (string pages, string name, string url);
        /// <summary>
        ///  PDF to JSON conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToJsonGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToJsonOptions ();
        /// <summary>
        ///  PDF to JSON conversion get view POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToJsonPost (string pages, string name, string url);
        /// <summary>
        ///  PDF to PNG image conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>MultiResponseModel</returns>
        MultiResponseModel PdfConvertToPngGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToPngOptions ();
        /// <summary>
        ///  PDF to PNG image conversion convert via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>MultiResponseModel</returns>
        MultiResponseModel PdfConvertToPngPost (string pages, string name, string url);
        /// <summary>
        ///  PDF to plain text conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToTextGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToTextOptions ();
        /// <summary>
        ///  PDF to plain text conversion via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToTextPost (string pages, string name, string url);
        /// <summary>
        ///  PDF to TIFF image (single or multi-page) conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToTiffGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToTiffOptions ();
        /// <summary>
        ///  PDF to TIFF image (single or multi-page) conversion via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToTiffPost (string pages, string name, string url);
        /// <summary>
        ///  PDF to XLS conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToXlsGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToXlsOptions ();
        /// <summary>
        ///  PDF to XLS conversion via POST request.
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToXlsPost (string pages, string name, string url);
        /// <summary>
        ///  PDF to XLSX conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToXlsxGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfConvertToXlsxOptions ();
        /// <summary>
        ///  PDF to XLSX conversion via POST request.
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfConvertToXlsxPost (string pages, string name, string url);
        /// <summary>
        ///  Gets PDF document information via GET request.
        /// </summary>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>PdfInfoResponseModel</returns>
        PdfInfoResponseModel PdfInfoGet (string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfInfoOptions ();
        /// <summary>
        ///  Gets PDF document information via POST request.
        /// </summary>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>PdfInfoResponseModel</returns>
        PdfInfoResponseModel PdfInfoPost (string url);
        /// <summary>
        ///  Merge two PDF documents via GET request.
        /// </summary>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">Comma-separated list of URLs of source PDF files.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfMergeGet (string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfMergeOptions ();
        /// <summary>
        ///  Merge two PDF documents via POST request.
        /// </summary>
        /// <param name="name">File name for generated result.</param>
        /// <param name="url">Comma-separated list of URLs of source PDF files.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfMergePost (string name, string url);
        /// <summary>
        ///  Sign PDF document via GET request.
        /// </summary>
        /// <param name="width">Width of the signature in PDF Points (1/72 in.).</param>
        /// <param name="text"></param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <param name="name">File name for generated result.</param>
        /// <param name="type"></param>
        /// <param name="y">Y coordinate of the signature in PDF Points (1/72 in.).</param>
        /// <param name="fontname"></param>
        /// <param name="x">X coordinate of the signature in PDF Points (1/72 in.).</param>
        /// <param name="height">Height of the signature in PDF Points (1/72 in.).</param>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="color"></param>
        /// <param name="urlimage">URL of the signature image file.</param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfSignGet (string width, string text, string url, string name, string type, string y, string fontname, string x, string height, string pages, string color, string urlimage);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfSignOptions ();
        /// <summary>
        ///  Sign PDF document via POST request.
        /// </summary>
        /// <param name="pdfSignRequestModel"></param>
        /// <returns>SingleResponseModel</returns>
        SingleResponseModel PdfSignPost (PdfSignRequestModel pdfSignRequestModel);
        /// <summary>
        ///  Split PDF document via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to split to. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">Base file name for generated result files.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>MultiResponseModel</returns>
        MultiResponseModel PdfSplitGet (string pages, string name, string url);
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>
        Empty PdfSplitOptions ();
        /// <summary>
        ///  Split PDF document via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to split to. Example: &#39;0,2-5,7-&#39;.</param>
        /// <param name="name">Base file name for generated result files.</param>
        /// <param name="url">URL of the source PDF file.</param>
        /// <returns>MultiResponseModel</returns>
        MultiResponseModel PdfSplitPost (string pages, string name, string url);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Barcode generation via GET request.
        /// </summary>
        /// <param name="name">Filename for the generated image.</param> 
        /// <param name="type">Barcode type. Valid values: Code128, Code39, Postnet, UPCA, EAN8, ISBN, Codabar, I2of5, Code93, EAN13, JAN13, Bookland, UPCE, PDF417, PDF417Truncated, DataMatrix, QRCode, Aztec, Planet, EAN128, GS1_128, USPSSackLabel, USPSTrayLabel, DeutschePostIdentcode, DeutschePostLeitcode, Numly, PZN, OpticalProduct, SwissPostParcel, RoyalMail, DutchKix, SingaporePostalCode, EAN2, EAN5, EAN14, MacroPDF417, MicroPDF417, GS1_DataMatrix, Telepen, IntelligentMail, GS1_DataBar_Omnidirectional, GS1_DataBar_Truncated, GS1_DataBar_Stacked, GS1_DataBar_Stacked_Omnidirectional, GS1_DataBar_Limited, GS1_DataBar_Expanded, GS1_DataBar_Expanded_Stacked, MaxiCode, Plessey, MSI, ITF14, GTIN12, GTIN8, GTIN13, GTIN14.</param> 
        /// <param name="value">Barcode value.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel BarcodeGenerateGet (string name, string type, string value)
        {
            
    
            var path = "/barcode/generate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeGenerateGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeGenerateGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty BarcodeGenerateOptions ()
        {
            
    
            var path = "/barcode/generate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeGenerateOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeGenerateOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Barcode generation via POST request.
        /// </summary>
        /// <param name="name">Filename for the generated image.</param> 
        /// <param name="type">Barcode type. Valid values: Code128, Code39, Postnet, UPCA, EAN8, ISBN, Codabar, I2of5, Code93, EAN13, JAN13, Bookland, UPCE, PDF417, PDF417Truncated, DataMatrix, QRCode, Aztec, Planet, EAN128, GS1_128, USPSSackLabel, USPSTrayLabel, DeutschePostIdentcode, DeutschePostLeitcode, Numly, PZN, OpticalProduct, SwissPostParcel, RoyalMail, DutchKix, SingaporePostalCode, EAN2, EAN5, EAN14, MacroPDF417, MicroPDF417, GS1_DataMatrix, Telepen, IntelligentMail, GS1_DataBar_Omnidirectional, GS1_DataBar_Truncated, GS1_DataBar_Stacked, GS1_DataBar_Stacked_Omnidirectional, GS1_DataBar_Limited, GS1_DataBar_Expanded, GS1_DataBar_Expanded_Stacked, MaxiCode, Plessey, MSI, ITF14, GTIN12, GTIN8, GTIN13, GTIN14.</param> 
        /// <param name="value">Barcode value.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel BarcodeGeneratePost (string name, string type, string value)
        {
            
    
            var path = "/barcode/generate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeGeneratePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeGeneratePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  Read barcodes via GET request.
        /// </summary>
        /// <param name="types">Comma-separated list of barcode types to decode. Valid types: AustralianPostCode, Aztec, CircularI2of5, Codabar, CodablockF, Code128, Code16K, Code39, Code39Extended, Code39Mod43, Code39Mod43Extended, Code93, DataMatrix, EAN13, EAN2, EAN5, EAN8, GS1, GS1DataBarExpanded, GS1DataBarExpandedStacked, GS1DataBarLimited, GS1DataBarOmnidirectional, GS1DataBarStacked, GTIN12, GTIN13, GTIN14, GTIN8, IntelligentMail, Interleaved2of5, ITF14, MaxiCode, MICR, MicroPDF, MSI, PatchCode, PDF417, Pharmacode, PostNet, PZN, QRCode, RoyalMail, RoyalMailKIX, Trioptic, UPCA, UPCE, UPU.</param> 
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="url">URL of the image to decode barcodes from.</param> 
        /// <returns>BarcodeReaderResponseModel</returns>            
        public BarcodeReaderResponseModel BarcodeReadFromUrlGet (string types, string pages, string url)
        {
            
    
            var path = "/barcode/read/from/url";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (types != null) queryParams.Add("types", ApiClient.ParameterToString(types)); // query parameter
 if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeReadFromUrlGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeReadFromUrlGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BarcodeReaderResponseModel) ApiClient.Deserialize(response.Content, typeof(BarcodeReaderResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty BarcodeReadFromUrlOptions ()
        {
            
    
            var path = "/barcode/read/from/url";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeReadFromUrlOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeReadFromUrlOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Read barcodes via POST request.
        /// </summary>
        /// <param name="types">Comma-separated list of barcode types to decode. Valid types: AustralianPostCode, Aztec, CircularI2of5, Codabar, CodablockF, Code128, Code16K, Code39, Code39Extended, Code39Mod43, Code39Mod43Extended, Code93, DataMatrix, EAN13, EAN2, EAN5, EAN8, GS1, GS1DataBarExpanded, GS1DataBarExpandedStacked, GS1DataBarLimited, GS1DataBarOmnidirectional, GS1DataBarStacked, GTIN12, GTIN13, GTIN14, GTIN8, IntelligentMail, Interleaved2of5, ITF14, MaxiCode, MICR, MicroPDF, MSI, PatchCode, PDF417, Pharmacode, PostNet, PZN, QRCode, RoyalMail, RoyalMailKIX, Trioptic, UPCA, UPCE, UPU.</param> 
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="url">URL of the image to decode barcodes from.</param> 
        /// <returns>BarcodeReaderResponseModel</returns>            
        public BarcodeReaderResponseModel BarcodeReadFromUrlPost (string types, string pages, string url)
        {
            
    
            var path = "/barcode/read/from/url";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (types != null) queryParams.Add("types", ApiClient.ParameterToString(types)); // query parameter
 if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeReadFromUrlPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BarcodeReadFromUrlPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BarcodeReaderResponseModel) ApiClient.Deserialize(response.Content, typeof(BarcodeReaderResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty FileUploadBase64Options ()
        {
            
    
            var path = "/file/upload/base64";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FileUploadBase64Options: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FileUploadBase64Options: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Upload a file to the cloud to use in other API methods. Uploaded files are automatically deleted after 1 hour.
        /// </summary>
        /// <param name="fileUploadBase64RequestModel"></param> 
        /// <param name="name">The name the file will be stored with.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel FileUploadBase64Post (FileUploadBase64RequestModel fileUploadBase64RequestModel, string name)
        {
            
            // verify the required parameter 'fileUploadBase64RequestModel' is set
            if (fileUploadBase64RequestModel == null) throw new ApiException(400, "Missing required parameter 'fileUploadBase64RequestModel' when calling FileUploadBase64Post");
            
    
            var path = "/file/upload/base64";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                    postBody = ApiClient.Serialize(fileUploadBase64RequestModel); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FileUploadBase64Post: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FileUploadBase64Post: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  Gets preassigned URL for binary file upload to the cloud to use in other API methods. Uploaded files are automatically deleted after 1 hour.
        /// </summary>
        /// <param name="contenttype">Content-Type describing the data contained in the request body, Use &#39;binary/octet-stream&#39;.</param> 
        /// <param name="name">The name the file will be stored with.</param> 
        /// <returns>PresignedUrlResponseModel</returns>            
        public PresignedUrlResponseModel FileUploadGetPresignedUrlGet (string contenttype, string name)
        {
            
    
            var path = "/file/upload/get-presigned-url";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (contenttype != null) queryParams.Add("contenttype", ApiClient.ParameterToString(contenttype)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FileUploadGetPresignedUrlGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FileUploadGetPresignedUrlGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PresignedUrlResponseModel) ApiClient.Deserialize(response.Content, typeof(PresignedUrlResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty FileUploadGetPresignedUrlOptions ()
        {
            
    
            var path = "/file/upload/get-presigned-url";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FileUploadGetPresignedUrlOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FileUploadGetPresignedUrlOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  CSV to PDF conversion via GET request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param> 
        /// <param name="url">URL of the source CSV file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertFromCsvGet (string name, string url)
        {
            
    
            var path = "/pdf/convert/from/csv";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromCsvGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertFromCsvOptions ()
        {
            
    
            var path = "/pdf/convert/from/csv";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromCsvOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromCsvOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  CSV to PDF conversion via POST request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param> 
        /// <param name="url">URL of the source CSV file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertFromCsvPost (string name, string url)
        {
            
    
            var path = "/pdf/convert/from/csv";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromCsvPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromCsvPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertFromHtmlOptions ()
        {
            
    
            var path = "/pdf/convert/from/html";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromHtmlOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromHtmlOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  HTML to PDF conversion via POST request.
        /// </summary>
        /// <param name="text">HTML data to convert to PDF.</param> 
        /// <param name="name">File name for the generated result.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertFromHtmlPost (Text text, string name)
        {
            
            // verify the required parameter 'text' is set
            if (text == null) throw new ApiException(400, "Missing required parameter 'text' when calling PdfConvertFromHtmlPost");
            
    
            var path = "/pdf/convert/from/html";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                    postBody = ApiClient.Serialize(text); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromHtmlPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromHtmlPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  Image to PDF conversion via GET request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param> 
        /// <param name="url">URL of the source image file.</param> 
        /// <returns>JobSingleResponseModel</returns>            
        public JobSingleResponseModel PdfConvertFromImageGet (string name, string url)
        {
            
    
            var path = "/pdf/convert/from/image";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromImageGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromImageGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JobSingleResponseModel) ApiClient.Deserialize(response.Content, typeof(JobSingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertFromImageOptions ()
        {
            
    
            var path = "/pdf/convert/from/image";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromImageOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromImageOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Image to PDF conversion via POST request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param> 
        /// <param name="url">URL of the source image file.</param> 
        /// <returns>JobSingleResponseModel</returns>            
        public JobSingleResponseModel PdfConvertFromImagePost (string name, string url)
        {
            
    
            var path = "/pdf/convert/from/image";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromImagePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromImagePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JobSingleResponseModel) ApiClient.Deserialize(response.Content, typeof(JobSingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  Saves a web page to PDF document via GET request.
        /// </summary>
        /// <param name="url">URL of the web page to be saved as PDF document.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertFromUrlGet (string url)
        {
            
    
            var path = "/pdf/convert/from/url";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromUrlGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromUrlGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertFromUrlOptions ()
        {
            
    
            var path = "/pdf/convert/from/url";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromUrlOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromUrlOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Saves a web page to PDF document via POST request.
        /// </summary>
        /// <param name="name">File name for the generated result.</param> 
        /// <param name="url">URL of the web page to be saved as PDF document.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertFromUrlPost (string name, string url)
        {
            
    
            var path = "/pdf/convert/from/url";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromUrlPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertFromUrlPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to CSV conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToCsvGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/csv";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToCsvGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToCsvOptions ()
        {
            
    
            var path = "/pdf/convert/to/csv";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToCsvOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToCsvOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to CSV conversion via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToCsvPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/csv";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToCsvPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToCsvPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to DOCX conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToDocxGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/docx";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToDocxGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToDocxGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToDocxOptions ()
        {
            
    
            var path = "/pdf/convert/to/docx";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToDocxOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToDocxOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to DOCX conversion via POST request.
        /// </summary>
        /// <param name="pages"></param> 
        /// <param name="name"></param> 
        /// <param name="url"></param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToDocxPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/docx";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToDocxPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToDocxPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to HTML conversion via GET request.
        /// </summary>
        /// <param name="simple">Set &#39;true&#39; to convert to a plain HTML format. Default is the rich HTML &amp; CSS format keeping the document design.</param> 
        /// <param name="columns">Set &#39;true&#39; if the PDF document is arranged in columns like a newspaper. Default is &#39;false&#39;.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToHtmlGet (string simple, string columns, string url, string name)
        {
            
    
            var path = "/pdf/convert/to/html";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (simple != null) queryParams.Add("simple", ApiClient.ParameterToString(simple)); // query parameter
 if (columns != null) queryParams.Add("columns", ApiClient.ParameterToString(columns)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToHtmlGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToHtmlGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToHtmlOptions ()
        {
            
    
            var path = "/pdf/convert/to/html";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToHtmlOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToHtmlOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to HTML conversion via POST request.
        /// </summary>
        /// <param name="simple">Set &#39;true&#39; to convert to a plain HTML format. Default is the rich HTML &amp; CSS format keeping the document design.</param> 
        /// <param name="columns">Set &#39;true&#39; if the PDF document is arranged in columns like a newspaper. Default is &#39;false&#39;.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToHtmlPost (string simple, string columns, string url, string name)
        {
            
    
            var path = "/pdf/convert/to/html";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (simple != null) queryParams.Add("simple", ApiClient.ParameterToString(simple)); // query parameter
 if (columns != null) queryParams.Add("columns", ApiClient.ParameterToString(columns)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToHtmlPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToHtmlPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to JPEG image conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>MultiResponseModel</returns>            
        public MultiResponseModel PdfConvertToJpgGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/jpg";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJpgGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJpgGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MultiResponseModel) ApiClient.Deserialize(response.Content, typeof(MultiResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToJpgOptions ()
        {
            
    
            var path = "/pdf/convert/to/jpg";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJpgOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJpgOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to JPEG image conversion via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>MultiResponseModel</returns>            
        public MultiResponseModel PdfConvertToJpgPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/jpg";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJpgPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJpgPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MultiResponseModel) ApiClient.Deserialize(response.Content, typeof(MultiResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to JSON conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToJsonGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/json";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJsonGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJsonGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToJsonOptions ()
        {
            
    
            var path = "/pdf/convert/to/json";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJsonOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJsonOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to JSON conversion get view POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToJsonPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/json";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJsonPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToJsonPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to PNG image conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>MultiResponseModel</returns>            
        public MultiResponseModel PdfConvertToPngGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/png";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToPngGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToPngGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MultiResponseModel) ApiClient.Deserialize(response.Content, typeof(MultiResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToPngOptions ()
        {
            
    
            var path = "/pdf/convert/to/png";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToPngOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToPngOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to PNG image conversion convert via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>MultiResponseModel</returns>            
        public MultiResponseModel PdfConvertToPngPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/png";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToPngPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToPngPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MultiResponseModel) ApiClient.Deserialize(response.Content, typeof(MultiResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to plain text conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToTextGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/text";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTextGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTextGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToTextOptions ()
        {
            
    
            var path = "/pdf/convert/to/text";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTextOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTextOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to plain text conversion via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToTextPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/text";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTextPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTextPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to TIFF image (single or multi-page) conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToTiffGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/tiff";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTiffGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTiffGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToTiffOptions ()
        {
            
    
            var path = "/pdf/convert/to/tiff";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTiffOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTiffOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to TIFF image (single or multi-page) conversion via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToTiffPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/tiff";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTiffPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToTiffPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to XLS conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToXlsGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/xls";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToXlsOptions ()
        {
            
    
            var path = "/pdf/convert/to/xls";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to XLS conversion via POST request.
        /// </summary>
        /// <param name="pages"></param> 
        /// <param name="name"></param> 
        /// <param name="url"></param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToXlsPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/xls";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  PDF to XLSX conversion via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToXlsxGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/xlsx";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsxGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsxGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfConvertToXlsxOptions ()
        {
            
    
            var path = "/pdf/convert/to/xlsx";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsxOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsxOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  PDF to XLSX conversion via POST request.
        /// </summary>
        /// <param name="pages"></param> 
        /// <param name="name"></param> 
        /// <param name="url"></param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfConvertToXlsxPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/convert/to/xlsx";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsxPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfConvertToXlsxPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  Gets PDF document information via GET request.
        /// </summary>
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>PdfInfoResponseModel</returns>            
        public PdfInfoResponseModel PdfInfoGet (string url)
        {
            
    
            var path = "/pdf/info";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfInfoGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfInfoGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PdfInfoResponseModel) ApiClient.Deserialize(response.Content, typeof(PdfInfoResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfInfoOptions ()
        {
            
    
            var path = "/pdf/info";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfInfoOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfInfoOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Gets PDF document information via POST request.
        /// </summary>
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>PdfInfoResponseModel</returns>            
        public PdfInfoResponseModel PdfInfoPost (string url)
        {
            
    
            var path = "/pdf/info";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfInfoPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfInfoPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PdfInfoResponseModel) ApiClient.Deserialize(response.Content, typeof(PdfInfoResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  Merge two PDF documents via GET request.
        /// </summary>
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">Comma-separated list of URLs of source PDF files.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfMergeGet (string name, string url)
        {
            
    
            var path = "/pdf/merge";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergeGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergeGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfMergeOptions ()
        {
            
    
            var path = "/pdf/merge";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergeOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergeOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Merge two PDF documents via POST request.
        /// </summary>
        /// <param name="name">File name for generated result.</param> 
        /// <param name="url">Comma-separated list of URLs of source PDF files.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfMergePost (string name, string url)
        {
            
    
            var path = "/pdf/merge";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfMergePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  Sign PDF document via GET request.
        /// </summary>
        /// <param name="width">Width of the signature in PDF Points (1/72 in.).</param> 
        /// <param name="text"></param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <param name="name">File name for generated result.</param> 
        /// <param name="type"></param> 
        /// <param name="y">Y coordinate of the signature in PDF Points (1/72 in.).</param> 
        /// <param name="fontname"></param> 
        /// <param name="x">X coordinate of the signature in PDF Points (1/72 in.).</param> 
        /// <param name="height">Height of the signature in PDF Points (1/72 in.).</param> 
        /// <param name="pages">Comma-separated list of page indices (or ranges) to process. Leave empty for all pages. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="color"></param> 
        /// <param name="urlimage">URL of the signature image file.</param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfSignGet (string width, string text, string url, string name, string type, string y, string fontname, string x, string height, string pages, string color, string urlimage)
        {
            
    
            var path = "/pdf/sign";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (width != null) queryParams.Add("width", ApiClient.ParameterToString(width)); // query parameter
 if (text != null) queryParams.Add("text", ApiClient.ParameterToString(text)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (y != null) queryParams.Add("y", ApiClient.ParameterToString(y)); // query parameter
 if (fontname != null) queryParams.Add("fontname", ApiClient.ParameterToString(fontname)); // query parameter
 if (x != null) queryParams.Add("x", ApiClient.ParameterToString(x)); // query parameter
 if (height != null) queryParams.Add("height", ApiClient.ParameterToString(height)); // query parameter
 if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (color != null) queryParams.Add("color", ApiClient.ParameterToString(color)); // query parameter
 if (urlimage != null) queryParams.Add("urlimage", ApiClient.ParameterToString(urlimage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSignGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSignGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfSignOptions ()
        {
            
    
            var path = "/pdf/sign";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSignOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSignOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Sign PDF document via POST request.
        /// </summary>
        /// <param name="pdfSignRequestModel"></param> 
        /// <returns>SingleResponseModel</returns>            
        public SingleResponseModel PdfSignPost (PdfSignRequestModel pdfSignRequestModel)
        {
            
            // verify the required parameter 'pdfSignRequestModel' is set
            if (pdfSignRequestModel == null) throw new ApiException(400, "Missing required parameter 'pdfSignRequestModel' when calling PdfSignPost");
            
    
            var path = "/pdf/sign";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(pdfSignRequestModel); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSignPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSignPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SingleResponseModel) ApiClient.Deserialize(response.Content, typeof(SingleResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  Split PDF document via GET request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to split to. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">Base file name for generated result files.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>MultiResponseModel</returns>            
        public MultiResponseModel PdfSplitGet (string pages, string name, string url)
        {
            
    
            var path = "/pdf/split";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSplitGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSplitGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MultiResponseModel) ApiClient.Deserialize(response.Content, typeof(MultiResponseModel), response.Headers);
        }
    
        /// <summary>
        ///  OPTIONS is for internal purposes, please ingore.
        /// </summary>
        /// <returns>Empty</returns>            
        public Empty PdfSplitOptions ()
        {
            
    
            var path = "/pdf/split";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.OPTIONS, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSplitOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSplitOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Empty) ApiClient.Deserialize(response.Content, typeof(Empty), response.Headers);
        }
    
        /// <summary>
        ///  Split PDF document via POST request.
        /// </summary>
        /// <param name="pages">Comma-separated list of page indices (or ranges) to split to. Example: &#39;0,2-5,7-&#39;.</param> 
        /// <param name="name">Base file name for generated result files.</param> 
        /// <param name="url">URL of the source PDF file.</param> 
        /// <returns>MultiResponseModel</returns>            
        public MultiResponseModel PdfSplitPost (string pages, string name, string url)
        {
            
    
            var path = "/pdf/split";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pages != null) queryParams.Add("pages", ApiClient.ParameterToString(pages)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (url != null) queryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSplitPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PdfSplitPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MultiResponseModel) ApiClient.Deserialize(response.Content, typeof(MultiResponseModel), response.Headers);
        }
    
    }
}
