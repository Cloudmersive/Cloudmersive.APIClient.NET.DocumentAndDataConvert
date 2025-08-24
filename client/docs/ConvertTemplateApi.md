# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.ConvertTemplateApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertTemplateApplyDocxTemplate**](ConvertTemplateApi.md#converttemplateapplydocxtemplate) | **POST** /convert/template/docx/apply | Apply Word DOCX template
[**ConvertTemplateApplyHtmlTemplate**](ConvertTemplateApi.md#converttemplateapplyhtmltemplate) | **POST** /convert/template/html/apply | Apply HTML template


<a name="converttemplateapplydocxtemplate"></a>
# **ConvertTemplateApplyDocxTemplate**
> byte[] ConvertTemplateApplyDocxTemplate (System.IO.Stream inputFile, Object templateDefinition = null)

Apply Word DOCX template

Apply operations to fill in a Word DOCX template by replacing target template/placeholder strings in the DOCX with values, generating a final Word DOCX result.  For example, you could create a Word Document invoice containing strings such as \"{FirstName}\" and \"{LastName}\" and then replace these values with \"John\" and \"Smith\".

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertTemplateApplyDocxTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertTemplateApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var templateDefinition = new Object(); // Object | Template definition for the document, including what values to replace (optional) 

            try
            {
                // Apply Word DOCX template
                byte[] result = apiInstance.ConvertTemplateApplyDocxTemplate(inputFile, templateDefinition);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertTemplateApi.ConvertTemplateApplyDocxTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **templateDefinition** | [**Object**](Object.md)| Template definition for the document, including what values to replace | [optional] 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="converttemplateapplyhtmltemplate"></a>
# **ConvertTemplateApplyHtmlTemplate**
> HtmlTemplateApplicationResponse ConvertTemplateApplyHtmlTemplate (HtmlTemplateApplicationRequest value)

Apply HTML template

Apply operations to fill in an HTML template, generating a final HTML result

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertTemplateApplyHtmlTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertTemplateApi();
            var value = new HtmlTemplateApplicationRequest(); // HtmlTemplateApplicationRequest | Operations to apply to template

            try
            {
                // Apply HTML template
                HtmlTemplateApplicationResponse result = apiInstance.ConvertTemplateApplyHtmlTemplate(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertTemplateApi.ConvertTemplateApplyHtmlTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | [**HtmlTemplateApplicationRequest**](HtmlTemplateApplicationRequest.md)| Operations to apply to template | 

### Return type

[**HtmlTemplateApplicationResponse**](HtmlTemplateApplicationResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

