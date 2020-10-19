# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api.ZipArchiveApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ZipArchiveZipCreate**](ZipArchiveApi.md#ziparchivezipcreate) | **POST** /convert/archive/zip/create | Compress files to create a new zip archive
[**ZipArchiveZipCreateAdvanced**](ZipArchiveApi.md#ziparchivezipcreateadvanced) | **POST** /convert/archive/zip/create/advanced | Compress files and folders to create a new zip archive with advanced options
[**ZipArchiveZipCreateEncrypted**](ZipArchiveApi.md#ziparchivezipcreateencrypted) | **POST** /convert/archive/zip/create/encrypted | Compress files to create a new, encrypted and password-protected zip archive
[**ZipArchiveZipDecrypt**](ZipArchiveApi.md#ziparchivezipdecrypt) | **POST** /convert/archive/zip/decrypt | Decrypt and remove password protection on a zip file
[**ZipArchiveZipEncryptAdvanced**](ZipArchiveApi.md#ziparchivezipencryptadvanced) | **POST** /convert/archive/zip/encrypt/advanced | Encrypt and password protect a zip file
[**ZipArchiveZipExtract**](ZipArchiveApi.md#ziparchivezipextract) | **POST** /convert/archive/zip/extract | Extract, decompress files and folders from a zip archive


<a name="ziparchivezipcreate"></a>
# **ZipArchiveZipCreate**
> byte[] ZipArchiveZipCreate (System.IO.Stream inputFile1, System.IO.Stream inputFile2 = null, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Compress files to create a new zip archive

Create a new zip archive by compressing input files.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ZipArchiveZipCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ZipArchiveApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on. (optional) 
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
                // Compress files to create a new zip archive
                byte[] result = apiInstance.ZipArchiveZipCreate(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipArchiveApi.ZipArchiveZipCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on. | [optional] 
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

<a name="ziparchivezipcreateadvanced"></a>
# **ZipArchiveZipCreateAdvanced**
> Object ZipArchiveZipCreateAdvanced (CreateZipArchiveRequest request)

Compress files and folders to create a new zip archive with advanced options

Create a new zip archive by compressing input files, folders and leverage advanced options to control the structure of the resulting zip archive.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ZipArchiveZipCreateAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ZipArchiveApi();
            var request = new CreateZipArchiveRequest(); // CreateZipArchiveRequest | Input request

            try
            {
                // Compress files and folders to create a new zip archive with advanced options
                Object result = apiInstance.ZipArchiveZipCreateAdvanced(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipArchiveApi.ZipArchiveZipCreateAdvanced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateZipArchiveRequest**](CreateZipArchiveRequest.md)| Input request | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ziparchivezipcreateencrypted"></a>
# **ZipArchiveZipCreateEncrypted**
> byte[] ZipArchiveZipCreateEncrypted (string password, System.IO.Stream inputFile1, string encryptionAlgorithm = null, System.IO.Stream inputFile2 = null, System.IO.Stream inputFile3 = null, System.IO.Stream inputFile4 = null, System.IO.Stream inputFile5 = null, System.IO.Stream inputFile6 = null, System.IO.Stream inputFile7 = null, System.IO.Stream inputFile8 = null, System.IO.Stream inputFile9 = null, System.IO.Stream inputFile10 = null)

Compress files to create a new, encrypted and password-protected zip archive

Create a new zip archive by compressing input files, and also applies encryption and password protection to the zip.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ZipArchiveZipCreateEncryptedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ZipArchiveApi();
            var password = password_example;  // string | Password to place on the Zip file; the longer the password, the more secure
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var encryptionAlgorithm = encryptionAlgorithm_example;  // string | Encryption algorithm to use; possible values are AES-256 (recommended), AES-128, and PK-Zip (not recommended; legacy, weak encryption algorithm). Default is AES-256. (optional) 
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on. (optional) 
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
                // Compress files to create a new, encrypted and password-protected zip archive
                byte[] result = apiInstance.ZipArchiveZipCreateEncrypted(password, inputFile1, encryptionAlgorithm, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipArchiveApi.ZipArchiveZipCreateEncrypted: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | **string**| Password to place on the Zip file; the longer the password, the more secure | 
 **inputFile1** | **System.IO.Stream**| First input file to perform the operation on. | 
 **encryptionAlgorithm** | **string**| Encryption algorithm to use; possible values are AES-256 (recommended), AES-128, and PK-Zip (not recommended; legacy, weak encryption algorithm). Default is AES-256. | [optional] 
 **inputFile2** | **System.IO.Stream**| Second input file to perform the operation on. | [optional] 
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

<a name="ziparchivezipdecrypt"></a>
# **ZipArchiveZipDecrypt**
> Object ZipArchiveZipDecrypt (System.IO.Stream inputFile, string zipPassword)

Decrypt and remove password protection on a zip file

Decrypts and removes password protection from an encrypted zip file with the specified password

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ZipArchiveZipDecryptExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ZipArchiveApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.
            var zipPassword = zipPassword_example;  // string | Required; Password for the input archive

            try
            {
                // Decrypt and remove password protection on a zip file
                Object result = apiInstance.ZipArchiveZipDecrypt(inputFile, zipPassword);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipArchiveApi.ZipArchiveZipDecrypt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 
 **zipPassword** | **string**| Required; Password for the input archive | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ziparchivezipencryptadvanced"></a>
# **ZipArchiveZipEncryptAdvanced**
> Object ZipArchiveZipEncryptAdvanced (ZipEncryptionAdvancedRequest encryptionRequest)

Encrypt and password protect a zip file

Encrypts and password protects an existing zip file with the specified password and encryption algorithm

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ZipArchiveZipEncryptAdvancedExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ZipArchiveApi();
            var encryptionRequest = new ZipEncryptionAdvancedRequest(); // ZipEncryptionAdvancedRequest | Encryption request

            try
            {
                // Encrypt and password protect a zip file
                Object result = apiInstance.ZipArchiveZipEncryptAdvanced(encryptionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipArchiveApi.ZipArchiveZipEncryptAdvanced: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **encryptionRequest** | [**ZipEncryptionAdvancedRequest**](ZipEncryptionAdvancedRequest.md)| Encryption request | 

### Return type

**Object**

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ziparchivezipextract"></a>
# **ZipArchiveZipExtract**
> ZipExtractResponse ZipArchiveZipExtract (System.IO.Stream inputFile)

Extract, decompress files and folders from a zip archive

Extracts a zip archive by decompressing files, and folders.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class ZipArchiveZipExtractExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new ZipArchiveApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Extract, decompress files and folders from a zip archive
                ZipExtractResponse result = apiInstance.ZipArchiveZipExtract(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZipArchiveApi.ZipArchiveZipExtract: " + e.Message );
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

[**ZipExtractResponse**](ZipExtractResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

