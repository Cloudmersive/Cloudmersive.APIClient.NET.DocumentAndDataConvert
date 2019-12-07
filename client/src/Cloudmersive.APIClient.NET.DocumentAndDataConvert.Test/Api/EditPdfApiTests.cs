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
    ///  Class for testing EditPdfApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EditPdfApiTests
    {
        private EditPdfApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EditPdfApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EditPdfApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EditPdfApi
            //Assert.IsInstanceOfType(typeof(EditPdfApi), instance, "instance is a EditPdfApi");
        }

        
        /// <summary>
        /// Test EditPdfDecrypt
        /// </summary>
        [Test]
        public void EditPdfDecryptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string password = null;
            //System.IO.Stream inputFile = null;
            //var response = instance.EditPdfDecrypt(password, inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditPdfDeletePages
        /// </summary>
        [Test]
        public void EditPdfDeletePagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //int? pageStart = null;
            //int? pageEnd = null;
            //var response = instance.EditPdfDeletePages(inputFile, pageStart, pageEnd);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditPdfEncrypt
        /// </summary>
        [Test]
        public void EditPdfEncryptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //string userPassword = null;
            //string ownerPassword = null;
            //string encryptionKeyLength = null;
            //var response = instance.EditPdfEncrypt(inputFile, userPassword, ownerPassword, encryptionKeyLength);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditPdfGetFormFields
        /// </summary>
        [Test]
        public void EditPdfGetFormFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.EditPdfGetFormFields(inputFile);
            //Assert.IsInstanceOf<PdfFormFields> (response, "response is PdfFormFields");
        }
        
        /// <summary>
        /// Test EditPdfGetMetadata
        /// </summary>
        [Test]
        public void EditPdfGetMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.EditPdfGetMetadata(inputFile);
            //Assert.IsInstanceOf<PdfMetadata> (response, "response is PdfMetadata");
        }
        
        /// <summary>
        /// Test EditPdfGetPdfTextByPages
        /// </summary>
        [Test]
        public void EditPdfGetPdfTextByPagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.EditPdfGetPdfTextByPages(inputFile);
            //Assert.IsInstanceOf<PdfTextByPageResult> (response, "response is PdfTextByPageResult");
        }
        
        /// <summary>
        /// Test EditPdfInsertPages
        /// </summary>
        [Test]
        public void EditPdfInsertPagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream sourceFile = null;
            //System.IO.Stream destinationFile = null;
            //int? pageStartSource = null;
            //int? pageEndSource = null;
            //int? pageInsertBeforeDesitnation = null;
            //var response = instance.EditPdfInsertPages(sourceFile, destinationFile, pageStartSource, pageEndSource, pageInsertBeforeDesitnation);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditPdfRasterize
        /// </summary>
        [Test]
        public void EditPdfRasterizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.EditPdfRasterize(inputFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditPdfSetFormFields
        /// </summary>
        [Test]
        public void EditPdfSetFormFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetPdfFormFieldsRequest fieldValues = null;
            //var response = instance.EditPdfSetFormFields(fieldValues);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditPdfSetMetadata
        /// </summary>
        [Test]
        public void EditPdfSetMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetPdfMetadataRequest request = null;
            //var response = instance.EditPdfSetMetadata(request);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditPdfSetPermissions
        /// </summary>
        [Test]
        public void EditPdfSetPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ownerPassword = null;
            //string userPassword = null;
            //System.IO.Stream inputFile = null;
            //string encryptionKeyLength = null;
            //bool? allowPrinting = null;
            //bool? allowDocumentAssembly = null;
            //bool? allowContentExtraction = null;
            //bool? allowFormFilling = null;
            //bool? allowEditing = null;
            //bool? allowAnnotations = null;
            //bool? allowDegradedPrinting = null;
            //var response = instance.EditPdfSetPermissions(ownerPassword, userPassword, inputFile, encryptionKeyLength, allowPrinting, allowDocumentAssembly, allowContentExtraction, allowFormFilling, allowEditing, allowAnnotations, allowDegradedPrinting);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditPdfWatermarkText
        /// </summary>
        [Test]
        public void EditPdfWatermarkTextTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string watermarkText = null;
            //System.IO.Stream inputFile = null;
            //string fontName = null;
            //decimal? fontSize = null;
            //string fontColor = null;
            //decimal? fontTransparency = null;
            //var response = instance.EditPdfWatermarkText(watermarkText, inputFile, fontName, fontSize, fontColor, fontTransparency);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
