# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.MergeDocumentApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MergeDocumentDocx**](MergeDocumentApi.md#mergedocumentdocx) | **POST** /convert/merge/docx | Merge Two Word DOCX Together
[**MergeDocumentDocxMulti**](MergeDocumentApi.md#mergedocumentdocxmulti) | **POST** /convert/merge/docx/multi | Merge Multple Word DOCX Together
[**MergeDocumentPdf**](MergeDocumentApi.md#mergedocumentpdf) | **POST** /convert/merge/pdf | Merge Two PDF Files Together
[**MergeDocumentPdfMulti**](MergeDocumentApi.md#mergedocumentpdfmulti) | **POST** /convert/merge/pdf/multi | Merge Multple PDF Files Together
[**MergeDocumentPng**](MergeDocumentApi.md#mergedocumentpng) | **POST** /convert/merge/png/vertical | Merge Multple PNG Files Together
[**MergeDocumentPptx**](MergeDocumentApi.md#mergedocumentpptx) | **POST** /convert/merge/pptx | Merge Two PowerPoint PPTX Together
[**MergeDocumentPptxMulti**](MergeDocumentApi.md#mergedocumentpptxmulti) | **POST** /convert/merge/pptx/multi | Merge Multple PowerPoint PPTX Together
[**MergeDocumentXlsx**](MergeDocumentApi.md#mergedocumentxlsx) | **POST** /convert/merge/xlsx | Merge Two Excel XLSX Together
[**MergeDocumentXlsxMulti**](MergeDocumentApi.md#mergedocumentxlsxmulti) | **POST** /convert/merge/xlsx/multi | Merge Multple Excel XLSX Together


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

<a name="mergedocumentpng"></a>
# **MergeDocumentPng**
> byte[] MergeDocumentPng (System.IO.Stream inputFile1, System.IO.Stream inputFile2)

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
                // Merge Multple PNG Files Together
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
 - **Accept**: application/octet-stream

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

