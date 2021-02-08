# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.EditHtmlApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditHtmlHtmlAppendHeading**](EditHtmlApi.md#edithtmlhtmlappendheading) | **POST** /convert/edit/html/append/heading | Append a Heading to an HTML Document
[**EditHtmlHtmlAppendImageFromUrl**](EditHtmlApi.md#edithtmlhtmlappendimagefromurl) | **POST** /convert/edit/html/append/image/from-url | Append an Image to an HTML Document from a URL
[**EditHtmlHtmlAppendImageInline**](EditHtmlApi.md#edithtmlhtmlappendimageinline) | **POST** /convert/edit/html/append/image/inline | Append a Base64 Inline Image to an HTML Document
[**EditHtmlHtmlAppendParagraph**](EditHtmlApi.md#edithtmlhtmlappendparagraph) | **POST** /convert/edit/html/append/paragraph | Append a Paragraph to an HTML Document
[**EditHtmlHtmlCreateBlankDocument**](EditHtmlApi.md#edithtmlhtmlcreateblankdocument) | **POST** /convert/edit/html/create/blank | Create a Blank HTML Document
[**EditHtmlHtmlGetLinks**](EditHtmlApi.md#edithtmlhtmlgetlinks) | **POST** /convert/edit/html/extract/links | Extract resolved link URLs from HTML File


<a name="edithtmlhtmlappendheading"></a>
# **EditHtmlHtmlAppendHeading**
> byte[] EditHtmlHtmlAppendHeading (string headingText, System.IO.Stream inputFile = null, string inputFileUrl = null, int? headingSize = null, string cssStyle = null)

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
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input. (optional) 
            var headingSize = 56;  // int? | Optional: The heading size number. Default is 1. Accepts values between 1 and 6. (optional) 
            var cssStyle = cssStyle_example;  // string | Optional: The CSS style for the heading. (optional) 

            try
            {
                // Append a Heading to an HTML Document
                byte[] result = apiInstance.EditHtmlHtmlAppendHeading(headingText, inputFile, inputFileUrl, headingSize, cssStyle);
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
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input. | [optional] 
 **headingSize** | **int?**| Optional: The heading size number. Default is 1. Accepts values between 1 and 6. | [optional] 
 **cssStyle** | **string**| Optional: The CSS style for the heading. | [optional] 

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
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input. (optional) 
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
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input. | [optional] 
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
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input. (optional) 
            var imageFile = new System.IO.Stream(); // System.IO.Stream | Optional: Image file to be appended as base64 inline image. (optional) 
            var imageUrl = imageUrl_example;  // string | Optional: Image URL to be appended as base64 inline image. (optional) 
            var cssStyle = cssStyle_example;  // string | Optional: CSS style for the image. (optional) 
            var imageExtension = imageExtension_example;  // string | Optional: The extension (JPG, PNG, GIF, etc.) of the image file. Recommended if uploading an imageFile directly, instead of using imageUrl. If no extension can be determined, will default to JPG. (optional) 

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
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input. | [optional] 
 **imageFile** | **System.IO.Stream**| Optional: Image file to be appended as base64 inline image. | [optional] 
 **imageUrl** | **string**| Optional: Image URL to be appended as base64 inline image. | [optional] 
 **cssStyle** | **string**| Optional: CSS style for the image. | [optional] 
 **imageExtension** | **string**| Optional: The extension (JPG, PNG, GIF, etc.) of the image file. Recommended if uploading an imageFile directly, instead of using imageUrl. If no extension can be determined, will default to JPG. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edithtmlhtmlappendparagraph"></a>
# **EditHtmlHtmlAppendParagraph**
> byte[] EditHtmlHtmlAppendParagraph (string paragraphText, System.IO.Stream inputFile = null, string inputFileUrl = null, string cssStyle = null)

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
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input. (optional) 
            var cssStyle = cssStyle_example;  // string | Optional: The CSS style for the paragraph. (optional) 

            try
            {
                // Append a Paragraph to an HTML Document
                byte[] result = apiInstance.EditHtmlHtmlAppendParagraph(paragraphText, inputFile, inputFileUrl, cssStyle);
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
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input. | [optional] 
 **cssStyle** | **string**| Optional: The CSS style for the paragraph. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edithtmlhtmlcreateblankdocument"></a>
# **EditHtmlHtmlCreateBlankDocument**
> byte[] EditHtmlHtmlCreateBlankDocument (string title = null, string cssUrl = null, string cssInline = null, string javascriptUrl = null, string javascriptInline = null)

Create a Blank HTML Document

Returns a blank HTML Document format file.  The file is blank, with no contents by default.  Use the optional input parameters to add various starting elements.  Use additional editing commands such as Append Header, Append Paragraph or Append Image from URL to populate the document.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditHtmlHtmlCreateBlankDocumentExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditHtmlApi();
            var title = title_example;  // string | Optional: The title of the HTML document (optional) 
            var cssUrl = cssUrl_example;  // string | Optional: A CSS style URL to be added to the document. (optional) 
            var cssInline = cssInline_example;  // string | Optional: An inline CSS style to be added to the document. (optional) 
            var javascriptUrl = javascriptUrl_example;  // string | Optional: Javascript URL to be added to the document. (optional) 
            var javascriptInline = javascriptInline_example;  // string | Optional: Inline Javascript to be added to the document. (optional) 

            try
            {
                // Create a Blank HTML Document
                byte[] result = apiInstance.EditHtmlHtmlCreateBlankDocument(title, cssUrl, cssInline, javascriptUrl, javascriptInline);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditHtmlApi.EditHtmlHtmlCreateBlankDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**| Optional: The title of the HTML document | [optional] 
 **cssUrl** | **string**| Optional: A CSS style URL to be added to the document. | [optional] 
 **cssInline** | **string**| Optional: An inline CSS style to be added to the document. | [optional] 
 **javascriptUrl** | **string**| Optional: Javascript URL to be added to the document. | [optional] 
 **javascriptInline** | **string**| Optional: Inline Javascript to be added to the document. | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edithtmlhtmlgetlinks"></a>
# **EditHtmlHtmlGetLinks**
> HtmlGetLinksResponse EditHtmlHtmlGetLinks (System.IO.Stream inputFile = null, string inputFileUrl = null, string baseUrl = null)

Extract resolved link URLs from HTML File

Extracts the resolved link URLs, fully-qualified if possible, from an input HTML file.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditHtmlHtmlGetLinksExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditHtmlApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Optional: Input file to perform the operation on. (optional) 
            var inputFileUrl = inputFileUrl_example;  // string | Optional: URL of a file to operate on as input. (optional) 
            var baseUrl = baseUrl_example;  // string | Optional: Base URL of the page, such as https://mydomain.com (optional) 

            try
            {
                // Extract resolved link URLs from HTML File
                HtmlGetLinksResponse result = apiInstance.EditHtmlHtmlGetLinks(inputFile, inputFileUrl, baseUrl);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditHtmlApi.EditHtmlHtmlGetLinks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Optional: Input file to perform the operation on. | [optional] 
 **inputFileUrl** | **string**| Optional: URL of a file to operate on as input. | [optional] 
 **baseUrl** | **string**| Optional: Base URL of the page, such as https://mydomain.com | [optional] 

### Return type

[**HtmlGetLinksResponse**](HtmlGetLinksResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

