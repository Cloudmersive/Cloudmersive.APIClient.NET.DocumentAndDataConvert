# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.EditTextApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EditTextBase64Decode**](EditTextApi.md#edittextbase64decode) | **POST** /convert/edit/text/encoding/base64/decode | Base 64 decode, convert base 64 string to binary content
[**EditTextBase64Detect**](EditTextApi.md#edittextbase64detect) | **POST** /convert/edit/text/encoding/base64/detect | Detect, check if text string is base 64 encoded
[**EditTextBase64Encode**](EditTextApi.md#edittextbase64encode) | **POST** /convert/edit/text/encoding/base64/encode | Base 64 encode, convert binary or file data to a text string
[**EditTextChangeLineEndings**](EditTextApi.md#edittextchangelineendings) | **POST** /convert/edit/text/line-endings/change | Set, change line endings of a text file
[**EditTextDetectLineEndings**](EditTextApi.md#edittextdetectlineendings) | **POST** /convert/edit/text/line-endings/detect | Detect line endings of a text file
[**EditTextFindRegex**](EditTextApi.md#edittextfindregex) | **POST** /convert/edit/text/find/regex | Find a regular expression regex in text input
[**EditTextFindSimple**](EditTextApi.md#edittextfindsimple) | **POST** /convert/edit/text/find/string | Find a string in text input
[**EditTextRemoveAllWhitespace**](EditTextApi.md#edittextremoveallwhitespace) | **POST** /convert/edit/text/remove/whitespace/all | Remove whitespace from text string
[**EditTextRemoveHtml**](EditTextApi.md#edittextremovehtml) | **POST** /convert/edit/text/remove/html | Remove HTML from text string
[**EditTextReplaceRegex**](EditTextApi.md#edittextreplaceregex) | **POST** /convert/edit/text/replace/regex | Replace a string in text with a regex regular expression string
[**EditTextReplaceSimple**](EditTextApi.md#edittextreplacesimple) | **POST** /convert/edit/text/replace/string | Replace a string in text with another string value
[**EditTextTextEncodingDetect**](EditTextApi.md#edittexttextencodingdetect) | **POST** /convert/edit/text/encoding/detect | Detect text encoding of file
[**EditTextTrimWhitespace**](EditTextApi.md#edittexttrimwhitespace) | **POST** /convert/edit/text/remove/whitespace/trim | Trim leading and trailing whitespace from text string


<a name="edittextbase64decode"></a>
# **EditTextBase64Decode**
> Base64DecodeResponse EditTextBase64Decode (Base64DecodeRequest request)

Base 64 decode, convert base 64 string to binary content

Decodes / converts base 64 UTF-8 text string to binary content

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextBase64DecodeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new Base64DecodeRequest(); // Base64DecodeRequest | Input request

            try
            {
                // Base 64 decode, convert base 64 string to binary content
                Base64DecodeResponse result = apiInstance.EditTextBase64Decode(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextBase64Decode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**Base64DecodeRequest**](Base64DecodeRequest.md)| Input request | 

### Return type

[**Base64DecodeResponse**](Base64DecodeResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextbase64detect"></a>
# **EditTextBase64Detect**
> Base64DetectResponse EditTextBase64Detect (Base64DetectRequest request)

Detect, check if text string is base 64 encoded

Checks, detects if input string is base 64 encoded

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextBase64DetectExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new Base64DetectRequest(); // Base64DetectRequest | Input request

            try
            {
                // Detect, check if text string is base 64 encoded
                Base64DetectResponse result = apiInstance.EditTextBase64Detect(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextBase64Detect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**Base64DetectRequest**](Base64DetectRequest.md)| Input request | 

### Return type

[**Base64DetectResponse**](Base64DetectResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextbase64encode"></a>
# **EditTextBase64Encode**
> Base64EncodeResponse EditTextBase64Encode (Base64EncodeRequest request)

Base 64 encode, convert binary or file data to a text string

Encodes / converts binary or file data to a text string

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextBase64EncodeExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new Base64EncodeRequest(); // Base64EncodeRequest | Input request

            try
            {
                // Base 64 encode, convert binary or file data to a text string
                Base64EncodeResponse result = apiInstance.EditTextBase64Encode(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextBase64Encode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**Base64EncodeRequest**](Base64EncodeRequest.md)| Input request | 

### Return type

[**Base64EncodeResponse**](Base64EncodeResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextchangelineendings"></a>
# **EditTextChangeLineEndings**
> ChangeLineEndingResponse EditTextChangeLineEndings (string lineEndingType, System.IO.Stream inputFile)

Set, change line endings of a text file

Sets the line ending type of a text file; set to Windows, Unix or Mac.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextChangeLineEndingsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var lineEndingType = lineEndingType_example;  // string | Required; 'Windows' will use carriage return and line feed, 'Unix' will use newline, and 'Mac' will use carriage return
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Set, change line endings of a text file
                ChangeLineEndingResponse result = apiInstance.EditTextChangeLineEndings(lineEndingType, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextChangeLineEndings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **lineEndingType** | **string**| Required; &#39;Windows&#39; will use carriage return and line feed, &#39;Unix&#39; will use newline, and &#39;Mac&#39; will use carriage return | 
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**ChangeLineEndingResponse**](ChangeLineEndingResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextdetectlineendings"></a>
# **EditTextDetectLineEndings**
> DetectLineEndingsResponse EditTextDetectLineEndings (System.IO.Stream inputFile)

Detect line endings of a text file

Detect line ending type (Windows, Unix or Mac) of an input file.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextDetectLineEndingsExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Detect line endings of a text file
                DetectLineEndingsResponse result = apiInstance.EditTextDetectLineEndings(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextDetectLineEndings: " + e.Message );
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

[**DetectLineEndingsResponse**](DetectLineEndingsResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextfindregex"></a>
# **EditTextFindRegex**
> FindStringRegexResponse EditTextFindRegex (FindStringRegexRequest request)

Find a regular expression regex in text input

Find all occurrences of the input regular expression in the input content, and returns the matches

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextFindRegexExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new FindStringRegexRequest(); // FindStringRegexRequest | Input request

            try
            {
                // Find a regular expression regex in text input
                FindStringRegexResponse result = apiInstance.EditTextFindRegex(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextFindRegex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**FindStringRegexRequest**](FindStringRegexRequest.md)| Input request | 

### Return type

[**FindStringRegexResponse**](FindStringRegexResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextfindsimple"></a>
# **EditTextFindSimple**
> FindStringSimpleResponse EditTextFindSimple (FindStringSimpleRequest request)

Find a string in text input

Finds all occurrences of the input string in the input content, and returns the matches

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextFindSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new FindStringSimpleRequest(); // FindStringSimpleRequest | Input request

            try
            {
                // Find a string in text input
                FindStringSimpleResponse result = apiInstance.EditTextFindSimple(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextFindSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**FindStringSimpleRequest**](FindStringSimpleRequest.md)| Input request | 

### Return type

[**FindStringSimpleResponse**](FindStringSimpleResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextremoveallwhitespace"></a>
# **EditTextRemoveAllWhitespace**
> RemoveWhitespaceFromTextResponse EditTextRemoveAllWhitespace (RemoveWhitespaceFromTextRequest request)

Remove whitespace from text string

Removes all whitespace from text, leaving behind only non-whitespace characters.  Whitespace includes newlines, spaces and other whitespace characters.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextRemoveAllWhitespaceExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new RemoveWhitespaceFromTextRequest(); // RemoveWhitespaceFromTextRequest | Input request

            try
            {
                // Remove whitespace from text string
                RemoveWhitespaceFromTextResponse result = apiInstance.EditTextRemoveAllWhitespace(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextRemoveAllWhitespace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RemoveWhitespaceFromTextRequest**](RemoveWhitespaceFromTextRequest.md)| Input request | 

### Return type

[**RemoveWhitespaceFromTextResponse**](RemoveWhitespaceFromTextResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextremovehtml"></a>
# **EditTextRemoveHtml**
> RemoveHtmlFromTextResponse EditTextRemoveHtml (RemoveHtmlFromTextRequest request)

Remove HTML from text string

Removes HTML from text, leaving behind only text.  Formatted text will become plain text.  Important for protecting against HTML and Cross-Site-Scripting attacks.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextRemoveHtmlExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new RemoveHtmlFromTextRequest(); // RemoveHtmlFromTextRequest | Input request

            try
            {
                // Remove HTML from text string
                RemoveHtmlFromTextResponse result = apiInstance.EditTextRemoveHtml(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextRemoveHtml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RemoveHtmlFromTextRequest**](RemoveHtmlFromTextRequest.md)| Input request | 

### Return type

[**RemoveHtmlFromTextResponse**](RemoveHtmlFromTextResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextreplaceregex"></a>
# **EditTextReplaceRegex**
> ReplaceStringRegexResponse EditTextReplaceRegex (ReplaceStringRegexRequest request)

Replace a string in text with a regex regular expression string

Replaces all occurrences of the input regular expression regex string in the input content, and returns the result

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextReplaceRegexExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new ReplaceStringRegexRequest(); // ReplaceStringRegexRequest | Input request

            try
            {
                // Replace a string in text with a regex regular expression string
                ReplaceStringRegexResponse result = apiInstance.EditTextReplaceRegex(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextReplaceRegex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ReplaceStringRegexRequest**](ReplaceStringRegexRequest.md)| Input request | 

### Return type

[**ReplaceStringRegexResponse**](ReplaceStringRegexResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittextreplacesimple"></a>
# **EditTextReplaceSimple**
> ReplaceStringSimpleResponse EditTextReplaceSimple (ReplaceStringSimpleRequest request)

Replace a string in text with another string value

Replaces all occurrences of the input string in the input content, and returns the result

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextReplaceSimpleExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new ReplaceStringSimpleRequest(); // ReplaceStringSimpleRequest | Input request

            try
            {
                // Replace a string in text with another string value
                ReplaceStringSimpleResponse result = apiInstance.EditTextReplaceSimple(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextReplaceSimple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**ReplaceStringSimpleRequest**](ReplaceStringSimpleRequest.md)| Input request | 

### Return type

[**ReplaceStringSimpleResponse**](ReplaceStringSimpleResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittexttextencodingdetect"></a>
# **EditTextTextEncodingDetect**
> TextEncodingDetectResponse EditTextTextEncodingDetect (System.IO.Stream inputFile)

Detect text encoding of file

Checks text encoding of file

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextTextEncodingDetectExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Detect text encoding of file
                TextEncodingDetectResponse result = apiInstance.EditTextTextEncodingDetect(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextTextEncodingDetect: " + e.Message );
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

[**TextEncodingDetectResponse**](TextEncodingDetectResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="edittexttrimwhitespace"></a>
# **EditTextTrimWhitespace**
> RemoveWhitespaceFromTextResponse EditTextTrimWhitespace (RemoveWhitespaceFromTextRequest request)

Trim leading and trailing whitespace from text string

Trim leading and trailing whitespace from text, leaving behind a trimmed string.  Whitespace includes newlines, spaces and other whitespace characters.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class EditTextTrimWhitespaceExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new EditTextApi();
            var request = new RemoveWhitespaceFromTextRequest(); // RemoveWhitespaceFromTextRequest | Input request

            try
            {
                // Trim leading and trailing whitespace from text string
                RemoveWhitespaceFromTextResponse result = apiInstance.EditTextTrimWhitespace(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EditTextApi.EditTextTrimWhitespace: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**RemoveWhitespaceFromTextRequest**](RemoveWhitespaceFromTextRequest.md)| Input request | 

### Return type

[**RemoveWhitespaceFromTextResponse**](RemoveWhitespaceFromTextResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

