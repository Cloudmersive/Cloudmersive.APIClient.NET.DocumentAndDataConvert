# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.ConvertDocumentApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertDocumentAutodetectGetInfo**](ConvertDocumentApi.md#convertdocumentautodetectgetinfo) | **POST** /convert/autodetect/get-info | Get document type information
[**ConvertDocumentAutodetectToPdf**](ConvertDocumentApi.md#convertdocumentautodetecttopdf) | **POST** /convert/autodetect/to/pdf | Convert Document to PDF
[**ConvertDocumentAutodetectToPngArray**](ConvertDocumentApi.md#convertdocumentautodetecttopngarray) | **POST** /convert/autodetect/to/png | Convert Document to PNG array
[**ConvertDocumentAutodetectToTxt**](ConvertDocumentApi.md#convertdocumentautodetecttotxt) | **POST** /convert/autodetect/to/txt | Convert Document to Text
[**ConvertDocumentCsvToXlsx**](ConvertDocumentApi.md#convertdocumentcsvtoxlsx) | **POST** /convert/csv/to/xlsx | Convert CSV to Excel XLSX Spreadsheet
[**ConvertDocumentDocToDocx**](ConvertDocumentApi.md#convertdocumentdoctodocx) | **POST** /convert/doc/to/docx | Convert Word DOC (97-03) Document to DOCX
[**ConvertDocumentDocToPdf**](ConvertDocumentApi.md#convertdocumentdoctopdf) | **POST** /convert/doc/to/pdf | Convert Word DOC (97-03) Document to PDF
[**ConvertDocumentDocxToPdf**](ConvertDocumentApi.md#convertdocumentdocxtopdf) | **POST** /convert/docx/to/pdf | Convert Word DOCX Document to PDF
[**ConvertDocumentDocxToTxt**](ConvertDocumentApi.md#convertdocumentdocxtotxt) | **POST** /convert/docx/to/txt | Convert Word DOCX Document to Text
[**ConvertDocumentHtmlToPdf**](ConvertDocumentApi.md#convertdocumenthtmltopdf) | **POST** /convert/html/to/pdf | Convert HTML to PDF Document
[**ConvertDocumentHtmlToPng**](ConvertDocumentApi.md#convertdocumenthtmltopng) | **POST** /convert/html/to/png | Convert HTML to PNG image array
[**ConvertDocumentPdfToDocx**](ConvertDocumentApi.md#convertdocumentpdftodocx) | **POST** /convert/pdf/to/docx | Convert PDF to Word DOCX Document
[**ConvertDocumentPdfToPngArray**](ConvertDocumentApi.md#convertdocumentpdftopngarray) | **POST** /convert/pdf/to/png | Convert PDF to PNG Image Array
[**ConvertDocumentPdfToPngSingle**](ConvertDocumentApi.md#convertdocumentpdftopngsingle) | **POST** /convert/pdf/to/png/merge-single | Convert PDF to Single PNG image
[**ConvertDocumentPdfToPptx**](ConvertDocumentApi.md#convertdocumentpdftopptx) | **POST** /convert/pdf/to/pptx | Convert PDF to PowerPoint PPTX Presentation
[**ConvertDocumentPdfToTxt**](ConvertDocumentApi.md#convertdocumentpdftotxt) | **POST** /convert/pdf/to/txt | Convert PDF Document to Text
[**ConvertDocumentPngArrayToPdf**](ConvertDocumentApi.md#convertdocumentpngarraytopdf) | **POST** /convert/png/to/pdf | Convert PNG Array to PDF
[**ConvertDocumentPptToPdf**](ConvertDocumentApi.md#convertdocumentppttopdf) | **POST** /convert/ppt/to/pdf | Convert PowerPoint PPT (97-03) Presentation to PDF
[**ConvertDocumentPptToPptx**](ConvertDocumentApi.md#convertdocumentppttopptx) | **POST** /convert/ppt/to/pptx | Convert PowerPoint PPT (97-03) Presentation to PPTX
[**ConvertDocumentPptxToPdf**](ConvertDocumentApi.md#convertdocumentpptxtopdf) | **POST** /convert/pptx/to/pdf | Convert PowerPoint PPTX Presentation to PDF
[**ConvertDocumentPptxToTxt**](ConvertDocumentApi.md#convertdocumentpptxtotxt) | **POST** /convert/pptx/to/txt | Convert PowerPoint PPTX Presentation to Text
[**ConvertDocumentXlsToCsv**](ConvertDocumentApi.md#convertdocumentxlstocsv) | **POST** /convert/xls/to/csv | Convert Excel XLS (97-03) Spreadsheet to CSV
[**ConvertDocumentXlsToPdf**](ConvertDocumentApi.md#convertdocumentxlstopdf) | **POST** /convert/xls/to/pdf | Convert Excel XLS (97-03) Spreadsheet to PDF
[**ConvertDocumentXlsToXlsx**](ConvertDocumentApi.md#convertdocumentxlstoxlsx) | **POST** /convert/xls/to/xlsx | Convert Excel XLS (97-03) Spreadsheet to XLSX
[**ConvertDocumentXlsxToCsv**](ConvertDocumentApi.md#convertdocumentxlsxtocsv) | **POST** /convert/xlsx/to/csv | Convert Excel XLSX Spreadsheet to CSV
[**ConvertDocumentXlsxToPdf**](ConvertDocumentApi.md#convertdocumentxlsxtopdf) | **POST** /convert/xlsx/to/pdf | Convert Excel XLSX Spreadsheet to PDF
[**ConvertDocumentXlsxToTxt**](ConvertDocumentApi.md#convertdocumentxlsxtotxt) | **POST** /convert/xlsx/to/txt | Convert Excel XLSX Spreadsheet to Text


<a name="convertdocumentautodetectgetinfo"></a>
# **ConvertDocumentAutodetectGetInfo**
> AutodetectGetInfoResult ConvertDocumentAutodetectGetInfo (System.IO.Stream inputFile)

Get document type information

Auto-detects a document's type information; does not require file extension.  Analyzes file contents to confirm file type.  Even if no file extension is present, the auto-detect system will reliably analyze the contents of the file and identify its file type.  Supports over 100 image file formats, Office document file formats, PDF, and more.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentAutodetectGetInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Get document type information
                AutodetectGetInfoResult result = apiInstance.ConvertDocumentAutodetectGetInfo(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentAutodetectGetInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**AutodetectGetInfoResult**](AutodetectGetInfoResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentautodetecttopdf"></a>
# **ConvertDocumentAutodetectToPdf**
> byte[] ConvertDocumentAutodetectToPdf (System.IO.Stream inputFile)

Convert Document to PDF

Automatically detect file type and convert it to PDF.  Supports all of the major Office document file formats including Word (DOCX, DOC), Excel (XLSX, XLS), PowerPoint (PPTX, PPT), over 100 image formats, HTML files, and even multi-page TIFF files.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentAutodetectToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Document to PDF
                byte[] result = apiInstance.ConvertDocumentAutodetectToPdf(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentAutodetectToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentautodetecttopngarray"></a>
# **ConvertDocumentAutodetectToPngArray**
> AutodetectToPngResult ConvertDocumentAutodetectToPngArray (System.IO.Stream inputFile)

Convert Document to PNG array

Automatically detect file type and convert it to an array of PNG images.  Supports all of the major Office document file formats, over 100 image formats, and even multi-page TIFF files.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentAutodetectToPngArrayExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Document to PNG array
                AutodetectToPngResult result = apiInstance.ConvertDocumentAutodetectToPngArray(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentAutodetectToPngArray: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**AutodetectToPngResult**](AutodetectToPngResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentautodetecttotxt"></a>
# **ConvertDocumentAutodetectToTxt**
> TextConversionResult ConvertDocumentAutodetectToTxt (System.IO.Stream inputFile)

Convert Document to Text

Automatically detect file type and convert it to Text.  Supports all of the major Office document file formats including Word (DOCX, DOC), Excel (XLSX, XLS), PowerPoint (PPTX, PPT) and PDF files.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentAutodetectToTxtExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Document to Text
                TextConversionResult result = apiInstance.ConvertDocumentAutodetectToTxt(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentAutodetectToTxt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**TextConversionResult**](TextConversionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentcsvtoxlsx"></a>
# **ConvertDocumentCsvToXlsx**
> byte[] ConvertDocumentCsvToXlsx (System.IO.Stream inputFile)

Convert CSV to Excel XLSX Spreadsheet

Convert CSV file to Office Excel XLSX Workbooks file format.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentCsvToXlsxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert CSV to Excel XLSX Spreadsheet
                byte[] result = apiInstance.ConvertDocumentCsvToXlsx(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentCsvToXlsx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentdoctodocx"></a>
# **ConvertDocumentDocToDocx**
> byte[] ConvertDocumentDocToDocx (System.IO.Stream inputFile)

Convert Word DOC (97-03) Document to DOCX

Convert/upgrade Office Word (97-2003 Format) Documents (doc) to the modern DOCX format

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentDocToDocxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Word DOC (97-03) Document to DOCX
                byte[] result = apiInstance.ConvertDocumentDocToDocx(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentDocToDocx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentdoctopdf"></a>
# **ConvertDocumentDocToPdf**
> byte[] ConvertDocumentDocToPdf (System.IO.Stream inputFile)

Convert Word DOC (97-03) Document to PDF

Convert Office Word (97-2003 Format) Documents (doc) to standard PDF

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentDocToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Word DOC (97-03) Document to PDF
                byte[] result = apiInstance.ConvertDocumentDocToPdf(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentDocToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentdocxtopdf"></a>
# **ConvertDocumentDocxToPdf**
> byte[] ConvertDocumentDocxToPdf (System.IO.Stream inputFile)

Convert Word DOCX Document to PDF

Convert Office Word Documents (docx) to standard PDF

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentDocxToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Word DOCX Document to PDF
                byte[] result = apiInstance.ConvertDocumentDocxToPdf(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentDocxToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentdocxtotxt"></a>
# **ConvertDocumentDocxToTxt**
> TextConversionResult ConvertDocumentDocxToTxt (System.IO.Stream inputFile)

Convert Word DOCX Document to Text

Convert Office Word Documents (docx) to text

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentDocxToTxtExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Word DOCX Document to Text
                TextConversionResult result = apiInstance.ConvertDocumentDocxToTxt(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentDocxToTxt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**TextConversionResult**](TextConversionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumenthtmltopdf"></a>
# **ConvertDocumentHtmlToPdf**
> byte[] ConvertDocumentHtmlToPdf (System.IO.Stream inputFile)

Convert HTML to PDF Document

Convert standard HTML, with full support for CSS, JavaScript, Images, and other complex behavior to PDF.  To use external files such as images, use an absolute URL to the file.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentHtmlToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert HTML to PDF Document
                byte[] result = apiInstance.ConvertDocumentHtmlToPdf(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentHtmlToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumenthtmltopng"></a>
# **ConvertDocumentHtmlToPng**
> PdfToPngResult ConvertDocumentHtmlToPng (System.IO.Stream inputFile)

Convert HTML to PNG image array

Convert standard HTML, with full support for CSS, JavaScript, Images, and other complex behavior to an array of PNG images, one for each page.  To use external files in your HTML such as images, use an absolute URL to the file.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentHtmlToPngExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert HTML to PNG image array
                PdfToPngResult result = apiInstance.ConvertDocumentHtmlToPng(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentHtmlToPng: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**PdfToPngResult**](PdfToPngResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentpdftodocx"></a>
# **ConvertDocumentPdfToDocx**
> byte[] ConvertDocumentPdfToDocx (System.IO.Stream inputFile)

Convert PDF to Word DOCX Document

Convert standard PDF to Office Word Documents (docx).    Converts a PDF at high fidelity into Word format, where it can be easily edited and processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPdfToDocxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PDF to Word DOCX Document
                byte[] result = apiInstance.ConvertDocumentPdfToDocx(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPdfToDocx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentpdftopngarray"></a>
# **ConvertDocumentPdfToPngArray**
> PdfToPngResult ConvertDocumentPdfToPngArray (System.IO.Stream inputFile)

Convert PDF to PNG Image Array

Convert PDF document to PNG array, one image per page.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPdfToPngArrayExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PDF to PNG Image Array
                PdfToPngResult result = apiInstance.ConvertDocumentPdfToPngArray(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPdfToPngArray: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**PdfToPngResult**](PdfToPngResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentpdftopngsingle"></a>
# **ConvertDocumentPdfToPngSingle**
> byte[] ConvertDocumentPdfToPngSingle (System.IO.Stream inputFile)

Convert PDF to Single PNG image

Convert PDF document to a single tall PNG image, by stacking/concatenating the images vertically into a single \"tall\" image

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPdfToPngSingleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PDF to Single PNG image
                byte[] result = apiInstance.ConvertDocumentPdfToPngSingle(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPdfToPngSingle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentpdftopptx"></a>
# **ConvertDocumentPdfToPptx**
> byte[] ConvertDocumentPdfToPptx (System.IO.Stream inputFile)

Convert PDF to PowerPoint PPTX Presentation

Convert standard PDF to Office PowerPoint Presentation (pptx).  Converts a PDF file at high fidelity into PowerPoint format, where it can be easily edited and processed.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPdfToPptxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PDF to PowerPoint PPTX Presentation
                byte[] result = apiInstance.ConvertDocumentPdfToPptx(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPdfToPptx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentpdftotxt"></a>
# **ConvertDocumentPdfToTxt**
> TextConversionResult ConvertDocumentPdfToTxt (System.IO.Stream inputFile)

Convert PDF Document to Text

PDF document to text

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPdfToTxtExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PDF Document to Text
                TextConversionResult result = apiInstance.ConvertDocumentPdfToTxt(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPdfToTxt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**TextConversionResult**](TextConversionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentpngarraytopdf"></a>
# **ConvertDocumentPngArrayToPdf**
> byte[] ConvertDocumentPngArrayToPdf (System.IO.Stream inputFile1, System.IO.Stream inputFile2, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Convert PNG Array to PDF

Convert an array of PNG images, one image per page, into a newly-created PDF.  Supports images of different sizes as input.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPngArrayToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on.
            var inputFile3 = new System.IO.Stream(); // System.IO.Stream | Third input file to perform the operation on. (optional) 
            var inputFile4 = new System.IO.Stream(); // System.IO.Stream | Fourth input file to perform the operation on. (optional) 
            var inputFile5 = new System.IO.Stream(); // System.IO.Stream | Fifth input file to perform the operation on. (optional) 
            var inputFile6 = new System.IO.Stream(); // System.IO.Stream | Sixth input file to perform the operation on. (optional) 
            var inputFile7 = new System.IO.Stream(); // System.IO.Stream | Seventh input file to perform the operation on. (optional) 
            var inputFile8 = new System.IO.Stream(); // System.IO.Stream | Eighth input file to perform the operation on. (optional) 
            var inputFile9 = new System.IO.Stream(); // System.IO.Stream | Ninth input file to perform the operation on. (optional) 
            var inputFile10 = new System.IO.Stream(); // System.IO.Stream | Tenth input file to perform the operation on. (optional) 

            try
            {
                // Convert PNG Array to PDF
                byte[] result = apiInstance.ConvertDocumentPngArrayToPdf(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPngArrayToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on. | 
 **inputFile3** | **System.IO.Stream**| Third input file to perform the operation on. | [optional] 
 **inputFile4** | **System.IO.Stream**| Fourth input file to perform the operation on. | [optional] 
 **inputFile5** | **System.IO.Stream**| Fifth input file to perform the operation on. | [optional] 
 **inputFile6** | **System.IO.Stream**| Sixth input file to perform the operation on. | [optional] 
 **inputFile7** | **System.IO.Stream**| Seventh input file to perform the operation on. | [optional] 
 **inputFile8** | **System.IO.Stream**| Eighth input file to perform the operation on. | [optional] 
 **inputFile9** | **System.IO.Stream**| Ninth input file to perform the operation on. | [optional] 
 **inputFile10** | **System.IO.Stream**| Tenth input file to perform the operation on. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentppttopdf"></a>
# **ConvertDocumentPptToPdf**
> byte[] ConvertDocumentPptToPdf (System.IO.Stream inputFile)

Convert PowerPoint PPT (97-03) Presentation to PDF

Convert Office PowerPoint (97-2003) Documents (ppt) to standard PDF

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPptToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PowerPoint PPT (97-03) Presentation to PDF
                byte[] result = apiInstance.ConvertDocumentPptToPdf(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPptToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentppttopptx"></a>
# **ConvertDocumentPptToPptx**
> byte[] ConvertDocumentPptToPptx (System.IO.Stream inputFile)

Convert PowerPoint PPT (97-03) Presentation to PPTX

Convert/upgrade Office PowerPoint (97-2003) Documents (ppt) to modern PPTX

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPptToPptxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PowerPoint PPT (97-03) Presentation to PPTX
                byte[] result = apiInstance.ConvertDocumentPptToPptx(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPptToPptx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentpptxtopdf"></a>
# **ConvertDocumentPptxToPdf**
> byte[] ConvertDocumentPptxToPdf (System.IO.Stream inputFile)

Convert PowerPoint PPTX Presentation to PDF

Convert Office PowerPoint Documents (pptx) to standard PDF

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPptxToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PowerPoint PPTX Presentation to PDF
                byte[] result = apiInstance.ConvertDocumentPptxToPdf(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPptxToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentpptxtotxt"></a>
# **ConvertDocumentPptxToTxt**
> TextConversionResult ConvertDocumentPptxToTxt (System.IO.Stream inputFile)

Convert PowerPoint PPTX Presentation to Text

Convert Office PowerPoint Documents (pptx) to standard Text

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentPptxToTxtExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert PowerPoint PPTX Presentation to Text
                TextConversionResult result = apiInstance.ConvertDocumentPptxToTxt(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentPptxToTxt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**TextConversionResult**](TextConversionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentxlstocsv"></a>
# **ConvertDocumentXlsToCsv**
> byte[] ConvertDocumentXlsToCsv (System.IO.Stream inputFile)

Convert Excel XLS (97-03) Spreadsheet to CSV

Convert/upgrade Office Excel (97-2003) Workbooks (xls) to standard CSV format.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentXlsToCsvExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Excel XLS (97-03) Spreadsheet to CSV
                byte[] result = apiInstance.ConvertDocumentXlsToCsv(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentXlsToCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentxlstopdf"></a>
# **ConvertDocumentXlsToPdf**
> byte[] ConvertDocumentXlsToPdf (System.IO.Stream inputFile)

Convert Excel XLS (97-03) Spreadsheet to PDF

Convert Office Excel (97-2003) Workbooks (xls) to standard PDF.  Converts all worksheets in the workbook to PDF.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentXlsToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Excel XLS (97-03) Spreadsheet to PDF
                byte[] result = apiInstance.ConvertDocumentXlsToPdf(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentXlsToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentxlstoxlsx"></a>
# **ConvertDocumentXlsToXlsx**
> byte[] ConvertDocumentXlsToXlsx (System.IO.Stream inputFile)

Convert Excel XLS (97-03) Spreadsheet to XLSX

Convert/upgrade Office Excel (97-2003) Workbooks (xls) to modern XLSX format.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentXlsToXlsxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Excel XLS (97-03) Spreadsheet to XLSX
                byte[] result = apiInstance.ConvertDocumentXlsToXlsx(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentXlsToXlsx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentxlsxtocsv"></a>
# **ConvertDocumentXlsxToCsv**
> byte[] ConvertDocumentXlsxToCsv (System.IO.Stream inputFile, string outputEncoding = null)

Convert Excel XLSX Spreadsheet to CSV

Convert Office Excel Workbooks (XLSX) to standard Comma-Separated Values (CSV) format.  Supports both XLSX and XLSB file Excel formats.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentXlsxToCsvExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var outputEncoding = outputEncoding_example;  // string | Optional, set the output text encoding for the result; possible values are UTF-8 and UTF-32.  Default is UTF-32. (optional) 

            try
            {
                // Convert Excel XLSX Spreadsheet to CSV
                byte[] result = apiInstance.ConvertDocumentXlsxToCsv(inputFile, outputEncoding);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentXlsxToCsv: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **outputEncoding** | **string**| Optional, set the output text encoding for the result; possible values are UTF-8 and UTF-32.  Default is UTF-32. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentxlsxtopdf"></a>
# **ConvertDocumentXlsxToPdf**
> byte[] ConvertDocumentXlsxToPdf (System.IO.Stream inputFile)

Convert Excel XLSX Spreadsheet to PDF

Convert Office Excel Workbooks (XLSX) to standard PDF.  Converts all worksheets in the workbook to PDF.  Supports both XLSX and XLSB Excel file formats.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentXlsxToPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Excel XLSX Spreadsheet to PDF
                byte[] result = apiInstance.ConvertDocumentXlsxToPdf(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentXlsxToPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdocumentxlsxtotxt"></a>
# **ConvertDocumentXlsxToTxt**
> TextConversionResult ConvertDocumentXlsxToTxt (System.IO.Stream inputFile)

Convert Excel XLSX Spreadsheet to Text

Convert Office Excel Workbooks (XLSX) to standard Text.  Converts all worksheets in the workbook to Text.  Supports both XLSX and XLSB file formats.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDocumentXlsxToTxtExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Excel XLSX Spreadsheet to Text
                TextConversionResult result = apiInstance.ConvertDocumentXlsxToTxt(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDocumentApi.ConvertDocumentXlsxToTxt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**TextConversionResult**](TextConversionResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

