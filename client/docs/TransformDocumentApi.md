# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.TransformDocumentApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TransformDocumentDocxReplace**](TransformDocumentApi.md#transformdocumentdocxreplace) | **POST** /convert/transform/docx/replace-all | Replace string in Word DOCX document
[**TransformDocumentPptxReplace**](TransformDocumentApi.md#transformdocumentpptxreplace) | **POST** /convert/transform/pptx/replace-all | Replace string in PowerPoint PPTX presentation


<a name="transformdocumentdocxreplace"></a>
# **TransformDocumentDocxReplace**
> byte[] TransformDocumentDocxReplace (string matchString, string replaceString, System.IO.Stream inputFile = null, string inputFileUrl = null, bool? matchCase = null)

Replace string in Word DOCX document

Replace all instances of a string in an Office Word Document (docx)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class TransformDocumentDocxReplaceExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TransformDocumentApi();
            var matchString = matchString_example;  // string | String to search for and match against, to be replaced
            var replaceString = replaceString_example;  // string | String to replace the matched values with
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Optional: Input file to perform the operation on. (optional) 
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). (optional) 
            var matchCase = true;  // bool? | Optional: True if the case should be matched, false for case insensitive match. Default is false. (optional) 

            try
            {
                // Replace string in Word DOCX document
                byte[] result = apiInstance.TransformDocumentDocxReplace(matchString, replaceString, inputFile, inputFileUrl, matchCase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransformDocumentApi.TransformDocumentDocxReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **matchString** | **string**| String to search for and match against, to be replaced | 
 **replaceString** | **string**| String to replace the matched values with | 
 **inputFile** | **System.IO.Stream**| Optional: Input file to perform the operation on. | [optional] 
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
 **matchCase** | **bool?**| Optional: True if the case should be matched, false for case insensitive match. Default is false. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transformdocumentpptxreplace"></a>
# **TransformDocumentPptxReplace**
> byte[] TransformDocumentPptxReplace (string matchString, string replaceString, System.IO.Stream inputFile = null, string inputFileUrl = null, bool? matchCase = null)

Replace string in PowerPoint PPTX presentation

Replace all instances of a string in an Office PowerPoint Document (pptx)

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class TransformDocumentPptxReplaceExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TransformDocumentApi();
            var matchString = matchString_example;  // string | String to search for and match against, to be replaced
            var replaceString = replaceString_example;  // string | String to replace the matched values with
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Optional: Input file to perform the operation on. (optional) 
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). (optional) 
            var matchCase = true;  // bool? | Optional: True if the case should be matched, false for case insensitive match. Default is false. (optional) 

            try
            {
                // Replace string in PowerPoint PPTX presentation
                byte[] result = apiInstance.TransformDocumentPptxReplace(matchString, replaceString, inputFile, inputFileUrl, matchCase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransformDocumentApi.TransformDocumentPptxReplace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **matchString** | **string**| String to search for and match against, to be replaced | 
 **replaceString** | **string**| String to replace the matched values with | 
 **inputFile** | **System.IO.Stream**| Optional: Input file to perform the operation on. | [optional] 
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
 **matchCase** | **bool?**| Optional: True if the case should be matched, false for case insensitive match. Default is false. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

