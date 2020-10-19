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
    ///  Class for testing ValidateDocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ValidateDocumentApiTests
    {
        private ValidateDocumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ValidateDocumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ValidateDocumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ValidateDocumentApi
            //Assert.IsInstanceOfType(typeof(ValidateDocumentApi), instance, "instance is a ValidateDocumentApi");
        }

        
        /// <summary>
        /// Test ValidateDocumentAutodetectValidation
        /// </summary>
        [Test]
        public void ValidateDocumentAutodetectValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentAutodetectValidation(inputFile);
            //Assert.IsInstanceOf<AutodetectDocumentValidationResult> (response, "response is AutodetectDocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentCsvValidation
        /// </summary>
        [Test]
        public void ValidateDocumentCsvValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentCsvValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentDocxValidation
        /// </summary>
        [Test]
        public void ValidateDocumentDocxValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentDocxValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentEmlValidation
        /// </summary>
        [Test]
        public void ValidateDocumentEmlValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentEmlValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentExecutableValidation
        /// </summary>
        [Test]
        public void ValidateDocumentExecutableValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentExecutableValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentGZipValidation
        /// </summary>
        [Test]
        public void ValidateDocumentGZipValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentGZipValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentHtmlValidation
        /// </summary>
        [Test]
        public void ValidateDocumentHtmlValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentHtmlValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentImageValidation
        /// </summary>
        [Test]
        public void ValidateDocumentImageValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentImageValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentJsonValidation
        /// </summary>
        [Test]
        public void ValidateDocumentJsonValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentJsonValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentMsgValidation
        /// </summary>
        [Test]
        public void ValidateDocumentMsgValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentMsgValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentPdfValidation
        /// </summary>
        [Test]
        public void ValidateDocumentPdfValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentPdfValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentPptxValidation
        /// </summary>
        [Test]
        public void ValidateDocumentPptxValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentPptxValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentRarValidation
        /// </summary>
        [Test]
        public void ValidateDocumentRarValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentRarValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentTarValidation
        /// </summary>
        [Test]
        public void ValidateDocumentTarValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentTarValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentXlsxValidation
        /// </summary>
        [Test]
        public void ValidateDocumentXlsxValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentXlsxValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentXmlValidation
        /// </summary>
        [Test]
        public void ValidateDocumentXmlValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentXmlValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
        /// <summary>
        /// Test ValidateDocumentZipValidation
        /// </summary>
        [Test]
        public void ValidateDocumentZipValidationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ValidateDocumentZipValidation(inputFile);
            //Assert.IsInstanceOf<DocumentValidationResult> (response, "response is DocumentValidationResult");
        }
        
    }

}
