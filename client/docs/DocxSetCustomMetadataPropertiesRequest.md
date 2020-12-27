# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model.DocxSetCustomMetadataPropertiesRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFileBytes** | **byte[]** | Optional: Bytes of the input file to operate on | [optional] 
**InputFileUrl** | **string** | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
**PropertiesToSet** | [**List&lt;DocxMetadataCustomProperty&gt;**](DocxMetadataCustomProperty.md) | Required: properties to set in the Word Document; provide one or more property definitions to set - be sure to specify the data type and value, together with the property name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

