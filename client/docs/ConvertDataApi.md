# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.ConvertDataApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertDataCsvToJson**](ConvertDataApi.md#convertdatacsvtojson) | **POST** /convert/csv/to/json | Convert CSV to JSON conversion
[**ConvertDataXlsToJson**](ConvertDataApi.md#convertdataxlstojson) | **POST** /convert/xls/to/json | Convert Excel (97-2003) XLS to JSON conversion
[**ConvertDataXlsxToJson**](ConvertDataApi.md#convertdataxlsxtojson) | **POST** /convert/xlsx/to/json | Convert Excel XLSX to JSON conversion
[**ConvertDataXmlToJson**](ConvertDataApi.md#convertdataxmltojson) | **POST** /convert/xml/to/json | Convert XML to JSON conversion


<a name="convertdatacsvtojson"></a>
# **ConvertDataCsvToJson**
> Object ConvertDataCsvToJson (System.IO.Stream inputFile)

Convert CSV to JSON conversion

Convert a CSV file to a JSON object array

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataCsvToJsonExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert CSV to JSON conversion
                Object result = apiInstance.ConvertDataCsvToJson(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataCsvToJson: " + e.Message );
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

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxlstojson"></a>
# **ConvertDataXlsToJson**
> Object ConvertDataXlsToJson (System.IO.Stream inputFile)

Convert Excel (97-2003) XLS to JSON conversion

Convert an Excel (97-2003) XLS file to a JSON object array

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXlsToJsonExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Excel (97-2003) XLS to JSON conversion
                Object result = apiInstance.ConvertDataXlsToJson(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXlsToJson: " + e.Message );
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

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxlsxtojson"></a>
# **ConvertDataXlsxToJson**
> Object ConvertDataXlsxToJson (System.IO.Stream inputFile)

Convert Excel XLSX to JSON conversion

Convert an Excel XLSX file to a JSON object array

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXlsxToJsonExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert Excel XLSX to JSON conversion
                Object result = apiInstance.ConvertDataXlsxToJson(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXlsxToJson: " + e.Message );
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

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmltojson"></a>
# **ConvertDataXmlToJson**
> Object ConvertDataXmlToJson (System.IO.Stream inputFile)

Convert XML to JSON conversion

Convert an XML string or file into JSON

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlToJsonExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Convert XML to JSON conversion
                Object result = apiInstance.ConvertDataXmlToJson(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlToJson: " + e.Message );
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

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

