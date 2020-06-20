/* 
 * convertapi
 *
 * Convert API lets you effortlessly convert file formats and types.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NET.DocumentAndDataConvert.Model;

namespace Cloudmersive.APIClient.NET.DocumentAndDataConvert.Test
{
    /// <summary>
    ///  Class for testing ConvertDocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConvertDocumentApiTests
    {
        private ConvertDocumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConvertDocumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConvertDocumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConvertDocumentApi
            //Assert.IsInstanceOfType(typeof(ConvertDocumentApi), instance, "instance is a ConvertDocumentApi");
        }

        
        /// <summary>
        /// Test ConvertDocumentAutodetectGetInfo
        /// </summary>
        [Test]
        public void ConvertDocumentAutodetectGetInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentAutodetectGetInfo(inputFile);
            //Assert.IsInstanceOf<AutodetectGetInfoResult> (response, "response is AutodetectGetInfoResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentAutodetectToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentAutodetectToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentAutodetectToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentAutodetectToPngArray
        /// </summary>
        [Test]
        public void ConvertDocumentAutodetectToPngArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentAutodetectToPngArray(inputFile);
            //Assert.IsInstanceOf<AutodetectToPngResult> (response, "response is AutodetectToPngResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentAutodetectToThumbnail
        /// </summary>
        [Test]
        public void ConvertDocumentAutodetectToThumbnailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //int? maxWidth = null;
            //int? maxHeight = null;
            //string extension = null;
            //var response = instance.ConvertDocumentAutodetectToThumbnail(inputFile, maxWidth, maxHeight, extension);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentAutodetectToThumbnailsAdvanced
        /// </summary>
        [Test]
        public void ConvertDocumentAutodetectToThumbnailsAdvancedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //int? pages = null;
            //int? maxWidth = null;
            //int? maxHeight = null;
            //string extension = null;
            //var response = instance.ConvertDocumentAutodetectToThumbnailsAdvanced(inputFile, pages, maxWidth, maxHeight, extension);
            //Assert.IsInstanceOf<AutodetectToThumbnailsResult> (response, "response is AutodetectToThumbnailsResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentAutodetectToTxt
        /// </summary>
        [Test]
        public void ConvertDocumentAutodetectToTxtTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string textFormattingMode = null;
            //var response = instance.ConvertDocumentAutodetectToTxt(inputFile, textFormattingMode);
            //Assert.IsInstanceOf<TextConversionResult> (response, "response is TextConversionResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentCsvToXlsx
        /// </summary>
        [Test]
        public void ConvertDocumentCsvToXlsxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentCsvToXlsx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocToDocx
        /// </summary>
        [Test]
        public void ConvertDocumentDocToDocxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentDocToDocx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentDocToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentDocToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocToTxt
        /// </summary>
        [Test]
        public void ConvertDocumentDocToTxtTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentDocToTxt(inputFile);
            //Assert.IsInstanceOf<TextConversionResult> (response, "response is TextConversionResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocxToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentDocxToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentDocxToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocxToPng
        /// </summary>
        [Test]
        public void ConvertDocumentDocxToPngTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentDocxToPng(inputFile);
            //Assert.IsInstanceOf<DocxToPngResult> (response, "response is DocxToPngResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentDocxToTxt
        /// </summary>
        [Test]
        public void ConvertDocumentDocxToTxtTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string textFormattingMode = null;
            //var response = instance.ConvertDocumentDocxToTxt(inputFile, textFormattingMode);
            //Assert.IsInstanceOf<TextConversionResult> (response, "response is TextConversionResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentEmlToHtml
        /// </summary>
        [Test]
        public void ConvertDocumentEmlToHtmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //bool? bodyOnly = null;
            //bool? includeAttachments = null;
            //var response = instance.ConvertDocumentEmlToHtml(inputFile, bodyOnly, includeAttachments);
            //Assert.IsInstanceOf<EmlToHtmlResult> (response, "response is EmlToHtmlResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentEmlToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentEmlToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //bool? bodyOnly = null;
            //var response = instance.ConvertDocumentEmlToPdf(inputFile, bodyOnly);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentGetFileTypeIcon
        /// </summary>
        [Test]
        public void ConvertDocumentGetFileTypeIconTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileExtension = null;
            //int? iconSize = null;
            //var response = instance.ConvertDocumentGetFileTypeIcon(fileExtension, iconSize);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentGetFileTypeIconAdvanced
        /// </summary>
        [Test]
        public void ConvertDocumentGetFileTypeIconAdvancedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileExtension = null;
            //int? iconSize = null;
            //var response = instance.ConvertDocumentGetFileTypeIconAdvanced(fileExtension, iconSize);
            //Assert.IsInstanceOf<GetFileTypeIconResult> (response, "response is GetFileTypeIconResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentHtmlToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentHtmlToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentHtmlToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentHtmlToPng
        /// </summary>
        [Test]
        public void ConvertDocumentHtmlToPngTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentHtmlToPng(inputFile);
            //Assert.IsInstanceOf<PdfToPngResult> (response, "response is PdfToPngResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentHtmlToTxt
        /// </summary>
        [Test]
        public void ConvertDocumentHtmlToTxtTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentHtmlToTxt(inputFile);
            //Assert.IsInstanceOf<TextConversionResult> (response, "response is TextConversionResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentKeynoteToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentKeynoteToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentKeynoteToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentMsgToHtml
        /// </summary>
        [Test]
        public void ConvertDocumentMsgToHtmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //bool? bodyOnly = null;
            //bool? includeAttachments = null;
            //var response = instance.ConvertDocumentMsgToHtml(inputFile, bodyOnly, includeAttachments);
            //Assert.IsInstanceOf<MsgToHtmlResult> (response, "response is MsgToHtmlResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentMsgToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentMsgToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //bool? bodyOnly = null;
            //var response = instance.ConvertDocumentMsgToPdf(inputFile, bodyOnly);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentOdpToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentOdpToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentOdpToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentOdsToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentOdsToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentOdsToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentOdtToDocx
        /// </summary>
        [Test]
        public void ConvertDocumentOdtToDocxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentOdtToDocx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentOdtToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentOdtToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentOdtToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPdfToDocx
        /// </summary>
        [Test]
        public void ConvertDocumentPdfToDocxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPdfToDocx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPdfToDocxRasterize
        /// </summary>
        [Test]
        public void ConvertDocumentPdfToDocxRasterizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPdfToDocxRasterize(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPdfToPngArray
        /// </summary>
        [Test]
        public void ConvertDocumentPdfToPngArrayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPdfToPngArray(inputFile);
            //Assert.IsInstanceOf<PdfToPngResult> (response, "response is PdfToPngResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentPdfToPngSingle
        /// </summary>
        [Test]
        public void ConvertDocumentPdfToPngSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPdfToPngSingle(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPdfToPptx
        /// </summary>
        [Test]
        public void ConvertDocumentPdfToPptxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPdfToPptx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPdfToTxt
        /// </summary>
        [Test]
        public void ConvertDocumentPdfToTxtTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string textFormattingMode = null;
            //var response = instance.ConvertDocumentPdfToTxt(inputFile, textFormattingMode);
            //Assert.IsInstanceOf<TextConversionResult> (response, "response is TextConversionResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentPngArrayToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentPngArrayToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile1 = null;
            //System.IO.Stream inputFile2 = null;
            //System.IO.Stream inputFile3 = null;
            //System.IO.Stream inputFile4 = null;
            //System.IO.Stream inputFile5 = null;
            //System.IO.Stream inputFile6 = null;
            //System.IO.Stream inputFile7 = null;
            //System.IO.Stream inputFile8 = null;
            //System.IO.Stream inputFile9 = null;
            //System.IO.Stream inputFile10 = null;
            //var response = instance.ConvertDocumentPngArrayToPdf(inputFile1, inputFile2, inputFile3, inputFile4, inputFile5, inputFile6, inputFile7, inputFile8, inputFile9, inputFile10);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPptToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentPptToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPptToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPptToPptx
        /// </summary>
        [Test]
        public void ConvertDocumentPptToPptxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPptToPptx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPptxToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentPptxToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPptxToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentPptxToPng
        /// </summary>
        [Test]
        public void ConvertDocumentPptxToPngTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPptxToPng(inputFile);
            //Assert.IsInstanceOf<PptxToPngResult> (response, "response is PptxToPngResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentPptxToTxt
        /// </summary>
        [Test]
        public void ConvertDocumentPptxToTxtTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentPptxToTxt(inputFile);
            //Assert.IsInstanceOf<TextConversionResult> (response, "response is TextConversionResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentRtfToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentRtfToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentRtfToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsToCsv
        /// </summary>
        [Test]
        public void ConvertDocumentXlsToCsvTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsToCsv(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentXlsToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsToXlsx
        /// </summary>
        [Test]
        public void ConvertDocumentXlsToXlsxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsToXlsx(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsxToCsv
        /// </summary>
        [Test]
        public void ConvertDocumentXlsxToCsvTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string outputEncoding = null;
            //var response = instance.ConvertDocumentXlsxToCsv(inputFile, outputEncoding);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsxToCsvMulti
        /// </summary>
        [Test]
        public void ConvertDocumentXlsxToCsvMultiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string outputEncoding = null;
            //var response = instance.ConvertDocumentXlsxToCsvMulti(inputFile, outputEncoding);
            //Assert.IsInstanceOf<CsvCollection> (response, "response is CsvCollection");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsxToPdf
        /// </summary>
        [Test]
        public void ConvertDocumentXlsxToPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsxToPdf(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsxToPng
        /// </summary>
        [Test]
        public void ConvertDocumentXlsxToPngTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsxToPng(inputFile);
            //Assert.IsInstanceOf<XlsxToPngResult> (response, "response is XlsxToPngResult");
        }
        
        /// <summary>
        /// Test ConvertDocumentXlsxToTxt
        /// </summary>
        [Test]
        public void ConvertDocumentXlsxToTxtTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ConvertDocumentXlsxToTxt(inputFile);
            //Assert.IsInstanceOf<TextConversionResult> (response, "response is TextConversionResult");
        }
        
    }

}
