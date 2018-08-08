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

namespace Cloudmersive.APIClient.NET.DocumentAndDataConvert.Test
{
    /// <summary>
    ///  Class for testing MergeDocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MergeDocumentApiTests
    {
        private MergeDocumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MergeDocumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MergeDocumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MergeDocumentApi
            //Assert.IsInstanceOfType(typeof(MergeDocumentApi), instance, "instance is a MergeDocumentApi");
        }

        
        /// <summary>
        /// Test MergeDocumentDocx
        /// </summary>
        [Test]
        public void MergeDocumentDocxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile1 = null;
            //System.IO.Stream inputFile2 = null;
            //var response = instance.MergeDocumentDocx(inputFile1, inputFile2);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
