# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.EditPdfApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditPdfAddAnnotations**](EditPdfApi.md#editpdfaddannotations) | **POST** /convert/edit/pdf/annotations/add-item | Add one or more PDF annotations, comments in the PDF document
[**EditPdfConvertToPdfA**](EditPdfApi.md#editpdfconverttopdfa) | **POST** /convert/edit/pdf/optimize/pdf-a | Convert a PDF file to PDF/A
[**EditPdfDecrypt**](EditPdfApi.md#editpdfdecrypt) | **POST** /convert/edit/pdf/decrypt | Decrypt and password-protect a PDF
[**EditPdfDeletePages**](EditPdfApi.md#editpdfdeletepages) | **POST** /convert/edit/pdf/pages/delete | Remove, delete pages from a PDF document
[**EditPdfDeletePagesBatchJob**](EditPdfApi.md#editpdfdeletepagesbatchjob) | **POST** /convert/edit/pdf/pages/delete/batch-job | Remove, delete pages from a PDF document as Batch Job
[**EditPdfEncrypt**](EditPdfApi.md#editpdfencrypt) | **POST** /convert/edit/pdf/encrypt | Encrypt and password-protect a PDF
[**EditPdfGetAnnotations**](EditPdfApi.md#editpdfgetannotations) | **POST** /convert/edit/pdf/annotations/list | Get PDF annotations, including comments in the document
[**EditPdfGetAsyncJobStatus**](EditPdfApi.md#editpdfgetasyncjobstatus) | **GET** /convert/edit/pdf/batch-job/status | Get the status and result of a PDF Batch Job
[**EditPdfGetFormFields**](EditPdfApi.md#editpdfgetformfields) | **POST** /convert/edit/pdf/form/get-fields | Gets PDF Form fields and values
[**EditPdfGetMetadata**](EditPdfApi.md#editpdfgetmetadata) | **POST** /convert/edit/pdf/get-metadata | Get PDF document metadata
[**EditPdfGetPdfTextByPages**](EditPdfApi.md#editpdfgetpdftextbypages) | **POST** /convert/edit/pdf/pages/get-text | Get text in a PDF document by page
[**EditPdfInsertPages**](EditPdfApi.md#editpdfinsertpages) | **POST** /convert/edit/pdf/pages/insert | Insert, copy pages from one PDF document into another
[**EditPdfInsertPagesBatchJob**](EditPdfApi.md#editpdfinsertpagesbatchjob) | **POST** /convert/edit/pdf/pages/insert/batch-job | Insert, copy pages from one PDF document into another as a batch job
[**EditPdfLinearize**](EditPdfApi.md#editpdflinearize) | **POST** /convert/edit/pdf/optimize/linearize | Linearize and optimize a PDF for streaming download
[**EditPdfRasterize**](EditPdfApi.md#editpdfrasterize) | **POST** /convert/edit/pdf/rasterize | Rasterize a PDF to an image-based PDF
[**EditPdfRasterizeBatchJob**](EditPdfApi.md#editpdfrasterizebatchjob) | **POST** /convert/edit/pdf/rasterize/batch-job | Rasterize a PDF to an image-based PDF as Batch Job
[**EditPdfReduceFileSize**](EditPdfApi.md#editpdfreducefilesize) | **POST** /convert/edit/pdf/optimize/reduce-file-size | Reduce the file size and optimize a PDF
[**EditPdfRemoveAllAnnotations**](EditPdfApi.md#editpdfremoveallannotations) | **POST** /convert/edit/pdf/annotations/remove-all | Remove all PDF annotations, including comments in the document
[**EditPdfRemoveAnnotationItem**](EditPdfApi.md#editpdfremoveannotationitem) | **POST** /convert/edit/pdf/annotations/remove-item | Remove a specific PDF annotation, comment in the document
[**EditPdfResize**](EditPdfApi.md#editpdfresize) | **POST** /convert/edit/pdf/resize | Change PDF Document&#39;s Paper Size
[**EditPdfRotateAllPages**](EditPdfApi.md#editpdfrotateallpages) | **POST** /convert/edit/pdf/pages/rotate/all | Rotate all pages in a PDF document
[**EditPdfRotatePageRange**](EditPdfApi.md#editpdfrotatepagerange) | **POST** /convert/edit/pdf/pages/rotate/page-range | Rotate a range, subset of pages in a PDF document
[**EditPdfSanitize**](EditPdfApi.md#editpdfsanitize) | **POST** /convert/edit/pdf/sanitize | Sanitize a PDF by removing embedded JavaScript
[**EditPdfSetFormFields**](EditPdfApi.md#editpdfsetformfields) | **POST** /convert/edit/pdf/form/set-fields | Sets ands fills PDF Form field values
[**EditPdfSetMetadata**](EditPdfApi.md#editpdfsetmetadata) | **POST** /convert/edit/pdf/set-metadata | Sets PDF document metadata
[**EditPdfSetPermissions**](EditPdfApi.md#editpdfsetpermissions) | **POST** /convert/edit/pdf/encrypt/set-permissions | Encrypt, password-protect and set restricted permissions on a PDF
[**EditPdfWatermarkText**](EditPdfApi.md#editpdfwatermarktext) | **POST** /convert/edit/pdf/watermark/text | Add a text watermark to a PDF


<a name="editpdfaddannotations"></a>
# **EditPdfAddAnnotations**
> byte[] EditPdfAddAnnotations (AddPdfAnnotationRequest request)

Add one or more PDF annotations, comments in the PDF document

Adds one or more annotations, comments to a PDF document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfAddAnnotationsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var request = new AddPdfAnnotationRequest(); // AddPdfAnnotationRequest | 

            try
            {
                // Add one or more PDF annotations, comments in the PDF document
                byte[] result = apiInstance.EditPdfAddAnnotations(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfAddAnnotations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**AddPdfAnnotationRequest**](AddPdfAnnotationRequest.md)|  | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfconverttopdfa"></a>
# **EditPdfConvertToPdfA**
> byte[] EditPdfConvertToPdfA (System.IO.Stream inputFile, string conformanceLevel = null)

Convert a PDF file to PDF/A

Converts the input PDF file to a PDF/A-1b or PDF/A-2b standardized PDF.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfConvertToPdfAExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var conformanceLevel = conformanceLevel_example;  // string | Optional: Select the conformance level for PDF/A - specify '1b' for PDF/A-1b or specify '2b' for PDF/A-2b; default is PDF/A-1b (optional) 

            try
            {
                // Convert a PDF file to PDF/A
                byte[] result = apiInstance.EditPdfConvertToPdfA(inputFile, conformanceLevel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfConvertToPdfA: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **conformanceLevel** | **string**| Optional: Select the conformance level for PDF/A - specify &#39;1b&#39; for PDF/A-1b or specify &#39;2b&#39; for PDF/A-2b; default is PDF/A-1b | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfdecrypt"></a>
# **EditPdfDecrypt**
> byte[] EditPdfDecrypt (string password, System.IO.Stream inputFile)

Decrypt and password-protect a PDF

Decrypt a PDF document with a password.  Decrypted PDF will no longer require a password to open.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfDecryptExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var password = password_example;  // string | Valid password for the PDF file
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Decrypt and password-protect a PDF
                byte[] result = apiInstance.EditPdfDecrypt(password, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfDecrypt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | **string**| Valid password for the PDF file | 
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfdeletepages"></a>
# **EditPdfDeletePages**
> byte[] EditPdfDeletePages (System.IO.Stream inputFile, int? pageStart, int? pageEnd)

Remove, delete pages from a PDF document

Remove one or more pages from a PDF document

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfDeletePagesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var pageStart = 56;  // int? | Page number (1 based) to start deleting pages from (inclusive).
            var pageEnd = 56;  // int? | Page number (1 based) to stop deleting pages from (inclusive).

            try
            {
                // Remove, delete pages from a PDF document
                byte[] result = apiInstance.EditPdfDeletePages(inputFile, pageStart, pageEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfDeletePages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **pageStart** | **int?**| Page number (1 based) to start deleting pages from (inclusive). | 
 **pageEnd** | **int?**| Page number (1 based) to stop deleting pages from (inclusive). | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfdeletepagesbatchjob"></a>
# **EditPdfDeletePagesBatchJob**
> EditPdfBatchJobCreateResult EditPdfDeletePagesBatchJob (System.IO.Stream inputFile, int? pageStart, int? pageEnd)

Remove, delete pages from a PDF document as Batch Job

Remove one or more pages from a PDF document.  Runs as a batch job async and returns a batch job ID that you can check the status of to get the result.  Requires Cloudmersive Private Cloud or Managed Instance.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfDeletePagesBatchJobExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var pageStart = 56;  // int? | Page number (1 based) to start deleting pages from (inclusive).
            var pageEnd = 56;  // int? | Page number (1 based) to stop deleting pages from (inclusive).

            try
            {
                // Remove, delete pages from a PDF document as Batch Job
                EditPdfBatchJobCreateResult result = apiInstance.EditPdfDeletePagesBatchJob(inputFile, pageStart, pageEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfDeletePagesBatchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **pageStart** | **int?**| Page number (1 based) to start deleting pages from (inclusive). | 
 **pageEnd** | **int?**| Page number (1 based) to stop deleting pages from (inclusive). | 

### Return type

[**EditPdfBatchJobCreateResult**](EditPdfBatchJobCreateResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfencrypt"></a>
# **EditPdfEncrypt**
> byte[] EditPdfEncrypt (System.IO.Stream inputFile, string userPassword = null, string ownerPassword = null, string encryptionKeyLength = null)

Encrypt and password-protect a PDF

Encrypt a PDF document with a password.  Set an owner password to control owner (editor/creator) permissions, and set a user (reader) password to control the viewer of the PDF.  Set the password fields null to omit the given password.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfEncryptExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var userPassword = userPassword_example;  // string | Password of a user (reader) of the PDF file (optional) 
            var ownerPassword = ownerPassword_example;  // string | Password of a owner (creator/editor) of the PDF file (optional) 
            var encryptionKeyLength = encryptionKeyLength_example;  // string | Possible values are \"128\" (128-bit RC4 encryption) and \"256\" (256-bit AES encryption).  Default is 256. (optional) 

            try
            {
                // Encrypt and password-protect a PDF
                byte[] result = apiInstance.EditPdfEncrypt(inputFile, userPassword, ownerPassword, encryptionKeyLength);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfEncrypt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **userPassword** | **string**| Password of a user (reader) of the PDF file | [optional] 
 **ownerPassword** | **string**| Password of a owner (creator/editor) of the PDF file | [optional] 
 **encryptionKeyLength** | **string**| Possible values are \&quot;128\&quot; (128-bit RC4 encryption) and \&quot;256\&quot; (256-bit AES encryption).  Default is 256. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfgetannotations"></a>
# **EditPdfGetAnnotations**
> GetPdfAnnotationsResult EditPdfGetAnnotations (System.IO.Stream inputFile)

Get PDF annotations, including comments in the document

Enumerates the annotations, including comments and notes, in a PDF document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfGetAnnotationsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Get PDF annotations, including comments in the document
                GetPdfAnnotationsResult result = apiInstance.EditPdfGetAnnotations(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfGetAnnotations: " + e.Message );
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

[**GetPdfAnnotationsResult**](GetPdfAnnotationsResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfgetasyncjobstatus"></a>
# **EditPdfGetAsyncJobStatus**
> EditPdfJobStatusResult EditPdfGetAsyncJobStatus (string asyncJobID)

Get the status and result of a PDF Batch Job

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
    public class EditPdfGetAsyncJobStatusExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var asyncJobID = asyncJobID_example;  // string | 

            try
            {
                // Get the status and result of a PDF Batch Job
                EditPdfJobStatusResult result = apiInstance.EditPdfGetAsyncJobStatus(asyncJobID);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfGetAsyncJobStatus: " + e.Message );
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

[**EditPdfJobStatusResult**](EditPdfJobStatusResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfgetformfields"></a>
# **EditPdfGetFormFields**
> PdfFormFields EditPdfGetFormFields (System.IO.Stream inputFile)

Gets PDF Form fields and values

Encrypt a PDF document with a password.  Set an owner password to control owner (editor/creator) permissions, and set a user (reader) password to control the viewer of the PDF.  Set the password fields null to omit the given password.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfGetFormFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Gets PDF Form fields and values
                PdfFormFields result = apiInstance.EditPdfGetFormFields(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfGetFormFields: " + e.Message );
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

[**PdfFormFields**](PdfFormFields.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfgetmetadata"></a>
# **EditPdfGetMetadata**
> PdfMetadata EditPdfGetMetadata (System.IO.Stream inputFile)

Get PDF document metadata

Returns the metadata from the PDF document, including Title, Author, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfGetMetadataExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Get PDF document metadata
                PdfMetadata result = apiInstance.EditPdfGetMetadata(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfGetMetadata: " + e.Message );
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

[**PdfMetadata**](PdfMetadata.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfgetpdftextbypages"></a>
# **EditPdfGetPdfTextByPages**
> PdfTextByPageResult EditPdfGetPdfTextByPages (System.IO.Stream inputFile, string textFormattingMode = null)

Get text in a PDF document by page

Gets the text in a PDF by page

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfGetPdfTextByPagesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var textFormattingMode = textFormattingMode_example;  // string | Optional; specify how whitespace should be handled when converting the document to text.  Possible values are 'preserveWhitespace' which will attempt to preserve whitespace in the document and relative positioning of text within the document, and 'minimizeWhitespace' which will not insert additional spaces into the document in most cases.  Default is 'preserveWhitespace'. (optional) 

            try
            {
                // Get text in a PDF document by page
                PdfTextByPageResult result = apiInstance.EditPdfGetPdfTextByPages(inputFile, textFormattingMode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfGetPdfTextByPages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **textFormattingMode** | **string**| Optional; specify how whitespace should be handled when converting the document to text.  Possible values are &#39;preserveWhitespace&#39; which will attempt to preserve whitespace in the document and relative positioning of text within the document, and &#39;minimizeWhitespace&#39; which will not insert additional spaces into the document in most cases.  Default is &#39;preserveWhitespace&#39;. | [optional] 

### Return type

[**PdfTextByPageResult**](PdfTextByPageResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfinsertpages"></a>
# **EditPdfInsertPages**
> byte[] EditPdfInsertPages (System.IO.Stream sourceFile, System.IO.Stream destinationFile, int? pageStartSource, int? pageEndSource, int? pageInsertBeforeDesitnation)

Insert, copy pages from one PDF document into another

Copy one or more pages from one PDF document (source document) and insert them into a second PDF document (destination document).

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfInsertPagesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var sourceFile = new System.IO.Stream(); // System.IO.Stream | Source PDF file to copy pages from.
            var destinationFile = new System.IO.Stream(); // System.IO.Stream | Destination PDF file to copy pages into.
            var pageStartSource = 56;  // int? | Page number (1 based) to start copying pages from (inclusive) in the Source file.
            var pageEndSource = 56;  // int? | Page number (1 based) to stop copying pages pages from (inclusive) in the Source file.
            var pageInsertBeforeDesitnation = 56;  // int? | Page number (1 based) to insert the pages before in the Destination file.

            try
            {
                // Insert, copy pages from one PDF document into another
                byte[] result = apiInstance.EditPdfInsertPages(sourceFile, destinationFile, pageStartSource, pageEndSource, pageInsertBeforeDesitnation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfInsertPages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sourceFile** | **System.IO.Stream**| Source PDF file to copy pages from. | 
 **destinationFile** | **System.IO.Stream**| Destination PDF file to copy pages into. | 
 **pageStartSource** | **int?**| Page number (1 based) to start copying pages from (inclusive) in the Source file. | 
 **pageEndSource** | **int?**| Page number (1 based) to stop copying pages pages from (inclusive) in the Source file. | 
 **pageInsertBeforeDesitnation** | **int?**| Page number (1 based) to insert the pages before in the Destination file. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfinsertpagesbatchjob"></a>
# **EditPdfInsertPagesBatchJob**
> EditPdfBatchJobCreateResult EditPdfInsertPagesBatchJob (System.IO.Stream sourceFile, System.IO.Stream destinationFile, int? pageStartSource, int? pageEndSource, int? pageInsertBeforeDesitnation)

Insert, copy pages from one PDF document into another as a batch job

Copy one or more pages from one PDF document (source document) and insert them into a second PDF document (destination document).  Runs as a batch job async and returns a batch job ID that you can check the status of to get the result.  Requires Cloudmersive Private Cloud or Managed Instance.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfInsertPagesBatchJobExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var sourceFile = new System.IO.Stream(); // System.IO.Stream | Source PDF file to copy pages from.
            var destinationFile = new System.IO.Stream(); // System.IO.Stream | Destination PDF file to copy pages into.
            var pageStartSource = 56;  // int? | Page number (1 based) to start copying pages from (inclusive) in the Source file.
            var pageEndSource = 56;  // int? | Page number (1 based) to stop copying pages pages from (inclusive) in the Source file.
            var pageInsertBeforeDesitnation = 56;  // int? | Page number (1 based) to insert the pages before in the Destination file.

            try
            {
                // Insert, copy pages from one PDF document into another as a batch job
                EditPdfBatchJobCreateResult result = apiInstance.EditPdfInsertPagesBatchJob(sourceFile, destinationFile, pageStartSource, pageEndSource, pageInsertBeforeDesitnation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfInsertPagesBatchJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sourceFile** | **System.IO.Stream**| Source PDF file to copy pages from. | 
 **destinationFile** | **System.IO.Stream**| Destination PDF file to copy pages into. | 
 **pageStartSource** | **int?**| Page number (1 based) to start copying pages from (inclusive) in the Source file. | 
 **pageEndSource** | **int?**| Page number (1 based) to stop copying pages pages from (inclusive) in the Source file. | 
 **pageInsertBeforeDesitnation** | **int?**| Page number (1 based) to insert the pages before in the Destination file. | 

### Return type

[**EditPdfBatchJobCreateResult**](EditPdfBatchJobCreateResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdflinearize"></a>
# **EditPdfLinearize**
> byte[] EditPdfLinearize (System.IO.Stream inputFile)

Linearize and optimize a PDF for streaming download

Linearizes the content of a PDF to optimize it for streaming download, particularly over web streaming.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfLinearizeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Linearize and optimize a PDF for streaming download
                byte[] result = apiInstance.EditPdfLinearize(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfLinearize: " + e.Message );
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

<a name="editpdfrasterize"></a>
# **EditPdfRasterize**
> byte[] EditPdfRasterize (System.IO.Stream inputFile, int? dpi = null)

Rasterize a PDF to an image-based PDF

Rasterize a PDF into an image-based PDF.  The output is a PDF where each page is comprised of a high-resolution image, with all text, figures and other components removed.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfRasterizeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var dpi = 56;  // int? | Optional; configures the pixel density in Dots per Inch (DPI) (default is 300).  This parameter can only be used with Cloudmersive Managed Instance and Private Cloud. (optional) 

            try
            {
                // Rasterize a PDF to an image-based PDF
                byte[] result = apiInstance.EditPdfRasterize(inputFile, dpi);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfRasterize: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **dpi** | **int?**| Optional; configures the pixel density in Dots per Inch (DPI) (default is 300).  This parameter can only be used with Cloudmersive Managed Instance and Private Cloud. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfrasterizebatchjob"></a>
# **EditPdfRasterizeBatchJob**
> EditPdfBatchJobCreateResult EditPdfRasterizeBatchJob (System.IO.Stream inputFile)

Rasterize a PDF to an image-based PDF as Batch Job

Rasterize a PDF into an image-based PDF.  The output is a PDF where each page is comprised of a high-resolution image, with all text, figures and other components removed.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfRasterizeBatchJobExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Rasterize a PDF to an image-based PDF as Batch Job
                EditPdfBatchJobCreateResult result = apiInstance.EditPdfRasterizeBatchJob(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfRasterizeBatchJob: " + e.Message );
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

[**EditPdfBatchJobCreateResult**](EditPdfBatchJobCreateResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfreducefilesize"></a>
# **EditPdfReduceFileSize**
> byte[] EditPdfReduceFileSize (System.IO.Stream inputFile, decimal? quality = null)

Reduce the file size and optimize a PDF

Reduces the file size and optimizes the content of a PDF to minimize its file size.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfReduceFileSizeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var quality = 8.14;  // decimal? | Quality level for the images in the PDF, ranging from 0.0 (low quality) to 1.0 (high quality); default is 0.3 (optional) 

            try
            {
                // Reduce the file size and optimize a PDF
                byte[] result = apiInstance.EditPdfReduceFileSize(inputFile, quality);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfReduceFileSize: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **quality** | **decimal?**| Quality level for the images in the PDF, ranging from 0.0 (low quality) to 1.0 (high quality); default is 0.3 | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfremoveallannotations"></a>
# **EditPdfRemoveAllAnnotations**
> byte[] EditPdfRemoveAllAnnotations (System.IO.Stream inputFile)

Remove all PDF annotations, including comments in the document

Removes all of the annotations, including comments and notes, in a PDF document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfRemoveAllAnnotationsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Remove all PDF annotations, including comments in the document
                byte[] result = apiInstance.EditPdfRemoveAllAnnotations(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfRemoveAllAnnotations: " + e.Message );
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

<a name="editpdfremoveannotationitem"></a>
# **EditPdfRemoveAnnotationItem**
> byte[] EditPdfRemoveAnnotationItem (System.IO.Stream inputFile, int? annotationIndex)

Remove a specific PDF annotation, comment in the document

Removes a specific annotation in a PDF document, using the AnnotationIndex.  To enumerate AnnotationIndex for all of the annotations in the PDF document, use the /edit/pdf/annotations/list API.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfRemoveAnnotationItemExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var annotationIndex = 56;  // int? | The 0-based index of the annotation in the document

            try
            {
                // Remove a specific PDF annotation, comment in the document
                byte[] result = apiInstance.EditPdfRemoveAnnotationItem(inputFile, annotationIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfRemoveAnnotationItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **annotationIndex** | **int?**| The 0-based index of the annotation in the document | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfresize"></a>
# **EditPdfResize**
> byte[] EditPdfResize (System.IO.Stream inputFile, string paperSize)

Change PDF Document's Paper Size

Resizes a PDF document's paper size.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfResizeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var paperSize = paperSize_example;  // string | The desired paper size for the resized PDF document. Size ranges from A7 (smallest) to A0 (largest), and Letter, Legal, Tabloid, Ledger and B5.

            try
            {
                // Change PDF Document's Paper Size
                byte[] result = apiInstance.EditPdfResize(inputFile, paperSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfResize: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **paperSize** | **string**| The desired paper size for the resized PDF document. Size ranges from A7 (smallest) to A0 (largest), and Letter, Legal, Tabloid, Ledger and B5. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfrotateallpages"></a>
# **EditPdfRotateAllPages**
> byte[] EditPdfRotateAllPages (System.IO.Stream inputFile, int? rotationAngle)

Rotate all pages in a PDF document

Rotate all of the pages in a PDF document by a multiple of 90 degrees

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfRotateAllPagesExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var rotationAngle = 56;  // int? | The angle to rotate the page in degrees, must be a multiple of 90 degrees, e.g. 90, 180, 270, or -90, -180, -270, etc.

            try
            {
                // Rotate all pages in a PDF document
                byte[] result = apiInstance.EditPdfRotateAllPages(inputFile, rotationAngle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfRotateAllPages: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **rotationAngle** | **int?**| The angle to rotate the page in degrees, must be a multiple of 90 degrees, e.g. 90, 180, 270, or -90, -180, -270, etc. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfrotatepagerange"></a>
# **EditPdfRotatePageRange**
> byte[] EditPdfRotatePageRange (System.IO.Stream inputFile, int? rotationAngle, int? pageStart, int? pageEnd)

Rotate a range, subset of pages in a PDF document

Rotate a range of specific pages in a PDF document by a multiple of 90 degrees

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfRotatePageRangeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var rotationAngle = 56;  // int? | The angle to rotate the page in degrees, must be a multiple of 90 degrees, e.g. 90, 180, 270, or -90, -180, -270, etc.
            var pageStart = 56;  // int? | Page number (1 based) to start rotating pages from (inclusive).
            var pageEnd = 56;  // int? | Page number (1 based) to stop rotating pages from (inclusive).

            try
            {
                // Rotate a range, subset of pages in a PDF document
                byte[] result = apiInstance.EditPdfRotatePageRange(inputFile, rotationAngle, pageStart, pageEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfRotatePageRange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **rotationAngle** | **int?**| The angle to rotate the page in degrees, must be a multiple of 90 degrees, e.g. 90, 180, 270, or -90, -180, -270, etc. | 
 **pageStart** | **int?**| Page number (1 based) to start rotating pages from (inclusive). | 
 **pageEnd** | **int?**| Page number (1 based) to stop rotating pages from (inclusive). | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfsanitize"></a>
# **EditPdfSanitize**
> Object EditPdfSanitize ()

Sanitize a PDF by removing embedded JavaScript

Removes embedded JavaScript from a PDF file.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfSanitizeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();

            try
            {
                // Sanitize a PDF by removing embedded JavaScript
                Object result = apiInstance.EditPdfSanitize();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfSanitize: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfsetformfields"></a>
# **EditPdfSetFormFields**
> byte[] EditPdfSetFormFields (SetPdfFormFieldsRequest fieldValues)

Sets ands fills PDF Form field values

Fill in the form fields in a PDF form with specific values.  Use form/get-fields to enumerate the available fields and their data types in an input form.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfSetFormFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var fieldValues = new SetPdfFormFieldsRequest(); // SetPdfFormFieldsRequest | 

            try
            {
                // Sets ands fills PDF Form field values
                byte[] result = apiInstance.EditPdfSetFormFields(fieldValues);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfSetFormFields: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldValues** | [**SetPdfFormFieldsRequest**](SetPdfFormFieldsRequest.md)|  | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfsetmetadata"></a>
# **EditPdfSetMetadata**
> byte[] EditPdfSetMetadata (SetPdfMetadataRequest request)

Sets PDF document metadata

Sets (writes) metadata into the input PDF document, including Title, Author, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfSetMetadataExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var request = new SetPdfMetadataRequest(); // SetPdfMetadataRequest | 

            try
            {
                // Sets PDF document metadata
                byte[] result = apiInstance.EditPdfSetMetadata(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfSetMetadata: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SetPdfMetadataRequest**](SetPdfMetadataRequest.md)|  | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfsetpermissions"></a>
# **EditPdfSetPermissions**
> byte[] EditPdfSetPermissions (string ownerPassword, string userPassword, System.IO.Stream inputFile, string encryptionKeyLength = null, bool? allowPrinting = null, bool? allowDocumentAssembly = null, bool? allowContentExtraction = null, bool? allowFormFilling = null, bool? allowEditing = null, bool? allowAnnotations = null, bool? allowDegradedPrinting = null)

Encrypt, password-protect and set restricted permissions on a PDF

Encrypt a PDF document with a password, and set permissions on the PDF.  Set an owner password to control owner (editor/creator) permissions [required], and set a user (reader) password to control the viewer of the PDF [optional].  Set the reader password to null to omit the password.  Restrict or allow printing, copying content, document assembly, editing (read-only), form filling, modification of annotations, and degraded printing through document Digital Rights Management (DRM).

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfSetPermissionsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var ownerPassword = ownerPassword_example;  // string | Password of a owner (creator/editor) of the PDF file (required)
            var userPassword = userPassword_example;  // string | Password of a user (reader) of the PDF file (optional)
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var encryptionKeyLength = encryptionKeyLength_example;  // string | Possible values are \"128\" (128-bit RC4 encryption) and \"256\" (256-bit AES encryption).  Default is 256. (optional) 
            var allowPrinting = true;  // bool? | Set to false to disable printing through DRM.  Default is true. (optional) 
            var allowDocumentAssembly = true;  // bool? | Set to false to disable document assembly through DRM.  Default is true. (optional) 
            var allowContentExtraction = true;  // bool? | Set to false to disable copying/extracting content out of the PDF through DRM.  Default is true. (optional) 
            var allowFormFilling = true;  // bool? | Set to false to disable filling out form fields in the PDF through DRM.  Default is true. (optional) 
            var allowEditing = true;  // bool? | Set to false to disable editing in the PDF through DRM (making the PDF read-only).  Default is true. (optional) 
            var allowAnnotations = true;  // bool? | Set to false to disable annotations and editing of annotations in the PDF through DRM.  Default is true. (optional) 
            var allowDegradedPrinting = true;  // bool? | Set to false to disable degraded printing of the PDF through DRM.  Default is true. (optional) 

            try
            {
                // Encrypt, password-protect and set restricted permissions on a PDF
                byte[] result = apiInstance.EditPdfSetPermissions(ownerPassword, userPassword, inputFile, encryptionKeyLength, allowPrinting, allowDocumentAssembly, allowContentExtraction, allowFormFilling, allowEditing, allowAnnotations, allowDegradedPrinting);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfSetPermissions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ownerPassword** | **string**| Password of a owner (creator/editor) of the PDF file (required) | 
 **userPassword** | **string**| Password of a user (reader) of the PDF file (optional) | 
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **encryptionKeyLength** | **string**| Possible values are \&quot;128\&quot; (128-bit RC4 encryption) and \&quot;256\&quot; (256-bit AES encryption).  Default is 256. | [optional] 
 **allowPrinting** | **bool?**| Set to false to disable printing through DRM.  Default is true. | [optional] 
 **allowDocumentAssembly** | **bool?**| Set to false to disable document assembly through DRM.  Default is true. | [optional] 
 **allowContentExtraction** | **bool?**| Set to false to disable copying/extracting content out of the PDF through DRM.  Default is true. | [optional] 
 **allowFormFilling** | **bool?**| Set to false to disable filling out form fields in the PDF through DRM.  Default is true. | [optional] 
 **allowEditing** | **bool?**| Set to false to disable editing in the PDF through DRM (making the PDF read-only).  Default is true. | [optional] 
 **allowAnnotations** | **bool?**| Set to false to disable annotations and editing of annotations in the PDF through DRM.  Default is true. | [optional] 
 **allowDegradedPrinting** | **bool?**| Set to false to disable degraded printing of the PDF through DRM.  Default is true. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editpdfwatermarktext"></a>
# **EditPdfWatermarkText**
> byte[] EditPdfWatermarkText (string watermarkText, System.IO.Stream inputFile, string fontName = null, decimal? fontSize = null, string fontColor = null, decimal? fontTransparency = null)

Add a text watermark to a PDF

Adds a text watermark to a PDF

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditPdfWatermarkTextExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditPdfApi();
            var watermarkText = watermarkText_example;  // string | Watermark text to add to the PDF (required)
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var fontName = fontName_example;  // string | Font Family Name for the watermark text; default is Times New Roman (optional) 
            var fontSize = 8.14;  // decimal? | Font Size in points of the text; default is 150 (optional) 
            var fontColor = fontColor_example;  // string | Font color in hexadecimal or HTML color name; default is Red (optional) 
            var fontTransparency = 8.14;  // decimal? | Font transparency between 0.0 (completely transparent) to 1.0 (fully opaque); default is 0.5 (optional) 

            try
            {
                // Add a text watermark to a PDF
                byte[] result = apiInstance.EditPdfWatermarkText(watermarkText, inputFile, fontName, fontSize, fontColor, fontTransparency);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditPdfApi.EditPdfWatermarkText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **watermarkText** | **string**| Watermark text to add to the PDF (required) | 
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **fontName** | **string**| Font Family Name for the watermark text; default is Times New Roman | [optional] 
 **fontSize** | **decimal?**| Font Size in points of the text; default is 150 | [optional] 
 **fontColor** | **string**| Font color in hexadecimal or HTML color name; default is Red | [optional] 
 **fontTransparency** | **decimal?**| Font transparency between 0.0 (completely transparent) to 1.0 (fully opaque); default is 0.5 | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

