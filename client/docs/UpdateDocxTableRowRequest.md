# Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model.UpdateDocxTableRowRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFileBytes** | **byte[]** | Optional: Bytes of the input file to operate on | [optional] 
**InputFileUrl** | **string** | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
**RowToUpdate** | [**DocxTableRow**](DocxTableRow.md) | Table row contents you would like to update the row with | [optional] 
**TableRowRowIndex** | **int?** | 0-based index of the Table Row to update | [optional] 
**ExistingTablePath** | **string** | Required; the path to the existing table to modify | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

