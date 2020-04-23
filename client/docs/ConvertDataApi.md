# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.ConvertDataApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertDataCsvToJson**](ConvertDataApi.md#convertdatacsvtojson) | **POST** /convert/csv/to/json | Convert CSV to JSON conversion
[**ConvertDataJsonToXml**](ConvertDataApi.md#convertdatajsontoxml) | **POST** /convert/json/to/xml | Convert JSON to XML conversion
[**ConvertDataXlsToJson**](ConvertDataApi.md#convertdataxlstojson) | **POST** /convert/xls/to/json | Convert Excel (97-2003) XLS to JSON conversion
[**ConvertDataXlsxToJson**](ConvertDataApi.md#convertdataxlsxtojson) | **POST** /convert/xlsx/to/json | Convert Excel XLSX to JSON conversion
[**ConvertDataXmlEditAddAttributeWithXPath**](ConvertDataApi.md#convertdataxmleditaddattributewithxpath) | **POST** /convert/xml/edit/xpath/add-attribute | Adds an attribute to all XML nodes matching XPath expression
[**ConvertDataXmlEditAddChildWithXPath**](ConvertDataApi.md#convertdataxmleditaddchildwithxpath) | **POST** /convert/xml/edit/xpath/add-child | Adds an XML node as a child to XML nodes matching XPath expression
[**ConvertDataXmlEditRemoveAllChildNodesWithXPath**](ConvertDataApi.md#convertdataxmleditremoveallchildnodeswithxpath) | **POST** /convert/xml/edit/xpath/remove-all-children | Removes, deletes all children of nodes matching XPath expression, but does not remove the nodes
[**ConvertDataXmlEditReplaceWithXPath**](ConvertDataApi.md#convertdataxmleditreplacewithxpath) | **POST** /convert/xml/edit/xpath/replace | Replaces XML nodes matching XPath expression with new node
[**ConvertDataXmlEditSetValueWithXPath**](ConvertDataApi.md#convertdataxmleditsetvaluewithxpath) | **POST** /convert/xml/edit/xpath/set-value | Sets the value contents of XML nodes matching XPath expression
[**ConvertDataXmlFilterWithXPath**](ConvertDataApi.md#convertdataxmlfilterwithxpath) | **POST** /convert/xml/select/xpath | Filter, select XML nodes using XPath expression, get results
[**ConvertDataXmlQueryWithXQuery**](ConvertDataApi.md#convertdataxmlquerywithxquery) | **POST** /convert/xml/query/xquery | Query an XML file using XQuery query, get results
[**ConvertDataXmlQueryWithXQueryMulti**](ConvertDataApi.md#convertdataxmlquerywithxquerymulti) | **POST** /convert/xml/query/xquery/multi | Query multiple XML files using XQuery query, get results
[**ConvertDataXmlRemoveWithXPath**](ConvertDataApi.md#convertdataxmlremovewithxpath) | **POST** /convert/xml/edit/xpath/remove | Remove, delete XML nodes and items matching XPath expression
[**ConvertDataXmlToJson**](ConvertDataApi.md#convertdataxmltojson) | **POST** /convert/xml/to/json | Convert XML to JSON conversion
[**ConvertDataXmlTransformWithXsltToXml**](ConvertDataApi.md#convertdataxmltransformwithxslttoxml) | **POST** /convert/xml/transform/xslt/to/xml | Transform XML document file with XSLT into a new XML document


<a name="convertdatacsvtojson"></a>
# **ConvertDataCsvToJson**
> Object ConvertDataCsvToJson (System.IO.Stream inputFile, bool? columnNamesFromFirstRow = null)

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
            var columnNamesFromFirstRow = true;  // bool? | Optional; If true, the first row will be used as the labels for the columns; if false, columns will be named Column0, Column1, etc.  Default is true.  Set to false if you are not using column headings, or have an irregular column structure. (optional) 

            try
            {
                // Convert CSV to JSON conversion
                Object result = apiInstance.ConvertDataCsvToJson(inputFile, columnNamesFromFirstRow);
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
 **columnNamesFromFirstRow** | **bool?**| Optional; If true, the first row will be used as the labels for the columns; if false, columns will be named Column0, Column1, etc.  Default is true.  Set to false if you are not using column headings, or have an irregular column structure. | [optional] 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdatajsontoxml"></a>
# **ConvertDataJsonToXml**
> byte[] ConvertDataJsonToXml (Object jsonObject)

Convert JSON to XML conversion

Convert a JSON object into XML

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataJsonToXmlExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var jsonObject = ;  // Object | Input JSON to convert to XML

            try
            {
                // Convert JSON to XML conversion
                byte[] result = apiInstance.ConvertDataJsonToXml(jsonObject);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataJsonToXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jsonObject** | **Object**| Input JSON to convert to XML | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/xml

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
 - **Accept**: application/json

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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmleditaddattributewithxpath"></a>
# **ConvertDataXmlEditAddAttributeWithXPath**
> XmlAddAttributeWithXPathResult ConvertDataXmlEditAddAttributeWithXPath (System.IO.Stream inputFile, string xPathExpression, string xmlAttributeName, string xmlAttributeValue)

Adds an attribute to all XML nodes matching XPath expression

Return the reuslts of editing an XML document by adding an attribute to all of the nodes that match an input XPath expression.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlEditAddAttributeWithXPathExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input XML file to perform the operation on.
            var xPathExpression = xPathExpression_example;  // string | Valid XML XPath query expression
            var xmlAttributeName = xmlAttributeName_example;  // string | Name of the XML attribute to add
            var xmlAttributeValue = xmlAttributeValue_example;  // string | Value of the XML attribute to add

            try
            {
                // Adds an attribute to all XML nodes matching XPath expression
                XmlAddAttributeWithXPathResult result = apiInstance.ConvertDataXmlEditAddAttributeWithXPath(inputFile, xPathExpression, xmlAttributeName, xmlAttributeValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlEditAddAttributeWithXPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input XML file to perform the operation on. | 
 **xPathExpression** | **string**| Valid XML XPath query expression | 
 **xmlAttributeName** | **string**| Name of the XML attribute to add | 
 **xmlAttributeValue** | **string**| Value of the XML attribute to add | 

### Return type

[**XmlAddAttributeWithXPathResult**](XmlAddAttributeWithXPathResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmleditaddchildwithxpath"></a>
# **ConvertDataXmlEditAddChildWithXPath**
> XmlAddChildWithXPathResult ConvertDataXmlEditAddChildWithXPath (System.IO.Stream inputFile, string xPathExpression, string xmlNodeToAdd)

Adds an XML node as a child to XML nodes matching XPath expression

Return the reuslts of editing an XML document by adding an XML node as a child to all of the nodes that match an input XPath expression.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlEditAddChildWithXPathExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input XML file to perform the operation on.
            var xPathExpression = xPathExpression_example;  // string | Valid XML XPath query expression
            var xmlNodeToAdd = xmlNodeToAdd_example;  // string | XML Node to add as a child

            try
            {
                // Adds an XML node as a child to XML nodes matching XPath expression
                XmlAddChildWithXPathResult result = apiInstance.ConvertDataXmlEditAddChildWithXPath(inputFile, xPathExpression, xmlNodeToAdd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlEditAddChildWithXPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input XML file to perform the operation on. | 
 **xPathExpression** | **string**| Valid XML XPath query expression | 
 **xmlNodeToAdd** | **string**| XML Node to add as a child | 

### Return type

[**XmlAddChildWithXPathResult**](XmlAddChildWithXPathResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmleditremoveallchildnodeswithxpath"></a>
# **ConvertDataXmlEditRemoveAllChildNodesWithXPath**
> XmlRemoveAllChildrenWithXPathResult ConvertDataXmlEditRemoveAllChildNodesWithXPath (System.IO.Stream inputFile, string xPathExpression)

Removes, deletes all children of nodes matching XPath expression, but does not remove the nodes

Return the reuslts of editing an XML document by removing all child nodes of the nodes that match an input XPath expression.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlEditRemoveAllChildNodesWithXPathExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input XML file to perform the operation on.
            var xPathExpression = xPathExpression_example;  // string | Valid XML XPath query expression

            try
            {
                // Removes, deletes all children of nodes matching XPath expression, but does not remove the nodes
                XmlRemoveAllChildrenWithXPathResult result = apiInstance.ConvertDataXmlEditRemoveAllChildNodesWithXPath(inputFile, xPathExpression);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlEditRemoveAllChildNodesWithXPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input XML file to perform the operation on. | 
 **xPathExpression** | **string**| Valid XML XPath query expression | 

### Return type

[**XmlRemoveAllChildrenWithXPathResult**](XmlRemoveAllChildrenWithXPathResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmleditreplacewithxpath"></a>
# **ConvertDataXmlEditReplaceWithXPath**
> XmlReplaceWithXPathResult ConvertDataXmlEditReplaceWithXPath (System.IO.Stream inputFile, string xPathExpression, string xmlNodeReplacement)

Replaces XML nodes matching XPath expression with new node

Return the reuslts of editing an XML document by replacing all of the nodes that match an input XPath expression with a new XML node expression.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlEditReplaceWithXPathExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input XML file to perform the operation on.
            var xPathExpression = xPathExpression_example;  // string | Valid XML XPath query expression
            var xmlNodeReplacement = xmlNodeReplacement_example;  // string | XML Node replacement content

            try
            {
                // Replaces XML nodes matching XPath expression with new node
                XmlReplaceWithXPathResult result = apiInstance.ConvertDataXmlEditReplaceWithXPath(inputFile, xPathExpression, xmlNodeReplacement);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlEditReplaceWithXPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input XML file to perform the operation on. | 
 **xPathExpression** | **string**| Valid XML XPath query expression | 
 **xmlNodeReplacement** | **string**| XML Node replacement content | 

### Return type

[**XmlReplaceWithXPathResult**](XmlReplaceWithXPathResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmleditsetvaluewithxpath"></a>
# **ConvertDataXmlEditSetValueWithXPath**
> XmlSetValueWithXPathResult ConvertDataXmlEditSetValueWithXPath (System.IO.Stream inputFile, string xPathExpression, string xmlValue)

Sets the value contents of XML nodes matching XPath expression

Return the reuslts of editing an XML document by setting the contents of all of the nodes that match an input XPath expression.  Supports elements and attributes.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlEditSetValueWithXPathExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input XML file to perform the operation on.
            var xPathExpression = xPathExpression_example;  // string | Valid XML XPath query expression
            var xmlValue = xmlValue_example;  // string | XML Value to set into the matching XML nodes

            try
            {
                // Sets the value contents of XML nodes matching XPath expression
                XmlSetValueWithXPathResult result = apiInstance.ConvertDataXmlEditSetValueWithXPath(inputFile, xPathExpression, xmlValue);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlEditSetValueWithXPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input XML file to perform the operation on. | 
 **xPathExpression** | **string**| Valid XML XPath query expression | 
 **xmlValue** | **string**| XML Value to set into the matching XML nodes | 

### Return type

[**XmlSetValueWithXPathResult**](XmlSetValueWithXPathResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmlfilterwithxpath"></a>
# **ConvertDataXmlFilterWithXPath**
> XmlFilterWithXPathResult ConvertDataXmlFilterWithXPath (string xPathExpression, System.IO.Stream inputFile)

Filter, select XML nodes using XPath expression, get results

Return the reuslts of filtering, selecting an XML document with an XPath expression

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlFilterWithXPathExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var xPathExpression = xPathExpression_example;  // string | Valid XML XPath query expression
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Filter, select XML nodes using XPath expression, get results
                XmlFilterWithXPathResult result = apiInstance.ConvertDataXmlFilterWithXPath(xPathExpression, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlFilterWithXPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPathExpression** | **string**| Valid XML XPath query expression | 
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**XmlFilterWithXPathResult**](XmlFilterWithXPathResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmlquerywithxquery"></a>
# **ConvertDataXmlQueryWithXQuery**
> XmlQueryWithXQueryResult ConvertDataXmlQueryWithXQuery (System.IO.Stream inputFile, string xQuery)

Query an XML file using XQuery query, get results

Return the reuslts of querying a single XML document with an XQuery expression.  Supports XQuery 3.1 and earlier.  This API is optimized for a single XML document as input.  Provided XML document is automatically loaded as the default context; to access elements in the document, simply refer to them without a document reference, such as bookstore/book

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlQueryWithXQueryExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input XML file to perform the operation on.
            var xQuery = xQuery_example;  // string | Valid XML XQuery 3.1 or earlier query expression; multi-line expressions are supported

            try
            {
                // Query an XML file using XQuery query, get results
                XmlQueryWithXQueryResult result = apiInstance.ConvertDataXmlQueryWithXQuery(inputFile, xQuery);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlQueryWithXQuery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input XML file to perform the operation on. | 
 **xQuery** | **string**| Valid XML XQuery 3.1 or earlier query expression; multi-line expressions are supported | 

### Return type

[**XmlQueryWithXQueryResult**](XmlQueryWithXQueryResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmlquerywithxquerymulti"></a>
# **ConvertDataXmlQueryWithXQueryMulti**
> XmlQueryWithXQueryMultiResult ConvertDataXmlQueryWithXQueryMulti (System.IO.Stream inputFile1, string xQuery, System.IO.Stream inputFile2 = null, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Query multiple XML files using XQuery query, get results

Return the reuslts of querying an XML document with an XQuery expression.  Supports XQuery 3.1 and earlier.  This API is optimized for multiple XML documents as input.  You can refer to the contents of a given document by name, for example doc(\"books.xml\") or doc(\"restaurants.xml\") if you included two input files named books.xml and restaurants.xml.  If input files contain no file name, they will default to file names input1.xml, input2.xml and so on.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlQueryWithXQueryMultiExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input XML file to perform the operation on.
            var xQuery = xQuery_example;  // string | Valid XML XQuery 3.1 or earlier query expression; multi-line expressions are supported
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input XML file to perform the operation on. (optional) 
            var inputFile3 = new System.IO.Stream(); // System.IO.Stream | Third input XML file to perform the operation on. (optional) 
            var inputFile4 = new System.IO.Stream(); // System.IO.Stream | Fourth input XML file to perform the operation on. (optional) 
            var inputFile5 = new System.IO.Stream(); // System.IO.Stream | Fifth input XML file to perform the operation on. (optional) 
            var inputFile6 = new System.IO.Stream(); // System.IO.Stream | Sixth input XML file to perform the operation on. (optional) 
            var inputFile7 = new System.IO.Stream(); // System.IO.Stream | Seventh input XML file to perform the operation on. (optional) 
            var inputFile8 = new System.IO.Stream(); // System.IO.Stream | Eighth input XML file to perform the operation on. (optional) 
            var inputFile9 = new System.IO.Stream(); // System.IO.Stream | Ninth input XML file to perform the operation on. (optional) 
            var inputFile10 = new System.IO.Stream(); // System.IO.Stream | Tenth input XML file to perform the operation on. (optional) 

            try
            {
                // Query multiple XML files using XQuery query, get results
                XmlQueryWithXQueryMultiResult result = apiInstance.ConvertDataXmlQueryWithXQueryMulti(inputFile1, xQuery, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlQueryWithXQueryMulti: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input XML file to perform the operation on. | 
 **xQuery** | **string**| Valid XML XQuery 3.1 or earlier query expression; multi-line expressions are supported | 
 **inputFile2** | **System.IO.Stream**| Second input XML file to perform the operation on. | [optional] 
 **inputFile3** | **System.IO.Stream**| Third input XML file to perform the operation on. | [optional] 
 **inputFile4** | **System.IO.Stream**| Fourth input XML file to perform the operation on. | [optional] 
 **inputFile5** | **System.IO.Stream**| Fifth input XML file to perform the operation on. | [optional] 
 **inputFile6** | **System.IO.Stream**| Sixth input XML file to perform the operation on. | [optional] 
 **inputFile7** | **System.IO.Stream**| Seventh input XML file to perform the operation on. | [optional] 
 **inputFile8** | **System.IO.Stream**| Eighth input XML file to perform the operation on. | [optional] 
 **inputFile9** | **System.IO.Stream**| Ninth input XML file to perform the operation on. | [optional] 
 **inputFile10** | **System.IO.Stream**| Tenth input XML file to perform the operation on. | [optional] 

### Return type

[**XmlQueryWithXQueryMultiResult**](XmlQueryWithXQueryMultiResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmlremovewithxpath"></a>
# **ConvertDataXmlRemoveWithXPath**
> XmlRemoveWithXPathResult ConvertDataXmlRemoveWithXPath (string xPathExpression, System.IO.Stream inputFile)

Remove, delete XML nodes and items matching XPath expression

Return the reuslts of editing an XML document by removing all of the nodes that match an input XPath expression

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ConvertDataXmlRemoveWithXPathExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var xPathExpression = xPathExpression_example;  // string | Valid XML XPath query expression
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Remove, delete XML nodes and items matching XPath expression
                XmlRemoveWithXPathResult result = apiInstance.ConvertDataXmlRemoveWithXPath(xPathExpression, inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlRemoveWithXPath: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xPathExpression** | **string**| Valid XML XPath query expression | 
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**XmlRemoveWithXPathResult**](XmlRemoveWithXPathResult.md)

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
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="convertdataxmltransformwithxslttoxml"></a>
# **ConvertDataXmlTransformWithXsltToXml**
> byte[] ConvertDataXmlTransformWithXsltToXml (System.IO.Stream inputFile, System.IO.Stream transformFile)

Transform XML document file with XSLT into a new XML document

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
    public class ConvertDataXmlTransformWithXsltToXmlExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ConvertDataApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input XML file to perform the operation on.
            var transformFile = new System.IO.Stream(); // System.IO.Stream | Input XSLT file to use to transform the input XML file.

            try
            {
                // Transform XML document file with XSLT into a new XML document
                byte[] result = apiInstance.ConvertDataXmlTransformWithXsltToXml(inputFile, transformFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConvertDataApi.ConvertDataXmlTransformWithXsltToXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input XML file to perform the operation on. | 
 **transformFile** | **System.IO.Stream**| Input XSLT file to use to transform the input XML file. | 

### Return type

**byte[]**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

