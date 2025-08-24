# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.MergeDocumentApi

All URIs are relative to *http://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MergeDocumentBatchJobCreate**](MergeDocumentApi.md#mergedocumentbatchjobcreate) | **POST** /convert/merge/batch-job/create | Merge an array of Documents into a Single Document by Page as a Batch Job
[**MergeDocumentDocx**](MergeDocumentApi.md#mergedocumentdocx) | **POST** /convert/merge/docx | Merge Two Word DOCX Together
[**MergeDocumentDocxMulti**](MergeDocumentApi.md#mergedocumentdocxmulti) | **POST** /convert/merge/docx/multi | Merge Multple Word DOCX Together
[**MergeDocumentDocxMultiArray**](MergeDocumentApi.md#mergedocumentdocxmultiarray) | **POST** /convert/merge/docx/multi/array | Merge Multple Word DOCX Together from an array
[**MergeDocumentGetAsyncJobStatus**](MergeDocumentApi.md#mergedocumentgetasyncjobstatus) | **GET** /convert/merge/batch-job/status | Get the status and result of a Merge Document Batch Job
[**MergeDocumentHtml**](MergeDocumentApi.md#mergedocumenthtml) | **POST** /convert/merge/html | Merge Two HTML (HTM) Files Together
[**MergeDocumentHtmlMulti**](MergeDocumentApi.md#mergedocumenthtmlmulti) | **POST** /convert/merge/html/multi | Merge Multple HTML (HTM) Files Together
[**MergeDocumentHtmlMultiArray**](MergeDocumentApi.md#mergedocumenthtmlmultiarray) | **POST** /convert/merge/html/multi/array | Merge Multple HTML (HTM) Files Together from an array
[**MergeDocumentPdf**](MergeDocumentApi.md#mergedocumentpdf) | **POST** /convert/merge/pdf | Merge Two PDF Files Together
[**MergeDocumentPdfMulti**](MergeDocumentApi.md#mergedocumentpdfmulti) | **POST** /convert/merge/pdf/multi | Merge Multple PDF Files Together
[**MergeDocumentPdfMultiArray**](MergeDocumentApi.md#mergedocumentpdfmultiarray) | **POST** /convert/merge/pdf/multi/array | Merge Multple PDF Files Together from an array
[**MergeDocumentPng**](MergeDocumentApi.md#mergedocumentpng) | **POST** /convert/merge/png/vertical | Merge Two PNG Files Together
[**MergeDocumentPngMulti**](MergeDocumentApi.md#mergedocumentpngmulti) | **POST** /convert/merge/png/vertical/multi | Merge Multple PNG Files Together
[**MergeDocumentPngMultiArray**](MergeDocumentApi.md#mergedocumentpngmultiarray) | **POST** /convert/merge/png/vertical/multi/array | Merge Multple PNG Files Together from an array
[**MergeDocumentPptx**](MergeDocumentApi.md#mergedocumentpptx) | **POST** /convert/merge/pptx | Merge Two PowerPoint PPTX Together
[**MergeDocumentPptxMulti**](MergeDocumentApi.md#mergedocumentpptxmulti) | **POST** /convert/merge/pptx/multi | Merge Multple PowerPoint PPTX Together
[**MergeDocumentPptxMultiArray**](MergeDocumentApi.md#mergedocumentpptxmultiarray) | **POST** /convert/merge/pptx/multi/array | Merge Multple PowerPoint PPTX Together from an array
[**MergeDocumentTxt**](MergeDocumentApi.md#mergedocumenttxt) | **POST** /convert/merge/txt | Merge Two Text (TXT) Files Together
[**MergeDocumentTxtMulti**](MergeDocumentApi.md#mergedocumenttxtmulti) | **POST** /convert/merge/txt/multi | Merge Multple Text (TXT) Files Together
[**MergeDocumentXlsx**](MergeDocumentApi.md#mergedocumentxlsx) | **POST** /convert/merge/xlsx | Merge Two Excel XLSX Together
[**MergeDocumentXlsxMulti**](MergeDocumentApi.md#mergedocumentxlsxmulti) | **POST** /convert/merge/xlsx/multi | Merge Multple Excel XLSX Together
[**MergeDocumentXlsxMultiArray**](MergeDocumentApi.md#mergedocumentxlsxmultiarray) | **POST** /convert/merge/xlsx/multi/array | Merge Multple Excel XLSX Together from an Array


<a name="mergedocumentbatchjobcreate"></a>
# **MergeDocumentBatchJobCreate**
> MergeBatchJobCreateResult MergeDocumentBatchJobCreate (DocumentArrayInput input)

Merge an array of Documents into a Single Document by Page as a Batch Job

Merge an array of Documents (PDF, PPTX, DOCX, XLSX supported), into a single document.  This API is designed for large jobs that could take a long time to create and so runs as a batch job that returns a Job ID that you can use with the GetAsyncJobStatus API to check on the status of the Job and ultimately get the output result.  This API automatically detects the document type and then performs the split by using the document type-specific API needed to perform the split.  This API is only available for Cloudmersive Managed Instance and Private Cloud deployments.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentBatchJobCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var input = new DocumentArrayInput(); // DocumentArrayInput | 

            try
            {
                // Merge an array of Documents into a Single Document by Page as a Batch Job
                MergeBatchJobCreateResult result = apiInstance.MergeDocumentBatchJobCreate(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentBatchJobCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DocumentArrayInput**](DocumentArrayInput.md)|  | 

### Return type

[**MergeBatchJobCreateResult**](MergeBatchJobCreateResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentdocx"></a>
# **MergeDocumentDocx**
> byte[] MergeDocumentDocx (System.IO.Stream inputFile1, System.IO.Stream inputFile2)

Merge Two Word DOCX Together

Combine two Office Word Documents (docx) into one single Office Word document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentDocxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Merge Two Word DOCX Together
                byte[] result = apiInstance.MergeDocumentDocx(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentDocx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on (more than 2 can be supplied). | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentdocxmulti"></a>
# **MergeDocumentDocxMulti**
> byte[] MergeDocumentDocxMulti (System.IO.Stream inputFile1, System.IO.Stream inputFile2, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Merge Multple Word DOCX Together

Combine multiple Office Word Documents (docx) into one single Office Word document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentDocxMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
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
                // Merge Multple Word DOCX Together
                byte[] result = apiInstance.MergeDocumentDocxMulti(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentDocxMulti: " + e.Message );
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

<a name="mergedocumentdocxmultiarray"></a>
# **MergeDocumentDocxMultiArray**
> Object MergeDocumentDocxMultiArray (DocumentArrayInput input)

Merge Multple Word DOCX Together from an array

Combine multiple Office Word Documents (docx), stored in an array, into one single Office Word document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentDocxMultiArrayExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var input = new DocumentArrayInput(); // DocumentArrayInput | Array of input files

            try
            {
                // Merge Multple Word DOCX Together from an array
                Object result = apiInstance.MergeDocumentDocxMultiArray(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentDocxMultiArray: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DocumentArrayInput**](DocumentArrayInput.md)| Array of input files | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentgetasyncjobstatus"></a>
# **MergeDocumentGetAsyncJobStatus**
> MergeJobStatusResult MergeDocumentGetAsyncJobStatus (string asyncJobID)

Get the status and result of a Merge Document Batch Job

Returns the result of the Async Job - possible states can be STARTED or COMPLETED.  This API is only available for Cloudmersive Managed Instance and Private Cloud deployments.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentGetAsyncJobStatusExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var asyncJobID = asyncJobID_example;  // string | 

            try
            {
                // Get the status and result of a Merge Document Batch Job
                MergeJobStatusResult result = apiInstance.MergeDocumentGetAsyncJobStatus(asyncJobID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentGetAsyncJobStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asyncJobID** | **string**|  | 

### Return type

[**MergeJobStatusResult**](MergeJobStatusResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumenthtml"></a>
# **MergeDocumentHtml**
> byte[] MergeDocumentHtml (System.IO.Stream inputFile1, System.IO.Stream inputFile2)

Merge Two HTML (HTM) Files Together

Combine two HTML (.HTM) files into a single text document, preserving the order of the input documents in the combined document by stacking them vertically.  The title will be taken from the first document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentHtmlExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Merge Two HTML (HTM) Files Together
                byte[] result = apiInstance.MergeDocumentHtml(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentHtml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on (more than 2 can be supplied). | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumenthtmlmulti"></a>
# **MergeDocumentHtmlMulti**
> byte[] MergeDocumentHtmlMulti (System.IO.Stream inputFile1, System.IO.Stream inputFile2, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Merge Multple HTML (HTM) Files Together

Combine multiple HTML (.HTM) files into a single text document, preserving the order of the input documents in the combined document by stacking them vertically.  The title will be taken from the first document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentHtmlMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
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
                // Merge Multple HTML (HTM) Files Together
                byte[] result = apiInstance.MergeDocumentHtmlMulti(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentHtmlMulti: " + e.Message );
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

<a name="mergedocumenthtmlmultiarray"></a>
# **MergeDocumentHtmlMultiArray**
> Object MergeDocumentHtmlMultiArray (DocumentArrayInput input)

Merge Multple HTML (HTM) Files Together from an array

Combine multiple HTML (.HTM) files, from an array, into a single text document, preserving the order of the input documents in the combined document by stacking them vertically.  The title will be taken from the first document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentHtmlMultiArrayExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var input = new DocumentArrayInput(); // DocumentArrayInput | Array of input files

            try
            {
                // Merge Multple HTML (HTM) Files Together from an array
                Object result = apiInstance.MergeDocumentHtmlMultiArray(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentHtmlMultiArray: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DocumentArrayInput**](DocumentArrayInput.md)| Array of input files | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentpdf"></a>
# **MergeDocumentPdf**
> byte[] MergeDocumentPdf (System.IO.Stream inputFile1, System.IO.Stream inputFile2)

Merge Two PDF Files Together

Combine two PDF files (pdf) into a single PDF document, preserving the order of the input documents in the combined document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPdfExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Merge Two PDF Files Together
                byte[] result = apiInstance.MergeDocumentPdf(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on (more than 2 can be supplied). | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentpdfmulti"></a>
# **MergeDocumentPdfMulti**
> byte[] MergeDocumentPdfMulti (System.IO.Stream inputFile1, System.IO.Stream inputFile2, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Merge Multple PDF Files Together

Combine multiple PDF files (pdf) into a single PDF document, preserving the order of the input documents in the combined document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPdfMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
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
                // Merge Multple PDF Files Together
                byte[] result = apiInstance.MergeDocumentPdfMulti(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPdfMulti: " + e.Message );
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

<a name="mergedocumentpdfmultiarray"></a>
# **MergeDocumentPdfMultiArray**
> Object MergeDocumentPdfMultiArray (DocumentArrayInput input)

Merge Multple PDF Files Together from an array

Combine multiple PDF files (pdf), as an array, into a single PDF document, preserving the order of the input documents in the combined document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPdfMultiArrayExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var input = new DocumentArrayInput(); // DocumentArrayInput | Array of input files

            try
            {
                // Merge Multple PDF Files Together from an array
                Object result = apiInstance.MergeDocumentPdfMultiArray(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPdfMultiArray: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DocumentArrayInput**](DocumentArrayInput.md)| Array of input files | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentpng"></a>
# **MergeDocumentPng**
> byte[] MergeDocumentPng (System.IO.Stream inputFile1, System.IO.Stream inputFile2)

Merge Two PNG Files Together

Combine two PNG files into a single PNG document, preserving the order of the input documents in the combined document by stacking them vertically

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPngExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Merge Two PNG Files Together
                byte[] result = apiInstance.MergeDocumentPng(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPng: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on (more than 2 can be supplied). | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentpngmulti"></a>
# **MergeDocumentPngMulti**
> byte[] MergeDocumentPngMulti (System.IO.Stream inputFile1, System.IO.Stream inputFile2, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Merge Multple PNG Files Together

Combine multiple PNG files into a single PNG document, preserving the order of the input documents in the combined document by stacking them vertically

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPngMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
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
                // Merge Multple PNG Files Together
                byte[] result = apiInstance.MergeDocumentPngMulti(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPngMulti: " + e.Message );
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

<a name="mergedocumentpngmultiarray"></a>
# **MergeDocumentPngMultiArray**
> Object MergeDocumentPngMultiArray (DocumentArrayInput input)

Merge Multple PNG Files Together from an array

Combine multiple PNG files, from an array, into a single PNG document, preserving the order of the input documents in the combined document by stacking them vertically

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPngMultiArrayExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var input = new DocumentArrayInput(); // DocumentArrayInput | Array of input files

            try
            {
                // Merge Multple PNG Files Together from an array
                Object result = apiInstance.MergeDocumentPngMultiArray(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPngMultiArray: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DocumentArrayInput**](DocumentArrayInput.md)| Array of input files | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentpptx"></a>
# **MergeDocumentPptx**
> byte[] MergeDocumentPptx (System.IO.Stream inputFile1, System.IO.Stream inputFile2)

Merge Two PowerPoint PPTX Together

Combine two Office PowerPoint presentations (pptx) into one single Office PowerPoint presentation

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPptxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Merge Two PowerPoint PPTX Together
                byte[] result = apiInstance.MergeDocumentPptx(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPptx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on (more than 2 can be supplied). | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentpptxmulti"></a>
# **MergeDocumentPptxMulti**
> byte[] MergeDocumentPptxMulti (System.IO.Stream inputFile1, System.IO.Stream inputFile2, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Merge Multple PowerPoint PPTX Together

Combine multiple Office PowerPoint presentations (pptx) into one single Office PowerPoint presentation

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPptxMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
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
                // Merge Multple PowerPoint PPTX Together
                byte[] result = apiInstance.MergeDocumentPptxMulti(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPptxMulti: " + e.Message );
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

<a name="mergedocumentpptxmultiarray"></a>
# **MergeDocumentPptxMultiArray**
> Object MergeDocumentPptxMultiArray (DocumentArrayInput input)

Merge Multple PowerPoint PPTX Together from an array

Combine multiple Office PowerPoint presentations (pptx), from an array, into one single Office PowerPoint presentation

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentPptxMultiArrayExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var input = new DocumentArrayInput(); // DocumentArrayInput | Array of input files

            try
            {
                // Merge Multple PowerPoint PPTX Together from an array
                Object result = apiInstance.MergeDocumentPptxMultiArray(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentPptxMultiArray: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DocumentArrayInput**](DocumentArrayInput.md)| Array of input files | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumenttxt"></a>
# **MergeDocumentTxt**
> Object MergeDocumentTxt (System.IO.Stream inputFile1, System.IO.Stream inputFile2)

Merge Two Text (TXT) Files Together

Combine two Text (.TXT) files into a single text document, preserving the order of the input documents in the combined document by stacking them vertically.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentTxtExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Merge Two Text (TXT) Files Together
                Object result = apiInstance.MergeDocumentTxt(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentTxt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on (more than 2 can be supplied). | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumenttxtmulti"></a>
# **MergeDocumentTxtMulti**
> byte[] MergeDocumentTxtMulti (System.IO.Stream inputFile1, System.IO.Stream inputFile2, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Merge Multple Text (TXT) Files Together

Combine multiple Text (.TXT) files into a single text document, preserving the order of the input documents in the combined document by stacking them vertically.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentTxtMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
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
                // Merge Multple Text (TXT) Files Together
                byte[] result = apiInstance.MergeDocumentTxtMulti(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentTxtMulti: " + e.Message );
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

<a name="mergedocumentxlsx"></a>
# **MergeDocumentXlsx**
> byte[] MergeDocumentXlsx (System.IO.Stream inputFile1, System.IO.Stream inputFile2)

Merge Two Excel XLSX Together

Combine two Office Excel spreadsheets (xlsx) into a single Office Excel spreadsheet

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentXlsxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Merge Two Excel XLSX Together
                byte[] result = apiInstance.MergeDocumentXlsx(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentXlsx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on (more than 2 can be supplied). | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mergedocumentxlsxmulti"></a>
# **MergeDocumentXlsxMulti**
> byte[] MergeDocumentXlsxMulti (System.IO.Stream inputFile1, System.IO.Stream inputFile2, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Merge Multple Excel XLSX Together

Combine multiple Office Excel spreadsheets (xlsx) into a single Office Excel spreadsheet

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentXlsxMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
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
                // Merge Multple Excel XLSX Together
                byte[] result = apiInstance.MergeDocumentXlsxMulti(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentXlsxMulti: " + e.Message );
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

<a name="mergedocumentxlsxmultiarray"></a>
# **MergeDocumentXlsxMultiArray**
> Object MergeDocumentXlsxMultiArray (DocumentArrayInput input)

Merge Multple Excel XLSX Together from an Array

Combine multiple Office Excel spreadsheets (xlsx), as an array, into a single Office Excel spreadsheet

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class MergeDocumentXlsxMultiArrayExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new MergeDocumentApi();
            var input = new DocumentArrayInput(); // DocumentArrayInput | Array of input files

            try
            {
                // Merge Multple Excel XLSX Together from an Array
                Object result = apiInstance.MergeDocumentXlsxMultiArray(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MergeDocumentApi.MergeDocumentXlsxMultiArray: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**DocumentArrayInput**](DocumentArrayInput.md)| Array of input files | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

