# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model.DocxComment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | Path to the comment in the document | [optional] 
**Author** | **string** | Author name of the comment | [optional] 
**AuthorInitials** | **string** | Initials of the author of the comment | [optional] 
**CommentText** | **string** | Text content of the comment | [optional] 
**CommentDate** | **DateTime?** | Date timestamp of the comment | [optional] 
**IsTopLevel** | **bool?** | True if the comment is at the top level, false if this comment is a child reply of another comment | [optional] 
**IsReply** | **bool?** | True if this comment is a reply to another comment, false otherwise | [optional] 
**ParentCommentPath** | **string** | Path to the parent of this comment, if this comment is a reply, otherwise this value will be null | [optional] 
**Done** | **bool?** | True if this comment is marked as Done in Word, otherwise it is false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

