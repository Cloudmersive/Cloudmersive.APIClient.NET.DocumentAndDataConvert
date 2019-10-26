# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model.AutodetectGetInfoResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Successful** | **bool?** | True if the operation was successful, false otherwise | [optional] 
**DetectedFileExtension** | **string** | Detected file extension of the file format, with a leading period | [optional] 
**DetectedMimeType** | **string** | MIME type of this file extension | [optional] 
**PageCount** | **long?** | Number of pages in a page-based document; for presentations, this is the number of slides and for a spreadsheet this is the number of worksheets.  Contains 0 when the page count cannot be determined, or if the concept of page count does not apply (e.g. for an image) | [optional] 
**Author** | **string** | User name of the creator/author of the document, if available, null if not available | [optional] 
**DateModified** | **DateTime?** | The timestamp that the document was last modified, if available, null if not available | [optional] 
**AlternateFileTypeCandidates** | [**List&lt;AlternateFileFormatCandidate&gt;**](AlternateFileFormatCandidate.md) | Alternate file type options and their probability | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

