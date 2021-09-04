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
    ///  Class for testing TransformDocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransformDocumentApiTests
    {
        private TransformDocumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransformDocumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransformDocumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransformDocumentApi
            //Assert.IsInstanceOfType(typeof(TransformDocumentApi), instance, "instance is a TransformDocumentApi");
        }

        
        /// <summary>
        /// Test TransformDocumentDocxReplace
        /// </summary>
        [Test]
        public void TransformDocumentDocxReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string matchString = null;
            //string replaceString = null;
            //System.IO.Stream inputFile = null;
            //string inputFileUrl = null;
            //bool? matchCase = null;
            //var response = instance.TransformDocumentDocxReplace(matchString, replaceString, inputFile, inputFileUrl, matchCase);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test TransformDocumentDocxReplaceEditSession
        /// </summary>
        [Test]
        public void TransformDocumentDocxReplaceEditSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string matchString = null;
            //string replaceString = null;
            //System.IO.Stream inputFile = null;
            //string inputFileUrl = null;
            //bool? matchCase = null;
            //var response = instance.TransformDocumentDocxReplaceEditSession(matchString, replaceString, inputFile, inputFileUrl, matchCase);
            //Assert.IsInstanceOf<DocumentTransformEditSession> (response, "response is DocumentTransformEditSession");
        }
        
        /// <summary>
        /// Test TransformDocumentDocxTableFillIn
        /// </summary>
        [Test]
        public void TransformDocumentDocxTableFillInTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocxTableTableFillRequest request = null;
            //var response = instance.TransformDocumentDocxTableFillIn(request);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test TransformDocumentDocxTableFillInEditSession
        /// </summary>
        [Test]
        public void TransformDocumentDocxTableFillInEditSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocxTableTableFillRequest request = null;
            //var response = instance.TransformDocumentDocxTableFillInEditSession(request);
            //Assert.IsInstanceOf<DocumentTransformEditSession> (response, "response is DocumentTransformEditSession");
        }
        
        /// <summary>
        /// Test TransformDocumentDocxTableFillInMulti
        /// </summary>
        [Test]
        public void TransformDocumentDocxTableFillInMultiTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocxTableTableFillMultiRequest request = null;
            //var response = instance.TransformDocumentDocxTableFillInMulti(request);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TransformDocumentPptxReplace
        /// </summary>
        [Test]
        public void TransformDocumentPptxReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string matchString = null;
            //string replaceString = null;
            //System.IO.Stream inputFile = null;
            //string inputFileUrl = null;
            //bool? matchCase = null;
            //var response = instance.TransformDocumentPptxReplace(matchString, replaceString, inputFile, inputFileUrl, matchCase);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
