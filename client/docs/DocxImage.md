# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model.DocxImage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The Path of the location of this object; leave blank for new tables | [optional] 
**ImageName** | **string** | The Name of the image | [optional] 
**ImageId** | **long?** | The Id of the image | [optional] 
**ImageDescription** | **string** | The Description of the image | [optional] 
**ImageWidth** | **long?** | Width of the image in EMUs (English Metric Units); set to 0 to default to page width and aspect-ratio based height | [optional] 
**ImageHeight** | **long?** | Height of the image in EMUs (English Metric Units); set to 0 to default to page width and aspect-ratio based height | [optional] 
**XOffset** | **long?** | X (horizontal) offset of the image | [optional] 
**YOffset** | **long?** | Y (vertical) offset of the image | [optional] 
**ImageDataEmbedId** | **string** | Read-only; internal ID for the image contents | [optional] 
**ImageDataContentType** | **string** | Read-only; image data MIME content-type | [optional] 
**ImageInternalFileName** | **string** | Read-only; internal file name/path for the image | [optional] 
**ImageContentsURL** | **string** | URL to the image contents; file is stored in an in-memory cache and will be deleted.  Call Finish-Editing to get the contents. | [optional] 
**InlineWithText** | **bool?** | True if the image is inline with the text; false if it is floating | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

