# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.TransformDocumentApi

All URIs are relative to *http://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TransformDocumentDocxReplace**](TransformDocumentApi.md#transformdocumentdocxreplace) | **POST** /convert/transform/docx/replace-all | Replace string in Word DOCX document, return result
[**TransformDocumentDocxReplaceEditSession**](TransformDocumentApi.md#transformdocumentdocxreplaceeditsession) | **POST** /convert/transform/docx/replace-all/edit-session | Replace string in Word DOCX document, return edit session
[**TransformDocumentDocxTableFillIn**](TransformDocumentApi.md#transformdocumentdocxtablefillin) | **POST** /convert/transform/docx/table/fill/data | Fill in data in a table in a Word DOCX document, return result
[**TransformDocumentDocxTableFillInEditSession**](TransformDocumentApi.md#transformdocumentdocxtablefillineditsession) | **POST** /convert/transform/docx/table/fill/data/edit-session | Fill in data in a table in a Word DOCX document, return edit session
[**TransformDocumentDocxTableFillInMulti**](TransformDocumentApi.md#transformdocumentdocxtablefillinmulti) | **POST** /convert/transform/docx/table/fill/data/multi | Fill in data in multiple tables in a Word DOCX document, return result
[**TransformDocumentPptxReplace**](TransformDocumentApi.md#transformdocumentpptxreplace) | **POST** /convert/transform/pptx/replace-all | Replace string in PowerPoint PPTX presentation, return result


<a name="transformdocumentdocxreplace"></a>
# **TransformDocumentDocxReplace**
> byte[] TransformDocumentDocxReplace (string matchString, string replaceString, System.IO.Stream inputFile = null, string inputFileUrl = null, bool? matchCase = null)

Replace string in Word DOCX document, return result

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
                // Replace string in Word DOCX document, return result
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

<a name="transformdocumentdocxreplaceeditsession"></a>
# **TransformDocumentDocxReplaceEditSession**
> DocumentTransformEditSession TransformDocumentDocxReplaceEditSession (string matchString, string replaceString, System.IO.Stream inputFile = null, string inputFileUrl = null, bool? matchCase = null)

Replace string in Word DOCX document, return edit session

Replace all instances of a string in an Office Word Document (docx).  Returns an edit session URL so that you can chain together multiple edit operations without having to send the entire document contents back and forth multiple times.  Call the Finish Editing API to retrieve the final document once editing is complete.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class TransformDocumentDocxReplaceEditSessionExample
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
                // Replace string in Word DOCX document, return edit session
                DocumentTransformEditSession result = apiInstance.TransformDocumentDocxReplaceEditSession(matchString, replaceString, inputFile, inputFileUrl, matchCase);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransformDocumentApi.TransformDocumentDocxReplaceEditSession: " + e.Message );
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

[**DocumentTransformEditSession**](DocumentTransformEditSession.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transformdocumentdocxtablefillin"></a>
# **TransformDocumentDocxTableFillIn**
> byte[] TransformDocumentDocxTableFillIn (DocxTableTableFillRequest request)

Fill in data in a table in a Word DOCX document, return result

Replace placeholder rows ina  table in an Office Word Document (docx) using one or more templates

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class TransformDocumentDocxTableFillInExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TransformDocumentApi();
            var request = new DocxTableTableFillRequest(); // DocxTableTableFillRequest | 

            try
            {
                // Fill in data in a table in a Word DOCX document, return result
                byte[] result = apiInstance.TransformDocumentDocxTableFillIn(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransformDocumentApi.TransformDocumentDocxTableFillIn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DocxTableTableFillRequest**](DocxTableTableFillRequest.md)|  | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transformdocumentdocxtablefillineditsession"></a>
# **TransformDocumentDocxTableFillInEditSession**
> DocumentTransformEditSession TransformDocumentDocxTableFillInEditSession (DocxTableTableFillRequest request)

Fill in data in a table in a Word DOCX document, return edit session

Replace placeholder rows ina  table in an Office Word Document (docx) using one or more templates.  Returns an edit session URL so that you can chain together multiple edit operations without having to send the entire document contents back and forth multiple times.  Call the Finish Editing API to retrieve the final document once editing is complete.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class TransformDocumentDocxTableFillInEditSessionExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TransformDocumentApi();
            var request = new DocxTableTableFillRequest(); // DocxTableTableFillRequest | 

            try
            {
                // Fill in data in a table in a Word DOCX document, return edit session
                DocumentTransformEditSession result = apiInstance.TransformDocumentDocxTableFillInEditSession(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransformDocumentApi.TransformDocumentDocxTableFillInEditSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DocxTableTableFillRequest**](DocxTableTableFillRequest.md)|  | 

### Return type

[**DocumentTransformEditSession**](DocumentTransformEditSession.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transformdocumentdocxtablefillinmulti"></a>
# **TransformDocumentDocxTableFillInMulti**
> byte[] TransformDocumentDocxTableFillInMulti (DocxTableTableFillMultiRequest request)

Fill in data in multiple tables in a Word DOCX document, return result

Replace placeholder rows in multiple tables in an Office Word Document (docx) using one or more templates

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class TransformDocumentDocxTableFillInMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new TransformDocumentApi();
            var request = new DocxTableTableFillMultiRequest(); // DocxTableTableFillMultiRequest | 

            try
            {
                // Fill in data in multiple tables in a Word DOCX document, return result
                byte[] result = apiInstance.TransformDocumentDocxTableFillInMulti(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransformDocumentApi.TransformDocumentDocxTableFillInMulti: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**DocxTableTableFillMultiRequest**](DocxTableTableFillMultiRequest.md)|  | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transformdocumentpptxreplace"></a>
# **TransformDocumentPptxReplace**
> byte[] TransformDocumentPptxReplace (string matchString, string replaceString, System.IO.Stream inputFile = null, string inputFileUrl = null, bool? matchCase = null)

Replace string in PowerPoint PPTX presentation, return result

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
                // Replace string in PowerPoint PPTX presentation, return result
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

