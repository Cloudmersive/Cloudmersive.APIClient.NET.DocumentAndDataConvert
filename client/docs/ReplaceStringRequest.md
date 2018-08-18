# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model.ReplaceStringRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFileBytes** | **byte[]** | Optional: Bytes of the input file to operate on | [optional] 
**InputFileUrl** | **string** | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
**MatchString** | **string** | String to search for and match against, to be replaced | [optional] 
**ReplaceString** | **string** | String to replace the matched values with | [optional] 
**MatchCase** | **bool?** | True if the case should be matched, false for case insensitive match | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

