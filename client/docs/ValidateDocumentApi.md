# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.ValidateDocumentApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ValidateDocumentAutodetectValidation**](ValidateDocumentApi.md#validatedocumentautodetectvalidation) | **POST** /convert/validate/autodetect | Autodetect content type and validate
[**ValidateDocumentCsvValidation**](ValidateDocumentApi.md#validatedocumentcsvvalidation) | **POST** /convert/validate/csv | Validate a CSV file document (CSV)
[**ValidateDocumentDocxValidation**](ValidateDocumentApi.md#validatedocumentdocxvalidation) | **POST** /convert/validate/docx | Validate a Word document (DOCX)
[**ValidateDocumentEmlValidation**](ValidateDocumentApi.md#validatedocumentemlvalidation) | **POST** /convert/validate/eml | Validate if an EML file is executable
[**ValidateDocumentExecutableValidation**](ValidateDocumentApi.md#validatedocumentexecutablevalidation) | **POST** /convert/validate/executable | Validate if a file is executable
[**ValidateDocumentGZipValidation**](ValidateDocumentApi.md#validatedocumentgzipvalidation) | **POST** /convert/validate/gzip | Validate a GZip Archive file (gzip or gz)
[**ValidateDocumentHtmlValidation**](ValidateDocumentApi.md#validatedocumenthtmlvalidation) | **POST** /convert/validate/html | Validate an HTML file
[**ValidateDocumentImageValidation**](ValidateDocumentApi.md#validatedocumentimagevalidation) | **POST** /convert/validate/image | Validate an Image File
[**ValidateDocumentJsonValidation**](ValidateDocumentApi.md#validatedocumentjsonvalidation) | **POST** /convert/validate/json | Validate a JSON file
[**ValidateDocumentMsgValidation**](ValidateDocumentApi.md#validatedocumentmsgvalidation) | **POST** /convert/validate/msg | Validate if an MSG file is executable
[**ValidateDocumentPdfValidation**](ValidateDocumentApi.md#validatedocumentpdfvalidation) | **POST** /convert/validate/pdf | Validate a PDF document file
[**ValidateDocumentPptxValidation**](ValidateDocumentApi.md#validatedocumentpptxvalidation) | **POST** /convert/validate/pptx | Validate a PowerPoint presentation (PPTX)
[**ValidateDocumentRarValidation**](ValidateDocumentApi.md#validatedocumentrarvalidation) | **POST** /convert/validate/rar | Validate a RAR Archive file (RAR)
[**ValidateDocumentTarValidation**](ValidateDocumentApi.md#validatedocumenttarvalidation) | **POST** /convert/validate/tar | Validate a TAR Tarball Archive file (TAR)
[**ValidateDocumentTxtValidation**](ValidateDocumentApi.md#validatedocumenttxtvalidation) | **POST** /convert/validate/txt | Validate an TXT file
[**ValidateDocumentXlsxValidation**](ValidateDocumentApi.md#validatedocumentxlsxvalidation) | **POST** /convert/validate/xlsx | Validate a Excel document (XLSX)
[**ValidateDocumentXmlValidation**](ValidateDocumentApi.md#validatedocumentxmlvalidation) | **POST** /convert/validate/xml | Validate an XML file
[**ValidateDocumentZipValidation**](ValidateDocumentApi.md#validatedocumentzipvalidation) | **POST** /convert/validate/zip | Validate a Zip Archive file (zip)


<a name="validatedocumentautodetectvalidation"></a>
# **ValidateDocumentAutodetectValidation**
> AutodetectDocumentValidationResult ValidateDocumentAutodetectValidation (System.IO.Stream inputFile)

Autodetect content type and validate

Automatically detect the type of content, verify and validate that the content is indeed fully valid at depth, and then report the validation result.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentAutodetectValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Autodetect content type and validate
                AutodetectDocumentValidationResult result = apiInstance.ValidateDocumentAutodetectValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentAutodetectValidation: " + e.Message );
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

[**AutodetectDocumentValidationResult**](AutodetectDocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentcsvvalidation"></a>
# **ValidateDocumentCsvValidation**
> DocumentValidationResult ValidateDocumentCsvValidation (System.IO.Stream inputFile)

Validate a CSV file document (CSV)

Validate a CSV file document (CSV); if the document is not valid, identifies the errors in the document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentCsvValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a CSV file document (CSV)
                DocumentValidationResult result = apiInstance.ValidateDocumentCsvValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentCsvValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentdocxvalidation"></a>
# **ValidateDocumentDocxValidation**
> DocumentValidationResult ValidateDocumentDocxValidation (System.IO.Stream inputFile)

Validate a Word document (DOCX)

Validate a Word document (DOCX); if the document is not valid, identifies the errors in the document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentDocxValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a Word document (DOCX)
                DocumentValidationResult result = apiInstance.ValidateDocumentDocxValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentDocxValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentemlvalidation"></a>
# **ValidateDocumentEmlValidation**
> DocumentValidationResult ValidateDocumentEmlValidation (System.IO.Stream inputFile)

Validate if an EML file is executable

Validate if an input file is an EML email file; if the document is not valid

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentEmlValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate if an EML file is executable
                DocumentValidationResult result = apiInstance.ValidateDocumentEmlValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentEmlValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentexecutablevalidation"></a>
# **ValidateDocumentExecutableValidation**
> DocumentValidationResult ValidateDocumentExecutableValidation (System.IO.Stream inputFile)

Validate if a file is executable

Validate if an input file is a binary executable file; if the document is not valid

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentExecutableValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate if a file is executable
                DocumentValidationResult result = apiInstance.ValidateDocumentExecutableValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentExecutableValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentgzipvalidation"></a>
# **ValidateDocumentGZipValidation**
> DocumentValidationResult ValidateDocumentGZipValidation (System.IO.Stream inputFile)

Validate a GZip Archive file (gzip or gz)

Validate a GZip archive file (GZIP or GZ)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentGZipValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a GZip Archive file (gzip or gz)
                DocumentValidationResult result = apiInstance.ValidateDocumentGZipValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentGZipValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumenthtmlvalidation"></a>
# **ValidateDocumentHtmlValidation**
> DocumentValidationResult ValidateDocumentHtmlValidation (System.IO.Stream inputFile)

Validate an HTML file

Validate an HTML document file; if the document is not valid, identifies the errors in the document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentHtmlValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate an HTML file
                DocumentValidationResult result = apiInstance.ValidateDocumentHtmlValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentHtmlValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentimagevalidation"></a>
# **ValidateDocumentImageValidation**
> DocumentValidationResult ValidateDocumentImageValidation (System.IO.Stream inputFile)

Validate an Image File

Validate an image file; if the document is not valid, identifies the errors in the document.  Formats supported include AAI, ART, ARW, AVS, BPG, BMP, BMP2, BMP3, BRF, CALS, CGM, CIN, CMYK, CMYKA, CR2, CRW, CUR, CUT, DCM, DCR, DCX, DDS, DIB, DJVU, DNG, DOT, DPX, EMF, EPDF, EPI, EPS, EPS2, EPS3, EPSF, EPSI, EPT, EXR, FAX, FIG, FITS, FPX, GIF, GPLT, GRAY, HDR, HEIC, HPGL, HRZ, ICO, ISOBRL, ISBRL6, JBIG, JNG, JP2, JPT, J2C, J2K, JPEG/JPG, JXR, MAT, MONO, MNG, M2V, MRW, MTV, NEF, ORF, OTB, P7, PALM, PAM, PBM, PCD, PCDS, PCL, PCX, PDF, PEF, PES, PFA, PFB, PFM, PGM, PICON, PICT, PIX, PNG, PNG8, PNG00, PNG24, PNG32, PNG48, PNG64, PNM, PPM, PSB, PSD, PTIF, PWB, RAD, RAF, RGB, RGBA, RGF, RLA, RLE, SCT, SFW, SGI, SID, SUN, SVG, TGA, TIFF, TIM, UIL, VIFF, VICAR, VBMP, WDP, WEBP, WPG, X, XBM, XCF, XPM, XWD, X3F, YCbCr, YCbCrA, YUV.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentImageValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate an Image File
                DocumentValidationResult result = apiInstance.ValidateDocumentImageValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentImageValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentjsonvalidation"></a>
# **ValidateDocumentJsonValidation**
> DocumentValidationResult ValidateDocumentJsonValidation (System.IO.Stream inputFile)

Validate a JSON file

Validate a JSON (JavaScript Object Notation) document file; if the document is not valid, identifies the errors in the document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentJsonValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a JSON file
                DocumentValidationResult result = apiInstance.ValidateDocumentJsonValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentJsonValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentmsgvalidation"></a>
# **ValidateDocumentMsgValidation**
> DocumentValidationResult ValidateDocumentMsgValidation (System.IO.Stream inputFile)

Validate if an MSG file is executable

Validate if an input file is an MSG email file; if the document is not valid

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentMsgValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate if an MSG file is executable
                DocumentValidationResult result = apiInstance.ValidateDocumentMsgValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentMsgValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentpdfvalidation"></a>
# **ValidateDocumentPdfValidation**
> DocumentValidationResult ValidateDocumentPdfValidation (System.IO.Stream inputFile)

Validate a PDF document file

Validate a PDF document; if the document is not valid, identifies the errors in the document.  Also checks if the PDF is password protected.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentPdfValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a PDF document file
                DocumentValidationResult result = apiInstance.ValidateDocumentPdfValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentPdfValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentpptxvalidation"></a>
# **ValidateDocumentPptxValidation**
> DocumentValidationResult ValidateDocumentPptxValidation (System.IO.Stream inputFile)

Validate a PowerPoint presentation (PPTX)

Validate a PowerPoint presentation (PPTX); if the document is not valid, identifies the errors in the document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentPptxValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a PowerPoint presentation (PPTX)
                DocumentValidationResult result = apiInstance.ValidateDocumentPptxValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentPptxValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentrarvalidation"></a>
# **ValidateDocumentRarValidation**
> DocumentValidationResult ValidateDocumentRarValidation (System.IO.Stream inputFile)

Validate a RAR Archive file (RAR)

Validate a RAR archive file (RAR)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentRarValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a RAR Archive file (RAR)
                DocumentValidationResult result = apiInstance.ValidateDocumentRarValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentRarValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumenttarvalidation"></a>
# **ValidateDocumentTarValidation**
> DocumentValidationResult ValidateDocumentTarValidation (System.IO.Stream inputFile)

Validate a TAR Tarball Archive file (TAR)

Validate a TAR tarball archive file (TAR)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentTarValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a TAR Tarball Archive file (TAR)
                DocumentValidationResult result = apiInstance.ValidateDocumentTarValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentTarValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumenttxtvalidation"></a>
# **ValidateDocumentTxtValidation**
> DocumentValidationResult ValidateDocumentTxtValidation (System.IO.Stream inputFile)

Validate an TXT file

Validate an TXT document file; if the document is not valid, identifies the errors in the document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentTxtValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate an TXT file
                DocumentValidationResult result = apiInstance.ValidateDocumentTxtValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentTxtValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentxlsxvalidation"></a>
# **ValidateDocumentXlsxValidation**
> DocumentValidationResult ValidateDocumentXlsxValidation (System.IO.Stream inputFile)

Validate a Excel document (XLSX)

Validate a Excel document (XLSX); if the document is not valid, identifies the errors in the document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentXlsxValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a Excel document (XLSX)
                DocumentValidationResult result = apiInstance.ValidateDocumentXlsxValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentXlsxValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentxmlvalidation"></a>
# **ValidateDocumentXmlValidation**
> DocumentValidationResult ValidateDocumentXmlValidation (System.IO.Stream inputFile)

Validate an XML file

Validate an XML document file; if the document is not valid, identifies the errors in the document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentXmlValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate an XML file
                DocumentValidationResult result = apiInstance.ValidateDocumentXmlValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentXmlValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatedocumentzipvalidation"></a>
# **ValidateDocumentZipValidation**
> DocumentValidationResult ValidateDocumentZipValidation (System.IO.Stream inputFile)

Validate a Zip Archive file (zip)

Validate a Zip archive file (ZIP)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ValidateDocumentZipValidationExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ValidateDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Validate a Zip Archive file (zip)
                DocumentValidationResult result = apiInstance.ValidateDocumentZipValidation(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ValidateDocumentApi.ValidateDocumentZipValidation: " + e.Message );
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

[**DocumentValidationResult**](DocumentValidationResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

