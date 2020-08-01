# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.EditHtmlApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditHtmlHtmlAppendHeading**](EditHtmlApi.md#edithtmlhtmlappendheading) | **POST** /convert/edit/html/append/heading | Append a Heading to an HTML Document
[**EditHtmlHtmlAppendImageFromUrl**](EditHtmlApi.md#edithtmlhtmlappendimagefromurl) | **POST** /convert/edit/html/append/image/from-url | Append an Image to an HTML Document from a URL
[**EditHtmlHtmlAppendImageInline**](EditHtmlApi.md#edithtmlhtmlappendimageinline) | **POST** /convert/edit/html/append/image/inline | Append a Base64 Inline Image to an HTML Document
[**EditHtmlHtmlAppendParagraph**](EditHtmlApi.md#edithtmlhtmlappendparagraph) | **POST** /convert/edit/html/append/paragraph | Append a Paragraph to an HTML Document


<a name="edithtmlhtmlappendheading"></a>
# **EditHtmlHtmlAppendHeading**
> byte[] EditHtmlHtmlAppendHeading (string headingText, System.IO.Stream inputFile = null, string inputFileUrl = null, int? headingSize = null)

Append a Heading to an HTML Document

Appends a heading to the end of an HTML document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditHtmlHtmlAppendHeadingExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditHtmlApi();
            var headingText = headingText_example;  // string | The text content to be used in the header.
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Optional: Input file to perform the operation on. (optional) 
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). (optional) 
            var headingSize = 56;  // int? | Optional: The heading size number. Default is 1. (optional) 

            try
            {
                // Append a Heading to an HTML Document
                byte[] result = apiInstance.EditHtmlHtmlAppendHeading(headingText, inputFile, inputFileUrl, headingSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditHtmlApi.EditHtmlHtmlAppendHeading: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **headingText** | **string**| The text content to be used in the header. | 
 **inputFile** | **System.IO.Stream**| Optional: Input file to perform the operation on. | [optional] 
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
 **headingSize** | **int?**| Optional: The heading size number. Default is 1. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edithtmlhtmlappendimagefromurl"></a>
# **EditHtmlHtmlAppendImageFromUrl**
> byte[] EditHtmlHtmlAppendImageFromUrl (string imageUrl, System.IO.Stream inputFile = null, string inputFileUrl = null, string cssStyle = null)

Append an Image to an HTML Document from a URL

Appends an image to the end of an HTML document using a URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditHtmlHtmlAppendImageFromUrlExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditHtmlApi();
            var imageUrl = imageUrl_example;  // string | The URL for the image.
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Optional: Input file to perform the operation on. (optional) 
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). (optional) 
            var cssStyle = cssStyle_example;  // string | Optional: CSS style for the image. (optional) 

            try
            {
                // Append an Image to an HTML Document from a URL
                byte[] result = apiInstance.EditHtmlHtmlAppendImageFromUrl(imageUrl, inputFile, inputFileUrl, cssStyle);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditHtmlApi.EditHtmlHtmlAppendImageFromUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageUrl** | **string**| The URL for the image. | 
 **inputFile** | **System.IO.Stream**| Optional: Input file to perform the operation on. | [optional] 
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
 **cssStyle** | **string**| Optional: CSS style for the image. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edithtmlhtmlappendimageinline"></a>
# **EditHtmlHtmlAppendImageInline**
> byte[] EditHtmlHtmlAppendImageInline (System.IO.Stream inputFile = null, string inputFileUrl = null, System.IO.Stream imageFile = null, string imageUrl = null, string cssStyle = null, string imageExtension = null)

Append a Base64 Inline Image to an HTML Document

Appends a base64 inline image to the end of an HTML document from an input file or URL.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditHtmlHtmlAppendImageInlineExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditHtmlApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Optional: Input file to perform the operation on. (optional) 
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). (optional) 
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Optional: Image file to be appended as base64 inline image. (optional) 
            var imageUrl = imageUrl_example;  // string | Optional: Image URL to be appended as base64 inline image. (optional) 
            var cssStyle = cssStyle_example;  // string | Optional: CSS style for the image. (optional) 
            var imageExtension = imageExtension_example;  // string | Optional: The extension (JPG, PNG, GIF, etc.) of the image file. Recommended if uploading a file directly, such as with a byte array. If no extension can be determined, will default to JPG. (optional) 

            try
            {
                // Append a Base64 Inline Image to an HTML Document
                byte[] result = apiInstance.EditHtmlHtmlAppendImageInline(inputFile, inputFileUrl, imageFile, imageUrl, cssStyle, imageExtension);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditHtmlApi.EditHtmlHtmlAppendImageInline: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Optional: Input file to perform the operation on. | [optional] 
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
 **imageFile** | **System.IO.Stream**| Optional: Image file to be appended as base64 inline image. | [optional] 
 **imageUrl** | **string**| Optional: Image URL to be appended as base64 inline image. | [optional] 
 **cssStyle** | **string**| Optional: CSS style for the image. | [optional] 
 **imageExtension** | **string**| Optional: The extension (JPG, PNG, GIF, etc.) of the image file. Recommended if uploading a file directly, such as with a byte array. If no extension can be determined, will default to JPG. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edithtmlhtmlappendparagraph"></a>
# **EditHtmlHtmlAppendParagraph**
> byte[] EditHtmlHtmlAppendParagraph (string paragraphText, System.IO.Stream inputFile = null, string inputFileUrl = null)

Append a Paragraph to an HTML Document

Appends a paragraph to the end of an HTML document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditHtmlHtmlAppendParagraphExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditHtmlApi();
            var paragraphText = paragraphText_example;  // string | The text content to be used in the paragraph.
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Optional: Input file to perform the operation on. (optional) 
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). (optional) 

            try
            {
                // Append a Paragraph to an HTML Document
                byte[] result = apiInstance.EditHtmlHtmlAppendParagraph(paragraphText, inputFile, inputFileUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditHtmlApi.EditHtmlHtmlAppendParagraph: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paragraphText** | **string**| The text content to be used in the paragraph. | 
 **inputFile** | **System.IO.Stream**| Optional: Input file to perform the operation on. | [optional] 
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API (part of EditDocumentApi) to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

