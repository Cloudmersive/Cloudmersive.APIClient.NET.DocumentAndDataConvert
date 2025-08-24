# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.CompareDocumentApi

All URIs are relative to *http://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompareDocumentDoc**](CompareDocumentApi.md#comparedocumentdoc) | **POST** /convert/compare/doc | Compare Two Word DOC (Legacy 97-2003 Format)
[**CompareDocumentDocx**](CompareDocumentApi.md#comparedocumentdocx) | **POST** /convert/compare/docx | Compare Two Word DOCX


<a name="comparedocumentdoc"></a>
# **CompareDocumentDoc**
> byte[] CompareDocumentDoc (System.IO.Stream inputFile1, System.IO.Stream inputFile2, string comparisonMode = null, bool? autorepair = null, bool? changeOutlines = null, bool? headersAndFooters = null, bool? acceptAllChanges = null)

Compare Two Word DOC (Legacy 97-2003 Format)

Compare two Office Word Documents (doc) legacy 97-2003 format files and highlight the differences

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class CompareDocumentDocExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CompareDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).
            var comparisonMode = comparisonMode_example;  // string | Optional; set to basic for a basic comparison, and advanced for advanced comparison mode.  Advanced comparison mode requires Managed Instance or Private Cloud deployment. (optional) 
            var autorepair = true;  // bool? | Optional; automatically repair input documents that have errors (default is true) (optional) 
            var changeOutlines = true;  // bool? | Optional; highlight changes with a blue outline (default is true) (optional) 
            var headersAndFooters = true;  // bool? | Optional; include headers and footers (default is false) (optional) 
            var acceptAllChanges = true;  // bool? | Optional; accept all changes before comparison (default is false) (optional) 

            try
            {
                // Compare Two Word DOC (Legacy 97-2003 Format)
                byte[] result = apiInstance.CompareDocumentDoc(inputFile1, inputFile2, comparisonMode, autorepair, changeOutlines, headersAndFooters, acceptAllChanges);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompareDocumentApi.CompareDocumentDoc: " + e.Message );
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
 **comparisonMode** | **string**| Optional; set to basic for a basic comparison, and advanced for advanced comparison mode.  Advanced comparison mode requires Managed Instance or Private Cloud deployment. | [optional] 
 **autorepair** | **bool?**| Optional; automatically repair input documents that have errors (default is true) | [optional] 
 **changeOutlines** | **bool?**| Optional; highlight changes with a blue outline (default is true) | [optional] 
 **headersAndFooters** | **bool?**| Optional; include headers and footers (default is false) | [optional] 
 **acceptAllChanges** | **bool?**| Optional; accept all changes before comparison (default is false) | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="comparedocumentdocx"></a>
# **CompareDocumentDocx**
> byte[] CompareDocumentDocx (System.IO.Stream inputFile1, System.IO.Stream inputFile2, string comparisonMode = null, bool? autorepair = null, bool? changeOutlines = null, bool? headersAndFooters = null, bool? acceptAllChanges = null)

Compare Two Word DOCX

Compare two Office Word Documents (docx) files and highlight the differences

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class CompareDocumentDocxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new CompareDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).
            var comparisonMode = comparisonMode_example;  // string | Optional; set to basic for a basic comparison, and advanced for advanced comparison mode.  Advanced comparison mode requires Managed Instance or Private Cloud deployment. (optional) 
            var autorepair = true;  // bool? | Optional; automatically repair input documents that have errors (default is true) (optional) 
            var changeOutlines = true;  // bool? | Optional; highlight changes with a blue outline (default is true) (optional) 
            var headersAndFooters = true;  // bool? | Optional; include headers and footers (default is false) (optional) 
            var acceptAllChanges = true;  // bool? | Optional; accept all changes before comparison (default is false) (optional) 

            try
            {
                // Compare Two Word DOCX
                byte[] result = apiInstance.CompareDocumentDocx(inputFile1, inputFile2, comparisonMode, autorepair, changeOutlines, headersAndFooters, acceptAllChanges);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompareDocumentApi.CompareDocumentDocx: " + e.Message );
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
 **comparisonMode** | **string**| Optional; set to basic for a basic comparison, and advanced for advanced comparison mode.  Advanced comparison mode requires Managed Instance or Private Cloud deployment. | [optional] 
 **autorepair** | **bool?**| Optional; automatically repair input documents that have errors (default is true) | [optional] 
 **changeOutlines** | **bool?**| Optional; highlight changes with a blue outline (default is true) | [optional] 
 **headersAndFooters** | **bool?**| Optional; include headers and footers (default is false) | [optional] 
 **acceptAllChanges** | **bool?**| Optional; accept all changes before comparison (default is false) | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

