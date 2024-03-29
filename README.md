# Cloudmersive.APIClient.NET.DocumentAndDataConvert - the C# library for the convertapi

Convert API lets you effortlessly convert file formats and types.

This C# SDK is for the [Cloudmersive Document and Data Conversion API](https://www.cloudmersive.com/convert-api):

- API version: v1
- SDK version: 3.6.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NET.DocumentAndDataConvert.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new CompareDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).
            var autorepair = true;  // bool? | Optional; automatically repair input documents that have errors (default is true) (optional) 

            try
            {
                // Compare Two Word DOCX
                byte[] result = apiInstance.CompareDocumentDocx(inputFile1, inputFile2, autorepair);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompareDocumentApi.CompareDocumentDocx: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CompareDocumentApi* | [**CompareDocumentDocx**](docs/CompareDocumentApi.md#comparedocumentdocx) | **POST** /convert/compare/docx | Compare Two Word DOCX
*ConvertDataApi* | [**ConvertDataCsvToJson**](docs/ConvertDataApi.md#convertdatacsvtojson) | **POST** /convert/csv/to/json | Convert CSV to JSON conversion
*ConvertDataApi* | [**ConvertDataCsvToXml**](docs/ConvertDataApi.md#convertdatacsvtoxml) | **POST** /convert/csv/to/xml | Convert CSV to XML conversion
*ConvertDataApi* | [**ConvertDataJsonStringToXml**](docs/ConvertDataApi.md#convertdatajsonstringtoxml) | **POST** /convert/json-string/to/xml | Convert JSON String to XML conversion
*ConvertDataApi* | [**ConvertDataJsonToXml**](docs/ConvertDataApi.md#convertdatajsontoxml) | **POST** /convert/json/to/xml | Convert JSON Object to XML conversion
*ConvertDataApi* | [**ConvertDataXlsToJson**](docs/ConvertDataApi.md#convertdataxlstojson) | **POST** /convert/xls/to/json | Convert Excel (97-2003) XLS to JSON conversion
*ConvertDataApi* | [**ConvertDataXlsxToJson**](docs/ConvertDataApi.md#convertdataxlsxtojson) | **POST** /convert/xlsx/to/json | Convert Excel XLSX to JSON conversion
*ConvertDataApi* | [**ConvertDataXlsxToXml**](docs/ConvertDataApi.md#convertdataxlsxtoxml) | **POST** /convert/xlsx/to/xml | Convert Excel XLSX to XML conversion
*ConvertDataApi* | [**ConvertDataXmlEditAddAttributeWithXPath**](docs/ConvertDataApi.md#convertdataxmleditaddattributewithxpath) | **POST** /convert/xml/edit/xpath/add-attribute | Adds an attribute to all XML nodes matching XPath expression
*ConvertDataApi* | [**ConvertDataXmlEditAddChildWithXPath**](docs/ConvertDataApi.md#convertdataxmleditaddchildwithxpath) | **POST** /convert/xml/edit/xpath/add-child | Adds an XML node as a child to XML nodes matching XPath expression
*ConvertDataApi* | [**ConvertDataXmlEditRemoveAllChildNodesWithXPath**](docs/ConvertDataApi.md#convertdataxmleditremoveallchildnodeswithxpath) | **POST** /convert/xml/edit/xpath/remove-all-children | Removes, deletes all children of nodes matching XPath expression, but does not remove the nodes
*ConvertDataApi* | [**ConvertDataXmlEditReplaceWithXPath**](docs/ConvertDataApi.md#convertdataxmleditreplacewithxpath) | **POST** /convert/xml/edit/xpath/replace | Replaces XML nodes matching XPath expression with new node
*ConvertDataApi* | [**ConvertDataXmlEditSetValueWithXPath**](docs/ConvertDataApi.md#convertdataxmleditsetvaluewithxpath) | **POST** /convert/xml/edit/xpath/set-value | Sets the value contents of XML nodes matching XPath expression
*ConvertDataApi* | [**ConvertDataXmlFilterWithXPath**](docs/ConvertDataApi.md#convertdataxmlfilterwithxpath) | **POST** /convert/xml/select/xpath | Filter, select XML nodes using XPath expression, get results
*ConvertDataApi* | [**ConvertDataXmlQueryWithXQuery**](docs/ConvertDataApi.md#convertdataxmlquerywithxquery) | **POST** /convert/xml/query/xquery | Query an XML file using XQuery query, get results
*ConvertDataApi* | [**ConvertDataXmlQueryWithXQueryMulti**](docs/ConvertDataApi.md#convertdataxmlquerywithxquerymulti) | **POST** /convert/xml/query/xquery/multi | Query multiple XML files using XQuery query, get results
*ConvertDataApi* | [**ConvertDataXmlRemoveWithXPath**](docs/ConvertDataApi.md#convertdataxmlremovewithxpath) | **POST** /convert/xml/edit/xpath/remove | Remove, delete XML nodes and items matching XPath expression
*ConvertDataApi* | [**ConvertDataXmlToJson**](docs/ConvertDataApi.md#convertdataxmltojson) | **POST** /convert/xml/to/json | Convert XML to JSON conversion
*ConvertDataApi* | [**ConvertDataXmlTransformWithXsltToXml**](docs/ConvertDataApi.md#convertdataxmltransformwithxslttoxml) | **POST** /convert/xml/transform/xslt/to/xml | Transform XML document file with XSLT into a new XML document
*ConvertDocumentApi* | [**ConvertDocumentAutodetectGetInfo**](docs/ConvertDocumentApi.md#convertdocumentautodetectgetinfo) | **POST** /convert/autodetect/get-info | Get document type information
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToJpg**](docs/ConvertDocumentApi.md#convertdocumentautodetecttojpg) | **POST** /convert/autodetect/to/jpg | Convert Document to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToPdf**](docs/ConvertDocumentApi.md#convertdocumentautodetecttopdf) | **POST** /convert/autodetect/to/pdf | Convert Document to PDF
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToPdfBatchJob**](docs/ConvertDocumentApi.md#convertdocumentautodetecttopdfbatchjob) | **POST** /convert/autodetect/to/pdf/batch-job | Convert Document to PDF as Batch Job
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToPngArray**](docs/ConvertDocumentApi.md#convertdocumentautodetecttopngarray) | **POST** /convert/autodetect/to/png | Convert Document to PNG array
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToThumbnail**](docs/ConvertDocumentApi.md#convertdocumentautodetecttothumbnail) | **POST** /convert/autodetect/to/thumbnail | Convert File to Thumbnail Image
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToThumbnailsAdvanced**](docs/ConvertDocumentApi.md#convertdocumentautodetecttothumbnailsadvanced) | **POST** /convert/autodetect/to/thumbnail/advanced | Convert File to Thumbnail Image Object
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToTxt**](docs/ConvertDocumentApi.md#convertdocumentautodetecttotxt) | **POST** /convert/autodetect/to/txt | Convert Document to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentCsvMultiToXlsx**](docs/ConvertDocumentApi.md#convertdocumentcsvmultitoxlsx) | **POST** /convert/csv/multi/to/xlsx | Convert Multiple CSV Files into a Single XLSX Spreadsheet
*ConvertDocumentApi* | [**ConvertDocumentCsvToHtml**](docs/ConvertDocumentApi.md#convertdocumentcsvtohtml) | **POST** /convert/csv/to/html | Convert CSV to HTML document
*ConvertDocumentApi* | [**ConvertDocumentCsvToPdf**](docs/ConvertDocumentApi.md#convertdocumentcsvtopdf) | **POST** /convert/csv/to/pdf | Convert CSV to PDF document
*ConvertDocumentApi* | [**ConvertDocumentCsvToXlsx**](docs/ConvertDocumentApi.md#convertdocumentcsvtoxlsx) | **POST** /convert/csv/to/xlsx | Convert CSV to Excel XLSX Spreadsheet
*ConvertDocumentApi* | [**ConvertDocumentDocToDocx**](docs/ConvertDocumentApi.md#convertdocumentdoctodocx) | **POST** /convert/doc/to/docx | Convert Word DOC (97-03) Document to DOCX
*ConvertDocumentApi* | [**ConvertDocumentDocToPdf**](docs/ConvertDocumentApi.md#convertdocumentdoctopdf) | **POST** /convert/doc/to/pdf | Convert Word DOC (97-03) Document to PDF
*ConvertDocumentApi* | [**ConvertDocumentDocToTxt**](docs/ConvertDocumentApi.md#convertdocumentdoctotxt) | **POST** /convert/doc/to/txt | Convert Word DOC (97-03) Document to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentDocxToDoc**](docs/ConvertDocumentApi.md#convertdocumentdocxtodoc) | **POST** /convert/docx/to/doc | Convert Word DOCX Document to Legacy Word DOC (97-03)
*ConvertDocumentApi* | [**ConvertDocumentDocxToHtml**](docs/ConvertDocumentApi.md#convertdocumentdocxtohtml) | **POST** /convert/docx/to/html | Convert Word DOCX Document to HTML Document
*ConvertDocumentApi* | [**ConvertDocumentDocxToJpg**](docs/ConvertDocumentApi.md#convertdocumentdocxtojpg) | **POST** /convert/docx/to/jpg | Convert Word DOCX Document to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentDocxToPdf**](docs/ConvertDocumentApi.md#convertdocumentdocxtopdf) | **POST** /convert/docx/to/pdf | Convert Word DOCX Document to PDF
*ConvertDocumentApi* | [**ConvertDocumentDocxToPng**](docs/ConvertDocumentApi.md#convertdocumentdocxtopng) | **POST** /convert/docx/to/png | Convert Word DOCX Document to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentDocxToRtf**](docs/ConvertDocumentApi.md#convertdocumentdocxtortf) | **POST** /convert/docx/to/rtf | Convert Word DOCX Document to RTF
*ConvertDocumentApi* | [**ConvertDocumentDocxToTxt**](docs/ConvertDocumentApi.md#convertdocumentdocxtotxt) | **POST** /convert/docx/to/txt | Convert Word DOCX Document to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentEmlToHtml**](docs/ConvertDocumentApi.md#convertdocumentemltohtml) | **POST** /convert/eml/to/html | Convert Email EML file to HTML string
*ConvertDocumentApi* | [**ConvertDocumentEmlToJpg**](docs/ConvertDocumentApi.md#convertdocumentemltojpg) | **POST** /convert/eml/to/jpg | Convert Email EML file to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentEmlToPdf**](docs/ConvertDocumentApi.md#convertdocumentemltopdf) | **POST** /convert/eml/to/pdf | Convert Email EML file to PDF document
*ConvertDocumentApi* | [**ConvertDocumentEmlToPng**](docs/ConvertDocumentApi.md#convertdocumentemltopng) | **POST** /convert/eml/to/png | Convert Email EML file to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentGetAsyncJobStatus**](docs/ConvertDocumentApi.md#convertdocumentgetasyncjobstatus) | **GET** /convert/batch-job/status | Get the status and result of a Convert Document Batch Job
*ConvertDocumentApi* | [**ConvertDocumentGetFileTypeIcon**](docs/ConvertDocumentApi.md#convertdocumentgetfiletypeicon) | **POST** /convert/autodetect/get-icon | Get PNG icon file for the file extension
*ConvertDocumentApi* | [**ConvertDocumentGetFileTypeIconAdvanced**](docs/ConvertDocumentApi.md#convertdocumentgetfiletypeiconadvanced) | **POST** /convert/autodetect/get-icon/advanced | Get PNG icon byte array for the file extension
*ConvertDocumentApi* | [**ConvertDocumentHtmlToPdf**](docs/ConvertDocumentApi.md#convertdocumenthtmltopdf) | **POST** /convert/html/to/pdf | Convert HTML document file to PDF Document
*ConvertDocumentApi* | [**ConvertDocumentHtmlToPng**](docs/ConvertDocumentApi.md#convertdocumenthtmltopng) | **POST** /convert/html/to/png | Convert HTML document file to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentHtmlToTxt**](docs/ConvertDocumentApi.md#convertdocumenthtmltotxt) | **POST** /convert/html/to/txt | HTML Document file to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentKeynoteToJpg**](docs/ConvertDocumentApi.md#convertdocumentkeynotetojpg) | **POST** /convert/key/to/jpg | Convert Keynote Presentation (KEY) to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentKeynoteToPdf**](docs/ConvertDocumentApi.md#convertdocumentkeynotetopdf) | **POST** /convert/key/to/pdf | Convert Keynote Presentation (KEY) to PDF
*ConvertDocumentApi* | [**ConvertDocumentKeynoteToPng**](docs/ConvertDocumentApi.md#convertdocumentkeynotetopng) | **POST** /convert/key/to/png | Convert Keynote Presentation (KEY) to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentKeynoteToPptx**](docs/ConvertDocumentApi.md#convertdocumentkeynotetopptx) | **POST** /convert/key/to/pptx | Convert Keynote Presentation (KEY) to PPTX
*ConvertDocumentApi* | [**ConvertDocumentMsgToHtml**](docs/ConvertDocumentApi.md#convertdocumentmsgtohtml) | **POST** /convert/msg/to/html | Convert Email MSG file to HTML string
*ConvertDocumentApi* | [**ConvertDocumentMsgToJpg**](docs/ConvertDocumentApi.md#convertdocumentmsgtojpg) | **POST** /convert/msg/to/jpg | Convert Email MSG file to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentMsgToPdf**](docs/ConvertDocumentApi.md#convertdocumentmsgtopdf) | **POST** /convert/msg/to/pdf | Convert Email MSG file to PDF document
*ConvertDocumentApi* | [**ConvertDocumentMsgToPng**](docs/ConvertDocumentApi.md#convertdocumentmsgtopng) | **POST** /convert/msg/to/png | Convert Email MSG file to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentOdpToJpg**](docs/ConvertDocumentApi.md#convertdocumentodptojpg) | **POST** /convert/odp/to/jpg | Convert ODP Presentation to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentOdpToPdf**](docs/ConvertDocumentApi.md#convertdocumentodptopdf) | **POST** /convert/odp/to/pdf | Convert ODP Presentation to PDF
*ConvertDocumentApi* | [**ConvertDocumentOdpToPng**](docs/ConvertDocumentApi.md#convertdocumentodptopng) | **POST** /convert/odp/to/png | Convert ODP Presentation to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentOdpToPptx**](docs/ConvertDocumentApi.md#convertdocumentodptopptx) | **POST** /convert/odp/to/pptx | Convert ODP Presentation to PPTX
*ConvertDocumentApi* | [**ConvertDocumentOdsToJpg**](docs/ConvertDocumentApi.md#convertdocumentodstojpg) | **POST** /convert/ods/to/jpg | Convert ODS Spreadsheet to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentOdsToPdf**](docs/ConvertDocumentApi.md#convertdocumentodstopdf) | **POST** /convert/ods/to/pdf | Convert ODS Spreadsheet to PDF
*ConvertDocumentApi* | [**ConvertDocumentOdsToPng**](docs/ConvertDocumentApi.md#convertdocumentodstopng) | **POST** /convert/ods/to/png | Convert ODS Spreadsheet to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentOdsToXlsx**](docs/ConvertDocumentApi.md#convertdocumentodstoxlsx) | **POST** /convert/ods/to/xlsx | Convert ODS Spreadsheet to XLSX
*ConvertDocumentApi* | [**ConvertDocumentOdtToDocx**](docs/ConvertDocumentApi.md#convertdocumentodttodocx) | **POST** /convert/odt/to/docx | Convert ODT Text File to Word DOCX
*ConvertDocumentApi* | [**ConvertDocumentOdtToJpg**](docs/ConvertDocumentApi.md#convertdocumentodttojpg) | **POST** /convert/odt/to/jpg | Convert ODT Text File to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentOdtToPdf**](docs/ConvertDocumentApi.md#convertdocumentodttopdf) | **POST** /convert/odt/to/pdf | Convert ODT Text File to PDF
*ConvertDocumentApi* | [**ConvertDocumentOdtToPng**](docs/ConvertDocumentApi.md#convertdocumentodttopng) | **POST** /convert/odt/to/png | Convert ODT Text File to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentPdfToDocx**](docs/ConvertDocumentApi.md#convertdocumentpdftodocx) | **POST** /convert/pdf/to/docx | Convert PDF to Word DOCX Document
*ConvertDocumentApi* | [**ConvertDocumentPdfToDocxRasterize**](docs/ConvertDocumentApi.md#convertdocumentpdftodocxrasterize) | **POST** /convert/pdf/to/docx/rasterize | Convert PDF to Word DOCX Document based on rasterized version of the PDF
*ConvertDocumentApi* | [**ConvertDocumentPdfToJpg**](docs/ConvertDocumentApi.md#convertdocumentpdftojpg) | **POST** /convert/pdf/to/jpg | Convert PDF to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentPdfToPngArray**](docs/ConvertDocumentApi.md#convertdocumentpdftopngarray) | **POST** /convert/pdf/to/png | Convert PDF to PNG Image Array
*ConvertDocumentApi* | [**ConvertDocumentPdfToPngArrayDirect**](docs/ConvertDocumentApi.md#convertdocumentpdftopngarraydirect) | **POST** /convert/pdf/to/png/direct | Convert PDF to PNG Image Array (Direct)
*ConvertDocumentApi* | [**ConvertDocumentPdfToPngSingle**](docs/ConvertDocumentApi.md#convertdocumentpdftopngsingle) | **POST** /convert/pdf/to/png/merge-single | Convert PDF to Single PNG image
*ConvertDocumentApi* | [**ConvertDocumentPdfToPptx**](docs/ConvertDocumentApi.md#convertdocumentpdftopptx) | **POST** /convert/pdf/to/pptx | Convert PDF to PowerPoint PPTX Presentation
*ConvertDocumentApi* | [**ConvertDocumentPdfToTiff**](docs/ConvertDocumentApi.md#convertdocumentpdftotiff) | **POST** /convert/pdf/to/tiff | Convert PDF to TIFF image
*ConvertDocumentApi* | [**ConvertDocumentPdfToTxt**](docs/ConvertDocumentApi.md#convertdocumentpdftotxt) | **POST** /convert/pdf/to/txt | Convert PDF Document to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentPngArrayToPdf**](docs/ConvertDocumentApi.md#convertdocumentpngarraytopdf) | **POST** /convert/png/to/pdf | Convert PNG Array to PDF
*ConvertDocumentApi* | [**ConvertDocumentPngArrayToPdfFlattenTransparency**](docs/ConvertDocumentApi.md#convertdocumentpngarraytopdfflattentransparency) | **POST** /convert/png/to/pdf/remove-transparency | Convert PNG Array to PDF and remove transparency
*ConvertDocumentApi* | [**ConvertDocumentPptToPdf**](docs/ConvertDocumentApi.md#convertdocumentppttopdf) | **POST** /convert/ppt/to/pdf | Convert PowerPoint PPT (97-03) Presentation to PDF
*ConvertDocumentApi* | [**ConvertDocumentPptToPptx**](docs/ConvertDocumentApi.md#convertdocumentppttopptx) | **POST** /convert/ppt/to/pptx | Convert PowerPoint PPT (97-03) Presentation to PPTX
*ConvertDocumentApi* | [**ConvertDocumentPptxToPdf**](docs/ConvertDocumentApi.md#convertdocumentpptxtopdf) | **POST** /convert/pptx/to/pdf | Convert PowerPoint PPTX Presentation to PDF
*ConvertDocumentApi* | [**ConvertDocumentPptxToPng**](docs/ConvertDocumentApi.md#convertdocumentpptxtopng) | **POST** /convert/pptx/to/png | Convert PowerPoint PPTX to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentPptxToPpt**](docs/ConvertDocumentApi.md#convertdocumentpptxtoppt) | **POST** /convert/pptx/to/ppt | Convert PowerPoint PPTX presentation to Legacy PowerPoint PPT (97-03)
*ConvertDocumentApi* | [**ConvertDocumentPptxToTxt**](docs/ConvertDocumentApi.md#convertdocumentpptxtotxt) | **POST** /convert/pptx/to/txt | Convert PowerPoint PPTX Presentation to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentRtfToDocx**](docs/ConvertDocumentApi.md#convertdocumentrtftodocx) | **POST** /convert/rtf/to/docx | Convert Rich Text Format RTF to DOCX Document
*ConvertDocumentApi* | [**ConvertDocumentRtfToHtml**](docs/ConvertDocumentApi.md#convertdocumentrtftohtml) | **POST** /convert/rtf/to/html | Convert Rich Text Format RTF to HTML Document
*ConvertDocumentApi* | [**ConvertDocumentRtfToJpg**](docs/ConvertDocumentApi.md#convertdocumentrtftojpg) | **POST** /convert/rtf/to/jpg | Convert Rich Text Format RTF to JPG/JPEG image array
*ConvertDocumentApi* | [**ConvertDocumentRtfToPdf**](docs/ConvertDocumentApi.md#convertdocumentrtftopdf) | **POST** /convert/rtf/to/pdf | Convert Rich Text Format RTF to PDF
*ConvertDocumentApi* | [**ConvertDocumentRtfToPng**](docs/ConvertDocumentApi.md#convertdocumentrtftopng) | **POST** /convert/rtf/to/png | Convert Rich Text Format RTF to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentTxtToPdf**](docs/ConvertDocumentApi.md#convertdocumenttxttopdf) | **POST** /convert/txt/to/pdf | Convert TXT text file to PDF Document
*ConvertDocumentApi* | [**ConvertDocumentXlsToCsv**](docs/ConvertDocumentApi.md#convertdocumentxlstocsv) | **POST** /convert/xls/to/csv | Convert Excel XLS (97-03) Spreadsheet to CSV
*ConvertDocumentApi* | [**ConvertDocumentXlsToPdf**](docs/ConvertDocumentApi.md#convertdocumentxlstopdf) | **POST** /convert/xls/to/pdf | Convert Excel XLS (97-03) Spreadsheet to PDF
*ConvertDocumentApi* | [**ConvertDocumentXlsToXlsx**](docs/ConvertDocumentApi.md#convertdocumentxlstoxlsx) | **POST** /convert/xls/to/xlsx | Convert Excel XLS (97-03) Spreadsheet to XLSX
*ConvertDocumentApi* | [**ConvertDocumentXlsxToCsv**](docs/ConvertDocumentApi.md#convertdocumentxlsxtocsv) | **POST** /convert/xlsx/to/csv | Convert Excel XLSX Spreadsheet to CSV, Single Worksheet
*ConvertDocumentApi* | [**ConvertDocumentXlsxToCsvMulti**](docs/ConvertDocumentApi.md#convertdocumentxlsxtocsvmulti) | **POST** /convert/xlsx/to/csv/multi | Convert Excel XLSX Spreadsheet to CSV, Multiple Worksheets
*ConvertDocumentApi* | [**ConvertDocumentXlsxToHtml**](docs/ConvertDocumentApi.md#convertdocumentxlsxtohtml) | **POST** /convert/xlsx/to/html | Convert Excel XLSX Spreadsheet to HTML Document
*ConvertDocumentApi* | [**ConvertDocumentXlsxToPdf**](docs/ConvertDocumentApi.md#convertdocumentxlsxtopdf) | **POST** /convert/xlsx/to/pdf | Convert Excel XLSX Spreadsheet to PDF
*ConvertDocumentApi* | [**ConvertDocumentXlsxToPng**](docs/ConvertDocumentApi.md#convertdocumentxlsxtopng) | **POST** /convert/xlsx/to/png | Convert Excel XLSX spreadsheet to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentXlsxToTxt**](docs/ConvertDocumentApi.md#convertdocumentxlsxtotxt) | **POST** /convert/xlsx/to/txt | Convert Excel XLSX Spreadsheet to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentXlsxToXls**](docs/ConvertDocumentApi.md#convertdocumentxlsxtoxls) | **POST** /convert/xlsx/to/xls | Convert Excel XLSX Spreadsheet to Legacy Excel XLS (97-03)
*ConvertImageApi* | [**ConvertImageGetImageInfo**](docs/ConvertImageApi.md#convertimagegetimageinfo) | **POST** /convert/image/get-info | Get information about an image
*ConvertImageApi* | [**ConvertImageImageFormatConvert**](docs/ConvertImageApi.md#convertimageimageformatconvert) | **POST** /convert/image/{format1}/to/{format2} | Image format conversion
*ConvertImageApi* | [**ConvertImageImageSetDPI**](docs/ConvertImageApi.md#convertimageimagesetdpi) | **POST** /convert/image/set-dpi/{dpi} | Change image DPI
*ConvertImageApi* | [**ConvertImageMultipageImageFormatConvert**](docs/ConvertImageApi.md#convertimagemultipageimageformatconvert) | **POST** /convert/image-multipage/{format1}/to/{format2} | Multi-page image format conversion
*ConvertTemplateApi* | [**ConvertTemplateApplyDocxTemplate**](docs/ConvertTemplateApi.md#converttemplateapplydocxtemplate) | **POST** /convert/template/docx/apply | Apply Word DOCX template
*ConvertTemplateApi* | [**ConvertTemplateApplyHtmlTemplate**](docs/ConvertTemplateApi.md#converttemplateapplyhtmltemplate) | **POST** /convert/template/html/apply | Apply HTML template
*ConvertWebApi* | [**ConvertWebHtmlToDocx**](docs/ConvertWebApi.md#convertwebhtmltodocx) | **POST** /convert/html/to/docx | Convert HTML to Word DOCX Document
*ConvertWebApi* | [**ConvertWebHtmlToPdf**](docs/ConvertWebApi.md#convertwebhtmltopdf) | **POST** /convert/web/html/to/pdf | Convert HTML string to PDF
*ConvertWebApi* | [**ConvertWebHtmlToPng**](docs/ConvertWebApi.md#convertwebhtmltopng) | **POST** /convert/web/html/to/png | Convert HTML string to PNG screenshot
*ConvertWebApi* | [**ConvertWebHtmlToTxt**](docs/ConvertWebApi.md#convertwebhtmltotxt) | **POST** /convert/web/html/to/txt | Convert HTML string to text (txt)
*ConvertWebApi* | [**ConvertWebMdToHtml**](docs/ConvertWebApi.md#convertwebmdtohtml) | **POST** /convert/web/md/to/html | Convert Markdown to HTML
*ConvertWebApi* | [**ConvertWebUrlToPdf**](docs/ConvertWebApi.md#convertweburltopdf) | **POST** /convert/web/url/to/pdf | Convert a URL to PDF
*ConvertWebApi* | [**ConvertWebUrlToScreenshot**](docs/ConvertWebApi.md#convertweburltoscreenshot) | **POST** /convert/web/url/to/screenshot | Take screenshot of URL
*ConvertWebApi* | [**ConvertWebUrlToTxt**](docs/ConvertWebApi.md#convertweburltotxt) | **POST** /convert/web/url/to/txt | Convert website URL page to text (txt)
*EditDocumentApi* | [**EditDocumentBeginEditing**](docs/EditDocumentApi.md#editdocumentbeginediting) | **POST** /convert/edit/begin-editing | Begin editing a document
*EditDocumentApi* | [**EditDocumentDocxAcceptAllTrackChanges**](docs/EditDocumentApi.md#editdocumentdocxacceptalltrackchanges) | **POST** /convert/edit/docx/track-changes/accept-all | Accept all tracked changes, revisions in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxBody**](docs/EditDocumentApi.md#editdocumentdocxbody) | **POST** /convert/edit/docx/get-body | Get body from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxCreateBlankDocument**](docs/EditDocumentApi.md#editdocumentdocxcreateblankdocument) | **POST** /convert/edit/docx/create/blank | Create a blank Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxDeletePages**](docs/EditDocumentApi.md#editdocumentdocxdeletepages) | **POST** /convert/edit/docx/delete-pages | Delete, remove pages from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxDeleteTableRow**](docs/EditDocumentApi.md#editdocumentdocxdeletetablerow) | **POST** /convert/edit/docx/delete-table-row | Deletes a table row in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxDeleteTableRowRange**](docs/EditDocumentApi.md#editdocumentdocxdeletetablerowrange) | **POST** /convert/edit/docx/delete-table-row/range | Deletes a range of multiple table rows in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxDisableTrackChanges**](docs/EditDocumentApi.md#editdocumentdocxdisabletrackchanges) | **POST** /convert/edit/docx/track-changes/disable | Disable track changes, revisions in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxEnableTrackChanges**](docs/EditDocumentApi.md#editdocumentdocxenabletrackchanges) | **POST** /convert/edit/docx/track-changes/enable | Enable track changes, revisions in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxFindParagraph**](docs/EditDocumentApi.md#editdocumentdocxfindparagraph) | **POST** /convert/edit/docx/find/paragraph | Find matching paragraphs in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetComments**](docs/EditDocumentApi.md#editdocumentdocxgetcomments) | **POST** /convert/edit/docx/get-comments/flat-list | Get comments from a Word DOCX document as a flat list
*EditDocumentApi* | [**EditDocumentDocxGetCommentsHierarchical**](docs/EditDocumentApi.md#editdocumentdocxgetcommentshierarchical) | **POST** /convert/edit/docx/get-comments/hierarchical | Get comments from a Word DOCX document hierarchically
*EditDocumentApi* | [**EditDocumentDocxGetContentControls**](docs/EditDocumentApi.md#editdocumentdocxgetcontentcontrols) | **POST** /convert/edit/docx/get-content-controls | Get all content controls (form fields) and values in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetFormFields**](docs/EditDocumentApi.md#editdocumentdocxgetformfields) | **POST** /convert/edit/docx/get-form-fields | Get all form fields in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetHeadersAndFooters**](docs/EditDocumentApi.md#editdocumentdocxgetheadersandfooters) | **POST** /convert/edit/docx/get-headers-and-footers | Get content of a footer from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetImages**](docs/EditDocumentApi.md#editdocumentdocxgetimages) | **POST** /convert/edit/docx/get-images | Get images from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetMacroInformation**](docs/EditDocumentApi.md#editdocumentdocxgetmacroinformation) | **POST** /convert/edit/docx/get-macros | Get macro information from a Word DOCX/DOCM document
*EditDocumentApi* | [**EditDocumentDocxGetMetadataProperties**](docs/EditDocumentApi.md#editdocumentdocxgetmetadataproperties) | **POST** /convert/edit/docx/get-metadata | Get all metadata properties in Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetSections**](docs/EditDocumentApi.md#editdocumentdocxgetsections) | **POST** /convert/edit/docx/get-sections | Get sections from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetStyles**](docs/EditDocumentApi.md#editdocumentdocxgetstyles) | **POST** /convert/edit/docx/get-styles | Get styles from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetTableByIndex**](docs/EditDocumentApi.md#editdocumentdocxgettablebyindex) | **POST** /convert/edit/docx/get-table/by-index | Get a specific table by index in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetTableRow**](docs/EditDocumentApi.md#editdocumentdocxgettablerow) | **POST** /convert/edit/docx/get-table-row | Gets the contents of an existing table row in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetTables**](docs/EditDocumentApi.md#editdocumentdocxgettables) | **POST** /convert/edit/docx/get-tables | Get all tables in Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxInsertCommentOnParagraph**](docs/EditDocumentApi.md#editdocumentdocxinsertcommentonparagraph) | **POST** /convert/edit/docx/insert-comment/on/paragraph | Insert a new comment into a Word DOCX document attached to a paragraph
*EditDocumentApi* | [**EditDocumentDocxInsertImage**](docs/EditDocumentApi.md#editdocumentdocxinsertimage) | **POST** /convert/edit/docx/insert-image | Insert image into a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxInsertParagraph**](docs/EditDocumentApi.md#editdocumentdocxinsertparagraph) | **POST** /convert/edit/docx/insert-paragraph | Insert a new paragraph into a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxInsertTable**](docs/EditDocumentApi.md#editdocumentdocxinserttable) | **POST** /convert/edit/docx/insert-table | Insert a new table into a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxInsertTableRow**](docs/EditDocumentApi.md#editdocumentdocxinserttablerow) | **POST** /convert/edit/docx/insert-table-row | Insert a new row into an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxPages**](docs/EditDocumentApi.md#editdocumentdocxpages) | **POST** /convert/edit/docx/get-pages | Get pages and content from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxRemoveAllComments**](docs/EditDocumentApi.md#editdocumentdocxremoveallcomments) | **POST** /convert/edit/docx/comments/remove-all | Remove all comments from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxRemoveHeadersAndFooters**](docs/EditDocumentApi.md#editdocumentdocxremoveheadersandfooters) | **POST** /convert/edit/docx/remove-headers-and-footers | Remove headers and footers from Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxRemoveObject**](docs/EditDocumentApi.md#editdocumentdocxremoveobject) | **POST** /convert/edit/docx/remove-object | Delete any object in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxReplace**](docs/EditDocumentApi.md#editdocumentdocxreplace) | **POST** /convert/edit/docx/replace-all | Replace string in Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxReplaceMulti**](docs/EditDocumentApi.md#editdocumentdocxreplacemulti) | **POST** /convert/edit/docx/replace-all/multi | Replace multiple strings in Word DOCX document, return result
*EditDocumentApi* | [**EditDocumentDocxReplaceMultiEditSession**](docs/EditDocumentApi.md#editdocumentdocxreplacemultieditsession) | **POST** /convert/edit/docx/replace-all/multi/edit-session | Replace multiple strings in Word DOCX document, return edit session
*EditDocumentApi* | [**EditDocumentDocxReplaceParagraph**](docs/EditDocumentApi.md#editdocumentdocxreplaceparagraph) | **POST** /convert/edit/docx/replace/paragraph | Replace matching paragraphs in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxSetCustomMetadataProperties**](docs/EditDocumentApi.md#editdocumentdocxsetcustommetadataproperties) | **POST** /convert/edit/docx/set-metadata/custom-property | Set custom property metadata properties in Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxSetFooter**](docs/EditDocumentApi.md#editdocumentdocxsetfooter) | **POST** /convert/edit/docx/set-footer | Set the footer in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxSetFooterAddPageNumber**](docs/EditDocumentApi.md#editdocumentdocxsetfooteraddpagenumber) | **POST** /convert/edit/docx/set-footer/add-page-number | Add page number to footer in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxSetFormFields**](docs/EditDocumentApi.md#editdocumentdocxsetformfields) | **POST** /convert/edit/docx/set-form-fields | Set and fill values for form fields in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxSetHeader**](docs/EditDocumentApi.md#editdocumentdocxsetheader) | **POST** /convert/edit/docx/set-header | Set the header in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxUpdateTableCell**](docs/EditDocumentApi.md#editdocumentdocxupdatetablecell) | **POST** /convert/edit/docx/update-table-cell | Update, set contents of a table cell in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxUpdateTableRow**](docs/EditDocumentApi.md#editdocumentdocxupdatetablerow) | **POST** /convert/edit/docx/update-table-row | Update, set contents of a table row in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentFinishEditing**](docs/EditDocumentApi.md#editdocumentfinishediting) | **POST** /convert/edit/finish-editing | Finish editing document, and download result from document editing
*EditDocumentApi* | [**EditDocumentPptxDeleteSlides**](docs/EditDocumentApi.md#editdocumentpptxdeleteslides) | **POST** /convert/edit/pptx/delete-slides | Delete, remove slides from a PowerPoint PPTX presentation document
*EditDocumentApi* | [**EditDocumentPptxEditSizeAndOrientation**](docs/EditDocumentApi.md#editdocumentpptxeditsizeandorientation) | **POST** /convert/edit/pptx/set-size-and-orientation | Set the size and/or orientation of a PowerPoint PPTX presentation document
*EditDocumentApi* | [**EditDocumentPptxGetMacroInformation**](docs/EditDocumentApi.md#editdocumentpptxgetmacroinformation) | **POST** /convert/edit/pptx/get-macros | Get macro information from a PowerPoint PPTX/PPTM presentation document
*EditDocumentApi* | [**EditDocumentPptxGetSizeAndOrientation**](docs/EditDocumentApi.md#editdocumentpptxgetsizeandorientation) | **POST** /convert/edit/pptx/get-size-and-orientation | Get the page layout information, including size and orientation of a PowerPoint PPTX presentation document
*EditDocumentApi* | [**EditDocumentPptxReplace**](docs/EditDocumentApi.md#editdocumentpptxreplace) | **POST** /convert/edit/pptx/replace-all | Replace string in PowerPoint PPTX presentation
*EditDocumentApi* | [**EditDocumentXlsxAppendRow**](docs/EditDocumentApi.md#editdocumentxlsxappendrow) | **POST** /convert/edit/xlsx/append-row | Append row to a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxClearCellByIndex**](docs/EditDocumentApi.md#editdocumentxlsxclearcellbyindex) | **POST** /convert/edit/xlsx/clear-cell/by-index | Clear cell contents in an Excel XLSX spreadsheet, worksheet by index
*EditDocumentApi* | [**EditDocumentXlsxClearRow**](docs/EditDocumentApi.md#editdocumentxlsxclearrow) | **POST** /convert/edit/xlsx/clear-row | Clear row from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxCreateBlankSpreadsheet**](docs/EditDocumentApi.md#editdocumentxlsxcreateblankspreadsheet) | **POST** /convert/edit/xlsx/create/blank | Create a blank Excel XLSX spreadsheet
*EditDocumentApi* | [**EditDocumentXlsxCreateSpreadsheetFromData**](docs/EditDocumentApi.md#editdocumentxlsxcreatespreadsheetfromdata) | **POST** /convert/edit/xlsx/create/from/data | Create a new Excel XLSX spreadsheet from column and row data
*EditDocumentApi* | [**EditDocumentXlsxDeleteWorksheet**](docs/EditDocumentApi.md#editdocumentxlsxdeleteworksheet) | **POST** /convert/edit/xlsx/delete-worksheet | Delete, remove worksheet from an Excel XLSX spreadsheet document
*EditDocumentApi* | [**EditDocumentXlsxDisableSharedWorkbook**](docs/EditDocumentApi.md#editdocumentxlsxdisablesharedworkbook) | **POST** /convert/edit/xlsx/configuration/disable-shared-workbook | Disable Shared Workbook (legacy) in Excel XLSX spreadsheet
*EditDocumentApi* | [**EditDocumentXlsxEnableSharedWorkbook**](docs/EditDocumentApi.md#editdocumentxlsxenablesharedworkbook) | **POST** /convert/edit/xlsx/configuration/enable-shared-workbook | Enable Shared Workbook (legacy) in Excel XLSX spreadsheet
*EditDocumentApi* | [**EditDocumentXlsxGetCellByIdentifier**](docs/EditDocumentApi.md#editdocumentxlsxgetcellbyidentifier) | **POST** /convert/edit/xlsx/get-cell/by-identifier | Get cell from an Excel XLSX spreadsheet, worksheet by cell identifier
*EditDocumentApi* | [**EditDocumentXlsxGetCellByIndex**](docs/EditDocumentApi.md#editdocumentxlsxgetcellbyindex) | **POST** /convert/edit/xlsx/get-cell/by-index | Get cell from an Excel XLSX spreadsheet, worksheet by index
*EditDocumentApi* | [**EditDocumentXlsxGetColumns**](docs/EditDocumentApi.md#editdocumentxlsxgetcolumns) | **POST** /convert/edit/xlsx/get-columns | Get columns from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetImages**](docs/EditDocumentApi.md#editdocumentxlsxgetimages) | **POST** /convert/edit/xlsx/get-images | Get images from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetMacroInformation**](docs/EditDocumentApi.md#editdocumentxlsxgetmacroinformation) | **POST** /convert/edit/xlsx/get-macros | Get macro information from a Excel XLSX/XLSM spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetRowsAndCells**](docs/EditDocumentApi.md#editdocumentxlsxgetrowsandcells) | **POST** /convert/edit/xlsx/get-rows-and-cells | Get rows and cells from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetSpecificRow**](docs/EditDocumentApi.md#editdocumentxlsxgetspecificrow) | **POST** /convert/edit/xlsx/get-specific-row | Get a specific row from a Excel XLSX spreadsheet, worksheet by path
*EditDocumentApi* | [**EditDocumentXlsxGetStyles**](docs/EditDocumentApi.md#editdocumentxlsxgetstyles) | **POST** /convert/edit/xlsx/get-styles | Get styles from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetWorksheets**](docs/EditDocumentApi.md#editdocumentxlsxgetworksheets) | **POST** /convert/edit/xlsx/get-worksheets | Get worksheets from a Excel XLSX spreadsheet
*EditDocumentApi* | [**EditDocumentXlsxInsertWorksheet**](docs/EditDocumentApi.md#editdocumentxlsxinsertworksheet) | **POST** /convert/edit/xlsx/insert-worksheet | Insert a new worksheet into an Excel XLSX spreadsheet
*EditDocumentApi* | [**EditDocumentXlsxRenameWorksheet**](docs/EditDocumentApi.md#editdocumentxlsxrenameworksheet) | **POST** /convert/edit/xlsx/rename-worksheet | Rename a specific worksheet in a Excel XLSX spreadsheet
*EditDocumentApi* | [**EditDocumentXlsxSetCellByIdentifier**](docs/EditDocumentApi.md#editdocumentxlsxsetcellbyidentifier) | **POST** /convert/edit/xlsx/set-cell/by-identifier | Set, update cell contents in an Excel XLSX spreadsheet, worksheet by cell identifier
*EditDocumentApi* | [**EditDocumentXlsxSetCellByIndex**](docs/EditDocumentApi.md#editdocumentxlsxsetcellbyindex) | **POST** /convert/edit/xlsx/set-cell/by-index | Set, update cell contents in an Excel XLSX spreadsheet, worksheet by index
*EditHtmlApi* | [**EditHtmlHtmlAppendHeaderTag**](docs/EditHtmlApi.md#edithtmlhtmlappendheadertag) | **POST** /convert/edit/html/head/append/tag | Append an HTML tag to the HEAD section of an HTML Document
*EditHtmlApi* | [**EditHtmlHtmlAppendHeading**](docs/EditHtmlApi.md#edithtmlhtmlappendheading) | **POST** /convert/edit/html/append/heading | Append a Heading to an HTML Document
*EditHtmlApi* | [**EditHtmlHtmlAppendImageFromUrl**](docs/EditHtmlApi.md#edithtmlhtmlappendimagefromurl) | **POST** /convert/edit/html/append/image/from-url | Append an Image to an HTML Document from a URL
*EditHtmlApi* | [**EditHtmlHtmlAppendImageInline**](docs/EditHtmlApi.md#edithtmlhtmlappendimageinline) | **POST** /convert/edit/html/append/image/inline | Append a Base64 Inline Image to an HTML Document
*EditHtmlApi* | [**EditHtmlHtmlAppendParagraph**](docs/EditHtmlApi.md#edithtmlhtmlappendparagraph) | **POST** /convert/edit/html/append/paragraph | Append a Paragraph to an HTML Document
*EditHtmlApi* | [**EditHtmlHtmlCreateBlankDocument**](docs/EditHtmlApi.md#edithtmlhtmlcreateblankdocument) | **POST** /convert/edit/html/create/blank | Create a Blank HTML Document
*EditHtmlApi* | [**EditHtmlHtmlGetLanguage**](docs/EditHtmlApi.md#edithtmlhtmlgetlanguage) | **POST** /convert/edit/html/head/get/language | Gets the language for the HTML document
*EditHtmlApi* | [**EditHtmlHtmlGetLinks**](docs/EditHtmlApi.md#edithtmlhtmlgetlinks) | **POST** /convert/edit/html/extract/links | Extract resolved link URLs from HTML File
*EditHtmlApi* | [**EditHtmlHtmlGetRelCanonical**](docs/EditHtmlApi.md#edithtmlhtmlgetrelcanonical) | **POST** /convert/edit/html/head/get/rel-canonical-url | Gets the rel canonical URL for the HTML document
*EditHtmlApi* | [**EditHtmlHtmlGetSitemap**](docs/EditHtmlApi.md#edithtmlhtmlgetsitemap) | **POST** /convert/edit/html/head/get/sitemap-url | Gets the sitemap URL for the HTML document
*EditHtmlApi* | [**EditHtmlHtmlSetLanguage**](docs/EditHtmlApi.md#edithtmlhtmlsetlanguage) | **POST** /convert/edit/html/head/set/language | Sets the language for the HTML document
*EditHtmlApi* | [**EditHtmlHtmlSetRelCanonical**](docs/EditHtmlApi.md#edithtmlhtmlsetrelcanonical) | **POST** /convert/edit/html/head/set/rel-canonical-url | Sets the rel canonical URL for the HTML document
*EditHtmlApi* | [**EditHtmlHtmlSetSitemapUrl**](docs/EditHtmlApi.md#edithtmlhtmlsetsitemapurl) | **POST** /convert/edit/html/head/set/sitemap-url | Sets the sitemap URL for the HTML document
*EditPdfApi* | [**EditPdfAddAnnotations**](docs/EditPdfApi.md#editpdfaddannotations) | **POST** /convert/edit/pdf/annotations/add-item | Add one or more PDF annotations, comments in the PDF document
*EditPdfApi* | [**EditPdfConvertToPdfA**](docs/EditPdfApi.md#editpdfconverttopdfa) | **POST** /convert/edit/pdf/optimize/pdf-a | Convert a PDF file to PDF/A
*EditPdfApi* | [**EditPdfDecrypt**](docs/EditPdfApi.md#editpdfdecrypt) | **POST** /convert/edit/pdf/decrypt | Decrypt and password-protect a PDF
*EditPdfApi* | [**EditPdfDeletePages**](docs/EditPdfApi.md#editpdfdeletepages) | **POST** /convert/edit/pdf/pages/delete | Remove, delete pages from a PDF document
*EditPdfApi* | [**EditPdfDeletePagesBatchJob**](docs/EditPdfApi.md#editpdfdeletepagesbatchjob) | **POST** /convert/edit/pdf/pages/delete/batch-job | Remove, delete pages from a PDF document as Batch Job
*EditPdfApi* | [**EditPdfEncrypt**](docs/EditPdfApi.md#editpdfencrypt) | **POST** /convert/edit/pdf/encrypt | Encrypt and password-protect a PDF
*EditPdfApi* | [**EditPdfGetAnnotations**](docs/EditPdfApi.md#editpdfgetannotations) | **POST** /convert/edit/pdf/annotations/list | Get PDF annotations, including comments in the document
*EditPdfApi* | [**EditPdfGetAsyncJobStatus**](docs/EditPdfApi.md#editpdfgetasyncjobstatus) | **GET** /convert/edit/pdf/batch-job/status | Get the status and result of a PDF Batch Job
*EditPdfApi* | [**EditPdfGetFormFields**](docs/EditPdfApi.md#editpdfgetformfields) | **POST** /convert/edit/pdf/form/get-fields | Gets PDF Form fields and values
*EditPdfApi* | [**EditPdfGetMetadata**](docs/EditPdfApi.md#editpdfgetmetadata) | **POST** /convert/edit/pdf/get-metadata | Get PDF document metadata
*EditPdfApi* | [**EditPdfGetPdfTextByPages**](docs/EditPdfApi.md#editpdfgetpdftextbypages) | **POST** /convert/edit/pdf/pages/get-text | Get text in a PDF document by page
*EditPdfApi* | [**EditPdfInsertPages**](docs/EditPdfApi.md#editpdfinsertpages) | **POST** /convert/edit/pdf/pages/insert | Insert, copy pages from one PDF document into another
*EditPdfApi* | [**EditPdfInsertPagesBatchJob**](docs/EditPdfApi.md#editpdfinsertpagesbatchjob) | **POST** /convert/edit/pdf/pages/insert/batch-job | Insert, copy pages from one PDF document into another as a batch job
*EditPdfApi* | [**EditPdfLinearize**](docs/EditPdfApi.md#editpdflinearize) | **POST** /convert/edit/pdf/optimize/linearize | Linearize and optimize a PDF for streaming download
*EditPdfApi* | [**EditPdfRasterize**](docs/EditPdfApi.md#editpdfrasterize) | **POST** /convert/edit/pdf/rasterize | Rasterize a PDF to an image-based PDF
*EditPdfApi* | [**EditPdfRasterizeBatchJob**](docs/EditPdfApi.md#editpdfrasterizebatchjob) | **POST** /convert/edit/pdf/rasterize/batch-job | Rasterize a PDF to an image-based PDF as Batch Job
*EditPdfApi* | [**EditPdfReduceFileSize**](docs/EditPdfApi.md#editpdfreducefilesize) | **POST** /convert/edit/pdf/optimize/reduce-file-size | Reduce the file size and optimize a PDF
*EditPdfApi* | [**EditPdfRemoveAllAnnotations**](docs/EditPdfApi.md#editpdfremoveallannotations) | **POST** /convert/edit/pdf/annotations/remove-all | Remove all PDF annotations, including comments in the document
*EditPdfApi* | [**EditPdfRemoveAnnotationItem**](docs/EditPdfApi.md#editpdfremoveannotationitem) | **POST** /convert/edit/pdf/annotations/remove-item | Remove a specific PDF annotation, comment in the document
*EditPdfApi* | [**EditPdfResize**](docs/EditPdfApi.md#editpdfresize) | **POST** /convert/edit/pdf/resize | Change PDF Document's Paper Size
*EditPdfApi* | [**EditPdfRotateAllPages**](docs/EditPdfApi.md#editpdfrotateallpages) | **POST** /convert/edit/pdf/pages/rotate/all | Rotate all pages in a PDF document
*EditPdfApi* | [**EditPdfRotatePageRange**](docs/EditPdfApi.md#editpdfrotatepagerange) | **POST** /convert/edit/pdf/pages/rotate/page-range | Rotate a range, subset of pages in a PDF document
*EditPdfApi* | [**EditPdfSetFormFields**](docs/EditPdfApi.md#editpdfsetformfields) | **POST** /convert/edit/pdf/form/set-fields | Sets ands fills PDF Form field values
*EditPdfApi* | [**EditPdfSetMetadata**](docs/EditPdfApi.md#editpdfsetmetadata) | **POST** /convert/edit/pdf/set-metadata | Sets PDF document metadata
*EditPdfApi* | [**EditPdfSetPermissions**](docs/EditPdfApi.md#editpdfsetpermissions) | **POST** /convert/edit/pdf/encrypt/set-permissions | Encrypt, password-protect and set restricted permissions on a PDF
*EditPdfApi* | [**EditPdfWatermarkText**](docs/EditPdfApi.md#editpdfwatermarktext) | **POST** /convert/edit/pdf/watermark/text | Add a text watermark to a PDF
*EditTextApi* | [**EditTextBase64Decode**](docs/EditTextApi.md#edittextbase64decode) | **POST** /convert/edit/text/encoding/base64/decode | Base 64 decode, convert base 64 string to binary content
*EditTextApi* | [**EditTextBase64Detect**](docs/EditTextApi.md#edittextbase64detect) | **POST** /convert/edit/text/encoding/base64/detect | Detect, check if text string is base 64 encoded
*EditTextApi* | [**EditTextBase64Encode**](docs/EditTextApi.md#edittextbase64encode) | **POST** /convert/edit/text/encoding/base64/encode | Base 64 encode, convert binary or file data to a text string
*EditTextApi* | [**EditTextChangeLineEndings**](docs/EditTextApi.md#edittextchangelineendings) | **POST** /convert/edit/text/line-endings/change | Set, change line endings of a text file
*EditTextApi* | [**EditTextDetectLineEndings**](docs/EditTextApi.md#edittextdetectlineendings) | **POST** /convert/edit/text/line-endings/detect | Detect line endings of a text file
*EditTextApi* | [**EditTextFindRegex**](docs/EditTextApi.md#edittextfindregex) | **POST** /convert/edit/text/find/regex | Find a regular expression regex in text input
*EditTextApi* | [**EditTextFindSimple**](docs/EditTextApi.md#edittextfindsimple) | **POST** /convert/edit/text/find/string | Find a string in text input
*EditTextApi* | [**EditTextRemoveAllWhitespace**](docs/EditTextApi.md#edittextremoveallwhitespace) | **POST** /convert/edit/text/remove/whitespace/all | Remove whitespace from text string
*EditTextApi* | [**EditTextRemoveHtml**](docs/EditTextApi.md#edittextremovehtml) | **POST** /convert/edit/text/remove/html | Remove HTML from text string
*EditTextApi* | [**EditTextReplaceRegex**](docs/EditTextApi.md#edittextreplaceregex) | **POST** /convert/edit/text/replace/regex | Replace a string in text with a regex regular expression string
*EditTextApi* | [**EditTextReplaceSimple**](docs/EditTextApi.md#edittextreplacesimple) | **POST** /convert/edit/text/replace/string | Replace a string in text with another string value
*EditTextApi* | [**EditTextTextEncodingDetect**](docs/EditTextApi.md#edittexttextencodingdetect) | **POST** /convert/edit/text/encoding/detect | Detect text encoding of file
*EditTextApi* | [**EditTextTrimWhitespace**](docs/EditTextApi.md#edittexttrimwhitespace) | **POST** /convert/edit/text/remove/whitespace/trim | Trim leading and trailing whitespace from text string
*MergeDocumentApi* | [**MergeDocumentBatchJobCreate**](docs/MergeDocumentApi.md#mergedocumentbatchjobcreate) | **POST** /convert/merge/batch-job/create | Merge an array of Documents into a Single Document by Page as a Batch Job
*MergeDocumentApi* | [**MergeDocumentDocx**](docs/MergeDocumentApi.md#mergedocumentdocx) | **POST** /convert/merge/docx | Merge Two Word DOCX Together
*MergeDocumentApi* | [**MergeDocumentDocxMulti**](docs/MergeDocumentApi.md#mergedocumentdocxmulti) | **POST** /convert/merge/docx/multi | Merge Multple Word DOCX Together
*MergeDocumentApi* | [**MergeDocumentDocxMultiArray**](docs/MergeDocumentApi.md#mergedocumentdocxmultiarray) | **POST** /convert/merge/docx/multi/array | Merge Multple Word DOCX Together from an array
*MergeDocumentApi* | [**MergeDocumentGetAsyncJobStatus**](docs/MergeDocumentApi.md#mergedocumentgetasyncjobstatus) | **GET** /convert/merge/batch-job/status | Get the status and result of a Merge Document Batch Job
*MergeDocumentApi* | [**MergeDocumentHtml**](docs/MergeDocumentApi.md#mergedocumenthtml) | **POST** /convert/merge/html | Merge Two HTML (HTM) Files Together
*MergeDocumentApi* | [**MergeDocumentHtmlMulti**](docs/MergeDocumentApi.md#mergedocumenthtmlmulti) | **POST** /convert/merge/html/multi | Merge Multple HTML (HTM) Files Together
*MergeDocumentApi* | [**MergeDocumentHtmlMultiArray**](docs/MergeDocumentApi.md#mergedocumenthtmlmultiarray) | **POST** /convert/merge/html/multi/array | Merge Multple HTML (HTM) Files Together from an array
*MergeDocumentApi* | [**MergeDocumentPdf**](docs/MergeDocumentApi.md#mergedocumentpdf) | **POST** /convert/merge/pdf | Merge Two PDF Files Together
*MergeDocumentApi* | [**MergeDocumentPdfMulti**](docs/MergeDocumentApi.md#mergedocumentpdfmulti) | **POST** /convert/merge/pdf/multi | Merge Multple PDF Files Together
*MergeDocumentApi* | [**MergeDocumentPdfMultiArray**](docs/MergeDocumentApi.md#mergedocumentpdfmultiarray) | **POST** /convert/merge/pdf/multi/array | Merge Multple PDF Files Together from an array
*MergeDocumentApi* | [**MergeDocumentPng**](docs/MergeDocumentApi.md#mergedocumentpng) | **POST** /convert/merge/png/vertical | Merge Two PNG Files Together
*MergeDocumentApi* | [**MergeDocumentPngMulti**](docs/MergeDocumentApi.md#mergedocumentpngmulti) | **POST** /convert/merge/png/vertical/multi | Merge Multple PNG Files Together
*MergeDocumentApi* | [**MergeDocumentPngMultiArray**](docs/MergeDocumentApi.md#mergedocumentpngmultiarray) | **POST** /convert/merge/png/vertical/multi/array | Merge Multple PNG Files Together from an array
*MergeDocumentApi* | [**MergeDocumentPptx**](docs/MergeDocumentApi.md#mergedocumentpptx) | **POST** /convert/merge/pptx | Merge Two PowerPoint PPTX Together
*MergeDocumentApi* | [**MergeDocumentPptxMulti**](docs/MergeDocumentApi.md#mergedocumentpptxmulti) | **POST** /convert/merge/pptx/multi | Merge Multple PowerPoint PPTX Together
*MergeDocumentApi* | [**MergeDocumentPptxMultiArray**](docs/MergeDocumentApi.md#mergedocumentpptxmultiarray) | **POST** /convert/merge/pptx/multi/array | Merge Multple PowerPoint PPTX Together from an array
*MergeDocumentApi* | [**MergeDocumentTxt**](docs/MergeDocumentApi.md#mergedocumenttxt) | **POST** /convert/merge/txt | Merge Two Text (TXT) Files Together
*MergeDocumentApi* | [**MergeDocumentTxtMulti**](docs/MergeDocumentApi.md#mergedocumenttxtmulti) | **POST** /convert/merge/txt/multi | Merge Multple Text (TXT) Files Together
*MergeDocumentApi* | [**MergeDocumentXlsx**](docs/MergeDocumentApi.md#mergedocumentxlsx) | **POST** /convert/merge/xlsx | Merge Two Excel XLSX Together
*MergeDocumentApi* | [**MergeDocumentXlsxMulti**](docs/MergeDocumentApi.md#mergedocumentxlsxmulti) | **POST** /convert/merge/xlsx/multi | Merge Multple Excel XLSX Together
*MergeDocumentApi* | [**MergeDocumentXlsxMultiArray**](docs/MergeDocumentApi.md#mergedocumentxlsxmultiarray) | **POST** /convert/merge/xlsx/multi/array | Merge Multple Excel XLSX Together from an Array
*SplitDocumentApi* | [**SplitDocumentBatchJobCreate**](docs/SplitDocumentApi.md#splitdocumentbatchjobcreate) | **POST** /convert/split/batch-job/create | Split a single Document into Separate Documents by Page as a Batch Job
*SplitDocumentApi* | [**SplitDocumentDocx**](docs/SplitDocumentApi.md#splitdocumentdocx) | **POST** /convert/split/docx | Split a single Word Document DOCX into Separate Documents by Page
*SplitDocumentApi* | [**SplitDocumentGetAsyncJobStatus**](docs/SplitDocumentApi.md#splitdocumentgetasyncjobstatus) | **GET** /convert/split/batch-job/status | Get the status and result of a Split Document Batch Job
*SplitDocumentApi* | [**SplitDocumentPdfByPage**](docs/SplitDocumentApi.md#splitdocumentpdfbypage) | **POST** /convert/split/pdf | Split a PDF file into separate PDF files, one per page
*SplitDocumentApi* | [**SplitDocumentPptx**](docs/SplitDocumentApi.md#splitdocumentpptx) | **POST** /convert/split/pptx | Split a single PowerPoint Presentation PPTX into Separate Slides
*SplitDocumentApi* | [**SplitDocumentPptxAdvanced**](docs/SplitDocumentApi.md#splitdocumentpptxadvanced) | **POST** /convert/split/pptx/advanced | Split a single PowerPoint Presentation PPTX into Separate Presentations
*SplitDocumentApi* | [**SplitDocumentTxtByLine**](docs/SplitDocumentApi.md#splitdocumenttxtbyline) | **POST** /convert/split/txt/by-line | Split a single Text file (txt) into lines
*SplitDocumentApi* | [**SplitDocumentTxtByString**](docs/SplitDocumentApi.md#splitdocumenttxtbystring) | **POST** /convert/split/txt/by-string | Split a single Text file (txt) by a string delimiter
*SplitDocumentApi* | [**SplitDocumentXlsx**](docs/SplitDocumentApi.md#splitdocumentxlsx) | **POST** /convert/split/xlsx | Split a single Excel XLSX into Separate Worksheets
*TransformDocumentApi* | [**TransformDocumentDocxReplace**](docs/TransformDocumentApi.md#transformdocumentdocxreplace) | **POST** /convert/transform/docx/replace-all | Replace string in Word DOCX document, return result
*TransformDocumentApi* | [**TransformDocumentDocxReplaceEditSession**](docs/TransformDocumentApi.md#transformdocumentdocxreplaceeditsession) | **POST** /convert/transform/docx/replace-all/edit-session | Replace string in Word DOCX document, return edit session
*TransformDocumentApi* | [**TransformDocumentDocxTableFillIn**](docs/TransformDocumentApi.md#transformdocumentdocxtablefillin) | **POST** /convert/transform/docx/table/fill/data | Fill in data in a table in a Word DOCX document, return result
*TransformDocumentApi* | [**TransformDocumentDocxTableFillInEditSession**](docs/TransformDocumentApi.md#transformdocumentdocxtablefillineditsession) | **POST** /convert/transform/docx/table/fill/data/edit-session | Fill in data in a table in a Word DOCX document, return edit session
*TransformDocumentApi* | [**TransformDocumentDocxTableFillInMulti**](docs/TransformDocumentApi.md#transformdocumentdocxtablefillinmulti) | **POST** /convert/transform/docx/table/fill/data/multi | Fill in data in multiple tables in a Word DOCX document, return result
*TransformDocumentApi* | [**TransformDocumentPptxReplace**](docs/TransformDocumentApi.md#transformdocumentpptxreplace) | **POST** /convert/transform/pptx/replace-all | Replace string in PowerPoint PPTX presentation, return result
*ValidateDocumentApi* | [**ValidateDocumentAutodetectValidation**](docs/ValidateDocumentApi.md#validatedocumentautodetectvalidation) | **POST** /convert/validate/autodetect | Autodetect content type and validate
*ValidateDocumentApi* | [**ValidateDocumentCsvValidation**](docs/ValidateDocumentApi.md#validatedocumentcsvvalidation) | **POST** /convert/validate/csv | Validate a CSV file document (CSV)
*ValidateDocumentApi* | [**ValidateDocumentDocValidation**](docs/ValidateDocumentApi.md#validatedocumentdocvalidation) | **POST** /convert/validate/doc | Validate a Word 97-2003 Legacy document (DOC)
*ValidateDocumentApi* | [**ValidateDocumentDocxRepair**](docs/ValidateDocumentApi.md#validatedocumentdocxrepair) | **POST** /convert/validate/docx/repair | Repair a Word document (DOCX) that contains errors
*ValidateDocumentApi* | [**ValidateDocumentDocxValidation**](docs/ValidateDocumentApi.md#validatedocumentdocxvalidation) | **POST** /convert/validate/docx | Validate a Word document (DOCX)
*ValidateDocumentApi* | [**ValidateDocumentEmlValidation**](docs/ValidateDocumentApi.md#validatedocumentemlvalidation) | **POST** /convert/validate/eml | Validate if input file is a valid EML file
*ValidateDocumentApi* | [**ValidateDocumentExecutableValidation**](docs/ValidateDocumentApi.md#validatedocumentexecutablevalidation) | **POST** /convert/validate/executable | Validate if a file is executable
*ValidateDocumentApi* | [**ValidateDocumentGZipValidation**](docs/ValidateDocumentApi.md#validatedocumentgzipvalidation) | **POST** /convert/validate/gzip | Validate a GZip Archive file (gzip or gz)
*ValidateDocumentApi* | [**ValidateDocumentHtmlSsrfValidation**](docs/ValidateDocumentApi.md#validatedocumenthtmlssrfvalidation) | **POST** /convert/validate/html/ssrf-threat-check | Validate an HTML file and checks for SSRF threats
*ValidateDocumentApi* | [**ValidateDocumentHtmlValidation**](docs/ValidateDocumentApi.md#validatedocumenthtmlvalidation) | **POST** /convert/validate/html | Validate an HTML file
*ValidateDocumentApi* | [**ValidateDocumentImageValidation**](docs/ValidateDocumentApi.md#validatedocumentimagevalidation) | **POST** /convert/validate/image | Validate an Image File
*ValidateDocumentApi* | [**ValidateDocumentJpgValidation**](docs/ValidateDocumentApi.md#validatedocumentjpgvalidation) | **POST** /convert/validate/jpg | Validate a JPG File
*ValidateDocumentApi* | [**ValidateDocumentJsonValidation**](docs/ValidateDocumentApi.md#validatedocumentjsonvalidation) | **POST** /convert/validate/json | Validate a JSON file
*ValidateDocumentApi* | [**ValidateDocumentMsgValidation**](docs/ValidateDocumentApi.md#validatedocumentmsgvalidation) | **POST** /convert/validate/msg | Validate if input file is a valid MSG file
*ValidateDocumentApi* | [**ValidateDocumentPdfValidation**](docs/ValidateDocumentApi.md#validatedocumentpdfvalidation) | **POST** /convert/validate/pdf | Validate a PDF document file
*ValidateDocumentApi* | [**ValidateDocumentPngValidation**](docs/ValidateDocumentApi.md#validatedocumentpngvalidation) | **POST** /convert/validate/png | Validate a PNG File
*ValidateDocumentApi* | [**ValidateDocumentPptValidation**](docs/ValidateDocumentApi.md#validatedocumentpptvalidation) | **POST** /convert/validate/ppt | Validate a PowerPoint 97-2003 Legacy presentation (PPT)
*ValidateDocumentApi* | [**ValidateDocumentPptxRepair**](docs/ValidateDocumentApi.md#validatedocumentpptxrepair) | **POST** /convert/validate/pptx/repair | Repair a PowerPoint presentation (PPTX) that contains errors
*ValidateDocumentApi* | [**ValidateDocumentPptxValidation**](docs/ValidateDocumentApi.md#validatedocumentpptxvalidation) | **POST** /convert/validate/pptx | Validate a PowerPoint presentation (PPTX)
*ValidateDocumentApi* | [**ValidateDocumentRarValidation**](docs/ValidateDocumentApi.md#validatedocumentrarvalidation) | **POST** /convert/validate/rar | Validate a RAR Archive file (RAR)
*ValidateDocumentApi* | [**ValidateDocumentRtfValidation**](docs/ValidateDocumentApi.md#validatedocumentrtfvalidation) | **POST** /convert/validate/rtf | Validate a Rich Text Format document (RTF)
*ValidateDocumentApi* | [**ValidateDocumentTarValidation**](docs/ValidateDocumentApi.md#validatedocumenttarvalidation) | **POST** /convert/validate/tar | Validate a TAR Tarball Archive file (TAR)
*ValidateDocumentApi* | [**ValidateDocumentTxtValidation**](docs/ValidateDocumentApi.md#validatedocumenttxtvalidation) | **POST** /convert/validate/txt | Validate an TXT file
*ValidateDocumentApi* | [**ValidateDocumentXlsValidation**](docs/ValidateDocumentApi.md#validatedocumentxlsvalidation) | **POST** /convert/validate/xls | Validate a Excel 97-2003 Legacy spreadsheet (XLS)
*ValidateDocumentApi* | [**ValidateDocumentXlsxRepair**](docs/ValidateDocumentApi.md#validatedocumentxlsxrepair) | **POST** /convert/validate/xlsx/repair | Repair an Excel spreadsheet (XLSX) that contains errors
*ValidateDocumentApi* | [**ValidateDocumentXlsxValidation**](docs/ValidateDocumentApi.md#validatedocumentxlsxvalidation) | **POST** /convert/validate/xlsx | Validate a Excel document (XLSX)
*ValidateDocumentApi* | [**ValidateDocumentXmlValidation**](docs/ValidateDocumentApi.md#validatedocumentxmlvalidation) | **POST** /convert/validate/xml | Validate an XML file
*ValidateDocumentApi* | [**ValidateDocumentXmlXxeThreatValidation**](docs/ValidateDocumentApi.md#validatedocumentxmlxxethreatvalidation) | **POST** /convert/validate/xml/xxe-threats | Validate an XML file for XML External Entity (XXE) threats
*ValidateDocumentApi* | [**ValidateDocumentZipValidation**](docs/ValidateDocumentApi.md#validatedocumentzipvalidation) | **POST** /convert/validate/zip | Validate a Zip Archive file (zip)
*ViewerToolsApi* | [**ViewerToolsCreateSimple**](docs/ViewerToolsApi.md#viewertoolscreatesimple) | **POST** /convert/viewer/create/web/simple | Create a web-based viewer
*ZipArchiveApi* | [**ZipArchiveZipCreate**](docs/ZipArchiveApi.md#ziparchivezipcreate) | **POST** /convert/archive/zip/create | Compress files to create a new zip archive
*ZipArchiveApi* | [**ZipArchiveZipCreateAdvanced**](docs/ZipArchiveApi.md#ziparchivezipcreateadvanced) | **POST** /convert/archive/zip/create/advanced | Compress files and folders to create a new zip archive with advanced options
*ZipArchiveApi* | [**ZipArchiveZipCreateEncrypted**](docs/ZipArchiveApi.md#ziparchivezipcreateencrypted) | **POST** /convert/archive/zip/create/encrypted | Compress files to create a new, encrypted and password-protected zip archive
*ZipArchiveApi* | [**ZipArchiveZipCreateQuarantine**](docs/ZipArchiveApi.md#ziparchivezipcreatequarantine) | **POST** /convert/archive/zip/create/quarantine | Create an encrypted zip file to quarantine a dangerous file
*ZipArchiveApi* | [**ZipArchiveZipDecrypt**](docs/ZipArchiveApi.md#ziparchivezipdecrypt) | **POST** /convert/archive/zip/decrypt | Decrypt and remove password protection on a zip file
*ZipArchiveApi* | [**ZipArchiveZipEncryptAdvanced**](docs/ZipArchiveApi.md#ziparchivezipencryptadvanced) | **POST** /convert/archive/zip/encrypt/advanced | Encrypt and password protect a zip file
*ZipArchiveApi* | [**ZipArchiveZipExtract**](docs/ZipArchiveApi.md#ziparchivezipextract) | **POST** /convert/archive/zip/extract | Extract, decompress files and folders from a zip archive


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddPdfAnnotationRequest](docs/AddPdfAnnotationRequest.md)
 - [Model.AlternateFileFormatCandidate](docs/AlternateFileFormatCandidate.md)
 - [Model.AppendXlsxRowRequest](docs/AppendXlsxRowRequest.md)
 - [Model.AppendXlsxRowResponse](docs/AppendXlsxRowResponse.md)
 - [Model.AutodetectDocumentValidationResult](docs/AutodetectDocumentValidationResult.md)
 - [Model.AutodetectGetInfoResult](docs/AutodetectGetInfoResult.md)
 - [Model.AutodetectToJpgResult](docs/AutodetectToJpgResult.md)
 - [Model.AutodetectToPngResult](docs/AutodetectToPngResult.md)
 - [Model.AutodetectToThumbnailsResult](docs/AutodetectToThumbnailsResult.md)
 - [Model.Base64DecodeRequest](docs/Base64DecodeRequest.md)
 - [Model.Base64DecodeResponse](docs/Base64DecodeResponse.md)
 - [Model.Base64DetectRequest](docs/Base64DetectRequest.md)
 - [Model.Base64DetectResponse](docs/Base64DetectResponse.md)
 - [Model.Base64EncodeRequest](docs/Base64EncodeRequest.md)
 - [Model.Base64EncodeResponse](docs/Base64EncodeResponse.md)
 - [Model.ChangeLineEndingResponse](docs/ChangeLineEndingResponse.md)
 - [Model.ClearXlsxCellRequest](docs/ClearXlsxCellRequest.md)
 - [Model.ClearXlsxCellResponse](docs/ClearXlsxCellResponse.md)
 - [Model.ClearXlsxRowRequest](docs/ClearXlsxRowRequest.md)
 - [Model.ClearXlsxRowResponse](docs/ClearXlsxRowResponse.md)
 - [Model.ConvertDocumentBatchJobCreateResult](docs/ConvertDocumentBatchJobCreateResult.md)
 - [Model.ConvertDocumentJobStatusResult](docs/ConvertDocumentJobStatusResult.md)
 - [Model.ConvertedJpgPage](docs/ConvertedJpgPage.md)
 - [Model.ConvertedPngDirectPage](docs/ConvertedPngDirectPage.md)
 - [Model.ConvertedPngPage](docs/ConvertedPngPage.md)
 - [Model.CreateBlankDocxRequest](docs/CreateBlankDocxRequest.md)
 - [Model.CreateBlankDocxResponse](docs/CreateBlankDocxResponse.md)
 - [Model.CreateBlankSpreadsheetRequest](docs/CreateBlankSpreadsheetRequest.md)
 - [Model.CreateBlankSpreadsheetResponse](docs/CreateBlankSpreadsheetResponse.md)
 - [Model.CreateSpreadsheetFromDataRequest](docs/CreateSpreadsheetFromDataRequest.md)
 - [Model.CreateSpreadsheetFromDataResponse](docs/CreateSpreadsheetFromDataResponse.md)
 - [Model.CreateZipArchiveRequest](docs/CreateZipArchiveRequest.md)
 - [Model.CsvCollection](docs/CsvCollection.md)
 - [Model.CsvFileResult](docs/CsvFileResult.md)
 - [Model.DeleteDocxTableRowRangeRequest](docs/DeleteDocxTableRowRangeRequest.md)
 - [Model.DeleteDocxTableRowRangeResponse](docs/DeleteDocxTableRowRangeResponse.md)
 - [Model.DeleteDocxTableRowRequest](docs/DeleteDocxTableRowRequest.md)
 - [Model.DeleteDocxTableRowResponse](docs/DeleteDocxTableRowResponse.md)
 - [Model.DetectLineEndingsResponse](docs/DetectLineEndingsResponse.md)
 - [Model.DisableSharedWorkbookRequest](docs/DisableSharedWorkbookRequest.md)
 - [Model.DisableSharedWorkbookResponse](docs/DisableSharedWorkbookResponse.md)
 - [Model.DocumentArrayInput](docs/DocumentArrayInput.md)
 - [Model.DocumentEditingEditSession](docs/DocumentEditingEditSession.md)
 - [Model.DocumentItem](docs/DocumentItem.md)
 - [Model.DocumentTransformEditSession](docs/DocumentTransformEditSession.md)
 - [Model.DocumentValidationError](docs/DocumentValidationError.md)
 - [Model.DocumentValidationResult](docs/DocumentValidationResult.md)
 - [Model.DocxBody](docs/DocxBody.md)
 - [Model.DocxCellStyle](docs/DocxCellStyle.md)
 - [Model.DocxComment](docs/DocxComment.md)
 - [Model.DocxContentControl](docs/DocxContentControl.md)
 - [Model.DocxFooter](docs/DocxFooter.md)
 - [Model.DocxHeader](docs/DocxHeader.md)
 - [Model.DocxImage](docs/DocxImage.md)
 - [Model.DocxInsertCommentOnParagraphRequest](docs/DocxInsertCommentOnParagraphRequest.md)
 - [Model.DocxInsertImageRequest](docs/DocxInsertImageRequest.md)
 - [Model.DocxInsertImageResponse](docs/DocxInsertImageResponse.md)
 - [Model.DocxMetadataCustomProperty](docs/DocxMetadataCustomProperty.md)
 - [Model.DocxPage](docs/DocxPage.md)
 - [Model.DocxParagraph](docs/DocxParagraph.md)
 - [Model.DocxRemoveObjectRequest](docs/DocxRemoveObjectRequest.md)
 - [Model.DocxRemoveObjectResponse](docs/DocxRemoveObjectResponse.md)
 - [Model.DocxRun](docs/DocxRun.md)
 - [Model.DocxSection](docs/DocxSection.md)
 - [Model.DocxSetCustomMetadataPropertiesRequest](docs/DocxSetCustomMetadataPropertiesRequest.md)
 - [Model.DocxSetFooterAddPageNumberRequest](docs/DocxSetFooterAddPageNumberRequest.md)
 - [Model.DocxSetFooterRequest](docs/DocxSetFooterRequest.md)
 - [Model.DocxSetFooterResponse](docs/DocxSetFooterResponse.md)
 - [Model.DocxSetFormFieldsRequest](docs/DocxSetFormFieldsRequest.md)
 - [Model.DocxSetHeaderRequest](docs/DocxSetHeaderRequest.md)
 - [Model.DocxSetHeaderResponse](docs/DocxSetHeaderResponse.md)
 - [Model.DocxStyle](docs/DocxStyle.md)
 - [Model.DocxTable](docs/DocxTable.md)
 - [Model.DocxTableCell](docs/DocxTableCell.md)
 - [Model.DocxTableRow](docs/DocxTableRow.md)
 - [Model.DocxTableSingleTableFill](docs/DocxTableSingleTableFill.md)
 - [Model.DocxTableTableFillMultiRequest](docs/DocxTableTableFillMultiRequest.md)
 - [Model.DocxTableTableFillRequest](docs/DocxTableTableFillRequest.md)
 - [Model.DocxTableTableFillTableCell](docs/DocxTableTableFillTableCell.md)
 - [Model.DocxTableTableFillTableRow](docs/DocxTableTableFillTableRow.md)
 - [Model.DocxTemplateApplicationRequest](docs/DocxTemplateApplicationRequest.md)
 - [Model.DocxTemplateOperation](docs/DocxTemplateOperation.md)
 - [Model.DocxText](docs/DocxText.md)
 - [Model.DocxToJpgResult](docs/DocxToJpgResult.md)
 - [Model.DocxToPngResult](docs/DocxToPngResult.md)
 - [Model.DocxTopLevelComment](docs/DocxTopLevelComment.md)
 - [Model.EditPdfBatchJobCreateResult](docs/EditPdfBatchJobCreateResult.md)
 - [Model.EditPdfJobStatusResult](docs/EditPdfJobStatusResult.md)
 - [Model.EmlAttachment](docs/EmlAttachment.md)
 - [Model.EmlToHtmlResult](docs/EmlToHtmlResult.md)
 - [Model.EmlToJpgResult](docs/EmlToJpgResult.md)
 - [Model.EmlToPngResult](docs/EmlToPngResult.md)
 - [Model.EnableSharedWorkbookRequest](docs/EnableSharedWorkbookRequest.md)
 - [Model.EnableSharedWorkbookResponse](docs/EnableSharedWorkbookResponse.md)
 - [Model.ExifValue](docs/ExifValue.md)
 - [Model.FillHandlebarFormField](docs/FillHandlebarFormField.md)
 - [Model.FindDocxParagraphRequest](docs/FindDocxParagraphRequest.md)
 - [Model.FindDocxParagraphResponse](docs/FindDocxParagraphResponse.md)
 - [Model.FindRegexMatch](docs/FindRegexMatch.md)
 - [Model.FindStringMatch](docs/FindStringMatch.md)
 - [Model.FindStringRegexRequest](docs/FindStringRegexRequest.md)
 - [Model.FindStringRegexResponse](docs/FindStringRegexResponse.md)
 - [Model.FindStringSimpleRequest](docs/FindStringSimpleRequest.md)
 - [Model.FindStringSimpleResponse](docs/FindStringSimpleResponse.md)
 - [Model.FinishEditingRequest](docs/FinishEditingRequest.md)
 - [Model.GetDocxBodyRequest](docs/GetDocxBodyRequest.md)
 - [Model.GetDocxBodyResponse](docs/GetDocxBodyResponse.md)
 - [Model.GetDocxCommentsHierarchicalResponse](docs/GetDocxCommentsHierarchicalResponse.md)
 - [Model.GetDocxCommentsResponse](docs/GetDocxCommentsResponse.md)
 - [Model.GetDocxContentControlsResponse](docs/GetDocxContentControlsResponse.md)
 - [Model.GetDocxGetCommentsHierarchicalRequest](docs/GetDocxGetCommentsHierarchicalRequest.md)
 - [Model.GetDocxGetCommentsRequest](docs/GetDocxGetCommentsRequest.md)
 - [Model.GetDocxGetFormFieldsResponse](docs/GetDocxGetFormFieldsResponse.md)
 - [Model.GetDocxHeadersAndFootersRequest](docs/GetDocxHeadersAndFootersRequest.md)
 - [Model.GetDocxHeadersAndFootersResponse](docs/GetDocxHeadersAndFootersResponse.md)
 - [Model.GetDocxImagesRequest](docs/GetDocxImagesRequest.md)
 - [Model.GetDocxImagesResponse](docs/GetDocxImagesResponse.md)
 - [Model.GetDocxMetadataPropertiesResponse](docs/GetDocxMetadataPropertiesResponse.md)
 - [Model.GetDocxPagesRequest](docs/GetDocxPagesRequest.md)
 - [Model.GetDocxPagesResponse](docs/GetDocxPagesResponse.md)
 - [Model.GetDocxSectionsRequest](docs/GetDocxSectionsRequest.md)
 - [Model.GetDocxSectionsResponse](docs/GetDocxSectionsResponse.md)
 - [Model.GetDocxStylesRequest](docs/GetDocxStylesRequest.md)
 - [Model.GetDocxStylesResponse](docs/GetDocxStylesResponse.md)
 - [Model.GetDocxTableByIndexRequest](docs/GetDocxTableByIndexRequest.md)
 - [Model.GetDocxTableByIndexResponse](docs/GetDocxTableByIndexResponse.md)
 - [Model.GetDocxTableRowRequest](docs/GetDocxTableRowRequest.md)
 - [Model.GetDocxTableRowResponse](docs/GetDocxTableRowResponse.md)
 - [Model.GetDocxTablesRequest](docs/GetDocxTablesRequest.md)
 - [Model.GetDocxTablesResponse](docs/GetDocxTablesResponse.md)
 - [Model.GetFileTypeIconResult](docs/GetFileTypeIconResult.md)
 - [Model.GetImageInfoResult](docs/GetImageInfoResult.md)
 - [Model.GetMacrosResponse](docs/GetMacrosResponse.md)
 - [Model.GetPdfAnnotationsResult](docs/GetPdfAnnotationsResult.md)
 - [Model.GetXlsxCellByIdentifierRequest](docs/GetXlsxCellByIdentifierRequest.md)
 - [Model.GetXlsxCellByIdentifierResponse](docs/GetXlsxCellByIdentifierResponse.md)
 - [Model.GetXlsxCellRequest](docs/GetXlsxCellRequest.md)
 - [Model.GetXlsxCellResponse](docs/GetXlsxCellResponse.md)
 - [Model.GetXlsxColumnsRequest](docs/GetXlsxColumnsRequest.md)
 - [Model.GetXlsxColumnsResponse](docs/GetXlsxColumnsResponse.md)
 - [Model.GetXlsxImagesRequest](docs/GetXlsxImagesRequest.md)
 - [Model.GetXlsxImagesResponse](docs/GetXlsxImagesResponse.md)
 - [Model.GetXlsxRowsAndCellsRequest](docs/GetXlsxRowsAndCellsRequest.md)
 - [Model.GetXlsxRowsAndCellsResponse](docs/GetXlsxRowsAndCellsResponse.md)
 - [Model.GetXlsxSpecificRowRequest](docs/GetXlsxSpecificRowRequest.md)
 - [Model.GetXlsxSpecificRowResponse](docs/GetXlsxSpecificRowResponse.md)
 - [Model.GetXlsxStylesRequest](docs/GetXlsxStylesRequest.md)
 - [Model.GetXlsxStylesResponse](docs/GetXlsxStylesResponse.md)
 - [Model.GetXlsxWorksheetsRequest](docs/GetXlsxWorksheetsRequest.md)
 - [Model.GetXlsxWorksheetsResponse](docs/GetXlsxWorksheetsResponse.md)
 - [Model.HandlebarFormField](docs/HandlebarFormField.md)
 - [Model.HtmlGetLanguageResult](docs/HtmlGetLanguageResult.md)
 - [Model.HtmlGetLinksResponse](docs/HtmlGetLinksResponse.md)
 - [Model.HtmlGetRelCanonicalUrlResult](docs/HtmlGetRelCanonicalUrlResult.md)
 - [Model.HtmlGetSitemapUrlResult](docs/HtmlGetSitemapUrlResult.md)
 - [Model.HtmlHyperlink](docs/HtmlHyperlink.md)
 - [Model.HtmlMdResult](docs/HtmlMdResult.md)
 - [Model.HtmlSsrfThreatCheckResult](docs/HtmlSsrfThreatCheckResult.md)
 - [Model.HtmlTemplateApplicationRequest](docs/HtmlTemplateApplicationRequest.md)
 - [Model.HtmlTemplateApplicationResponse](docs/HtmlTemplateApplicationResponse.md)
 - [Model.HtmlTemplateOperation](docs/HtmlTemplateOperation.md)
 - [Model.HtmlThreatLink](docs/HtmlThreatLink.md)
 - [Model.HtmlToOfficeRequest](docs/HtmlToOfficeRequest.md)
 - [Model.HtmlToPdfRequest](docs/HtmlToPdfRequest.md)
 - [Model.HtmlToPngRequest](docs/HtmlToPngRequest.md)
 - [Model.HtmlToTextRequest](docs/HtmlToTextRequest.md)
 - [Model.HtmlToTextResponse](docs/HtmlToTextResponse.md)
 - [Model.InsertDocxCommentOnParagraphResponse](docs/InsertDocxCommentOnParagraphResponse.md)
 - [Model.InsertDocxInsertParagraphRequest](docs/InsertDocxInsertParagraphRequest.md)
 - [Model.InsertDocxInsertParagraphResponse](docs/InsertDocxInsertParagraphResponse.md)
 - [Model.InsertDocxTableRowRequest](docs/InsertDocxTableRowRequest.md)
 - [Model.InsertDocxTableRowResponse](docs/InsertDocxTableRowResponse.md)
 - [Model.InsertDocxTablesRequest](docs/InsertDocxTablesRequest.md)
 - [Model.InsertDocxTablesResponse](docs/InsertDocxTablesResponse.md)
 - [Model.InsertXlsxWorksheetRequest](docs/InsertXlsxWorksheetRequest.md)
 - [Model.InsertXlsxWorksheetResponse](docs/InsertXlsxWorksheetResponse.md)
 - [Model.JobStatusResult](docs/JobStatusResult.md)
 - [Model.KeynoteToJpgResult](docs/KeynoteToJpgResult.md)
 - [Model.KeynoteToPngResult](docs/KeynoteToPngResult.md)
 - [Model.MergeBatchJobCreateResult](docs/MergeBatchJobCreateResult.md)
 - [Model.MergeJobStatusResult](docs/MergeJobStatusResult.md)
 - [Model.MsgAttachment](docs/MsgAttachment.md)
 - [Model.MsgToHtmlResult](docs/MsgToHtmlResult.md)
 - [Model.MsgToJpgResult](docs/MsgToJpgResult.md)
 - [Model.MsgToPngResult](docs/MsgToPngResult.md)
 - [Model.MultiReplaceStringRequest](docs/MultiReplaceStringRequest.md)
 - [Model.MultipageImageFormatConversionResult](docs/MultipageImageFormatConversionResult.md)
 - [Model.OdpToJpgResult](docs/OdpToJpgResult.md)
 - [Model.OdpToPngResult](docs/OdpToPngResult.md)
 - [Model.OdsToJpgResult](docs/OdsToJpgResult.md)
 - [Model.OdsToPngResult](docs/OdsToPngResult.md)
 - [Model.OdtToJpgResult](docs/OdtToJpgResult.md)
 - [Model.OdtToPngResult](docs/OdtToPngResult.md)
 - [Model.PageConversionResult](docs/PageConversionResult.md)
 - [Model.PdfAnnotation](docs/PdfAnnotation.md)
 - [Model.PdfDocument](docs/PdfDocument.md)
 - [Model.PdfFormField](docs/PdfFormField.md)
 - [Model.PdfFormFields](docs/PdfFormFields.md)
 - [Model.PdfMetadata](docs/PdfMetadata.md)
 - [Model.PdfPageText](docs/PdfPageText.md)
 - [Model.PdfTextByPageResult](docs/PdfTextByPageResult.md)
 - [Model.PdfToJpgResult](docs/PdfToJpgResult.md)
 - [Model.PdfToPngDirectResult](docs/PdfToPngDirectResult.md)
 - [Model.PdfToPngResult](docs/PdfToPngResult.md)
 - [Model.PptxPageLayoutInformation](docs/PptxPageLayoutInformation.md)
 - [Model.PptxSplitAdvancedRequest](docs/PptxSplitAdvancedRequest.md)
 - [Model.PptxSplitAdvancedResponse](docs/PptxSplitAdvancedResponse.md)
 - [Model.PptxToPngResult](docs/PptxToPngResult.md)
 - [Model.PresentationAdvancedResult](docs/PresentationAdvancedResult.md)
 - [Model.PresentationResult](docs/PresentationResult.md)
 - [Model.RemoveDocxHeadersAndFootersRequest](docs/RemoveDocxHeadersAndFootersRequest.md)
 - [Model.RemoveDocxHeadersAndFootersResponse](docs/RemoveDocxHeadersAndFootersResponse.md)
 - [Model.RemoveDocxPagesRequest](docs/RemoveDocxPagesRequest.md)
 - [Model.RemoveHtmlFromTextRequest](docs/RemoveHtmlFromTextRequest.md)
 - [Model.RemoveHtmlFromTextResponse](docs/RemoveHtmlFromTextResponse.md)
 - [Model.RemovePptxSlidesRequest](docs/RemovePptxSlidesRequest.md)
 - [Model.RemoveWhitespaceFromTextRequest](docs/RemoveWhitespaceFromTextRequest.md)
 - [Model.RemoveWhitespaceFromTextResponse](docs/RemoveWhitespaceFromTextResponse.md)
 - [Model.RemoveXlsxWorksheetRequest](docs/RemoveXlsxWorksheetRequest.md)
 - [Model.RenameXlsxWorksheetRequest](docs/RenameXlsxWorksheetRequest.md)
 - [Model.RenameXlsxWorksheetResponse](docs/RenameXlsxWorksheetResponse.md)
 - [Model.ReplaceDocxParagraphRequest](docs/ReplaceDocxParagraphRequest.md)
 - [Model.ReplaceDocxParagraphResponse](docs/ReplaceDocxParagraphResponse.md)
 - [Model.ReplaceStringRegexRequest](docs/ReplaceStringRegexRequest.md)
 - [Model.ReplaceStringRegexResponse](docs/ReplaceStringRegexResponse.md)
 - [Model.ReplaceStringRequest](docs/ReplaceStringRequest.md)
 - [Model.ReplaceStringSimpleRequest](docs/ReplaceStringSimpleRequest.md)
 - [Model.ReplaceStringSimpleResponse](docs/ReplaceStringSimpleResponse.md)
 - [Model.RtfToJpgResult](docs/RtfToJpgResult.md)
 - [Model.RtfToPngResult](docs/RtfToPngResult.md)
 - [Model.ScreenshotRequest](docs/ScreenshotRequest.md)
 - [Model.SetFormFieldValue](docs/SetFormFieldValue.md)
 - [Model.SetPdfFormFieldsRequest](docs/SetPdfFormFieldsRequest.md)
 - [Model.SetPdfMetadataRequest](docs/SetPdfMetadataRequest.md)
 - [Model.SetXlsxCellByIdentifierRequest](docs/SetXlsxCellByIdentifierRequest.md)
 - [Model.SetXlsxCellByIdentifierResponse](docs/SetXlsxCellByIdentifierResponse.md)
 - [Model.SetXlsxCellRequest](docs/SetXlsxCellRequest.md)
 - [Model.SetXlsxCellResponse](docs/SetXlsxCellResponse.md)
 - [Model.SingleReplaceString](docs/SingleReplaceString.md)
 - [Model.SplitBatchJobCreateResult](docs/SplitBatchJobCreateResult.md)
 - [Model.SplitDocumentResult](docs/SplitDocumentResult.md)
 - [Model.SplitDocxDocumentResult](docs/SplitDocxDocumentResult.md)
 - [Model.SplitPdfResult](docs/SplitPdfResult.md)
 - [Model.SplitPptxPresentationResult](docs/SplitPptxPresentationResult.md)
 - [Model.SplitTextDocumentByLinesResult](docs/SplitTextDocumentByLinesResult.md)
 - [Model.SplitTextDocumentByStringResult](docs/SplitTextDocumentByStringResult.md)
 - [Model.SplitXlsxWorksheetResult](docs/SplitXlsxWorksheetResult.md)
 - [Model.TextConversionResult](docs/TextConversionResult.md)
 - [Model.TextDocumentElement](docs/TextDocumentElement.md)
 - [Model.TextDocumentLine](docs/TextDocumentLine.md)
 - [Model.TextEncodingDetectResponse](docs/TextEncodingDetectResponse.md)
 - [Model.Thumbnail](docs/Thumbnail.md)
 - [Model.UpdateDocxTableCellRequest](docs/UpdateDocxTableCellRequest.md)
 - [Model.UpdateDocxTableCellResponse](docs/UpdateDocxTableCellResponse.md)
 - [Model.UpdateDocxTableRowRequest](docs/UpdateDocxTableRowRequest.md)
 - [Model.UpdateDocxTableRowResponse](docs/UpdateDocxTableRowResponse.md)
 - [Model.UrlToPdfRequest](docs/UrlToPdfRequest.md)
 - [Model.UrlToTextRequest](docs/UrlToTextRequest.md)
 - [Model.UrlToTextResponse](docs/UrlToTextResponse.md)
 - [Model.ViewerResponse](docs/ViewerResponse.md)
 - [Model.WorksheetResult](docs/WorksheetResult.md)
 - [Model.XlsxImage](docs/XlsxImage.md)
 - [Model.XlsxSpreadsheetCell](docs/XlsxSpreadsheetCell.md)
 - [Model.XlsxSpreadsheetColumn](docs/XlsxSpreadsheetColumn.md)
 - [Model.XlsxSpreadsheetRow](docs/XlsxSpreadsheetRow.md)
 - [Model.XlsxToPngResult](docs/XlsxToPngResult.md)
 - [Model.XlsxWorksheet](docs/XlsxWorksheet.md)
 - [Model.XmlAddAttributeWithXPathResult](docs/XmlAddAttributeWithXPathResult.md)
 - [Model.XmlAddChildWithXPathResult](docs/XmlAddChildWithXPathResult.md)
 - [Model.XmlFilterWithXPathResult](docs/XmlFilterWithXPathResult.md)
 - [Model.XmlQueryWithXQueryMultiResult](docs/XmlQueryWithXQueryMultiResult.md)
 - [Model.XmlQueryWithXQueryResult](docs/XmlQueryWithXQueryResult.md)
 - [Model.XmlRemoveAllChildrenWithXPathResult](docs/XmlRemoveAllChildrenWithXPathResult.md)
 - [Model.XmlRemoveWithXPathResult](docs/XmlRemoveWithXPathResult.md)
 - [Model.XmlReplaceWithXPathResult](docs/XmlReplaceWithXPathResult.md)
 - [Model.XmlSetValueWithXPathResult](docs/XmlSetValueWithXPathResult.md)
 - [Model.XxeThreatDetectionResult](docs/XxeThreatDetectionResult.md)
 - [Model.ZipDirectory](docs/ZipDirectory.md)
 - [Model.ZipEncryptionAdvancedRequest](docs/ZipEncryptionAdvancedRequest.md)
 - [Model.ZipExtractResponse](docs/ZipExtractResponse.md)
 - [Model.ZipFile](docs/ZipFile.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

