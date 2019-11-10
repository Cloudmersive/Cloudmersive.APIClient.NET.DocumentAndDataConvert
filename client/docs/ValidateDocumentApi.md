# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.ValidateDocumentApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ValidateDocumentAutodetectValidation**](ValidateDocumentApi.md#validatedocumentautodetectvalidation) | **POST** /convert/validate/autodetect | Autodetect content type and validate
[**ValidateDocumentDocxValidation**](ValidateDocumentApi.md#validatedocumentdocxvalidation) | **POST** /convert/validate/docx | Validate a Word document (DOCX)
[**ValidateDocumentExecutableValidation**](ValidateDocumentApi.md#validatedocumentexecutablevalidation) | **POST** /convert/validate/executable | Validate if a file is executable
[**ValidateDocumentJsonValidation**](ValidateDocumentApi.md#validatedocumentjsonvalidation) | **POST** /convert/validate/json | Validate a JSON file
[**ValidateDocumentPdfValidation**](ValidateDocumentApi.md#validatedocumentpdfvalidation) | **POST** /convert/validate/pdf | Validate a PDF document file
[**ValidateDocumentPptxValidation**](ValidateDocumentApi.md#validatedocumentpptxvalidation) | **POST** /convert/validate/pptx | Validate a PowerPoint presentation (PPTX)
[**ValidateDocumentXlsxValidation**](ValidateDocumentApi.md#validatedocumentxlsxvalidation) | **POST** /convert/validate/xlsx | Validate a Excel document (XLSX)
[**ValidateDocumentXmlValidation**](ValidateDocumentApi.md#validatedocumentxmlvalidation) | **POST** /convert/validate/xml | Validate an XML file


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

<a name="validatedocumentpdfvalidation"></a>
# **ValidateDocumentPdfValidation**
> DocumentValidationResult ValidateDocumentPdfValidation (System.IO.Stream inputFile)

Validate a PDF document file

Validate a PDF document; if the document is not valid, identifies the errors in the document

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

